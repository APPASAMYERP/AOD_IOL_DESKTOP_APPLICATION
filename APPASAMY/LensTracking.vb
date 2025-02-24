Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel

Public Class LensTracking
    Dim table As New DataTable
    Dim cmd As SqlCommand
    Dim Sql As String
    'Dim sqla As SqlDataAdapter
    Dim Ds As New DataSet
    Dim Dr As SqlDataReader
    Dim DtRow As DataRow
    Dim StrLorBarNo As String

    Public Function selectQueryExecute(ByVal StrSql As String) As DataSet

        Dim ds As New DataSet
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function
    Private Sub txtlotbarno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlotbarno.TextChanged
        If productline = "PHILIC" Then

            If rdblanksId.Checked = True Then

                Sql = "SELECT     PL.Lot_SrNo FROM         IOL_ERP.dbo.work_In__Progress1 AS wip INNER JOIN    POUCH_LABEL AS PL ON wip.LotNo = PL.RefLot WHERE     (wip.BatchNo = '" & txtlotbarno.Text & "') AND (wip.Process_Code = 'PHI 0022 MIFQI') order by PL.Lot_SrNo"
                Dim dataadapter As New SqlDataAdapter(Sql, con)
                Dim ds As New DataSet()

                dataadapter.Fill(ds, "Lot_Srno")

                GRID2.DataSource = ds
                GRID2.DataMember = "Lot_Srno"

            ElseIf rdbtc.Checked = True Then

                Sql = "SELECT     PL.Lot_SrNo FROM         IOL_ERP.dbo.work_In__Progress1 AS wip INNER JOIN    POUCH_LABEL AS PL ON wip.LotNo = PL.RefLot WHERE     (PL.Btc_No  = '" & txtlotbarno.Text & "') AND (wip.Process_Code = 'PHI 0022 MIFQI') order by PL.Lot_SrNo"


                Dim dataadapter As New SqlDataAdapter(Sql, con)
                Dim ds1 As New DataSet()

                dataadapter.Fill(ds1, "Lot_Srno")

                GRID2.DataSource = ds1
                GRID2.DataMember = "Lot_Srno"

            End If
        End If
       

        If productline = "PHOBIC" Then
            If rdblanksId.Checked = True Then

                Sql = "SELECT     PL.Lot_SrNo FROM        MOULDING_ERP.dbo.Moulding_Rejection AS wip INNER JOIN    POUCH_LABEL AS PL ON wip.Reflot= PL.RefLot WHERE     (wip. Solution_Id = '" & txtlotbarno.Text & "') AND (wip.Process_Code = 'PHO FC 001') order by PL.Lot_SrNo"


                Dim dataadapter As New SqlDataAdapter(Sql, con)
                Dim ds As New DataSet()

                dataadapter.Fill(ds, "Lot_Srno")

                GRID2.DataSource = ds
                GRID2.DataMember = "Lot_Srno"

            ElseIf rdbtc.Checked = True Then

                Sql = "SELECT PL.Lot_SrNo FROM         MOULDING_ERP.dbo.Moulding_Rejection AS wip INNER JOIN    POUCH_LABEL AS PL ON wip.Reflot = PL.RefLot WHERE       (PL.Btc_No  = '" & txtlotbarno.Text & "') AND   (wip.Process_code = 'PHO FC 001') order by PL.Lot_SrNo"

                Dim dataadapter As New SqlDataAdapter(Sql, con)
                Dim ds As New DataSet()

                dataadapter.Fill(ds, "Lot_Srno")

                GRID2.DataSource = ds
                GRID2.DataMember = "Lot_Srno"


            End If
            End If

        If productline = "PHOBIC_Preloaded" Then
            If rdblanksId.Checked = True Then

                Sql = "SELECT     PL.Lot_SrNo FROM        MOULDING_ERP.dbo.Moulding_Rejection AS wip INNER JOIN    POUCH_LABEL AS PL ON wip.Reflot= PL.RefLot WHERE     (wip. Solution_Id = '" & txtlotbarno.Text & "') AND (wip.Process_Code = 'PHO FC 001') order by PL.Lot_SrNo"


                Dim dataadapter As New SqlDataAdapter(Sql, con)
                Dim ds As New DataSet()

                dataadapter.Fill(ds, "Lot_Srno")

                GRID2.DataSource = ds
                GRID2.DataMember = "Lot_Srno"

            ElseIf rdbtc.Checked = True Then

                Sql = "SELECT PL.Lot_SrNo FROM         MOULDING_ERP.dbo.Moulding_Rejection AS wip INNER JOIN    POUCH_LABEL AS PL ON wip.Reflot = PL.RefLot WHERE       (PL.Btc_No  = '" & txtlotbarno.Text & "') AND   (wip.Process_code = 'PHO FC 001') order by PL.Lot_SrNo"

                Dim dataadapter As New SqlDataAdapter(Sql, con)
                Dim ds As New DataSet()

                dataadapter.Fill(ds, "Lot_Srno")

                GRID2.DataSource = ds
                GRID2.DataMember = "Lot_Srno"


            End If
        End If

        If productline = "PMMA" Then
            If rdblanksId.Checked = True Then

                Sql = "SELECT     PL.Lot_SrNo FROM         PMMA_ERP.dbo.work_In__Progress1 AS wip INNER JOIN          POUCH_LABEL AS PL ON wip.LotNo = PL.GlassyLotno WHERE     (wip.Process_Code = 'PMA 0022 SUR OBV') AND (wip.BatchNo = '" & txtlotbarno.Text & "') ORDER BY Lot_SrNo"


                Dim dataadapter As New SqlDataAdapter(Sql, con)
                Dim ds As New DataSet()

                dataadapter.Fill(ds, "Lot_Srno")

                GRID2.DataSource = ds
                GRID2.DataMember = "Lot_Srno"

            ElseIf rdbtc.Checked = True Then

                Sql = "SELECT     PL.Lot_SrNo FROM         PMMA_ERP.dbo.work_In__Progress1 AS wip INNER JOIN    POUCH_LABEL AS PL ON wip.LotNo = PL.GlassyLotno WHERE     (wip.Process_Code = 'PMA 0022 SUR OBV') AND (PL.Btc_No = '" & txtlotbarno.Text & "') ORDER BY PL.Lot_SrNo"

                Dim dataadapter As New SqlDataAdapter(Sql, con)
                Dim ds As New DataSet()

                dataadapter.Fill(ds, "Lot_Srno")

                GRID2.DataSource = ds
                GRID2.DataMember = "Lot_Srno"


            End If

        End If



    End Sub

    Private Sub ExportToExcel(ByVal dt As DataTable, ByVal excelFilePath As String)
        Dim xlApp As New Excel.Application()
        Dim xlWorkBook As Excel.Workbook = xlApp.Workbooks.Add()
        Dim xlWorkSheet As Excel.Worksheet = CType(xlWorkBook.Worksheets(1), Excel.Worksheet)

        Dim i As Integer = 0
        Dim j As Integer = 0

        ' Writing Headers
        For Each column As DataColumn In dt.Columns
            j += 1
            xlWorkSheet.Cells(1, j) = column.ColumnName
        Next

        ' Writing Data

        Application.DoEvents()

        For Each row As DataRow In dt.Rows

            i += 1
            j = 0
            For Each column As DataColumn In dt.Columns
                j += 1
                xlWorkSheet.Cells(i + 1, j) = row(column.ColumnName)
            Next


            Application.DoEvents()
        Next


        ' Save the Excel file
        xlWorkBook.SaveAs(excelFilePath)
        xlWorkBook.Close()
        xlApp.Quit()

        ReleaseObject(xlApp)
        ReleaseObject(xlWorkBook)
        ReleaseObject(xlWorkSheet)





    End Sub
    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    Public Function FlipDataSet(ByVal my_DataSet As DataSet) As DataSet
        Dim ds As DataSet = New DataSet()

        For Each dt As DataTable In my_DataSet.Tables
            Dim table As DataTable = New DataTable()


            table.Columns.Add("Field")
            table.Columns.Add("Value")

            Dim r As DataRow

            For k As Integer = 0 To dt.Columns.Count - 1
                r = table.NewRow()
                r(0) = dt.Columns(k).ToString()

                For j As Integer = 1 To dt.Rows.Count
                    r(j) = dt.Rows(j - 1)(k)
                Next

                table.Rows.Add(r)
            Next

            ds.Tables.Add(table)
        Next

        Return ds
    End Function

    Private Sub GRID2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID2.CellContentClick
 

    End Sub

    Private Sub GRID2_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRID2.SelectionChanged
        If GRID2.SelectedCells.Count > 0 Then
            '' Get the selected cell
            Dim selectedCell As DataGridViewCell = GRID2.SelectedCells(0)

            '' Get the value of the selected cell
            Dim cellValue As Object = selectedCell.Value

            '' Display the value in a Label control or use it as needed
            txtchange.Text = cellValue.ToString()
        End If
    End Sub

    Private Sub txtchange_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtchange.TextChanged


        Lens_Details()


    End Sub

    Private Sub LensTracking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click




        Dim dt As DataTable
        dt = GRID1.DataSource

        Dim excelFilePath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\" + productline + "_Tracking_REPORT_" + DateTime.Now().ToString("yyyy_MM_dd_HH_mm_ss") + ".xlsx"
        ExportToExcel(dt, excelFilePath)
        MessageBox.Show("Data Exported Successfully")
    End Sub

    Private Sub rdbtc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtc.CheckedChanged
        If rdblanksId.Checked = True Then
            Label5.Text = "Enter Blanks ID"
        ElseIf rdbtc.Checked = True Then
            Label5.Text = "Enter Batch No"
        End If
    End Sub

    'Private Sub txtchange_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtchange.KeyDown
    '    Lens_Details()
    'End Sub
    Private Sub Lens_Details()

        Try

            'Dim StrLorBarNo As String

            If grop1.Checked = True Then
                StrLorBarNo = txtchange.Text
            ElseIf group2.Checked = True Then
                StrLorBarNo = txtScanLot_srNO.Text
            End If

            GRID1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            If StrLorBarNo <> "" Then
                StrLorBarNo = UCase(Trim(StrLorBarNo))
                If productline = "PHILIC" Then

                    If rdblanksId.Checked = True Or rdbtc.Checked = True Then


                        Sql = "SELECT   TOP (1)     PL.Lot_SrNo, WIP.BatchNo, WIP.Tumbling_No, CAST(WIP.Startdate AS VARCHAR) + ' ' + CAST(WIP.Starttime AS VARCHAR) AS StartDateTime, CAST(WIP.Enddate AS VARCHAR) " & _
                     "     + ' ' + CAST(WIP.Endtime AS VARCHAR) AS EndDateTime, PL.Lot_Prefix + PL.Lot_No AS Packing_LotNo, PL.Created_Date, PL.Brand_Name, PL.Model_Name, PL.Power,  " & _
                      "    CASE WHEN PL.Sterilization = 0 THEN 'No' ELSE 'Yes' END AS Before_Sterilization, BSD.Created_Date AS Before_Sterilization_Created_Date,PL.Injector_Ref, PL.Injector_batch,  " & _
                        "  CASE WHEN PL.Sterilization_After = 0 THEN 'No' ELSE 'Yes' END AS After_Sterilization, PL.Sterilization_Date, PL.Btc_No,  " & _
                        "  CASE WHEN PL.Sample_Taken = 0 THEN 'No' ELSE 'Yes' END AS Sample_Taken, CASE WHEN ST.Created_Date IS NULL  " & _
                        "  THEN CS.Created_Date ELSE ST.Created_Date END AS Sample_Taken_date, PL.Type_Sample, CASE WHEN PL.Sterilization_Reject = 0 THEN 'No' ELSE 'Yes' END AS Sterilization_Reject_Status,  " & _
                        "  SRD.Created_Date AS Sterilization_Reject_Created_Date, CASE WHEN PL.Areation_Status = 0 THEN 'No' ELSE 'Yes' END AS Areation_Status, ASD.Created_Date AS Aeration_Received_Date,  " & _
                         " PL.Rack_Location, PL.Tray_No, CASE WHEN PL.BPL_Taken = 0 THEN 'No' ELSE 'Yes' END AS BPL_Taken, PL.BPL_NO, BG.Created_Date AS BPL_Created_Date,  " & _
                         " CASE WHEN PL.BPL_Collection_Status = 0 THEN 'No' ELSE 'Yes' END AS BPL_Collection_Status_Description, PL.BPL_Collected_by, BID.Inspection_By, BID.Inspection_date AS Inspection_Date,  " & _
                         " CASE WHEN PL.Box_Packing = 0 THEN 'No' ELSE 'Yes' END AS Box_Packing_Status, PL.Boxtime, PL.Box_By " & _
                         "FROM         IOL_ERP.dbo.work_In__Progress1 AS WIP INNER JOIN " & _
                     "     POUCH_LABEL AS PL ON WIP.Tumbling_No = PL.RefLot LEFT OUTER JOIN " & _
                        "  Before_Sterilization_Scan_Details AS BSD ON PL.Sterilization_No = BSD.Sterilization_Before_No LEFT OUTER JOIN " & _
                        "  Sterile_Reject_Details AS SRD ON PL.Lot_SrNo = SRD.Lot_SrNo LEFT OUTER JOIN " & _
                       "   Areation_Scan_Details AS ASD ON PL.Areation_Scan_No = ASD.Areation_Scan_No LEFT OUTER JOIN " & _
                       "   BPL_GEN AS BG ON PL.BPL_NO = BG.BPL_No LEFT OUTER JOIN " & _
                        "  Box_Inspection_Details AS BID ON PL.BPL_NO = BID.BPL_No LEFT OUTER JOIN " & _
                        "  STERILIZATION_TEST AS ST ON PL.Lot_SrNo = ST.Lot_SrNo LEFT OUTER JOIN " & _
                         " CONTROL_SAMPLE AS CS ON PL.Lot_SrNo = CS.Lot_SrNo " & _
                    "WHERE     (PL.@Lot_SrNo = '" & StrLorBarNo & "') AND (WIP.Process_Code = 'PHI 0017 SMP TUMBLING')"




                        If rdLotSerial.Checked = True Or GroupBox3.Visible = True Then
                            Sql = Sql.Replace("@Lot_SrNo", "Lot_SrNo")
                        ElseIf rdUDICode.Checked = True Then
                            Sql = Sql.Replace("@Lot_SrNo", "Udi_Code")
                        Else
                            MessageBox.Show("Please Select 'Lot Serial' Or 'UDI Serial'")

                        End If


                    End If






                ElseIf productline = "PHOBIC" Then

                    If rdblanksId.Checked = True Or rdbtc.Checked = True Then
                        Sql = "SELECT    TOP (1)    PL.Lot_SrNo,ME.Solution_Id, ME.Reflot, MIN(ME.Updated_Date) AS StartDateTime, MAX(ME.Updated_Date) AS EndDateTime, PL.Lot_Prefix + PL.Lot_No AS Packing_LotNo, PL.Created_Date, PL.Brand_Name,  " & _
                        "      PL.Model_Name, PL.Power, CASE WHEN PL.Sterilization = 0 THEN 'No' ELSE 'Yes' END AS Before_Sterilization, BSD.Created_Date AS Before_Sterilization_Created_Date,  " & _
                          "    CASE WHEN PL.Sterilization_After = 0 THEN 'No' ELSE 'Yes' END AS After_Sterilization, PL.Sterilization_Date, PL.Btc_No,PL.Injector_Ref, PL.Injector_batch,    " & _
                           "   CASE WHEN PL.Sample_Taken = 0 THEN 'No' ELSE 'Yes' END AS Sample_Taken, CASE WHEN ST.Created_Date IS NULL  " & _
                           "   THEN CS.Created_Date ELSE ST.Created_Date END AS Sample_Taken_date, PL.Type_Sample, CASE WHEN PL.Sterilization_Reject = 0 THEN 'No' ELSE 'Yes' END AS Sterilization_Reject_Status,  " & _
                             " SRD.Created_Date AS Sterilization_Reject_Created_Date, CASE WHEN PL.Areation_Status = 0 THEN 'No' ELSE 'Yes' END AS Areation_Status, ASD.Created_Date AS Aeration_Received_Date,  " & _
                            "  PL.Rack_Location, PL.Tray_No, CASE WHEN PL.BPL_Taken = 0 THEN 'No' ELSE 'Yes' END AS BPL_Taken, PL.BPL_NO, BG.Created_Date AS BPL_Created_Date,  " & _
                            "  CASE WHEN PL.BPL_Collection_Status = 0 THEN 'No' ELSE 'Yes' END AS BPL_Collection_Status_Description, PL.BPL_Collected_by, BID.Inspection_By, BID.Inspection_date AS Inspection_Date,  " & _
                             " CASE WHEN PL.Box_Packing = 0 THEN 'No' ELSE 'Yes' END AS Box_Packing_Status, PL.Boxtime, PL.Box_By " & _
                             "FROM         MOULDING_ERP.dbo.Moulding_Rejection AS ME INNER JOIN " & _
                             " POUCH_LABEL AS PL ON ME.Reflot = PL.RefLot LEFT OUTER JOIN " & _
                             " Before_Sterilization_Scan_Details AS BSD ON PL.Sterilization_No = BSD.Sterilization_Before_No LEFT OUTER JOIN " & _
                            "  Sterile_Reject_Details AS SRD ON PL.Lot_SrNo = SRD.Lot_SrNo LEFT OUTER JOIN " & _
                            "  Areation_Scan_Details AS ASD ON PL.Areation_Scan_No = ASD.Areation_Scan_No LEFT OUTER JOIN " & _
                           "   BPL_GEN AS BG ON PL.BPL_NO = BG.BPL_No LEFT OUTER JOIN " & _
                            "  Box_Inspection_Details AS BID ON PL.BPL_NO = BID.BPL_No LEFT OUTER JOIN " & _
                           "   STERILIZATION_TEST AS ST ON PL.Lot_SrNo = ST.Lot_SrNo LEFT OUTER JOIN " & _
                             " CONTROL_SAMPLE AS CS ON PL.Lot_SrNo = CS.Lot_SrNo " & _
            "WHERE      (PL.@Lot_SrNo = '" & StrLorBarNo & "') AND (ME.Process_code IN ('PHO FC 001', 'PHO SIAB 007')) " & _
            "GROUP BY   PL.Lot_SrNo,ME.Solution_Id, ME.Reflot, PL.Lot_Prefix + PL.Lot_No, PL.Created_Date, PL.Brand_Name, PL.Model_Name, PL.Power, CASE WHEN PL.Sterilization = 0 THEN 'No' ELSE 'Yes' END,  " & _
                           "   BSD.Created_Date, CASE WHEN PL.Sterilization_After = 0 THEN 'No' ELSE 'Yes' END, PL.Sterilization_Date, PL.Btc_No,PL.Injector_Ref, PL.Injector_batch ,  CASE WHEN PL.Sample_Taken = 0 THEN 'No' ELSE 'Yes' END,  " & _
                           "   CASE WHEN ST.Created_Date IS NULL THEN CS.Created_Date ELSE ST.Created_Date END, PL.Type_Sample, CASE WHEN PL.Sterilization_Reject = 0 THEN 'No' ELSE 'Yes' END,  " & _
                            "  SRD.Created_Date, CASE WHEN PL.Areation_Status = 0 THEN 'No' ELSE 'Yes' END, ASD.Created_Date, PL.Rack_Location, PL.Tray_No, CASE WHEN PL.BPL_Taken = 0 THEN 'No' ELSE 'Yes' END,  " & _
                            "  PL.BPL_NO, BG.Created_Date, CASE WHEN PL.BPL_Collection_Status = 0 THEN 'No' ELSE 'Yes' END, PL.BPL_Collected_by, BID.Inspection_By, BID.Inspection_date,  " & _
                            "  CASE WHEN PL.Box_Packing = 0 THEN 'No' ELSE 'Yes' END, PL.Boxtime, PL.Box_By "



                        If rdLotSerial.Checked = True Or GroupBox3.Visible = True Then
                            Sql = Sql.Replace("@Lot_SrNo", "Lot_SrNo")
                        ElseIf rdUDICode.Checked = True Then
                            Sql = Sql.Replace("@Lot_SrNo", "Udi_Code")
                        Else
                            MessageBox.Show("Please Select 'Lot Serial' Or 'UDI Serial'")

                        End If


                    End If



                ElseIf productline = "PHOBIC_Preloaded" Then

                    If rdblanksId.Checked = True Or rdbtc.Checked = True Then
                        Sql = "SELECT      TOP (1)  PL.Lot_SrNo,ME.Solution_Id, ME.Reflot, MIN(ME.Updated_Date) AS StartDateTime, MAX(ME.Updated_Date) AS EndDateTime, PL.Lot_Prefix + PL.Lot_No AS Packing_LotNo, PL.Created_Date, PL.Brand_Name,  " & _
                        "      PL.Model_Name, PL.Power, CASE WHEN PL.Sterilization = 0 THEN 'No' ELSE 'Yes' END AS Before_Sterilization, BSD.Created_Date AS Before_Sterilization_Created_Date,  " & _
                          "    CASE WHEN PL.Sterilization_After = 0 THEN 'No' ELSE 'Yes' END AS After_Sterilization, PL.Sterilization_Date, PL.Btc_No,PL.Injector_Ref, PL.Injector_batch,    " & _
                           "   CASE WHEN PL.Sample_Taken = 0 THEN 'No' ELSE 'Yes' END AS Sample_Taken, CASE WHEN ST.Created_Date IS NULL  " & _
                           "   THEN CS.Created_Date ELSE ST.Created_Date END AS Sample_Taken_date, PL.Type_Sample, CASE WHEN PL.Sterilization_Reject = 0 THEN 'No' ELSE 'Yes' END AS Sterilization_Reject_Status,  " & _
                             " SRD.Created_Date AS Sterilization_Reject_Created_Date, CASE WHEN PL.Areation_Status = 0 THEN 'No' ELSE 'Yes' END AS Areation_Status, ASD.Created_Date AS Aeration_Received_Date,  " & _
                            "  PL.Rack_Location, PL.Tray_No, CASE WHEN PL.BPL_Taken = 0 THEN 'No' ELSE 'Yes' END AS BPL_Taken, PL.BPL_NO, BG.Created_Date AS BPL_Created_Date,  " & _
                            "  CASE WHEN PL.BPL_Collection_Status = 0 THEN 'No' ELSE 'Yes' END AS BPL_Collection_Status_Description, PL.BPL_Collected_by, BID.Inspection_By, BID.Inspection_date AS Inspection_Date,  " & _
                             " CASE WHEN PL.Box_Packing = 0 THEN 'No' ELSE 'Yes' END AS Box_Packing_Status, PL.Boxtime, PL.Box_By " & _
                             "FROM         MOULDING_ERP.dbo.Moulding_Rejection AS ME INNER JOIN " & _
                             " POUCH_LABEL AS PL ON ME.Reflot = PL.RefLot LEFT OUTER JOIN " & _
                             " Before_Sterilization_Scan_Details AS BSD ON PL.Sterilization_No = BSD.Sterilization_Before_No LEFT OUTER JOIN " & _
                            "  Sterile_Reject_Details AS SRD ON PL.Lot_SrNo = SRD.Lot_SrNo LEFT OUTER JOIN " & _
                            "  Areation_Scan_Details AS ASD ON PL.Areation_Scan_No = ASD.Areation_Scan_No LEFT OUTER JOIN " & _
                           "   BPL_GEN AS BG ON PL.BPL_NO = BG.BPL_No LEFT OUTER JOIN " & _
                            "  Box_Inspection_Details AS BID ON PL.BPL_NO = BID.BPL_No LEFT OUTER JOIN " & _
                           "   STERILIZATION_TEST AS ST ON PL.Lot_SrNo = ST.Lot_SrNo LEFT OUTER JOIN " & _
                             " CONTROL_SAMPLE AS CS ON PL.Lot_SrNo = CS.Lot_SrNo " & _
            "WHERE      (PL.@Lot_SrNo = '" & StrLorBarNo & "') AND (ME.Process_code IN ('PHO FC 001', 'PHO SIAB 007')) " & _
            "GROUP BY   PL.Lot_SrNo,ME.Solution_Id, ME.Reflot, PL.Lot_Prefix + PL.Lot_No, PL.Created_Date, PL.Brand_Name, PL.Model_Name, PL.Power, CASE WHEN PL.Sterilization = 0 THEN 'No' ELSE 'Yes' END,  " & _
                           "   BSD.Created_Date, CASE WHEN PL.Sterilization_After = 0 THEN 'No' ELSE 'Yes' END, PL.Sterilization_Date, PL.Btc_No,PL.Injector_Ref, PL.Injector_batch ,  CASE WHEN PL.Sample_Taken = 0 THEN 'No' ELSE 'Yes' END,  " & _
                           "   CASE WHEN ST.Created_Date IS NULL THEN CS.Created_Date ELSE ST.Created_Date END, PL.Type_Sample, CASE WHEN PL.Sterilization_Reject = 0 THEN 'No' ELSE 'Yes' END,  " & _
                            "  SRD.Created_Date, CASE WHEN PL.Areation_Status = 0 THEN 'No' ELSE 'Yes' END, ASD.Created_Date, PL.Rack_Location, PL.Tray_No, CASE WHEN PL.BPL_Taken = 0 THEN 'No' ELSE 'Yes' END,  " & _
                            "  PL.BPL_NO, BG.Created_Date, CASE WHEN PL.BPL_Collection_Status = 0 THEN 'No' ELSE 'Yes' END, PL.BPL_Collected_by, BID.Inspection_By, BID.Inspection_date,  " & _
                            "  CASE WHEN PL.Box_Packing = 0 THEN 'No' ELSE 'Yes' END, PL.Boxtime, PL.Box_By "


                        If rdLotSerial.Checked = True Or GroupBox3.Visible = True Then
                            Sql = Sql.Replace("@Lot_SrNo", "Lot_SrNo")
                        ElseIf rdUDICode.Checked = True Then
                            Sql = Sql.Replace("@Lot_SrNo", "Udi_Code")
                        Else
                            MessageBox.Show("Please Select 'Lot Serial' Or 'UDI Serial'")

                        End If


                    End If



                ElseIf productline = "PMMA" Then

                    If rdblanksId.Checked = True Or rdbtc.Checked = True Then
                        Sql = "SELECT DISTINCT   TOP (1)  " & _
                       "       PL.Lot_SrNo, PL.GlassyLotno, WIP.BatchNo, CAST(WIP.Startdate AS VARCHAR) + ' ' + CAST(WIP.Starttime AS VARCHAR) AS StartDateTime, CAST(WIP.Enddate AS VARCHAR) " & _
                            "  + ' ' + CAST(WIP.Endtime AS VARCHAR) AS EndDateTime, PL.Lot_Prefix + PL.Lot_No AS Packing_LotNo, PL.Created_Date, PL.Brand_Name, PL.Model_Name, PL.Power,  " & _
                      "    CASE WHEN PL.Sterilization = 0 THEN 'No' ELSE 'Yes' END AS Before_Sterilization, BSD.Created_Date AS Before_Sterilization_Created_Date, " & _
                        "      CASE WHEN PL.Sterilization_After = 0 THEN 'No' ELSE 'Yes' END AS After_Sterilization, PL.Sterilization_Date, PL.Btc_No, " & _
                          "    CASE WHEN PL.Sample_Taken = 0 THEN 'No' ELSE 'Yes' END AS Sample_Taken, CASE WHEN ST.Created_Date IS NULL " & _
                          "    THEN CS.Created_Date ELSE ST.Created_Date END AS Sample_Taken_date, PL.Type_Sample, CASE WHEN PL.Sterilization_Reject = 0 THEN 'No' ELSE 'Yes' END AS Sterilization_Reject_Status, " & _
                         "   SRD.Created_Date AS Sterilization_Reject_Created_Date, CASE WHEN PL.Areation_Status = 0 THEN 'No' ELSE 'Yes' END AS Areation_Status, ASD.Created_Date AS Aeration_Received_Date, " & _
                           "   PL.Rack_Location, PL.Tray_No, CASE WHEN PL.BPL_Taken = 0 THEN 'No' ELSE 'Yes' END AS BPL_Taken, PL.BPL_NO, BG.Created_Date AS BPL_Created_Date, " & _
                          "    CASE WHEN PL.BPL_Collection_Status = 0 THEN 'No' ELSE 'Yes' END AS BPL_Collection_Status_Description, PL.BPL_Collected_by, BID.Inspection_By, BID.Inspection_date AS Inspection_Date, " & _
                           "   CASE WHEN PL.Box_Packing = 0 THEN 'No' ELSE 'Yes' END AS Box_Packing_Status, PL.Boxtime, PL.Box_By " & _
                " FROM         PMMA_ERP.dbo.work_In__Progress1 AS WIP INNER JOIN " & _
                       "       POUCH_LABEL AS PL ON WIP.Product_Code = PL.GlassyLotno LEFT OUTER JOIN " & _
                         "     Before_Sterilization_Scan_Details AS BSD ON PL.Sterilization_No = BSD.Sterilization_Before_No LEFT OUTER JOIN " & _
                           "   Sterile_Reject_Details AS SRD ON PL.Lot_SrNo = SRD.Lot_SrNo LEFT OUTER JOIN  " & _
                              " Areation_Scan_Details AS ASD ON PL.Areation_Scan_No = ASD.Areation_Scan_No LEFT OUTER JOIN  " & _
                           "   BPL_GEN AS BG ON PL.BPL_NO = BG.BPL_No LEFT OUTER JOIN  " & _
                            "  Box_Inspection_Details AS BID ON PL.BPL_NO = BID.BPL_No LEFT OUTER JOIN  " & _
                            "  STERILIZATION_TEST AS ST ON PL.Lot_SrNo = ST.Lot_SrNo LEFT OUTER JOIN  " & _
                            "  Control_Sample AS CS ON PL.Lot_SrNo = CS.Lot_SrNo " & _
                " WHERE     (WIP.Process_Code = 'PMA 0022 SUR OBV') AND (PL.@Lot_SrNo = '" & StrLorBarNo & "')  " & _
                " GROUP BY PL.Lot_SrNo, PL.GlassyLotno, WIP.BatchNo, CAST(WIP.Startdate AS VARCHAR) + ' ' + CAST(WIP.Starttime AS VARCHAR), CAST(WIP.Enddate AS VARCHAR) + ' ' + CAST(WIP.Endtime AS VARCHAR),  " & _
                           "   PL.Lot_Prefix + PL.Lot_No, PL.Created_Date, PL.Brand_Name, PL.Model_Name, PL.Power, CASE WHEN PL.Sterilization = 0 THEN 'No' ELSE 'Yes' END, BSD.Created_Date,  " & _
                           "   CASE WHEN PL.Sterilization_After = 0 THEN 'No' ELSE 'Yes' END, PL.Sterilization_Date, PL.Btc_No, CASE WHEN PL.Sample_Taken = 0 THEN 'No' ELSE 'Yes' END,   " & _
                            "  CASE WHEN ST.Created_Date IS NULL THEN CS.Created_Date ELSE ST.Created_Date END, PL.Type_Sample, CASE WHEN PL.Sterilization_Reject = 0 THEN 'No' ELSE 'Yes' END,  " & _
                             "  SRD.Created_Date, CASE WHEN PL.Areation_Status = 0 THEN 'No' ELSE 'Yes' END, ASD.Created_Date, PL.Rack_Location, PL.Tray_No, CASE WHEN PL.BPL_Taken = 0 THEN 'No' ELSE 'Yes' END,   " & _
                             "  PL.BPL_NO, BG.Created_Date, CASE WHEN PL.BPL_Collection_Status = 0 THEN 'No' ELSE 'Yes' END, PL.BPL_Collected_by, BID.Inspection_By, BID.Inspection_date,  " & _
                           "   CASE WHEN PL.Box_Packing = 0 THEN 'No' ELSE 'Yes' END, PL.Boxtime, PL.Box_By"



                        If rdLotSerial.Checked = True Or GroupBox3.Visible = True Then
                            Sql = Sql.Replace("@Lot_SrNo", "Lot_SrNo")
                        ElseIf rdUDICode.Checked = True Then
                            Sql = Sql.Replace("@Lot_SrNo", "Udi_Code")
                        Else
                            MessageBox.Show("Please Select 'Lot Serial' Or 'UDI Serial'")

                        End If


                    End If
                End If




                Ds = selectQueryExecute(Sql)

                Ds = FlipDataSet(Ds)

                GRID1.DataSource = Ds.Tables(0)


                If grop1.Checked = True Then

                ElseIf group2.Checked = True Then
                    txtScanLot_srNO.Text = ""
                    txtScanLot_srNO.Focus()
                End If



            Else
                MsgBox("Scan Correct Lot SrNo")


                If grop1.Checked = True Then

                ElseIf group2.Checked = True Then
                    txtScanLot_srNO.Text = ""
                    txtScanLot_srNO.Focus()
                End If
            End If

        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try


    End Sub

    Private Sub grop1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grop1.CheckedChanged
        If grop1.Checked = True Then
            group2.Checked = False
            GroupBox3.Visible = True
            GroupBox1.Visible = False
            'GRID1.Rows.Clear()
            'GRID2.Columns.Clear()
            txtlotbarno.Text = ""
            txtchange.Text = ""
            GRID2.Visible = True
            grp1.Visible = False
            grp2.Visible = True
        End If

    End Sub

    Private Sub group2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles group2.CheckedChanged
        If group2.Checked = True Then
            txtlotbarno.Text = ""
            txtchange.Text = ""
           
            'GRID1.Rows.Clear()
            'GRID2.Columns.Clear()
            grop1.Checked = False
            GroupBox1.Visible = True
            GroupBox3.Visible = False
            GRID2.Visible = False
            grp1.Visible = True
            grp2.Visible = False
        End If
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        
        GRID1.DataSource = Nothing
        GRID2.DataSource = Nothing
        txtlotbarno.Text = ""
        txtchange.Text = ""
        grop1.Checked = False
        GroupBox1.Visible = True
        GroupBox3.Visible = False

    End Sub

    Private Sub txtScanLot_srNO_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtScanLot_srNO.KeyDown

        If e.KeyCode = Keys.Enter Then
            Lens_Details()
        End If

    End Sub
End Class