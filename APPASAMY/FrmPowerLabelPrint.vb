
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO



Public Class FrmPowerLabelPrint






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
    Dim Stract As String
    Dim Stracpwr As String
    Dim len As String
    Dim opt As String
    Dim StrgsCode As String
    Dim StrUDICode As String
    Dim StrOptic, strpwradd, StrRefName, Strcyl, StrInexp1, StrInmfd, StrLen, StrPwr, StrRef, StrExp, StrBrand, StrLotPrefix, StrLotNo, StrSrNo, StrEpMon, StrEpYr, StrMdl, Strbtc, StrlotBarNo, StroneDBar, StrSronlyNo, strrefname1 As String

    Private Sub FrmPowerLabelPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CmbShPower.Items.Clear()
        StrSql = "SELECT DISTINCT POWER from LENS_MASTER  order by POWER"
        cmd = New SqlCommand(StrSql, con)
        StrRs = cmd.ExecuteReader
        While StrRs.Read
            CmbShPower.Items.Add(Format(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)), "0.00"))
        End While
        StrRs.Close()
        cmd.Dispose()




    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        'If CmbShPower.Text = "" Then
        '    MsgBox("Select Power", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If


        'IntPrintQty = Val(txtcrMaxQty.Text)
        'IntNoofLine = Val(IntPrintQty) / 4
        'Dim s As String = IntNoofLine
        'Dim Ck As Integer
        'Ck = 0
        '' Split the string on the backslash character
        'Dim parts As String() = s.Split(New Char() {"."c})

        'For e1 As Integer = 1 To 2
        '    IntNoofLine1 = parts(0)
        '    Ck = parts(1)
        'Next

        'If Ck = 0 Then
        '    IntNoofLine1 = IntNoofLine1
        'Else
        '    IntNoofLine1 = Val(IntNoofLine1) + 1
        'End If

        'Dim writePRN As New StreamWriter(Application.StartupPath & "\write.prn")
        'For StI As Integer = 1 To IntNoofLine1

        '    Dim readPRN As New StreamReader(Application.StartupPath & "\Power.prn")
        '    Dim idx As Integer
        '    Dim dt As String
        '    While readPRN.Peek <> -1
        '        dt = readPRN.ReadLine
        '        Debug.Print(dt)
        '        idx = dt.IndexOf("Pwr")
        '        Dim sTRpW As String
        '        'sTRpW = Format(CmbShPower.Text, "0.0")
        '        If idx <> -1 Then
        '            dt = dt.Substring(0, idx) & CmbShPower.Text & " D"
        '        End If
        '        writePRN.WriteLine(dt)
        '        Debug.Print(dt)
        '    End While
        '    readPRN.Close()
        '    readPRN.Dispose()
        'Next

        'writePRN.Flush()
        'writePRN.Close()
        'writePRN.Dispose()

        'RawPrinterHelper.SendFileToPrinter(DefaultPrinterName, Application.StartupPath & "\write.prn")


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

    Private Sub LabelNameBind()
        Dim ds As New DataSet()
        StrSql = "select distinct LabelName from BTW_Master where Department = 'POUCH'"
        Dim cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)

        cmbPrintLabel.DisplayMember = "LabelName"
        cmbPrintLabel.DataSource = ds.Tables(0)


    End Sub

    Private Sub FrmNewPouchReprintPhobic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LabelNameBind()
        StrSql = "SELECT DISTINCT RefLot from POUCH_LABEL order by RefLot"
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        cmbreflot.Items.Clear()
        While StrRs.Read
            cmbreflot.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        Cmd.Dispose()

    End Sub

    Private Function BTWFileName(ByVal modelno As String, ByVal labelname As String) As String
        Dim ds As New DataSet()
        StrSql = "select * from BTW_Master where Department = 'POUCH' and ModelNo = '" & modelno & "' and LabelName = '" & labelname & "' "
        Dim cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)
        If ds.Tables(0).Rows.Count <> 0 Then
            Return ds.Tables(0).Rows(0)("FileName")
        Else
            Return ""
        End If


    End Function


    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()

        'Dim bApp As New BarTender.Application
        'Dim bt As New BarTender.Format
        'Dim btFile As String

        'btFile = Application.StartupPath & "\ACRYFOLD_BT_MAX.btw"
        'bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
    End Sub

    Private Sub cmbreflot_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbreflot.SelectedIndexChanged
        StrSql = "SELECT DISTINCT Power from POUCH_LABEL where RefLot='" & cmbreflot.Text & "' order by Power"
        cmd = New SqlCommand(StrSql, con)
        StrRs = cmd.ExecuteReader
        cmbpower.Items.Clear()
        While StrRs.Read
            cmbpower.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        cmd.Dispose()
    End Sub

    Private Sub cmbpower_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpower.SelectedIndexChanged
        Dim Strsql As String
        Strsql = "select sum (Qty_1) as Balance_Qty  from POUCH_LABEL where  RefLot='" & cmbreflot.Text & "' and  Power='" & cmbpower.Text & "'"
        cmd = New SqlCommand(Strsql, con)
        StrRs = cmd.ExecuteReader
        If StrRs.Read Then
            TextBox2.Text = IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0))
        Else
            TextBox2.Text = ""

        End If
        StrRs.Close()
        cmd.Dispose()
    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click

        Try

            If cmbPrintLabel.SelectedItem Is Nothing Then
                Err.SetError(cmbPrintLabel, "Please Select valid Label")
                cmbPrintLabel.Focus()
                Exit Sub
            Else
                Err.SetError(cmbPrintLabel, "")
            End If

            If cmbreflot.SelectedItem Is Nothing Then
                err.SetError(cmbreflot, "Please Select valid Reflot")
                cmbreflot.Focus()
                Exit Sub
            Else
                err.SetError(cmbreflot, "")
            End If

            If cmbpower.SelectedItem Is Nothing Then
                err.SetError(cmbpower, "Please Select valid Power")
                cmbpower.Focus()
                Exit Sub
            Else
                err.SetError(cmbpower, "")
            End If


            StrSql = "select * from  POUCH_LABEL where RefLot = '" & cmbreflot.Text & "' and  Power = '" & cmbpower.Text & "'  order by Lot_SrNo"
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


            If productline <> "SUPERPHOB" Then

                StrSql = "select * from  POUCH_LABEL where RefLot = '" & cmbreflot.Text & "' and  Power = '" & cmbpower.Text & "'  order by Lot_SrNo "

                Cmd = New SqlCommand(StrSql, con)
                Dim pouchds As New DataSet
                Dim ad As New SqlDataAdapter(Cmd)
                ad.Fill(pouchds)
                Dim i As Integer = 0
                For j = 0 To pouchds.Tables(0).Rows.Count - 1

                    i = i + 1
                    'For i As Integer = 1 To TextBox1.Text

                    Dim StrFName As String
                    StrRef = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(1)), "", pouchds.Tables(0).Rows(j)(1))
                    StrgsCode = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(3)), "", pouchds.Tables(0).Rows(j)(3))
                    StrUDICode = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(89)), "", pouchds.Tables(0).Rows(j)(89))
                    StrOptic = Format(IIf(IsDBNull(pouchds.Tables(0).Rows(j)(5)), "", pouchds.Tables(0).Rows(j)(5)), "0.00")
                    StrLen = Format(IIf(IsDBNull(pouchds.Tables(0).Rows(j)(6)), "", pouchds.Tables(0).Rows(j)(6)), "0.00")
                    StrPwr = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(4)), "", pouchds.Tables(0).Rows(j)(4))

                    StrExp = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(5)), "", pouchds.Tables(0).Rows(j)(5))

                    strmfdmon = Format(IIf(IsDBNull(pouchds.Tables(0).Rows(j)(16)), "", pouchds.Tables(0).Rows(j)(16)), "00")
                    strmfdyear = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(17)), "", pouchds.Tables(0).Rows(j)(17))

                    StrEpMon = Format(IIf(IsDBNull(pouchds.Tables(0).Rows(j)(18)), "", pouchds.Tables(0).Rows(j)(18)), "00")
                    StrEpYr = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(19)), "", pouchds.Tables(0).Rows(j)(19))
                    StrBrand = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(0)), "", pouchds.Tables(0).Rows(j)(0))
                    StrRefName = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(2)), "", pouchds.Tables(0).Rows(j)(2))
                    StrRef = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(1)), "", pouchds.Tables(0).Rows(j)(1))
                    StrLotPrefix = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(13)), "", pouchds.Tables(0).Rows(j)(13))
                    StrLotNo = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(14)), "", pouchds.Tables(0).Rows(j)(14))
                    StrSrNo = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(15)), "", pouchds.Tables(0).Rows(j)(15))
                    StrMdl = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(1)), "", pouchds.Tables(0).Rows(j)(1))
                    Strbtc = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(58)), "", pouchds.Tables(0).Rows(j)(58))
                    Stract = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(52)), "", pouchds.Tables(0).Rows(j)(52))

                    Stracpwr = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(65)), "", pouchds.Tables(0).Rows(j)(65))

                    StrExp = StrEpYr & "-" & StrEpMon

                    strmfd = strmfdyear & "-" & strmfdmon


                    StrFName = BTWFileName(pouchds.Tables(0).Rows(j)("Model_Name"), cmbPrintLabel.Text)
                    StrFName = StrFName.Replace("POUCH", "POWER")

                    If StrFName = "" Then
                        MessageBox.Show("BTW file record not found")
                        Exit Sub
                    End If

                    strpwradd = StrPwr & " " & "D"
                    Stracpwr = Stracpwr & " " & "D"
                    len = StrLen & "  " & "mm"
                    opt = StrOptic & "  " & "mm"

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
                    'ElseIf StrRef = "SPTFDY 200" Then
                    '    strpwradd = StrPwr & " " & "D" & "    " & "ADD 3.50"
                    'ElseIf StrRef = "SUPRAPHOB MS" Then
                    '    strpwradd = StrPwr & " " & "D" & " " & "Adl" & " " & Strcyl & " " & " D"
                    'ElseIf StrRef = "SP INFO" Then
                    '    strpwradd = StrPwr & " " & "D"
                    'Else
                    '    strpwradd = StrPwr & " " & "D"
                    '    Stracpwr = Stracpwr & " " & "D"
                    '    Len = StrLen & "  " & "mm"
                    '    opt = StrOptic & "  " & "mm"
                    'End If

                    StrSronlyNo = StrLotPrefix & StrLotNo

                    StroneDBar = StrSrNo

                    Dim StrEanCode As String
                    StrEanCode = StrgsCode.ToString().Remove(StrgsCode.ToString().Length - 1, 1)

                    Dim strbtcexpiry As String = StrEpYr.Substring(2, 2)
                    StrInexp1 = strbtcexpiry & StrEpMon & "00"
                    Dim strbtcmfd As String = strmfdyear.Substring(2, 2)
                    StrInmfd = strbtcmfd & strmfdmon & "00"
                    StroneDBar = StroneDBar.Replace(" ", "")

                    If StrEanCode = "" Or Strbtc = "" Then
                        MessageBox.Show("Batch Or GSCode Missing for " & StroneDBar)
                        Exit Sub
                    End If


                    btFile = Application.StartupPath & "\" & StrFName & ""
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)



                    If i Mod 2 = 0 Then
                        bt.SetNamedSubStringValue("Pwr2", strpwradd)
                        bt.SetNamedSubStringValue("LotNo2", StroneDBar)
                        bt.SetNamedSubStringValue("apwr2", Stracpwr)
                        bt.PrintOut()
                        bt.Close()
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                        'i = 0
                    Else
                        'bt.SetNamedSubStringValue("Ref", StrMdl)
                        bt.SetNamedSubStringValue("Pwr", strpwradd)
                        'bt.SetNamedSubStringValue("Brandname", strrefname1)
                        bt.SetNamedSubStringValue("LotNo", StroneDBar)
                        'bt.SetNamedSubStringValue("optic", StrOptic)
                        'bt.SetNamedSubStringValue("Length", StrLen)
                        'bt.SetNamedSubStringValue("Expdate", StrExp)
                        'bt.SetNamedSubStringValue("mfddate", strmfd)
                        bt.SetNamedSubStringValue("apwr", Stracpwr)
                        'bt.SetNamedSubStringValue("EanCode", StrEanCode)
                        'bt.SetNamedSubStringValue("Btc", Strbtc)
                        'bt.SetNamedSubStringValue("mfdtwod", StrInmfd)
                        'bt.SetNamedSubStringValue("exptwod", StrInexp1)
                    End If






                Next j

                If i Mod 2 <> 0 Then
                    bt.SetNamedSubStringValue("Pwr2", "")
                    bt.SetNamedSubStringValue("LotNo2", "")
                    bt.SetNamedSubStringValue("apwr2", "")
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                End If

                Cmd.Dispose()
            Else
                'SUPERPHOB

                StrSql = "select * from  POUCH_LABEL where RefLot = '" & cmbreflot.Text & "' and  Power = '" & cmbpower.Text & "'  order by Lot_SrNo "

                Cmd = New SqlCommand(StrSql, con)
                Dim pouchds As New DataSet
                Dim ad As New SqlDataAdapter(Cmd)
                ad.Fill(pouchds)
                Dim i As Integer = 0
                For j = 0 To pouchds.Tables(0).Rows.Count - 1

                    i = i + 1
                    StrPwr = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(4)), "", pouchds.Tables(0).Rows(j)(4))
                    StrSrNo = Format(IIf(IsDBNull(pouchds.Tables(0).Rows(j)(11)), "", pouchds.Tables(0).Rows(j)(11)), "00000")
                    strpwradd = StrPwr & " " & "D"

                    Dim StrFName As String
                    StrFName = BTWFileName(pouchds.Tables(0).Rows(j)("Model_Name"), cmbPrintLabel.Text)
                    StrFName = StrFName.Replace("POUCH", "POWER")
                    If StrFName = "" Then
                        MessageBox.Show("BTW file record not found")
                        Exit Sub
                    End If

                    btFile = Application.StartupPath & "\" & StrFName & ""
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("Pwr", strpwradd)
                    bt.SetNamedSubStringValue("SrNo", StrSrNo)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)


                Next j
                Cmd.Dispose()

            End If







            cmbreflot.Text = ""
            cmbpower.Text = ""
            TextBox1.Text = ""
            ComboBox1.Text = ""
            TextBox2.Text = ""

        Catch ex As Exception

            MsgBox("An unexpected error occurred.")
            Exit Sub

        End Try

        
    End Sub

    Private Sub txtsigsrno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsigsrno.KeyDown
        If e.KeyCode = Keys.Enter Then

            If txtsigsrno.Text <> "" Then

                Try

                    If cmbPrintLabel.SelectedItem Is Nothing Then
                        Err.SetError(cmbPrintLabel, "Please Select valid Label")
                        cmbPrintLabel.Focus()
                        Exit Sub
                    Else
                        Err.SetError(cmbPrintLabel, "")
                    End If

                    If rdLotSerial.Checked = True Then
                        StrSql = "select * from  POUCH_LABEL where Lot_SrNo = '" & txtsigsrno.Text & "'"
                    ElseIf rdUDICode.Checked = True Then
                        StrSql = "select * from  POUCH_LABEL where Udi_code = '" & txtsigsrno.Text & "'"
                    Else
                        MessageBox.Show("Please Select 'Lot Serial' Or 'UDI Serial'")
                        Exit Sub
                    End If

                    Cmd = New SqlCommand(StrSql, con)
                    Dim pouchds As New DataSet
                    Dim ad As New SqlDataAdapter(Cmd)
                    ad.Fill(pouchds)

                    For i = 0 To pouchds.Tables(0).Rows.Count - 1

                        If productline <> "SUPERPHOB" Then

                            Dim StrFName As String


                            StrRef = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(1)), "", pouchds.Tables(0).Rows(i)(1))
                            StrgsCode = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(3)), "", pouchds.Tables(0).Rows(i)(3))
                            StrUDICode = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(89)), "", pouchds.Tables(0).Rows(i)(89))



                            StrOptic = Format(IIf(IsDBNull(pouchds.Tables(0).Rows(i)(5)), "", pouchds.Tables(0).Rows(i)(5)), "0.00")
                            StrLen = Format(IIf(IsDBNull(pouchds.Tables(0).Rows(i)(6)), "", pouchds.Tables(0).Rows(i)(6)), "0.00")
                            StrPwr = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(4)), "", pouchds.Tables(0).Rows(i)(4))

                            StrExp = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(5)), "", pouchds.Tables(0).Rows(i)(5))

                            strmfdmon = Format(IIf(IsDBNull(pouchds.Tables(0).Rows(i)(16)), "", pouchds.Tables(0).Rows(i)(16)), "00")
                            strmfdyear = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(17)), "", pouchds.Tables(0).Rows(i)(17))

                            StrRefName = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(2)), "", pouchds.Tables(0).Rows(i)(2))

                            StrEpMon = Format(IIf(IsDBNull(pouchds.Tables(0).Rows(i)(18)), "", pouchds.Tables(0).Rows(i)(18)), "00")
                            StrEpYr = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(19)), "", pouchds.Tables(0).Rows(i)(19))
                            StrBrand = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(0)), "", pouchds.Tables(0).Rows(i)(0))

                            StrRef = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(1)), "", pouchds.Tables(0).Rows(i)(1))
                            StrLotPrefix = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(13)), "", pouchds.Tables(0).Rows(i)(13))
                            StrLotNo = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(14)), "", pouchds.Tables(0).Rows(i)(14))
                            StrSrNo = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(15)), "", pouchds.Tables(0).Rows(i)(15))
                            StrMdl = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(1)), "", pouchds.Tables(0).Rows(i)(1))
                            Strbtc = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(58)), "", pouchds.Tables(0).Rows(i)(58))
                            Stract = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(65)), "", pouchds.Tables(0).Rows(i)(65))

                            Strcyl = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(53)), "", pouchds.Tables(0).Rows(i)(53))
                            Stracpwr = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(65)), "", pouchds.Tables(0).Rows(i)(65))
                            StrExp = StrEpYr & "-" & StrEpMon

                            strmfd = strmfdyear & "-" & strmfdmon

                            StrFName = BTWFileName(pouchds.Tables(0).Rows(i)("Model_Name"), cmbPrintLabel.Text)
                            StrFName = StrFName.Replace("POUCH", "POWER")
                            If StrFName = "" Then
                                MessageBox.Show("BTW file record not found")
                                Exit Sub
                            End If


                            StrSronlyNo = StrLotPrefix & StrLotNo

                            StroneDBar = StrSrNo
                            strpwradd = StrPwr & " " & "D"
                            Stracpwr = Stract & " " & "D"

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

                            'ElseIf StrRef = "SPTFDY 200" Then
                            '    strpwradd = StrPwr & " " & "D" & "   " & "ADD 3.50"

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
                            '    strpwradd = StrPwr & " " & "D"
                            '    Stracpwr = Stract & " " & "D"
                            'End If



                            Dim StrEanCode As String
                            StrEanCode = StrgsCode.ToString().Remove(StrgsCode.ToString().Length - 1, 1)

                            Dim strbtcexpiry As String = StrEpYr.Substring(2, 2)
                            StrInexp1 = strbtcexpiry & StrEpMon & "00"
                            Dim strbtcmfd As String = strmfdyear.Substring(2, 2)
                            StrInmfd = strbtcmfd & strmfdmon & "00"
                            StroneDBar = StroneDBar.Replace(" ", "")

                            If StrEanCode = "" Or Strbtc = "" Then
                                MessageBox.Show("Batch Or GSCode Missing for " & StroneDBar)
                                Exit Sub
                            End If


                            btFile = Application.StartupPath & "\" & StrFName & ""
                            bt = bApp.Formats.Open(btFile, , DefaultPrinterName)



                            bt.SetNamedSubStringValue("Pwr", strpwradd)
                            bt.SetNamedSubStringValue("LotNo", StroneDBar)
                            bt.SetNamedSubStringValue("apwr", Stracpwr)
                            bt.SetNamedSubStringValue("Pwr2", "")
                            bt.SetNamedSubStringValue("LotNo2", "")
                            bt.SetNamedSubStringValue("apwr2", "")


                            bt.PrintOut()

                            bt.Close()
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                        Else
                            'Superphob

                            StrPwr = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(4)), "", pouchds.Tables(0).Rows(i)(4))
                            StrSrNo = Format(IIf(IsDBNull(pouchds.Tables(0).Rows(i)(11)), "", pouchds.Tables(0).Rows(i)(11)), "00000")
                            strpwradd = StrPwr & " " & "D"

                            Dim StrFName As String
                            StrFName = BTWFileName(pouchds.Tables(0).Rows(i)("Model_Name"), cmbPrintLabel.Text)
                            StrFName = StrFName.Replace("POUCH", "POWER")
                            If StrFName = "" Then
                                MessageBox.Show("BTW file record not found")
                                Exit Sub
                            End If

                            btFile = Application.StartupPath & "\" & StrFName & ""
                            bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                            bt.SetNamedSubStringValue("Pwr", strpwradd)
                            bt.SetNamedSubStringValue("SrNo", StrSrNo)
                            bt.PrintOut()
                            bt.Close()
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)


                        End If





                    Next

                    Cmd.Dispose()

                    txtsigsrno.Text = ""

                    txtsigsrno.Focus()

                Catch ex As Exception
                    MsgBox("An unexpected error occurred.")
                    Exit Sub
                End Try

                


            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Menulblmstdatacre.LblHomeMenuDisplyName.Visible = False
        Menulblmstdatacre.TimHomeSideDisply.Start()
    End Sub
End Class