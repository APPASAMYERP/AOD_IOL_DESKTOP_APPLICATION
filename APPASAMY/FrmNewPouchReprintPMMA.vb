Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft
Imports System.Data.Sql



Public Class FrmNewPouchReprintPMMA
    Dim StrSql As String
    Dim StrRs As SqlDataReader
    Dim strmfdmon, strmfdyear, strmfd As String
    Dim Cmd As New SqlCommand
    Dim bApp As New BarTender.Application
    Dim bt As New BarTender.Format
    Dim btFile As String
    Dim bApp1 As New BarTender.Application
    Dim bt1 As New BarTender.Format
    Dim btFile1 As String
    Dim StrOptic, strpwradd, StrRefName, StrScanTwoD, StrScanLotNo, Strcyl, StrLen, StrPwr, StrRef, StrExp, StrBrand, StrLotPrefix, StrLotNo, StrSrNo, StrEpMon, StrEpYr, StrMdl, Strbtc, StrlotBarNo, StroneDBar, StrSronlyNo, strrefname1 As String

    

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
        Menulblmstdatacre.LblHomeMenuDisplyName.Visible = False
        Menulblmstdatacre.TimHomeSideDisply.Start()
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        txtcrFromQty.Text = ""
        txtcrToQty.Text = ""
    End Sub


    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click

        If txtcrFromQty.Text = "" Then
            err.SetError(txtcrFromQty, "This information is required")
            txtcrFromQty.Focus()
            Exit Sub
        Else
            err.SetError(txtcrFromQty, "")
        End If



        If txtcrToQty.Text = "" Then
            err.SetError(txtcrToQty, "This information is required")
            txtcrToQty.Focus()
            Exit Sub
        Else
            err.SetError(txtcrToQty, "")
        End If


        StrSql = "select * from  POUCH_LABEL where Lot_SrNo Between '" & txtcrFromQty.Text & "' and '" & txtcrToQty.Text & "' order by  Lot_SrNo "
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        If StrRs.Read Then
            'StrRs.Close()
        Else
            MsgBox("No Data Found", MsgBoxStyle.Critical)
            Exit Sub
        End If
        StrRs.Close()
        Cmd.Dispose()



        StrSql = "select * from  POUCH_LABEL where Lot_SrNo Between '" & txtcrFromQty.Text & "' and '" & txtcrToQty.Text & "' order by  Lot_SrNo "
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader


        'Dim StrFName As String
        'StrFName = "Pouch.btw"
        'Dim writePRN As New StreamWriter(Application.StartupPath & "\write.prn")

        While StrRs.Read

            Dim StrFName As String
            StrRef = IIf(IsDBNull(StrRs.GetValue(1)), "", StrRs.GetValue(1))

            ' If (StrRef = "502") Or (StrRef = "601") Or (StrRef = "701") Or (StrRef = "nAs207") Or (StrRef = "nAsY207") Or (StrRef = "701H") Or (StrRef = "ULTRASMART") Then



            'If (StrRef = "SPMFDY200") Or (StrRef = "SPMFD200") Or (StrRef = "SUPRAPHOB MS") Or (StrRef = "SP INFO") Then

            '    StrFName = "Pouch_MFD.btw"

            'ElseIf (StrRef = "SP-TORIC T3" Or StrRef = "SP-TORIC T4" Or StrRef = "SP-TORIC T5" Or StrRef = "SP-TORIC T6" Or StrRef = "SP-TORIC T7" Or StrRef = "SP-TORIC T8" Or StrRef = "SP-TORIC T9") Then

            '    StrFName = "Pouch_Toric.btw"

            'ElseIf (StrRef = "MFD605") Then

            '    StrFName = "Pouch.btw"

            'ElseIf (StrRef = "MFDY605") Then

            '    StrFName = "Pouch_Toric_MFD.btw"

            'ElseIf (StrRef = "CENTERFIT" Or StrRef = "CENTERFIX" Or StrRef = "ULTRASMART" Or StrRef = "M-DIFF") Then

            '    StrFName = "Galaxyfold_Pouch.btw"


            'ElseIf (StrRef = "AE-01") Then
            '    StrFName = "Pouch AE-01.btw"


            'ElseIf StrRef = "AE INFO" Then

            '    StrFName = "Pouch AE INFO.btw"

            'Else
            '    StrFName = "Pouch.btw"
            'End If



            StrOptic = Format(IIf(IsDBNull(StrRs.GetValue(5)), "", StrRs.GetValue(5)), "0.00")
            StrLen = Format(IIf(IsDBNull(StrRs.GetValue(6)), "", StrRs.GetValue(6)), "0.00")
            StrPwr = IIf(IsDBNull(StrRs.GetValue(4)), "", StrRs.GetValue(4))

            StrExp = IIf(IsDBNull(StrRs.GetValue(5)), "", StrRs.GetValue(5))

            strmfdmon = Format(IIf(IsDBNull(StrRs.GetValue(16)), "", StrRs.GetValue(16)), "00")
            strmfdyear = IIf(IsDBNull(StrRs.GetValue(17)), "", StrRs.GetValue(17))

            StrEpMon = Format(IIf(IsDBNull(StrRs.GetValue(18)), "", StrRs.GetValue(18)), "00")
            StrEpYr = IIf(IsDBNull(StrRs.GetValue(19)), "", StrRs.GetValue(19))
            StrBrand = IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0))
            strrefname1 = IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0))
            StrRef = IIf(IsDBNull(StrRs.GetValue(1)), "", StrRs.GetValue(1))
            StrLotPrefix = IIf(IsDBNull(StrRs.GetValue(13)), "", StrRs.GetValue(13))
            StrLotNo = IIf(IsDBNull(StrRs.GetValue(14)), "", StrRs.GetValue(14))
            StrSrNo = IIf(IsDBNull(StrRs.GetValue(15)), "", StrRs.GetValue(15))
            StrMdl = IIf(IsDBNull(StrRs.GetValue(1)), "", StrRs.GetValue(1))
            Strbtc = IIf(IsDBNull(StrRs.GetValue(54)), "", StrRs.GetValue(54))

            'Strcyl = IIf(IsDBNull(StrRs.GetValue(67)), "", StrRs.GetValue(67))

            StrExp = StrEpYr & "-" & StrEpMon

            strmfd = strmfdyear & "-" & strmfdmon

            'Dim strss As String

            'strss = StrSrNo.Remove(7, 1)

            'StroneDBar = strss & "," & Strbtc



            If (strrefname1 = "APPALENS" Or strrefname1 = "APPALENS PLUS" Or strrefname1 = "HEERALENS" Or strrefname1 = "LIBERTY IRIS CLAW LENS" Or strrefname1 = "LIBERTYLENS" Or strrefname1 = "LIBERTYLENS BBY" Or strrefname1 = "SWISS LENS") Then
                'If (StrMdl = "205" Or StrMdl = "206" Or StrMdl = "209" Or StrMdl = "304" Or StrMdl = "407" Or StrMdl = "208" Or StrMdl = "220" Or StrMdl = "100" Or StrMdl = "101" Or StrMdl = "303" Or StrMdl = "106" Or StrMdl = "110" Or StrMdl = "105" Or StrMdl = "103" Or StrMdl = "109" Or StrMdl = "107" Or StrMdl = "302" Or StrMdl = "210" Or StrMdl = "207" Or StrMdl = "108" Or StrMdl = "102" Or StrMdl = "SQ100" Or StrMdl = "SQ101" Or StrMdl = "SQ209" Or StrMdl = "SQ207" Or StrMdl = "SQ102" Or StrMdl = "207H" Or StrMdl = "102H" Or StrMdl = "110H" Or StrMdl = "101H" Or StrMdl = "106H" Or StrMdl = "407H" Or StrMdl = "103H" Or StrMdl = "302H" Or StrMdl = "100H" Or StrMdl = "220H" Or StrMdl = "210H" Or StrMdl = "105H" Or StrMdl = "209H" Or StrMdl = "206H" Or StrMdl = "205H" Or StrMdl = "107H" Or StrMdl = "208H" Or StrMdl = "109H" Or StrMdl = "303H" Or StrMdl = "108H" Or StrMdl = "304H" Or StrMdl = "304L" Or StrMdl = "303L" Or StrMdl = "108L" Or StrMdl = "106L" Or StrMdl = "109L" Or StrMdl = "220L" Or StrMdl = "220L" Or StrMdl = "210L" Or StrMdl = "101L" Or StrMdl = "208L" Or StrMdl = "205L" Or StrMdl = "105L" Or StrMdl = "107L" Or StrMdl = "209L" Or StrMdl = "207L" Or StrMdl = "206L" Or StrMdl = "100L" Or StrMdl = "102L" Or StrMdl = "407L" Or StrMdl = "103L" Or StrMdl = "302L" Or StrMdl = "110L" Or StrMdl = "YE207" Or StrMdl = "SQ52120" Or StrMdl = "SQ60125" Or StrMdl = "SQ55120" Or StrMdl = "SQ65130" Or StrMdl = "SQ50120" Or StrMdl = "ICA5585" Or StrMdl = "ICA4272" Or StrMdl = "ICA5590") Then
                ' If (CmbType.Text = "Local" Or CmbType.Text = "Sqr" Or CmbType.Text = "AI" Or CmbType.Text = "Moulding" Or CmbType.Text = "YELLOW" Or CmbType.Text = "Super" Or CmbType.Text = "Balance" Or CmbType.Text = "LOWTHICK" Or CmbType.Text = "Return" Or CmbType.Text = "CST" Or CmbType.Text = "Phobic" Or CmbType.Text = "Re-Process" Or CmbType.Text = "Re-Tumbling" Or CmbType.Text = "Re-Tumbling_SQR" Or CmbType.Text = "SriLanka-Liberty" Or CmbType.Text = "Yellow Blanks" Or CmbType.Text = "Special" Or CmbType.Text = "8_cf" Or CmbType.Text = "Local_1") Then

                StrFName = "PMMALOCAL.btw"

            Else
                ' StrMdl = "LCRD102" Or StrMdl = "LCRS103" Or StrMdl = "LCRS101" Or StrMdl = "Cionni125" Or StrMdl = "Cionni120" Or StrMdl = "Cionni130" Or StrMdl = "ES701" Or StrMdl = "ES501" Or StrMdl = "ERB130" Or StrMdl = "ER135" Or StrMdl = "ERB125" Or StrMdl = "ER120" Or StrMdl = "ERB110" Or StrMdl = "ERB140" Or StrMdl = "ER110" Or StrMdl = "ES601" Or StrMdl = "ES901" Or StrMdl = "ER125" Or StrMdl = "ER100" Or StrMdl = "ERB135" Or StrMdl = "ERB120" Or StrMdl = "ER140" Or StrMdl = "ER130" Or StrMdl = "LIR100" Or StrMdl = "IR-M" Or StrMdl = "ICRS-250" Or StrMdl = "ICRS-300" Or StrMdl = "ICRS-200" Or StrMdl = "ICRS-350" Or StrMdl = "ICRS-150" Or StrMdl = "CTS95"

                StrFName = "PMMARING.btw"
            End If


            'If StrRef = "SP-TORIC T3" Then
            '    strpwradd = StrPwr & " " & "D" & " " & "Adl Cyl 1.50"
            'ElseIf StrRef = "SP-TORIC T4" Then
            '    strpwradd = StrPwr & " " & "D" & " " & "Adl Cyl 2.25"
            'ElseIf StrRef = "SP-TORIC T5" Then
            '    strpwradd = StrPwr & " " & "D" & " " & "Adl Cyl 3.00"
            'ElseIf StrRef = "SP-TORIC T6" Then
            '    strpwradd = StrPwr & " " & "D" & " " & "Adl Cyl 3.75"
            'ElseIf StrRef = "SP-TORIC T7" Then
            '    strpwradd = StrPwr & " " & "D" & " " & "Adl Cyl 4.50"
            'ElseIf StrRef = "SP-TORIC T8" Then
            '    strpwradd = StrPwr & " " & "D" & " " & "Adl Cyl 5.25"
            'ElseIf StrRef = "SP-TORIC T9" Then
            '    strpwradd = StrPwr & " " & "D" & " " & "Adl Cyl 6.00"
            'ElseIf StrRef = "MFD605" Then
            '    strpwradd = StrPwr & " " & "D" & " " & "Adl 3.50 D"

            'ElseIf StrRef = "MFDY605" Then
            '    strpwradd = StrPwr & " " & "D" & " " & "Adl 3.50 D"



            'ElseIf StrRef = "SPMFD200" Then
            '    strpwradd = StrPwr & " " & "D" & " " & "Adl" & " " & Strcyl & " " & " D"

            'ElseIf StrRef = "SPMFDY200" Then
            '    strpwradd = StrPwr & " " & "D" & " " & "Adl" & " " & Strcyl & " " & " D"

            'ElseIf StrRef = "SUPRAPHOB MS" Then
            '    strpwradd = StrPwr & " " & "D" & " " & "Adl" & " " & Strcyl & " " & " D"

            'ElseIf StrRef = "SP INFO" Then
            '    strpwradd = StrPwr & " " & "D"
            '    'strpwradd = StrPwr & " " & "D" & " " & "Adl" & " " & Strcyl & " " & " D"

            'Else
            '    strpwradd = StrPwr & "D"
            'End If










            If RdoRef.Checked = True Then
                strrefname1 = StrRef
            Else
                strrefname1 = StrBrand
            End If



            StrSronlyNo = StrLotPrefix & StrLotNo

            StroneDBar = StrSrNo



            'StrlotonlyNo = LblShowLotPrefix.Text & LblShowLotNo.Text

            'StrlotBarNo = LblShowLotPrefix.Text & LblShowLotNo.Text & " " & Format(StrStPrQty, "000")

            Dim steirli As String
            Dim nameaddre As String
            Dim licenc As String
            Dim temp As String
            Dim mrp As String



            If (strrefname1 = "APPALENS" Or strrefname1 = "APPALENS PLUS" Or strrefname1 = "HEERALENS" Or strrefname1 = "LIBERTY IRIS CLAW LENS" Or strrefname1 = "LIBERTYLENS" Or strrefname1 = "LIBERTYLENS BBY" Or strrefname1 = "SWISS LENS") Then
                '  If (StrMdl = "205" Or StrMdl = "206" Or StrMdl = "209" Or StrMdl = "304" Or StrMdl = "407" Or StrMdl = "208" Or StrMdl = "220" Or StrMdl = "100" Or StrMdl = "101" Or StrMdl = "303" Or StrMdl = "106" Or StrMdl = "110" Or StrMdl = "105" Or StrMdl = "103" Or StrMdl = "109" Or StrMdl = "107" Or StrMdl = "302" Or StrMdl = "210" Or StrMdl = "207" Or StrMdl = "108" Or StrMdl = "102" Or StrMdl = "SQ100" Or StrMdl = "SQ101" Or StrMdl = "SQ209" Or StrMdl = "SQ207" Or StrMdl = "SQ102" Or StrMdl = "207H" Or StrMdl = "102H" Or StrMdl = "110H" Or StrMdl = "101H" Or StrMdl = "106H" Or StrMdl = "407H" Or StrMdl = "103H" Or StrMdl = "302H" Or StrMdl = "100H" Or StrMdl = "220H" Or StrMdl = "210H" Or StrMdl = "105H" Or StrMdl = "209H" Or StrMdl = "206H" Or StrMdl = "205H" Or StrMdl = "107H" Or StrMdl = "208H" Or StrMdl = "109H" Or StrMdl = "303H" Or StrMdl = "108H" Or StrMdl = "304H" Or StrMdl = "304L" Or StrMdl = "303L" Or StrMdl = "108L" Or StrMdl = "106L" Or StrMdl = "109L" Or StrMdl = "220L" Or StrMdl = "220L" Or StrMdl = "210L" Or StrMdl = "101L" Or StrMdl = "208L" Or StrMdl = "205L" Or StrMdl = "105L" Or StrMdl = "107L" Or StrMdl = "209L" Or StrMdl = "207L" Or StrMdl = "206L" Or StrMdl = "100L" Or StrMdl = "102L" Or StrMdl = "407L" Or StrMdl = "103L" Or StrMdl = "302L" Or StrMdl = "110L" Or StrMdl = "YE207" Or StrMdl = "SQ52120" Or StrMdl = "SQ60125" Or StrMdl = "SQ55120" Or StrMdl = "SQ65130" Or StrMdl = "SQ50120" Or StrMdl = "ICA5585") Then



                'strsql = "SELECT * from LENS_MASTER where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "'  and Brand_Name='" & CmbShBrand.Text & "' "
                'cmd = New SqlCommand(strsql, con)
                'If con.State = Data.ConnectionState.Open Then
                '    con.Close()
                'End If
                'con.Open()
                'StrRs = cmd.ExecuteReader

                'If StrRs.Read Then

                '    steirli = IIf(IsDBNull(StrRs.GetValue(22)), "", StrRs.GetValue(22))
                '    nameaddre = IIf(IsDBNull(StrRs.GetValue(20)), "", StrRs.GetValue(20))
                '    licenc = IIf(IsDBNull(StrRs.GetValue(19)), "", StrRs.GetValue(19))
                '    temp = IIf(IsDBNull(StrRs.GetValue(21)), "", StrRs.GetValue(21))
                '    mrp = IIf(IsDBNull(StrRs.GetValue(17)), "", StrRs.GetValue(17))

                'End If
                'Dim Twodbar As String

                'Twodbar = CmbShBrand.Text + "," + CmbShModel.Text + "," + CmbShPower.Text + "," + steirli + "," + StrlotBarNo + "," + LblShowMfdDate.Text + "," + LblShowExpDate.Text + "," + mrp + "," + licenc + "," + nameaddre + "," + temp







                StrOptic = StrOptic & " " & "mm"
                StrLen = StrLen & " " & "mm"
                StrPwr = StrPwr & " " & "D"


                'stroptic = LblShowOptic.Text
                'strlength = LblShowLength.Text
                'strpwr = CmbShPower.Text


                btFile = Application.StartupPath & "\" & StrFName & ""
                bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                bt.SetNamedSubStringValue("Ref", StrMdl)
                bt.SetNamedSubStringValue("Pwr", StrPwr)
                bt.SetNamedSubStringValue("Brandname", strrefname1)
                'bt.SetNamedSubStringValue("SNo", StrlotBarNo)
                bt.SetNamedSubStringValue("LotNo", StrSrNo)
                bt.SetNamedSubStringValue("optic", StrOptic)
                bt.SetNamedSubStringValue("Length", StrLen)
                bt.SetNamedSubStringValue("Expdate", StrExp)
                bt.SetNamedSubStringValue("mfddate", strmfd)

                ' bt.SetNamedSubStringValue("Twodbar", Twodbar)




                bt.PrintOut()

                bt.Close()

                System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)






            Else



                'StrOptic = StrOptic & " " & "mm"
                'StrLen = StrLen & " " & "mm"
                'StrPwr = StrPwr & " " & "D"

                Dim Size As String
                'Size = StrOptic & "X" & StrLen



                'btFile = Application.StartupPath & "\" & StrFName & ""

                'bt = bApp.Formats.Open(btFile, , DefaultPrinterName)


                'bt.SetNamedSubStringValue("Ref", CmbShModel.Text)
                '' bt.SetNamedSubStringValue("Pwr", strpwr)
                'bt.SetNamedSubStringValue("Brandname", strrefname1)
                ''bt.SetNamedSubStringValue("SNo", StrlotBarNo)
                'bt.SetNamedSubStringValue("LotNo", StrlotBarNo)
                'bt.SetNamedSubStringValue("optic", SIZE)
                ''bt.SetNamedSubStringValue("Length", strlength)
                'bt.SetNamedSubStringValue("Expdate", LblShowExpDate.Text)
                'bt.SetNamedSubStringValue("mfddate", LblShowMfdDate.Text)

                'bt.PrintOut()

                'bt.Close()

                'System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                StrOptic = StrOptic & " " & "mm"
                StrLen = StrLen & " " & "mm"
                ' StrPwr = StrPwr & " " & "D"


                btFile = Application.StartupPath & "\" & StrFName & ""

                bt = bApp.Formats.Open(btFile, , DefaultPrinterName)


                bt.SetNamedSubStringValue("Ref", StrMdl)
                ' bt.SetNamedSubStringValue("Pwr", strpwr)
                bt.SetNamedSubStringValue("Brandname", strrefname1)
                'bt.SetNamedSubStringValue("SNo", StrlotBarNo)
                bt.SetNamedSubStringValue("LotNo", StrSrNo)
                bt.SetNamedSubStringValue("optic", StrOptic)
                bt.SetNamedSubStringValue("Length", StrLen)
                bt.SetNamedSubStringValue("Expdate", StrExp)
                bt.SetNamedSubStringValue("mfddate", strmfd)

                bt.PrintOut()

                bt.Close()
                System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

            End If


        End While
        StrRs.Close()

        Cmd.Dispose()



        txtcrFromQty.Text = ""
        txtcrToQty.Text = ""


    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub FrmNewPouchReprintPMMA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtsigsrno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsigsrno.KeyDown
        If e.KeyCode = Keys.Enter Then

            If txtsigsrno.Text <> "" Then

                StrSql = "select * from  POUCH_LABEL where Lot_SrNo = '" & txtsigsrno.Text & "'"
                Cmd = New SqlCommand(StrSql, con)
                StrRs = Cmd.ExecuteReader

                'Dim writePRN As New StreamWriter(Application.StartupPath & "\write.prn")

                While StrRs.Read

                    StrRef = IIf(IsDBNull(StrRs.GetValue(1)), "", StrRs.GetValue(1))

                    Dim StrFName As String

                    If (StrRef = "502") Or (StrRef = "601") Or (StrRef = "701") Or (StrRef = "nAs207") Or (StrRef = "nAsY207") Or (StrRef = "701H") Then

                        StrFName = "PouchPhilic.btw"

                    ElseIf (StrRef = "SPMFDY200") Or (StrRef = "SPMFD200") Or (StrRef = "SUPRAPHOB MS") Or (StrRef = "SP INFO") Then

                        StrFName = "Pouch_MFD.btw"

                    ElseIf (StrRef = "SP-TORIC T3" Or StrRef = "SP-TORIC T4" Or StrRef = "SP-TORIC T5" Or StrRef = "SP-TORIC T6" Or StrRef = "SP-TORIC T7" Or StrRef = "SP-TORIC T8" Or StrRef = "SP-TORIC T9" Or StrRef = "MFD605") Then

                        StrFName = "Pouch_Toric.btw"

                    ElseIf (StrRef = "MFDY605") Then

                        StrFName = "Pouch_Toric_MFD.btw"

                    Else
                        StrFName = "Pouch.btw"
                    End If

                    StrOptic = Format(IIf(IsDBNull(StrRs.GetValue(5)), "", StrRs.GetValue(5)), "0.00")
                    StrLen = Format(IIf(IsDBNull(StrRs.GetValue(6)), "", StrRs.GetValue(6)), "0.00")
                    StrPwr = IIf(IsDBNull(StrRs.GetValue(4)), "", StrRs.GetValue(4))

                    StrExp = IIf(IsDBNull(StrRs.GetValue(5)), "", StrRs.GetValue(5))

                    strmfdmon = Format(IIf(IsDBNull(StrRs.GetValue(16)), "", StrRs.GetValue(16)), "00")
                    strmfdyear = IIf(IsDBNull(StrRs.GetValue(17)), "", StrRs.GetValue(17))

                    StrRefName = IIf(IsDBNull(StrRs.GetValue(2)), "", StrRs.GetValue(2))

                    StrEpMon = Format(IIf(IsDBNull(StrRs.GetValue(18)), "", StrRs.GetValue(18)), "00")
                    StrEpYr = IIf(IsDBNull(StrRs.GetValue(19)), "", StrRs.GetValue(19))
                    StrBrand = IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0))
                    StrRef = IIf(IsDBNull(StrRs.GetValue(1)), "", StrRs.GetValue(1))
                    StrLotPrefix = IIf(IsDBNull(StrRs.GetValue(13)), "", StrRs.GetValue(13))
                    StrLotNo = IIf(IsDBNull(StrRs.GetValue(14)), "", StrRs.GetValue(14))
                    StrSrNo = IIf(IsDBNull(StrRs.GetValue(15)), "", StrRs.GetValue(15))
                    StrMdl = IIf(IsDBNull(StrRs.GetValue(1)), "", StrRs.GetValue(1))
                    Strbtc = IIf(IsDBNull(StrRs.GetValue(54)), "", StrRs.GetValue(54))

                    Strcyl = IIf(IsDBNull(StrRs.GetValue(53)), "", StrRs.GetValue(53))

                    StrExp = StrEpYr & "-" & StrEpMon

                    strmfd = strmfdyear & "-" & strmfdmon

                    
                    'StrExp = StrEpYr & "-" & StrEpMon


                    'strmfd = strmfdyear & "-" & strmfdmon

                    'Dim strss As String

                    'strss = StrSrNo.Remove(7, 1)

                    'StroneDBar = strss & "," & Strbtc
                    StrSronlyNo = StrLotPrefix & StrLotNo

                    StroneDBar = StrSrNo

                    If StrRef = "SP-TORIC T3" Then
                        strpwradd = StrPwr & " " & "D" & " " & "Adl Cyl 1.50"
                    ElseIf StrRef = "SP-TORIC T4" Then
                        strpwradd = StrPwr & " " & "D" & " " & "Adl Cyl 2.25"
                    ElseIf StrRef = "SP-TORIC T5" Then
                        strpwradd = StrPwr & " " & "D" & " " & "Adl Cyl 3.00"
                    ElseIf StrRef = "SP-TORIC T6" Then
                        strpwradd = StrPwr & " " & "D" & " " & "Adl Cyl 3.75"
                    ElseIf StrRef = "SP-TORIC T7" Then
                        strpwradd = StrPwr & " " & "D" & " " & "Adl Cyl 4.50"
                    ElseIf StrRef = "SP-TORIC T8" Then
                        strpwradd = StrPwr & " " & "D" & " " & "Adl Cyl 5.25"
                    ElseIf StrRef = "SP-TORIC T9" Then
                        strpwradd = StrPwr & " " & "D" & " " & "Adl Cyl 6.00"
                    ElseIf StrRef = "MFD605" Then
                        strpwradd = StrPwr & " " & "D" & " " & "Adl 3.50 D"

                    ElseIf StrRef = "MFDY605" Then
                        strpwradd = StrPwr & " " & "D" & " " & "Adl 3.50 D"


                    ElseIf StrRef = "SPMFD200" Then
                        strpwradd = StrPwr & " " & "D" & " " & "Adl" & " " & Strcyl & " " & " D"

                    ElseIf StrRef = "SPMFDY200" Then
                        strpwradd = StrPwr & " " & "D" & " " & "Adl" & " " & Strcyl & " " & " D"


                    ElseIf StrRef = "SUPRAPHOB MS" Then
                        strpwradd = StrPwr & " " & "D" & " " & "Adl" & " " & Strcyl & " " & " D"

                    ElseIf StrRef = "SP INFO" Then
                        strpwradd = StrPwr & " " & "D"
                        'strpwradd = StrPwr & " " & "D" & " " & "Adl" & " " & Strcyl & " " & " D"



                    Else
                        strpwradd = StrPwr & "D"
                    End If






                    If RdoRef.Checked = True Then
                        strrefname1 = StrRef
                    Else
                        strrefname1 = StrBrand
                    End If



                    'StrlotonlyNo = LblShowLotPrefix.Text & LblShowLotNo.Text

                    'StrlotBarNo = LblShowLotPrefix.Text & LblShowLotNo.Text & " " & Format(StrStPrQty, "000")

                    StrOptic = StrOptic & " " & "mm"
                    StrLen = StrLen & " " & "mm"
                    StrPwr = StrPwr & " " & "D"


                    btFile = Application.StartupPath & "\" & StrFName & ""
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)


                    bt.SetNamedSubStringValue("Ref", StrMdl)
                    bt.SetNamedSubStringValue("Pwr", strpwradd)
                    bt.SetNamedSubStringValue("Brandname", strrefname1)
                    'bt.SetNamedSubStringValue("SNo", StrlotBarNo)
                    bt.SetNamedSubStringValue("LotNo", StroneDBar)
                    bt.SetNamedSubStringValue("optic", StrOptic)
                    bt.SetNamedSubStringValue("Length", StrLen)
                    bt.SetNamedSubStringValue("Expdate", StrExp)
                    bt.SetNamedSubStringValue("mfddate", strmfd)


                    bt.PrintOut()

                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)


                End While
               
                StrRs.Close()
                Cmd.Dispose()

                txtsigsrno.Text = ""

                txtsigsrno.Focus()


            End If
        End If

    End Sub

   
    Private Sub txttwodBarcode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttwodBarcode.KeyDown


        If txttwodBarcode.Text <> "" Then


            If e.KeyCode = Keys.Enter Then



                StrScanTwoD = txttwodBarcode.Text
                Dim s As String = StrScanTwoD
                Dim Ck As Integer
                Dim parts As String() = s.Split(New Char() {","c})

                For e1 As Integer = 1 To 2
                    StrScanLotNo = parts(0)
                Next


                StrSql = "select * from  POUCH_LABEL where Lot_SrNo = '" & StrScanLotNo & "' "
                Cmd = New SqlCommand(StrSql, con)
                If con.State = Data.ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                StrRs = Cmd.ExecuteReader
                If StrRs.Read Then
                    'StrRs.Close()
                Else
                    MsgBox("No Data Found", MsgBoxStyle.Critical)
                    txttwodBarcode.Text = ""

                    Exit Sub
                End If
                StrRs.Close()
                Cmd.Dispose()



                StrSql = "select * from  POUCH_LABEL where Lot_SrNo = '" & StrScanLotNo & "' "
                Cmd = New SqlCommand(StrSql, con)
                If con.State = Data.ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                StrRs = Cmd.ExecuteReader


                'Dim StrFName As String
                'StrFName = "Pouch.btw"
                'Dim writePRN As New StreamWriter(Application.StartupPath & "\write.prn")

                While StrRs.Read

                    Dim StrFName As String
                    StrRef = IIf(IsDBNull(StrRs.GetValue(1)), "", StrRs.GetValue(1))

                    ' If (StrRef = "502") Or (StrRef = "601") Or (StrRef = "701") Or (StrRef = "nAs207") Or (StrRef = "nAsY207") Or (StrRef = "701H") Or (StrRef = "ULTRASMART") Then



                    'If (StrRef = "SPMFDY200") Or (StrRef = "SPMFD200") Or (StrRef = "SUPRAPHOB MS") Or (StrRef = "SP INFO") Then

                    '    StrFName = "Pouch_MFD.btw"

                    'ElseIf (StrRef = "SP-TORIC T3" Or StrRef = "SP-TORIC T4" Or StrRef = "SP-TORIC T5" Or StrRef = "SP-TORIC T6" Or StrRef = "SP-TORIC T7" Or StrRef = "SP-TORIC T8" Or StrRef = "SP-TORIC T9") Then

                    '    StrFName = "Pouch_Toric.btw"

                    'ElseIf (StrRef = "MFD605") Then

                    '    StrFName = "Pouch.btw"

                    'ElseIf (StrRef = "MFDY605") Then

                    '    StrFName = "Pouch_Toric_MFD.btw"

                    'ElseIf (StrRef = "CENTERFIT" Or StrRef = "CENTERFIX" Or StrRef = "ULTRASMART" Or StrRef = "M-DIFF") Then

                    '    StrFName = "Galaxyfold_Pouch.btw"


                    'ElseIf (StrRef = "AE-01") Then
                    '    StrFName = "Pouch AE-01.btw"


                    'ElseIf StrRef = "AE INFO" Then

                    '    StrFName = "Pouch AE INFO.btw"

                    'Else
                    '    StrFName = "Pouch.btw"
                    'End If



                    StrOptic = Format(IIf(IsDBNull(StrRs.GetValue(5)), "", StrRs.GetValue(5)), "0.00")
                    StrLen = Format(IIf(IsDBNull(StrRs.GetValue(6)), "", StrRs.GetValue(6)), "0.00")
                    StrPwr = IIf(IsDBNull(StrRs.GetValue(4)), "", StrRs.GetValue(4))

                    StrExp = IIf(IsDBNull(StrRs.GetValue(5)), "", StrRs.GetValue(5))

                    strmfdmon = Format(IIf(IsDBNull(StrRs.GetValue(16)), "", StrRs.GetValue(16)), "00")
                    strmfdyear = IIf(IsDBNull(StrRs.GetValue(17)), "", StrRs.GetValue(17))

                    StrEpMon = Format(IIf(IsDBNull(StrRs.GetValue(18)), "", StrRs.GetValue(18)), "00")
                    StrEpYr = IIf(IsDBNull(StrRs.GetValue(19)), "", StrRs.GetValue(19))
                    StrBrand = IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0))
                    strrefname1 = IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0))
                    StrRef = IIf(IsDBNull(StrRs.GetValue(1)), "", StrRs.GetValue(1))
                    StrLotPrefix = IIf(IsDBNull(StrRs.GetValue(13)), "", StrRs.GetValue(13))
                    StrLotNo = IIf(IsDBNull(StrRs.GetValue(14)), "", StrRs.GetValue(14))
                    StrSrNo = IIf(IsDBNull(StrRs.GetValue(15)), "", StrRs.GetValue(15))
                    StrMdl = IIf(IsDBNull(StrRs.GetValue(1)), "", StrRs.GetValue(1))
                    Strbtc = IIf(IsDBNull(StrRs.GetValue(54)), "", StrRs.GetValue(54))

                    'Strcyl = IIf(IsDBNull(StrRs.GetValue(67)), "", StrRs.GetValue(67))

                    StrExp = StrEpYr & "-" & StrEpMon

                    strmfd = strmfdyear & "-" & strmfdmon

                    'Dim strss As String

                    'strss = StrSrNo.Remove(7, 1)

                    'StroneDBar = strss & "," & Strbtc



                    If (strrefname1 = "APPALENS" Or strrefname1 = "APPALENS PLUS" Or strrefname1 = "HEERALENS" Or strrefname1 = "LIBERTY IRIS CLAW LENS" Or strrefname1 = "LIBERTYLENS" Or strrefname1 = "LIBERTYLENS BBY" Or strrefname1 = "SWISS LENS") Then
                        'If (StrMdl = "205" Or StrMdl = "206" Or StrMdl = "209" Or StrMdl = "304" Or StrMdl = "407" Or StrMdl = "208" Or StrMdl = "220" Or StrMdl = "100" Or StrMdl = "101" Or StrMdl = "303" Or StrMdl = "106" Or StrMdl = "110" Or StrMdl = "105" Or StrMdl = "103" Or StrMdl = "109" Or StrMdl = "107" Or StrMdl = "302" Or StrMdl = "210" Or StrMdl = "207" Or StrMdl = "108" Or StrMdl = "102" Or StrMdl = "SQ100" Or StrMdl = "SQ101" Or StrMdl = "SQ209" Or StrMdl = "SQ207" Or StrMdl = "SQ102" Or StrMdl = "207H" Or StrMdl = "102H" Or StrMdl = "110H" Or StrMdl = "101H" Or StrMdl = "106H" Or StrMdl = "407H" Or StrMdl = "103H" Or StrMdl = "302H" Or StrMdl = "100H" Or StrMdl = "220H" Or StrMdl = "210H" Or StrMdl = "105H" Or StrMdl = "209H" Or StrMdl = "206H" Or StrMdl = "205H" Or StrMdl = "107H" Or StrMdl = "208H" Or StrMdl = "109H" Or StrMdl = "303H" Or StrMdl = "108H" Or StrMdl = "304H" Or StrMdl = "304L" Or StrMdl = "303L" Or StrMdl = "108L" Or StrMdl = "106L" Or StrMdl = "109L" Or StrMdl = "220L" Or StrMdl = "220L" Or StrMdl = "210L" Or StrMdl = "101L" Or StrMdl = "208L" Or StrMdl = "205L" Or StrMdl = "105L" Or StrMdl = "107L" Or StrMdl = "209L" Or StrMdl = "207L" Or StrMdl = "206L" Or StrMdl = "100L" Or StrMdl = "102L" Or StrMdl = "407L" Or StrMdl = "103L" Or StrMdl = "302L" Or StrMdl = "110L" Or StrMdl = "YE207" Or StrMdl = "SQ52120" Or StrMdl = "SQ60125" Or StrMdl = "SQ55120" Or StrMdl = "SQ65130" Or StrMdl = "SQ50120" Or StrMdl = "ICA5585" Or StrMdl = "ICA4272" Or StrMdl = "ICA5590") Then
                        ' If (CmbType.Text = "Local" Or CmbType.Text = "Sqr" Or CmbType.Text = "AI" Or CmbType.Text = "Moulding" Or CmbType.Text = "YELLOW" Or CmbType.Text = "Super" Or CmbType.Text = "Balance" Or CmbType.Text = "LOWTHICK" Or CmbType.Text = "Return" Or CmbType.Text = "CST" Or CmbType.Text = "Phobic" Or CmbType.Text = "Re-Process" Or CmbType.Text = "Re-Tumbling" Or CmbType.Text = "Re-Tumbling_SQR" Or CmbType.Text = "SriLanka-Liberty" Or CmbType.Text = "Yellow Blanks" Or CmbType.Text = "Special" Or CmbType.Text = "8_cf" Or CmbType.Text = "Local_1") Then

                        StrFName = "PMMALOCAL.btw"

                    Else
                        ' StrMdl = "LCRD102" Or StrMdl = "LCRS103" Or StrMdl = "LCRS101" Or StrMdl = "Cionni125" Or StrMdl = "Cionni120" Or StrMdl = "Cionni130" Or StrMdl = "ES701" Or StrMdl = "ES501" Or StrMdl = "ERB130" Or StrMdl = "ER135" Or StrMdl = "ERB125" Or StrMdl = "ER120" Or StrMdl = "ERB110" Or StrMdl = "ERB140" Or StrMdl = "ER110" Or StrMdl = "ES601" Or StrMdl = "ES901" Or StrMdl = "ER125" Or StrMdl = "ER100" Or StrMdl = "ERB135" Or StrMdl = "ERB120" Or StrMdl = "ER140" Or StrMdl = "ER130" Or StrMdl = "LIR100" Or StrMdl = "IR-M" Or StrMdl = "ICRS-250" Or StrMdl = "ICRS-300" Or StrMdl = "ICRS-200" Or StrMdl = "ICRS-350" Or StrMdl = "ICRS-150" Or StrMdl = "CTS95"

                        StrFName = "PMMARING.btw"
                    End If


                    'If StrRef = "SP-TORIC T3" Then
                    '    strpwradd = StrPwr & " " & "D" & " " & "Adl Cyl 1.50"
                    'ElseIf StrRef = "SP-TORIC T4" Then
                    '    strpwradd = StrPwr & " " & "D" & " " & "Adl Cyl 2.25"
                    'ElseIf StrRef = "SP-TORIC T5" Then
                    '    strpwradd = StrPwr & " " & "D" & " " & "Adl Cyl 3.00"
                    'ElseIf StrRef = "SP-TORIC T6" Then
                    '    strpwradd = StrPwr & " " & "D" & " " & "Adl Cyl 3.75"
                    'ElseIf StrRef = "SP-TORIC T7" Then
                    '    strpwradd = StrPwr & " " & "D" & " " & "Adl Cyl 4.50"
                    'ElseIf StrRef = "SP-TORIC T8" Then
                    '    strpwradd = StrPwr & " " & "D" & " " & "Adl Cyl 5.25"
                    'ElseIf StrRef = "SP-TORIC T9" Then
                    '    strpwradd = StrPwr & " " & "D" & " " & "Adl Cyl 6.00"
                    'ElseIf StrRef = "MFD605" Then
                    '    strpwradd = StrPwr & " " & "D" & " " & "Adl 3.50 D"

                    'ElseIf StrRef = "MFDY605" Then
                    '    strpwradd = StrPwr & " " & "D" & " " & "Adl 3.50 D"



                    'ElseIf StrRef = "SPMFD200" Then
                    '    strpwradd = StrPwr & " " & "D" & " " & "Adl" & " " & Strcyl & " " & " D"

                    'ElseIf StrRef = "SPMFDY200" Then
                    '    strpwradd = StrPwr & " " & "D" & " " & "Adl" & " " & Strcyl & " " & " D"

                    'ElseIf StrRef = "SUPRAPHOB MS" Then
                    '    strpwradd = StrPwr & " " & "D" & " " & "Adl" & " " & Strcyl & " " & " D"

                    'ElseIf StrRef = "SP INFO" Then
                    '    strpwradd = StrPwr & " " & "D"
                    '    'strpwradd = StrPwr & " " & "D" & " " & "Adl" & " " & Strcyl & " " & " D"

                    'Else
                    '    strpwradd = StrPwr & "D"
                    'End If










                    If RdoRef.Checked = True Then
                        strrefname1 = StrRef
                    Else
                        strrefname1 = StrBrand
                    End If



                    StrSronlyNo = StrLotPrefix & StrLotNo

                    StroneDBar = StrSrNo



                    'StrlotonlyNo = LblShowLotPrefix.Text & LblShowLotNo.Text

                    'StrlotBarNo = LblShowLotPrefix.Text & LblShowLotNo.Text & " " & Format(StrStPrQty, "000")

                    Dim steirli As String
                    Dim nameaddre As String
                    Dim licenc As String
                    Dim temp As String
                    Dim mrp As String



                    If (strrefname1 = "APPALENS" Or strrefname1 = "APPALENS PLUS" Or strrefname1 = "HEERALENS" Or strrefname1 = "LIBERTY IRIS CLAW LENS" Or strrefname1 = "LIBERTYLENS" Or strrefname1 = "LIBERTYLENS BBY" Or strrefname1 = "SWISS LENS") Then
                        '  If (StrMdl = "205" Or StrMdl = "206" Or StrMdl = "209" Or StrMdl = "304" Or StrMdl = "407" Or StrMdl = "208" Or StrMdl = "220" Or StrMdl = "100" Or StrMdl = "101" Or StrMdl = "303" Or StrMdl = "106" Or StrMdl = "110" Or StrMdl = "105" Or StrMdl = "103" Or StrMdl = "109" Or StrMdl = "107" Or StrMdl = "302" Or StrMdl = "210" Or StrMdl = "207" Or StrMdl = "108" Or StrMdl = "102" Or StrMdl = "SQ100" Or StrMdl = "SQ101" Or StrMdl = "SQ209" Or StrMdl = "SQ207" Or StrMdl = "SQ102" Or StrMdl = "207H" Or StrMdl = "102H" Or StrMdl = "110H" Or StrMdl = "101H" Or StrMdl = "106H" Or StrMdl = "407H" Or StrMdl = "103H" Or StrMdl = "302H" Or StrMdl = "100H" Or StrMdl = "220H" Or StrMdl = "210H" Or StrMdl = "105H" Or StrMdl = "209H" Or StrMdl = "206H" Or StrMdl = "205H" Or StrMdl = "107H" Or StrMdl = "208H" Or StrMdl = "109H" Or StrMdl = "303H" Or StrMdl = "108H" Or StrMdl = "304H" Or StrMdl = "304L" Or StrMdl = "303L" Or StrMdl = "108L" Or StrMdl = "106L" Or StrMdl = "109L" Or StrMdl = "220L" Or StrMdl = "220L" Or StrMdl = "210L" Or StrMdl = "101L" Or StrMdl = "208L" Or StrMdl = "205L" Or StrMdl = "105L" Or StrMdl = "107L" Or StrMdl = "209L" Or StrMdl = "207L" Or StrMdl = "206L" Or StrMdl = "100L" Or StrMdl = "102L" Or StrMdl = "407L" Or StrMdl = "103L" Or StrMdl = "302L" Or StrMdl = "110L" Or StrMdl = "YE207" Or StrMdl = "SQ52120" Or StrMdl = "SQ60125" Or StrMdl = "SQ55120" Or StrMdl = "SQ65130" Or StrMdl = "SQ50120" Or StrMdl = "ICA5585") Then



                        'strsql = "SELECT * from LENS_MASTER where Model_Name='" & CmbShModel.Text & "' and POWER='" & CmbShPower.Text & "'  and Brand_Name='" & CmbShBrand.Text & "' "
                        'cmd = New SqlCommand(strsql, con)
                        'If con.State = Data.ConnectionState.Open Then
                        '    con.Close()
                        'End If
                        'con.Open()
                        'StrRs = cmd.ExecuteReader

                        'If StrRs.Read Then

                        '    steirli = IIf(IsDBNull(StrRs.GetValue(22)), "", StrRs.GetValue(22))
                        '    nameaddre = IIf(IsDBNull(StrRs.GetValue(20)), "", StrRs.GetValue(20))
                        '    licenc = IIf(IsDBNull(StrRs.GetValue(19)), "", StrRs.GetValue(19))
                        '    temp = IIf(IsDBNull(StrRs.GetValue(21)), "", StrRs.GetValue(21))
                        '    mrp = IIf(IsDBNull(StrRs.GetValue(17)), "", StrRs.GetValue(17))

                        'End If
                        'Dim Twodbar As String

                        'Twodbar = CmbShBrand.Text + "," + CmbShModel.Text + "," + CmbShPower.Text + "," + steirli + "," + StrlotBarNo + "," + LblShowMfdDate.Text + "," + LblShowExpDate.Text + "," + mrp + "," + licenc + "," + nameaddre + "," + temp







                        StrOptic = StrOptic & " " & "mm"
                        StrLen = StrLen & " " & "mm"
                        StrPwr = StrPwr & " " & "D"


                        'stroptic = LblShowOptic.Text
                        'strlength = LblShowLength.Text
                        'strpwr = CmbShPower.Text


                        btFile = Application.StartupPath & "\" & StrFName & ""
                        bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                        bt.SetNamedSubStringValue("Ref", StrMdl)
                        bt.SetNamedSubStringValue("Pwr", StrPwr)
                        bt.SetNamedSubStringValue("Brandname", strrefname1)
                        'bt.SetNamedSubStringValue("SNo", StrlotBarNo)
                        bt.SetNamedSubStringValue("LotNo", StrSrNo)
                        bt.SetNamedSubStringValue("optic", StrOptic)
                        bt.SetNamedSubStringValue("Length", StrLen)
                        bt.SetNamedSubStringValue("Expdate", StrExp)
                        bt.SetNamedSubStringValue("mfddate", strmfd)

                        ' bt.SetNamedSubStringValue("Twodbar", Twodbar)




                        bt.PrintOut()

                        bt.Close()

                        System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)






                    Else



                        'StrOptic = StrOptic & " " & "mm"
                        'StrLen = StrLen & " " & "mm"
                        'StrPwr = StrPwr & " " & "D"

                        Dim Size As String
                        'Size = StrOptic & "X" & StrLen



                        'btFile = Application.StartupPath & "\" & StrFName & ""

                        'bt = bApp.Formats.Open(btFile, , DefaultPrinterName)


                        'bt.SetNamedSubStringValue("Ref", CmbShModel.Text)
                        '' bt.SetNamedSubStringValue("Pwr", strpwr)
                        'bt.SetNamedSubStringValue("Brandname", strrefname1)
                        ''bt.SetNamedSubStringValue("SNo", StrlotBarNo)
                        'bt.SetNamedSubStringValue("LotNo", StrlotBarNo)
                        'bt.SetNamedSubStringValue("optic", SIZE)
                        ''bt.SetNamedSubStringValue("Length", strlength)
                        'bt.SetNamedSubStringValue("Expdate", LblShowExpDate.Text)
                        'bt.SetNamedSubStringValue("mfddate", LblShowMfdDate.Text)

                        'bt.PrintOut()

                        'bt.Close()

                        'System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                        StrOptic = StrOptic & " " & "mm"
                        StrLen = StrLen & " " & "mm"
                        ' StrPwr = StrPwr & " " & "D"


                        btFile = Application.StartupPath & "\" & StrFName & ""

                        bt = bApp.Formats.Open(btFile, , DefaultPrinterName)


                        bt.SetNamedSubStringValue("Ref", StrMdl)
                        ' bt.SetNamedSubStringValue("Pwr", strpwr)
                        bt.SetNamedSubStringValue("Brandname", strrefname1)
                        'bt.SetNamedSubStringValue("SNo", StrlotBarNo)
                        bt.SetNamedSubStringValue("LotNo", StrSrNo)
                        bt.SetNamedSubStringValue("optic", StrOptic)
                        bt.SetNamedSubStringValue("Length", StrLen)
                        bt.SetNamedSubStringValue("Expdate", StrExp)
                        bt.SetNamedSubStringValue("mfddate", strmfd)

                        bt.PrintOut()

                        bt.Close()
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                    End If


                End While
                StrRs.Close()

                Cmd.Dispose()



                txtcrFromQty.Text = ""
                txtcrToQty.Text = ""
                txttwodBarcode.Text = ""




            End If


        End If




    End Sub
End Class