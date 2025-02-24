Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.OleDb
Imports System.Web
Imports System.Web.UI.WebControls

Public Class BPL_Cancellation
    Dim StrRs, StrRs1 As SqlDataReader
    Dim Cmd As New SqlCommand
    Dim DtRow As DataRow
    Dim StrSql, StrSql2, StrSql1, StrSql3, bplcolby, CANCEL_DATE As String
    Dim table As New DataTable
    Dim StSet As New DataSet
    Dim dr As OleDbDataReader
    Dim cm As New OleDbCommand


    Dim StrDtTo, StrDtFr, GETBPL As String
    Dim StAd As New SqlDataAdapter

    Public Sub LoadForm()
        Button2.Visible = False
        
        CANCEL_DATE = Format(DateTime.Today, "yyyy-MM-dd")


        If (chkbpl_collect.Checked = True) Then


            'StrSql = " SELECT DISTINCT BPL_NO  from Pouch_Label WHERE     (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 1) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = '0') AND  (BPL_NO IS NOT NULL) AND (BPL_NO IN (SELECT     BPL_No  FROM          BPL_GEN  WHERE       ( created_date >= '2023-10-14'))) and BPL_Collection_Status is NULL  and Box_reject=0 order by bpl_no "

            StrSql = " SELECT     BPL_NO FROM         (SELECT DISTINCT BPL_NO, dbo.CSVParser(BPL_NO, 3) AS ThirdPart " & _
                    " FROM          POUCH_LABEL WHERE      (BPL_NO IS NOT NULL) AND (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 1) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND " & _
                    " (Sterilization_Reject = '0') AND (BPL_NO IN (SELECT     BPL_No FROM          BPL_GEN  WHERE      (Created_Date >= '2023-10-14'))) AND (BPL_Collection_Status IS NULL) AND (Box_Reject = 0)) AS new_tab " & _
                    " ORDER BY CAST(ThirdPart AS int) "

            Dim cmd As New SqlCommand(StrSql, con)

            Dim dataadapter As New SqlDataAdapter(StrSql, con)
            Dim ds As New DataSet()

            dataadapter.Fill(ds, "BPL_NO")

            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "BPL_NO"

        End If


        StrSql2 = "SELECT DISTINCT BPL_NO  from Pouch_Label WHERE     (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 1) AND (Box_Packing = 0) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = '0') AND  (BPL_NO IS NOT NULL)AND (BPL_NO IN (SELECT     BPL_No  FROM          BPL_GEN  WHERE      ( created_date >= '2023-10-14'))) and BPL_Collection_Status =1 and Box_reject=0  order by bpl_no "
        Dim cmd2 As New SqlCommand(StrSql2, con)

        Dim dataadapter2 As New SqlDataAdapter(StrSql2, con)
        Dim ds2 As New DataSet()

        dataadapter2.Fill(ds2, "BPL_NO")

        DataGridView3.DataSource = ds2
        DataGridView3.DataMember = "BPL_NO"

    End Sub

    Private Sub BPL_Cancellation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadForm()


    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim strsql As String
        Dim dr As DataRow

        Dim strInsertQry As String = ""
        If (cmbgetid.Text <> "" And CmbBPLNo.Text <> "" And cmbreason.Text <> "") Then



            If (cmbfull.Checked = True) Then
                If (cmbreason.Text = "Others") Then
                    strsql = "insert into BPL_Cancel_Datails (bpl_no, bpl_cancel_date, cancel_reason, bpl_cancled_by) VALUES ('" & CmbBPLNo.Text & "','" & CANCEL_DATE & "','" & addtxt.Text & "','" & cmbgetid.Text & "')"
                Else
                    strsql = "insert into BPL_Cancel_Datails (bpl_no, bpl_cancel_date, cancel_reason, bpl_cancled_by) VALUES ('" & CmbBPLNo.Text & "','" & CANCEL_DATE & "','" & cmbreason.Text & "','" & cmbgetid.Text & "')"
                    
                End If
                Dim cmd As New SqlCommand(strsql, con)
                If con.State = Data.ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

             
            ElseIf (cmbpartial.Checked = True) Then
                If (cmbreason.Text = "Others") Then
                    strsql = "insert into BPL_Cancel_Datails (bpl_no, bpl_cancel_date, cancel_reason, bpl_cancled_by) VALUES ('" & cmp_parbpl.Text & "','" & CANCEL_DATE & "','" & addtxt.Text & "','" & cmbgetid.Text & "')"
                Else
                    strsql = "insert into BPL_Cancel_Datails (bpl_no, bpl_cancel_date, cancel_reason, bpl_cancled_by) VALUES ('" & cmp_parbpl.Text & "','" & CANCEL_DATE & "','" & cmbreason.Text & "','" & cmbgetid.Text & "')"
                    
                End If
                Dim cmd As New SqlCommand(strsql, con)
                If con.State = Data.ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
               
            End If


            strsql = "select distinct id from BPL_Cancel_Datails where BPL_NO ='" & CmbBPLNo.Text & "'"

            Dim dataadapter As New SqlDataAdapter(strsql, con)
            Dim ds As New DataSet()
            dataadapter.Fill(ds, "id")

            For Each dr In ds.Tables(0).Rows

                'strsql = " update POUCH_LABEL set bpl_cancel_status='" & dr(0).ToString() & "' where  BPL_NO ='" & CmbBPLNo.Text & "'"
                strsql = " update POUCH_LABEL set bpl_cancel_status='" & dr(0).ToString() & "', bpl_taken=0,bpl_no=NULL,ord_country=NULL,packing_model=NULL where  BPL_NO ='" & CmbBPLNo.Text & "' AND Box_Packing ='0' AND Box_Reject='0'"

            Next
            Dim cmd1 As New SqlCommand(strsql, con)

            If con.State = Data.ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()


            MessageBox.Show("BPL canceled successfully")
            cmbgetid.Text = ""
            CmbBPLNo.Text = ""
            cmbreason.Text = ""
            addtxt.Text = ""
            DataGridView4.DataSource = Nothing



        Else
            MessageBox.Show("Select BPL canceled Employee ID, Reason or BPL NO ")

        End If



    End Sub

    Public Function getBPLCount(ByVal StrSql As String) As DataSet

        Dim ds As New DataSet
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function
    Dim ds As New DataSet
    Dim Ds1 As New DataSet

    Dim ad As New SqlDataAdapter(Cmd)
    Dim bplno As String = ""
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try

            bplno = ""
            If (box_col_by.Text <> "") Then
                For i = 0 To DataGridView2.Rows.Count - 2
                    bplno = DataGridView2.Rows(i).Cells("BPL_NO").Value.ToString()
                    StrSql = "Update POUCH_LABEL set BPL_Collection_Status =1,BPL_Collected_by ='" & box_col_by.Text & "' where BPL_NO IN ('" & bplno & "')"
                    Cmd = New SqlCommand(StrSql, con)
                    Cmd.ExecuteNonQuery()
                    Cmd.Dispose()
                Next

                'tray generation table
                For i = 0 To DataGridView2.Rows.Count - 2
                    bplno = DataGridView2.Rows(i).Cells("BPL_NO").Value.ToString()
                    StrSql = "SELECT Tray_No, SUM(Qty_1) AS Qty from Pouch_Label WHERE  BPL_NO = '" & bplno & "'   GROUP BY Tray_No ORDER BY Tray_No"
                    Ds1 = SQL_SelectQuery_Execute(StrSql)


                    For Each eachRow1 As DataRow In Ds1.Tables(0).Rows
                        StrSql = "Insert into TrayRack_Movement (Tray_From, Qty,  Tray_label_updated, BPL_No, Created_date, Created_By) VALUES " & _
                    "('" & eachRow1("Tray_No") & "','" & eachRow1("Qty") & "','0','" & bplno & "',GETDATE(),'" & StrLoginUser & "')"
                        'UpdateorInsertQuery_Execute(StrSql)
                        Cmd = New SqlCommand(StrSql, con)
                        Cmd.ExecuteNonQuery()
                        Cmd.Dispose()
                    Next
                Next


                'update -Tray_allot_master
                Dim bpl_nos As String = ""
                For i = 0 To DataGridView2.Rows.Count - 2
                    bpl_nos = bpl_nos + "'" + DataGridView2.Rows(i).Cells("BPL_NO").Value.ToString() + "',"
                Next
                bpl_nos = bpl_nos.Remove(bpl_nos.Length - 1, 1)
                StrSql = "  UPDATE TRM " & _
                " SET Filled_Qty = TRM.Filled_Qty - ISNULL(PL.TotalQty, 0) " & _
                " FROM Tray_Rack_Master TRM " & _
                 " LEFT JOIN ( " & _
                    " SELECT Tray_No, SUM(Qty_1) AS TotalQty " & _
                    " FROM POUCH_LABEL " & _
                    " WHERE BPL_NO in( " & bpl_nos & " )  " & _
                    " GROUP BY Tray_No " & _
                ") PL ON TRM.Tray_No = PL.Tray_No " & _
                "  WHERE PL.Tray_No IS NOT NULL "
                UpdateorInsertQuery_Execute(StrSql)



                MessageBox.Show("BPL Collected Status updated successfully")
                box_col_by.Text = ""

                DataGridView2.DataSource = Nothing
                LoadForm()
            Else
                MessageBox.Show("Select BPL Collected Employee ID... ")

            End If

        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
       


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



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Try

            Dim dt As New DataTable()
            dt.Columns.Add("BPL_NO")

            For Each row As DataGridViewRow In DataGridView1.Rows
                Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("bplchk").Value)
                If isSelected Then
                    dt.Rows.Add(row.Cells(1).Value)
                End If
            Next
            DataGridView2.DataSource = dt
            Button2.Visible = True
            StrSql = "SELECT DISTINCT Emp_ID + '-' + Emp_Name AS Employee FROM         Login WHERE     (Emp_Dept = 'aeration')"
            Cmd = New SqlCommand(StrSql, con)

            If con.State = Data.ConnectionState.Open Then
                con.Close()
            End If

            Try
                con.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            StrRs = Cmd.ExecuteReader
            box_col_by.Items.Clear()
            While StrRs.Read
                box_col_by.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
            End While
            StrRs.Close()
            Cmd.Dispose()

        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
    End Sub




    Private Sub chkbpl_cancel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbpl_cancel.CheckedChanged

        If chkbpl_cancel.Checked = True Then
            chkbpl_collect.Checked = False
            GroupBox7.Visible = False
            GroupBox2.Visible = True
            cmbfull.Checked = True
            cmbpartial.Visible = True
           
        End If
        If chkbpl_cancel.Checked = False Then
            GroupBox2.Visible = False
        End If

        If (chkbpl_cancel.Checked = True) Then
            Dim cmd1 As New SqlCommand(StrSql1, con)
            Dim ad1 As New SqlDataAdapter(cmd1)
            StrSql = "SELECT DISTINCT Emp_ID + '-' + Emp_Name AS Employee FROM         Login order by Employee"

            If con.State = Data.ConnectionState.Open Then
                con.Close()
            End If
            If con.State = Data.ConnectionState.Closed Then
                con.Open()
            End If

            cmd1 = New SqlCommand(StrSql, con)
            StrRs = cmd1.ExecuteReader
            cmbgetid.Items.Clear()
            While StrRs.Read
                cmbgetid.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
            End While
            StrRs.Close()
            cmd1.Dispose()


            'full cancellation
            StrSql1 = "SELECT     BPL_NO FROM         (SELECT     BPL_NO, SUM(Qty_1) AS TotQty, SUM(Box_Packing) AS PackedQty, SUM(Box_Reject) AS RejectedQty FROM          POUCH_LABEL WHERE     (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 1)  AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = '0') AND  (BPL_NO IS NOT NULL) AND (BPL_NO IN (SELECT     BPL_No  FROM          BPL_GEN  WHERE      ( created_date >= '2023-10-14')))   GROUP BY BPL_NO) AS pl WHERE     (PackedQty + RejectedQty = 0) "
            Dim cmd As New SqlCommand(StrSql1, con)

            StrRs1 = cmd.ExecuteReader
            CmbBPLNo.Items.Clear()
            While StrRs1.Read
                CmbBPLNo.Items.Add(IIf(IsDBNull(StrRs1.GetValue(0)), "", StrRs1.GetValue(0)))
            End While
            StrRs1.Close()
            cmd.Dispose()

            'partial cancellation
            StrSql1 = "SELECT     BPL_NO  FROM  (SELECT DISTINCT BPL_NO, SUM(Qty_1) AS TotQty, SUM(Box_Packing) AS PackedQty, SUM(Box_Reject) AS RejectedQty FROM         POUCH_LABEL WHERE     (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 1) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = '0') AND (BPL_NO IS NOT NULL) AND  (BPL_NO IN (SELECT     BPL_No   FROM          BPL_GEN  WHERE      (Created_Date >= '2023-10-14')))  GROUP BY BPL_NO) AS pl WHERE     (PackedQty + RejectedQty <> 0) AND (PackedQty + RejectedQty <> TotQty) GROUP BY BPL_NO order by bpl_no"
            Dim cmd2 As New SqlCommand(StrSql1, con)

            StrRs1 = cmd2.ExecuteReader
            cmp_parbpl.Items.Clear()
            While StrRs1.Read

                cmp_parbpl.Items.Add(IIf(IsDBNull(StrRs1.GetValue(0)), "", StrRs1.GetValue(0)))


            End While
            StrRs1.Close()
            cmd2.Dispose()


            StrSql = "SELECT DISTINCT  Bpl_cancel_reason from Bpl_cancel_Reason order by  Bpl_cancel_reason"
            cmd1 = New SqlCommand(StrSql, con)
            StrRs = cmd1.ExecuteReader
            cmbreason.Items.Clear()
            While StrRs.Read
                cmbreason.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
            End While
            StrRs.Close()
            cmd1.Dispose()
        End If
    End Sub

    Private Sub chkbpl_collect_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbpl_collect.CheckedChanged
        If chkbpl_collect.Checked = True Then
            chkbpl_cancel.Checked = False
            GroupBox2.Visible = False
            GroupBox7.Visible = True

        End If

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub CmbBPLNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBPLNo.SelectedIndexChanged
        StrSql = "SELECT Brand_Name,Model_Name,Power,Sum(qty_1) as Qty  from Pouch_Label WHERE  bpl_no='" & CmbBPLNo.Text & "' Group by Brand_Name,Model_Name,Power order by Brand_Name,Model_Name,Power "

        Dim cmd As New SqlCommand(StrSql, con)

        Dim dataadapter As New SqlDataAdapter(StrSql, con)
        Dim ds As New DataSet()

        dataadapter.Fill(ds)

        DataGridView4.DataSource = ds.Tables(0)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cmbfull_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfull.CheckedChanged

        If cmbfull.Checked = True Then
            
            Label9.Visible = False
            cmp_parbpl.Visible = False
            cmbpartial.Checked = False
            Label1.Visible = True
            CmbBPLNo.Visible = True
            DataGridView4.DataSource = Nothing
        End If
    End Sub

    Private Sub cmbpartial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpartial.CheckedChanged
        If cmbpartial.Checked = True Then
            Label9.Visible = True
            cmp_parbpl.Visible = True
            Label1.Visible = False
            CmbBPLNo.Visible = False
            cmbfull.Checked = False
            DataGridView4.DataSource = Nothing
        End If
    End Sub

    Private Sub cmp_parbpl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmp_parbpl.SelectedIndexChanged
        StrSql = "SELECT Brand_Name,Model_Name,Power,sum(qty_1) as qty  from Pouch_Label WHERE  bpl_no='" & cmp_parbpl.Text & "' group by Brand_Name,Model_Name,Power order by Brand_Name,Model_Name,Power "
        Dim cmd As New SqlCommand(StrSql, con)
        Dim dataadapter As New SqlDataAdapter(StrSql, con)
        Dim ds As New DataSet()
        dataadapter.Fill(ds)
        DataGridView4.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub cmbreason_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbreason.SelectedIndexChanged
        If (cmbreason.Text = "Others") Then
            REASONLBL.Visible = True
            addtxt.Visible = True
        End If
    End Sub
End Class