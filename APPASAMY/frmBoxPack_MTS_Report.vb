Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration

Public Class frmBoxPack_MTS_Report

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
        StrSqlSeHd = "Select Max(Header_ID) As Header, Max(Detail_ID) As Detail from BoxPack_to_Despatch_Move_details"
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

    Public Function getPackedBPLNumbers() As String

        Dim bpls As String = ""
        Dim ds As New DataSet
        Dim StrSql As String = "SELECT DISTINCT BPL_No FROM         POUCH_LABEL    " & _
        " WHERE BPL_No IN( SELECT DISTINCT BPL_NO FROM   BPL_GEN WHERE BoxPack_to_Despatch_Move_Status IS NULL) AND Box_Packing=1   "
        Dim Cmd As New SqlCommand(StrSql, con)
        Dim ad As New SqlDataAdapter(Cmd)
        ad.Fill(ds)

        For Each eachRow1 As DataRow In ds.Tables(0).Rows
            bpls = bpls + "'" + eachRow1("BPL_No") + "',"
        Next

        If bpls <> "" Then
            bpls = bpls.Remove(bpls.Length - 1, 1)
        Else
            Return "''"
        End If

        Return bpls

    End Function

    Public Sub Load_BPL_No()
        'Dim packed_BPLs As String = ""
        'packed_BPLs = getPackedBPLNumbers()

        'StrSql = " SELECT DISTINCT BPL_NO FROM         BPL_GEN " & _
        '            " WHERE    " & _
        '            " (BoxPack_to_Despatch_Move_Status IS NULL)  AND BPL_No in(" & packed_BPLs & ") "
        Dim bpls As String = ""

        StrSql = "SELECT     BPL_NO FROM    (SELECT DISTINCT BPL_No, dbo.CSVParser(BPL_NO, 3) AS ThirdPart  FROM         POUCH_LABEL    " & _
       " WHERE BPL_No IN( SELECT DISTINCT BPL_NO FROM   BPL_GEN WHERE BoxPack_to_Despatch_Move_Status IS NULL) AND Box_Packing=1) as new_table  ORDER BY CAST(ThirdPart AS int) "

        Ds = SQL_SelectQuery_Execute(StrSql)
        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            bpls = bpls + "'" + eachRow1("BPL_NO") + "',"
        Next

        If bpls <> "" Then
            bpls = bpls.Remove(bpls.Length - 1, 1)
        Else
            bpls = "''"
        End If

        StrSql = "SELECT     BPL_NO   " & _
                " FROM         (SELECT     b1.BPL_No, dbo.CSVParser(b1.BPL_No, 3) AS ThirdPart " & _
                    " FROM          (SELECT     BPL_No, SUM(Acc_Qty) AS Total_Acc_Qty " & _
                        "FROM          Box_Inspection_Details " & _
                        "WHERE      (BPL_No IN (" & bpls & ")) " & _
                        "GROUP BY BPL_No) AS b1 INNER JOIN " & _
                        "(SELECT     BPL_NO, SUM(Qty_1) AS Total_Packed_Qty " & _
                        "FROM          POUCH_LABEL " & _
                        "WHERE      (BPL_NO IN (" & bpls & ")) AND (Box_Packing = '1') " & _
                        "GROUP BY BPL_NO) AS b2 ON b1.BPL_No = b2.BPL_NO AND b1.Total_Acc_Qty = b2.Total_Packed_Qty) AS new_table " & _
                "ORDER BY CAST(ThirdPart AS int)"

        Ds = SQL_SelectQuery_Execute(StrSql)

        DataGridView1.DataSource = Ds.Tables(0)

        DataGridView1.Columns("BPL_NO").ReadOnly = True
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False

    End Sub
    Public Sub Form_Load()
        LoadMovementNO()
        Load_BPL_No()
    End Sub

    Private Sub frmBoxPack_MTS_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim From_Loc As String = ""

            If productline = "PMMA" Then
                From_Loc = "PMMA BOX PACKING"
            ElseIf productline = "PHILIC" Then
                From_Loc = "FOLDABLE BOX PACKING"
            ElseIf productline = "PHOBIC" Then
                From_Loc = "FOLDABLE BOX PACKING"
            ElseIf productline = "PHOBIC NONPRELOADED" Then
                From_Loc = "FOLDABLE BOX PACKING"
            End If

            lbl_FromLocation.Text = From_Loc
            lbl_ToLocation.Text = " Despatch"

            Form_Load()

        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        

    End Sub


    Public Sub GridChange()
        Dim bpl_nos As String = ""


        For i = 0 To DataGridView2.Rows.Count - 1
            bpl_nos = bpl_nos + "'" + DataGridView2.Item(0, i).Value + "',"
        Next

        If bpl_nos = "" Then

        Else
            bpl_nos = bpl_nos.Remove(bpl_nos.Length - 1, 1)
            StrSql = " SELECT      BPL_No,Brand_Name, Model_Name, Power,  SUM(Qty_1) AS Qty  " & _
                    " FROM         POUCH_LABEL   WHERE     (Sterilization = 1) AND (Sample_Taken = 0) AND (Sterilization_After = 1) AND (box_packing = 1 ) AND (box_reject = 0)AND (Dc_Packing = 0)AND (ShrinkWarp_Rejection is NULL) AND " & _
                    "  (BPL_No IN (" & bpl_nos & ")) GROUP BY BPL_No, Brand_Name, Model_Name, Power  ORDER BY BPL_No,Brand_Name, Model_Name, Power  "
            Ds = SQL_SelectQuery_Execute(StrSql)
            DataGridView3.DataSource = Ds.Tables(0)
            DataGridView3.AllowUserToAddRows = False
            DataGridView3.AllowUserToDeleteRows = False
        End If


    End Sub

    Private Sub DataGridView2_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles DataGridView2.RowsAdded
        GridChange()
    End Sub


  
    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        DataGridView2.DataSource = Nothing
        DataGridView3.DataSource = Nothing
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Try
            If DataGridView3.Rows.Count > 0 Then


                Str_Header = 0
                Str_Detail = 0
                StrSqlSeHd = "Select Max(Header_ID) As Header, Max(Detail_ID) As Detail from BoxPack_to_Despatch_Move_details"
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
                    strInsertQry = strInsertQry + "('" + Str_Header.ToString() + "','" + Str_Detail.ToString() + "','" + lblMovementNo.Text + "','" + DataGridView3.Item(1, i).Value.ToString() + "','" + DataGridView3.Item(2, i).Value.ToString() + "','" + DataGridView3.Item(3, i).Value.ToString() + "','" + DataGridView3.Item(0, i).Value.ToString() + "','" + DataGridView3.Item(4, i).Value.ToString() + "','" + StrLoginUser + "', GETDATE(),'" + StrLoginUser + "', GETDATE(),'" + lbl_FromLocation.Text + "','" + lbl_ToLocation.Text + "'),"
                Next


                ' Insert record to sterilization table
                If strInsertQry = "" Then
                Else
                    strInsertQry = strInsertQry.Remove(strInsertQry.Length - 1, 1)
                    Sql = "Insert Into BoxPack_to_Despatch_Move_details (  Header_ID, Detail_ID,  Movement_No, Brand_Name, Model_Name, Power, BPL_No, Qty, Created_By, Created_Date, Modified_By, Modified_Date,Location_from,Location_To ) values" & strInsertQry
                    UpdateorInsertQuery_Execute(Sql)
                End If



                If bpl_nos = "" Then
                Else
                    bpl_nos = bpl_nos.Remove(bpl_nos.Length - 1, 1)
                    Sql = "Update BPL_GEN set BoxPack_to_Despatch_Move_Status=1,  BoxPack_to_Despatch_Move_No='" & lblMovementNo.Text & "'  " & _
                            " WHERE     BoxPack_to_Despatch_Move_Status IS NULL  AND (BPL_No IN (" & bpl_nos & "))  "
                    UpdateorInsertQuery_Execute(Sql)
                End If


                Dim cryRpt As New CryMTSBoxPack_to_Despatch

                Dim txt_mts_no, txt_from_loc, txt_to_loc As CrystalDecisions.CrystalReports.Engine.TextObject
                txt_mts_no = cryRpt.ReportDefinition.Sections(0).ReportObjects("mts_no")
                txt_from_loc = cryRpt.ReportDefinition.Sections(0).ReportObjects("from_loc")
                txt_to_loc = cryRpt.ReportDefinition.Sections(0).ReportObjects("to_loc")

                txt_mts_no.Text = lblMovementNo.Text
                txt_from_loc.Text = lbl_FromLocation.Text
                txt_to_loc.Text = lbl_ToLocation.Text



                cryRpt.SetDataSource(DataGridView3.DataSource)
                RptViwCollection.CryViewCollectList.ReportSource = cryRpt
                RptViwCollection.Show()

                Form_Load()
                DataGridView2.DataSource = Nothing
                DataGridView3.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        


    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            Dim dt As New DataTable()
            dt.Columns.Add("BPL_No")


            For i = 0 To DataGridView1.Rows.Count - 1
                Dim isSelected As Boolean = Convert.ToBoolean(DataGridView1.Item(0, i).Value)
                If isSelected Then
                    dt.Rows.Add(DataGridView1.Item(1, i).Value)
                End If
            Next

            DataGridView2.DataSource = dt
            DataGridView2.AllowUserToAddRows = False
            DataGridView2.AllowUserToDeleteRows = False
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub

        End Try
        
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class