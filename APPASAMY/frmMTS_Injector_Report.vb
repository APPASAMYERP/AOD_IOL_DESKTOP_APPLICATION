
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration
Public Class frmMTS_Injector_Report

    Dim StrSql As String

    Dim table As New DataTable
    Dim cmd As SqlCommand
    Dim Sql As String
    'Dim sqla As SqlDataAdapter
    Dim Ds As New DataSet
    Dim Dr As SqlDataReader
    Dim DtRow As DataRow
    Dim StrLorBarNo As String
    Dim Str_Header As Integer
    Dim Str_Detail As Integer
    Dim StrUniqueNo As String
    Dim StrSqlSeHd As String

    Public Function SQL_SelectQuery_Execute(ByVal StrSql As String) As DataSet

        Dim ds As New DataSet
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Public Sub UpdateorInsertQuery_Execute(ByVal strQuery As String)

        Dim strsql As String
        strsql = strQuery
        Dim cmd As New SqlCommand(strsql, con)
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Public Sub Form_Load()
        Try
            StrSql = " SELECT     Distinct MTS_No " & _
                    " FROM        Injector_Movement  order by  MTS_No DESC "
            Ds = SQL_SelectQuery_Execute(StrSql)
            CmbMTSNo.Items.Clear()
            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                CmbMTSNo.Items.Add(eachRow1("MTS_No"))
            Next

        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try

        



    End Sub


    Private Sub frmMTS_Injector_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form_Load()

    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Try

            If CmbMTSNo.Text <> "" Then

                If CmbMTSNo.SelectedItem Is Nothing Then
                    MessageBox.Show("Please Select valid Label")
                    CmbMTSNo.Focus()
                    Exit Sub
                End If

                Dim cryRpt As New cryMTS_Report_Injector

                Dim txt_mts_no, txt_from_loc, txt_to_loc As CrystalDecisions.CrystalReports.Engine.TextObject
                txt_mts_no = cryRpt.ReportDefinition.Sections(0).ReportObjects("mts_no")
                txt_from_loc = cryRpt.ReportDefinition.Sections(0).ReportObjects("from_loc")
                txt_to_loc = cryRpt.ReportDefinition.Sections(0).ReportObjects("to_loc")


                StrSql = " SELECT DISTINCT Moved_Location, MTS_No  " & _
                        "  FROM         Injector_Movement   WHERE     (MTS_No = '" & CmbMTSNo.Text & "')  "
                Ds = SQL_SelectQuery_Execute(StrSql)
                If Ds.Tables(0).Rows.Count = 1 Then
                    txt_mts_no.Text = Ds.Tables(0).Rows(0)("MTS_No")
                    txt_from_loc.Text = " Injector "
                    txt_to_loc.Text = Ds.Tables(0).Rows(0)("Moved_Location")
                Else
                    MessageBox.Show("More then one location or MMS number Updated. Please check")
                    Exit Sub
                End If




                StrSql = " SELECT     Product_Name, Inj_Ref, Inj_Batch, SUM(Moved_Qty) AS Moved_qty  " & _
                        "  FROM         Injector_Movement  WHERE     (MTS_No = '" & CmbMTSNo.Text & "') " & _
                         "  GROUP BY Product_Name, Inj_Ref, Inj_Batch  " & _
                          "  ORDER BY Product_Name, Inj_Ref, Inj_Batch "
                Ds = SQL_SelectQuery_Execute(StrSql)

                cryRpt.SetDataSource(Ds.Tables(0))
                RptViwCollection.CryViewCollectList.ReportSource = cryRpt
                CryViewMTSReport.Refresh()
                RptViwCollection.Show()





            End If

        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
    End Sub
End Class