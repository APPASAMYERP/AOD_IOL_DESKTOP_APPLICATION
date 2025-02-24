

Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft
Imports System.Data.Sql
Public Class FrmPouchLabelPrint_Superphob

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



    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
        Menulblmstdatacre.LblHomeMenuDisplyName.Visible = False
        Menulblmstdatacre.TimHomeSideDisply.Start()
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        cmbreflot.Text = ""
        cmbpower.Text = ""
        TextBox2.Text = ""

    End Sub


    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click

        Try

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

            If cmbPrintLabel.SelectedItem Is Nothing Then
                err.SetError(cmbPrintLabel, "Please Select valid Label")
                cmbPrintLabel.Focus()
                Exit Sub
            Else
                err.SetError(cmbPrintLabel, "")
            End If

            If Val(TextBox2.Text) < 1 Then
                err.SetError(TextBox2, "Enter Minimum 1 Qty")
                TextBox2.Focus()
                Exit Sub
            Else
                err.SetError(TextBox2, "")
            End If

            StrSql = "select * from  POUCH_LABEL where RefLot = '" & cmbreflot.Text & "' and  Power = '" & cmbpower.Text & "' and Status ='Not Labelled' order by Lot_SrNo"
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

            'UPDATE POUCHSTATION
            If productline = "SUPERPHOB" Then
                StrSql = "Update  POUCH_LABEL set PouchStation ='" & station & "', Created_by='" & StrLoginUser & "' where RefLot = '" & cmbreflot.Text & "' and  Power = '" & cmbpower.Text & "'  and pouchstation is null and Status ='Not Labelled'"
                Cmd = New SqlCommand(StrSql, con)
                Cmd.ExecuteNonQuery()
                Cmd.Dispose()
            End If





            StrSql = "select * from  POUCH_LABEL where RefLot = '" & cmbreflot.Text & "' and  Power = '" & cmbpower.Text & "'  AND  Status ='Not Labelled' order by Lot_SrNo "

            Cmd = New SqlCommand(StrSql, con)
            Dim pouchds As New DataSet
            Dim ad As New SqlDataAdapter(Cmd)
            ad.Fill(pouchds)

            For j = 0 To pouchds.Tables(0).Rows.Count - 1


                'For i As Integer = 1 To TextBox1.Text

                Dim StrFName As String
                StrRef = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(1)), "", pouchds.Tables(0).Rows(j)(1))
                StrgsCode = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(3)), "", pouchds.Tables(0).Rows(j)(3))
                If productline <> "SUPERPHOB" Then
                    StrUDICode = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(89)), "", pouchds.Tables(0).Rows(j)(89))
                    Strbtc = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(58)), "", pouchds.Tables(0).Rows(j)(58))
                    Stracpwr = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(65)), "", pouchds.Tables(0).Rows(j)(65))
                End If

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


                If productline <> "SUPERPHOB" Then
                    Dim StrType As String = ""
                    StrType = IIf(IsDBNull(pouchds.Tables(0).Rows(j)(40)), "", pouchds.Tables(0).Rows(j)(40))
                    If StrType <> "Thailand" Then
                        MessageBox.Show("Label print for only Thaildan order")
                        Exit Sub
                    End If
                End If


                StrExp = StrEpYr & "-" & StrEpMon
                strmfd = strmfdyear & "-" & strmfdmon

                StrFName = BTWFileName(pouchds.Tables(0).Rows(j)("Model_Name"), cmbPrintLabel.Text)
                If StrFName = "" Then
                    MessageBox.Show("BTW file record not found")
                    Exit Sub
                End If



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
                    strpwradd = StrPwr & " " & "D" & "    " & "ADD 3.50"
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

            StrSql = "Update  POUCH_LABEL set PouchBTWLabelName ='" & cmbPrintLabel.Text & "', Status='Labelled' where RefLot = '" & cmbreflot.Text & "' and  Power = '" & cmbpower.Text & "' and Status ='Not Labelled'"
            Cmd = New SqlCommand(StrSql, con)
            Cmd.ExecuteNonQuery()
            Cmd.Dispose()

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
        StrSql = "SELECT DISTINCT RefLot from POUCH_LABEL WHERE Status ='Not Labelled' order by RefLot"
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




    Private Sub cmbreflot_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbreflot.SelectedIndexChanged

        StrSql = "SELECT DISTINCT Power from POUCH_LABEL where RefLot='" & cmbreflot.Text & "' AND Status ='Not Labelled'  order by Power"
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
        Strsql = "select sum (Qty_1) as Balance_Qty  from POUCH_LABEL where  RefLot='" & cmbreflot.Text & "' and  Power='" & cmbpower.Text & "' and Status ='Not Labelled' "
        Cmd = New SqlCommand(Strsql, con)
        StrRs = Cmd.ExecuteReader
        If StrRs.Read Then
            TextBox2.Text = IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0))
        Else
            TextBox2.Text = ""

        End If
        StrRs.Close()
        Cmd.Dispose()

        'Strsql = "SELECT DISTINCT Lot_SrNo from POUCH_LABEL where RefLot='" & cmbreflot.Text & "' and Power='" & cmbpower.Text & "' order by Lot_SrNo"
        'Cmd = New SqlCommand(Strsql, con)
        'StrRs = Cmd.ExecuteReader
        'ComboBox1.Items.Clear()
        'While StrRs.Read
        '    ComboBox1.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        'End While
        'StrRs.Close()
        'Cmd.Dispose()


    End Sub

End Class