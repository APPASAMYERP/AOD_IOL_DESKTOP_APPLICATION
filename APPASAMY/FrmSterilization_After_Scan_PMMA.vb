Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration

Public Class FrmSterilization_After_Scan_PMMA

    Dim StrSql, Sql As String
    Dim ds1 As New DataSet
    'Dim Dr, Dr1 As SqlDataReader
    'Dim DtRow As DataRow
    'Dim cmd, cmd1 As SqlCommand
    'Dim table, table1 As New DataTable
    Dim StrLorBarNo As String
    Dim Ds As New DataSet
    Dim Str_Header As Integer
    Dim Str_Detail As Integer
    Dim StrUniqueNo As String
    Dim StrSqlSeHd As String


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

    Public Function getBatchNumbers() As String


        Dim btaches As String = ""
        Dim ds As New DataSet
        Dim StrSql As String = "SELECT DISTINCT Btc_No FROM         POUCH_LABEL   WHERE     (pouchRepack_staus = '1')"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)

        For Each eachRow1 As DataRow In ds.Tables(0).Rows
            btaches = btaches + "'" + eachRow1("Btc_No") + "',"

        Next
        If btaches <> "" Then
            btaches = btaches.Remove(btaches.Length - 1, 1)
        Else
            Return "''"
        End If

        Return btaches

    End Function

    Private Sub Form_Load()
        Dim SterileBatches As String = ""
        SterileBatches = getBatchNumbers()

        StrSql = "Select Distinct Btc_no from Pouch_Label where (BPL_Taken = '0') AND (Dc_No IS NULL) AND (Sterilization_After = '1') AND (Sterilization_Reject = '0') AND (Sample_Taken = '0') AND (Sterilization = '1') AND  (udi_code is not NULL)  and Dc_Packing='0'  AND (Box_Packing = '0') AND (Areation_Status is NULL)  AND Sterile_to_Areation_Move_status = 1  and Btc_No not in(" & SterileBatches & ") "
        Ds = SQL_SelectQuery_Execute(StrSql)
        cmbBatch.Items.Clear()
        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            cmbBatch.Items.Add(eachRow1("Btc_no"))
        Next


        Str_Header = 0
        Str_Detail = 0
        StrSqlSeHd = "Select Max(Header_ID) As Header, Max(Detail_ID) As Detail from Areation_Scan_Details"
        Ds = SQL_SelectQuery_Execute(StrSqlSeHd)

        If DBNull.Value.Equals(Ds.Tables(0).Rows(0)("Header")) Then
            Str_Header = 0
        Else
            Str_Header = Val(Ds.Tables(0).Rows(0)("Header"))
        End If

        If DBNull.Value.Equals(Ds.Tables(0).Rows(0)("Detail")) Then
            Str_Detail = 0
        Else
            Str_Detail = Val(Ds.Tables(0).Rows(0)("Detail"))
        End If


        If Str_Header = 0 Then
            Str_Header = 1
        Else
            Str_Header = Str_Header + 1
        End If

        If Str_Detail = 0 Then
            Str_Detail = 1
        Else
            Str_Detail = Str_Detail + 1
        End If


        StrUniqueNo = "AS/" & Format(Now, "ddMMyy") & "/" & Str_Header
        lblAreationNo.Text = StrUniqueNo

    End Sub

    Private Sub FrmSterilization_After_Scan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Form_Load()
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try


    End Sub
    Public Function getLotSerialNumber() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = "SELECT DISTINCT Lot_SrNo, Model_Name, Power,Btc_No, Areation_scan from temp_POUCH_LABEL_Areation  " & _
        "where Btc_no = '" & cmbBatch.Text & "' AND Lot_prefix+Lot_No = '" & cmbLot_No.Text & "'  AND (BPL_Taken = '0') AND (Dc_No IS NULL) AND (Sterilization_After = '1') AND (Sterilization_Reject = '0') AND (Sample_Taken = '0') AND (Sterilization = '1') AND  (udi_code is not NULL)  and Dc_Packing='0'  AND Sterile_to_Areation_Move_status = 1  AND (Box_Packing = '0')  " & _
        " order by  Lot_SrNo"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Public Function getTotalbtcQty() As DataSet


        Dim StrSql As String = "SELECT Sum(qty_1) as Qty from Pouch_Label  " & _
        "where Btc_no = '" & cmbBatch.Text & "'   AND (BPL_Taken = '0') AND (Dc_No IS NULL) AND (Sterilization_After = '1') AND (Sterilization_Reject = '0') AND (Sample_Taken = '0') AND (Sterilization = '1') AND  (udi_code is not NULL)  and Dc_Packing='0'  AND Sterile_to_Areation_Move_status = 1 AND (Box_Packing = '0') "
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds1)
        Return ds1

    End Function

    Private Sub ColorCode_SerialLoad()
        Dim scanedCount As Integer = 0

        For i As Integer = 0 To DataGridView2.Rows.Count - 2
            If Not IsDBNull(Me.DataGridView2.Rows(i).Cells("Areation_scan").Value) Then
                If Me.DataGridView2.Rows(i).Cells("Areation_scan").Value = "1" Then
                    Me.DataGridView2.Rows(i).Cells("Lot_SrNo").Style.BackColor = Color.LightGreen
                    scanedCount = scanedCount + 1
                End If
            End If
        Next
        lblScannedQty.Text = scanedCount
    End Sub

    Private Sub cmbBatch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBatch.SelectedIndexChanged
        Try
            Dim dsSampleLens As DataSet
            Dim sampleLensQty As Integer = 0
            cmbLot_No.Items.Clear()
            ' Validation for sample lens must taken for each Batch
            dsSampleLens = sampleLens()
            For Each eachQty As DataRow In dsSampleLens.Tables(0).Rows
                If Not IsDBNull(eachQty("Qty")) Then
                    sampleLensQty = sampleLensQty + Convert.ToInt32(eachQty("Qty"))
                End If
            Next

            If productline = "PMMA" Then
                If sampleLensQty < 70 Then
                    MessageBox.Show("The Sample taken Process is not done. Please Check")
                    Exit Sub
                End If
            ElseIf productline = "PHILIC" Then
                If sampleLensQty < 73 Then
                    MessageBox.Show("The Sample taken Process is not done. Please Check")
                    Exit Sub
                End If
            ElseIf productline = "PHOBIC" Then
                If sampleLensQty < 64 Then
                    MessageBox.Show("The Sample taken Process is not done. Please Check")
                    Exit Sub
                End If
            ElseIf productline = "PHOBIC NONPRELOADED" Then
                If sampleLensQty < 64 Then
                    MessageBox.Show("The Sample taken Process is not done. Please Check")
                    Exit Sub
                End If
            End If

            DataGridView2.Rows.Clear()
            cmbLot_No.Text = ""
            lblScannedQty.Text = ""
            lblTotalQty.Text = ""
            getTotalbtcQty()
            For i As Integer = 0 To ds1.Tables(0).Rows.Count - 1
                Dim someVar As Integer = Integer.Parse(ds1.Tables(0).Rows(i)(0).ToString())

                lblbtcQty.Text = someVar
            Next


            StrSql = "Select Distinct Lot_Prefix+Lot_No As Lot_Number from Pouch_Label where (BPL_Taken = '0') AND (Dc_No IS NULL) AND (Sterilization_After = '1') AND (Sterilization_Reject = '0') AND (Sample_Taken = '0') AND (Sterilization = '1') AND  (udi_code is not NULL)  and Dc_Packing='0'  AND Sterile_to_Areation_Move_status = 1 AND (Box_Packing = '0') AND (Areation_Status is NULL) and  Btc_no = '" & cmbBatch.Text & "'  order by Lot_Number   "
            Ds = SQL_SelectQuery_Execute(StrSql)
            cmbLot_No.Items.Clear()
            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                cmbLot_No.Items.Add(eachRow1("Lot_Number"))
            Next
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        

    End Sub

    Private Sub txtLotSrNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLotSrNo.KeyDown


        'Dim StrGrLot As String

        If e.KeyCode = Keys.Enter Then

            If txtLotSrNo.Text <> "" Then
                Try

                    StrLorBarNo = UCase(Trim(txtLotSrNo.Text))
                    Sql = "select Model_Name,Btc_no,Power,Lot_srno from temp_POUCH_LABEL_Areation where Udi_Code='" & txtLotSrNo.Text & "' AND Btc_no = '" & cmbBatch.Text & "' AND Lot_prefix+Lot_No = '" & cmbLot_No.Text & "'  AND (BPL_Taken = '0') AND (Dc_No IS NULL) AND (Sterilization_After = '1') AND (Sterilization_Reject = '0') AND (Sample_Taken = '0') AND (Sterilization = '1') AND  (udi_code is not NULL)  and Dc_Packing='0'  AND Sterile_to_Areation_Move_status = 1  AND (Box_Packing = '0') AND pouchRepack_staus is NULL "
                    Ds = SQL_SelectQuery_Execute(Sql)

                    If Ds.Tables(0).Rows.Count = 1 Then

                        For i = 0 To DataGridView2.Rows.Count - 2

                            If DataGridView2.Item(0, i).Value.ToString() = Ds.Tables(0).Rows(0)("Lot_srno").ToString() Then
                                If DataGridView2.Item(4, i).Value.ToString() <> "1" Then
                                    DataGridView2.Item(4, i).Value = 1
                                    StrSql = "UPDATE    temp_POUCH_LABEL_Areation " & _
                                        "SET              Areation_scan = '1' " & _
                                        " where Lot_SrNo = '" & Ds.Tables(0).Rows(0)("Lot_srno").ToString() & "' "
                                    UpdateorInsertQuery_Execute(StrSql)
                                    'ColorCode_SerialLoad()
                                    lblScannedQty.Text = Val(lblScannedQty.Text) + 1

                                    txtLotSrNo.Text = ""
                                    txtLotSrNo.Focus()
                                    Exit Sub
                                Else
                                    Dim customMsgBox As New CustomMessageBox("Already Scan")
                                    customMsgBox.ShowDialog()
                                    'MsgBox("Already Scan")
                                    txtLotSrNo.Text = ""
                                    txtLotSrNo.Focus()
                                End If
                            End If

                        Next
                    Else
                        Dim customMsgBox As New CustomMessageBox("Scan Correct Lot Sr No")
                        customMsgBox.ShowDialog()
                        'MsgBox("Scan Correct Lot Sr No")
                        txtLotSrNo.Text = ""
                        txtLotSrNo.Focus()
                    End If

                Catch ex As Exception
                    MsgBox("An unexpected error occurred.")
                    Exit Sub
                End Try
                


            End If


        End If
    End Sub

    Private Sub btnComplete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComplete.Click
        Try
            Str_Header = 0
            Str_Detail = 0
            StrSqlSeHd = "Select Max(Header_ID) As Header, Max(Detail_ID) As Detail from Areation_Scan_Details"
            Ds = SQL_SelectQuery_Execute(StrSqlSeHd)

            If DBNull.Value.Equals(Ds.Tables(0).Rows(0)("Header")) Then
                Str_Header = 0
            Else
                Str_Header = Val(Ds.Tables(0).Rows(0)("Header"))
            End If

            If DBNull.Value.Equals(Ds.Tables(0).Rows(0)("Detail")) Then
                Str_Detail = 0
            Else
                Str_Detail = Val(Ds.Tables(0).Rows(0)("Detail"))
            End If


            If Str_Header = 0 Then
                Str_Header = 1
            Else
                Str_Header = Str_Header + 1
            End If

            If Str_Detail = 0 Then
                Str_Detail = 1
            Else
                Str_Detail = Str_Detail + 1
            End If


            If lblScannedQty.Text = lblTotalQty.Text Then
                Dim strUpdateQry As String = ""
                For i = 0 To DataGridView2.Rows.Count - 2

                    strUpdateQry = strUpdateQry + "'" + DataGridView2.Rows(i).Cells("Lot_srno").Value.ToString() + "',"


                Next i

                ' Insert record to sterilization table
                Sql = "Insert Into Areation_Scan_Details ( Header_ID, Detail_ID, Areation_Scan_No, Created_By, Created_Date, Modified_By, Modified_Date, Btc_No, Lot_No, Qty ) values ( " & _
                                  "'" & Str_Header & "','" & Str_Detail & "', '" & lblAreationNo.Text & "', " & _
                                  "'" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),'" & cmbBatch.Text & "' ,'" & cmbLot_No.Text & "','" & Val(lblScannedQty.Text) & "' )"
                UpdateorInsertQuery_Execute(Sql)


                Sql = strUpdateQry.Remove(strUpdateQry.Length - 1, 1)
                Sql = "Update POUCH_LABEL set Areation_Status=1,  Areation_Scan_No='" & lblAreationNo.Text & "' where Lot_SrNo IN (" & Sql & ")"
                UpdateorInsertQuery_Execute(Sql)

                Sql = "DELETE FROM temp_POUCH_LABEL_Areation WHERE     Lot_prefix+Lot_No = '" & cmbLot_No.Text & "'  AND (Btc_No = '" & cmbBatch.Text & "' ) "
                UpdateorInsertQuery_Execute(Sql)

                MsgBox("Saved")
                cmbBatch.Text = ""
                cmbLot_No.Text = ""
                cmbLot_No.Items.Clear()
                txtLotSrNo.Text = ""
                DataGridView2.Rows.Clear()
                lblScannedQty.Text = "0"
                lblTotalQty.Text = "0"
                lblbtcQty.Text = "0"

                Form_Load()
            Else
                MsgBox("Batch not fully scanned. Please check")
                txtLotSrNo.Focus()
            End If
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        cmbBatch.Text = ""
        txtLotSrNo.Text = ""
        DataGridView2.Rows.Clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Public Function check_btc_data_created() As Boolean
        Dim temp_count, original_count As Integer
        Dim ds As New DataSet
        Dim StrSql As String = "SELECT  count(*) AS Total from temp_POUCH_LABEL_Areation  " & _
        "where Lot_prefix+Lot_No = '" & cmbLot_No.Text & "'  AND Btc_no = '" & cmbBatch.Text & "'  AND (BPL_Taken = '0') AND (Dc_No IS NULL) AND (Sterilization_After = '1') AND (Sterilization_Reject = '0') AND (Sample_Taken = '0') AND (Sterilization = '1') AND  (udi_code is not NULL)  and Dc_Packing='0'  AND Sterile_to_Areation_Move_status = 1 AND (Box_Packing = '0')  "

        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        If Val(ds.Tables(0).Rows(0)("Total")) < 1 Then
            Return False
        Else
            temp_count = Val(ds.Tables(0).Rows(0)("Total"))
        End If

        Dim ds1 As New DataSet
        StrSql = "SELECT count(*) AS Total from POUCH_LABEL   " & _
        "where Lot_prefix+Lot_No = '" & cmbLot_No.Text & "'  AND Btc_no = '" & cmbBatch.Text & "'  AND (BPL_Taken = '0') AND (Dc_No IS NULL) AND (Sterilization_After = '1') AND (Sterilization_Reject = '0') AND (Sample_Taken = '0') AND (Sterilization = '1') AND  (udi_code is not NULL)  and Dc_Packing='0'  AND Sterile_to_Areation_Move_status = 1 AND (Box_Packing = '0')  "

        Dim Cmd1 As New SqlCommand(StrSql, con)
        Dim ad1 As New SqlDataAdapter(Cmd1)
        ad1.Fill(ds1)
        original_count = Val(ds1.Tables(0).Rows(0)("Total"))

        If temp_count = original_count Then
            Return True
        Else
            Return False
        End If


    End Function
    Private Sub to_create_records()
        StrSql = " INSERT INTO temp_POUCH_LABEL_Areation " & _
            "SELECT * from POUCH_LABEL   " & _
         "where Lot_prefix+Lot_No = '" & cmbLot_No.Text & "'  AND Btc_no = '" & cmbBatch.Text & "'  AND (BPL_Taken = '0') AND (Dc_No IS NULL) AND (Sterilization_After = '1') AND (Sterilization_Reject = '0') AND (Sample_Taken = '0') AND (Sterilization = '1') AND  (udi_code is not NULL)  and Dc_Packing='0'  AND Sterile_to_Areation_Move_status = 1  AND (Box_Packing = '0') AND  " & _
         " Lot_Srno not in(SELECT DISTINCT Lot_SrNo from temp_POUCH_LABEL_Areation  " & _
         "  where Lot_prefix+Lot_No = '" & cmbLot_No.Text & "'  AND Btc_no = '" & cmbBatch.Text & "'  AND (BPL_Taken = '0') AND (Dc_No IS NULL) AND (Sterilization_After = '1') AND (Sterilization_Reject = '0') AND (Sample_Taken = '0') AND (Sterilization = '1') AND  (udi_code is not NULL)  and Dc_Packing='0'  AND Sterile_to_Areation_Move_status = 1  AND (Box_Packing = '0') ) "

        UpdateorInsertQuery_Execute(StrSql)
    End Sub

    Private Sub btc_load_inGrid()
        Ds = getLotSerialNumber()
        DataGridView2.Rows.Clear()
        For Each eachRow As DataRow In Ds.Tables(0).Rows
            DataGridView2.Rows.Add(eachRow("Lot_SrNo"), eachRow("Model_Name"), eachRow("Power"), eachRow("Btc_no"), eachRow("Areation_scan"))
        Next
        lblTotalQty.Text = DataGridView2.Rows.Count - 1
        txtLotSrNo.Focus()
        DataGridView2.ClearSelection()

        ColorCode_SerialLoad()
    End Sub

    Public Function sampleLens() As DataSet

        Dim ds, dsPhobic, dsNP As New DataSet
        Dim dtPhobic, dtNP As New DataTable
        Dim conPHOBIC, conNP As New SqlConnection

        conPHOBIC.ConnectionString = ConfigurationSettings.AppSettings("conStrPHOBIC").ToString()
        conNP.ConnectionString = ConfigurationSettings.AppSettings("conStrPHOBICNONPRE").ToString()

        Dim StrSql As String = "SELECT SUM(Qty_1)as Qty from POUCH_LABEL  WHERE  (Btc_No = '" & cmbBatch.Text & "') AND (Sample_Taken = '1' OR BPL_NO LIKE 'CST%' ) "



        If productline = "PHOBIC" Or productline = "PHOBIC NONPRELOADED" Then
            'Phobic
            Dim Cmd As New SqlCommand(StrSql, conPHOBIC)
            Dim ad As New SqlDataAdapter(Cmd)
            ad.Fill(dsPhobic)
            dtPhobic = dsPhobic.Tables(0)

            'NP
            Cmd = New SqlCommand(StrSql, conNP)
            ad = New SqlDataAdapter(Cmd)
            ad.Fill(dsNP)
            dtNP = dsNP.Tables(0)
            dtPhobic.Merge(dtNP)


            Return dtPhobic.DataSet

        Else
            Dim Cmd As New SqlCommand(StrSql, con)
            Dim ad As New SqlDataAdapter(Cmd)
            ad.Fill(ds)
            Return ds
        End If



    End Function

    Private Sub cmbLot_No_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLot_No.SelectedIndexChanged
        Try
            Dim btc_data_created As Boolean = False
            btc_data_created = check_btc_data_created()

            If btc_data_created = True Then
                btc_load_inGrid()
            Else

                to_create_records()
                btc_load_inGrid()
            End If

        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try

        


    End Sub


    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub cmbBatch_QueryAccessibilityHelp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.QueryAccessibilityHelpEventArgs) Handles cmbBatch.QueryAccessibilityHelp

    End Sub
End Class