Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration

Public Class FrmCreateFGTNforBPL

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
    Public Sub Form_Load()
        LoadMovementNO()
        Load_BPL_No()
    End Sub
    Public Sub LoadMovementNO()


        Str_Header = 0
        Str_Detail = 0
        StrSqlSeHd = "Select Max(Header_ID) As Header, Max(Detail_ID) As Detail from FGTN_details"
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
            StrUniqueNo = "PMMA-FGTN-" & Format(Now, "ddMMyy") & "-" & Str_Header
        ElseIf productline = "PHILIC" Then
            StrUniqueNo = "PHI-FGTN-" & Format(Now, "ddMMyy") & "-" & Str_Header
        ElseIf productline = "PHOBIC" Then
            StrUniqueNo = "PHO-FGTN-" & Format(Now, "ddMMyy") & "-" & Str_Header
        ElseIf productline = "PHOBIC NONPRELOADED" Then
            StrUniqueNo = "PHO(NP)-FGTN-" & Format(Now, "ddMMyy") & "-" & Str_Header
        End If

        lblFGTN_No.Text = StrUniqueNo

    End Sub


    Public Sub Load_BPL_No()

        Dim bpls As String = ""

        StrSql = "SELECT     BPL_NO FROM    (SELECT DISTINCT BPL_No, dbo.CSVParser(BPL_NO, 3) AS ThirdPart  FROM         POUCH_LABEL    " & _
       " WHERE BPL_No IN( SELECT DISTINCT BPL_NO FROM   BPL_GEN WHERE FGTN_Created IS NULL) AND Box_Packing=1) as new_table  ORDER BY CAST(ThirdPart AS int) "

        Ds = SQL_SelectQuery_Execute(StrSql)
        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            bpls = bpls + "'" + eachRow1("BPL_NO") + "',"
        Next

        If bpls <> "" Then
            bpls = bpls.Remove(bpls.Length - 1, 1)
        Else
            bpls = "''"
        End If


        'BI date not completed bpls
        Dim not_completed_bpls As String = ""

        StrSql = "SELECT DISTINCT BPL_NO   FROM         POUCH_LABEL  " & _
       " WHERE     (BPL_NO IN (" & bpls & ")) AND (BI_End_Date > GETDATE() - 14 OR BI_End_Date IS NULL)  "

        Ds = SQL_SelectQuery_Execute(StrSql)
        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            not_completed_bpls = not_completed_bpls + "'" + eachRow1("BPL_NO") + "',"
        Next

        If not_completed_bpls <> "" Then
            not_completed_bpls = not_completed_bpls.Remove(not_completed_bpls.Length - 1, 1)
        Else
            not_completed_bpls = "''"
        End If


        'bpl fully box packed-- check with inspection table

        StrSql = "SELECT       BPL_NO   " & _
                " FROM         (SELECT     b1.BPL_No, dbo.CSVParser(b1.BPL_No, 3) AS ThirdPart " & _
                    " FROM          (SELECT     BPL_No, SUM(Acc_Qty) AS Total_Acc_Qty " & _
                        "FROM          Box_Inspection_Details " & _
                        "WHERE      (BPL_No IN (" & bpls & ")) and (BPL_No Not IN (" & not_completed_bpls & ")) " & _
                        "GROUP BY BPL_No) AS b1 INNER JOIN " & _
                        "(SELECT     BPL_NO, SUM(Qty_1) AS Total_Packed_Qty " & _
                        "FROM          POUCH_LABEL " & _
                        "WHERE      (BPL_NO IN (" & bpls & ")) AND (Box_Packing = '1') and (BPL_No Not IN (" & not_completed_bpls & "))  " & _
                        "GROUP BY BPL_NO) AS b2 ON b1.BPL_No = b2.BPL_NO AND b1.Total_Acc_Qty = b2.Total_Packed_Qty) AS new_table " & _
                "ORDER BY CAST(ThirdPart AS int)"

        Ds = SQL_SelectQuery_Execute(StrSql)

        cmbBPL.Items.Clear()
        For Each eachRow As DataRow In Ds.Tables(0).Rows
            cmbBPL.Items.Add(eachRow("BPL_NO"))
        Next
         

    End Sub

    Private Sub FrmCreateFGTNforBPL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form_Load()

    End Sub

    Private Sub cmbStbatch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBPL.SelectedIndexChanged

        StrSql = " SELECT      BPL_No,Brand_Name, Model_Name, Power,  SUM(Qty_1) AS Qty  " & _
                    " FROM         POUCH_LABEL   WHERE     (Sterilization = 1) AND (Sample_Taken = 0) AND (Sterilization_After = 1) AND (box_packing = 1 ) AND (box_reject = 0)AND (Dc_Packing = 0)AND (ShrinkWarp_Rejection is NULL) AND " & _
                    "  (BPL_No ='" & cmbBPL.Text & "') GROUP BY BPL_No, Brand_Name, Model_Name, Power  ORDER BY BPL_No,Brand_Name, Model_Name, Power  "
        Ds = SQL_SelectQuery_Execute(StrSql)
        DataGridView3.DataSource = Ds.Tables(0)
        DataGridView3.AllowUserToAddRows = False
        DataGridView3.AllowUserToDeleteRows = False

    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click

        Try
            If DataGridView3.Rows.Count > 0 Then


                Str_Header = 0
                Str_Detail = 0
                StrSqlSeHd = "Select Max(Header_ID) As Header, Max(Detail_ID) As Detail from FGTN_details"
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
                    StrUniqueNo = "PMMA-FGTN-" & Format(Now, "ddMMyy") & "-" & Str_Header
                ElseIf productline = "PHILIC" Then
                    StrUniqueNo = "PHI-FGTN-" & Format(Now, "ddMMyy") & "-" & Str_Header
                ElseIf productline = "PHOBIC" Then
                    StrUniqueNo = "PHO-FGTN-" & Format(Now, "ddMMyy") & "-" & Str_Header
                ElseIf productline = "PHOBIC NONPRELOADED" Then
                    StrUniqueNo = "PHO(NP)-FGTN-" & Format(Now, "ddMMyy") & "-" & Str_Header
                End If

                lblFGTN_No.Text = StrUniqueNo



                Dim bpl_nos As String = ""
                Dim strInsertQry As String = ""

                For i = 0 To DataGridView3.Rows.Count - 1
                    bpl_nos = bpl_nos + "'" + DataGridView3.Item(0, i).Value + "',"
                    strInsertQry = strInsertQry + "('" + Str_Header.ToString() + "','" + Str_Detail.ToString() + "','" + lblFGTN_No.Text + "','" + DataGridView3.Item(1, i).Value.ToString() + "','" + DataGridView3.Item(2, i).Value.ToString() + "','" + DataGridView3.Item(3, i).Value.ToString() + "','" + DataGridView3.Item(0, i).Value.ToString() + "','" + DataGridView3.Item(4, i).Value.ToString() + "','" + StrLoginUser + "', GETDATE(),'" + StrLoginUser + "', GETDATE()),"
                Next


                ' Insert record  
                If strInsertQry = "" Then
                Else
                    strInsertQry = strInsertQry.Remove(strInsertQry.Length - 1, 1)
                    Sql = "Insert Into FGTN_details (  Header_ID, Detail_ID,  FGTN_No, Brand_Name, Model_Name, Power, BPL_No, Qty, Created_By, Created_Date, Modified_By, Modified_Date  ) values" & strInsertQry
                    UpdateorInsertQuery_Execute(Sql)
                End If



                If bpl_nos = "" Then
                Else
                    bpl_nos = bpl_nos.Remove(bpl_nos.Length - 1, 1)
                    Sql = "Update BPL_GEN set FGTN_Created=1,  FGTN_No='" & lblFGTN_No.Text & "'  " & _
                            " WHERE     FGTN_Created IS NULL  AND (BPL_No IN (" & bpl_nos & "))  "
                    UpdateorInsertQuery_Execute(Sql)
                End If


                Dim cryRpt As New CryFGTN

                Dim txt_mts_no As CrystalDecisions.CrystalReports.Engine.TextObject
                txt_mts_no = cryRpt.ReportDefinition.Sections(0).ReportObjects("mts_no") 

                txt_mts_no.Text = lblFGTN_No.Text
                 



                cryRpt.SetDataSource(DataGridView3.DataSource)
                RptViwCollection.CryViewCollectList.ReportSource = cryRpt
                RptViwCollection.Show()

                cmbBPL.Text = ""
                cmbBPL.Items.Clear()
                DataGridView3.DataSource = Nothing

                Form_Load()
            End If
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try

    End Sub
End Class