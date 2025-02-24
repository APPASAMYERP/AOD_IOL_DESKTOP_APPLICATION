Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmLotWiseTrackingReport

    Dim Sql As String
    Dim Ds As New DataSet

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

    Private Sub viewReport()

        Try
            If txtLotNumber.Text = "" Then
                err.SetError(txtLotNumber, "This information is required")
                Exit Sub
            Else
                err.SetError(txtLotNumber, "")
            End If

            Sql = " SELECT     Lot_SrNo, Model_Name, Power, CASE WHEN BPL_Taken = 1 THEN 'YES' ELSE 'NO' END AS BPL_Taken, BPL_NO, CASE WHEN bpl_no IS NULL THEN NULL ELSE " & _
                        " (SELECT     TOP (1) Created_Date FROM          BPL_GEN " & _
                        " WHERE      (BPL_No = PL.BPL_NO)) END AS BPL_Taken_Date, CASE WHEN BPL_Collection_Status = 1 THEN 'YES' ELSE 'NO' END AS BPL_Collection_Status, BPL_Collected_by, " & _
                        " CASE WHEN  (SELECT     TOP (1) bpl_no FROM          Box_Inspection_Details WHERE      (BPL_No = PL.BPL_NO)) IS NULL THEN 'NO' ELSE 'YES' END AS Inspection_Status, " & _
                        " (SELECT     TOP (1) Inspection_By FROM          Box_Inspection_Details WHERE      (BPL_No = PL.BPL_NO)) AS Inspected_By, " & _
                        " (SELECT     TOP (1) Inspection_date FROM          Box_Inspection_Details AS Box_Inspection_Details_1 WHERE      (BPL_No = PL.BPL_NO)) AS Inspection_date, " & _
                        " CASE WHEN Box_Reject = 1 THEN 'YES' ELSE 'NO' END AS Box_Rejected, " & _
                        " CASE WHEN Box_Packing = 1 THEN 'YES' ELSE 'NO' END AS Box_Packed, Box_By, Boxtime, Tray_No, Rack_Location " & _
                    " FROM         POUCH_LABEL AS PL " & _
                    " WHERE     (Lot_Prefix + Lot_No = '" & txtLotNumber.Text & "') AND (Sterilization = 1) AND (Sample_Taken = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND " & _
                        " (Sterilization_Reject = 0) AND (Dc_No IS NULL) AND (Areation_Status = '1') Order by Lot_SrNo "

            Ds = SQL_SelectQuery_Execute(Sql)
            grid.DataSource = Ds.Tables(0)
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        


    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        viewReport()
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

        For Each row As DataRow In dt.Rows

            i += 1
            j = 0
            For Each column As DataColumn In dt.Columns
                j += 1
                xlWorkSheet.Cells(i + 1, j) = row(column.ColumnName)
            Next

        Next


        ' Save the Excel file
        xlWorkBook.SaveAs(excelFilePath)
        xlWorkBook.Close()
        xlApp.Quit()

        ReleaseObject(xlApp)
        ReleaseObject(xlWorkBook)
        ReleaseObject(xlWorkSheet)




    End Sub

    Private Sub DownloadReport()
        Try
            If grid.Rows.Count > 1 Then
                Dim dt As DataTable
                dt = grid.DataSource

                Dim excelFilePath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\" + productline + " - " + txtLotNumber.Text + "_LOT_REPORT_" + DateTime.Now().ToString("yyyy_MM_dd_HH_mm_ss") + ".xlsx"
                ExportToExcel(dt, excelFilePath)

                MsgBox("Excel file exported successfully!", MsgBoxStyle.Information)
            Else
                MsgBox("No Data Found in GRID", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        



    End Sub
    Private Sub btn_Download_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Download.Click
        DownloadReport()
    End Sub
End Class