
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.OleDb
Imports System.Web
Imports System.Web.UI.WebControls

Public Class FrmInjectorStockReceive

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
            Dim btcs As String = ""

            StrSql = " SELECT DISTINCT Str_batch FROM         Injector_Label WHERE     (Created_Date > '2023-11-01 00:00:01') AND (Received_Sterile IS NULL) ORDER BY Str_batch "
            Ds = SQL_SelectQuery_Execute(StrSql)

            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                btcs = btcs + "'" + eachRow1("Str_batch") + "',"
            Next

            If btcs <> "" Then
                btcs = btcs.Remove(btcs.Length - 1, 1)
            Else
                btcs = "''"
            End If


            StrSql = " SELECT DISTINCT Str_batch FROM         Injector_to_sterile_move WHERE     (Str_batch IN (" & btcs & ")) "
            Ds = SQL_SelectQuery_Execute(StrSql)

            CmbBatch.Items.Clear()
            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                CmbBatch.Items.Add(eachRow1("Str_batch"))
            Next
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
    End Sub
    Public Sub Product_Load()
        Try
            StrSql = " SELECT DISTINCT Product_Name FROM         Injector_Product_Master "
            Ds = SQL_SelectQuery_Execute(StrSql)

            cmbProduct_Name.Items.Clear()
            For Each eachRow1 As DataRow In Ds.Tables(0).Rows
                cmbProduct_Name.Items.Add(eachRow1("Product_Name"))
            Next
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
    End Sub

    Private Sub FrmInjectorStockReceive_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Batch_Load()
        Product_Load()

    End Sub

 
    Private Sub CmbBatch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBatch.SelectedIndexChanged

        StrSql = " SELECT DISTINCT  Inj_Ref, CAST(Mfd_Month AS varchar) + '-' + CAST(Mfd_Year AS varchar) AS Mfd_Date, CAST(Exp_Month AS varchar) + '-' + CAST(Exp_year AS varchar) AS Exp_Date, " & _
                "  Qty, BTWLabelName, (SELECT DISTINCT Movement_No FROM         Injector_to_sterile_move WHERE     (Str_batch = '" & CmbBatch.Text & "' )) As MTS_No FROM         Injector_Label WHERE     (Str_batch = '" & CmbBatch.Text & "') "
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
                txtlabeled_qty.Text = eachRow1("Qty")
                txtLabel_Name.Text = eachRow1("BTWLabelName")
                txtMTS_NO.Text = eachRow1("MTS_No")

            Next
        Else
            MessageBox.Show("This Batch Number Not Present, Contact ERP Team.!!!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CmbBatch.Text = ""
            CmbBatch.Focus()
            Exit Sub
        End If

        

    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
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

            If cmbProduct_Name.Text = "" Then
                err.SetError(cmbProduct_Name, "This information is required")
                Exit Sub
            Else
                err.SetError(cmbProduct_Name, "")
            End If

            If cmbProduct_Name.SelectedItem Is Nothing Then
                err.SetError(cmbProduct_Name, " Please Select Valid Product Name")
                Exit Sub
            End If


            If txtReceived_qty.Text = "" Then
                err.SetError(txtReceived_qty, "This information is required")
                Exit Sub
            Else
                err.SetError(txtReceived_qty, "")
            End If

            If Val(txtReceived_qty.Text) <= 0 Then
                err.SetError(txtReceived_qty, "Please Enter Valid Qty")
                Exit Sub
            Else
                err.SetError(txtReceived_qty, "")
            End If

            If Val(txtReceived_qty.Text) > Val(txtlabeled_qty.Text) Then
                err.SetError(txtReceived_qty, "Please Enter Valid Qty")
                Exit Sub
            Else
                err.SetError(txtReceived_qty, "")
            End If


            If txtMTS_NO.Text = "" Then
                err.SetError(txtMTS_NO, "This information is required")
                Exit Sub
            Else
                err.SetError(txtMTS_NO, "")
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

            If txtlabeled_qty.Text = "" Then
                err.SetError(txtlabeled_qty, "This information is required")
                Exit Sub
            Else
                err.SetError(txtlabeled_qty, "")
            End If

            If txtLabel_Name.Text = "" Then
                err.SetError(txtLabel_Name, "This information is required")
                Exit Sub
            Else
                err.SetError(txtLabel_Name, "")
            End If

            '*******************************

            StrSql = "Insert into Injector_Stock (Inj_Batch, Inj_Ref, Product_Name, Mfd_Date, Exp_Date, Labeled_Qty, Received_Qty, Stock_Qty, Label_Name, MTS_No, Created_By, Created_Date,  Inspection_Done, Sample_done ) VALUES " & _
                            "('" & CmbBatch.Text & "','" & txtInj_ref.Text & "','" & cmbProduct_Name.Text & "','" & txtmfd_date.Text & "','" & txtExp_date.Text & "','" & txtlabeled_qty.Text & "','" & txtReceived_qty.Text & "','" & txtReceived_qty.Text & "','" & txtLabel_Name.Text & "','" & txtMTS_NO.Text & "','" & StrLoginUser & "',GETDATE(), 0, 0)"
            UpdateorInsertQuery_Execute(StrSql)

            StrSql = "UPDATE    Injector_Label SET              Received_Sterile = '1' WHERE     (Str_batch = '" & CmbBatch.Text & "') "
            UpdateorInsertQuery_Execute(StrSql)


            Clear()
            Batch_Load()

        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try
        
    End Sub

    Public Sub Clear()
        CmbBatch.Text = ""
        cmbProduct_Name.Text = ""
        txtInj_ref.Text = ""
        txtExp_date.Text = ""
        txtmfd_date.Text = ""
        txtlabeled_qty.Text = ""
        txtReceived_qty.Text = ""
        txtLabel_Name.Text = ""
        txtMTS_NO.Text = ""
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        Clear()
    End Sub
End Class