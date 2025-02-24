Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.OleDb
Imports System.Web
Imports System.Web.UI.WebControls

Public Class FrmInjector_Movement
    Dim StrRs, StrRs1 As SqlDataReader
    Dim Cmd As New SqlCommand
    Dim DtRow As DataRow
    Dim StrSql As String
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

    Public Sub Batch_Load()
        Try
            StrSql = " SELECT DISTINCT Inj_Batch FROM         Injector_Stock WHERE     (Inspection_Done = '1') and (Sample_done= '1') and (sterile_to_aeration=1) and (Stock_Qty > 0) ORDER BY Inj_Batch "
            Ds = SQL_SelectQuery_Execute(StrSql)

            CmbBatch.Items.Clear()
            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                CmbBatch.Items.Add(eachRow1("Inj_Batch"))
            Next
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
    End Sub
    Public Sub MTS_No_Load()
        Try
            Str_Header = 0
            Str_Detail = 0
            StrSqlSeHd = "Select Max(Header_ID) As Header, Max(Detail_ID) As Detail from Injector_Movement"
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


            StrUniqueNo = "INJECTOR-MMS-" & Format(Now, "ddMMyy") & "-" & Str_Header
            txtMTS_NO.Text = StrUniqueNo
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        

    End Sub
    Private Sub FrmInjector_Movement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MTS_No_Load()
        Batch_Load()
    End Sub

    Private Sub CmbBatch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBatch.SelectedIndexChanged
        'validation
        For Each row As DataGridViewRow In GRID2.Rows
            If Not row.IsNewRow Then
                Dim btch As String = row.Cells(0).Value.ToString()
                If btch = CmbBatch.Text Then
                    MessageBox.Show("This Batch Number Already added. Please clear and Reselect")
                    CmbBatch.SelectedIndex = -1
                    CmbBatch.Text = ""
                    CmbBatch.Focus()
                    Exit Sub
                End If
            End If
        Next



        StrSql = " SELECT DISTINCT Inj_Ref, Product_Name, Mfd_Date, Exp_Date, Stock_Qty AS Available_qty  " & _
                "  FROM         Injector_Stock WHERE     (Inj_Batch = '" & CmbBatch.Text & "') "
        Ds = SQL_SelectQuery_Execute(StrSql)


        If Ds.Tables(0).Rows.Count > 1 Then
            MessageBox.Show("This Batch Number Multiple Time Present, Contact ERP Team.!!!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CmbBatch.Text = ""
            CmbBatch.Focus()
            Exit Sub
        ElseIf Ds.Tables(0).Rows.Count = 1 Then
            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                txtInj_ref.Text = eachRow1("Inj_Ref")
                txtmfd_date.Text = eachRow1("Mfd_Date")
                txtExp_date.Text = eachRow1("Exp_Date")
                txtProduct_Name.Text = eachRow1("Product_Name")
                txtAvailable_Qty.Text = eachRow1("Available_qty")
            Next
        Else
            MessageBox.Show("This Batch Number Not Present, Contact ERP Team.!!!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CmbBatch.Text = ""
            CmbBatch.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        Try

            'MTS Number load
            MTS_No_Load()
            'validation
            If GRID2.Rows.Count > 1 Then

                For Each row As DataGridViewRow In GRID2.Rows
                    If Not row.IsNewRow Then
                        StrSql = "Insert into    Injector_Movement (Inj_Batch, Inj_Ref, Mfd_date, Exp_date, Product_Name, Total_Qty, Moved_Qty, Moved_Location, Created_by, Created_date, MTS_No, Header_ID, Detail_ID ) VALUES " & _
                            "('" & row.Cells(0).Value.ToString() & "','" & row.Cells(1).Value.ToString() & "','" & row.Cells(2).Value.ToString() & "','" & row.Cells(3).Value.ToString() & "','" & row.Cells(4).Value.ToString() & "','" & row.Cells(5).Value.ToString() & "','" & row.Cells(6).Value.ToString() & "','" & row.Cells(7).Value.ToString() & "','" & StrLoginUser & "',GETDATE(), '" & txtMTS_NO.Text & "','" & Str_Header & "','" & Str_Detail & "')"
                        UpdateorInsertQuery_Execute(StrSql)

                        StrSql = "UPDATE     Injector_Stock SET      Stock_Qty= Stock_Qty - " & Val(row.Cells(6).Value.ToString()) & " WHERE     (Inj_Batch = '" & row.Cells(0).Value.ToString() & "') "
                        UpdateorInsertQuery_Execute(StrSql)

                    End If
                Next

            Else
                MessageBox.Show("please add atleast one batch")
                Exit Sub
            End If


            Dim cryRpt As New cryMTS_Report_Injector

            Dim txt_mts_no, txt_from_loc, txt_to_loc As CrystalDecisions.CrystalReports.Engine.TextObject
            txt_mts_no = cryRpt.ReportDefinition.Sections(0).ReportObjects("mts_no")
            txt_from_loc = cryRpt.ReportDefinition.Sections(0).ReportObjects("from_loc")
            txt_to_loc = cryRpt.ReportDefinition.Sections(0).ReportObjects("to_loc")


            StrSql = " SELECT DISTINCT Moved_Location, MTS_No  " & _
                    "  FROM         Injector_Movement   WHERE     (MTS_No = '" & txtMTS_NO.Text & "')  "
            Ds = SQL_SelectQuery_Execute(StrSql)
            If Ds.Tables(0).Rows.Count = 1 Then
                txt_mts_no.Text = Ds.Tables(0).Rows(0)("MTS_No")
                txt_from_loc.Text = " Injector "
                txt_to_loc.Text = Ds.Tables(0).Rows(0)("Moved_Location")
            Else
                MessageBox.Show("More then one location or MMS number Updated. Please check")
                Exit Sub
            End If




            StrSql = " SELECT     Product_Name, Inj_Ref, Inj_Batch, SUM(Moved_Qty) AS Moved_qty  " & _
                    "  FROM         Injector_Movement  WHERE     (MTS_No = '" & txtMTS_NO.Text & "') " & _
                     "  GROUP BY Product_Name, Inj_Ref, Inj_Batch  " & _
                      "  ORDER BY Product_Name, Inj_Ref, Inj_Batch "
            Ds = SQL_SelectQuery_Execute(StrSql)

            cryRpt.SetDataSource(Ds.Tables(0))
            RptViwCollection.CryViewCollectList.ReportSource = cryRpt
            RptViwCollection.Show()


            txtMTS_NO.Text = ""
            GRID2.Rows.Clear()
            lblTotBplQty.Text = "0"

            MTS_No_Load()

            ''Validation  *******************************
            'If CmbBatch.Text = "" Then
            '    Err.SetError(CmbBatch, "This information is required")
            '    Exit Sub
            'Else
            '    Err.SetError(CmbBatch, "")
            'End If

            'If CmbBatch.SelectedItem Is Nothing Then
            '    Err.SetError(CmbBatch, " Please Select Valid Batch Number")
            '    Exit Sub
            'End If

            'If txtProduct_Name.Text = "" Then
            '    Err.SetError(txtProduct_Name, "This information is required")
            '    Exit Sub
            'Else
            '    Err.SetError(txtProduct_Name, "")
            'End If


            'If txtInj_ref.Text = "" Then
            '    Err.SetError(txtInj_ref, "This information is required")
            '    Exit Sub
            'Else
            '    Err.SetError(txtInj_ref, "")
            'End If

            'If txtmfd_date.Text = "" Then
            '    Err.SetError(txtmfd_date, "This information is required")
            '    Exit Sub
            'Else
            '    Err.SetError(txtmfd_date, "")
            'End If

            'If txtExp_date.Text = "" Then
            '    Err.SetError(txtExp_date, "This information is required")
            '    Exit Sub
            'Else
            '    Err.SetError(txtExp_date, "")
            'End If

            'If Val(txtMoved_qty.Text) > Val(txtAvailable_Qty.Text) Then
            '    err.SetError(txtMoved_qty, "Please Enter Valid Qty")
            '    Exit Sub
            'Else
            '    err.SetError(txtMoved_qty, "")
            'End If

            'If Val(txtMoved_qty.Text) <= 0 Then
            '    Err.SetError(txtMoved_qty, "Please Enter Valid Qty")
            '    Exit Sub
            'Else
            '    Err.SetError(txtMoved_qty, "")
            'End If


            'If CmbLocation.Text = "" Then
            '    err.SetError(CmbLocation, "This information is required")
            '    Exit Sub
            'Else
            '    err.SetError(CmbLocation, "")
            'End If

            'If CmbLocation.SelectedItem Is Nothing Then
            '    err.SetError(CmbLocation, " Please Select Valid Location")
            '    Exit Sub
            'End If

            'If txtMTS_NO.Text = "" Then
            '    err.SetError(txtMTS_NO, "This information is required")
            '    Exit Sub
            'Else
            '    err.SetError(txtMTS_NO, "")
            'End If
            '' *******************************

            'StrSql = "Insert into    Injector_Movement (Inj_Batch, Inj_Ref, Mfd_date, Exp_date, Product_Name, Total_Qty, Moved_Qty, Moved_Location, Created_by, Created_date, MTS_No ) VALUES " & _
            '                "('" & CmbBatch.Text & "','" & txtInj_ref.Text & "','" & txtmfd_date.Text & "','" & txtExp_date.Text & "','" & txtProduct_Name.Text & "','" & txtAvailable_Qty.Text & "','" & txtMoved_qty.Text & "','" & CmbLocation.Text & "','" & StrLoginUser & "',GETDATE(), '" & txtMTS_NO.Text & "')"
            'UpdateorInsertQuery_Execute(StrSql)

            'StrSql = "UPDATE     Injector_Stock SET      Stock_Qty= Stock_Qty - " & Val(txtMoved_qty.Text) & " WHERE     (Inj_Batch = '" & CmbBatch.Text & "') "
            'UpdateorInsertQuery_Execute(StrSql)

            Clear()
            Batch_Load()

        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        

    End Sub
    Public Sub Clear()
        CmbBatch.Text = ""
        txtProduct_Name.Text = ""
        txtInj_ref.Text = ""
        txtExp_date.Text = ""
        txtmfd_date.Text = ""
        txtAvailable_Qty.Text = ""
        txtMoved_qty.Text = ""
        CmbLocation.Text = ""

    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        Clear()
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub btn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add.Click

        Try

            'Validation  *******************************
            If CmbBatch.Text = "" Then
                err.SetError(CmbBatch, "This information is required")
                Exit Sub
            Else
                err.SetError(CmbBatch, "")
            End If

            If CmbBatch.SelectedItem Is Nothing Then
                err.SetError(CmbBatch, " Please Select Valid Batch Number")
                Exit Sub
            End If

            If txtProduct_Name.Text = "" Then
                err.SetError(txtProduct_Name, "This information is required")
                Exit Sub
            Else
                err.SetError(txtProduct_Name, "")
            End If


            If txtInj_ref.Text = "" Then
                err.SetError(txtInj_ref, "This information is required")
                Exit Sub
            Else
                err.SetError(txtInj_ref, "")
            End If

            If txtmfd_date.Text = "" Then
                err.SetError(txtmfd_date, "This information is required")
                Exit Sub
            Else
                err.SetError(txtmfd_date, "")
            End If

            If txtExp_date.Text = "" Then
                err.SetError(txtExp_date, "This information is required")
                Exit Sub
            Else
                err.SetError(txtExp_date, "")
            End If

            If Val(txtMoved_qty.Text) > Val(txtAvailable_Qty.Text) Then
                err.SetError(txtMoved_qty, "Please Enter Valid Qty")
                Exit Sub
            Else
                err.SetError(txtMoved_qty, "")
            End If

            If Val(txtMoved_qty.Text) <= 0 Then
                err.SetError(txtMoved_qty, "Please Enter Valid Qty")
                Exit Sub
            Else
                err.SetError(txtMoved_qty, "")
            End If


            If CmbLocation.Text = "" Then
                err.SetError(CmbLocation, "This information is required")
                Exit Sub
            Else
                err.SetError(CmbLocation, "")
            End If

            If CmbLocation.SelectedItem Is Nothing Then
                err.SetError(CmbLocation, " Please Select Valid Location")
                Exit Sub
            End If

            If txtMTS_NO.Text = "" Then
                err.SetError(txtMTS_NO, "This information is required")
                Exit Sub
            Else
                err.SetError(txtMTS_NO, "")
            End If
            ' *******************************

            GRID2.Rows.Add(CmbBatch.Text, txtInj_ref.Text, txtmfd_date.Text, txtExp_date.Text, txtProduct_Name.Text, txtAvailable_Qty.Text, txtMoved_qty.Text, CmbLocation.Text)
            lblTotBplQty.Text = Val(lblTotBplQty.Text) + Val(txtMoved_qty.Text)


            Clear()
            Batch_Load()

        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
        
    End Sub

    Private Sub CmbLocation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbLocation.SelectedIndexChanged

        'validation
        For Each row As DataGridViewRow In GRID2.Rows
            If Not row.IsNewRow Then
                Dim location As String = row.Cells(7).Value.ToString()
                If location <> CmbLocation.Text Then
                    MessageBox.Show("You select another location please check")
                    CmbLocation.SelectedIndex = -1
                    CmbLocation.Text = ""
                    CmbLocation.Focus()
                    Exit Sub
                End If
            End If
        Next

    End Sub
End Class