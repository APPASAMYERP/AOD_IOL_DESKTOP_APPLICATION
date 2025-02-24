
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class FrmRackLocationDetails
    Dim StrSql As String

    Dim table As New DataTable
    Dim cmd As SqlCommand
    Dim Sql As String
    'Dim sqla As SqlDataAdapter
    Dim Ds As New DataSet
    Dim Dr As SqlDataReader
    Dim DtRow As DataRow
    Dim StrLorBarNo As String

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
    Function CompareDataTables(ByVal dt1 As DataTable, ByVal dt2 As DataTable) As Boolean

        If dt1.Columns.Count <> dt2.Columns.Count Then
            Return False
        End If


        If dt1.Rows.Count <> dt2.Rows.Count Then
            Return False
        End If


        For Each column As DataColumn In dt1.Columns
            For Each row As DataRow In dt1.Rows
                Dim rowIndex As Integer = dt1.Rows.IndexOf(row)
                Dim value1 As Object = row(column)
                Dim value2 As Object = dt2.Rows(rowIndex)(column.ColumnName)

                If Not value1.Equals(value2) Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    Public Function check_rack_data_created() As Boolean
        Dim temp_count, original_count As Integer
        Dim dsTemp, dsOriginal As New DataSet
        Dim StrSql As String = "SELECT Lot_SrNo,Brand_Name,Model_Name,Power  from temp_Areation_Audit  " & _
        " WHERE  Rack_Location='" & txtScannedRack.Text & "' and (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1)   Order By Brand_Name,Model_Name,Power,Lot_SrNo  "
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(dsTemp)
        

        StrSql = "SELECT Lot_SrNo,Brand_Name,Model_Name,Power from Pouch_Label  " & _
        " WHERE  Rack_Location='" & txtScannedRack.Text & "' and (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1)   Order By Brand_Name,Model_Name,Power,Lot_SrNo  "
        Dim Cmd1 As New SqlCommand(StrSql, con)
        Dim ad1 As New SqlDataAdapter(Cmd1)
        ad1.Fill(dsOriginal)
        
        Return CompareDataTables(dsTemp.Tables(0), dsOriginal.Tables(0))

    End Function

    Private Sub ColorCode_SerialLoad()
        Dim scanedCount As Integer = 0

        For i As Integer = 0 To GRID1.Rows.Count - 2
            If Not IsDBNull(Me.GRID1.Rows(i).Cells("Scanned").Value) Then
                If Me.GRID1.Rows(i).Cells("Scanned").Value = "1" Then
                    Me.GRID1.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                    scanedCount = scanedCount + 1
                End If
            End If
        Next
        lblScannedQty.Text = scanedCount
    End Sub

    Private Sub rack_load_inGrid()
        GRID1.Rows.Clear()
        Sql = "SELECT Lot_SrNo,Brand_Name,Model_Name,Power, Scanned  from temp_Areation_Audit  WHERE  Rack_Location='" & txtScannedRack.Text & "' and (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1)   Order By Brand_Name,Model_Name,Power,Lot_SrNo"
        Ds = SQL_SelectQuery_Execute(Sql)
        For Each eachRow As DataRow In Ds.Tables(0).Rows
            GRID1.Rows.Add(eachRow("Lot_SrNo"), eachRow("Brand_Name"), eachRow("Model_Name"), eachRow("Power"), eachRow("Scanned"))
        Next

        lblTotalRack_Loc_Qty.Text = GRID1.Rows.Count - 1
        txtRackLocation.Text = ""
        txtLotSrNo.Focus()

        GRID1.ClearSelection()

        ColorCode_SerialLoad()
    End Sub

    Private Sub to_create_records()
        Dim strLotSerials As String = ""
        'new record insert
        StrSql = " INSERT INTO temp_Areation_Audit " & _
            " SELECT *, '' AS Scanned  from Pouch_Label   " & _
         " WHERE  Rack_Location='" & txtScannedRack.Text & "' and (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) AND  " & _
         " Lot_Srno not in(SELECT Lot_SrNo from temp_Areation_Audit " & _
         "  WHERE  Rack_Location='" & txtScannedRack.Text & "' and (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) ) "

        UpdateorInsertQuery_Execute(StrSql)


        'Removed the records 
        StrSql = "SELECT  Lot_SrNo  from Pouch_Label   " & _
         " WHERE  Rack_Location='" & txtScannedRack.Text & "' and (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1)   "
        Ds = SQL_SelectQuery_Execute(StrSql)

        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            strLotSerials = strLotSerials + "'" + eachRow1("Lot_SrNo") + "',"
        Next

        If strLotSerials = "" Then
            strLotSerials = "''"
        Else
            strLotSerials = strLotSerials.Remove(strLotSerials.Length - 1, 1)
        End If

        StrSql = " DELETE FROM temp_Areation_Audit WHERE  Rack_Location='" & txtScannedRack.Text & "' and (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) AND  " & _
            " Lot_SrNo Not IN (" & strLotSerials & ")"

        UpdateorInsertQuery_Execute(StrSql)

    End Sub

    Private Sub clear_scnned_details()
        

        StrSql = " update temp_Areation_Audit set scanned=0 WHERE  Rack_Location='" & txtScannedRack.Text & "' and (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1)  "
            

        UpdateorInsertQuery_Execute(StrSql)

    End Sub


    Private Sub txtRackLocation_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRackLocation.KeyDown, txtScannedRack.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txtRackLocation.Text <> "" Then
                    txtScannedRack.Text = txtRackLocation.Text
                    GRID2.DataSource = Nothing
                    Dim rack_data_created As Boolean = False
                    rack_data_created = check_rack_data_created()
                    If rack_data_created = True Then
                        rack_load_inGrid()
                    Else
                        clear_scnned_details()
                        to_create_records()
                        rack_load_inGrid()
                    End If
                    Sql = "SELECT Tray_No,Brand_Name,Model_Name,Power, Sum(Qty_1) as Qty from temp_Areation_Audit  WHERE  Rack_Location='" & txtScannedRack.Text & "' and (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1) Group By Tray_No,Brand_Name,Model_Name,Power Order By Tray_No, Brand_Name,Model_Name,CAST(Power AS float)"
                    Ds = SQL_SelectQuery_Execute(Sql)
                    GRID2.DataSource = Ds.Tables(0)
                End If
            End If
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try

       


    End Sub


    Private Sub txtLotSrNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLotSrNo.KeyDown

        If e.KeyCode = Keys.Enter Then

            If txtLotSrNo.Text <> "" Then
                Try
                    If txtScannedRack.Text = "" Then
                        err.SetError(txtScannedRack, "This information is required")
                        Exit Sub
                    Else
                        err.SetError(txtScannedRack, "")
                    End If

                    StrLorBarNo = UCase(Trim(txtLotSrNo.Text))
                    If rdLotSerial.Checked = True Then
                        Sql = "select Lot_SrNo,Brand_Name,Model_Name,Power,Scanned  from temp_Areation_Audit where Lot_SrNo='" & txtLotSrNo.Text & "' AND  Rack_Location='" & txtScannedRack.Text & "' and (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1)  "
                    ElseIf rdUDICode.Checked = True Then
                        Sql = "select  Lot_SrNo,Brand_Name,Model_Name,Power,Scanned  from temp_Areation_Audit where Udi_Code='" & txtLotSrNo.Text & "' AND  Rack_Location='" & txtScannedRack.Text & "' and (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 0) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = 0) AND (Areation_Status = 1)  "
                    Else
                        MsgBox(" Plese choose Lot Serial or UDI Serial")
                        Exit Sub
                    End If


                    Ds = SQL_SelectQuery_Execute(Sql)

                    If Ds.Tables(0).Rows.Count = 1 Then

                        For i = 0 To GRID1.Rows.Count - 2

                            If GRID1.Item(0, i).Value.ToString() = Ds.Tables(0).Rows(0)("Lot_SrNo").ToString() Then

                                If GRID1.Item(4, i).Value.ToString() <> "1" Then
                                    GRID1.Item(4, i).Value = 1

                                    StrSql = "UPDATE    temp_Areation_Audit " & _
                                        "SET           Scanned = '1' " & _
                                        " where Lot_SrNo = '" & Ds.Tables(0).Rows(0)("Lot_srno").ToString() & "' "



                                    UpdateorInsertQuery_Execute(StrSql)

                                    lblScannedQty.Text = Val(lblScannedQty.Text) + 1
                                    Me.GRID1.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                                    txtLotSrNo.Text = ""
                                    txtLotSrNo.Focus()
                                    Exit Sub
                                Else
                                    Dim customMsgBox As New CustomMessageBox("Already Scan")
                                    customMsgBox.ShowDialog()
                                    txtLotSrNo.Text = ""
                                    txtLotSrNo.Focus()
                                End If

                            End If

                        Next
                    Else
                        Dim customMsgBox As New CustomMessageBox("Scan Correct Lot Sr No")
                        customMsgBox.ShowDialog()
                        txtLotSrNo.Text = ""
                        txtLotSrNo.Focus()
                    End If

                Catch ex As Exception
                    MsgBox("An unexpected error occurred.")
                    Exit Sub
                End Try

                

            End If


        End If


    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnVerified_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerified.Click
        Try
            If lblScannedQty.Text = lblTotalRack_Loc_Qty.Text Then

                Sql = "DELETE FROM temp_Areation_Audit WHERE     Rack_Location='" & txtScannedRack.Text & "' "
                UpdateorInsertQuery_Execute(Sql)

                MsgBox("Verified")
                txtScannedRack.Text = ""
                txtRackLocation.Text = ""
                txtLotSrNo.Text = ""
                GRID1.Rows.Clear()
                GRID2.DataSource = Nothing
                lblScannedQty.Text = "0"
                lblTotalRack_Loc_Qty.Text = "0"

            Else
                MsgBox("Not fully scanned. Please check")
                txtLotSrNo.Focus()
            End If
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
    End Sub
End Class