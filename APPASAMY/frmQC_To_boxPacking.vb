
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class frmQC_To_boxPacking
    Dim StrSql As String

    Dim table As New DataTable
    Dim cmd As SqlCommand
    Dim Sql As String
    'Dim sqla As SqlDataAdapter
    Dim Ds As New DataSet
    Dim Dr As SqlDataReader
    Dim DtRow As DataRow
    Dim StrLorBarNo As String
    Dim Str_Header As Integer
    Dim Str_Detail As Integer
    Dim StrUniqueNo As String
    Dim StrSqlSeHd As String
    Public Function SQL_SelectQuery_Execute(ByVal StrSql As String) As DataSet

        Dim ds As New DataSet
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(cmd)
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
    Public Sub LoadMovementNO()

        Str_Header = 0
        Str_Detail = 0
        StrSqlSeHd = "Select Max(Header_ID) As Header, Max(Detail_ID) As Detail from Qc_To_Boxpack "
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
            StrUniqueNo = "PMMA-BoxPack-MMS-" & Format(Now, "ddMMyy") & "-" & Str_Header
        ElseIf productline = "PHILIC" Then
            StrUniqueNo = "PHILIC-BoxPack-MMS-" & Format(Now, "ddMMyy") & "-" & Str_Header
        ElseIf productline = "PHOBIC" Then
            StrUniqueNo = "PHOBIC-BoxPack-MMS-" & Format(Now, "ddMMyy") & "-" & Str_Header
        ElseIf productline = "PHOBIC NONPRELOADED" Then
            StrUniqueNo = "PHOBIC(NP)-BoxPack-MMS-" & Format(Now, "ddMMyy") & "-" & Str_Header
        End If

        lblMovementNo.Text = StrUniqueNo


    End Sub
    Public Sub Load_BPL_No()
        'Dim packed_BPLs As String = ""
        'packed_BPLs = getPackedBPLNumbers()

        'StrSql = " SELECT DISTINCT BPL_NO FROM         BPL_GEN " & _
        '            " WHERE    " & _
        '            " (BoxPack_to_Despatch_Move_Status IS NULL)  AND BPL_No in(" & packed_BPLs & ") "
        Dim btcs As String = ""

        StrSql = "SELECT     Btc_NO FROM    (SELECT DISTINCT Btc_No FROM         POUCH_LABEL    " & _
       " WHERE Btc_No IN( SELECT DISTINCT Btc_NO FROM   MMS_QC WHERE Sterile_to_QC = 1) AND SAMPLE_TAKEN=1) as new_table  "

        Ds = SQL_SelectQuery_Execute(StrSql)
        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            btcs = btcs + "'" + eachRow1("Btc_NO") + "',"
        Next

        If btcs <> "" Then
            btcs = btcs.Remove(btcs.Length - 1, 1)
        Else
            btcs = "''"
        End If

        StrSql = "SELECT Btc_NO,sum(qty_1) as qty from pouch_label where sample_taken='1' AND TYPE_SAMPLE='CST' group by btc_no  "

        Ds = SQL_SelectQuery_Execute(StrSql)

        DataGridView1.DataSource = Ds.Tables(0)

        DataGridView1.Columns("Btc_NO").ReadOnly = True
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False

    End Sub
    Public Function getBATCHNumbers() As String

        Dim btcs As String = ""
        Dim ds As New DataSet
        Dim StrSql As String = "SELECT DISTINCT Btc_No FROM         POUCH_LABEL    " & _
        " WHERE Btc_No IN( SELECT DISTINCT Btc_NO FROM MMS_QC ) AND SAMPLE_TAKEN=1   "
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)

        For Each eachRow1 As DataRow In ds.Tables(0).Rows
            btcs = btcs + "'" + eachRow1("Btc_No") + "',"
        Next

        If btcs <> "" Then
            btcs = btcs.Remove(btcs.Length - 1, 1)
        Else
            Return "''"
        End If

        Return btcs

    End Function
   
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim dt As New DataTable()
        dt.Columns.Add("Batch_No")


        For i = 0 To DataGridView1.Rows.Count - 1
            Dim isSelected As Boolean = Convert.ToBoolean(DataGridView1.Item(0, i).Value)
            If isSelected Then
                dt.Rows.Add(DataGridView1.Item(1, i).Value)
            End If
        Next

        DataGridView2.DataSource = dt
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.AllowUserToDeleteRows = False
    End Sub
    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        DataGridView2.DataSource = Nothing
        DataGridView3.DataSource = Nothing
    End Sub
    Public Sub GridChange()
        Dim btcs_nos As String = ""


        For i = 0 To DataGridView2.Rows.Count - 1
            btcs_nos = btcs_nos + "'" + DataGridView2.Item(0, i).Value + "',"
        Next

        If btcs_nos = "" Then

        Else
            btcs_nos = btcs_nos.Remove(btcs_nos.Length - 1, 1)
            StrSql = " SELECT     btc_no,  SUM(Qty_1) AS Qty  " & _
                    " FROM         POUCH_LABEL   WHERE      (Sample_Taken = 1)  AND (box_reject = 0)AND (Dc_Packing = 0) and TYPE_SAMPLE='CST' " & _
                    "  (Btc_No IN (" & btcs_nos & ")) GROUP BY Btc_No  ORDER BY Btc_No  "
            Ds = SQL_SelectQuery_Execute(StrSql)
            DataGridView3.DataSource = Ds.Tables(0)
            DataGridView3.AllowUserToAddRows = False
            DataGridView3.AllowUserToDeleteRows = False
        End If


    End Sub
    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click

        If DataGridView3.Rows.Count > 0 Then
            'Dim dtee As String = ""
            'dtee = Format(System.DateTime.Today(), "dd/MM/yyyy")
            Str_Header = 0
            Str_Detail = 0
            StrSqlSeHd = "Select Max(Header_ID) As Header, Max(Detail_ID) As Detail from Qc_To_Boxpack"
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
                StrUniqueNo = "PMMA-BoxPack-MMS-" & Format(Now, "ddMMyy") & "-" & Str_Header
            ElseIf productline = "PHILIC" Then
                StrUniqueNo = "PHILIC-BoxPack-MMS-" & Format(Now, "ddMMyy") & "-" & Str_Header
            ElseIf productline = "PHOBIC" Then
                StrUniqueNo = "PHOBIC-BoxPack-MMS-" & Format(Now, "ddMMyy") & "-" & Str_Header
            ElseIf productline = "PHOBIC NONPRELOADED" Then
                StrUniqueNo = "PHOBIC(NP)-BoxPack-MMS-" & Format(Now, "ddMMyy") & "-" & Str_Header
            End If

            lblMovementNo.Text = StrUniqueNo
            Dim bpl_nos As String = ""
            Dim strInsertQry As String = ""
            For i = 0 To DataGridView3.Rows.Count - 1
                bpl_nos = bpl_nos + "'" + DataGridView3.Item(0, i).Value + "',"
                strInsertQry = strInsertQry + "('" + Str_Header.ToString() + "','" + Str_Detail.ToString() + "','" + lblMovementNo.Text + "','" + DataGridView3.Item(0, i).Value.ToString() + "','" + DataGridView3.Item(1, i).Value.ToString() + "','" + StrLoginUser + "','" + System.DateTime.Today + "','" + "1" + "'),"
            Next
            If strInsertQry = "" Then
            Else
                strInsertQry = strInsertQry.Remove(strInsertQry.Length - 1, 1)
                Sql = "Insert Into Qc_To_Boxpack (  Header_ID, Detail_ID,  Movement_No, Btc_no,  Qty, Created_By, Created_Date, QC_To_boxpack) values" & strInsertQry
                UpdateorInsertQuery_Execute(Sql)
            End If
           
        End If
    End Sub


    Private Sub lbl_ToLocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_ToLocation.Click

    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
    Private Sub lbl_FromLocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_FromLocation.Click

    End Sub

    Private Sub frmQC_To_boxPacking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class