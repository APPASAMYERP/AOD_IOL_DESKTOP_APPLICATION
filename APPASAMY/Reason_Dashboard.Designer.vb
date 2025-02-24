<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reason_Dashboard
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reason_Dashboard))
        Me.btnSubmit = New System.Windows.Forms.Button
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.cmbstatype = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.statype = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpdate = New System.Windows.Forms.DateTimePicker
        Me.cmbempname = New System.Windows.Forms.ComboBox
        Me.cmbShift = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbempname2 = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GRID2 = New System.Windows.Forms.DataGridView
        Me.dtpFromTime = New System.Windows.Forms.DateTimePicker
        Me.dtpToTime = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnAdd = New System.Windows.Forms.Button
        Me.chkPacking = New System.Windows.Forms.CheckBox
        Me.grid1 = New System.Windows.Forms.DataGridView
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Station = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UserName1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UserName2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Shift = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateTimeFrom = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateTimeTo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PackingStatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Reason = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Station1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UserName11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UserName21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Shift1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateTimeFrom1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateTimeTo1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PackingStatus1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Reason1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Update = New System.Windows.Forms.DataGridViewButtonColumn
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(388, 248)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(141, 32)
        Me.btnSubmit.TabIndex = 60
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(293, 193)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(408, 31)
        Me.RichTextBox1.TabIndex = 59
        Me.RichTextBox1.Text = ""
        '
        'cmbstatype
        '
        Me.cmbstatype.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbstatype.FormattingEnabled = True
        Me.cmbstatype.Location = New System.Drawing.Point(146, 58)
        Me.cmbstatype.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbstatype.Name = "cmbstatype"
        Me.cmbstatype.Size = New System.Drawing.Size(159, 28)
        Me.cmbstatype.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(142, 200)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 25)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Reason"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 106)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 25)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Printed By"
        '
        'statype
        '
        Me.statype.AutoSize = True
        Me.statype.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statype.Location = New System.Drawing.Point(7, 57)
        Me.statype.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.statype.Name = "statype"
        Me.statype.Size = New System.Drawing.Size(80, 25)
        Me.statype.TabIndex = 52
        Me.statype.Text = "Station"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 25)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Date"
        '
        'dtpdate
        '
        Me.dtpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdate.Location = New System.Drawing.Point(118, 17)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(246, 31)
        Me.dtpdate.TabIndex = 48
        '
        'cmbempname
        '
        Me.cmbempname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbempname.FormattingEnabled = True
        Me.cmbempname.Location = New System.Drawing.Point(146, 106)
        Me.cmbempname.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbempname.Name = "cmbempname"
        Me.cmbempname.Size = New System.Drawing.Size(219, 28)
        Me.cmbempname.TabIndex = 58
        '
        'cmbShift
        '
        Me.cmbShift.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbShift.FormattingEnabled = True
        Me.cmbShift.Items.AddRange(New Object() {"I", "II", "G"})
        Me.cmbShift.Location = New System.Drawing.Point(500, 58)
        Me.cmbShift.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbShift.Name = "cmbShift"
        Me.cmbShift.Size = New System.Drawing.Size(159, 28)
        Me.cmbShift.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(365, 57)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 25)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Shift"
        '
        'cmbempname2
        '
        Me.cmbempname2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbempname2.FormattingEnabled = True
        Me.cmbempname2.Location = New System.Drawing.Point(500, 108)
        Me.cmbempname2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbempname2.Name = "cmbempname2"
        Me.cmbempname2.Size = New System.Drawing.Size(218, 28)
        Me.cmbempname2.TabIndex = 65
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(365, 106)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 25)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Packed By"
        '
        'GRID2
        '
        Me.GRID2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.GRID2.BackgroundColor = System.Drawing.Color.White
        Me.GRID2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GRID2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.GRID2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Station, Me.UserName1, Me.UserName2, Me.Shift, Me.DateTimeFrom, Me.DateTimeTo, Me.PackingStatus, Me.Reason})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GRID2.DefaultCellStyle = DataGridViewCellStyle1
        Me.GRID2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GRID2.Location = New System.Drawing.Point(10, 306)
        Me.GRID2.Name = "GRID2"
        Me.GRID2.RowHeadersWidth = 60
        Me.GRID2.RowTemplate.Height = 24
        Me.GRID2.Size = New System.Drawing.Size(694, 324)
        Me.GRID2.TabIndex = 66
        '
        'dtpFromTime
        '
        Me.dtpFromTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFromTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpFromTime.Location = New System.Drawing.Point(146, 150)
        Me.dtpFromTime.Name = "dtpFromTime"
        Me.dtpFromTime.ShowUpDown = True
        Me.dtpFromTime.Size = New System.Drawing.Size(162, 31)
        Me.dtpFromTime.TabIndex = 48
        '
        'dtpToTime
        '
        Me.dtpToTime.Checked = False
        Me.dtpToTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpToTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpToTime.Location = New System.Drawing.Point(497, 150)
        Me.dtpToTime.Name = "dtpToTime"
        Me.dtpToTime.ShowUpDown = True
        Me.dtpToTime.Size = New System.Drawing.Size(162, 31)
        Me.dtpToTime.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 150)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 25)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "From Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(364, 150)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 25)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "To Time"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(146, 248)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(141, 32)
        Me.btnAdd.TabIndex = 60
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'chkPacking
        '
        Me.chkPacking.AutoSize = True
        Me.chkPacking.Location = New System.Drawing.Point(14, 200)
        Me.chkPacking.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkPacking.Name = "chkPacking"
        Me.chkPacking.Size = New System.Drawing.Size(65, 17)
        Me.chkPacking.TabIndex = 67
        Me.chkPacking.Text = "Packing"
        Me.chkPacking.UseVisualStyleBackColor = True
        '
        'grid1
        '
        Me.grid1.AllowUserToAddRows = False
        Me.grid1.AllowUserToDeleteRows = False
        Me.grid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Station1, Me.UserName11, Me.UserName21, Me.Shift1, Me.DateTimeFrom1, Me.DateTimeTo1, Me.PackingStatus1, Me.Reason1, Me.Update})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 4.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid1.DefaultCellStyle = DataGridViewCellStyle3
        Me.grid1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.grid1.Location = New System.Drawing.Point(722, 39)
        Me.grid1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grid1.Name = "grid1"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 2.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.grid1.RowTemplate.Height = 24
        Me.grid1.Size = New System.Drawing.Size(680, 591)
        Me.grid1.TabIndex = 68
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(1360, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        '
        'Station
        '
        Me.Station.HeaderText = "Station"
        Me.Station.Name = "Station"
        '
        'UserName1
        '
        Me.UserName1.HeaderText = "Printed By"
        Me.UserName1.Name = "UserName1"
        Me.UserName1.Width = 120
        '
        'UserName2
        '
        Me.UserName2.HeaderText = "Packed By"
        Me.UserName2.Name = "UserName2"
        Me.UserName2.Width = 120
        '
        'Shift
        '
        Me.Shift.HeaderText = "Shift"
        Me.Shift.Name = "Shift"
        Me.Shift.Width = 50
        '
        'DateTimeFrom
        '
        Me.DateTimeFrom.HeaderText = "DateTimeFrom"
        Me.DateTimeFrom.Name = "DateTimeFrom"
        '
        'DateTimeTo
        '
        Me.DateTimeTo.HeaderText = "DateTimeTo"
        Me.DateTimeTo.Name = "DateTimeTo"
        '
        'PackingStatus
        '
        Me.PackingStatus.HeaderText = "Status"
        Me.PackingStatus.Name = "PackingStatus"
        Me.PackingStatus.Width = 60
        '
        'Reason
        '
        Me.Reason.HeaderText = "Reason"
        Me.Reason.Name = "Reason"
        Me.Reason.Width = 210
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 43
        '
        'Station1
        '
        Me.Station1.HeaderText = "Station"
        Me.Station1.Name = "Station1"
        Me.Station1.ReadOnly = True
        Me.Station1.Width = 72
        '
        'UserName11
        '
        Me.UserName11.HeaderText = "Printed By"
        Me.UserName11.Name = "UserName11"
        Me.UserName11.ReadOnly = True
        Me.UserName11.Width = 90
        '
        'UserName21
        '
        Me.UserName21.HeaderText = "Packed By"
        Me.UserName21.Name = "UserName21"
        Me.UserName21.ReadOnly = True
        Me.UserName21.Width = 93
        '
        'Shift1
        '
        Me.Shift1.HeaderText = "Shift"
        Me.Shift1.Name = "Shift1"
        Me.Shift1.ReadOnly = True
        Me.Shift1.Width = 58
        '
        'DateTimeFrom1
        '
        Me.DateTimeFrom1.HeaderText = "DateTimeFrom"
        Me.DateTimeFrom1.Name = "DateTimeFrom1"
        Me.DateTimeFrom1.Width = 113
        '
        'DateTimeTo1
        '
        Me.DateTimeTo1.HeaderText = "DateTimeTo"
        Me.DateTimeTo1.Name = "DateTimeTo1"
        Me.DateTimeTo1.Width = 101
        '
        'PackingStatus1
        '
        Me.PackingStatus1.HeaderText = "PackingStatus"
        Me.PackingStatus1.Name = "PackingStatus1"
        Me.PackingStatus1.ReadOnly = True
        Me.PackingStatus1.Width = 114
        '
        'Reason1
        '
        Me.Reason1.HeaderText = "Reason"
        Me.Reason1.Name = "Reason1"
        Me.Reason1.ReadOnly = True
        Me.Reason1.Width = 75
        '
        'Update
        '
        Me.Update.HeaderText = "btnUpdate"
        Me.Update.Name = "Update"
        Me.Update.ReadOnly = True
        Me.Update.Width = 72
        '
        'Reason_Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1426, 656)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.chkPacking)
        Me.Controls.Add(Me.GRID2)
        Me.Controls.Add(Me.cmbempname2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbShift)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.cmbempname)
        Me.Controls.Add(Me.cmbstatype)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.statype)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpToTime)
        Me.Controls.Add(Me.dtpFromTime)
        Me.Controls.Add(Me.dtpdate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Reason_Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents cmbstatype As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents statype As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbempname As System.Windows.Forms.ComboBox
    Friend WithEvents cmbShift As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbempname2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GRID2 As System.Windows.Forms.DataGridView
    Friend WithEvents dtpFromTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpToTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents chkPacking As System.Windows.Forms.CheckBox
    Friend WithEvents grid1 As System.Windows.Forms.DataGridView
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Station As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserName1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserName2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Shift As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateTimeFrom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateTimeTo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PackingStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Reason As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Station1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserName11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserName21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Shift1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateTimeFrom1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateTimeTo1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PackingStatus1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Reason1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Update As System.Windows.Forms.DataGridViewButtonColumn
End Class
