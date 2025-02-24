
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.OleDb
Imports System.Web
Imports System.Web.UI.WebControls

Public Class frmSterileComple
    Dim StrRs, Sql, StrRs1, StrRsSeHd, StrRsSeDt As SqlDataReader
    Dim Cmd As New SqlCommand
    Dim StrSql, Str_Header, StrUniqueNo, StrSqlSeHd, Str_Detail, StrSqlSeDt As String
    Dim bplno As String = ""
    Dim Ds1 As New DataSet
    Private Sub frmSterileComple_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StrSql = "SELECT DISTINCT btc_no  from Pouch_Label WHERE     (Sterilization = 1) AND (Sample_Taken = 0)   AND (Sterilization_After = 1) AND (Sterilization_Reject = '0') order by btc_no "


        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        Btc_no.Items.Clear()
        While StrRs.Read

            Btc_no.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        Cmd.Dispose()
    End Sub
    Public Function SQL_SelectQuery_Execute(ByVal StrSql As String) As DataSet

        Dim ds As New DataSet
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds, "Srno")
        Return ds

    End Function

 

    Private Sub Btc_no_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btc_no.SelectedIndexChanged

        Dim getlots As String = ""

        StrSql = "select lot_srno from Sterility_Test_Details"

        Ds1 = SQL_SelectQuery_Execute(StrSql)

        For Each eachRow1 As DataRow In Ds1.Tables(0).Rows
            getlots = getlots + "'" + eachRow1("lot_srno") + "',"
        Next
        getlots = getlots.Remove(getlots.Length - 1, 1)

        StrSql = "SELECT DISTINCT Lot_Srno  from Pouch_Label WHERE btc_no= '" & Btc_no.Text & "' and Type_sample='sst' and Lot_Srno not in (" & getlots & ") order by Lot_srno"

        Ds1 = SQL_SelectQuery_Execute(StrSql)
        DataGridView1.DataSource = Ds1
        DataGridView1.DataMember = "Srno"
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter
        Dim dt As New DataTable()
        dt.Columns.Add("Srno")
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("bplchk").Value)
            If isSelected Then
                dt.Rows.Add(row.Cells(1).Value)
            End If
        Next
    End Sub

    Private Sub BtnComplete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnComplete.Click

        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("bplchk").Value)
            If isSelected Then
                StrSql = "Insert Into Sterility_Test_Details ( Btc_no, Lot_srno, Test_type, Created_Date, Created_By) values ('" & Btc_no.Text & "','" & row.Cells(1).Value & "','" & cmb_test.Text & "',GETDATE(),'" & StrLoginUser & "')"
                UpdateorInsertQuery_Execute(StrSql)
            End If

        Next
        cmb_test.Text = ""
        DataGridView1.DataSource = Nothing
        Btc_no.Items.Clear()

    End Sub
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
End Class