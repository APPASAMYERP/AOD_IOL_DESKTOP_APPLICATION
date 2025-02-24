Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft
Imports System.Data.Sql

Public Class FrmNewPouchLablePrint
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


    Dim sql1 As String
    Private Sub FrmNewPouchLablePrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If

        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        StrSql = "SELECT DISTINCT Model_Name from LENS_MASTER order by Model_Name"
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        CmbShModel.Items.Clear()
        While StrRs.Read
            CmbShModel.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        Cmd.Dispose()


        StrSql = "SELECT DISTINCT Type from Lot_Type order by Type"
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        CmbType.Items.Clear()
        While StrRs.Read
            CmbType.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        Cmd.Dispose()

        LblShowLotPrefix.Text = ""
        LblShowLotNo.Text = ""

        lblShowMaxQty.Text = 0
        LblShowPrintedQty.Text = 0
        LblBalanceQty.Text = 0
        Label18.Visible = False
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

    Private Sub CmbShBrand_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbShBrand.SelectedIndexChanged


        If CmbShModel.Text = "SFE5" Or CmbShModel.Text = "SFC6" Or CmbShModel.Text = "SFC7" Or CmbShModel.Text = "SFAC6" Or CmbShModel.Text = "SFAC7" Or CmbShModel.Text = "HF01" Or CmbShModel.Text = "HF02" Or CmbShModel.Text = "HF03" Or CmbShModel.Text = "SCC6012" Or CmbShModel.Text = "CHY6013" Then


            CmbShType.Enabled = False
            StrSql = "SELECT * from LENS_MASTER where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "'  and Brand_Name='" & CmbShBrand.Text & "' "
            Cmd = New SqlCommand(StrSql, con)
            StrRs = Cmd.ExecuteReader

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
            Cmd.Dispose()

        Else

            CmbShType.Enabled = True

            If CmbShBrand.Text <> "" Then
                StrSql = "SELECT DISTINCT Type_GS_Code from LENS_MASTER where Brand_Name='" & CmbShBrand.Text & "' and Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' order by Type_GS_Code"
                Cmd = New SqlCommand(StrSql, con)
                StrRs = Cmd.ExecuteReader
                CmbShType.Items.Clear()
                CmbShType.Text = ""
                While StrRs.Read
                    CmbShType.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
                End While
                StrRs.Close()
                Cmd.Dispose()
            End If

        End If

    End Sub

    Private Sub CmbShModel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbShModel.SelectedIndexChanged
        If CmbShModel.Text <> "" Then
            StrSql = "SELECT DISTINCT POWER from LENS_MASTER where Model_Name='" & CmbShModel.Text & "' order by POWER"
            Cmd = New SqlCommand(StrSql, con)
            StrRs = Cmd.ExecuteReader

            CmbShPower.Items.Clear()
            CmbShBrand.Items.Clear()
            CmbShType.Items.Clear()

            CmbShPower.Text = ""
            CmbShBrand.Text = ""
            CmbShType.Text = ""

            txtcylsize.Text = "NULL"
            txtrpwr.Text = "NULL"

            While StrRs.Read
                CmbShPower.Items.Add(Format(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)), "0.00"))
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

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click


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


        If CmbShPower.Text = "" Then
            err.SetError(CmbShPower, "This information is required")
            CmbShPower.Focus()
            Exit Sub
        Else
            err.SetError(CmbShPower, "")
        End If


        If CmbShBrand.Text = "" Then
            err.SetError(CmbShBrand, "This information is required")
            Exit Sub
        Else
            err.SetError(CmbShBrand, "")
        End If


        If txtquantity.Text = "" Then
            err.SetError(txtquantity, "Enter Qty")
            Exit Sub
        Else
            err.SetError(txtquantity, "")
        End If

        If CmbShModel.Text = "SPMFDY200" Or CmbShModel.Text = "SPMFD200" Or CmbShModel.Text = "SUPRAPHOB MS" Then

            If txtcylsize.Text = "NULL" Then
                err.SetError(txtcylsize, "This should not be null")
                Exit Sub
            Else
                err.SetError(txtcylsize, "")
            End If
        End If

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
            If CmbType.Text = "Export-Turkey" Then
                StrSql = "Update LENS_LOT set Active='NO' where  type='Export' and Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "'"
                Cmd = New SqlCommand(StrSql, con)
                Cmd.ExecuteNonQuery()
                Cmd.Dispose()

                StrSql = "Update LENS_LOT set Active='NO',Modified_By='" & StrLoginUser & "',Modified_Date=GETDATE() where Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "' and type='Export'"
                Cmd = New SqlCommand(StrSql, con)
                Cmd.ExecuteNonQuery()
                Cmd.Dispose()

                Dim IntLot As Integer

                IntLot = Val(LblShowLotNo.Text) + 1
                LblShowLotNo.Text = IntLot.ToString

                StrSql = "Insert into LENS_LOT (Lot_Prefix,	Lot_No,Max_Qty,Printed_Qty,	Active,	Created_By,	Created_Date,	Modified_By,	Modified_Date,Type) VALUES   ( " & _
                        "'" & LblShowLotPrefix.Text & "','" & LblShowLotNo.Text & "','" & lblShowMaxQty.Text & "',0,'YES','" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),'Export')"
                Cmd = New SqlCommand(StrSql, con)
                Cmd.ExecuteNonQuery()
                Cmd.Dispose()

            Else
                StrSql = "Update LENS_LOT set Active='NO' where  type='" & CmbType.Text & "' and Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "'"
                Cmd = New SqlCommand(StrSql, con)
                Cmd.ExecuteNonQuery()
                Cmd.Dispose()

                StrSql = "Update LENS_LOT set Active='NO',Modified_By='" & StrLoginUser & "',Modified_Date=GETDATE() where Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "' and type='" & CmbType.Text & "'"
                Cmd = New SqlCommand(StrSql, con)
                Cmd.ExecuteNonQuery()
                Cmd.Dispose()

                Dim IntLot As Integer

                IntLot = Val(LblShowLotNo.Text) + 1
                LblShowLotNo.Text = IntLot.ToString

                StrSql = "Insert into LENS_LOT (Lot_Prefix,	Lot_No,Max_Qty,Printed_Qty,	Active,	Created_By,	Created_Date,	Modified_By,	Modified_Date,Type) VALUES   ( " & _
                        "'" & LblShowLotPrefix.Text & "','" & LblShowLotNo.Text & "','" & lblShowMaxQty.Text & "',0,'YES','" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),'" & CmbType.Text & "')"
                Cmd = New SqlCommand(StrSql, con)
                Cmd.ExecuteNonQuery()
                Cmd.Dispose()

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


        Dim StrFName As String

        If CmbShModel.Text = "SP-TORIC T3" Then
            strpwradd = CmbShPower.Text & " " & "D" & " " & "Adl Cyl 1.50"
        ElseIf CmbShModel.Text = "SP-TORIC T4" Then
            strpwradd = CmbShPower.Text & " " & "D" & " " & "Adl Cyl 2.25"
        ElseIf CmbShModel.Text = "SP-TORIC T5" Then
            strpwradd = CmbShPower.Text & " " & "D" & " " & "Adl Cyl 3.00"
        ElseIf CmbShModel.Text = "SP-TORIC T6" Then
            strpwradd = CmbShPower.Text & " " & "D" & " " & "Adl Cyl 3.75"
        ElseIf CmbShModel.Text = "SP-TORIC T7" Then
            strpwradd = CmbShPower.Text & " " & "D" & " " & "Adl Cyl 4.50"
        ElseIf CmbShModel.Text = "SP-TORIC T8" Then
            strpwradd = CmbShPower.Text & " " & "D" & " " & "Adl Cyl 5.25"
        ElseIf CmbShModel.Text = "SP-TORIC T9" Then
            strpwradd = CmbShPower.Text & " " & "D" & " " & "Adl Cyl 6.00"
        ElseIf CmbShModel.Text = "MFD605" Then
            strpwradd = CmbShPower.Text & " " & "D" & " " & "Adl 3.50 D"

        ElseIf CmbShModel.Text = "MFDY605" Then
            strpwradd = CmbShPower.Text & " " & "D" & " " & "Adl 3.50 D"



        ElseIf CmbShModel.Text = "SPMFD200" Then
            strpwradd = CmbShPower.Text & " " & "D" & " " & "Adl" & " " & txtcylsize.Text & " " & " D"

        ElseIf CmbShModel.Text = "SPMFDY200" Then
            strpwradd = CmbShPower.Text & " " & "D" & " " & "Adl" & " " & txtcylsize.Text & " " & " D"

            'ElseIf CmbShModel.Text = "SUPRAPHOB MS" Then
            '    strpwradd = CmbShPower.Text & " " & "D" & " " & "Adl" & " " & txtcylsize.Text & " " & " D"

            'ElseIf CmbShModel.Text = "SP INFO" Then
            '    strpwradd = CmbShPower.Text & " " & "D"
            'strpwradd = CmbShPower.Text & " " & "D" & " " & "Adl" & " " & txtcylsize.Text & " " & " D"



        Else
            strpwradd = CmbShPower.Text
        End If



        'If (CmbShModel.Text = "502") Or (CmbShModel.Text = "601") Or (CmbShModel.Text = "701") Or (CmbShModel.Text = "nAs207") Or (CmbShModel.Text = "nAsY207") Or (CmbShModel.Text = "701H") Or (CmbShModel.Text = "ULTRASMART") Then

        StrFName = "PouchPhilic.btw"

        If (CmbShModel.Text = "SPMFDY200" Or CmbShModel.Text = "SPMFD200") Then

            StrFName = "Pouch_MFD.btw"

        ElseIf (CmbShModel.Text = "SP-TORIC T3" Or CmbShModel.Text = "SP-TORIC T4" Or CmbShModel.Text = "SP-TORIC T5" Or CmbShModel.Text = "SP-TORIC T6" Or CmbShModel.Text = "SP-TORIC T7" Or CmbShModel.Text = "SP-TORIC T8" Or CmbShModel.Text = "SP-TORIC T9") Then

            StrFName = "Pouch_Toric.btw"

        ElseIf (CmbShModel.Text = "MFD605") Then

            StrFName = "Pouch.btw"

        ElseIf (CmbShModel.Text = "MFDY605") Then

            StrFName = "Pouch_Toric_MFD.btw"

            'StrFName = "Pouch.btw"  'For Chennai 

        ElseIf (CmbShModel.Text = "CENTERFIT" Or CmbShModel.Text = "CENTERFIX" Or CmbShModel.Text = "ULTRASMART" Or CmbShModel.Text = "M-DIFF") Then

            StrFName = "Galaxyfold_Pouch.btw"



        Else

            StrFName = "Pouch.btw"

        End If

        If RdoRef.Checked = True Then

            strrefname1 = LblShowRefName.Text
        Else
            strrefname1 = CmbShBrand.Text
        End If

        For StI As Integer = StrStPrQty To StrEnPrQty

            StrlotonlyNo = LblShowLotPrefix.Text & LblShowLotNo.Text

            StrlotBarNo = LblShowLotPrefix.Text & LblShowLotNo.Text & " " & Format(StrStPrQty, "000")

            If (CmbShModel.Text = "SPMFDY200") Or (CmbShModel.Text = "SPMFD200") Or (CmbShModel.Text = "SP-TORIC T3" Or CmbShModel.Text = "SP-TORIC T4" Or CmbShModel.Text = "SP-TORIC T5" Or CmbShModel.Text = "SP-TORIC T6" Or CmbShModel.Text = "SP-TORIC T7" Or CmbShModel.Text = "SP-TORIC T8" Or CmbShModel.Text = "SP-TORIC T9" Or CmbShModel.Text = "MFD605" Or CmbShModel.Text = "MFDY605") Then

                stroptic = LblShowOptic.Text & " " & "mm"
                strlength = LblShowLength.Text & " " & "mm"
                strpwr = CmbShPower.Text & " " & "D"


                btFile = Application.StartupPath & "\" & StrFName & ""

                bt = bApp.Formats.Open(btFile, , DefaultPrinterName)


                bt.SetNamedSubStringValue("Ref", CmbShModel.Text)
                bt.SetNamedSubStringValue("Pwr", strpwradd)
                bt.SetNamedSubStringValue("Brandname", strrefname1)
                'bt.SetNamedSubStringValue("SNo", StrlotBarNo)
                bt.SetNamedSubStringValue("LotNo", StrlotBarNo)
                bt.SetNamedSubStringValue("optic", stroptic)
                bt.SetNamedSubStringValue("Length", strlength)
                bt.SetNamedSubStringValue("Expdate", LblShowExpDate.Text)
                bt.SetNamedSubStringValue("mfddate", LblShowMfdDate.Text)

                bt.PrintOut()

                bt.Close()

                System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

            ElseIf (CmbShModel.Text = "CENTERFIT" Or CmbShModel.Text = "CENTERFIX" Or CmbShModel.Text = "ULTRASMART" Or CmbShModel.Text = "M-DIFF") Then

                'StrlotonlyNo = LblShowLotPrefix.Text & LblShowLotNo.Text

                StrlotBarNo = LblShowLotPrefix.Text & LblShowLotNo.Text & Format(StrStPrQty, "00000")

                stroptic = LblShowOptic.Text & " " & "mm"
                strlength = LblShowLength.Text & " " & "mm"
                strpwr = CmbShPower.Text & " " & "D"

                btFile = Application.StartupPath & "\" & StrFName & ""

                bt = bApp.Formats.Open(btFile, , DefaultPrinterName)


                bt.SetNamedSubStringValue("Ref", CmbShModel.Text)
                bt.SetNamedSubStringValue("Pwr", strpwradd)
                bt.SetNamedSubStringValue("Brandname", strrefname1)
                bt.SetNamedSubStringValue("LotNo", StrlotBarNo)
                bt.SetNamedSubStringValue("LotNo", StrlotBarNo)
                'bt.SetNamedSubStringValue("optic", stroptic)
                'bt.SetNamedSubStringValue("Length", strlength)
                'bt.SetNamedSubStringValue("Expdate", LblShowExpDate.Text)
                'bt.SetNamedSubStringValue("mfddate", LblShowMfdDate.Text)

                bt.PrintOut()

                bt.Close()

                System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)



            Else


                stroptic = LblShowOptic.Text & " " & "mm"
                strlength = LblShowLength.Text & " " & "mm"
                strpwr = CmbShPower.Text & " " & "D"
                ' strpwr = CmbShPower.Text


                btFile = Application.StartupPath & "\" & StrFName & ""

                bt = bApp.Formats.Open(btFile, , DefaultPrinterName)


                bt.SetNamedSubStringValue("Ref", CmbShModel.Text)
                bt.SetNamedSubStringValue("Pwr", strpwr)
                bt.SetNamedSubStringValue("Brandname", strrefname1)
                'bt.SetNamedSubStringValue("SNo", StrlotBarNo)
                bt.SetNamedSubStringValue("LotNo", StrlotBarNo)
                bt.SetNamedSubStringValue("optic", stroptic)
                bt.SetNamedSubStringValue("Length", strlength)
                bt.SetNamedSubStringValue("Expdate", LblShowExpDate.Text)
                bt.SetNamedSubStringValue("mfddate", LblShowMfdDate.Text)

                bt.PrintOut()

                bt.Close()

                System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)





            End If


            If rdobrand.Checked = True Then
                strsql = " insert into POUCH_LABEL (Brand_Name,Model_Name,Reference_Name,GS_Code,Power,Optic,Length,Lot_Unit," & _
                         "A_Constant,Type_GS_Code,Qty,St_SrNo,St_EnNo,Lot_Prefix,Lot_No,Lot_SrNo,Mfd_Month,Mfd_Year,Exp_Month,Exp_Year,Sterilization, " & _
                         "Sample_Taken,Type_Sample,BPL_Taken,Box_Packing,Dc_Packing,Created_By,Created_Date,Modified_By,Modified_Date,Sterilization_Reject,Qty_1,Type,Sterilization_After,Box_Reject,Print_Name,Btc_No,Cylsize) values ( " & _
                         "'" & CmbShBrand.Text & "','" & CmbShModel.Text & "','" & LblShowRefName.Text & "','" & LblShowGSCode.Text & "','" & CmbShPower.Text & "','" & LblShowOptic.Text & "','" & LblShowLength.Text & "' ," & _
                         "'mm','" & LblshAConstant.Text & "','" & LblShowGSType.Text & "','" & txtquantity.Text & "','" & StrStPrQty & "','" & StrEnPrQty & "','" & LblShowLotPrefix.Text & "','" & LblShowLotNo.Text & "','" & StrlotBarNo & "' , " & _
                         "'" & strmfmonth & "','" & strmfyear & "','" & strexmonth & "','" & strexyear & "',0,0,'NO',0,0,0,'" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),0,1,'" & CmbType.Text & "',0,0,'" & CmbShBrand.Text & "','" & txtbtc.Text & "','" & txtcylsize.Text & "')"

                cmd = New SqlCommand(strsql, con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

            Else
                strsql = " insert into POUCH_LABEL (Brand_Name,Model_Name,Reference_Name,GS_Code,Power,Optic,Length,Lot_Unit," & _
                         "A_Constant,Type_GS_Code,Qty,St_SrNo,St_EnNo,Lot_Prefix,Lot_No,Lot_SrNo,Mfd_Month,Mfd_Year,Exp_Month,Exp_Year,Sterilization, " & _
                         "Sample_Taken,Type_Sample,BPL_Taken,Box_Packing,Dc_Packing,Created_By,Created_Date,Modified_By,Modified_Date,Sterilization_Reject,Qty_1,Type,Sterilization_After,Box_Reject,Print_Name,Btc_No,Cylsize) values ( " & _
                         "'" & CmbShBrand.Text & "','" & CmbShModel.Text & "','" & LblShowRefName.Text & "','" & LblShowGSCode.Text & "','" & CmbShPower.Text & "','" & LblShowOptic.Text & "','" & LblShowLength.Text & "' ," & _
                         "'mm','" & LblshAConstant.Text & "','" & LblShowGSType.Text & "','" & txtquantity.Text & "','" & StrStPrQty & "','" & StrEnPrQty & "','" & LblShowLotPrefix.Text & "','" & LblShowLotNo.Text & "','" & StrlotBarNo & "' , " & _
                         "'" & strmfmonth & "','" & strmfyear & "','" & strexmonth & "','" & strexyear & "',0,0,'NO',0,0,0,'" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),0,1,'" & CmbType.Text & "',0,0,'" & LblShowRefName.Text & "','" & txtbtc.Text & "','" & txtcylsize.Text & "')"

                cmd = New SqlCommand(strsql, con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

            End If


            If CmbType.Text = "Export-Turkey" Then
                strsql = "Update LENS_LOT set Printed_Qty='" & StrStPrQty & "' where Active='YES' and type='Export' and Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "'"
                cmd = New SqlCommand(strsql, con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Else
                strsql = "Update LENS_LOT set Printed_Qty='" & StrStPrQty & "' where Active='YES' and type='" & CmbType.Text & "' and Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "'"
                cmd = New SqlCommand(strsql, con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End If


            LblShowPrintedQty.Text = StrStPrQty
            LblBalanceQty.Text = Val(lblShowMaxQty.Text) - StrStPrQty


            If Val(LblBalanceQty.Text) = 0 Then

                If CmbType.Text = "Export-Turkey" Then

                    strsql = "Update LENS_LOT set Active='NO' where  type='Export' and Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "'"
                    cmd = New SqlCommand(strsql, con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    strsql = "Update LENS_LOT set Active='NO',Modified_By='" & StrLoginUser & "',Modified_Date=GETDATE() where Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "' and type='Export'"
                    cmd = New SqlCommand(strsql, con)
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
                    Dim stringlotno As String

                    IntLot = Val(LblShowLotNo.Text) + 1

                    stringlotno = IntLot.ToString("0000")
                    LblShowLotNo.Text = stringlotno

                    'LblShowLotNo.Text = String.Format(stringlotno, "000")

                    strsql = "Insert into LENS_LOT (Lot_Prefix,	Lot_No,Max_Qty,Printed_Qty,	Active,	Created_By,	Created_Date,	Modified_By,	Modified_Date,Type) VALUES   ( " & _
                            "'" & LblShowLotPrefix.Text & "','" & LblShowLotNo.Text & "','" & lblShowMaxQty.Text & "',0,'YES','" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),'" & CmbType.Text & "')"
                    cmd = New SqlCommand(strsql, con)
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

            StrStPrQty = Val(StrStPrQty) + 1

        Next

        clear()


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

    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
        Menulblmstdatacre.LblHomeMenuDisplyName.Visible = False
        Menulblmstdatacre.TimHomeSideDisply.Start()
        'RawPrinterHelper.SendFileToPrinter(DefaultPrinterName, Application.StartupPath & "\write.prn")
    End Sub


    Private Sub CmbShPower_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbShPower.SelectedIndexChanged
        If CmbShPower.Text <> "" Then
            StrSql = "SELECT DISTINCT Brand_Name from LENS_MASTER where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' order by Brand_Name"
            Cmd = New SqlCommand(StrSql, con)
            StrRs = Cmd.ExecuteReader

            CmbShBrand.Items.Clear()
            CmbShType.Items.Clear()

            CmbShBrand.Text = ""
            CmbShType.Text = ""
            While StrRs.Read
                CmbShBrand.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
            End While
            StrRs.Close()
            Cmd.Dispose()
        End If
    End Sub

    Private Sub CmbShType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbShType.SelectedIndexChanged
        If CmbShType.Text <> "" Then
            StrSql = "SELECT * from LENS_MASTER where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' and Type_GS_Code='" & CmbShType.Text & "' and Brand_Name='" & CmbShBrand.Text & "' "
            Cmd = New SqlCommand(StrSql, con)
            StrRs = Cmd.ExecuteReader

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
            Cmd.Dispose()
        End If
    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnl.Enter

    End Sub

    Private Sub CmbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbType.SelectedIndexChanged
        If CmbType.Text <> "" Then
            If CmbType.Text = "Export-Turkey" Then
                StrSql = "select Lot_Prefix,Lot_No,Max_Qty,Printed_Qty,(Max_Qty-Printed_Qty) as Balance_Qty,Active from LENS_LOT where Active='YES' and type='Export'"
                Cmd = New SqlCommand(StrSql, con)
                StrRs = Cmd.ExecuteReader
            Else
                StrSql = "select Lot_Prefix,Lot_No,Max_Qty,Printed_Qty,(Max_Qty-Printed_Qty) as Balance_Qty,Active from LENS_LOT where Active='YES' and type='" & CmbType.Text & "'"
                Cmd = New SqlCommand(StrSql, con)
                StrRs = Cmd.ExecuteReader
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
            Cmd.Dispose()
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


    End Sub



   
End Class