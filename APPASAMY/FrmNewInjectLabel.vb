Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft
Imports System.Data.Sql
Imports System.Configuration




Public Class FrmNewInjectLabel

    Dim bApp As New BarTender.Application
    Dim bt As New BarTender.Format
    Dim btFile As String
    Dim bApp1 As New BarTender.Application
    Dim bt1 As New BarTender.Format
    Dim btFile1 As String
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
    Dim IntLotNo, count As Integer
    Dim StrLotSrNo As String
    Dim StrB As String
    Dim StrT As String
    Dim StrExDate As String
    Dim StrMfDate As String
    Dim StrPower As String
    Dim StrlotBarNo As String
    Dim StrlotBarNo2 As String
    Dim cmd1 As SqlCommand
    Dim read1, Dr As SqlDataReader

    Dim sql1 As String
    Dim injector_Ref As String
    Private Sub LabelNameBind()
        Dim ds As New DataSet()
        StrSql = "select distinct LabelName from BTW_Master where Department = 'Injector'"
        Dim cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)

        cmbPrintLabel.DisplayMember = "LabelName"
        cmbPrintLabel.DataSource = ds.Tables(0)
    End Sub

    Private Sub FrmNewInjectLabel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If

        LabelNameBind()

        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Type Load
        StrSql = "SELECT DISTINCT Type FROM         Lot_Type WHERE     (Type IN ('Injet', 'Export-Injet')) ORDER BY Type"
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        CmbType.Items.Clear()
        While StrRs.Read
            CmbType.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        Cmd.Dispose()

        'Model Load
        StrSql = "SELECT DISTINCT Type FROM         Injector_Model  ORDER BY Type"
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        CmbShModel.Items.Clear()
        While StrRs.Read
            CmbShModel.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        Cmd.Dispose()

    End Sub
    Private Function BTWFileName() As String
        Dim ds As New DataSet()
        StrSql = "select * from BTW_Master where Department = 'Injector' and ModelNo = '" & lblModel.Text & "' and LabelName = '" & cmbPrintLabel.Text & "' "
        Dim cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)
        If ds.Tables(0).Rows.Count <> 0 Then
            Return ds.Tables(0).Rows(0)("FileName")
        Else
            Return ""
        End If
    End Function

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim StrMdf, strmfmonth, strmfyear, StrInmfd As String
        Dim StrExp, strexmonth, strexyear, StrInexp1 As String
        Dim StrFName As String


        Try

            If cmbPrintLabel.SelectedItem Is Nothing Then
                err.SetError(cmbPrintLabel, "Please Select valid Label")
                cmbPrintLabel.Focus()
                Exit Sub
            Else
                err.SetError(cmbPrintLabel, "")
            End If


            If lblGsCode.Text = "" Or lblGsCode.Text = "GS_Code" Then
                err.SetError(lblGsCode, "This information is required")
                Exit Sub
            Else
                err.SetError(lblGsCode, "")
            End If
            If lblMfd.Text = "" Or lblMfd.Text = "Mfd_Date" Then
                err.SetError(lblMfd, "This information is required")
                Exit Sub
            Else
                err.SetError(lblMfd, "")
            End If
            If lblExp.Text = "" Or lblExp.Text = "Exp_Date" Then
                err.SetError(lblExp, "This information is required")
                Exit Sub
            Else
                err.SetError(lblExp, "")
            End If
            If lblModel.Text = "" Or lblModel.Text = "Model" Then
                err.SetError(lblModel, "This information is required")
                Exit Sub
            Else
                err.SetError(lblModel, "")
            End If
            If lblTypeGSCode.Text = "" Or lblTypeGSCode.Text = "Type_GS_Code" Then
                err.SetError(lblTypeGSCode, "This information is required")
                Exit Sub
            Else
                err.SetError(lblTypeGSCode, "")
            End If

            'First Time print
            If Chkreprint.Checked = False Then
                If txtquantity.Text = "" Then
                    err.SetError(txtquantity, "Enter Qty")
                    Exit Sub
                Else
                    err.SetError(txtquantity, "")
                End If

                StrPrQty = txtquantity.Text
                If Val(StrPrQty) <= 0 Then
                    MsgBox("Enter Minimum 1 Qty")
                    txtquantity.Text = ""
                    txtquantity.Focus()
                    Exit Sub
                End If

                If txtbatno.Text = "" Then
                    err.SetError(txtbatno, "Enter Batch No")
                    Exit Sub
                Else
                    err.SetError(txtbatno, "")
                End If

                If Val(LblBalanceQty.Text) < Val(txtquantity.Text) Then
                    MsgBox("No.Of.Label is greater than Balance Qty")
                    txtquantity.Text = ""
                    txtquantity.Focus()
                    Exit Sub
                End If

                If typegs1.Text = "" Then
                    err.SetError(typegs1, "Select Type GS_Code")
                    Exit Sub
                Else
                    err.SetError(typegs1, "")
                End If

                StrMaxQty = lblShowMaxQty.Text
                StrPrtedQty = LblShowPrintedQty.Text
                StrBalQty = LblBalanceQty.Text

                If Val(LblBalanceQty.Text) = 0 Then
                    MsgBox("Balance Qty is Zero. Please Check")
                    Exit Sub
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

                '' Mfd & Exp Calculation
                'Dim StrMdf, strmfmonth, strmfyear As String
                'Dim StrExp, strexmonth, strexyear As String
                'IntTotExp = 5
                'StrMfdMonth = Now.Month
                'StrMfdYear = Now.Year

                'strmfmonth = StrMfdMonth.ToString("00")
                'strmfyear = StrMfdYear.ToString("0000")

                'StrExpMonth = StrMfdMonth - 1
                'strexmonth = StrExpMonth.ToString("00")

                'StrExpYear = StrMfdYear + IntTotExp
                'strexyear = StrExpYear.ToString("0000")

                'If StrExpMonth = 0 Then
                '    strexmonth = (12).ToString("00")
                '    strexyear = (StrExpYear - 1).ToString("0000")
                'End If
                'StrMdf = strmfyear & "-" & strmfmonth
                'StrExp = strexyear & "-" & strexmonth
                strmfyear = lblMfd.Text.Split(New Char() {"-"c})(0)
                strmfmonth = lblMfd.Text.Split(New Char() {"-"c})(1)
                strexyear = lblExp.Text.Split(New Char() {"-"c})(0)
                strexmonth = lblExp.Text.Split(New Char() {"-"c})(1)
                StrMdf = lblMfd.Text
                StrExp = lblExp.Text

                'UDI
                Dim StrEanCode As String
                StrEanCode = lblGsCode.Text.Remove(lblGsCode.Text.Length - 1, 1)
                Dim strbtcexpiry As String = strexyear.Substring(2, 2)
                StrInexp1 = strbtcexpiry & strexmonth & "00"
                Dim strbtcmfd As String = strmfyear.Substring(2, 2)
                StrInmfd = strbtcmfd & strmfmonth & "00"
                Dim udi_code As String = "01" & lblGsCode.Text & "10" & txtbatno.Text & "11" & StrInmfd & "17" & StrInexp1


                'BTW Filename
                StrFName = BTWFileName()
                If StrFName = "" Then
                    MessageBox.Show("BTW file record not found")
                    Exit Sub
                End If

                ''Insert Injector_label
                sql = "SELECT Inj_Ref, Mfd_Year, Mfd_Month, Exp_year, Exp_Month, Str_batch, Qty, Lot_srno FROM  Injector_Label WHERE  (Lot_srno = '" & "INJ" + LblShowLotNo.Text & "')"
                Cmd = New SqlCommand(sql, con)
                Dr = Cmd.ExecuteReader

                If Dr.Read Then
                    Dr.Close()
                    MsgBox("Batch No Already Exist. Please click Reprint")
                    Exit Sub
                Else

                    'PHILIC
                    Dim conStringPhilic As String = ConfigurationSettings.AppSettings("conStrPHILIC").ToString()
                    Dim conPhilic As SqlConnection
                    conPhilic = New SqlConnection(conStringPhilic)
                    Try
                        conPhilic.Open()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    StrSql = "Insert into Injector_Label (Inj_Ref,Mfd_Year,Mfd_Month,Exp_Year,Exp_Month,Str_batch,Qty,Created_Date,	Updated_By,Type_GS_Code, GS_Code, UDI_code,BTWLabelName, Lot_srno) VALUES   ( " & _
                            "'" & CmbShModel.Text & "','" & strmfyear & "','" & strmfmonth & "'," & _
                            "'" & strexyear & "','" & strexmonth & "','" & txtbatno.Text & "','" & txtquantity.Text & "',GETDATE(), '" & StrLoginUser & "'," & _
                            "'" & lblTypeGSCode.Text & "','" & lblGsCode.Text & "','" & udi_code & "','" & cmbPrintLabel.Text & "','" & "INJ" + LblShowLotNo.Text & "')"
                    Cmd = New SqlCommand(StrSql, conPhilic)
                    Cmd.ExecuteNonQuery()
                    Cmd.Dispose()

                    'PHOBIC
                    Dim conStringPhobic As String = ConfigurationSettings.AppSettings("conStrPHOBIC").ToString()
                    Dim conPhobic As SqlConnection
                    conPhobic = New SqlConnection(conStringPhobic)
                    Try
                        conPhobic.Open()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    StrSql = "Insert into Injector_Label (Inj_Ref,Mfd_Year,Mfd_Month,Exp_Year,Exp_Month,Str_batch,Qty,Created_Date,	Updated_By,Type_GS_Code, GS_Code, UDI_code,BTWLabelName,Lot_srno) VALUES   ( " & _
                            "'" & CmbShModel.Text & "','" & strmfyear & "','" & strmfmonth & "'," & _
                            "'" & strexyear & "','" & strexmonth & "','" & txtbatno.Text & "','" & txtquantity.Text & "',GETDATE(), '" & StrLoginUser & "'," & _
                            "'" & lblTypeGSCode.Text & "','" & lblGsCode.Text & "','" & udi_code & "','" & cmbPrintLabel.Text & "','" & "INJ" + LblShowLotNo.Text & "')"
                    Cmd = New SqlCommand(StrSql, conPhobic)
                    Cmd.ExecuteNonQuery()
                    Cmd.Dispose()

                    'Non Preloaded
                    Dim conStringNP As String = ConfigurationSettings.AppSettings("conStrPHOBICNONPRE").ToString()
                    Dim conNP As SqlConnection
                    conNP = New SqlConnection(conStringNP)
                    Try
                        conNP.Open()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    StrSql = "Insert into Injector_Label (Inj_Ref,Mfd_Year,Mfd_Month,Exp_Year,Exp_Month,Str_batch,Qty,Created_Date,	Updated_By,Type_GS_Code, GS_Code, UDI_code,BTWLabelName,Lot_srno) VALUES   ( " & _
                            "'" & CmbShModel.Text & "','" & strmfyear & "','" & strmfmonth & "'," & _
                            "'" & strexyear & "','" & strexmonth & "','" & txtbatno.Text & "','" & txtquantity.Text & "',GETDATE(), '" & StrLoginUser & "'," & _
                            "'" & lblTypeGSCode.Text & "','" & lblGsCode.Text & "','" & udi_code & "','" & cmbPrintLabel.Text & "','" & "INJ" + LblShowLotNo.Text & "')"
                    Cmd = New SqlCommand(StrSql, conNP)
                    Cmd.ExecuteNonQuery()
                    Cmd.Dispose()

                End If

                'Printout
                For StI As Integer = StrStPrQty To StrEnPrQty

                    Dim StrTo As Integer

                    'StrlotBarNo = LblShowLotPrefix.Text & LblShowLotNo.Text & " " & Format(StrStPrQty, "000")
                    btFile = Application.StartupPath & "\" & StrFName & ""
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("Ref", CmbShModel.Text)
                    bt.SetNamedSubStringValue("exp", StrExp)
                    bt.SetNamedSubStringValue("mfd", StrMdf)
                    bt.SetNamedSubStringValue("lot", txtbatno.Text)
                    bt.SetNamedSubStringValue("gs1", lblGsCode.Text)
                    bt.SetNamedSubStringValue("EanCode", StrEanCode)
                    bt.SetNamedSubStringValue("mfdtwod", StrInmfd)
                    bt.SetNamedSubStringValue("exptwod", StrInexp1)
                    bt.SetNamedSubStringValue("Lotno", "INJ" + LblShowLotNo.Text)

                    'bt.SetNamedSubStringValue("lotsr", StrlotBarNo)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                    ' Update lens_lot table
                    If con.State = Data.ConnectionState.Open Then
                        con.Close()
                    End If
                    Try
                        con.Open()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    StrSql = "Update LENS_LOT set Printed_Qty='" & StrStPrQty & "' where Active='YES' and type='" & CmbType.Text & "'  and Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "'"
                    Cmd = New SqlCommand(StrSql, con)
                    Cmd.ExecuteNonQuery()
                    Cmd.Dispose()
                    LblShowPrintedQty.Text = StrStPrQty
                    LblBalanceQty.Text = Val(lblShowMaxQty.Text) - StrStPrQty


                    StrStPrQty = Val(StrStPrQty) + 1
                    StrTo = StrTo + 1

                Next
                ' Next Lot  Open Automattically.
                StrSql = "Update LENS_LOT set Active='NO',Modified_By='" & StrLoginUser & "',Modified_Date=GETDATE() where Lot_Prefix='" & LblShowLotPrefix.Text & "' and Lot_No='" & LblShowLotNo.Text & "' and type='" & CmbType.Text & "'"
                Cmd = New SqlCommand(StrSql, con)
                Cmd.ExecuteNonQuery()
                Cmd.Dispose()
                'LblShowLotNo.Text = (LblShowLotNo.Text.Split(New Char() {" "c})(0)).ToString() + " " + (Val(LblShowLotNo.Text.Split(New Char() {" "c})(1)) + 1).ToString("00")
                LblShowLotNo.Text = (Val(LblShowLotNo.Text) + 1).ToString("00000000")
                StrSql = "Insert into LENS_LOT (Lot_Prefix,	Lot_No,Max_Qty,Printed_Qty,	Active,	Created_By,	Created_Date,	Modified_By,	Modified_Date,Type) VALUES   ( " & _
                        "'" & LblShowLotPrefix.Text & "','" & LblShowLotNo.Text & "','" & lblShowMaxQty.Text & "',0,'YES','" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),'" & CmbType.Text & "')"
                Cmd = New SqlCommand(StrSql, con)
                Cmd.ExecuteNonQuery()
                Cmd.Dispose()
                StrEnPrQty = StrEnPrQty - Val(lblShowMaxQty.Text)
                StrStPrQty = 0
                StrBalQty = StrMaxQty
                LblBalanceQty.Text = StrBalQty
                StrPrtedQty = 0
                LblShowPrintedQty.Text = 0

                'Reprint
            Else
                If txtReprintQty.Text = "" Then
                    err.SetError(txtReprintQty, "Enter Qty")
                    Exit Sub
                Else
                    err.SetError(txtReprintQty, "")
                End If
                If cmbLotNo.Text = "" Then
                    err.SetError(cmbLotNo, "Select Lot No")
                    Exit Sub
                Else
                    err.SetError(txtReprintQty, "")
                End If

                StrPrQty = txtReprintQty.Text
                If Val(StrPrQty) <= 0 Then
                    MsgBox("Enter Minimum 1 Qty")
                    txtReprintQty.Text = ""
                    txtReprintQty.Focus()
                    Exit Sub
                End If

                If cmbBatch.Text = "" Then
                    err.SetError(cmbBatch, "Enter Batch No")
                    Exit Sub
                Else
                    err.SetError(cmbBatch, "")
                End If

                If typegs1.Text = "" Then
                    err.SetError(typegs1, "Type_GS_code is Empty Please check")
                    Exit Sub
                Else
                    err.SetError(typegs1, "")
                End If

                'BTW Filename
                StrFName = BTWFileName()
                If StrFName = "" Then
                    MessageBox.Show("BTW file record not found")
                    Exit Sub
                End If

                strmfyear = lblMfd.Text.Split(New Char() {"-"c})(0)
                strmfmonth = lblMfd.Text.Split(New Char() {"-"c})(1)
                strexyear = lblExp.Text.Split(New Char() {"-"c})(0)
                strexmonth = lblExp.Text.Split(New Char() {"-"c})(1)
                StrMdf = lblMfd.Text
                StrExp = lblExp.Text

                'UDI
                Dim StrEanCode As String
                StrEanCode = lblGsCode.Text.Remove(lblGsCode.Text.Length - 1, 1)
                Dim strbtcexpiry As String = strexyear.Substring(2, 2)
                StrInexp1 = strbtcexpiry & strexmonth & "00"
                Dim strbtcmfd As String = strmfyear.Substring(2, 2)
                StrInmfd = strbtcmfd & strmfmonth & "00"
                Dim udi_code As String = "01" & lblGsCode.Text & "10" & txtbatno.Text & "11" & StrInmfd & "17" & StrInexp1



                For StI As Integer = 1 To txtReprintQty.Text
                    Dim StrTo As Integer
                    btFile = Application.StartupPath & "\" & StrFName & ""
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("Ref", lblModel.Text)
                    bt.SetNamedSubStringValue("exp", StrExp)
                    bt.SetNamedSubStringValue("mfd", StrMdf)
                    bt.SetNamedSubStringValue("lot", cmbBatch.Text)
                    bt.SetNamedSubStringValue("gs1", lblGsCode.Text)
                    bt.SetNamedSubStringValue("EanCode", StrEanCode)
                    bt.SetNamedSubStringValue("mfdtwod", StrInmfd)
                    bt.SetNamedSubStringValue("exptwod", StrInexp1)
                    bt.SetNamedSubStringValue("Lotno", cmbLotNo.Text)
                    'bt.SetNamedSubStringValue("lotsr", StrlotBarNo)

                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                    StrStPrQty = Val(StrStPrQty) + 1
                    StrTo = StrTo + 1
                Next

            End If
            txtReprintQty.Text = ""
            txtquantity.Text = ""
            CmbShModel.Text = ""
            txtbatno.Text = ""

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

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
        'RawPrinterHelper.SendFileToPrinter(DefaultPrinterName, Application.StartupPath & "\write.prn")
        'txtquantity.Text = ""
    End Sub

    Private Sub CmbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbType.SelectedIndexChanged

        If CmbType.Text <> "" Then
            StrSql = "select Lot_Prefix,Lot_No,Max_Qty,Printed_Qty,(Max_Qty-Printed_Qty) as Balance_Qty,Active from LENS_LOT where Active='YES' and type='" & CmbType.Text & "'"
            Cmd = New SqlCommand(StrSql, con)
            StrRs = Cmd.ExecuteReader
            If StrRs.Read Then
                LblShowLotPrefix.Text = IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0))
                LblShowLotNo.Text = IIf(IsDBNull(StrRs.GetValue(1)), "", StrRs.GetValue(1))
                lblShowMaxQty.Text = IIf(IsDBNull(StrRs.GetValue(2)), "", StrRs.GetValue(2))
                LblShowPrintedQty.Text = IIf(IsDBNull(StrRs.GetValue(3)), "", StrRs.GetValue(3))
                LblBalanceQty.Text = IIf(IsDBNull(StrRs.GetValue(4)), "", StrRs.GetValue(4))
                CmbShModel.Focus()
            Else
                LblShowLotPrefix.Text = ""
                LblShowLotNo.Text = ""
                lblShowMaxQty.Text = 0
                LblShowPrintedQty.Text = 0
                LblBalanceQty.Text = 0
            End If
            StrRs.Close()
            Cmd.Dispose()
        End If
    End Sub

    Private Sub rdoInt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoInt.CheckedChanged
        'If RdoExportturkey.Checked = True Then
        '    Label10.Visible = True
        '    typegs1.Visible = True
        'Else
        '    Label10.Visible = False
        '    typegs1.Visible = False
        'End If
    End Sub

    Private Sub RdoInA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoInA.CheckedChanged

    End Sub

    Private Sub RdoIntBIg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoIntBIg.CheckedChanged

    End Sub

    Private Sub RdoExportturkey_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoExportturkey.CheckedChanged

    End Sub

    Private Sub rdosupra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdosupra.CheckedChanged

    End Sub

    Private Sub typegs1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles typegs1.SelectedIndexChanged



    End Sub

    Private Sub CmbShModel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbShModel.SelectedIndexChanged

        ' Mfd & Exp Calculation
        Dim StrMdf, strmfmonth, strmfyear As String
        Dim StrExp, strexmonth, strexyear As String


        If CmbType.Text = "" Then
            err.SetError(CmbType, "Plese Select Type")
            lblGsCode.Text = ""
            lblMfd.Text = ""
            lblExp.Text = ""
            lblModel.Text = ""
            Exit Sub
        Else
            err.SetError(CmbType, "")
        End If

        If typegs1.Text = "" Then
            err.SetError(typegs1, "Plese Select Type_GS_Code")
            lblGsCode.Text = ""
            lblMfd.Text = ""
            lblExp.Text = ""
            lblModel.Text = ""
            Exit Sub
        Else
            err.SetError(typegs1, "")
        End If

        StrSql = "select Model_Name,Gs_Code,Tot_Exp,Type_Gs_Code from LENS_MASTER where  Model_Name='" & CmbShModel.Text & "' AND Type_Gs_Code='" & typegs1.Text & "' "
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader

        If StrRs.Read Then
            lblModel.Text = IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0))
            lblGsCode.Text = IIf(IsDBNull(StrRs.GetValue(1)), "", StrRs.GetValue(1))
            IntTotExp = IIf(IsDBNull(StrRs.GetValue(2)), "", StrRs.GetValue(2))
            lblTypeGSCode.Text = IIf(IsDBNull(StrRs.GetValue(3)), "", StrRs.GetValue(3))
            StrMfdMonth = Now.Month
            StrMfdYear = Now.Year
            strmfmonth = StrMfdMonth.ToString("00")
            strmfyear = StrMfdYear.ToString("0000")

            StrExpMonth = StrMfdMonth - 1
            strexmonth = StrExpMonth.ToString("00")

            StrExpYear = StrMfdYear + IntTotExp
            strexyear = StrExpYear.ToString("0000")

            If StrExpMonth = 0 Then
                strexmonth = (12).ToString("00")
                strexyear = (StrExpYear - 1).ToString("0000")
            End If
            StrMdf = strmfyear & "-" & strmfmonth
            StrExp = strexyear & "-" & strexmonth

            lblMfd.Text = StrMdf
            lblExp.Text = StrExp

            txtbatno.Focus()
        Else
            lblGsCode.Text = ""
            lblMfd.Text = ""
            lblExp.Text = ""
            lblModel.Text = ""
            MsgBox("GS Code not registered. Please Check.")
            StrRs.Close()
            Cmd.Dispose()
            Exit Sub
        End If
        StrRs.Close()
        Cmd.Dispose()
    End Sub
    Private Sub batchNumberBind()
        'Dim ds As New DataSet()
        'StrSql = "select distinct Str_batch from  Injector_Label"
        'Dim cmd As New SqlCommand(StrSql, con)
        'Dim ad As New SqlDataAdapter(cmd)
        'ad.Fill(ds)
        'cmbBatch.DisplayMember = "Str_batch"
        'cmbBatch.DataSource = ds.Tables(0)

        'batch Load for reprint
        StrSql = "select distinct Str_batch from  Injector_Label"
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        cmbBatch.Items.Clear()
        While StrRs.Read
            cmbBatch.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        Cmd.Dispose()
    End Sub

    Private Sub LotNumberBind()
        StrSql = "select distinct Lot_srno from  Injector_Label Where  Str_batch ='" & cmbBatch.Text & "'"
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        cmbLotNo.Items.Clear()
        While StrRs.Read
            cmbLotNo.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        Cmd.Dispose()
    End Sub
    Private Sub Chkreprint_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chkreprint.CheckedChanged
        If Chkreprint.Checked = True Then
            GroupBox1.Visible = False
            GroupBox2.Visible = False
            GroupBox4.Visible = False

            GroupBox8.Visible = True
            cmbPrintLabel.Enabled = False
            typegs1.Enabled = False
            batchNumberBind()
            lblGsCode.Text = ""
            lblMfd.Text = ""
            lblExp.Text = ""
            lblModel.Text = ""
            lblTypeGSCode.Text = ""
            cmbPrintLabel.Text = ""
            typegs1.Text = ""

        Else
            GroupBox8.Visible = False
            GroupBox1.Visible = True
            GroupBox2.Visible = True
            GroupBox4.Visible = True

            cmbPrintLabel.Enabled = True
            typegs1.Enabled = True
            lblGsCode.Text = ""
            lblMfd.Text = ""
            lblExp.Text = ""
            lblModel.Text = ""
            lblTypeGSCode.Text = ""
            cmbPrintLabel.Text = ""
            typegs1.Text = ""
        End If
    End Sub

    Private Sub cmbBatch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBatch.SelectedIndexChanged
        ' Mfd & Exp Calculation
        Dim StrMdf, strmfmonth, strmfyear As String
        Dim StrExp, strexmonth, strexyear As String
        LotNumberBind()
        StrSql = "select Inj_Ref, Mfd_Year, Mfd_Month, Exp_year, Exp_Month, Str_batch,Type_GS_Code, GS_Code, BTWLabelName from Injector_Label where   Str_batch='" & cmbBatch.Text & "' "
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader

        If StrRs.Read Then
            lblModel.Text = IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0))
            lblGsCode.Text = IIf(IsDBNull(StrRs.GetValue(7)), "", StrRs.GetValue(7))
            lblTypeGSCode.Text = IIf(IsDBNull(StrRs.GetValue(6)), "", StrRs.GetValue(6))
            typegs1.Text = IIf(IsDBNull(StrRs.GetValue(6)), "", StrRs.GetValue(6))
            cmbPrintLabel.Text = IIf(IsDBNull(StrRs.GetValue(8)), "", StrRs.GetValue(8))
            StrMfdMonth = Convert.ToInt32(IIf(IsDBNull(StrRs.GetValue(2)), "", StrRs.GetValue(2)))
            StrMfdYear = Convert.ToInt32(IIf(IsDBNull(StrRs.GetValue(1)), "", StrRs.GetValue(1)))
            StrExpMonth = Convert.ToInt32(IIf(IsDBNull(StrRs.GetValue(4)), "", StrRs.GetValue(4)))
            StrExpYear = Convert.ToInt32(IIf(IsDBNull(StrRs.GetValue(3)), "", StrRs.GetValue(3)))

            strmfmonth = StrMfdMonth.ToString("00")
            strmfyear = StrMfdYear.ToString("0000")
            strexmonth = StrExpMonth.ToString("00")
            strexyear = StrExpYear.ToString("0000")

            StrMdf = strmfyear & "-" & strmfmonth
            StrExp = strexyear & "-" & strexmonth

            lblMfd.Text = StrMdf
            lblExp.Text = StrExp
            StrRs.Close()
            Cmd.Dispose()
        Else
            lblGsCode.Text = ""
            lblMfd.Text = ""
            lblExp.Text = ""
            lblModel.Text = ""
            lblTypeGSCode.Text = ""
            'MsgBox("Data Not found. Please Check.")
            StrRs.Close()
            Cmd.Dispose()
            'Exit Sub
        End If

    End Sub
End Class