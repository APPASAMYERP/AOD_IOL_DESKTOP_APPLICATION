Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class frmBeforeSterilization_PMMA


    Dim StrSql, Sql As String

    Dim StrLorBarNo As String
    Dim Ds As New DataSet

    Dim getdetail As String
    Dim cmd As SqlCommand
    Dim read As SqlDataReader
    Dim table As New DataTable

    Dim getDetails As String

    Dim readdetail As SqlDataReader
    Dim Str_Header As Integer
    Dim Str_Detail As Integer
    Dim Str_Lotno, Slno As Integer
    Dim StrSqlSel1 As String
    Dim StrRsSel1 As SqlDataReader

    Dim StrSqlSeHd As String
    Dim StrRsSeHd As SqlDataReader

    Dim StrSqlSeDt As String
    Dim StrRsSeDt As SqlDataReader
    Dim StrUniqueNo As String

    Dim sqla As SqlDataAdapter

    Dim Dr As SqlDataReader
    Dim DtRow As DataRow

    Dim StrLotLesBarNo As String

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub


    Private Sub Form_load()
        StrSql = "Select Distinct Btc_no from Pouch_Label where  (Btc_No IS NOT NULL) AND (Sterilization_After = '0') AND (Sample_Taken = '0') AND (Sterilization = '0') AND (Dc_Packing = '0') AND (Dc_No IS NULL) AND (BPL_Taken = '0') "
        Ds = SQL_SelectQuery_Execute(StrSql)
        cmbBatch.Items.Clear()
        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            cmbBatch.Items.Add(eachRow1("Btc_no"))
        Next

        Str_Header = 0
        Str_Detail = 0
        StrSqlSeHd = "Select Max(Header_ID) As Header, Max(Detail_ID) As Detail from Before_Sterilization_Scan_Details"
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


        StrUniqueNo = "STB/" & Format(Now, "ddMMyy") & "/" & Str_Header
        lblSterNo.Text = StrUniqueNo
    End Sub

    Private Sub btnComplete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComplete.Click
        Try
            Str_Header = 0
            Str_Detail = 0
            StrSqlSeHd = "Select Max(Header_ID) As Header, Max(Detail_ID) As Detail from Before_Sterilization_Scan_Details"
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


            If lblScannedQty.Text > 0 Then

                If lblScannedQty.Text = lblTotalQty.Text Then
                    Dim strUpdateQry As String = ""
                    For i = 0 To DataGridView2.Rows.Count - 2

                        strUpdateQry = strUpdateQry + "'" + DataGridView2.Rows(i).Cells("Lot_srno").Value.ToString() + "',"


                    Next i

                    ' Insert record to sterilization table
                    Sql = "Insert Into Before_Sterilization_Scan_Details ( Header_ID, Detail_ID, Sterilization_Before_No, Created_By, Created_Date, Modified_By, Modified_Date, Btc_No, Qty, LotNo ) values ( " & _
                                      "'" & Str_Header & "','" & Str_Detail & "', '" & lblSterNo.Text & "', " & _
                                      "'" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),'" & cmbBatch.Text & "', '" & Val(lblScannedQty.Text) & "','" & cmbLot.Text & "' )"
                    UpdateorInsertQuery_Execute(Sql)


                    Sql = strUpdateQry.Remove(strUpdateQry.Length - 1, 1)
                    Sql = "DECLARE  @Sterilization_No nvarchar(50) ='" & lblSterNo.Text & "' Update POUCH_LABEL set Sterilization=1, Sterilization_No=@Sterilization_No  where Lot_SrNo IN (" & Sql & ")"
                    UpdateorInsertQuery_Execute(Sql)

                    Sql = "DECLARE  @Lot_prefix+lot_no @nvarchar(50) ='" & cmbLot.Text & "' ,@Btc_No  @nvarchar(50)='" & cmbBatch.Text & "'  DELETE FROM temp_POUCH_LABEL WHERE     Lot_prefix+lot_no =@Lot_prefix+lot_no AND (Btc_No = @Btc_No ) "
                    UpdateorInsertQuery_Execute(Sql)

                    MsgBox("Saved")
                    cmbBatch.Text = ""
                    cmbLot.Text = ""
                    cmbLot.Items.Clear()
                    txtLotSrNo.Text = ""
                    DataGridView2.Rows.Clear()
                    lblScannedQty.Text = "0"
                    lblTotalQty.Text = "0"

                    Form_load()
                Else
                    MsgBox("Batch not fully scanned. Please check")
                    txtLotSrNo.Focus()
                End If

            End If


        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub


        End Try
        

    End Sub

    Private Sub frmBeforeSterilization_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form_load()

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

    Private Sub txtLotSrNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLotSrNo.KeyDown
        'Dim StrGrLot As String

        If e.KeyCode = Keys.Enter Then

            Try

                If cmbBatch.SelectedItem Is Nothing Then
                    err.SetError(cmbBatch, "Please Select valid Batch No")
                    cmbBatch.Focus()
                    txtLotSrNo.Text = ""
                    Exit Sub
                Else
                    err.SetError(cmbBatch, "")
                End If

                If cmbLot.SelectedItem Is Nothing Then
                    err.SetError(cmbLot, "Please Select valid Lot No")
                    cmbLot.Focus()
                    txtLotSrNo.Text = ""
                    Exit Sub
                Else
                    err.SetError(cmbLot, "")
                End If


                If txtLotSrNo.Text <> "" Then

                    If DataGridView2.Rows.Count < 2 Then
                        MsgBox("No records found.")
                        Exit Sub
                    End If
                    StrLorBarNo = UCase(Trim(txtLotSrNo.Text))

                    If rdLotSerial.Checked = True Then
                        Sql = "DECLARE @Lot_SrNo NVARCHAR(50) = '" & txtLotSrNo.Text & "',@lot_prefix+lot_no NVARCHAR(50)= '" & cmbLot.Text & "',@Btc_no nvarchar(50)= '" & cmbBatch.Text & "'  select Model_Name,Btc_no,Power,Lot_srno from temp_POUCH_LABEL where Lot_SrNo=@Lot_SrNo AND Btc_no = @Btc_no AND lot_prefix+lot_no = @lot_prefix+lot_no and (Btc_No IS NOT NULL) AND (Sterilization_After = '0') AND (Sample_Taken = '0') AND (Sterilization = '0') AND (Dc_Packing = '0') AND (Dc_No IS NULL) AND (BPL_Taken = '0') "
                    ElseIf rdUDICode.Checked = True Then
                        Sql = "DECLARE @Udi_Code NVARCHAR(100) = '" & txtLotSrNo.Text & "',@lot_prefix+lot_no NVARCHAR(50)= '" & cmbLot.Text & "',@Btc_no nvarchar(50)= '" & cmbBatch.Text & "'    select Model_Name,Btc_no,Power,Lot_srno from temp_POUCH_LABEL where Udi_Code=@Udi_Code AND Btc_no = @Btc_no AND lot_prefix+lot_no = @lot_prefix+lot_no and (Btc_No IS NOT NULL) AND (Sterilization_After = '0') AND (Sample_Taken = '0') AND (Sterilization = '0') AND (Dc_Packing = '0') AND (Dc_No IS NULL) AND (BPL_Taken = '0') "
                    Else
                        MsgBox(" Plese choose Lot Serial or UDI Serial")
                        Exit Sub
                    End If
                    Ds = SQL_SelectQuery_Execute(Sql)

                    If Ds.Tables(0).Rows.Count = 1 Then

                        For i = 0 To DataGridView2.Rows.Count - 2

                            If DataGridView2.Item(0, i).Value.ToString() = Ds.Tables(0).Rows(0)("Lot_srno").ToString() Then
                                If DataGridView2.Item(4, i).Value.ToString() <> "1" Then
                                    DataGridView2.Item(4, i).Value = 1


                                    StrSql = "DECLARE @Lot_SrNo NVARCHAR(50) ='" & Ds.Tables(0).Rows(0)("Lot_srno").ToString() & "'  UPDATE    temp_POUCH_LABEL " & _
                                        "SET           Sterilization_scan = '1' " & _
                                        " where Lot_SrNo = @Lot_SrNo "



                                    UpdateorInsertQuery_Execute(StrSql)

                                    lblScannedQty.Text = Val(lblScannedQty.Text) + 1

                                    txtLotSrNo.Text = ""
                                    txtLotSrNo.Focus()
                                    Exit Sub
                                Else
                                    Dim customMsgBox As New CustomMessageBox("Already Scan")
                                    customMsgBox.ShowDialog()
                                    txtLotSrNo.Text = ""
                                    txtLotSrNo.Focus()
                                End If
                            End If

                        Next
                    Else
                        Dim customMsgBox As New CustomMessageBox("Scan Correct Lot Sr No")
                        customMsgBox.ShowDialog()
                        txtLotSrNo.Text = ""
                        txtLotSrNo.Focus()
                    End If


                End If

            Catch ex As Exception

                MsgBox("An unexpected error occurred.")
                Exit Sub

            End Try

            


        End If
    End Sub

    Private Sub ColorCode_SerialLoad()
        Dim scanedCount As Integer = 0

        For i As Integer = 0 To DataGridView2.Rows.Count - 2
            If Not IsDBNull(Me.DataGridView2.Rows(i).Cells("Sterilization_scan").Value) Then
                If Me.DataGridView2.Rows(i).Cells("Sterilization_scan").Value = "1" Then
                    Me.DataGridView2.Rows(i).Cells("Lot_SrNo").Style.BackColor = Color.LightGreen
                    scanedCount = scanedCount + 1
                End If
            End If
        Next
        lblScannedQty.Text = scanedCount
    End Sub


    Private Sub cmbBatch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBatch.SelectedIndexChanged
        lblScannedQty.Text = "0"
        lblTotalQty.Text = "0"
        cmbLot.Text = ""
        DataGridView2.Rows.Clear()

        StrSql = "DECLARE @Btc_no nvarchar(50)= '" & cmbBatch.Text & "' Select Distinct Lot_Prefix+lot_no as LotNO from Pouch_Label where  (Btc_No = @Btc_no ) AND (Sterilization_After = '0') AND (Sample_Taken = '0') AND (Sterilization = '0') AND (Dc_Packing = '0') AND (Dc_No IS NULL) AND (BPL_Taken = '0') "
        Ds = SQL_SelectQuery_Execute(StrSql)
        cmbLot.Items.Clear()
        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            cmbLot.Items.Add(eachRow1("LotNO"))
        Next

    End Sub
    Public Function getLotSerialNumber() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = "DECLARE @Lot_prefix+lot_no NVARCHAR(50) = '" & cmbLot.Text & "',@Btc_no nvarchar(50) = '" & cmbBatch.Text & "' SELECT DISTINCT Lot_SrNo, Model_Name, Power,Btc_No, Sterilization_scan from temp_Pouch_Label  " & _
        "where Lot_prefix+lot_no = @Lot_prefix+lot_no  AND Btc_no= @Btc_no  AND  (Btc_No IS NOT NULL) AND (Sterilization_After = '0') AND (Sample_Taken = '0') AND (Sterilization = '0') AND (Dc_Packing = '0') AND (Dc_No IS NULL) AND (BPL_Taken = '0')  " & _
        " order by  Lot_SrNo"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        cmbBatch.Text = ""
        cmbLot.Text = ""
        txtLotSrNo.Text = ""
        DataGridView2.Rows.Clear()
        lblScannedQty.Text = "0"
        lblTotalQty.Text = "0"
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Public Function check_btc_data_created() As Boolean
        Dim temp_count, original_count As Integer
        Dim ds As New DataSet
        Dim StrSql As String = "DECLARE @Lot_prefix+lot_no NVARCHAR(50) = '" & cmbLot.Text & "',@Btc_no nvarchar(50) = '" & cmbBatch.Text & "'  SELECT Count(*) As Total from temp_Pouch_Label  " & _
        "where  Lot_prefix+lot_no = @Lot_prefix+lot_no  AND Btc_no = @Btc_no AND  (Btc_No IS NOT NULL) AND (Sterilization_After = '0') AND (Sample_Taken = '0') AND (Sterilization = '0') AND (Dc_Packing = '0') AND (Dc_No IS NULL) AND (BPL_Taken = '0')  "
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        If Val(ds.Tables(0).Rows(0)("Total")) < 1 Then
            Return False
        Else
            temp_count = Val(ds.Tables(0).Rows(0)("Total"))
        End If

        Dim ds1 As New DataSet
        StrSql = "DECLARE @Lot_prefix+lot_no NVARCHAR(50) = '" & cmbLot.Text & "', @Btc_no nvarchar(50) = '" & cmbBatch.Text & "' SELECT Count(*) As Total from Pouch_Label  " & _
        "where  Lot_prefix+lot_no = @Lot_prefix+lot_no AND Btc_no = @Btc_no  AND  (Btc_No IS NOT NULL) AND (Sterilization_After = '0') AND (Sample_Taken = '0') AND (Sterilization = '0') AND (Dc_Packing = '0') AND (Dc_No IS NULL) AND (BPL_Taken = '0')  "
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


    Private Sub btc_load_inGrid()
        Ds = getLotSerialNumber()
        DataGridView2.Rows.Clear()
        For Each eachRow As DataRow In Ds.Tables(0).Rows
            DataGridView2.Rows.Add(eachRow("Lot_SrNo"), eachRow("Model_Name"), eachRow("Power"), eachRow("Btc_no"), eachRow("Sterilization_scan"))
        Next
        lblTotalQty.Text = DataGridView2.Rows.Count - 1
        txtLotSrNo.Focus()
        DataGridView2.ClearSelection()

        ColorCode_SerialLoad()
    End Sub

    Private Sub to_create_records()
        StrSql = "DECLARE @Lot_prefix+lot_no NVARCHAR(50) = '" & cmbLot.Text & "', @Btc_no nvarchar(50) = '" & cmbBatch.Text & "' INSERT INTO temp_Pouch_Label " & _
            "SELECT * from Pouch_Label   " & _
         "where  Lot_prefix+lot_no = @Lot_prefix+lot_no AND Btc_no = @Btc_no AND  (Btc_No IS NOT NULL) AND (Sterilization_After = '0') AND (Sample_Taken = '0') AND (Sterilization = '0') AND (Dc_Packing = '0') AND (Dc_No IS NULL) AND (BPL_Taken = '0') AND  " & _
         " Lot_Srno not in(SELECT lot_srno from temp_Pouch_Label " & _
         "  where  Lot_prefix+lot_no = @Lot_prefix+lot_no AND Btc_no = @Btc_no AND  (Btc_No IS NOT NULL) AND (Sterilization_After = '0') AND (Sample_Taken = '0') AND (Sterilization = '0') AND (Dc_Packing = '0') AND (Dc_No IS NULL) AND (BPL_Taken = '0')) "

        ' StrSql = " INSERT INTO temp_Pouch_Label " & _
        '   "SELECT Lot_SrNo,Model_Name,Power,Btc_no,Sterilization_scan from Pouch_Label   " & _
        '"where  Lot_prefix+lot_no = '" & cmbLot.Text & "' AND Btc_no = '" & cmbBatch.Text & "' AND  (Btc_No IS NOT NULL) AND (Sterilization_After = '0') AND (Sample_Taken = '0') AND (Sterilization = '0') AND (Dc_Packing = '0') AND (Dc_No IS NULL) AND (BPL_Taken = '0') AND  " & _
        '" Lot_Srno not in(SELECT lot_srno from temp_Pouch_Label " & _
        '"  where  Lot_prefix+lot_no = '" & cmbLot.Text & "' AND Btc_no = '" & cmbBatch.Text & "' AND  (Btc_No IS NOT NULL) AND (Sterilization_After = '0') AND (Sample_Taken = '0') AND (Sterilization = '0') AND (Dc_Packing = '0') AND (Dc_No IS NULL) AND (BPL_Taken = '0')) "

        UpdateorInsertQuery_Execute(StrSql)
    End Sub

    Private Sub cmbLot_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLot.SelectedIndexChanged


        If cmbBatch.SelectedItem Is Nothing Then
            err.SetError(cmbBatch, "Please Select valid Batch No")
            cmbBatch.Focus()
            Exit Sub
        Else
            err.SetError(cmbBatch, "")
        End If

        Dim btc_data_created As Boolean = False
        btc_data_created = check_btc_data_created()

        If btc_data_created = True Then
            btc_load_inGrid()
        Else
            to_create_records()
            btc_load_inGrid()
        End If
    End Sub
End Class