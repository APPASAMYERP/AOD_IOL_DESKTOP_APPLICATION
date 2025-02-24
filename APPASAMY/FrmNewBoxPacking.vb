
Imports System.Data
Imports System.IO
Imports System.Data.SqlClient

Public Class FrmNewBoxPacking
    Dim bApp As New BarTender.Application
    Dim bt As New BarTender.Format
    Dim btFile As String
    Dim table As New DataTable
    Dim table1 As New DataTable

    Dim bApp1 As New BarTender.Application
    Dim bt1 As New BarTender.Format
    Dim btFile1 As String

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
    Dim Strsize As String
    Dim StrInexp1 As String
    Dim StrInyear As String
    Dim strsql, StrSelInj As String
    Dim strrs As SqlDataReader
    Dim strInjRs As SqlDataReader
    Dim cmd As SqlCommand
    Dim strfilename As String
    Dim strtype As String
    Dim strbtcexpiry, strinjbtc As String
    Dim strcyl As String
    Dim strApwr As String
    Dim StrLotNo, strinjyear, lotno, lotcout, strinjmonth, strinjexp, strinjmanf, StrLotBarNo, StrLotPower, StrOptic, strinj_ref, strinj_batch, StrLength, StrEanCode, StrUnit, StrMfDMonth, StrMfDYear, StrModel, StrExpmonth, StrExpYear, StrUni, StrMfD, StrExp As String
    Dim StrTwoDBar, Strbtc_No, Strprice, Strprize, strbtcmfd, Strinmfd As String

    Private Sub FrmNewBoxPacking_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        killProcess("bartend")
    End Sub

    Private Sub killProcess(ByRef StrProcessKill As String)
        Dim Proc() As Process = Process.GetProcesses
        For i As Integer = 0 To Proc.GetUpperBound(0)
            'MsgBox(Proc(i).ProcessName)
            If Proc(i).ProcessName = StrProcessKill Then
                'MsgBox(Proc(i).ProcessName)
                Try
                    Proc(i).Kill()
                Catch ex As Exception
                End Try
            End If
        Next
    End Sub
    Private Sub FrmNewBoxPacking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox4.Visible = False
        GroupBox5.Visible = False
        GroupBox2.Visible = False
        gbxinject.Visible = False



        'table.Columns.Add("Inj_ref", GetType(String))
        'table.Columns.Add("Inj_batch", GetType(String))

        'GRID2.DataSource = table


        'With GRID2.ColumnHeadersDefaultCellStyle
        '    .Alignment = DataGridViewContentAlignment.TopRight
        '    .BackColor = Color.DarkRed
        '    .ForeColor = Color.Gold
        '    .Font = New Font(.Font.FontFamily, .Font.Size, _
        '     .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        'End With




        'table1.Columns.Add("Lot_Sr_No", GetType(String))


        'Grid3.DataSource = table1


        'With Grid3.ColumnHeadersDefaultCellStyle
        '    .Alignment = DataGridViewContentAlignment.TopRight
        '    .BackColor = Color.DarkRed
        '    .ForeColor = Color.Gold
        '    .Font = New Font(.Font.FontFamily, .Font.Size, _
        '     .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        'End With

    End Sub
    'Private Sub txtlotbarno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlotbarno.KeyDown
    '    Me.txtinj_No.Focus()
    'End Sub
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
    
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        killProcess("bartend")
        Me.Close()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Rdbttypespb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rdbttypesfb.CheckedChanged
        If Rdbttypesfb.Checked = True Then
            GroupBox5.Visible = True
            GroupBox4.Visible = False
            GroupBox2.Visible = True
        End If
    End Sub

    Private Sub rdbttypeothers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbttypeothers.CheckedChanged
        If rdbttypeothers.Checked = True Then
            GroupBox4.Visible = True
            GroupBox5.Visible = False
            GroupBox2.Visible = True
            'GroupBox7.Visible = True
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        Dim strbar As String
        strbar = txtsrno.Text & txtmfddate.Text & txtexpdate.Text
        btFile = Application.StartupPath & "\SWISSFOLD4.btw"
        bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
        bt.SetNamedSubStringValue("code11", strbar)
        bt.SetNamedSubStringValue("Expdt", txtexpdate.Text)
        bt.SetNamedSubStringValue("Mfddt", txtmfddate.Text)
        bt.SetNamedSubStringValue("LotSr", txtsrno.Text)
        bt.PrintOut()
        bt.Close()
        System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
    End Sub

    Private Sub rbttype4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbttype4.CheckedChanged
        If rbttype4.Checked = True Then
            gbxinject.Visible = True
        End If
    End Sub

    Private Sub txtinj_No_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtinj_No.KeyDown

        If txtinj_No.Text <> "" Then




            '    StrSelInj = "SELECT Inj_ref,Str_batch from Injector_Label where Str_batch = '" & txtinj_No.Text & "' "

            '    cmd = New SqlCommand(StrSelInj, con)

            '    strInjRs = cmd.ExecuteReader

            '    If strInjRs.Read Then

            '        strinj_ref = IIf(IsDBNull(strInjRs.GetValue(0)), "", strInjRs.GetValue(0))
            '        strinj_batch = IIf(IsDBNull(strInjRs.GetValue(1)), "", strInjRs.GetValue(1))
            '    Else
            '        MsgBox(" Scan Correct Lot No")
            '        txtinj_No.Text = ""
            '        txtinj_No.Focus()
            '        strInjRs.Close()
            '        cmd.Dispose()
            '        Exit Sub

            '    End If

            '    strInjRs.Close()
            '    cmd.Dispose()

            'End If

        If e.KeyCode = Keys.Enter Then

            txtlotbarno.Focus()
        Else

        End If

        End If

    End Sub

   
    Private Sub txtlotbarno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlotbarno.KeyDown

        If e.KeyCode = Keys.Enter Then

            If txtlotbarno.Text <> "" Then

                Dim StrSeSql As String
                Dim StrSeRs As SqlDataReader
                Dim Cmd As New SqlCommand
                Dim SqlIn As String

                Dim StrLotPrefix, Strinjbtc_No, Strinjref, strinjmy, strinjmm As String
                Dim StrLotSu As String
                Dim StrOnlyLot As String


                'If txtlotbarno.Text <> "" And txtinj_No.Text <> "" Then
                If txtlotbarno.Text <> "" Then


                    'strsql = "select Lot_Count from  Lot where Lens_Material = 'PHILIC' and Active = 'YES' "
                    'Cmd = New SqlCommand(strsql, con)
                    'If con.State = Data.ConnectionState.Open Then
                    '    con.Close()
                    'End If
                    'con.Open()
                    'strrs = Cmd.ExecuteReader
                    'If strrs.Read Then
                    '    lotcout = IIf(IsDBNull(strrs.GetValue(0)), "", strrs.GetValue(0))
                    'Else
                    '    MsgBox("No Data Found", MsgBoxStyle.Critical)
                    '    Exit Sub
                    'End If
                    'strrs.Close()
                    'Cmd.Dispose()


                    lotno = txtlotbarno.Text.Substring(lotcout, txtlotbarno.Text.Length - lotcout)
                    txtlotbarno.Text = lotno



                    'StrSelInj = "SELECT Inj_ref,Str_batch,Exp_year,Exp_Month,Mfd_Year,Mfd_Month from Injector_Label where Str_batch = '" & txtinj_No.Text & "' "
                    'Cmd = New SqlCommand(StrSelInj, con)
                    'strInjRs = Cmd.ExecuteReader
                    'If strInjRs.Read Then

                    '    strinj_ref = IIf(IsDBNull(strInjRs.GetValue(0)), "", strInjRs.GetValue(0))
                    '    strinj_batch = IIf(IsDBNull(strInjRs.GetValue(1)), "", strInjRs.GetValue(1))
                    '    strinjyear = IIf(IsDBNull(strInjRs.GetValue(2)), "", strInjRs.GetValue(2))
                    '    strinjmonth = IIf(IsDBNull(strInjRs.GetValue(3)), "", strInjRs.GetValue(3))
                    '    strinjmy = IIf(IsDBNull(strInjRs.GetValue(4)), "", strInjRs.GetValue(4))
                    '    strinjmm = IIf(IsDBNull(strInjRs.GetValue(5)), "", strInjRs.GetValue(5))

                    'Else
                    '    MsgBox(" Scan Correct Lot No")
                    '    txtinj_No.Text = ""
                    '    txtinj_No.Focus()
                    '    strInjRs.Close()
                    '    Cmd.Dispose()
                    '    Exit Sub

                    'End If

                    'strInjRs.Close()
                    'Cmd.Dispose()

                    'strinjmanf = strinjmy & "-" & strinjmm
                    'strinjexp = strinjyear & "-" & strinjmonth

                    StrSeSql = "SELECT Brand_Name,Model_Name,Reference_Name,GS_Code,Power,Optic,Length,A_Constant,Type_GS_Code,Lot_Prefix,Lot_No,Lot_SrNo,Mfd_Month,Mfd_Year,Exp_Month,Exp_Year,Type,Btc_No,price,R_Power,Injector_Ref,Injector_batch from POUCH_LABEL where Lot_SrNo='" & txtlotbarno.Text & "' " & _
                   "and Sterilization=1  and Sample_Taken=0 and BPL_Taken=1 and Dc_Packing=0  "

                    ''StrSeSql = "select * from POUCH_LABEL where Lot_SrNo='" & txtlotbarno.Text & "' " & _
                    '' "and Sterilization=1  and Sample_Taken=0 and BPL_Taken=1  and Dc_Packing=0 and Box_Reject=0 "

                    Cmd = New SqlCommand(StrSeSql, con)
                    StrSeRs = Cmd.ExecuteReader

                    If StrSeRs.Read Then

                        If rdobrand.Checked = True Then

                            StrRefName = IIf(IsDBNull(StrSeRs.GetValue(0)), "", StrSeRs.GetValue(0))
                        Else
                            StrRefName = IIf(IsDBNull(StrSeRs.GetValue(2)), "", StrSeRs.GetValue(2))
                        End If

                        StrModel = IIf(IsDBNull(StrSeRs.GetValue(1)), "", StrSeRs.GetValue(1))
                        StrEanCode = IIf(IsDBNull(StrSeRs.GetValue(3)), "", StrSeRs.GetValue(3))
                        StrLotPower = IIf(IsDBNull(StrSeRs.GetValue(4)), 0, StrSeRs.GetValue(4))
                        StrOptic = Format(IIf(IsDBNull(StrSeRs.GetValue(5)), 0, StrSeRs.GetValue(5)), "0.00")
                        StrLength = Format(IIf(IsDBNull(StrSeRs.GetValue(6)), 0, StrSeRs.GetValue(6)), "0.00")
                        StrAConst = Format(IIf(IsDBNull(StrSeRs.GetValue(7)), 0, StrSeRs.GetValue(7)), "0.00")
                        GS_Type = IIf(IsDBNull(StrSeRs.GetValue(8)), 0, StrSeRs.GetValue(8))
                        StrLotPrefix = IIf(IsDBNull(StrSeRs.GetValue(9)), 0, StrSeRs.GetValue(9))
                        StrLotSu = IIf(IsDBNull(StrSeRs.GetValue(10)), 0, StrSeRs.GetValue(10))
                        StrLotBarNo = IIf(IsDBNull(StrSeRs.GetValue(11)), "", StrSeRs.GetValue(11))
                        ' StrUnit = IIf(IsDBNull(StrSeRs.GetValue(8)), "", StrSeRs.GetValue(8))
                        StrMfDMonth = Format(IIf(IsDBNull(StrSeRs.GetValue(12)), "", StrSeRs.GetValue(12)), "00")
                        StrMfDYear = IIf(IsDBNull(StrSeRs.GetValue(13)), "", StrSeRs.GetValue(13))
                        StrExpmonth = Format(IIf(IsDBNull(StrSeRs.GetValue(14)), "", StrSeRs.GetValue(14)), "00")
                        StrExpYear = IIf(IsDBNull(StrSeRs.GetValue(15)), "", StrSeRs.GetValue(15))
                        ' IntBoxPAck = IIf(IsDBNull(StrSeRs.GetValue(26)), 0, StrSeRs.GetValue(26))
                        strtype = IIf(IsDBNull(StrSeRs.GetValue(16)), 0, StrSeRs.GetValue(16))
                        Strbtc_No = IIf(IsDBNull(StrSeRs.GetValue(17)), 0, StrSeRs.GetValue(17))
                        Strinjref = IIf(IsDBNull(StrSeRs.GetValue(20)), 0, StrSeRs.GetValue(20))
                        Strinjbtc_No = IIf(IsDBNull(StrSeRs.GetValue(21)), 0, StrSeRs.GetValue(21))
                        Strprize = IIf(IsDBNull(StrSeRs.GetValue(18)), 0, StrSeRs.GetValue(18))
                        strApwr = IIf(IsDBNull(StrSeRs.GetValue(19)), 0, StrSeRs.GetValue(19))

                    Else

                        MsgBox(" Scan Correct Lot No")
                        txtlotbarno.Text = ""
                        txtlotbarno.Focus()
                        StrSeRs.Close()
                        Cmd.Dispose()

                        Exit Sub

                    End If
                    StrSeRs.Close()
                    Cmd.Dispose()

                    Strsize = StrOptic & "X" & StrLength & "mm"
                    StrMfD = StrMfDYear & "-" & StrMfDMonth
                    StrExp = StrExpYear & "-" & StrExpmonth

                    strbtcexpiry = StrExpmonth & "-" & StrExpYear

                    StrInyear = StrExpYear + 3
                    StrInexp1 = StrInyear & "-" & StrExpmonth
                    StrOnlyLot = StrLotPrefix & StrLotSu
                    Strprice = "M.R.P. ` :" & " " & Strprize & "/-"
                    StrTwoDBar = StrLotBarNo & "," & StrLotPower & " D" & "," & StrModel & "," & StrRefName & "," & StrOptic & " mm" & "," & StrLength & " mm" & "," & strbtcexpiry & "," & Strbtc_No


                    strbtcexpiry = StrExpYear.Substring(2, 2)
                    StrInexp1 = strbtcexpiry & StrExpmonth & "00"


                    strbtcmfd = StrMfDYear.Substring(2, 2)
                    Strinmfd = strbtcmfd & StrMfDMonth & "00"

                    StrInexp1 = strbtcexpiry & StrExpmonth & "00"
                    Strinmfd = strbtcmfd & StrMfDMonth & "00"
                    'StrEanCode = "0" & StrEanCode
                    StrEanCode = StrEanCode



                    If rdbttypeothers.Checked = True Then

                        ''//PANDIAN//''

                        'strsql = "select File_Name from Printer_Master where printer_Name='" & DefaultPrinterName() & "' and model_name='" & StrModel & "'"
                        'Cmd = New SqlCommand(strsql, con)
                        'strrs = Cmd.ExecuteReader
                        'If strrs.Read Then
                        '    strfilename = IIf(IsDBNull(strrs.GetValue(0)), "", strrs.GetValue(0))

                        'Else
                        '    MsgBox(" Please verify printer,file details for present model ")
                        '    strrs.Close()
                        '    Cmd.Dispose()
                        '    Exit Sub
                        'End If

                        'strrs.Close()
                        'Cmd.Dispose()

                        If StrModel = "nAs207" Or StrModel = "nAsY207" Then

                            'Dim writePRN As New StreamWriter(Application.StartupPath & "\write.prn")

                            Dim StrFName As String

                            If StrModel = "nAs207" Then
                                StrFName = "NaSPRONEW.btw"
                            ElseIf StrModel = "nAsY207" Then
                                StrFName = "NaSPRONEW-BBY.btw"
                            End If


                            btFile = Application.StartupPath & "\" & StrFName & ""
                            bt = bApp.Formats.Open(btFile, , DefaultPrinterName)

                            bt.SetNamedSubStringValue("Model", StrModel)
                            bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                            bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                            bt.SetNamedSubStringValue("Len", StrLength & " mm")
                            bt.SetNamedSubStringValue("Expdt", StrExp)
                            bt.SetNamedSubStringValue("mfdate", StrMfD)
                            bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                            bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                            bt.SetNamedSubStringValue("Lot", Strbtc_No)
                            bt.SetNamedSubStringValue("Aconst", StrAConst)
                            bt.SetNamedSubStringValue("EanCode", StrEanCode)
                            bt.SetNamedSubStringValue("Btc", Strbtc_No)
                            bt.SetNamedSubStringValue("mfdtwod", Strinmfd)
                            bt.SetNamedSubStringValue("exptwod", StrInexp1)
                            bt.SetNamedSubStringValue("Lotno", StrLotBarNo)


                            'bt.SetNamedSubStringValue("Inj_ref", strinj_ref)
                            'bt.SetNamedSubStringValue("Inj_lot", strinj_batch)
                            'bt.SetNamedSubStringValue("injexp", strinjexp)
                            'bt.SetNamedSubStringValue("price", Strprice)
                            'bt.SetNamedSubStringValue("RefName", StrRefName)StrLotBarNo
                            'bt.SetNamedSubStringValue("injexp", StrInexp1)

                            bt.PrintOut()
                            '  End If
                            bt.Close()
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                            'ElseIf StrModel = "SFAC6" Or StrModel = "SFAC7" Or StrModel = "SFE5" Then
                        ElseIf StrRefName = "SWISSFOLD" Then


                            btFile = Application.StartupPath & "\SWUHHDD.btw"
                            bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                            bt.SetNamedSubStringValue("Model", StrModel)
                            bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                            bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                            bt.SetNamedSubStringValue("Len", StrLength & " mm")
                            bt.SetNamedSubStringValue("mfddt", StrMfD)
                            bt.SetNamedSubStringValue("Expdt", StrExp)
                            bt.SetNamedSubStringValue("Pwr", StrLotPower & "D")
                            bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                            bt.SetNamedSubStringValue("btc_no", Strbtc_No)
                            bt.SetNamedSubStringValue("Aconst", StrAConst)
                            'bt.SetNamedSubStringValue("EanCode", StrEanCode)
                            'bt.SetNamedSubStringValue("Mfddt", StrMfD)
                            bt.SetNamedSubStringValue("lensz", Strsize)
                            bt.SetNamedSubStringValue("EanCode", StrEanCode)
                            bt.SetNamedSubStringValue("Btc", Strbtc_No)
                            bt.SetNamedSubStringValue("mfdtwod", Strinmfd)
                            bt.SetNamedSubStringValue("exptwod", StrInexp1)
                            bt.SetNamedSubStringValue("Lotno", StrLotBarNo)
                            'bt.SetNamedSubStringValue("Inj_ref", strinj_ref)
                            'bt.SetNamedSubStringValue("Inj_lot", strinj_batch)
                            'bt.SetNamedSubStringValue("price", Strprice)
                            bt.PrintOut()
                            '  End If
                            bt.Close()
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                        ElseIf ((StrModel = "502" Or StrModel = "601" Or StrModel = "701" Or StrModel = "701H") And strtype <> "Export-Turkey") Then

                            If RdoFSL.Checked = True Then
                                'btFile = Application.StartupPath & "\ACRYFOLD_BT_MAX.btw "
                                'bt = bApp.Formats.Open(btFile, , DefaultPrinterName)

                            ElseIf Rdocolumbian.Checked = True Then

                                'btFile = Application.StartupPath & "\ACRYFOLD_BT_MAX _7 _Columbian.btw"
                                btFile = Application.StartupPath & "\ACRYFOLD_BT_MAX.btw"
                                bt = bApp.Formats.Open(btFile, , DefaultPrinterName)

                            ElseIf RdoSSL.Checked = True Then
                                'btFile = Application.StartupPath & "\ACRYFOLD_BT_MAX _7.btw "
                                'bt = bApp.Formats.Open(btFile, , DefaultPrinterName)

                            Else

                                'btFile = Application.StartupPath & "\ACRYFOLD_OTR.btw"
                                'bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                            End If

                            If RdoOt.Checked = True Then

                                'bt.SetNamedSubStringValue("Model", StrModel)
                                'bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                                'bt.SetNamedSubStringValue("Len", StrLength & " mm")
                                'bt.SetNamedSubStringValue("mfdate", StrMfD)
                                'bt.SetNamedSubStringValue("Expdt", StrExp)
                                'bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                                'bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                                'bt.SetNamedSubStringValue("Lot", Strbtc_No)
                                'bt.SetNamedSubStringValue("Aconst", StrAConst)
                                'bt.SetNamedSubStringValue("RefName", StrRefName)
                                ''bt.SetNamedSubStringValue("price", Strprice)
                                'bt.PrintOut()
                                'bt.Close()
                                'System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                                'btFile = Application.StartupPath & "\ACRYFOLD_OTR1.btw"
                                'bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                                'bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                                'bt.SetNamedSubStringValue("EanCode", StrEanCode)
                                ''bt.SetNamedSubStringValue("Inj_ref", strinj_ref)
                                ''bt.SetNamedSubStringValue("Inj_lot", strinj_batch)
                                'bt.PrintOut()

                            Else
                                bt.SetNamedSubStringValue("Model", StrModel)
                                bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                                bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                                bt.SetNamedSubStringValue("Len", StrLength & " mm")
                                bt.SetNamedSubStringValue("Expdt", StrExp)
                                bt.SetNamedSubStringValue("mfdate", StrMfD)
                                bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                                bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                                bt.SetNamedSubStringValue("Lot", Strbtc_No)
                                bt.SetNamedSubStringValue("Aconst", StrAConst)
                                bt.SetNamedSubStringValue("EanCode", StrEanCode)
                                bt.SetNamedSubStringValue("Btc", Strbtc_No)
                                bt.SetNamedSubStringValue("mfdtwod", Strinmfd)
                                bt.SetNamedSubStringValue("exptwod", StrInexp1)
                                bt.SetNamedSubStringValue("Lotno", StrLotBarNo)
                                bt.SetNamedSubStringValue("RefName", StrRefName)
                                bt.SetNamedSubStringValue("Inj_ref", strinj_ref)
                                'bt.SetNamedSubStringValue("Inj_lot", strinj_batch)
                                'bt.SetNamedSubStringValue("price", Strprice)
                                bt.PrintOut()
                            End If
                            bt.Close()
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)


                        ElseIf StrModel = "SUPRAPHOB BBY" Then

                            btFile = Application.StartupPath & "\SUPRA_PHOB_BBY.btw"
                            bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                            bt.SetNamedSubStringValue("Model", StrModel)
                            bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                            bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                            bt.SetNamedSubStringValue("Len", StrLength & " mm")
                            bt.SetNamedSubStringValue("mfdate", StrMfD)
                            bt.SetNamedSubStringValue("Expdt", StrExp)
                            bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                            bt.SetNamedSubStringValue("Apwr", strApwr & "D")
                            bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                            bt.SetNamedSubStringValue("btcno", Strbtc_No)
                            bt.SetNamedSubStringValue("Aconst", StrAConst)
                            bt.SetNamedSubStringValue("EanCode", StrEanCode)
                            bt.SetNamedSubStringValue("Btc", Strbtc_No)
                            bt.SetNamedSubStringValue("mfdtwod", Strinmfd)
                            bt.SetNamedSubStringValue("exptwod", StrInexp1)
                            bt.SetNamedSubStringValue("Lotno", StrLotBarNo)
                            'bt.SetNamedSubStringValue("price", Strprice)
                            bt.PrintOut()
                            bt.Close()
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                        ElseIf StrModel = "SUPRAPHOB MS" Or StrModel = "SP INFO" Then

                            btFile = Application.StartupPath & "\SUPRA_PHOB_INFO.btw"

                            bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                            bt.SetNamedSubStringValue("Model", StrModel)
                            'bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                            bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                            'bt.SetNamedSubStringValue("Len", StrLength & " mm")
                            bt.SetNamedSubStringValue("Expdt", StrExp)
                            bt.SetNamedSubStringValue("cyl", strcyl)
                            bt.SetNamedSubStringValue("Pwr", StrLotPower & "D")
                            bt.SetNamedSubStringValue("Apwr", strApwr & " D")
                            bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                            bt.SetNamedSubStringValue("Lot", Strbtc_No)
                            'bt.SetNamedSubStringValue("btc_no", Strbtc_No)
                            'bt.SetNamedSubStringValue("Aconst", StrAConst)
                            bt.SetNamedSubStringValue("EanCode", StrEanCode)
                            bt.SetNamedSubStringValue("Btc", Strbtc_No)
                            bt.SetNamedSubStringValue("mfdtwod", Strinmfd)
                            bt.SetNamedSubStringValue("exptwod", StrInexp1)
                            bt.SetNamedSubStringValue("Lotno", StrLotBarNo)
                            bt.SetNamedSubStringValue("mfdate", StrMfD)
                            ' bt.SetNamedSubStringValue("lensz", Strsize)
                            bt.SetNamedSubStringValue("Inj_ref", strinj_ref)
                            bt.SetNamedSubStringValue("Inj_lot", strinj_batch)

                            bt.PrintOut()
                            '  End If
                            bt.Close()
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                        ElseIf StrModel = "SPNT200" Or StrModel = "SPNT300" Or StrModel = "HPNT200" Or StrModel = "SPNTY200" Or StrModel = "SPNT300-PL" Or StrModel = "HPNT300" Then

                            'btFile = Application.StartupPath & "\SUPRA_PHOB.btw"
                            'bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                            'bt.SetNamedSubStringValue("Model", StrModel)
                            ''bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                            'bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                            ''bt.SetNamedSubStringValue("Len", StrLength & " mm")
                            'bt.SetNamedSubStringValue("Expdt", StrExp)
                            'bt.SetNamedSubStringValue("mfdate", StrMfD)
                            'bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                            'bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                            'bt.SetNamedSubStringValue("Lot", Strbtc_No)
                            ''bt.SetNamedSubStringValue("Aconst", StrAConst)
                            'bt.SetNamedSubStringValue("EanCode", StrEanCode)
                            ''bt.SetNamedSubStringValue("Btc", Strbtc_No)
                            'bt.SetNamedSubStringValue("mfdtwod", Strinmfd)
                            'bt.SetNamedSubStringValue("exptwod", StrInexp1)
                            'bt.SetNamedSubStringValue("Lotno", StrLotBarNo)
                            ''bt.SetNamedSubStringValue("Inj_ref", strinj_ref)
                            ''bt.SetNamedSubStringValue("Inj_lot", strinj_batch)
                            ''bt.SetNamedSubStringValue("price", Strprice)
                            'bt.PrintOut()
                            'bt.Close()
                            'System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                            btFile = Application.StartupPath & "\SUPRA_PHOB.btw"
                            bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                            bt.SetNamedSubStringValue("Model", StrModel)
                            'bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                            bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                            'bt.SetNamedSubStringValue("Len", StrLength & " mm")
                            bt.SetNamedSubStringValue("Expdt", StrExp)
                            bt.SetNamedSubStringValue("mfdate", StrMfD)
                            bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                            bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                            bt.SetNamedSubStringValue("Lot", Strbtc_No)
                            'bt.SetNamedSubStringValue("Aconst", StrAConst)
                            bt.SetNamedSubStringValue("EanCode", StrEanCode)
                            'bt.SetNamedSubStringValue("Btc", Strbtc_No)
                            ' bt.SetNamedSubStringValue("mfdtwod", Strinmfd)
                            ' bt.SetNamedSubStringValue("exptwod", StrInexp1)
                            bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                            'bt.SetNamedSubStringValue("Inj_ref", strinj_ref)
                            'bt.SetNamedSubStringValue("Inj_lot", strinj_batch)
                            'bt.SetNamedSubStringValue("price", Strprice)
                            bt.PrintOut()
                            bt.Close()
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                        ElseIf StrModel = "HF01" Or StrModel = "HF02" Or StrModel = "HF03" Then

                            btFile1 = Application.StartupPath & "\HEERAFOLD_main.btw"
                            bt1 = bApp1.Formats.Open(btFile1, , DefaultPrinterName)
                            bt1.SetNamedSubStringValue("TwoD", StrTwoDBar)
                            bt1.SetNamedSubStringValue("Model", StrModel)
                            bt1.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                            bt1.SetNamedSubStringValue("LotSr", StrLotBarNo)
                            bt1.SetNamedSubStringValue("Lot", Strbtc_No)
                            'bt.SetNamedSubStringValue("price", Strprice)
                            bt1.PrintOut()
                            bt1.Close()
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(bt1)


                            btFile = Application.StartupPath & "\HEERAFOLD.BTW"
                            bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                            bt.SetNamedSubStringValue("Model", StrModel)
                            bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                            bt.SetNamedSubStringValue("Len", StrLength & " mm")
                            bt.SetNamedSubStringValue("mfdate", StrMfD)
                            bt.SetNamedSubStringValue("Expdt", StrExp)
                            bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                            bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                            bt.SetNamedSubStringValue("Lot", Strbtc_No)
                            bt.SetNamedSubStringValue("Aconst", StrAConst)
                            'bt.SetNamedSubStringValue("price", Strprice)
                            bt.PrintOut()
                            bt.Close()
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)


                        ElseIf ((StrModel = "502" Or StrModel = "601" Or StrModel = "701") And strtype = "Export-Turkey") Then

                            btFile = Application.StartupPath & "\acryfoldotr.btw"

                            bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                            bt.SetNamedSubStringValue("Model", StrModel)
                            bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                            bt.SetNamedSubStringValue("Len", StrLength & " mm")
                            bt.SetNamedSubStringValue("Expdt", StrExp)
                            bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                            'bt.SetNamedSubStringValue("price", Strprice)
                            bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                            'bt.SetNamedSubStringValue("Lot", Strbtc_No)
                            bt.SetNamedSubStringValue("Aconst", StrAConst)
                            bt.SetNamedSubStringValue("RefName", StrRefName)
                            bt.PrintOut()
                            bt.Close()
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                            btFile1 = Application.StartupPath & "\HEERAFOLD_2.BTW"
                            bt1 = bApp1.Formats.Open(btFile1, , DefaultPrinterName)
                            bt1.SetNamedSubStringValue("TwoD", StrTwoDBar)
                            bt.SetNamedSubStringValue("EanCode", StrEanCode)
                            bt.SetNamedSubStringValue("Btc", Strbtc_No)
                            bt.SetNamedSubStringValue("mfdtwod", Strinmfd)
                            bt.SetNamedSubStringValue("exptwod", StrInexp1)
                            bt.SetNamedSubStringValue("Lotno", StrLotBarNo)
                            bt1.PrintOut()
                            bt1.Close()
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(bt1)

                        ElseIf StrModel = "CHP6013" Then

                            btFile = Application.StartupPath & "\CATRAPHOB.btw"
                            bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                            bt.SetNamedSubStringValue("Model", StrModel)
                            bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                            bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                            bt.SetNamedSubStringValue("Len", StrLength & " mm")
                            bt.SetNamedSubStringValue("mfdate", StrMfD)
                            bt.SetNamedSubStringValue("Expdt", StrExp)
                            bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                            bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                            bt.SetNamedSubStringValue("Lot", Strbtc_No)
                            'bt.SetNamedSubStringValue("price", Strprice)
                            bt.SetNamedSubStringValue("Aconst", StrAConst)
                            'bt.SetNamedSubStringValue("EanCode", StrEanCode)
                            'bt.SetNamedSubStringValue("RefName", StrRefName)
                            bt.SetNamedSubStringValue("EanCode", StrEanCode)
                            bt.SetNamedSubStringValue("Btc", Strbtc_No)
                            bt.SetNamedSubStringValue("mfdtwod", Strinmfd)
                            bt.SetNamedSubStringValue("exptwod", StrInexp1)
                            bt.SetNamedSubStringValue("Lotno", StrLotBarNo)
                            bt.PrintOut()
                            bt.Close()
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                        ElseIf StrModel = "SCC6012" Then

                            btFile = Application.StartupPath & "\CATRAFLEX.btw"
                            bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                            bt.SetNamedSubStringValue("Model", StrModel)
                            bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                            bt.SetNamedSubStringValue("mfdate", StrMfD)
                            bt.SetNamedSubStringValue("Expdt", StrExp)
                            'bt.SetNamedSubStringValue("price", Strprice)
                            bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                            bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                            bt.PrintOut()
                            bt.Close()
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                        End If
                        SqlIn = "update POUCH_LABEL set Box_Packing =1,Box_By='" & StrLoginUser & "',Injector_Ref ='" & strinj_ref & "',Injector_batch ='" & strinj_batch & "',Box_Date=GETDATE() where Lot_SrNo='" & txtlotbarno.Text & "' "
                        Cmd = New SqlCommand(SqlIn, con)
                        Cmd.ExecuteNonQuery()
                        Cmd.Dispose()


                        StrLotBarNo = ""
                        StrLotPrefix = ""
                        StrLotSu = ""
                        StrLotPower = ""
                        StrOptic = ""
                        StrLength = ""
                        StrUnit = ""
                        StrMfDMonth = ""
                        StrMfDYear = ""
                        StrExpmonth = ""
                        StrExpYear = ""
                        IntBoxPAck = 0
                        GS_Type = ""
                        txtlotbarno.Text = ""

                        txtlotbarno.Text = ""
                        txtinj_No.Text = ""
                        txtinj_No.Focus()
                        Exit Sub

                    Else
                        If rbttype1.Checked = True Then

                            btFile = Application.StartupPath & "\SwissFold.btw"
                            bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                            bt.SetNamedSubStringValue("Model", StrModel)
                            bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                            bt.SetNamedSubStringValue("Expdt", StrExp)
                            bt.SetNamedSubStringValue("mfdate", StrMfD)
                            bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                            bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                            bt.SetNamedSubStringValue("btcno", Strbtc_No)
                            bt.SetNamedSubStringValue("Size1", Strsize)
                            bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                            bt.SetNamedSubStringValue("Len", StrLength & " mm")
                            'bt.SetNamedSubStringValue("Inj_ref", strinj_ref)
                            'bt.SetNamedSubStringValue("Inj_lot", strinj_batch)
                            'bt.SetNamedSubStringValue("price", Strprice)
                            bt.PrintOut()
                            bt.Close()
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                        ElseIf rbttype2.Checked = True Then
                            btFile = Application.StartupPath & "\SWISSFOLD2.btw"
                            bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                            bt.SetNamedSubStringValue("Model", StrModel)
                            bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                            bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                            bt.SetNamedSubStringValue("Len", StrLength & " mm")
                            bt.SetNamedSubStringValue("Expdt", StrExp)
                            bt.SetNamedSubStringValue("mfdate", StrMfD)
                            bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                            bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                            bt.SetNamedSubStringValue("Btcno", Strbtc_No)
                            bt.SetNamedSubStringValue("Aconst", StrAConst)
                            'bt.SetNamedSubStringValue("Inj_ref", strinj_ref)
                            'bt.SetNamedSubStringValue("Inj_lot", strinj_batch)
                            'bt.SetNamedSubStringValue("price", Strprice)
                            bt.PrintOut()
                            bt.Close()
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                        ElseIf rbttype3.Checked = True Then

                            btFile = Application.StartupPath & "\SWISSFOLD3.btw"
                            bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                            bt.SetNamedSubStringValue("mfdate", StrMfD)
                            bt.SetNamedSubStringValue("Expdt", StrExp)
                            bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                            bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                            bt.SetNamedSubStringValue("Size1", Strsize)
                            'bt.SetNamedSubStringValue("Inj_ref", strinj_ref)
                            'bt.SetNamedSubStringValue("Inj_lot", strinj_batch)
                            'bt.SetNamedSubStringValue("price", Strprice)
                            bt.PrintOut()
                            bt.Close()
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                        ElseIf rbttype4.Checked = True Then
                            gbxinject.Visible = True
                        End If

                        SqlIn = "update POUCH_LABEL set Box_Packing =1,Box_By='" & StrLoginUser & "',Injector_Ref ='" & strinj_ref & "',Injector_batch ='" & strinj_batch & "',Box_Date=GETDATE() where Lot_SrNo='" & txtlotbarno.Text & "' "
                        Cmd = New SqlCommand(SqlIn, con)
                        Cmd.ExecuteNonQuery()
                        Cmd.Dispose()

                        StrLotBarNo = ""
                        StrLotPrefix = ""
                        StrLotSu = ""
                        StrLotPower = ""
                        StrOptic = ""
                        StrLength = ""
                        StrUnit = ""
                        StrMfDMonth = ""
                        StrMfDYear = ""
                        StrExpmonth = ""
                        StrExpYear = ""
                        IntBoxPAck = 0
                        GS_Type = ""

                        txtlotbarno.Text = ""
                        txtinj_No.Text = ""
                        txtinj_No.Focus()

                        Exit Sub

                    End If
                End If

                txtinj_No.Text = ""
                txtlotbarno.Text = ""
                txtinj_No.Focus()

                'End If









                '    print_box.Focus()
                'Else


            End If

        End If

    End Sub

   
    Private Sub print_box_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles print_box.Click


        Dim StrSeSql As String
        Dim StrSeRs As SqlDataReader
        Dim Cmd As New SqlCommand
        Dim SqlIn As String

        Dim StrLotPrefix As String
        Dim StrLotSu As String
        Dim StrOnlyLot As String



        If txtlotbarno.Text <> "" And txtinj_No.Text <> "" Then



            StrSelInj = "SELECT Inj_ref,Str_batch,Exp_year,Exp_Month from Injector_Label where Str_batch = '" & txtinj_No.Text & "' "

            Cmd = New SqlCommand(StrSelInj, con)

            strInjRs = Cmd.ExecuteReader

            If strInjRs.Read Then

                strinj_ref = IIf(IsDBNull(strInjRs.GetValue(0)), "", strInjRs.GetValue(0))
                strinj_batch = IIf(IsDBNull(strInjRs.GetValue(1)), "", strInjRs.GetValue(1))
                strinjyear = IIf(IsDBNull(strInjRs.GetValue(2)), "", strInjRs.GetValue(2))
                strinjmonth = IIf(IsDBNull(strInjRs.GetValue(3)), "", strInjRs.GetValue(3))

            Else
                MsgBox(" Scan Correct Lot No")
                txtinj_No.Text = ""
                txtinj_No.Focus()
                strInjRs.Close()
                Cmd.Dispose()
                Exit Sub

            End If

            strInjRs.Close()
            Cmd.Dispose()

            strinjexp = strinjyear & "-" & strinjmonth


            StrSeSql = "SELECT Brand_Name,Model_Name,Reference_Name,GS_Code,Power,Optic,Length,A_Constant,Type_GS_Code,Lot_Prefix,Lot_No,Lot_SrNo,Mfd_Month,Mfd_Year,Exp_Month,Exp_Year,Type,Btc_No,price from POUCH_LABEL where Lot_SrNo='" & txtlotbarno.Text & "' " & _
           "and Sterilization=1  and Sample_Taken=0 and BPL_Taken=1 and Dc_Packing=0  "

            ''StrSeSql = "select * from POUCH_LABEL where Lot_SrNo='" & txtlotbarno.Text & "' " & _
            '' "and Sterilization=1  and Sample_Taken=0 and BPL_Taken=1  and Dc_Packing=0 and Box_Reject=0 "

            Cmd = New SqlCommand(StrSeSql, con)

            StrSeRs = Cmd.ExecuteReader

            If StrSeRs.Read Then

                If rdobrand.Checked = True Then

                    StrRefName = IIf(IsDBNull(StrSeRs.GetValue(0)), "", StrSeRs.GetValue(0))
                Else
                    StrRefName = IIf(IsDBNull(StrSeRs.GetValue(2)), "", StrSeRs.GetValue(2))
                End If

                StrModel = IIf(IsDBNull(StrSeRs.GetValue(1)), "", StrSeRs.GetValue(1))
                StrEanCode = IIf(IsDBNull(StrSeRs.GetValue(3)), "", StrSeRs.GetValue(3))
                StrLotPower = IIf(IsDBNull(StrSeRs.GetValue(4)), 0, StrSeRs.GetValue(4))

                StrOptic = Format(IIf(IsDBNull(StrSeRs.GetValue(5)), 0, StrSeRs.GetValue(5)), "0.00")
                StrLength = Format(IIf(IsDBNull(StrSeRs.GetValue(6)), 0, StrSeRs.GetValue(6)), "0.00")
                StrAConst = Format(IIf(IsDBNull(StrSeRs.GetValue(7)), 0, StrSeRs.GetValue(7)), "0.00")
                GS_Type = IIf(IsDBNull(StrSeRs.GetValue(8)), 0, StrSeRs.GetValue(8))

                StrLotPrefix = IIf(IsDBNull(StrSeRs.GetValue(9)), 0, StrSeRs.GetValue(9))

                StrLotSu = IIf(IsDBNull(StrSeRs.GetValue(10)), 0, StrSeRs.GetValue(10))

                StrLotBarNo = IIf(IsDBNull(StrSeRs.GetValue(11)), "", StrSeRs.GetValue(11))

                ' StrUnit = IIf(IsDBNull(StrSeRs.GetValue(8)), "", StrSeRs.GetValue(8))
                StrMfDMonth = Format(IIf(IsDBNull(StrSeRs.GetValue(12)), "", StrSeRs.GetValue(12)), "00")
                StrMfDYear = IIf(IsDBNull(StrSeRs.GetValue(13)), "", StrSeRs.GetValue(13))
                StrExpmonth = Format(IIf(IsDBNull(StrSeRs.GetValue(14)), "", StrSeRs.GetValue(14)), "00")
                StrExpYear = IIf(IsDBNull(StrSeRs.GetValue(15)), "", StrSeRs.GetValue(15))
                ' IntBoxPAck = IIf(IsDBNull(StrSeRs.GetValue(26)), 0, StrSeRs.GetValue(26))

                strtype = IIf(IsDBNull(StrSeRs.GetValue(16)), 0, StrSeRs.GetValue(16))
                Strbtc_No = IIf(IsDBNull(StrSeRs.GetValue(17)), 0, StrSeRs.GetValue(17))
                Strprize = IIf(IsDBNull(StrSeRs.GetValue(18)), 0, StrSeRs.GetValue(18))

            Else

                MsgBox(" Scan Correct Lot No")
                txtlotbarno.Text = ""
                txtlotbarno.Focus()
                StrSeRs.Close()
                Cmd.Dispose()

                Exit Sub

            End If
            StrSeRs.Close()
            Cmd.Dispose()
            Strsize = StrOptic & "X" & StrLength & "mm"
            StrMfD = StrMfDYear & "-" & StrMfDMonth
            StrExp = StrExpYear & "-" & StrExpmonth

            strbtcexpiry = StrExpmonth & "-" & StrExpYear



            StrInyear = StrExpYear + 3
            StrInexp1 = StrInyear & "-" & StrExpmonth
            StrOnlyLot = StrLotPrefix & StrLotSu
            Strprice = "M.R.P. ` :" & " " & Strprize & "/-"
            StrTwoDBar = StrLotBarNo & "," & StrLotPower & " D" & "," & StrModel & "," & StrRefName & "," & StrOptic & " mm" & "," & StrLength & " mm" & "," & strbtcexpiry & "," & Strbtc_No

            If rdbttypeothers.Checked = True Then

                ''//PANDIAN//''

                'strsql = "select File_Name from Printer_Master where printer_Name='" & DefaultPrinterName() & "' and model_name='" & StrModel & "'"
                'Cmd = New SqlCommand(strsql, con)
                'strrs = Cmd.ExecuteReader
                'If strrs.Read Then
                '    strfilename = IIf(IsDBNull(strrs.GetValue(0)), "", strrs.GetValue(0))

                'Else
                '    MsgBox(" Please verify printer,file details for present model ")
                '    strrs.Close()
                '    Cmd.Dispose()
                '    Exit Sub
                'End If

                'strrs.Close()
                'Cmd.Dispose()

                If StrModel = "nAs207" Or StrModel = "nAsY207" Then

                    'Dim writePRN As New StreamWriter(Application.StartupPath & "\write.prn")

                    Dim StrFName As String

                    If StrModel = "nAs207" Then
                        StrFName = "NaSPRONEW.btw"
                    ElseIf StrModel = "nAsY207" Then
                        StrFName = "NaSPRONEW-BBY.btw"
                    End If


                    btFile = Application.StartupPath & "\" & StrFName & ""
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)

                    bt.SetNamedSubStringValue("Model", StrModel)
                    bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                    bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                    bt.SetNamedSubStringValue("Len", StrLength & " mm")
                    bt.SetNamedSubStringValue("Expdt", StrExp)
                    bt.SetNamedSubStringValue("mfdate", StrMfD)
                    bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                    bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                    bt.SetNamedSubStringValue("Lot", Strbtc_No)
                    bt.SetNamedSubStringValue("Aconst", StrAConst)
                    bt.SetNamedSubStringValue("EanCode", StrEanCode)
                    bt.SetNamedSubStringValue("Inj_ref", strinj_ref)
                    bt.SetNamedSubStringValue("Inj_lot", strinj_batch)
                    bt.SetNamedSubStringValue("injexp", strinjexp)

                    'bt.SetNamedSubStringValue("price", Strprice)
                    'bt.SetNamedSubStringValue("RefName", StrRefName)
                    'bt.SetNamedSubStringValue("injexp", StrInexp1)
                    bt.PrintOut()
                    '  End If
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                ElseIf StrModel = "SFAC6" Or StrModel = "SFAC7" Or StrModel = "SFE5" Then

                    btFile = Application.StartupPath & "\SWUHHDD.btw"
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("Model", StrModel)
                    bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                    bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                    bt.SetNamedSubStringValue("Len", StrLength & " mm")
                    bt.SetNamedSubStringValue("mfdate", StrMfD)
                    bt.SetNamedSubStringValue("Expdt", StrExp)
                    bt.SetNamedSubStringValue("Pwr", StrLotPower & "D")
                    bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                    bt.SetNamedSubStringValue("btc_no", Strbtc_No)
                    bt.SetNamedSubStringValue("Aconst", StrAConst)
                    'bt.SetNamedSubStringValue("EanCode", StrEanCode)
                    bt.SetNamedSubStringValue("Mfddt", StrMfD)
                    bt.SetNamedSubStringValue("lensz", Strsize)
                    bt.SetNamedSubStringValue("Inj_ref", strinj_ref)
                    bt.SetNamedSubStringValue("Inj_lot", strinj_batch)
                    'bt.SetNamedSubStringValue("price", Strprice)
                    bt.PrintOut()
                    '  End If
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                ElseIf ((StrModel = "502" Or StrModel = "601" Or StrModel = "701" Or StrModel = "701H") And strtype <> "Export-Turkey") Then

                    If RdoFSL.Checked = True Then
                        btFile = Application.StartupPath & "\ACRYFOLD_BT_MAX.btw "
                        bt = bApp.Formats.Open(btFile, , DefaultPrinterName)

                    ElseIf Rdocolumbian.Checked = True Then

                        btFile = Application.StartupPath & "\ACRYFOLD_BT_MAX_7_Columbian.btw"
                        bt = bApp.Formats.Open(btFile, , DefaultPrinterName)

                    ElseIf RdoSSL.Checked = True Then
                        btFile = Application.StartupPath & "\ACRYFOLD_BT_MAX_7.btw "
                        bt = bApp.Formats.Open(btFile, , DefaultPrinterName)

                    Else

                        btFile = Application.StartupPath & "\ACRYFOLD_OTR.btw"
                        bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    End If

                    If RdoOt.Checked = True Then

                        bt.SetNamedSubStringValue("Model", StrModel)
                        bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                        bt.SetNamedSubStringValue("Len", StrLength & " mm")
                        bt.SetNamedSubStringValue("mfdate", StrMfD)
                        bt.SetNamedSubStringValue("Expdt", StrExp)
                        bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                        bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                        bt.SetNamedSubStringValue("Lot", Strbtc_No)
                        bt.SetNamedSubStringValue("Aconst", StrAConst)
                        bt.SetNamedSubStringValue("RefName", StrRefName)
                        'bt.SetNamedSubStringValue("price", Strprice)
                        bt.PrintOut()
                        bt.Close()
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                        btFile = Application.StartupPath & "\ACRYFOLD_OTR1.btw"
                        bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                        bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                        bt.SetNamedSubStringValue("EanCode", StrEanCode)
                        bt.SetNamedSubStringValue("Inj_ref", strinj_ref)
                        bt.SetNamedSubStringValue("Inj_lot", strinj_batch)
                        bt.PrintOut()

                    Else
                        bt.SetNamedSubStringValue("Model", StrModel)
                        bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                        bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                        bt.SetNamedSubStringValue("Len", StrLength & " mm")
                        bt.SetNamedSubStringValue("Expdt", StrExp)
                        bt.SetNamedSubStringValue("mfdate", StrMfD)
                        bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                        bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                        bt.SetNamedSubStringValue("Lot", Strbtc_No)
                        bt.SetNamedSubStringValue("Aconst", StrAConst)
                        bt.SetNamedSubStringValue("EanCode", StrEanCode)
                        bt.SetNamedSubStringValue("RefName", StrRefName)
                        bt.SetNamedSubStringValue("Inj_ref", strinj_ref)
                        bt.SetNamedSubStringValue("Inj_lot", strinj_batch)
                        'bt.SetNamedSubStringValue("price", Strprice)
                        bt.PrintOut()
                    End If
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)


                ElseIf StrModel = "SUPRAPHOB BBY" Then

                    btFile = Application.StartupPath & "\SUPRA_PHOB_BBY.btw"
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("Model", StrModel)
                    bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                    bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                    bt.SetNamedSubStringValue("Len", StrLength & " mm")
                    bt.SetNamedSubStringValue("mfdate", StrMfD)
                    bt.SetNamedSubStringValue("Expdt", StrExp)
                    bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                    bt.SetNamedSubStringValue("Apwr", strApwr & "D")
                    bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                    bt.SetNamedSubStringValue("btcno", Strbtc_No)
                    bt.SetNamedSubStringValue("Aconst", StrAConst)
                    bt.SetNamedSubStringValue("EanCode", StrEanCode)
                    'bt.SetNamedSubStringValue("price", Strprice)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                ElseIf StrModel = "SUPRAPHOB MS" Or StrModel = "SP INFO" Then

                    btFile = Application.StartupPath & "\SUPRA_PHOB_INFO.btw"

                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("Model", StrModel)
                    'bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                    bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                    'bt.SetNamedSubStringValue("Len", StrLength & " mm")
                    bt.SetNamedSubStringValue("Expdt", StrExp)
                    bt.SetNamedSubStringValue("cyl", strcyl)
                    bt.SetNamedSubStringValue("Pwr", StrLotPower & "D")
                    bt.SetNamedSubStringValue("Apwr", strApwr & "D")
                    bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                    bt.SetNamedSubStringValue("Lot", Strbtc_No)
                    'bt.SetNamedSubStringValue("btc_no", Strbtc_No)
                    'bt.SetNamedSubStringValue("Aconst", StrAConst)
                    bt.SetNamedSubStringValue("EanCode", StrEanCode)
                    bt.SetNamedSubStringValue("mfdate", StrMfD)
                    ' bt.SetNamedSubStringValue("lensz", Strsize)
                    bt.SetNamedSubStringValue("Inj_ref", strinj_ref)
                    bt.SetNamedSubStringValue("Inj_lot", strinj_batch)
                    bt.PrintOut()
                    '  End If
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                ElseIf StrModel = "SPNT200" Or StrModel = "SPNT300" Or StrModel = "HPNT200" Or StrModel = "SPNTY200" Or StrModel = "SPNT300-PL" Or StrModel = "HPNT300" Then

                    btFile = Application.StartupPath & "\SUPRA_PHOB.btw"
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("Model", StrModel)
                    'bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                    bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                    'bt.SetNamedSubStringValue("Len", StrLength & " mm")
                    bt.SetNamedSubStringValue("Expdt", StrExp)
                    bt.SetNamedSubStringValue("mfdate", StrMfD)
                    bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                    bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                    bt.SetNamedSubStringValue("Lot", Strbtc_No)
                    'bt.SetNamedSubStringValue("Aconst", StrAConst)
                    bt.SetNamedSubStringValue("EanCode", StrEanCode)
                    bt.SetNamedSubStringValue("Inj_ref", strinj_ref)
                    bt.SetNamedSubStringValue("Inj_lot", strinj_batch)
                    'bt.SetNamedSubStringValue("price", Strprice)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)


                ElseIf StrModel = "HF01" Or StrModel = "HF02" Or StrModel = "HF03" Then

                    btFile1 = Application.StartupPath & "\HEERAFOLD_main.btw"
                    bt1 = bApp1.Formats.Open(btFile1, , DefaultPrinterName)
                    bt1.SetNamedSubStringValue("TwoD", StrTwoDBar)
                    bt1.SetNamedSubStringValue("Model", StrModel)
                    bt1.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                    bt1.SetNamedSubStringValue("LotSr", StrLotBarNo)
                    bt1.SetNamedSubStringValue("Lot", Strbtc_No)
                    'bt.SetNamedSubStringValue("price", Strprice)
                    bt1.PrintOut()
                    bt1.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt1)


                    btFile = Application.StartupPath & "\HEERAFOLD.BTW"
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("Model", StrModel)
                    bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                    bt.SetNamedSubStringValue("Len", StrLength & " mm")
                    bt.SetNamedSubStringValue("mfdate", StrMfD)
                    bt.SetNamedSubStringValue("Expdt", StrExp)
                    bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                    bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                    bt.SetNamedSubStringValue("Lot", Strbtc_No)
                    bt.SetNamedSubStringValue("Aconst", StrAConst)
                    'bt.SetNamedSubStringValue("price", Strprice)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)


                ElseIf ((StrModel = "502" Or StrModel = "601" Or StrModel = "701") And strtype = "Export-Turkey") Then

                    btFile = Application.StartupPath & "\acryfoldotr.btw"

                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("Model", StrModel)
                    bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                    bt.SetNamedSubStringValue("Len", StrLength & " mm")
                    bt.SetNamedSubStringValue("Expdt", StrExp)
                    bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                    'bt.SetNamedSubStringValue("price", Strprice)
                    bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                    'bt.SetNamedSubStringValue("Lot", Strbtc_No)
                    bt.SetNamedSubStringValue("Aconst", StrAConst)
                    bt.SetNamedSubStringValue("RefName", StrRefName)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                    btFile1 = Application.StartupPath & "\HEERAFOLD_2.BTW"
                    bt1 = bApp1.Formats.Open(btFile1, , DefaultPrinterName)
                    bt1.SetNamedSubStringValue("TwoD", StrTwoDBar)
                    bt1.SetNamedSubStringValue("EanCode", StrEanCode)
                    bt1.PrintOut()
                    bt1.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt1)

                ElseIf StrModel = "CHP6013" Then

                    btFile = Application.StartupPath & "\CATRAPHOB.btw"
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("Model", StrModel)
                    bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                    bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                    bt.SetNamedSubStringValue("Len", StrLength & " mm")
                    bt.SetNamedSubStringValue("mfdate", StrMfD)
                    bt.SetNamedSubStringValue("Expdt", StrExp)
                    bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                    bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                    bt.SetNamedSubStringValue("Lot", Strbtc_No)
                    'bt.SetNamedSubStringValue("price", Strprice)
                    bt.SetNamedSubStringValue("Aconst", StrAConst)
                    'bt.SetNamedSubStringValue("EanCode", StrEanCode)
                    'bt.SetNamedSubStringValue("RefName", StrRefName)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                ElseIf StrModel = "SCC6012" Then

                    btFile = Application.StartupPath & "\CATRAFLEX.btw"
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("Model", StrModel)
                    bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                    bt.SetNamedSubStringValue("mfdate", StrMfD)
                    bt.SetNamedSubStringValue("Expdt", StrExp)
                    'bt.SetNamedSubStringValue("price", Strprice)
                    bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                    bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                End If
                SqlIn = "update POUCH_LABEL set Box_Packing =1,Box_By='" & StrLoginUser & "',Injector_Ref ='" & strinj_ref & "',Injector_batch ='" & strinj_batch & "',Box_Date=GETDATE() where Lot_SrNo='" & txtlotbarno.Text & "' "
                Cmd = New SqlCommand(SqlIn, con)
                Cmd.ExecuteNonQuery()
                Cmd.Dispose()


                StrLotBarNo = ""
                StrLotPrefix = ""
                StrLotSu = ""
                StrLotPower = ""
                StrOptic = ""
                StrLength = ""
                StrUnit = ""
                StrMfDMonth = ""
                StrMfDYear = ""
                StrExpmonth = ""
                StrExpYear = ""
                IntBoxPAck = 0
                GS_Type = ""
                txtlotbarno.Text = ""

                txtlotbarno.Text = ""
                txtinj_No.Text = ""
                txtinj_No.Focus()
                Exit Sub

            Else
                If rbttype1.Checked = True Then

                    btFile = Application.StartupPath & "\SwissFold.btw"
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("Model", StrModel)
                    bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                    bt.SetNamedSubStringValue("Expdt", StrExp)
                    bt.SetNamedSubStringValue("mfdate", StrMfD)
                    bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                    bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                    bt.SetNamedSubStringValue("btcno", Strbtc_No)
                    bt.SetNamedSubStringValue("Size1", Strsize)
                    bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                    bt.SetNamedSubStringValue("Len", StrLength & " mm")
                    bt.SetNamedSubStringValue("Inj_ref", strinj_ref)
                    bt.SetNamedSubStringValue("Inj_lot", strinj_batch)
                    'bt.SetNamedSubStringValue("price", Strprice)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                ElseIf rbttype2.Checked = True Then
                    btFile = Application.StartupPath & "\SWISSFOLD2.btw"
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("Model", StrModel)
                    bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                    bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                    bt.SetNamedSubStringValue("Len", StrLength & " mm")
                    bt.SetNamedSubStringValue("Expdt", StrExp)
                    bt.SetNamedSubStringValue("mfdate", StrMfD)
                    bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                    bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                    bt.SetNamedSubStringValue("Btcno", Strbtc_No)
                    bt.SetNamedSubStringValue("Aconst", StrAConst)
                    bt.SetNamedSubStringValue("Inj_ref", strinj_ref)
                    bt.SetNamedSubStringValue("Inj_lot", strinj_batch)
                    'bt.SetNamedSubStringValue("price", Strprice)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                ElseIf rbttype3.Checked = True Then

                    btFile = Application.StartupPath & "\SWISSFOLD3.btw"
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("mfdate", StrMfD)
                    bt.SetNamedSubStringValue("Expdt", StrExp)
                    bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                    bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                    bt.SetNamedSubStringValue("Size1", Strsize)
                    bt.SetNamedSubStringValue("Inj_ref", strinj_ref)
                    bt.SetNamedSubStringValue("Inj_lot", strinj_batch)
                    'bt.SetNamedSubStringValue("price", Strprice)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                ElseIf rbttype4.Checked = True Then
                    gbxinject.Visible = True
                End If

                SqlIn = "update POUCH_LABEL set Box_Packing =1,Box_By='" & StrLoginUser & "',Injector_Ref ='" & strinj_ref & "',Injector_batch ='" & strinj_batch & "',Box_Date=GETDATE() where Lot_SrNo='" & txtlotbarno.Text & "' "
                Cmd = New SqlCommand(SqlIn, con)
                Cmd.ExecuteNonQuery()
                Cmd.Dispose()

                StrLotBarNo = ""
                StrLotPrefix = ""
                StrLotSu = ""
                StrLotPower = ""
                StrOptic = ""
                StrLength = ""
                StrUnit = ""
                StrMfDMonth = ""
                StrMfDYear = ""
                StrExpmonth = ""
                StrExpYear = ""
                IntBoxPAck = 0
                GS_Type = ""

                txtlotbarno.Text = ""
                txtinj_No.Text = ""
                txtinj_No.Focus()

                Exit Sub

            End If
        End If

        txtinj_No.Text = ""
        txtlotbarno.Text = ""
        txtinj_No.Focus()

        'End If

    End Sub

    Private Sub print_box_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles print_box.Enter

        Dim StrSeSql As String
        Dim StrSeRs As SqlDataReader
        Dim Cmd As New SqlCommand
        Dim SqlIn As String

        Dim StrLotPrefix As String
        Dim StrLotSu As String
        Dim StrOnlyLot As String



        If txtlotbarno.Text <> "" Then



            StrSelInj = "SELECT Inj_ref,Str_batch,Exp_year,Exp_Month from Injector_Label where Str_batch = '" & txtinj_No.Text & "' "

            Cmd = New SqlCommand(StrSelInj, con)

            strInjRs = Cmd.ExecuteReader

            If strInjRs.Read Then

                strinj_ref = IIf(IsDBNull(strInjRs.GetValue(0)), "", strInjRs.GetValue(0))
                strinj_batch = IIf(IsDBNull(strInjRs.GetValue(1)), "", strInjRs.GetValue(1))
                strinjyear = IIf(IsDBNull(strInjRs.GetValue(2)), "", strInjRs.GetValue(2))
                strinjmonth = IIf(IsDBNull(strInjRs.GetValue(3)), "", strInjRs.GetValue(3))

            Else
                MsgBox(" Scan Correct Lot No")
                txtinj_No.Text = ""
                txtinj_No.Focus()
                strInjRs.Close()
                Cmd.Dispose()
                Exit Sub

            End If

            strInjRs.Close()
            Cmd.Dispose()

            strinjexp = strinjyear & "-" & strinjmonth

            StrSeSql = "SELECT Brand_Name,Model_Name,Reference_Name,GS_Code,Power,Optic,Length,A_Constant,Type_GS_Code,Lot_Prefix,Lot_No,Lot_SrNo,Mfd_Month,Mfd_Year,Exp_Month,Exp_Year,Type,Btc_No,price from POUCH_LABEL where Lot_SrNo='" & txtlotbarno.Text & "' " & _
           "and Sterilization=1  and Sample_Taken=0 and BPL_Taken=1 and Dc_Packing=0  "

            ''StrSeSql = "select * from POUCH_LABEL where Lot_SrNo='" & txtlotbarno.Text & "' " & _
            '' "and Sterilization=1  and Sample_Taken=0 and BPL_Taken=1  and Dc_Packing=0 and Box_Reject=0 "

            Cmd = New SqlCommand(StrSeSql, con)

            StrSeRs = Cmd.ExecuteReader

            If StrSeRs.Read Then

                If rdobrand.Checked = True Then

                    StrRefName = IIf(IsDBNull(StrSeRs.GetValue(0)), "", StrSeRs.GetValue(0))
                Else
                    StrRefName = IIf(IsDBNull(StrSeRs.GetValue(2)), "", StrSeRs.GetValue(2))
                End If

                StrModel = IIf(IsDBNull(StrSeRs.GetValue(1)), "", StrSeRs.GetValue(1))
                StrEanCode = IIf(IsDBNull(StrSeRs.GetValue(3)), "", StrSeRs.GetValue(3))
                StrLotPower = IIf(IsDBNull(StrSeRs.GetValue(4)), 0, StrSeRs.GetValue(4))

                StrOptic = Format(IIf(IsDBNull(StrSeRs.GetValue(5)), 0, StrSeRs.GetValue(5)), "0.00")
                StrLength = Format(IIf(IsDBNull(StrSeRs.GetValue(6)), 0, StrSeRs.GetValue(6)), "0.00")
                StrAConst = Format(IIf(IsDBNull(StrSeRs.GetValue(7)), 0, StrSeRs.GetValue(7)), "0.00")
                GS_Type = IIf(IsDBNull(StrSeRs.GetValue(8)), 0, StrSeRs.GetValue(8))

                StrLotPrefix = IIf(IsDBNull(StrSeRs.GetValue(9)), 0, StrSeRs.GetValue(9))

                StrLotSu = IIf(IsDBNull(StrSeRs.GetValue(10)), 0, StrSeRs.GetValue(10))

                StrLotBarNo = IIf(IsDBNull(StrSeRs.GetValue(11)), "", StrSeRs.GetValue(11))

                ' StrUnit = IIf(IsDBNull(StrSeRs.GetValue(8)), "", StrSeRs.GetValue(8))
                StrMfDMonth = Format(IIf(IsDBNull(StrSeRs.GetValue(12)), "", StrSeRs.GetValue(12)), "00")
                StrMfDYear = IIf(IsDBNull(StrSeRs.GetValue(13)), "", StrSeRs.GetValue(13))
                StrExpmonth = Format(IIf(IsDBNull(StrSeRs.GetValue(14)), "", StrSeRs.GetValue(14)), "00")
                StrExpYear = IIf(IsDBNull(StrSeRs.GetValue(15)), "", StrSeRs.GetValue(15))
                ' IntBoxPAck = IIf(IsDBNull(StrSeRs.GetValue(26)), 0, StrSeRs.GetValue(26))

                strtype = IIf(IsDBNull(StrSeRs.GetValue(16)), 0, StrSeRs.GetValue(16))
                Strbtc_No = IIf(IsDBNull(StrSeRs.GetValue(17)), 0, StrSeRs.GetValue(17))
                Strprize = IIf(IsDBNull(StrSeRs.GetValue(18)), 0, StrSeRs.GetValue(18))

            Else

                MsgBox(" Scan Correct Lot No")
                txtlotbarno.Text = ""
                txtlotbarno.Focus()
                StrSeRs.Close()
                Cmd.Dispose()

                Exit Sub

            End If
            StrSeRs.Close()
            Cmd.Dispose()
            Strsize = StrOptic & "X" & StrLength & "mm"
            StrMfD = StrMfDYear & "-" & StrMfDMonth
            StrExp = StrExpYear & "-" & StrExpmonth

            strbtcexpiry = StrExpmonth & "-" & StrExpYear



            StrInyear = StrExpYear + 3
            StrInexp1 = StrInyear & "-" & StrExpmonth
            StrOnlyLot = StrLotPrefix & StrLotSu
            Strprice = "M.R.P. ` :" & " " & Strprize & "/-"
            StrTwoDBar = StrLotBarNo & "," & StrLotPower & " D" & "," & StrModel & "," & StrRefName & "," & StrOptic & " mm" & "," & StrLength & " mm" & "," & strbtcexpiry & "," & Strbtc_No

            If rdbttypeothers.Checked = True Then

                ''//PANDIAN//''

                'strsql = "select File_Name from Printer_Master where printer_Name='" & DefaultPrinterName() & "' and model_name='" & StrModel & "'"
                'Cmd = New SqlCommand(strsql, con)
                'strrs = Cmd.ExecuteReader
                'If strrs.Read Then
                '    strfilename = IIf(IsDBNull(strrs.GetValue(0)), "", strrs.GetValue(0))

                'Else
                '    MsgBox(" Please verify printer,file details for present model ")
                '    strrs.Close()
                '    Cmd.Dispose()
                '    Exit Sub
                'End If

                'strrs.Close()
                'Cmd.Dispose()

                If StrModel = "nAs207" Or StrModel = "nAsY207" Then

                    'Dim writePRN As New StreamWriter(Application.StartupPath & "\write.prn")

                    Dim StrFName As String

                    If StrModel = "nAs207" Then
                        StrFName = "NaSPRONEW.btw"
                    ElseIf StrModel = "nAsY207" Then
                        StrFName = "NaSPRONEW-BBY.btw"
                    End If


                    btFile = Application.StartupPath & "\" & StrFName & ""
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)

                    bt.SetNamedSubStringValue("Model", StrModel)
                    bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                    bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                    bt.SetNamedSubStringValue("Len", StrLength & " mm")
                    bt.SetNamedSubStringValue("Expdt", StrExp)
                    bt.SetNamedSubStringValue("mfdate", StrMfD)
                    bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                    bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                    bt.SetNamedSubStringValue("Lot", Strbtc_No)
                    bt.SetNamedSubStringValue("Aconst", StrAConst)
                    bt.SetNamedSubStringValue("EanCode", StrEanCode)
                    bt.SetNamedSubStringValue("Inj_ref", strinj_ref)
                    bt.SetNamedSubStringValue("Inj_lot", strinj_batch)
                    bt.SetNamedSubStringValue("injexp", strinjexp)

                    'bt.SetNamedSubStringValue("price", Strprice)
                    'bt.SetNamedSubStringValue("RefName", StrRefName)
                    'bt.SetNamedSubStringValue("injexp", StrInexp1)
                    bt.PrintOut()
                    '  End If
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                ElseIf StrModel = "SFAC6" Or StrModel = "SFAC7" Or StrModel = "SFE5" Then

                    btFile = Application.StartupPath & "\SWUHHDD.btw"
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("Model", StrModel)
                    bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                    bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                    bt.SetNamedSubStringValue("Len", StrLength & " mm")
                    bt.SetNamedSubStringValue("mfdate", StrMfD)
                    bt.SetNamedSubStringValue("Expdt", StrExp)
                    bt.SetNamedSubStringValue("Pwr", StrLotPower & "D")
                    bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                    bt.SetNamedSubStringValue("btc_no", Strbtc_No)
                    bt.SetNamedSubStringValue("Aconst", StrAConst)
                    'bt.SetNamedSubStringValue("EanCode", StrEanCode)
                    bt.SetNamedSubStringValue("Mfddt", StrMfD)
                    bt.SetNamedSubStringValue("lensz", Strsize)
                    bt.SetNamedSubStringValue("Inj_ref", strinj_ref)
                    bt.SetNamedSubStringValue("Inj_lot", strinj_batch)
                    'bt.SetNamedSubStringValue("price", Strprice)
                    bt.PrintOut()
                    '  End If
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                ElseIf ((StrModel = "502" Or StrModel = "601" Or StrModel = "701" Or StrModel = "701H") And strtype <> "Export-Turkey") Then

                    If RdoFSL.Checked = True Then
                        btFile = Application.StartupPath & "\ACRYFOLD_BT_MAX.btw "
                        bt = bApp.Formats.Open(btFile, , DefaultPrinterName)

                    ElseIf Rdocolumbian.Checked = True Then

                        btFile = Application.StartupPath & "\ACRYFOLD_BT_MAX _7 _Columbian.btw"
                        bt = bApp.Formats.Open(btFile, , DefaultPrinterName)

                    ElseIf RdoSSL.Checked = True Then
                        btFile = Application.StartupPath & "\ACRYFOLD_BT_MAX _7.btw "
                        bt = bApp.Formats.Open(btFile, , DefaultPrinterName)

                    Else

                        btFile = Application.StartupPath & "\ACRYFOLD_OTR.btw"
                        bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    End If

                    If RdoOt.Checked = True Then

                        bt.SetNamedSubStringValue("Model", StrModel)
                        bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                        bt.SetNamedSubStringValue("Len", StrLength & " mm")
                        'bt.SetNamedSubStringValue("mfdate", StrMfD)
                        bt.SetNamedSubStringValue("Expdt", StrExp)
                        bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                        bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                        bt.SetNamedSubStringValue("Lot", Strbtc_No)
                        bt.SetNamedSubStringValue("Aconst", StrAConst)
                        bt.SetNamedSubStringValue("RefName", StrRefName)
                        'bt.SetNamedSubStringValue("price", Strprice)
                        bt.PrintOut()
                        bt.Close()
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                        btFile = Application.StartupPath & "\ACRYFOLD_OTR1.btw"
                        bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                        bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                        bt.SetNamedSubStringValue("EanCode", StrEanCode)
                        bt.SetNamedSubStringValue("Inj_ref", strinj_ref)
                        bt.SetNamedSubStringValue("Inj_lot", strinj_batch)
                        bt.PrintOut()

                    Else
                        bt.SetNamedSubStringValue("Model", StrModel)
                        bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                        bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                        bt.SetNamedSubStringValue("Len", StrLength & " mm")
                        bt.SetNamedSubStringValue("Expdt", StrExp)
                        bt.SetNamedSubStringValue("mfdate", StrMfD)
                        bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                        bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                        bt.SetNamedSubStringValue("Lot", Strbtc_No)
                        bt.SetNamedSubStringValue("Aconst", StrAConst)
                        bt.SetNamedSubStringValue("EanCode", StrEanCode)
                        bt.SetNamedSubStringValue("RefName", StrRefName)
                        bt.SetNamedSubStringValue("Inj_ref", strinj_ref)
                        bt.SetNamedSubStringValue("Inj_lot", strinj_batch)
                        'bt.SetNamedSubStringValue("price", Strprice)
                        bt.PrintOut()
                    End If
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)


                ElseIf StrModel = "SUPRAPHOB BBY" Then

                    btFile = Application.StartupPath & "\SUPRA_PHOB_BBY.btw"
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("Model", StrModel)
                    bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                    bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                    bt.SetNamedSubStringValue("Len", StrLength & " mm")
                    bt.SetNamedSubStringValue("mfdate", StrMfD)
                    bt.SetNamedSubStringValue("Expdt", StrExp)
                    bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                    bt.SetNamedSubStringValue("Apwr", strApwr & "D")
                    bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                    bt.SetNamedSubStringValue("btcno", Strbtc_No)
                    bt.SetNamedSubStringValue("Aconst", StrAConst)
                    bt.SetNamedSubStringValue("EanCode", StrEanCode)
                    'bt.SetNamedSubStringValue("price", Strprice)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                ElseIf StrModel = "SPNT200" Or StrModel = "SPNT300" Or StrModel = "HPNT200" Or StrModel = "SPNTY200" Or StrModel = "SPNT300-PL" Or StrModel = "HPNT300" Then

                    btFile = Application.StartupPath & "\SUPRA_PHOB.btw"
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("Model", StrModel)
                    'bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                    bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                    'bt.SetNamedSubStringValue("Len", StrLength & " mm")
                    bt.SetNamedSubStringValue("Expdt", StrExp)
                    bt.SetNamedSubStringValue("mfdate", StrMfD)
                    bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                    bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                    bt.SetNamedSubStringValue("Lot", Strbtc_No)
                    'bt.SetNamedSubStringValue("Aconst", StrAConst)
                    bt.SetNamedSubStringValue("EanCode", StrEanCode)
                    bt.SetNamedSubStringValue("Inj_ref", strinj_ref)
                    bt.SetNamedSubStringValue("Inj_lot", strinj_batch)
                    'bt.SetNamedSubStringValue("price", Strprice)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)


                ElseIf StrModel = "HF01" Or StrModel = "HF02" Or StrModel = "HF03" Then

                    btFile1 = Application.StartupPath & "\HEERAFOLD_main.btw"
                    bt1 = bApp1.Formats.Open(btFile1, , DefaultPrinterName)
                    bt1.SetNamedSubStringValue("TwoD", StrTwoDBar)
                    bt1.SetNamedSubStringValue("Model", StrModel)
                    bt1.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                    bt1.SetNamedSubStringValue("LotSr", StrLotBarNo)
                    bt1.SetNamedSubStringValue("Lot", Strbtc_No)
                    'bt.SetNamedSubStringValue("price", Strprice)
                    bt1.PrintOut()
                    bt1.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt1)


                    btFile = Application.StartupPath & "\HEERAFOLD.BTW"
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("Model", StrModel)
                    bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                    bt.SetNamedSubStringValue("Len", StrLength & " mm")
                    bt.SetNamedSubStringValue("mfdate", StrMfD)
                    bt.SetNamedSubStringValue("Expdt", StrExp)
                    bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                    bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                    bt.SetNamedSubStringValue("Lot", Strbtc_No)
                    bt.SetNamedSubStringValue("Aconst", StrAConst)
                    'bt.SetNamedSubStringValue("price", Strprice)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)


                ElseIf ((StrModel = "502" Or StrModel = "601" Or StrModel = "701") And strtype = "Export-Turkey") Then

                    btFile = Application.StartupPath & "\acryfoldotr.btw"

                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("Model", StrModel)
                    bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                    bt.SetNamedSubStringValue("Len", StrLength & " mm")
                    bt.SetNamedSubStringValue("Expdt", StrExp)
                    bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                    'bt.SetNamedSubStringValue("price", Strprice)
                    bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                    'bt.SetNamedSubStringValue("Lot", Strbtc_No)
                    bt.SetNamedSubStringValue("Aconst", StrAConst)
                    bt.SetNamedSubStringValue("RefName", StrRefName)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                    btFile1 = Application.StartupPath & "\HEERAFOLD_2.BTW"
                    bt1 = bApp1.Formats.Open(btFile1, , DefaultPrinterName)
                    bt1.SetNamedSubStringValue("TwoD", StrTwoDBar)
                    bt1.SetNamedSubStringValue("EanCode", StrEanCode)
                    bt1.PrintOut()
                    bt1.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt1)

                ElseIf StrModel = "CHP6013" Then

                    btFile = Application.StartupPath & "\CATRAPHOB.btw"
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("Model", StrModel)
                    bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                    bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                    bt.SetNamedSubStringValue("Len", StrLength & " mm")
                    bt.SetNamedSubStringValue("mfdate", StrMfD)
                    bt.SetNamedSubStringValue("Expdt", StrExp)
                    bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                    bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                    bt.SetNamedSubStringValue("Lot", Strbtc_No)
                    'bt.SetNamedSubStringValue("price", Strprice)
                    bt.SetNamedSubStringValue("Aconst", StrAConst)
                    'bt.SetNamedSubStringValue("EanCode", StrEanCode)
                    'bt.SetNamedSubStringValue("RefName", StrRefName)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                ElseIf StrModel = "SCC6012" Then

                    btFile = Application.StartupPath & "\CATRAFLEX.btw"
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("Model", StrModel)
                    bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                    bt.SetNamedSubStringValue("mfdate", StrMfD)
                    bt.SetNamedSubStringValue("Expdt", StrExp)
                    'bt.SetNamedSubStringValue("price", Strprice)
                    bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                    bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                End If
                SqlIn = "update POUCH_LABEL set Box_Packing =1,Box_By='" & StrLoginUser & "',Injector_Ref ='" & strinj_ref & "',Injector_batch ='" & strinj_batch & "',Box_Date=GETDATE() where Lot_SrNo='" & txtlotbarno.Text & "' "
                Cmd = New SqlCommand(SqlIn, con)
                Cmd.ExecuteNonQuery()
                Cmd.Dispose()


                StrLotBarNo = ""
                StrLotPrefix = ""
                StrLotSu = ""
                StrLotPower = ""
                StrOptic = ""
                StrLength = ""
                StrUnit = ""
                StrMfDMonth = ""
                StrMfDYear = ""
                StrExpmonth = ""
                StrExpYear = ""
                IntBoxPAck = 0
                GS_Type = ""

                txtinj_No.Text = ""
                txtlotbarno.Text = ""
                txtinj_No.Focus()

                Exit Sub


            Else
                If rbttype1.Checked = True Then

                    btFile = Application.StartupPath & "\SwissFold.btw"
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("Model", StrModel)
                    bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                    bt.SetNamedSubStringValue("Expdt", StrExp)
                    bt.SetNamedSubStringValue("mfdate", StrMfD)
                    bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                    bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                    bt.SetNamedSubStringValue("btcno", Strbtc_No)
                    bt.SetNamedSubStringValue("Size1", Strsize)
                    bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                    bt.SetNamedSubStringValue("Len", StrLength & " mm")
                    bt.SetNamedSubStringValue("Inj_ref", strinj_ref)
                    bt.SetNamedSubStringValue("Inj_lot", strinj_batch)
                    'bt.SetNamedSubStringValue("price", Strprice)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                ElseIf rbttype2.Checked = True Then
                    btFile = Application.StartupPath & "\SWISSFOLD2.btw"
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("Model", StrModel)
                    bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                    bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                    bt.SetNamedSubStringValue("Len", StrLength & " mm")
                    bt.SetNamedSubStringValue("Expdt", StrExp)
                    bt.SetNamedSubStringValue("mfdate", StrMfD)
                    bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                    bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                    bt.SetNamedSubStringValue("Btcno", Strbtc_No)
                    bt.SetNamedSubStringValue("Aconst", StrAConst)
                    bt.SetNamedSubStringValue("Inj_ref", strinj_ref)
                    bt.SetNamedSubStringValue("Inj_lot", strinj_batch)
                    'bt.SetNamedSubStringValue("price", Strprice)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                ElseIf rbttype3.Checked = True Then

                    btFile = Application.StartupPath & "\SWISSFOLD3.btw"
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("mfdate", StrMfD)
                    bt.SetNamedSubStringValue("Expdt", StrExp)
                    bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                    bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                    bt.SetNamedSubStringValue("Size1", Strsize)
                    bt.SetNamedSubStringValue("Inj_ref", strinj_ref)
                    bt.SetNamedSubStringValue("Inj_lot", strinj_batch)
                    'bt.SetNamedSubStringValue("price", Strprice)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                ElseIf rbttype4.Checked = True Then
                    gbxinject.Visible = True
                End If

                SqlIn = "update POUCH_LABEL set Box_Packing =1,Box_By='" & StrLoginUser & "',Injector_Ref ='" & strinj_ref & "',Injector_batch ='" & strinj_batch & "',Box_Date=GETDATE() where Lot_SrNo='" & txtlotbarno.Text & "' "
                Cmd = New SqlCommand(SqlIn, con)
                Cmd.ExecuteNonQuery()
                Cmd.Dispose()

                StrLotBarNo = ""
                StrLotPrefix = ""
                StrLotSu = ""
                StrLotPower = ""
                StrOptic = ""
                StrLength = ""
                StrUnit = ""
                StrMfDMonth = ""
                StrMfDYear = ""
                StrExpmonth = ""
                StrExpYear = ""
                IntBoxPAck = 0
                GS_Type = ""

                txtlotbarno.Text = ""
                txtinj_No.Text = ""

                Exit Sub

            End If
        End If

        txtinj_No.Text = ""
        txtlotbarno.Text = ""
        txtinj_No.Focus()

    End Sub

    Private Sub txtinj_No_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtinj_No.TextChanged

    End Sub

    Private Sub Rdocolumbian_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rdocolumbian.CheckedChanged

    End Sub
End Class