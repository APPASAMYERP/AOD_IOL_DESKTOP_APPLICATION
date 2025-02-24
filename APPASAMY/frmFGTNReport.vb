
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration
Public Class frmFGTNReport
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
            StrSql = " SELECT     Distinct FGTN_No " & _
                    " FROM        FGTN_details  order by  FGTN_No DESC "
            Ds = SQL_SelectQuery_Execute(StrSql)
            CmbFGTN_No.Items.Clear()
            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                CmbFGTN_No.Items.Add(eachRow1("FGTN_No"))
            Next
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try






    End Sub

    Private Sub frmFGTNReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form_Load()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click

        Try
            If CmbFGTN_No.Text <> "" Then
                If CmbFGTN_No.SelectedItem Is Nothing Then
                    MessageBox.Show("Please Select valid FGTN NO")
                    CmbFGTN_No.Focus()
                    Exit Sub
                End If


                
                 

                StrSql = " SELECT     BPL_No,Brand_Name, Model_Name, Power,  SUM(Qty) AS Qty  " & _
                        " FROM          FGTN_details   WHERE   FGTN_No = '" & CmbFGTN_No.Text & "'   " & _
                        "  GROUP BY BPL_No,Brand_Name, Model_Name, Power  ORDER BY BPL_No,Brand_Name, Model_Name, Power "
                Ds = SQL_SelectQuery_Execute(StrSql)


                Dim cryRpt As New CryFGTN

                Dim txt_mts_no As CrystalDecisions.CrystalReports.Engine.TextObject
                txt_mts_no = cryRpt.ReportDefinition.Sections(0).ReportObjects("mts_no")
                 

                txt_mts_no.Text = CmbFGTN_No.Text 

                cryRpt.SetDataSource(Ds.Tables(0))
                CryViewMTSReport.ReportSource = cryRpt
                CryViewMTSReport.Refresh()
                CryViewMTSReport.Show()
            End If
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try

    End Sub
End Class