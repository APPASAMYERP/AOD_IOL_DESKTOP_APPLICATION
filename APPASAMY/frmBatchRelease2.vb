Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class frmBatchRelease2
    Dim StrSql As String
    Dim StrSqlIn As String
    Dim StrRs As SqlDataReader
    Dim strmfdmon, strmfdyear, strmfd As String
    Dim Cmd As New SqlCommand
    Dim sterileCompleteDate, datetoday As String
    Dim BTCNO As String
    Dim Ds, sd As New DataSet


    Public Sub Form_load()

        datetoday = Format(DateTime.Today, "MM/dd/yyyy hh:mm:ss")
        TextBox2.Text = datetoday
        Button1.Visible = False

        StrSql = "SELECT DISTINCT btc_no  from pouch_label WHERE BI_End_Date is not null AND(Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) and sterilization_reject='0' and Sterility_Status is NULL "


        Ds = SQL_SelectQuery_Execute(StrSql)
        Batch.Items.Clear()
        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            Batch.Items.Add(eachRow1("Btc_no"))
        Next

    End Sub

    

    Private Sub frmBatchRelease_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form_load()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BTCNO = Batch.SelectedItem
        If BTCNO <> Nothing Then
            Dim Ds, sd As New DataSet
            sterileCompleteDate = Format(DateTime.Today.AddDays(-14), "yyyy-MM-dd")
            StrSql = "SELECT DISTINCT btc_no  from pouch_label WHERE BI_END_DATE <= '" & sterileCompleteDate & "' and  btc_no='" & Batch.Text & "' "
            Ds = SQL_SelectQuery_Execute(StrSql)
            If Ds.Tables(0).Rows.Count = 1 Then
                StrSql = "update POUCH_LABEL set Sterility_Status =1,Sterility_Comp_Date='" & TextBox2.Text & "' where btc_no='" & Batch.Text & "' "
                Cmd = New SqlCommand(StrSql, con)
                Cmd.ExecuteNonQuery()
                Cmd.Dispose()
            Else
                Dim result As DialogResult = MessageBox.Show("This batch does not meet sterilization process.. Do you want to Release the batch?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    StrSql = "update POUCH_LABEL set Sterility_Status =1,Sterility_Comp_Date='" & TextBox2.Text & "' where btc_no='" & Batch.Text & "' "
                    Cmd = New SqlCommand(StrSql, con)
                    Cmd.ExecuteNonQuery()
                    Cmd.Dispose()
                ElseIf result = DialogResult.No Then
                    Exit Sub
                End If
            End If


            MsgBox("BATCH RELEASED")

            Batch.Text = ""
            TextBox1.Text = ""
            txtLot_size.Text = ""
            scannedtext.Text = ""
            Form_load()
        Else

        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub clear()
        Batch.Text = Nothing
        txtLot_size.Text = Nothing
        TextBox1.Text = Nothing
        scannedtext.Text = Nothing
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Public Function SQL_SelectQuery_Execute(ByVal StrSql As String) As DataSet

        Dim ds As New DataSet
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Private Sub Batch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Batch.SelectedIndexChanged
        If Batch.SelectedItem <> Nothing Then

            Dim Ds, sd As New DataSet
           
            StrSql = "SELECT     BI_Start_Date, SUM(Qty_1) AS qty, SUM(CASE WHEN Areation_Status = '1' THEN qty_1 ELSE 0 END) AS aereation " & _
               "  FROM         POUCH_LABEL " & _
                   " WHERE     (Btc_No = '" & Batch.Text & "' ) AND (Sterilization = 1) AND (Sample_Taken = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = '0') AND (Dc_Packing = 0) " & _
                       "GROUP BY BI_Start_Date "


            Ds = SQL_SelectQuery_Execute(StrSql)
            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                txtLot_size.Text = eachRow1("qty")
                scannedtext.Text = eachRow1("aereation")
                TextBox1.Text = eachRow1("BI_Start_Date").ToString()

            Next
            If txtLot_size.Text = scannedtext.Text Then
                Button1.Visible = True

            Else
                Button1.Visible = False
                MessageBox.Show(" Aereation Scan is not fully completed")
            End If
        End If
    End Sub
End Class