
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration

Public Class FrmTrayLabelReprint
    Dim StrDtFr As String
    Dim StrDtTo As String
    Dim cmd As SqlCommand
    Dim Sql As String
    Dim Ds As New DataSet
    Private headerCheckBox As CheckBox = New CheckBox()
    Dim bt As New BarTender.Format
    Dim bApp As New BarTender.Application
    Dim btFile As String
    Dim getDetails As String
    Dim checkBoxColumnAdded As Integer
    Dim SqlCk1 As String
    Dim SqlCk2 As String
    Dim RsCk1 As SqlDataReader
    Dim Cmd2 As New SqlCommand



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


    Public Function getDistinctAllUsedTrayNumber(ByVal FrDate As String, ByVal ToDate As String) As DataSet

        Dim ds As New DataSet

        Dim StrSql As String = "SELECT DISTINCT Tray_No FROM  POUCH_LABEL  WHERE " & _
                " (Tray_No IN (SELECT DISTINCT Tray_From FROM  TrayRack_Movement WHERE  (Created_Date BETWEEN '" & FrDate & "' AND '" & ToDate & "') and Tray_label_updated ='0' )) OR" & _
                 " (Tray_No IN (SELECT DISTINCT Tray_To FROM  TrayRack_Movement WHERE  (Created_Date BETWEEN '" & FrDate & "' AND '" & ToDate & "')and Tray_label_updated ='0' )) "

        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Public Function getDistinctTrayNumber(ByVal trayNumbers As String) As DataSet

        Dim ds As New DataSet

        Dim StrSql As String = "SELECT DISTINCT  SUBSTRING(Rack_Location, 1, CHARINDEX('-', Rack_Location) - 1) AS Rack FROM  POUCH_LABEL  WHERE " & _
                "(Tray_No IN (" & trayNumbers & ")) AND (Sterilization_After = '1') AND (Sterilization_Reject = '0') AND (Sample_Taken = '0')  " & _
                "  AND (BPL_Taken = '0') AND (Dc_No IS NULL) AND (Sterilization = '1') AND (Dc_Packing = '0')"

        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function


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


    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Dim strTrayNumbers As String = ""

        StrDtFr = Format(dtpToDate.Value.AddDays(-15), "yyyy-MM-dd") & " 00:00:01"
        StrDtTo = Format(dtpToDate.Value, "yyyy-MM-dd") & " 23:59:59"

        Ds = getDistinctAllUsedTrayNumber(StrDtFr, StrDtTo)
        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            strTrayNumbers = strTrayNumbers + "'" + eachRow1("tray_no").ToString() + "',"
        Next
        strTrayNumbers = strTrayNumbers.Remove(strTrayNumbers.Length - 1, 1)


        Ds = getDistinctTrayNumber(strTrayNumbers)
        dataGridView1.DataSource = Ds.Tables(0)

        If checkBoxColumnAdded = 0 Then

            'Find the Location of Header Cell.
            Dim headerCellLocation As Point = Me.dataGridView1.GetCellDisplayRectangle(0, -1, True).Location

            'Place the Header CheckBox in the Location of the Header Cell.
            headerCheckBox.Location = New Point(headerCellLocation.X + 8, headerCellLocation.Y + 2)
            headerCheckBox.BackColor = Color.White
            headerCheckBox.Size = New Size(18, 18)

            'Assign Click event to the Header CheckBox.
            AddHandler headerCheckBox.Click, AddressOf HeaderCheckBox_Clicked
            dataGridView1.Controls.Add(headerCheckBox)

            'Add a CheckBox Column to the DataGridView at the first position.
            Dim checkBoxColumn As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn()
            checkBoxColumn.HeaderText = ""
            checkBoxColumn.Width = 30
            checkBoxColumn.Name = "checkBoxColumn"
            dataGridView1.Columns.Insert(0, checkBoxColumn)
            'Assign Click event to the DataGridView Cell.
            AddHandler dataGridView1.CellContentClick, AddressOf dataGridView1_CellClick

            checkBoxColumnAdded = 1
        End If
        
    End Sub

    Private Sub dataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataGridView1.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then

            'Loop to verify whether all row CheckBoxes are checked or not.
            Dim isChecked As Boolean = True
            For Each row As DataGridViewRow In dataGridView1.Rows
                If Convert.ToBoolean(row.Cells("checkBoxColumn").EditedFormattedValue) = False Then
                    isChecked = False
                    Exit For
                End If
            Next

            headerCheckBox.Checked = isChecked
        End If
    End Sub

    Private Sub HeaderCheckBox_Clicked(ByVal sender As Object, ByVal e As EventArgs)
        'Necessary to end the edit mode of the Cell.
        dataGridView1.EndEdit()

        'Loop and check and uncheck all row CheckBoxes based on Header Cell CheckBox.
        For Each row As DataGridViewRow In dataGridView1.Rows
            Dim checkBox As DataGridViewCheckBoxCell = (TryCast(row.Cells("checkBoxColumn"), DataGridViewCheckBoxCell))
            checkBox.Value = headerCheckBox.Checked
        Next
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
        Menulblmstdatacre.LblHomeMenuDisplyName.Visible = False
        Menulblmstdatacre.TimHomeSideDisply.Start()
    End Sub

    Public Function getTrayDetail(ByVal trayNumber As String) As DataSet

        Dim ds As New DataSet
        Dim StrSql As String
        Dim trayDetail As String = Nothing

        StrSql = "SELECT     CAST(Power AS varchar) + ' - ' + Lot_Prefix + Lot_No + ' ' + RIGHT('00' + CAST(MIN(St_SrNo) AS varchar), 3)  + ' TO ' + RIGHT('00' + CAST(MAX(St_SrNo) AS varchar), 3) + ' - ' + CAST(SUM(Qty_1) AS varchar) AS TrayDeatil, Model_Name, Power, Btc_No, Lot_Prefix+Lot_No AS lotno, MIN(St_SrNo) AS SFROM, MAX(St_SrNo) AS STO, SUM(Qty_1) AS Qty, Tray_No , Rack_Location FROM POUCH_LABEL  WHERE  (Tray_No = '" & trayNumber & "') AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) GROUP BY Model_Name, Power, Btc_No, Lot_Prefix, Lot_No, Tray_No, Rack_Location ORDER BY Lot_Prefix, Lot_No"

        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds
        
    End Function
    Public Sub TraYLabelPrint()

        If dataGridView1.Rows.Count > 0 Then
            For i = 0 To dataGridView1.Rows.Count - 1
                If dataGridView1.Rows(i).Cells("checkBoxColumn").Value = True Then

                    Dim trayDetail As String = Nothing
                    Dim trayModel As String = Nothing
                    Dim sterileBatch As String = Nothing
                    Dim RackNo As String = Nothing
                    Dim dsTrayDetail As New DataSet


                    'PHOBIC
                    Dim trayPower As String = Nothing
                    Dim trayLotNo As String = Nothing
                    Dim StSrNo As Integer = 200
                    Dim EnSrNo As Integer = 0
                    Dim totTrayQty As Integer = 0




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
                    dsTrayDetail = getTrayDetail(dataGridView1.Rows(i).Cells("Tray_No").Value)
                    For Each eachRecord As DataRow In dsTrayDetail.Tables(0).Rows
                        trayDetail = trayDetail + Environment.NewLine + eachRecord("TrayDeatil").ToString()
                        trayModel = eachRecord("Model_Name").ToString()
                        RackNo = eachRecord("Rack_Location").ToString()
                        sterileBatch = eachRecord("Btc_No").ToString()

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
                        If productline = "PHILIC" Then
                            If traydetailRowCount = 6 Then
                                bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                                bt.SetNamedSubStringValue("trayDetail", trayDetail)
                                bt.SetNamedSubStringValue("model", trayModel)
                                bt.SetNamedSubStringValue("trayNo", dataGridView1.Rows(i).Cells("Tray_No").Value.ToString())
                                bt.SetNamedSubStringValue("batchNo", sterileBatch)

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
                        End If

                    Next

                    If productline = "PHILIC" And traydetailRowCount = 0 Then
                    Else
                        bt = bApp.Formats.Open(btFile, , DefaultPrinterName)
                        bt.SetNamedSubStringValue("trayDetail", trayDetail)
                        bt.SetNamedSubStringValue("model", trayModel)
                        bt.SetNamedSubStringValue("trayNo", dataGridView1.Rows(i).Cells("Tray_No").Value.ToString())
                        bt.SetNamedSubStringValue("batchNo", sterileBatch)

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

                    Sql = "Update TrayRack_Movement set Tray_label_updated='1' where Tray_From='" & dataGridView1.Rows(i).Cells("Tray_No").Value.ToString() & "' OR Tray_To='" & dataGridView1.Rows(i).Cells("Tray_No").Value.ToString() & "'"
                    cmd = New SqlCommand(Sql, con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()


                End If




            Next i
            dataGridView1.DataSource = Nothing
        Else
            MsgBox("Please Add minimum 1 Serial Number.")
            Exit Sub
        End If



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

    Private Sub CheckTMP_BPL_LIST()


        Try

            SqlCk2 = "Drop Table temp_RackBin"
            UpdateorInsertQuery_Execute(SqlCk2)
        Catch ex As Exception

        End Try



    End Sub

    Public Sub ViewRackReport()

        If CmbRack.SelectedItem <> "" Then


            CheckTMP_BPL_LIST()
            Dim StrSql As String = ""
            Dim trayNumbers As String = ""

            StrSql = "SELECT     CAST(Power AS varchar) + ' - ' + Lot_Prefix + Lot_No + ' ' + RIGHT('00' + CAST(MIN(St_SrNo) AS varchar), 3) + ' TO ' + RIGHT('00' + CAST(MAX(St_SrNo) AS varchar), 3)  " & _
         "+ ' - ' + CAST(SUM(Qty_1) AS varchar) AS TrayDeatil, Model_Name, Power, Btc_No, Lot_Prefix + Lot_No AS lotno, RIGHT('00' + CAST(MIN(St_SrNo) AS varchar), 3)  AS SFROM, RIGHT('00' + CAST(MAX(St_SrNo) AS varchar), 3) AS STO, " & _
         "SUM(Qty_1) AS Qty, Tray_No, Rack_Location   INTO temp_RackBin FROM   POUCH_LABEL  WHERE     (Sterilization = 1) AND (Areation_Status = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND " & _
         "  (Sterilization_Reject = 0) AND (SUBSTRING(Rack_Location, 0, CHARINDEX('-', Rack_Location)) = '" & CmbRack.Text & "') " & _
         "GROUP BY Model_Name, Power, Btc_No, Lot_Prefix, Lot_No, Tray_No, Rack_Location " & _
         " ORDER BY Lot_Prefix, Lot_No, Tray_No, Rack_Location "

            UpdateorInsertQuery_Execute(StrSql)


            '   StrSql = "SELECT     Rack_location, Tray_No, stuff ((SELECT DISTINCT CHAR(10) + MOdel_name FROM         temp_RackBin AS t2 WHERE     t2.Tray_No = t1.Tray_No FOR XML PATH('')), 1, 1, '') AS Model_Name,  " & _
            '"stuff ((SELECT DISTINCT CHAR(10) + Power FROM         temp_RackBin AS t2 WHERE     t2.Tray_No = t1.Tray_No FOR XML PATH('')), 1, 1, '') AS Power, stuff " & _
            '"((SELECT DISTINCT CHAR(10) + Btc_no  FROM         temp_RackBin AS t2 WHERE     t2.Tray_No = t1.Tray_No FOR XML PATH('')), 1, 1, '') AS Btc_No, stuff " & _
            '"  ((SELECT DISTINCT CHAR(10) + lotno + ' ' + cast(Sfrom AS varchar) + '-' + cast(sto AS varchar) + '--' + cast(qty AS varchar) " & _
            '" FROM         temp_RackBin AS t2 WHERE     t2.Tray_No = t1.Tray_No FOR XML PATH('')), 1, 1, '') AS Lot_No ,  SUBSTRING(Rack_Location, 0, CHARINDEX('-', Rack_Location) + 2) AS Rack  FROM         temp_RackBin AS t1  " & _
            '" GROUP BY Rack_location, Tray_No ORDER BY Rack_location, Tray_No "


            'StrSql = "SELECT     Rack_location, Tray_No, stuff ((SELECT DISTINCT CHAR(10) + MOdel_name FROM         temp_RackBin AS t2 WHERE     t2.Tray_No = t1.Tray_No FOR XML PATH('')), 1, 1, '') AS Model,  " & _
            '                " stuff ((SELECT DISTINCT CHAR(10) + Btc_No + REPLICATE(' ', 22 - LEN(Btc_No)) + Power + REPLICATE(' ', 11 - LEN(Power)) + Model_name + REPLICATE(' ', 26 - LEN(Model_name)) " & _
            '                " + lotno + ' ' + cast(Sfrom AS varchar) + '-' + cast(sto AS varchar) + REPLICATE(' ', 35 - LEN(lotno + ' ' + cast(Sfrom AS varchar) + '-' + cast(sto AS varchar))) + cast(qty AS varchar) " & _
            '                 " FROM         temp_RackBin AS t2 WHERE     t2.Tray_No = t1.Tray_No   FOR XML PATH('')), 1, 1, '') AS  Tray_Detail, Sum(Qty) As Total " & _
            '        "  FROM         temp_RackBin AS t1  " & _
            '        " GROUP BY Rack_location, Tray_No  ORDER BY Rack_location, Tray_No"

            StrSql = "SELECT     Rack_location, Tray_No, stuff ((SELECT DISTINCT CHAR(10) + MOdel_name FROM         temp_RackBin AS t2 WHERE     t2.Tray_No = t1.Tray_No FOR XML PATH('')), 1, 1, '') AS Model,  " & _
                            " stuff ((SELECT DISTINCT CHAR(10) + Btc_No +  '//' + Power +  '//' + Model_name +  '//' " & _
                            " + lotno + ' ' + cast(Sfrom AS varchar) + '-' + cast(sto AS varchar) + '//' + cast(qty AS varchar) " & _
                             " FROM         temp_RackBin AS t2 WHERE     t2.Tray_No = t1.Tray_No   FOR XML PATH('')), 1, 1, '') AS  Tray_Detail, Sum(Qty) As Total " & _
                    "  FROM         temp_RackBin AS t1  " & _
                    " GROUP BY Rack_location, Tray_No  ORDER BY Rack_location, Tray_No"


            Ds = SQL_SelectQuery_Execute(StrSql)


            Dim cryRpt As New cryRackBinReport
            cryRpt.SetDataSource(Ds.Tables(0))
            CryViewRackBin.ReportSource = cryRpt

            Dim txtRack As CrystalDecisions.CrystalReports.Engine.TextObject
            txtRack = cryRpt.ReportDefinition.Sections(0).ReportObjects("txtRack")
            txtRack.Text = CmbRack.Text




            ' For update trayRack_Movement
            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                trayNumbers = trayNumbers + "'" + eachRow1("Tray_No") + "',"
            Next

            If trayNumbers = "" Then
                trayNumbers = "''"
            Else
                trayNumbers = trayNumbers.Remove(trayNumbers.Length - 1, 1)
            End If


            Sql = "Update TrayRack_Movement set Tray_label_updated='1' where Tray_From IN(" & trayNumbers & ") OR Tray_To IN(" & trayNumbers & ")"
            UpdateorInsertQuery_Execute(Sql)


            loadForm()


        Else
            MsgBox("No Rack Selected. Please check")
            Exit Sub


        End If

    End Sub



    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            If CmbRack.SelectedItem Is Nothing Then
                MessageBox.Show("Please Select valid Rack")
                CmbRack.Focus() 
                Exit Sub
            End If

            'TraYLabelPrint()
            ViewRackReport()
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        

        
    End Sub


    Private Sub loadForm()

        'Dim strTrayNumbers As String = ""

        'StrDtFr = Format(dtpToDate.Value.AddDays(-15), "yyyy-MM-dd") & " 00:00:01"
        'StrDtTo = Format(dtpToDate.Value, "yyyy-MM-dd") & " 23:59:59"

        'Ds = getDistinctAllUsedTrayNumber(StrDtFr, StrDtTo)
        'For Each eachRow1 As DataRow In Ds.Tables(0).Rows
        '    strTrayNumbers = strTrayNumbers + "'" + eachRow1("tray_no").ToString() + "',"
        'Next

        'If strTrayNumbers = "" Then
        '    strTrayNumbers = "''"
        'Else
        '    strTrayNumbers = strTrayNumbers.Remove(strTrayNumbers.Length - 1, 1)
        'End If

        'Ds = getDistinctTrayNumber(strTrayNumbers)

        Ds = getDistinctRackNumbers()
        CmbRack.Items.Clear()
        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            CmbRack.Items.Add(eachRow1("Rack"))
        Next

        'CmbRack.DataSource = Ds.Tables(0)
        'CmbRack.DisplayMember = "Rack"



    End Sub

    Private Sub FrmTrayLabelReprint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            loadForm()

            checkBoxColumnAdded = 0
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
    End Sub
End Class