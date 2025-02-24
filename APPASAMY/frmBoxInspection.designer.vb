<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBoxInspection
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.insdate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.CmbBPL = New System.Windows.Forms.ComboBox
        Me.txtrec = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbrejreason = New System.Windows.Forms.TextBox
        Me.txtacc = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnExit = New System.Windows.Forms.Button
        Me.BtnClear = New System.Windows.Forms.Button
        Me.Save = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GRID1 = New System.Windows.Forms.DataGridView
        Me.GRID2 = New System.Windows.Forms.DataGridView
        Me.Lot_SrNo = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Reason_of_Rejection = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.chkRejection = New System.Windows.Forms.CheckBox
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtMTSNo = New System.Windows.Forms.TextBox
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Textsrscan = New System.Windows.Forms.TextBox
        Me.drpreason = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rdUDICode = New System.Windows.Forms.RadioButton
        Me.rdLotSerial = New System.Windows.Forms.RadioButton
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.GRID1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.insdate)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.CmbBPL)
        Me.GroupBox4.Location = New System.Drawing.Point(31, 45)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(805, 48)
        Me.GroupBox4.TabIndex = 69
        Me.GroupBox4.TabStop = False
        '
        'insdate
        '
        Me.insdate.Location = New System.Drawing.Point(567, 19)
        Me.insdate.Name = "insdate"
        Me.insdate.Size = New System.Drawing.Size(130, 20)
        Me.insdate.TabIndex = 74
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(455, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 16)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Inspection Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(39, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 16)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "BPL NO"
        '
        'CmbBPL
        '
        Me.CmbBPL.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBPL.ForeColor = System.Drawing.Color.Red
        Me.CmbBPL.FormattingEnabled = True
        Me.CmbBPL.Items.AddRange(New Object() {"1", "2", "3"})
        Me.CmbBPL.Location = New System.Drawing.Point(99, 12)
        Me.CmbBPL.Name = "CmbBPL"
        Me.CmbBPL.Size = New System.Drawing.Size(207, 26)
        Me.CmbBPL.TabIndex = 0
        '
        'txtrec
        '
        Me.txtrec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtrec.Enabled = False
        Me.txtrec.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrec.Location = New System.Drawing.Point(99, 522)
        Me.txtrec.Name = "txtrec"
        Me.txtrec.Size = New System.Drawing.Size(88, 22)
        Me.txtrec.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(37, 525)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Rec Qty"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(210, 525)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Acc Qty"
        '
        'cmbrejreason
        '
        Me.cmbrejreason.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmbrejreason.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbrejreason.Location = New System.Drawing.Point(450, 522)
        Me.cmbrejreason.Name = "cmbrejreason"
        Me.cmbrejreason.Size = New System.Drawing.Size(65, 22)
        Me.cmbrejreason.TabIndex = 43
        '
        'txtacc
        '
        Me.txtacc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtacc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtacc.Location = New System.Drawing.Point(273, 523)
        Me.txtacc.Name = "txtacc"
        Me.txtacc.Size = New System.Drawing.Size(85, 22)
        Me.txtacc.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(391, 525)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Rej Qty"
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.White
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.Red
        Me.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExit.Location = New System.Drawing.Point(567, 29)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(94, 32)
        Me.BtnExit.TabIndex = 88
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.White
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.Navy
        Me.BtnClear.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnClear.Location = New System.Drawing.Point(360, 29)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(94, 32)
        Me.BtnClear.TabIndex = 87
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'Save
        '
        Me.Save.BackColor = System.Drawing.Color.White
        Me.Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save.ForeColor = System.Drawing.Color.DarkGreen
        Me.Save.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Save.Location = New System.Drawing.Point(144, 29)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(94, 32)
        Me.Save.TabIndex = 86
        Me.Save.Text = " SAVE"
        Me.Save.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnClear)
        Me.GroupBox5.Controls.Add(Me.BtnExit)
        Me.GroupBox5.Controls.Add(Me.Save)
        Me.GroupBox5.Location = New System.Drawing.Point(31, 565)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(816, 80)
        Me.GroupBox5.TabIndex = 75
        Me.GroupBox5.TabStop = False
        '
        'GRID1
        '
        Me.GRID1.AllowUserToDeleteRows = False
        Me.GRID1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.GRID1.BackgroundColor = System.Drawing.Color.White
        Me.GRID1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GRID1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.GRID1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GRID1.Location = New System.Drawing.Point(40, 153)
        Me.GRID1.Name = "GRID1"
        Me.GRID1.Size = New System.Drawing.Size(490, 363)
        Me.GRID1.TabIndex = 76
        '
        'GRID2
        '
        Me.GRID2.AllowUserToDeleteRows = False
        Me.GRID2.BackgroundColor = System.Drawing.Color.White
        Me.GRID2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GRID2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.GRID2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Lot_SrNo, Me.Reason_of_Rejection})
        Me.GRID2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.GRID2.Location = New System.Drawing.Point(545, 147)
        Me.GRID2.Name = "GRID2"
        Me.GRID2.Size = New System.Drawing.Size(302, 366)
        Me.GRID2.TabIndex = 77
        Me.GRID2.Visible = False
        '
        'Lot_SrNo
        '
        Me.Lot_SrNo.HeaderText = "Lot_SrNo"
        Me.Lot_SrNo.Name = "Lot_SrNo"
        Me.Lot_SrNo.Width = 150
        '
        'Reason_of_Rejection
        '
        Me.Reason_of_Rejection.HeaderText = "Reason_of_Rejection"
        Me.Reason_of_Rejection.Name = "Reason_of_Rejection"
        '
        'chkRejection
        '
        Me.chkRejection.AutoSize = True
        Me.chkRejection.Location = New System.Drawing.Point(99, 99)
        Me.chkRejection.Name = "chkRejection"
        Me.chkRejection.Size = New System.Drawing.Size(71, 17)
        Me.chkRejection.TabIndex = 78
        Me.chkRejection.Text = "Rejection"
        Me.chkRejection.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(134, 26)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete Row"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(521, 522)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 16)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "MTS NO"
        '
        'txtMTSNo
        '
        Me.txtMTSNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMTSNo.Enabled = False
        Me.txtMTSNo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMTSNo.Location = New System.Drawing.Point(584, 519)
        Me.txtMTSNo.Name = "txtMTSNo"
        Me.txtMTSNo.Size = New System.Drawing.Size(309, 22)
        Me.txtMTSNo.TabIndex = 43
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Textsrscan)
        Me.GroupBox1.Controls.Add(Me.drpreason)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.txtrec)
        Me.GroupBox1.Controls.Add(Me.chkRejection)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.GRID2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GRID1)
        Me.GroupBox1.Controls.Add(Me.txtacc)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cmbrejreason)
        Me.GroupBox1.Controls.Add(Me.txtMTSNo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1109, 668)
        Me.GroupBox1.TabIndex = 79
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(503, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 16)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Lot_Srno"
        '
        'Textsrscan
        '
        Me.Textsrscan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Textsrscan.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textsrscan.Location = New System.Drawing.Point(584, 111)
        Me.Textsrscan.Name = "Textsrscan"
        Me.Textsrscan.Size = New System.Drawing.Size(252, 22)
        Me.Textsrscan.TabIndex = 81
        '
        'drpreason
        '
        Me.drpreason.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drpreason.ForeColor = System.Drawing.Color.Red
        Me.drpreason.FormattingEnabled = True
        Me.drpreason.Items.AddRange(New Object() {"1", "2", "3"})
        Me.drpreason.Location = New System.Drawing.Point(240, 116)
        Me.drpreason.Name = "drpreason"
        Me.drpreason.Size = New System.Drawing.Size(207, 26)
        Me.drpreason.TabIndex = 80
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(181, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 16)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Reason"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdUDICode)
        Me.GroupBox2.Controls.Add(Me.rdLotSerial)
        Me.GroupBox2.Location = New System.Drawing.Point(876, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(164, 77)
        Me.GroupBox2.TabIndex = 87
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
        Me.rdLotSerial.Location = New System.Drawing.Point(31, 19)
        Me.rdLotSerial.Name = "rdLotSerial"
        Me.rdLotSerial.Size = New System.Drawing.Size(89, 19)
        Me.rdLotSerial.TabIndex = 66
        Me.rdLotSerial.Text = "Lot Serial"
        Me.rdLotSerial.UseVisualStyleBackColor = True
        '
        'frmBoxInspection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1672, 904)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmBoxInspection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.GRID1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CmbBPL As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtrec As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtacc As System.Windows.Forms.TextBox
    Friend WithEvents cmbrejreason As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents insdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GRID1 As System.Windows.Forms.DataGridView
    Friend WithEvents GRID2 As System.Windows.Forms.DataGridView
    Friend WithEvents chkRejection As System.Windows.Forms.CheckBox
    Friend WithEvents Lot_SrNo As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Reason_of_Rejection As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtMTSNo As System.Windows.Forms.TextBox
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents drpreason As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Textsrscan As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdUDICode As System.Windows.Forms.RadioButton
    Friend WithEvents rdLotSerial As System.Windows.Forms.RadioButton
End Class
