Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft
Imports System.Data.Sql
Imports System.Configuration

Public Class injectorreportform
    Dim StrSql, StrSql1 As String
    Dim StrRs, StrRss As SqlDataReader
    Dim Cmd As New SqlCommand
    Dim fromdte As String
    Dim toodate As String
    Dim ds As New DataSet
    Public Function SQL_SelectQuery_Execute(ByVal StrSql As String) As DataSet

        Dim ds As New DataSet
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function


    Private Sub Btnstock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnstock.Click
        Try
            Dim cryRpt As New injectorstock
            StrSql = "SELECT DISTINCT Inj_Batch, Inj_Ref, Product_Name, Mfd_Date, Exp_Date,Stock_Qty FROm Injector_Stock where stock_qty > 0  "
            ds = SQL_SelectQuery_Execute(StrSql)
            cryRpt.SetDataSource(ds.Tables(0))
            CrystalReportViewer1.ReportSource = cryRpt
            CrystalReportViewer1.Refresh()
            CrystalReportViewer1.Show()
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
       
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

        

    End Sub
End Class
