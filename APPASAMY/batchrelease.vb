Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class batchrelease

    Dim StrSql As String
    Dim StrRs As SqlDataReader
    Dim strmfdmon, strmfdyear, strmfd As String
    Dim Cmd As New SqlCommand
    Dim sterileCompleteDate As String
    Dim BTCNO As String




    Private Sub batchrelease_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       sterileCompleteDate= Format(DateTime.Today.AddDays(-14), "yyyy-MM-dd")
        StrSql = "SELECT DISTINCT btc_no  from pouch_label WHERE Sterilization_Date <= '" & sterileCompleteDate & "' AND(Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) and sterilization_reject='0' and Sterility_Status<>1"
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        While StrRs.Read
            Batch.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        Cmd.Dispose()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnComplete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BTCNO = Batch.SelectedItem
        StrSql = "update POUCH_LABEL set Sterility_Status =1 where btc_no='" & BTCNO & "' "
        Cmd = New SqlCommand(StrSql, con)
        Cmd.ExecuteNonQuery()
        Cmd.Dispose()

        If BTCNO <> Nothing Then
            MsgBox("BATCH RELEASED")

        Else
            MsgBox("BATCH NOT FOUND")
        End If

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class