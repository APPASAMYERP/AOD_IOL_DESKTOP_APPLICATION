
Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft
Imports System.Data.Sql
Imports System.Configuration

Public Class FrmNewStockValidation

    Dim strsql As String
    Dim strrs As SqlDataReader
    Dim cmd As SqlCommand
    Dim IntTotExp As Integer
    Dim StrMfDMonth, StrMfDYear, StrExpmonth, StrExpYear As String
    Dim table As New DataTable
    Dim Ds As New DataSet
    Dim dcNo As String
    Private prevModel, prevPower, prevLotPrefix, prevLotNo, prevLotOrUDISerial As String



    Public Sub PouchLabelUpdateorInsert(ByVal strQuery As String)

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

    Private Sub txtstartqty_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtstartqty.KeyDown

        Dim getserialno As String

        If (e.KeyCode = Keys.Enter) Then

            

            getserialno = txtstartqty.Text


            If txtRackLocation.Text = "" Then
                err.SetError(txtRackLocation, "This information is required")
                txtRackLocation.Focus()
                Exit Sub
            Else
                err.SetError(txtRackLocation, "")
            End If

            If txtTrayNo.Text = "" Then
                err.SetError(txtTrayNo, "This information is required")
                txtTrayNo.Focus()
                Exit Sub
            Else
                err.SetError(txtTrayNo, "")
            End If

            If CmbShPower.Text = "" Then
                err.SetError(CmbShPower, "This information is required")
                CmbShPower.Focus()
                Exit Sub
            Else
                err.SetError(CmbShPower, "")
            End If


            ' lot Sreial
            If rdLotSerial.Checked = True Then

                'mfd validation
                Dim preMfd As String = ""
                Dim mfd_year As String = ""
                preMfd = txtlotprefix.Text.Substring(txtlotprefix.Text.Length - 4)

                If preMfd.Substring(0, 2) = "20" Then
                    mfd_year = "2020"
                ElseIf preMfd.Substring(0, 2) = "21" Then
                    mfd_year = "2021"
                ElseIf preMfd.Substring(0, 2) = "22" Then
                    mfd_year = "2022"
                ElseIf preMfd.Substring(0, 2) = "23" Then
                    mfd_year = "2023"
                Else
                    MessageBox.Show("Mfd Not Found", "Stock Verify Validation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                If preMfd.Substring(preMfd.Length - 2) & "-" & mfd_year <> LblShowMfdDate.Text Then
                    MessageBox.Show("Selected Mfd and Scaned Mfd Missmatch", "Stock Verify Validation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                '----------------



                Dim St_srno As String = getserialno.Split(" ")(1)

                ' Validations--------------------------------------------------
                If LblShowGSCode.Text = "" Then
                    err.SetError(LblShowGSCode, "This information is required")
                    LblShowGSCode.Focus()
                    Exit Sub
                Else
                    err.SetError(LblShowGSCode, "")
                End If

                If LblShowPower.Text = "" Then
                    err.SetError(LblShowPower, "This information is required")
                    LblShowPower.Focus()
                    Exit Sub
                Else
                    err.SetError(LblShowPower, "")
                End If

                If LblShowRefName.Text = "" Then
                    err.SetError(LblShowRefName, "This information is required")
                    LblShowRefName.Focus()
                    Exit Sub
                Else
                    err.SetError(LblShowRefName, "")
                End If

                If LblShowOptic.Text = "" Then
                    err.SetError(LblShowOptic, "This information is required")
                    LblShowOptic.Focus()
                    Exit Sub
                Else
                    err.SetError(LblShowOptic, "")
                End If
                If LblShowLength.Text = "" Then
                    err.SetError(LblShowLength, "This information is required")
                    LblShowLength.Focus()
                    Exit Sub
                Else
                    err.SetError(LblShowLength, "")
                End If

                If LblShowGSType.Text = "" Then
                    err.SetError(LblShowGSType, "This information is required")
                    LblShowGSType.Focus()
                    Exit Sub
                Else
                    err.SetError(LblShowGSType, "")
                End If

                If LblshAConstant.Text = "" Then
                    err.SetError(LblshAConstant, "This information is required")
                    LblshAConstant.Focus()
                    Exit Sub
                Else
                    err.SetError(LblshAConstant, "")
                End If

                If txtlotprefix.Text <> "" And txtlotno.Text <> "" Then
                    Dim str As String = getserialno.Split(" ")(0)
                    If txtlotprefix.Text & txtlotno.Text <> str Then
                        MessageBox.Show("Serial No. not matching with the Prefix and LotNo!!!", "Stock Verify Validation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                Else
                    MessageBox.Show("Enter the Prefix and LotNo before scanning", "Stock Verify Validation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                '---------------------------------------------------------------------------

                If getserialno <> "" Then


                    Dim ds As New DataSet
                    strsql = "select * from Pouch_label where Lot_SrNo = '" & getserialno & "'   "
                    Dim cmd As New SqlCommand(strsql, con)
                    Dim ad As New SqlDataAdapter(cmd)
                    ad.Fill(ds)

                    If ds.Tables(0).Rows.Count > 1 Then
                        PictureBox1.Image = Image.FromFile(Application.StartupPath & "\red-button-png-5.png")
                        MessageBox.Show("Serial Number Multiple Time Present, Contact ERP Team.!!!", "Stock Verify Validation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtstartqty.Text = ""
                        txtstartqty.Focus()
                        Exit Sub
                    ElseIf ds.Tables(0).Rows.Count = 1 Then

                        If Format(Val(ds.Tables(0).Rows(0)("Power")), "0.00") = LblShowPower.Text And ds.Tables(0).Rows(0)("Model_Name").ToString() = CmbShModel.Text And Format(Val(ds.Tables(0).Rows(0)("Mfd_Month")), "00") & "-" & Format(Val(ds.Tables(0).Rows(0)("Mfd_Year")), "0000") = LblShowMfdDate.Text And Format(Val(ds.Tables(0).Rows(0)("Exp_Month")), "00") & "-" & Format(Val(ds.Tables(0).Rows(0)("Exp_Year")), "0000") = LblShowExpDate.Text Then
                            strsql = "UPDATE    POUCH_LABEL " & _
                                    "SET              Sterilization_After = '1', Sterilization_Reject = '0', Sample_Taken = '0', BPL_Taken = '0', Dc_No = NULL, Dc_Packing = '1', Sterilization = '1', Type_Sample = 'NO', " & _
                                    "BPL_NO = NULL, Sterility_Status ='1', Inward_No ='1807', Tray_No ='" & txtTrayNo.Text & "', Rack_Location='" & txtRackLocation.Text & "' , Inward_No1 ='" & StrLoginUser & "' " & _
                                    " where Lot_SrNo = '" & getserialno & "' "
                            PouchLabelUpdateorInsert(strsql)
                            ColorCode(getserialno)
                            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\123.png")


                        Else
                            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\red-button-png-5.png")
                            MessageBox.Show(" Model,Power,Mfd or Exp Mismatch, Contact ERP Team.!!!", "Stock Verify Validation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtstartqty.Text = ""
                            txtstartqty.Focus()
                            Exit Sub

                        End If

                    Else
                        ' Data Creation
                        Dim result As DialogResult = MessageBox.Show("Serial Number missing. Are you sure you want to Create Serial Number?", "caption", MessageBoxButtons.YesNoCancel)
                        If result = DialogResult.Cancel Then

                        ElseIf result = DialogResult.No Then

                        ElseIf result = DialogResult.Yes Then
                            strsql = " insert into POUCH_LABEL (Brand_Name,Model_Name,Reference_Name,GS_Code,Power,Optic,Length,Lot_Unit," & _
                                                 "A_Constant,Type_GS_Code,St_SrNo,St_EnNo,Lot_Prefix,Lot_No,Lot_SrNo,Mfd_Month,Mfd_Year,Exp_Month,Exp_Year,Sterilization," & _
                                                 "Sample_Taken,Type_Sample,BPL_Taken,Box_Packing,Dc_Packing,Created_By,Created_Date,Modified_By,Modified_Date,Sterilization_Reject,Qty_1,Sterilization_After,Box_Reject,Print_Name, Inward_No, Tray_No, Rack_Location, Btc_No, Inward_No1 ) values ( " & _
                                                 "'" & LblShowRefName.Text & "','" & CmbShModel.Text & "','" & LblShowRefName.Text & "','" & LblShowGSCode.Text & "','" & CmbShPower.Text & "','" & LblShowOptic.Text & "','" & LblShowLength.Text & "' ," & _
                                                 "'mm','" & LblshAConstant.Text & "','AOD','" & St_srno & "','200','" & txtlotprefix.Text & "','" & txtlotno.Text & "','" & txtstartqty.Text & "' , " & _
                                                 "'" & StrMfDMonth & "','" & StrMfDYear & "','" & StrExpmonth & "','" & StrExpYear & "',1,0,'NO',0,0,1,'" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),0,1,1,0,'" & LblShowRefName.Text & "','1807', '" & txtTrayNo.Text & "', '" & txtRackLocation.Text & "', 'STOCK-SEP', '" & StrLoginUser & "' )"
                            PouchLabelUpdateorInsert(strsql)
                            ColorCode(getserialno)
                            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\123.png")

                        End If


                    End If


                Else
                    MsgBox(" Scan Correct Lot No")
                    Exit Sub
                End If



                'UDI SERIAl

            ElseIf rdUDICode.Checked = True Then

                If getserialno <> "" Then


                    Dim ds As New DataSet
                    strsql = "select * from Pouch_label where Udi_Code = '" & getserialno & "'   "
                    Dim cmd As New SqlCommand(strsql, con)
                    Dim ad As New SqlDataAdapter(cmd)
                    ad.Fill(ds)

                    If ds.Tables(0).Rows.Count > 1 Then
                        PictureBox1.Image = Image.FromFile(Application.StartupPath & "\red-button-png-5.png")
                        MessageBox.Show("Serial Number Multiple Time Present, Contact ERP Team.!!!", "Stock Verify Validation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtstartqty.Text = ""
                        txtstartqty.Focus()
                        Exit Sub
                    ElseIf ds.Tables(0).Rows.Count = 1 Then

                        If ds.Tables(0).Rows(0)("Lot_SrNo").StartsWith(txtlotprefix.Text & txtlotno.Text) Then
                        Else
                            MessageBox.Show("Serial No. not matching with the Prefix and LotNo!!!", "Stock Verify Validation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If


                        strsql = "UPDATE    POUCH_LABEL " & _
                                    "SET              Sterilization_After = '1', Sterilization_Reject = '0', Sample_Taken = '0', BPL_Taken = '0', Dc_No = NULL, Dc_Packing = '1', Sterilization = '1', Type_Sample = 'NO', " & _
                                    "BPL_NO = NULL, Sterility_Status ='1', Inward_No ='1807' , Tray_No ='" & txtTrayNo.Text & "', Rack_Location='" & txtRackLocation.Text & "', Inward_No1 ='" & StrLoginUser & "' " & _
                                   " where Udi_code = '" & getserialno & "' "
                        PouchLabelUpdateorInsert(strsql)
                        ColorCode(ds.Tables(0).Rows(0)("Lot_SrNo").ToString())
                        PictureBox1.Image = Image.FromFile(Application.StartupPath & "\123.png")

                    Else
                        PictureBox1.Image = Image.FromFile(Application.StartupPath & "\red-button-png-5.png")
                        MessageBox.Show(" Serial Number Not Found, Contact ERP Team.!!!", "Stock Verify Validation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtstartqty.Text = ""
                        txtstartqty.Focus()
                        Exit Sub

                    End If


                Else
                    MsgBox(" Scan Correct Lot No")
                    Exit Sub
                End If

            Else
                MessageBox.Show("Please Select 'Lot Serial' Or 'UDI Serial'")
                Exit Sub
            End If


            txtstartqty.Text = ""
            txtstartqty.Focus()

        End If

    End Sub

    Private Sub CmbShPower_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbShPower.SelectedIndexChanged

        If CmbShModel.Text = "" Then
            err.SetError(CmbShModel, "This information is required")
            CmbShModel.Focus()
            Exit Sub
        Else
            err.SetError(CmbShModel, "")
        End If

        If CmbShPower.Text <> "" Then
            If CmbShPower.Text <> prevPower Then
                For i As Integer = 0 To GRID2.Rows.Count - 2
                    If Me.GRID2.Rows(i).Cells("Lot_SrNo").Style.BackColor = Color.LightGreen Then
                        CmbShPower.Text = prevPower
                        MessageBox.Show("You Cannot change the Power, Please click Complete Button")
                        Exit Sub
                    End If
                Next
            End If
            

            If con.State = Data.ConnectionState.Open Then
                con.Close()
            End If

            Try
                con.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            If productline = "PMMA" Then
                strsql = "SELECT * from LENS_MASTER1 where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "'  "
            Else
                strsql = "SELECT * from LENS_MASTER where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' "
            End If
            cmd = New SqlCommand(strsql, con)
            strrs = cmd.ExecuteReader

            If strrs.Read Then

                LblShowGSCode.Text = IIf(IsDBNull(strrs.GetValue(5)), "", strrs.GetValue(5))
                LblShowPower.Text = Format(IIf(IsDBNull(strrs.GetValue(6)), 0, strrs.GetValue(6)), "0.00")
                LblShowRefName.Text = IIf(IsDBNull(strrs.GetValue(4)), "", strrs.GetValue(4))
                LblShowOptic.Text = Format(IIf(IsDBNull(strrs.GetValue(7)), "", strrs.GetValue(7)), "0.00")
                LblShowLength.Text = Format(IIf(IsDBNull(strrs.GetValue(8)), "", strrs.GetValue(8)), "0.00")
                LblShowGSType.Text = IIf(IsDBNull(strrs.GetValue(11)), "", strrs.GetValue(11))
                LblshAConstant.Text = Format(IIf(IsDBNull(strrs.GetValue(10)), 0, strrs.GetValue(10)), "0.00")
                IntTotExp = IIf(IsDBNull(strrs.GetValue(12)), 0, strrs.GetValue(12))

                If productline = "PHILIC" Then
                    If rbExport.Checked = True Then
                        IntTotExp = 3
                    End If
                End If

                StrMfDMonth = dtpMFDDate.Value.Month
                StrMfDYear = dtpMFDDate.Value.Year

                Dim strprefix, strmdl As String

                strmdl = CmbShModel.Text

                strprefix = txtlotprefix.Text

                StrMfDMonth = Format(dtpMFDDate.Value.Month, "00")
                StrMfDYear = Format(dtpMFDDate.Value.Year, "0000")

                StrExpmonth = Format(StrMfDMonth - 1, "00")
                StrExpYear = Format(StrMfDYear + IntTotExp, "0000")


                If StrExpmonth = 0 Then
                    StrExpmonth = Format(12, "00")
                    StrExpYear = Format(StrExpYear - 1, "0000")
                End If

                LblShowMfdDate.Text = StrMfDMonth & "-" & StrMfDYear
                LblShowExpDate.Text = StrExpmonth & "-" & StrExpYear


            End If
            strrs.Close()
            cmd.Dispose()

            Ds = LotPrefixBind()
            txtlotprefix.Items.Clear()
            For Each eachRow As DataRow In Ds.Tables(0).Rows
                txtlotprefix.Items.Add(eachRow("Lot_Prefix"))
            Next

            prevPower = CmbShPower.Text
            txtlotprefix.Text = ""
            txtlotno.Text = ""
            txtlotprefix.Focus()
        End If

    End Sub

    Public Function LotPrefixBind() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = "SELECT DISTINCT Lot_Prefix from POUCH_LABEL " & _
        "WHERE     (Sterilization_After = '1') AND (Sterilization_Reject = '0') AND (Sample_Taken = '0') AND (BPL_Taken = '0') AND (Dc_No IS NULL) AND (Sterilization = '1') AND " & _
        "(Dc_Packing = '0') AND (Model_Name = '" & CmbShModel.Text & "')   AND (Power = '" & CmbShPower.Text & "') OR " & _
        "(Sterilization_After = '1') AND (Sterilization_Reject = '0') AND (Sample_Taken = '0') AND (BPL_Taken = '0') AND (Dc_No = '" & dcNo & "') AND (Sterilization = '1') AND " & _
        "(Model_Name = '" & CmbShModel.Text & "') AND (Power = '" & CmbShPower.Text & "') order by  Lot_Prefix"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Public Function RackLocationBind() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = "SELECT DISTINCT RackId from Rack_Master   order by RackId"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Private Sub FrmNewStockValidation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If productline = "PHOBIC" Then

            dcNo = "DC/S/9013"
        ElseIf productline = "PHILIC" Then
            dcNo = "DC/D/1253"
        ElseIf productline = "PMMA" Then
            dcNo = "DC/H/11607"
        ElseIf productline = "PHOBIC NONPRELOADED" Then
            dcNo = "DC/S/400"
        End If


        Ds = RackLocationBind()
        txtRackLocation.Items.Clear()
        For Each eachRow As DataRow In Ds.Tables(0).Rows
            txtRackLocation.Items.Add(eachRow("RackId"))
        Next



        dtpMFDDate.Value = System.DateTime.Today

        'table.Columns.Add("Lot_SrNo", GetType(String))
        'GRID2.DataSource = table
        'With GRID2.ColumnHeadersDefaultCellStyle
        '    .Alignment = DataGridViewContentAlignment.TopRight
        '    .BackColor = Color.DarkRed
        '    .ForeColor = Color.Gold
        '    .Font = New Font(.Font.FontFamily, .Font.Size, _
        '     .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        'End With


        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If

        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        If productline = "PMMA" Then
            strsql = "SELECT DISTINCT Model_Name from LENS_MASTER1 order by Model_Name"
        Else
            strsql = "SELECT DISTINCT Model_Name from LENS_MASTER order by Model_Name"
        End If
        cmd = New SqlCommand(strsql, con)
        strrs = cmd.ExecuteReader
        CmbShModel.Items.Clear()
        While strrs.Read
            CmbShModel.Items.Add(IIf(IsDBNull(strrs.GetValue(0)), "", strrs.GetValue(0)))
        End While
        strrs.Close()
        cmd.Dispose()

        LblShowGSCode.Text = ""
        LblShowPower.Text = ""
        LblShowRefName.Text = ""
        LblShowOptic.Text = ""
        LblShowLength.Text = ""
        LblShowGSType.Text = ""
        LblshAConstant.Text = ""

    End Sub

    Private Sub CmbShModel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbShModel.SelectedIndexChanged, txtRackLocation.SelectedIndexChanged

        If CmbShModel.Text <> "" Then
            If CmbShModel.Text <> prevModel Then
                For i As Integer = 0 To GRID2.Rows.Count - 2
                    If Me.GRID2.Rows(i).Cells("Lot_SrNo").Style.BackColor = Color.LightGreen Then
                        CmbShModel.Text = prevModel
                        MessageBox.Show("You Cannot change the Model Name, Please click Complete Button")
                        Exit Sub
                    End If
                Next
            End If
            

            If con.State = Data.ConnectionState.Open Then
                con.Close()
            End If

            Try
                con.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            If productline = "PMMA" Then
                strsql = "SELECT DISTINCT POWER from LENS_MASTER1 where Model_Name='" & CmbShModel.Text & "' order by POWER"
            Else
                strsql = "SELECT DISTINCT POWER from LENS_MASTER where Model_Name='" & CmbShModel.Text & "' order by POWER"
            End If
            cmd = New SqlCommand(strsql, con)
            strrs = cmd.ExecuteReader

            CmbShPower.Items.Clear()


            CmbShPower.Text = ""
            txtlotprefix.Text = ""
            txtlotno.Text = ""
            LblShowGSCode.Text = ""
            LblShowPower.Text = ""
            LblShowRefName.Text = ""
            LblShowOptic.Text = ""
            LblShowLength.Text = ""
            LblShowGSType.Text = ""
            LblshAConstant.Text = ""

            While strrs.Read
                CmbShPower.Items.Add(Format(IIf(IsDBNull(strrs.GetValue(0)), "", strrs.GetValue(0)), "0.00"))
            End While
            strrs.Close()
            cmd.Dispose()
            prevModel = CmbShModel.Text
        End If

    End Sub

    Private Sub rdUDICode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdUDICode.CheckedChanged

        For i As Integer = 0 To GRID2.Rows.Count - 2
            If Me.GRID2.Rows(i).Cells("Lot_SrNo").Style.BackColor = Color.LightGreen Then
                MessageBox.Show("You Cannot change the UDI Serial or Lot Serial, Please click Complete Button")
                Exit Sub
            End If
        Next

        If rdUDICode.Checked = True Then
            GroupBox3.Visible = False
            GroupBox6.Visible = False
        Else
            GroupBox3.Visible = True
            GroupBox6.Visible = True
        End If



    End Sub

    Private Sub rdLotSerial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdLotSerial.CheckedChanged

        'If rdUDICode.Checked = True Then
        '    GroupBox3.Visible = False
        '    GroupBox4.Visible = False
        '    GroupBox6.Visible = False
        'Else
        '    GroupBox3.Visible = True
        '    GroupBox4.Visible = True
        '    GroupBox6.Visible = True
        'End If
    End Sub

    Private Sub rbExport_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbExport.CheckedChanged
        LblShowGSCode.Text = ""
        LblShowPower.Text = ""
        LblShowRefName.Text = ""
        LblShowOptic.Text = ""
        LblShowLength.Text = ""
        LblShowGSType.Text = ""
        LblshAConstant.Text = ""
    End Sub

    Private Sub rbLocal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbLocal.CheckedChanged
        LblShowGSCode.Text = ""
        LblShowPower.Text = ""
        LblShowRefName.Text = ""
        LblShowOptic.Text = ""
        LblShowLength.Text = ""
        LblShowGSType.Text = ""
        LblshAConstant.Text = ""
    End Sub

    Public Function LotNumberBind() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = "SELECT DISTINCT Lot_No from POUCH_LABEL " & _
        "WHERE     (Sterilization_After = '1') AND (Sterilization_Reject = '0') AND (Sample_Taken = '0') AND (BPL_Taken = '0') AND (Dc_No IS NULL) AND (Sterilization = '1') AND " & _
        "(Dc_Packing = '0') AND (Model_Name = '" & CmbShModel.Text & "')   AND (Power = '" & CmbShPower.Text & "') AND (Lot_Prefix = '" & txtlotprefix.Text & "') OR " & _
        "(Sterilization_After = '1') AND (Sterilization_Reject = '0') AND (Sample_Taken = '0') AND (BPL_Taken = '0') AND (Dc_No = '" & dcNo & "') AND (Sterilization = '1') AND " & _
        "(Model_Name = '" & CmbShModel.Text & "') AND (Power = '" & CmbShPower.Text & "')AND (Lot_Prefix = '" & txtlotprefix.Text & "')   order by  Lot_No"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Private Sub txtlotprefix_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlotprefix.SelectedIndexChanged

        If txtlotprefix.Text <> "" Then
            If txtlotprefix.Text <> prevLotPrefix Then
                For i As Integer = 0 To GRID2.Rows.Count - 2
                    If Me.GRID2.Rows(i).Cells("Lot_SrNo").Style.BackColor = Color.LightGreen Then
                        txtlotprefix.Text = prevLotPrefix
                        MessageBox.Show("You Cannot change the Lot Number, Please click Complete Button")
                        Exit Sub
                    End If
                Next
            End If
            

            'If GRID2.Rows.Count > 1 Then
            '    MessageBox.Show("You Cannot change the Lot Prefix, Please click Complete Button")
            '    Exit Sub
            'End If

            If CmbShPower.Text = "" Then
                err.SetError(CmbShPower, "This information is required")
                CmbShPower.Focus()
                Exit Sub
            Else
                err.SetError(CmbShPower, "")
            End If

            Ds = LotNumberBind()
            txtlotno.Items.Clear()
            For Each eachRow As DataRow In Ds.Tables(0).Rows
                txtlotno.Items.Add(eachRow("Lot_No"))
            Next
            prevLotPrefix = txtlotprefix.Text
            txtlotno.Text = ""
            txtlotno.Focus()
        End If

        

    End Sub

    Public Function getLotSerialNumber() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = "SELECT DISTINCT Lot_SrNo, Inward_No from POUCH_LABEL " & _
        "WHERE     (Sterilization_After = '1') AND (Sterilization_Reject = '0') AND (Sample_Taken = '0') AND (BPL_Taken = '0') AND (Dc_No IS NULL) AND (Sterilization = '1') AND " & _
        "(Dc_Packing = '0') AND (Model_Name = '" & CmbShModel.Text & "')   AND (Power = '" & CmbShPower.Text & "') AND (Lot_Prefix = '" & txtlotprefix.Text & "') AND (Lot_No = '" & txtlotno.Text & "') OR " & _
        "(Sterilization_After = '1') AND (Sterilization_Reject = '0') AND (Sample_Taken = '0') AND (BPL_Taken = '0') AND (Dc_No = '" & dcNo & "') AND (Sterilization = '1') AND " & _
        "(Model_Name = '" & CmbShModel.Text & "') AND (Power = '" & CmbShPower.Text & "')AND (Lot_Prefix = '" & txtlotprefix.Text & "')  AND (Lot_No = '" & txtlotno.Text & "')  OR  " & _
        " (Sterilization_After = '1') AND (Sterilization_Reject = '0') AND (Sample_Taken = '0') AND (BPL_Taken = '0') AND (Dc_No IS NULL) AND (Sterilization = '1') AND  " & _
        "(Dc_Packing = '1') AND (Model_Name = '" & CmbShModel.Text & "')   AND (Power = '" & CmbShPower.Text & "') AND (Lot_Prefix = '" & txtlotprefix.Text & "') AND (Lot_No = '" & txtlotno.Text & "') and inward_no='1807' " & _
        " order by  Lot_SrNo"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Private Sub txtlotno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlotno.SelectedIndexChanged
        If txtlotno.Text <> "" Then
            If txtlotno.Text <> prevLotNo Then
                For i As Integer = 0 To GRID2.Rows.Count - 2
                    If Me.GRID2.Rows(i).Cells("Lot_SrNo").Style.BackColor = Color.LightGreen Then
                        txtlotno.Text = prevLotNo
                        MessageBox.Show("You Cannot change the Lot Number, Please click Complete Button")
                        Exit Sub
                    End If
                Next

            End If

            
            'If GRID2.Rows.Count > 1 Then
            '    MessageBox.Show("You Cannot change the Lot Number, Please click Complete Button")
            '    Exit Sub
            'End If

            Ds = getLotSerialNumber()

            GRID2.Rows.Clear()
            For Each eachRow As DataRow In Ds.Tables(0).Rows
                GRID2.Rows.Add(eachRow("Lot_SrNo"), eachRow("Inward_No"))
            Next
            'GRID2.DataSource = table
            prevLotNo = txtlotno.Text
            lblcount.Text = GRID2.Rows.Count - 1
            ColorCode_SerialLoad()
            txtstartqty.Focus()
            GRID2.ClearSelection()

        End If
    End Sub

    Private Sub ColorCode_SerialLoad()
        Dim scanedCount As Integer = 0

        For i As Integer = 0 To GRID2.Rows.Count - 2
            If Not IsDBNull(Me.GRID2.Rows(i).Cells("Inward_No").Value) Then
                If Me.GRID2.Rows(i).Cells("Inward_No").Value = "1807" Then
                    Me.GRID2.Rows(i).Cells("Lot_SrNo").Style.BackColor = Color.LightGreen
                    scanedCount = scanedCount + 1
                End If
            End If
        Next
        lblScanedCount.Text = scanedCount
    End Sub

    Private Sub ColorCode(ByVal StrLotSr As String)

        Dim LotPresent As Boolean = False
        For i As Integer = 0 To GRID2.Rows.Count - 2
            If Me.GRID2.Rows(i).Cells("Lot_SrNo").Value = StrLotSr Then
                'Me.GRID2.Rows(i).Cells("Lot_SrNo").Style.BackColor = Color.LightGreen
                Me.GRID2.Rows(i).Cells("Inward_No").Value = "1807"
                ColorCode_SerialLoad()
                LotPresent = True
                Exit For
            End If
        Next

        If LotPresent = False Then
            GRID2.Rows.Add(StrLotSr, "1807")
            ColorCode_SerialLoad()
            'For i As Integer = 0 To GRID2.Rows.Count - 2
            '    If Me.GRID2.Rows(i).Cells("Lot_SrNo").Value = StrLotSr Then
            '        Me.GRID2.Rows(i).Cells("Lot_SrNo").Style.BackColor = Color.LightGreen
            '        LotPresent = True
            '        Exit For
            '    End If
            'Next
            lblcount.Text = GRID2.Rows.Count - 1
        End If
    End Sub

    Private Sub BtnComplete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnComplete.Click
        Dim GreenCount As Integer = 0
        Dim notStockSerials As String = ""
        For i As Integer = 0 To GRID2.Rows.Count - 2
            If Me.GRID2.Rows(i).Cells("Lot_SrNo").Style.BackColor = Color.LightGreen Then
                GreenCount = GreenCount + 1
            Else
                notStockSerials = notStockSerials + "'" + Me.GRID2.Rows(i).Cells("Lot_SrNo").Value.ToString() + "',"
            End If
        Next

        If GRID2.Rows.Count - 1 = GreenCount Then
            ' INSERT COMPLETED LOT DETAILS
            strsql = "Insert into  Stock_verification_Completed_Lots (Model_Name, Power, Lot_Prefix, Lot_No, Qty, Created_By, Created_Date) VALUES ('" & CmbShModel.Text & "','" & CmbShPower.Text & "','" & txtlotprefix.Text & "','" & txtlotno.Text & "','" & GreenCount & "','" & StrLoginUser & "',GETDATE())"
            PouchLabelUpdateorInsert(strsql)


            GRID2.Rows.Clear()
            lblcount.Text = GRID2.Rows.Count - 1
            txtlotprefix.Text = ""
            txtlotno.Text = ""

        Else
            If notStockSerials <> "" Then
                notStockSerials = notStockSerials.Remove(notStockSerials.Length - 1, 1)
            End If

            Dim result As DialogResult = MessageBox.Show((GRID2.Rows.Count - 1 - GreenCount).ToString() & " Serial Number Not Scan. Are you sure you want to Remove the Serial Numbers from Stock?", "caption", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then

            ElseIf result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                ' INSERT COMPLETED LOT DETAILS
                strsql = "Insert into  Stock_verification_Completed_Lots (Model_Name, Power, Lot_Prefix, Lot_No, Qty, Created_By, Created_Date) VALUES ('" & CmbShModel.Text & "','" & CmbShPower.Text & "','" & txtlotprefix.Text & "','" & txtlotno.Text & "','" & GreenCount & "','" & StrLoginUser & "',GETDATE())"
                PouchLabelUpdateorInsert(strsql)

                GRID2.Rows.Clear()
                lblcount.Text = GRID2.Rows.Count - 1
                txtlotprefix.Text = ""
                txtlotno.Text = ""
                strsql = "UPDATE    POUCH_LABEL " & _
                                    "SET             Dc_No = 'DC/1807', Dc_Packing = '1' , Inward_No1 ='" & StrLoginUser & "' " & _
                                   " where Lot_SrNo in(" & notStockSerials & " )"
                PouchLabelUpdateorInsert(strsql)
            End If
        End If
    End Sub

    Private Sub dtpMFDDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpMFDDate.ValueChanged
        CmbShPower.Text = ""
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
        Menulblmstdatacre.LblHomeMenuDisplyName.Visible = False
        Menulblmstdatacre.TimHomeSideDisply.Start()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        GRID2.Rows.Clear()
        lblcount.Text = GRID2.Rows.Count - 1
        txtlotprefix.Text = ""
        txtlotno.Text = ""
    End Sub
End Class