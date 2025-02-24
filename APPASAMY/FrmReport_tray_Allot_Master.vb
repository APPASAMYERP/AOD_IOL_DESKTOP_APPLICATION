

Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration

Public Class FrmReport_tray_Allot_Master
    Dim Ds As New DataSet

    Public Function SQL_SelectQuery_Execute(ByVal StrSql As String) As DataSet

        Dim ds As New DataSet
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Public Function SQL_SelectQuery_Execute_with_ConString(ByVal StrSql As String, ByVal conStr As SqlConnection) As DataSet

        Dim ds As New DataSet
        Dim Cmd As New SqlCommand(StrSql, conStr)
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
    Public Function getAllData() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = "SELECT     Sequence_id, Rack_No, Rack_Location, Tray_No, Model_Name, Max_Qty, Filled_Qty FROM         Tray_Rack_Master ORDER BY Sequence_id "
        ds = SQL_SelectQuery_Execute(StrSql)
        Return ds

    End Function

    Public Function ModelBind() As DataSet
         

        Dim ds As New DataSet
        Dim StrSql As String = "SELECT DISTINCT Model_Name FROM         Tray_Rack_Master ORDER BY Model_Name "
        ds = SQL_SelectQuery_Execute(StrSql)
        Return ds

    End Function

    Private Sub Form_load()
        Ds = getAllData() 
        DataGridView1.DataSource = Ds.Tables(0)


        Ds = ModelBind()
        cmbModel.Items.Clear()
        For Each eachRow As DataRow In Ds.Tables(0).Rows
            cmbModel.Items.Add(eachRow("Model_Name"))
        Next
    End Sub

    Private Sub FrmReport_tray_Allot_Master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Form_load()

    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        Form_load()
    End Sub

    Public Function getData_model_based() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = "SELECT     Sequence_id, Rack_No, Rack_Location, Tray_No, Model_Name, Max_Qty, Filled_Qty FROM         Tray_Rack_Master WHERE     (Model_Name = '" & cmbModel.Text & "' ) ORDER BY Sequence_id "
        ds = SQL_SelectQuery_Execute(StrSql)
        Return ds

    End Function
    Private Sub Btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnview.Click


        Ds = getData_model_based() 
        DataGridView1.DataSource = Ds.Tables(0)

    End Sub
End Class