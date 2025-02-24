Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft
Imports System.Data.Sql
Public Class frmPrinter

    Dim StrSql As String
    Dim StrRs As SqlDataReader
    Dim Cmd As New SqlCommand
    Dim pid As String
    Dim strpid As String

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If rdbnew.Checked = True Then

            If txtpntname.Text = "" Then
                Err.SetError(txtpntname, "This information is required")
                txtpntname.Focus()
                Exit Sub
            Else
                Err.SetError(txtpntname, "")
            End If
            StrSql = "insert into Printer(Printer_Id,Printer_Name)values('" & pid & "','" & txtpntname.Text & "')"
            Cmd = New SqlCommand(StrSql, con)
            Cmd.ExecuteNonQuery()
            MsgBox("Data Saved Successfully")
            txtpntname.Text = ""
            StrRs.Close()
            Cmd.Dispose()
        Else

            If rdbedit.Checked = True Then
                If cbxpname.Text = "" Then
                    Err.SetError(cbxpname, "This information is required")
                    cbxpname.Focus()
                    Exit Sub
                Else
                    Err.SetError(cbxpname, "")
                End If
                If txtpname.Text = "" Then
                    Err.SetError(txtpname, "This information is required")
                    txtpname.Focus()
                    Exit Sub
                Else
                    Err.SetError(txtpname, "")
                End If

                StrSql = "select Printer_Id from  Printer where Printer_Name='" & cbxpname.Text & "'"
                Cmd = New SqlCommand(StrSql, con)
                StrRs = Cmd.ExecuteReader
                If StrRs.Read Then
                    strpid = StrRs.GetValue(0)
                End If
                StrRs.Close()
                Cmd.Dispose()

                StrSql = "update Printer set Printer_Name='" & txtpname.Text & "' where Printer_Id='" & strpid & "'"
                Cmd = New SqlCommand(StrSql, con)
                Cmd.ExecuteNonQuery()
                Cmd.Dispose()
                MsgBox("Data Saved Successfully")
                txtpname.Text = ""
                cbxpname.Text = ""
                StrRs.Close()
                Cmd.Dispose()
            End If
        End If
        cbxpname.Items.Clear()
        StrSql = "select distinct Printer_Name from Printer"
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        While StrRs.Read
            cbxpname.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        Cmd.Dispose()
    End Sub

    Private Sub frmPrinter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        gbxnew.Visible = False
        gbxedit.Visible = False

        StrSql = "select Max(Printer_ID) from Printer"
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        If StrRs.Read Then
            pid = IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0))

        End If
        pid = pid + 1
        StrRs.Close()
        Cmd.Dispose()

        StrSql = "select distinct Printer_Name from Printer"
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        While StrRs.Read
            cbxpname.Items.Add(IIf(IsDBNull(StrRs.GetValue(0)), "", StrRs.GetValue(0)))
        End While
        StrRs.Close()
        Cmd.Dispose()


    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtpntname.Text = ""
        txtpname.Text = ""
        cbxpname.Text = ""
    End Sub

    Private Sub rdbnew_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbnew.CheckedChanged
        gbxnew.Visible = True
        gbxedit.Visible = False
    End Sub

    Private Sub rdbedit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbedit.CheckedChanged
        gbxedit.Visible = True
        gbxnew.Visible = True
    End Sub
End Class