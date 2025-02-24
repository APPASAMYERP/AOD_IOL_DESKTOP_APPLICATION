Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class frmBIComplete

    Dim StrSql As String
    Dim Ds As New DataSet
    Dim cmd As SqlCommand

    Public Sub Form_load()

        StrSql = "Select Distinct Btc_no from Pouch_Label where (Sterilization = 1) AND (Sample_Taken = 0)  AND (Sterilization_After = 1) AND (Sterilization_Reject = '0')   and (udi_code is not NULL) and (sterility_status is NULL)  and (BI_Start_Date is NULL) and  (BI_End_Date is NULL) AND (DC_PACKING=0) "
        Ds = SQL_SelectQuery_Execute(StrSql)
        cmbbtc.Items.Clear()
        For Each eachRow1 As DataRow In Ds.Tables(0).Rows
            cmbbtc.Items.Add(eachRow1("Btc_no"))
        Next

    End Sub

    Private Sub frmBIComplete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form_load()
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cmbbtc.Text <> Nothing Then
            Try
                StrSql = "UPDATE POUCH_LABEL SET BI_Start_Date = @StartDate, BI_End_Date = @EndDate WHERE btc_no = @BatchNo"
                cmd = New SqlCommand(StrSql, con)
                cmd.Parameters.AddWithValue("@StartDate", DateTime.Parse(BI_StartDate.Text))
                cmd.Parameters.AddWithValue("@EndDate", DateTime.Parse(BI_EndDate.Text))
                cmd.Parameters.AddWithValue("@BatchNo", cmbbtc.Text)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MsgBox("BI Date has been Updated")
                clear()
                Form_load()
            Catch ex As Exception
                MsgBox("Error:" & ex.Message)
            End Try
        Else
            MsgBox("BATCH NOT FOUND")
        End If
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        clear()
    End Sub
    Private Sub clear()
        cmbbtc.Text = Nothing
        BI_StartDate.Text = Nothing
        BI_EndDate.Text = Nothing
    End Sub
End Class