<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewPouchReprint
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
        Me.txtcrFromQty = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.pnl = New System.Windows.Forms.GroupBox
        Me.BtnClear = New System.Windows.Forms.Button
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.txtcrToQty = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.RdoRef = New System.Windows.Forms.RadioButton
        Me.rdobrand = New System.Windows.Forms.RadioButton
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rdUDICode = New System.Windows.Forms.RadioButton
        Me.rdLotSerial = New System.Windows.Forms.RadioButton
        Me.txtsigsrno = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbPrintLabel = New System.Windows.Forms.ComboBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.pnl.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtcrFromQty
        '
        Me.txtcrFromQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcrFromQty.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcrFromQty.Location = New System.Drawing.Point(135, 57)
        Me.txtcrFromQty.Name = "txtcrFromQty"
        Me.txtcrFromQty.Size = New System.Drawing.Size(179, 29)
        Me.txtcrFromQty.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(27, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "From Sr no"
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.BtnClear)
        Me.pnl.Controls.Add(Me.RadioButton2)
        Me.pnl.Controls.Add(Me.BtnPrint)
        Me.pnl.Controls.Add(Me.BtnExit)
        Me.pnl.Controls.Add(Me.txtcrFromQty)
        Me.pnl.Controls.Add(Me.Label2)
        Me.pnl.Controls.Add(Me.txtcrToQty)
        Me.pnl.Controls.Add(Me.Label4)
        Me.pnl.Location = New System.Drawing.Point(73, 280)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(604, 151)
        Me.pnl.TabIndex = 61
        Me.pnl.TabStop = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.White
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.Navy
        Me.BtnClear.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnClear.Location = New System.Drawing.Point(219, 105)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(94, 32)
        Me.BtnClear.TabIndex = 3
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.Red
        Me.RadioButton2.Location = New System.Drawing.Point(18, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(56, 19)
        Me.RadioButton2.TabIndex = 67
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Bulk"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.Color.White
        Me.BtnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnPrint.Location = New System.Drawing.Point(94, 105)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(94, 32)
        Me.BtnPrint.TabIndex = 2
        Me.BtnPrint.Text = "Print"
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.White
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.Red
        Me.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExit.Location = New System.Drawing.Point(344, 105)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(94, 32)
        Me.BtnExit.TabIndex = 4
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'txtcrToQty
        '
        Me.txtcrToQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcrToQty.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcrToQty.Location = New System.Drawing.Point(419, 57)
        Me.txtcrToQty.Name = "txtcrToQty"
        Me.txtcrToQty.Size = New System.Drawing.Size(179, 29)
        Me.txtcrToQty.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(322, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "To Sr no "
        '
        'RdoRef
        '
        Me.RdoRef.AutoSize = True
        Me.RdoRef.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoRef.ForeColor = System.Drawing.Color.Red
        Me.RdoRef.Location = New System.Drawing.Point(457, 116)
        Me.RdoRef.Name = "RdoRef"
        Me.RdoRef.Size = New System.Drawing.Size(131, 19)
        Me.RdoRef.TabIndex = 65
        Me.RdoRef.Text = "Reference Name"
        Me.RdoRef.UseVisualStyleBackColor = True
        '
        'rdobrand
        '
        Me.rdobrand.AutoSize = True
        Me.rdobrand.Checked = True
        Me.rdobrand.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdobrand.ForeColor = System.Drawing.Color.Red
        Me.rdobrand.Location = New System.Drawing.Point(457, 81)
        Me.rdobrand.Name = "rdobrand"
        Me.rdobrand.Size = New System.Drawing.Size(107, 19)
        Me.rdobrand.TabIndex = 64
        Me.rdobrand.TabStop = True
        Me.rdobrand.Text = "Brand Name"
        Me.rdobrand.UseVisualStyleBackColor = True
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.Red
        Me.RadioButton1.Location = New System.Drawing.Point(21, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(66, 19)
        Me.RadioButton1.TabIndex = 66
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Single"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtsigsrno)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(73, 159)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(604, 115)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdUDICode)
        Me.GroupBox2.Controls.Add(Me.rdLotSerial)
        Me.GroupBox2.Location = New System.Drawing.Point(433, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(164, 77)
        Me.GroupBox2.TabIndex = 69
        Me.GroupBox2.TabStop = False
        '
        'rdUDICode
        '
        Me.rdUDICode.AutoSize = True
        Me.rdUDICode.Checked = True
        Me.rdUDICode.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdUDICode.ForeColor = System.Drawing.Color.Red
        Me.rdUDICode.Location = New System.Drawing.Point(33, 48)
        Me.rdUDICode.Name = "rdUDICode"
        Me.rdUDICode.Size = New System.Drawing.Size(93, 19)
        Me.rdUDICode.TabIndex = 66
        Me.rdUDICode.TabStop = True
        Me.rdUDICode.Text = "UDI Serial"
        Me.rdUDICode.UseVisualStyleBackColor = True
        '
        'rdLotSerial
        '
        Me.rdLotSerial.AutoSize = True
        Me.rdLotSerial.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdLotSerial.ForeColor = System.Drawing.Color.Red
        Me.rdLotSerial.Location = New System.Drawing.Point(33, 23)
        Me.rdLotSerial.Name = "rdLotSerial"
        Me.rdLotSerial.Size = New System.Drawing.Size(89, 19)
        Me.rdLotSerial.TabIndex = 66
        Me.rdLotSerial.Text = "Lot Serial"
        Me.rdLotSerial.UseVisualStyleBackColor = True
        '
        'txtsigsrno
        '
        Me.txtsigsrno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsigsrno.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsigsrno.Location = New System.Drawing.Point(218, 59)
        Me.txtsigsrno.Name = "txtsigsrno"
        Me.txtsigsrno.Size = New System.Drawing.Size(179, 29)
        Me.txtsigsrno.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(110, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "From Sr no "
        '
        'cmbPrintLabel
        '
        Me.cmbPrintLabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPrintLabel.ForeColor = System.Drawing.Color.Red
        Me.cmbPrintLabel.FormattingEnabled = True
        Me.cmbPrintLabel.Location = New System.Drawing.Point(113, 109)
        Me.cmbPrintLabel.Name = "cmbPrintLabel"
        Me.cmbPrintLabel.Size = New System.Drawing.Size(212, 26)
        Me.cmbPrintLabel.TabIndex = 70
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Blue
        Me.Label26.Location = New System.Drawing.Point(73, 114)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(38, 14)
        Me.Label26.TabIndex = 69
        Me.Label26.Text = "Label"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(240, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(271, 24)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "POUCH LABEL REPRINT"
        '
        'FrmNewPouchReprint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(762, 501)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbPrintLabel)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RdoRef)
        Me.Controls.Add(Me.rdobrand)
        Me.Controls.Add(Me.pnl)
        Me.Name = "FrmNewPouchReprint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtcrFromQty As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnl As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents txtcrToQty As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RdoRef As System.Windows.Forms.RadioButton
    Friend WithEvents rdobrand As System.Windows.Forms.RadioButton
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtsigsrno As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents cmbPrintLabel As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents rdLotSerial As System.Windows.Forms.RadioButton
    Friend WithEvents rdUDICode As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
