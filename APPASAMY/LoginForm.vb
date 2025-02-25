Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Net
Imports System.Security
Imports System.Security.Cryptography
Imports System.Text
Imports System.Runtime.InteropServices



Public Class LoginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Dim getdetail As String
    Dim getdetail1 As String
    Dim cmd As SqlCommand
    Dim cmd1 As SqlCommand
    Dim read As SqlDataReader
    Dim read1 As SqlDataReader
    'Public con As SqlConnection
    'Dim constr As String = "Data Source=shanmugam\sqlexpress;Initial Catalog=APS;User ID=sa;Password=admin@123"
    'Public constr As String = "Data Source=COM610\SQLEXPRESS;Initial Catalog=APS;User ID=sa;Password=admin123"

    ' Define lockout parameters
    Const MaxFailedAttempts As Integer = 3
    Const LockoutDuration As Integer = 10 ' in minutes


    Function AuthenticateUser(ByVal username As String, ByVal password As String) As Boolean

        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If

        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Try

            Dim cmdCheckLockout As New SqlCommand("SELECT FailedAttempts, LockoutTime FROM UserLoginAttempts WHERE Username = @Username", con)
            cmdCheckLockout.Parameters.AddWithValue("@Username", username)

            Dim reader = cmdCheckLockout.ExecuteReader()
            If reader.Read() Then
                Dim failedAttempts As Integer = CInt(reader("FailedAttempts"))
                Dim lockoutTime As DateTime = If(IsDBNull(reader("LockoutTime")), DateTime.MinValue, CDate(reader("LockoutTime")))

                Dim lockoutEndTime As DateTime = lockoutTime.AddMinutes(LockoutDuration)

                If failedAttempts >= MaxFailedAttempts AndAlso lockoutEndTime > DateTime.Now Then
                    MsgBox("Account is locked. Try again after " & lockoutTime.AddMinutes(LockoutDuration))
                    Return False
                End If
            End If
            reader.Close()


            Dim cmdAuth As New SqlCommand("SELECT COUNT(*) FROM Login WHERE Username = @Username AND Password = @Password", con)
            cmdAuth.Parameters.AddWithValue("@Username", username)
            cmdAuth.Parameters.AddWithValue("@Password", password)

            Dim userExists As Integer = CInt(cmdAuth.ExecuteScalar())

            If userExists > 0 Then
                Dim cmdResetAttempts As New SqlCommand("UPDATE UserLoginAttempts SET FailedAttempts = 0, LockoutTime = NULL WHERE Username = @Username", con)
                cmdResetAttempts.Parameters.AddWithValue("@Username", username)
                cmdResetAttempts.ExecuteNonQuery()

                Console.WriteLine("Login successful!")
            Else
                Dim cmdUpdateAttempts As New SqlCommand("" & _
                    "IF EXISTS (SELECT * FROM UserLoginAttempts WHERE Username = @Username) " & _
                    "BEGIN " & _
                        "UPDATE UserLoginAttempts " & _
                        "SET FailedAttempts = FailedAttempts + 1, " & _
                        "LockoutTime = CASE WHEN FailedAttempts + 1 >= @MaxFailedAttempts THEN GETDATE() ELSE LockoutTime END " & _
                        "WHERE Username = @Username " & _
                    "END " & _
                    "ELSE " & _
                    "BEGIN " & _
                        "INSERT INTO UserLoginAttempts (Username, FailedAttempts, LockoutTime) " & _
                        "VALUES (@Username, 1, NULL) " & _
                    "END", con)

                cmdUpdateAttempts.Parameters.AddWithValue("@Username", username)
                cmdUpdateAttempts.Parameters.AddWithValue("@MaxFailedAttempts", MaxFailedAttempts)
                cmdUpdateAttempts.ExecuteNonQuery()

                MsgBox("Invalid username or password.")
                Return False
            End If
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Function SecureStringToString(ByVal secureStr As SecureString) As String
        Dim ptr As IntPtr = IntPtr.Zero
        Try
            ptr = Marshal.SecureStringToBSTR(secureStr)
            Return Marshal.PtrToStringBSTR(ptr)
        Finally
            Marshal.ZeroFreeBSTR(ptr)
        End Try
    End Function

    Public Function HashPassword(ByVal password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hashBytes As Byte() = sha256.ComputeHash(bytes)
            Return Convert.ToBase64String(hashBytes)
        End Using
    End Function

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        


        If cmbStation.SelectedItem Is Nothing Then
            errLogin.SetError(cmbStation, "Please Select valid Station")
            cmbStation.Focus()
            Exit Sub
        Else
            errLogin.SetError(cmbStation, "")
        End If

        If cmbStation.Text = "" Then
            errLogin.SetError(cmbStation, "This information is required")
            Exit Sub
        Else
            errLogin.SetError(cmbStation, "")
        End If

  
    


        Dim password As New SecureString()
        For i As Integer = 0 To txtPassword.Text.Length - 1
            password.AppendChar(txtPassword.Text.Chars(i))
        Next
        password.MakeReadOnly()


        Dim enteredPasswordStr As String = SecureStringToString(password)
        Dim hashedEnteredPassword As String = HashPassword(enteredPasswordStr)


        enteredPasswordStr = New String(" "c, enteredPasswordStr.Length)
        enteredPasswordStr = Nothing


        txtPassword.Text = New String(" "c, txtPassword.Text.Length)
        txtPassword.Clear()
        GC.Collect()
        GC.WaitForPendingFinalizers()

        'KPMG
        If Not AuthenticateUser(txtUsername.Text, hashedEnteredPassword) Then
            Exit Sub
        End If


        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If

        Try
            con.Open()
            productline = cmbProductLine.Text
            station = cmbStation.Text
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


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

            getdetail1 = "SELECT UserName,password FROM LOGIN WHERE USERNAME='" & txtUsername.Text & "' AND PASSWORD='" & hashedEnteredPassword & "'"
            cmd1 = New SqlCommand(getdetail1, con)
            read1 = cmd1.ExecuteReader
            If read1.Read Then
                Create = read1.GetString(0)
                StrLoginUser = read1.GetString(0)


                'password validation

                Dim expectedPassword As String = read1.GetString(1)
                Dim inputPassword As String = hashedEnteredPassword

                If IsValidPassword(inputPassword, expectedPassword) Then
                    Console.WriteLine("Password is valid.")
                Else
                    MsgBox("Password is invalid.")
                    txtPassword.Focus()
                    errLogin.SetError(txtPassword, "")
                    ' MsgBox("Invalid username or password")
                    Exit Sub

                End If


                'Menulblmstdatacre.LblHomeWelcome.Text = "Welcome - " & StrLoginUser
                'Menulblmstdatacre.MenuBtnAdmin.Enabled = True
                'Menulblmstdatacre.MenuBtnMaster.Enabled = True
                'Menulblmstdatacre.MenuBtnProcess.Enabled = True
                'Menulblmstdatacre.MenuBtnReport.Enabled = True
                'Menulblmstdatacre.lblHomeLogin.Text = "Logout"
                'Menulblmstdatacre.TimHomeSideDisply.Start()
                'Menulblmstdatacre.LblHomeMenuDisplyName.Visible = False
                'Me.Close()
                cmd1.Dispose()
                read1.Close()

                ' boxPacking validation updated by sundar-14-08-2023
                If chkIsBoxPacking.Checked = True Then

                    If txtUsername.Text = "" Then
                        errLogin.SetError(txtUsername, "This information is required")
                        txtUsername.Focus()
                        Exit Sub
                    Else
                        errLogin.SetError(txtUsername, "")
                    End If

                    If txtUsername2.Text = "" Then
                        errLogin.SetError(txtUsername2, "This information is required")
                        txtUsername2.Focus()
                        Exit Sub
                    Else
                        errLogin.SetError(txtUsername2, "")
                    End If

                    If txtUsername2.Text.Length <> 8 Then
                        errLogin.SetError(txtUsername2, "This information is Wrong")
                        txtUsername2.Focus()
                        Exit Sub
                    End If

                    getdetail1 = "SELECT * FROM  Reaon_of_Packing WHERE (Printed_By LIKE '%" & txtUsername2.Text & "' OR " & _
                    " Printed_By LIKE '%" & txtUsername.Text & "') AND (Packed_By LIKE '%" & txtUsername2.Text & "' OR " & _
                    "Packed_By LIKE '%" & txtUsername.Text & "') AND (GETDATE() >= DateTimeFrom) AND (GETDATE() <= DateTimeTo) AND (Station = '" & cmbStation.Text & "')"
                    cmd1 = New SqlCommand(getdetail1, con)
                    read1 = cmd1.ExecuteReader
                    If read1.Read Then
                        cmd1.Dispose()
                        read1.Close()
                    Else
                        errLogin.SetError(txtUsername2, "Invalid UserName")
                        txtUsername2.Focus()
                        Exit Sub

                    End If
                    cmd1.Dispose()
                    read1.Close()
                    errLogin.SetError(txtUsername2, "")
                Else

                    getdetail1 = "SELECT UserName FROM LOGIN WHERE USERNAME='" & txtUsername.Text & "' AND PASSWORD='" & hashedEnteredPassword & "' and  Bx_Pking ='0' "
                    cmd1 = New SqlCommand(getdetail1, con)
                    read1 = cmd1.ExecuteReader
                    If read1.Read Then

                        cmd1.Dispose()
                        read1.Close()
                    Else
                        cmd1.Dispose()
                        read1.Close()
                        getdetail = "SELECT UserName FROM LOGIN WHERE USERNAME='" & txtUsername.Text & "' AND PASSWORD='" & hashedEnteredPassword & "' and boxLabelReprint ='1' "
                        cmd = New SqlCommand(getdetail, con)
                        read = cmd.ExecuteReader
                        If read.Read Then
                            read.Close()
                            cmd.Dispose()
                            errLogin.SetError(txtUsername, "")
                            'Else
                            '    cmd1.Dispose()
                            '    read1.Close()
                            '    getdetail = "SELECT UserName FROM LOGIN WHERE USERNAME='" & txtUsername.Text & "' AND PASSWORD='" & txtPassword.Text & "' and Other_sample_scan ='1' "
                            '    cmd = New SqlCommand(getdetail, con)
                            '    read = cmd.ExecuteReader
                            '    If read.Read Then
                            '        read.Close()
                            '        cmd.Dispose()
                            '        errLogin.SetError(txtUsername, "")
                        Else
                            cmd.Dispose()
                            read.Close()
                            getdetail = "SELECT UserName FROM LOGIN WHERE USERNAME='" & txtUsername.Text & "' AND PASSWORD='" & hashedEnteredPassword & "' "
                            cmd = New SqlCommand(getdetail, con)
                            read = cmd.ExecuteReader
                            If read.Read Then
                                IsNotBoxPackUser = 1
                                read.Close()
                                cmd.Dispose()
                                errLogin.SetError(txtUsername, "")
                            Else
                                'MsgBox("Invalid Username")
                                errLogin.SetError(txtUsername, "Invalid Username")
                                txtUsername.Focus()
                                Exit Sub

                            End If


                        End If


                    End If



                End If

                '-----------

                Me.Hide()

                Dim frm As New FrmMain
                frm.Show()

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
    Function IsValidPassword(ByVal inputPassword As String, ByVal expectedPassword As String) As Boolean
        ' Check if the input password matches the expected password exactly (case-sensitive)
        If inputPassword <> expectedPassword Then
            Return False
        Else
            Return True
        End If

        '' Additional checks (length, character types) can be added here if needed
        'If inputPassword.Length < 8 Then
        '    Return False
        'End If

        'Dim hasUpperCase As Boolean = False
        'Dim hasLowerCase As Boolean = False
        'Dim hasDigit As Boolean = False
        'Dim hasSpecialChar As Boolean = False

        'For Each c As Char In inputPassword
        '    If Char.IsUpper(c) Then
        '        hasUpperCase = True
        '    ElseIf Char.IsLower(c) Then
        '        hasLowerCase = True
        '    ElseIf Char.IsDigit(c) Then
        '        hasDigit = True
        '    ElseIf IsSpecialChar(c) Then
        '        hasSpecialChar = True
        '    End If
        'Next

        'Return hasUpperCase And hasLowerCase And hasDigit And hasSpecialChar
    End Function

    Function IsSpecialChar(ByVal c As Char) As Boolean
        Dim specialChars As String = "!@#$%^&*()_+[]{}|;:'"",.<>?/`~"
        Return specialChars.Contains(c)
    End Function





    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub StationBind()

 

        Dim ds As New DataSet()
        Dim strsql As String = "select distinct StationName from StationMaster_With_MachineName WHERE Machine_Name ='" & txt_MachineName.Text & "' "
        Dim cmd As New SqlCommand(strsql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)

        If ds.Tables(0).Rows.Count <> 1 Then
            MsgBox("Station Name not assigned for the Machine name ")
            Exit Sub
        End If


        Dim ds1 As New DataSet()
        Dim strsql1 As String = "select distinct StationName from Station_Master Where StationName ='" & ds.Tables(0).Rows(0)("StationName") & "'  "
        Dim cmd1 As New SqlCommand(strsql1, con)
        Dim ad1 As New SqlDataAdapter(cmd1)
        ad1.Fill(ds1)

      

        cmbStation.DisplayMember = "StationName"
        cmbStation.DataSource = ds1.Tables(0)


    End Sub
    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_MachineName.Text = Dns.GetHostEntry(Dns.GetHostName()).HostName
    End Sub

     


    Private Sub cmbProductLine_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProductLine.SelectedIndexChanged
        cmbStation.Text = ""
        If cmbProductLine.Text = "PMMA" Then
            conString = ConfigurationSettings.AppSettings("conStrPMMA").ToString()
        ElseIf cmbProductLine.Text = "PHILIC" Then
            conString = ConfigurationSettings.AppSettings("conStrPHILIC").ToString()
        ElseIf cmbProductLine.Text = "PHOBIC" Then
            conString = ConfigurationSettings.AppSettings("conStrPHOBIC").ToString()
        ElseIf cmbProductLine.Text = "PHOBIC NONPRELOADED" Then
            conString = ConfigurationSettings.AppSettings("conStrPHOBICNONPRE").ToString()
        ElseIf cmbProductLine.Text = "SUPERPHOB" Then
            conString = ConfigurationSettings.AppSettings("conStrSUPERPHOB").ToString()
        End If

        con = New SqlConnection(conString)
 
        conString = New String(" "c, conString.Length) 
        conString = Nothing
        GC.Collect()
        GC.WaitForPendingFinalizers()
         

        StationBind()
    End Sub

    Private Sub chkIsBoxPacking_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIsBoxPacking.CheckedChanged
        If chkIsBoxPacking.Checked = True Then
            Label3.Visible = True
            txtUsername2.Visible = True

        Else
            Label3.Visible = False
            txtUsername2.Visible = False
        End If
    End Sub

    Private Sub LoginForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        System.Environment.Exit(0)
    End Sub
End Class
