
Imports System.Data
Imports System.IO
Imports System.Data.SqlClient

Public Class FrmNewBoxPackingPHOBIC
    Dim bApp As New BarTender.Application
    Dim bt As New BarTender.Format
    Dim btFile As String
    Dim table As New DataTable
    Dim table1 As New DataTable

    Dim bApp1 As New BarTender.Application
    Dim bt1 As New BarTender.Format
    Dim btFile1 As String
    Dim ds As New DataSet()
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

    Private Sub FrmNewBoxPackingPHOBIC_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub LabelNameBind()
        Dim ds As New DataSet()
        strsql = "select distinct LabelName from BTW_Master where Department = 'BOX' "
        Dim cmd As New SqlCommand(strsql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)
        cmbPrintLabel.DisplayMember = "LabelName"
        cmbPrintLabel.DataSource = ds.Tables(0)

    End Sub

    Private Sub FrmNewBoxPackingPHOBIC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
 

        GroupBox5.Visible = False
        gbxinject.Visible = False 
        LabelNameBind()

        If IsBoxPackRePrtUser = 1 Then
            ckReprint.Checked = True
        Else
            ckReprint.Checked = False
        End If

        ChkCST_CheckedChanged(ChkCST, EventArgs.Empty)



    

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

    Private Function BTWFileName() As String
        Dim labelds = New DataSet
        Dim ModelNo As String = ""

        If ckReprint.Checked = True Then
            If rdLotSerial.Checked = True Then
                strsql = "DECLARE @Lot_SrNo NVARCHAR(50) = '" & txtlotbarno.Text & "' select Model_Name from  POUCH_LABEL where Lot_SrNo = @Lot_SrNo  "
            ElseIf rdUDICode.Checked = True Then
                strsql = "DECLARE @Lot_SrNo NVARCHAR(100) = '" & txtlotbarno.Text & "' select Model_Name from  POUCH_LABEL where Udi_code = @Lot_SrNo  "
            Else
                MsgBox(" Plese choose Lot Serial or UDI Serial")
                Exit Function
            End If
        

        Else
            If rdLotSerial.Checked = True Then
                strsql = "DECLARE @Lot_SrNo NVARCHAR(50) = '" & txtlotbarno.Text & "' select Model_Name from  temp_POUCH_LABEL_box where Lot_SrNo = @Lot_SrNo  "
            ElseIf rdUDICode.Checked = True Then
                strsql = "DECLARE @Lot_SrNo NVARCHAR(100) = '" & txtlotbarno.Text & "' select Model_Name from  temp_POUCH_LABEL_box where Udi_code = @Lot_SrNo  "
            Else
                MsgBox(" Plese choose Lot Serial or UDI Serial")
                Exit Function
            End If
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

    Private Function InspectionOrNot() As Boolean
        Dim labelds = New DataSet
        Dim BPLNo As String = ""
        If ckReprint.Checked = True Then
            If rdLotSerial.Checked = True Then
                strsql = "DECLARE @Lot_SrNo NVARCHAR(50) = '" & txtlotbarno.Text & "' select BPL_NO,Box_Packing from  POUCH_LABEL where Lot_SrNo = @Lot_SrNo  "
            ElseIf rdUDICode.Checked = True Then
                strsql = "DECLARE @Lot_SrNo NVARCHAR(100) = '" & txtlotbarno.Text & "' select BPL_NO,Box_Packing from  POUCH_LABEL where Udi_code = @Lot_SrNo  "
            Else
                MsgBox(" Plese choose Lot Serial or UDI Serial")
                Exit Function
            End If
        Else
            If rdLotSerial.Checked = True Then
                strsql = "DECLARE @Lot_SrNo NVARCHAR(50) = '" & txtlotbarno.Text & "' select BPL_NO,Box_Packing from  temp_POUCH_LABEL_box where Lot_SrNo = @Lot_SrNo  "
            ElseIf rdUDICode.Checked = True Then
                strsql = "DECLARE @Lot_SrNo NVARCHAR(100) = '" & txtlotbarno.Text & "' select BPL_NO,Box_Packing from  temp_POUCH_LABEL_box where Udi_code = @Lot_SrNo  "
            Else
                MsgBox(" Plese choose Lot Serial or UDI Serial")
                Exit Function
            End If

        End If
        

        Dim cmd = New SqlCommand(strsql, con)
        Dim ad1 As New SqlDataAdapter(cmd)
        ad1.Fill(labelds)
        If labelds.Tables(0).Rows.Count = 1 Then
            BPLNo = labelds.Tables(0).Rows(0)("BPL_NO").ToString()
        Else
            MsgBox(" Serial Number not present OR Multiple time present. Please check")
            Exit Function
        End If

        If labelds.Tables(0).Rows(0)("Box_Packing").ToString() = "1" Then
            Return True
        Else
            Dim ds As New DataSet()
            strsql = "select * from Box_Inspection_Details where BPL_No = '" & BPLNo & "'  "
            cmd = New SqlCommand(strsql, con)
            Dim ad As New SqlDataAdapter(cmd)
            ad.Fill(ds)
            If ds.Tables(0).Rows.Count = 1 Then
                Return True
            Else
                Return False
            End If
        End If


    End Function

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
    Private Sub BPL_No_Bind()

        Dim ds As New DataSet()

        strsql = "DECLARE @Station VARCHAR(50)  = '" & station & "'  SELECT  Bpl_no FROM Lens_BPL  where station  = @Station and Active='YES' AND    (Bpl_no LIKE 'bpl%')"
        ds = SQL_SelectQuery_Execute(strsql)
        If ds.Tables(0).Rows.Count = 0 Then
            strsql = "SELECT BPL_No " & _
                                 "FROM ( " & _
                                 "    SELECT DISTINCT BPL_No, dbo.CSVParser(BPL_No, 3) AS bpl_index " & _
                                 "    FROM Box_Inspection_Details " & _
                                 "    WHERE (BPL_No IN ( " & _
                                 "        SELECT DISTINCT BPL_NO " & _
                                 "        FROM POUCH_LABEL " & _
                                 "        WHERE (Box_Packing = 0) AND (BPL_Taken = 1) AND (Box_Reject = 0) AND (BPL_NO IS NOT NULL)  AND  (BPL_Collection_Status=1) AND  (Sterilization_Reject=0) " & _
                                 "              AND (Dc_Packing = 0) AND (Sample_Taken = 0)AND (Ord_Country NOT IN ('Argentina', 'Re-Process')) " & _
                                 "    )) AND (BPL_No NOT IN ( " & _
                                 "        SELECT DISTINCT BPL_NO " & _
                                 "        FROM temp_POUCH_LABEL_box  WHERE      (BPL_NO IS NOT NULL) " & _
                                 "    )) " & _
                                 ") AS t1 " & _
                                 "ORDER BY CAST(bpl_index AS int)"
            ds = SQL_SelectQuery_Execute(strsql)
            cmbBPL.DisplayMember = "BPL_No"
            cmbBPL.DataSource = ds.Tables(0)


            Label6.Visible = True
            cmbBPL.Visible = True
            cmbBPL.Enabled = True
            BTC.Visible = False
            Cmbbtc.Visible = False
            BtnStart.Visible = True

            'cha-
            lblModel.Visible = False
            cmbModel.Visible = False

            lblpackedQty.Text = "0"
            lblTotalQty.Text = "0"

        ElseIf ds.Tables(0).Rows.Count = 1 Then
            cmbBPL.Text = ds.Tables(0).Rows(0)("Bpl_no").ToString()

            Label6.Visible = True
            cmbBPL.Visible = True
            cmbBPL.Enabled = False
            BTC.Visible = False
            Cmbbtc.Visible = False
            BtnStart.Visible = False

            lblModel.Visible = False
            cmbModel.Visible = False

            load_grid()
            ColorCode_SerialLoad()
        Else
            MsgBox("Please check Multiple Bpl open against the station ")
            Exit Sub
        End If



    End Sub
    Private Sub BatchNo_Load()
        

        Dim ds As New DataSet()

        strsql = "DECLARE @station VARCHAR(50)='" & station & "'  SELECT  Bpl_no,Model_Name  FROM Lens_BPL  where station  = @station and Active='YES' AND    (Bpl_no NOT LIKE 'bpl%')"
        ds = SQL_SelectQuery_Execute(strsql)
        If ds.Tables(0).Rows.Count = 0 Then
            strsql = "SELECT DISTINCT Btc_No " & _
                        "FROM POUCH_LABEL " & _
                        "WHERE " & _
                        "    Sterilization = 1 " & _
                        "    AND Sample_Taken = 1 " & _
                        "    AND Type_Sample = 'CST' " & _
                        "    AND Dc_Packing = 0 " & _
                        "    AND Box_Reject = 0 " & _
                        "    AND Sterilization_After = 1 " & _
                        "    AND Sterilization_Reject = 0 " & _
                        "    AND Btc_No IS NOT NULL " & _
                        "    AND Box_Packing = 0 " & _
                        "    AND Btc_No NOT IN " & _
                        "    ( " & _
                        "        SELECT DISTINCT Btc_No " & _
                        "        FROM temp_POUCH_LABEL_box Where Btc_No is not NULL" & _
                        "    ) " & _
                        "    AND Created_Date > '2023-01-01' "
            ds = SQL_SelectQuery_Execute(strsql)
            Cmbbtc.DisplayMember = "Btc_No"
            Cmbbtc.DataSource = ds.Tables(0)

            cmbBPL.Visible = False
            Label6.Visible = False
            BTC.Visible = True
            Cmbbtc.Enabled = True
            Cmbbtc.Visible = True
            BtnStart.Visible = True

            'cha-
            lblModel.Visible = True
            cmbModel.Enabled = True
            cmbModel.Visible = True

            lblpackedQty.Text = "0"
            lblTotalQty.Text = "0"


        ElseIf ds.Tables(0).Rows.Count = 1 Then
            Cmbbtc.Text = ds.Tables(0).Rows(0)("Bpl_no").ToString()
            cmbModel.Text = ds.Tables(0).Rows(0)("Model_Name").ToString()
            cmbBPL.Visible = False
            Label6.Visible = False
            BTC.Visible = True
            Cmbbtc.Enabled = False
            Cmbbtc.Visible = True
            BtnStart.Visible = False

            'cha-
            lblModel.Visible = True
            cmbModel.Enabled = False
            cmbModel.Visible = True

            load_grid()
            ColorCode_SerialLoad()
        Else
            MsgBox("Please check Multiple Bpl open against the station ")
            Exit Sub

        End If
    End Sub
    Private Sub load_grid()

        DataGridView2.Rows.Clear()

        If ChkCST.Checked = True Then
            If Cmbbtc.Text <> "" Then
                strsql = " " & _
                      "DECLARE @Btc_No NVARCHAR(50)='" & Cmbbtc.Text & "', @Model_Name VARCHAR(50)='" & cmbModel.Text & "' SELECT Lot_SrNo,  Model_Name,  Power,  Btc_No, Box_Packing " & _
                      "FROM temp_POUCH_LABEL_box " & _
                      "WHERE  (Type_Sample = 'CST')  AND (Box_Reject = 0) AND (Dc_Packing = 0) AND (Sample_Taken = 1) " & _
                      "      AND (Btc_No = @Btc_No) AND (Model_Name = @Model_Name) "
                ds = SQL_SelectQuery_Execute(strsql)
                For Each eachRow As DataRow In ds.Tables(0).Rows
                    DataGridView2.Rows.Add(eachRow("Lot_SrNo"), eachRow("Model_Name"), eachRow("Power"), eachRow("Btc_no"), eachRow("Box_Packing"))
                Next
            End If

        Else
            If cmbBPL.Text <> "" Then
                strsql = " " & _
                                  "DECLARE @Bpl_no NVARCHAR(50)='" & cmbBPL.Text & "' SELECT Lot_SrNo,  Model_Name,  Power,  Btc_No, Box_Packing " & _
                                  "FROM temp_POUCH_LABEL_box " & _
                                  "WHERE  (BPL_Taken = 1) AND (Box_Reject = 0) AND (BPL_NO IS NOT NULL) AND (Dc_Packing = 0) AND (Sample_Taken = 0) " & _
                                  "      AND (BPL_NO = @Bpl_no)"
                ds = SQL_SelectQuery_Execute(strsql)
                For Each eachRow As DataRow In ds.Tables(0).Rows
                    DataGridView2.Rows.Add(eachRow("Lot_SrNo"), eachRow("Model_Name"), eachRow("Power"), eachRow("Btc_no"), eachRow("Box_Packing"))
                Next
            End If

        End If

        lblTotalQty.Text = ds.Tables(0).Rows.Count.ToString()
    End Sub

    Private Sub ColorCode_SerialLoad()
        Dim scanedCount As Integer = 0

        For i As Integer = 0 To DataGridView2.Rows.Count - 2
            If Not IsDBNull(Me.DataGridView2.Rows(i).Cells("Box_Packing").Value) Then
                If Me.DataGridView2.Rows(i).Cells("Box_Packing").Value = "1" Then
                    Me.DataGridView2.Rows(i).Cells("Lot_SrNo").Style.BackColor = Color.LightGreen
                    scanedCount = scanedCount + 1
                End If
            End If
        Next
        lblpackedQty.Text = scanedCount
    End Sub

    Private Sub ckReprint_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckReprint.CheckedChanged

        If ckReprint.Checked = True Then
            GroupBox11.Visible = False
        Else
            GroupBox11.Visible = True
        End If
    End Sub

    Private Sub txtlotbarno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlotbarno.KeyDown

        If e.KeyCode = Keys.Enter Then

            If txtlotbarno.Text <> "" Then

                Try

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


                    If cmbPrintLabel.SelectedItem Is Nothing Then
                        MessageBox.Show("Please Select valid Label")
                        cmbPrintLabel.Focus()
                        cmbPrintLabel.Text = ""
                        Exit Sub
                    End If

                    StrLog = "Select * from LOGIN Where username = '" & StrLoginUser & "'   "
                    Ds_new = SQL_SelectQuery_Execute(StrLog)
                    If Ds_new.Tables(0).Rows.Count = 1 Then
                        ' Check logged user is ERP user or not
                        If DBNull.Value.Equals(Ds_new.Tables(0).Rows(0)("IsErpUser")) Then
                            IsErpUser = 0
                        ElseIf Ds_new.Tables(0).Rows(0)("IsErpUser") = "1" Then
                            IsErpUser = 1
                        Else
                            IsErpUser = 0
                        End If

                        If Not DBNull.Value.Equals(Ds_new.Tables(0).Rows(0)("boxLabelReprint")) Then
                            If Ds_new.Tables(0).Rows(0)("boxLabelReprint") = 1 Then
                                ' Check logged user level -13-09-2024
                                If DBNull.Value.Equals(Ds_new.Tables(0).Rows(0)("Reprint_User_Level")) Then
                                    MsgBox(" Reprint User Level not set.")
                                    txtlotbarno.Text = ""
                                    txtlotbarno.Focus()
                                    Exit Sub
                                Else
                                    Logged_Reprint_User_Level = Ds_new.Tables(0).Rows(0)("Reprint_User_Level")
                                End If
                            End If
                        End If

                    Else
                        MsgBox(" The Logged Username multiple time present. Please check")
                        txtlotbarno.Text = ""
                        txtlotbarno.Focus()
                        Exit Sub
                    End If

                    'check the label already printed using reprint user id
                    If IsErpUser = 0 And IsBoxPackRePrtUser = 1 Then
                        If rdLotSerial.Checked = True Then
                            StrLog = "DECLARE @Lot_SrNo NVARCHAR(50) = '" & txtlotbarno.Text & "'  Select * from Box_Packing_Reprint_details Where  IsErpUser=0 And Lot_SrNo = ( Select Distinct Lot_SrNo from Pouch_Label Where Lot_SrNo=@Lot_SrNo ) "
                        ElseIf rdUDICode.Checked = True Then
                            StrLog = "DECLARE @Udi_Code NVARCHAR(100) = '" & txtlotbarno.Text & "'  Select * from Box_Packing_Reprint_details Where  IsErpUser=0 And Lot_SrNo = (Select Distinct Lot_SrNo from Pouch_Label Where Udi_Code=@Udi_Code ) "
                        Else
                            MsgBox(" Plese choose Lot Serial or UDI Serial")
                            Exit Sub
                        End If
                        Ds_new = SQL_SelectQuery_Execute(StrLog)
                        If Ds_new.Tables(0).Rows.Count > 0 Then
                            For Each eachRow1 As DataRow In Ds_new.Tables(0).Rows
                                If Logged_Reprint_User_Level = IIf(IsDBNull(eachRow1("Reprint_User_Level")), "", eachRow1("Reprint_User_Level")) Then
                                    MsgBox(" Serial number already printed by " + Logged_Reprint_User_Level + " Reprint user")
                                    Exit Sub
                                End If
                                Reprint_taken_User_Levels = Reprint_taken_User_Levels + "" + IIf(IsDBNull(eachRow1("Reprint_User_Level")), "", eachRow1("Reprint_User_Level")) + ","
                            Next
                            If Logged_Reprint_User_Level = "L2" Then
                                If Not Reprint_taken_User_Levels.Contains("L1") Then
                                    MsgBox(" Please Reprint take using L1 Reprint user.Printed User Levels -" + Reprint_taken_User_Levels + "")
                                    Exit Sub
                                End If
                            ElseIf Logged_Reprint_User_Level = "L3" Then
                                If Not Reprint_taken_User_Levels.Contains("L2") Then
                                    MsgBox(" Please Reprint take using L2 Reprint user.Printed User Levels -" + Reprint_taken_User_Levels + "")
                                    Exit Sub
                                End If
                            ElseIf Logged_Reprint_User_Level = "L4" Then
                                If Not Reprint_taken_User_Levels.Contains("L3") Then
                                    MsgBox(" Please Reprint take using L3 Reprint user.Printed User Levels -" + Reprint_taken_User_Levels + "")
                                    Exit Sub
                                End If
                            ElseIf Logged_Reprint_User_Level = "L5" Then
                                If Not Reprint_taken_User_Levels.Contains("L4") Then
                                    MsgBox(" Please Reprint take using L4 Reprint user.Printed User Levels -" + Reprint_taken_User_Levels + "")
                                    Exit Sub
                                End If
                            ElseIf Logged_Reprint_User_Level = "L6" Then
                                If Not Reprint_taken_User_Levels.Contains("L5") Then
                                    MsgBox(" Please Reprint take using L5 Reprint user.Printed User Levels -" + Reprint_taken_User_Levels + "")
                                    Exit Sub
                                End If
                            ElseIf Logged_Reprint_User_Level = "L7" Then
                                If Not Reprint_taken_User_Levels.Contains("L6") Then
                                    MsgBox(" Please Reprint take using L6 Reprint user.Printed User Levels -" + Reprint_taken_User_Levels + "")
                                    Exit Sub
                                End If
                            End If

                        ElseIf Logged_Reprint_User_Level <> "L1" Then
                            MsgBox(" Please Reprint take by L1 Reprint user")
                            Exit Sub

                        End If


                    End If


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

                        If ChkCST.Checked = True Then
                        Else
                            IsInspected = InspectionOrNot()
                            If IsInspected = False Then
                                MsgBox(" Inspection process not completed. Please check")
                                txtlotbarno.Text = ""
                                txtlotbarno.Focus()
                                Exit Sub
                            End If
                        End If


                        If con.State = Data.ConnectionState.Open Then
                            con.Close()
                        End If

                        Try
                            con.Open()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try

                        If rbnonpreloader.Checked Then
                            If rdInjBatch.Checked = True Then
                                StrSelInj = "DECLARE @Str_batch NVARCHAR(50)  = '" & txtinj_No.Text & "' SELECT Inj_ref,Str_batch,Exp_year,Exp_Month,Mfd_Year,Mfd_Month,Lot_srno from Injector_Label where Str_batch = @Str_batch "
                            ElseIf rdInjLot.Checked = True Then
                                StrSelInj = "DECLARE @Lot_srno VARCHAR(50)  = '" & txtinj_No.Text & "' SELECT Inj_ref,Str_batch,Exp_year,Exp_Month,Mfd_Year,Mfd_Month,Lot_srno from Injector_Label where Lot_srno = @Lot_srno "
                            Else
                                MsgBox(" Please choose Injector Batch or Injector Lot ")
                                Exit Sub
                            End If

                            Cmd = New SqlCommand(StrSelInj, con)
                            strInjRs = Cmd.ExecuteReader
                            If strInjRs.Read Then

                                strinj_ref = IIf(IsDBNull(strInjRs.GetValue(0)), "", strInjRs.GetValue(0))
                                strinj_batch = IIf(IsDBNull(strInjRs.GetValue(1)), "", strInjRs.GetValue(1))
                                strinjyear = IIf(IsDBNull(strInjRs.GetValue(2)), "", strInjRs.GetValue(2))
                                strinjmonth = IIf(IsDBNull(strInjRs.GetValue(3)), "", strInjRs.GetValue(3))
                                strinjmy = IIf(IsDBNull(strInjRs.GetValue(4)), "", strInjRs.GetValue(4))
                                strinjmm = IIf(IsDBNull(strInjRs.GetValue(5)), "", strInjRs.GetValue(5))
                                strinj_Lot = IIf(IsDBNull(strInjRs.GetValue(6)), "", strInjRs.GetValue(6))
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

                        If ChkCST.Checked = True Then
                            If ckReprint.Checked = True Then

                                If rdLotSerial.Checked = True Then
                                    StrSeSql = "DECLARE @Lot_SrNo NVARCHAR(50) = '" & txtlotbarno.Text & "' SELECT Brand_Name,Model_Name,Reference_Name,GS_Code,Power,Optic,Length,A_Constant,Type_GS_Code,Lot_Prefix,Lot_No,Lot_SrNo,Mfd_Month,Mfd_Year,Exp_Month,Exp_Year,Type,Btc_No,price,R_Power,Injector_Ref,Injector_batch,Cylsize, Box_Packing from POUCH_LABEL where Lot_SrNo=@Lot_SrNo " & _
                               "and Sterilization=1   and Sample_Taken=1 and Type_Sample='CST' and Dc_Packing=0  and Box_Reject = 0 and Sterilization_After = 1 and Sterilization_Reject = 0  and  Btc_No is not null "
                                ElseIf rdUDICode.Checked = True Then
                                    StrSeSql = "DECLARE @Lot_SrNo NVARCHAR(100) = '" & txtlotbarno.Text & "' SELECT Brand_Name,Model_Name,Reference_Name,GS_Code,Power,Optic,Length,A_Constant,Type_GS_Code,Lot_Prefix,Lot_No,Lot_SrNo,Mfd_Month,Mfd_Year,Exp_Month,Exp_Year,Type,Btc_No,price,R_Power,Injector_Ref,Injector_batch,Cylsize, Box_Packing from POUCH_LABEL where Udi_code=@Lot_SrNo " & _
                               "and Sterilization=1   and Sample_Taken=1 and Type_Sample='CST' and Dc_Packing=0  and Box_Reject = 0 and Sterilization_After = 1 and Sterilization_Reject = 0  and  Btc_No is not null "
                                Else
                                    MsgBox(" Plese choose Lot Serial or UDI Serial")
                                    Exit Sub
                                End If

                            Else


                                If rdLotSerial.Checked = True Then
                                    StrSeSql = "DECLARE @Lot_SrNo NVARCHAR(50) = '" & txtlotbarno.Text & "' SELECT Brand_Name,Model_Name,Reference_Name,GS_Code,Power,Optic,Length,A_Constant,Type_GS_Code,Lot_Prefix,Lot_No,Lot_SrNo,Mfd_Month,Mfd_Year,Exp_Month,Exp_Year,Type,Btc_No,price,R_Power,Injector_Ref,Injector_batch,Cylsize, Box_Packing from temp_POUCH_LABEL_box where Lot_SrNo=@Lot_SrNo " & _
                               "and Sterilization=1   and Sample_Taken=1 and Type_Sample='CST' and Dc_Packing=0  and Box_Reject = 0 and Sterilization_After = 1 and Sterilization_Reject = 0  and  Btc_No is not null "
                                ElseIf rdUDICode.Checked = True Then
                                    StrSeSql = "DECLARE @Lot_SrNo NVARCHAR(100) = '" & txtlotbarno.Text & "' SELECT Brand_Name,Model_Name,Reference_Name,GS_Code,Power,Optic,Length,A_Constant,Type_GS_Code,Lot_Prefix,Lot_No,Lot_SrNo,Mfd_Month,Mfd_Year,Exp_Month,Exp_Year,Type,Btc_No,price,R_Power,Injector_Ref,Injector_batch,Cylsize, Box_Packing from temp_POUCH_LABEL_box where Udi_code=@Lot_SrNo " & _
                               "and Sterilization=1   and Sample_Taken=1 and Type_Sample='CST' and Dc_Packing=0  and Box_Reject = 0 and Sterilization_After = 1 and Sterilization_Reject = 0  and  Btc_No is not null "
                                Else
                                    MsgBox(" Plese choose Lot Serial or UDI Serial")
                                    Exit Sub
                                End If

                            End If

                            If IsErpUser = 1 Then
                                StrSeSql = StrSeSql
                            ElseIf IsBoxPackRePrtUser = 1 Then

                                StrSeSql = StrSeSql + " AND (Box_Packing = '1') "
                            End If

                        Else
                            If ckReprint.Checked = True Then

                                If rdLotSerial.Checked = True Then
                                    StrSeSql = "DECLARE @Lot_SrNo NVARCHAR(50) = '" & txtlotbarno.Text & "' SELECT Brand_Name,Model_Name,Reference_Name,GS_Code,Power,Optic,Length,A_Constant,Type_GS_Code,Lot_Prefix,Lot_No,Lot_SrNo,Mfd_Month,Mfd_Year,Exp_Month,Exp_Year,Type,Btc_No,price,R_Power,Injector_Ref,Injector_batch,Cylsize, Box_Packing from POUCH_LABEL where Lot_SrNo=@Lot_SrNo " & _
                               "and Sterilization=1  and Sample_Taken=0 and BPL_Taken=1 and Dc_Packing=0  and Box_Reject = 0 and Sterilization_After = 1 and Sterilization_Reject = 0  and  Btc_No is not null "
                                ElseIf rdUDICode.Checked = True Then
                                    StrSeSql = "DECLARE @Lot_SrNo NVARCHAR(100) = '" & txtlotbarno.Text & "' SELECT Brand_Name,Model_Name,Reference_Name,GS_Code,Power,Optic,Length,A_Constant,Type_GS_Code,Lot_Prefix,Lot_No,Lot_SrNo,Mfd_Month,Mfd_Year,Exp_Month,Exp_Year,Type,Btc_No,price,R_Power,Injector_Ref,Injector_batch,Cylsize, Box_Packing from POUCH_LABEL where Udi_code=@Lot_SrNo " & _
                               "and Sterilization=1  and Sample_Taken=0 and BPL_Taken=1 and Dc_Packing=0  and Box_Reject = 0 and Sterilization_After = 1 and Sterilization_Reject = 0  and  Btc_No is not null "
                                Else
                                    MsgBox(" Plese choose Lot Serial or UDI Serial")
                                    Exit Sub
                                End If

                            Else
                                If rdLotSerial.Checked = True Then
                                    StrSeSql = "DECLARE @Lot_SrNo NVARCHAR(50) = '" & txtlotbarno.Text & "' SELECT Brand_Name,Model_Name,Reference_Name,GS_Code,Power,Optic,Length,A_Constant,Type_GS_Code,Lot_Prefix,Lot_No,Lot_SrNo,Mfd_Month,Mfd_Year,Exp_Month,Exp_Year,Type,Btc_No,price,R_Power,Injector_Ref,Injector_batch,Cylsize, Box_Packing from temp_POUCH_LABEL_box where Lot_SrNo=@Lot_SrNo " & _
                               "and Sterilization=1  and Sample_Taken=0 and BPL_Taken=1 and Dc_Packing=0  and Box_Reject = 0 and Sterilization_After = 1 and Sterilization_Reject = 0  and  Btc_No is not null "
                                ElseIf rdUDICode.Checked = True Then
                                    StrSeSql = "DECLARE @Lot_SrNo NVARCHAR(100) = '" & txtlotbarno.Text & "' SELECT Brand_Name,Model_Name,Reference_Name,GS_Code,Power,Optic,Length,A_Constant,Type_GS_Code,Lot_Prefix,Lot_No,Lot_SrNo,Mfd_Month,Mfd_Year,Exp_Month,Exp_Year,Type,Btc_No,price,R_Power,Injector_Ref,Injector_batch,Cylsize, Box_Packing from temp_POUCH_LABEL_box where Udi_code=@Lot_SrNo " & _
                               "and Sterilization=1  and Sample_Taken=0 and BPL_Taken=1 and Dc_Packing=0  and Box_Reject = 0 and Sterilization_After = 1 and Sterilization_Reject = 0  and  Btc_No is not null "
                                Else
                                    MsgBox(" Plese choose Lot Serial or UDI Serial")
                                    Exit Sub
                                End If
                            End If



                            If IsErpUser = 1 Then
                                StrSeSql = StrSeSql
                            ElseIf IsBoxPackRePrtUser <> 1 Then
                                StrSeSql = StrSeSql + " And  BPL_Collection_Status ='1' "
                            Else
                                StrSeSql = StrSeSql + " AND (Box_Packing = '1') "
                            End If

                        End If


                        Cmd = New SqlCommand(StrSeSql, con)
                        StrSeRs = Cmd.ExecuteReader

                        If StrSeRs.Read Then
                            strIsBoxPacking = IIf(IsDBNull(StrSeRs.GetValue(23)), 0, StrSeRs.GetValue(23))
                            If IsBoxPackRePrtUser <> 1 Then
                                If strIsBoxPacking = 1 Then
                                    MsgBox(" Serial Number already scaned.")
                                    txtlotbarno.Text = ""
                                    txtlotbarno.Focus()
                                    StrSeRs.Close()
                                    Cmd.Dispose()
                                    Exit Sub
                                End If
                            End If

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
                            ' StrUnit = IIf(IsDBNull(StrSeRs.GetValue(8)), "", StrSeRs.GetValue(8))
                            ' IntBoxPAck = IIf(IsDBNull(StrSeRs.GetValue(26)), 0, StrSeRs.GetValue(26))
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

                        If IsErpUser = 0 And IsBoxPackRePrtUser <> 1 Then

                            For i = 0 To DataGridView2.Rows.Count - 2

                                If DataGridView2.Item(0, i).Value.ToString() = StrLotBarNo Then
                                    If DataGridView2.Item(4, i).Value.ToString() <> "1" Then
                                        DataGridView2.Item(4, i).Value = 1
                                        Me.DataGridView2.Rows(i).Cells("Lot_SrNo").Style.BackColor = Color.LightGreen


                                        'Update Query
                                        If rdLotSerial.Checked = True Then
                                            SqlIn = "DECLARE @Lot_SrNo NVARCHAR(50)='" & txtlotbarno.Text & "', @Box_By nvarchar(15)='" & StrLoginUser & "',@Injector_Ref nvarchar(10)='" & strinj_ref & "',@Injector_batch nvarchar(50)='" & strinj_batch & "' ,@Station varchar(50)= '" & station & "' ,@Injector_Lot nvarchar(50)= '" & strinj_Lot & "' ,@BoxBTWLabelName varchar(50)= '" & cmbPrintLabel.Text & "' " & _
                                                  " update temp_POUCH_LABEL_box set Box_Packing =1,Box_By=@Box_By ,Injector_Ref =@Injector_Ref ,Injector_batch=@Injector_batch ,Box_Date=GETDATE(),Boxtime = GETDATE(),Station=@Station ,Injector_Lot=@Injector_Lot ,BoxBTWLabelName =@BoxBTWLabelName where Lot_SrNo=@Lot_SrNo "

                                        ElseIf rdUDICode.Checked = True Then
                                            'SqlIn = "update POUCH_LABEL set Box_Packing =1,Box_By='" & StrLoginUser & "',Injector_Ref ='" & strinj_ref & "',Injector_batch ='" & strinj_batch & "',Box_Date=GETDATE(),Boxtime = GETDATE(),Station = '" & station & "',Injector_Lot = '" & strinj_Lot & "',BoxBTWLabelName = '" & cmbPrintLabel.Text & "' where Udi_code='" & txtlotbarno.Text & "' "

                                            SqlIn = "DECLARE @Udi_code NVARCHAR(100)='" & txtlotbarno.Text & "', @Box_By nvarchar(15)='" & StrLoginUser & "',@Injector_Ref nvarchar(10)='" & strinj_ref & "',@Injector_batch nvarchar(50)='" & strinj_batch & "' ,@Station varchar(50)= '" & station & "' ,@Injector_Lot nvarchar(50)= '" & strinj_Lot & "' ,@BoxBTWLabelName varchar(50)= '" & cmbPrintLabel.Text & "' " & _
                                                  " update temp_POUCH_LABEL_box set Box_Packing =1,Box_By=@Box_By ,Injector_Ref =@Injector_Ref ,Injector_batch=@Injector_batch ,Box_Date=GETDATE(),Boxtime = GETDATE(),Station=@Station ,Injector_Lot=@Injector_Lot ,BoxBTWLabelName =@BoxBTWLabelName where Udi_code=@Udi_code "
                                        Else
                                            MsgBox(" Plese choose Lot Serial or UDI Serial")
                                            Exit Sub
                                        End If
                                        Cmd = New SqlCommand(SqlIn, con)
                                        Cmd.ExecuteNonQuery()
                                        Cmd.Dispose()
                                        'Update Query


                                        lblpackedQty.Text = Val(lblpackedQty.Text) + 1
                                        Exit For
                                    Else
                                        Dim customMsgBox As New CustomMessageBox("Already Scan")
                                        customMsgBox.ShowDialog()
                                        txtlotbarno.Text = ""
                                        txtlotbarno.Focus()
                                        Exit Sub
                                    End If
                                End If

                            Next




                        Else
                            SqlIn = "Insert Into Box_Packing_Reprint_details (Lot_SrNo,Box_By,Injector_Ref,Injector_batch,Boxtime,Station,Injector_Lot,BoxBTWLabelName,Created_By, Created_Date, Modified_By, Modified_Date,IsErpUser, Reprint_User_Level ) " & _
                                    "values ('" & StrLotBarNo & "','" & StrLoginUser & "','" & strinj_ref & "','" & strinj_batch & "',GETDATE(),'" & station & "'," & _
                                    " '" & strinj_Lot & "','" & cmbPrintLabel.Text & "','" & StrLoginUser & "',GETDATE(),'" & StrLoginUser & "',GETDATE(),'" & IsErpUser & "','" & Logged_Reprint_User_Level & "')"
                            UpdateorInsertQuery_Execute(SqlIn)

                        End If


                        Dim cylType As String = ""
                        Dim swiToricModel As String = ""


                        If StrModel = "SPHTORIC 300-T2" Or StrModel = "SPHTORIC 300-T3" Or StrModel = "SPHTORIC 300-T4" Or StrModel = "SPHTORIC 300-T5" Or StrModel = "SPHTORIC 300-T6" Or StrModel = "SPHTORIC 300-T7" Or StrModel = "SPHTORIC 300-T8" Or StrModel = "SPHTORIC 300-T9" Then
                            Dim splitResult As String() = StrModel.Split(New Char() {"-"c})
                            cylType = splitResult(1)
                            swiToricModel = splitResult(0)
                        End If


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
                        bt.SetNamedSubStringValue("Lotno", StrLotBarNo.Replace(" ", ""))
                        bt.SetNamedSubStringValue("Apwr", strApwr & " D")
                        bt.SetNamedSubStringValue("UdiEanCode", StrUdiEanCode)
                        bt.SetNamedSubStringValue("Inj_ref", strinj_ref)
                        bt.SetNamedSubStringValue("Inj_lot", strinj_batch)
                        bt.SetNamedSubStringValue("Inj_lotno", strinj_Lot)
                        bt.SetNamedSubStringValue("cyl", strcyl)
                        bt.SetNamedSubStringValue("Bdname", strbdname)
                        bt.SetNamedSubStringValue("RefName", StrRefName)
                        If strbdname = "SWISSPHOB TORIC" Then
                            bt.SetNamedSubStringValue("cylType", cylType)
                            bt.SetNamedSubStringValue("swiToricModel", swiToricModel)
                        End If

                        If cmbPrintLabel.Text.Contains("MORRACO") Then
                            bt.SetNamedSubStringValue("mor_bar", StrLotBarNo + "," + Strbtc_No + "," + StrExp)
                        End If


                        'bt.SetNamedSubStringValue("injexp", strinjexp)
                        'bt.SetNamedSubStringValue("price", Strprice)
                        'bt.SetNamedSubStringValue("RefName", StrRefName)StrLotBarNo
                        'bt.SetNamedSubStringValue("injexp", StrInexp1)

                        bt.PrintOut()

                        ''save Btw file-2024-08-27
                        'Dim pdfFilePath As String = Application.StartupPath & "\" & DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") & "-" & StrLotBarNo & "-" & StrFName & ""
                        'bt.SaveAs(pdfFilePath)
                        ''------------


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
                Catch ex As Exception
                    MsgBox("An unexpected error occurred.")
                    Exit Sub

                End Try



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


                    'ElseIf StrModel = "SUPRAPHOB BBY" Then

                    '    btFile = Application.StartupPath & "\SUPRA_PHOB_BBY.btw"
                    '    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    '    bt.SetNamedSubStringValue("Model", StrModel)
                    '    bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                    '    bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                    '    bt.SetNamedSubStringValue("Len", StrLength & " mm")
                    '    bt.SetNamedSubStringValue("mfdate", StrMfD)
                    '    bt.SetNamedSubStringValue("Expdt", StrExp)
                    '    bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                    '    bt.SetNamedSubStringValue("Apwr", strApwr & " D")
                    '    bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                    '    bt.SetNamedSubStringValue("btcno", Strbtc_No)
                    '    bt.SetNamedSubStringValue("Aconst", StrAConst)
                    '    bt.SetNamedSubStringValue("EanCode", StrEanCode)
                    '    'bt.SetNamedSubStringValue("price", Strprice)
                    '    bt.PrintOut()
                    '    bt.Close()
                    '    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

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

                    'ElseIf StrModel = "SPNT200" Or StrModel = "SPNT300" Or StrModel = "HPNT200" Or StrModel = "SPNTY200" Or StrModel = "SPNT300-PL" Then

                    '    btFile = Application.StartupPath & "\SUPRA_PHOB.btw"
                    '    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    '    bt.SetNamedSubStringValue("Model", StrModel)
                    '    'bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                    '    bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                    '    'bt.SetNamedSubStringValue("Len", StrLength & " mm")
                    '    bt.SetNamedSubStringValue("Expdt", StrExp)
                    '    bt.SetNamedSubStringValue("mfdate", StrMfD)
                    '    bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                    '    bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                    '    bt.SetNamedSubStringValue("Lot", Strbtc_No)
                    '    'bt.SetNamedSubStringValue("Aconst", StrAConst)
                    '    bt.SetNamedSubStringValue("EanCode", StrEanCode)
                    '    bt.SetNamedSubStringValue("Inj_ref", strinj_ref)
                    '    bt.SetNamedSubStringValue("Inj_lot", strinj_batch)
                    '    'bt.SetNamedSubStringValue("price", Strprice)
                    '    bt.PrintOut()
                    '    bt.Close()
                    '    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                ElseIf StrModel = "SPNT200" Or StrModel = "SPNT300" Or StrModel = "HPNT200" Or StrModel = "SPNTY200" Or StrModel = "SPNT300-PL" Then

                    If rbPreloader.Checked Then
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
                    Else
                        btFile = Application.StartupPath & "\SUPRA_PHOB_NONPRELOADER.btw"
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

                    End If

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
                SqlIn = "update POUCH_LABEL set Box_Packing =1,Box_By='" & StrLoginUser & "',Injector_Ref ='" & strinj_ref & "',Injector_batch ='" & strinj_batch & "',Box_Date=GETDATE(),Boxtime = GETDATE(),Station = '" & station & "' where Lot_SrNo='" & txtlotbarno.Text & "' "
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
                MsgBox(" END OF THE PROGRAM")
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


                    'ElseIf StrModel = "SUPRAPHOB BBY" Then

                    '    btFile = Application.StartupPath & "\SUPRA_PHOB_BBY.btw"
                    '    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    '    bt.SetNamedSubStringValue("Model", StrModel)
                    '    bt.SetNamedSubStringValue("Opt1", StrOptic & " mm")
                    '    bt.SetNamedSubStringValue("TwoD", StrTwoDBar)
                    '    bt.SetNamedSubStringValue("Len", StrLength & " mm")
                    '    bt.SetNamedSubStringValue("mfdate", StrMfD)
                    '    bt.SetNamedSubStringValue("Expdt", StrExp)
                    '    bt.SetNamedSubStringValue("Pwr", StrLotPower & " D")
                    '    bt.SetNamedSubStringValue("Apwr", strApwr & " D")
                    '    bt.SetNamedSubStringValue("LotSr", StrLotBarNo)
                    '    bt.SetNamedSubStringValue("btcno", Strbtc_No)
                    '    bt.SetNamedSubStringValue("Aconst", StrAConst)
                    '    bt.SetNamedSubStringValue("EanCode", StrEanCode)
                    '    'bt.SetNamedSubStringValue("price", Strprice)
                    '    bt.PrintOut()
                    '    bt.Close()
                    '    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

                ElseIf StrModel = "SPNT200" Or StrModel = "SPNT300" Or StrModel = "HPNT200" Or StrModel = "SPNTY200" Or StrModel = "SPNT300-PL" Or StrModel = "SUPRAPHOB BBY" Or StrModel = "SUPRAPHOB BBY" Then

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

    Private Sub rbnonpreloader_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnonpreloader.CheckedChanged
        GroupBox7.Visible = True

    End Sub

    Private Sub rbPreloader_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPreloader.CheckedChanged
        GroupBox7.Visible = False
    End Sub

    Private Sub txtlotbarno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlotbarno.TextChanged

    End Sub

    Private Sub BtnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStart.Click

        Try
            If ChkCST.Checked = True Then
                If Cmbbtc.SelectedItem Is Nothing Then
                    MsgBox(" Please select valid Batch")
                    Cmbbtc.Text = ""
                    Cmbbtc.Focus()
                    Exit Sub
                End If

                'cha-
                If cmbModel.SelectedItem Is Nothing Then
                    MsgBox(" Please select valid Model")
                    cmbModel.Text = ""
                    cmbModel.Focus()
                    Exit Sub
                End If

                strsql = "DECLARE @Bpl_no NVARCHAR(50)='" & Cmbbtc.Text & "',@Station VARCHAR(50)  = '" & station & "', @Model_Name VARCHAR(50)='" & cmbModel.Text & "' Insert Into Lens_BPL( Bpl_no, Active, Created_By, Created_Date, Modified_By, Modified_Date, station,Model_Name) " & _
                               "values (@Bpl_no,'YES','" & StrLoginUser & "',GETDATE() ,'" & StrLoginUser & "',GETDATE(),@Station, @Model_Name)"
                UpdateorInsertQuery_Execute(strsql)

                strsql = "DECLARE @Btc_No NVARCHAR(50)='" & Cmbbtc.Text & "', @Model_Name VARCHAR(50)='" & cmbModel.Text & "'  INSERT INTO temp_POUCH_LABEL_box " & _
            "SELECT Brand_Name, Model_Name, Reference_Name, GS_Code, Power, Optic, Length, Lot_Unit, A_Constant, Type_GS_Code, Lot_Prefix, Lot_No, Lot_SrNo, Mfd_Month, Mfd_Year, Exp_Month,  " & _
            "Exp_Year, Sterilization, Sterilization_No, Sample_Taken, Type_Sample, BPL_Taken, BPL_NO, Box_Packing, Dc_Packing_List, DCL_No, Dc_Packing, Dc_No, Sterilization_After, " & _
            "Sterilization_No_After, Sterilization_Reject, Qty_1, Type, Box_Reject, Box_Reject_Date, Box_Reject_By, Sterilization_Date, Sterilization_By, Box_By, Box_Date, Print_Name, Packing_Model, " & _
            "Ord_Country, Btc_No, price, Sterility_Comp_Date, Sterility_Status, Injector_Ref, Injector_batch, R_Power, Cylsize, rotlex_type, Label, RefLot, Status, MTS_No, Box_No, Dc_Status, Product_code, " & _
            " PouchPrint, PowerPrint, Export_Qty, Box_Type, Boxtime, PouchStation, Station, PouchBTWLabelName, Udi_code, Injector_Lot, pouchRepack_staus, BPL_Collection_Status, bpl_cancel_status, " & _
            " BPL_Collected_by, Repk_Scanned, Areation_Status, Areation_scan, Sterilization_scan, Pouch_Order_Type, Pouch_Order_Country, Areation_Scan_No, BoxBTWLabelName " & _
            "FROM POUCH_LABEL " & _
            "WHERE Sterilization = 1 AND Sterilization_After = 1 AND Sterilization_Reject = 0 AND (Box_Packing = 0)  AND (Box_Reject = 0) AND (Dc_Packing = 0) AND (Sample_Taken = 1) and Type_Sample='CST'  AND (Btc_No = @Btc_No)  AND (Model_Name = @Model_Name) "

                UpdateorInsertQuery_Execute(strsql)
                Cmbbtc.Enabled = False
                'cha-
                cmbModel.Enabled = False
                BtnStart.Visible = False

                load_grid()

                ColorCode_SerialLoad()

            Else
                If cmbBPL.SelectedItem Is Nothing Then
                    MsgBox(" Please select valid BPL")
                    txtlotbarno.Text = ""
                    txtlotbarno.Focus()
                    Exit Sub
                End If
                strsql = "DECLARE @Bpl_no NVARCHAR(50)='" & cmbBPL.Text & "',@Station VARCHAR(50)  = '" & station & "' Insert Into Lens_BPL( Bpl_no, Active, Created_By, Created_Date, Modified_By, Modified_Date, station) " & _
                                       "values (@Bpl_no,'YES','" & StrLoginUser & "',GETDATE() ,'" & StrLoginUser & "',GETDATE(),@Station)"
                UpdateorInsertQuery_Execute(strsql)

                strsql = "DECLARE @Bpl_no NVARCHAR(50)='" & cmbBPL.Text & "' INSERT INTO temp_POUCH_LABEL_box " & _
            "SELECT Brand_Name, Model_Name, Reference_Name, GS_Code, Power, Optic, Length, Lot_Unit, A_Constant, Type_GS_Code, Lot_Prefix, Lot_No, Lot_SrNo, Mfd_Month, Mfd_Year, Exp_Month,  " & _
            "Exp_Year, Sterilization, Sterilization_No, Sample_Taken, Type_Sample, BPL_Taken, BPL_NO, Box_Packing, Dc_Packing_List, DCL_No, Dc_Packing, Dc_No, Sterilization_After, " & _
            "Sterilization_No_After, Sterilization_Reject, Qty_1, Type, Box_Reject, Box_Reject_Date, Box_Reject_By, Sterilization_Date, Sterilization_By, Box_By, Box_Date, Print_Name, Packing_Model, " & _
            "Ord_Country, Btc_No, price, Sterility_Comp_Date, Sterility_Status, Injector_Ref, Injector_batch, R_Power, Cylsize, rotlex_type, Label, RefLot, Status, MTS_No, Box_No, Dc_Status, Product_code, " & _
            " PouchPrint, PowerPrint, Export_Qty, Box_Type, Boxtime, PouchStation, Station, PouchBTWLabelName, Udi_code, Injector_Lot, pouchRepack_staus, BPL_Collection_Status, bpl_cancel_status, " & _
            " BPL_Collected_by, Repk_Scanned, Areation_Status, Areation_scan, Sterilization_scan, Pouch_Order_Type, Pouch_Order_Country, Areation_Scan_No, BoxBTWLabelName " & _
            "FROM POUCH_LABEL " & _
            "WHERE (Box_Packing = 0) AND (BPL_Taken = 1) AND (Box_Reject = 0) AND (BPL_NO IS NOT NULL) AND (Dc_Packing = 0) AND (Sample_Taken = 0)  AND  (BPL_Collection_Status=1) AND  (Sterilization_Reject=0) AND (BPL_NO = @Bpl_no)"

                UpdateorInsertQuery_Execute(strsql)
                cmbBPL.Enabled = False
                BtnStart.Visible = False

                load_grid()

                ColorCode_SerialLoad()

            End If


        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
    End Sub

    Private Sub btn_complete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_complete.Click
        If lblpackedQty.Text <> 0 Then

            If lblpackedQty.Text = lblTotalQty.Text Then

                Try
                    If ChkCST.Checked = True Then

                        Dim lot_Serial_numbers As String = ""
                        For i = 0 To DataGridView2.Rows.Count - 2
                            lot_Serial_numbers = lot_Serial_numbers + "'" + DataGridView2.Rows(i).Cells("Lot_srno").Value.ToString() + "',"
                        Next i

                        lot_Serial_numbers = lot_Serial_numbers.Remove(lot_Serial_numbers.Length - 1, 1)

                        'update Box_By ,Station  
                        strsql = "DECLARE @Btc_No NVARCHAR(50)='" & Cmbbtc.Text & "'  SELECT DISTINCT Box_Packing, Box_By, Station " & _
                                "FROM         temp_POUCH_LABEL_box " & _
                                " WHERE  Btc_No = @Btc_No " & _
                                " and  Lot_SrNo IN (" & lot_Serial_numbers & ")"

                        ds = SQL_SelectQuery_Execute(strsql)
                        If ds.Tables(0).Rows.Count = 1 Then

                            strsql = "DECLARE @Box_By nvarchar(15)='" & ds.Tables(0).Rows(0)("Box_By") & "',@Station VARCHAR(50)  = '" & ds.Tables(0).Rows(0)("Station") & "'  Update POUCH_LABEL set Box_Packing =1,Box_By=@Box_By , Box_Date=GETDATE(), Station=@Station     where Lot_SrNo IN (" & lot_Serial_numbers & " ) "
                            UpdateorInsertQuery_Execute(strsql)

                        Else
                            MsgBox("No Data found (or) Box_By or Station  Multiple time present in  temp_POUCH_LABEL_Box against the Batch (" + Cmbbtc.Text + ")  ")
                            txtlotbarno.Focus()
                            Exit Sub
                        End If


                        'update Boxtime ,Injector_Ref , Injector_batch, BoxBTW
                        Dim update_query_boxtime As String = ""
                        Dim update_query_injref As String = ""
                        Dim update_query_injbatch As String = ""
                        Dim update_query_boxBTW As String = ""

                        strsql = "DECLARE @Btc_No NVARCHAR(50)='" & Cmbbtc.Text & "' SELECT Lot_SrNo, Boxtime, Injector_Ref,Injector_batch ,BoxBTWLabelName " & _
                                "FROM         temp_POUCH_LABEL_box " & _
                                " WHERE  Btc_No = @Btc_No " & _
                                " and  Lot_SrNo IN (" & lot_Serial_numbers & ")"
                        ds = SQL_SelectQuery_Execute(strsql)

                        If ds.Tables(0).Rows.Count > 0 Then
                            For Each eachRow As DataRow In ds.Tables(0).Rows
                                update_query_boxtime = update_query_boxtime + " WHEN lot_srno = '" + eachRow("Lot_SrNo").ToString() + "' THEN '" + DateTime.Parse(eachRow("Boxtime").ToString()).ToString("yyyy-MM-dd HH:mm:ss") + "' "
                                update_query_injref = update_query_injref + " WHEN lot_srno = '" + eachRow("Lot_SrNo").ToString() + "' THEN '" + eachRow("Injector_Ref").ToString() + "' "
                                update_query_injbatch = update_query_injbatch + " WHEN lot_srno = '" + eachRow("Lot_SrNo").ToString() + "' THEN '" + eachRow("Injector_batch").ToString() + "' "
                                update_query_boxBTW = update_query_boxBTW + " WHEN lot_srno = '" + eachRow("Lot_SrNo").ToString() + "' THEN '" + eachRow("BoxBTWLabelName").ToString() + "' "


                            Next

                            strsql = "UPDATE    POUCH_LABEL SET              Boxtime = (CASE  _boxtime_ END),  Injector_Ref= (CASE  _injref_ END), Injector_batch= (CASE  _injbatch_ END), BoxBTWLabelName= (CASE  _boxbTW_ END)  WHERE     (Lot_SrNo IN (" & lot_Serial_numbers & ")) "
                            strsql = strsql.Replace("_boxtime_", update_query_boxtime)
                            strsql = strsql.Replace("_injref_", update_query_injref)
                            strsql = strsql.Replace("_injbatch_", update_query_injbatch)
                            strsql = strsql.Replace("_boxbTW_", update_query_boxBTW)

                            UpdateorInsertQuery_Execute(strsql)


                        End If


                        strsql = "DECLARE @Btc_No NVARCHAR(50)='" & Cmbbtc.Text & "' DELETE FROM temp_POUCH_LABEL_box WHERE     (Btc_No = @Btc_No ) and Box_packing='1' "
                        UpdateorInsertQuery_Execute(strsql)

                        strsql = "DECLARE @Bpl_no NVARCHAR(50)='" & Cmbbtc.Text & "' UPDATE    Lens_BPL SET              Active = 'NO' WHERE     (Bpl_no = @Bpl_no) "
                        UpdateorInsertQuery_Execute(strsql)


                        MsgBox("Saved")
                        Cmbbtc.Text = ""
                        DataGridView2.Rows.Clear()
                        lblpackedQty.Text = "0"
                        lblTotalQty.Text = "0"


                        BatchNo_Load()





                    Else
                        Dim lot_Serial_numbers As String = ""
                        For i = 0 To DataGridView2.Rows.Count - 2
                            lot_Serial_numbers = lot_Serial_numbers + "'" + DataGridView2.Rows(i).Cells("Lot_srno").Value.ToString() + "',"
                        Next i

                        lot_Serial_numbers = lot_Serial_numbers.Remove(lot_Serial_numbers.Length - 1, 1)

                        'update Box_By ,Station , BoxBTWLabelName
                        strsql = "DECLARE @bpl_no NVARCHAR(50)='" & cmbBPL.Text & "'  SELECT DISTINCT Box_Packing, Box_By, Station, BoxBTWLabelName " & _
                                "FROM         temp_POUCH_LABEL_box " & _
                                " WHERE  bpl_no = @bpl_no " & _
                                " and  Lot_SrNo IN (" & lot_Serial_numbers & ")"

                        ds = SQL_SelectQuery_Execute(strsql)

                        If ds.Tables(0).Rows.Count = 1 Then
                            strsql = "DECLARE @Box_By nvarchar(15)='" & ds.Tables(0).Rows(0)("Box_By") & "',@Station VARCHAR(50)  = '" & ds.Tables(0).Rows(0)("Station") & "' ,@BoxBTWLabelName VARCHAR(50)='" & ds.Tables(0).Rows(0)("BoxBTWLabelName") & "' Update POUCH_LABEL set  Box_Packing =1,Box_By=@Box_By , Box_Date=GETDATE(), Station=@Station   ,BoxBTWLabelName = @BoxBTWLabelName where Lot_SrNo IN (" & lot_Serial_numbers & ") "
                            UpdateorInsertQuery_Execute(strsql)
                        Else
                            MsgBox("No Data found (or) Box_By or Station or BoxBTWLabelName Multiple time present in  temp_POUCH_LABEL_Box against the BPL (" + cmbBPL.Text + ")  ")
                            txtlotbarno.Focus()
                            Exit Sub
                        End If


                        'update Boxtime ,Injector_Ref , Injector_batch
                        Dim update_query_boxtime As String = ""
                        Dim update_query_injref As String = ""
                        Dim update_query_injbatch As String = ""

                        strsql = "DECLARE @bpl_no NVARCHAR(50)='" & cmbBPL.Text & "' SELECT Lot_SrNo, Boxtime, Injector_Ref,Injector_batch " & _
                                "FROM         temp_POUCH_LABEL_box " & _
                                " WHERE  bpl_no = @bpl_no " & _
                                " and  Lot_SrNo IN (" & lot_Serial_numbers & ")"
                        ds = SQL_SelectQuery_Execute(strsql)

                        If ds.Tables(0).Rows.Count > 0 Then
                            For Each eachRow As DataRow In ds.Tables(0).Rows
                                update_query_boxtime = update_query_boxtime + " WHEN lot_srno = '" + eachRow("Lot_SrNo").ToString() + "' THEN '" + DateTime.Parse(eachRow("Boxtime").ToString()).ToString("yyyy-MM-dd HH:mm:ss") + "' "
                                update_query_injref = update_query_injref + " WHEN lot_srno = '" + eachRow("Lot_SrNo").ToString() + "' THEN '" + eachRow("Injector_Ref").ToString() + "' "
                                update_query_injbatch = update_query_injbatch + " WHEN lot_srno = '" + eachRow("Lot_SrNo").ToString() + "' THEN '" + eachRow("Injector_batch").ToString() + "' "
                            Next

                            strsql = "UPDATE    POUCH_LABEL SET              Boxtime = (CASE  _boxtime_ END),  Injector_Ref= (CASE  _injref_ END), Injector_batch= (CASE  _injbatch_ END) WHERE     (Lot_SrNo IN (" & lot_Serial_numbers & ")) "
                            strsql = strsql.Replace("_boxtime_", update_query_boxtime)
                            strsql = strsql.Replace("_injref_", update_query_injref)
                            strsql = strsql.Replace("_injbatch_", update_query_injbatch)
                            UpdateorInsertQuery_Execute(strsql)


                        End If




                        strsql = "DECLARE @bpl_no NVARCHAR(50)='" & cmbBPL.Text & "' DELETE FROM temp_POUCH_LABEL_box WHERE     (BPL_No = @bpl_no ) and Box_packing='1' "
                        UpdateorInsertQuery_Execute(strsql)

                        strsql = "DECLARE @bpl_no NVARCHAR(50)='" & cmbBPL.Text & "' UPDATE    Lens_BPL SET              Active = 'NO' WHERE     (Bpl_no = @bpl_no) "
                        UpdateorInsertQuery_Execute(strsql)


                        MsgBox("Saved")
                        cmbBPL.Text = ""
                        DataGridView2.Rows.Clear()
                        lblpackedQty.Text = "0"
                        lblTotalQty.Text = "0"

                        BPL_No_Bind()
                    End If


                Catch ex As Exception
                    MsgBox("An unexpected error occurred.")
                    Exit Sub
                End Try
                
               

            Else
                MsgBox("BPL or Batch Not fully packed. Please check")
                txtlotbarno.Focus()
            End If

        End If

    End Sub

    Private Sub ChkCST_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkCST.CheckedChanged
        DataGridView2.Rows.Clear()
        If ChkCST.Checked = True Then

            BatchNo_Load()

        Else
            BPL_No_Bind()


        End If


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTC.Click

    End Sub

    Private Sub GroupBox11_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox11.Enter

    End Sub

    Private Sub Cmbbtc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbbtc.SelectedIndexChanged
        strsql = "select distinct Model_Name from Pouch_Label where Btc_No = '" & Cmbbtc.Text & "' and  Sterilization = 1 AND Sterilization_After = 1 AND Sterilization_Reject = 0 AND (Box_Packing = 0)  AND (Box_Reject = 0) AND (Dc_Packing = 0) AND (Sample_Taken = 1) and Type_Sample='CST'  "
        ds = SQL_SelectQuery_Execute(strsql)
        cmbModel.DisplayMember = "Model_Name"
        cmbModel.DataSource = ds.Tables(0)
    End Sub
End Class