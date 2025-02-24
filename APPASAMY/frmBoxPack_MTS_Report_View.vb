Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration
Public Class frmBoxPack_MTS_Report_View
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
            StrSql = " SELECT     Distinct BoxPack_to_Despatch_Move_No " & _
                    " FROM         BPL_GEN  WHERE   BoxPack_to_Despatch_Move_Status=1 order by  BoxPack_to_Despatch_Move_No DESC "
            Ds = SQL_SelectQuery_Execute(StrSql)
            CmbMTSNo.Items.Clear()
            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                CmbMTSNo.Items.Add(eachRow1("BoxPack_to_Despatch_Move_No"))
            Next
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try

        




    End Sub

    Private Sub frmBoxPack_MTS_Report_View_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form_Load()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Try
            If CmbMTSNo.Text <> "" Then
                If CmbMTSNo.SelectedItem Is Nothing Then
                    MessageBox.Show("Please Select valid MTS NO")
                    CmbMTSNo.Focus()
                    Exit Sub
                End If


                Dim form_loc As String = ""
                Dim to_loc As String = ""
                StrSql = " SELECT     distinct  Location_from, Location_To " & _
                        " FROM       BoxPack_to_Despatch_Move_details WHERE    Movement_No = '" & CmbMTSNo.Text & "'   "
                Ds = SQL_SelectQuery_Execute(StrSql)
                form_loc = Ds.Tables(0).Rows(0)("Location_from")
                to_loc = Ds.Tables(0).Rows(0)("Location_To")

                StrSql = " SELECT     BPL_No,Brand_Name, Model_Name, Power,  SUM(Qty) AS Qty  " & _
                        " FROM         BoxPack_to_Despatch_Move_details   WHERE   Movement_No = '" & CmbMTSNo.Text & "'   " & _
                        "  GROUP BY BPL_No,Brand_Name, Model_Name, Power  ORDER BY BPL_No,Brand_Name, Model_Name, Power "
                Ds = SQL_SelectQuery_Execute(StrSql)


                Dim cryRpt As New CryMTSBoxPack_to_Despatch

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