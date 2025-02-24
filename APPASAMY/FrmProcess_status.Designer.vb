<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProcess_status
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.rdodc = New System.Windows.Forms.RadioButton
        Me.rdobxpkg = New System.Windows.Forms.RadioButton
        Me.rdobpl = New System.Windows.Forms.RadioButton
        Me.Rdosecster = New System.Windows.Forms.RadioButton
        Me.rdoforster = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnSerch = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dtpto = New System.Windows.Forms.DateTimePicker
        Me.lblfrm = New System.Windows.Forms.Label
        Me.dtpfrom = New System.Windows.Forms.DateTimePicker
        Me.lbl = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ChkModel = New System.Windows.Forms.CheckBox
        Me.ChkType = New System.Windows.Forms.CheckBox
        Me.CmbType = New System.Windows.Forms.ComboBox
        Me.CmbShModel = New System.Windows.Forms.ComboBox
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rdodc)
        Me.GroupBox4.Controls.Add(Me.rdobxpkg)
        Me.GroupBox4.Controls.Add(Me.rdobpl)
        Me.GroupBox4.Controls.Add(Me.Rdosecster)
        Me.GroupBox4.Controls.Add(Me.rdoforster)
        Me.GroupBox4.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Red
        Me.GroupBox4.Location = New System.Drawing.Point(62, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(493, 136)
        Me.GroupBox4.TabIndex = 76
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Report Type"
        '
        'rdodc
        '
        Me.rdodc.AutoSize = True
        Me.rdodc.Location = New System.Drawing.Point(41, 100)
        Me.rdodc.Name = "rdodc"
        Me.rdodc.Size = New System.Drawing.Size(113, 19)
        Me.rdodc.TabIndex = 39
        Me.rdodc.Text = "Ready For DC"
        Me.rdodc.UseVisualStyleBackColor = True
        '
        'rdobxpkg
        '
        Me.rdobxpkg.AutoSize = True
        Me.rdobxpkg.Location = New System.Drawing.Point(266, 61)
        Me.rdobxpkg.Name = "rdobxpkg"
        Me.rdobxpkg.Size = New System.Drawing.Size(169, 19)
        Me.rdobxpkg.TabIndex = 38
        Me.rdobxpkg.Text = "Ready For BoxPacking"
        Me.rdobxpkg.UseVisualStyleBackColor = True
        '
        'rdobpl
        '
        Me.rdobpl.AutoSize = True
        Me.rdobpl.Location = New System.Drawing.Point(41, 61)
        Me.rdobpl.Name = "rdobpl"
        Me.rdobpl.Size = New System.Drawing.Size(97, 19)
        Me.rdobpl.TabIndex = 37
        Me.rdobpl.Text = "Ready BPL "
        Me.rdobpl.UseVisualStyleBackColor = True
        '
        'Rdosecster
        '
        Me.Rdosecster.AutoSize = True
        Me.Rdosecster.Location = New System.Drawing.Point(266, 20)
        Me.Rdosecster.Name = "Rdosecster"
        Me.Rdosecster.Size = New System.Drawing.Size(175, 19)
        Me.Rdosecster.TabIndex = 36
        Me.Rdosecster.Text = "Ready For Second_Ster"
        Me.Rdosecster.UseVisualStyleBackColor = True
        '
        'rdoforster
        '
        Me.rdoforster.AutoSize = True
        Me.rdoforster.Checked = True
        Me.rdoforster.Location = New System.Drawing.Point(41, 20)
        Me.rdoforster.Name = "rdoforster"
        Me.rdoforster.Size = New System.Drawing.Size(187, 19)
        Me.rdoforster.TabIndex = 35
        Me.rdoforster.TabStop = True
        Me.rdoforster.Text = "Ready For Sterailization"
        Me.rdoforster.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnClose)
        Me.GroupBox3.Controls.Add(Me.BtnSerch)
        Me.GroupBox3.Location = New System.Drawing.Point(62, 421)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(495, 72)
        Me.GroupBox3.TabIndex = 75
        Me.GroupBox3.TabStop = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.White
        Me.BtnClose.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClose.Location = New System.Drawing.Point(266, 19)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(87, 32)
        Me.BtnClose.TabIndex = 45
        Me.BtnClose.Text = "CLOSE"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnSerch
        '
        Me.BtnSerch.BackColor = System.Drawing.Color.White
        Me.BtnSerch.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSerch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSerch.Location = New System.Drawing.Point(95, 19)
        Me.BtnSerch.Name = "BtnSerch"
        Me.BtnSerch.Size = New System.Drawing.Size(93, 32)
        Me.BtnSerch.TabIndex = 44
        Me.BtnSerch.Text = "SUBMIT"
        Me.BtnSerch.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpto)
        Me.GroupBox2.Controls.Add(Me.lblfrm)
        Me.GroupBox2.Controls.Add(Me.dtpfrom)
        Me.GroupBox2.Controls.Add(Me.lbl)
        Me.GroupBox2.Location = New System.Drawing.Point(60, 154)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(495, 121)
        Me.GroupBox2.TabIndex = 74
        Me.GroupBox2.TabStop = False
        '
        'dtpto
        '
        Me.dtpto.CustomFormat = "dd/MM/yyyy"
        Me.dtpto.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpto.Location = New System.Drawing.Point(213, 77)
        Me.dtpto.Name = "dtpto"
        Me.dtpto.Size = New System.Drawing.Size(115, 22)
        Me.dtpto.TabIndex = 43
        '
        'lblfrm
        '
        Me.lblfrm.AutoSize = True
        Me.lblfrm.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfrm.ForeColor = System.Drawing.Color.Blue
        Me.lblfrm.Location = New System.Drawing.Point(48, 30)
        Me.lblfrm.Name = "lblfrm"
        Me.lblfrm.Size = New System.Drawing.Size(84, 16)
        Me.lblfrm.TabIndex = 40
        Me.lblfrm.Text = "FROM DATE"
        '
        'dtpfrom
        '
        Me.dtpfrom.CalendarForeColor = System.Drawing.Color.Navy
        Me.dtpfrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpfrom.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfrom.Location = New System.Drawing.Point(204, 30)
        Me.dtpfrom.Name = "dtpfrom"
        Me.dtpfrom.Size = New System.Drawing.Size(124, 22)
        Me.dtpfrom.TabIndex = 41
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.Blue
        Me.lbl.Location = New System.Drawing.Point(48, 82)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(63, 16)
        Me.lbl.TabIndex = 42
        Me.lbl.Text = "TO DATE"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChkModel)
        Me.GroupBox1.Controls.Add(Me.ChkType)
        Me.GroupBox1.Controls.Add(Me.CmbType)
        Me.GroupBox1.Controls.Add(Me.CmbShModel)
        Me.GroupBox1.Location = New System.Drawing.Point(62, 281)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(495, 134)
        Me.GroupBox1.TabIndex = 73
        Me.GroupBox1.TabStop = False
        '
        'ChkModel
        '
        Me.ChkModel.AutoSize = True
        Me.ChkModel.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkModel.ForeColor = System.Drawing.Color.Red
        Me.ChkModel.Location = New System.Drawing.Point(51, 77)
        Me.ChkModel.Name = "ChkModel"
        Me.ChkModel.Size = New System.Drawing.Size(66, 20)
        Me.ChkModel.TabIndex = 53
        Me.ChkModel.Text = "Model"
        Me.ChkModel.UseVisualStyleBackColor = True
        '
        'ChkType
        '
        Me.ChkType.AutoSize = True
        Me.ChkType.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkType.ForeColor = System.Drawing.Color.Red
        Me.ChkType.Location = New System.Drawing.Point(51, 26)
        Me.ChkType.Name = "ChkType"
        Me.ChkType.Size = New System.Drawing.Size(58, 20)
        Me.ChkType.TabIndex = 52
        Me.ChkType.Text = "Type"
        Me.ChkType.UseVisualStyleBackColor = True
        '
        'CmbType
        '
        Me.CmbType.Enabled = False
        Me.CmbType.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbType.ForeColor = System.Drawing.Color.Blue
        Me.CmbType.FormattingEnabled = True
        Me.CmbType.Items.AddRange(New Object() {"LOCAL", "SQUARE EDGE", "EXPORT"})
        Me.CmbType.Location = New System.Drawing.Point(213, 19)
        Me.CmbType.Name = "CmbType"
        Me.CmbType.Size = New System.Drawing.Size(173, 24)
        Me.CmbType.TabIndex = 46
        '
        'CmbShModel
        '
        Me.CmbShModel.Enabled = False
        Me.CmbShModel.FormattingEnabled = True
        Me.CmbShModel.Items.AddRange(New Object() {"1", "2", "3"})
        Me.CmbShModel.Location = New System.Drawing.Point(213, 76)
        Me.CmbShModel.Name = "CmbShModel"
        Me.CmbShModel.Size = New System.Drawing.Size(173, 21)
        Me.CmbShModel.TabIndex = 50
        '
        'FrmProcess_status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(618, 536)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmProcess_status"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Rdosecster As System.Windows.Forms.RadioButton
    Friend WithEvents rdoforster As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents BtnClose As System.Windows.Forms.Button
    Private WithEvents BtnSerch As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents dtpto As System.Windows.Forms.DateTimePicker
    Private WithEvents lblfrm As System.Windows.Forms.Label
    Private WithEvents dtpfrom As System.Windows.Forms.DateTimePicker
    Private WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkModel As System.Windows.Forms.CheckBox
    Friend WithEvents ChkType As System.Windows.Forms.CheckBox
    Private WithEvents CmbType As System.Windows.Forms.ComboBox
    Friend WithEvents CmbShModel As System.Windows.Forms.ComboBox
    Friend WithEvents rdodc As System.Windows.Forms.RadioButton
    Friend WithEvents rdobxpkg As System.Windows.Forms.RadioButton
    Friend WithEvents rdobpl As System.Windows.Forms.RadioButton
End Class
