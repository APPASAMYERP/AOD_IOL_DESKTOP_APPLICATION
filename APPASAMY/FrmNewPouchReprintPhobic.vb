Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft
Imports System.Data.Sql



Public Class FrmNewPouchReprintPhobic
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

    

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click, Button1.Click
        Me.Close()
        Menulblmstdatacre.LblHomeMenuDisplyName.Visible = False
        Menulblmstdatacre.TimHomeSideDisply.Start()
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        txtcrFromQty.Text = ""
        txtcrToQty.Text = ""
    End Sub


    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click


        'Validation.
        If cmbreflot.Text = "" Then
            err.SetError(cmbreflot, "This information is required")
            cmbreflot.Focus()
            Exit Sub
        Else
            err.SetError(cmbreflot, "")
        End If

        If cmbpower.Text = "" Then
            err.SetError(cmbpower, "This information is required")
            cmbpower.Focus()
            Exit Sub
        Else
            err.SetError(cmbpower, "")
        End If

        If cmbreflot.SelectedItem Is Nothing Then
            err.SetError(cmbreflot, "Please Select valid RefLot")
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

        If Val(TextBox2.Text) < 1 Then
            err.SetError(TextBox2, "Enter Minimum 1 Qty")
            TextBox2.Focus()
            Exit Sub
        Else
            err.SetError(TextBox2, "")
        End If


        StrSql = "select * from  POUCH_LABEL where RefLot = '" & cmbreflot.Text & "' and  Power = '" & cmbpower.Text & "' and Status ='Labelled'  order by Lot_SrNo"
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

        ''UPDATE POUCHSTATION
        'If productline = "SUPERPHOB" Then
        '    StrSql = "Update  POUCH_LABEL set PouchStation ='" & station & "', Created_by='" & StrLoginUser & "' where RefLot = '" & cmbreflot.Text & "' and  Power = '" & cmbpower.Text & "'  and pouchstation is null and Status ='Labelled'"
        '    Cmd = New SqlCommand(StrSql, con)
        '    Cmd.ExecuteNonQuery()
        '    Cmd.Dispose()
        'End If


        StrSql = "select * from  POUCH_LABEL where RefLot = '" & cmbreflot.Text & "' and  Power = '" & cmbpower.Text & "' and Status ='Labelled' order by Lot_SrNo "
        'StrSql = "select * from  POUCH_LABEL where Lot_SrNo Between '" & txtcrFromQty.Text & "' and '" & txtcrToQty.Text & "'"
        Cmd = New SqlCommand(StrSql, con)
        Dim pouchds As New DataSet
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(pouchds)

        For j = 0 To pouchds.Tables(0).Rows.Count - 1
            If productline = "SUPERPHOB" Then
                If IIf(IsDBNull(pouchds.Tables(0).Rows(j)(63)), "", pouchds.Tables(0).Rows(j)(63)).ToString() <> cmbPrintLabel.Text Then
                    MessageBox.Show("Label Name Mismatch. Please check.")
                    Exit For
                End If
            Else
                If IIf(IsDBNull(pouchds.Tables(0).Rows(j)(86)), "", pouchds.Tables(0).Rows(j)(86)).ToString() <> cmbPrintLabel.Text Then
                    MessageBox.Show("Label Name Mismatch. Please check.")
                    Exit For
                End If
            End If
            

            'For i As Integer = 1 To TextBox1.Text

            Dim StrFName As String
            StrRef = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(1)), "", pouchds.Tables(0).Rows(j)(1))
            StrgsCode = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(3)), "", pouchds.Tables(0).Rows(j)(3))
            If productline <> "SUPERPHOB" Then
                StrUDICode = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(89)), "", pouchds.Tables(0).Rows(j)(89))
                Strbtc = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(58)), "", pouchds.Tables(0).Rows(j)(58))
                Stracpwr = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(65)), "", pouchds.Tables(0).Rows(j)(65))
            End If


            ' If (StrRef = "502") Or (StrRef = "601") Or (StrRef = "701") Or (StrRef = "nAs207") Or (StrRef = "nAsY207") Or (StrRef = "701H") Or (StrRef = "ULTRASMART") Then

            'StrFName = "PouchPhilic.btw"

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
            If productline = "SUPERPHOB" Then
                Stracpwr = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(52)), "", pouchds.Tables(0).Rows(j)(52))
            End If




            StrExp = StrEpYr & "-" & StrEpMon

            strmfd = strmfdyear & "-" & strmfdmon


            StrFName = BTWFileName(pouchds.Tables(0).Rows(j)("Model_Name"), cmbPrintLabel.Text)
            If StrFName = "" Then
                MessageBox.Show("BTW file record not found")
                Exit Sub
            End If

            'Dim strss As String

            'strss = StrSrNo.Remove(7, 1)

            'StroneDBar = strss & "," & Strbtc




            If StrRef = "SP-TORIC T3" Then
                strpwradd = StrPwr & " " & "D" & "     " & "CYL 1.50"
            ElseIf StrRef = "SP-TORIC T4" Then
                strpwradd = StrPwr & " " & "D" & "     " & "CYL 2.25"
            ElseIf StrRef = "SP-TORIC T5" Then
                strpwradd = StrPwr & " " & "D" & "     " & "CYL 3.00"
            ElseIf StrRef = "SP-TORIC T6" Then
                strpwradd = StrPwr & " " & "D" & "     " & "CYL 3.75"
            ElseIf StrRef = "SP-TORIC T7" Then
                strpwradd = StrPwr & " " & "D" & "     " & "CYL 4.50"
            ElseIf StrRef = "SP-TORIC T8" Then
                strpwradd = StrPwr & " " & "D" & "     " & "CYL 5.25"
            ElseIf StrRef = "SP-TORIC T9" Then
                strpwradd = StrPwr & " " & "D" & "     " & "CYL 6.00"
            ElseIf StrRef = "MFD605" Then
                strpwradd = StrPwr & " " & "D" & "     " & "Adl 3.50 D"

            ElseIf StrRef = "MFDY605" Then
                strpwradd = StrPwr & " " & "D" & "     " & "Adl 3.50 D"



            ElseIf StrRef = "SPMFD200" Then
                strpwradd = StrPwr & " " & "D" & " " & "Adl" & " " & Strcyl & " " & " D"

            ElseIf StrRef = "SPMFDY200" Then
                strpwradd = StrPwr & " " & "D" & " " & "Adl" & " " & Strcyl & " " & " D"


            ElseIf StrRef = "SPTFDY 200" Then
                strpwradd = StrPwr & " " & "D"


            ElseIf StrRef = "SUPRAPHOB MS" Then
                strpwradd = StrPwr & " " & "D" & " " & "Adl" & " " & Strcyl & " " & " D"

            ElseIf StrRef = "SP INFO" Then
                strpwradd = StrPwr & " " & "D"
                'strpwradd = StrPwr & " " & "D" & " " & "Adl" & " " & Strcyl & " " & " D"

            Else
                strpwradd = StrPwr & " " & "D"
                Stracpwr = Stracpwr & " " & "D"
                len = StrLen & "  " & "mm"
                opt = StrOptic & "  " & "mm"
            End If










            If RdoRef.Checked = True Then
                strrefname1 = StrRef
            Else
                strrefname1 = StrBrand
            End If

            StrSronlyNo = StrLotPrefix & StrLotNo

            StroneDBar = StrSrNo



            'StrlotonlyNo = LblShowLotPrefix.Text & LblShowLotNo.Text

            'StrlotBarNo = LblShowLotPrefix.Text & LblShowLotNo.Text & " " & Format(StrStPrQty, "000")

            'StrOptic = StrOptic & " " & "mm"
            'StrLen = StrLen & " " & "mm"
            'StrPwr = StrPwr & " " & "D"

            Dim StrEanCode As String
            StrEanCode = StrgsCode.ToString().Remove(StrgsCode.ToString().Length - 1, 1)

            Dim strbtcexpiry As String = StrEpYr.Substring(2, 2)
            StrInexp1 = strbtcexpiry & StrEpMon & "00"
            Dim strbtcmfd As String = strmfdyear.Substring(2, 2)
            StrInmfd = strbtcmfd & strmfdmon & "00"


            If productline <> "SUPERPHOB" Then
                StroneDBar = StroneDBar.Replace(" ", "")
                If StrEanCode = "" Or Strbtc = "" Or StrUDICode = "" Then
                    MessageBox.Show("Batch Or GSCode Missing for " & StroneDBar)
                    Exit Sub
                End If
            End If

            


            btFile = Application.StartupPath & "\" & StrFName & ""
            bt = bApp.Formats.Open(btFile, , DefaultPrinterName)

            'If StrRef = "AE-01" Then
            bt.SetNamedSubStringValue("Ref", StrMdl)
            bt.SetNamedSubStringValue("Pwr", strpwradd)
            bt.SetNamedSubStringValue("Brandname", strrefname1)
            'bt.SetNamedSubStringValue("SNo", StrlotBarNo)
            bt.SetNamedSubStringValue("LotNo", StroneDBar)
            bt.SetNamedSubStringValue("optic", StrOptic)
            bt.SetNamedSubStringValue("Length", StrLen)
            bt.SetNamedSubStringValue("Expdate", StrExp)
            bt.SetNamedSubStringValue("mfddate", strmfd)
            bt.SetNamedSubStringValue("apwr", Stracpwr)

            bt.SetNamedSubStringValue("EanCode", StrEanCode)
            bt.SetNamedSubStringValue("Btc", Strbtc)
            bt.SetNamedSubStringValue("mfdtwod", StrInmfd)
            bt.SetNamedSubStringValue("exptwod", StrInexp1)


            'Else
            '    bt.SetNamedSubStringValue("Ref", StrMdl)
            '    bt.SetNamedSubStringValue("Pwr", strpwradd)
            '    bt.SetNamedSubStringValue("Brandname", strrefname1)
            '    'bt.SetNamedSubStringValue("SNo", StrlotBarNo)
            '    bt.SetNamedSubStringValue("LotNo", StroneDBar)
            '    bt.SetNamedSubStringValue("optic", StrOptic)
            '    bt.SetNamedSubStringValue("Length", StrLen)
            '    bt.SetNamedSubStringValue("Expdate", StrExp)
            '    bt.SetNamedSubStringValue("mfddate", strmfd)
            '    bt.SetNamedSubStringValue("apwr", Stracpwr)

            'End If
            bt.PrintOut()

            bt.Close()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)


            'Next i




        Next j


        Cmd.Dispose()

        cmbreflot.Text = ""
        cmbpower.Text = ""
        TextBox1.Text = ""
        ComboBox1.Text = ""
        TextBox2.Text = ""



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

    Private Sub FrmNewPouchReprintPhobic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LabelNameBind()
        StrSql = "SELECT DISTINCT RefLot from POUCH_LABEL WHERE Status ='Labelled' order by RefLot"
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
                        StrSql = "select * from  POUCH_LABEL where Lot_SrNo = '" & txtsigsrno.Text & "'   AND (Status = 'Labelled') "
                    ElseIf rdUDICode.Checked = True Then
                        StrSql = "select * from  POUCH_LABEL where Udi_code = '" & txtsigsrno.Text & "' AND (Status = 'Labelled') "
                    Else
                        MessageBox.Show("Please Select 'Lot Serial' Or 'UDI Serial'")
                        Exit Sub
                    End If

                    Cmd = New SqlCommand(StrSql, con)
                    Dim pouchds As New DataSet
                    Dim ad As New SqlDataAdapter(Cmd)
                    ad.Fill(pouchds)



                    For i = 0 To pouchds.Tables(0).Rows.Count - 1

                        If productline = "SUPERPHOB" Then
                            If IIf(IsDBNull(pouchds.Tables(0).Rows(i)(63)), "", pouchds.Tables(0).Rows(i)(63)).ToString() <> cmbPrintLabel.Text Then
                                MessageBox.Show("Label Name Mismatch. Please check.")
                                Exit For
                            End If
                        Else
                            If IIf(IsDBNull(pouchds.Tables(0).Rows(i)(86)), "", pouchds.Tables(0).Rows(i)(86)).ToString() <> cmbPrintLabel.Text Then
                                MessageBox.Show("Label Name Mismatch. Please check.")
                                Exit For
                            End If
                        End If


                        Dim StrFName As String


                        StrRef = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(1)), "", pouchds.Tables(0).Rows(i)(1))
                        StrgsCode = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(3)), "", pouchds.Tables(0).Rows(i)(3))
                        If productline <> "SUPERPHOB" Then
                            StrUDICode = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(89)), "", pouchds.Tables(0).Rows(i)(89))
                            Strbtc = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(58)), "", pouchds.Tables(0).Rows(i)(58))
                            Stracpwr = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(65)), "", pouchds.Tables(0).Rows(i)(65))
                            Strcyl = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(66)), "", pouchds.Tables(0).Rows(i)(66))
                        End If


                        'If (StrRef = "502") Or (StrRef = "601") Or (StrRef = "701") Or (StrRef = "nAs207") Or (StrRef = "nAsY207") Or (StrRef = "701H") Then

                        '    StrFName = "PouchPhilic.btw"

                        'ElseIf (StrRef = "SPMFDY200") Or (StrRef = "SPMFD200") Or (StrRef = "SUPRAPHOB MS") Or (StrRef = "SP INFO") Then

                        '    StrFName = "Pouch_MFD.btw"

                        'ElseIf (StrRef = "SP-TORIC T3" Or StrRef = "SP-TORIC T4" Or StrRef = "SP-TORIC T5" Or StrRef = "SP-TORIC T6" Or StrRef = "SP-TORIC T7" Or StrRef = "SP-TORIC T8" Or StrRef = "SP-TORIC T9" Or StrRef = "MFD605") Then

                        '    StrFName = "Pouch_Toric.btw"

                        'ElseIf (StrRef = "MFDY605") Then

                        '    StrFName = "Pouch_Toric_MFD.btw"

                        'Else
                        '    StrFName = "Pouch.btw"
                        'End If

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



                        If productline = "SUPERPHOB" Then
                            Stracpwr = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(52)), "", pouchds.Tables(0).Rows(i)(52))
                            Strcyl = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(53)), "", pouchds.Tables(0).Rows(i)(53))
                        End If




                        'Strcyl = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(53)), "", pouchds.Tables(0).Rows(i)(53))

                        StrExp = StrEpYr & "-" & StrEpMon

                        strmfd = strmfdyear & "-" & strmfdmon

                        StrFName = BTWFileName(pouchds.Tables(0).Rows(i)("Model_Name"), cmbPrintLabel.Text)



                        If StrFName = "" Then
                            MessageBox.Show("BTW file record not found")
                            Exit Sub
                        End If

                        Dim cylType As String = ""
                        Dim swiToricModel As String = ""

                        'StrExp = StrEpYr & "-" & StrEpMon


                        'strmfd = strmfdyear & "-" & strmfdmon

                        'Dim strss As String

                        'strss = StrSrNo.Remove(7, 1)

                        'StroneDBar = strss & "," & Strbtc
                        StrSronlyNo = StrLotPrefix & StrLotNo

                        StroneDBar = StrSrNo

                        If StrRef = "SP-TORIC T3" Then
                            strpwradd = StrPwr & " " & "D" & "     " & "CYL  " & Strcyl
                        ElseIf StrRef = "SP-TORIC T4" Then
                            strpwradd = StrPwr & " " & "D" & "     " & "CYL " & Strcyl
                        ElseIf StrRef = "SP-TORIC T5" Then
                            strpwradd = StrPwr & " " & "D" & "     " & "CYL " & Strcyl
                        ElseIf StrRef = "SP-TORIC T6" Then
                            strpwradd = StrPwr & " " & "D" & "     " & "CYL " & Strcyl
                        ElseIf StrRef = "SP-TORIC T7" Then
                            strpwradd = StrPwr & " " & "D" & "     " & "CYL " & Strcyl
                        ElseIf StrRef = "SP-TORIC T8" Then
                            strpwradd = StrPwr & " " & "D" & "     " & "CYL " & Strcyl
                        ElseIf StrRef = "SP-TORIC T9" Then
                            strpwradd = StrPwr & " " & "D" & "     " & "CYL " & Strcyl
                        ElseIf StrRef = "MFD605" Then
                            strpwradd = StrPwr & " " & "D" & " " & "Adl " & Strcyl

                        ElseIf StrRef = "MFDY605" Then
                            strpwradd = StrPwr & " " & "D" & " " & "Adl " & Strcyl

                            'swiss toric


                        ElseIf StrRef = "SPHTORIC 300-T2" Or StrRef = "SPHTORIC 300-T3" Or StrRef = "SPHTORIC 300-T4" Or StrRef = "SPHTORIC 300-T5" Or StrRef = "SPHTORIC 300-T6" Or StrRef = "SPHTORIC 300-T7" Or StrRef = "SPHTORIC 300-T8" Or StrRef = "SPHTORIC 300-T9" Then
                            strpwradd = StrPwr & " " & "D" & "     " & "CYL : " & Strcyl
                            Dim splitResult As String() = StrRef.Split(New Char() {"-"c})
                            cylType = splitResult(1)
                            swiToricModel = splitResult(0)

                        ElseIf StrRef = "SPTFDY 200" Then
                            strpwradd = StrPwr & " " & "D"

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
                            Stracpwr = Stracpwr & " " & "D"
                        End If

                        If RdoRef.Checked = True Then
                            strrefname1 = StrRef
                        Else
                            strrefname1 = StrBrand
                        End If



                        'StrlotonlyNo = LblShowLotPrefix.Text & LblShowLotNo.Text

                        'StrlotBarNo = LblShowLotPrefix.Text & LblShowLotNo.Text & " " & Format(StrStPrQty, "000")

                        'StrOptic = StrOptic & " " & "mm"
                        'StrLen = StrLen & " " & "mm"
                        'StrPwr = StrPwr & " " & "D"

                        Dim StrEanCode As String
                        StrEanCode = StrgsCode.ToString().Remove(StrgsCode.ToString().Length - 1, 1)

                        Dim strbtcexpiry As String = StrEpYr.Substring(2, 2)
                        StrInexp1 = strbtcexpiry & StrEpMon & "00"
                        Dim strbtcmfd As String = strmfdyear.Substring(2, 2)
                        StrInmfd = strbtcmfd & strmfdmon & "00"

                        If productline <> "SUPERPHOB" Then
                            StroneDBar = StroneDBar.Replace(" ", "")
                            If StrEanCode = "" Or Strbtc = "" Or StrUDICode = "" Then
                                MessageBox.Show("Batch Or GSCode Missing for " & StroneDBar)
                                Exit Sub
                            End If
                        End If




                        '----------------------------------------------
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
                        bt.SetNamedSubStringValue("apwr", Stracpwr)

                        bt.SetNamedSubStringValue("EanCode", StrEanCode)
                        bt.SetNamedSubStringValue("Btc", Strbtc)
                        bt.SetNamedSubStringValue("mfdtwod", StrInmfd)
                        bt.SetNamedSubStringValue("exptwod", StrInexp1)
                        If strrefname1 = "SWISSPHOB TORIC" Then
                            bt.SetNamedSubStringValue("cylType", cylType)
                            bt.SetNamedSubStringValue("swiToricModel", swiToricModel)
                        End If

                        bt.PrintOut()

                        bt.Close()
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                        '-----------------------------------------------------



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
    Private Function ReplacePlaceholder(ByVal input As String, ByVal placeholder As String, ByVal replacement As String) As String
        If input.Contains(placeholder) Then
            input = input.Replace(placeholder, replacement)
        End If
        Return input
    End Function

   
    Private Sub cmbreflot_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbreflot.SelectedIndexChanged

        StrSql = "SELECT DISTINCT Power from POUCH_LABEL where RefLot='" & cmbreflot.Text & "'  and Status ='Labelled' order by Power"
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        cmbpower.Items.Clear()
        While StrRs.Read
            cmbpower.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        Cmd.Dispose()
    End Sub

    Private Sub cmbpower_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpower.SelectedIndexChanged

        

        Dim Strsql As String
        Strsql = "select sum (Qty_1) as Balance_Qty  from POUCH_LABEL where  RefLot='" & cmbreflot.Text & "' and  Power='" & cmbpower.Text & "' and Status ='Labelled'"
        Cmd = New SqlCommand(Strsql, con)
        StrRs = Cmd.ExecuteReader
        If StrRs.Read Then
            TextBox2.Text = IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0))
        Else
            TextBox2.Text = ""

        End If
        StrRs.Close()
        Cmd.Dispose()

        'StrSql = "SELECT DISTINCT Lot_SrNo from POUCH_LABEL where RefLot='" & cmbreflot.Text & "' and Power='" & cmbpower.Text & "' order by Lot_SrNo"
        'Cmd = New SqlCommand(StrSql, con)
        'StrRs = Cmd.ExecuteReader
        'ComboBox1.Items.Clear()
        'While StrRs.Read
        '    ComboBox1.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        'End While
        'StrRs.Close()
        'Cmd.Dispose()


    End Sub

    Private Sub rdLotSerial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdLotSerial.CheckedChanged
        rdUDICode.Checked = False
    End Sub

    Private Sub rdUDICode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdUDICode.CheckedChanged
        rdLotSerial.Checked = False
    End Sub


End Class