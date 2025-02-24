Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration

Public Class frmSterileMTSReport_Reprint

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
            StrSql = " SELECT     Distinct Sterile_to_Areation_Move_NO " & _
                    " FROM         POUCH_LABEL  WHERE   Sterile_to_Areation_Move_status=1 order by  Sterile_to_Areation_Move_NO DESC "
            Ds = SQL_SelectQuery_Execute(StrSql)
            CmbMTSNo.Items.Clear()
            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                CmbMTSNo.Items.Add(eachRow1("Sterile_to_Areation_Move_NO"))
            Next
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        


        

    End Sub

    Private Sub frmSterileMTSReport_Reprint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form_Load()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Try

            If CmbMTSNo.Text <> "" Then

                If CmbMTSNo.SelectedItem Is Nothing Then
                    MessageBox.Show("Please Select valid MTS No")
                    CmbMTSNo.Focus()
                    Exit Sub
                End If

                Dim form_loc As String = ""
                Dim to_loc As String = ""
                StrSql = " SELECT     distinct  Location_from, Location_To " & _
                        " FROM       Sterile_to_Areation_Move_details WHERE    Movement_No = '" & CmbMTSNo.Text & "'   "
                Ds = SQL_SelectQuery_Execute(StrSql)
                form_loc = Ds.Tables(0).Rows(0)("Location_from")
                to_loc = Ds.Tables(0).Rows(0)("Location_To")

                StrSql = " SELECT      Btc_No, Model_Name, Lot_Number,  Qty " & _
                        " FROM         Sterile_to_Areation_Move_details WHERE   Movement_No = '" & CmbMTSNo.Text & "'  " & _
                        "  ORDER BY Btc_No,Model_Name, Lot_Number "
                Ds = SQL_SelectQuery_Execute(StrSql)


                Dim cryRpt As New CryMTSReport_Sterile

                Dim txt_mts_no, txt_from_loc, txt_to_loc As CrystalDecisions.CrystalReports.Engine.TextObject
                txt_mts_no = cryRpt.ReportDefinition.Sections(0).ReportObjects("mts_no")
                txt_from_loc = cryRpt.ReportDefinition.Sections(0).ReportObjects("from_loc")
                txt_to_loc = cryRpt.ReportDefinition.Sections(0).ReportObjects("to_loc")

                txt_mts_no.Text = CmbMTSNo.Text
                txt_from_loc.Text = form_loc
                txt_to_loc.Text = to_loc

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