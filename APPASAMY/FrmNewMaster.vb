Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft
Imports System.Data.Sql

Public Class FrmNewMaster

    Private Sub FrmNewMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Cmd As SqlCommand
        Dim StrRs As SqlDataReader
        Dim StrSql As String
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnadd.Click
        Dim Cmd As SqlCommand
        Dim StrRs As SqlDataReader
        Dim StrSql As String
        Dim head As String
        Dim h As String
        If txtBrdName.Text = "" Then
            err.SetError(txtBrdName, "This information is required")
            txtBrdName.Focus()
            Exit Sub
        Else
            err.SetError(txtBrdName, "")
        End If
        If txtmdl.Text = "" Then
            err.SetError(txtmdl, "This information is required")
            txtmdl.Focus()
            Exit Sub
        Else
            err.SetError(txtmdl, "")
        End If

        If txtrefname.Text = "" Then
            err.SetError(txtrefname, "This information is required")
            txtrefname.Focus()
            Exit Sub
        Else
            err.SetError(txtrefname, "")
        End If

        If txtgscode.Text = "" Then
            err.SetError(txtgscode, "This information is required")
            txtgscode.Focus()
            Exit Sub
        Else
            err.SetError(txtgscode, "")
        End If

        If txtpwr.Text = "" Then
            err.SetError(txtpwr, "This information is required")
            txtpwr.Focus()
            Exit Sub
        Else
            err.SetError(txtpwr, "")
        End If
        'If IsNumeric(txtpwr.Text) Then
        '    err.SetError(txtpwr, "")
        'Else
        '    err.SetError(txtpwr, "This information is required")
        '    txtpwr.Focus()
        '    Exit Sub
        'End If

        If txtopt.Text = "" Then
            err.SetError(txtopt, "This information is required")
            txtopt.Focus()
            Exit Sub
        Else
            err.SetError(txtopt, "")
        End If

        If txtlen.Text = "" Then
            err.SetError(txtlen, "This information is required")
            txtlen.Focus()
            Exit Sub
        Else
            err.SetError(txtlen, "")
        End If

        If txtacon.Text = "" Then
            err.SetError(txtacon, "This information is required")
            txtacon.Focus()
            Exit Sub
        Else
            err.SetError(txtacon, "")
        End If

        If cbxtypegscode.Text = "" Then
            err.SetError(cbxtypegscode, "This information is required")
            cbxtypegscode.Focus()
            Exit Sub
        Else
            err.SetError(cbxtypegscode, "")
        End If

        If txtexp.Text = "" Then
            err.SetError(txtexp, "This information is required")
            txtexp.Focus()
            Exit Sub
        Else
            err.SetError(txtexp, "")
        End If
        If IsNumeric(txtpwr.Text) Then
            err.SetError(txtpwr, "")
        Else
            err.SetError(txtpwr, "This information is required")
            txtpwr.Focus()
            MsgBox("ONLY NUMERIC VALUES", MsgBoxStyle.Information)
            Exit Sub
        End If
        If IsNumeric(txtopt.Text) Then
            err.SetError(txtopt, "")
        Else
            err.SetError(txtopt, "This information is required")
            txtopt.Focus()
            MsgBox("ONLY NUMERIC VALUES", MsgBoxStyle.Information)
            Exit Sub
        End If
        If IsNumeric(txtlen.Text) Then
            err.SetError(txtpwr, "")
        Else
            err.SetError(txtlen, "This information is required")
            txtlen.Focus()
            MsgBox("ONLY NUMERIC VALUES", MsgBoxStyle.Information)
            Exit Sub
        End If
        If IsNumeric(txtacon.Text) Then
            err.SetError(txtacon, "")
        Else
            err.SetError(txtacon, "This information is required")
            txtacon.Focus()
            MsgBox("ONLY NUMERIC VALUES", MsgBoxStyle.Information)
            Exit Sub
        End If
        If IsNumeric(txtpwr.Text) Then
            err.SetError(txtexp, "")
        Else
            err.SetError(txtexp, "This information is required")
            txtexp.Focus()
            MsgBox("ONLY NUMERIC VALUES", MsgBoxStyle.Information)
            Exit Sub
        End If




        StrSql = "SELECT max(Header_ID) from LENS_MASTER"
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        If StrRs.Read Then
            h = StrRs.GetValue(0)
        End If
        StrRs.Close()
        head = h + 1


        StrSql = "INSERT INTO LENS_MASTER(Header_ID, Detail_ID, Brand_Name, Model_Name, Reference_Name,GS_Code, Power, Optic, Length, Lot_Unit, A_Constant, Type_GS_Code, Tot_Exp, Created_By,Created_Date, Modified_By, Modified_Date)VALUES('" & head & "','" & head & "','" & txtBrdName.Text & "','" & txtmdl.Text & "','" & txtrefname.Text & "','" & txtgscode.Text & "','" & txtpwr.Text & "','" & txtopt.Text & "','" & txtlen.Text & "','mm','" & txtacon.Text & "','" & cbxtypegscode.Text & "','" & txtexp.Text & "','" & StrLoginUser & "',GETDATE(),'" & StrLoginUser & "',GETDATE())"
        Cmd = New SqlCommand(StrSql, con)
        StrRs = Cmd.ExecuteReader
        MsgBox("SUCCESS FULLY ADDED", MsgBoxStyle.Information)

        'MessageBox.Show("SUCCESSFULLY ADDED")

        StrRs.Close()
        Cmd.Dispose()

        txtBrdName.Text = ""
        txtmdl.Text = ""
        txtrefname.Text = ""
        txtgscode.Text = ""
        txtpwr.Text = ""
        txtopt.Text = ""
        txtlen.Text = ""
        txtacon.Text = ""
        cbxtypegscode.Text = ""
        txtexp.Text = ""
    End Sub


    Private Sub Btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnexit.Click
        Me.Close()
    End Sub

End Class