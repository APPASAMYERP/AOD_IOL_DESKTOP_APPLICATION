Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Public Class FrmNewBoxPackingSUPERPHOB



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
    Dim strbdname As String
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
    Dim StrUdiEanCode As String
    Dim StrLotNo, strinjyear, lotno, lotcout, strinjmonth, strinjexp, strinjmanf, StrLotBarNo, StrLotPower, StrOptic, strinj_ref, strinj_Lot, strinj_batch, StrLength, StrEanCode, StrUnit, StrMfDMonth, StrMfDYear, StrModel, StrExpmonth, StrExpYear, StrUni, StrMfD, StrExp As String
    Dim StrTwoDBar, Strbtc_No, Strprice, Strprize, strbtcmfd, Strinmfd As String


    Private Sub rb_with_Injector_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_with_Injector.CheckedChanged
        If rb_with_Injector.Checked = True Then
            GroupBox7.Visible = True
        Else
            GroupBox7.Visible = False
        End If


    End Sub

    Private Sub txtinj_No_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtinj_No.KeyDown
        If txtinj_No.Text <> "" Then

            If e.KeyCode = Keys.Enter Then

                txtlotbarno.Focus()
            Else

            End If

        End If
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
        strsql = "select distinct LabelName from BTW_Master where Department = 'BOX' "
        Dim cmd As New SqlCommand(strsql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)

        cmbPrintLabel.DisplayMember = "LabelName"
        cmbPrintLabel.DataSource = ds.Tables(0)

    End Sub

    Private Sub FrmNewBoxPackingSUPERPHOB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LabelNameBind()
    End Sub

    Private Sub FrmNewBoxPackingSUPERPHOB_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        killProcess("bartend")
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        killProcess("bartend")
        Me.Close()
    End Sub

    Public Function SQL_SelectQuery_Execute(ByVal StrSql As String) As DataSet

        Dim ds As New DataSet
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Public Sub UpdateorInsertQuery_Execute(ByVal strQuery As String)

        Dim strsql As String
        strsql = strQuery
        Dim cmd As New SqlCommand(strsql, con)
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Function BTWFileName() As String
        Dim labelds = New DataSet
        Dim ModelNo As String = ""
        If rdLotSerial.Checked = True Then
            strsql = "select * from  POUCH_LABEL where Lot_SrNo = '" & txtlotbarno.Text & "'  "
        ElseIf rdUDICode.Checked = True Then
            strsql = "select * from  POUCH_LABEL where Udi_code = '" & txtlotbarno.Text & "'  "
        Else
            MsgBox(" Plese choose Lot Serial or UDI Serial")
            Exit Function
        End If

        Dim cmd = New SqlCommand(strsql, con)
        Dim ad1 As New SqlDataAdapter(cmd)
        ad1.Fill(labelds)
        If labelds.Tables(0).Rows.Count <> 0 Then
            ModelNo = labelds.Tables(0).Rows(0)("Model_Name").ToString()
        End If


        Dim ds As New DataSet()
        strsql = "select * from BTW_Master where Department = 'BOX' and ModelNo = '" & ModelNo & "' and LabelName = '" & cmbPrintLabel.Text & "' "
        cmd = New SqlCommand(strsql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)
        If ds.Tables(0).Rows.Count <> 0 Then
            Return ds.Tables(0).Rows(0)("FileName")
        Else
            Return ""
        End If


    End Function

    Private Sub txtlotbarno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlotbarno.KeyDown


        If e.KeyCode = Keys.Enter Then

            If txtlotbarno.Text <> "" Then

                Dim StrSeSql As String
                Dim StrSeRs As SqlDataReader
                Dim Cmd As New SqlCommand
                Dim SqlIn As String

                Dim StrLotPrefix, Strinjbtc_No, Strinjref, strinjmy, strinjmm As String
                Dim StrLotSu As String
                Dim strIsBoxPacking As String = ""
                Dim IsInspected As Boolean = False

                Dim IsErpUser As Integer = 0
                Dim Logged_Reprint_User_Level As String = ""
                Dim Reprint_taken_User_Levels As String = ""
                Dim Ds_new As New DataSet
                Dim StrLog As String = ""


                




                If txtlotbarno.Text <> "" Then

                    strinj_ref = ""
                    strinj_batch = ""
                    strinjyear = ""
                    strinjmonth = ""
                    strinjmy = ""
                    strinj_Lot = ""
                    strinjmm = ""
                    strinjmanf = ""
                    strinjexp = ""

                    
                    If con.State = Data.ConnectionState.Open Then
                        con.Close()
                    End If

                    Try
                        con.Open()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    If rb_with_Injector.Checked Then
                        StrSelInj = "SELECT Inj_ref,Str_batch,Exp_year,Exp_Month,Mfd_Year,Mfd_Month from Injector_Label where Str_batch = '" & txtinj_No.Text & "' "


                        Cmd = New SqlCommand(StrSelInj, con)
                        strInjRs = Cmd.ExecuteReader
                        If strInjRs.Read Then

                            strinj_ref = IIf(IsDBNull(strInjRs.GetValue(0)), "", strInjRs.GetValue(0))
                            strinj_batch = IIf(IsDBNull(strInjRs.GetValue(1)), "", strInjRs.GetValue(1))
                            strinjyear = IIf(IsDBNull(strInjRs.GetValue(2)), "", strInjRs.GetValue(2))
                            strinjmonth = IIf(IsDBNull(strInjRs.GetValue(3)), "", strInjRs.GetValue(3))
                            strinjmy = IIf(IsDBNull(strInjRs.GetValue(4)), "", strInjRs.GetValue(4))
                            strinjmm = IIf(IsDBNull(strInjRs.GetValue(5)), "", strInjRs.GetValue(5))

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

                        strinjmanf = strinjmy & "-" & strinjmm
                        strinjexp = strinjyear & "-" & strinjmonth
                    End If


                    If con.State = Data.ConnectionState.Open Then
                        con.Close()
                    End If

                    Try
                        con.Open()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try


                    StrSeSql = "SELECT Brand_Name,Model_Name,Reference_Name,GS_Code,Power,Optic,Length,A_Constant,Type_GS_Code,Lot_Prefix,Lot_No,Lot_SrNo,Mfd_Month,Mfd_Year,Exp_Month,Exp_Year,Type,Btc_No,price,R_Power,Injector_Ref,Injector_batch,Cylsize, Box_Packing from POUCH_LABEL where Lot_SrNo='" & txtlotbarno.Text & "' " & _
                  "and Sterilization=1  and Sample_Taken=0 and BPL_Taken=1 and Dc_Packing=0  and Box_Reject = 0 and Sterilization_After = 1 and Sterilization_Reject = 0  and  Btc_No is not null "



                    Cmd = New SqlCommand(StrSeSql, con)
                    StrSeRs = Cmd.ExecuteReader

                    If StrSeRs.Read Then
                        strbdname = IIf(IsDBNull(StrSeRs.GetValue(0)), "", StrSeRs.GetValue(0))
                        StrRefName = IIf(IsDBNull(StrSeRs.GetValue(2)), "", StrSeRs.GetValue(2))
                        StrModel = IIf(IsDBNull(StrSeRs.GetValue(1)), "", StrSeRs.GetValue(1))
                        StrEanCode = IIf(IsDBNull(StrSeRs.GetValue(3)), "", StrSeRs.GetValue(3))
                        StrLotPower = IIf(IsDBNull(StrSeRs.GetValue(4)), 0, StrSeRs.GetValue(4))
                        StrOptic = Format(IIf(IsDBNull(StrSeRs.GetValue(5)), 0, StrSeRs.GetValue(5)), "0.00")
                        StrLength = Format(IIf(IsDBNull(StrSeRs.GetValue(6)), 0, StrSeRs.GetValue(6)), "0.00")
                        StrAConst = Format(IIf(IsDBNull(StrSeRs.GetValue(7)), 0, StrSeRs.GetValue(7)), "0.0")
                        GS_Type = IIf(IsDBNull(StrSeRs.GetValue(8)), 0, StrSeRs.GetValue(8))
                        StrLotPrefix = IIf(IsDBNull(StrSeRs.GetValue(9)), 0, StrSeRs.GetValue(9))
                        StrLotSu = IIf(IsDBNull(StrSeRs.GetValue(10)), 0, StrSeRs.GetValue(10))
                        StrLotBarNo = IIf(IsDBNull(StrSeRs.GetValue(11)), "", StrSeRs.GetValue(11))
                        StrMfDMonth = Format(IIf(IsDBNull(StrSeRs.GetValue(12)), "", StrSeRs.GetValue(12)), "00")
                        StrMfDYear = IIf(IsDBNull(StrSeRs.GetValue(13)), "", StrSeRs.GetValue(13))
                        StrExpmonth = Format(IIf(IsDBNull(StrSeRs.GetValue(14)), "", StrSeRs.GetValue(14)), "00")
                        StrExpYear = IIf(IsDBNull(StrSeRs.GetValue(15)), "", StrSeRs.GetValue(15))
                        strtype = IIf(IsDBNull(StrSeRs.GetValue(16)), 0, StrSeRs.GetValue(16))
                        Strbtc_No = IIf(IsDBNull(StrSeRs.GetValue(17)), 0, StrSeRs.GetValue(17))
                        Strinjref = IIf(IsDBNull(StrSeRs.GetValue(20)), 0, StrSeRs.GetValue(20))
                        Strinjbtc_No = IIf(IsDBNull(StrSeRs.GetValue(21)), 0, StrSeRs.GetValue(21))
                        Strprize = IIf(IsDBNull(StrSeRs.GetValue(18)), 0, StrSeRs.GetValue(18))
                        strApwr = IIf(IsDBNull(StrSeRs.GetValue(19)), 0, StrSeRs.GetValue(19))
                        strcyl = IIf(IsDBNull(StrSeRs.GetValue(22)), 0, StrSeRs.GetValue(22))
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

                    StrTwoDBar = StrLotBarNo & "," & StrLotPower & " D" & "," & StrModel & "," & strbdname & "," & StrOptic & " mm" & "," & StrLength & " mm" & "," & strbtcexpiry & "," & Strbtc_No


                    strbtcexpiry = StrExpYear.Substring(2, 2)
                    StrInexp1 = strbtcexpiry & StrExpmonth & "00"


                    strbtcmfd = StrMfDYear.Substring(2, 2)
                    Strinmfd = strbtcmfd & StrMfDMonth & "00"

                    StrInexp1 = strbtcexpiry & StrExpmonth & "00"
                    Strinmfd = strbtcmfd & StrMfDMonth & "00"


                    'sundar UDI
                    If StrEanCode.Length <> 14 Then
                        MessageBox.Show("please check GTIN Code")
                        Exit Sub
                    End If
                    StrUdiEanCode = StrEanCode.Remove(StrEanCode.ToString().Length - 1, 1)


                    Dim StrFName As String

                    StrFName = BTWFileName()

                    If StrFName = "" Then
                        MessageBox.Show("BTW file record not found")
                        Exit Sub
                    End If

                    btFile = Application.StartupPath & "\" & StrFName & ""

                    If System.IO.File.Exists(btFile) Then
                        'The file exists
                    Else
                        MessageBox.Show("BTW file record not found")
                        Exit Sub
                    End If


                    If con.State = Data.ConnectionState.Open Then
                        con.Close()
                    End If

                    Try
                        con.Open()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    'Update Query
                    SqlIn = "update POUCH_LABEL set Box_Packing =1,Box_By='" & StrLoginUser & "',Injector_Ref ='" & strinj_ref & "',Injector_batch ='" & strinj_batch & "',Box_Date=GETDATE(),Boxtime = GETDATE(),Station = '" & station & "'  where Lot_SrNo='" & txtlotbarno.Text & "' "

                    Cmd = New SqlCommand(SqlIn, con)
                    Cmd.ExecuteNonQuery()
                    Cmd.Dispose()
                    'Update Query





                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)

                    bt.SetNamedSubStringValue("Model", StrModel)
                    bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                    bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                    bt.SetNamedSubStringValue("Len", StrLength & " mm")
                    bt.SetNamedSubStringValue("Expdt", StrExp)
                    bt.SetNamedSubStringValue("mfdate", StrMfD)
                    bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                    bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                    bt.SetNamedSubStringValue("Aconst", StrAConst)
                    bt.SetNamedSubStringValue("EanCode", StrEanCode)
                    bt.SetNamedSubStringValue("Btc", Strbtc_No)
                    bt.SetNamedSubStringValue("mfdtwod", Strinmfd)
                    bt.SetNamedSubStringValue("exptwod", StrInexp1)
                    bt.SetNamedSubStringValue("Lotno", StrLotBarNo.Replace(" ", ""))
                    bt.SetNamedSubStringValue("UdiEanCode", StrUdiEanCode)
                    bt.SetNamedSubStringValue("Inj_ref", strinj_ref)
                    bt.SetNamedSubStringValue("Inj_lot", strinj_batch)
                    bt.SetNamedSubStringValue("cyl", strcyl)
                    bt.SetNamedSubStringValue("Bdname", strbdname)
                    bt.SetNamedSubStringValue("RefName", StrRefName)
                    bt.SetNamedSubStringValue("inj_mfd", strinjmanf)
                    bt.SetNamedSubStringValue("inj_exp", strinjexp)

                    bt.PrintOut()

                  


                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)




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






                End If

            End If
        End If
    End Sub
End Class