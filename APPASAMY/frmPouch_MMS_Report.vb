
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration
Public Class frmPouch_MMS_Report
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

    Public Sub LoadMovementNO()

        Str_Header = 0
        Str_Detail = 0
        StrSqlSeHd = "Select Max(Header_ID) As Header, Max(Detail_ID) As Detail from PouchPack_to_Sterile_Move_details"
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


        StrUniqueNo = productline & "-PouchPack-MMS-" & Format(Now, "ddMMyy") & "-" & Str_Header
        lblMovementNo.Text = StrUniqueNo

    End Sub

    Public Sub LoadSterileBatch()
         

        StrSql = " SELECT DISTINCT Btc_No FROM         POUCH_LABEL " & _
                    " WHERE    (Sample_Taken = 0)  " & _
                    " AND (Sterilization_Reject = 0) AND (Sterilization_After = 0) AND (PouchPack_to_Sterile_Move_status IS NULL) and Dc_packing=0   "
        Ds = SQL_SelectQuery_Execute(StrSql)
        DataGridView1.DataSource = Ds.Tables(0)
        DataGridView1.Columns("Btc_No").ReadOnly = True
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False

    End Sub

    Public Sub Form_Load()
        LoadMovementNO()
        LoadSterileBatch()

    End Sub

    Private Sub frmPouch_MMS_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lbl_FromLocation.Text = productline & " Pouch Packing"
        lbl_ToLocation.Text = productline & "  Sterile"
        Form_Load()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Try
            Dim dt As New DataTable()
            dt.Columns.Add("Btc_No")


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

    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        DataGridView2.DataSource = Nothing
        DataGridView3.DataSource = Nothing
    End Sub

    Public Sub GridChange()
        Dim strbatches As String = ""


        For i = 0 To DataGridView2.Rows.Count - 1
            strbatches = strbatches + "'" + DataGridView2.Item(0, i).Value + "',"
        Next

        If strbatches = "" Then

        Else
            strbatches = strbatches.Remove(strbatches.Length - 1, 1)
            StrSql = "  " & _
                    " SELECT     Btc_No, Model_Name, Lot_Prefix + Lot_No  AS Lot_Number, SUM(Qty_1) AS Qty  " & _
                    " FROM         POUCH_LABEL   WHERE       (Sample_Taken = 0) AND " & _
                    " (Sterilization_Reject = 0)AND (Sterilization_After = 0) AND (Dc_Packing=0) AND   (PouchPack_to_Sterile_Move_status IS NULL)AND (Btc_No IN (" & strbatches & ")) GROUP BY Btc_No, Model_Name,Lot_Prefix + Lot_No  order by Btc_No, Model_Name,Lot_Prefix + Lot_No"
            Ds = SQL_SelectQuery_Execute(StrSql)
            DataGridView3.DataSource = Ds.Tables(0)
            DataGridView3.AllowUserToAddRows = False
            DataGridView3.AllowUserToDeleteRows = False
        End If

    End Sub

    Private Sub DataGridView2_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles DataGridView2.RowsAdded
        GridChange()
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click

        Try
            If DataGridView3.Rows.Count > 0 Then

                Str_Header = 0
                Str_Detail = 0
                StrSqlSeHd = "Select Max(Header_ID) As Header, Max(Detail_ID) As Detail from PouchPack_to_Sterile_Move_details "
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


                StrUniqueNo = productline & "-PouchPack-MMS-" & Format(Now, "ddMMyy") & "-" & Str_Header
                lblMovementNo.Text = StrUniqueNo

                Dim strbatches As String = ""
                Dim strInsertQry As String = ""

                For i = 0 To DataGridView3.Rows.Count - 1
                    strbatches = strbatches + "'" + DataGridView3.Item(0, i).Value + "',"
                    strInsertQry = strInsertQry + "('" + Str_Header.ToString() + "','" + Str_Detail.ToString() + "','" + lblMovementNo.Text + "','" + DataGridView3.Item(1, i).Value.ToString() + "','" + DataGridView3.Item(2, i).Value.ToString() + "','" + DataGridView3.Item(0, i).Value.ToString() + "','" + DataGridView3.Item(3, i).Value.ToString() + "','" + StrLoginUser + "', GETDATE(),'" + StrLoginUser + "', GETDATE(),'" + lbl_FromLocation.Text + "','" + lbl_ToLocation.Text + "'),"
                Next


                ' Insert record to sterilization table
                If strInsertQry = "" Then
                Else
                    strInsertQry = strInsertQry.Remove(strInsertQry.Length - 1, 1)
                    Sql = "Insert Into PouchPack_to_Sterile_Move_details (  Header_ID, Detail_ID, Movement_No, Model_Name, Lot_Number, Btc_No, Qty, Created_By, Created_Date, Modified_By, Modified_Date,Location_from,Location_To ) values" & strInsertQry
                    UpdateorInsertQuery_Execute(Sql)
                End If



                If strbatches = "" Then
                Else
                    strbatches = strbatches.Remove(strbatches.Length - 1, 1)
                    Sql = "Update POUCH_LABEL set PouchPack_to_Sterile_Move_status=1,  PouchPack_to_Sterile_Move_No='" & lblMovementNo.Text & "'  " & _
                            " WHERE      (Sample_Taken = 0) AND (PouchPack_to_Sterile_Move_status IS NULL) AND (Sterilization_Reject = 0) AND (Sterilization_After = 0) AND (Dc_Packing=0) AND (Btc_No IN (" & strbatches & "))  "
                    UpdateorInsertQuery_Execute(Sql)
                End If

                Dim cryRpt As New CryMTSReport_Sterile

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
End Class