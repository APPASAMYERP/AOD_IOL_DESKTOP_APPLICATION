<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LensTracking
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
        Me.GRID2 = New System.Windows.Forms.DataGridView
        Me.txtlotbarno = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GRID1 = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtchange = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rdbtc = New System.Windows.Forms.RadioButton
        Me.rdblanksId = New System.Windows.Forms.RadioButton
        Me.rdUDICode = New System.Windows.Forms.RadioButton
        Me.rdLotSerial = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.grop1 = New System.Windows.Forms.RadioButton
        Me.group2 = New System.Windows.Forms.RadioButton
        Me.BtnClear = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtScanLot_srNO = New System.Windows.Forms.TextBox
        Me.grp1 = New System.Windows.Forms.GroupBox
        Me.grp2 = New System.Windows.Forms.GroupBox
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRID1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grp1.SuspendLayout()
        Me.grp2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GRID2
        '
        Me.GRID2.BackgroundColor = System.Drawing.Color.White
        Me.GRID2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRID2.Location = New System.Drawing.Point(103, 425)
        Me.GRID2.Name = "GRID2"
        Me.GRID2.Size = New System.Drawing.Size(295, 387)
        Me.GRID2.TabIndex = 85
        '
        'txtlotbarno
        '
        Me.txtlotbarno.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlotbarno.Location = New System.Drawing.Point(248, 41)
        Me.txtlotbarno.Name = "txtlotbarno"
        Me.txtlotbarno.Size = New System.Drawing.Size(309, 48)
        Me.txtlotbarno.TabIndex = 82
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(30, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 29)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Enter Blanks ID"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.Navy
        Me.Button1.Location = New System.Drawing.Point(780, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(217, 28)
        Me.Button1.TabIndex = 87
        Me.Button1.Text = "Export To Excel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GRID1
        '
        Me.GRID1.AllowUserToDeleteRows = False
        Me.GRID1.BackgroundColor = System.Drawing.Color.White
        Me.GRID1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GRID1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID1.DefaultCellStyle = DataGridViewCellStyle1
        Me.GRID1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GRID1.Location = New System.Drawing.Point(619, 61)
        Me.GRID1.Name = "GRID1"
        Me.GRID1.Size = New System.Drawing.Size(575, 749)
        Me.GRID1.TabIndex = 86
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(21, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 29)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Selected Lot Srno"
        '
        'txtchange
        '
        Me.txtchange.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchange.Location = New System.Drawing.Point(248, 114)
        Me.txtchange.Name = "txtchange"
        Me.txtchange.Size = New System.Drawing.Size(309, 48)
        Me.txtchange.TabIndex = 90
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdbtc)
        Me.GroupBox3.Controls.Add(Me.rdblanksId)
        Me.GroupBox3.Location = New System.Drawing.Point(32, 32)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(203, 85)
        Me.GroupBox3.TabIndex = 91
        Me.GroupBox3.TabStop = False
        '
        'rdbtc
        '
        Me.rdbtc.AutoSize = True
        Me.rdbtc.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbtc.ForeColor = System.Drawing.Color.Red
        Me.rdbtc.Location = New System.Drawing.Point(29, 44)
        Me.rdbtc.Name = "rdbtc"
        Me.rdbtc.Size = New System.Drawing.Size(120, 19)
        Me.rdbtc.TabIndex = 72
        Me.rdbtc.Text = "Batch Number"
        Me.rdbtc.UseVisualStyleBackColor = True
        '
        'rdblanksId
        '
        Me.rdblanksId.AutoSize = True
        Me.rdblanksId.Checked = True
        Me.rdblanksId.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdblanksId.ForeColor = System.Drawing.Color.Red
        Me.rdblanksId.Location = New System.Drawing.Point(29, 19)
        Me.rdblanksId.Name = "rdblanksId"
        Me.rdblanksId.Size = New System.Drawing.Size(88, 19)
        Me.rdblanksId.TabIndex = 71
        Me.rdblanksId.TabStop = True
        Me.rdblanksId.Text = "Blanks ID"
        Me.rdblanksId.UseVisualStyleBackColor = True
        '
        'rdUDICode
        '
        Me.rdUDICode.AutoSize = True
        Me.rdUDICode.Checked = True
        Me.rdUDICode.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdUDICode.ForeColor = System.Drawing.Color.Red
        Me.rdUDICode.Location = New System.Drawing.Point(17, 20)
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
        Me.rdLotSerial.Location = New System.Drawing.Point(17, 45)
        Me.rdLotSerial.Name = "rdLotSerial"
        Me.rdLotSerial.Size = New System.Drawing.Size(89, 19)
        Me.rdLotSerial.TabIndex = 72
        Me.rdLotSerial.Text = "Lot Serial"
        Me.rdLotSerial.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdLotSerial)
        Me.GroupBox1.Controls.Add(Me.rdUDICode)
        Me.GroupBox1.Location = New System.Drawing.Point(305, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(174, 85)
        Me.GroupBox1.TabIndex = 92
        Me.GroupBox1.TabStop = False
        '
        'grop1
        '
        Me.grop1.AutoSize = True
        Me.grop1.Checked = True
        Me.grop1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grop1.ForeColor = System.Drawing.Color.Red
        Me.grop1.Location = New System.Drawing.Point(61, 12)
        Me.grop1.Name = "grop1"
        Me.grop1.Size = New System.Drawing.Size(146, 19)
        Me.grop1.TabIndex = 93
        Me.grop1.TabStop = True
        Me.grop1.Text = "Batch or Blanks ID"
        Me.grop1.UseVisualStyleBackColor = True
        '
        'group2
        '
        Me.group2.AutoSize = True
        Me.group2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group2.ForeColor = System.Drawing.Color.Red
        Me.group2.Location = New System.Drawing.Point(322, 12)
        Me.group2.Name = "group2"
        Me.group2.Size = New System.Drawing.Size(134, 19)
        Me.group2.TabIndex = 94
        Me.group2.Text = "UDI or Lot Serial"
        Me.group2.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.White
        Me.BtnClear.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.Navy
        Me.BtnClear.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnClear.Location = New System.Drawing.Point(647, 12)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(94, 32)
        Me.BtnClear.TabIndex = 95
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(15, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 29)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Scan Lot Srno"
        '
        'txtScanLot_srNO
        '
        Me.txtScanLot_srNO.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScanLot_srNO.Location = New System.Drawing.Point(248, 19)
        Me.txtScanLot_srNO.Name = "txtScanLot_srNO"
        Me.txtScanLot_srNO.Size = New System.Drawing.Size(309, 48)
        Me.txtScanLot_srNO.TabIndex = 90
        '
        'grp1
        '
        Me.grp1.Controls.Add(Me.txtScanLot_srNO)
        Me.grp1.Controls.Add(Me.Label2)
        Me.grp1.Location = New System.Drawing.Point(12, 327)
        Me.grp1.Name = "grp1"
        Me.grp1.Size = New System.Drawing.Size(581, 92)
        Me.grp1.TabIndex = 96
        Me.grp1.TabStop = False
        '
        'grp2
        '
        Me.grp2.Controls.Add(Me.txtchange)
        Me.grp2.Controls.Add(Me.Label1)
        Me.grp2.Controls.Add(Me.txtlotbarno)
        Me.grp2.Controls.Add(Me.Label5)
        Me.grp2.Location = New System.Drawing.Point(12, 123)
        Me.grp2.Name = "grp2"
        Me.grp2.Size = New System.Drawing.Size(581, 186)
        Me.grp2.TabIndex = 97
        Me.grp2.TabStop = False
        '
        'LensTracking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1206, 822)
        Me.Controls.Add(Me.grp2)
        Me.Controls.Add(Me.grp1)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.group2)
        Me.Controls.Add(Me.grop1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GRID1)
        Me.Controls.Add(Me.GRID2)
        Me.Name = "LensTracking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRID1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grp1.ResumeLayout(False)
        Me.grp1.PerformLayout()
        Me.grp2.ResumeLayout(False)
        Me.grp2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GRID2 As System.Windows.Forms.DataGridView
    Friend WithEvents txtlotbarno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GRID1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtchange As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbtc As System.Windows.Forms.RadioButton
    Friend WithEvents rdblanksId As System.Windows.Forms.RadioButton
    Friend WithEvents rdUDICode As System.Windows.Forms.RadioButton
    Friend WithEvents rdLotSerial As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grop1 As System.Windows.Forms.RadioButton
    Friend WithEvents group2 As System.Windows.Forms.RadioButton
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtScanLot_srNO As System.Windows.Forms.TextBox
    Friend WithEvents grp1 As System.Windows.Forms.GroupBox
    Friend WithEvents grp2 As System.Windows.Forms.GroupBox
End Class
