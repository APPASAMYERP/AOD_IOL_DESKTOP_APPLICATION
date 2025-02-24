

Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.OleDb
Imports System.Web
Imports System
Imports System.Globalization
Imports System.Web.UI.WebControls
Imports System.Threading

Public Class BPL_Dashboard
    Dim StrRs As SqlDataReader
    Dim Cmd As New SqlCommand
    Dim DtRow As DataRow
    Dim StrSql, StrSql2, StrSql1, StrSql3, bplcolby As String
    Dim table As New DataTable
    Dim StSet As New DataSet
    Dim dr As OleDbDataReader
    Dim cm As New OleDbCommand
    Dim Ds As New DataSet
    Dim StrDtFr, GETBPL As String
    Dim StrDtTo As String
    Dim bal_qty As String
    Dim StAd As New SqlDataAdapter

    Public Sub LoadForm()

        Dim bplwotzeroqty As String = ""


        StrSql3 = "select * from BPL_Dashboard_Details"

        Ds = getBPLDetails(StrSql3)

        Dim dt As New DataTable
        dt = Ds.Tables(0)


        Dim dt1, dt2 As DataTable
        dt1 = dt.Clone()
        dt2 = dt.Clone()

        For j As Integer = 0 To dt.Rows.Count - 1
            If (j < 50) Then
                dt1.ImportRow(dt.Rows(j))
            ElseIf (j >= 50) Then
                dt2.ImportRow(dt.Rows(j))

            End If
        Next
        BPL_Dashboard1.DataSource = dt1
        DataGridView1.DataSource = dt2




    End Sub
    Public Function getBPLDetails(ByVal StrSql As String) As DataSet

        Dim ds As New DataSet
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        Return ds

    End Function

    Private Sub BPL_Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadForm()


    End Sub

    Private Sub BPL_Dashboard1_RowDefaultCellStyleChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs)

    End Sub

    Private Sub BPL_Dashboard1_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles BPL_Dashboard1.CellFormatting
        


    End Sub

    Private Sub DataGridView1_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        
    End Sub




    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click


        StrDtTo = Format(dtpdate.Value, "yyyy-MM-dd")

        StrDtFr = Format(dtpdate.Value, "ddMMyy")

        GETBPL = "%" + StrDtFr + "%"

        Dim bplwotzeroqty As String = ""

        StrSql3 = "SELECT     BPL_NO FROM     POUCH_LABEL WHERE     (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 1) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = '0') AND " & _
    "(BPL_NO IN  (SELECT     BPL_No  FROM          BPL_GEN WHERE      (BPL_No LIKE '" & GETBPL & "'))) AND (Box_Packing = 1) OR (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 1) AND (Dc_Packing = 0) AND " & _
    "(Sterilization_After = 1) AND (Sterilization_Reject = '0') AND  (BPL_NO IN (SELECT     BPL_No FROM          BPL_GEN AS BPL_GEN_1 WHERE      (BPL_No LIKE '" & GETBPL & "'))) AND (Box_Reject = '1') GROUP BY BPL_NO ORDER BY BPL_NO"


        Ds = getBPLDetails(StrSql3)
        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            bplwotzeroqty = bplwotzeroqty + "'" + eachRow1("BPL_No") + "',"
        Next
        bplwotzeroqty = bplwotzeroqty.Remove(bplwotzeroqty.Length - 1, 1)

        StrSql3 = "SELECT     TOP (100) PERCENT BPL_NO, SUM(Qty_1) AS BPL_QTY, CAST(CASE WHEN SUM(BPL_Collection_Status) IS NULL THEN 0 ELSE SUM(BPL_Collection_Status) END AS Varchar)  AS COLLETED_QTY, SUM(Box_Packing) AS BOX_PACKED_QTY , SUM(box_reject) AS BOX_REJECTION_QTY, SUM(Qty_1) - SUM(Box_Packing) - SUM(Box_Reject) AS BALANCE_QTY  FROM  dbo.POUCH_LABEL " & _
" WHERE     (Sterilization = 1) AND (Sample_Taken = 0) AND (BPL_Taken = 1) AND (Dc_Packing = 0) AND (Sterilization_After = 1) AND (Sterilization_Reject = '0') AND (BPL_NO IN " & _
" (SELECT BPL_No  FROM  dbo.BPL_GEN    WHERE      (BPL_No LIKE '" & GETBPL & "'))) and  BPL_NO NOT IN (" & bplwotzeroqty & ") GROUP BY BPL_NO ORDER BY BPL_NO"


        Ds = getBPLDetails(StrSql3)


        Dim dt As New DataTable
        dt = Ds.Tables(0)



        Dim dt1, dt2 As DataTable
        dt1 = dt.Clone()
        dt2 = dt.Clone()

        For j As Integer = 0 To dt.Rows.Count - 1
            If (j < 50) Then
                dt1.ImportRow(dt.Rows(j))
            ElseIf (j >= 50) Then
                dt2.ImportRow(dt.Rows(j))

            End If
        Next
        BPL_Dashboard1.DataSource = dt1
        DataGridView1.DataSource = dt2




        BPL_Dashboard1.ColumnHeadersDefaultCellStyle.BackColor = Color.Purple
        BPL_Dashboard1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Purple
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LoadForm()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim reason As String = ""
        Dim bpl_no As String = ""

        For i = 0 To BPL_Dashboard1.Rows.Count - 2

            If BPL_Dashboard1.Rows(i).Cells("reason1").Value IsNot Nothing Or BPL_Dashboard1.Rows(i).Cells("reason1").ToString() <> "" Then
                bpl_no = BPL_Dashboard1.Rows(i).Cells("BPL_NO").Value.ToString()
                reason = BPL_Dashboard1.Rows(i).Cells("reason1").Value
                If (reason <> "") Then
                    StrSql = "insert into Box_Dashboard_Reason (bpl_no, reason_for_notpack, reason_update_date)VALUES ('" & bpl_no & "','" & reason & "',GETDATE())"
                    Cmd = New SqlCommand(StrSql, con)
                    Cmd.ExecuteNonQuery()
                    Cmd.Dispose()
                End If

            End If
        Next
        For j = 0 To DataGridView1.Rows.Count - 2

            If DataGridView1.Rows(j).Cells("Reason").Value IsNot Nothing Or DataGridView1.Rows(j).Cells("Reason").ToString() <> "" Then
                bpl_no = DataGridView1.Rows(j).Cells("BPL_NO").Value.ToString()
                reason = DataGridView1.Rows(j).Cells("Reason").Value
                If (reason <> "") Then
                    StrSql = "insert into Box_Dashboard_Reason (bpl_no, reason_for_notpack, reason_update_date)VALUES ('" & bpl_no & "','" & reason & "',GETDATE())"
                    Cmd = New SqlCommand(StrSql, con)
                    Cmd.ExecuteNonQuery()
                    Cmd.Dispose()
                End If

            End If

        Next
        MessageBox.Show("Reason Updated Successfully...")
        LoadForm()

    End Sub
End Class