
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class frmSterileRepack
    Dim Sql, Sql1, StrSql As String
    Dim Ds As New DataSet
    Dim Dr, Dr1 As SqlDataReader
    Dim DtRow As DataRow
    Dim cmd, cmd1 As SqlCommand
    Dim table, table1 As New DataTable
    Dim StrLorBarNo As String

    Public Sub loadTable()

        table.Columns.Add("Model_Name", GetType(String))
        table.Columns.Add("Btc_no", GetType(String))
        table.Columns.Add("Power", GetType(String))
        table.Columns.Add("Lot_srno", GetType(String))
        GRID2.DataSource = table

        With GRID2.ColumnHeadersDefaultCellStyle
            .Alignment = DataGridViewContentAlignment.TopRight
            .BackColor = Color.DarkRed
            .ForeColor = Color.Gold
            .Font = New Font(.Font.FontFamily, .Font.Size, _
             .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With

    End Sub
    Public Sub loadTable1()
        table1.Columns.Add("Model_Name", GetType(String))
        table1.Columns.Add("Btc_no", GetType(String))
        table1.Columns.Add("Power", GetType(String))
        table1.Columns.Add("Lot_srno", GetType(String))
        DataGridView1.DataSource = table1

        With DataGridView1.ColumnHeadersDefaultCellStyle
            .Alignment = DataGridViewContentAlignment.TopRight
            .BackColor = Color.DarkRed
            .ForeColor = Color.Gold
            .Font = New Font(.Font.FontFamily, .Font.Size, _
             .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With

    End Sub
   

    Private Sub BtnComplete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnComplete.Click
        Dim lotno As String = ""
        Dim model_name As String = ""
        Dim power As String = ""
        Dim btc As String = ""
        Dim strUpdateQry As String = ""
        Dim strInsertQry As String = ""

        Try
            If GRID2.Rows.Count > 1 Then
                For i = 0 To GRID2.Rows.Count - 2
                    lotno = GRID2.Rows(i).Cells("Lot_srno").Value.ToString()
                    model_name = GRID2.Rows(i).Cells("Model_Name").Value.ToString()
                    power = GRID2.Rows(i).Cells("Power").Value.ToString()
                    btc = GRID2.Rows(i).Cells("Btc_no").Value.ToString()

                    If con.State = Data.ConnectionState.Open Then
                        con.Close()
                    End If
                    If con.State = Data.ConnectionState.Closed Then
                        con.Open()
                    End If

                    strUpdateQry = strUpdateQry + "'" + lotno + "',"
                    strInsertQry = strInsertQry + "('" & btc & "','" & model_name & "','" & power & "','" & lotno & "', " & _
                          " GETDATE(), '" & StrLoginUser & "'),"
                Next
                Sql = strUpdateQry.Remove(strUpdateQry.Length - 1, 1)
                Sql = "Update POUCH_LABEL set pouchRepack_staus=1 where Lot_SrNo IN (" & Sql & ") "
                cmd = New SqlCommand(Sql, con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()



                StrSql = strInsertQry.Remove(strInsertQry.Length - 1, 1)
                StrSql = "Insert into  Repack_Details (Batch_no, Model_Name, Power, Lot_Srno, repack_date, repack_by) VALUES " & StrSql
                cmd = New SqlCommand(StrSql, con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()


                MessageBox.Show("Repack Status updated successfully")
                GRID2.ClearSelection()
                table.Clear()
                table.Dispose()
                table.Columns.Clear()
                lblcount.Text = table.Rows.Count.ToString()
                Repack_lot_txt.Text = ""
                Repack_lot_txt.Focus()
                cmbbtc.Text = ""
                loadTable()
            End If

        Catch ex As Exception

            MsgBox("An unexpected error occurred.")
            Exit Sub

        End Try
        

        
    End Sub

    Private Sub frmSterileRepack_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadTable()
        'loadTable1()
        
        If rdRepack.Checked = True Then
            StrSql = "Select Distinct Btc_no from Pouch_Label where (Sterilization = 1) AND (Sample_Taken = 0)  AND (Sterilization_After = 1) AND (Sterilization_Reject = '0')  and (pouchRepack_staus is NULL) and (udi_code is not NULL) and (sterility_status is NULL) and (Areation_status is NULL)"
            Ds = SQL_SelectQuery_Execute(StrSql)
            cmbbtc.Items.Clear()
            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                cmbbtc.Items.Add(eachRow1("Btc_no"))
            Next
        End If

    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        GRID2.ClearSelection()
        table.Clear()
        table.Dispose()
        table.Columns.Clear()
        lblcount.Text = table.Rows.Count.ToString()
        Repack_lot_txt.Text = ""
        Repack_lot_txt.Focus()
        cmbbtc.Text = ""
        loadTable()
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub GRID2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID2.CellContentClick

    End Sub

    Private Sub Repack_lot_txt_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Repack_lot_txt.KeyDown
        Dim StrGrLot As String
        If e.KeyCode = Keys.Enter Then

            If Repack_lot_txt.Text <> "" Then

                Try

                    StrLorBarNo = UCase(Trim(Repack_lot_txt.Text))

                    If rdLotSerial.Checked = True Then
                        Sql = "select  Model_Name,Btc_no,Power,Lot_srno from pouch_label where Lot_SrNo='" & Repack_lot_txt.Text & "' AND (Sterilization = 1) AND (Sample_Taken = 0)  AND (Sterilization_After = 1) AND (Sterilization_Reject = '0')  and (pouchRepack_staus is NULL) and (udi_code is not NULL) and (sterility_status is NULL) and (Areation_status is NULL)"
                    ElseIf rdUDICode.Checked = True Then
                        Sql = "select  Model_Name,Btc_no,Power,Lot_srno from pouch_label where Udi_Code='" & Repack_lot_txt.Text & "' AND (Sterilization = 1) AND (Sample_Taken = 0)  AND (Sterilization_After = 1) AND (Sterilization_Reject = '0')  and (pouchRepack_staus is NULL) and (udi_code is not NULL) and (sterility_status is NULL) and (Areation_status is NULL) "

                    Else
                        MessageBox.Show("Please Select 'Lot Serial' Or 'UDI Serial'")
                        Exit Sub
                    End If


                    cmd = New SqlCommand(Sql, con)
                    Dr = cmd.ExecuteReader()
                    If Dr.Read Then
                        If cmbbtc.Text = Dr("Btc_no") Then
                            For i = 0 To GRID2.Rows.Count - 2
                                StrGrLot = ""
                                StrGrLot = GRID2.Item(3, i).Value
                                If StrGrLot = Dr("Lot_srno") Then
                                    MsgBox("Already Scan")
                                    Repack_lot_txt.Text = ""
                                    Repack_lot_txt.Focus()
                                    i = GRID2.Rows.Count - 2
                                    Dr.Close()
                                    Exit Sub
                                End If
                            Next
                            DtRow = table.NewRow
                            table.Rows.Add(Dr("Model_Name"), Dr("Btc_no"), Dr("Power"), Dr("Lot_srno"))
                            Dr.Close()
                            cmd.Dispose()
                            lblcount.Text = table.Rows.Count.ToString()
                        Else
                            MsgBox("Batch does not match")
                        End If

                    Else
                        MsgBox("Scan Correct Lot Sr No")
                        Dr.Close()
                        cmd.Dispose()
                        Repack_lot_txt.Text = ""
                        Repack_lot_txt.Focus()


                    End If

                    Dr.Close()
                    cmd.Dispose()

                    Repack_lot_txt.Text = ""
                    Repack_lot_txt.Focus()


                Catch ex As Exception


                    MsgBox("An unexpected error occurred.")
                    Exit Sub

                End Try
                

            End If
           

        End If
    End Sub
    Private Sub ColorCode_SerialLoad()
        Dim scanedCount As Integer = 0

        For i As Integer = 0 To DataGridView2.Rows.Count - 2
            If Not IsDBNull(Me.DataGridView2.Rows(i).Cells("Repk_Scanned").Value) Then
                If Me.DataGridView2.Rows(i).Cells("Repk_Scanned").Value = "1" Then
                    Me.DataGridView2.Rows(i).Cells("Lot_SrNo").Style.BackColor = Color.LightGreen
                    scanedCount = scanedCount + 1
                End If
            End If
        Next
        lblCoutReturn.Text = scanedCount
    End Sub
 
    Private Sub txtScanRepackRemove_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtScanRepackRemove.KeyDown

        'Dim StrGrLot As String

        If e.KeyCode = Keys.Enter Then

            If txtScanRepackRemove.Text <> "" Then

                Try

                    StrLorBarNo = UCase(Trim(txtScanRepackRemove.Text))

                    If rdLotSerial.Checked = True Then
                        Sql = "select Model_Name,Btc_no,Power,Lot_srno from pouch_label where Lot_SrNo='" & txtScanRepackRemove.Text & "' AND (Sterilization = 1) AND (Sample_Taken = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = '0')  and (pouchRepack_staus ='1') and (sterility_status is NULL)"

                    ElseIf rdUDICode.Checked = True Then
                        Sql = "select Model_Name,Btc_no,Power,Lot_srno from pouch_label where Udi_Code='" & txtScanRepackRemove.Text & "' AND (Sterilization = 1) AND (Sample_Taken = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = '0')  and (pouchRepack_staus ='1') and (sterility_status is NULL)"
                    Else
                        MessageBox.Show("Please Select 'Lot Serial' Or 'UDI Serial'")
                        Exit Sub
                    End If


                    Ds = SQL_SelectQuery_Execute(Sql)

                    If Ds.Tables(0).Rows.Count = 1 Then

                        For i = 0 To DataGridView2.Rows.Count - 2

                            If DataGridView2.Item(0, i).Value.ToString() = Ds.Tables(0).Rows(0)("Lot_srno").ToString() Then
                                If DataGridView2.Item(4, i).Value.ToString() <> "1" Then
                                    DataGridView2.Item(4, i).Value = 1
                                    StrSql = "UPDATE    POUCH_LABEL " & _
                                        "SET              Repk_Scanned = '1' " & _
                                        " where Lot_SrNo = '" & Ds.Tables(0).Rows(0)("Lot_srno").ToString() & "' "
                                    UpdateorInsertQuery_Execute(StrSql)
                                    ColorCode_SerialLoad()
                                    txtScanRepackRemove.Text = ""
                                    txtScanRepackRemove.Focus()
                                    Exit Sub
                                Else
                                    MsgBox("Already Scan")
                                    txtScanRepackRemove.Text = ""
                                    txtScanRepackRemove.Focus()
                                End If
                            End If

                        Next
                    Else
                        MsgBox("Scan Correct Lot Sr No")
                        txtScanRepackRemove.Text = ""
                        txtScanRepackRemove.Focus()
                    End If


                  

                Catch ex As Exception

                    MsgBox("An unexpected error occurred.")
                    Exit Sub

                End Try
                

            End If


        End If
    End Sub

    Private Sub btnCompleteRepackRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompleteRepackRemove.Click
        Dim lotno As String = ""

        Dim model_name As String = ""
        Dim power As String = ""
        Dim btc As String = ""
        Dim strUpdateQry As String = ""
        Dim strInsertQry As String = ""

        Try

            If (lblCoutReturn.Text = btc_count.Text) Then
                For i = 0 To DataGridView2.Rows.Count - 2
                    lotno = DataGridView2.Rows(i).Cells("Lot_srno").Value.ToString()
                    model_name = DataGridView2.Rows(i).Cells("Model_Name").Value.ToString()
                    power = DataGridView2.Rows(i).Cells("Power").Value.ToString()
                    btc = DataGridView2.Rows(i).Cells("Btc_no").Value.ToString()
                    If con.State = Data.ConnectionState.Open Then
                        con.Close()
                    End If
                    If con.State = Data.ConnectionState.Closed Then
                        con.Open()
                    End If

                    strUpdateQry = strUpdateQry + "'" + lotno + "',"
                    strInsertQry = strInsertQry + "('" & btc & "','" & model_name & "','" & power & "','" & lotno & "', " & _
                          " GETDATE(), '" & StrLoginUser & "' ),"


                Next
                Sql = strUpdateQry.Remove(strUpdateQry.Length - 1, 1)
                Sql = "Update POUCH_LABEL set pouchRepack_staus =NULL, Repk_Scanned = NULL where Lot_SrNo IN (" & Sql & ")"
                cmd = New SqlCommand(Sql, con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                StrSql = strInsertQry.Remove(strInsertQry.Length - 1, 1)
                StrSql = "Insert into  Repack_Details (Batch_no, Model_Name, Power, Lot_Srno, repack_return_date, repack_return_by) VALUES " & StrSql
                cmd = New SqlCommand(StrSql, con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                MessageBox.Show("Repack Status updated successfully")
            Else
                MessageBox.Show("Total Scanned Qty and Batch Qty does not Match..")
                'Dr.Close()
                Exit Sub
            End If

            DataGridView2.Rows.Clear()
            'table1.Clear()
            'table1.Dispose()
            'table1.Columns.Clear()
            lblCoutReturn.Text = table1.Rows.Count.ToString()
            txtScanRepackRemove.Text = ""
            txtScanRepackRemove.Focus()
            cmbbtc1.Text = ""
            btc_count.Text = ""
            'loadTable1()
        Catch ex As Exception

            MsgBox("An unexpected error occurred.")
            Exit Sub

        End Try
        
    End Sub

    Private Sub btnExit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit1.Click
        Me.Close()
    End Sub

    Private Sub btnClear1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear1.Click
        'DataGridView1.ClearSelection()
        'table1.Clear()
        'table1.Dispose()
        'table1.Columns.Clear()
        DataGridView2.Rows.Clear()
        lblCoutReturn.Text = table1.Rows.Count.ToString()
        txtScanRepackRemove.Text = ""
        txtScanRepackRemove.Focus()
        cmbbtc1.Text = ""
        btc_count.Text = ""
        'loadTable1()
    End Sub

    Private Sub rdRepack_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdRepack.CheckedChanged

        If rdRepack.Checked = True Then
            GroupBox1.Visible = True
            GroupBox2.Visible = False
        Else
            GroupBox1.Visible = False
            GroupBox2.Visible = True
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
        
    End Sub
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

    Private Sub cmbbtc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbtc.SelectedIndexChanged
        StrSql = "Select count(Btc_no) as Batch from Pouch_Label where Btc_no  = '" & cmbbtc.Text & "' group by btc_no order by btc_no "
        Ds = SQL_SelectQuery_Execute(StrSql)

        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            btc_cont.Text = Ds.Tables(0).Rows(0)("Batch")
        Next
    End Sub

    Public Function getLotSerialNumber() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = "SELECT DISTINCT Lot_SrNo, Model_Name, Power,Btc_No, Repk_Scanned from Pouch_Label  " & _
        "where Btc_no = '" & cmbbtc1.Text & "'AND (pouchRepack_staus = 1) " & _
        " order by  Lot_SrNo"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Private Sub cmbbtc1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbtc1.SelectedIndexChanged
        Ds = getLotSerialNumber()
        DataGridView2.Rows.Clear()
        For Each eachRow As DataRow In Ds.Tables(0).Rows
            DataGridView2.Rows.Add(eachRow("Lot_SrNo"), eachRow("Model_Name"), eachRow("Power"), eachRow("Btc_no"), eachRow("Repk_Scanned"))
        Next
        btc_count.Text = DataGridView2.Rows.Count - 1
        txtScanRepackRemove.Focus()
        DataGridView2.ClearSelection()

        ColorCode_SerialLoad()

    End Sub

    Private Sub rdrepackReturn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdrepackReturn.CheckedChanged
        If rdrepackReturn.Checked = True Then

            StrSql = "Select Distinct Btc_no from Pouch_Label where (Sterilization = 1) AND (Sample_Taken = 0)  AND (Sterilization_After = 1) AND (Sterilization_Reject = '0')  and  (udi_code is not NULL)  and (pouchRepack_staus=1) and (sterility_status is NULL)"
            Ds = SQL_SelectQuery_Execute(StrSql)
            cmbbtc1.Items.Clear()
            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                cmbbtc1.Items.Add(eachRow1("Btc_no"))

            Next
        End If
    End Sub
End Class