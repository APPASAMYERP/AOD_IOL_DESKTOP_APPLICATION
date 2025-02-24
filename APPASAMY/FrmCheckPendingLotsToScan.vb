
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Office.Interop.Excel
Imports Excel = Microsoft.Office.Interop.Excel
Imports Npgsql


Public Class FrmCheckPendingLotsToScan
    Dim table As New System.Data.DataTable
    Dim cmd As SqlCommand
    Dim Sql As String
    'Dim sqla As SqlDataAdapter
    Dim Ds As New DataSet
    Dim Dr As SqlDataReader
    Dim DtRow As DataRow
    Dim StrLorBarNo As String
    Dim dcNo As String


    Private Sub ChkModel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkModel.CheckedChanged
        If ChkModel.Checked = True Then
            CmbShModel.Enabled = True
        Else
            CmbShModel.Enabled = False
        End If
    End Sub

    Public Function getPendingLotDetails(ByVal StrSql As String) As DataSet

        Dim ds As New DataSet
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click

        Dim allLotDetails As String = ""

        If ChkModel.Checked = True And CmbShModel.Text = "" Then
            MsgBox("Select Model Name")
            CmbShModel.Focus()
            Exit Sub
        End If

        If ChkModel.Checked = True Then

            Sql = "SELECT  Model_Name+'-'+Power+'-'+Lot_Prefix+'-'+Lot_No AS Lot_Detail from Stock_verification_Completed_Lots  WHERE  Model_Name='" & CmbShModel.Text & "'  order by  Model_Name, Power, Lot_Prefix, Lot_No"
            Ds = getPendingLotDetails(Sql)
            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                allLotDetails = allLotDetails + "'" + eachRow1("Lot_Detail") + "',"
            Next
            
            If allLotDetails = "" Then
                allLotDetails = "''"
            Else
                allLotDetails = allLotDetails.Remove(allLotDetails.Length - 1, 1)
            End If
            Sql = "SELECT  Model_Name, Lot_Prefix, Lot_No , Power, SUM(Qty_1) AS Qty  FROM POUCH_LABEL " & _
        "WHERE     (Sterilization_After = '1') AND (Sterilization_Reject = '0') AND (Sample_Taken = '0') AND (BPL_Taken = '0') AND (Dc_No IS NULL) AND (Sterilization = '1') AND " & _
        "(Dc_Packing = '0') AND (Model_Name = '" & CmbShModel.Text & "') AND ((Model_Name+'-'+Power+'-'+Lot_Prefix+'-'+Lot_No) NOT IN (" & allLotDetails & ")) OR " & _
        "(Sterilization_After = '1') AND (Sterilization_Reject = '0') AND (Sample_Taken = '0') AND (BPL_Taken = '0') AND (Dc_No = '" & dcNo & "') AND (Sterilization = '1') AND " & _
        "(Model_Name = '" & CmbShModel.Text & "') AND ((Model_Name+'-'+Power+'-'+Lot_Prefix+'-'+Lot_No) NOT IN (" & allLotDetails & ")) GROUP BY Model_Name,Lot_Prefix, Lot_No, Power ORDER BY Model_Name,Lot_Prefix, Lot_No, Power"

            Ds = getPendingLotDetails(Sql)
            GRID2.DataSource = Ds.Tables(0)
        Else

            Sql = "SELECT  Model_Name+'-'+Power+'-'+Lot_Prefix+'-'+Lot_No AS Lot_Detail from Stock_verification_Completed_Lots  order by  Model_Name, Power, Lot_Prefix, Lot_No"
            Ds = getPendingLotDetails(Sql)
            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                allLotDetails = allLotDetails + "'" + eachRow1("Lot_Detail") + "',"
            Next

            If allLotDetails = "" Then
                allLotDetails = "''"
            Else
                allLotDetails = allLotDetails.Remove(allLotDetails.Length - 1, 1)
            End If

            Sql = "SELECT  Model_Name, Lot_Prefix, Lot_No , Power, SUM(Qty_1) AS Qty  FROM POUCH_LABEL " & _
        "WHERE     (Sterilization_After = '1') AND (Sterilization_Reject = '0') AND (Sample_Taken = '0') AND (BPL_Taken = '0') AND (Dc_No IS NULL) AND (Sterilization = '1') AND " & _
        "(Dc_Packing = '0')   AND ((Model_Name+'-'+Power+'-'+Lot_Prefix+'-'+Lot_No) NOT IN (" & allLotDetails & ")) OR " & _
        "(Sterilization_After = '1') AND (Sterilization_Reject = '0') AND (Sample_Taken = '0') AND (BPL_Taken = '0') AND (Dc_No = '" & dcNo & "') AND (Sterilization = '1')  " & _
        "  AND ((Model_Name+'-'+Power+'-'+Lot_Prefix+'-'+Lot_No) NOT IN (" & allLotDetails & ")) GROUP BY Model_Name,Lot_Prefix, Lot_No, Power ORDER BY Model_Name,Lot_Prefix, Lot_No, Power"

            Ds = getPendingLotDetails(Sql)
            GRID2.DataSource = Ds.Tables(0)
            
        End If
    End Sub

    Private Sub FrmCheckPendingLotsToScan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Sql = "SELECT DISTINCT Model_Name from LENS_MASTER order by Model_Name"
        If productline = "PMMA" Then
            Sql = "SELECT DISTINCT Model_Name from LENS_MASTER1 order by Model_Name"
        End If
        Ds = getPendingLotDetails(Sql)

        CmbShModel.DataSource = Ds.Tables(0)
        CmbShModel.DisplayMember = "Model_Name"


        CmbShModel.Enabled = False

        If productline = "PHOBIC" Then
            dcNo = "DC/S/9013"
        ElseIf productline = "PHILIC" Then
            dcNo = "DC/D/1253"
        ElseIf productline = "PMMA" Then
            dcNo = "DC/H/11607"
        ElseIf productline = "PHOBIC NONPRELOADED" Then
            dcNo = "DC/S/400"
        End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'CmbShModel.DataSource = Nothing

        GRID2.DataSource = Nothing
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownload.Click

        
        
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")

        For i = 0 To GRID2.RowCount - 2
            For j = 0 To GRID2.ColumnCount - 1
                For k As Integer = 1 To GRID2.Columns.Count
                    xlWorkSheet.Cells(1, k) = GRID2.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = GRID2(j, i).Value.ToString()
                Next
            Next
        Next
        Dim SaveFileDialog1 As New SaveFileDialog()
        SaveFileDialog1.Filter = "Execl files (*.xlsx)|*.xlsx"
        SaveFileDialog1.FilterIndex = 2
        SaveFileDialog1.RestoreDirectory = True
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            xlWorkSheet.SaveAs(SaveFileDialog1.FileName)
            MsgBox("Save file success")
        Else
            Return
        End If

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub


    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click

        'Dim connString As String = "Host=192.168.76.157;Port=5432;Username=openpg;Password=openpgpwd;Database=AOD_IOL"
        '' Dim conn As New NpgsqlConnection(connString)
        'Try
        '    Dim sql As String = "SELECT id,login FROM res_users  "

        '    Ds = SQL_SelectQuery_Execute(sql, conn)
        '    DataGridView1.DataSource = Ds.Tables(0)

        'Catch ex As Exception
        '    MessageBox.Show("An error occurred: " & ex.Message)
        'End Try


    End Sub


    'Public Function SQL_SelectQuery_Execute(ByVal StrSql As String, ByVal con1 As NpgsqlConnection) As DataSet

    '    Dim ds As New DataSet
    '    Dim Cmd As New NpgsqlCommand(StrSql, con1)
    '    Dim ad As New NpgsqlDataAdapter(Cmd)
    '    ad.Fill(ds)
    '    Return ds

    'End Function
End Class