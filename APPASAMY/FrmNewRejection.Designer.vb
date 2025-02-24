<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewRejection
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
        Me.RdoRej = New System.Windows.Forms.RadioButton
        Me.rdorework = New System.Windows.Forms.RadioButton
        Me.txtlotbarno = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblSterileNo = New System.Windows.Forms.Label
        Me.txtMTSNo = New System.Windows.Forms.TextBox
        Me.BtnExit = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rdLotSerial = New System.Windows.Forms.RadioButton
        Me.rdUDICode = New System.Windows.Forms.RadioButton
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RdoRej
        '
        Me.RdoRej.AutoSize = True
        Me.RdoRej.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoRej.ForeColor = System.Drawing.Color.Red
        Me.RdoRej.Location = New System.Drawing.Point(376, 19)
        Me.RdoRej.Name = "RdoRej"
        Me.RdoRej.Size = New System.Drawing.Size(194, 20)
        Me.RdoRej.TabIndex = 38
        Me.RdoRej.Text = "Box Packing - Rejection"
        Me.RdoRej.UseVisualStyleBackColor = True
        Me.RdoRej.Visible = False
        '
        'rdorework
        '
        Me.rdorework.AutoSize = True
        Me.rdorework.Checked = True
        Me.rdorework.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdorework.ForeColor = System.Drawing.Color.Red
        Me.rdorework.Location = New System.Drawing.Point(80, 19)
        Me.rdorework.Name = "rdorework"
        Me.rdorework.Size = New System.Drawing.Size(163, 20)
        Me.rdorework.TabIndex = 37
        Me.rdorework.TabStop = True
        Me.rdorework.Text = "Sterilization Reject"
        Me.rdorework.UseVisualStyleBackColor = True
        '
        'txtlotbarno
        '
        Me.txtlotbarno.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlotbarno.Location = New System.Drawing.Point(285, 56)
        Me.txtlotbarno.Name = "txtlotbarno"
        Me.txtlotbarno.Size = New System.Drawing.Size(317, 48)
        Me.txtlotbarno.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(48, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(207, 29)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Scan Lot No Sr.No"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.rdorework)
        Me.GroupBox7.Controls.Add(Me.RdoRej)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 29)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(724, 64)
        Me.GroupBox7.TabIndex = 57
        Me.GroupBox7.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lblSterileNo)
        Me.GroupBox1.Controls.Add(Me.txtMTSNo)
        Me.GroupBox1.Controls.Add(Me.txtlotbarno)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 167)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(724, 182)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(50, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 16)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "MTS NO"
        '
        'lblSterileNo
        '
        Me.lblSterileNo.AutoSize = True
        Me.lblSterileNo.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSterileNo.ForeColor = System.Drawing.Color.Blue
        Me.lblSterileNo.Location = New System.Drawing.Point(60, 129)
        Me.lblSterileNo.Name = "lblSterileNo"
        Me.lblSterileNo.Size = New System.Drawing.Size(15, 23)
        Me.lblSterileNo.TabIndex = 26
        Me.lblSterileNo.Text = "."
        '
        'txtMTSNo
        '
        Me.txtMTSNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMTSNo.Enabled = False
        Me.txtMTSNo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMTSNo.Location = New System.Drawing.Point(113, 19)
        Me.txtMTSNo.Name = "txtMTSNo"
        Me.txtMTSNo.Size = New System.Drawing.Size(309, 22)
        Me.txtMTSNo.TabIndex = 61
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.White
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.Red
        Me.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExit.Location = New System.Drawing.Point(311, 355)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(94, 32)
        Me.BtnExit.TabIndex = 59
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdLotSerial)
        Me.GroupBox2.Controls.Add(Me.rdUDICode)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 100)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(724, 64)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        '
        'rdLotSerial
        '
        Me.rdLotSerial.AutoSize = True
        Me.rdLotSerial.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdLotSerial.ForeColor = System.Drawing.Color.Red
        Me.rdLotSerial.Location = New System.Drawing.Point(80, 19)
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
        Me.rdUDICode.Location = New System.Drawing.Point(385, 19)
        Me.rdUDICode.Name = "rdUDICode"
        Me.rdUDICode.Size = New System.Drawing.Size(93, 19)
        Me.rdUDICode.TabIndex = 71
        Me.rdUDICode.TabStop = True
        Me.rdUDICode.Text = "UDI Serial"
        Me.rdUDICode.UseVisualStyleBackColor = True
        '
        'FrmNewRejection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(777, 424)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmNewRejection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RdoRej As System.Windows.Forms.RadioButton
    Friend WithEvents rdorework As System.Windows.Forms.RadioButton
    Friend WithEvents txtlotbarno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents lblSterileNo As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdLotSerial As System.Windows.Forms.RadioButton
    Friend WithEvents rdUDICode As System.Windows.Forms.RadioButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtMTSNo As System.Windows.Forms.TextBox
End Class
