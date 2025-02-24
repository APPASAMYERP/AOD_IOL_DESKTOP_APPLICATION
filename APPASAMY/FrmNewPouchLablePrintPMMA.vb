Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft
Imports System.Data.Sql
Imports System.Configuration

Public Class FrmNewPouchLablePrintPMMA
    Dim Ds As New DataSet
    Dim bApp As New BarTender.Application
    Dim bt As New BarTender.Format
    Dim btFile As String
    Dim bApp1 As New BarTender.Application
    Dim bt1 As New BarTender.Format
    Dim btFile1 As String
    Dim strpwradd As String
    Dim readdetail As SqlDataReader
    Dim Str_Header As Integer
    Dim Str_Detail As Integer
    Dim Str_Lotno, Slno As Integer
    Dim StrSqlSel1 As String
    Dim StrRsSel1 As SqlDataReader
    Dim StrSqlSeDt As String
    Dim StrRsSeDt As SqlDataReader
    Dim StrSqlSeHd As String
    Dim StrRsSeHd As SqlDataReader
    Dim IntBoxPAck As Integer
    Dim StrAConst As String
    Dim StrRefName As String
    Dim StrInExpyr As String
    Dim StrInExpm As String
    Dim StrInExp As String
    Dim GS_Type As String
    Dim StrLotSu As String
    Dim Strsize As String
    Dim StrInexp1 As String
    Dim StrInyear As String
    Dim strsql As String
    Dim StrRs As SqlDataReader
    Dim cmd As SqlCommand
    Dim strfilename As String
    Dim StrOnlyLot As String
    Dim strtype As String
    Dim strbdname As String
    Dim strpfile As String
    Dim Strrpwr As String
    Dim strrefpwr As String
    Dim strrefname1 As String
    Dim StrMfdMonth As Integer
    Dim StrMfdYear As Integer
    Dim StrExpMonth As Integer
    Dim StrExpYear As Integer
    Dim IntTotExp As Integer
    Dim getdetail As String

    Dim strmfmonth As String
    Dim strmfyear As String
    Dim strexmonth As String
    Dim strexyear As String


    Dim strmonth1 As String
    Dim stryear1 As String
    Dim strpwr As String

    Dim stroptic As String
    Dim strlength As String


    Dim strexpsupdate As String

    Dim strmfdsupdate As String
    Dim cmd1 As SqlCommand
    Dim read1 As SqlDataReader
    Dim read As SqlDataReader
    Dim sql As String

    Dim StrSqlSe1 As String
    Dim StrRsSe1 As SqlDataReader
    Dim StrStSrNo, StrlotonlyNo As String
    Dim StrEnSrNo As String
    Dim StrMaxQty As Integer
    Dim StrPrtedQty As Integer
    Dim StrPrQty As Integer
    Dim StrBalQty As Integer

    Dim StrStPrQty As Integer
    Dim StrEnPrQty As Integer

    Dim StrSqlSePr, StroneDBar As String
    Dim StrRsSePr As SqlDataReader

    Dim StrLotPrefix As Integer
    Dim IntLotNo As Integer
    Dim StrLotSrNo As String
    Dim StrB As String
    Dim StrT As String
    Dim StrExDate As String
    Dim StrMfDate As String
    Dim StrPower As String
    Dim StrlotBarNo As String
    Dim Stroptic1 As String
    Dim Strlength1 As String
    Dim StrLot1 As String
    Dim StrSno1 As String
    Dim StrTo As Integer
    Dim StrRs1 As SqlDataReader
    Dim StrInmfd As String
    Dim sql1 As String
    Private Sub LabelNameBind()
        Dim ds As New DataSet()
        strsql = "select distinct LabelName from BTW_Master where Department = 'POUCH' "
        Dim cmd As New SqlCommand(strsql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)

        cmbPrintLabel.DisplayMember = "LabelName"
        cmbPrintLabel.DataSource = ds.Tables(0)


    End Sub
    Private Sub FrmNewPouchLablePrintPMMA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If

        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TextBox4.Text = 0

        LabelNameBind()


        Dim conString1 As String = ConfigurationSettings.AppSettings("conStrPMMA_ERP").ToString()
        Dim con1 As SqlConnection
        con1 = New SqlConnection(conString1)
        Try
            con1.Open()
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        strsql = ("SELECT  distinct GlassyLotNo from PMMAPowerSegregationChild where  Flag<>2")
        cmd = New SqlCommand(strsql, con1)
        StrRs = cmd.ExecuteReader
        ComboBox1.Items.Clear()
        While StrRs.Read
            ComboBox1.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))

        End While
        StrRs.Close()
        cmd.Dispose()





        'StrSql = "SELECT DISTINCT Model_Name from LENS_MASTER order by Model_Name"
        'Cmd = New SqlCommand(StrSql, con)
        'StrRs = Cmd.ExecuteReader
        'CmbShModel.Items.Clear()
        'While StrRs.Read
        '    CmbShModel.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        'End While
        'StrRs.Close()
        'cmd.Dispose()



        strsql = "SELECT DISTINCT Type from Lot_Type order by Type"
        cmd = New SqlCommand(strsql, con)
        StrRs = cmd.ExecuteReader
        CmbType.Items.Clear()
        While StrRs.Read
            CmbType.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        cmd.Dispose()

        LblShowLotPrefix.Text = ""
        LblShowLotNo.Text = ""

        TextBox3.Text = 0

        lblShowMaxQty.Text = 0
        LblShowPrintedQty.Text = 0
        LblBalanceQty.Text = 0
        'Label18.Visible = False
        txtbtc.Visible = False


        LblShowGSCode.Text = ""
        LblShowPower.Text = ""
        LblShowRefName.Text = ""
        LblShowOptic.Text = ""
        LblShowLength.Text = ""
        LblShowGSType.Text = ""
        LblshAConstant.Text = ""
        txtrpwr.Visible = False
        txtcylsize.Visible = False
        lblrpwr.Visible = False
        lblcylsz.Visible = False

    End Sub

    Private Sub CmbShBrand_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


        If CmbShModel.Text = "SFE5" Or CmbShModel.Text = "SFC6" Or CmbShModel.Text = "SFC7" Or CmbShModel.Text = "SFAC6" Or CmbShModel.Text = "SFAC7" Or CmbShModel.Text = "HF01" Or CmbShModel.Text = "HF02" Or CmbShModel.Text = "HF03" Or CmbShModel.Text = "SCC6012" Or CmbShModel.Text = "CHY6013" Then


            CmbShType.Enabled = False
            strsql = "SELECT * from LENS_MASTER where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "'  and Brand_Name='" & CmbShBrand.Text & "' "
            cmd = New SqlCommand(strsql, con)
            StrRs = cmd.ExecuteReader

            If StrRs.Read Then

                LblShowGSCode.Text = IIf(IsDBNull(StrRs.GetValue(5)), "", StrRs.GetValue(5))
                LblShowPower.Text = Format(IIf(IsDBNull(StrRs.GetValue(6)), 0, StrRs.GetValue(6)), "0.00")
                LblShowRefName.Text = IIf(IsDBNull(StrRs.GetValue(4)), "", StrRs.GetValue(4))
                LblShowOptic.Text = Format(IIf(IsDBNull(StrRs.GetValue(7)), "", StrRs.GetValue(7)), "0.00")
                LblShowLength.Text = Format(IIf(IsDBNull(StrRs.GetValue(8)), "", StrRs.GetValue(8)), "0.00")
                LblShowGSType.Text = IIf(IsDBNull(StrRs.GetValue(11)), "", StrRs.GetValue(11))
                LblshAConstant.Text = Format(IIf(IsDBNull(StrRs.GetValue(10)), 0, StrRs.GetValue(10)), "0.00")
                IntTotExp = IIf(IsDBNull(StrRs.GetValue(12)), 0, StrRs.GetValue(12))

                StrMfdMonth = Now.Month
                strmfmonth = StrMfdMonth.ToString("00")

                StrMfdYear = Now.Year
                strmfyear = StrMfdYear.ToString("0000")

                StrExpMonth = StrMfdMonth - 1
                strexmonth = StrExpMonth.ToString("00")

                StrExpYear = StrMfdYear + IntTotExp
                strexyear = StrExpYear.ToString("0000")

                If StrExpMonth = 0 Then
                    strexmonth = (12).ToString("00")
                    strexyear = (StrExpYear - 1).ToString("0000")
                End If

                LblShowMfdDate.Text = strmfyear & "-" & strmfmonth
                LblShowExpDate.Text = strexyear & "-" & strexmonth

            Else
                MsgBox("No Data Found", MsgBoxStyle.Critical)
                Exit Sub
            End If
            StrRs.Close()
            cmd.Dispose()

        Else

            CmbShType.Enabled = True

            If CmbShBrand.Text <> "" Then
                strsql = "SELECT DISTINCT Type_GS_Code from LENS_MASTER where Brand_Name='" & CmbShBrand.Text & "' and Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' order by Type_GS_Code"
                cmd = New SqlCommand(strsql, con)
                StrRs = cmd.ExecuteReader
                CmbShType.Items.Clear()
                CmbShType.Text = ""
                While StrRs.Read
                    CmbShType.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
                End While
                StrRs.Close()
                cmd.Dispose()
            End If

        End If

    End Sub

    Private Sub CmbShModel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CmbShModel.Text <> "" Then
            strsql = "SELECT DISTINCT POWER from LENS_MASTER where Model_Name='" & CmbShModel.Text & "' order by POWER"
            cmd = New SqlCommand(strsql, con)
            StrRs = cmd.ExecuteReader

            'CmbShPower.Items.Clear()
            'CmbShBrand.Items.Clear()
            CmbShType.Items.Clear()

            CmbShPower.Text = ""
            CmbShBrand.Text = ""
            CmbShType.Text = ""

            txtcylsize.Text = "NULL"
            txtrpwr.Text = "NULL"

            While StrRs.Read
                ' CmbShPower.Items.Add(Format(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)), "0.00"))
            End While
            StrRs.Close()
            cmd.Dispose()

            If CmbShModel.Text = "SPMFDY200" Or CmbShModel.Text = "SPMFD200" Or CmbShModel.Text = "SUPRAPHOB MS" Then

                lblcylsz.Visible = True
                txtcylsize.Visible = True
            Else

                lblcylsz.Visible = False
                txtcylsize.Visible = False
            End If


        End If
    End Sub

    Private Function BTWFileName() As String
        Dim ds As New DataSet()
        strsql = "select * from BTW_Master where Department = 'POUCH' and ModelNo = '" & CmbShModel.Text & "' and LabelName = '" & cmbPrintLabel.Text & "' "
        Dim cmd As New SqlCommand(strsql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)
        If ds.Tables(0).Rows.Count <> 0 Then
            Return ds.Tables(0).Rows(0)("FileName")
        Else
            Return ""
        End If


    End Function

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        'sundar 08-05-2024-- Plan based report

        Try


            If cmb_Order_Type.SelectedItem Is Nothing Then
                err.SetError(cmb_Order_Type, "Please Select valid Order Type")
                cmb_Order_Type.Focus()
                Exit Sub
            Else
                err.SetError(cmb_Order_Type, "")
            End If

            If cmb_Order_Type.Text = "" Then
                err.SetError(cmb_Order_Type, "This information is required")
                Exit Sub
            Else
                err.SetError(cmb_Order_Type, "")
            End If

            If cmb_Order_Country.SelectedItem Is Nothing Then
                err.SetError(cmb_Order_Country, "Please Select valid Order Country")
                cmb_Order_Country.Focus()
                Exit Sub
            Else
                err.SetError(cmb_Order_Country, "")
            End If

            If cmb_Order_Country.Text = "" Then
                err.SetError(cmb_Order_Country, "This information is required")
                Exit Sub
            Else
                err.SetError(cmb_Order_Country, "")
            End If
            '--


            If LblShowGSCode.Text = "" Then
                err.SetError(LblShowGSCode, "This information is required")
                CmbType.Focus()
                Exit Sub
            Else
                err.SetError(LblShowGSCode, "")
            End If

            If CmbShPower.Text = "" Then
                err.SetError(CmbShPower, "This information is required")
                CmbShPower.Focus()
                Exit Sub
            Else
                err.SetError(CmbShPower, "")
            End If

            If LblShowPower.Text <> CmbShPower.Text Then
                err.SetError(CmbShPower, "Power mismatch Please check")
                CmbShPower.Focus()
                Exit Sub
            Else
                err.SetError(CmbShPower, "")
            End If

            If CmbType.Text = "" Then
                err.SetError(CmbType, "This information is required")
                CmbType.Focus()
                Exit Sub
            Else
                err.SetError(CmbShModel, "")
            End If


            If LblShowLotPrefix.Text = "" Then
                err.SetError(LblShowLotPrefix, "This information is required")
                CmbType.Focus()
                Exit Sub
            Else
                err.SetError(LblShowLotPrefix, "")
            End If


            If LblShowLotNo.Text = "" Then
                err.SetError(LblShowLotPrefix, "This information is required")
                CmbType.Focus()
                Exit Sub
            Else
                err.SetError(LblShowLotPrefix, "")
            End If


            If CmbShModel.Text = "" Then
                err.SetError(CmbShModel, "This information is required")
                CmbShModel.Focus()
                Exit Sub
            Else
                err.SetError(CmbShModel, "")
            End If

            If CmbShBrand.Text = "" Then
                err.SetError(CmbShBrand, "This information is required")
                Exit Sub
            Else
                err.SetError(CmbShBrand, "")
            End If


            'KPMG
            If ComboBox1.SelectedItem Is Nothing Then
                err.SetError(ComboBox1, "Please Select valid Glassy Lot Number")
                ComboBox1.Focus()
                Exit Sub
            Else
                err.SetError(ComboBox1, "")
            End If

            If CmbType.SelectedItem Is Nothing Then
                err.SetError(CmbType, "Please Select valid Type")
                CmbType.Focus()
                Exit Sub
            Else
                err.SetError(CmbType, "")
            End If

            If cmbPrintLabel.SelectedItem Is Nothing Then
                err.SetError(cmbPrintLabel, "Please Select valid Label")
                cmbPrintLabel.Focus()
                Exit Sub
            Else
                err.SetError(cmbPrintLabel, "")
            End If





            'sundar UDI
            If lblStrBatch.Text = "" Then
                err.SetError(lblStrBatch, "Batch Number is Empty, Please Check")
                lblStrBatch.Focus()
                Exit Sub
            Else
                err.SetError(lblStrBatch, "")
            End If

            Dim ds As New DataSet
            ds = getOpenedSterileBatch(CmbType.Text)
            If ds.Tables(0).Rows.Count <> 0 Then
                If lblStrBatch.Text = ds.Tables(0).Rows(0)("btc_no") Then
                    If ds.Tables(0).Rows(0)("Max_Qty") < Convert.ToInt32(TextBox2.Text) + Convert.ToInt32(lblStrPrintedQty.Text) Then
                        MsgBox("Maximum Qty Reached. Please assign another sterile Batch.", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                Else
                    MsgBox("batch no mismatch", MsgBoxStyle.Critical)
                    Exit Sub

                End If

            End If



            Dim max As Integer
            Dim print As Integer
            Dim tota As Integer
            Dim to1 As Integer

            max = Convert.ToInt32(txtquantity.Text)
            print = Convert.ToInt32(TextBox3.Text)

            to1 = max + print

            'If (to1 <= TextBox2.Text) Then


            StrPrQty = txtquantity.Text

            If Val(StrPrQty) <= 0 Then
                MsgBox("Enter Minimum 1 Qty")
                txtquantity.Text = ""
                txtquantity.Focus()
                Exit Sub
            End If

            StrMaxQty = lblShowMaxQty.Text
            StrPrtedQty = LblShowPrintedQty.Text

            StrBalQty = LblBalanceQty.Text

            If Val(LblBalanceQty.Text) = 0 Then

                If CmbType.Text = "Export" Then
                    strsql = "Update LENS_LOT set Active='NO' where  type='Export' and Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "'"
                    cmd = New SqlCommand(strsql, con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    strsql = "Update LENS_LOT set Active='NO',Modified_By='" & StrLoginUser & "',Modified_Date=GETDATE() where Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "' and type='Export'"
                    cmd = New SqlCommand(strsql, con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    Dim IntLot As Integer

                    IntLot = Val(LblShowLotNo.Text) + 1
                    LblShowLotNo.Text = IntLot.ToString

                    strsql = "Insert into LENS_LOT (Lot_Prefix,	Lot_No,Max_Qty,Printed_Qty,	Active,	Created_By,	Created_Date,	Modified_By,	Modified_Date,Type,Reflot) VALUES   ( " & _
                            "'" & LblShowLotPrefix.Text & "','" & LblShowLotNo.Text & "','" & lblShowMaxQty.Text & "',0,'YES','" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),'Export','" & ComboBox1.Text & "')"
                    cmd = New SqlCommand(strsql, con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                Else
                    strsql = "Update LENS_LOT set Active='NO' where  type='" & CmbType.Text & "' and Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "'"
                    cmd = New SqlCommand(strsql, con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    strsql = "Update LENS_LOT set Active='NO',Modified_By='" & StrLoginUser & "',Modified_Date=GETDATE() where Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "' and type='" & CmbType.Text & "'"
                    cmd = New SqlCommand(strsql, con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    Dim IntLot As Integer

                    IntLot = Val(LblShowLotNo.Text) + 1
                    LblShowLotNo.Text = IntLot.ToString

                    strsql = "Insert into LENS_LOT (Lot_Prefix,	Lot_No,Max_Qty,Printed_Qty,	Active,	Created_By,	Created_Date,	Modified_By,	Modified_Date,Type,Reflot) VALUES   ( " & _
                            "'" & LblShowLotPrefix.Text & "','" & LblShowLotNo.Text & "','" & lblShowMaxQty.Text & "',0,'YES','" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),'" & CmbType.Text & "','" & ComboBox1.Text & "')"
                    cmd = New SqlCommand(strsql, con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                End If

                StrPrQty = txtquantity.Text
                If Val(StrPrQty) <= 0 Then
                    MsgBox("Enter Minimum 1 Qty")
                    txtquantity.Text = ""
                    txtquantity.Focus()
                    Exit Sub
                End If
                StrMaxQty = lblShowMaxQty.Text

                StrStPrQty = 0
                LblShowPrintedQty.Text = StrPrtedQty
                StrBalQty = StrMaxQty
                LblBalanceQty.Text = StrBalQty
                StrPrtedQty = 0
                LblShowPrintedQty.Text = 0
                'StrEnPrQty = StrEnPrQty - Val(lblShowMaxQty.Text)

                'StrStPrQty = 0

                'StI = 0
            End If

            If Val(StrBalQty) < 0 Then

                MsgBox("Max Qty Reached")
                txtquantity.Text = ""
                txtquantity.Focus()
                Exit Sub

            End If

            StrStPrQty = StrPrtedQty + 1
            StrEnPrQty = StrPrtedQty + StrPrQty

            StrStSrNo = StrStPrQty
            StrEnSrNo = StrEnPrQty

            Stroptic1 = LblShowOptic.Text
            Strlength1 = LblShowLength.Text

            StrLot1 = LblShowLotPrefix.Text + LblShowLotNo.Text








            Dim StrFName As String

            StrFName = BTWFileName()

            If StrFName = "" Then
                MessageBox.Show("BTW file record not found")
                Exit Sub
            End If


            If RdoRef.Checked = True Then

                strrefname1 = LblShowRefName.Text
            Else
                strrefname1 = CmbShBrand.Text
            End If





            For StI As Integer = StrStPrQty To StrEnPrQty

                StrlotonlyNo = LblShowLotPrefix.Text & LblShowLotNo.Text

                StrlotBarNo = LblShowLotPrefix.Text & LblShowLotNo.Text & " " & Format(StrStPrQty, "000")


                Dim steirli As String
                Dim nameaddre As String
                Dim licenc As String
                Dim temp As String
                Dim mrp As String





                stroptic = LblShowOptic.Text
                strlength = LblShowLength.Text
                strpwr = CmbShPower.Text
                Dim SIZE As String

                ' SIZE = stroptic & "X" & strlength

                Dim StrRs As SqlDataReader
                Dim acon As String
                Dim ster As String
                Dim com As String
                Dim lic As String
                Dim tem As String
                Dim price1 As String


                strsql = "select A_Constant ,Sterilize_type,Name_address , LicenceNo , Storage_Temp , price from  LENS_MASTER1 where Brand_Name ='" & CmbShBrand.Text & "' and Model_Name='" & CmbShModel.Text & "' and Power = '" & CmbShPower.Text & "' "
                cmd = New SqlCommand(strsql, con)
                StrRs = cmd.ExecuteReader

                While StrRs.Read


                    acon = Format(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)), "0.00")
                    ster = IIf(IsDBNull(StrRs.GetValue(1)), "", StrRs.GetValue(1))
                    com = IIf(IsDBNull(StrRs.GetValue(2)), "", StrRs.GetValue(2))
                    lic = IIf(IsDBNull(StrRs.GetValue(3)), "", StrRs.GetValue(3))
                    tem = IIf(IsDBNull(StrRs.GetValue(4)), "", StrRs.GetValue(4))
                    price1 = IIf(IsDBNull(StrRs.GetValue(5)), "", StrRs.GetValue(5))





                End While


                Dim Towd As String

                Towd = StrlotBarNo & "," & strrefname1 & "," & CmbShModel.Text & "," & strpwr & "" & "D" & "," & stroptic & " " & "mm" & "," & strlength & " " & "mm" & "," & acon & "," & ster & "," & LblShowMfdDate.Text & "," & LblShowExpDate.Text & "," & com & "," & lic & "," & tem & "," & price1 & "," & txtbatchno.Text


                If (strrefname1 = "APPALENS" Or strrefname1 = "APPALENS PLUS" Or strrefname1 = "HEERALENS" Or strrefname1 = "LIBERTY IRIS CLAW LENS" Or strrefname1 = "LIBERTYLENS" Or strrefname1 = "LIBERTYLENS BBY" Or strrefname1 = "SWISS LENS") Then

                    stroptic = stroptic & " " & "mm"
                    strlength = strlength & " " & "mm"
                    strpwr = strpwr & " " & "D"

                    'sundar Udi
                    Dim StrEanCode As String
                    StrEanCode = LblShowGSCode.Text.Remove(LblShowGSCode.Text.Length - 1, 1)

                    Dim strbtc As String = lblStrBatch.Text
                    Dim strbtcexpiry As String = strexyear.Substring(2, 2)
                    StrInexp1 = strbtcexpiry & strexmonth & "00"
                    Dim strbtcmfd As String = strmfyear.Substring(2, 2)
                    StrInmfd = strbtcmfd & strmfmonth & "00"

                    'For Algeria order -11-10-2023
                    If StrFName <> "PMMA_POUCH_Export_1D_Algeria.btw" Then
                        StrlotBarNo = StrlotBarNo.Replace(" ", "")
                    End If



                    btFile = Application.StartupPath & "\" & StrFName & ""
                    If Not File.Exists(btFile) Then
                        MessageBox.Show("btw file not found")
                        Exit Sub
                    End If

                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)


                    bt.SetNamedSubStringValue("Ref", CmbShModel.Text)
                    bt.SetNamedSubStringValue("Pwr", strpwr)
                    'bt.SetNamedSubStringValue("Brandname", strrefname1)
                    'bt.SetNamedSubStringValue("SNo", StrlotBarNo)
                    bt.SetNamedSubStringValue("LotNo", StrlotBarNo)
                    'bt.SetNamedSubStringValue("optic", stroptic)
                    'bt.SetNamedSubStringValue("Length", strlength)
                    bt.SetNamedSubStringValue("Expdate", LblShowExpDate.Text)
                    bt.SetNamedSubStringValue("mfddate", LblShowMfdDate.Text)
                    bt.SetNamedSubStringValue("Twodbar", Towd)

                    bt.SetNamedSubStringValue("Ref", CmbShModel.Text)
                    bt.SetNamedSubStringValue("Pwr", strpwr)
                    bt.SetNamedSubStringValue("Brandname", strrefname1)
                    'bt.SetNamedSubStringValue("SNo", StrlotBarNo)
                    bt.SetNamedSubStringValue("LotNo", StrlotBarNo)
                    bt.SetNamedSubStringValue("optic", stroptic)
                    bt.SetNamedSubStringValue("Length", strlength)
                    bt.SetNamedSubStringValue("Expdate", LblShowExpDate.Text)
                    bt.SetNamedSubStringValue("mfddate", LblShowMfdDate.Text)

                    bt.SetNamedSubStringValue("EanCode", StrEanCode)
                    bt.SetNamedSubStringValue("Btc", strbtc)
                    bt.SetNamedSubStringValue("mfdtwod", StrInmfd)
                    bt.SetNamedSubStringValue("exptwod", StrInexp1)

                    bt.PrintOut()

                    bt.Close()

                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                Else

                    Dim Towd1 As String
                    '  Towd1 = StrlotBarNo & "," & strrefname1 & "," & CmbShModel.Text & "," & stroptic & "" & "mm" & "," & strlength & "" & "mm" & "," & acon & "," & ster & "," & LblShowMfdDate.Text & "," & LblShowExpDate.Text & "," & com & "," & lic & "," & tem & "," & txtbatchno.Text
                    'stroptic = stroptic & " " & "mm"
                    'strlength = strlength & " " & "mm"
                    'strpwr = strpwr & " " & "D"

                    'sundar Udi
                    Dim StrEanCode As String
                    StrEanCode = LblShowGSCode.Text.Remove(LblShowGSCode.Text.Length - 1, 1)
                    Dim strbtc As String = lblStrBatch.Text
                    Dim strbtcexpiry As String = strexyear.Substring(2, 2)
                    StrInexp1 = strbtcexpiry & strexmonth & "00"
                    Dim strbtcmfd As String = strmfyear.Substring(2, 2)
                    StrInmfd = strbtcmfd & strmfmonth & "00"

                    'For Algeria order -11-10-2023
                    If StrFName <> "PMMA_POUCH_Export_1D_Algeria.btw" Then
                        StrlotBarNo = StrlotBarNo.Replace(" ", "")
                    End If

                    btFile = Application.StartupPath & "\" & StrFName & ""

                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)





                    bt.SetNamedSubStringValue("Ref", CmbShModel.Text)
                    ' bt.SetNamedSubStringValue("Pwr", strpwr)
                    bt.SetNamedSubStringValue("Brandname", strrefname1)
                    'bt.SetNamedSubStringValue("SNo", StrlotBarNo)
                    bt.SetNamedSubStringValue("LotNo", StrlotBarNo)
                    bt.SetNamedSubStringValue("optic", stroptic)
                    bt.SetNamedSubStringValue("Length", strlength)
                    bt.SetNamedSubStringValue("Expdate", LblShowExpDate.Text)
                    bt.SetNamedSubStringValue("mfddate", LblShowMfdDate.Text)

                    bt.SetNamedSubStringValue("EanCode", StrEanCode)
                    bt.SetNamedSubStringValue("Btc", strbtc)
                    bt.SetNamedSubStringValue("mfdtwod", StrInmfd)
                    bt.SetNamedSubStringValue("exptwod", StrInexp1)

                    bt.PrintOut()
                    bt.Close()

                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                End If



                Dim udi_code As String = "01" & LblShowGSCode.Text & "10" & lblStrBatch.Text & "11" & StrInmfd & "17" & StrInexp1 & "21" & StrlotBarNo

                ' End If


                If rdobrand.Checked = True Then
                    strsql = " insert into POUCH_LABEL (Brand_Name,Model_Name,Reference_Name,GS_Code,Power,Optic,Length,Lot_Unit," & _
                             "A_Constant,Type_GS_Code,Qty,St_SrNo,St_EnNo,Lot_Prefix,Lot_No,Lot_SrNo,Mfd_Month,Mfd_Year,Exp_Month,Exp_Year,Sterilization, " & _
                             "Sample_Taken,Type_Sample,BPL_Taken,Box_Packing,Dc_Packing,Created_By,Created_Date,Modified_By,Modified_Date,Sterilization_Reject,Qty_1,Type,Sterilization_After,Box_Reject,Print_Name,GlassyLotno,Price,Btc_No,PouchStation,PouchBTWLabelName, Udi_code,Pouch_Order_Type, Pouch_Order_Country ) values ( " & _
                             "'" & CmbShBrand.Text & "','" & CmbShModel.Text & "', '" & CmbShBrand.Text & "','" & LblShowGSCode.Text & "','" & CmbShPower.Text & "','" & LblShowOptic.Text & "','" & LblShowLength.Text & "' ," & _
                             "'mm','" & LblshAConstant.Text & "','" & LblShowGSType.Text & "' ,'" & txtquantity.Text & "','" & StrStPrQty & "','" & StrEnPrQty & "','" & LblShowLotPrefix.Text & "','" & LblShowLotNo.Text & "','" & StrlotBarNo & "' , " & _
                             "'" & strmfmonth & "','" & strmfyear & "','" & strexmonth & "','" & strexyear & "',0,0,'NO',0,0,0,'" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),0,1,'" & CmbType.Text & "',0,0,'" & CmbShBrand.Text & "','" & ComboBox1.Text & "','" & price1 & "','" & lblStrBatch.Text & "','" & station & "','" & cmbPrintLabel.Text & "', '" & udi_code & "','" & cmb_Order_Type.Text & "','" & cmb_Order_Country.Text & "' )"

                    cmd = New SqlCommand(strsql, con)
                    If con.State = Data.ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                Else
                    strsql = " insert into POUCH_LABEL (Brand_Name,Model_Name,Reference_Name,GS_Code,Power,Optic,Length,Lot_Unit," & _
                             "A_Constant,Type_GS_Code,Qty,St_SrNo,St_EnNo,Lot_Prefix,Lot_No,Lot_SrNo,Mfd_Month,Mfd_Year,Exp_Month,Exp_Year,Sterilization, " & _
                             "Sample_Taken,Type_Sample,BPL_Taken,Box_Packing,Dc_Packing,Created_By,Created_Date,Modified_By,Modified_Date,Sterilization_Reject,Qty_1,Type,Sterilization_After,Box_Reject,Print_Name,GlassyLotno,Price,Btc_No,PouchStation,PouchBTWLabelName, Udi_code,Pouch_Order_Type, Pouch_Order_Country ) values ( " & _
                             "'" & CmbShBrand.Text & "','" & CmbShModel.Text & "','" & CmbShBrand.Text & "','" & LblShowGSCode.Text & "' ,'" & CmbShPower.Text & "','" & LblShowOptic.Text & "','" & LblShowLength.Text & "' ," & _
                             "'mm','" & LblshAConstant.Text & "','" & LblShowGSType.Text & "','" & txtquantity.Text & "','" & StrStPrQty & "','" & StrEnPrQty & "','" & LblShowLotPrefix.Text & "','" & LblShowLotNo.Text & "','" & StrlotBarNo & "' , " & _
                             "'" & strmfmonth & "','" & strmfyear & "','" & strexmonth & "','" & strexyear & "',0,0,'NO',0,0,0,'" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),0,1,'" & CmbType.Text & "',0,0,'" & LblShowRefName.Text & "','" & ComboBox1.Text & "','" & price1 & "','" & lblStrBatch.Text & "','" & station & "','" & cmbPrintLabel.Text & "', '" & udi_code & "', '" & cmb_Order_Type.Text & "','" & cmb_Order_Country.Text & "' )"

                    cmd = New SqlCommand(strsql, con)
                    If con.State = Data.ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                End If


                If CmbType.Text = "Export" Then
                    strsql = "Update LENS_LOT set Printed_Qty='" & StrStPrQty & "' where Active='YES' and type='Export' and Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "'"
                    cmd = New SqlCommand(strsql, con)
                    If con.State = Data.ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                Else
                    strsql = "Update LENS_LOT set Printed_Qty='" & StrStPrQty & "' where Active='YES' and type='" & CmbType.Text & "' and Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "'"
                    cmd = New SqlCommand(strsql, con)
                    If con.State = Data.ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                End If


                LblShowPrintedQty.Text = StrStPrQty
                LblBalanceQty.Text = Val(lblShowMaxQty.Text) - StrStPrQty


                'sundar UDI
                lblStrPrintedQty.Text = lblStrPrintedQty.Text + 1
                PrintedQtyUpdate(lblStrPrintedQty.Text, CmbType.Text)





                If Val(LblBalanceQty.Text) = 0 Then

                    If CmbType.Text = "Export-Turkey" Then

                        strsql = "Update LENS_LOT set Active='NO' where  type='Export' and Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "'"
                        cmd = New SqlCommand(strsql, con)
                        If con.State = Data.ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                        strsql = "Update LENS_LOT set Active='NO',Modified_By='" & StrLoginUser & "',Modified_Date=GETDATE() where Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "' and type='Export'"
                        cmd = New SqlCommand(strsql, con)
                        If con.State = Data.ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                        Dim IntLot As Integer
                        Dim stringlotno As String

                        IntLot = Val(LblShowLotNo.Text) + 1

                        stringlotno = IntLot.ToString("0000")

                        LblShowLotNo.Text = stringlotno

                        'LblShowLotNo.Text = String.Format(stringlotno, "000")

                        strsql = "Insert into LENS_LOT (Lot_Prefix,	Lot_No,Max_Qty,Printed_Qty,	Active,	Created_By,	Created_Date,	Modified_By,	Modified_Date,Type) VALUES   ( " & _
                                "'" & LblShowLotPrefix.Text & "','" & LblShowLotNo.Text & "','" & lblShowMaxQty.Text & "',0,'YES','" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),'Export')"
                        cmd = New SqlCommand(strsql, con)
                        If con.State = Data.ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                    Else

                        strsql = "Update LENS_LOT set Active='NO' where  type='" & CmbType.Text & "' and Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "'"
                        cmd = New SqlCommand(strsql, con)
                        If con.State = Data.ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                        strsql = "Update LENS_LOT set Active='NO',Modified_By='" & StrLoginUser & "',Modified_Date=GETDATE() where Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "' and type='" & CmbType.Text & "'"
                        cmd = New SqlCommand(strsql, con)
                        If con.State = Data.ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                        Dim IntLot As Integer
                        Dim stringlotno As String

                        IntLot = Val(LblShowLotNo.Text) + 1

                        stringlotno = IntLot.ToString("0000")
                        LblShowLotNo.Text = stringlotno

                        'LblShowLotNo.Text = String.Format(stringlotno, "000")

                        strsql = "Insert into LENS_LOT (Lot_Prefix,	Lot_No,Max_Qty,Printed_Qty,	Active,	Created_By,	Created_Date,	Modified_By,	Modified_Date,Type) VALUES   ( " & _
                                "'" & LblShowLotPrefix.Text & "','" & LblShowLotNo.Text & "','" & lblShowMaxQty.Text & "',0,'YES','" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),'" & CmbType.Text & "')"
                        cmd = New SqlCommand(strsql, con)
                        If con.State = Data.ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                    End If

                    StrEnPrQty = StrEnPrQty - Val(lblShowMaxQty.Text)

                    StrStPrQty = 0


                    StrBalQty = StrMaxQty
                    LblBalanceQty.Text = StrBalQty
                    StrPrtedQty = 0
                    LblShowPrintedQty.Text = 0

                    'StI = 0
                End If

                '    StrStPrQty = Val(StrStPrQty) + 1

                'Next

                'clear()

                Dim qy As Integer

                qy = Convert.ToInt32(txtquantity.Text) + Convert.ToInt32(TextBox3.Text)


                If (TextBox4.Text = qy.ToString()) Then

                    Dim conString1 As String = ConfigurationSettings.AppSettings("conStrPMMA_ERP").ToString()
                    Dim con1 As SqlConnection
                    con1 = New SqlConnection(conString1)

                    Try
                        con1.Open()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    strsql = "Update PMMAPowerSegregationChild set Flag = '2' where GlassyLotNo='" & ComboBox1.Text & "' "
                    cmd = New SqlCommand(strsql, con1)
                    If con1.State = Data.ConnectionState.Open Then
                        con1.Close()
                    End If
                    con1.Open()
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()








                End If

                StrStPrQty = Val(StrStPrQty) + 1

            Next


            clear()
        Catch ex As Exception

            MsgBox("An unexpected error occurred.")
            Exit Sub

        End Try


        


    End Sub
    Public Sub PrintedQtyUpdate(ByVal Printed_Qty As String, ByVal pck_type As String)
        Dim strsql As String
        strsql = " update LENS_BATCH set Printed_Qty = '" & Printed_Qty & "' where Active='YES' and type='" & pck_type & "' and  btc_no='" & lblStrBatch.Text & "'"
        Dim cmd As New SqlCommand(strsql, con)
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub
    Public Shared Function DefaultPrinterName() As String
        Dim oPS As New System.Drawing.Printing.PrinterSettings
        Try
            DefaultPrinterName = oPS.PrinterName
        Catch ex As System.Exception
            DefaultPrinterName = ""
        Finally
            oPS = Nothing
        End Try
    End Function
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtcrMaxQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtquantity.TextChanged

    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        clear()
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
        Menulblmstdatacre.LblHomeMenuDisplyName.Visible = False
        Menulblmstdatacre.TimHomeSideDisply.Start()
        'RawPrinterHelper.SendFileToPrinter(DefaultPrinterName, Application.StartupPath & "\write.prn")
    End Sub


    Private Sub CmbShPower_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CmbShPower.Text <> "" Then
            strsql = "SELECT DISTINCT Brand_Name from LENS_MASTER where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' order by Brand_Name"
            cmd = New SqlCommand(strsql, con)
            StrRs = cmd.ExecuteReader

            ' CmbShBrand.Items.Clear()
            CmbShType.Items.Clear()

            CmbShBrand.Text = ""
            CmbShType.Text = ""
            While StrRs.Read
                ' CmbShBrand.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
            End While
            StrRs.Close()
            cmd.Dispose()
        End If
    End Sub

    Private Sub CmbShType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbShType.SelectedIndexChanged
        If CmbShType.Text <> "" Then
            strsql = "SELECT * from LENS_MASTER where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' and Type_GS_Code='" & CmbShType.Text & "' and Brand_Name='" & CmbShBrand.Text & "' "
            cmd = New SqlCommand(strsql, con)
            StrRs = cmd.ExecuteReader

            If StrRs.Read Then

                LblShowGSCode.Text = IIf(IsDBNull(StrRs.GetValue(5)), "", StrRs.GetValue(5))
                LblShowPower.Text = Format(IIf(IsDBNull(StrRs.GetValue(6)), 0, StrRs.GetValue(6)), "0.00")
                LblShowRefName.Text = IIf(IsDBNull(StrRs.GetValue(4)), "", StrRs.GetValue(4))
                LblShowOptic.Text = Format(IIf(IsDBNull(StrRs.GetValue(7)), "", StrRs.GetValue(7)), "0.00")
                LblShowLength.Text = Format(IIf(IsDBNull(StrRs.GetValue(8)), "", StrRs.GetValue(8)), "0.00")
                LblShowGSType.Text = IIf(IsDBNull(StrRs.GetValue(11)), "", StrRs.GetValue(11))
                LblshAConstant.Text = Format(IIf(IsDBNull(StrRs.GetValue(10)), 0, StrRs.GetValue(10)), "0.00")
                IntTotExp = IIf(IsDBNull(StrRs.GetValue(12)), 0, StrRs.GetValue(12))

                StrMfdMonth = Now.Month
                strmfmonth = StrMfdMonth.ToString("00")

                StrMfdYear = Now.Year
                strmfyear = StrMfdYear.ToString("0000")

                StrExpMonth = StrMfdMonth - 1
                strexmonth = StrExpMonth.ToString("00")

                StrExpYear = StrMfdYear + IntTotExp
                strexyear = StrExpYear.ToString("0000")

                If StrExpMonth = 0 Then
                    strexmonth = (12).ToString("00")
                    strexyear = (StrExpYear - 1).ToString("0000")
                End If

                LblShowMfdDate.Text = strmfyear & "-" & strmfmonth
                LblShowExpDate.Text = strexyear & "-" & strexmonth

            Else
                MsgBox("No Data Found", MsgBoxStyle.Critical)
                Exit Sub
            End If
            StrRs.Close()
            cmd.Dispose()
        End If
    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnl.Enter

    End Sub
    Public Function getOpenedSterileBatch(ByVal pck_type As String) As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = "select btc_no,Max_Qty,Printed_Qty  from LENS_BATCH where Active='YES' and type='" & pck_type & "'"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Private Sub CmbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbType.SelectedIndexChanged


        'Dim IntLot As Integer
        'Dim stringlotno As String

        'IntLot = Val(LblShowLotNo.Text) + 1

        'stringlotno = IntLot.ToString("0000")
        'LblShowLotNo.Text = stringlotno

        ''LblShowLotNo.Text = String.Format(stringlotno, "000")

        'strsql = "Insert into LENS_LOT (Lot_Prefix,	Lot_No,Max_Qty,Printed_Qty,	Active,	Created_By,	Created_Date,	Modified_By,	Modified_Date,Type) VALUES   ( " & _
        '        "'" & LblShowLotPrefix.Text & "','" & LblShowLotNo.Text & "','" & lblShowMaxQty.Text & "',0,'YES','" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),'" & CmbType.Text & "')"
        'cmd = New SqlCommand(strsql, con)
        'If con.State = Data.ConnectionState.Open Then
        '    con.Close()
        'End If
        'con.Open()
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()





        If CmbType.Text <> "" Then
            'sundar UDI
            Dim ds As New DataSet
            ds = getOpenedSterileBatch(CmbType.Text)
            If ds.Tables(0).Rows.Count <> 0 Then
                lblStrBatch.Text = ds.Tables(0).Rows(0)("btc_no")
                lblStrPrintedQty.Text = ds.Tables(0).Rows(0)("Printed_Qty")
            Else
                MsgBox("No sterile batch open. please check", MsgBoxStyle.Critical)
                Exit Sub
            End If


            If CmbType.Text = "Export-Turkey" Then
                strsql = "select Lot_Prefix,Lot_No,Max_Qty,Printed_Qty,(Max_Qty-Printed_Qty) as Balance_Qty,Active from LENS_LOT where Active='YES' and type='Export'"
                cmd = New SqlCommand(strsql, con)
                StrRs = cmd.ExecuteReader
            Else
                strsql = "select Lot_Prefix,Lot_No,Max_Qty,Printed_Qty,(Max_Qty-Printed_Qty) as Balance_Qty,Active from LENS_LOT where Active='YES' and type='" & CmbType.Text & "'"
                cmd = New SqlCommand(strsql, con)
                StrRs = cmd.ExecuteReader
            End If

            If StrRs.Read Then
                LblShowLotPrefix.Text = IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0))

                LblShowLotNo.Text = IIf(IsDBNull(StrRs.GetValue(1)), "", StrRs.GetValue(1))

                lblShowMaxQty.Text = IIf(IsDBNull(StrRs.GetValue(2)), "", StrRs.GetValue(2))
                LblShowPrintedQty.Text = IIf(IsDBNull(StrRs.GetValue(3)), "", StrRs.GetValue(3))
                LblBalanceQty.Text = IIf(IsDBNull(StrRs.GetValue(4)), "", StrRs.GetValue(4))
                CmbShModel.Focus()

            Else
                LblShowLotPrefix.Text = ""
                LblShowLotNo.Text = ""

                lblShowMaxQty.Text = 0
                LblShowPrintedQty.Text = 0
                LblBalanceQty.Text = 0
            End If
            StrRs.Close()
            cmd.Dispose()




        End If
    End Sub

    Private Sub clear()

        CmbShBrand.Text = ""
        CmbShModel.Text = ""
        CmbShPower.Text = ""
        CmbShType.Text = ""
        txtquantity.Text = ""
        LblshAConstant.Text = ""
        LblShowExpDate.Text = ""
        LblShowOptic.Text = ""
        LblShowGSCode.Text = ""
        LblShowLength.Text = ""
        LblShowPower.Text = ""
        LblShowRefName.Text = ""
        LblShowGSType.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        LblShowMfdDate.Text = ""
        ComboBox1.Text = ""
        CmbType.Text = ""
        cmb_Order_Type.Text = ""
        cmb_Order_Country.Text = ""



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged


        txtquantity.Enabled = False


        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        txtquantity.Text = ""

        Dim conString1 As String = ConfigurationSettings.AppSettings("conStrPMMA_ERP").ToString()
        Dim con1 As SqlConnection
        con1 = New SqlConnection(conString1)
        Try
            con1.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        strsql = ("SELECT  Qty  from  PMMAPowerSegregationChild  where GlassyLotNo = '" & ComboBox1.Text & "'  ")
        cmd = New SqlCommand(strsql, con1)
        If con1.State = Data.ConnectionState.Open Then
            con1.Close()
        End If
        con1.Open()
        StrRs1 = cmd.ExecuteReader
        'ComboBox2.Items.Clear()
        While StrRs1.Read
            TextBox2.Text = (IIf(IsDBNull(StrRs1.GetValue(0)), "", StrRs1.GetValue(0)))
            'Dim s As String = TextBox1.Text
            'Dim word As String() = s.Split(New Char() {"/"c})

            'CmbShModel.Text = word(1)
            'CmbShPower.Text = word(3)
            'CmbShBrand.Text = word(0)
        End While
        StrRs1.Close()
        cmd.Dispose()

        If (TextBox2.Text <= 300) Then


            strsql = ("SELECT  sum(Accepted_Qty) as qty   from work_In__Progress1  where LotNo = '" & ComboBox1.Text & "' and   Process_Name  = 'PMA - FQI MICROSCOPIC INSPECTION' and Accepted_Qty is not null   ")
            cmd = New SqlCommand(strsql, con1)
            If con1.State = Data.ConnectionState.Open Then
                con1.Close()
            End If
            con1.Open()
            StrRs1 = cmd.ExecuteReader
            'ComboBox2.Items.Clear()
            If StrRs1.Read Then
                If Not IsDBNull(StrRs1.GetValue(0)) Then

                    TextBox4.Text = (IIf(IsDBNull(StrRs1.GetValue(0)), "", StrRs1.GetValue(0)))

                    txtquantity.Text = TextBox4.Text

                Else

                    MsgBox("Enter the Final Quality Inspection")
                    Exit Sub


                End If

                'Dim s As String = TextBox1.Text
                'Dim word As String() = s.Split(New Char() {"/"c})

                'CmbShModel.Text = word(1)
                'CmbShPower.Text = word(3)
                'CmbShBrand.Text = word(0)

            Else

                MsgBox("Enter the Final Quality Inspection")
                Exit Sub


            End If

            StrRs1.Close()
            cmd.Dispose()


            strsql = ("SELECT  distinct Product_Description  from work_In__Progress1  where LotNo = '" & ComboBox1.Text & "' ")
            cmd = New SqlCommand(strsql, con1)
            If con1.State = Data.ConnectionState.Open Then
                con1.Close()
            End If
            con1.Open()
            StrRs1 = cmd.ExecuteReader
            'ComboBox2.Items.Clear()
            While StrRs1.Read

                TextBox1.Text = (IIf(IsDBNull(StrRs1.GetValue(0)), "", StrRs1.GetValue(0)))
                Dim s As String = TextBox1.Text
                Dim word As String() = s.Split(New Char() {"/"c})

                CmbShModel.Text = word(1)
                CmbShPower.Text = word(3)
                CmbShBrand.Text = word(0)

            End While
            StrRs1.Close()
            cmd.Dispose()





            strsql = ("SELECT  sum(Qty_1) as qty   from POUCH_LABEL  where GlassyLotno = '" & ComboBox1.Text & "' ")
            cmd = New SqlCommand(strsql, con)
            If con.State = Data.ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            StrRs1 = cmd.ExecuteReader
            'ComboBox2.Items.Clear()
            While StrRs1.Read
                TextBox3.Text = (IIf(IsDBNull(StrRs1.GetValue(0)), "", StrRs1.GetValue(0)))
                'Dim s As String = TextBox1.Text
                'Dim word As String() = s.Split(New Char() {"/"c})

                'CmbShModel.Text = word(1)
                'CmbShPower.Text = word(3)
                'CmbShBrand.Text = word(0)


            End While
            StrRs1.Close()
            cmd.Dispose()


            strsql = ("SELECT  distinct Product_Description  from work_In__Progress1  where LotNo = '" & ComboBox1.Text & "' ")
            cmd = New SqlCommand(strsql, con1)
            If con1.State = Data.ConnectionState.Open Then
                con1.Close()
            End If
            con1.Open()
            StrRs1 = cmd.ExecuteReader
            'ComboBox2.Items.Clear()
            While StrRs1.Read

                TextBox1.Text = (IIf(IsDBNull(StrRs1.GetValue(0)), "", StrRs1.GetValue(0)))
                Dim s As String = TextBox1.Text
                Dim word As String() = s.Split(New Char() {"/"c})

                CmbShModel.Text = word(1)
                CmbShPower.Text = word(3)
                CmbShBrand.Text = word(0)

            End While
            StrRs1.Close()
            cmd.Dispose()





            strsql = "SELECT * from LENS_MASTER1 where Model_Name='" & CmbShModel.Text & "' and   Brand_Name='" & CmbShBrand.Text & "' and power ='" & CmbShPower.Text & "'"

            cmd = New SqlCommand(strsql, con)
            If con.State = Data.ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            StrRs1 = cmd.ExecuteReader

            If StrRs1.Read Then

                LblShowGSCode.Text = IIf(IsDBNull(StrRs1.GetValue(5)), "", StrRs1.GetValue(5))
                LblShowPower.Text = Format(IIf(IsDBNull(StrRs1.GetValue(6)), 0, StrRs1.GetValue(6)), "0.00")
                LblShowRefName.Text = IIf(IsDBNull(StrRs1.GetValue(4)), "", StrRs1.GetValue(4))
                LblShowOptic.Text = Format(IIf(IsDBNull(StrRs1.GetValue(7)), "", StrRs1.GetValue(7)), "0.00")
                LblShowLength.Text = Format(IIf(IsDBNull(StrRs1.GetValue(8)), "", StrRs1.GetValue(8)), "0.00")
                LblShowGSType.Text = IIf(IsDBNull(StrRs1.GetValue(11)), "", StrRs1.GetValue(11))
                LblshAConstant.Text = Format(IIf(IsDBNull(StrRs1.GetValue(10)), 0, StrRs1.GetValue(10)), "0.00")
                IntTotExp = IIf(IsDBNull(StrRs1.GetValue(12)), 0, StrRs1.GetValue(12))

                StrMfdMonth = Now.Month
                strmfmonth = StrMfdMonth.ToString("00")

                StrMfdYear = Now.Year
                strmfyear = StrMfdYear.ToString("0000")

                StrExpMonth = StrMfdMonth - 1
                strexmonth = StrExpMonth.ToString("00")

                StrExpYear = StrMfdYear + IntTotExp
                strexyear = StrExpYear.ToString("0000")

                If StrExpMonth = 0 Then
                    strexmonth = (12).ToString("00")
                    strexyear = (StrExpYear - 1).ToString("0000")
                End If

                LblShowMfdDate.Text = strmfyear & "-" & strmfmonth
                LblShowExpDate.Text = strexyear & "-" & strexmonth

            Else
                MsgBox("No Data Found", MsgBoxStyle.Critical)
                Exit Sub
            End If
            StrRs1.Close()
            cmd.Dispose()

            If (TextBox3.Text <> "") Then
            Else

                TextBox3.Text = 0
            End If


            StrRs.Close()


            txtquantity.Enabled = False
















        Else


            strsql = ("SELECT  *  from POUCH_LABEL  where GlassyLotno = '" & ComboBox1.Text & "' ")
            cmd = New SqlCommand(strsql, con)
            If con.State = Data.ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            StrRs = cmd.ExecuteReader
            If StrRs.Read Then


                strsql = ("SELECT  sum(Qty_1) as qty   from POUCH_LABEL  where GlassyLotno = '" & ComboBox1.Text & "' ")
                cmd = New SqlCommand(strsql, con)
                If con.State = Data.ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                StrRs1 = cmd.ExecuteReader
                'ComboBox2.Items.Clear()
                While StrRs1.Read
                    TextBox3.Text = (IIf(IsDBNull(StrRs1.GetValue(0)), "", StrRs1.GetValue(0)))
                    'Dim s As String = TextBox1.Text
                    'Dim word As String() = s.Split(New Char() {"/"c})

                    'CmbShModel.Text = word(1)
                    'CmbShPower.Text = word(3)
                    'CmbShBrand.Text = word(0)

                End While
                StrRs1.Close()
                cmd.Dispose()




                strsql = ("SELECT  sum (Accepted_Qty) as qty   from work_In__Progress1  where LotNo = '" & ComboBox1.Text & "' and   Process_Name  = 'PMA - FQI MICROSCOPIC INSPECTION' and Accepted_Qty is not null  ")
                cmd = New SqlCommand(strsql, con1)
                If con1.State = Data.ConnectionState.Open Then
                    con1.Close()
                End If
                con1.Open()
                StrRs1 = cmd.ExecuteReader

                If (StrRs1.Read) Then

                    'End If
                    'ComboBox2.Items.Clear()
                    ' If StrRs1.GetValue(0) <> Nothing Then

                    TextBox4.Text = (IIf(IsDBNull(StrRs1.GetValue(0)), "0", StrRs1.GetValue(0)))
                    'Dim s As String = TextBox1.Text
                    'Dim word As String() = s.Split(New Char() {"/"c})

                    'CmbShModel.Text = word(1)
                    'CmbShPower.Text = word(3)
                    'CmbShBrand.Text = word(0)

                Else

                    MsgBox("Enter the Final Quality Inspection")
                    Exit Sub

                    'End If
                End If
                StrRs1.Close()
                cmd.Dispose()


                txtquantity.Text = Convert.ToInt32(TextBox4.Text) - Convert.ToInt32(TextBox3.Text)



                strsql = ("SELECT  distinct Product_Description  from work_In__Progress1  where LotNo = '" & ComboBox1.Text & "' ")
                cmd = New SqlCommand(strsql, con1)
                If con1.State = Data.ConnectionState.Open Then
                    con1.Close()
                End If
                con1.Open()
                StrRs1 = cmd.ExecuteReader
                'ComboBox2.Items.Clear()
                While StrRs1.Read

                    TextBox1.Text = (IIf(IsDBNull(StrRs1.GetValue(0)), "", StrRs1.GetValue(0)))
                    Dim s As String = TextBox1.Text
                    Dim word As String() = s.Split(New Char() {"/"c})

                    CmbShModel.Text = word(1)
                    CmbShPower.Text = word(3)
                    CmbShBrand.Text = word(0)

                End While
                StrRs1.Close()
                cmd.Dispose()

                strsql = "SELECT * from LENS_MASTER1 where Model_Name='" & CmbShModel.Text & "' and   Brand_Name='" & CmbShBrand.Text & "' and power ='" & CmbShPower.Text & "'"
                cmd = New SqlCommand(strsql, con)
                If con.State = Data.ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                StrRs1 = cmd.ExecuteReader

                If StrRs1.Read Then

                    LblShowGSCode.Text = IIf(IsDBNull(StrRs1.GetValue(5)), "", StrRs1.GetValue(5))
                    LblShowPower.Text = Format(IIf(IsDBNull(StrRs1.GetValue(6)), 0, StrRs1.GetValue(6)), "0.00")
                    LblShowRefName.Text = IIf(IsDBNull(StrRs1.GetValue(4)), "", StrRs1.GetValue(4))
                    LblShowOptic.Text = Format(IIf(IsDBNull(StrRs1.GetValue(7)), "", StrRs1.GetValue(7)), "0.00")
                    LblShowLength.Text = Format(IIf(IsDBNull(StrRs1.GetValue(8)), "", StrRs1.GetValue(8)), "0.00")
                    LblShowGSType.Text = IIf(IsDBNull(StrRs1.GetValue(11)), "", StrRs1.GetValue(11))
                    LblshAConstant.Text = Format(IIf(IsDBNull(StrRs1.GetValue(10)), 0, StrRs1.GetValue(10)), "0.00")
                    IntTotExp = IIf(IsDBNull(StrRs1.GetValue(12)), 0, StrRs1.GetValue(12))

                    StrMfdMonth = Now.Month
                    strmfmonth = StrMfdMonth.ToString("00")

                    StrMfdYear = Now.Year
                    strmfyear = StrMfdYear.ToString("0000")

                    StrExpMonth = StrMfdMonth - 1
                    strexmonth = StrExpMonth.ToString("00")

                    StrExpYear = StrMfdYear + IntTotExp
                    strexyear = StrExpYear.ToString("0000")

                    If StrExpMonth = 0 Then
                        strexmonth = (12).ToString("00")
                        strexyear = (StrExpYear - 1).ToString("0000")
                    End If

                    LblShowMfdDate.Text = strmfyear & "-" & strmfmonth
                    LblShowExpDate.Text = strexyear & "-" & strexmonth

                Else
                    MsgBox("No Data Found", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                StrRs1.Close()
                cmd.Dispose()


                strsql = ("SELECT  Qty  from  PMMAPowerSegregationChild  where GlassyLotNo = '" & ComboBox1.Text & "'  ")
                cmd = New SqlCommand(strsql, con1)
                If con1.State = Data.ConnectionState.Open Then
                    con1.Close()
                End If
                con1.Open()
                StrRs1 = cmd.ExecuteReader
                'ComboBox2.Items.Clear()
                While StrRs1.Read
                    TextBox2.Text = (IIf(IsDBNull(StrRs1.GetValue(0)), "", StrRs1.GetValue(0)))
                    'Dim s As String = TextBox1.Text
                    'Dim word As String() = s.Split(New Char() {"/"c})

                    'CmbShModel.Text = word(1)
                    'CmbShPower.Text = word(3)
                    'CmbShBrand.Text = word(0)


                End While
                StrRs1.Close()
                cmd.Dispose()



            Else


                strsql = ("SELECT  distinct Product_Description  from work_In__Progress1  where LotNo = '" & ComboBox1.Text & "' ")
                cmd = New SqlCommand(strsql, con1)
                If con1.State = Data.ConnectionState.Open Then
                    con1.Close()
                End If
                con1.Open()
                StrRs1 = cmd.ExecuteReader
                'ComboBox2.Items.Clear()
                While StrRs1.Read

                    TextBox1.Text = (IIf(IsDBNull(StrRs1.GetValue(0)), "", StrRs1.GetValue(0)))
                    Dim s As String = TextBox1.Text
                    Dim word As String() = s.Split(New Char() {"/"c})

                    CmbShModel.Text = word(1)
                    CmbShPower.Text = word(3)
                    CmbShBrand.Text = word(0)

                End While
                StrRs1.Close()
                cmd.Dispose()



                'strsql = ("SELECT  sum(Accepted_Qty) as qty   from work_In__Progress1  where LotNo = '" & ComboBox1.Text & "' and   Process_Name  = 'PMA - FQI MICROSCOPIC INSPECTION'  ")
                'cmd = New SqlCommand(strsql, con1)
                'StrRs = cmd.ExecuteReader
                ''ComboBox2.Items.Clear()
                'While StrRs.Read
                '    TextBox2.Text = (IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
                '    'Dim s As String = TextBox1.Text
                '    'Dim word As String() = s.Split(New Char() {"/"c})

                '    'CmbShModel.Text = word(1)
                '    'CmbShPower.Text = word(3)
                '    'CmbShBrand.Text = word(0)


                'End While
                'StrRs.Close()
                'cmd.Dispose()



                strsql = ("SELECT  Qty  from  PMMAPowerSegregationChild  where GlassyLotNo = '" & ComboBox1.Text & "'  ")
                cmd = New SqlCommand(strsql, con1)
                If con1.State = Data.ConnectionState.Open Then
                    con1.Close()
                End If
                con1.Open()
                StrRs1 = cmd.ExecuteReader
                'ComboBox2.Items.Clear()
                While StrRs1.Read
                    TextBox2.Text = (IIf(IsDBNull(StrRs1.GetValue(0)), "", StrRs1.GetValue(0)))
                    'Dim s As String = TextBox1.Text
                    'Dim word As String() = s.Split(New Char() {"/"c})

                    'CmbShModel.Text = word(1)
                    'CmbShPower.Text = word(3)
                    'CmbShBrand.Text = word(0)  




                End While
                StrRs1.Close()
                cmd.Dispose()


                Dim labl As Integer



                labl = Convert.ToInt32(TextBox2.Text) / 2

                txtquantity.Text = labl




                TextBox3.Text = 0




                'strsql = ("SELECT  sum(Qty_1) as qty   from POUCH_LABEL  where GlassyLotno = '" & ComboBox1.Text & "' ")
                'cmd = New SqlCommand(strsql, con)
                'StrRs1 = cmd.ExecuteReader
                ''ComboBox2.Items.Clear()
                'While StrRs1.Read
                '    TextBox3.Text = (IIf(IsDBNull(StrRs1.GetValue(0)), "", StrRs1.GetValue(0)))
                '    'Dim s As String = TextBox1.Text
                '    'Dim word As String() = s.Split(New Char() {"/"c})

                '    'CmbShModel.Text = word(1)
                '    'CmbShPower.Text = word(3)
                '    'CmbShBrand.Text = word(0)


                'End While
                'StrRs1.Close()
                'cmd.Dispose()






                strsql = "SELECT * from LENS_MASTER1 where Model_Name='" & CmbShModel.Text & "' and   Brand_Name='" & CmbShBrand.Text & "' and power ='" & CmbShPower.Text & "'"
                cmd = New SqlCommand(strsql, con)
                If con.State = Data.ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                StrRs1 = cmd.ExecuteReader

                If StrRs1.Read Then

                    LblShowGSCode.Text = IIf(IsDBNull(StrRs1.GetValue(5)), "", StrRs1.GetValue(5))
                    LblShowPower.Text = Format(IIf(IsDBNull(StrRs1.GetValue(6)), 0, StrRs1.GetValue(6)), "0.00")
                    LblShowRefName.Text = IIf(IsDBNull(StrRs1.GetValue(4)), "", StrRs1.GetValue(4))
                    LblShowOptic.Text = Format(IIf(IsDBNull(StrRs1.GetValue(7)), "", StrRs1.GetValue(7)), "0.00")
                    LblShowLength.Text = Format(IIf(IsDBNull(StrRs1.GetValue(8)), "", StrRs1.GetValue(8)), "0.00")
                    LblShowGSType.Text = IIf(IsDBNull(StrRs1.GetValue(11)), "", StrRs1.GetValue(11))
                    LblshAConstant.Text = Format(IIf(IsDBNull(StrRs1.GetValue(10)), 0, StrRs1.GetValue(10)), "0.00")
                    IntTotExp = IIf(IsDBNull(StrRs1.GetValue(12)), 0, StrRs1.GetValue(12))

                    StrMfdMonth = Now.Month
                    strmfmonth = StrMfdMonth.ToString("00")

                    StrMfdYear = Now.Year
                    strmfyear = StrMfdYear.ToString("0000")

                    StrExpMonth = StrMfdMonth - 1
                    strexmonth = StrExpMonth.ToString("00")

                    StrExpYear = StrMfdYear + IntTotExp
                    strexyear = StrExpYear.ToString("0000")

                    If StrExpMonth = 0 Then
                        strexmonth = (12).ToString("00")
                        strexyear = (StrExpYear - 1).ToString("0000")
                    End If

                    LblShowMfdDate.Text = strmfyear & "-" & strmfmonth
                    LblShowExpDate.Text = strexyear & "-" & strexmonth

                Else
                    MsgBox("No Data Found", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                StrRs1.Close()
                cmd.Dispose()

                If (TextBox3.Text <> "") Then
                Else

                    TextBox3.Text = 0
                End If





            End If

            StrRs.Close()




        End If






    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Label25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label25.Click

    End Sub

    Private Sub Label28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Public Function SQL_SelectQuery_Execute(ByVal StrSql As String) As DataSet

        Dim ds As New DataSet
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Private Sub cmb_Order_Type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Order_Type.SelectedIndexChanged

        cmb_Order_Country.Text = ""
        strsql = "SELECT DISTINCT Order_Country from Pouch_Order_Country_Master  Where Order_Type='" & cmb_Order_Type.Text & "' order by Order_Country"
        Ds = SQL_SelectQuery_Execute(strsql)
        cmb_Order_Country.Items.Clear()
        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            cmb_Order_Country.Items.Add(eachRow1("Order_Country"))
        Next

    End Sub
End Class