Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft
Imports System.Data.Sql


Public Class FrmNewInjetLabelReprint
    Dim StrSql As String
    Dim StrRs As SqlDataReader
    Dim Cmd As New SqlCommand
   
    Dim StrMfdMonth As Integer
    Dim StrMfdYear As Integer
    Dim StrExpMonth As Integer
    Dim StrExpYear As Integer
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
    Dim StrlotBarNo As String
    Dim StrlotBarNo2 As String
    Dim cmd1 As SqlCommand
    Dim read1 As SqlDataReader

    Dim sql1 As String
    Dim StrOptic, StrLen, StrPwr, StrRef, StrExp, StrBrand, StrLotNo, StrSrNo, StrEpMon, StrEpYr, StrMdl As String

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



        If txtlotno.Text = "" Then
            err.SetError(txtlotno, "This information is required")
            txtlotno.Focus()
            Exit Sub
        Else
            err.SetError(txtlotno, "")
        End If




        If txtLotNoPrefix.Text = "" Then
            err.SetError(txtLotNoPrefix, "This information is required")
            txtLotNoPrefix.Focus()
            Exit Sub
        Else
            err.SetError(txtLotNoPrefix, "")
        End If



        'StrSql = "select * from  POUCH_LABEL where Lot_SrNo Between '" & txtcrFromQty.Text & "' and '" & txtcrToQty.Text & "'"
        'Cmd = New SqlCommand(StrSql, con)
        'StrRs = Cmd.ExecuteReader
        'If StrRs.Read Then
        'Else
        '    MsgBox("No Data Found", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If
        'StrRs.Close()
        'Cmd.Dispose()

        'If txtquantity.Text = "" Then
        '    err.SetError(txtquantity, "Enter Qty")
        '    Exit Sub
        'Else
        '    err.SetError(txtquantity, "")
        'End If


        If RdoIntBIg.Checked = True Then
            If txtbatno.Text = "" Then
                err.SetError(txtbatno, "Enter Batch No")
                Exit Sub
            Else
                err.SetError(txtbatno, "")
            End If
        End If

        'StrPrQty = txtquantity.Text
        'If Val(StrPrQty) <= 0 Then
        '    MsgBox("Enter Minimum 1 Qty")
        '    txtquantity.Text = ""
        '    txtquantity.Focus()
        '    Exit Sub
        'End If
        'StrMaxQty = lblShowMaxQty.Text
        'StrPrtedQty = LblShowPrintedQty.Text







        'StrBalQty = LblBalanceQty.Text



      

        IntTotExp = 5


        'If Val(StrBalQty) < 0 Then
        '    MsgBox("Max Qty Reached")
        '    txtquantity.Text = ""
        '    txtquantity.Focus()
        '    Exit Sub
        'End If

        StrStPrQty = txtcrFromQty.Text
        StrEnPrQty = txtcrToQty.Text

        StrStSrNo = StrStPrQty
        StrEnSrNo = StrEnPrQty

        StrMfdMonth = Now.Month
        StrMfdYear = Now.Year

        Dim StrMdf As String
        Dim StrExp As String

        StrExpMonth = StrMfdMonth - 1
        StrExpYear = StrMfdYear + IntTotExp

        If StrExpMonth = 0 Then
            StrExpMonth = 12
            StrExpYear = StrExpYear - 1
        End If

        StrMdf = StrMfdMonth & "-" & StrMfdYear
        StrExp = StrExpMonth & "-" & StrExpYear
        Dim StrWInt As Integer

        Dim writePRN As New StreamWriter(Application.StartupPath & "\write.prn")

        StrWInt = 1
        For StI As Integer = StrStPrQty To StrEnPrQty
            Dim StrTo As Integer
            'StrTo = Val(txtquantity.Text)

            'For StI As Integer = 0 To StrTo



            If RdoInA.Checked = True Then
                StrlotBarNo = "A" & txtLotNoPrefix.Text & txtlotno.Text & " " & Format(StrStPrQty, "000")
            Else
                StrlotBarNo = txtLotNoPrefix.Text & txtlotno.Text & " " & Format(StrStPrQty, "000")
            End If






            If RdoInA.Checked = True Or rdoInt.Checked = True Then



                If StrWInt = 1 Then

                    writePRN.WriteLine("AARZ")
                    writePRN.WriteLine("ACS2Z")
                    writePRN.WriteLine("AA101840710Z")
                    writePRN.WriteLine("AA3H0000V0000Z")
                    writePRN.WriteLine("A%2H694V165")
                    writePRN.WriteLine("PS$A,31,31,0$=Inc Size")

                    writePRN.WriteLine("H690V80")
                    writePRN.WriteLine("$A,31,31,0$=EXP")

                    writePRN.WriteLine("H694V37")
                    writePRN.WriteLine("$A,31,31,0$=S.No")

                    writePRN.WriteLine("H694V122")
                    writePRN.WriteLine("$A,31,31,0$=MFG ")

                    writePRN.WriteLine("H534V165")
                    writePRN.WriteLine("$A,31,31,0$=" & CmbShModel.Text & "")

                    writePRN.WriteLine("H598V125")
                    writePRN.WriteLine("$A,31,31,0$=" & StrMdf & "")

                    writePRN.WriteLine("H598V82")
                    writePRN.WriteLine("$A,31,31,0$=" & StrExp & "")

                    writePRN.WriteLine("H598V40")
                    writePRN.WriteLine("$A,31,31,0$=" & StrlotBarNo & "")

                    writePRN.WriteLine("H566V166")
                    writePRN.WriteLine("$A,38,38,0$=:")

                    writePRN.WriteLine("H614V131")
                    writePRN.WriteLine("$A,38,38,0$=:")

                    writePRN.WriteLine("H614V86")
                    writePRN.WriteLine("$A,38,38,0$=:")

                    writePRN.WriteLine("H614V41")
                    writePRN.WriteLine("$A,38,38,0$=:")
                    '***************new**************************+
                    'writePRN.WriteLine("AARZ")
                    'writePRN.WriteLine("ACS3Z")
                    'writePRN.WriteLine("A#E5CZ")
                    'writePRN.WriteLine("AA102771018Z")
                    'writePRN.WriteLine("AA3H0000V0000Z")
                    'writePRN.WriteLine("A%2H760V235")
                    'writePRN.WriteLine("PSL0101XB1" & CmbShModel.Text & "")
                    'writePRN.WriteLine("H875V186")
                    'writePRN.WriteLine("L0101XB1" & StrMdf & "")
                    'writePRN.WriteLine("H868V79")
                    'writePRN.WriteLine("L0101XB1" & StrlotBarNo & "")
                    'writePRN.WriteLine("H880V127")
                    'writePRN.WriteLine("L0101XB1" & StrExp & "")
                    'writePRN.WriteLine("H1000V235")
                    'writePRN.WriteLine("L0101XB1Inc Size  :")
                    'writePRN.WriteLine("H1004V180")
                    'writePRN.WriteLine("L0101XB1MFG :")
                    'writePRN.WriteLine("H1000V79")
                    'writePRN.WriteLine("L0101XB1S.N  :")
                    'writePRN.WriteLine("H1000V127")
                    'writePRN.WriteLine("L0101XB1EXP :")


                    ''300 dpi haed
                    ''writePRN.WriteLine("AARZ")
                    ''writePRN.WriteLine("ACS2Z")
                    ''writePRN.WriteLine("A#E5CZ")
                    ''writePRN.WriteLine("AA102771018Z")
                    ''writePRN.WriteLine("AA3H0000V0000Z")
                    ''writePRN.WriteLine("A%2H722V241")
                    ''writePRN.WriteLine("PSRDB00,47,47," & CmbShModel.Text & "")
                    ''writePRN.WriteLine("H838V192")
                    ''writePRN.WriteLine("RDB00,47,47," & StrMdf & "")
                    ''writePRN.WriteLine("H830V84")
                    ''writePRN.WriteLine("RDB00,41,47," & StrlotBarNo & "")
                    ''writePRN.WriteLine("H842V132")
                    ''writePRN.WriteLine("RDB00,47,47," & StrExp & "")
                    ''writePRN.WriteLine("H0972V241")
                    ''writePRN.WriteLine("RDB00,47,47,Inc Size  :")
                    ''writePRN.WriteLine("H0976V185")
                    ''writePRN.WriteLine("RDB00,41,47,MFG :")
                    ''writePRN.WriteLine("H0972V84")
                    ''writePRN.WriteLine("RDB00,47,47,S.N  :")
                    ''writePRN.WriteLine("H0972V132")
                    ''writePRN.WriteLine("RDB00,47,47,EXP :")

                    StrWInt = 0
                Else


                    writePRN.WriteLine("H182V166")
                    writePRN.WriteLine("$A,38,38,0$=:")
                    writePRN.WriteLine("H230V131")
                    writePRN.WriteLine("$A,38,38,0$=:")
                    writePRN.WriteLine("H230V86")
                    writePRN.WriteLine("$A,38,38,0$=:")
                    writePRN.WriteLine("H230V41")
                    writePRN.WriteLine("$A,38,38,0$=:")


                    writePRN.WriteLine("H204V125")
                    writePRN.WriteLine("$A,31,31,0$=" & StrMdf & "")

                    writePRN.WriteLine("H204V82")
                    writePRN.WriteLine("$A,31,31,0$=" & StrExp & "")
                    writePRN.WriteLine("H204V40")
                    writePRN.WriteLine("$A,31,31,0$=" & StrlotBarNo & "")

                    writePRN.WriteLine("H140V165")
                    writePRN.WriteLine("$A,31,31,0$=" & CmbShModel.Text & "")

                    writePRN.WriteLine("H300V165")
                    writePRN.WriteLine("$A,31,31,0$=Inc Size")
                    writePRN.WriteLine("H300V80")
                    writePRN.WriteLine("$A,31,31,0$=EXP")
                    writePRN.WriteLine("H300V37")
                    writePRN.WriteLine("$A,31,31,0$=S.No")
                    writePRN.WriteLine("H300V122")
                    writePRN.WriteLine("$A,31,31,0$=MFG ")
                    writePRN.WriteLine("Q1")
                    writePRN.WriteLine("Z")
                    '**********************new*******************
                    'writePRN.WriteLine("H247V235")
                    'writePRN.WriteLine("L0101XB1" & CmbShModel.Text & "")
                    'writePRN.WriteLine("H362V186")
                    'writePRN.WriteLine("L0101XB1" & StrMdf & "")
                    'writePRN.WriteLine("H355V79")
                    'writePRN.WriteLine("L0101XB1" & StrlotBarNo & "")
                    'writePRN.WriteLine("H367V127")
                    'writePRN.WriteLine("L0101XB1" & StrExp & "")
                    'writePRN.WriteLine("H487V235")
                    'writePRN.WriteLine("L0101XB1Inc Size  :")
                    'writePRN.WriteLine("H491V180")
                    'writePRN.WriteLine("L0101XB1MFG :")
                    'writePRN.WriteLine("H487V79")
                    'writePRN.WriteLine("L0101XB1S.N  :")
                    'writePRN.WriteLine("H487V127")
                    'writePRN.WriteLine("L0101XB1EXP :")
                    'writePRN.WriteLine("Q1")
                    'writePRN.WriteLine("Z")

                    ''//300 dpi head
                    ''writePRN.WriteLine("H159V241")
                    ''writePRN.WriteLine("RDB00,47,47," & CmbShModel.Text & "")
                    ''writePRN.WriteLine("H275V192")
                    ''writePRN.WriteLine("RDB00,47,47," & StrMdf & "")
                    ''writePRN.WriteLine("H267V84")
                    ''writePRN.WriteLine("RDB00,41,47," & StrlotBarNo & "")
                    ''writePRN.WriteLine("H279V132")
                    ''writePRN.WriteLine("RDB00,47,47," & StrExp & "")
                    ''writePRN.WriteLine("H399V241")
                    ''writePRN.WriteLine("RDB00,47,47,Inc Size  :")
                    ''writePRN.WriteLine("H403V185")
                    ''writePRN.WriteLine("RDB00,41,47,MFG :")
                    ''writePRN.WriteLine("H399V84")
                    ''writePRN.WriteLine("RDB00,47,47,S.N  :")
                    ''writePRN.WriteLine("H399V132")
                    ''writePRN.WriteLine("RDB00,47,47,EXP :")
                    ''writePRN.WriteLine("Q1")
                    ''writePRN.WriteLine("Z")

                    StrWInt = 1
                End If


            ElseIf RdoIntBIg.Checked = True Then


                writePRN.WriteLine("AARZ")
                writePRN.WriteLine("ACS2Z")
                writePRN.WriteLine("AA101600550Z")
                writePRN.WriteLine("AA3H0000V0000Z")
                writePRN.WriteLine("A%2H516V103")
                writePRN.WriteLine("PS$A,31,31,0$=Inc Size")
                writePRN.WriteLine("H228V146")
                writePRN.WriteLine("$A,31,31,0$=EXP")
                writePRN.WriteLine("H516V53")
                writePRN.WriteLine("$A,31,31,0$=S.No")
                writePRN.WriteLine("H516V146")
                writePRN.WriteLine("$A,31,31,0$=MFG ")
                writePRN.WriteLine("H365V103")
                writePRN.WriteLine("$A,31,31,0$=" & CmbShModel.Text & "")
                writePRN.WriteLine("H420V146")
                writePRN.WriteLine("$A,31,31,0$=" & StrMdf & "")
                writePRN.WriteLine("H132V146")
                writePRN.WriteLine("$A,31,31,0$=" & StrExp & "")
                writePRN.WriteLine("H428V53")
                writePRN.WriteLine("$A,31,31,0$=" & StrlotBarNo & "")
                writePRN.WriteLine("H397V104")
                writePRN.WriteLine("$A,38,38,0$=:")
                writePRN.WriteLine("H436V154")
                writePRN.WriteLine("$A,38,38,0$=:")
                writePRN.WriteLine("H148V154")
                writePRN.WriteLine("$A,38,38,0$=:")
                writePRN.WriteLine("H444V61")
                writePRN.WriteLine("$A,38,38,0$=:")
                writePRN.WriteLine("H220V53")
                writePRN.WriteLine("$A,31,31,0$=B.No :")
                writePRN.WriteLine("H132V53")
                writePRN.WriteLine("$A,31,31,0$=" & txtbatno.Text & "'")
                writePRN.WriteLine("Q1")
                writePRN.WriteLine("Z")


            ElseIf RdoExportturkey.Checked = True Then


                If StrWInt = 1 Then

                   
                    ''//300 dpi 
                    ''writePRN.WriteLine("AARZ")
                    ''writePRN.WriteLine("A#E5CZ")
                    ''writePRN.WriteLine("AA103971248Z")
                    ''writePRN.WriteLine("AA3H0000V0000Z")

                    ''writePRN.WriteLine("A%2H1216V348")
                    ''writePRN.WriteLine("PSRDB00,42,42,Inc Size  :")
                    ''writePRN.WriteLine("H1000V348")
                    ''writePRN.WriteLine("RDB00,42,42," & CmbShModel.Text & "")
                    ''writePRN.WriteLine("H1216V300")
                    ''writePRN.WriteLine("RDB00,31,42,MFG       :")
                    ''writePRN.WriteLine("H1000V300")
                    ''writePRN.WriteLine("RDB00,42,42," & StrMdf & "")
                    ''writePRN.WriteLine("H1216V252")
                    ''writePRN.WriteLine("RDB00,31,42,EXP       :")
                    ''writePRN.WriteLine("H1000V252")
                    ''writePRN.WriteLine("RDB00,42,42," & StrExp & "")
                    ''writePRN.WriteLine("H1216V204")
                    ''writePRN.WriteLine("RDB00,33,42,S.NO      :")
                    ''writePRN.WriteLine("H1012V204")
                    ''writePRN.WriteLine("RDB00,42,42," & StrlotBarNo & "")


                    ''writePRN.WriteLine("H1192V144")
                    ''writePRN.WriteLine("D304065890412559858")
                    ''writePRN.WriteLine("H1180V80")
                    ''writePRN.WriteLine("RDB00,57,57,9")
                    ''writePRN.WriteLine("H1152V80")
                    ''writePRN.WriteLine("RDB00,57,57,0")
                    ''writePRN.WriteLine("H1123V80")
                    ''writePRN.WriteLine("RDB00,57,57,4")
                    ''writePRN.WriteLine("H1089V80")
                    ''writePRN.WriteLine("RDB00,57,57,1")
                    ''writePRN.WriteLine("H1066V80")
                    ''writePRN.WriteLine("RDB00,57,57,2")
                    ''writePRN.WriteLine("H1037V80")
                    ''writePRN.WriteLine("RDB00,57,57,5")
                    ''writePRN.WriteLine("H996V80")
                    ''writePRN.WriteLine("RDB00,57,57,5")
                    ''writePRN.WriteLine("H968V80")
                    ''writePRN.WriteLine("RDB00,57,57,9")
                    ''writePRN.WriteLine("H939V80")
                    ''writePRN.WriteLine("RDB00,57,57,8")
                    ''writePRN.WriteLine("H911V80")
                    ''writePRN.WriteLine("RDB00,57,57,5")
                    ''writePRN.WriteLine("H882V80")
                    ''writePRN.WriteLine("RDB00,57,57,8")
                    ''writePRN.WriteLine("H853V80")
                    ''writePRN.WriteLine("RDB00,57,57,4")
                    ''writePRN.WriteLine("H1228V80")
                    ''writePRN.WriteLine("RDB00,57,57,8")


                    ''200 dpi
                    writePRN.WriteLine("AARZ")
                    writePRN.WriteLine("A#E5CZ")
                    writePRN.WriteLine("AA102640831Z")
                    writePRN.WriteLine("AA3H0000V0000Z")

                    writePRN.WriteLine("A%2H792V232")
                    writePRN.WriteLine("PSRDB00,28,28,Inc Size  :")
                    writePRN.WriteLine("H648V232")
                    writePRN.WriteLine("RDB00,28,28," & CmbShModel.Text & "")
                    writePRN.WriteLine("H792V200")
                    writePRN.WriteLine("RDB00,24,33,MFG       :")
                    writePRN.WriteLine("H648V200")
                    writePRN.WriteLine("RDB00,28,28," & StrMdf & "")
                    writePRN.WriteLine("H792V168")
                    writePRN.WriteLine("RDB00,24,30,EXP       :")
                    writePRN.WriteLine("H648V168")
                    writePRN.WriteLine("RDB00,28,28," & StrExp & "")
                    writePRN.WriteLine("H792V136")
                    writePRN.WriteLine("RDB00,24,30,S.NO      :")
                    writePRN.WriteLine("H656V136")
                    writePRN.WriteLine("RDB00,28,28," & StrlotBarNo & "")


                    writePRN.WriteLine("H776V95")
                    writePRN.WriteLine("D303043890412569858")
                    writePRN.WriteLine("H766V53")
                    writePRN.WriteLine("RDB00,38,38,9")
                    writePRN.WriteLine("H745V53")
                    writePRN.WriteLine("RDB00,38,38,0")
                    writePRN.WriteLine("H724V53")
                    writePRN.WriteLine("RDB00,38,38,4")
                    writePRN.WriteLine("H698V53")
                    writePRN.WriteLine("RDB00,38,38,1")
                    writePRN.WriteLine("H680V53")
                    writePRN.WriteLine("RDB00,38,38,2")
                    writePRN.WriteLine("H659V53")
                    writePRN.WriteLine("RDB00,38,38,5")
                    writePRN.WriteLine("H628V53")
                    writePRN.WriteLine("RDB00,38,38,6")
                    writePRN.WriteLine("H607V53")
                    writePRN.WriteLine("RDB00,38,38,9")
                    writePRN.WriteLine("H585V53")
                    writePRN.WriteLine("RDB00,38,38,8")
                    writePRN.WriteLine("H564V53")
                    writePRN.WriteLine("RDB00,38,38,5")
                    writePRN.WriteLine("H542V53")
                    writePRN.WriteLine("RDB00,38,38,8")
                    writePRN.WriteLine("H522V53")
                    writePRN.WriteLine("RDB00,38,38,4")
                    writePRN.WriteLine("H803V53")
                    writePRN.WriteLine("RDB00,38,38,8")

                    StrWInt = 0
                Else


                    ''//300 dpi 
                    ''writePRN.WriteLine("H568V348")
                    ''writePRN.WriteLine("RDB00,42,42,Inc Size  :")
                    ''writePRN.WriteLine("H352V348")
                    ''writePRN.WriteLine("RDB00,42,42," & CmbShModel.Text & "")
                    ''writePRN.WriteLine("H568V300")
                    ''writePRN.WriteLine("RDB00,31,42,MFG       :")
                    ''writePRN.WriteLine("H352V300")
                    ''writePRN.WriteLine("RDB00,42,42," & StrMdf & "")
                    ''writePRN.WriteLine("H568V252")
                    ''writePRN.WriteLine("RDB00,31,42,EXP       :")
                    ''writePRN.WriteLine("H352V252")
                    ''writePRN.WriteLine("RDB00,42,42," & StrExp & "")
                    ''writePRN.WriteLine("H568V204")
                    ''writePRN.WriteLine("RDB00,33,42,S.NO      :")
                    ''writePRN.WriteLine("H364V204")
                    ''writePRN.WriteLine("RDB00,42,42," & StrlotBarNo & "")


                    ''writePRN.WriteLine("H544V144")
                    ''writePRN.WriteLine("D304065890412559858")
                    ''writePRN.WriteLine("H532V80")
                    ''writePRN.WriteLine("RDB00,57,57,9")
                    ''writePRN.WriteLine("H504V80")
                    ''writePRN.WriteLine("RDB00,57,57,0")
                    ''writePRN.WriteLine("H475V80")
                    ''writePRN.WriteLine("RDB00,57,57,4")
                    ''writePRN.WriteLine("H441V80")
                    ''writePRN.WriteLine("RDB00,57,57,1")
                    ''writePRN.WriteLine("H418V80")
                    ''writePRN.WriteLine("RDB00,57,57,2")
                    ''writePRN.WriteLine("H389V80")
                    ''writePRN.WriteLine("RDB00,57,57,5")
                    ''writePRN.WriteLine("H348V80")
                    ''writePRN.WriteLine("RDB00,57,57,5")
                    ''writePRN.WriteLine("H320V80")
                    ''writePRN.WriteLine("RDB00,57,57,9")
                    ''writePRN.WriteLine("H291V80")
                    ''writePRN.WriteLine("RDB00,57,57,8")
                    ''writePRN.WriteLine("H263V80")
                    ''writePRN.WriteLine("RDB00,57,57,5")
                    ''writePRN.WriteLine("H234V80")
                    ''writePRN.WriteLine("RDB00,57,57,8")
                    ''writePRN.WriteLine("H205V80")
                    ''writePRN.WriteLine("RDB00,57,57,4")
                    ''writePRN.WriteLine("H580V80")
                    ''writePRN.WriteLine("RDB00,57,57,8")


                    ''writePRN.WriteLine("Q1")
                    ''writePRN.WriteLine("Z")


                    ''//200 dpi
                    writePRN.WriteLine("H360V232")
                    writePRN.WriteLine("RDB00,28,28,Inc Size  :")
                    writePRN.WriteLine("H216V232")
                    writePRN.WriteLine("RDB00,28,28," & CmbShModel.Text & "")
                    writePRN.WriteLine("H360V200")
                    writePRN.WriteLine("RDB00,24,33,MFG       :")
                    writePRN.WriteLine("H216V200")
                    writePRN.WriteLine("RDB00,28,28," & StrMdf & "")
                    writePRN.WriteLine("H360V168")
                    writePRN.WriteLine("RDB00,24,30,EXP       :")
                    writePRN.WriteLine("H216V168")
                    writePRN.WriteLine("RDB00,28,28," & StrExp & "")
                    writePRN.WriteLine("H360V136")
                    writePRN.WriteLine("RDB00,24,30,S.NO      :")
                    writePRN.WriteLine("H224V136")
                    writePRN.WriteLine("RDB00,28,28," & StrlotBarNo & "")


                    writePRN.WriteLine("H344V95")
                    writePRN.WriteLine("D303043890412569858")
                    writePRN.WriteLine("H334V53")
                    writePRN.WriteLine("RDB00,38,38,9")
                    writePRN.WriteLine("H313V53")
                    writePRN.WriteLine("RDB00,38,38,0")
                    writePRN.WriteLine("H292V53")
                    writePRN.WriteLine("RDB00,38,38,4")
                    writePRN.WriteLine("H266V53")
                    writePRN.WriteLine("RDB00,38,38,1")
                    writePRN.WriteLine("H248V53")
                    writePRN.WriteLine("RDB00,38,38,2")
                    writePRN.WriteLine("H227V53")
                    writePRN.WriteLine("RDB00,38,38,5")
                    writePRN.WriteLine("H196V53")
                    writePRN.WriteLine("RDB00,38,38,6")
                    writePRN.WriteLine("H175V53")
                    writePRN.WriteLine("RDB00,38,38,9")
                    writePRN.WriteLine("H153V53")
                    writePRN.WriteLine("RDB00,38,38,8")
                    writePRN.WriteLine("H132V53")
                    writePRN.WriteLine("RDB00,38,38,5")
                    writePRN.WriteLine("H110V53")
                    writePRN.WriteLine("RDB00,38,38,8")
                    writePRN.WriteLine("H90V53")
                    writePRN.WriteLine("RDB00,38,38,4")
                    writePRN.WriteLine("H371V53")
                    writePRN.WriteLine("RDB00,38,38,8")


                    writePRN.WriteLine("Q1")
                    writePRN.WriteLine("Z")


                    StrWInt = 1
                End If




                ''single datamax
                'Dim readPRN As New StreamReader(Application.StartupPath & "\Exportturkeyinjet.prn")
                'Dim idx As Integer
                'Dim dt As String
                'While readPRN.Peek <> -1
                '    dt = readPRN.ReadLine
                '    Debug.Print(dt)
                '    idx = dt.IndexOf("ref")
                '    If idx <> -1 Then
                '        dt = dt.Substring(0, idx) & CmbShModel.Text
                '    End If


                '    idx = dt.IndexOf("mfd1")
                '    If idx <> -1 Then
                '        dt = dt.Substring(0, idx) & StrMdf
                '    End If


                '    idx = dt.IndexOf("exp1")
                '    If idx <> -1 Then
                '        dt = dt.Substring(0, idx) & StrExp
                '    End If

                '    'idx = dt.IndexOf("Pwr")
                '    'If idx <> -1 Then
                '    '    dt = dt.Substring(0, idx) & LblShowPower.Text & " D"
                '    'End If

                '    idx = dt.IndexOf("Lotsrno")
                '    If idx <> -1 Then
                '        dt = dt.Substring(0, idx) & StrlotBarNo
                '    End If



                '    If pnl.Focus Then

                '    End If


                '    'idx = dt.IndexOf("RefName")
                '    'If idx <> -1 Then
                '    '    dt = dt.Substring(0, idx) & LblShowRefName.Text
                '    'End If



                '    writePRN.WriteLine(dt)
                '    Debug.Print(dt)
                'End While
                'readPRN.Close()
                'readPRN.Dispose()

            ElseIf rdosupra.Checked = True Then



                If StrWInt = 1 Then


                    ''//300 dpi
                    ''writePRN.WriteLine("AARZ")
                    ''writePRN.WriteLine("A#E5CZ")
                    ''writePRN.WriteLine("AA103971248Z")
                    ''writePRN.WriteLine("AA3H0000V0000Z")
                    ''writePRN.WriteLine("A%2H1192V324")
                    ''writePRN.WriteLine("PSRDB00,29,42,Ref        :")
                    ''writePRN.WriteLine("H976V324")
                    ''writePRN.WriteLine("RDB00,42,42," & CmbShModel.Text & "")
                    ''writePRN.WriteLine("H1192V156")
                    ''writePRN.WriteLine("RDB00,31,42,MFG     :")
                    ''writePRN.WriteLine("H1000V156")
                    ''writePRN.WriteLine("RDB00,42,42," & StrMdf & "")
                    ''writePRN.WriteLine("H1192V108")
                    ''writePRN.WriteLine("RDB00,27,42,EXP       :")
                    ''writePRN.WriteLine("H1000V108")
                    ''writePRN.WriteLine("RDB00,42,42," & StrExp & "")
                    ''writePRN.WriteLine("H1192V276")
                    ''writePRN.WriteLine("RDB00,35,42,S.NO  :")
                    ''writePRN.WriteLine("H988V276")
                    ''writePRN.WriteLine("RDB00,42,42," & StrlotBarNo & "")

                    ''writePRN.WriteLine("H1192V216")
                    ''writePRN.WriteLine("RDB00,29,42,LOT       :")
                    ''writePRN.WriteLine("H988V216")
                    ''writePRN.WriteLine("RDB00,42,42," & txtbatno.Text & "")


                    ''//200 dpi
                    writePRN.WriteLine("AARZ")
                    writePRN.WriteLine("A#E5CZ")
                    writePRN.WriteLine("AA102640831Z")
                    writePRN.WriteLine("AA3H0000V0000Z")
                    writePRN.WriteLine("A%2H792V216")
                    writePRN.WriteLine("PSRDB00,24,37,Ref       :")
                    writePRN.WriteLine("H640V216")
                    writePRN.WriteLine("RDB00,28,28," & CmbShModel.Text & "")
                    writePRN.WriteLine("H792V104")
                    writePRN.WriteLine("RDB00,24,33,MFG    :")
                    writePRN.WriteLine("H640V104")
                    writePRN.WriteLine("RDB00,28,28," & StrMdf & "")
                    writePRN.WriteLine("H792V72")
                    writePRN.WriteLine("RDB00,24,37,EXP    :")
                    writePRN.WriteLine("H640V64")
                    writePRN.WriteLine("RDB00,28,28," & StrExp & "")
                    writePRN.WriteLine("H792V184")
                    writePRN.WriteLine("RDB00,24,28,S.NO   :")
                    writePRN.WriteLine("H640V184")
                    writePRN.WriteLine("RDB00,28,28," & StrlotBarNo & "")

                    writePRN.WriteLine("H792V144")
                    writePRN.WriteLine("RDB00,24,33,LOT    :")
                    writePRN.WriteLine("H640V144")
                    writePRN.WriteLine("RDB00,28,28," & txtbatno.Text & "")



                    StrWInt = 0
                Else


                    ''//300 dpi

                    ''writePRN.WriteLine("H544V324")
                    ''writePRN.WriteLine("RDB00,29,42,Ref        :")
                    ''writePRN.WriteLine("H328V324")
                    ''writePRN.WriteLine("RDB00,42,42," & CmbShModel.Text & "")
                    ''writePRN.WriteLine("H544V156")
                    ''writePRN.WriteLine("RDB00,31,42,MFG     :")
                    ''writePRN.WriteLine("H352V156")
                    ''writePRN.WriteLine("RDB00,42,42," & StrMdf & "")
                    ''writePRN.WriteLine("H544V108")
                    ''writePRN.WriteLine("RDB00,27,42,EXP       :")
                    ''writePRN.WriteLine("H352V108")
                    ''writePRN.WriteLine("RDB00,42,42," & StrExp & "")
                    ''writePRN.WriteLine("H544V276")
                    ''writePRN.WriteLine("RDB00,35,42,S.NO   :")
                    ''writePRN.WriteLine("H340V276")
                    ''writePRN.WriteLine("RDB00,42,42," & StrlotBarNo & "")

                    ''writePRN.WriteLine("H544V216")
                    ''writePRN.WriteLine("RDB00,29,42,LOT       :")
                    ''writePRN.WriteLine("H340V216")
                    ''writePRN.WriteLine("RDB00,42,42," & txtbatno.Text & "")


                    ''//200 dpi


                    writePRN.WriteLine("H360V216")
                    writePRN.WriteLine("RDB00,24,37,Ref       :")
                    writePRN.WriteLine("H208V216")
                    writePRN.WriteLine("RDB00,28,28," & CmbShModel.Text & "")
                    writePRN.WriteLine("H360V104")
                    writePRN.WriteLine("RDB00,24,33,MFG    :")
                    writePRN.WriteLine("H208V104")
                    writePRN.WriteLine("RDB00,28,28," & StrMdf & "")
                    writePRN.WriteLine("H360V72")
                    writePRN.WriteLine("RDB00,24,37,EXP    :")
                    writePRN.WriteLine("H208V64")
                    writePRN.WriteLine("RDB00,28,28," & StrExp & "")
                    writePRN.WriteLine("H360V184")
                    writePRN.WriteLine("RDB00,24,28,S.NO   :")
                    writePRN.WriteLine("H208V184")
                    writePRN.WriteLine("RDB00,28,28," & StrlotBarNo & "")

                    writePRN.WriteLine("H360V144")
                    writePRN.WriteLine("RDB00,24,33,LOT    :")
                    writePRN.WriteLine("H208V144")
                    writePRN.WriteLine("RDB00,28,28," & txtbatno.Text & "")


                    writePRN.WriteLine("Q1")
                    writePRN.WriteLine("Z")

                    StrWInt = 1
                End If



                ''\\Pandian single datamax
                'Dim readPRN As New StreamReader(Application.StartupPath & "\ExportSuprainjet.prn")
                'Dim idx As Integer
                'Dim dt As String
                'While readPRN.Peek <> -1
                '    dt = readPRN.ReadLine
                '    Debug.Print(dt)
                '    idx = dt.IndexOf("ref")
                '    If idx <> -1 Then
                '        dt = dt.Substring(0, idx) & CmbShModel.Text
                '    End If


                '    idx = dt.IndexOf("mfd1")
                '    If idx <> -1 Then
                '        dt = dt.Substring(0, idx) & StrMdf
                '    End If


                '    idx = dt.IndexOf("exp1")
                '    If idx <> -1 Then
                '        dt = dt.Substring(0, idx) & StrExp
                '    End If

                '    'idx = dt.IndexOf("Pwr")
                '    'If idx <> -1 Then
                '    '    dt = dt.Substring(0, idx) & LblShowPower.Text & " D"
                '    'End If

                '    idx = dt.IndexOf("Lotsrno")
                '    If idx <> -1 Then
                '        dt = dt.Substring(0, idx) & StrlotBarNo
                '    End If


                '    idx = dt.IndexOf("Btc")
                '    If idx <> -1 Then
                '        dt = dt.Substring(0, idx) & txtbatno.Text
                '    End If
                '    If pnl.Focus Then

                '    End If


                '    'idx = dt.IndexOf("RefName")
                '    'If idx <> -1 Then
                '    '    dt = dt.Substring(0, idx) & LblShowRefName.Text
                '    'End If



                '    writePRN.WriteLine(dt)
                '    Debug.Print(dt)
                'End While
                'readPRN.Close()
                'readPRN.Dispose()












            End If





            'LblShowPrintedQty.Text = StrStPrQty
            'LblBalanceQty.Text = Val(lblShowMaxQty.Text) - StrStPrQty






            StrStPrQty = Val(StrStPrQty) + 1
            StrTo = StrTo + 1
        Next



        If StrWInt = 0 Then
            writePRN.WriteLine("Q1")
            writePRN.WriteLine("Z")
        End If


        writePRN.Flush()
        writePRN.Close()
        writePRN.Dispose()

        RawPrinterHelper.SendFileToPrinter(DefaultPrinterName, Application.StartupPath & "\write.prn")
        'txtquantity.Text = ""




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

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
        'RawPrinterHelper.SendFileToPrinter(DefaultPrinterName, Application.StartupPath & "\write.prn")
    End Sub
End Class