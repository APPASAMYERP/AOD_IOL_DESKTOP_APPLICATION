<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewPouchLabelPrint_New
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
        Me.cmbPrintLabel = New System.Windows.Forms.ComboBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.pnl = New System.Windows.Forms.GroupBox
        Me.GRID1 = New System.Windows.Forms.DataGridView
        Me.ScanLot_srNo = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.BtnExit = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.cmbreflot = New System.Windows.Forms.ComboBox
        Me.BtnClear = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbpower = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.RdoRef = New System.Windows.Forms.RadioButton
        Me.rdobrand = New System.Windows.Forms.RadioButton
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label9 = New System.Windows.Forms.Label
        Me.btn_Complete = New System.Windows.Forms.Button
        Me.pnl.SuspendLayout()
        CType(Me.GRID1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbPrintLabel
        '
        Me.cmbPrintLabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPrintLabel.ForeColor = System.Drawing.Color.Red
        Me.cmbPrintLabel.FormattingEnabled = True
        Me.cmbPrintLabel.Location = New System.Drawing.Point(89, 49)
        Me.cmbPrintLabel.Name = "cmbPrintLabel"
        Me.cmbPrintLabel.Size = New System.Drawing.Size(327, 26)
        Me.cmbPrintLabel.TabIndex = 83
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Blue
        Me.Label26.Location = New System.Drawing.Point(49, 54)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(38, 14)
        Me.Label26.TabIndex = 82
        Me.Label26.Text = "Label"
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GRID1)
        Me.pnl.Controls.Add(Me.ScanLot_srNo)
        Me.pnl.Controls.Add(Me.TextBox2)
        Me.pnl.Controls.Add(Me.Label7)
        Me.pnl.Controls.Add(Me.Label6)
        Me.pnl.Controls.Add(Me.Label8)
        Me.pnl.Controls.Add(Me.BtnExit)
        Me.pnl.Controls.Add(Me.TextBox1)
        Me.pnl.Controls.Add(Me.btn_Complete)
        Me.pnl.Controls.Add(Me.BtnPrint)
        Me.pnl.Controls.Add(Me.cmbreflot)
        Me.pnl.Controls.Add(Me.BtnClear)
        Me.pnl.Controls.Add(Me.Label5)
        Me.pnl.Controls.Add(Me.cmbpower)
        Me.pnl.Controls.Add(Me.Label3)
        Me.pnl.Location = New System.Drawing.Point(24, 96)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(936, 445)
        Me.pnl.TabIndex = 78
        Me.pnl.TabStop = False
        '
        'GRID1
        '
        Me.GRID1.AllowUserToDeleteRows = False
        Me.GRID1.BackgroundColor = System.Drawing.Color.White
        Me.GRID1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GRID1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.GRID1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GRID1.Location = New System.Drawing.Point(478, 59)
        Me.GRID1.Name = "GRID1"
        Me.GRID1.Size = New System.Drawing.Size(404, 367)
        Me.GRID1.TabIndex = 80
        '
        'ScanLot_srNo
        '
        Me.ScanLot_srNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScanLot_srNo.Location = New System.Drawing.Point(165, 128)
        Me.ScanLot_srNo.Name = "ScanLot_srNo"
        Me.ScanLot_srNo.Size = New System.Drawing.Size(264, 38)
        Me.ScanLot_srNo.TabIndex = 79
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(783, 21)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 78
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(750, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 15)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "Qty"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(6, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 27)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Scan Lot SrNo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(476, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 15)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Label Qty"
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.White
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.Red
        Me.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExit.Location = New System.Drawing.Point(266, 219)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(94, 32)
        Me.BtnExit.TabIndex = 77
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(542, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 73
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.Color.White
        Me.BtnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnPrint.Location = New System.Drawing.Point(141, 309)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(94, 32)
        Me.BtnPrint.TabIndex = 75
        Me.BtnPrint.Text = "Print"
        Me.BtnPrint.UseVisualStyleBackColor = False
        Me.BtnPrint.Visible = False
        '
        'cmbreflot
        '
        Me.cmbreflot.FormattingEnabled = True
        Me.cmbreflot.Location = New System.Drawing.Point(130, 31)
        Me.cmbreflot.Name = "cmbreflot"
        Me.cmbreflot.Size = New System.Drawing.Size(184, 21)
        Me.cmbreflot.TabIndex = 72
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.White
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.Navy
        Me.BtnClear.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnClear.Location = New System.Drawing.Point(141, 219)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(94, 32)
        Me.BtnClear.TabIndex = 76
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(28, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Reflot"
        '
        'cmbpower
        '
        Me.cmbpower.FormattingEnabled = True
        Me.cmbpower.Location = New System.Drawing.Point(130, 75)
        Me.cmbpower.Name = "cmbpower"
        Me.cmbpower.Size = New System.Drawing.Size(192, 21)
        Me.cmbpower.TabIndex = 70
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(24, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Power"
        '
        'RdoRef
        '
        Me.RdoRef.AutoSize = True
        Me.RdoRef.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoRef.ForeColor = System.Drawing.Color.Red
        Me.RdoRef.Location = New System.Drawing.Point(587, 51)
        Me.RdoRef.Name = "RdoRef"
        Me.RdoRef.Size = New System.Drawing.Size(131, 19)
        Me.RdoRef.TabIndex = 80
        Me.RdoRef.Text = "Reference Name"
        Me.RdoRef.UseVisualStyleBackColor = True
        Me.RdoRef.Visible = False
        '
        'rdobrand
        '
        Me.rdobrand.AutoSize = True
        Me.rdobrand.Checked = True
        Me.rdobrand.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdobrand.ForeColor = System.Drawing.Color.Red
        Me.rdobrand.Location = New System.Drawing.Point(439, 51)
        Me.rdobrand.Name = "rdobrand"
        Me.rdobrand.Size = New System.Drawing.Size(107, 19)
        Me.rdobrand.TabIndex = 79
        Me.rdobrand.TabStop = True
        Me.rdobrand.Text = "Brand Name"
        Me.rdobrand.UseVisualStyleBackColor = True
        Me.rdobrand.Visible = False
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(286, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(241, 24)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "POUCH LABEL PRINT"
        '
        'btn_Complete
        '
        Me.btn_Complete.BackColor = System.Drawing.Color.White
        Me.btn_Complete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Complete.ForeColor = System.Drawing.Color.DarkGreen
        Me.btn_Complete.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Complete.Location = New System.Drawing.Point(11, 219)
        Me.btn_Complete.Name = "btn_Complete"
        Me.btn_Complete.Size = New System.Drawing.Size(94, 32)
        Me.btn_Complete.TabIndex = 75
        Me.btn_Complete.Text = "Complete"
        Me.btn_Complete.UseVisualStyleBackColor = False
        '
        'FrmNewPouchLabelPrint_New
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(972, 569)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbPrintLabel)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.RdoRef)
        Me.Controls.Add(Me.rdobrand)
        Me.Controls.Add(Me.pnl)
        Me.Name = "FrmNewPouchLabelPrint_New"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        CType(Me.GRID1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbPrintLabel As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents pnl As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cmbreflot As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbpower As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents RdoRef As System.Windows.Forms.RadioButton
    Friend WithEvents rdobrand As System.Windows.Forms.RadioButton
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ScanLot_srNo As System.Windows.Forms.TextBox
    Friend WithEvents GRID1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Complete As System.Windows.Forms.Button
End Class
