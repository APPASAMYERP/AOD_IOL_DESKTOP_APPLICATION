<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBTWMaster
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbDepartment = New System.Windows.Forms.ComboBox
        Me.cmbModelNo = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbTypeName = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbLabelName = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbPrinterName = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtFileName = New System.Windows.Forms.TextBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.gridBTW = New System.Windows.Forms.DataGridView
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtId = New System.Windows.Forms.TextBox
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox
        Me.chkBulkModel = New System.Windows.Forms.CheckBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtFileNameSearch = New System.Windows.Forms.TextBox
        Me.chkCheckAll = New System.Windows.Forms.LinkLabel
        Me.chkUncheckAll = New System.Windows.Forms.LinkLabel
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtSearchModel = New System.Windows.Forms.TextBox
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnTest = New System.Windows.Forms.Button
        CType(Me.gridBTW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(22, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Department"
        '
        'cmbDepartment
        '
        Me.cmbDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDepartment.FormattingEnabled = True
        Me.cmbDepartment.Items.AddRange(New Object() {"POUCH", "BOX", "Injector"})
        Me.cmbDepartment.Location = New System.Drawing.Point(119, 37)
        Me.cmbDepartment.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(276, 25)
        Me.cmbDepartment.TabIndex = 1
        '
        'cmbModelNo
        '
        Me.cmbModelNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbModelNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbModelNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModelNo.FormattingEnabled = True
        Me.cmbModelNo.Location = New System.Drawing.Point(119, 77)
        Me.cmbModelNo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbModelNo.Name = "cmbModelNo"
        Me.cmbModelNo.Size = New System.Drawing.Size(276, 25)
        Me.cmbModelNo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(22, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Model No"
        '
        'cmbTypeName
        '
        Me.cmbTypeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbTypeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTypeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTypeName.FormattingEnabled = True
        Me.cmbTypeName.Items.AddRange(New Object() {"LOCAL", "EXPORT"})
        Me.cmbTypeName.Location = New System.Drawing.Point(119, 266)
        Me.cmbTypeName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbTypeName.Name = "cmbTypeName"
        Me.cmbTypeName.Size = New System.Drawing.Size(276, 25)
        Me.cmbTypeName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(22, 266)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Type"
        '
        'cmbLabelName
        '
        Me.cmbLabelName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbLabelName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbLabelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLabelName.FormattingEnabled = True
        Me.cmbLabelName.Location = New System.Drawing.Point(119, 304)
        Me.cmbLabelName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbLabelName.Name = "cmbLabelName"
        Me.cmbLabelName.Size = New System.Drawing.Size(276, 25)
        Me.cmbLabelName.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(22, 304)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Label"
        '
        'cmbPrinterName
        '
        Me.cmbPrinterName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbPrinterName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPrinterName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPrinterName.FormattingEnabled = True
        Me.cmbPrinterName.Location = New System.Drawing.Point(119, 344)
        Me.cmbPrinterName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbPrinterName.Name = "cmbPrinterName"
        Me.cmbPrinterName.Size = New System.Drawing.Size(276, 25)
        Me.cmbPrinterName.TabIndex = 9
        Me.cmbPrinterName.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(22, 344)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Printer"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(22, 387)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "File Name"
        '
        'txtFileName
        '
        Me.txtFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileName.ForeColor = System.Drawing.Color.Blue
        Me.txtFileName.Location = New System.Drawing.Point(25, 406)
        Me.txtFileName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(362, 23)
        Me.txtFileName.TabIndex = 11
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(77, 461)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 29)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(184, 461)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 29)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(390, 461)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 29)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'gridBTW
        '
        Me.gridBTW.AllowUserToAddRows = False
        Me.gridBTW.AllowUserToDeleteRows = False
        Me.gridBTW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridBTW.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gridBTW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridBTW.DefaultCellStyle = DataGridViewCellStyle2
        Me.gridBTW.Location = New System.Drawing.Point(404, 77)
        Me.gridBTW.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gridBTW.Name = "gridBTW"
        Me.gridBTW.ReadOnly = True
        Me.gridBTW.RowTemplate.Height = 24
        Me.gridBTW.Size = New System.Drawing.Size(677, 340)
        Me.gridBTW.TabIndex = 15
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(77, 461)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(90, 29)
        Me.btnUpdate.TabIndex = 16
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(400, 427)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Double click to select"
        '
        'txtId
        '
        Me.txtId.ForeColor = System.Drawing.Color.Blue
        Me.txtId.Location = New System.Drawing.Point(119, 14)
        Me.txtId.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(76, 20)
        Me.txtId.TabIndex = 18
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(119, 113)
        Me.CheckedListBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckedListBox1.MultiColumn = True
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(276, 94)
        Me.CheckedListBox1.TabIndex = 19
        '
        'chkBulkModel
        '
        Me.chkBulkModel.AutoSize = True
        Me.chkBulkModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBulkModel.ForeColor = System.Drawing.Color.Blue
        Me.chkBulkModel.Location = New System.Drawing.Point(25, 113)
        Me.chkBulkModel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkBulkModel.Name = "chkBulkModel"
        Me.chkBulkModel.Size = New System.Drawing.Size(96, 21)
        Me.chkBulkModel.TabIndex = 20
        Me.chkBulkModel.Text = "Bulk Model"
        Me.chkBulkModel.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(407, 43)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 17)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "File Name"
        '
        'txtFileNameSearch
        '
        Me.txtFileNameSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileNameSearch.ForeColor = System.Drawing.Color.Blue
        Me.txtFileNameSearch.Location = New System.Drawing.Point(476, 43)
        Me.txtFileNameSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFileNameSearch.Name = "txtFileNameSearch"
        Me.txtFileNameSearch.Size = New System.Drawing.Size(362, 23)
        Me.txtFileNameSearch.TabIndex = 22
        '
        'chkCheckAll
        '
        Me.chkCheckAll.AutoSize = True
        Me.chkCheckAll.Location = New System.Drawing.Point(119, 231)
        Me.chkCheckAll.Name = "chkCheckAll"
        Me.chkCheckAll.Size = New System.Drawing.Size(52, 13)
        Me.chkCheckAll.TabIndex = 23
        Me.chkCheckAll.TabStop = True
        Me.chkCheckAll.Text = "Check All"
        '
        'chkUncheckAll
        '
        Me.chkUncheckAll.AutoSize = True
        Me.chkUncheckAll.Location = New System.Drawing.Point(181, 231)
        Me.chkUncheckAll.Name = "chkUncheckAll"
        Me.chkUncheckAll.Size = New System.Drawing.Size(66, 13)
        Me.chkUncheckAll.TabIndex = 24
        Me.chkUncheckAll.TabStop = True
        Me.chkUncheckAll.Text = "UnCheck All"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(252, 231)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Search"
        '
        'txtSearchModel
        '
        Me.txtSearchModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchModel.ForeColor = System.Drawing.Color.Blue
        Me.txtSearchModel.Location = New System.Drawing.Point(297, 229)
        Me.txtSearchModel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSearchModel.Name = "txtSearchModel"
        Me.txtSearchModel.Size = New System.Drawing.Size(98, 23)
        Me.txtSearchModel.TabIndex = 26
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(287, 461)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(94, 29)
        Me.btnDelete.TabIndex = 27
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnTest
        '
        Me.btnTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTest.Location = New System.Drawing.Point(818, 427)
        Me.btnTest.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(151, 29)
        Me.btnTest.TabIndex = 28
        Me.btnTest.Text = "Test btw Load"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'frmBTWMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1090, 567)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtSearchModel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.chkUncheckAll)
        Me.Controls.Add(Me.chkCheckAll)
        Me.Controls.Add(Me.txtFileNameSearch)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.chkBulkModel)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gridBTW)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbPrinterName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbLabelName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbTypeName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbModelNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbDepartment)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmBTWMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.gridBTW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents cmbModelNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbTypeName As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbLabelName As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbPrinterName As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents gridBTW As System.Windows.Forms.DataGridView
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents chkBulkModel As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFileNameSearch As System.Windows.Forms.TextBox
    Friend WithEvents chkCheckAll As System.Windows.Forms.LinkLabel
    Friend WithEvents chkUncheckAll As System.Windows.Forms.LinkLabel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSearchModel As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnTest As System.Windows.Forms.Button
End Class
