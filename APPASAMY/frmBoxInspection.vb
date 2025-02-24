Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.OleDb
Imports System.Web
Imports System.Web.UI.WebControls
Imports System.Net.Http
Imports Newtonsoft.Json.Linq


Public Class frmBoxInspection
    Dim StrRs, StrRs1 As SqlDataReader
    Dim Cmd As New SqlCommand
    Dim DtRow As DataRow
    Dim StrSql, StrSql2, StrSql1, StrSql3, bplcolby, getModel, GetBrand, GetPower, GetLength As String
    Dim table As New DataTable
    Dim StSet As New DataSet
    Dim dr As OleDbDataReader
    Dim cm As New OleDbCommand
    Dim Ds, Ds1 As New DataSet
    Private rowIndex As Integer = 0
    Dim totBPLQty As Integer = 0
    Dim StAd As New SqlDataAdapter
    Dim Str_Header As Integer
    Dim Str_Detail As Integer
    Dim StrUniqueNo As String
    Dim StrSqlSeHd As String

    Public Sub Clear()
        CmbBPL.Text = ""
        txtrec.Text = ""
        txtacc.Text = ""
        cmbrejreason.Text = ""
        txtMTSNo.Text = ""
        GRID1.DataSource = Nothing
        GRID2.Rows.Clear()
        chkRejection.Checked = False
    End Sub
    Public Sub BPL_Load()
        Dim frdate, toDate As String
        Dim BPL_Nos As String = ""
        Dim InspectionCompletedBPLs As String = ""
        toDate = Format(insdate.Value, "yyyy-MM-dd") & " 23:59:01"
        frdate = Format(insdate.Value.AddDays(-30), "yyyy-MM-dd") & " 00:00:01"

        StrSql = "SELECT DISTINCT BPL_NO  from Pouch_Label WHERE     (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 1) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = '0') AND  (BPL_NO IS NOT NULL) " & _
                "AND (BPL_NO IN (SELECT     BPL_No  FROM          BPL_GEN  WHERE      (Created_Date > '2023-09-10'))) and box_reject=0 and  BPL_Collection_Status='1'  " & _
                "   order by bpl_no "
        Ds = SQL_SelectQuery_Execute(StrSql)
        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            BPL_Nos = BPL_Nos + "'" + eachRow1("BPL_NO") + "',"
        Next

        If BPL_Nos = "" Then
            BPL_Nos = "''"
        Else
            BPL_Nos = BPL_Nos.Remove(BPL_Nos.Length - 1, 1)
        End If


        StrSql = "SELECT DISTINCT BPL_NO  from Box_Inspection_Details  " & _
                " WHERE   BPL_NO IN(" & BPL_Nos & ") " & _
                "order by BPL_NO "
        Ds = SQL_SelectQuery_Execute(StrSql)
        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            InspectionCompletedBPLs = InspectionCompletedBPLs + "'" + eachRow1("BPL_NO") + "',"
        Next

        If InspectionCompletedBPLs = "" Then
            InspectionCompletedBPLs = "''"
        Else
            InspectionCompletedBPLs = InspectionCompletedBPLs.Remove(InspectionCompletedBPLs.Length - 1, 1)
        End If

        StrSql = "SELECT DISTINCT BPL_NO  from Pouch_Label WHERE     (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 1) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = '0') AND  (BPL_NO IS NOT NULL) " & _
                "AND (BPL_NO IN (SELECT     BPL_No  FROM          BPL_GEN  WHERE      (Created_Date > '2023-09-10'))) and box_reject=0 and  BPL_Collection_Status='1'  " & _
                " AND BPL_NO NOT IN(" & InspectionCompletedBPLs & ") order by bpl_no "
        Ds = SQL_SelectQuery_Execute(StrSql)
        CmbBPL.Items.Clear()
        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            CmbBPL.Items.Add(eachRow1("BPL_NO"))
        Next
    End Sub

    Public Sub MTS_No_Load()

        Dim utcTime As DateTime = DateTime.UtcNow
        Dim indiaTime As DateTime = utcTime.AddHours(5).AddMinutes(30)
        Dim startDate As String = indiaTime.ToString("yyyy-MM-dd 00:00:01")
        Dim endDate As String = indiaTime.ToString("yyyy-MM-dd 23:59:59")
        Dim From_Loc As String = ""

        StrSql = "Select Movement_No from Rejection_MTS_Details_Boxpacking Where Created_date between '" & startDate & "' and '" & endDate & "'  "
        Ds = SQL_SelectQuery_Execute(StrSql)
        If Ds.Tables(0).Rows.Count = 1 Then
            StrUniqueNo = Ds.Tables(0).Rows(0)("Movement_No")
            txtMTSNo.Text = StrUniqueNo
        ElseIf Ds.Tables(0).Rows.Count < 1 Then
            Str_Header = 0
            Str_Detail = 0
            StrSqlSeHd = "Select Max(Header_ID) As Header, Max(Detail_ID) As Detail from Rejection_MTS_Details_Boxpacking"
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


            If productline = "PMMA" Then
                StrUniqueNo = "PMMA-BOX-REJ-MMS-" & Format(indiaTime, "ddMMyy") & "-" & Str_Header
                From_Loc = "PMMA BOX PACKING"
            ElseIf productline = "PHILIC" Then
                StrUniqueNo = "PHILIC-BOX-REJ-MMS-" & Format(indiaTime, "ddMMyy") & "-" & Str_Header
                From_Loc = "FOLDABLE BOX PACKING"
            ElseIf productline = "PHOBIC" Then
                StrUniqueNo = "PHOBIC-BOX-REJ-MMS-" & Format(indiaTime, "ddMMyy") & "-" & Str_Header
                From_Loc = "FOLDABLE BOX PACKING"
            ElseIf productline = "PHOBIC NONPRELOADED" Then
                StrUniqueNo = "PHOBIC(NP)-BOX-REJ-MMS-" & Format(indiaTime, "ddMMyy") & "-" & Str_Header
                From_Loc = "FOLDABLE BOX PACKING"
            End If

            'StrUniqueNo = productline & "-BOX-REJ-MMS-" & Format(Now, "yyMMdd") & "-" & Str_Header
            txtMTSNo.Text = StrUniqueNo


            'StrSql = "Insert Into Rejection_MTS_Details_Boxpacking (  Header_ID, Detail_ID, Movement_No, Created_By, Created_Date, Modified_By, Modified_Date,Location_from,Location_To ) values" & _
            '"('" + Str_Header.ToString() + "','" + Str_Detail.ToString() + "','" + StrUniqueNo + "','" + StrLoginUser + "', GETDATE(),'" + StrLoginUser + "', GETDATE(),'" + From_Loc + "','Store')"
            'UpdateorInsertQuery_Execute(StrSql)


        Else
            MessageBox.Show("More than one MTS No contains.Please check")
            Exit Sub

        End If



    End Sub

    Public Sub Insert_MTS_No()
        Dim utcTime As DateTime = DateTime.UtcNow
        Dim indiaTime As DateTime = utcTime.AddHours(5).AddMinutes(30)
        Dim startDate As String = indiaTime.ToString("yyyy-MM-dd 00:00:01")
        Dim endDate As String = indiaTime.ToString("yyyy-MM-dd 23:59:59")
        Dim From_Loc As String = ""

        StrSql = "Select Movement_No from Rejection_MTS_Details_Boxpacking Where Created_date between '" & startDate & "' and '" & endDate & "'  "
        Ds = SQL_SelectQuery_Execute(StrSql)
        If Ds.Tables(0).Rows.Count = 1 Then
            StrUniqueNo = Ds.Tables(0).Rows(0)("Movement_No")
            txtMTSNo.Text = StrUniqueNo
        ElseIf Ds.Tables(0).Rows.Count < 1 Then
            Str_Header = 0
            Str_Detail = 0
            StrSqlSeHd = "Select Max(Header_ID) As Header, Max(Detail_ID) As Detail from Rejection_MTS_Details_Boxpacking"
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


            If productline = "PMMA" Then
                StrUniqueNo = "PMMA-BOX-REJ-MMS-" & Format(indiaTime, "ddMMyy") & "-" & Str_Header
                From_Loc = "PMMA BOX PACKING"
            ElseIf productline = "PHILIC" Then
                StrUniqueNo = "PHILIC-BOX-REJ-MMS-" & Format(indiaTime, "ddMMyy") & "-" & Str_Header
                From_Loc = "FOLDABLE BOX PACKING"
            ElseIf productline = "PHOBIC" Then
                StrUniqueNo = "PHOBIC-BOX-REJ-MMS-" & Format(indiaTime, "ddMMyy") & "-" & Str_Header
                From_Loc = "FOLDABLE BOX PACKING"
            ElseIf productline = "PHOBIC NONPRELOADED" Then
                StrUniqueNo = "PHOBIC(NP)-BOX-REJ-MMS-" & Format(indiaTime, "ddMMyy") & "-" & Str_Header
                From_Loc = "FOLDABLE BOX PACKING"
            End If

            'StrUniqueNo = productline & "-BOX-REJ-MMS-" & Format(Now, "yyMMdd") & "-" & Str_Header
            txtMTSNo.Text = StrUniqueNo


            StrSql = "Insert Into Rejection_MTS_Details_Boxpacking (  Header_ID, Detail_ID, Movement_No, Created_By, Created_Date, Modified_By, Modified_Date,Location_from,Location_To ) values" & _
            "('" + Str_Header.ToString() + "','" + Str_Detail.ToString() + "','" + StrUniqueNo + "','" + StrLoginUser + "', GETDATE(),'" + StrLoginUser + "', GETDATE(),'" + From_Loc + "','Store')"
            UpdateorInsertQuery_Execute(StrSql)


        Else
            MessageBox.Show("More than one MTS No contains.Please check")
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
 

    Private Sub frmBoxInspection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        BPL_Load()

        StrSql = "SELECT DISTINCT BoxAndInspection FROM         Box_Inspection_Rej_Reason ORDER BY BoxAndInspection "
        Ds1 = SQL_SelectQuery_Execute(StrSql)


    End Sub

    Public Sub Datagrid2_refresh()
        GRID2.Rows.Clear()

        StrSql = "SELECT DISTINCT Lot_SrNo  from Pouch_Label WHERE  BPL_NO = '" & CmbBPL.Text & "' AND  (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 1) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = '0') AND  (BPL_NO IS NOT NULL) and box_reject=0 and  BPL_Collection_Status='1'   order by Lot_SrNo "
        Ds = SQL_SelectQuery_Execute(StrSql)


        StrSql = "SELECT DISTINCT BoxAndInspection FROM         Box_Inspection_Rej_Reason ORDER BY BoxAndInspection "
        Ds1 = SQL_SelectQuery_Execute(StrSql)


        Dim comboBoxCell1 As DataGridViewComboBoxColumn = CType(GRID2.Columns("Lot_SrNo"), DataGridViewComboBoxColumn)
        comboBoxCell1.DataSource = Ds.Tables(0)
        comboBoxCell1.DisplayMember = "Lot_SrNo"

        Dim comboBoxCell2 As DataGridViewComboBoxColumn = CType(GRID2.Columns("Reason_of_Rejection"), DataGridViewComboBoxColumn)
        comboBoxCell2.DataSource = Ds1.Tables(0)
        comboBoxCell2.DisplayMember = "BoxAndInspection"
    End Sub
    

    Private Sub CmbBPL_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBPL.SelectedIndexChanged
        totBPLQty = 0

        StrSql = "SELECT Brand_Name,Model_Name,Power,Lot_Prefix+''+Lot_No As Lot_Number, SUM(Qty_1) AS Qty from Pouch_Label WHERE  BPL_NO = '" & CmbBPL.Text & "' AND  (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 1) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = '0') AND  (BPL_NO IS NOT NULL) and box_reject=0 and  BPL_Collection_Status='1'  GROUP BY Brand_Name,Model_Name,Power,Lot_Prefix,Lot_No ORDER BY Brand_Name,Model_Name,Power,Lot_Number"
        Ds = SQL_SelectQuery_Execute(StrSql)
        GRID1.DataSource = Ds.Tables(0)

        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            totBPLQty = totBPLQty + Val(eachRow1("Qty"))
        Next
        txtrec.Text = totBPLQty
        Datagrid2_refresh()

    End Sub

    Private Sub Textsrscan_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Textsrscan.KeyDown
        Dim StrGrLot As String

        ' Check if Enter key was pressed
        If e.KeyCode = Keys.Enter Then
            ' Check if the input text is not empty
            If Textsrscan.Text <> "" Then
                ' Close the connection if it is already open
     

                ' Define the SQL query

                If rdUDICode.Checked = True Then
                    Dim StrSql As String = "SELECT DISTINCT Lot_SrNo FROM Pouch_Label WHERE BPL_NO = '" & CmbBPL.Text & "' AND  Udi_code = '" & Textsrscan.Text & "' and (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 1) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = '0') AND (BPL_NO IS NOT NULL) AND box_reject = 0 AND BPL_Collection_Status = '1' ORDER BY Lot_SrNo"
                    Dim Ds As DataSet = SQL_SelectQuery_Execute(StrSql)
                    If Ds.Tables.Count = 0 OrElse Ds.Tables(0).Rows.Count = 0 Then
                        MessageBox.Show("Serial number not present in selected BPL_NO")

                        Exit Sub
                    End If

                    ' Loop through the DataGridView rows to check for duplicates
                    For i As Integer = 0 To GRID2.Rows.Count - 1
                        If GRID2.Item(0, i).Value = Nothing Then
                            Continue For
                        End If
                        StrGrLot = GRID2.Item(0, i).Value.ToString() ' Assuming Lot_SrNo is in the 4th column (index 3)

                        ' Check if the scanned Lot_SrNo already exists in the grid
                        If StrGrLot = Textsrscan.Text Then
                            MessageBox.Show("Already Scanned")
                            Textsrscan.Text = ""
                            Textsrscan.Focus()

                            Exit Sub
                        End If


                    Next
                    GRID2.Rows.Add(Ds.Tables(0).Rows(0)("Lot_SrNo").ToString(), drpreason.Text)
                    '' Add the scanned Lot_SrNo to the DataGridView
                    'Dim DtRow As DataRow = table.NewRow()
                    'DtRow("Lot_SrNo") = Ds.Tables(0).Rows(0)("Lot_SrNo") ' Adjust column names accordingly
                    'DtRow("Reason_of_Rejection") = drpreason.Text

                    'table.Rows.Add(DtRow)

                    ' Clear the TextBox after adding the entry
                    Textsrscan.Text = ""
                    Textsrscan.Focus()

                ElseIf rdLotSerial.Checked = True Then
                    Dim StrSql As String = "SELECT DISTINCT Lot_SrNo FROM Pouch_Label WHERE BPL_NO = '" & CmbBPL.Text & "' AND  Lot_SrNo = '" & Textsrscan.Text & "' and (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 1) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = '0') AND (BPL_NO IS NOT NULL) AND box_reject = 0 AND BPL_Collection_Status = '1' ORDER BY Lot_SrNo"
                    Dim Ds As DataSet = SQL_SelectQuery_Execute(StrSql)

                    ' Check if the DataSet is empty
                    If Ds.Tables.Count = 0 OrElse Ds.Tables(0).Rows.Count = 0 Then
                        MessageBox.Show("Serial number not present in selected BPL_NO")

                        Exit Sub
                    End If

                    ' Loop through the DataGridView rows to check for duplicates
                    For i As Integer = 0 To GRID2.Rows.Count - 1
                        If GRID2.Item(0, i).Value = Nothing Then
                            Continue For
                        End If
                        StrGrLot = GRID2.Item(0, i).Value.ToString() ' Assuming Lot_SrNo is in the 4th column (index 3)

                        ' Check if the scanned Lot_SrNo already exists in the grid
                        If StrGrLot = Textsrscan.Text Then
                            MessageBox.Show("Already Scanned")
                            Textsrscan.Text = ""
                            Textsrscan.Focus()

                            Exit Sub
                        End If


                    Next
                    GRID2.Rows.Add(Ds.Tables(0).Rows(0)("Lot_SrNo").ToString(), drpreason.Text)
                    '' Add the scanned Lot_SrNo to the DataGridView
                    'Dim DtRow As DataRow = table.NewRow()
                    'DtRow("Lot_SrNo") = Ds.Tables(0).Rows(0)("Lot_SrNo") ' Adjust column names accordingly
                    'DtRow("Reason_of_Rejection") = drpreason.Text

                    'table.Rows.Add(DtRow)

                    ' Clear the TextBox after adding the entry
                    Textsrscan.Text = ""
                    Textsrscan.Focus()
                End If
            End If
        End If


    End Sub



    Private Sub chkRejection_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRejection.CheckedChanged

        If chkRejection.Checked = True Then
            If CmbBPL.Text <> "" Then
                GRID2.Visible = True

                StrSql = "SELECT DISTINCT BoxAndInspection FROM  Box_Inspection_Rej_Reason ORDER BY BoxAndInspection "
                Ds1 = SQL_SelectQuery_Execute(StrSql)
                drpreason.DataSource = Ds1.Tables(0)
                drpreason.DisplayMember = "BoxAndInspection"

            Else
                chkRejection.Checked = False
                MessageBox.Show("Please Select BPL Number")
                Exit Sub
            End If

        Else
            GRID2.Rows.Clear()
            GRID2.Visible = False
        End If

        If chkRejection.Checked = True Then
            MTS_No_Load()
        Else
            txtMTSNo.Text = ""
        End If
    End Sub

    Private Sub GRID2_CellMouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GRID2.CellMouseUp
        If e.Button = MouseButtons.Right Then
            Me.GRID2.Rows(e.RowIndex).Selected = True
            Me.rowIndex = e.RowIndex
            Me.GRID2.CurrentCell = Me.GRID2.Rows(e.RowIndex).Cells(1)
            Me.ContextMenuStrip1.Show(Me.GRID2, e.Location)
            ContextMenuStrip1.Show(Cursor.Position)
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If Not Me.GRID2.Rows(Me.rowIndex).IsNewRow Then
            Me.GRID2.Rows.RemoveAt(Me.rowIndex)
        End If
    End Sub

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click

        Dim rejection_detail_id As Integer = 0

        If CmbBPL.Text = "" Then
            err.SetError(CmbBPL, "This information is required")
            Exit Sub
        Else
            err.SetError(CmbBPL, "")
        End If

        If txtrec.Text = "" Then
            err.SetError(txtrec, "This information is required")
            Exit Sub
        Else
            err.SetError(txtrec, "")
        End If

        If txtacc.Text = "" Then
            err.SetError(txtacc, "This information is required")
            Exit Sub
        Else
            err.SetError(txtacc, "")
        End If


        If chkRejection.Checked = True Then
            If GRID2.Rows.Count < 2 Then
                MessageBox.Show("Please Add the rejection Serial Numbers.")
                Exit Sub
            End If
        End If

        If Val(txtrec.Text) <> (Val(txtacc.Text) + Val(cmbrejreason.Text)) Then
            MessageBox.Show("Qty Mismatch, Pleace check Accepted Qty and Rejection Qty")
            Exit Sub
        End If

        If GRID2.Rows.Count > 1 Then
            If cmbrejreason.Text = "" Then
                err.SetError(cmbrejreason, "This information is required")
                Exit Sub
            Else
                err.SetError(cmbrejreason, "")
            End If

            If txtMTSNo.Text = "" Then
                err.SetError(txtMTSNo, "This information is required")
                Exit Sub
            Else
                err.SetError(txtMTSNo, "")
            End If
        End If

        Try

            If GRID2.Rows.Count - 1 <> Val(cmbrejreason.Text) Then
                MessageBox.Show("Rejection Qty Entered Wrongly. Please check")
                Exit Sub
            End If

            If GRID2.Rows.Count > 1 Then
                For i = 0 To GRID2.Rows.Count - 2
                    If GRID2.Rows(i).Cells("Lot_SrNo").Value Is Nothing Or GRID2.Rows(i).Cells("Reason_of_Rejection").Value Is Nothing Then
                        MessageBox.Show("Rejection Reason not updated properly. Please check the rejection GRID View")
                        Exit Sub
                    End If
                Next i
            End If

            'insert Rejection_MTS_Details_Boxpacking
            If Val(cmbrejreason.Text) > 0 Then
                Insert_MTS_No()
            End If

            StrSql = "Insert into Box_Inspection_Details (BPL_No, Rec_Qty, Acc_Qty, Rej_Qty, Inspection_By, Inspection_date, MTS_No, Created_date, Created_By) VALUES " & _
            "('" & CmbBPL.Text & "','" & txtrec.Text & "','" & txtacc.Text & "','" & cmbrejreason.Text & "','" & StrLoginUser & "','" & DateTime.Parse(insdate.Value).ToString("yyyy-MM-dd HH:mm:ss") & "','" & txtMTSNo.Text & "',GETDATE(),'" & StrLoginUser & "')"
            UpdateorInsertQuery_Execute(StrSql)


            If GRID2.Rows.Count > 1 Then
                StrSql = "SELECT     MAX(ID) AS Reason_id FROM         Box_Inspection_Details WHERE     (BPL_No = '" & CmbBPL.Text & "')"
                Ds = SQL_SelectQuery_Execute(StrSql)
                If Ds.Tables(0).Rows.Count = 1 Then
                    rejection_detail_id = Val(Ds.Tables(0).Rows(0)("Reason_id"))
                Else
                    MessageBox.Show("Something Went Wrong. Please Contact ERP Team.")
                    Exit Sub
                End If


                For i = 0 To GRID2.Rows.Count - 2
                    StrSql = "Insert into Box_Inspection_Rejection_Serials (Inspection_id, BPL_No, Lot_SrNo, Reason_of_Rejection) VALUES " & _
                            "('" & rejection_detail_id & "','" & CmbBPL.Text & "','" & GRID2.Rows(i).Cells("Lot_SrNo").Value & "','" & GRID2.Rows(i).Cells("Reason_of_Rejection").Value & "')"
                    UpdateorInsertQuery_Execute(StrSql)

                    StrSql = "update POUCH_LABEL set Box_Reject=1 ,Box_Reject_Date=GETDATE(),Box_Reject_By='" & StrLoginUser & "' where Lot_SrNo='" & GRID2.Rows(i).Cells("Lot_SrNo").Value & "' "
                    UpdateorInsertQuery_Execute(StrSql)
                Next i
            End If

            Clear()
            BPL_Load()

        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        Clear()
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

End Class