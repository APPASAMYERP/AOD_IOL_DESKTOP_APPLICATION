<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportLensTracking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReportLensTracking))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.txtlotbarno = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rdLotSerial = New System.Windows.Forms.RadioButton
        Me.rdUDICode = New System.Windows.Forms.RadioButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GRID1 = New System.Windows.Forms.DataGridView
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRID1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtlotbarno
        '
        Me.txtlotbarno.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlotbarno.Location = New System.Drawing.Point(212, 112)
        Me.txtlotbarno.Name = "txtlotbarno"
        Me.txtlotbarno.Size = New System.Drawing.Size(317, 48)
        Me.txtlotbarno.TabIndex = 68
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(43, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 29)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Scan Lot No"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdLotSerial)
        Me.GroupBox3.Controls.Add(Me.rdUDICode)
        Me.GroupBox3.Location = New System.Drawing.Point(35, 26)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(494, 63)
        Me.GroupBox3.TabIndex = 70
        Me.GroupBox3.TabStop = False
        '
        'rdLotSerial
        '
        Me.rdLotSerial.AutoSize = True
        Me.rdLotSerial.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdLotSerial.ForeColor = System.Drawing.Color.Red
        Me.rdLotSerial.Location = New System.Drawing.Point(347, 19)
        Me.rdLotSerial.Name = "rdLotSerial"
        Me.rdLotSerial.Size = New System.Drawing.Size(89, 19)
        Me.rdLotSerial.TabIndex = 72
        Me.rdLotSerial.Text = "Lot Serial"
        Me.rdLotSerial.UseVisualStyleBackColor = True
        '
        'rdUDICode
        '
        Me.rdUDICode.AutoSize = True
        Me.rdUDICode.Checked = True
        Me.rdUDICode.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdUDICode.ForeColor = System.Drawing.Color.Red
        Me.rdUDICode.Location = New System.Drawing.Point(29, 19)
        Me.rdUDICode.Name = "rdUDICode"
        Me.rdUDICode.Size = New System.Drawing.Size(93, 19)
        Me.rdUDICode.TabIndex = 71
        Me.rdUDICode.TabStop = True
        Me.rdUDICode.Text = "UDI Serial"
        Me.rdUDICode.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(1009, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 77
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
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
        Me.GRID1.Location = New System.Drawing.Point(561, 12)
        Me.GRID1.Name = "GRID1"
        Me.GRID1.Size = New System.Drawing.Size(394, 624)
        Me.GRID1.TabIndex = 78
        '
        'FrmReportLensTracking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1052, 648)
        Me.Controls.Add(Me.GRID1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtlotbarno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "FrmReportLensTracking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRID1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtlotbarno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdLotSerial As System.Windows.Forms.RadioButton
    Friend WithEvents rdUDICode As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GRID1 As System.Windows.Forms.DataGridView
End Class
