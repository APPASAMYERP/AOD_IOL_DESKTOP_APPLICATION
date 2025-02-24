<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPowerLabelPrint
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
        Me.CmbShPower = New System.Windows.Forms.ComboBox
        Me.txtcrMaxQty = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbPrintLabel = New System.Windows.Forms.ComboBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rdUDICode = New System.Windows.Forms.RadioButton
        Me.rdLotSerial = New System.Windows.Forms.RadioButton
        Me.txtsigsrno = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.pnl = New System.Windows.Forms.GroupBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.cmbreflot = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbpower = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnClear = New System.Windows.Forms.Button
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.pnl.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbShPower
        '
        Me.CmbShPower.FormattingEnabled = True
        Me.CmbShPower.Items.AddRange(New Object() {"1", "2", "3"})
        Me.CmbShPower.Location = New System.Drawing.Point(103, 23)
        Me.CmbShPower.Name = "CmbShPower"
        Me.CmbShPower.Size = New System.Drawing.Size(128, 21)
        Me.CmbShPower.TabIndex = 2
        '
        'txtcrMaxQty
        '
        Me.txtcrMaxQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcrMaxQty.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcrMaxQty.Location = New System.Drawing.Point(100, 61)
        Me.txtcrMaxQty.Name = "txtcrMaxQty"
        Me.txtcrMaxQty.Size = New System.Drawing.Size(135, 22)
        Me.txtcrMaxQty.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(19, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 16)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Qty"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(19, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Power"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnSave)
        Me.GroupBox4.Controls.Add(Me.BtnExit)
        Me.GroupBox4.Location = New System.Drawing.Point(302, 9)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(266, 72)
        Me.GroupBox4.TabIndex = 61
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Visible = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.White
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnSave.Location = New System.Drawing.Point(22, 19)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(94, 32)
        Me.BtnSave.TabIndex = 48
        Me.BtnSave.Text = " SAVE"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.White
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.Red
        Me.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExit.Location = New System.Drawing.Point(154, 19)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(94, 32)
        Me.BtnExit.TabIndex = 50
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbShPower)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtcrMaxQty)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(266, 101)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'cmbPrintLabel
        '
        Me.cmbPrintLabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPrintLabel.ForeColor = System.Drawing.Color.Red
        Me.cmbPrintLabel.FormattingEnabled = True
        Me.cmbPrintLabel.Location = New System.Drawing.Point(52, 128)
        Me.cmbPrintLabel.Name = "cmbPrintLabel"
        Me.cmbPrintLabel.Size = New System.Drawing.Size(291, 26)
        Me.cmbPrintLabel.TabIndex = 81
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Blue
        Me.Label26.Location = New System.Drawing.Point(12, 133)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(38, 14)
        Me.Label26.TabIndex = 80
        Me.Label26.Text = "Label"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.txtsigsrno)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(32, 163)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(977, 136)
        Me.GroupBox2.TabIndex = 79
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdUDICode)
        Me.GroupBox3.Controls.Add(Me.rdLotSerial)
        Me.GroupBox3.Location = New System.Drawing.Point(733, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 88)
        Me.GroupBox3.TabIndex = 73
        Me.GroupBox3.TabStop = False
        '
        'rdUDICode
        '
        Me.rdUDICode.AutoSize = True
        Me.rdUDICode.Checked = True
        Me.rdUDICode.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdUDICode.ForeColor = System.Drawing.Color.Red
        Me.rdUDICode.Location = New System.Drawing.Point(28, 47)
        Me.rdUDICode.Name = "rdUDICode"
        Me.rdUDICode.Size = New System.Drawing.Size(93, 19)
        Me.rdUDICode.TabIndex = 71
        Me.rdUDICode.TabStop = True
        Me.rdUDICode.Text = "UDI Serial"
        Me.rdUDICode.UseVisualStyleBackColor = True
        '
        'rdLotSerial
        '
        Me.rdLotSerial.AutoSize = True
        Me.rdLotSerial.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdLotSerial.ForeColor = System.Drawing.Color.Red
        Me.rdLotSerial.Location = New System.Drawing.Point(28, 22)
        Me.rdLotSerial.Name = "rdLotSerial"
        Me.rdLotSerial.Size = New System.Drawing.Size(89, 19)
        Me.rdLotSerial.TabIndex = 72
        Me.rdLotSerial.Text = "Lot Serial"
        Me.rdLotSerial.UseVisualStyleBackColor = True
        '
        'txtsigsrno
        '
        Me.txtsigsrno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsigsrno.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsigsrno.Location = New System.Drawing.Point(400, 37)
        Me.txtsigsrno.Name = "txtsigsrno"
        Me.txtsigsrno.Size = New System.Drawing.Size(179, 29)
        Me.txtsigsrno.TabIndex = 67
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(283, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "From Sr no "
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.TextBox2)
        Me.pnl.Controls.Add(Me.Label7)
        Me.pnl.Controls.Add(Me.ComboBox1)
        Me.pnl.Controls.Add(Me.Label6)
        Me.pnl.Controls.Add(Me.Label8)
        Me.pnl.Controls.Add(Me.TextBox1)
        Me.pnl.Controls.Add(Me.cmbreflot)
        Me.pnl.Controls.Add(Me.Label9)
        Me.pnl.Controls.Add(Me.cmbpower)
        Me.pnl.Controls.Add(Me.Label10)
        Me.pnl.Location = New System.Drawing.Point(32, 336)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(977, 173)
        Me.pnl.TabIndex = 78
        Me.pnl.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(776, 49)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 78
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(743, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 15)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "Qty"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(205, 97)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(184, 21)
        Me.ComboBox1.TabIndex = 76
        Me.ComboBox1.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(143, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 15)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Lot_srno"
        Me.Label6.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(447, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 15)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Label Qty"
        Me.Label8.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(513, 98)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 73
        Me.TextBox1.Visible = False
        '
        'cmbreflot
        '
        Me.cmbreflot.FormattingEnabled = True
        Me.cmbreflot.Location = New System.Drawing.Point(205, 51)
        Me.cmbreflot.Name = "cmbreflot"
        Me.cmbreflot.Size = New System.Drawing.Size(184, 21)
        Me.cmbreflot.TabIndex = 72
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(160, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 15)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Reflot"
        '
        'cmbpower
        '
        Me.cmbpower.FormattingEnabled = True
        Me.cmbpower.Location = New System.Drawing.Point(513, 49)
        Me.cmbpower.Name = "cmbpower"
        Me.cmbpower.Size = New System.Drawing.Size(192, 21)
        Me.cmbpower.TabIndex = 70
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(447, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 17)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "Power"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(557, 553)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 32)
        Me.Button1.TabIndex = 77
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.Color.White
        Me.BtnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnPrint.Location = New System.Drawing.Point(307, 553)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(94, 32)
        Me.BtnPrint.TabIndex = 75
        Me.BtnPrint.Text = "Print"
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.White
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.Navy
        Me.BtnClear.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnClear.Location = New System.Drawing.Point(432, 553)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(94, 32)
        Me.BtnClear.TabIndex = 76
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'FrmPowerLabelPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1020, 712)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmbPrintLabel)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPowerLabelPrint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbShPower As System.Windows.Forms.ComboBox
    Friend WithEvents txtcrMaxQty As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbPrintLabel As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdUDICode As System.Windows.Forms.RadioButton
    Friend WithEvents rdLotSerial As System.Windows.Forms.RadioButton
    Friend WithEvents txtsigsrno As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pnl As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cmbreflot As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbpower As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
End Class
