Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.OleDb
Imports System.Web
Imports System.Web.UI.WebControls

Public Class FrmInjectorInspection

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
            StrSql = " SELECT DISTINCT Inj_Batch FROM         Injector_Stock WHERE     (Inspection_Done = '0') ORDER BY Inj_Batch "
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
            Dim utcTime As DateTime = DateTime.UtcNow
            Dim indiaTime As DateTime = utcTime.AddHours(5).AddMinutes(30)
            Dim startDate As String = indiaTime.ToString("yyyy-MM-dd 00:00:01")
            Dim endDate As String = indiaTime.ToString("yyyy-MM-dd 23:59:59")
            Dim From_Loc As String = ""

            StrSql = "Select Movement_No from Rejection_MTS_Details_Injector Where Created_date between '" & startDate & "' and '" & endDate & "'  "
            Ds = SQL_SelectQuery_Execute(StrSql)
            If Ds.Tables(0).Rows.Count = 1 Then
                StrUniqueNo = Ds.Tables(0).Rows(0)("Movement_No")
                txtMTS_NO.Text = StrUniqueNo
            ElseIf Ds.Tables(0).Rows.Count < 1 Then
                Str_Header = 0
                Str_Detail = 0
                StrSqlSeHd = "Select Max(Header_ID) As Header, Max(Detail_ID) As Detail from Rejection_MTS_Details_Injector"
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


                StrUniqueNo = "INJECTOR-REJ-MMS-" & Format(indiaTime, "ddMMyy") & "-" & Str_Header
                From_Loc = "INJECTOR STERILE"
                txtMTS_NO.Text = StrUniqueNo


            Else
                MessageBox.Show("More than one MTS No contains.Please check")
                Exit Sub

            End If
        Catch ex As Exception
            MsgBox("An unexpected error occurred.")
            Exit Sub
        End Try

        



    End Sub

    Public Sub Insert_MTS_No()
        Dim utcTime As DateTime = DateTime.UtcNow
        Dim indiaTime As DateTime = utcTime.AddHours(5).AddMinutes(30)
        Dim startDate As String = indiaTime.ToString("yyyy-MM-dd 00:00:01")
        Dim endDate As String = indiaTime.ToString("yyyy-MM-dd 23:59:59")
        Dim From_Loc As String = ""

        StrSql = "Select Movement_No from Rejection_MTS_Details_Injector Where Created_date between '" & startDate & "' and '" & endDate & "'  "
        Ds = SQL_SelectQuery_Execute(StrSql)
        If Ds.Tables(0).Rows.Count = 1 Then
            StrUniqueNo = Ds.Tables(0).Rows(0)("Movement_No")
            txtMTS_NO.Text = StrUniqueNo
        ElseIf Ds.Tables(0).Rows.Count < 1 Then
            Str_Header = 0
            Str_Detail = 0
            StrSqlSeHd = "Select Max(Header_ID) As Header, Max(Detail_ID) As Detail from Rejection_MTS_Details_Injector"
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


            StrUniqueNo = "INJECTOR-REJ-MMS-" & Format(indiaTime, "ddMMyy") & "-" & Str_Header
            From_Loc = "INJECTOR STERILE"
            txtMTS_NO.Text = StrUniqueNo


            StrSql = "Insert Into Rejection_MTS_Details_Injector (  Header_ID, Detail_ID, Movement_No, Created_By, Created_Date, Modified_By, Modified_Date,Location_from,Location_To ) values" & _
            "('" + Str_Header.ToString() + "','" + Str_Detail.ToString() + "','" + StrUniqueNo + "','" + StrLoginUser + "', GETDATE(),'" + StrLoginUser + "', GETDATE(),'" + From_Loc + "','Store')"
            UpdateorInsertQuery_Execute(StrSql)


        Else
            MessageBox.Show("More than one MTS No contains.Please check")
            Exit Sub

        End If



    End Sub

    Private Sub FrmInjectorInspection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Batch_Load()
        MTS_No_Load()
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


            If txtReceived_qty.Text = "" Then
                err.SetError(txtReceived_qty, "This information is required")
                Exit Sub
            Else
                err.SetError(txtReceived_qty, "")
            End If

            If Val(txtReceived_qty.Text) <= 0 Or Val(txtReceived_qty.Text) > Val(txtTotal_Qty.Text) Then
                err.SetError(txtReceived_qty, "Please Enter Valid Qty")
                Exit Sub
            Else
                err.SetError(txtReceived_qty, "")
            End If

            If Val(txtReceived_qty.Text) <> Val(txtTotal_Qty.Text) Then
                err.SetError(txtReceived_qty, "Please Enter Valid Qty")
                Exit Sub
            Else
                err.SetError(txtReceived_qty, "")
            End If

            If txtAccepted_Qty.Text = "" Then
                err.SetError(txtAccepted_Qty, "This information is required")
                Exit Sub
            Else
                err.SetError(txtAccepted_Qty, "")
            End If


            If Val(txtAccepted_Qty.Text) > Val(txtTotal_Qty.Text) Then
                err.SetError(txtAccepted_Qty, "Please Enter Valid Qty")
                Exit Sub
            Else
                err.SetError(txtAccepted_Qty, "")
            End If

            If txtRejected_qty.Text = "" Then
                err.SetError(txtRejected_qty, "This information is required")
                Exit Sub
            Else
                err.SetError(txtRejected_qty, "")
            End If


            If Val(txtRejected_qty.Text) > Val(txtTotal_Qty.Text) Then
                err.SetError(txtRejected_qty, "Please Enter Valid Qty")
                Exit Sub
            Else
                err.SetError(txtRejected_qty, "")
            End If

            If Val(txtAccepted_Qty.Text) + Val(txtRejected_qty.Text) <> Val(txtTotal_Qty.Text) Then
                MessageBox.Show("Qty Mismatch, Pleace check Accepted Qty and Rejection Qty")
                Exit Sub
            End If

            If Val(txtRejected_qty.Text) > 0 Then
                If txtMTS_NO.Text = "" Then
                    err.SetError(txtMTS_NO, "This information is required")
                    Exit Sub
                Else
                    err.SetError(txtMTS_NO, "")
                End If

            Else
                err.SetError(txtRejected_qty, "")
            End If

            If Val(txtRejected_qty.Text) > 0 Then
                Insert_MTS_No()
            End If

            ' *******************************
            StrSql = "Insert into  Injector_Inspection (Inj_Batch, Inj_Ref, Mfd_date, Exp_date, Product_Name, Total_Qty, Received_Qty, Accepted_Qty, Rejected_Qty, MTS_No, Inspection_by,  Inspection_date ) VALUES " & _
                            "('" & CmbBatch.Text & "','" & txtInj_ref.Text & "','" & txtmfd_date.Text & "','" & txtExp_date.Text & "','" & txtProduct_Name.Text & "','" & txtTotal_Qty.Text & "','" & txtReceived_qty.Text & "','" & txtAccepted_Qty.Text & "','" & txtRejected_qty.Text & "','" & txtMTS_NO.Text & "','" & StrLoginUser & "',GETDATE())"
            UpdateorInsertQuery_Execute(StrSql)

            StrSql = "UPDATE     Injector_Stock SET               Inspection_Done = '1', Stock_Qty= Stock_Qty - " & Val(txtRejected_qty.Text) & " WHERE     (Inj_Batch = '" & CmbBatch.Text & "') "
            UpdateorInsertQuery_Execute(StrSql)


            Clear()
            Batch_Load()
            MTS_No_Load()
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
        txtReceived_qty.Text = ""
        txtAccepted_Qty.Text = ""
        txtMTS_NO.Text = ""
        txtRejected_qty.Text = ""
    End Sub
    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        Clear()
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class