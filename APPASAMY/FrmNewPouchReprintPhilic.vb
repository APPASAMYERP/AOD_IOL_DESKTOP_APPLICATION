Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft
Imports System.Data.Sql



Public Class FrmNewPouchReprintPhilic
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
    Dim StrgsCode As String
    Dim StrOptic, strpwradd, StrRefName, StrInexp1, StrInmfd, Strcyl, StrLen, StrPwr, StrRef, StrExp, StrBrand, StrLotPrefix, StrLotNo, StrSrNo, StrEpMon, StrEpYr, StrMdl, Strbtc, StrlotBarNo, StroneDBar, StrSronlyNo, strrefname1 As String

    

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

        Try

            If cmbPrintLabel.SelectedItem Is Nothing Then
                err.SetError(cmbPrintLabel, "Please Select valid Label")
                cmbPrintLabel.Focus()
                Exit Sub
            Else
                err.SetError(cmbPrintLabel, "")
            End If


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

            StrSql = "select * from  POUCH_LABEL where Lot_SrNo Between '" & txtcrFromQty.Text & "' and '" & txtcrToQty.Text & "'  order by Lot_SrNo"
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
                Exit Sub
            End If
            StrRs.Close()
            Cmd.Dispose()



            StrSql = "select * from  POUCH_LABEL where Lot_SrNo Between '" & txtcrFromQty.Text & "' and '" & txtcrToQty.Text & "' order by Lot_SrNo "
            Cmd = New SqlCommand(StrSql, con)
            Dim pouchds As New DataSet
            Dim ad As New SqlDataAdapter(Cmd)
            ad.Fill(pouchds)

            For i = 0 To pouchds.Tables(0).Rows.Count - 1

                If IIf(IsDBNull(pouchds.Tables(0).Rows(i)(85)), "", pouchds.Tables(0).Rows(i)(85)).ToString() <> cmbPrintLabel.Text Then
                    MessageBox.Show("Label Name Mismatch. Please check.")
                    Exit For
                End If
                Dim StrFName As String


                StrRef = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(1)), "", pouchds.Tables(0).Rows(i)(1))
                StrgsCode = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(3)), "", pouchds.Tables(0).Rows(i)(3))
                'StrFName = "PHILICPOUCH.btw"


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


                'Strcyl = IIf(IsDBNull(StrRs.GetValue(67)), "", StrRs.GetValue(67))

                StrExp = StrEpYr & "-" & StrEpMon

                strmfd = strmfdyear & "-" & strmfdmon

                StrFName = BTWFileName(pouchds.Tables(0).Rows(i)("Model_Name"), cmbPrintLabel.Text)
                If StrFName = "" Then
                    MessageBox.Show("BTW file record not found")
                    Exit Sub
                End If

                'Dim strss As String

                'strss = StrSrNo.Remove(7, 1)

                'StroneDBar = strss & "," & Strbtc




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
                strpwradd = StrPwr & " " & "D"
                ' End If


                Dim steirli As String
                Dim nameaddre As String
                Dim licenc As String
                Dim temp As String
                Dim mrp As String


                'StrSql = "SELECT * from LENS_MASTER where Model_Name='" & StrMdl & "' and POWER='" & StrPwr & "' and Type_GS_Code='Aod' and Brand_Name='" & StrBrand & "' "
                'Cmd = New SqlCommand(StrSql, con)
                'If con.State = Data.ConnectionState.Open Then
                '    con.Close()
                'End If
                'con.Open()
                'StrRs = Cmd.ExecuteReader

                'If StrRs.Read Then

                '    steirli = IIf(IsDBNull(StrRs.GetValue(22)), "", StrRs.GetValue(22))
                '    nameaddre = IIf(IsDBNull(StrRs.GetValue(20)), "", StrRs.GetValue(20))
                '    licenc = IIf(IsDBNull(StrRs.GetValue(19)), "", StrRs.GetValue(19))
                '    temp = IIf(IsDBNull(StrRs.GetValue(21)), "", StrRs.GetValue(21))
                '    mrp = IIf(IsDBNull(StrRs.GetValue(17)), "", StrRs.GetValue(17))

                'End If



                Dim Twodbar As String

                'Twodbar = StrBrand + "," + StrMdl + "," + StrPwr + "," + steirli + "," + StrlotBarNo + "," + strmfd + "," + StrExp + "," + mrp + "," + licenc + "," + nameaddre + "," + temp







                If RdoRef.Checked = True Then

                    strrefname1 = StrRefName
                Else
                    strrefname1 = StrBrand
                End If

                StrSronlyNo = StrLotPrefix & StrLotNo

                StroneDBar = StrSrNo

                Twodbar = StrSrNo & "," & strpwradd & "," & StrMdl & "," & strrefname1 & "," & StrOptic & " mm" & "," & StrLen & " mm" & "," & StrExp & "," & Strbtc

                'StrlotonlyNo = LblShowLotPrefix.Text & LblShowLotNo.Text

                'StrlotBarNo = LblShowLotPrefix.Text & LblShowLotNo.Text & " " & Format(StrStPrQty, "000")

                StrOptic = StrOptic & " " & "mm"
                StrLen = StrLen & " " & "mm"
                StrPwr = StrPwr & " " & "D"

                Dim StrEanCode As String
                StrEanCode = StrgsCode.ToString().Remove(StrgsCode.ToString().Length - 1, 1)

                Dim strbtcexpiry As String = StrEpYr.Substring(2, 2)
                StrInexp1 = strbtcexpiry & StrEpMon & "00"
                Dim strbtcmfd As String = strmfdyear.Substring(2, 2)
                StrInmfd = strbtcmfd & strmfdmon & "00"

                If cmbPrintLabel.Text <> "Argentina" Then
                    StroneDBar = StroneDBar.Replace(" ", "")
                End If

                btFile = Application.StartupPath & "\" & StrFName & ""
                bt = bApp.Formats.Open(btFile, , DefaultPrinterName)

                'If StrRef = "AE INFO" Then
                '    bt.SetNamedSubStringValue("Ref", StrMdl)
                '    bt.SetNamedSubStringValue("Pwr", strpwradd)
                '    bt.SetNamedSubStringValue("Brandname", strrefname1)
                '    'bt.SetNamedSubStringValue("SNo", StrlotBarNo)
                '    bt.SetNamedSubStringValue("LotNo", StroneDBar)
                '    bt.SetNamedSubStringValue("optic", StrOptic)
                '    bt.SetNamedSubStringValue("Length", StrLen)
                '    'bt.SetNamedSubStringValue("Expdate", StrExp)
                '    'bt.SetNamedSubStringValue("mfddate", strmfd)
                'Else

                bt.SetNamedSubStringValue("LotNo", StroneDBar)
                bt.SetNamedSubStringValue("Pwr", StrPwr)
                bt.SetNamedSubStringValue("Brandname", strrefname1)
                bt.SetNamedSubStringValue("Ref", StrMdl)
                bt.SetNamedSubStringValue("Expdate", StrExp)
                bt.SetNamedSubStringValue("mfddate", strmfd)
                bt.SetNamedSubStringValue("Twodbar", Twodbar)

                bt.SetNamedSubStringValue("EanCode", StrEanCode)
                bt.SetNamedSubStringValue("Btc", Strbtc)
                bt.SetNamedSubStringValue("mfdtwod", StrInmfd)
                bt.SetNamedSubStringValue("exptwod", StrInexp1)
                'bt.SetNamedSubStringValue("Brandname", strrefname1)
                'bt.SetNamedSubStringValue("SNo", StrlotBarNo)

                bt.SetNamedSubStringValue("optic", StrOptic)
                bt.SetNamedSubStringValue("Length", StrLen)

                'End If
                bt.PrintOut()

                bt.Close()
                System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)




            Next


            Cmd.Dispose()

            txtcrFromQty.Text = ""
            txtcrToQty.Text = ""



        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try

        


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

    Private Sub LabelNameBind()
        Dim ds As New DataSet()
        StrSql = "select distinct LabelName from BTW_Master where Department = 'POUCH'"
        Dim cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)

        cmbPrintLabel.DisplayMember = "LabelName"
        cmbPrintLabel.DataSource = ds.Tables(0)


    End Sub

    Private Sub FrmNewPouchReprintPhilic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LabelNameBind()
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

    Private Sub txtsigsrno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsigsrno.KeyDown
        If e.KeyCode = Keys.Enter Then

            If txtsigsrno.Text <> "" Then

                Try

                    If cmbPrintLabel.SelectedItem Is Nothing Then
                        err.SetError(cmbPrintLabel, "Please Select valid Label")
                        cmbPrintLabel.Focus()
                        Exit Sub
                    Else
                        err.SetError(cmbPrintLabel, "")
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


                        If IIf(IsDBNull(pouchds.Tables(0).Rows(i)(85)), "", pouchds.Tables(0).Rows(i)(85)).ToString() <> cmbPrintLabel.Text Then
                            MessageBox.Show("Label Name Mismatch. Please check.")
                            Exit For
                        End If

                        StrRef = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(1)), "", pouchds.Tables(0).Rows(i)(1))

                        Dim StrFName As String



                        'StrFName = "PHILICPOUCH.btw"


                        StrgsCode = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(3)), "", pouchds.Tables(0).Rows(i)(3))
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

                        Strcyl = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(53)), "", pouchds.Tables(0).Rows(i)(53))

                        StrExp = StrEpYr & "-" & StrEpMon

                        strmfd = strmfdyear & "-" & strmfdmon

                        StrFName = BTWFileName(pouchds.Tables(0).Rows(i)("Model_Name"), cmbPrintLabel.Text)
                        If StrFName = "" Then
                            MessageBox.Show("BTW file record not found")
                            Exit Sub
                        End If


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
                            strpwradd = StrPwr & " " & "D"
                        End If






                        If RdoRef.Checked = True Then
                            strrefname1 = StrRefName
                        Else
                            strrefname1 = StrBrand
                        End If



                        'StrlotonlyNo = LblShowLotPrefix.Text & LblShowLotNo.Text

                        'StrlotBarNo = LblShowLotPrefix.Text & LblShowLotNo.Text & " " & Format(StrStPrQty, "000")

                        StrOptic = StrOptic & " " & "mm"
                        StrLen = StrLen & " " & "mm"
                        StrPwr = StrPwr & " " & "D"

                        Dim StrEanCode As String
                        StrEanCode = StrgsCode.ToString().Remove(StrgsCode.ToString().Length - 1, 1)

                        Dim strbtcexpiry As String = StrEpYr.Substring(2, 2)
                        StrInexp1 = strbtcexpiry & StrEpMon & "00"
                        Dim strbtcmfd As String = strmfdyear.Substring(2, 2)
                        StrInmfd = strbtcmfd & strmfdmon & "00"

                        If cmbPrintLabel.Text <> "Argentina" Then
                            StroneDBar = StroneDBar.Replace(" ", "")
                        End If


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

                        bt.SetNamedSubStringValue("EanCode", StrEanCode)
                        bt.SetNamedSubStringValue("Btc", Strbtc)
                        bt.SetNamedSubStringValue("mfdtwod", StrInmfd)
                        bt.SetNamedSubStringValue("exptwod", StrInexp1)


                        bt.PrintOut()

                        bt.Close()
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)




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

   
    Private Sub txtsigsrno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsigsrno.TextChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub rdobrand_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdobrand.CheckedChanged

    End Sub

    Private Sub rdLotSerial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdLotSerial.CheckedChanged
        rdUDICode.Checked = False
    End Sub

    Private Sub rdUDICode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdUDICode.CheckedChanged
        rdLotSerial.Checked = False
    End Sub
End Class