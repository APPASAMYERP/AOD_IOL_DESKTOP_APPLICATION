Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmBoxPackingReprintReport
    Dim StrSql As String
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

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Try
            If FromDate.Value > ToDate.Value Then
                'error
            End If
            Dim dateFrom As String = ""
            Dim dateTo As String = ""
            dateFrom = Format(FromDate.Value, "yyyy-MM-dd") & " 00:00:01"
            dateTo = Format(ToDate.Value, "yyyy-MM-dd") & " 23:59:59"

            StrSql = " SELECT     Lot_SrNo, Box_By, Boxtime, Station, BoxBTWLabelName, Injector_Ref, Injector_batch, CASE WHEN IsErpUser = 1 THEN 'YES' ELSE 'NO' END AS IsErpUser, " & _
                        " CASE WHEN isErpuser = 0 THEN Reprint_User_Level ELSE NULL END AS Reprint_User_Level  FROM         Box_Packing_Reprint_details " & _
                        "  WHERE     (Boxtime BETWEEN '" & dateFrom & "' AND '" & dateTo & "')  " & _
                        "  ORDER BY Boxtime  "
            Ds = SQL_SelectQuery_Execute(StrSql)

            DataGridView1.DataSource = Ds.Tables(0)

        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
    

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


            Application.DoEvents()
        Next

        xlWorkSheet.Name = "BOXREPORT_" & DateTime.Now().ToString("yyyy_MM_dd_HH_mm_ss")
        ' Save the Excel file
        xlWorkBook.SaveAs(excelFilePath)
        xlWorkBook.Close()
        xlApp.Quit()

        ReleaseObject(xlApp)
        ReleaseObject(xlWorkBook)
        ReleaseObject(xlWorkSheet)

    End Sub
    Private Sub btn_download_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_download.Click
        Dim dt As DataTable
        dt = DataGridView1.DataSource
        'Dim excelFilePath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "_" + productline + "\_BOXPACK_REPRINT_REPORT_" + DateTime.Now().ToString("yyyy_MM_dd_HH_mm_ss") + ".xlsx"


        Dim excelFilePath As String = ""
        Using saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx"
            saveFileDialog.Title = "Select File Location"
            saveFileDialog.FileName = productline & "_BOXPACK_REPRINT_REPORT_" & DateTime.Now().ToString("yyyy_MM_dd_HH_mm_ss") & ".xlsx"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                excelFilePath = saveFileDialog.FileName
            End If
        End Using

        ExportToExcel(dt, excelFilePath)
        MsgBox("Excel file exported successfully!", MsgBoxStyle.Information)
    End Sub
End Class