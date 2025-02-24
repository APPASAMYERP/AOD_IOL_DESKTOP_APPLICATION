
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports Microsoft
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Configuration
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Diagnostics
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop
Public Class Report
    Dim ex As System.Exception
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Dim cmd As SqlCommand
    Dim StrRs As SqlDataReader
    Dim str1 As String
    Dim RowcCount, Startuppath, Destinationpath, ColcCount, Strsql As String
    Dim Streamwrite As StreamWriter

    Private Sub Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If con.State = Data.ConnectionState.Open Then
        '    con.Close()
        'End If

        'Try
        '    con.Open()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

        Me.ProgressBar1.Visible = False


    End Sub

    Private Sub btnconvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconvert.Click


        'Create excel objects
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim oValue As Object = System.Reflection.Missing.Value

        Dim sPath As String = String.Empty

        'Dim saveFileDialog1 As New SaveFileDialog()
        Dim filename As String

        'cereate new object SaveFileDialog that will be use to save the file
        Dim dlgSave As New SaveFileDialog()

        'filename = "Packing_Export_On" + DateTime.Now.ToString("dd-MMM-yyy")
        filename = cmbdcno.Text
        dlgSave.CheckPathExists = True
        dlgSave.AddExtension = True
        dlgSave.ValidateNames = True

        dlgSave.FileName = filename
        'dlgSave.DefaultExt = ".CSV"
        'dlgSave.Filter = "txt files (*.CSV)|*.*"
        dlgSave.FilterIndex = 2
        dlgSave.RestoreDirectory = True

        'If saveFileDialog1.ShowDialog() = DialogResult.OK Then

        'filename = dlgSave.FileName



        'Create a new instance of databale, this will server as container of data
        'Dim dt As New DataTable

        'We need to set the default extension to xls so the SaveFileDialog will save the file
        'as excel file
        dlgSave.DefaultExt = "xlsx"

        'Set the filter for SaveFileDialog
        dlgSave.Filter = "Microsoft Excel|*.xlsx"

        'set the initial path, you may set a different path if you like
        'dlgSave.InitialDirectory = Application.StartupPath
        dlgSave.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        'Export the data if the user click the ok button of SaveFileDialog
        If dlgSave.ShowDialog() = DialogResult.OK Then
            Try
                'Create a new instance of excel application
                xlApp = New Microsoft.Office.Interop.Excel.Application

                'Create an excel workbook
                xlBook = xlApp.Workbooks.Add(oValue)

                'Create an excel sheet named sheet1
                xlSheet = xlBook.Worksheets("sheet1")


                Dim xlRow As Long = 2
                Dim xlCol As Short = 1

                'Dim columnsCount As Integer = dtgexport.Columns.Count

                For Each column In dtgexport.Columns
                    xlSheet.Cells(1, column.Index + 1).Value = column.Name
                Next

                'To create a column for excel we need to loop through DataTable(dtStudentGrade)
                'For k As Integer = 0 To dtgexport.ColumnCount - 1

                '    'Get the column name and assigned it to excel sheet cells
                '    'to assign value to each cell we need to specify the row and column xlSheet.Cells(row, column)
                '    xlSheet.Cells(1, xlCol) = dtgexport(k, 0).Value

                '    'xlSheet.Cells(1, xlCol + 1).Value = k.Name
                '    'Increment the xlCol so we can set another column
                '    xlCol += 1

                'Next

                'reset the progressbar
                Me.ProgressBar1.Visible = True
                Me.ProgressBar1.Minimum = 0
                Me.ProgressBar1.Maximum = dtgexport.Rows.Count


                For i As Integer = 0 To dtgexport.RowCount - 1
                    'Reset(xlCol) 's value to 1 
                    xlCol = 1

                    'Loop through dtStudentGrade and set the value of each excel sheet cells
                    For k As Integer = 0 To dtgexport.ColumnCount - 1

                        'Assign the value of each field to selected excel sheet cell
                        xlSheet.Cells(xlRow, xlCol) = dtgexport(k, i).Value

                        'Increment the xlCol so we can set another the the value of another cell
                        xlCol += 1
                    Next

                    'Increment the xlCol
                    xlRow += 1

                    'Set the value of progressbar
                    If Me.ProgressBar1.Maximum > Me.ProgressBar1.Value + 1 Then
                        Me.ProgressBar1.Value = Me.ProgressBar1.Value + 1
                    End If

                Next

                'Set the filename and set the filename to xlx to save the file as excel 2003
                'You may remove the Replace function and save the file with xlsx(excel 2007) extension
                'Dim sFileName As String = Replace(dlgSave.FileName, ".xlsx", "xlx")

                'save the file
                xlSheet.SaveAs(dlgSave.FileName)

                'close the workbook
                xlBook.Close()

                'Quit the application using this code
                xlApp.Quit()

                'Release the objects used by excell application by calling our procedure releaseObject
                'releaseObject(xlApp)
                'releaseObject(xlBook)
                'releaseObject(xlSheet)


                'Reset the progressbar
                Me.ProgressBar1.Value = 0
                Me.ProgressBar1.Visible = False

                'inform the user if successfull
                MsgBox("Data successfully exported.", MsgBoxStyle.Information, "Pandian")
            Catch
                MsgBox(ErrorToString)
            Finally

            End Try
        End If
        dtgexport.DataSource = ""

    End Sub

    Private Sub btngo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngo.Click

        dtgexport.DataSource = ""

        If con.State = Data.ConnectionState.Open Then
            con.Close()

        End If

        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim StrRs1 As SqlDataReader

        'con.Open()
        str1 = "SELECT DISTINCT DC_NO FROM DC_SOFT WHERE (Created_Date BETWEEN '" & dtpdcfrom.Text & "' AND '" & dtpdcto.Text & "')"
        'str1 = "SELECT DISTINCT Dc_No FROM POUCH_LABEL WHERE (Dc_Date BETWEEN '" & dtpdcfrom.Text & "' AND '" & dtpdcto.Text & "') AND (Dc_No IS NOT NULL)GROUP BY Dc_No ORDER BY Dc_No"
        cmd = New SqlCommand(str1, con)
        StrRs = cmd.ExecuteReader
        cmbdcno.Items.Clear()
        'Try
        While StrRs.Read
            cmbdcno.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        cmd.Dispose()
        con.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

        ' ''str1 = "SELECT  DATENAME(weekday, Box_Date) AS Day, CONVERT(Varchar, Box_Date, 101) AS Date, MIN(RIGHT(Lot_SrNo, 5)) AS Start_No, MAX(RIGHT(Lot_SrNo, 5)) AS Stop_No, SUM(Box_Packing) AS Total_Count, btc_No As BatchID FROM POUCH_LABEL WHERE(Box_Date BETWEEN '" & dtpdcfrom.Value & "' AND '" & dtpdcto.Value & "') GROUP BY Box_Date, btc_No ORDER BY date"
        'con.Open()
        'adp = New SqlDataAdapter(str1, con)
        'Dim ds4 As New DataSet()
        'adp.Fill(ds4, "POUCH_LABEL")

        'If (ds4.Tables(0).Rows.Count = 0) Then

        '    MessageBox.Show("Box packing Does Not Exists in this Date", "Pandian")
        'Else

        '    dtgexport.DataSource = ds4.Tables(0)


        'End If


    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click

        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If

      
        '' Strsql = "SELECT   DATENAME(weekday, Box_Date) AS Day, CONVERT(Varchar, Box_Date, 101) AS Date, MIN(RIGHT(Lot_SrNo, 5)) AS Start_No, MAX(RIGHT(Lot_SrNo, 5)) AS Stop_No, SUM(Box_Packing) AS Total_Count, btc_No As BatchID FROM POUCH_LABEL WHERE(Box_Date BETWEEN '" & dtpdcfrom.Value & "' AND '" & dtpdcto.Value & "') GROUP BY Box_Date, btc_No ORDER BY date"
        ''Strsql = "SELECT Ord_Country AS Order_Moria,Reference_Name As Moria_Ref, Brand_Name As Moria_Designation, btc_no As Lot ,CAST(Power as varchar)+ ' D' As Power,CAST(Mfd_Month AS varchar) + '-' + CAST(Mfd_Year AS varchar) AS MFDate, CAST(Exp_Month AS varchar) + '-' + CAST(Exp_Year AS varchar) AS ExpDate,Lot_SrNo As Serial_No,Qty_1 As Qty, Small_Box As Parcel_No FROM POUCH_LABEL WHERE (Dc_No = '" + cmbdcno.Text + "') ORDER BY Lot_SrNo"
        '        Strsql = "SELECT (Brand_Name+' '+Model_Name+' ('+Cast(Power as varchar)+')') as Product_Name,(Lot_Srno+','+Cast(Power as varchar)+' D,'+Model_name+','+Brand_name+','+Cast(Optic as varchar)+' mm,'+Cast(Length as varchar)+' mm,'+(Cast(Exp_Month as varchar)+'-'+Cast(Exp_year as varchar))+','+Btc_No) as scanformat, CAST(Exp_Month AS varchar) + '-' + CAST(Exp_Year AS varchar) AS ExpDate FROM POUCH_LABEL WHERE (Dc_No = '" + cmbdcno.Text + "') ORDER BY Lot_SrNo"
        Strsql = "SELECT (Brand_Name+' '+Model_Name+' ('+Cast(Power as varchar)+')') as Product_Name,(Lot_Srno+','+Cast(Power as varchar)+' D,'+Model_name+','+Brand_name+','+Cast(Optic as varchar)+' mm,'+Cast(Length as varchar)+' mm,'+(Cast(Exp_Month as varchar)+'-'+Cast(Exp_year as varchar))+','+Btc_No) as scanformat,CAST(MFD_Month AS varchar) + '-' + CAST(MFD_Year AS varchar) AS MFDDate, CAST(Exp_Month AS varchar) + '-' + CAST(Exp_Year AS varchar) AS ExpDate,Type_GS_Code as MFDUnit FROM POUCH_LABEL WHERE (Dc_No = '" + cmbdcno.Text + "') ORDER BY Lot_SrNo"
        con.Open()
        adp = New SqlDataAdapter(Strsql, con)
        Dim ds4 As New DataSet()
        adp.Fill(ds4, "POUCH_LABEL")

        If (ds4.Tables(0).Rows.Count = 0) Then

            MessageBox.Show("DC Does Not Exists in this Date", "Pandian")
        Else

            dtgexport.DataSource = ds4.Tables(0)


        End If


    End Sub

    Private Sub btncsvexport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncsvexport.Click

        'Dim myStream As Stream
        Dim saveFileDialog1 As New SaveFileDialog()
        Dim filename As String

        'filename = "Packing_Export_On" + DateTime.Now.ToString("dd-MMM-yyy")
        filename = cmbdcno.Text
        saveFileDialog1.CheckPathExists = True
        saveFileDialog1.AddExtension = True
        saveFileDialog1.ValidateNames = True
        saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        saveFileDialog1.FileName = filename
        saveFileDialog1.DefaultExt = ".CSV"
        saveFileDialog1.Filter = "txt files (*.CSV)|*.*"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then

            filename = saveFileDialog1.FileName

            If dtgexport.RowCount > 0 Then
                RowcCount = ""

                'Startuppath = Application.StartupPath + "/"
                ''//File Extension as your requirement .dat or .txt 

                'Destinationpath = Startuppath + "" + DateTime.Now.ToString("dd-MMM-yyy") + ".CSV"
                Destinationpath = filename

                'For Each column As DataGridViewColumn In dtgexport.Columns
                '    Dim cell As New PdfPCell(New Phrase(column.HeaderText))
                '    cell.BackgroundColor = New iTextSharp.text.Color(240, 240, 240)
                '    pdfTable.AddCell(cell)
                'Next
                ColcCount = ""
                For Each column As DataGridViewColumn In dtgexport.Columns

                    If (ColcCount.Length > 0) Then

                        ColcCount = ColcCount + "," + column.HeaderText

                    Else

                        ColcCount = column.HeaderText
                    End If


                Next


                Using Streamwrite = File.CreateText(Destinationpath)

                    'Dim i, j As Integer
                    Streamwrite.WriteLine(ColcCount)

                    For i As Integer = 0 To dtgexport.Rows.Count - 2

                        RowcCount = ""

                        For j As Integer = 0 To dtgexport.Columns.Count - 1

                            If (RowcCount.Length > 0) Then

                                RowcCount = RowcCount + "," + dtgexport.Rows(i).Cells(j).Value.ToString()

                            Else

                                RowcCount = dtgexport.Rows(i).Cells(j).Value.ToString()
                            End If

                        Next j

                        Streamwrite.WriteLine(RowcCount)

                    Next i

                    Streamwrite.WriteLine(Streamwrite.NewLine)
                    Streamwrite.Close()
                    MessageBox.Show("File Created Successfully")


                End Using
            Else

            End If


        End If
        dtgexport.DataSource = ""


    End Sub
End Class