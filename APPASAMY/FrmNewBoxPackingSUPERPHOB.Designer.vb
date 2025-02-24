<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewBoxPackingSUPERPHOB
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
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.rb_with_Injector = New System.Windows.Forms.RadioButton
        Me.rb_without_Injector = New System.Windows.Forms.RadioButton
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.rdLotSerial = New System.Windows.Forms.RadioButton
        Me.rdUDICode = New System.Windows.Forms.RadioButton
        Me.cmbPrintLabel = New System.Windows.Forms.ComboBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtinj_No = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BtnExit = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtlotbarno = New System.Windows.Forms.TextBox
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.rb_with_Injector)
        Me.GroupBox9.Controls.Add(Me.rb_without_Injector)
        Me.GroupBox9.Location = New System.Drawing.Point(36, 27)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(579, 54)
        Me.GroupBox9.TabIndex = 80
        Me.GroupBox9.TabStop = False
        '
        'rb_with_Injector
        '
        Me.rb_with_Injector.AutoSize = True
        Me.rb_with_Injector.Checked = True
        Me.rb_with_Injector.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_with_Injector.ForeColor = System.Drawing.Color.Red
        Me.rb_with_Injector.Location = New System.Drawing.Point(30, 17)
        Me.rb_with_Injector.Name = "rb_with_Injector"
        Me.rb_with_Injector.Size = New System.Drawing.Size(117, 21)
        Me.rb_with_Injector.TabIndex = 66
        Me.rb_with_Injector.TabStop = True
        Me.rb_with_Injector.Text = "With Injector"
        Me.rb_with_Injector.UseVisualStyleBackColor = True
        '
        'rb_without_Injector
        '
        Me.rb_without_Injector.AutoSize = True
        Me.rb_without_Injector.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_without_Injector.ForeColor = System.Drawing.Color.Red
        Me.rb_without_Injector.Location = New System.Drawing.Point(361, 17)
        Me.rb_without_Injector.Name = "rb_without_Injector"
        Me.rb_without_Injector.Size = New System.Drawing.Size(140, 21)
        Me.rb_without_Injector.TabIndex = 65
        Me.rb_without_Injector.Text = "Without Injector"
        Me.rb_without_Injector.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.rdLotSerial)
        Me.GroupBox8.Controls.Add(Me.rdUDICode)
        Me.GroupBox8.Location = New System.Drawing.Point(36, 135)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(258, 78)
        Me.GroupBox8.TabIndex = 79
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Lens"
        Me.GroupBox8.Visible = False
        '
        'rdLotSerial
        '
        Me.rdLotSerial.AutoSize = True
        Me.rdLotSerial.Checked = True
        Me.rdLotSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdLotSerial.ForeColor = System.Drawing.Color.Red
        Me.rdLotSerial.Location = New System.Drawing.Point(11, 31)
        Me.rdLotSerial.Name = "rdLotSerial"
        Me.rdLotSerial.Size = New System.Drawing.Size(96, 21)
        Me.rdLotSerial.TabIndex = 69
        Me.rdLotSerial.TabStop = True
        Me.rdLotSerial.Text = "Lot Serial"
        Me.rdLotSerial.UseVisualStyleBackColor = True
        '
        'rdUDICode
        '
        Me.rdUDICode.AutoSize = True
        Me.rdUDICode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdUDICode.ForeColor = System.Drawing.Color.Red
        Me.rdUDICode.Location = New System.Drawing.Point(126, 31)
        Me.rdUDICode.Name = "rdUDICode"
        Me.rdUDICode.Size = New System.Drawing.Size(99, 21)
        Me.rdUDICode.TabIndex = 70
        Me.rdUDICode.Text = "UDI Serial"
        Me.rdUDICode.UseVisualStyleBackColor = True
        '
        'cmbPrintLabel
        '
        Me.cmbPrintLabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPrintLabel.ForeColor = System.Drawing.Color.Red
        Me.cmbPrintLabel.FormattingEnabled = True
        Me.cmbPrintLabel.Location = New System.Drawing.Point(79, 95)
        Me.cmbPrintLabel.Name = "cmbPrintLabel"
        Me.cmbPrintLabel.Size = New System.Drawing.Size(338, 26)
        Me.cmbPrintLabel.TabIndex = 78
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Blue
        Me.Label26.Location = New System.Drawing.Point(39, 100)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(38, 14)
        Me.Label26.TabIndex = 77
        Me.Label26.Text = "Label"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.txtinj_No)
        Me.GroupBox7.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Red
        Me.GroupBox7.Location = New System.Drawing.Point(36, 219)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(582, 87)
        Me.GroupBox7.TabIndex = 76
        Me.GroupBox7.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(47, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 29)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Scan Injector"
        '
        'txtinj_No
        '
        Me.txtinj_No.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinj_No.Location = New System.Drawing.Point(228, 25)
        Me.txtinj_No.Name = "txtinj_No"
        Me.txtinj_No.Size = New System.Drawing.Size(317, 48)
        Me.txtinj_No.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnExit)
        Me.GroupBox3.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Red
        Me.GroupBox3.Location = New System.Drawing.Point(36, 479)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(582, 77)
        Me.GroupBox3.TabIndex = 75
        Me.GroupBox3.TabStop = False
        '
        'BtnExit
        '
        Me.BtnExit.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.Red
        Me.BtnExit.Location = New System.Drawing.Point(237, 22)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(108, 42)
        Me.BtnExit.TabIndex = 43
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtlotbarno)
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(36, 314)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(582, 87)
        Me.GroupBox2.TabIndex = 74
        Me.GroupBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(6, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(207, 29)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Scan Lot No Sr.No"
        '
        'txtlotbarno
        '
        Me.txtlotbarno.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlotbarno.Location = New System.Drawing.Point(228, 25)
        Me.txtlotbarno.Name = "txtlotbarno"
        Me.txtlotbarno.Size = New System.Drawing.Size(317, 48)
        Me.txtlotbarno.TabIndex = 0
        '
        'FrmNewBoxPackingSUPERPHOB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 623)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.cmbPrintLabel)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FrmNewBoxPackingSUPERPHOB"
        Me.Text = "FrmNewBoxPackingSUPERPHOB"
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_with_Injector As System.Windows.Forms.RadioButton
    Friend WithEvents rb_without_Injector As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents rdLotSerial As System.Windows.Forms.RadioButton
    Friend WithEvents rdUDICode As System.Windows.Forms.RadioButton
    Friend WithEvents cmbPrintLabel As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtinj_No As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtlotbarno As System.Windows.Forms.TextBox
End Class
