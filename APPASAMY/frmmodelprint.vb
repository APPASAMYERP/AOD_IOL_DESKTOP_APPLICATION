Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft
Imports System.Data.Sql

Public Class frmmodelprint
    Dim StrSql As String
    Dim StrRs As SqlDataReader
    Dim Cmd As New SqlCommand
    Private Sub frmmodelprint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        StrSql = "select distinct Model_name from LENS_MASTER"
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        While StrRs.Read
            cbxmodel.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        Cmd.Dispose()
        StrSql = "select distinct Printer_name from Printer"
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        While StrRs.Read
            cbxpname.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        Cmd.Dispose()
        
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If cbxmodel.Text = "" Then
            Err.SetError(cbxmodel, "This information is required")
            cbxmodel.Focus()
            Exit Sub
        Else
            Err.SetError(cbxmodel, "")
        End If
        If cbxpname.Text = "" Then
            Err.SetError(cbxpname, "This information is required")
            cbxpname.Focus()
            Exit Sub
        Else
            Err.SetError(cbxpname, "")
        End If
        If txtfilename.Text = "" Then
            Err.SetError(txtfilename, "This information is required")
            txtfilename.Focus()
            Exit Sub
        Else
            Err.SetError(txtfilename, "")
        End If

        StrSql = "insert into Printer_Master(Model_Name,Printer_Name,File_Name)Values('" & cbxmodel.Text & "','" & cbxpname.Text & "','" & txtfilename.Text & "')"
        Cmd = New SqlCommand(StrSql, con)
        Cmd.ExecuteNonQuery()
        MsgBox("Data Saved Successfully")
        cbxmodel.Text = ""
        cbxpname.Text = ""
        txtfilename.Text = ""
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        cbxmodel.Text = ""
        cbxpname.Text = ""
        txtfilename.Text = ""
    End Sub
End Class