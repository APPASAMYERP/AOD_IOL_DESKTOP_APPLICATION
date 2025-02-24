Imports System.Data
Imports System.IO
Imports System.Data.SqlClient



Public Class FrmNewLogin

    Dim getdetail As String
    Dim getdetail1 As String
    Dim cmd As SqlCommand
    Dim cmd1 As SqlCommand
    Dim read As SqlDataReader
    Dim read1 As SqlDataReader
    'Public con As SqlConnection
    'Dim constr As String = "Data Source=shanmugam\sqlexpress;Initial Catalog=APS;User ID=sa;Password=admin@123"
    'Public constr As String = "Data Source=COM610\SQLEXPRESS;Initial Catalog=APS;User ID=sa;Password=admin123"

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If

        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Try
            getdetail = "SELECT * FROM LOGIN WHERE USERNAME='" & txtUsername.Text & "' "
            cmd = New SqlCommand(getdetail, con)
            read = cmd.ExecuteReader
            If read.Read Then
            Else
                'MsgBox("Invalid Username")
                errLogin.SetError(txtUsername, "Invaild User Name ")
                txtUsername.Focus()
                Exit Sub
            End If
            read.Close()
            cmd.Dispose()

            errLogin.SetError(txtUsername, "")

            getdetail = "SELECT * FROM LOGIN WHERE USERNAME='" & txtUsername.Text & "' and Active='1' "
            cmd = New SqlCommand(getdetail, con)
            read = cmd.ExecuteReader
            If read.Read Then
            Else
                'MsgBox("Invalid Username")
                errLogin.SetError(txtUsername, "User Is InActive")
                txtUsername.Focus()
                Exit Sub
            End If
            read.Close()
            cmd.Dispose()
            errLogin.SetError(txtUsername, "")

            getdetail1 = "SELECT UserName FROM LOGIN WHERE USERNAME='" & txtUsername.Text & "' AND PASSWORD='" & txtPassword.Text & "'"
            cmd1 = New SqlCommand(getdetail1, con)
            read1 = cmd1.ExecuteReader
            If read1.Read Then
                Create = read1.GetString(0)
                StrLoginUser = read1.GetString(0)
                Menulblmstdatacre.LblHomeWelcome.Text = "Welcome - " & StrLoginUser
                Menulblmstdatacre.MenuBtnAdmin.Enabled = True
                Menulblmstdatacre.MenuBtnMaster.Enabled = True
                Menulblmstdatacre.MenuBtnProcess.Enabled = True
                Menulblmstdatacre.MenuBtnReport.Enabled = True
                Menulblmstdatacre.lblHomeLogin.Text = "Logout"
                Menulblmstdatacre.TimHomeSideDisply.Start()
                Menulblmstdatacre.LblHomeMenuDisplyName.Visible = False
                Me.Close()
                cmd1.Dispose()
                read1.Close()
            Else
                errLogin.SetError(txtPassword, "Invalid Password")
                txtPassword.Focus()
                Exit Sub
                'MsgBox("Invalid Password")
            End If
            cmd1.Dispose()
            read1.Close()
            errLogin.SetError(txtPassword, "")

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        Menulblmstdatacre.LblHomeMenuDisplyName.Visible = False
        Menulblmstdatacre.TimHomeSideDisply.Start()

    End Sub

    Private Sub FrmNewLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUsername.Focus()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class