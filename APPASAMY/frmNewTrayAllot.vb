
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration

Public Class frmNewTrayAllot
    Dim Ds As New DataSet
    Dim serialTable As New DataTable

    Dim Str_Header As Integer
    Dim Str_Detail As Integer
    Dim StrUniqueNo As String
    Dim StrSqlSeHd As String

    Public Function SQL_SelectQuery_Execute(ByVal StrSql As String) As DataSet

        Dim ds As New DataSet
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Public Function SQL_SelectQuery_Execute_with_ConString(ByVal StrSql As String, ByVal conStr As SqlConnection) As DataSet

        Dim ds As New DataSet
        Dim Cmd As New SqlCommand(StrSql, conStr)
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


    Public Sub LoadTrayAllotNO()

        Str_Header = 0
        Str_Detail = 0
        StrSqlSeHd = "Select Max(Header_ID) As Header, Max(Detail_ID) As Detail from Tray_Allot_Details"
        Ds = SQL_SelectQuery_Execute(StrSqlSeHd)

        If DBNull.Value.Equals(Ds.Tables(0).Rows(0)("Header")) Then
            Str_Header = 0
        Else
            Str_Header = Val(Ds.Tables(0).Rows(0)("Header"))
        End If

        If DBNull.Value.Equals(Ds.Tables(0).Rows(0)("Detail")) Then
            Str_Detail = 0
        Else
            Str_Detail = Val(Ds.Tables(0).Rows(0)("Detail"))
        End If


        If Str_Header = 0 Then
            Str_Header = 1
        Else
            Str_Header = Str_Header + 1
        End If

        If Str_Detail = 0 Then
            Str_Detail = 1
        Else
            Str_Detail = Str_Detail + 1
        End If


        StrUniqueNo = productline & "-TA-" & Format(Now, "ddMMyy") & "-" & Str_Header
        lblMovementNo.Text = StrUniqueNo

    End Sub


    Public Function getBatchNumbers() As String


        Dim btaches As String = ""
        Dim ds As New DataSet
        Dim StrSql As String = "SELECT DISTINCT Btc_No FROM         POUCH_LABEL   WHERE     (pouchRepack_staus = '1')"
        ds = SQL_SelectQuery_Execute(StrSql)
         

        For Each eachRow1 As DataRow In ds.Tables(0).Rows
            btaches = btaches + "'" + eachRow1("Btc_No") + "',"

        Next
        If btaches <> "" Then
            btaches = btaches.Remove(btaches.Length - 1, 1)
        Else
            Return "''"
        End If

        Return btaches

    End Function

    Public Function SterileBatchBind() As DataSet
        Dim SterileBatches As String = ""
        SterileBatches = getBatchNumbers()

        Dim ds As New DataSet
        Dim StrSql As String = "SELECT DISTINCT Btc_No from POUCH_LABEL  WHERE    ( (Mfd_Year = '2023') AND (Mfd_Month NOT IN ('1', '2', '3', '4'))   OR (Mfd_Year >= '2024') ) AND (Tray_No IS NULL) AND (Tray_Label_Gen IS NULL) AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) and (pouchRepack_staus is NULL) and Btc_No not in(" & SterileBatches & ") AND (Areation_Status = 1) order by Btc_No"
        ds = SQL_SelectQuery_Execute(StrSql)
        Return ds

    End Function

    Private Sub frmNewTrayAllot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadTrayAllotNO()
        Ds = SterileBatchBind()
        cmbStbatch.Items.Clear()
        TextBox1.Text = ""
        For Each eachRow As DataRow In Ds.Tables(0).Rows
            cmbStbatch.Items.Add(eachRow("Btc_No"))
        Next




        'Unique Serial Grid View
        serialTable.Columns.Add("Model_Name", GetType(String))
        serialTable.Columns.Add("Power", GetType(String))
        serialTable.Columns.Add("Batch", GetType(String))
        serialTable.Columns.Add("Lot_Number", GetType(String))
        serialTable.Columns.Add("St_SrNo", GetType(String))
        serialTable.Columns.Add("Qty", GetType(String))
        serialTable.Columns.Add("TrayNo", GetType(String))
        serialTable.Columns.Add("Rack_Location", GetType(String))
        DataGridView1.DataSource = serialTable


        With DataGridView1.ColumnHeadersDefaultCellStyle
            .Alignment = DataGridViewContentAlignment.TopRight
            .BackColor = Color.DarkRed
            .ForeColor = Color.Gold
            .Font = New Font(.Font.FontFamily, .Font.Size, _
             .Font.Style Or FontStyle.Bold, GraphicsUnit.Point)
        End With

    End Sub


    Public Function sampleLens() As DataSet

        Dim ds, dsPhobic, dsNP As New DataSet
        Dim dtPhobic, dtNP As New DataTable
        Dim conPHOBIC, conNP As New SqlConnection

        conPHOBIC.ConnectionString = ConfigurationSettings.AppSettings("conStrPHOBIC").ToString()
        conNP.ConnectionString = ConfigurationSettings.AppSettings("conStrPHOBICNONPRE").ToString()

        Dim StrSql As String = "SELECT SUM(Qty_1)as Qty from POUCH_LABEL  WHERE  (Btc_No = '" & cmbStbatch.Text & "') AND (Sample_Taken = '1' OR BPL_NO LIKE 'CST%' ) "



        If productline = "PHOBIC" Or productline = "PHOBIC NONPRELOADED" Then
            'Phobic             
            dsPhobic = SQL_SelectQuery_Execute_with_ConString(StrSql, conPHOBIC)
            dtPhobic = dsPhobic.Tables(0)

            'NP
             
            dsNP = SQL_SelectQuery_Execute_with_ConString(StrSql, conNP)
            dtNP = dsNP.Tables(0)
            dtPhobic.Merge(dtNP)


            Return dtPhobic.DataSet

        Else
            ds = SQL_SelectQuery_Execute(StrSql)
            Return ds
        End If



    End Function

    Public Function getAllSeialNumber() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = "SELECT     Model_Name, Power, Btc_No, Lot_Prefix+Lot_No AS lotno,St_SrNo, Qty_1 AS Qty FROM POUCH_LABEL  WHERE  (Tray_No IS NULL or Tray_No='') AND (Btc_No = '" & cmbStbatch.Text & "') AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) ORDER BY Model_Name, Lot_Prefix, Lot_No, Lot_SrNo"
        ds = SQL_SelectQuery_Execute(StrSql)
        Return ds

    End Function

    Public Function getDistintModel() As DataSet

        Dim ds As New DataSet
        Dim StrSql As String = ""
        StrSql = "SELECT     DISTINCT  Model_Name,Power FROM POUCH_LABEL  WHERE  (Tray_No IS NULL or Tray_No='') AND (Btc_No = '" & cmbStbatch.Text & "') AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0)AND (Areation_Status = 1) ORDER BY Model_Name, CAST(Power AS float)"


        ds = SQL_SelectQuery_Execute(StrSql)
        Return ds

    End Function


    Public Function check_Allocation(ByVal Model_Name As String) As Integer

        Dim ds As New DataSet
        Dim StrSql As String = ""
        StrSql = "SELECT     SUM(Max_Qty - Filled_Qty) AS bal_qty  FROM         Tray_Rack_Master WHERE     (Model_Name = '" & Model_Name & "') "


        ds = SQL_SelectQuery_Execute(StrSql)
        Return ds.Tables(0).Rows(0)("bal_qty")

    End Function


    Public Function getTrayAllot(ByVal qty As Integer, ByVal Model_name As String) As DataSet


        Dim ds As New DataSet
        Dim StrSql As String = ""
        StrSql = "  SELECT     Rack_No, Rack_Location, Tray_No, Allocated_Qty " & _
        " FROM         (SELECT     Rack_No, Rack_Location, Tray_No, CASE WHEN Cumulative_Balance <= " & qty & " THEN Balance WHEN Cumulative_Balance - Balance < " & qty & " THEN " & qty & " - (Cumulative_Balance - Balance) " & _
        " ELSE 0 END AS Allocated_Qty " & _
        " FROM          (SELECT       CAST(Sequence_id AS int) AS Sequence_id, CAST(Rack_No AS int) AS Rack_No, CAST(Rack_Location AS nvarchar(10)) AS Rack_Location, CAST(Tray_No AS nvarchar(50)) AS Tray_No, Max_Qty, Filled_Qty, " & _
        " Max_Qty - Filled_Qty AS Balance, " & _
        " (SELECT     SUM(Max_Qty - Filled_Qty) AS Expr1 " & _
        " FROM          Tray_Rack_Master AS t2 " & _
        " WHERE        (Model_Name = '" & Model_name & "') AND (Sequence_id <= t1.Sequence_id) ) AS Cumulative_Balance " & _
        " FROM          Tray_Rack_Master AS t1 WHERE     (Model_Name = '" & Model_name & "' ) ) AS t1_1) AS Distributed_Temp " & _
        " WHERE     (Allocated_Qty > 0) " & _
        " ORDER BY Rack_No, Rack_Location, Tray_No "

        ds = SQL_SelectQuery_Execute(StrSql)
        Return ds

    End Function


    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click

        'validation
        If cmbStbatch.SelectedItem Is Nothing Then
            MessageBox.Show("Please Select valid Batch")
            cmbStbatch.Focus()
            Exit Sub
        End If



        Dim dsSampleLens As DataSet
        Dim sampleLensQty As Integer = 0
        Dim dsAllSerial As DataSet
        Dim dsDistinctModel As DataSet

        Dim Model_Power_wise_batch_Qty, Bal_TrayQty As Integer
        Dim dsAllotTray As DataSet
        ' Validation for sample lens must taken for each Batch 

        dsSampleLens = sampleLens()
        For Each eachQty As DataRow In dsSampleLens.Tables(0).Rows
            If Not IsDBNull(eachQty("Qty")) Then
                sampleLensQty = sampleLensQty + Convert.ToInt32(eachQty("Qty"))
            End If
        Next

        If productline = "PMMA" Then
            If sampleLensQty < 70 Then
                GRID2.Rows.Clear()
                DataGridView1.DataSource.Rows.Clear()
                TextBox1.Text = ""
                MessageBox.Show("The Sample taken Process is not done. Please Check")
                Exit Sub
            End If
        ElseIf productline = "PHILIC" Then
            If sampleLensQty < 73 Then
                GRID2.Rows.Clear()
                DataGridView1.DataSource.Rows.Clear()
                TextBox1.Text = ""
                MessageBox.Show("The Sample taken Process is not done. Please Check")
                Exit Sub
            End If
        ElseIf productline = "PHOBIC" Then
            If sampleLensQty < 64 Then
                GRID2.Rows.Clear()
                TextBox1.Text = ""
                DataGridView1.DataSource.Rows.Clear()
                MessageBox.Show("The Sample taken Process is not done. Please Check")
                Exit Sub
            End If
        ElseIf productline = "PHOBIC NONPRELOADED" Then
            If sampleLensQty < 64 Then
                GRID2.Rows.Clear()
                TextBox1.Text = ""
                DataGridView1.DataSource.Rows.Clear()
                MessageBox.Show("The Sample taken Process is not done. Please Check")
                Exit Sub
            End If
        End If






        GRID2.Rows.Clear()
        dsAllSerial = getAllSeialNumber()
        serialTable.Rows.Clear()
        Try
            DataGridView1.DataSource.Rows.Clear()

        Catch ex As Exception

        End Try
        

        dsDistinctModel = getDistintModel()
        For Each eachModel As DataRow In dsDistinctModel.Tables(0).Rows

            Model_Power_wise_batch_Qty = dsAllSerial.Tables(0).Select("Model_Name = '" & eachModel("Model_Name").ToString() & "' AND Power = '" & eachModel("Power").ToString() & "'").Length()

            Bal_TrayQty = check_Allocation(eachModel("Model_Name").ToString())
            If Model_Power_wise_batch_Qty > Bal_TrayQty Then
                MessageBox.Show("No Space  " & eachModel("Model_Name").ToString() & " batch Qty -" & Model_Power_wise_batch_Qty & "  Balance Qty - " & Bal_TrayQty & "")
                Exit Sub
            End If


            dsAllotTray = getTrayAllot(Model_Power_wise_batch_Qty, eachModel("Model_Name").ToString())


            Dim serialIndex As Integer = 0
            Dim trayIndex As Integer = 0
            Dim trayassigned_qty As Integer = 0
            For Each serialRow As DataRow In dsAllSerial.Tables(0).Select("Model_Name = '" & eachModel("Model_Name").ToString() & "'")
                Dim modelName As String = serialRow("Model_Name").ToString()
                Dim power As Double = Convert.ToDouble(serialRow("Power"))
                Dim btcNo As String = serialRow("Btc_No").ToString()
                Dim lotNo As String = serialRow("lotno").ToString()
                Dim stSrNo As Integer = Convert.ToInt32(serialRow("St_SrNo"))
                Dim qty As Integer = Convert.ToInt32(serialRow("Qty"))

                Dim trayAllocated_Qty As Integer

                While trayIndex < dsAllotTray.Tables(0).Rows.Count
                    Dim trayRow As DataRow = dsAllotTray.Tables(0).Rows(trayIndex)
                    Dim rackLocation As String = trayRow("Rack_Location").ToString()
                    Dim trayNo As String = trayRow("Tray_No").ToString()
                    Dim trayAllocatedQty As Integer = Convert.ToInt32(trayRow("Allocated_Qty"))

                    Dim trayRemainingQty As Integer = trayAllocatedQty - trayassigned_qty

                    If trayRemainingQty <= 0 Then
                        trayIndex += 1
                        trayassigned_qty = 0
                        Exit While
                    End If

                    Dim newRow As DataRow = serialTable.NewRow()

                    newRow("Model_Name") = modelName
                    newRow("Power") = power
                    newRow("Batch") = btcNo
                    newRow("Lot_Number") = lotNo
                    newRow("St_SrNo") = stSrNo
                    newRow("Qty") = 1
                    newRow("TrayNo") = trayNo
                    newRow("Rack_Location") = rackLocation

                    serialTable.Rows.Add(newRow)

                    If trayRemainingQty <= 1 Then
                        trayIndex += 1
                        trayassigned_qty = 0
                        Exit While
                    End If

                    trayassigned_qty += 1

                    Exit While

                End While
            Next


        Next


        DataGridView1.DataSource = serialTable




        Dim tray_no As String = ""
        Dim Rack_Location As String = ""
        Dim LotNo1 As String = ""
        Dim serialFrom As String = ""
        Dim serialTo As String = ""
        Dim ModelName1 As String = ""
        Dim Power1 As String = ""
        Dim qty1 As Integer = 0
        For i = 0 To serialTable.Rows.Count - 1
            If LotNo1 <> serialTable.Rows(i)("Lot_Number") Or Rack_Location <> serialTable.Rows(i)("Rack_Location") Or tray_no <> serialTable.Rows(i)("TrayNo") Or ModelName1 <> serialTable.Rows(i)("Model_Name") Or Power1 <> serialTable.Rows(i)("Power") Then
                If LotNo1 <> "" Then
                    GRID2.Rows.Add(ModelName1, Power1, serialTable.Rows(i - 1)("Batch"), LotNo1, serialFrom, serialTo, qty1, tray_no, Rack_Location)
                End If
                tray_no = serialTable.Rows(i)("TrayNo")
                Rack_Location = serialTable.Rows(i)("Rack_Location")
                LotNo1 = serialTable.Rows(i)("Lot_Number")
                serialFrom = serialTable.Rows(i)("St_SrNo")
                serialTo = serialTable.Rows(i)("St_SrNo")
                ModelName1 = serialTable.Rows(i)("Model_Name")
                Power1 = serialTable.Rows(i)("Power")
                qty1 = 1
            Else
                serialTo = serialTable.Rows(i)("St_SrNo")
                qty1 = qty1 + 1
            End If
            If i = serialTable.Rows.Count - 1 Then
                GRID2.Rows.Add(ModelName1, Power1, serialTable.Rows(i)("Batch"), LotNo1, serialFrom, serialTo, qty1, tray_no, Rack_Location)
            End If
        Next

        TextBox1.Text = (serialTable.Rows.Count).ToString()
        cmbStbatch.Enabled = False

    End Sub

    Private Sub Clear()
        GRID2.Rows.Clear()
        Try
            DataGridView1.DataSource = Nothing
        Catch ex As Exception

        End Try


        cmbStbatch.Text = ""
        TextBox1.Text = ""
        cmbStbatch.Enabled = True
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If DataGridView1.Rows.Count < 1 Then
            MessageBox.Show("Please Preview the batch first ")
            Exit Sub
        End If

        Str_Header = 0
        Str_Detail = 0
        StrSqlSeHd = "Select Max(Header_ID) As Header, Max(Detail_ID) As Detail from Tray_Allot_Details"
        Ds = SQL_SelectQuery_Execute(StrSqlSeHd)

        If DBNull.Value.Equals(Ds.Tables(0).Rows(0)("Header")) Then
            Str_Header = 0
        Else
            Str_Header = Val(Ds.Tables(0).Rows(0)("Header"))
        End If

        If DBNull.Value.Equals(Ds.Tables(0).Rows(0)("Detail")) Then
            Str_Detail = 0
        Else
            Str_Detail = Val(Ds.Tables(0).Rows(0)("Detail"))
        End If


        If Str_Header = 0 Then
            Str_Header = 1
        Else
            Str_Header = Str_Header + 1
        End If

        If Str_Detail = 0 Then
            Str_Detail = 1
        Else
            Str_Detail = Str_Detail + 1
        End If


        StrUniqueNo = productline & "-TA-" & Format(Now, "ddMMyy") & "-" & Str_Header
        lblMovementNo.Text = StrUniqueNo

        'insert
        Dim StrSql As String = ""
        StrSql = "Insert Into  Tray_Allot_Details (  Header_ID, Detail_ID, Tray_Allot_No, Btc_No, Qty, Created_By, Created_Date, Modified_By, Modified_Date ) values" & "('" + Str_Header.ToString() + "','" + Str_Detail.ToString() + "','" + lblMovementNo.Text + "','" + cmbStbatch.Text + "','" + TextBox1.Text + "','" + StrLoginUser + "', GETDATE(),'" + StrLoginUser + "', GETDATE() ) "
        UpdateorInsertQuery_Execute(StrSql)

        'pouch update 
        Dim lot_Serial_numbers As String = ""
        Dim update_query_RackLocation As String = ""
        Dim update_query_tray_no As String = ""


        If DataGridView1.Rows.Count > 0 Then
            For i = 0 To DataGridView1.Rows.Count - 1
                lot_Serial_numbers = lot_Serial_numbers + "'" + DataGridView1.Item(3, i).Value + "" + CInt(DataGridView1.Item(4, i).Value).ToString("000") + "',"
                update_query_RackLocation = update_query_RackLocation + " WHEN lot_srno = '" + DataGridView1.Item(3, i).Value + "" + CInt(DataGridView1.Item(4, i).Value).ToString("000") + "' THEN '" + DataGridView1.Item(7, i).Value + "' "
                update_query_tray_no = update_query_tray_no + " WHEN lot_srno = '" + DataGridView1.Item(3, i).Value + "" + CInt(DataGridView1.Item(4, i).Value).ToString("000") + "' THEN '" + DataGridView1.Item(6, i).Value + "' "
            Next

            lot_Serial_numbers = lot_Serial_numbers.Remove(lot_Serial_numbers.Length - 1, 1)

            StrSql = "UPDATE    POUCH_LABEL SET              Rack_Location = (CASE  _rackLocation_ END),  Tray_No= (CASE  _trayNo_ END)   WHERE     (Lot_SrNo IN (" & lot_Serial_numbers & ")) "
            StrSql = StrSql.Replace("_rackLocation_", update_query_RackLocation)
            StrSql = StrSql.Replace("_trayNo_", update_query_tray_no)

            UpdateorInsertQuery_Execute(StrSql)

            StrSql = "UPDATE    POUCH_LABEL SET              Tray_Allot_No = '" & lblMovementNo.Text & "'    WHERE     (Lot_SrNo IN (" & lot_Serial_numbers & ")) "
            UpdateorInsertQuery_Execute(StrSql)
        End If

        'update tray filled Qty
        StrSql = "  UPDATE TRM " & _
        " SET Filled_Qty = TRM.Filled_Qty + ISNULL(PL.TotalQty, 0) " & _
        " FROM Tray_Rack_Master TRM " & _
         " LEFT JOIN ( " & _
            " SELECT Tray_No, SUM(Qty_1) AS TotalQty " & _
            " FROM POUCH_LABEL " & _
            " WHERE Tray_Allot_No = '" & lblMovementNo.Text & "' " & _
            " GROUP BY Tray_No " & _
        ") PL ON TRM.Tray_No = PL.Tray_No " & _
        "  WHERE PL.Tray_No IS NOT NULL "
        UpdateorInsertQuery_Execute(StrSql)


        'report
        StrSql = "select P.Brand_Name,P.Model_Name,P.Power, " & _
                     "convert(varchar(30),P.Lot_Prefix )+''+convert(varchar(30), P.Lot_No ) as Lot_No,right(P.Lot_SrNo,3) as SrNo, " & _
                     " P.Tray_Allot_No,  P.Btc_No,P.Tray_no as Tray_No, P.Rack_Location as Rack_No " & _
                     "from POUCH_LABEL P where" & _
                     " P.Tray_Allot_No='" & lblMovementNo.Text & "' order by Rack_Location,Tray_No,Model_Name, Lot_srno,srno "

        Ds = SQL_SelectQuery_Execute(StrSql)


        Dim cryRpt As New CryTray_allot
        cryRpt.SetDataSource(Ds.Tables(0))
        RptViwCollection.CryViewCollectList.ReportSource = cryRpt
        RptViwCollection.Show()

        Clear()
        LoadTrayAllotNO()

        Ds = SterileBatchBind()
        cmbStbatch.Items.Clear()
        TextBox1.Text = ""
        For Each eachRow As DataRow In Ds.Tables(0).Rows
            cmbStbatch.Items.Add(eachRow("Btc_No"))

        Next



    End Sub

    Private Sub btn_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Clear.Click
        Clear()
    End Sub
End Class