Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class frmBatchRelease

    Dim StrSql As String
    Dim StrSqlIn As String
    Dim StrRs As SqlDataReader
    Dim strmfdmon, strmfdyear, strmfd As String
    Dim Cmd As New SqlCommand
    Dim sterileCompleteDate As String
    Dim BTCNO As String

    Private Sub frmBatchRelease_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sterileCompleteDate = Format(DateTime.Today.AddDays(-14), "yyyy-MM-dd")
        StrSql = "SELECT DISTINCT btc_no  from pouch_label WHERE Sterilization_Date <= '" & sterileCompleteDate & "' AND(Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) and sterilization_reject='0' and Sterility_Status is NULL "
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        While StrRs.Read
            Batch.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        Cmd.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        BTCNO = Batch.SelectedItem
        If BTCNO <> Nothing Then

            Try
                StrSql = "update POUCH_LABEL set Sterility_Status =1 where btc_no='" & BTCNO & "' "
                Cmd = New SqlCommand(StrSql, con)
                Cmd.ExecuteNonQuery()
                Cmd.Dispose()

                'StrSql = "INSERT INTO PRN_Report_Data (Batch_no, Esr_no, PRN_no, Lot_size, Sterile_date, Release_date, Flag)VALUES('" & Batch.SelectedText & "','" & Prntext.Text & "' , '" & txtLot_size.Text & "' , '" & Steriledate.Text & "', '" & Releasedate.Text & "')"
                'Cmd = New SqlCommand(StrSqlIn, con)
                'Cmd.ExecuteNonQuery()
                'MsgBox("Save Sucessfully", MsgBoxStyle.Information)
                MsgBox("BATCH RELEASED")

            Catch ex As Exception
                MsgBox("An unexpected error occurred.")
                Exit Sub
            End Try
            

        Else
            MsgBox("BATCH NOT FOUND")
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Releasedate.ValueChanged

    End Sub
End Class