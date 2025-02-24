Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft
Imports System.Data.Sql
Imports System.Configuration

Public Class FrnNewGalaxyBoxPacking_Egypt
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
    Dim strrs As SqlDataReader
    Dim cmd As SqlCommand
    Dim strfilename As String
    Dim StrOnlyLot As String
    Dim strtype As String
    Dim strbdname As String
    Dim strpfile As String
    Dim Strrpwr As String
    Dim strrefpwr As String


    Dim StrLotNo, SqlIn, StrLotBarNo, StrLotPower, strbtcexpiry, StrOptic, StrLength, StrEanCode, StrUnit, EANCODE, StrMfDMonth, StrMfDYear, strcons, StrModel, StrExpmonth, StrExpYear, StrUni, StrMfD, StrExp As String
    Dim StrTwoDBar As String


    'Dim StrSql As String
    'Dim StrRs As SqlDataReader
    'Dim Cmd As New SqlCommand
    'Dim StrMfdMonth As Integer
    'Dim StrMfdYear As Integer
    'Dim StrExpMonth As Integer
    'Dim StrExpYear As Integer
    Dim IntTotExp As Integer
    Dim getdetail As String


    Dim read As SqlDataReader
    Dim sql As String

    Dim StrSqlSe1 As String
    Dim StrRsSe1 As SqlDataReader
    Dim StrStSrNo As String
    Dim StrEnSrNo As String
    Dim StrMaxQty As Integer
    Dim StrPrtedQty As Integer
    Dim StrPrQty As Integer
    Dim StrBalQty As Integer
    Dim Strmodel2 As String
    Dim StrStPrQty As Integer
    Dim StrEnPrQty As Integer

    Dim StrSqlSePr As String
    Dim StrRsSePr As SqlDataReader

    Dim StrLotPrefix As Integer
    Dim IntLotNo As Integer
    Dim StrLotSrNo As String
    Dim StrB As String
    Dim StrT As String
    Dim StrExDate As String
    Dim StrMfDate As String
    Dim StrPower As String
    Dim StrApwr As String
    Dim Stroptic1 As String
    Dim Strlength1 As String
    Dim StrLot1 As String
    Dim StrSno1 As String
    Dim strpwr As String
    'Dim mfdate As String
    'Dim expdate As String

    'Dim StrRpwr As String
    'Dim StrlotBarNo As String



    ''pANDIN 
    Dim strmonth As String
    Dim stryear As String
    Dim strmonth1 As String
    Dim stryear1 As String


    Dim strexpmonth1 As String
    Dim strexpyear1 As String
    Dim strexpsupdate As String

    Dim strmfdsupdate As String
    Dim cmd1 As SqlCommand
    Dim read1 As SqlDataReader

    Dim sql1 As String

    Dim strinj_ref As String
    Dim strinj_batch As String
    Dim strinjyear As String
    Dim strinjmonth As String
    Dim strinjmy As String
    Dim strinjmm As String


    Dim strinjmanf As String
    Dim strinjexp As String


    Private Sub FrnNewGalaxyBoxPacking_Egypt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpMFDDate.Value = System.DateTime.Today



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

        Chkupdate.Checked = True


        LblShowGSCode.Text = ""
        LblShowPower.Text = ""
        LblShowRefName.Text = ""
        LblShowOptic.Text = ""
        LblShowLength.Text = ""
        LblShowGSType.Text = ""
        LblshAConstant.Text = ""

        lblrpwr.Visible = False
        'cbxrpwr.Visible = False
        txtrpwr.Visible = False
        lblcylsz.Visible = False
        txtcylsize.Visible = False

    End Sub
    Private Sub CmbShBrand_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbShBrand.SelectedIndexChanged

        ' If CmbShModel.Text = "SFE5" Or CmbShModel.Text = "SFC6" Or CmbShModel.Text = "SFC7" Or CmbShModel.Text = "SFAC6" Or CmbShModel.Text = "SFAC7" Or CmbShModel.Text = "HF01" Or CmbShModel.Text = "HF02" Or CmbShModel.Text = "HF03" Or CmbShModel.Text = "SCC6012" Or CmbShModel.Text = "CHY6013" Then

        CmbShType.Enabled = True
        If productline = "PMMA" Then
            strsql = "SELECT * from LENS_MASTER1 where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "'  and Brand_Name='" & CmbShBrand.Text & "' "
        Else
            strsql = "SELECT * from LENS_MASTER where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "'  and Brand_Name='" & CmbShBrand.Text & "' "
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
                If rbExport.Checked Then
                    IntTotExp = 3
                End If
            End If

            StrMfDMonth = dtpMFDDate.Value.Month
            StrMfDYear = dtpMFDDate.Value.Year


            StrExpmonth = StrMfDMonth - 1
            StrExpYear = StrMfDYear + IntTotExp

            If StrExpmonth = 0 Then
                StrExpmonth = 12
                StrExpYear = StrExpYear - 1
            End If

            LblShowMfdDate.Text = StrMfDYear & "-" & StrMfDMonth
            LblShowExpDate.Text = StrExpYear & "-" & StrExpmonth

        Else
            MsgBox("No Data Found", MsgBoxStyle.Critical)
            Exit Sub
        End If
        strrs.Close()
        cmd.Dispose()



        'Else

        CmbShType.Enabled = True

        If CmbShBrand.Text <> "" Then
            If productline = "PMMA" Then
                strsql = "SELECT DISTINCT Type_GS_Code from LENS_MASTER1 where Brand_Name='" & CmbShBrand.Text & "' and Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' order by Type_GS_Code"
            Else
                strsql = "SELECT DISTINCT Type_GS_Code from LENS_MASTER where Brand_Name='" & CmbShBrand.Text & "' and Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' order by Type_GS_Code"
            End If
            cmd = New SqlCommand(strsql, con)
            strrs = cmd.ExecuteReader
            CmbShType.Items.Clear()
            CmbShType.Text = ""
            While strrs.Read
                CmbShType.Items.Add(IIf(IsDBNull(strrs.GetValue(0)), "", strrs.GetValue(0)))
            End While
            strrs.Close()
            cmd.Dispose()
        End If
        ' End If

    End Sub

    Private Sub CmbShModel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbShModel.SelectedIndexChanged
        If CmbShModel.Text <> "" Then
            If productline = "PMMA" Then
                strsql = "SELECT DISTINCT POWER from LENS_MASTER1 where Model_Name='" & CmbShModel.Text & "' order by POWER"
            Else
                strsql = "SELECT DISTINCT POWER from LENS_MASTER where Model_Name='" & CmbShModel.Text & "' order by POWER"
            End If
            cmd = New SqlCommand(strsql, con)
            strrs = cmd.ExecuteReader

            CmbShPower.Items.Clear()
            CmbShBrand.Items.Clear()
            CmbShType.Items.Clear()

            CmbShPower.Text = ""
            CmbShBrand.Text = ""
            CmbShType.Text = ""
            txtcylsize.Text = "NULL"
            txtrpwr.Text = "NULL"
            While strrs.Read
                CmbShPower.Items.Add(Format(IIf(IsDBNull(strrs.GetValue(0)), "", strrs.GetValue(0)), "0.00"))
            End While
            strrs.Close()
            cmd.Dispose()

            If CmbShModel.Text = "SCE" Or CmbShModel.Text = "PCE" Then
                lblrpwr.Visible = True
                txtrpwr.Visible = True
                lblcylsz.Visible = False
                txtcylsize.Visible = False
            Else
                lblrpwr.Visible = False
                txtrpwr.Visible = False
                lblcylsz.Visible = False
                txtcylsize.Visible = False
            End If

        End If

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        If txtlotprefix.Text = "" Then
            err.SetError(txtlotprefix, "This information is required")
            txtlotprefix.Focus()
            Exit Sub
        Else
            err.SetError(txtlotprefix, "")
        End If


        If txtlotno.Text = "" Then
            err.SetError(txtlotno, "This information is required")
            txtlotno.Focus()
            Exit Sub
        Else
            err.SetError(txtlotno, "")
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


        If Txt_btc.Text = "" Then
            err.SetError(Txt_btc, "This information is required")
            Exit Sub
        Else
            err.SetError(Txt_btc, "")
        End If



        If txtinj.Text = "" Then
            err.SetError(txtinj, "This information is required")
            Exit Sub
        Else
            err.SetError(txtinj, "")
        End If


        If txtstartqty.Text = "" Then
            err.SetError(txtstartqty, "Enter Qty")
            Exit Sub
        Else
            err.SetError(txtstartqty, "")
        End If

        StrPrQty = txtstartqty.Text



        StrPrQty = txtstartqty.Text
        StrEnPrQty = txtendqty.Text

        If Val(StrPrQty) <= 0 Then
            MsgBox("Enter Minimum 1 Qty")
            txtstartqty.Text = ""
            txtstartqty.Focus()
            Exit Sub
        End If
        If Val(StrEnPrQty) <= 0 Then
            MsgBox("Enter Minimum 1 Qty")
            txtendqty.Text = ""
            txtendqty.Focus()
            Exit Sub
        End If



        StrStSrNo = StrPrQty
        StrEnSrNo = StrEnPrQty

        Dim Count As Integer

        StrEnSrNo = StrEnSrNo + 1

        Count = StrEnSrNo - StrStSrNo

        Stroptic1 = LblShowOptic.Text
        Strlength1 = LblShowLength.Text

        StrLot1 = txtlotprefix.Text + txtlotno.Text

        If CmbShModel.Text = "AE-01" Then

            StrSno1 = Format(StrStSrNo, "00000")

        Else

            StrSno1 = Format(StrStSrNo, "000")

        End If

        Dim StrFName As String

        If CmbShModel.Text = "CENTERFIT" Then
            StrFName = "galaxyfold_cfit.btw"

        ElseIf CmbShModel.Text = "CENTERFIX" Then

            StrFName = "galaxyfold_cfix.btw"

        ElseIf CmbShModel.Text = "M-DIFF" Then

            StrFName = "galaxyfold_mdiff.btw"

        ElseIf CmbShModel.Text = "ULTRASMART" Then

            StrFName = "galaxyfold_utst.btw"

        ElseIf CmbShModel.Text = "601" Or CmbShModel.Text = "502" Or CmbShModel.Text = "701" Then

            StrFName = "ACRYFOLD_BT_MAX _7.btw"


        ElseIf CmbShModel.Text = "nAs207" Then

            StrFName = "NaSPRONEW.btw"

        ElseIf CmbShModel.Text = "nAsY207" Then

            StrFName = "NaSPRONEW-BBY.btw"

        ElseIf CmbShModel.Text = "SPNT300" Then

            StrFName = "SUPRA_PHOB.btw"

        ElseIf CmbShModel.Text = "SUPRAPHOB BBY" Then

            StrFName = "SUPRA_PHOB_BBY.btw"


        ElseIf CmbShBrand.Text = "HYDROPHOBIC FOLDABLE SINGLE PIECE INTRAOCULAR LENS" Then

            StrFName = "SUPRA_PHOB_INFO.btw"

        Else
            MsgBox("Select Correct Model No")

        End If



        For StI As Integer = StrPrQty To StrEnPrQty

            strexpsupdate = StrExDate
            strmfdsupdate = StrMfDate

            StrSno1 = Format(StI, "000")
            'StrLotBarNo = LblShowLotPrefix.Text & LblShowLotNo.Text

            StrLotBarNo = txtlotprefix.Text & txtlotno.Text & " " & StrSno1
            StrLot1 = txtlotprefix.Text & txtlotno.Text

            StrOptic = LblShowOptic.Text & " " & "mm"
            StrLength = LblShowLength.Text & " " & "mm"
            strpwr = CmbShPower.Text & " " & "D"

            StrTwoDBar = StrLotBarNo & "," & strpwr & "," & CmbShModel.Text & "," & CmbShBrand.Text & "," & StrOptic & "," & StrLength & "," & LblShowExpDate.Text & "," & Txt_btc.Text
            btFile = Application.StartupPath & "\" & StrFName & ""

            bt = bApp.Formats.Open(btFile, , DefaultPrinterName)

            bt.SetNamedSubStringValue("Model", CmbShModel.Text)
            bt.SetNamedSubStringValue("Pwr", strpwr)
            bt.SetNamedSubStringValue("EanCode", LblShowGSCode.Text)
            bt.SetNamedSubStringValue("Lot", Txt_btc.Text)
            bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
            bt.SetNamedSubStringValue("Opt1", StrOptic)
            bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
            bt.SetNamedSubStringValue("Len", StrLength)
            bt.SetNamedSubStringValue("Expdt", LblShowExpDate.Text)
            bt.SetNamedSubStringValue("mfdate", LblShowMfdDate.Text)
            bt.SetNamedSubStringValue("Inj_lot", txtinj.Text)

            bt.PrintOut()

            bt.Close()

            System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)


            StrSqlSe1 = "Select Lot_Srno from Pouch_Label where Lot_SrNo = '" & StrLotBarNo & "'"
            cmd = New SqlCommand(StrSqlSe1, con)
            StrRsSe1 = cmd.ExecuteReader


            If StrRsSe1.Read Then


                StrRsSe1.Close()


                If Chkupdate.Checked = True Then

                    SqlIn = "update POUCH_LABEL set Brand_Name = '" & CmbShBrand.Text & "',Model_Name = '" & CmbShModel.Text & "',GS_Code = '" & LblShowGSCode.Text & "',Power = '" & CmbShPower.Text & "',Optic = '" & LblShowOptic.Text & "',Length = '" & LblShowLength.Text & "',Box_Packing =1,Box_By='" & StrLoginUser & "',Box_Date=DATEADD(day, DATEDIFF(day, 0, GETDATE()),Boxtime = GETDATE()  where Lot_SrNo='" & StrLotBarNo & "' "
                    cmd = New SqlCommand(SqlIn, con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                End If


            Else
                StrRsSe1.Close()

                If CmbShModel.Text = "CENTERFIT" Or CmbShModel.Text = "CENTERFIX" Or CmbShModel.Text = "ULTRASMART" Or CmbShModel.Text = "M-DIFF" Then

                    strsql = " insert into POUCH_LABEL (Brand_Name,Model_Name,Reference_Name,GS_Code,Power,Optic,Length,Lot_Unit," & _
                                             "A_Constant,Type_GS_Code,Qty,St_SrNo,St_EnNo,Lot_Prefix,Lot_No,Lot_SrNo,Mfd_Month,Mfd_Year,Exp_Month,Exp_Year,Sterilization," & _
                                             "Sample_Taken,Type_Sample,BPL_Taken,Box_Packing,Dc_Packing,Box_Date,Boxtime,Created_By,Created_Date,Modified_By,Modified_Date,Sterilization_Reject,Qty_1,Sterilization_After,Box_Reject,Print_Name,R_Power,Cylsize,Btc_No) values ( " & _
                                             "'" & CmbShBrand.Text & "','" & CmbShModel.Text & "','" & LblShowRefName.Text & "','" & LblShowGSCode.Text & "','" & CmbShPower.Text & "','" & LblShowOptic.Text & "','" & LblShowLength.Text & "' ," & _
                                             "'mm','" & LblshAConstant.Text & "','" & LblShowGSType.Text & "','" & Count & "','" & StrPrQty & "','" & StrEnPrQty & "','" & txtlotprefix.Text & "','" & txtlotno.Text & "','" & StrLotBarNo & "' , " & _
                                             "'" & StrMfDMonth & "','" & StrMfDYear & "','" & StrExpmonth & "','" & StrExpYear & "',1,0,'NO',1,1,0,DATEADD(day, DATEDIFF(day, 0, GETDATE()), 0),GETDATE(),'" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),0,1,1,0,'" & CmbShBrand.Text & "','" & txtrpwr.Text & "','" & txtcylsize.Text & "','" & StrLot1 & "')"
                    cmd = New SqlCommand(strsql, con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                Else
                    StrRsSe1.Close()
                    strsql = " insert into POUCH_LABEL (Brand_Name,Model_Name,Reference_Name,GS_Code,Power,Optic,Length,Lot_Unit," & _
                                             "A_Constant,Type_GS_Code,Qty,St_SrNo,St_EnNo,Lot_Prefix,Lot_No,Lot_SrNo,Mfd_Month,Mfd_Year,Exp_Month,Exp_Year,Sterilization," & _
                                             "Sample_Taken,Type_Sample,BPL_Taken,Box_Packing,Dc_Packing,Box_Date,Boxtime,Created_By,Created_Date,Modified_By,Modified_Date,Sterilization_Reject,Qty_1,Sterilization_After,Box_Reject,Print_Name,R_Power,Cylsize,Btc_No,Injector_batch) values ( " & _
                                             "'" & CmbShBrand.Text & "','" & CmbShModel.Text & "','" & LblShowRefName.Text & "','" & LblShowGSCode.Text & "','" & CmbShPower.Text & "','" & LblShowOptic.Text & "','" & LblShowLength.Text & "' ," & _
                                             "'mm','" & LblshAConstant.Text & "','" & LblShowGSType.Text & "','" & Count & "','" & StrPrQty & "','" & StrEnPrQty & "','" & txtlotprefix.Text & "','" & txtlotno.Text & "','" & StrLotBarNo & "' , " & _
                                             "'" & StrMfDMonth & "','" & StrMfDYear & "','" & StrExpmonth & "','" & StrExpYear & "',1,0,'NO',1,1,0,DATEADD(day, DATEDIFF(day, 0, GETDATE()), 0),GETDATE(),'" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),0,1,1,0,'" & CmbShBrand.Text & "','" & txtrpwr.Text & "','" & txtcylsize.Text & "','" & Txt_btc.Text & "','" & txtinj.Text & "')"
                    cmd = New SqlCommand(strsql, con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                End If
            End If

            cmd.Dispose()
            StrRsSe1.Close()

        Next
        cmd.Dispose()

        '//Pandian//

        clear()

    End Sub
    Private Sub clear()

        Chkupdate.Checked = True
        CmbShBrand.Text = ""
        CmbShModel.Text = ""
        CmbShPower.Text = ""
        CmbShType.Text = ""
        txtstartqty.Text = ""
        txtendqty.Text = ""
        txtlotprefix.Text = ""
        txtlotno.Text = ""
        LblshAConstant.Text = ""
        LblShowMfdDate.Text = ""
        LblShowExpDate.Text = ""
        LblShowOptic.Text = ""
        LblShowGSCode.Text = ""
        LblShowLength.Text = ""
        LblShowPower.Text = ""
        LblShowRefName.Text = ""
        LblShowGSType.Text = ""


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



    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click

        Chkupdate.Checked = True
        CmbShBrand.Text = ""
        CmbShModel.Text = ""
        CmbShPower.Text = ""
        CmbShType.Text = ""
        txtstartqty.Text = ""
        txtendqty.Text = ""
        txtlotprefix.Text = ""
        txtlotno.Text = ""
        LblshAConstant.Text = ""
        LblShowMfdDate.Text = ""
        LblShowExpDate.Text = ""
        LblShowOptic.Text = ""
        LblShowGSCode.Text = ""
        LblShowLength.Text = ""
        LblShowPower.Text = ""
        LblShowRefName.Text = ""
        LblShowGSType.Text = ""
        Txt_btc.Text = ""
        txtinj.Text = ""


    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click

        Me.Close()
        Menulblmstdatacre.LblHomeMenuDisplyName.Visible = False
        Menulblmstdatacre.TimHomeSideDisply.Start()

        'RawPrinterHelper.SendFileToPrinter(DefaultPrinterName, Application.StartupPath & "\write.prn")
    End Sub


    Private Sub CmbShPower_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbShPower.SelectedIndexChanged
        If CmbShPower.Text <> "" Then
            If productline = "PMMA" Then
                strsql = "SELECT DISTINCT Brand_Name from LENS_MASTER1 where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' order by Brand_Name"
            Else
                strsql = "SELECT DISTINCT Brand_Name from LENS_MASTER where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' order by Brand_Name"
            End If
            cmd = New SqlCommand(strsql, con)
            strrs = cmd.ExecuteReader

            CmbShBrand.Items.Clear()
            CmbShType.Items.Clear()

            CmbShBrand.Text = ""
            CmbShType.Text = ""
            While strrs.Read
                CmbShBrand.Items.Add(IIf(IsDBNull(strrs.GetValue(0)), "", strrs.GetValue(0)))
            End While
            strrs.Close()
            cmd.Dispose()

        End If
    End Sub

    Private Sub CmbShType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbShType.SelectedIndexChanged
        If CmbShType.Text <> "" Then
            If productline = "PMMA" Then
                strsql = "SELECT * from LENS_MASTER1 where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' and Type_GS_Code='" & CmbShType.Text & "' and Brand_Name='" & CmbShBrand.Text & "' "
            Else
                strsql = "SELECT * from LENS_MASTER where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' and Type_GS_Code='" & CmbShType.Text & "' and Brand_Name='" & CmbShBrand.Text & "' "
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
                    If rbExport.Checked Then
                        IntTotExp = 3
                    End If
                End If

                StrMfDMonth = dtpMFDDate.Value.Month
                StrMfDYear = dtpMFDDate.Value.Year

                Dim strprefix, strmdl As String

                strmdl = CmbShModel.Text

                strprefix = txtlotprefix.Text
                ''//pandian
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



                '    ElseIf (strmdl = "SPNT200" Or strmdl = "HPNT200" Or strmdl = "SP-TORIC T3" Or strmdl = "SP-TORIC T4" Or strmdl = "SP-TORIC T5" Or strmdl = "SP-TORIC T6" Or strmdl = "SP-TORIC T7" Or strmdl = "SP-TORIC T8" Or strmdl = "SP-TORIC T9") Then
                '        If strmonth = "01" Then

                '            strmonth1 = strmonth
                '            stryear1 = Convert.ToString(Convert.ToInt32(stryear) + 2000)

                '            strexpmonth1 = Convert.ToString((Convert.ToUInt32(strmonth) - 1) + 12)
                '            strexpyear1 = Convert.ToString(Convert.ToInt32(stryear) + 2004)

                '        Else
                '            strmonth1 = strmonth
                '            stryear1 = Convert.ToString(Convert.ToInt32(stryear) + 2000)

                '            strexpyear1 = Convert.ToString(Convert.ToInt32(stryear) + 2005)

                '            strexpmonth1 = "0" & Convert.ToString(Convert.ToUInt32(strmonth - 1))

                '        End If


                '    ElseIf (strmdl = "AE-01") Then

                '        If StrMfDMonth = "1" Then


                '            strmonth1 = StrMfDMonth

                '            stryear1 = Format(Convert.ToString(Convert.ToInt32(StrMfDYear)), "00")


                '            strexpmonth1 = Format(Convert.ToString((Convert.ToUInt32(StrMfDMonth) - 1) + 12), "00")

                '            strexpyear1 = Format(Convert.ToString(Convert.ToInt32(StrMfDYear) + 4), "0000")

                '        Else
                '            strmonth1 = Format(StrMfDMonth, "00")

                '            stryear1 = Format(Convert.ToString(Convert.ToInt32(StrMfDYear)), "00")

                '            strexpyear1 = Format(Convert.ToString(Convert.ToInt32(StrMfDYear) + 5), "0000")

                '            strexpmonth1 = Format(Convert.ToString(Convert.ToUInt32(StrMfDMonth - 1)), "00")

                '        End If




                '    ElseIf (strmdl = "SPNT200MF") Then


                '        If strmonth = "01" Then

                '            strmonth1 = strmonth
                '            stryear1 = Convert.ToString(Convert.ToInt32(stryear) + 2000)

                '            strexpmonth1 = Convert.ToString((Convert.ToUInt32(strmonth) - 1) + 12)
                '            strexpyear1 = Convert.ToString(Convert.ToInt32(stryear) + 2004)

                '        Else
                '            strmonth1 = strmonth
                '            stryear1 = Convert.ToString(Convert.ToInt32(stryear) + 2000)

                '            strexpyear1 = Convert.ToString(Convert.ToInt32(stryear) + 2005)

                '            strexpmonth1 = "0" & Convert.ToString(Convert.ToUInt32(strmonth - 1))

                '        End If

                '    ElseIf (strmdl = "SCE") Then
                '        StrMfDMonth = Now.Month
                '        StrMfDYear = Now.Year


                '        StrExpmonth = StrMfDMonth - 1
                '        StrExpYear = StrMfDYear + IntTotExp

                '        If StrExpmonth = 0 Then
                '            StrExpmonth = 12
                '            StrExpYear = StrExpYear - 1
                '        End If

                '        LblShowMfdDate.Text = StrMfDMonth & "-" & StrMfDYear
                '        LblShowExpDate.Text = StrExpmonth & "-" & StrExpYear



                '    End If

                '    'StrExpmonth = StrMfDMonth - 1
                '    'StrExpYear = StrMfDYear + IntTotExp

                '    'If StrExpmonth = 0 Then
                '    '    StrExpmonth = 12
                '    '    StrExpYear = StrExpYear - 1
                '    'End If
                '    If (strmdl <> "SCE") Then
                '        LblShowMfdDate.Text = strmonth1 & "-" & stryear1
                '        LblShowExpDate.Text = strexpmonth1 & "-" & strexpyear1
                '    End If

                'Else

                '    StrExpmonth = StrMfDMonth - 1
                '    StrExpYear = StrMfDYear + IntTotExp

                '    If StrExpmonth = 0 Then
                '        StrExpmonth = 12
                '        StrExpYear = StrExpYear - 1
                '    End If
            End If
            strrs.Close()
            cmd.Dispose()
        End If
        txtlotprefix.Focus()

    End Sub




    'Private Sub txtlotbarno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)


    '    If txtlotbarno.Text <> "" Then

    '        If e.KeyCode = Keys.Enter Then


    '            strsql = "select Brand_Name,Power,Lot_SrNo,Exp_Month,Exp_Year,Optic,Length,Model_Name ,GS_Code,Btc_No,A_Constant from POUCH_LABEL where Lot_SrNo='" & txtlotbarno.Text & "' " & _
    '   "and Sterilization=1  and Sample_Taken=0 and BPL_Taken=1  and Dc_Packing=0 and Box_Reject=0 "
    '            cmd = New SqlCommand(strsql, con)
    '            If con.State = Data.ConnectionState.Open Then
    '                con.Close()
    '            End If
    '            con.Open()
    '            strrs = cmd.ExecuteReader
    '            If strrs.Read Then


    '                StrRefName = IIf(IsDBNull(strrs.GetValue(0)), "", strrs.GetValue(0))
    '                StrLotPower = IIf(IsDBNull(strrs.GetValue(1)), 0, strrs.GetValue(1))
    '                StrLotBarNo = IIf(IsDBNull(strrs.GetValue(2)), "", strrs.GetValue(2))
    '                StrExpmonth = Format(IIf(IsDBNull(strrs.GetValue(3)), "", strrs.GetValue(3)), "00")
    '                StrExpYear = IIf(IsDBNull(strrs.GetValue(4)), "", strrs.GetValue(4))
    '                StrOptic = Format(IIf(IsDBNull(strrs.GetValue(5)), 0, strrs.GetValue(5)), "0.00")
    '                StrLength = Format(IIf(IsDBNull(strrs.GetValue(6)), 0, strrs.GetValue(6)), "0.00")
    '                StrModel = IIf(IsDBNull(strrs.GetValue(7)), "", strrs.GetValue(7))
    '                EANCODE = IIf(IsDBNull(strrs.GetValue(8)), "", strrs.GetValue(8))
    '                StrLot1 = IIf(IsDBNull(strrs.GetValue(9)), "", strrs.GetValue(9))
    '                strcons = IIf(IsDBNull(strrs.GetValue(10)), "", strrs.GetValue(10))



    '                ' StrLotPrefix = IIf(IsDBNull(StrSeRs.GetValue(13)), 0, StrSeRs.GetValue(13))
    '                'StrLotSu = IIf(IsDBNull(StrSeRs.GetValue(14)), 0, StrSeRs.GetValue(14))


    '                'StrUnit = IIf(IsDBNull(StrSeRs.GetValue(8)), "", StrSeRs.GetValue(8))
    '                'StrMfDMonth = Format(IIf(IsDBNull(StrSeRs.GetValue(16)), "", StrSeRs.GetValue(16)), "00")
    '                'strmfdyear = IIf(IsDBNull(StrSeRs.GetValue(17)), "", StrSeRs.GetValue(17))

    '                'IntBoxPAck = IIf(IsDBNull(StrSeRs.GetValue(26)), 0, StrSeRs.GetValue(26))
    '                'GS_Type = IIf(IsDBNull(StrSeRs.GetValue(9)), 0, StrSeRs.GetValue(9))
    '                'strtype = IIf(IsDBNull(StrSeRs.GetValue(40)), 0, StrSeRs.GetValue(40))
    '                'Strbtc_No = IIf(IsDBNull(StrSeRs.GetValue(58)), 0, StrSeRs.GetValue(58))
    '                'Strprize = IIf(IsDBNull(StrSeRs.GetValue(55)), 0, StrSeRs.GetValue(55))
    '                'StrApwr = IIf(IsDBNull(StrSeRs.GetValue(65)), "", StrSeRs.GetValue(65))
    '                'Strcyl = IIf(IsDBNull(StrSeRs.GetValue(66)), "", StrSeRs.GetValue(66))

    '                ' StrAConst = Format(IIf(IsDBNull(StrSeRs.GetValue(8)), 0, StrSeRs.GetValue(8)), "0.00")

    '                ' StrEanCode = IIf(IsDBNull(StrSeRs.GetValue(3)), "", StrSeRs.GetValue(3))
    '                'strbdname = IIf(IsDBNull(StrSeRs.GetValue(0)), "", StrSeRs.GetValue(0))
    '                'Strrpwr = IIf(IsDBNull(StrSeRs.GetValue(52)), "", StrSeRs.GetValue(52))
    '            Else
    '                MsgBox(" Scan Correct Lot No")
    '                txtlotbarno.Text = ""
    '                txtlotbarno.Focus()
    '                strrs.Close()
    '                cmd.Dispose()
    '                Exit Sub
    '            End If
    '            strrs.Close()
    '            cmd.Dispose()


    '            strbtcexpiry = StrExpmonth & "-" & StrExpYear


    '            Dim StrFName As String


    '            If StrModel = "CENTERFIT" Then

    '                StrFName = "galaxyfold_cfit.btw"

    '            ElseIf StrModel = "CENTERFIX" Then

    '                StrFName = "galaxyfold_cfix.btw"

    '            ElseIf StrModel = "M-DIFF" Then

    '                StrFName = "galaxyfold_mdiff.btw"

    '            ElseIf StrModel = "ULTRASMART" Then

    '                StrFName = "galaxyfold_utst.btw"
    '            Else
    '                MsgBox("Select Correct Model No")

    '            End If




    '            StrOptic = StrOptic & " " & "mm"
    '            StrLength = StrLength & " " & "mm"
    '            strpwr = StrLotPower & " " & "D"

    '            StrTwoDBar = StrLotBarNo & "," & strpwr & "," & StrModel & "," & StrRefName & "," & StrOptic & "," & StrLength & "," & strbtcexpiry & "," & StrLot1

    '            btFile = Application.StartupPath & "\" & StrFName & ""

    '            bt = bApp.Formats.Open(btFile, , DefaultPrinterName)

    '            bt.SetNamedSubStringValue("Model", StrModel)
    '            bt.SetNamedSubStringValue("Pwr", strpwr)
    '            bt.SetNamedSubStringValue("EanCode", EANCODE)
    '            bt.SetNamedSubStringValue("Lot", StrLot1)
    '            bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
    '            bt.SetNamedSubStringValue("Opt1", StrOptic)
    '            bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
    '            bt.SetNamedSubStringValue("Len", StrLength)
    '            bt.SetNamedSubStringValue("Expdt", strbtcexpiry)
    '            'bt.SetNamedSubStringValue("mfddate", strmfdsupdate)

    '            bt.PrintOut()

    '            bt.Close()

    '            System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)




    '            SqlIn = "update POUCH_LABEL set Box_Packing =1,Box_By='" & StrLoginUser & "', Box_Date = DATEADD(Day, DATEDIFF(Day, 0, GETDATE()), 0) where Lot_SrNo='" & txtlotbarno.Text & "' "
    '            'SqlIn = "update POUCH_LABEL set Box_Packing =1,Box_By='" & StrLoginUser & "',Box_Date= GETDATE(),Boxtime = GETDATE() where Lot_SrNo='" & txtlotbarno.Text & "' "
    '            cmd = New SqlCommand(SqlIn, con)
    '            cmd.ExecuteNonQuery()
    '            cmd.Dispose()

    '            txtlotbarno.Text = ""


    '        End If
    '    End If

    'End Sub

    Private Sub Chkupdate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chkupdate.CheckedChanged

    End Sub

    Private Function CheckSerialNoExit(ByVal serialno As String) As Integer
        Dim ds As New DataSet
        strsql = "select * from Pouch_label where Lot_SrNo = '" & serialno & "'   "
        Dim cmd As New SqlCommand(strsql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)
        Return ds.Tables(0).Rows.Count
    End Function
 
    Private Sub GetSerialnoInformation(ByVal serialno As String)

        Dim strsql As String = "select * from Pouch_Label where Lot_SrNo = '" & serialno & "'"
        Dim ds As New DataSet
        Dim cmd As New SqlCommand(strsql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)
        For i = 0 To ds.Tables(0).Rows.Count - 1
            CmbShModel.Text = ds.Tables(0).Rows(0)("Model_Name")
            CmbShPower.Text = ds.Tables(0).Rows(0)("Power")
            CmbShBrand.Text = ds.Tables(0).Rows(0)("Brand_Name")
            CmbShType.Text = ds.Tables(0).Rows(0)("Type_GS_Code")
            'LblShowMfdDate.Text = ds.Tables(0).Rows(0)("Mfd_Year") & "-" & ds.Tables(0).Rows(0)("Mfd_Month")
            'LblShowExpDate.Text = ds.Tables(0).Rows(0)("Exp_Year") & "-" & ds.Tables(0).Rows(0)("Exp_Month")
            Txt_btc.Text = ds.Tables(0).Rows(0)("btc_no")
            txtinj.Text = IIf(IsDBNull(ds.Tables(0).Rows(0)("Injector_batch")), "", ds.Tables(0).Rows(0)("Injector_batch"))
            txtlotprefix.Text = ds.Tables(0).Rows(0)("Lot_Prefix")
            txtlotno.Text = ds.Tables(0).Rows(0)("Lot_No")
        Next

    End Sub

    Private Sub txtstartqty_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtstartqty.KeyDown


        Dim getserialno As String

        If (e.KeyCode = Keys.Enter) Then

            getserialno = txtstartqty.Text
            'GetSerialnoInformation(getserialno)

            'If txtlotprefix.Text <> "" And txtlotno.Text <> "" Then
            '    Dim str As String = getserialno.Split(" ")(0)
            '    If txtlotprefix.Text & txtlotno.Text <> str Then
            '        MessageBox.Show("Serial No. not matching with the Prefix and LotNo!!!", "Serial No Scan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '        Exit Sub
            '    End If
            'Else
            '    MessageBox.Show("Enter the Prefix and LotNo before scanning", "Serial No Scan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If

            If getserialno <> "" Then


                Dim conString1 As String = ConfigurationSettings.AppSettings("conStrAPSBOX").ToString()
                Dim con1 As SqlConnection
                con1 = New SqlConnection(conString1)
                Try
                    con1.Open()
                Catch ex As Exception

                    MsgBox(ex.Message)

                End Try


                ' check the serial no exist already
                Dim ds As New DataSet
                strsql = "select * from Pouch_label where Lot_SrNo = '" & getserialno & "'   "
                Dim cmd As New SqlCommand(strsql, con1)
                Dim ad As New SqlDataAdapter(cmd)
                ad.Fill(ds)
                If ds.Tables(0).Rows.Count >= 1 Then
                    If Chkupdate.Checked = False Then
                        MessageBox.Show("Serial No Scanned already!!!", "Serial No Scan", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtstartqty.Text = ""
                        txtstartqty.Focus()
                        Exit Sub
                    End If

                    CmbShModel.Text = ds.Tables(0).Rows(0)("Model_Name")
                    CmbShPower.Text = ds.Tables(0).Rows(0)("Power")
                    CmbShBrand.Text = ds.Tables(0).Rows(0)("Brand_Name")
                    CmbShType.Text = ds.Tables(0).Rows(0)("Type_GS_Code")
                    LblShowMfdDate.Text = ds.Tables(0).Rows(0)("Mfd_Year") & "-" & Format(ds.Tables(0).Rows(0)("Mfd_Month"), "00")
                    LblShowExpDate.Text = ds.Tables(0).Rows(0)("Exp_Year") & "-" & Format(ds.Tables(0).Rows(0)("Exp_Month"), "00")
                    Txt_btc.Text = ds.Tables(0).Rows(0)("btc_no")
                    txtinj.Text = IIf(IsDBNull(ds.Tables(0).Rows(0)("Injector_batch")), "", ds.Tables(0).Rows(0)("Injector_batch"))
                    txtlotprefix.Text = ds.Tables(0).Rows(0)("Lot_Prefix")
                    txtlotno.Text = ds.Tables(0).Rows(0)("Lot_No")

                    'txtstartqty.Text = ""
                    'txtstartqty.Focus()
                    '
                End If



                'check injecter exist  ------------------------------------             
                Dim StrSelInj As String = "SELECT Inj_ref,Str_batch,Exp_year,Exp_Month,Mfd_Year,Mfd_Month from Injector_Label where Str_batch = '" & txtinj.Text & "' "
                cmd = New SqlCommand(StrSelInj, con)
                Dim dsinj As New DataSet
                Dim add As New SqlDataAdapter(cmd)
                add.Fill(dsinj)
                If dsinj.Tables(0).Rows.Count <> 0 Then
                    strinj_ref = IIf(IsDBNull(dsinj.Tables(0).Rows(0)(0)), "", dsinj.Tables(0).Rows(0)(0))
                    strinj_batch = IIf(IsDBNull(dsinj.Tables(0).Rows(0)(1)), "", dsinj.Tables(0).Rows(0)(1))
                    strinjyear = IIf(IsDBNull(dsinj.Tables(0).Rows(0)(2)), "", dsinj.Tables(0).Rows(0)(2))
                    strinjmonth = IIf(IsDBNull(dsinj.Tables(0).Rows(0)(3)), "", dsinj.Tables(0).Rows(0)(3))
                    strinjmy = IIf(IsDBNull(dsinj.Tables(0).Rows(0)(4)), "", dsinj.Tables(0).Rows(0)(4))
                    strinjmm = IIf(IsDBNull(dsinj.Tables(0).Rows(0)(5)), "", dsinj.Tables(0).Rows(0)(5))

                    'Else
                    '    MsgBox(" Scan Correct Lot No")
                    '    txtinj.Text = ""
                    '    txtinj.Focus()
                    '    Exit Sub
                End If
                strinjmanf = strinjmy & "-" & strinjmm
                strinjexp = strinjyear & "-" & strinjmonth
                '-----------------------------------------------------------------


                Stroptic1 = LblShowOptic.Text
                Strlength1 = LblShowLength.Text

                StrLot1 = txtlotprefix.Text + txtlotno.Text



                Dim StrFName As String

                If CmbShModel.Text = "CENTERFIT" Then
                    StrFName = "galaxyfold_cfit.btw"

                ElseIf CmbShModel.Text = "CENTERFIX" Then

                    StrFName = "galaxyfold_cfix.btw"

                ElseIf CmbShModel.Text = "M-DIFF" Then

                    StrFName = "galaxyfold_mdiff.btw"

                ElseIf CmbShModel.Text = "ULTRASMART" Then

                    StrFName = "galaxyfold_utst.btw"

                ElseIf CmbShModel.Text = "601" Or CmbShModel.Text = "502" Or CmbShModel.Text = "701" Then
                    If rbExportNormal.Checked Or rbExport.Checked Then
                        StrFName = "ACRYFOLD_BT_EXPORT_EGYPT.btw"
                    Else
                        StrFName = "ACRYFOLD_BT_MAX _7.btw"
                    End If

                ElseIf CmbShModel.Text = "SFAC6" Then
                    StrFName = "SWUHHDD.btw"


                ElseIf CmbShModel.Text = "nAs207" Then

                    'StrFName = "NaSPRONEW.btw"
                    If rbExportNormal.Checked Or rbExport.Checked Then
                        StrFName = "NaSPRONEW_EXPORT.btw"
                    Else
                        StrFName = "NaSPRONEW.btw"
                    End If


                ElseIf CmbShModel.Text = "nAsY207" Then
                    ' StrFName = "NaSPRONEW-BBY.btw"
                    If rbExportNormal.Checked Or rbExport.Checked Then
                        StrFName = "NaSPRONEW-BBY_EXPORT.btw"
                    Else
                        StrFName = "NaSPRONEW-BBY.btw"
                    End If

                ElseIf CmbShBrand.Text = "SUPRAPHOB" And CmbShModel.Text = "SPNT300" Then

                    StrFName = "SUPRA_PHOB.btw"

                ElseIf CmbShModel.Text = "SUPRAPHOB BBY" Then

                    StrFName = "SUPRA_PHOB_BBY.btw"

                ElseIf CmbShModel.Text = "SPH60130" Then

                    StrFName = "SWISSPHOB.btw"

                ElseIf CmbShModel.Text = "SPNT300-PL" Then
                    If rbExportNormal.Checked Or rbExport.Checked Then
                        StrFName = "SUPRA_PHOB_THAILAND.btw"
                    Else
                        StrFName = "SUPRA_PHOB_PL.btw"
                    End If

                ElseIf CmbShModel.Text = "SP INFO" Then

                    StrFName = "SUPRA_PHOB_INFO.btw"


                ElseIf CmbShBrand.Text = "HYDROPHOBIC FOLDABLE SINGLE PIECE INTRAOCULAR LENS" And CmbShModel.Text = "SPNT300" Then

                    StrFName = "SUPRA_PHOB_NP.btw"

                ElseIf CmbShBrand.Text = "APPALENS" Then
                    StrFName = "APPALENSAOD2.btw"

                ElseIf CmbShBrand.Text = "LIBERTY IRIS CLAW LENS" Then
                    StrFName = "LIBERTYLENS CLAW.btw"

                ElseIf CmbShBrand.Text = "APPALENS PLUS" Then
                    StrFName = "APPALENS PLUS.btw"

                ElseIf CmbShBrand.Text = "LIBERTY CAPSULAR RETRACTOR" Then
                    StrFName = "LIBERTYLENS CLAW.btw"

                ElseIf CmbShBrand.Text = "LIBERTY RINGS" Then
                    StrFName = "ring.btw"

                ElseIf CmbShBrand.Text = "HEERALENS" Then
                    StrFName = "APPALENSAOD2.btw"

                ElseIf CmbShBrand.Text = "SWISS LENS" Then
                    StrFName = "SWISSLENS.btw"

                ElseIf CmbShBrand.Text = "LIBERTYLENS" Then
                    StrFName = "LIBERTYLENS.btw"

                Else
                    MsgBox("Select Correct Model No")

                End If



                'For StI As Integer = StrPrQty To StrEnPrQty

                strexpsupdate = StrExDate
                strmfdsupdate = StrMfDate

                'StrSno1 = Format(StI, "000")
                'StrLotBarNo = LblShowLotPrefix.Text & LblShowLotNo.Text

                'StrLotBarNo = txtlotprefix.Text & txtlotno.Text & " " & StrSno1
                StrLotBarNo = txtstartqty.Text
                StrLot1 = txtlotprefix.Text & txtlotno.Text

                StrOptic = LblShowOptic.Text & " " & "mm"
                StrLength = LblShowLength.Text & " " & "mm"
                strpwr = CmbShPower.Text & " " & "D"

                StrTwoDBar = txtstartqty.Text & "," & strpwr & "," & CmbShModel.Text & "," & CmbShBrand.Text & "," & StrOptic & "," & StrLength & "," & LblShowExpDate.Text & "," & Txt_btc.Text
                btFile = Application.StartupPath & "\" & StrFName & ""

                bt = bApp.Formats.Open(btFile, , DefaultPrinterName)

                bt.SetNamedSubStringValue("Model", CmbShModel.Text)
                bt.SetNamedSubStringValue("Pwr", strpwr)
                bt.SetNamedSubStringValue("EanCode", LblShowGSCode.Text)
                bt.SetNamedSubStringValue("Lot", Txt_btc.Text)
                bt.SetNamedSubStringValue("LotSr", txtstartqty.Text)
                bt.SetNamedSubStringValue("Opt1", StrOptic)
                bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                bt.SetNamedSubStringValue("Len", StrLength)
                bt.SetNamedSubStringValue("Expdt", LblShowExpDate.Text)
                bt.SetNamedSubStringValue("mfdate", LblShowMfdDate.Text)
                bt.SetNamedSubStringValue("Inj_lot", txtinj.Text)

                'bt.SetNamedSubStringValue("Inj_ref", strinj_ref)
                'bt.SetNamedSubStringValue("injexp", strinjexp)

                bt.PrintOut()

                bt.Close()

                System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)



                'StrSqlSe1 = "Select Lot_Srno from Pouch_Label where Lot_SrNo = '" & txtstartqty.Text & "'"
                'cmd = New SqlCommand(StrSqlSe1, con1)
                'StrRsSe1 = cmd.ExecuteReader


                'If StrRsSe1.Read Then


                '    StrRsSe1.Close()


                '    If Chkupdate.Checked = True Then

                '        'SqlIn = "update POUCH_LABEL set Brand_Name = '" & CmbShBrand.Text & "',Model_Name = '" & CmbShModel.Text & "',GS_Code = '" & LblShowGSCode.Text & "',Power = '" & CmbShPower.Text & "',Optic = '" & LblShowOptic.Text & "',Length = '" & LblShowLength.Text & "',Box_Packing =1,Box_By='" & StrLoginUser & "' where Lot_SrNo='" & txtstartqty.Text & "' "
                '        'cmd = New SqlCommand(SqlIn, con1)
                '        'cmd.ExecuteNonQuery()
                '        'cmd.Dispose()

                '    End If


                'Else
                '    StrRsSe1.Close()

                '    If CmbShModel.Text = "CENTERFIT" Or CmbShModel.Text = "CENTERFIX" Or CmbShModel.Text = "ULTRASMART" Or CmbShModel.Text = "M-DIFF" Then

                '        strsql = " insert into POUCH_LABEL (Brand_Name,Model_Name,Reference_Name,GS_Code,Power,Optic,Length,Lot_Unit," & _
                '                                 "A_Constant,Type_GS_Code,Qty,St_SrNo,St_EnNo,Lot_Prefix,Lot_No,Lot_SrNo,Mfd_Month,Mfd_Year,Exp_Month,Exp_Year,Sterilization," & _
                '                                 "Sample_Taken,Type_Sample,BPL_Taken,Box_Packing,Dc_Packing,Box_Date,Boxtime,Created_By,Created_Date,Modified_By,Modified_Date,Sterilization_Reject,Qty_1,Sterilization_After,Box_Reject,Print_Name,R_Power,Cylsize,Btc_No) values ( " & _
                '                                 "'" & CmbShBrand.Text & "','" & CmbShModel.Text & "','" & LblShowRefName.Text & "','" & LblShowGSCode.Text & "','" & CmbShPower.Text & "','" & LblShowOptic.Text & "','" & LblShowLength.Text & "' ," & _
                '                                 "'mm','" & LblshAConstant.Text & "','" & LblShowGSType.Text & "','" & 1 & "','" & StrPrQty & "','" & StrEnPrQty & "','" & txtlotprefix.Text & "','" & txtlotno.Text & "','" & StrLotBarNo & "' , " & _
                '                                 "'" & StrMfDMonth & "','" & StrMfDYear & "','" & StrExpmonth & "','" & StrExpYear & "',1,0,'NO',1,1,0,DATEADD(day, DATEDIFF(day, 0, GETDATE()), 0),GETDATE(),'" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),0,1,1,0,'" & CmbShBrand.Text & "','" & txtrpwr.Text & "','" & txtcylsize.Text & "','" & StrLot1 & "')"
                '        cmd = New SqlCommand(strsql, con1)
                '        cmd.ExecuteNonQuery()
                '        cmd.Dispose()

                '    Else
                '        StrRsSe1.Close()
                '        strsql = " insert into POUCH_LABEL (Brand_Name,Model_Name,Reference_Name,GS_Code,Power,Optic,Length,Lot_Unit," & _
                '                                 "A_Constant,Type_GS_Code,Qty,St_SrNo,St_EnNo,Lot_Prefix,Lot_No,Lot_SrNo,Mfd_Month,Mfd_Year,Exp_Month,Exp_Year,Sterilization," & _
                '                                 "Sample_Taken,Type_Sample,BPL_Taken,Box_Packing,Dc_Packing,Box_Date,Boxtime,Created_By,Created_Date,Modified_By,Modified_Date,Sterilization_Reject,Qty_1,Sterilization_After,Box_Reject,Print_Name,R_Power,Cylsize,Btc_No,Injector_batch,box_by,station) values ( " & _
                '                                 "'" & CmbShBrand.Text & "','" & CmbShModel.Text & "','" & LblShowRefName.Text & "','" & LblShowGSCode.Text & "','" & CmbShPower.Text & "','" & LblShowOptic.Text & "','" & LblShowLength.Text & "' ," & _
                '                                 "'mm','" & LblshAConstant.Text & "','" & LblShowGSType.Text & "','" & 1 & "','" & StrPrQty & "','" & StrEnPrQty & "','" & txtlotprefix.Text & "','" & txtlotno.Text & "','" & txtstartqty.Text & "' , " & _
                '                                 "'" & StrMfDMonth & "','" & StrMfDYear & "','" & StrExpmonth & "','" & StrExpYear & "',1,0,'NO',1,1,0,DATEADD(day, DATEDIFF(day, 0, GETDATE()), 0),GETDATE(),'" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),0,1,1,0,'" & CmbShBrand.Text & "','" & txtrpwr.Text & "','" & txtcylsize.Text & "','" & Txt_btc.Text & "','" & txtinj.Text & "','" & StrLoginUser & "','" & station & "')"
                '        cmd = New SqlCommand(strsql, con1)
                '        cmd.ExecuteNonQuery()
                '        cmd.Dispose()

                '    End If
                'End If

                cmd.Dispose()
                'StrRsSe1.Close()
                con1.Close()
                txtstartqty.Text = ""
                txtstartqty.Focus()
                clear()
                Exit Sub
            Else
                MsgBox(" Scan Correct Lot No")
                txtstartqty.Focus()
                'strInjRs.Close()
                cmd.Dispose()
                Exit Sub
            End If

                '//Pandian//




            End If

        txtstartqty.Focus()
    End Sub




    Private Sub dtpMFDDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpMFDDate.ValueChanged

    End Sub

    Private Sub CmbShType_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbShType.TextChanged
        If CmbShType.Text <> "" Then
            If productline = "PMMA" Then
                strsql = "SELECT * from LENS_MASTER1 where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' and Type_GS_Code='" & CmbShType.Text & "' and Brand_Name='" & CmbShBrand.Text & "' "
            Else
                strsql = "SELECT * from LENS_MASTER where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "' and Type_GS_Code='" & CmbShType.Text & "' and Brand_Name='" & CmbShBrand.Text & "' "
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
                    If rbExport.Checked Then
                        IntTotExp = 3
                    End If
                End If

                StrMfDMonth = dtpMFDDate.Value.Month
                StrMfDYear = dtpMFDDate.Value.Year

                Dim strprefix, strmdl As String

                strmdl = CmbShModel.Text

                strprefix = txtlotprefix.Text
                ''//pandian
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
        End If
        txtlotprefix.Focus()
    End Sub
End Class