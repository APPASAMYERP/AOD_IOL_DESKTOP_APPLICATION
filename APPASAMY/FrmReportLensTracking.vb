
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class FrmReportLensTracking
    Dim table As New DataTable
    Dim cmd As SqlCommand
    Dim Sql As String
    'Dim sqla As SqlDataAdapter
    Dim Ds As New DataSet
    Dim Dr As SqlDataReader
    Dim DtRow As DataRow
    Dim StrLorBarNo As String

    Public Function selectQueryExecute(ByVal StrSql As String) As DataSet

        Dim ds As New DataSet
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function


    Private Sub txtlotbarno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlotbarno.KeyDown
        If e.KeyCode = Keys.Enter Then



            If txtlotbarno.Text <> "" Then
                Try
                    StrLorBarNo = UCase(Trim(txtlotbarno.Text))

                    If rdLotSerial.Checked = True Then
                        Sql = "select Brand_Name, Model_Name, Power, Lot_SrNo, Mfd_Month, Mfd_Year, Exp_Month, Exp_Year, Sample_Taken, Type_Sample, BPL_Taken, BPL_NO,  Box_Packing, Box_By,  Boxtime As BoxDate, Sterilization_After, Sterilization_Reject, Box_Reject, Box_Reject_By, Tray_No, Rack_Location,pouchRepack_staus AS IsPouchRepack, Areation_Status, Btc_no from POUCH_LABEL where Lot_SrNo='" & txtlotbarno.Text & "'  "
                    ElseIf rdUDICode.Checked = True Then
                        Sql = "select Brand_Name, Model_Name, Power, Lot_SrNo, Mfd_Month, Mfd_Year, Exp_Month, Exp_Year, Sample_Taken, Type_Sample, BPL_Taken, BPL_NO,  Box_Packing, Box_By,  Boxtime As BoxDate, Sterilization_After, Sterilization_Reject, Box_Reject, Box_Reject_By, Tray_No, Rack_Location,pouchRepack_staus AS IsPouchRepack, Areation_Status, Btc_no from POUCH_LABEL where Udi_code='" & txtlotbarno.Text & "'   "

                    Else
                        MessageBox.Show("Please Select 'Lot Serial' Or 'UDI Serial'")
                        Exit Sub
                    End If

                    Ds = selectQueryExecute(Sql)

                    Ds = FlipDataSet(Ds)

                    GRID1.DataSource = Ds.Tables(0)
                    txtlotbarno.Text = ""
                    txtlotbarno.Focus()
                Catch ex As Exception
                    MsgBox("An unexpected error occurred.")
                    Exit Sub
                End Try
                


            Else
                MsgBox("Scan Correct Lot Sr No")
                txtlotbarno.Text = ""
                txtlotbarno.Focus()
            End If
            
        End If

    End Sub


    Public Function FlipDataSet(ByVal my_DataSet As DataSet) As DataSet
        Dim ds As DataSet = New DataSet()

        For Each dt As DataTable In my_DataSet.Tables
            Dim table As DataTable = New DataTable()

            For i As Integer = 0 To dt.Rows.Count
                table.Columns.Add(Convert.ToString(i))
            Next

            Dim r As DataRow

            For k As Integer = 0 To dt.Columns.Count - 1
                r = table.NewRow()
                r(0) = dt.Columns(k).ToString()

                For j As Integer = 1 To dt.Rows.Count
                    r(j) = dt.Rows(j - 1)(k)
                Next

                table.Rows.Add(r)
            Next

            ds.Tables.Add(table)
        Next

        Return ds
    End Function

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class