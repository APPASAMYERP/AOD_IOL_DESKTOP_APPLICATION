
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class Pouchreport_BasedOnPlan

    Dim StrSql, Sql As String
    Dim ds1 As New DataSet
    'Dim Dr, Dr1 As SqlDataReader
    'Dim DtRow As DataRow
    'Dim cmd, cmd1 As SqlCommand
    'Dim table, table1 As New DataTable
    Dim StrLorBarNo As String
    Dim Ds As New DataSet

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


    Private Sub Pouchreport_BasedOnPlan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class