
Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Text.RegularExpressions
Imports System.Security.Cryptography
Imports System.Text




Public Class FrmNewUserCreation
    Dim StrValidate As Integer
    Dim StrSqlChk As String
    Dim StrRsChkAs As SqlDataReader
    Dim Cmd As New SqlCommand
    Dim StrSqlIn As String

    Public Function HashPassword(ByVal password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hashBytes As Byte() = sha256.ComputeHash(bytes)
            Return Convert.ToBase64String(hashBytes)
        End Using
    End Function


    Private Sub check_EmpId_duplicate()

        Dim empId As String = TxtCrEmpId.Text.Trim()

        Dim cmdCheckEmpId As New SqlCommand("SELECT COUNT(*) FROM Login WHERE Emp_ID = @EmpId", con)
        cmdCheckEmpId.Parameters.AddWithValue("@EmpId", empId)

        Dim count As Integer = CInt(cmdCheckEmpId.ExecuteScalar())
        If count > 0 Then
            MessageBox.Show("This Employee ID already exists. Please enter a unique ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

    End Sub

    Private Sub check_Strong_password()

        Dim password As String = txtCrPassword.Text.Trim()
        Dim passwordRegex As New Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$")

        If Not passwordRegex.IsMatch(password) Then
            MessageBox.Show("Password must be at least 8 characters long and include uppercase, lowercase, numeric, and special characters.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

    End Sub

    Private Sub check_invalid_inputs()

        Dim nameRegex As New Regex("^[a-zA-Z\s.]+$")
        If Not nameRegex.IsMatch(txtCrName.Text.Trim()) Then
            MessageBox.Show("Name should only contain alphabets, spaces, and dots.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not nameRegex.IsMatch(txtCrFatName.Text.Trim()) Then
            MessageBox.Show("Father Name should only contain alphabets, spaces, and dots.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim empIdRegex As New Regex("^[a-zA-Z0-9]+$")
        If Not empIdRegex.IsMatch(TxtCrEmpId.Text.Trim()) Then
            MessageBox.Show("Employee ID should only contain alphanumeric characters (letters and digits).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim nameWithNumbersRegex As New Regex("^[a-zA-Z0-9_]+$")
        If Not nameWithNumbersRegex.IsMatch(txtcruserName.Text.Trim()) Then
            MessageBox.Show("UserName should only contain letters, numbers, and underscores.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        '
        If txtCrName.Text = "" Then
            Err.SetError(txtCrName, "This information is required")
            txtCrName.Focus()
            Exit Sub
        Else
            Err.SetError(txtCrName, "")
        End If

        If TxtCrEmpId.Text = "" Then
            Err.SetError(TxtCrEmpId, "This information is required")
            TxtCrEmpId.Focus()
            Exit Sub
        Else
            Err.SetError(TxtCrEmpId, "")
        End If



        If txtCrFatName.Text = "" Then
            Err.SetError(txtCrFatName, "This information is required")
            txtCrFatName.Focus()
            Exit Sub
        Else
            Err.SetError(txtCrFatName, "")
        End If


        If CmbCrSex.Text = "" Then
            Err.SetError(CmbCrSex, "This information is required")
            CmbCrSex.Focus()
            Exit Sub
        Else
            Err.SetError(CmbCrSex, "")
        End If

        If CmbCrDepart.Text = "" Then
            Err.SetError(CmbCrDepart, "This information is required")
            CmbCrDepart.Focus()
            Exit Sub
        Else
            Err.SetError(CmbCrDepart, "")
        End If

        If CmbCrPosition.Text = "" Then
            Err.SetError(CmbCrPosition, "This information is required")
            CmbCrPosition.Focus()
            Exit Sub
        Else
            Err.SetError(CmbCrPosition, "")
        End If

        If txtcruserName.Text = "" Then
            Err.SetError(txtcruserName, "This information is required")
            txtcruserName.Focus()
            Exit Sub
        Else
            Err.SetError(txtcruserName, "")
        End If

        If txtCrPassword.Text = "" Then
            Err.SetError(txtCrPassword, "This information is required")
            txtCrPassword.Focus()
            Exit Sub
        Else
            Err.SetError(txtCrPassword, "")
        End If


        If txtcrReTypePassword.Text = "" Then
            Err.SetError(txtcrReTypePassword, "This information is required")
            txtcrReTypePassword.Focus()
            Exit Sub
        Else
            Err.SetError(txtcrReTypePassword, "")
        End If

        If Chk_boxLabelReprint.Checked = True Then
            If cmbReprintUserLevel.Text = "" Then
                Err.SetError(cmbReprintUserLevel, "This information is required")
                cmbReprintUserLevel.Focus()
                Exit Sub
            Else
                Err.SetError(cmbReprintUserLevel, "")
            End If
        End If

        If Chk_Pwr_Lbl.Checked = False And Chk_Pouch_Lbl.Checked = False And Chk_Pch_lbl_Reprint.Checked = False And Chk_inject_lbl.Checked = False And Chk_Ster.Checked = False And Chk_Ster_release.Checked = False And Chk_ster_batch_update.Checked = False And Chk_Other_sample_scan.Checked = False And Chk_Bx_Pking_Lst.Checked = False And Chk_Bx_Pking.Checked = False And Chk_Bx_Ins.Checked = False And Chk_areation.Checked = False And Chk_Rack_Label_Print.Checked = False And Chk_Turkey_gs_lbl.Checked = False And Chk_Bpl_Report.Checked = False And Chk_bx_annexure.Checked = False And Chk_Pouch_Pkg_Report.Checked = False And Chk_lotsheet_report.Checked = False And Chk_ster_Ck_Report.Checked = False And Chk_prn_report.Checked = False And Chk_Lens_Tracking_Report.Checked = False And Chk_boxLabelReprint.Checked = False And Chk_Bx_pack_to_Des.Checked = False And Chk_Mts_report.Checked = False And Chk_Shrink_Warp_Rej.Checked = False And Chk_CST_SST_Report.Checked = False And chk_MMS_Report_Pouch.Checked = False Then

            Err.SetError(GroupBox3, "This information is required")
            GroupBox3.Focus()
            Exit Sub
        Else
            Err.SetError(GroupBox3, "")
        End If


        'KPMG Validations

        'Employee_id duplicate check
        Dim empId As String = TxtCrEmpId.Text.Trim()

        Dim cmdCheckEmpId As New SqlCommand("SELECT COUNT(*) FROM Login WHERE Emp_ID = @EmpId", con)
        cmdCheckEmpId.Parameters.AddWithValue("@EmpId", empId)

        Dim count As Integer = CInt(cmdCheckEmpId.ExecuteScalar())
        If count > 0 Then
            MessageBox.Show("This Employee ID already exists. Please enter a unique ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'check strong password
        Dim password As String = txtCrPassword.Text.Trim()
        Dim passwordRegex As New Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&#])[A-Za-z\d@$!%*?&#]{8,}$")

        If Not passwordRegex.IsMatch(password) Then
            MessageBox.Show("Password must be at least 8 characters long and include uppercase, lowercase, numeric, and special characters.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'check invalid inputs
        Dim nameRegex As New Regex("^[a-zA-Z\s.]+$")
        If Not nameRegex.IsMatch(txtCrName.Text.Trim()) Then
            MessageBox.Show("Name should only contain alphabets, spaces, and dots.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not nameRegex.IsMatch(txtCrFatName.Text.Trim()) Then
            MessageBox.Show("Father Name should only contain alphabets, spaces, and dots.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim empIdRegex As New Regex("^[a-zA-Z0-9]+$")
        If Not empIdRegex.IsMatch(TxtCrEmpId.Text.Trim()) Then
            MessageBox.Show("Employee ID should only contain alphanumeric characters (letters and digits).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim nameWithNumbersRegex As New Regex("^[a-zA-Z0-9_]+$")
        If Not nameWithNumbersRegex.IsMatch(txtcruserName.Text.Trim()) Then
            MessageBox.Show("UserName should only contain letters, numbers, and underscores.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If CmbCrSex.SelectedItem Is Nothing Then
            MsgBox(" Please select valid Sex")
            CmbCrSex.Text = ""
            CmbCrSex.Focus()
            Exit Sub
        End If

        If CmbCrDepart.SelectedItem Is Nothing Then
            MsgBox(" Please select valid Position")
            CmbCrDepart.Text = ""
            CmbCrDepart.Focus()
            Exit Sub
        End If

        If CmbCrPosition.SelectedItem Is Nothing Then
            MsgBox(" Please select valid Position")
            CmbCrPosition.Text = ""
            CmbCrPosition.Focus()
            Exit Sub
        End If

        'KPMG Validations


        If txtcruserName.Text <> "" Then
            StrSqlChk = "select * from LoGIN where UserName='" & txtcruserName.Text & "'"
            Cmd = New SqlCommand(StrSqlChk, con)
            StrRsChkAs = Cmd.ExecuteReader

            If StrRsChkAs.Read Then
                Err.SetError(txtcruserName, "")
                ErrOk.SetError(txtcruserName, "")
                ErrWarning.SetError(txtcruserName, "This ID is not available")
                LblWarningMsg.Text = "This ID is not available"
                LblWarningMsg.Top = txtcruserName.Top + 5
                LblWarningMsg.Left = txtcruserName.Left + txtcruserName.Width + 20
                LblWarningMsg.Visible = True
                txtcruserName.Focus()
                StrRsChkAs.Close()
                Cmd.Dispose()
                Exit Sub
            Else
                ErrWarning.SetError(txtcruserName, "")
                ErrOk.SetError(txtcruserName, "This ID is available")
                Err.SetError(txtcruserName, "")
                LblWarningMsg.Text = "This ID is  available"
                LblWarningMsg.Top = txtcruserName.Top + 5
                LblWarningMsg.Left = txtcruserName.Left + txtcruserName.Width + 20
                LblWarningMsg.Visible = True
            End If
        End If

        StrRsChkAs.Close()
        Cmd.Dispose()
        If txtCrPassword.Text <> txtcrReTypePassword.Text Then

            ErrWarning.SetError(txtcrReTypePassword, "")
            ErrOk.SetError(txtcrReTypePassword, "")
            Err.SetError(txtcrReTypePassword, "The passwords you entered do not match.Please try again.")
            LblWarningMsg.Text = "The passwords you entered do not match." & vbCrLf & "Please try again."
            LblWarningMsg.Top = txtcrReTypePassword.Top + 5
            LblWarningMsg.Left = txtcrReTypePassword.Left + txtcrReTypePassword.Width + 20
            LblWarningMsg.Visible = True
            txtcrReTypePassword.Focus()
            Exit Sub
        End If



        Dim chk_Active As Integer
        Dim admin As Integer

        Dim Pwr_Lbl, Pouch_Lbl, Pch_lbl_Reprint, inject_lbl, Ster, Ster_release As Integer
        Dim ster_batch_update, Other_sample_scan, Bx_Pking_Lst, Bx_Pking, Bx_Ins, areation As Integer
        Dim Rack_Label_Print, Turkey_gs_lbl, Bpl_Report, bx_annexure, lotsheet_report, ster_Ck_Report As Integer
        Dim prn_report, Lens_Tracking_Report, boxLabelReprint, Bx_pack_to_Des, Mts_report, Pouch_Pkg_Report, CST_SST_Report, MMS_Report_Ster As Integer
        Dim BoxreprintUserLevel, Shrink_Warp_Rej, MMS_Report_Pouch As String


        If chkActive.Checked = True Then
            chk_Active = 1
        Else
            chk_Active = 0
        End If

        If chkAdmin.Checked = True Then
            admin = 1
        Else
            admin = 0
        End If

        If Chk_Pwr_Lbl.Checked Then
            Pwr_Lbl = 1
        Else
            Pwr_Lbl = 0
        End If

        If Chk_Pouch_Lbl.Checked Then
            Pouch_Lbl = 1
        Else
            Pouch_Lbl = 0
        End If

        If Chk_Pch_lbl_Reprint.Checked Then
            Pch_lbl_Reprint = 1
        Else
            Pch_lbl_Reprint = 0
        End If

        If Chk_inject_lbl.Checked Then
            inject_lbl = 1
        Else
            inject_lbl = 0
        End If

        If Chk_Ster.Checked Then
            Ster = 1
        Else
            Ster = 0
        End If

        If Chk_Ster_release.Checked Then
            Ster_release = 1
        Else
            Ster_release = 0
        End If

        If Chk_ster_batch_update.Checked Then
            ster_batch_update = 1
        Else
            ster_batch_update = 0
        End If

        If Chk_Other_sample_scan.Checked Then
            Other_sample_scan = 1
        Else
            Other_sample_scan = 0
        End If

        If Chk_Bx_Pking_Lst.Checked Then
            Bx_Pking_Lst = 1
        Else
            Bx_Pking_Lst = 0
        End If

        If Chk_Bx_Pking.Checked Then
            Bx_Pking = 1
        Else
            Bx_Pking = 0
        End If

        If Chk_Bx_Ins.Checked Then
            Bx_Ins = 1
        Else
            Bx_Ins = 0
        End If

        If Chk_areation.Checked Then
            areation = 1
        Else
            areation = 0
        End If

        If Chk_Rack_Label_Print.Checked Then
            Rack_Label_Print = 1
        Else
            Rack_Label_Print = 0
        End If

        If Chk_Turkey_gs_lbl.Checked Then
            Turkey_gs_lbl = 1
        Else
            Turkey_gs_lbl = 0
        End If

        If Chk_Bpl_Report.Checked Then
            Bpl_Report = 1
        Else
            Bpl_Report = 0
        End If

        If Chk_bx_annexure.Checked Then
            bx_annexure = 1
        Else
            bx_annexure = 0
        End If

        If Chk_lotsheet_report.Checked Then
            lotsheet_report = 1
        Else
            lotsheet_report = 0
        End If

        If Chk_ster_Ck_Report.Checked Then
            ster_Ck_Report = 1
        Else
            ster_Ck_Report = 0
        End If

        If Chk_prn_report.Checked Then
            prn_report = 1
        Else
            prn_report = 0
        End If

        If Chk_Lens_Tracking_Report.Checked Then
            Lens_Tracking_Report = 1
        Else
            Lens_Tracking_Report = 0
        End If

        If Chk_boxLabelReprint.Checked Then
            boxLabelReprint = 1

        Else
            boxLabelReprint = 0
        End If

        If Chk_Bx_pack_to_Des.Checked Then
            Bx_pack_to_Des = 1
        Else
            Bx_pack_to_Des = 0
        End If

        If Chk_Mts_report.Checked Then
            Mts_report = 1
        Else
            Mts_report = 0
        End If

        If Chk_Pouch_Pkg_Report.Checked = True Then
            Pouch_Pkg_Report = 1
        Else
            Pouch_Pkg_Report = 0
        End If
        If Chk_CST_SST_Report.Checked = True Then
            CST_SST_Report = 1
        Else
            CST_SST_Report = 0
        End If

        If chk_MMS_Report_Ster.Checked = True Then
            MMS_Report_Ster = 1
        Else
            MMS_Report_Ster = 0
        End If

        If Chk_Shrink_Warp_Rej.Checked = True Then
            Shrink_Warp_Rej = 1
        Else
            Shrink_Warp_Rej = 0
        End If

        If chk_MMS_Report_Pouch.Checked = True Then
            MMS_Report_Pouch = 1
        Else
            MMS_Report_Pouch = 0
        End If

        'StrSqlIn = " INSERT INTO LOGIN(Emp_Name, Emp_ID, Emp_Father_Name, Emp_Sex, Emp_Dept, Emp_Positions, UserName, Password, Active, Created_By, Created_Date, Modified_By,Modified_Date, Admin, )" & _
        '        "VALUES('" & txtCrName.Text & "','" & TxtCrEmpId.Text & "','" & txtCrFatName.Text & "','" & CmbCrSex.Text & "','" & CmbCrDepart.Text & "','" & CmbCrPosition.Text & "','" & txtcruserName.Text & "','" & txtCrPassword.Text & "','" & chk_Active & "','" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),'" & admin & "'" & _
        '        " )"


        If Chk_boxLabelReprint.Checked = True Then
            BoxreprintUserLevel = cmbReprintUserLevel.Text
        Else
            BoxreprintUserLevel = "NULL"
        End If


        Dim plainTextPassword As String = txtCrPassword.Text
        Dim hashedPassword As String = HashPassword(plainTextPassword)

        StrSqlIn = "INSERT INTO LOGIN(Emp_Name, Emp_ID, Emp_Father_Name, Emp_Sex, Emp_Dept, Emp_Positions, UserName, " & _
                    "Password, Active, Created_By, Created_Date, Modified_By, Modified_Date, Admin, Pwr_Lbl, Pouch_Lbl, " & _
                    "Pch_lbl_Reprint, inject_lbl, Ster, Ster_release, ster_batch_update, Other_sample_scan, Bx_Pking_Lst, " & _
                    "Bx_Pking, Bx_Ins, areation, Rack_Label_Print, Turkey_gs_lbl, Bpl_Report, bx_annexure, lotsheet_report, " & _
                    "ster_Ck_Report, prn_report, Lens_Tracking_Report, boxLabelReprint, Bx_pack_to_Des,Mts_report,Pouch_Pkg_Report, " & _
                    " CST_SST_Report,MMS_Report_Ster,Reprint_User_Level,Shrink_Warp_Rej,MMS_Report_Pouch ) " & _
                "VALUES('" & txtCrName.Text & "','" & TxtCrEmpId.Text & "','" & txtCrFatName.Text & "','" & CmbCrSex.Text & "','" & CmbCrDepart.Text & "','" & CmbCrPosition.Text & "','" & txtcruserName.Text & "','" & hashedPassword & "','" & chk_Active & "','" & StrLoginUser & "',GETDATE(), '" & StrLoginUser & "',GETDATE(),'" & admin & "'," & _
                Pwr_Lbl & "," & Pouch_Lbl & "," & Pch_lbl_Reprint & "," & inject_lbl & "," & Ster & "," & Ster_release & "," & ster_batch_update & "," & Other_sample_scan & "," & Bx_Pking_Lst & "," & Bx_Pking & "," & Bx_Ins & "," & areation & "," & Rack_Label_Print & "," & Turkey_gs_lbl & "," & Bpl_Report & "," & bx_annexure & "," & lotsheet_report & "," & ster_Ck_Report & "," & prn_report & "," & Lens_Tracking_Report & "," & boxLabelReprint & "," & Bx_pack_to_Des & "," & Mts_report & "," & _
                " " & Pouch_Pkg_Report & "," & CST_SST_Report & "," & MMS_Report_Ster & ",'" & BoxreprintUserLevel & "','" & Shrink_Warp_Rej & "','" & MMS_Report_Pouch & "' )"



        Cmd = New SqlCommand(StrSqlIn, con)
        Cmd.ExecuteNonQuery()

        MsgBox("Save Sucessfully", MsgBoxStyle.Information)

        Clear()
        loadUserLoginBind()

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Clear()

        txtCrName.Text = ""
        TxtCrEmpId.Text = ""
        txtCrFatName.Text = ""
        CmbCrDepart.Text = ""
        CmbCrPosition.Text = ""
        CmbCrSex.Text = ""
        txtcruserName.Text = ""
        txtCrPassword.Text = ""
        txtcrReTypePassword.Text = ""
        ErrOk.SetError(txtcruserName, "")

        chkAdmin.Checked = False
        Button1.Visible = True
        btnUpdate.Visible = False
        txtcruserName.Enabled = True

        Chk_Pwr_Lbl.Checked = False
        Chk_Pouch_Lbl.Checked = False
        Chk_Pch_lbl_Reprint.Checked = False
        Chk_inject_lbl.Checked = False
        Chk_Ster.Checked = False
        Chk_Ster_release.Checked = False
        Chk_ster_batch_update.Checked = False
        Chk_Other_sample_scan.Checked = False
        Chk_Bx_Pking_Lst.Checked = False
        Chk_Bx_Pking.Checked = False
        Chk_Bx_Ins.Checked = False
        Chk_areation.Checked = False
        Chk_Rack_Label_Print.Checked = False
        Chk_Turkey_gs_lbl.Checked = False
        Chk_Bpl_Report.Checked = False
        Chk_bx_annexure.Checked = False
        Chk_lotsheet_report.Checked = False
        Chk_ster_Ck_Report.Checked = False
        Chk_prn_report.Checked = False
        Chk_Lens_Tracking_Report.Checked = False
        Chk_boxLabelReprint.Checked = False
        Chk_Bx_pack_to_Des.Checked = False
        Chk_Mts_report.Checked = False
        Chk_Shrink_Warp_Rej.Checked = False
        Chk_CST_SST_Report.Checked = False
        chk_MMS_Report_Ster.Checked = False
        Chk_Shrink_Warp_Rej.Checked = False
        chk_MMS_Report_Pouch.Checked = False




    End Sub

    Private Sub loadUserLoginBind()
        Dim Cmd As New SqlCommand
        Dim sql As String
        Dim ds As New DataSet
        Dim ad As New SqlDataAdapter
        sql = "select * from Login Order by Emp_Name"
        Cmd = New SqlCommand(sql, con)
        ad = New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)


    End Sub
    Private Sub FrmNewUserCreation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        LblWarningMsg.Visible = False
        'Dim constr As String = "Data Source=COM610\SQLEXPRESS;Initial Catalog=APS;User ID=sa;Password=admin123"
        'Dim con As New Global.System.Data.SqlClient.SqlConnection(constr)

        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If

        Try
            con.Open()

            loadUserLoginBind()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub txtcruserName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcruserName.LostFocus

        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If

        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If txtcruserName.Text <> "" Then
            StrSqlChk = "select * from LoGIN where UserName='" & txtcruserName.Text & "'"
            Cmd = New SqlCommand(StrSqlChk, con)
            StrRsChkAs = Cmd.ExecuteReader

            If StrRsChkAs.Read Then
                Err.SetError(txtcruserName, "")
                ErrOk.SetError(txtcruserName, "")
                ErrWarning.SetError(txtcruserName, "This ID is not available")
                LblWarningMsg.Text = "This ID is not available"
                LblWarningMsg.Top = txtcruserName.Top + 5
                LblWarningMsg.Left = txtcruserName.Left + txtcruserName.Width + 20
                LblWarningMsg.Visible = True
            Else
                ErrWarning.SetError(txtcruserName, "")
                ErrOk.SetError(txtcruserName, "This ID is available")
                Err.SetError(txtcruserName, "")
                LblWarningMsg.Text = "This ID is  available"
                LblWarningMsg.Top = txtcruserName.Top + 5
                LblWarningMsg.Left = txtcruserName.Left + txtcruserName.Width + 20
                LblWarningMsg.Visible = True
            End If
            StrRsChkAs.Close()
            Cmd.Dispose()
        End If
    End Sub


    Private Sub txtcruserName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcruserName.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        'Home.LblHomeMenuDisplyName.Visible = False
        'Home.TimHomeSideDisply.Start()
    End Sub

    Private Sub txtcrReTypePassword_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcrReTypePassword.LostFocus
        If txtCrPassword.Text <> txtcrReTypePassword.Text Then

            ErrWarning.SetError(txtcrReTypePassword, "")
            ErrOk.SetError(txtcrReTypePassword, "")
            Err.SetError(txtcrReTypePassword, "The passwords you entered do not match. Please try again.")
            LblWarningMsg.Text = "The passwords you entered do not match." & vbCrLf & "Please try again."
            LblWarningMsg.Top = txtcrReTypePassword.Top + 5
            LblWarningMsg.Left = txtcrReTypePassword.Left + txtcrReTypePassword.Width + 20
            LblWarningMsg.Visible = True

        End If
    End Sub



    Private Sub txtcrReTypePassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcrReTypePassword.TextChanged

    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        Clear()
    End Sub

    Private Sub chbxbpk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click


        If txtCrName.Text = "" Then
            Err.SetError(txtCrName, "This information is required")
            txtCrName.Focus()
            Exit Sub
        Else
            Err.SetError(txtCrName, "")
        End If

        If TxtCrEmpId.Text = "" Then
            Err.SetError(TxtCrEmpId, "This information is required")
            TxtCrEmpId.Focus()
            Exit Sub
        Else
            Err.SetError(TxtCrEmpId, "")
        End If



        If txtCrFatName.Text = "" Then
            Err.SetError(txtCrFatName, "This information is required")
            txtCrFatName.Focus()
            Exit Sub
        Else
            Err.SetError(txtCrFatName, "")
        End If


        If CmbCrSex.Text = "" Then
            Err.SetError(CmbCrSex, "This information is required")
            CmbCrSex.Focus()
            Exit Sub
        Else
            Err.SetError(CmbCrSex, "")
        End If

        If CmbCrDepart.Text = "" Then
            Err.SetError(CmbCrDepart, "This information is required")
            CmbCrDepart.Focus()
            Exit Sub
        Else
            Err.SetError(CmbCrDepart, "")
        End If

        If CmbCrPosition.Text = "" Then
            Err.SetError(CmbCrPosition, "This information is required")
            CmbCrPosition.Focus()
            Exit Sub
        Else
            Err.SetError(CmbCrPosition, "")
        End If

        If txtcruserName.Text = "" Then
            Err.SetError(txtcruserName, "This information is required")
            txtcruserName.Focus()
            Exit Sub
        Else
            Err.SetError(txtcruserName, "")
        End If

        If txtCrPassword.Text = "" Then
            Err.SetError(txtCrPassword, "This information is required")
            txtCrPassword.Focus()
            Exit Sub
        Else
            Err.SetError(txtCrPassword, "")
        End If


        If txtcrReTypePassword.Text = "" Then
            Err.SetError(txtcrReTypePassword, "This information is required")
            txtcrReTypePassword.Focus()
            Exit Sub
        Else
            Err.SetError(txtcrReTypePassword, "")
        End If

        If Chk_Pwr_Lbl.Checked = False And Chk_Pouch_Lbl.Checked = False And Chk_Pch_lbl_Reprint.Checked = False And Chk_inject_lbl.Checked = False And Chk_Ster.Checked = False And Chk_Ster_release.Checked = False And Chk_ster_batch_update.Checked = False And Chk_Other_sample_scan.Checked = False And Chk_Bx_Pking_Lst.Checked = False And Chk_Bx_Pking.Checked = False And Chk_Bx_Ins.Checked = False And Chk_areation.Checked = False And Chk_Rack_Label_Print.Checked = False And Chk_Turkey_gs_lbl.Checked = False And Chk_Bpl_Report.Checked = False And Chk_bx_annexure.Checked = False And Chk_lotsheet_report.Checked = False And Chk_ster_Ck_Report.Checked = False And Chk_prn_report.Checked = False And Chk_Lens_Tracking_Report.Checked = False And Chk_boxLabelReprint.Checked = False And Chk_Bx_pack_to_Des.Checked = False And Chk_Mts_report.Checked = False And Chk_Shrink_Warp_Rej.Checked = False And Chk_CST_SST_Report.Checked = False And Chk_Pouch_Pkg_Report.Checked = False And Chk_Shrink_Warp_Rej.Checked = False And chk_MMS_Report_Pouch.Checked = False Then

            Err.SetError(GroupBox3, "This information is required")
            GroupBox3.Focus()
            Exit Sub
        Else
            Err.SetError(GroupBox3, "")
        End If

        If Chk_boxLabelReprint.Checked = True Then
            If cmbReprintUserLevel.Text = "" Then
                Err.SetError(cmbReprintUserLevel, "This information is required")
                cmbReprintUserLevel.Focus()
                Exit Sub
            Else
                Err.SetError(cmbReprintUserLevel, "")
            End If
        End If

        If txtCrPassword.Text <> txtcrReTypePassword.Text Then

            ErrWarning.SetError(txtcrReTypePassword, "")
            ErrOk.SetError(txtcrReTypePassword, "")
            Err.SetError(txtcrReTypePassword, "The passwords you entered do not match.Please try again.")
            LblWarningMsg.Text = "The passwords you entered do not match." & vbCrLf & "Please try again."
            LblWarningMsg.Top = txtcrReTypePassword.Top + 5
            LblWarningMsg.Left = txtcrReTypePassword.Left + txtcrReTypePassword.Width + 20
            LblWarningMsg.Visible = True
            txtcrReTypePassword.Focus()
            Exit Sub
        End If



        'KPMG Validations

        'Employee_id duplicate check
        Dim empId As String = TxtCrEmpId.Text.Trim()

        Dim cmdCheckEmpId As New SqlCommand("SELECT COUNT(*) FROM Login WHERE Emp_ID = @EmpId and Username != @Username ", con)
        cmdCheckEmpId.Parameters.AddWithValue("@EmpId", empId)
        cmdCheckEmpId.Parameters.AddWithValue("@Username", txtcruserName.Text.Trim())

        Dim count As Integer = CInt(cmdCheckEmpId.ExecuteScalar())
        If count > 0 Then
            MessageBox.Show("This Employee ID already exists. Please enter a unique ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'check strong password
        Dim password As String = txtCrPassword.Text.Trim()
        Dim passwordRegex As New Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&#])[A-Za-z\d@$!%*?&#]{8,}$")

        If Not passwordRegex.IsMatch(password) Then
            MessageBox.Show("Password must be at least 8 characters long and include uppercase, lowercase, numeric, and special characters.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'check invalid inputs
        Dim nameRegex As New Regex("^[a-zA-Z\s.]+$")
        If Not nameRegex.IsMatch(txtCrName.Text.Trim()) Then
            MessageBox.Show("Name should only contain alphabets, spaces, and dots.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not nameRegex.IsMatch(txtCrFatName.Text.Trim()) Then
            MessageBox.Show("Father Name should only contain alphabets, spaces, and dots.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim empIdRegex As New Regex("^[a-zA-Z0-9]+$")
        If Not empIdRegex.IsMatch(TxtCrEmpId.Text.Trim()) Then
            MessageBox.Show("Employee ID should only contain alphanumeric characters (letters and digits).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim nameWithNumbersRegex As New Regex("^[a-zA-Z0-9_]+$")
        If Not nameWithNumbersRegex.IsMatch(txtcruserName.Text.Trim()) Then
            MessageBox.Show("UserName should only contain letters, numbers, and underscores.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        If CmbCrSex.SelectedItem Is Nothing Then
            MsgBox(" Please select valid Sex")
            CmbCrSex.Text = ""
            CmbCrSex.Focus()
            Exit Sub
        End If

        If CmbCrDepart.SelectedItem Is Nothing Then
            MsgBox(" Please select valid Position")
            CmbCrDepart.Text = ""
            CmbCrDepart.Focus()
            Exit Sub
        End If

        If CmbCrPosition.SelectedItem Is Nothing Then
            MsgBox(" Please select valid Position")
            CmbCrPosition.Text = ""
            CmbCrPosition.Focus()
            Exit Sub
        End If

        'KPMG Validations


        Dim chk_Active As Integer
        Dim admin As Integer

        Dim Pwr_Lbl, Pouch_Lbl, Pch_lbl_Reprint, inject_lbl, Ster, Ster_release As Integer
        Dim ster_batch_update, Other_sample_scan, Bx_Pking_Lst, Bx_Pking, Bx_Ins, areation As Integer
        Dim Rack_Label_Print, Turkey_gs_lbl, Bpl_Report, bx_annexure, lotsheet_report, ster_Ck_Report As Integer
        Dim prn_report, Lens_Tracking_Report, boxLabelReprint, Bx_pack_to_Des, Mts_report, Pouch_Pkg_Report, CST_SST_Report, MMS_Report_Ster As Integer
        Dim BoxreprintUserLevel, Shrink_Warp_Rej, MMS_Report_Pouch As String

        If chkActive.Checked = True Then
            chk_Active = 1
        Else
            chk_Active = 0
        End If

        If chkAdmin.Checked = True Then
            admin = 1
        Else
            admin = 0
        End If


        If Chk_Pwr_Lbl.Checked Then
            Pwr_Lbl = 1
        Else
            Pwr_Lbl = 0
        End If

        If Chk_Pouch_Lbl.Checked Then
            Pouch_Lbl = 1
        Else
            Pouch_Lbl = 0
        End If

        If Chk_Pch_lbl_Reprint.Checked Then
            Pch_lbl_Reprint = 1
        Else
            Pch_lbl_Reprint = 0
        End If

        If Chk_inject_lbl.Checked Then
            inject_lbl = 1
        Else
            inject_lbl = 0
        End If

        If Chk_Ster.Checked Then
            Ster = 1
        Else
            Ster = 0
        End If

        If Chk_Ster_release.Checked Then
            Ster_release = 1
        Else
            Ster_release = 0
        End If

        If Chk_ster_batch_update.Checked Then
            ster_batch_update = 1
        Else
            ster_batch_update = 0
        End If

        If Chk_Other_sample_scan.Checked Then
            Other_sample_scan = 1
        Else
            Other_sample_scan = 0
        End If

        If Chk_Bx_Pking_Lst.Checked Then
            Bx_Pking_Lst = 1
        Else
            Bx_Pking_Lst = 0
        End If

        If Chk_Bx_Pking.Checked Then
            Bx_Pking = 1
        Else
            Bx_Pking = 0
        End If

        If Chk_Bx_Ins.Checked Then
            Bx_Ins = 1
        Else
            Bx_Ins = 0
        End If

        If Chk_areation.Checked Then
            areation = 1
        Else
            areation = 0
        End If

        If Chk_Rack_Label_Print.Checked Then
            Rack_Label_Print = 1
        Else
            Rack_Label_Print = 0
        End If

        If Chk_Turkey_gs_lbl.Checked Then
            Turkey_gs_lbl = 1
        Else
            Turkey_gs_lbl = 0
        End If

        If Chk_Bpl_Report.Checked Then
            Bpl_Report = 1
        Else
            Bpl_Report = 0
        End If

        If Chk_bx_annexure.Checked Then
            bx_annexure = 1
        Else
            bx_annexure = 0
        End If

        If Chk_lotsheet_report.Checked Then
            lotsheet_report = 1
        Else
            lotsheet_report = 0
        End If

        If Chk_ster_Ck_Report.Checked Then
            ster_Ck_Report = 1
        Else
            ster_Ck_Report = 0
        End If

        If Chk_prn_report.Checked Then
            prn_report = 1
        Else
            prn_report = 0
        End If

        If Chk_Lens_Tracking_Report.Checked Then
            Lens_Tracking_Report = 1
        Else
            Lens_Tracking_Report = 0
        End If


        If Chk_boxLabelReprint.Checked Then
            boxLabelReprint = 1
        Else
            boxLabelReprint = 0
        End If

        If Chk_Bx_pack_to_Des.Checked Then
            Bx_pack_to_Des = 1
        Else
            Bx_pack_to_Des = 0
        End If

        If Chk_Mts_report.Checked Then
            Mts_report = 1
        Else
            Mts_report = 0
        End If


        If Chk_Pouch_Pkg_Report.Checked = True Then
            Pouch_Pkg_Report = 1
        Else
            Pouch_Pkg_Report = 0
        End If
        If Chk_CST_SST_Report.Checked = True Then
            CST_SST_Report = 1
        Else
            CST_SST_Report = 0
        End If
        If chk_MMS_Report_Ster.Checked = True Then
            MMS_Report_Ster = 1
        Else
            MMS_Report_Ster = 0
        End If
        If Chk_Shrink_Warp_Rej.Checked = True Then
            Shrink_Warp_Rej = 1
        Else
            Shrink_Warp_Rej = 0
        End If

        If chk_MMS_Report_Pouch.Checked = True Then
            MMS_Report_Pouch = 1
        Else
            MMS_Report_Pouch = 0
        End If

        If Chk_boxLabelReprint.Checked = True Then
            BoxreprintUserLevel = cmbReprintUserLevel.Text
        Else
            BoxreprintUserLevel = "NULL"
        End If

        StrLoginUser = StrLoginUser

        Dim plainTextPassword As String = txtCrPassword.Text
        Dim hashedPassword As String = HashPassword(plainTextPassword)

        StrSqlIn = "UPDATE LOGIN SET " & _
                "Emp_Name = '" & txtCrName.Text & "', " & _
                "Emp_ID = '" & TxtCrEmpId.Text & "', " & _
                "Emp_Father_Name = '" & txtCrFatName.Text & "', " & _
                "Emp_Sex = '" & CmbCrSex.Text & "', " & _
                "Emp_Dept = '" & CmbCrDepart.Text & "', " & _
                "Emp_Positions = '" & CmbCrPosition.Text & "', " & _
                "Password = '" & hashedPassword & "', " & _
                "Active = '" & chk_Active & "', " & _
                "Admin = '" & admin & "', " & _
                "Pwr_Lbl = " & Pwr_Lbl & ", " & _
                "Pouch_Lbl = " & Pouch_Lbl & ", " & _
                "Pch_lbl_Reprint = " & Pch_lbl_Reprint & ", " & _
                "inject_lbl = " & inject_lbl & ", " & _
                "Ster = " & Ster & ", " & _
                "Ster_release = " & Ster_release & ", " & _
                "ster_batch_update = " & ster_batch_update & ", " & _
                "Other_sample_scan = " & Other_sample_scan & ", " & _
                "Bx_Pking_Lst = " & Bx_Pking_Lst & ", " & _
                "Bx_Pking = " & Bx_Pking & ", " & _
                "Bx_Ins = " & Bx_Ins & ", " & _
                "areation = " & areation & ", " & _
                "Rack_Label_Print = " & Rack_Label_Print & ", " & _
                "Turkey_gs_lbl = " & Turkey_gs_lbl & ", " & _
                "Bpl_Report = " & Bpl_Report & ", " & _
                "bx_annexure = " & bx_annexure & ", " & _
                "lotsheet_report = " & lotsheet_report & ", " & _
                "ster_Ck_Report = " & ster_Ck_Report & ", " & _
                "prn_report = " & prn_report & ", " & _
                "boxLabelReprint = " & boxLabelReprint & ", " & _
                "Lens_Tracking_Report = " & Lens_Tracking_Report & ", " & _
                "Bx_pack_to_Des = " & Bx_pack_to_Des & ", " & _
                "Mts_report = " & Mts_report & ", " & _
                "Pouch_Pkg_Report = " & Pouch_Pkg_Report & ", " & _
                "CST_SST_Report = " & CST_SST_Report & ", " & _
                "MMS_Report_Ster = " & MMS_Report_Ster & ", " & _
                "Reprint_User_Level = '" & BoxreprintUserLevel & "', " & _
                "Shrink_Warp_Rej = '" & Shrink_Warp_Rej & "', " & _
                 "MMS_Report_Pouch = '" & MMS_Report_Pouch & "' " & _
                "WHERE UserName = '" & txtcruserName.Text & "'"

        Cmd = New SqlCommand(StrSqlIn, con)
        Cmd.ExecuteNonQuery()

        MsgBox("Updated Sucessfully", MsgBoxStyle.Information)

        Clear()
        loadUserLoginBind()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Button1.Visible = False

        btnUpdate.Visible = True
        txtcruserName.Enabled = False

        Dim Cmd As New SqlCommand
        Dim sql As String
        Dim ds As New DataSet
        Dim ad As New SqlDataAdapter
        sql = "select * from Login  where Username = '" & DataGridView1.CurrentRow.Cells("UserName").Value.ToString() & "' "
        Cmd = New SqlCommand(sql, con)
        ad = New SqlDataAdapter(Cmd)
        ad.Fill(ds)
        If ds.Tables(0).Rows.Count <> 0 Then
            txtCrName.Text = ds.Tables(0).Rows(0)("Emp_Name").ToString()
            TxtCrEmpId.Text = ds.Tables(0).Rows(0)("Emp_ID").ToString()
            txtCrFatName.Text = ds.Tables(0).Rows(0)("Emp_Father_Name").ToString()
            CmbCrSex.Text = ds.Tables(0).Rows(0)("Emp_Sex").ToString()
            CmbCrDepart.Text = ds.Tables(0).Rows(0)("Emp_Dept").ToString()
            CmbCrPosition.Text = ds.Tables(0).Rows(0)("Emp_Positions").ToString()
            txtcruserName.Text = ds.Tables(0).Rows(0)("UserName").ToString()
            txtCrPassword.Text = ds.Tables(0).Rows(0)("Password").ToString()
            txtcrReTypePassword.Text = ds.Tables(0).Rows(0)("Password").ToString()
            If ds.Tables(0).Rows(0)("Active").ToString() = "1" Then
                chkActive.Checked = True
            Else
                chkActive.Checked = False
            End If

            If ds.Tables(0).Rows(0)("Admin").ToString() = "1" Then
                chkAdmin.Checked = True
            Else
                chkAdmin.Checked = False
            End If


            If ds.Tables(0).Rows(0)("Pwr_lbl").ToString() = "1" Then
                Chk_Pwr_Lbl.Checked = True
            Else
                Chk_Pwr_Lbl.Checked = False
            End If

            If ds.Tables(0).Rows(0)("Pouch_Lbl").ToString() = "1" Then
                Chk_Pouch_Lbl.Checked = True
            Else
                Chk_Pouch_Lbl.Checked = False
            End If

            If ds.Tables(0).Rows(0)("Pch_lbl_Reprint").ToString() = "1" Then
                Chk_Pch_lbl_Reprint.Checked = True
            Else
                Chk_Pch_lbl_Reprint.Checked = False
            End If

            If ds.Tables(0).Rows(0)("inject_lbl").ToString() = "1" Then
                Chk_inject_lbl.Checked = True
            Else
                Chk_inject_lbl.Checked = False
            End If

            If ds.Tables(0).Rows(0)("Ster").ToString() = "1" Then
                Chk_Ster.Checked = True
            Else
                Chk_Ster.Checked = False
            End If

            If ds.Tables(0).Rows(0)("Ster_release").ToString() = "1" Then
                Chk_Ster_release.Checked = True
            Else
                Chk_Ster_release.Checked = False
            End If

            If ds.Tables(0).Rows(0)("ster_batch_update").ToString() = "1" Then
                Chk_ster_batch_update.Checked = True
            Else
                Chk_ster_batch_update.Checked = False
            End If

            If ds.Tables(0).Rows(0)("Other_sample_scan").ToString() = "1" Then
                Chk_Other_sample_scan.Checked = True
            Else
                Chk_Other_sample_scan.Checked = False
            End If

            If ds.Tables(0).Rows(0)("Bx_Pking_Lst").ToString() = "1" Then
                Chk_Bx_Pking_Lst.Checked = True
            Else
                Chk_Bx_Pking_Lst.Checked = False
            End If

            If ds.Tables(0).Rows(0)("Bx_Pking").ToString() = "1" Then
                Chk_Bx_Pking.Checked = True
            Else
                Chk_Bx_Pking.Checked = False
            End If

            If ds.Tables(0).Rows(0)("Bx_Ins").ToString() = "1" Then
                Chk_Bx_Ins.Checked = True
            Else
                Chk_Bx_Ins.Checked = False
            End If

            If ds.Tables(0).Rows(0)("areation").ToString() = "1" Then
                Chk_areation.Checked = True
            Else
                Chk_areation.Checked = False
            End If

            If ds.Tables(0).Rows(0)("Rack_Label_Print").ToString() = "1" Then
                Chk_Rack_Label_Print.Checked = True
            Else
                Chk_Rack_Label_Print.Checked = False
            End If

            If ds.Tables(0).Rows(0)("Turkey_gs_lbl").ToString() = "1" Then
                Chk_Turkey_gs_lbl.Checked = True
            Else
                Chk_Turkey_gs_lbl.Checked = False
            End If

            If ds.Tables(0).Rows(0)("Bpl_Report").ToString() = "1" Then
                Chk_Bpl_Report.Checked = True
            Else
                Chk_Bpl_Report.Checked = False
            End If

            If ds.Tables(0).Rows(0)("bx_annexure").ToString() = "1" Then
                Chk_bx_annexure.Checked = True
            Else
                Chk_bx_annexure.Checked = False
            End If

            If ds.Tables(0).Rows(0)("lotsheet_report").ToString() = "1" Then
                Chk_lotsheet_report.Checked = True
            Else
                Chk_lotsheet_report.Checked = False
            End If

            If ds.Tables(0).Rows(0)("ster_Ck_Report").ToString() = "1" Then
                Chk_ster_Ck_Report.Checked = True
            Else
                Chk_ster_Ck_Report.Checked = False
            End If

            If ds.Tables(0).Rows(0)("prn_report").ToString() = "1" Then
                Chk_prn_report.Checked = True
            Else
                Chk_prn_report.Checked = False
            End If

            If ds.Tables(0).Rows(0)("Lens_Tracking_Report").ToString() = "1" Then
                Chk_Lens_Tracking_Report.Checked = True
            Else
                Chk_Lens_Tracking_Report.Checked = False
            End If

            If ds.Tables(0).Rows(0)("boxLabelReprint").ToString() = "1" Then
                Chk_boxLabelReprint.Checked = True
            Else
                Chk_boxLabelReprint.Checked = False
            End If
            ''
            If ds.Tables(0).Rows(0)("Bx_pack_to_Des").ToString() = "1" Then
                Chk_Bx_pack_to_Des.Checked = True
            Else
                Chk_Bx_pack_to_Des.Checked = False
            End If
            If ds.Tables(0).Rows(0)("Mts_report").ToString() = "1" Then
                Chk_Mts_report.Checked = True
            Else
                Chk_Mts_report.Checked = False
            End If
            If ds.Tables(0).Rows(0)("Pouch_Pkg_Report").ToString() = "1" Then
                chk_MMS_Report_Pouch.Checked = True
            Else
                chk_MMS_Report_Pouch.Checked = False
            End If
            If ds.Tables(0).Rows(0)("CST_SST_Report").ToString() = "1" Then
                Chk_CST_SST_Report.Checked = True
            Else
                Chk_CST_SST_Report.Checked = False
            End If
            If ds.Tables(0).Rows(0)("MMS_Report_Ster").ToString() = "1" Then
                chk_MMS_Report_Ster.Checked = True
            Else
                chk_MMS_Report_Ster.Checked = False
            End If

            If ds.Tables(0).Rows(0)("Shrink_Warp_Rej").ToString() = "1" Then
                Chk_Shrink_Warp_Rej.Checked = True
            Else
                Chk_Shrink_Warp_Rej.Checked = False
            End If

            If ds.Tables(0).Rows(0)("MMS_Report_Pouch").ToString() = "1" Then
                chk_MMS_Report_Pouch.Checked = True
            Else
                chk_MMS_Report_Pouch.Checked = False
            End If


        End If



    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


    Private Sub Chk_boxLabelReprint_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_boxLabelReprint.CheckedChanged
        If Chk_boxLabelReprint.Checked = True Then
            cmbReprintUserLevel.Visible = True
        Else
            cmbReprintUserLevel.Visible = False
        End If
    End Sub
End Class