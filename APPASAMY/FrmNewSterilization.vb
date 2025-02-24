
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO



Public Class FrmNewSterilization



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
    Dim Sql As String
    Dim sqla As SqlDataAdapter
    Dim Ds As New DataSet
    Dim Dr As SqlDataReader
    Dim DtRow As DataRow
    Dim StrLorBarNo As String
    Dim StrLotLesBarNo As String
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

    Private Sub Form_load()
         

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


        LotPrefixBind()

        typeBind()
    End Sub

    Private Sub FrmNewSterilization_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
 
        Form_load()

        table.Columns.Add("Lot_Srl_No", GetType(String))
        table.Columns.Add("Lot_Prefix", GetType(String))
        table.Columns.Add("Lot_No", GetType(String))
        GRID2.DataSource = table


        With GRID2.ColumnHeadersDefaultCellStyle
            .Alignment = DataGridViewContentAlignment.TopRight
            .BackColor = Color.DarkRed
            .ForeColor = Color.Gold
            .Font = New Font(.Font.FontFamily, .Font.Size, _
             .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With

    End Sub

    Private Sub LotPrefixBind()
        Dim ds As New DataSet()

        If RdoASt.Checked Then
            Sql = "select distinct Lot_Prefix from Pouch_Label where   (Sterilization = '1') AND (Sterilization_After = '0') AND (BPL_Taken = '0') AND (Sample_Taken = '0') AND (Sterilization_Reject = '0') AND (Box_Packing = '0') AND    (Dc_No IS NULL) AND (BPL_NO IS NULL) AND (Box_Reject = '0') AND (Dc_Packing = '0') AND PouchPack_to_Sterile_Move_status =1 "
        End If
        If Sql Is Nothing Then

        Else
            cmd = New SqlCommand(Sql, con)
            Dim ad As New SqlDataAdapter(cmd)
            ad.Fill(ds)
            cmbLotPrefix.DisplayMember = "Lot_Prefix"
            cmbLotPrefix.DataSource = ds.Tables(0)
        End If

       
    End Sub

    Private Sub LotNoBind()
        Dim ds As New DataSet()

        If RdoASt.Checked Then
            Sql = "select distinct Lot_No from Pouch_Label where (Sterilization = '1') AND (Sterilization_After = '0') AND (BPL_Taken = '0') AND (Sample_Taken = '0') AND (Sterilization_Reject = '0') AND (Box_Packing = '0') AND    (Dc_No IS NULL) AND (BPL_NO IS NULL) AND (Box_Reject = '0') AND (Dc_Packing = '0') AND PouchPack_to_Sterile_Move_status =1 and Lot_Prefix = '" & cmbLotPrefix.Text & "' order by Lot_No "
        End If

        'Sql = "select distinct Lot_No from Pouch_Label where Lot_Prefix = '" & cmbLotPrefix.Text & "' order by Lot_No"
        cmd = New SqlCommand(Sql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)
        cmbLotNo.DisplayMember = "Lot_No"
        cmbLotNo.DataSource = ds.Tables(0)
        ComboLotTo.Items.Clear()
        For Each eachRow As DataRow In ds.Tables(0).Rows
            ComboLotTo.Items.Add(eachRow("Lot_No"))
        Next
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
        Menulblmstdatacre.LblHomeMenuDisplyName.Visible = False
        Menulblmstdatacre.TimHomeSideDisply.Start()

    End Sub

    Private Sub BtnComplete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnComplete.Click


        If dtpDate.Value <= Date.Now() Then
        Else
            MsgBox("Please Select valid Date", MsgBoxStyle.Information)
            Exit Sub
        End If

        Try


            If RdoASt.Checked = True Then

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


                If txtbtno.Text = "" Then
                    MsgBox("Please Enter Batch No", MsgBoxStyle.Information)
                    txtbtno.Focus()
                    Exit Sub

                End If

                ' Insert record to sterilization table
                Sql = "Insert Into After_Sterilization_Scan_Details ( Header_ID,Detail_ID,Lot_Prefix,Lot_From, Lot_To, St_Type, St_Oven_Id, Sterilization_No, Btc_No, Qty, Created_By, Created_Date, Modified_By,Modified_Date, Sterilization_Date, Machine_Report_Path ) values ( " & _
                                  "'" & Str_Header & "','" & Str_Detail & "','" & cmbLotPrefix.Text & "','" & cmbLotNo.Text & "','" & ComboLotTo.Text & "','" & CmbStType.Text & "','" & CmbStOvenid.Text & "','" & lblSterNo.Text & "', " & _
                                  "'" & txtbtno.Text & "', '" & lblcount.Text & "', '" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(), '" & dtpDate.Text & "', '" & targetNetworkPath & "' )"
                cmd = New SqlCommand(Sql, con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()



                ' Update After Sterilization

                Sql = "Update POUCH_LABEL set  Sterilization_After=1,Sterilization_Date='" & dtpDate.Text & "', Sterilization_No_After= '" & lblSterNo.Text & "'  where Lot_Prefix = '" & cmbLotPrefix.Text & "' and Lot_No  between  '" & cmbLotNo.Text & "' and '" & ComboLotTo.Text & "'  and (Sterilization = '1') AND (Sterilization_After = '0') AND (BPL_Taken = '0') AND (Sample_Taken = '0') AND (Sterilization_Reject = '0') AND (Box_Packing = '0') AND    (Dc_No IS NULL) AND (BPL_NO IS NULL) AND (Box_Reject = '0') AND (Dc_Packing = '0') AND PouchPack_to_Sterile_Move_status =1 "
                cmd = New SqlCommand(Sql, con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()



                MsgBox("Saved ")
                Form_load()
                cmbLotPrefix.Text = ""
                cmbLotNo.Text = ""
                ComboLotTo.Text = ""
                txtbtno.Text = ""
                CmbStType.Text = Nothing
                CmbStOvenid.Text = Nothing
                lblcount.Text = 0
                table.Rows.Clear()

            End If

            btnAdd.Visible = True
            cmbLotNo.Enabled = True
            ComboLotTo.Enabled = True
            cmbLotPrefix.Enabled = True



            LotPrefixBind()


        Catch ex As Exception

            MsgBox("An unexpected error occurred.")
            Exit Sub

        End Try

        

    End Sub


    Private Sub clear()

        CmbStType.Text = Nothing
        CmbStOvenid.Text = Nothing
        cmbLotPrefix.Text = Nothing
        ComboLotTo.Text = Nothing
        cmbLotNo.Text = Nothing
        txtbtno.Text = Nothing
        btnAdd.Visible = True
        cmbLotNo.Enabled = True
        ComboLotTo.Enabled = True
        cmbLotPrefix.Enabled = True
        GRID2.ClearSelection()
        table.Clear()
        lblcount.Text = 0

    End Sub

    Private Sub RdoASt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoASt.CheckedChanged
        'GroupBox4.Visible = False
        'GRID2.ClearSelection()
        'table.Clear()
        'lblcount.Text = 0
        'If RdoASt.Checked = True Then
        '    lblno.Visible = True
        '    txtbtno.Visible = True
        '    Label3.Visible = True
        '    dtpDate.Visible = True
        'End If
        'btnAdd.Visible = True
        'cmbLotNo.Enabled = True
        'ComboLotTo.Enabled = True
        'cmbLotPrefix.Enabled = True

    End Sub

    Private Sub cmbLotPrefix_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLotPrefix.SelectedIndexChanged
        ComboLotTo.Text = ""
        LotNoBind()

    End Sub

    Private Sub SterilizationlistBind()
        Dim ds As New DataSet()
        Dim i As Integer
        If RdoASt.Checked = True Then
            Sql = "select Lot_Srno,Lot_Prefix,Lot_No from Pouch_Label where Lot_Prefix = '" & cmbLotPrefix.Text & "' and Lot_No  between  '" & cmbLotNo.Text & "' and '" & ComboLotTo.Text & "'  and (Sterilization = '1') AND (Sterilization_After = '0') AND (BPL_Taken = '0') AND (Sample_Taken = '0') AND (Sterilization_Reject = '0') AND (Box_Packing = '0') AND    (Dc_No IS NULL) AND (BPL_NO IS NULL) AND (Box_Reject = '0') AND (Dc_Packing = '0') AND PouchPack_to_Sterile_Move_status =1  order by Lot_srno"
        End If
        cmd = New SqlCommand(Sql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)

        ' table.Rows.Clear()

        For i = 0 To ds.Tables(0).Rows.Count - 1
            table.Rows.Add(ds.Tables(0).Rows(i)("Lot_Srno").ToString(), ds.Tables(0).Rows(i)("Lot_Prefix").ToString(), ds.Tables(0).Rows(i)("Lot_No").ToString())
        Next

        GRID2.DataSource = table
        lblcount.Text = table.Rows.Count.ToString()


    End Sub
    Private Function getDistinctBatchNo() As DataSet
        Dim ds As New DataSet()

        Sql = "select DISTINCT Btc_No from Pouch_Label where Lot_Prefix = '" & cmbLotPrefix.Text & "' and Lot_No  between  '" & cmbLotNo.Text & "' and '" & ComboLotTo.Text & "'  and (Sterilization = '1') AND (Sterilization_After = '0') AND (BPL_Taken = '0') AND (Sample_Taken = '0') AND (Sterilization_Reject = '0') AND (Box_Packing = '0') AND    (Dc_No IS NULL) AND (BPL_NO IS NULL) AND (Box_Reject = '0') AND (Dc_Packing = '0') AND PouchPack_to_Sterile_Move_status =1 "

        cmd = New SqlCommand(Sql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Try

            SterilizationlistBind()
            If RdoASt.Checked = True Then
                Dim dsDistinctBatch As New DataSet()
                dsDistinctBatch = getDistinctBatchNo()
                If dsDistinctBatch.Tables(0).Rows.Count > 1 Then
                    MsgBox("Multiple Batch present, Please Check", MsgBoxStyle.Information)
                    Exit Sub
                ElseIf dsDistinctBatch.Tables(0).Rows.Count < 1 Then
                    MsgBox("Batch not Updated, Please Check", MsgBoxStyle.Information)
                    Exit Sub
                Else
                    txtbtno.Text = dsDistinctBatch.Tables(0).Rows(0)("Btc_No")
                End If
            End If

            ' For user do not change Lot number after click add button.
            btnAdd.Visible = False
            cmbLotNo.Enabled = False
            ComboLotTo.Enabled = False
            cmbLotPrefix.Enabled = False



        Catch ex As Exception

            MsgBox("An unexpected error occurred.")
            Exit Sub

        End Try
        

    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        clear()
    End Sub


    Private Sub typeBind()
        CmbStType.DataSource = Nothing
        Dim ds As New DataSet()

        If RdoASt.Checked Then
            Sql = "select distinct Type from Sterilization_Machine_Master  "
        End If
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

        If RdoASt.Checked Then
            Sql = "select distinct Machine_Id from Sterilization_Machine_Master Where Type=  '" & CmbStType.Text & "' "
        End If
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

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click

        OpenFileDialog1.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.pdf;*.tiff"
        OpenFileDialog1.Title = "Select an Image File"
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
        End If

    End Sub
End Class