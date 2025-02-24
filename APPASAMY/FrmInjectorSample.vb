Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.OleDb
Imports System.Web
Imports System.Web.UI.WebControls

Public Class FrmInjectorSample
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
            StrSql = " SELECT DISTINCT Inj_Batch FROM         Injector_Stock WHERE     (Inspection_Done = '1') and (Sample_done= '0') ORDER BY Inj_Batch "
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

    Private Sub FrmInjectorSample_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Batch_Load()
    End Sub

    Private Sub CmbBatch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBatch.SelectedIndexChanged
        StrSql = " SELECT DISTINCT Inj_Ref, Product_Name, Mfd_Date, Exp_Date, Stock_Qty AS Total_qty  " & _
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
                txtTotal_Qty.Text = eachRow1("Total_qty")
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

            If Val(txtSampletaken_qty.Text) > Val(txtTotal_Qty.Text) Then
                err.SetError(txtSampletaken_qty, "Please Enter Valid Qty")
                Exit Sub
            Else
                err.SetError(txtSampletaken_qty, "")
            End If

            If Val(txtSampletaken_qty.Text) <= 0 Then
                err.SetError(txtSampletaken_qty, "Please Enter Valid Qty")
                Exit Sub
            Else
                err.SetError(txtSampletaken_qty, "")
            End If
            ' *******************************

            StrSql = "Insert into    Injector_Sample (Inj_Batch, Inj_Ref, Mfd_date, Exp_date, Product_Name, Total_Qty, Sample_Taken_Qty, Created_by, Created_date ) VALUES " & _
                            "('" & CmbBatch.Text & "','" & txtInj_ref.Text & "','" & txtmfd_date.Text & "','" & txtExp_date.Text & "','" & txtProduct_Name.Text & "','" & txtTotal_Qty.Text & "','" & txtSampletaken_qty.Text & "','" & StrLoginUser & "',GETDATE())"
            UpdateorInsertQuery_Execute(StrSql)

            StrSql = "UPDATE     Injector_Stock SET               Sample_Done = '1', Stock_Qty= Stock_Qty - " & Val(txtSampletaken_qty.Text) & " WHERE     (Inj_Batch = '" & CmbBatch.Text & "') "
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
        txtProduct_Name.Text = ""
        txtInj_ref.Text = ""
        txtExp_date.Text = ""
        txtmfd_date.Text = ""
        txtTotal_Qty.Text = ""
        txtSampletaken_qty.Text = ""
         
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        Clear()
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class