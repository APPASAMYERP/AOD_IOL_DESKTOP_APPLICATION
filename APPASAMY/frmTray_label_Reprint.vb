Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class frmTray_label_Reprint
    Dim Ds As New DataSet
    Dim bt As New BarTender.Format
    Dim bApp As New BarTender.Application
    Dim btFile As String
    Dim Sql As String

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

    Public Function RackLocationBindForReprint() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = "SELECT DISTINCT Rack_Location from POUCH_LABEL  WHERE (Tray_No IS NOT NULL) AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) order by Rack_Location"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function
    Public Function SterileBatchBindForReprint() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = "SELECT DISTINCT Btc_No from POUCH_LABEL  WHERE    ( (Mfd_Year = '2023') AND (Mfd_Month NOT IN ('1', '2', '3', '4'))   OR (Mfd_Year >= '2024') ) AND (Tray_No IS NOT NULL) AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) order by Btc_No"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Public Function getDistinctTrayNumber() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = "SELECT DISTINCT Tray_No AS tray_no from POUCH_LABEL  WHERE   (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) order by Tray_No"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function


    Private Sub frmTray_label_Reprint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Rack Location Load
            Ds = RackLocationBindForReprint()
            cmbRackLocation.DataSource = Ds.Tables(0)
            cmbRackLocation.DisplayMember = "Rack_Location"

            'Tray No Load
            Ds = getDistinctTrayNumber()
            cmbTray1.DataSource = Ds.Tables(0)
            cmbTray1.DisplayMember = "tray_no"


            'Tray No load with Sterile Batch
            Ds = SterileBatchBindForReprint()
            cmbStrBatchReprint.Items.Clear()
            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                cmbStrBatchReprint.Items.Add(eachRow1("Btc_No"))
            Next

            'TEST
            Ds = getDistinctRackNumbers()
            ComboBox1.Items.Clear()
            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                ComboBox1.Items.Add(eachRow1("Rack"))
            Next
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try

        
    End Sub

    Public Function getDistinctTrayNumberForReprint() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = "SELECT DISTINCT Tray_No AS tray_no from POUCH_LABEL  WHERE (Btc_No = '" & cmbStrBatchReprint.Text & "') AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) order by Tray_No"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Private Sub cmbStrBatchReprint_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStrBatchReprint.SelectedIndexChanged
        Try
            Ds = getDistinctTrayNumberForReprint()
            cmbTrayNo.Items.Clear()
            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                cmbTrayNo.Items.Add(eachRow1("tray_no"))
            Next
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try

        
    End Sub
    Public Function getTrayDetail(ByVal trayNumber As String) As DataSet

        Dim ds As New DataSet
        Dim StrSql As String
        Dim trayDetail As String = Nothing

        StrSql = "SELECT     CAST(Power AS varchar) + ' - ' + Lot_Prefix + Lot_No + ' ' + RIGHT('00' + CAST(MIN(St_SrNo) AS varchar), 3)  + ' TO ' + RIGHT('00' + CAST(MAX(St_SrNo) AS varchar), 3)    AS TrayDeatil, Model_Name, Power, Btc_No, Lot_Prefix+Lot_No AS lotno, MIN(St_SrNo) AS SFROM, MAX(St_SrNo) AS STO, SUM(Qty_1) AS Qty, Tray_No , Rack_Location FROM POUCH_LABEL  WHERE  (Btc_No = '" & cmbStrBatchReprint.Text & "') AND (Tray_No = '" & trayNumber & "') AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) GROUP BY Model_Name, Power, Btc_No, Lot_Prefix, Lot_No, Tray_No, Rack_Location ORDER BY Lot_Prefix, Lot_No"
       

        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds
        'For Each eachRow As DataRow In ds.Tables(0).Rows
        '    trayDetail = trayDetail + Environment.NewLine + eachRow("TrayDeatil").ToString()
        'Next
        'Return trayDetail
    End Function
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Try
            Dim trayDetail As String = Nothing
            Dim trayModel As String = Nothing
            Dim RackNo As String = Nothing
            Dim dsTrayDetail As New DataSet


            'PHOBIC
            Dim trayPower As String = Nothing
            Dim trayLotNo As String = Nothing
            Dim StSrNo As Integer = 200
            Dim EnSrNo As Integer = 0
            Dim totTrayQty As Integer = 0

            If cmbStrBatchReprint.Text = "" Or cmbTrayNo.Text = "" Then
                MessageBox.Show("Please Choose the Tray Number")
                Exit Sub
            End If


            If cmbStrBatchReprint.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Batch")
                cmbStrBatchReprint.Focus()
                Exit Sub
            End If

            If cmbTrayNo.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Tray")
                cmbTrayNo.Focus()
                Exit Sub
            End If

            Dim StrFName As String = ""
            If productline = "PMMA" Then
                StrFName = "Tray_Label_PMMA.btw"
            ElseIf productline = "PHILIC" Then
                StrFName = "Tray_Label_philic.btw"
            ElseIf productline = "PHOBIC" Then
                StrFName = "Tray_Label_phobic.btw"
            ElseIf productline = "PHOBIC NONPRELOADED" Then
                StrFName = "Tray_Label_phobic.btw"
            End If

            btFile = Application.StartupPath & "\" & StrFName & ""
            If System.IO.File.Exists(btFile) Then
                'The file exists
            Else
                MessageBox.Show("BTW file record not found")
                Exit Sub
            End If

            Dim traydetailRowCount As Integer = 0
            dsTrayDetail = getTrayDetail(cmbTrayNo.Text)
            For Each eachRecord As DataRow In dsTrayDetail.Tables(0).Rows
                trayDetail = trayDetail + Environment.NewLine + eachRecord("TrayDeatil").ToString()
                trayModel = eachRecord("Model_Name").ToString()
                RackNo = eachRecord("Rack_Location").ToString()

                'PHOBIC
                trayPower = trayPower + Environment.NewLine + eachRecord("Power").ToString()
                trayLotNo = eachRecord("lotno").ToString()
                If StSrNo > Convert.ToInt32(eachRecord("SFROM")) Then
                    StSrNo = Convert.ToInt32(eachRecord("SFROM"))
                End If
                If EnSrNo < Convert.ToInt32(eachRecord("STO")) Then
                    EnSrNo = Convert.ToInt32(eachRecord("STO"))
                End If
                totTrayQty = totTrayQty + Convert.ToInt32(eachRecord("Qty"))

                'Next Label print
                traydetailRowCount = traydetailRowCount + 1
                'If productline = "PHILIC" Then
                If traydetailRowCount = 6 Then
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("trayDetail", trayDetail)
                    bt.SetNamedSubStringValue("model", trayModel)
                    bt.SetNamedSubStringValue("trayNo", cmbTrayNo.Text)
                    bt.SetNamedSubStringValue("batchNo", cmbStrBatchReprint.Text)

                    'PHOBIC
                    bt.SetNamedSubStringValue("power", trayPower)
                    bt.SetNamedSubStringValue("lotno", trayLotNo)
                    bt.SetNamedSubStringValue("sFrom", StSrNo)
                    bt.SetNamedSubStringValue("sTo", EnSrNo)
                    bt.SetNamedSubStringValue("qty", totTrayQty)
                    bt.SetNamedSubStringValue("rackNo", RackNo)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                    traydetailRowCount = 0
                    trayDetail = ""
                    trayModel = ""
                    totTrayQty = 0
                End If
                ' End If

            Next

            If traydetailRowCount = 0 Then 'productline = "PHILIC" And 
            Else
                bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                bt.SetNamedSubStringValue("trayDetail", trayDetail)
                bt.SetNamedSubStringValue("model", trayModel)
                bt.SetNamedSubStringValue("trayNo", cmbTrayNo.Text)
                bt.SetNamedSubStringValue("batchNo", cmbStrBatchReprint.Text)

                'PHOBIC
                bt.SetNamedSubStringValue("power", trayPower)
                bt.SetNamedSubStringValue("lotno", trayLotNo)
                bt.SetNamedSubStringValue("sFrom", StSrNo)
                bt.SetNamedSubStringValue("sTo", EnSrNo)
                bt.SetNamedSubStringValue("qty", totTrayQty)

                bt.SetNamedSubStringValue("rackNo", RackNo)

                bt.PrintOut()
                bt.Close()
                System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

            End If
            cmbStrBatchReprint.Text = ""
            cmbTrayNo.Text = ""
            clear()
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try


        
    End Sub
    Public Function getTrayNumber(ByVal rackLocation As String) As DataSet

        Dim ds As New DataSet
        Dim StrSql As String
        StrSql = "SELECT  DISTINCT Tray_No  FROM POUCH_LABEL  WHERE  (Rack_Location = '" & rackLocation & "') AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1)  ORDER BY Tray_No"
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Public Function getTrayDetail_RackBased(ByVal trayNumber As String) As DataSet

        Dim ds As New DataSet
        Dim StrSql As String
        Dim trayDetail As String = Nothing
        StrSql = "SELECT     CAST(Power AS varchar) + ' - ' + Lot_Prefix + Lot_No + ' ' + RIGHT('00' + CAST(MIN(St_SrNo) AS varchar), 3)  + ' TO ' + RIGHT('00' + CAST(MAX(St_SrNo) AS varchar), 3)   AS TrayDeatil, Model_Name, Power, Btc_No, Lot_Prefix+Lot_No AS lotno, MIN(St_SrNo) AS SFROM, MAX(St_SrNo) AS STO, SUM(Qty_1) AS Qty, Tray_No , Rack_Location FROM POUCH_LABEL  WHERE  (Rack_location = '" & cmbRackLocation.Text & "') AND (Tray_No = '" & trayNumber & "') AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) GROUP BY Model_Name, Power, Btc_No, Lot_Prefix, Lot_No, Tray_No, Rack_Location ORDER BY Lot_Prefix, Lot_No"

        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds
        'For Each eachRow As DataRow In ds.Tables(0).Rows
        '    trayDetail = trayDetail + Environment.NewLine + eachRow("TrayDeatil").ToString()
        'Next
        'Return trayDetail
    End Function

    Private Sub btnPrintRackWise_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintRackWise.Click

        Try
            Dim trayDetail As String = Nothing
            Dim trayModel As String = Nothing
            Dim RackNo As String = Nothing
            Dim dsTrayDetail, dsDistinctTray As New DataSet



            'PHOBIC
            Dim trayPower As String = Nothing
            Dim trayLotNo As String = Nothing
            Dim trayNo As String = Nothing
            Dim str_batch As String = Nothing
            Dim StSrNo As Integer = 200
            Dim EnSrNo As Integer = 0
            Dim totTrayQty As Integer = 0

            If cmbRackLocation.Text = "" Then
                MessageBox.Show("Please Choose the Rack Location")
                Exit Sub
            End If

            If cmbRackLocation.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Rack location")
                cmbRackLocation.Focus()
                Exit Sub
            End If


            Dim StrFName As String = ""
            If productline = "PMMA" Then
                StrFName = "Tray_Label_PMMA.btw"
            ElseIf productline = "PHILIC" Then
                StrFName = "Tray_Label_philic.btw"
            ElseIf productline = "PHOBIC" Then
                StrFName = "Tray_Label_phobic.btw"
            ElseIf productline = "PHOBIC NONPRELOADED" Then
                StrFName = "Tray_Label_phobic.btw"
            End If

            btFile = Application.StartupPath & "\" & StrFName & ""
            If System.IO.File.Exists(btFile) Then
                'The file exists
            Else
                MessageBox.Show("BTW file record not found")
                Exit Sub
            End If

            dsDistinctTray = getTrayNumber(cmbRackLocation.Text)

            Dim traydetailRowCount As Integer = 0
            For Each eachRow As DataRow In dsDistinctTray.Tables(0).Rows
                StSrNo = 200
                EnSrNo = 0
                traydetailRowCount = 0
                trayDetail = ""
                trayModel = ""
                totTrayQty = 0

                dsTrayDetail = getTrayDetail_RackBased(eachRow("Tray_No").ToString())
                For Each eachRecord As DataRow In dsTrayDetail.Tables(0).Rows
                    trayDetail = trayDetail + Environment.NewLine + eachRecord("TrayDeatil").ToString()
                    trayModel = eachRecord("Model_Name").ToString()
                    RackNo = eachRecord("Rack_Location").ToString()
                    trayNo = eachRecord("Tray_No").ToString()
                    str_batch = eachRecord("Btc_No").ToString()
                    'PHOBIC
                    trayPower = trayPower + Environment.NewLine + eachRecord("Power").ToString()
                    trayLotNo = eachRecord("lotno").ToString()
                    If StSrNo > Convert.ToInt32(eachRecord("SFROM")) Then
                        StSrNo = Convert.ToInt32(eachRecord("SFROM"))
                    End If
                    If EnSrNo < Convert.ToInt32(eachRecord("STO")) Then
                        EnSrNo = Convert.ToInt32(eachRecord("STO"))
                    End If
                    totTrayQty = totTrayQty + Convert.ToInt32(eachRecord("Qty"))

                    'Next Label print
                    traydetailRowCount = traydetailRowCount + 1
                    'If productline = "PHILIC" Then
                    If traydetailRowCount = 6 Then
                        bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                        bt.SetNamedSubStringValue("trayDetail", trayDetail)
                        bt.SetNamedSubStringValue("model", trayModel)
                        bt.SetNamedSubStringValue("trayNo", trayNo)
                        bt.SetNamedSubStringValue("batchNo", str_batch)

                        'PHOBIC
                        bt.SetNamedSubStringValue("power", trayPower)
                        bt.SetNamedSubStringValue("lotno", trayLotNo)
                        bt.SetNamedSubStringValue("sFrom", StSrNo)
                        bt.SetNamedSubStringValue("sTo", EnSrNo)
                        bt.SetNamedSubStringValue("qty", totTrayQty)
                        bt.SetNamedSubStringValue("rackNo", RackNo)
                        bt.PrintOut()
                        bt.Close()
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                        traydetailRowCount = 0
                        trayDetail = ""
                        trayModel = ""
                        totTrayQty = 0
                    End If
                    'End If

                Next

                If traydetailRowCount = 0 Then 'productline = "PHILIC" And 
                Else
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("trayDetail", trayDetail)
                    bt.SetNamedSubStringValue("model", trayModel)
                    bt.SetNamedSubStringValue("trayNo", trayNo)
                    bt.SetNamedSubStringValue("batchNo", str_batch)

                    'PHOBIC
                    bt.SetNamedSubStringValue("power", trayPower)
                    bt.SetNamedSubStringValue("lotno", trayLotNo)
                    bt.SetNamedSubStringValue("sFrom", StSrNo)
                    bt.SetNamedSubStringValue("sTo", EnSrNo)
                    bt.SetNamedSubStringValue("qty", totTrayQty)
                    bt.SetNamedSubStringValue("rackNo", RackNo)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                    'cmbTrayNo.Text = ""
                End If
            Next
            cmbRackLocation.Text = ""
            clear()
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
    End Sub

    Public Function getTrayDetailWithoutSterileBatch(ByVal trayNumber As String) As DataSet

        Dim ds As New DataSet
        Dim StrSql As String
        Dim trayDetail As String = Nothing
        StrSql = "SELECT     CAST(Power AS varchar) + ' - ' + Lot_Prefix + Lot_No + ' ' + RIGHT('00' + CAST(MIN(St_SrNo) AS varchar), 3)  + ' TO ' + RIGHT('00' + CAST(MAX(St_SrNo) AS varchar), 3)    AS TrayDeatil, Model_Name, Power, Btc_No, Lot_Prefix+Lot_No AS lotno, MIN(St_SrNo) AS SFROM, MAX(St_SrNo) AS STO, SUM(Qty_1) AS Qty, Tray_No , Rack_Location FROM POUCH_LABEL  WHERE   (Tray_No = '" & trayNumber & "') AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) GROUP BY Model_Name, Power, Btc_No, Lot_Prefix, Lot_No, Tray_No, Rack_Location ORDER BY Lot_Prefix, Lot_No"

        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds
        
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            Dim trayDetail As String = Nothing
            Dim trayModel As String = Nothing
            Dim RackNo As String = Nothing
            Dim dsTrayDetail As New DataSet


            'PHOBIC
            Dim trayPower As String = Nothing
            Dim trayLotNo As String = Nothing
            Dim str_batch As String = Nothing
            Dim StSrNo As Integer = 200
            Dim EnSrNo As Integer = 0
            Dim totTrayQty As Integer = 0

            If cmbTray1.Text = "" Then
                MessageBox.Show("Please Choose the Tray Number")
                Exit Sub
            End If
            If cmbTray1.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Tray")
                cmbTray1.Focus()
                Exit Sub
            End If


            Dim StrFName As String = ""
            If productline = "PMMA" Then
                StrFName = "Tray_Label_PMMA.btw"
            ElseIf productline = "PHILIC" Then
                StrFName = "Tray_Label_philic.btw"
            ElseIf productline = "PHOBIC" Then
                StrFName = "Tray_Label_phobic.btw"
            ElseIf productline = "PHOBIC NONPRELOADED" Then
                StrFName = "Tray_Label_phobic.btw"
            End If

            btFile = Application.StartupPath & "\" & StrFName & ""
            If System.IO.File.Exists(btFile) Then
                'The file exists
            Else
                MessageBox.Show("BTW file record not found")
                Exit Sub
            End If

            Dim traydetailRowCount As Integer = 0
            dsTrayDetail = getTrayDetailWithoutSterileBatch(cmbTray1.Text)
            For Each eachRecord As DataRow In dsTrayDetail.Tables(0).Rows
                trayDetail = trayDetail + Environment.NewLine + eachRecord("TrayDeatil").ToString()
                trayModel = eachRecord("Model_Name").ToString()
                RackNo = eachRecord("Rack_Location").ToString()
                str_batch = eachRecord("Btc_No").ToString()
                'PHOBIC
                trayPower = trayPower + Environment.NewLine + eachRecord("Power").ToString()
                trayLotNo = eachRecord("lotno").ToString()
                If StSrNo > Convert.ToInt32(eachRecord("SFROM")) Then
                    StSrNo = Convert.ToInt32(eachRecord("SFROM"))
                End If
                If EnSrNo < Convert.ToInt32(eachRecord("STO")) Then
                    EnSrNo = Convert.ToInt32(eachRecord("STO"))
                End If
                totTrayQty = totTrayQty + Convert.ToInt32(eachRecord("Qty"))

                'Next Label print
                traydetailRowCount = traydetailRowCount + 1
                'If productline = "PHILIC" Then
                If traydetailRowCount = 6 Then
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("trayDetail", trayDetail)
                    bt.SetNamedSubStringValue("model", trayModel)
                    bt.SetNamedSubStringValue("trayNo", cmbTray1.Text)
                    bt.SetNamedSubStringValue("batchNo", str_batch)

                    'PHOBIC
                    bt.SetNamedSubStringValue("power", trayPower)
                    bt.SetNamedSubStringValue("lotno", trayLotNo)
                    bt.SetNamedSubStringValue("sFrom", StSrNo)
                    bt.SetNamedSubStringValue("sTo", EnSrNo)
                    bt.SetNamedSubStringValue("qty", totTrayQty)
                    bt.SetNamedSubStringValue("rackNo", RackNo)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                    traydetailRowCount = 0
                    trayDetail = ""
                    trayModel = ""
                    totTrayQty = 0
                End If
                ' End If

            Next

            If traydetailRowCount = 0 Then 'productline = "PHILIC" And 
            Else
                bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                bt.SetNamedSubStringValue("trayDetail", trayDetail)
                bt.SetNamedSubStringValue("model", trayModel)
                bt.SetNamedSubStringValue("trayNo", cmbTray1.Text)
                bt.SetNamedSubStringValue("batchNo", str_batch)

                'PHOBIC
                bt.SetNamedSubStringValue("power", trayPower)
                bt.SetNamedSubStringValue("lotno", trayLotNo)
                bt.SetNamedSubStringValue("sFrom", StSrNo)
                bt.SetNamedSubStringValue("sTo", EnSrNo)
                bt.SetNamedSubStringValue("qty", totTrayQty)

                bt.SetNamedSubStringValue("rackNo", RackNo)

                bt.PrintOut()
                bt.Close()
                System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)

            End If
            cmbTray1.Text = ""
            clear()
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
    End Sub

    Public Function SelectQueryExecute(ByVal StrSql As String) As DataSet

        Dim ds As New DataSet
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function


    Private Sub cmbRackLocation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRackLocation.SelectedIndexChanged


        clear()
        Sql = "SELECT Tray_No, Sum(Qty_1) as Qty from POUCH_LABEL  WHERE  Rack_Location='" & cmbRackLocation.Text & "' and (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) Group By Tray_No Order By Tray_No"
        Ds = SelectQueryExecute(Sql)
        GRID1.DataSource = Ds.Tables(0)
    End Sub

    Private Sub cmbTray1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTray1.SelectedIndexChanged
        
        clear()
        Sql = "SELECT Lot_SrNO, Tray_No, Rack_Location from POUCH_LABEL  WHERE  Tray_No='" & cmbTray1.Text & "' and (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1)   Order By Lot_SrNo "
        Ds = SelectQueryExecute(Sql)
        GRID2.DataSource = Ds.Tables(0)
        lblcount.Text = Ds.Tables(0).Rows.Count
    End Sub

    Private Sub cmbTrayNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTrayNo.SelectedIndexChanged
        clear()
        Sql = "SELECT Lot_SrNO, Tray_No, Rack_Location from POUCH_LABEL  WHERE  Tray_No='" & cmbTrayNo.Text & "' and (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1)   Order By Lot_SrNo "
        Ds = SelectQueryExecute(Sql)
        GRID3.DataSource = Ds.Tables(0)
        lblcount1.Text = Ds.Tables(0).Rows.Count
    End Sub

    Public Sub clear()
        GRID1.DataSource = Nothing
        GRID2.DataSource = Nothing
        GRID3.DataSource = Nothing
    End Sub


    Public Function getDistinctRackNumbers() As DataSet

        Dim ds As New DataSet

        Dim StrSql As String = "SELECT DISTINCT  SUBSTRING(Rack_Location, 1, CHARINDEX('-', Rack_Location) - 1) AS Rack FROM  POUCH_LABEL  WHERE " & _
                " (Sterilization_After = '1') AND (Sterilization_Reject = '0') AND (Sample_Taken = '0')  " & _
                "  AND (BPL_Taken = '0') AND (Dc_No IS NULL) AND (Sterilization = '1') AND (Dc_Packing = '0') AND (SUBSTRING(Rack_Location, 1, CHARINDEX('-', Rack_Location) - 1) IS NOT NULL) ORDER BY Rack"

        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Public Function SQL_SelectQuery_Execute(ByVal StrSql As String) As DataSet

        Dim ds As New DataSet
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function


    Public Function getTrayDetail_RackBased1(ByVal trayNumber As String, ByVal rackid As String) As DataSet

        Dim ds As New DataSet
        Dim StrSql As String
        Dim trayDetail As String = Nothing
        StrSql = "SELECT     CAST(Power AS varchar) + ' - ' + Lot_Prefix + Lot_No + ' ' + RIGHT('00' + CAST(MIN(St_SrNo) AS varchar), 3)  + ' TO ' + RIGHT('00' + CAST(MAX(St_SrNo) AS varchar), 3)   AS TrayDeatil, Model_Name, Power, Btc_No, Lot_Prefix+Lot_No AS lotno, MIN(St_SrNo) AS SFROM, MAX(St_SrNo) AS STO, SUM(Qty_1) AS Qty, Tray_No , Rack_Location FROM POUCH_LABEL  WHERE  (Rack_location = '" & rackid & "') AND (Tray_No = '" & trayNumber & "') AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) GROUP BY Model_Name, Power, Btc_No, Lot_Prefix, Lot_No, Tray_No, Rack_Location ORDER BY Lot_Prefix, Lot_No"

        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds
        'For Each eachRow As DataRow In ds.Tables(0).Rows
        '    trayDetail = trayDetail + Environment.NewLine + eachRow("TrayDeatil").ToString()
        'Next
        'Return trayDetail
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim trayDetail As String = Nothing
        Dim trayModel As String = Nothing
        Dim RackNo As String = Nothing
        Dim dsTrayDetail, dsDistinctTray As New DataSet



        'PHOBIC
        Dim trayPower As String = Nothing
        Dim trayLotNo As String = Nothing
        Dim trayNo As String = Nothing
        Dim str_batch As String = Nothing
        Dim StSrNo As Integer = 200
        Dim EnSrNo As Integer = 0
        Dim totTrayQty As Integer = 0

        'If cmbRackLocation.Text = "" Then
        '    MessageBox.Show("Please Choose the Rack Location")
        '    Exit Sub
        'End If


        Dim StrFName As String = ""
        If productline = "PMMA" Then
            StrFName = "Tray_Label_PMMA.btw"
        ElseIf productline = "PHILIC" Then
            StrFName = "Tray_Label_philic.btw"
        ElseIf productline = "PHOBIC" Then
            StrFName = "Tray_Label_phobic.btw"
        ElseIf productline = "PHOBIC NONPRELOADED" Then
            StrFName = "Tray_Label_phobic.btw"
        End If

        btFile = Application.StartupPath & "\" & StrFName & ""
        If System.IO.File.Exists(btFile) Then
            'The file exists
        Else
            MessageBox.Show("BTW file record not found")
            Exit Sub
        End If

        '(SUBSTRING(Rack_Location, 0, CHARINDEX('-', Rack_Location)) = '" & CmbRack.Text & "')  
        Sql = "SELECT     DISTINCT RACKID FROM RACK_MASTER WHERE  (SUBSTRING(RACKID, 0, CHARINDEX('-', RACKID)) = '" & ComboBox1.Text & "') "
        Ds = SQL_SelectQuery_Execute(Sql)

        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            dsDistinctTray = getTrayNumber(eachRow1("RACKID"))

            Dim traydetailRowCount As Integer = 0
            For Each eachRow As DataRow In dsDistinctTray.Tables(0).Rows
                StSrNo = 200
                EnSrNo = 0
                traydetailRowCount = 0
                trayDetail = ""
                trayModel = ""
                totTrayQty = 0

                dsTrayDetail = getTrayDetail_RackBased1(eachRow("Tray_No").ToString(), eachRow1("RACKID"))
                For Each eachRecord As DataRow In dsTrayDetail.Tables(0).Rows
                    trayDetail = trayDetail + Environment.NewLine + eachRecord("TrayDeatil").ToString()
                    trayModel = eachRecord("Model_Name").ToString()
                    RackNo = eachRecord("Rack_Location").ToString()
                    trayNo = eachRecord("Tray_No").ToString()
                    str_batch = eachRecord("Btc_No").ToString()
                    'PHOBIC
                    trayPower = trayPower + Environment.NewLine + eachRecord("Power").ToString()
                    trayLotNo = eachRecord("lotno").ToString()
                    If StSrNo > Convert.ToInt32(eachRecord("SFROM")) Then
                        StSrNo = Convert.ToInt32(eachRecord("SFROM"))
                    End If
                    If EnSrNo < Convert.ToInt32(eachRecord("STO")) Then
                        EnSrNo = Convert.ToInt32(eachRecord("STO"))
                    End If
                    totTrayQty = totTrayQty + Convert.ToInt32(eachRecord("Qty"))

                    'Next Label print
                    traydetailRowCount = traydetailRowCount + 1
                    'If productline = "PHILIC" Then
                    If traydetailRowCount = 6 Then
                        bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                        bt.SetNamedSubStringValue("trayDetail", trayDetail)
                        bt.SetNamedSubStringValue("model", trayModel)
                        bt.SetNamedSubStringValue("trayNo", trayNo)
                        bt.SetNamedSubStringValue("batchNo", str_batch)

                        'PHOBIC
                        bt.SetNamedSubStringValue("power", trayPower)
                        bt.SetNamedSubStringValue("lotno", trayLotNo)
                        bt.SetNamedSubStringValue("sFrom", StSrNo)
                        bt.SetNamedSubStringValue("sTo", EnSrNo)
                        bt.SetNamedSubStringValue("qty", totTrayQty)
                        bt.SetNamedSubStringValue("rackNo", RackNo)
                        bt.PrintOut()
                        bt.Close()
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                        traydetailRowCount = 0
                        trayDetail = ""
                        trayModel = ""
                        totTrayQty = 0
                    End If
                    'End If

                Next

                If traydetailRowCount = 0 Then 'productline = "PHILIC" And 
                Else
                    bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                    bt.SetNamedSubStringValue("trayDetail", trayDetail)
                    bt.SetNamedSubStringValue("model", trayModel)
                    bt.SetNamedSubStringValue("trayNo", trayNo)
                    bt.SetNamedSubStringValue("batchNo", str_batch)

                    'PHOBIC
                    bt.SetNamedSubStringValue("power", trayPower)
                    bt.SetNamedSubStringValue("lotno", trayLotNo)
                    bt.SetNamedSubStringValue("sFrom", StSrNo)
                    bt.SetNamedSubStringValue("sTo", EnSrNo)
                    bt.SetNamedSubStringValue("qty", totTrayQty)
                    bt.SetNamedSubStringValue("rackNo", RackNo)
                    bt.PrintOut()
                    bt.Close()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(bt)
                    'cmbTrayNo.Text = ""
                End If
            Next
        Next

        
        'cmbRackLocation.Text = ""
        clear()
    End Sub
End Class