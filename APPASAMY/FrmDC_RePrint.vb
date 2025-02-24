Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmDC_RePrint
    Dim bApp As New BarTender.Application
    Dim bt As New BarTender.Format
    Dim btFile As String
    Dim StrSql As String
    Dim StrRs As SqlDataReader
    Dim cmd As SqlCommand
    Dim listlot As New ArrayList
    Dim i As Integer
    Dim intcount As Integer
    Dim dctwod As String


    Private Sub FrmDC_RePrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        StrSql = "SELECT DISTINCT top(20)dc_NO,CONVERT(INT, SUBSTRING(dc_NO,6,10) )AS dc from Pouch_Label ORDER BY dc DESC"
        cmd = New SqlCommand(StrSql, con)
        StrRs = cmd.ExecuteReader
        While StrRs.Read
            cbxdcno.Items.Add(StrRs.GetValue(0))
        End While
        StrRs.Close()
        cmd.Dispose()

    End Sub

    Private Sub cbxdcno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxdcno.SelectedIndexChanged
        'If cbxdcno.Text <> "" Then
        '    StrSql = "select Distinct Lot_srno from Pouch_Label where DC_no='" & cbxdcno.Text & "'"
        '    cmd = New SqlCommand(StrSql, con)
        '    StrRs = cmd.ExecuteReader
        '    If StrRs.Read Then
        '        listlot.Add(value:=StrRs.GetValue(0))
        '    End If
        'End If
    End Sub

    
    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        If cbxdcno.Text <> "" Then
            StrSql = "select Distinct Lot_srno from Pouch_Label where DC_no='" & cbxdcno.Text & "'"
            cmd = New SqlCommand(StrSql, con)
            StrRs = cmd.ExecuteReader
            While StrRs.Read
                listlot.Add(StrRs.GetValue(0))
            End While
            StrRs.Close()
            cmd.Dispose()
            Dim intpgno As Integer = 1
            For j As Integer = 1 To listlot.Count - 1

                StrSql = "select Lot_srno,Model_Name,Power,Exp_Month,Exp_year from Pouch_Label where Lot_Srno='" & listlot.Item(j) & "'"
                cmd = New SqlCommand(StrSql, con)
                StrRs = cmd.ExecuteReader
                If StrRs.Read Then
                    dctwod = dctwod & StrRs.GetValue(0) & "," & StrRs.GetValue(1) & "," & StrRs.GetValue(2) & "," & StrRs.GetValue(3) & "-" & StrRs.GetValue(4) & ";"
                    intcount += 1
                End If
                cmd.Dispose()
                StrRs.Close()

                If intcount = 80 Then
                    btFile = Application.StartupPath & "\DC_2D.btw"
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("DCNO", cbxdcno.Text)
                    bt.SetNamedSubStringValue("dcdate", Now.Date)
                    bt.SetNamedSubStringValue("DC2D", dctwod)
                    bt.SetNamedSubStringValue("pgno", intpgno)
                    dctwod = ""
                ElseIf intcount = 160 Then
                    bt.SetNamedSubStringValue("DC2D22", dctwod)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                    dctwod = ""
                    intcount = 0
                    intpgno += 1

                End If
            Next
            If intcount <> 0 Then
                If intcount < 80 Then
                    btFile = Application.StartupPath & "\DC_2D.btw"
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("DCNO", cbxdcno.Text)
                    bt.SetNamedSubStringValue("dcdate", Now.Date)
                    bt.SetNamedSubStringValue("DC2D", dctwod)
                    bt.SetNamedSubStringValue("DC2D22", " ")
                    bt.SetNamedSubStringValue("pgno", intpgno)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                ElseIf intcount > 80 And intcount < 160 Then
                    bt.SetNamedSubStringValue("DC2D22", dctwod)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                End If
            End If

            StrRs.Close()
            cmd.Dispose()
        Else
            MsgBox("PLEASE SELECT DC NO")
        End If
    End Sub
    Public Shared Function DefaultPrinterName() As String
        Dim oPS As New System.Drawing.Printing.PrinterSettings
        Try
            DefaultPrinterName = oPS.PrinterName
        Catch ex As System.Exception
            DefaultPrinterName = ""
        Finally
            oPS = Nothing
        End Try
    End Function
End Class