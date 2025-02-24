Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft
Imports System.Data.Sql
Imports System.Configuration

Public Class FrmNewPouchLablePrintPhilic
    Dim Ds As New DataSet
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
    Dim StrRs As SqlDataReader
    Dim cmd As SqlCommand
    Dim strfilename As String
    Dim StrOnlyLot As String
    Dim strtype As String
    Dim strbdname As String
    Dim strpfile As String
    Dim Strrpwr As String
    Dim strrefpwr As String
    Dim strrefname1 As String
    Dim StrMfdMonth As Integer
    Dim StrMfdYear As Integer
    Dim StrExpMonth As Integer
    Dim StrExpYear As Integer
    Dim IntTotExp As Integer
    Dim getdetail As String

    Dim strmfmonth As String
    Dim strmfyear As String
    Dim strexmonth As String
    Dim strexyear As String


    Dim strmonth1 As String
    Dim StrInmfd As String
    Dim stryear1 As String
    Dim strpwr As String

    Dim stroptic As String
    Dim strlength As String


    Dim strexpsupdate As String

    Dim strmfdsupdate As String
    Dim cmd1 As SqlCommand
    Dim read1 As SqlDataReader
    Dim read As SqlDataReader
    Dim sql As String

    Dim StrSqlSe1 As String
    Dim StrRsSe1 As SqlDataReader
    Dim StrStSrNo, StrlotonlyNo As String
    Dim StrEnSrNo As String
    Dim StrMaxQty As Integer
    Dim StrPrtedQty As Integer
    Dim StrPrQty As Integer
    Dim StrBalQty As Integer

    Dim StrStPrQty As Integer
    Dim StrEnPrQty As Integer

    Dim StrSqlSePr, StroneDBar As String
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
    Dim Stroptic1 As String
    Dim Strlength1 As String
    Dim StrLot1 As String
    Dim StrSno1 As String

    Dim sql1 As String
    Dim StrTo As Integer

    Private Sub LabelNameBind()
        Dim ds As New DataSet()
        strsql = "select distinct LabelName from BTW_Master where Department = 'POUCH'"
        Dim cmd As New SqlCommand(strsql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)

        cmbPrintLabel.DisplayMember = "LabelName"
        cmbPrintLabel.DataSource = ds.Tables(0)


    End Sub

    Private Sub FrmNewPouchLablePrintPhilic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If

        LabelNameBind()

        Dim conString1 As String = ConfigurationSettings.AppSettings("conStrPHILIC_ERP").ToString()
        Dim con1 As SqlConnection
        con1 = New SqlConnection(conString1)

        Try
            con1.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        strsql = ("SELECT  distinct TumblingNo from MinFQI where Flag = 1 and   AcceptedQty <> 0")
        cmd = New SqlCommand(strsql, con1)
        If con1.State = Data.ConnectionState.Open Then
            con1.Close()
        End If
        con1.Open()
        StrRs = cmd.ExecuteReader
        ComboBox1.Items.Clear()
        While StrRs.Read
            ComboBox1.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        cmd.Dispose()




        'strsql = "SELECT DISTINCT TumblingNo from LENS_LOT where Active =  'YES' and TumblingNo is not null  order by TumblingNo"
        'cmd = New SqlCommand(strsql, con)
        'StrRs = cmd.ExecuteReader
        'ComboBox1.Items.Clear()
        'While StrRs.Read
        '    ComboBox1.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        'End While
        'StrRs.Close()
        'cmd.Dispose()


        'StrSql = "SELECT DISTINCT Model_Name from LENS_MASTER order by Model_Name"
        'Cmd = New SqlCommand(StrSql, con)
        'StrRs = Cmd.ExecuteReader
        'CmbShModel3.Items.Clear()
        'While StrRs.Read
        '    CmbShModel3.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        'End While
        'StrRs.Close()
        'Cmd.Dispose()


        strsql = "SELECT DISTINCT Type from LENS_LOT where Active =  'YES' and Type is not null  order by Type"
        cmd = New SqlCommand(strsql, con)
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        StrRs = cmd.ExecuteReader
        CmbType.Items.Clear()
        While StrRs.Read
            CmbType.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        cmd.Dispose()

        LblShowLotPrefix.Text = ""
        LblShowLotNo.Text = ""

        lblShowMaxQty.Text = 0
        LblShowPrintedQty.Text = 0
        LblBalanceQty.Text = 0
        'Label18.Visible = False
        'txtbtc.Visible = False


        LblShowGSCode.Text = ""
        LblShowPower.Text = ""
        LblShowRefName.Text = ""
        LblShowOptic.Text = ""
        LblShowLength.Text = ""
        LblShowGSType.Text = ""
        LblshAConstant.Text = ""
        txtrpwr.Visible = False
        txtcylsize.Visible = False
        lblrpwr.Visible = False
        lblcylsz.Visible = False

    End Sub

    Private Sub CmbShBrand_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


        If CmbShModel2.Text = "SFE5" Or CmbShModel2.Text = "SFC6" Or CmbShModel2.Text = "SFC7" Or CmbShModel2.Text = "SFAC6" Or CmbShModel2.Text = "SFAC7" Or CmbShModel2.Text = "HF01" Or CmbShModel2.Text = "HF02" Or CmbShModel2.Text = "HF03" Or CmbShModel2.Text = "SCC6012" Or CmbShModel2.Text = "CHY6013" Then


            CmbShType.Enabled = False
            strsql = "SELECT * from LENS_MASTER where Model_Name='" & CmbShModel2.Text & "' and POWER='" & CmbShPower1.Text & "'  and Brand_Name='" & CmbShBrand1.Text & "' "
            cmd = New SqlCommand(strsql, con)
            If con.State = Data.ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            StrRs = cmd.ExecuteReader

            If StrRs.Read Then

                LblShowGSCode.Text = IIf(IsDBNull(StrRs.GetValue(5)), "", StrRs.GetValue(5))
                LblShowPower.Text = Format(IIf(IsDBNull(StrRs.GetValue(6)), 0, StrRs.GetValue(6)), "0.00")
                LblShowRefName.Text = IIf(IsDBNull(StrRs.GetValue(4)), "", StrRs.GetValue(4))
                LblShowOptic.Text = Format(IIf(IsDBNull(StrRs.GetValue(7)), "", StrRs.GetValue(7)), "0.00")
                LblShowLength.Text = Format(IIf(IsDBNull(StrRs.GetValue(8)), "", StrRs.GetValue(8)), "0.00")
                LblShowGSType.Text = IIf(IsDBNull(StrRs.GetValue(11)), "", StrRs.GetValue(11))
                LblshAConstant.Text = Format(IIf(IsDBNull(StrRs.GetValue(10)), 0, StrRs.GetValue(10)), "0.00")
                IntTotExp = IIf(IsDBNull(StrRs.GetValue(12)), 0, StrRs.GetValue(12))

                StrMfdMonth = Now.Month
                strmfmonth = StrMfdMonth.ToString("00")

                StrMfdYear = Now.Year
                strmfyear = StrMfdYear.ToString("0000")

                StrExpMonth = StrMfdMonth - 1
                strexmonth = StrExpMonth.ToString("00")

                StrExpYear = StrMfdYear + IntTotExp
                strexyear = StrExpYear.ToString("0000")

                If StrExpMonth = 0 Then
                    strexmonth = (12).ToString("00")
                    strexyear = (StrExpYear - 1).ToString("0000")
                End If

                LblShowMfdDate.Text = strmfyear & "-" & strmfmonth
                LblShowExpDate.Text = strexyear & "-" & strexmonth

            Else
                MsgBox("No Data Found", MsgBoxStyle.Critical)
                Exit Sub
            End If
            StrRs.Close()
            cmd.Dispose()

        Else

            CmbShType.Enabled = True

            If CmbShBrand1.Text <> "" Then
                strsql = "SELECT DISTINCT Type_GS_Code from LENS_MASTER where Brand_Name='" & CmbShBrand1.Text & "' and Model_Name='" & CmbShModel2.Text & "' and POWER='" & CmbShPower1.Text & "' order by Type_GS_Code"
                cmd = New SqlCommand(strsql, con)
                If con.State = Data.ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                StrRs = cmd.ExecuteReader
                CmbShType.Items.Clear()
                CmbShType.Text = ""
                While StrRs.Read
                    CmbShType.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
                End While
                StrRs.Close()
                cmd.Dispose()
            End If

        End If

    End Sub

    Private Sub CmbShModel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If CmbShModel2.Text <> "" Then
            strsql = "SELECT DISTINCT POWER from LENS_MASTER where Model_Name='" & CmbShModel2.Text & "' order by POWER"
            cmd = New SqlCommand(strsql, con)
            If con.State = Data.ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            StrRs = cmd.ExecuteReader

            'CmbShPower1.Items.Clear()
            'CmbShBrand1.Items.Clear()
            CmbShType.Items.Clear()

            CmbShPower1.Text = ""
            CmbShBrand1.Text = ""
            CmbShType.Text = ""

            txtcylsize.Text = "NULL"
            txtrpwr.Text = "NULL"

            While StrRs.Read
                'CmbShPower1.Items.Add(Format(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)), "0.00"))
            End While
            StrRs.Close()
            cmd.Dispose()

            If CmbShModel2.Text = "SPMFDY200" Or CmbShModel2.Text = "SPMFD200" Or CmbShModel2.Text = "SUPRAPHOB MS" Then

                lblcylsz.Visible = True
                txtcylsize.Visible = True
            Else

                lblcylsz.Visible = False
                txtcylsize.Visible = False
            End If
        End If
    End Sub

    Private Function BTWFileName() As String
        Dim ds As New DataSet()
        strsql = "select * from BTW_Master where Department = 'POUCH' and ModelNo = '" & CmbShModel2.Text & "' and LabelName = '" & cmbPrintLabel.Text & "' "
        Dim cmd As New SqlCommand(strsql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)
        If ds.Tables(0).Rows.Count <> 0 Then
            Return ds.Tables(0).Rows(0)("FileName")
        Else
            Return ""
        End If


    End Function

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        'sundar 08-05-2024-- Plan based report

        Try
            If cmb_Order_Type.SelectedItem Is Nothing Then
                err.SetError(cmb_Order_Type, "Please Select valid Order Type")
                cmb_Order_Type.Focus()
                Exit Sub
            Else
                err.SetError(cmb_Order_Type, "")
            End If

            If cmb_Order_Type.Text = "" Then
                err.SetError(cmb_Order_Type, "This information is required")
                Exit Sub
            Else
                err.SetError(cmb_Order_Type, "")
            End If

            If cmb_Order_Country.SelectedItem Is Nothing Then
                err.SetError(cmb_Order_Country, "Please Select valid Order Country")
                cmb_Order_Country.Focus()
                Exit Sub
            Else
                err.SetError(cmb_Order_Country, "")
            End If

            If cmb_Order_Country.Text = "" Then
                err.SetError(cmb_Order_Country, "This information is required")
                Exit Sub
            Else
                err.SetError(cmb_Order_Country, "")
            End If
            '--


            If CmbType.Text = "" Then
                err.SetError(CmbType, "This information is required")
                CmbType.Focus()
                Exit Sub
            Else
                err.SetError(CmbShModel2, "")
            End If


            If LblShowLotPrefix.Text = "" Then
                err.SetError(LblShowLotPrefix, "This information is required")
                CmbType.Focus()
                Exit Sub
            Else
                err.SetError(LblShowLotPrefix, "")
            End If


            If LblShowLotNo.Text = "" Then
                err.SetError(LblShowLotPrefix, "This information is required")
                CmbType.Focus()
                Exit Sub
            Else
                err.SetError(LblShowLotPrefix, "")
            End If


            If CmbShModel2.Text = "" Then
                err.SetError(CmbShModel2, "This information is required")
                CmbShModel2.Focus()
                Exit Sub
            Else
                err.SetError(CmbShModel2, "")
            End If


            If CmbShPower1.Text = "" Then
                err.SetError(CmbShPower1, "This information is required")
                CmbShPower1.Focus()
                Exit Sub
            Else
                err.SetError(CmbShPower1, "")
            End If


            If CmbShBrand1.Text = "" Then
                err.SetError(CmbShBrand1, "This information is required")
                Exit Sub
            Else
                err.SetError(CmbShBrand1, "")
            End If

            If CmbShType.Text = "" Then
                err.SetError(CmbShType, "This information is required")
                Exit Sub
            Else
                err.SetError(CmbShType, "")
            End If

            If txtquantity.Text = "" Then
                err.SetError(txtquantity, "Enter Qty")
                Exit Sub
            Else
                err.SetError(txtquantity, "")
            End If

            'KPMG
            If ComboBox1.SelectedItem Is Nothing Then
                err.SetError(ComboBox1, "Please Select valid Glassy Lot Number")
                ComboBox1.Focus()
                Exit Sub
            Else
                err.SetError(ComboBox1, "")
            End If

            If CmbType.SelectedItem Is Nothing Then
                err.SetError(CmbType, "Please Select valid Type")
                CmbType.Focus()
                Exit Sub
            Else
                err.SetError(CmbType, "")
            End If

            If cmbPrintLabel.SelectedItem Is Nothing Then
                err.SetError(cmbPrintLabel, "Please Select valid Label")
                cmbPrintLabel.Focus()
                Exit Sub
            Else
                err.SetError(cmbPrintLabel, "")
            End If


            'sundar UDI
            If lblStrBatch.Text = "" Then
                err.SetError(lblStrBatch, "Batch Number is Empty, Please Check")
                lblStrBatch.Focus()
                Exit Sub
            Else
                err.SetError(lblStrBatch, "")
            End If

            Dim ds As New DataSet
            ds = getOpenedSterileBatch(CmbType.Text)
            If ds.Tables(0).Rows.Count <> 0 Then
                If lblStrBatch.Text = ds.Tables(0).Rows(0)("btc_no") Then
                    If ds.Tables(0).Rows(0)("Max_Qty") < Convert.ToInt32(TextBox3.Text) + Convert.ToInt32(lblStrPrintedQty.Text) Then
                        MsgBox("Maximum Qty Reached. Please assign another sterile Batch.", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                Else
                    MsgBox("batch no mismatch", MsgBoxStyle.Critical)
                    Exit Sub

                End If

            End If


            Dim max As Integer
            Dim print As Integer
            Dim tota As Integer
            Dim to1 As Integer

            max = Convert.ToInt32(txtquantity.Text)
            print = Convert.ToInt32(TextBox1.Text)

            to1 = max + print

            If (to1 >= TextBox2.Text) Then



                If CmbShModel2.Text = "SPMFDY200" Or CmbShModel2.Text = "SPMFD200" Or CmbShModel2.Text = "SUPRAPHOB MS" Then

                    If txtcylsize.Text = "NULL" Then
                        err.SetError(txtcylsize, "This should not be null")
                        Exit Sub
                    Else
                        err.SetError(txtcylsize, "")
                    End If
                End If

                StrPrQty = txtquantity.Text
                If Val(StrPrQty) <= 0 Then
                    MsgBox("Enter Minimum 1 Qty")
                    txtquantity.Text = ""
                    txtquantity.Focus()
                    Exit Sub
                End If
                StrMaxQty = lblShowMaxQty.Text
                StrPrtedQty = LblShowPrintedQty.Text

                StrBalQty = LblBalanceQty.Text

                If Val(LblBalanceQty.Text) = 0 Then
                    If CmbType.Text = "Export-Turkey" Then
                        strsql = "Update LENS_LOT set Active='NO' where  type='Export' and Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "'"
                        cmd = New SqlCommand(strsql, con)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                        strsql = "Update LENS_LOT set Active='NO',Modified_By='" & StrLoginUser & "',Modified_Date=GETDATE() where Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "' and type='Export'"
                        cmd = New SqlCommand(strsql, con)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                        Dim IntLot As Integer

                        IntLot = Val(LblShowLotNo.Text) + 1
                        LblShowLotNo.Text = IntLot.ToString

                        strsql = "Insert into LENS_LOT (Lot_Prefix,	Lot_No,Max_Qty,Printed_Qty,	Active,	Created_By,	Created_Date,	Modified_By,	Modified_Date,Type) VALUES   ( " & _
                                "'" & LblShowLotPrefix.Text & "','" & LblShowLotNo.Text & "','" & lblShowMaxQty.Text & "',0,'YES','" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),'Export')"
                        cmd = New SqlCommand(strsql, con)
                        If con.State = Data.ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                    Else

                        strsql = "Update LENS_LOT set Active='NO' where  type='" & CmbType.Text & "' and Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "'"
                        cmd = New SqlCommand(strsql, con)
                        If con.State = Data.ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                        strsql = "Update LENS_LOT set Active='NO',Modified_By='" & StrLoginUser & "',Modified_Date=GETDATE() where Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "' and type='" & CmbType.Text & "'"
                        cmd = New SqlCommand(strsql, con)
                        If con.State = Data.ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                        Dim IntLot As Integer

                        IntLot = Val(LblShowLotNo.Text) + 1
                        LblShowLotNo.Text = IntLot.ToString

                        strsql = "Insert into LENS_LOT (Lot_Prefix,	Lot_No,Max_Qty,Printed_Qty,	Active,	Created_By,	Created_Date,	Modified_By,	Modified_Date,Type) VALUES   ( " & _
                                "'" & LblShowLotPrefix.Text & "','" & LblShowLotNo.Text & "','" & lblShowMaxQty.Text & "',0,'YES','" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),'" & CmbType.Text & "')"
                        cmd = New SqlCommand(strsql, con)
                        If con.State = Data.ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                    End If

                    StrPrQty = txtquantity.Text
                    If Val(StrPrQty) <= 0 Then
                        MsgBox("Enter Minimum 1 Qty")
                        txtquantity.Text = ""
                        txtquantity.Focus()
                        Exit Sub
                    End If
                    StrMaxQty = lblShowMaxQty.Text

                    StrStPrQty = 0
                    LblShowPrintedQty.Text = StrPrtedQty
                    StrBalQty = StrMaxQty
                    LblBalanceQty.Text = StrBalQty
                    StrPrtedQty = 0
                    LblShowPrintedQty.Text = 0
                    'StrEnPrQty = StrEnPrQty - Val(lblShowMaxQty.Text)

                    'StrStPrQty = 0

                    'StI = 0
                End If

                If Val(StrBalQty) < 0 Then

                    MsgBox("Max Qty Reached")
                    txtquantity.Text = ""
                    txtquantity.Focus()
                    Exit Sub

                End If

                StrStPrQty = StrPrtedQty + 1
                StrEnPrQty = StrPrtedQty + StrPrQty

                StrStSrNo = StrStPrQty
                StrEnSrNo = StrEnPrQty

                Stroptic1 = LblShowOptic.Text
                Strlength1 = LblShowLength.Text

                StrLot1 = LblShowLotPrefix.Text + LblShowLotNo.Text

                If CmbShModel2.Text = "AE-01" Then

                    If StrStSrNo.Length = 1 Then
                        StrSno1 = "0000" + StrStSrNo
                    ElseIf StrStSrNo.Length = 2 Then
                        StrSno1 = "000" + StrStSrNo
                    ElseIf StrStSrNo.Length = 3 Then
                        StrSno1 = "00" + StrStSrNo
                    ElseIf StrStSrNo.Length = 4 Then
                        StrSno1 = "0" + StrStSrNo

                    Else
                        StrSno1 = StrStSrNo
                    End If
                ElseIf CmbShModel2.Text = "AE-INFO" Then

                    If StrStSrNo.Length = 1 Then
                        StrSno1 = "0000" + StrStSrNo
                    ElseIf StrStSrNo.Length = 2 Then
                        StrSno1 = "000" + StrStSrNo
                    ElseIf StrStSrNo.Length = 3 Then
                        StrSno1 = "00" + StrStSrNo
                    ElseIf StrStSrNo.Length = 4 Then
                        StrSno1 = "0" + StrStSrNo

                    Else
                        StrSno1 = StrStSrNo
                    End If
                Else


                    If StrStSrNo.Length = 1 Then
                        StrSno1 = "00" + StrStSrNo
                    ElseIf StrStSrNo.Length = 2 Then
                        StrSno1 = "0" + StrStSrNo
                    Else
                        StrSno1 = StrStSrNo
                    End If

                End If
                StrLotSrNo = StrLot1 + " " + StrSno1
                StrMfDate = LblShowMfdDate.Text
                StrExDate = LblShowExpDate.Text


                Dim StrFName As String


                If CmbShModel2.Text = "SP-TORIC T3" Then
                    strpwradd = CmbShPower1.Text & " " & "D" & " " & "Adl Cyl 1.50"
                ElseIf CmbShModel2.Text = "SP-TORIC T4" Then
                    strpwradd = CmbShPower1.Text & " " & "D" & " " & "Adl Cyl 2.25"
                ElseIf CmbShModel2.Text = "SP-TORIC T5" Then
                    strpwradd = CmbShPower1.Text & " " & "D" & " " & "Adl Cyl 3.00"
                ElseIf CmbShModel2.Text = "SP-TORIC T6" Then
                    strpwradd = CmbShPower1.Text & " " & "D" & " " & "Adl Cyl 3.75"
                ElseIf CmbShModel2.Text = "SP-TORIC T7" Then
                    strpwradd = CmbShPower1.Text & " " & "D" & " " & "Adl Cyl 4.50"
                ElseIf CmbShModel2.Text = "SP-TORIC T8" Then
                    strpwradd = CmbShPower1.Text & " " & "D" & " " & "Adl Cyl 5.25"
                ElseIf CmbShModel2.Text = "SP-TORIC T9" Then
                    strpwradd = CmbShPower1.Text & " " & "D" & " " & "Adl Cyl 6.00"
                ElseIf CmbShModel2.Text = "MFD605" Then
                    strpwradd = CmbShPower1.Text & " " & "D" & " " & "Adl 3.50 D"

                ElseIf CmbShModel2.Text = "MFDY605" Then
                    strpwradd = CmbShPower1.Text & " " & "D" & " " & "Adl 3.50 D"



                ElseIf CmbShModel2.Text = "SPMFD200" Then
                    strpwradd = CmbShPower1.Text & " " & "D" & " " & "Adl" & " " & txtcylsize.Text & " " & " D"

                ElseIf CmbShModel2.Text = "SPMFDY200" Then
                    strpwradd = CmbShPower1.Text & " " & "D" & " " & "Adl" & " " & txtcylsize.Text & " " & " D"

                ElseIf CmbShModel2.Text = "SUPRAPHOB MS" Then
                    strpwradd = CmbShPower1.Text & " " & "D" & " " & "Adl" & " " & txtcylsize.Text & " " & " D"

                ElseIf CmbShModel2.Text = "SP INFO" Then
                    strpwradd = CmbShPower1.Text & " " & "D"
                    'strpwradd = CmbShPower.Text & " " & "D" & " " & "Adl" & " " & txtcylsize.Text & " " & " D"



                Else
                    strpwradd = CmbShPower1.Text
                End If



                'If (CmbShModel2.Text = "502") Or (CmbShModel2.Text = "601") Or (CmbShModel2.Text = "701") Or (CmbShModel2.Text = "nAs207") Or (CmbShModel2.Text = "NASY207") Or (CmbShModel2.Text = "701H") Then

                '    StrFName = "PouchPhilic.btw"

                'ElseIf (CmbShModel2.Text = "SPMFDY200" Or CmbShModel2.Text = "SPMFD200" Or CmbShModel2.Text = "SUPRAPHOB MS" Or CmbShModel2.Text = "SP INFO") Then

                '    StrFName = "Pouch_MFD.btw"

                'ElseIf (CmbShModel2.Text = "SP-TORIC T3" Or CmbShModel2.Text = "SP-TORIC T4" Or CmbShModel2.Text = "SP-TORIC T5" Or CmbShModel2.Text = "SP-TORIC T6" Or CmbShModel2.Text = "SP-TORIC T7" Or CmbShModel2.Text = "SP-TORIC T8" Or CmbShModel2.Text = "SP-TORIC T9") Then

                '    StrFName = "Pouch_Toric.btw"

                'ElseIf (CmbShModel2.Text = "MFD605") Then

                '    StrFName = "Pouch.btw"

                'ElseIf (CmbShModel2.Text = "MFDY605") Then

                '    StrFName = "Pouch_Toric_MFD.btw"

                '    'StrFName = "Pouch.btw"  'For Chennai 

                '    'KASTHURI Update
                'ElseIf (CmbShModel2.Text = "CENTERFIT" Or CmbShModel2.Text = "CENTERFIX" Or CmbShModel2.Text = "ULTRASMART" Or CmbShModel2.Text = "M-DIFF") Then

                '    StrFName = "Galaxyfold_Pouch.btw"

                'ElseIf CmbShModel2.Text = "AE-01" Then

                '    StrFName = "Pouch AE-01.btw"

                'ElseIf CmbShModel2.Text = "AE INFO" Then

                '    StrFName = "Pouch AE INFO.btw"
                'Else

                '    StrFName = "Pouch.btw"

                ' End If

                If RdoRef.Checked = True Then

                    strrefname1 = LblShowRefName.Text
                Else
                    strrefname1 = CmbShBrand1.Text
                End If

                For StI As Integer = StrStPrQty To StrEnPrQty

                    StrlotonlyNo = LblShowLotPrefix.Text & LblShowLotNo.Text

                    StrlotBarNo = LblShowLotPrefix.Text & LblShowLotNo.Text & " " & Format(StrStPrQty, "000")

                    'If (CmbShModel2.Text = "SPMFDY200") Or (CmbShModel2.Text = "SPMFD200") Or (CmbShModel2.Text = "SUPRAPHOB MS") Or (CmbShModel2.Text = "SP-TORIC T3" Or CmbShModel2.Text = "SP-TORIC T4" Or CmbShModel2.Text = "SP-TORIC T5" Or CmbShModel2.Text = "SP-TORIC T6" Or CmbShModel2.Text = "SP-TORIC T7" Or CmbShModel2.Text = "SP-TORIC T8" Or CmbShModel2.Text = "SP-TORIC T9" Or CmbShModel2.Text = "MFD605" Or CmbShModel2.Text = "MFDY605") Then

                    '    stroptic = LblShowOptic.Text & " " & "mm"
                    '    strlength = LblShowLength.Text & " " & "mm"
                    '    strpwr = CmbShPower1.Text & " " & "D"


                    '    btFile = Application.StartupPath & "\" & StrFName & ""

                    '    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)


                    '    bt.SetNamedSubStringValue("Ref", CmbShModel2.Text)
                    '    bt.SetNamedSubStringValue("Pwr", strpwr)
                    '    'bt.SetNamedSubStringValue("Brandname", strrefname1)
                    '    'bt.SetNamedSubStringValue("SNo", StrlotBarNo)
                    '    bt.SetNamedSubStringValue("LotNo", StrlotBarNo)
                    '    bt.SetNamedSubStringValue("optic", stroptic)
                    '    bt.SetNamedSubStringValue("Length", strlength)
                    '    'bt.SetNamedSubStringValue("Expdate", LblShowExpDate.Text)
                    '    'bt.SetNamedSubStringValue("mfddate", LblShowMfdDate.Text)

                    '    bt.PrintOut()

                    '    bt.Close()

                    '    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                    'ElseIf (CmbShModel2.Text = "CENTERFIT" Or CmbShModel2.Text = "CENTERFIX" Or CmbShModel2.Text = "ULTRASMART" Or CmbShModel2.Text = "M-DIFF") Then

                    '    'StrlotonlyNo = LblShowLotPrefix.Text & LblShowLotNo.Text

                    '    StrlotBarNo = LblShowLotPrefix.Text & LblShowLotNo.Text & Format(StrStPrQty, "00000")

                    '    stroptic = LblShowOptic.Text & " " & "mm"
                    '    strlength = LblShowLength.Text & " " & "mm"
                    '    strpwr = CmbShPower1.Text & " " & "D"


                    '    'stroptic = LblShowOptic.Text
                    '    'strlength = LblShowLength.Text
                    '    'strpwr = CmbShPower1.Text

                    '    btFile = Application.StartupPath & "\" & StrFName & ""

                    '    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)


                    '    bt.SetNamedSubStringValue("Ref", CmbShModel2.Text)
                    '    bt.SetNamedSubStringValue("Pwr", strpwr)
                    '    bt.SetNamedSubStringValue("Brandname", strrefname1)
                    '    bt.SetNamedSubStringValue("LotNo", StrlotBarNo)
                    '    bt.SetNamedSubStringValue("LotNo", StrlotBarNo)
                    '    bt.SetNamedSubStringValue("optic", stroptic)
                    '    bt.SetNamedSubStringValue("Length", strlength)
                    '    bt.SetNamedSubStringValue("Expdate", LblShowExpDate.Text)
                    '    bt.SetNamedSubStringValue("mfddate", LblShowMfdDate.Text)

                    '    bt.PrintOut()

                    '    bt.Close()

                    '    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                    'ElseIf CmbShModel2.Text = "AE-01" Then

                    '    StrlotBarNo = LblShowLotPrefix.Text & LblShowLotNo.Text & Format(StrStPrQty, "00000")

                    '    stroptic = LblShowOptic.Text & " " & "mm"
                    '    strlength = LblShowLength.Text & " " & "mm"
                    '    strpwr = CmbShPower1.Text & " " & "D"



                    '    'stroptic = LblShowOptic.Text
                    '    'strlength = LblShowLength.Text
                    '    'strpwr = CmbShPower1.Text

                    '    btFile = Application.StartupPath & "\" & StrFName & ""

                    '    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)


                    '    bt.SetNamedSubStringValue("Ref", CmbShModel2.Text)
                    '    bt.SetNamedSubStringValue("Pwr", strpwr)
                    '    bt.SetNamedSubStringValue("Brandname", CmbShBrand1.Text)
                    '    bt.SetNamedSubStringValue("SNo", StrlotBarNo)

                    '    bt.SetNamedSubStringValue("LotNo", StrlotBarNo)
                    '    bt.SetNamedSubStringValue("optic", stroptic)
                    '    bt.SetNamedSubStringValue("Length", strlength)
                    '    bt.SetNamedSubStringValue("Expdate", strexpsupdate)
                    '    bt.SetNamedSubStringValue("mfddate", strmfdsupdate)


                    '    bt.PrintOut()

                    '    bt.Close()
                    '    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                    'ElseIf CmbShModel2.Text = "AE INFO" Then

                    '    StrlotBarNo = LblShowLotPrefix.Text & LblShowLotNo.Text & Format(StrStPrQty, "00000")

                    '    stroptic = LblShowOptic.Text & " " & "mm"
                    '    strlength = LblShowLength.Text & " " & "mm"
                    '    strpwr = CmbShPower1.Text & " " & "D"


                    'stroptic = LblShowOptic.Text
                    'strlength = LblShowLength.Text
                    'strpwr = CmbShPower1.Text


                    'btFile = Application.StartupPath & "\" & StrFName & ""

                    'bt = bApp.Formats.Open(btFile, , DefaultPrinterName)


                    'bt.SetNamedSubStringValue("Ref", CmbShModel2.Text)
                    'bt.SetNamedSubStringValue("Pwr", strpwr)
                    'bt.SetNamedSubStringValue("Brandname", CmbShBrand1.Text)
                    'bt.SetNamedSubStringValue("SNo", StrlotBarNo)

                    'bt.SetNamedSubStringValue("LotNo", StrlotBarNo)
                    'bt.SetNamedSubStringValue("optic", stroptic)
                    'bt.SetNamedSubStringValue("Length", strlength)
                    'bt.SetNamedSubStringValue("Expdate", strexpsupdate)
                    'bt.SetNamedSubStringValue("mfddate", strmfdsupdate)


                    'bt.PrintOut()

                    'bt.Close()
                    'System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                    'Else


                    'stroptic = LblShowOptic.Text & " " & "mm"
                    'strlength = LblShowLength.Text & " " & "mm"
                    'strpwr = CmbShPower1.Text & " " & "D"

                    Dim steirli As String
                    Dim nameaddre As String
                    Dim licenc As String
                    Dim temp As String
                    Dim mrp As String


                    StrFName = BTWFileName()

                    If StrFName = "" Then
                        MessageBox.Show("BTW file record not found")
                        Exit Sub
                    End If


                    strsql = "SELECT * from LENS_MASTER where Model_Name='" & CmbShModel2.Text & "' and POWER='" & CmbShPower1.Text & "' and Type_GS_Code='" & CmbShType.Text & "' and Brand_Name='" & CmbShBrand1.Text & "' "
                    cmd = New SqlCommand(strsql, con)
                    If con.State = Data.ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    StrRs = cmd.ExecuteReader

                    If StrRs.Read Then

                        steirli = IIf(IsDBNull(StrRs.GetValue(22)), "", StrRs.GetValue(22))
                        nameaddre = IIf(IsDBNull(StrRs.GetValue(20)), "", StrRs.GetValue(20))
                        licenc = IIf(IsDBNull(StrRs.GetValue(19)), "", StrRs.GetValue(19))
                        temp = IIf(IsDBNull(StrRs.GetValue(21)), "", StrRs.GetValue(21))
                        mrp = IIf(IsDBNull(StrRs.GetValue(17)), "", StrRs.GetValue(17))

                    End If
                    StrRs.Close()




                    Dim Twodbar As String

                    Twodbar = CmbShBrand1.Text + "," + CmbShModel2.Text + "," + CmbShPower1.Text + "," + steirli + "," + StrlotBarNo + "," + LblShowMfdDate.Text + "," + LblShowExpDate.Text + "," + mrp + "," + licenc + "," + nameaddre + "," + temp


                    stroptic = LblShowOptic.Text & " " & "mm"
                    strlength = LblShowLength.Text & " " & "mm"
                    strpwr = CmbShPower1.Text & " " & "D"

                    'sundar Udi
                    Dim StrEanCode As String
                    StrEanCode = LblShowGSCode.Text.Remove(LblShowGSCode.Text.Length - 1, 1)

                    Dim strbtc As String = lblStrBatch.Text
                    Dim strbtcexpiry As String = strexyear.Substring(2, 2)
                    StrInexp1 = strbtcexpiry & strexmonth & "00"
                    Dim strbtcmfd As String = strmfyear.Substring(2, 2)
                    StrInmfd = strbtcmfd & strmfmonth & "00"

                    If CmbType.Text <> "Argentina" Then
                        StrlotBarNo = StrlotBarNo.Replace(" ", "")
                    End If


                    'If (CmbShModel2.Text = "502") Or (CmbShModel2.Text = "601") Or (CmbShModel2.Text = "701") Or (CmbShModel2.Text = "nAs207") Or (CmbShModel2.Text = "NASY207") Or (CmbShModel2.Text = "701H") Then

                    'StrFName = "PHILICCASE.btw"


                    btFile = Application.StartupPath & "\" & StrFName & ""
                    If System.IO.File.Exists(btFile) Then
                        'The file exists
                    Else
                        MessageBox.Show("BTW file record not found")
                        Exit Sub
                    End If

                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)

                    bt.SetNamedSubStringValue("LotNo", StrlotBarNo)
                    bt.SetNamedSubStringValue("Pwr", strpwr)
                    bt.SetNamedSubStringValue("Ref", CmbShModel2.Text)
                    bt.SetNamedSubStringValue("Expdate", LblShowExpDate.Text)
                    bt.SetNamedSubStringValue("mfddate", LblShowMfdDate.Text)
                    bt.SetNamedSubStringValue("Twodbar", Twodbar)
                    bt.SetNamedSubStringValue("Brandname", strrefname1)

                    bt.SetNamedSubStringValue("EanCode", StrEanCode)
                    bt.SetNamedSubStringValue("Btc", strbtc)
                    bt.SetNamedSubStringValue("mfdtwod", StrInmfd)
                    bt.SetNamedSubStringValue("exptwod", StrInexp1)

                    bt.SetNamedSubStringValue("optic", stroptic)
                    bt.SetNamedSubStringValue("Length", strlength)

                    'bt.SetNamedSubStringValue("lotSerial", StrlotBarNo)


                    bt.PrintOut()

                    bt.Close()

                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                    'End If
                    Dim udi_code As String = "01" & LblShowGSCode.Text & "10" & lblStrBatch.Text & "11" & StrInmfd & "17" & StrInexp1 & "21" & StrlotBarNo

                    If rdobrand.Checked = True Then
                        strsql = " insert into POUCH_LABEL (Brand_Name,Model_Name,Reference_Name,GS_Code,Power,Optic,Length,Lot_Unit," & _
                                 "A_Constant,Type_GS_Code,Qty,St_SrNo,St_EnNo,Lot_Prefix,Lot_No,Lot_SrNo,Mfd_Month,Mfd_Year,Exp_Month,Exp_Year,Sterilization, " & _
                                 "Sample_Taken,Type_Sample,BPL_Taken,Box_Packing,Dc_Packing,Created_By,Created_Date,Modified_By,Modified_Date,Sterilization_Reject,Qty_1,Type,Sterilization_After,Box_Reject,Print_Name,Btc_No,Cylsize,RefLot,PouchStation,PouchBTWLabelName, Udi_code,Pouch_Order_Type, Pouch_Order_Country ) values ( " & _
                                 "'" & CmbShBrand1.Text & "','" & CmbShModel2.Text & "','" & LblShowRefName.Text & "','" & LblShowGSCode.Text & "','" & CmbShPower1.Text & "','" & LblShowOptic.Text & "','" & LblShowLength.Text & "' ," & _
                                 "'mm','" & LblshAConstant.Text & "','" & LblShowGSType.Text & "','" & txtquantity.Text & "','" & StrStPrQty & "','" & StrEnPrQty & "','" & LblShowLotPrefix.Text & "','" & LblShowLotNo.Text & "','" & StrlotBarNo & "' , " & _
                                 "'" & strmfmonth & "','" & strmfyear & "','" & strexmonth & "','" & strexyear & "',0,0,'NO',0,0,0,'" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),0,1,'" & CmbType.Text & "',0,0,'" & CmbShBrand1.Text & "','" & lblStrBatch.Text & "','" & txtcylsize.Text & "','" & ComboBox1.Text & "','" & station & "','" & cmbPrintLabel.Text & "', '" & udi_code & "','" & cmb_Order_Type.Text & "','" & cmb_Order_Country.Text & "' )"

                        cmd = New SqlCommand(strsql, con)
                        If con.State = Data.ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                    Else
                        strsql = " insert into POUCH_LABEL (Brand_Name,Model_Name,Reference_Name,GS_Code,Power,Optic,Length,Lot_Unit," & _
                                 "A_Constant,Type_GS_Code,Qty,St_SrNo,St_EnNo,Lot_Prefix,Lot_No,Lot_SrNo,Mfd_Month,Mfd_Year,Exp_Month,Exp_Year,Sterilization, " & _
                                 "Sample_Taken,Type_Sample,BPL_Taken,Box_Packing,Dc_Packing,Created_By,Created_Date,Modified_By,Modified_Date,Sterilization_Reject,Qty_1,Type,Sterilization_After,Box_Reject,Print_Name,Btc_No,Cylsize,RefLot,PouchStation,PouchBTWLabelName, Udi_code,Pouch_Order_Type, Pouch_Order_Country ) values ( " & _
                                 "'" & CmbShBrand1.Text & "','" & CmbShModel2.Text & "','" & LblShowRefName.Text & "','" & LblShowGSCode.Text & "','" & CmbShPower1.Text & "','" & LblShowOptic.Text & "','" & LblShowLength.Text & "' ," & _
                                 "'mm','" & LblshAConstant.Text & "','" & LblShowGSType.Text & "','" & txtquantity.Text & "','" & StrStPrQty & "','" & StrEnPrQty & "','" & LblShowLotPrefix.Text & "','" & LblShowLotNo.Text & "','" & StrlotBarNo & "' , " & _
                                 "'" & strmfmonth & "','" & strmfyear & "','" & strexmonth & "','" & strexyear & "',0,0,'NO',0,0,0,'" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),0,1,'" & CmbType.Text & "',0,0,'" & LblShowRefName.Text & "','" & lblStrBatch.Text & "','" & txtcylsize.Text & "','" & ComboBox1.Text & "','" & station & "','" & cmbPrintLabel.Text & "', '" & udi_code & "','" & cmb_Order_Type.Text & "','" & cmb_Order_Country.Text & "'  )"

                        cmd = New SqlCommand(strsql, con)
                        If con.State = Data.ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()

                    End If


                    If CmbType.Text = "Export-Turkey" Then
                        strsql = "Update LENS_LOT set Printed_Qty='" & StrStPrQty & "' where Active='YES' and type='Export' and Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "'"
                        cmd = New SqlCommand(strsql, con)
                        If con.State = Data.ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                    Else
                        strsql = "Update LENS_LOT set Printed_Qty='" & StrStPrQty & "' where Active='YES' and type='" & CmbType.Text & "' and Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "'"
                        cmd = New SqlCommand(strsql, con)
                        If con.State = Data.ConnectionState.Open Then
                            con.Close()
                        End If
                        con.Open()
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                    End If


                    LblShowPrintedQty.Text = StrStPrQty
                    LblBalanceQty.Text = Val(lblShowMaxQty.Text) - StrStPrQty

                    'sundar UDI
                    lblStrPrintedQty.Text = lblStrPrintedQty.Text + 1
                    PrintedQtyUpdate(lblStrPrintedQty.Text, CmbType.Text)


                    If Val(StrStPrQty) = TextBox2.Text Then

                        If CmbType.Text = "Export-Turkey" Then

                            strsql = "Update LENS_LOT set Active='NO' where  type='Export' and Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "'"
                            cmd = New SqlCommand(strsql, con)
                            If con.State = Data.ConnectionState.Open Then
                                con.Close()
                            End If
                            con.Open()
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()

                            strsql = "Update LENS_LOT set Active='NO',Modified_By='" & StrLoginUser & "',Modified_Date=GETDATE() where Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "' and type='Export'"
                            cmd = New SqlCommand(strsql, con)
                            If con.State = Data.ConnectionState.Open Then
                                con.Close()
                            End If
                            con.Open()
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()

                            Dim IntLot As Integer
                            Dim stringlotno As String

                            IntLot = Val(LblShowLotNo.Text) + 1

                            stringlotno = IntLot.ToString("0000")

                            LblShowLotNo.Text = stringlotno

                            'LblShowLotNo.Text = String.Format(stringlotno, "000")

                            strsql = "Insert into LENS_LOT (Lot_Prefix,	Lot_No,Max_Qty,Printed_Qty,	Active,	Created_By,	Created_Date,	Modified_By,	Modified_Date,Type) VALUES   ( " & _
                                    "'" & LblShowLotPrefix.Text & "','" & LblShowLotNo.Text & "','" & lblShowMaxQty.Text & "',0,'YES','" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),'Export')"
                            cmd = New SqlCommand(strsql, con)
                            If con.State = Data.ConnectionState.Open Then
                                con.Close()
                            End If
                            con.Open()
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()

                        Else

                            strsql = "Update LENS_LOT set Active='NO' where  type='" & CmbType.Text & "' and Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "'"
                            cmd = New SqlCommand(strsql, con)
                            If con.State = Data.ConnectionState.Open Then
                                con.Close()
                            End If
                            con.Open()
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()

                            strsql = "Update LENS_LOT set Active='NO',Modified_By='" & StrLoginUser & "',Modified_Date=GETDATE() where Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "' and type='" & CmbType.Text & "'"
                            cmd = New SqlCommand(strsql, con)
                            If con.State = Data.ConnectionState.Open Then
                                con.Close()
                            End If
                            con.Open()
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()

                            Dim IntLot As Integer
                            Dim stringlotno As String

                            IntLot = Val(LblShowLotNo.Text) + 1

                            stringlotno = IntLot.ToString("0000")
                            LblShowLotNo.Text = stringlotno

                            'LblShowLotNo.Text = String.Format(stringlotno, "000")

                            strsql = "Insert into LENS_LOT (Lot_Prefix,	Lot_No,Max_Qty,Printed_Qty,	Active,	Created_By,	Created_Date,	Modified_By,	Modified_Date,Type) VALUES   ( " & _
                                    "'" & LblShowLotPrefix.Text & "','" & LblShowLotNo.Text & "','" & lblShowMaxQty.Text & "',0,'YES','" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),'" & CmbType.Text & "')"
                            cmd = New SqlCommand(strsql, con)
                            If con.State = Data.ConnectionState.Open Then
                                con.Close()
                            End If
                            con.Open()
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()

                        End If

                        StrEnPrQty = StrEnPrQty - Val(lblShowMaxQty.Text)

                        StrStPrQty = 0


                        StrBalQty = StrMaxQty
                        LblBalanceQty.Text = StrBalQty
                        StrPrtedQty = 0
                        LblShowPrintedQty.Text = 0

                        'StI = 0
                    End If

                    StrStPrQty = Val(StrStPrQty) + 1

                Next


                ''sundar UDI
                'Dim ds As New DataSet
                'ds = getOpenedSterileBatch(CmbType.Text)
                'If ds.Tables(0).Rows.Count <> 0 Then
                '    lblStrBatch.Text = ds.Tables(0).Rows(0)("btc_no")
                '    lblStrPrintedQty.Text = Convert.ToInt32(ds.Tables(0).Rows(0)("Printed_Qty")) + Convert.ToInt32(LblShowPrintedQty.Text)
                'Else
                '    MsgBox("No Data Found", MsgBoxStyle.Critical)
                '    Exit Sub
                'End If
                'PrintedQtyUpdate(lblStrPrintedQty.Text, CmbType.Text)


                If Val(LblBalanceQty.Text) = 0 Then

                    strsql = "Update LENS_LOT set Active='NO' where  type='" & CmbType.Text & "' and Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "'"
                    cmd = New SqlCommand(strsql, con)
                    If con.State = Data.ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    strsql = "Update LENS_LOT set Active='NO',Modified_By='" & StrLoginUser & "',Modified_Date=GETDATE() where Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "' and type='" & CmbType.Text & "'"
                    cmd = New SqlCommand(strsql, con)
                    If con.State = Data.ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    Dim IntLot As String

                    IntLot = Val(LblShowLotNo.Text) + 1


                    If IntLot.ToString.Length = 1 Then
                        IntLot = "00" & IntLot
                    ElseIf IntLot.ToString.Length = 2 Then
                        IntLot = "0" & IntLot
                    ElseIf IntLot.ToString.Length = 2 Then



                        IntLot = IntLot



                    End If

                    'LblShowLotNo.Text
                    'IntLot = Format(IntLot, "000")
                    LblShowLotNo.Text = IntLot.ToString

                    'LblShowLotNo.Text = Format(LblShowLotNo.Text, "000")

                    strsql = "Insert into LENS_LOT (Lot_Prefix,	Lot_No,Max_Qty,Printed_Qty,	Active,	Created_By,	Created_Date,	Modified_By,	Modified_Date,Type) VALUES   ( " & _
                            "'" & LblShowLotPrefix.Text & "','" & LblShowLotNo.Text & "','" & lblShowMaxQty.Text & "',0,'YES','" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),'" & CmbType.Text & "')"
                    cmd = New SqlCommand(strsql, con)
                    If con.State = Data.ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    StrEnPrQty = StrEnPrQty - Val(lblShowMaxQty.Text)
                    StrStPrQty = 0

                    StrBalQty = StrMaxQty
                    LblBalanceQty.Text = StrBalQty
                    StrPrtedQty = 0
                    LblShowPrintedQty.Text = 0



                    'StI = 0
                End If

                StrStPrQty = Val(StrStPrQty) + 1
                StrTo = StrTo + 1


                'conString1 = ConfigurationSettings.AppSettings("conStr").ToString()
                'con = New SqlConnection(conString1)
                'Try
                '    con.Open()
                'Catch ex As Exception
                '    MsgBox(ex.Message)
                'End Try
                If con.State = Data.ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                strsql = ("SELECT Sum(Qty_1) as TotQty from POUCH_LABEL where RefLot = '" + ComboBox1.Text + "' and  Power ='" + CmbShPower1.Text + "' ")
                cmd = New SqlCommand(strsql, con)
                StrRs = cmd.ExecuteReader
                If StrRs.Read Then
                    TextBox1.Text = IIf(IsDBNull(StrRs.GetValue(0)), "0", StrRs.GetValue(0))
                Else
                    TextBox1.Text = 0
                End If
                StrRs.Close()
                cmd.Dispose()


                If (TextBox2.Text = to1) Then

                    Dim conString1 As String = ConfigurationSettings.AppSettings("conStrPhilic_ERP").ToString()
                    Dim con1 As SqlConnection
                    con1 = New SqlConnection(conString1)

                    Try
                        con1.Open()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    strsql = "Update MinFQI set Flag='2' where TumblingNo='" & ComboBox1.Text & "' and Power ='" & CmbShPower1.Text & "' "
                    cmd = New SqlCommand(strsql, con1)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()

                    If con1.State = Data.ConnectionState.Open Then
                        con1.Close()
                    End If

                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    TextBox3.Text = ""


                End If


                clear()
            Else
                MsgBox("Greater then Accepted Qty")
            End If

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
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtcrMaxQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtquantity.TextChanged

    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        clear()
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
        Menulblmstdatacre.LblHomeMenuDisplyName.Visible = False
        Menulblmstdatacre.TimHomeSideDisply.Start()
        'RawPrinterHelper.SendFileToPrinter(DefaultPrinterName, Application.StartupPath & "\write.prn")
    End Sub


    Private Sub CmbShPower_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CmbShPower1.Text <> "" Then
            strsql = "SELECT DISTINCT Brand_Name from LENS_MASTER where Model_Name='" & CmbShModel2.Text & "' and POWER='" & CmbShPower1.Text & "' order by Brand_Name"
            cmd = New SqlCommand(strsql, con)
            If con.State = Data.ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            StrRs = cmd.ExecuteReader

            'CmbShBrand1.Items.Clear()
            CmbShType.Items.Clear()

            CmbShBrand1.Text = ""
            CmbShType.Text = ""
            While StrRs.Read
                'CmbShBrand1.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
            End While
            StrRs.Close()
            cmd.Dispose()
        End If
    End Sub

    Private Sub CmbShType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbShType.SelectedIndexChanged
        If CmbShType.Text <> "" Then
            strsql = "SELECT * from LENS_MASTER where Model_Name='" & CmbShModel2.Text & "' and POWER='" & CmbShPower1.Text & "' and Type_GS_Code='" & CmbShType.Text & "' and Brand_Name='" & CmbShBrand1.Text & "' "
            cmd = New SqlCommand(strsql, con)
            StrRs = cmd.ExecuteReader

            If StrRs.Read Then

                LblShowGSCode.Text = IIf(IsDBNull(StrRs.GetValue(5)), "", StrRs.GetValue(5))
                LblShowPower.Text = Format(IIf(IsDBNull(StrRs.GetValue(6)), 0, StrRs.GetValue(6)), "0.00")
                LblShowRefName.Text = IIf(IsDBNull(StrRs.GetValue(4)), "", StrRs.GetValue(4))
                LblShowOptic.Text = Format(IIf(IsDBNull(StrRs.GetValue(7)), "", StrRs.GetValue(7)), "0.00")
                LblShowLength.Text = Format(IIf(IsDBNull(StrRs.GetValue(8)), "", StrRs.GetValue(8)), "0.00")
                LblShowGSType.Text = IIf(IsDBNull(StrRs.GetValue(11)), "", StrRs.GetValue(11))
                LblshAConstant.Text = Format(IIf(IsDBNull(StrRs.GetValue(10)), 0, StrRs.GetValue(10)), "0.00")
                IntTotExp = IIf(IsDBNull(StrRs.GetValue(12)), 0, StrRs.GetValue(12))

                'For 3 Year Expiry
                If CmbType.Text = "" Then
                    err.SetError(CmbType, "This information is required")
                    CmbType.Focus()
                    Exit Sub
                Else
                    err.SetError(CmbShModel2, "")
                End If

                If CmbType.Text = "3_Years" Then
                    IntTotExp = 3
                End If
                'For 3 Year Expiry


                StrMfdMonth = Now.Month
                strmfmonth = StrMfdMonth.ToString("00")

                StrMfdYear = Now.Year
                strmfyear = StrMfdYear.ToString("0000")

                StrExpMonth = StrMfdMonth - 1
                strexmonth = StrExpMonth.ToString("00")

                StrExpYear = StrMfdYear + IntTotExp
                strexyear = StrExpYear.ToString("0000")

                If StrExpMonth = 0 Then
                    strexmonth = (12).ToString("00")
                    strexyear = (StrExpYear - 1).ToString("0000")
                End If

                LblShowMfdDate.Text = strmfyear & "-" & strmfmonth
                LblShowExpDate.Text = strexyear & "-" & strexmonth

            Else
                MsgBox("No Data Found", MsgBoxStyle.Critical)
                Exit Sub
            End If
            StrRs.Close()
            cmd.Dispose()
        End If
    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pnl.Enter

    End Sub
    Public Function getOpenedSterileBatch(ByVal pck_type As String) As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = "select btc_no,Max_Qty,Printed_Qty  from LENS_BATCH where Active='YES' and type='" & pck_type & "'"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function
    Public Sub PrintedQtyUpdate(ByVal Printed_Qty As String, ByVal pck_type As String)
        Dim strsql As String
        strsql = " update LENS_BATCH set Printed_Qty = '" & Printed_Qty & "' where Active='YES' and type='" & pck_type & "' and  btc_no='" & lblStrBatch.Text & "' "
        Dim cmd As New SqlCommand(strsql, con)
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd.ExecuteNonQuery()
        cmd.Dispose()

    End Sub

    Private Sub CmbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbType.SelectedIndexChanged

        If CmbType.Text <> "" Then

            CmbShPower1.Text = ""
            CmbShType.Text = ""
            'sundar UDI
            Dim ds As New DataSet
            ds = getOpenedSterileBatch(CmbType.Text)
            If ds.Tables(0).Rows.Count <> 0 Then
                lblStrBatch.Text = ds.Tables(0).Rows(0)("btc_no")
                lblStrPrintedQty.Text = ds.Tables(0).Rows(0)("Printed_Qty")
            Else
                MsgBox("No sterile batch open. please check", MsgBoxStyle.Critical)
                Exit Sub
            End If


            If CmbType.Text = "Export-Turkey" Then
                strsql = "select Lot_Prefix,Lot_No,Max_Qty,Printed_Qty,(Max_Qty-Printed_Qty) as Balance_Qty,Active from LENS_LOT where Active='YES' and type='Export'"
                cmd = New SqlCommand(strsql, con)
                StrRs = cmd.ExecuteReader
            Else
                strsql = "select Lot_Prefix,Lot_No,Max_Qty,Printed_Qty,(Max_Qty-Printed_Qty) as Balance_Qty,Active from LENS_LOT where Active='YES' and type='" & CmbType.Text & "'"
                cmd = New SqlCommand(strsql, con)
                StrRs = cmd.ExecuteReader
            End If

            If StrRs.Read Then
                LblShowLotPrefix.Text = IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0))

                LblShowLotNo.Text = IIf(IsDBNull(StrRs.GetValue(1)), "", StrRs.GetValue(1))

                lblShowMaxQty.Text = IIf(IsDBNull(StrRs.GetValue(2)), "", StrRs.GetValue(2))
                LblShowPrintedQty.Text = IIf(IsDBNull(StrRs.GetValue(3)), "", StrRs.GetValue(3))
                LblBalanceQty.Text = IIf(IsDBNull(StrRs.GetValue(4)), "", StrRs.GetValue(4))
                CmbShModel2.Focus()

            Else
                LblShowLotPrefix.Text = ""
                LblShowLotNo.Text = ""

                lblShowMaxQty.Text = 0
                LblShowPrintedQty.Text = 0
                LblBalanceQty.Text = 0
            End If
            StrRs.Close()
            cmd.Dispose()




        End If
    End Sub

    Private Sub clear()

        CmbShBrand1.Text = ""
        CmbShModel2.Text = ""
        CmbShPower1.Text = ""
        CmbShType.Text = ""
        txtquantity.Text = ""
        LblshAConstant.Text = ""
        LblShowExpDate.Text = ""
        LblShowOptic.Text = ""
        LblShowGSCode.Text = ""
        LblShowLength.Text = ""
        LblShowPower.Text = ""
        LblShowRefName.Text = ""
        LblShowGSType.Text = ""
        ComboBox1.Text = ""
        LblShowMfdDate.Text = ""
        cmb_Order_Type.Text = ""
        cmb_Order_Country.Text = ""




    End Sub




    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        CmbShPower1.Text = ""
        CmbShType.Text = ""

        Dim conString1 As String = ConfigurationSettings.AppSettings("conStrPHILIC_ERP").ToString()
        Dim con1 As SqlConnection
        con1 = New SqlConnection(conString1)
        Try
            con1.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        strsql = ("SELECT  distinct Power from MinFQI where TumblingNo ='" + ComboBox1.Text + "' and Flag = 1 and AcceptedQty <> 0 ")
        cmd = New SqlCommand(strsql, con1)
        If con1.State = Data.ConnectionState.Open Then
            con1.Close()
        End If
        con1.Open()
        StrRs = cmd.ExecuteReader
        CmbShPower1.Items.Clear()
        While StrRs.Read
            CmbShPower1.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        cmd.Dispose()

        strsql = ("SELECT  distinct Product_Description  from work_In__Progress1  where LotNo = '" & ComboBox1.Text & "' ")
        cmd = New SqlCommand(strsql, con1)
        If con1.State = Data.ConnectionState.Open Then
            con1.Close()
        End If
        con1.Open()
        StrRs = cmd.ExecuteReader
        'ComboBox2.Items.Clear()
        While StrRs.Read
            TextBox4.Text = (IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
            Dim s As String = TextBox4.Text
            Dim word As String() = s.Split(New Char() {"/"c})
            CmbShModel2.Text = word(1)
            'CmbShPower1.Text = word(3)
            CmbShBrand1.Text = word(0)
        End While
        StrRs.Close()
        cmd.Dispose()

        ' conString1 = ConfigurationSettings.AppSettings("ConStr1").ToString()
        ' con = New SqlConnection(conString1)
        'Try
        '    con1.Open()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        strsql = ("SELECT sum(AcceptedQty) as qty from MinFQI where TumblingNo = '" + ComboBox1.Text + "' ")
        cmd = New SqlCommand(strsql, con1)
        If con1.State = Data.ConnectionState.Open Then
            con1.Close()
        End If
        con1.Open()
        StrRs = cmd.ExecuteReader
        If StrRs.Read Then
            TextBox3.Text = IIf(IsDBNull(StrRs.GetValue(0)), "0", StrRs.GetValue(0))
        Else
            TextBox3.Text = 0
        End If

        StrRs.Close()
        cmd.Dispose()


    End Sub

    Private Sub CmbShPower1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbShPower1.SelectedIndexChanged
        CmbShType.Text = ""



        'conString1 = ConfigurationSettings.AppSettings("conStr").ToString()
        'con = New SqlConnection(conString1)
        'Try
        '    con.Open()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        strsql = ("SELECT Sum(Qty_1) as TotQty from POUCH_LABEL where RefLot = '" + ComboBox1.Text + "' and  Power ='" + CmbShPower1.Text + "' ")
        cmd = New SqlCommand(strsql, con)
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        StrRs = cmd.ExecuteReader
        If StrRs.Read Then
            TextBox1.Text = IIf(IsDBNull(StrRs.GetValue(0)), "0", StrRs.GetValue(0))
        Else
            TextBox1.Text = 0
        End If
        StrRs.Close()
        cmd.Dispose()


        'conString1 = ConfigurationSettings.AppSettings("ConStr1").ToString()
        'con = New SqlConnection(conString1)
        Dim conString1 As String = ConfigurationSettings.AppSettings("conStrPHILIC_ERP").ToString()
        Dim con1 As SqlConnection
        con1 = New SqlConnection(conString1)

        Try
            con1.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        strsql = ("SELECT sum(AcceptedQty) as qty from MinFQI where TumblingNo = '" + ComboBox1.Text + "' and Power ='" + CmbShPower1.Text + "' ")
        cmd = New SqlCommand(strsql, con1)
        If con1.State = Data.ConnectionState.Open Then
            con1.Close()
        End If
        con1.Open()
        StrRs = cmd.ExecuteReader
        If StrRs.Read Then
            TextBox2.Text = IIf(IsDBNull(StrRs.GetValue(0)), "0", StrRs.GetValue(0))
        Else
            TextBox2.Text = 0
        End If

        StrRs.Close()
        cmd.Dispose()


        TextBox2.Text = TextBox2.Text - TextBox1.Text

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        strsql = ("SELECT  distinct TumblingNo from MinFQI where Flag = 1")
        cmd = New SqlCommand(strsql, con)
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        StrRs = cmd.ExecuteReader
        ComboBox1.Items.Clear()
        While StrRs.Read
            ComboBox1.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        cmd.Dispose()


    End Sub

    Public Function SQL_SelectQuery_Execute(ByVal StrSql As String) As DataSet

        Dim ds As New DataSet
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Private Sub cmb_Order_Type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Order_Type.SelectedIndexChanged

        cmb_Order_Country.Text = ""
        strsql = "SELECT DISTINCT Order_Country from Pouch_Order_Country_Master  Where Order_Type='" & cmb_Order_Type.Text & "' order by Order_Country"
        Ds = SQL_SelectQuery_Execute(strsql)
        cmb_Order_Country.Items.Clear()
        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            cmb_Order_Country.Items.Add(eachRow1("Order_Country"))
        Next

    End Sub
End Class