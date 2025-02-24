<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSampleScan
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lens_count = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.btn_clear = New System.Windows.Forms.Button
        Me.btc_comple = New System.Windows.Forms.Button
        Me.btn_exit = New System.Windows.Forms.Button
        Me.txt_lotscan = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.drop_sampletype = New System.Windows.Forms.ComboBox
        Me.lbl_reason = New System.Windows.Forms.Label
        Me.cmb_remark = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.rdUDICode = New System.Windows.Forms.RadioButton
        Me.rdLotSerial = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1300, 68)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(499, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(267, 29)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "SAMPLES SCAN FORM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(94, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 29)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "CHOOSE SAMPLE TYPE"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.btn_clear)
        Me.GroupBox2.Controls.Add(Me.btc_comple)
        Me.GroupBox2.Controls.Add(Me.btn_exit)
        Me.GroupBox2.Controls.Add(Me.txt_lotscan)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(191, 161)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(983, 520)
        Me.GroupBox2.TabIndex = 81
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.lens_count)
        Me.GroupBox3.Location = New System.Drawing.Point(784, 143)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(99, 138)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(6, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Total Count"
        '
        'lens_count
        '
        Me.lens_count.AutoSize = True
        Me.lens_count.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lens_count.ForeColor = System.Drawing.Color.Red
        Me.lens_count.Location = New System.Drawing.Point(30, 59)
        Me.lens_count.Name = "lens_count"
        Me.lens_count.Size = New System.Drawing.Size(35, 40)
        Me.lens_count.TabIndex = 32
        Me.lens_count.Text = "0"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(107, 91)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(626, 356)
        Me.DataGridView1.TabIndex = 43
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.Color.Red
        Me.btn_clear.Location = New System.Drawing.Point(367, 472)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(108, 42)
        Me.btn_clear.TabIndex = 30
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btc_comple
        '
        Me.btc_comple.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btc_comple.ForeColor = System.Drawing.Color.Red
        Me.btc_comple.Location = New System.Drawing.Point(191, 472)
        Me.btc_comple.Name = "btc_comple"
        Me.btc_comple.Size = New System.Drawing.Size(108, 42)
        Me.btc_comple.TabIndex = 28
        Me.btc_comple.Text = "Complete"
        Me.btc_comple.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Red
        Me.btn_exit.Location = New System.Drawing.Point(540, 472)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(108, 42)
        Me.btn_exit.TabIndex = 29
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'txt_lotscan
        '
        Me.txt_lotscan.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lotscan.Location = New System.Drawing.Point(309, 19)
        Me.txt_lotscan.Name = "txt_lotscan"
        Me.txt_lotscan.Size = New System.Drawing.Size(381, 48)
        Me.txt_lotscan.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(131, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 29)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Scan Lot No"
        '
        'drop_sampletype
        '
        Me.drop_sampletype.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drop_sampletype.FormattingEnabled = True
        Me.drop_sampletype.Location = New System.Drawing.Point(382, 104)
        Me.drop_sampletype.Name = "drop_sampletype"
        Me.drop_sampletype.Size = New System.Drawing.Size(381, 33)
        Me.drop_sampletype.TabIndex = 84
        '
        'lbl_reason
        '
        Me.lbl_reason.AutoSize = True
        Me.lbl_reason.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_reason.ForeColor = System.Drawing.Color.Blue
        Me.lbl_reason.Location = New System.Drawing.Point(789, 108)
        Me.lbl_reason.Name = "lbl_reason"
        Me.lbl_reason.Size = New System.Drawing.Size(111, 29)
        Me.lbl_reason.TabIndex = 83
        Me.lbl_reason.Text = "REASON"
        Me.lbl_reason.Visible = False
        '
        'cmb_remark
        '
        Me.cmb_remark.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_remark.Location = New System.Drawing.Point(906, 96)
        Me.cmb_remark.Name = "cmb_remark"
        Me.cmb_remark.Size = New System.Drawing.Size(242, 48)
        Me.cmb_remark.TabIndex = 85
        Me.cmb_remark.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rdUDICode)
        Me.GroupBox4.Controls.Add(Me.rdLotSerial)
        Me.GroupBox4.Location = New System.Drawing.Point(784, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(164, 77)
        Me.GroupBox4.TabIndex = 86
        Me.GroupBox4.TabStop = False
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
        'frmSampleScan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1349, 688)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmb_remark)
        Me.Controls.Add(Me.drop_sampletype)
        Me.Controls.Add(Me.lbl_reason)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSampleScan"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSampleScan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lens_count As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btc_comple As System.Windows.Forms.Button
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents txt_lotscan As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents drop_sampletype As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_reason As System.Windows.Forms.Label
    Friend WithEvents cmb_remark As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rdUDICode As System.Windows.Forms.RadioButton
    Friend WithEvents rdLotSerial As System.Windows.Forms.RadioButton
End Class
