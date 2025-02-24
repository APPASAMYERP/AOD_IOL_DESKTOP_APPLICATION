Imports System.Data
Imports System.Data.SqlClient
Public Class frmSterilizationRelease
    Dim ds As New DataSet
    Dim strsql As String


    Private Sub btnRelease_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelease.Click

        strsql = "insert into Sterilization_ReleaseDate(ReleaseDate,BatchNo,UserId,CreatedDate) values ( '" & dtpReleaseDate.Value & "', '" & cmbBatchNo.Text & "','" & StrLoginUser & "',GETDATE() ) "
        Dim cmd As New SqlCommand(strsql, con)
        cmd.ExecuteNonQuery()

        strsql = "update Pouch_Label set Sterility_Status = '1' where btc_no = '" & cmbBatchNo.Text & "' "
        cmd = New SqlCommand(strsql, con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Released Successfully")

        BatchNoBind()
        Sterilization_ReleaseDateBind()
    End Sub


    Private Sub frmSterilizationRelease_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If

        con.Open()

        BatchNoBind()
        Sterilization_ReleaseDateBind()
    End Sub



    Private Sub Sterilization_ReleaseDateBind()

        ds = New DataSet()
        strsql = "select * from Sterilization_ReleaseDate where cast (ReleaseDate as Date) = '" & dtpReleaseDateSearch.Value.Date & "'"
        Dim cmd As New SqlCommand(strsql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)
        gridSterlization.DataSource = ds.Tables(0)
    End Sub

    Private Sub BatchNoBind()

        ds = New DataSet()
        strsql = "select Distinct btc_no from Pouch_Label where Sterility_Status = '0'"
        Dim cmd As New SqlCommand(strsql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)

        cmbBatchNo.DisplayMember = "btc_no"
        cmbBatchNo.DataSource = ds.Tables(0)
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Sterilization_ReleaseDateBind()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class