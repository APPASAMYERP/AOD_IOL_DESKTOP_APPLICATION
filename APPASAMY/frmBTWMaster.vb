Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class frmBTWMaster

    Dim ds As New DataSet
    Dim strsql As String

    Private Sub frmBTWMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If

        LensMasterBind()
        TypeBind()
        LabelNameBind()
        PrinterNameBind()
        SelectAllBTW()
        Clear()
    End Sub

    Private Sub LensMasterBind()
        ds = New DataSet()
        If productline = "PMMA" Then
            strsql = "select distinct Model_Name from Lens_Master1 order by Model_Name"
        Else
            strsql = "select distinct Model_Name from Lens_Master order by Model_Name"
        End If
        Dim cmd As New SqlCommand(strsql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)

        cmbModelNo.DisplayMember = "Model_Name"
        cmbModelNo.DataSource = ds.Tables(0)

        CheckedListBox1.Items.Clear()
        For i = 0 To ds.Tables(0).Rows.Count - 1
            CheckedListBox1.Items.Add(ds.Tables(0).Rows(i)("Model_Name").ToString())
        Next
    End Sub

    Private Sub TypeBind()
        ds = New DataSet()
        strsql = "select distinct Type from Lot_Type "
        Dim cmd As New SqlCommand(strsql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)

        cmbTypeName.DisplayMember = "Type"
        cmbTypeName.DataSource = ds.Tables(0)


    End Sub

    Private Sub LabelNameBind()
        ds = New DataSet()
        strsql = "select distinct LabelName from BTW_Master "
        Dim cmd As New SqlCommand(strsql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)

        cmbLabelName.DisplayMember = "LabelName"
        cmbLabelName.DataSource = ds.Tables(0)


    End Sub

    Private Sub PrinterNameBind()
        ds = New DataSet()
        strsql = "select distinct PrinterName from BTW_Master "
        Dim cmd As New SqlCommand(strsql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)

        cmbPrinterName.DisplayMember = "PrinterName"
        cmbPrinterName.DataSource = ds.Tables(0)


    End Sub

    Private Sub SelectBTW()
        btnSave.Visible = False
        btnUpdate.Visible = True
        ds = New DataSet()

        strsql = "select * from BTW_Master where id = '" & gridBTW.CurrentRow.Cells(0).Value.ToString() & "'   "
        Dim cmd As New SqlCommand(strsql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)

        If ds.Tables(0).Rows.Count <> 0 Then
            txtId.Text = ds.Tables(0).Rows(0)("Id").ToString()
            cmbDepartment.Text = ds.Tables(0).Rows(0)("Department").ToString()
            cmbModelNo.Text = ds.Tables(0).Rows(0)("ModelNo").ToString()
            cmbTypeName.Text = ds.Tables(0).Rows(0)("TypeName").ToString()
            cmbLabelName.Text = ds.Tables(0).Rows(0)("LabelName").ToString()
            cmbPrinterName.Text = ds.Tables(0).Rows(0)("PrinterName").ToString()
            txtFileName.Text = ds.Tables(0).Rows(0)("FileName").ToString()
        End If




    End Sub

    Private Sub SelectAllBTW()
        ds = New DataSet()
        strsql = "select * from BTW_Master  "
        Dim cmd As New SqlCommand(strsql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)

        gridBTW.DataSource = ds.Tables(0)



    End Sub

    Private Sub SearchFileNameBTW()
        ds = New DataSet()
        strsql = "select * from BTW_Master where FileName Like '" & txtFileNameSearch.Text & "%'"
        Dim cmd As New SqlCommand(strsql, con)
        Dim ad As New SqlDataAdapter(cmd)
        ad.Fill(ds)

        gridBTW.DataSource = ds.Tables(0)



    End Sub

    Private Sub Clear()

        LensMasterBind()

        LabelNameBind()
        cmbDepartment.Text = ""
        cmbModelNo.Text = ""
        cmbTypeName.Text = ""
        cmbLabelName.Text = ""
        cmbPrinterName.Text = ""
        txtFileName.Text = ""
        txtId.Text = ""
        txtSearchModel.Text = ""

        btnSave.Visible = True
        btnUpdate.Visible = False
        CheckedListBox1.Enabled = False
        chkBulkModel.Checked = False



    End Sub

    Private Sub AutoGenerateBTWFileName()
        Dim filename As String
        '& "_" & cmbPrinterName.Text
        If chkBulkModel.Checked Then
            filename = productline & "_" & cmbDepartment.Text & "_" & cmbTypeName.Text & "_" & cmbLabelName.Text & ".btw"
        Else
            filename = productline & "_" & cmbDepartment.Text & "_" & cmbModelNo.Text & "_" & cmbTypeName.Text & "_" & cmbLabelName.Text & ".btw"
        End If

        txtFileName.Text = filename
    End Sub

    Private Function ValidateMethod() As Boolean
        Dim flag As Boolean = True
        If cmbDepartment.Text = "" Then
            flag = False
            MessageBox.Show("Select the Department")
        End If

        If cmbModelNo.Text = "" Then
            If chkBulkModel.Checked = False Then
                flag = False
                MessageBox.Show("Select the Model No")
            End If
        End If

        If cmbTypeName.Text = "" Then
            flag = False
            MessageBox.Show("Select the Type Local / Export")
        End If

        If cmbLabelName.Text = "" Then
            flag = False
            MessageBox.Show("Enter the Label Name")
            'ElseIf cmbPrinterName.Text = "" Then
            '    flag = False
            '    MessageBox.Show("Enter the Printer Name")
        End If
        If txtFileName.Text = "" Then
            flag = False
            MessageBox.Show("Enter the FileName")
        End If

        If txtId.Text = "" Then
            ds = New DataSet()
            If chkBulkModel.Checked Then
                strsql = "select * from BTW_Master where Department = '" & cmbDepartment.Text & "' and LabelName = '" & cmbLabelName.Text & "' "
            Else
                strsql = "select * from BTW_Master where Department = '" & cmbDepartment.Text & "' and ModelNo = '" & cmbModelNo.Text & "' and LabelName = '" & cmbLabelName.Text & "' "
            End If
            Dim cmd As New SqlCommand(strsql, con)
            Dim ad As New SqlDataAdapter(cmd)
            ad.Fill(ds)
            If ds.Tables(0).Rows.Count <> 0 Then
                flag = False
                MessageBox.Show("Already Exist")
            End If
        End If


            Return flag

    End Function
    Private Sub SaveBTW()
        If ValidateMethod() Then

            If chkBulkModel.Checked = False Then
                strsql = "insert into BTW_Master (Department,ModelNo,TypeName,LabelName,PrinterName,FileName) values ('" & cmbDepartment.Text & "','" & cmbModelNo.Text & "','" & cmbTypeName.Text & "','" & cmbLabelName.Text & "','" & cmbPrinterName.Text & "','" & txtFileName.Text & "') "
                Dim cmd As New SqlCommand(strsql, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Saved Successfully")
                Clear()
            Else ' bulk save
                For i = 0 To CheckedListBox1.Items.Count - 1
                    If CheckedListBox1.GetItemChecked(i) = True Then
                        ds = New DataSet
                        strsql = "select * from BTW_Master where Department = '" & cmbDepartment.Text & "' and ModelNo = '" & CheckedListBox1.Items(i).ToString() & "' and TypeName = '" & cmbTypeName.Text & "' and LabelName = '" & cmbLabelName.Text & "' and PrinterName = '" & cmbPrinterName.Text & "'"
                        Dim cmd1 As New SqlCommand(strsql, con)
                        Dim ad As New SqlDataAdapter(cmd1)
                        ad.Fill(ds)
                        If ds.Tables(0).Rows.Count <> 0 Then
                            MessageBox.Show("Model No " & CheckedListBox1.Items(i).ToString() & " Already Exist")

                        Else
                            strsql = "insert into BTW_Master (Department,ModelNo,TypeName,LabelName,PrinterName,FileName) values ('" & cmbDepartment.Text & "','" & CheckedListBox1.Items(i).ToString() & "','" & cmbTypeName.Text & "','" & cmbLabelName.Text & "','" & cmbPrinterName.Text & "','" & txtFileName.Text & "') "
                            Dim cmd As New SqlCommand(strsql, con)
                            con.Open()
                            cmd.ExecuteNonQuery()
                            con.Close()
                        End If
                    End If
                Next
                Clear()
            End If
        End If

    End Sub

    Private Sub UpdateBTW()
        If ValidateMethod() Then
            strsql = "update BTW_Master set Department = '" & cmbDepartment.Text & "' ,ModelNo = '" & cmbModelNo.Text & "',TypeName = '" & cmbTypeName.Text & "',LabelName = '" & cmbLabelName.Text & "',PrinterName = '" & cmbPrinterName.Text & "',FileName = '" & txtFileName.Text & "' where id = '" & txtId.Text & "'  "
            Dim cmd As New SqlCommand(strsql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Updated Successfully")
            Clear()
        End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Clear()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'KPMG--

        If cmbDepartment.SelectedItem Is Nothing Then
            MsgBox(" Please select valid Department")
            cmbDepartment.Text = ""
            cmbDepartment.Focus()
            Exit Sub
        End If
        If chkBulkModel.Checked = False Then
            If cmbModelNo.SelectedItem Is Nothing Then
                MsgBox(" Please select valid Model")
                cmbModelNo.Text = ""
                cmbModelNo.Focus()
                Exit Sub
            End If
        End If

        Dim nameWithNumbersRegex As New Regex("^[a-zA-Z0-9_]+$")
        If Not nameWithNumbersRegex.IsMatch(cmbTypeName.Text.Trim()) Then
            MessageBox.Show("Type should only contain letters, numbers, and underscores.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not nameWithNumbersRegex.IsMatch(cmbLabelName.Text.Trim()) Then
            MessageBox.Show("Label should only contain letters, numbers, and underscores.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not nameWithNumbersRegex.IsMatch(txtFileName.Text.Trim()) Then
            MessageBox.Show("FileName should only contain letters, numbers, and underscores.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'KPMG--

        SaveBTW()
        SelectAllBTW()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        'KPMG--

        If cmbDepartment.SelectedItem Is Nothing Then
            MsgBox(" Please select valid Department")
            cmbDepartment.Text = ""
            cmbDepartment.Focus()
            Exit Sub
        End If
        If chkBulkModel.Checked = False Then
            If cmbModelNo.SelectedItem Is Nothing Then
                MsgBox(" Please select valid Model")
                cmbModelNo.Text = ""
                cmbModelNo.Focus()
                Exit Sub
            End If
        End If

        Dim nameWithNumbersRegex As New Regex("^[a-zA-Z0-9_]+$")
        If Not nameWithNumbersRegex.IsMatch(cmbTypeName.Text.Trim()) Then
            MessageBox.Show("Type should only contain letters, numbers, and underscores.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not nameWithNumbersRegex.IsMatch(cmbLabelName.Text.Trim()) Then
            MessageBox.Show("Label should only contain letters, numbers, and underscores.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not nameWithNumbersRegex.IsMatch(txtFileName.Text.Trim()) Then
            MessageBox.Show("FileName should only contain letters, numbers, and underscores.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'KPMG--

        UpdateBTW()
        SelectAllBTW()
    End Sub

    Private Sub gridBTW_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridBTW.CellDoubleClick
        SelectBTW()

    End Sub

    Private Sub cmbDepartment_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AutoGenerateBTWFileName()
    End Sub

    Private Sub cmbDepartment_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDepartment.TextChanged
        AutoGenerateBTWFileName()
    End Sub

    Private Sub cmbModelNo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbModelNo.SelectedValueChanged
        AutoGenerateBTWFileName()
    End Sub

    Private Sub cmbTypeName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTypeName.TextChanged
        AutoGenerateBTWFileName()
    End Sub

    Private Sub cmbLabelName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLabelName.TextChanged
        AutoGenerateBTWFileName()
    End Sub

    Private Sub cmbPrinterName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPrinterName.TextChanged
        AutoGenerateBTWFileName()
    End Sub

    Private Sub chkBulkModel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBulkModel.CheckedChanged
        If chkBulkModel.Checked Then
            cmbModelNo.Text = ""
            cmbModelNo.Enabled = False
            CheckedListBox1.Enabled = True
        Else
            cmbModelNo.Text = ""
            cmbModelNo.Enabled = True
            CheckedListBox1.Enabled = False
        End If
        AutoGenerateBTWFileName()
    End Sub

    Private Sub txtFileNameSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFileNameSearch.TextChanged
        SearchFileNameBTW()
    End Sub

 
    Private Sub chkCheckAll_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles chkCheckAll.LinkClicked
        For i = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.SetItemChecked(i, True)
        Next
    End Sub

    Private Sub chkUncheckAll_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles chkUncheckAll.LinkClicked
        For i = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.SetItemChecked(i, False)
        Next
    End Sub

    Private Sub txtSearchModel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchModel.TextChanged
        Try
            Dim s As Integer = CheckedListBox1.FindString(txtSearchModel.Text)
            CheckedListBox1.SetSelected(s, True)
        Catch ex As Exception

        End Try
        

         
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure to Delete?", "Delete BTW", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            strsql = "delete from BTW_Master where id = '" & txtId.Text & "' "
            Dim cmd As New SqlCommand(strsql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Deleted Successfully")
            SelectAllBTW()
            Clear()
        End If
    End Sub

    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
        Dim frm As New frmPouch
        'frm.MdiParent = Me
        frm.ShowDialog()
    End Sub
End Class