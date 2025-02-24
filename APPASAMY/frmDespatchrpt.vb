Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft
Imports System.Data.Sql
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmDespatchrpt

    Dim StrSql As String
    Dim StrRs As SqlDataReader
    Dim Cmd As New SqlCommand

    Dim dcno As New ArrayList
    Dim fromdate As String
    Dim todate As String
    Dim strsname As String
    Dim strdbname As String
    Dim strpass As String

    Private Sub frmDespatchrpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If

        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        StrSql = "select distinct Brand_Name from Lens_Master"
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        While StrRs.Read
            cbxmodel.Items.Add(Format(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0))))
        End While

        strdbname = con.Database.ToString()
        strsname = con.DataSource.ToString()

        StrRs.Close()
        Cmd.Dispose()
    End Sub

    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        Dim cryRpt As New Despatchbydate
        deltemp()
        fromdate = Format(dtpdesfrom.Value, "yyyy-MM-dd") & " 00:00:00"
        todate = Format(dtpdesto.Value, "yyyy-MM-dd") & " 23:59:59"


        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo
        Dim CrTables As Tables
        Dim CrTable As Table

        cryRpt.Load("\Despatchbydate.rpt")

         

        CrTables = cryRpt.Database.Tables
        For Each CrTable In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)
        Next
        
        'StrSql = "select DC_NO from DC_SOFT where Created_Date between '" & fromdate & "' and  '" & todate & "'"
        'Cmd = New SqlCommand(StrSql, con)
        'StrRs = Cmd.ExecuteReader
        'While StrRs.Read
        '    dcno.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        'End While
        'StrRs.Close()
        'Cmd.Dispose()


        ' For i As Integer = 1 To dcno.Count
        'convert(varchar(30),P.Lot_Prefix )+''+convert(varchar(30), P.Lot_No ) as Lot_No
        StrSql = "select P.Brand_NAme,P.Model_Name,P.Power,sum(P.Qty_1) as Quantity into TMP_despatchrpt from Pouch_Label P,DC_SOFT D where D.Created_Date between '" & fromdate & "' and  '" & todate & "' and D.DC_NO=P.DC_NO and DC_Comp='1' and P.brand_Name='" & cbxmodel.Text & "' group by P.Power,P.Brand_Name,P.Model_Name"
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        StrRs.Close()
        Cmd.Dispose()


        'cryRpt.SetDatabaseLogon("sa", "sachin2123!@#")
        Despatchbydate.ReportSource = cryRpt
     
        Despatchbydate.Update()
        Despatchbydate.Validate()
        Despatchbydate.Refresh()
        Despatchbydate.Show()

    End Sub
    Public Sub deltemp()
        'StrSql = " select * from TMP_despatchrpt"
        'Cmd = New SqlCommand(StrSql, con)
        'StrRs = Cmd.ExecuteReader
        'If StrRs.Read Then
        '    StrRs.Close()
        '    Cmd.Dispose()
        StrSql = "Drop Table TMP_despatchrpt"
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        'End If
        StrRs.Close()
        Cmd.Dispose()
    End Sub

    
End Class