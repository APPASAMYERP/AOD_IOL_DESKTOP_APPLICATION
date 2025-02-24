Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class frmStationMaster
    Dim ds As New DataSet
    Dim strsql As String
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure to Delete?", "Delete Station", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Delete()
            SelectAllStation()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Save()
        SelectAllStation()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Clear()
    End Sub
    Private Sub Clear()
        txtStationName.Text = ""
    End Sub

    Private Sub Delete()
        strsql = "delete from Station_Master where id = '" & gridStation.CurrentRow.Cells("Id").Value.ToString() & "'"
        Dim cmd As New SqlCommand(strsql, con)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Deleted Successfully")
        Clear()
    End Sub

    Private Function ValidateMethod() As Boolean
        Dim flag As Boolean = True

        Dim stationRegex As New Regex("^[a-zA-Z0-9_-]+$")
        If Not stationRegex.IsMatch(txtStationName.Text.Trim()) Then
            MessageBox.Show("Station Name should only only contain letters, numbers, and underscores.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            flag = False
        End If

        If txtStationName.Text = "" Then
            flag = False
            MessageBox.Show("Enter Station Name")
        End If
        Return flag
    End Function
    Private Sub Save()
        If ValidateMethod() Then
            strsql = "insert into Station_Master (StationName) values ('" & txtStationName.Text & "') "
            Dim cmd As New SqlCommand(strsql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()


            MessageBox.Show("Saved Successfully")
            Clear()
        End If
    End Sub

    Private Sub SelectAllStation()
        ds = New DataSet()
        strsql = "select * from Station_Master   "
        Dim cmd As New SqlCommand(strsql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)

        gridStation.DataSource = ds.Tables(0)


    End Sub

    Private Sub frmStationMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If
      
        SelectAllStation()
        Clear()
    End Sub
End Class