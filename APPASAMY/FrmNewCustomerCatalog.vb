Imports System.Data
Imports System.Data.SqlClient
Imports System.IO



Public Class FrmNewCustomerCatalog
    Dim StrSql As String
    Dim Cmd As New SqlCommand

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If txtcompanyName.Text = "" Then
            err.SetError(txtcompanyName, "This information is required")
            txtcompanyName.Focus()
            Exit Sub
        Else
            err.SetError(txtcompanyName, "")
        End If

        If txtadd1.Text = "" Then
            err.SetError(txtadd1, "This information is required")
            txtadd1.Focus()
            Exit Sub
        Else
            err.SetError(txtadd1, "")
        End If


        If txtadd2.Text = "" Then
            err.SetError(txtadd2, "This information is required")
            txtadd2.Focus()
            Exit Sub
        Else
            err.SetError(txtadd2, "")
        End If


        If txtlocation.Text = "" Then
            err.SetError(txtlocation, "This information is required")
            txtlocation.Focus()
            Exit Sub
        Else
            err.SetError(txtlocation, "")
        End If


        If txtstate.Text = "" Then
            err.SetError(txtstate, "This information is required")
            txtstate.Focus()
            Exit Sub
        Else
            err.SetError(txtstate, "")
        End If


        If txtcountry.Text = "" Then
            err.SetError(txtcountry, "This information is required")
            txtcountry.Focus()
            Exit Sub
        Else
            err.SetError(txtcountry, "")
        End If


        StrSql = "insert into CUSTOMER_CATALOG( Company_Name,Add_1,Add_2,Location,State,Country,Pincode,Contact_Person,Mobile,Tel_No,E_Mail,Created_By,Created_Date,Modified_By,Modified_Date) values (" & _
                 "'" & txtcompanyName.Text & "','" & txtadd1.Text & "','" & txtadd2.Text & "','" & txtlocation.Text & "','" & txtstate.Text & "','" & txtcountry.Text & "','" & txtpincode.Text & "', " & _
                 "'" & txtcontactperson.Text & "','" & txtmobileno.Text & "','" & txttelno.Text & "','" & txtemailid.Text & "'," & _
                 "'" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE())"
        Cmd = New SqlCommand(StrSql, con)
        Cmd.ExecuteNonQuery()
        Cmd.Dispose()

        MsgBox("Save Sucessfully")
        Clear()

    End Sub


    Private Sub Clear()
        txtcompanyName.Text = ""
        txtadd1.Text = ""
        txtadd2.Text = ""
        txtlocation.Text = ""
        txtstate.Text = ""
        txtcountry.Text = ""
        txtpincode.Text = ""
        txtcontactperson.Text = ""
        txtmobileno.Text = ""
        txttelno.Text = ""
        txtemailid.Text = ""



    End Sub

    Private Sub FrmNewCustomerCatalog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If

        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
        Menulblmstdatacre.LblHomeMenuDisplyName.Visible = False
        Menulblmstdatacre.TimHomeSideDisply.Start()
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        Clear()
    End Sub
End Class