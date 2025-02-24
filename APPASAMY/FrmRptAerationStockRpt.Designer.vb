<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRptAerationStockRpt
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dtpto = New System.Windows.Forms.DateTimePicker
        Me.lblfrm = New System.Windows.Forms.Label
        Me.dtpfrom = New System.Windows.Forms.DateTimePicker
        Me.lbl = New System.Windows.Forms.Label
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.ChkModel = New System.Windows.Forms.CheckBox
        Me.ChkType = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CmbType = New System.Windows.Forms.ComboBox
        Me.CmbShModel = New System.Windows.Forms.ComboBox
        Me.CmbShBrand = New System.Windows.Forms.ComboBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnSerch = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpto)
        Me.GroupBox2.Controls.Add(Me.lblfrm)
        Me.GroupBox2.Controls.Add(Me.dtpfrom)
        Me.GroupBox2.Controls.Add(Me.lbl)
        Me.GroupBox2.Location = New System.Drawing.Point(54, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(495, 121)
        Me.GroupBox2.TabIndex = 73
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
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.Red
        Me.CheckBox2.Location = New System.Drawing.Point(51, 134)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(58, 20)
        Me.CheckBox2.TabIndex = 54
        Me.CheckBox2.Text = "Type"
        Me.CheckBox2.UseVisualStyleBackColor = True
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.ChkModel)
        Me.GroupBox1.Controls.Add(Me.ChkType)
        Me.GroupBox1.Controls.Add(Me.CmbType)
        Me.GroupBox1.Controls.Add(Me.CmbShModel)
        Me.GroupBox1.Controls.Add(Me.CmbShBrand)
        Me.GroupBox1.Location = New System.Drawing.Point(54, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(495, 190)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
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
        'CmbShBrand
        '
        Me.CmbShBrand.Enabled = False
        Me.CmbShBrand.FormattingEnabled = True
        Me.CmbShBrand.Items.AddRange(New Object() {"A", "B", "C"})
        Me.CmbShBrand.Location = New System.Drawing.Point(213, 134)
        Me.CmbShBrand.Name = "CmbShBrand"
        Me.CmbShBrand.Size = New System.Drawing.Size(173, 21)
        Me.CmbShBrand.TabIndex = 51
        Me.CmbShBrand.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnClose)
        Me.GroupBox3.Controls.Add(Me.BtnSerch)
        Me.GroupBox3.Location = New System.Drawing.Point(54, 320)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(495, 72)
        Me.GroupBox3.TabIndex = 74
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
        'FrmRptAerationStockRpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(603, 459)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "FrmRptAerationStockRpt"
        Me.Text = "FrmRptAerationStockRpt"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents dtpto As System.Windows.Forms.DateTimePicker
    Private WithEvents lblfrm As System.Windows.Forms.Label
    Private WithEvents dtpfrom As System.Windows.Forms.DateTimePicker
    Private WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents ChkModel As System.Windows.Forms.CheckBox
    Friend WithEvents ChkType As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents CmbType As System.Windows.Forms.ComboBox
    Friend WithEvents CmbShModel As System.Windows.Forms.ComboBox
    Friend WithEvents CmbShBrand As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents BtnClose As System.Windows.Forms.Button
    Private WithEvents BtnSerch As System.Windows.Forms.Button
End Class
