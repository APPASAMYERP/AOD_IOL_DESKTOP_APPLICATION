Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft
Imports System.Data.Sql



Public Class FrmNewPouchReprint
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
    Dim StrInexp1 As String
    Dim StrInmfd As String
    Dim StrOptic, strpwradd, StrRefName, Strcyl, StrLen, StrPwr1, StrPwr, StrRef, StrExp, StrgsCode, StrBrand, StrLotPrefix, StrLotNo, StrSrNo, StrEpMon, StrEpYr, StrMdl, Strbtc, StrlotBarNo, StroneDBar, StrSronlyNo, strrefname1 As String



    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        txtcrFromQty.Text = ""
        txtcrToQty.Text = ""
    End Sub


    Dim Towd As String

    Private Sub GetTowd()

        Dim acon As String
        Dim ster As String
        Dim com As String
        Dim lic As String
        Dim tem As String
        Dim price1 As String


        StrSql = "select A_Constant ,Sterilize_type,Name_address , LicenceNo , Storage_Temp , price from  LENS_MASTER1 where Brand_Name ='" & StrBrand & "' and Model_Name='" & StrMdl & "' and Power = '" & StrPwr1 & "' "
        Cmd = New SqlCommand(StrSql, con)
        Dim ds As New DataSet
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)

        If ds.Tables(0).Rows.Count <> 0 Then
            acon = Format(IIf(IsDBNull(ds.Tables(0).Rows(0)(0)), "", ds.Tables(0).Rows(0)(0)), "0.00")
            ster = IIf(IsDBNull(ds.Tables(0).Rows(0)(1)), "", ds.Tables(0).Rows(0)(1))
            com = IIf(IsDBNull(ds.Tables(0).Rows(0)(2)), "", ds.Tables(0).Rows(0)(2))
            lic = IIf(IsDBNull(ds.Tables(0).Rows(0)(3)), "", ds.Tables(0).Rows(0)(3))
            tem = IIf(IsDBNull(ds.Tables(0).Rows(0)(4)), "", ds.Tables(0).Rows(0)(4))
            price1 = IIf(IsDBNull(ds.Tables(0).Rows(0)(5)), "", ds.Tables(0).Rows(0)(5))

        End If

        Towd = StroneDBar & "," & strrefname1 & "," & StrMdl & "," & StrPwr & "" & "D" & "," & StrOptic & "" & "," & StrLen & "" & "," & acon & "," & ster & "," & strmfd & "," & StrExp & "," & com & "," & lic & "," & tem & "," & price1


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

            'StrSql = "select * from  POUCH_LABEL where Lot_SrNo Between '" & txtcrFromQty.Text & "' and '" & txtcrToQty.Text & "' order by Lot_SrNo "
            'Cmd = New SqlCommand(StrSql, con)
            'If con.State = Data.ConnectionState.Open Then
            '    con.Close()
            'End If
            'con.Open()
            'StrRs = Cmd.ExecuteReader
            'If StrRs.Read Then
            '    'StrRs.Close()
            'Else
            '    MsgBox("No Data Found", MsgBoxStyle.Critical)
            '    Exit Sub
            'End If
            'StrRs.Close()
            'Cmd.Dispose()








            Dim StrFName As String
            'StrFName = "PMMA_Case&Pouch_LABEL.btw"





            StrSql = "select * from  POUCH_LABEL where Lot_SrNo Between '" & txtcrFromQty.Text & "' and '" & txtcrToQty.Text & "' order by Lot_SrNo"
            Cmd = New SqlCommand(StrSql, con)
            Dim pouchds As New DataSet
            Dim ad As New SqlDataAdapter(Cmd)
            ad.Fill(pouchds)

            For i = 0 To pouchds.Tables(0).Rows.Count - 1


                If IIf(IsDBNull(pouchds.Tables(0).Rows(i)(70)), "", pouchds.Tables(0).Rows(i)(70)).ToString() <> cmbPrintLabel.Text Then
                    MessageBox.Show("Label Name Mismatch. Please check.")
                    Exit For
                End If


                StrRef = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(1)), "", pouchds.Tables(0).Rows(i)(1))
                StrgsCode = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(3)), "", pouchds.Tables(0).Rows(i)(3))
                StrOptic = Format(IIf(IsDBNull(pouchds.Tables(0).Rows(i)(5)), "", pouchds.Tables(0).Rows(i)(5)), "0.00")
                StrLen = Format(IIf(IsDBNull(pouchds.Tables(0).Rows(i)(6)), "", pouchds.Tables(0).Rows(i)(6)), "0.00")
                StrPwr = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(4)), "", pouchds.Tables(0).Rows(i)(4))
                StrPwr1 = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(4)), "", pouchds.Tables(0).Rows(i)(4))

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
                Strbtc = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(51)), "", pouchds.Tables(0).Rows(i)(51))

                Strcyl = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(53)), "", pouchds.Tables(0).Rows(i)(53))

                StrExp = StrEpYr & "-" & StrEpMon

                strmfd = strmfdyear & "-" & strmfdmon



                StrFName = BTWFileName(pouchds.Tables(0).Rows(i)("Model_Name"), cmbPrintLabel.Text) 'pouchds.Tables(0).Rows(i)("PouchBTWLabelName")
                If StrFName = "" Then
                    MessageBox.Show("BTW file record not found")
                    Exit Sub
                End If

                StrRef = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(1)), "", pouchds.Tables(0).Rows(i)(1))


                If RdoRef.Checked = True Then
                    strrefname1 = StrRef
                Else
                    strrefname1 = StrBrand
                End If

                StrSronlyNo = StrLotPrefix & StrLotNo

                StroneDBar = StrSrNo



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

                GetTowd()

                btFile = Application.StartupPath & "\" & StrFName & ""
                bt = bApp.Formats.Open(btFile, , DefaultPrinterName)


                bt.SetNamedSubStringValue("Ref", StrMdl)
                bt.SetNamedSubStringValue("Pwr", StrPwr)
                bt.SetNamedSubStringValue("Brandname", strrefname1)
                'bt.SetNamedSubStringValue("SNo", StrlotBarNo)
                bt.SetNamedSubStringValue("LotNo", StroneDBar)
                bt.SetNamedSubStringValue("optic", StrOptic)
                bt.SetNamedSubStringValue("Length", StrLen)
                bt.SetNamedSubStringValue("Expdate", StrExp)
                bt.SetNamedSubStringValue("mfddate", strmfd)
                bt.SetNamedSubStringValue("Twodbar", Towd)

                bt.SetNamedSubStringValue("EanCode", StrEanCode)
                bt.SetNamedSubStringValue("Btc", Strbtc)
                bt.SetNamedSubStringValue("mfdtwod", StrInmfd)
                bt.SetNamedSubStringValue("exptwod", StrInexp1)

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
        StrSql = "select distinct LabelName from BTW_Master where Department = 'POUCH' "
        Dim cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)

        cmbPrintLabel.DisplayMember = "LabelName"
        cmbPrintLabel.DataSource = ds.Tables(0)


    End Sub

    Private Sub FrmNewPouchReprint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TypeBind()
        LabelNameBind()
        ' LensMasterBind()
    End Sub

    'Private Sub LensMasterBind()
    '    Dim ds As New DataSet()
    '    If productline = "PMMA" Then
    '        StrSql = "select distinct Model_Name from Lens_Master1 order by Model_Name"
    '    Else
    '        StrSql = "select distinct Model_Name from Lens_Master order by Model_Name"
    '    End If
    '    Dim cmd As New SqlCommand(StrSql, con)
    '    Dim ad As New SqlDataAdapter(cmd)
    '    ad.Fill(ds)

    '    cmbModelNo.DisplayMember = "Model_Name"
    '    cmbModelNo.DataSource = ds.Tables(0)


    'End Sub

    Private Sub TypeBind()
        'Dim ds As New DataSet()
        'strsql = "select distinct Type from Lot_Type "
        'Dim cmd As New SqlCommand(strsql, con)
        'Dim ad As New SqlDataAdapter(cmd)
        'ad.Fill(ds)

        'CmbType.DisplayMember = "Type"
        'CmbType.DataSource = ds.Tables(0)


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

            Dim StrFName As String


            'StrFName = "PMMA_Case&Pouch_LABEL.btw"       

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


                        If IIf(IsDBNull(pouchds.Tables(0).Rows(i)(70)), "", pouchds.Tables(0).Rows(i)(70)).ToString() <> cmbPrintLabel.Text Then
                            MessageBox.Show("Label Name Mismatch. Please check.")
                            Exit For
                        End If

                        StrRef = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(1)), "", pouchds.Tables(0).Rows(i)(1))
                        StrgsCode = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(3)), "", pouchds.Tables(0).Rows(i)(3))
                        StrOptic = Format(IIf(IsDBNull(pouchds.Tables(0).Rows(i)(5)), "", pouchds.Tables(0).Rows(i)(5)), "0.00")
                        StrLen = Format(IIf(IsDBNull(pouchds.Tables(0).Rows(i)(6)), "", pouchds.Tables(0).Rows(i)(6)), "0.00")
                        StrPwr = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(4)), "", pouchds.Tables(0).Rows(i)(4))
                        StrPwr1 = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(4)), "", pouchds.Tables(0).Rows(i)(4))

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
                        Strbtc = IIf(IsDBNull(pouchds.Tables(0).Rows(i)(51)), "", pouchds.Tables(0).Rows(i)(51))

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

                        Dim StrEanCode As String
                        StrEanCode = StrgsCode.ToString().Remove(StrgsCode.ToString().Length - 1, 1)

                        Dim strbtcexpiry As String = StrEpYr.Substring(2, 2)
                        StrInexp1 = strbtcexpiry & StrEpMon & "00"
                        Dim strbtcmfd As String = strmfdyear.Substring(2, 2)
                        StrInmfd = strbtcmfd & strmfdmon & "00"
                        'StrlotBarNo = StrlotBarNo.Replace(" ", "")


                        GetTowd()

                        btFile = Application.StartupPath & "\" & StrFName & ""
                        bt = bApp.Formats.Open(btFile, , DefaultPrinterName)


                        bt.SetNamedSubStringValue("Ref", StrMdl)
                        bt.SetNamedSubStringValue("Pwr", StrPwr) 'strpwradd
                        bt.SetNamedSubStringValue("Brandname", strrefname1)
                        'bt.SetNamedSubStringValue("SNo", StrlotBarNo)
                        bt.SetNamedSubStringValue("LotNo", StroneDBar)
                        bt.SetNamedSubStringValue("optic", StrOptic)
                        bt.SetNamedSubStringValue("Length", StrLen)
                        bt.SetNamedSubStringValue("Expdate", StrExp)
                        bt.SetNamedSubStringValue("mfddate", strmfd)
                        bt.SetNamedSubStringValue("Twodbar", Towd)

                        bt.SetNamedSubStringValue("EanCode", StrEanCode)
                        bt.SetNamedSubStringValue("Btc", Strbtc)
                        bt.SetNamedSubStringValue("mfdtwod", StrInmfd)
                        bt.SetNamedSubStringValue("exptwod", StrInexp1)

                        bt.PrintOut()

                        bt.Close()
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)




                    Next

                    ' StrRs.Close()
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


    Private Sub rdLotSerial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdLotSerial.CheckedChanged
        rdUDICode.Checked = False
    End Sub

    Private Sub rdUDICode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdUDICode.CheckedChanged
        rdLotSerial.Checked = False
    End Sub
End Class