Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports System.Net
Imports System.Array
Imports System.Net.Sockets
Imports System.Drawing.Imaging



Public Class frmSterilizationAfter_Scan

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
        StrSql = "Select Distinct Btc_no from Pouch_Label  WHERE (Sterilization = '1') AND (Sterilization_After = '0') AND (BPL_Taken = '0') AND (Sample_Taken = '0') AND (Sterilization_Reject = '0') AND (Box_Packing = '0') AND    (Dc_No IS NULL) AND (BPL_NO IS NULL) AND (Box_Reject = '0') AND (Dc_Packing = '0') AND PouchPack_to_Sterile_Move_status =1 "
        Ds = SQL_SelectQuery_Execute(StrSql)
        cmbBatch.Items.Clear()
        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            cmbBatch.Items.Add(eachRow1("Btc_no"))
        Next

        Str_Header = 0
        Str_Detail = 0
        StrSqlSeHd = "Select Max(Header_ID) As Header, Max(Detail_ID) As Detail from After_Sterilization_Scan_Details"
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


        StrUniqueNo = "STA/" & Format(Now, "ddMMyy") & "/" & Str_Header
        lblSterNo.Text = StrUniqueNo

        typeBind()

    End Sub


    Private Sub btnComplete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComplete.Click

        Try

            If cmbBatch.SelectedItem Is Nothing Then
                err.SetError(cmbBatch, "Please Select valid Batch Number")
                cmbBatch.Focus()
                Exit Sub
            Else
                err.SetError(cmbBatch, "")
            End If

            If cmbBatch.Text = "" Then
                err.SetError(cmbBatch, "This information is required")
                Exit Sub
            Else
                err.SetError(cmbBatch, "")
            End If

            If CmbStOvenid.SelectedItem Is Nothing Then
                err.SetError(CmbStOvenid, "Please Select valid Oven Id")
                CmbStOvenid.Focus()
                Exit Sub
            Else
                err.SetError(cmbBatch, "")
            End If

            If CmbStOvenid.Text = "" Then
                err.SetError(CmbStOvenid, "This information is required")
                Exit Sub
            Else
                err.SetError(CmbStOvenid, "")
            End If

            If CmbStType.SelectedItem Is Nothing Then
                err.SetError(CmbStType, "Please Select valid Type")
                CmbStType.Focus()
                Exit Sub
            Else
                err.SetError(cmbBatch, "")
            End If

            If CmbStType.Text = "" Then
                err.SetError(CmbStType, "This information is required")
                Exit Sub
            Else
                err.SetError(CmbStType, "")
            End If


            'Image Exist or Not
            Dim targetNetworkPath As String = ""
            Dim imagePath As String = TextBox1.Text

            'Image Exist or Not
            Dim filePath As String = TextBox1.Text

            If File.Exists(filePath) Then
                Try

                    Dim command As String = "aws"
                    Dim arguments As String = String.Format("s3 cp ""{0}"" s3://aod-iol-rotlex/Sterile_Machine_Report/ --region ap-south-1", filePath)

                    Dim processInfo As New ProcessStartInfo()
                    processInfo.FileName = command
                    processInfo.Arguments = arguments
                    processInfo.UseShellExecute = False
                    processInfo.RedirectStandardOutput = True
                    processInfo.RedirectStandardError = True
                    processInfo.CreateNoWindow = True

                    Dim FileName As String()

                    FileName = TextBox1.Text.ToString().Split("\"c)
                    targetNetworkPath = "s3://aod-iol-rotlex/Sterile_Machine_Report/" + FileName(FileName.Length - 1)

                    ' Start the process
                    Using process As Process = process.Start(processInfo)
                        Dim output As String = process.StandardOutput.ReadToEnd()
                        Dim errors As String = process.StandardError.ReadToEnd()
                        process.WaitForExit()

                        If Not String.IsNullOrEmpty(errors) Then
                            MsgBox("Errors: " & errors, MsgBoxStyle.Information)
                            Exit Sub
                        End If
                    End Using

                Catch ex As OutOfMemoryException
                    MsgBox("The file exists but it does not contain valid image data.")
                    Exit Sub
                Catch ex As FileNotFoundException
                    MsgBox("The file could not be found.")
                    Exit Sub
                Catch ex As Exception
                    MsgBox("An error occurred while loading the image: " & ex.Message)
                    Exit Sub
                End Try
            Else
                MsgBox("The image file does not exist.")
                Exit Sub
            End If


            'If File.Exists(imagePath) Then
            '    Try
            '        Using img As Image = Image.FromFile(imagePath)

            '            Dim FileName As String()
            '            Dim fileNameWithoutExtension As String = Path.GetFileNameWithoutExtension(TextBox1.Text)

            '            FileName = TextBox1.Text.ToString().Split("\"c)
            '            targetNetworkPath = "\\iolserver1\FILESHARE2023\Machine Report Upload\Sterilization\" + FileName(FileName.Length - 1)

            '            If fileNameWithoutExtension <> cmbBatch.Text Then
            '                MsgBox("FileName Mismatch. Please check")
            '                Exit Sub
            '            End If

            '            File.Copy(TextBox1.Text, targetNetworkPath, True)
            '        End Using
            '    Catch ex As OutOfMemoryException
            '        MsgBox("The file exists but it does not contain valid image data.")
            '        Exit Sub
            '    Catch ex As FileNotFoundException
            '        MsgBox("The file could not be found.")
            '        Exit Sub
            '    Catch ex As Exception
            '        MsgBox("An error occurred while loading the image: " & ex.Message)
            '        Exit Sub
            '    End Try
            'Else
            '    MsgBox("The image file does not exist.")
            '    Exit Sub
            'End If



            Str_Header = 0
            Str_Detail = 0
            StrSqlSeHd = "Select Max(Header_ID) As Header, Max(Detail_ID) As Detail from After_Sterilization_Scan_Details"
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


            StrUniqueNo = "STA/" & Format(Now, "ddMMyy") & "/" & Str_Header
            lblSterNo.Text = StrUniqueNo


            If lblScannedQty.Text <> 0 Then

                If lblScannedQty.Text = lblTotalQty.Text Then
                    Dim strUpdateQry As String = ""
                    For i = 0 To DataGridView2.Rows.Count - 2

                        strUpdateQry = strUpdateQry + "'" + DataGridView2.Rows(i).Cells("Lot_srno").Value.ToString() + "',"


                    Next i

                    ' Insert record to sterilization table
                    Sql = "Insert Into After_Sterilization_Scan_Details ( Header_ID,Detail_ID, St_Type, St_Oven_Id, Sterilization_No, Btc_No, Qty, Created_By, Created_Date, Modified_By,Modified_Date, Sterilization_Date, Machine_Report_Path ) values ( " & _
                                      "'" & Str_Header & "','" & Str_Detail & "','" & CmbStType.Text & "','" & CmbStOvenid.Text & "','" & lblSterNo.Text & "', " & _
                                      "'" & cmbBatch.Text & "', '" & lblScannedQty.Text & "', '" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(), GETDATE(), '" & targetNetworkPath & "' )"

                    UpdateorInsertQuery_Execute(Sql)





                    ' Update After Sterilization
                    Sql = strUpdateQry.Remove(strUpdateQry.Length - 1, 1)
                    Sql = "Declare @Sterilization_No_After nvarchar(50)='" & lblSterNo.Text & "' Update POUCH_LABEL set  Sterilization_After=1,Sterilization_Date=GETDATE(), Sterilization_No_After=@Sterilization_No_After  where Lot_SrNo IN (" & Sql & ") "
                    UpdateorInsertQuery_Execute(Sql)

                    Sql = "Declare @Btc_No nvarchar(50)='" & cmbBatch.Text & "'  DELETE FROM temp_POUCH_LABEL_After WHERE     (Btc_No = @Btc_No) and Sterilization_scan='1' "
                    UpdateorInsertQuery_Execute(Sql)

                    MsgBox("Saved")
                    cmbBatch.Text = ""
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

            If txtLotSrNo.Text <> "" Then

                Try

                    If cmbBatch.SelectedItem Is Nothing Then
                        err.SetError(cmbBatch, "Please Select valid Batch No")
                        cmbBatch.Focus()
                        txtLotSrNo.Text = ""
                        Exit Sub
                    Else
                        err.SetError(cmbBatch, "")
                    End If

                    StrLorBarNo = UCase(Trim(txtLotSrNo.Text))
                    If rdLotSerial.Checked = True Then
                        Sql = "DECLARE @Lot_SrNo NVARCHAR(50) = '" & txtLotSrNo.Text & "',@Btc_no NVARCHAR(50) = '" & cmbBatch.Text & "'  select Model_Name,Btc_no,Power,Lot_srno from temp_pouch_label_After where Lot_SrNo=@Lot_SrNo AND Btc_no = @Btc_no AND  (Sterilization = '1') AND (Sterilization_After = '0') AND (BPL_Taken = '0') AND (Sample_Taken = '0') AND (Sterilization_Reject = '0') AND (Box_Packing = '0') AND    (Dc_No IS NULL) AND (BPL_NO IS NULL) AND (Box_Reject = '0') AND (Dc_Packing = '0') AND PouchPack_to_Sterile_Move_status =1 "
                    ElseIf rdUDICode.Checked = True Then
                        Sql = "DECLARE @Udi_Code NVARCHAR(50) = '" & txtLotSrNo.Text & "',@Btc_no NVARCHAR(50) = '" & cmbBatch.Text & "'  select Model_Name,Btc_no,Power,Lot_srno from temp_pouch_label_After where Udi_Code=@Udi_Code AND Btc_no = @Btc_no AND  (Sterilization = '1') AND (Sterilization_After = '0') AND (BPL_Taken = '0') AND (Sample_Taken = '0') AND (Sterilization_Reject = '0') AND (Box_Packing = '0') AND    (Dc_No IS NULL) AND (BPL_NO IS NULL) AND (Box_Reject = '0') AND (Dc_Packing = '0') AND PouchPack_to_Sterile_Move_status =1 "
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
                                    Me.DataGridView2.Rows(i).Cells("Lot_SrNo").Style.BackColor = Color.LightGreen


                                    StrSql = "DECLARE @Lot_SrNo NVARCHAR(50) ='" & Ds.Tables(0).Rows(0)("Lot_srno").ToString() & "'  UPDATE    temp_POUCH_LABEL_After " & _
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
            If Not IsDBNull(Me.DataGridView2.Rows(i).Cells("Sterilization_scan").Value) Then
                If Me.DataGridView2.Rows(i).Cells("Sterilization_scan").Value = "1" Then
                    Me.DataGridView2.Rows(i).Cells("Lot_SrNo").Style.BackColor = Color.LightGreen
                    scanedCount = scanedCount + 1
                End If
            End If
        Next
        lblScannedQty.Text = scanedCount
    End Sub

    Public Function check_btc_data_created() As Boolean
        Dim temp_count, original_count As Integer
        Dim ds As New DataSet
        Dim StrSql As String = "Declare @Btc_no NVARCHAR(50) = '" & cmbBatch.Text & "'   SELECT Count(*) As Total from temp_Pouch_Label_After  " & _
        "where Btc_no = @Btc_no AND  (Sterilization = '1') AND (Sterilization_After = '0') AND (BPL_Taken = '0') AND (Sample_Taken = '0') AND (Sterilization_Reject = '0') AND (Box_Packing = '0') AND    (Dc_No IS NULL) AND (BPL_NO IS NULL) AND (Box_Reject = '0') AND (Dc_Packing = '0') AND PouchPack_to_Sterile_Move_status =1  "
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        If Val(ds.Tables(0).Rows(0)("Total")) < 1 Then
            Return False
        Else
            temp_count = Val(ds.Tables(0).Rows(0)("Total"))
        End If

        Dim ds1 As New DataSet
        StrSql = "Declare @Btc_no NVARCHAR(50) = '" & cmbBatch.Text & "'  SELECT Count(*) As Total from Pouch_Label  " & _
        "where Btc_no = @Btc_no AND  (Sterilization = '1') AND (Sterilization_After = '0') AND (BPL_Taken = '0') AND (Sample_Taken = '0') AND (Sterilization_Reject = '0') AND (Box_Packing = '0') AND    (Dc_No IS NULL) AND (BPL_NO IS NULL) AND (Box_Reject = '0') AND (Dc_Packing = '0') AND PouchPack_to_Sterile_Move_status =1  "
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
        StrSql = "Declare @Btc_no NVARCHAR(50) = '" & cmbBatch.Text & "'  INSERT INTO temp_Pouch_Label_After " & _
            "SELECT * from Pouch_Label   " & _
         "where Btc_no = @Btc_no AND  (Sterilization = '1') AND (Sterilization_After = '0') AND (BPL_Taken = '0') AND (Sample_Taken = '0') AND (Sterilization_Reject = '0') AND (Box_Packing = '0') AND    (Dc_No IS NULL) AND (BPL_NO IS NULL) AND (Box_Reject = '0') AND (Dc_Packing = '0') AND PouchPack_to_Sterile_Move_status =1  AND  " & _
         " Lot_Srno not in(SELECT lot_srno from temp_Pouch_Label_After " & _
         "  where Btc_no = @Btc_no AND  (Sterilization = '1') AND (Sterilization_After = '0') AND (BPL_Taken = '0') AND (Sample_Taken = '0') AND (Sterilization_Reject = '0') AND (Box_Packing = '0') AND    (Dc_No IS NULL) AND (BPL_NO IS NULL) AND (Box_Reject = '0') AND (Dc_Packing = '0') AND PouchPack_to_Sterile_Move_status =1 ) "



        ' StrSql = " INSERT INTO temp_Pouch_Label_After " & _
        '   "SELECT Lot_SrNo,Model_Name,Sterilization_scan,Power,Btc_no,Sterilization_scan from Pouch_Label   " & _
        '"where Btc_no = '" & cmbBatch.Text & "' AND  (Sterilization = '1') AND (Sterilization_After = '0') AND (BPL_Taken = '0') AND (Sample_Taken = '0') AND (Sterilization_Reject = '0') AND (Box_Packing = '0') AND    (Dc_No IS NULL) AND (BPL_NO IS NULL) AND (Box_Reject = '0') AND (Dc_Packing = '0') AND PouchPack_to_Sterile_Move_status =1  AND  " & _
        '" Lot_Srno not in(SELECT lot_srno from temp_Pouch_Label_After " & _
        '"  where Btc_no = '" & cmbBatch.Text & "' AND  (Sterilization = '1') AND (Sterilization_After = '0') AND (BPL_Taken = '0') AND (Sample_Taken = '0') AND (Sterilization_Reject = '0') AND (Box_Packing = '0') AND    (Dc_No IS NULL) AND (BPL_NO IS NULL) AND (Box_Reject = '0') AND (Dc_Packing = '0') AND PouchPack_to_Sterile_Move_status =1 ) "
        ' UpdateorInsertQuery_Execute(StrSql)
    End Sub

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



    Private Sub cmbBatch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBatch.SelectedIndexChanged
        Dim btc_data_created As Boolean = False
        btc_data_created = check_btc_data_created()

        If btc_data_created = True Then
            btc_load_inGrid()
        Else
            to_create_records()
            btc_load_inGrid()
        End If


    End Sub
    Public Function getLotSerialNumber() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = "Declare @Btc_no NVARCHAR(50) = '" & cmbBatch.Text & "'  SELECT DISTINCT Lot_SrNo, Model_Name, Power,Btc_No, Sterilization_scan from temp_Pouch_Label_After  " & _
        "where Btc_no =  @Btc_no AND  (Sterilization = '1') AND (Sterilization_After = '0') AND (BPL_Taken = '0') AND (Sample_Taken = '0') AND (Sterilization_Reject = '0') AND (Box_Packing = '0') AND    (Dc_No IS NULL) AND (BPL_NO IS NULL) AND (Box_Reject = '0') AND (Dc_Packing = '0') AND PouchPack_to_Sterile_Move_status =1 " & _
        " order by  Lot_SrNo"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click, Button1.Click
        cmbBatch.Text = ""
        txtLotSrNo.Text = ""
        DataGridView2.Rows.Clear()
        lblScannedQty.Text = "0"
        lblTotalQty.Text = "0"
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmSterilizationAfter_Scan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Form_load()

    End Sub

    Public Function ImageToByteArray(ByVal image As Image) As Byte()
        Dim ms As New MemoryStream()
        image.Save(ms, image.RawFormat)
        Return ms.ToArray()
    End Function

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.pdf;*.tiff"
        OpenFileDialog1.Title = "Select an Image File"
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
        End If
    End Sub

    'Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
    '    Try
    '        OpenFileDialog1.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tiff,*.pdf"
    '        OpenFileDialog1.Title = "Select an Image File"

    '        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
    '        If result = DialogResult.OK Then
    '            Dim selectedFile As String = OpenFileDialog1.FileName

    '            ' Check if the file is an image
    '            Dim validExtensions As String() = {".bmp", ".jpg", ".jpeg", ".png", ".gif", ".tiff", ".pdf"}
    '            Dim fileExtension As String = Path.GetExtension(selectedFile).ToLower()

    '            If Array.IndexOf(validExtensions, fileExtension) >= 0 Then
    '                Dim resizedImagePath As String = ResizeImage(selectedFile)
    '                TextBox1.Text = resizedImagePath
    '            Else
    '                MessageBox.Show("Please select a valid image file.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Function ResizeImage(ByVal imagePath As String) As String
    '    Try
    '        ' Load the image
    '        Using originalImage As Image = Image.FromFile(imagePath)
    '            Dim newWidth As Integer = originalImage.Width
    '            Dim newHeight As Integer = originalImage.Height
    '            Dim quality As Long = 50 ' Start with medium quality

    '            ' Resize until the file size is below 50 KB
    '            Dim tempPath As String = Path.GetTempFileName()
    '            Using memoryStream As New MemoryStream()
    '                Do
    '                    memoryStream.SetLength(0)
    '                    Dim encoderParams As New EncoderParameters(1)
    '                    'Dim encoderInfo As ImageCodecInfo = ImageCodecInfo.GetImageDecoders().FirstOrDefault(Function(codec) codec.FormatID = ImageFormat.Jpeg.Guid)

    '                    Dim encoderInfo As ImageCodecInfo = Nothing
    '                    For Each codec As ImageCodecInfo In ImageCodecInfo.GetImageDecoders()
    '                        If codec.FormatID = ImageFormat.Jpeg.Guid Then
    '                            encoderInfo = codec
    '                            Exit For
    '                        End If
    '                    Next

    '                    encoderParams.Param(0) = New EncoderParameter(Encoder.Quality, quality)
    '                    originalImage.Save(memoryStream, encoderInfo, encoderParams)



    '                    ' Adjust quality and dimensions if file size exceeds 50 KB
    '                    If memoryStream.Length > 50 * 1024 Then
    '                        quality -= 5
    '                        newWidth = CInt(newWidth * 0.9)
    '                        newHeight = CInt(newHeight * 0.9)
    '                        Using resizedImage As New Bitmap(originalImage, New Size(newWidth, newHeight))
    '                            resizedImage.Save(memoryStream, encoderInfo, encoderParams)
    '                        End Using
    '                    End If
    '                Loop While memoryStream.Length > 50 * 1024 AndAlso quality > 10

    '                ' Save the resized image to a temporary path
    '                File.WriteAllBytes(tempPath, memoryStream.ToArray())
    '            End Using
    '            Return tempPath
    '        End Using
    '    Catch ex As Exception
    '        MessageBox.Show("Error resizing image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return String.Empty
    '    End Try
    'End Function

    Private Sub typeBind()
        CmbStType.DataSource = Nothing
        Dim ds As New DataSet()


        Sql = "select distinct Type from Sterilization_Machine_Master  "

        If Sql Is Nothing Then

        Else
            cmd = New SqlCommand(Sql, con)
            Dim ad As New SqlDataAdapter(cmd)
            ad.Fill(ds)
            CmbStType.DisplayMember = "Type"
            CmbStType.DataSource = ds.Tables(0)
        End If


    End Sub


    Private Sub MachineIdBind()
        CmbStOvenid.DataSource = Nothing
        Dim ds As New DataSet()


        Sql = "select distinct Machine_Id from Sterilization_Machine_Master Where Type=  '" & CmbStType.Text & "' "

        If Sql Is Nothing Then

        Else
            cmd = New SqlCommand(Sql, con)
            Dim ad As New SqlDataAdapter(cmd)
            ad.Fill(ds)
            CmbStOvenid.DisplayMember = "Machine_Id"
            CmbStOvenid.DataSource = ds.Tables(0)
        End If




    End Sub

    Private Sub CmbStType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbStType.SelectedIndexChanged

        MachineIdBind()
    End Sub
End Class