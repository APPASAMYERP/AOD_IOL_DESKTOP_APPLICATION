<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSterilization_After_Scan_PMMA
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblScannedQty = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmbLot_No = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbBatch = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLotSrNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblTotalQty = New System.Windows.Forms.Label
        Me.btnComplete = New System.Windows.Forms.Button
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.Lot_SrNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Model_Name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Power = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Btc_no = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Areation_scan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblbtcQty = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.lblAreationNo = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(579, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 18)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Scanned Count"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(371, 28)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 42)
        Me.btnExit.TabIndex = 29
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblScannedQty
        '
        Me.lblScannedQty.AutoSize = True
        Me.lblScannedQty.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScannedQty.ForeColor = System.Drawing.Color.Red
        Me.lblScannedQty.Location = New System.Drawing.Point(618, 131)
        Me.lblScannedQty.Name = "lblScannedQty"
        Me.lblScannedQty.Size = New System.Drawing.Size(35, 40)
        Me.lblScannedQty.TabIndex = 78
        Me.lblScannedQty.Text = "0"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbLot_No)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cmbBatch)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtLotSrNo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(530, 230)
        Me.GroupBox2.TabIndex = 79
        Me.GroupBox2.TabStop = False
        '
        'cmbLot_No
        '
        Me.cmbLot_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLot_No.FormattingEnabled = True
        Me.cmbLot_No.Location = New System.Drawing.Point(160, 75)
        Me.cmbLot_No.Name = "cmbLot_No"
        Me.cmbLot_No.Size = New System.Drawing.Size(335, 33)
        Me.cmbLot_No.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(18, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 29)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Lot No"
        '
        'cmbBatch
        '
        Me.cmbBatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBatch.FormattingEnabled = True
        Me.cmbBatch.Location = New System.Drawing.Point(160, 22)
        Me.cmbBatch.Name = "cmbBatch"
        Me.cmbBatch.Size = New System.Drawing.Size(335, 33)
        Me.cmbBatch.TabIndex = 59
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(18, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 29)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Batch No"
        '
        'txtLotSrNo
        '
        Me.txtLotSrNo.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLotSrNo.Location = New System.Drawing.Point(153, 136)
        Me.txtLotSrNo.Name = "txtLotSrNo"
        Me.txtLotSrNo.Size = New System.Drawing.Size(342, 48)
        Me.txtLotSrNo.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(9, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 29)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Scan Lot No"
        '
        'lblTotalQty
        '
        Me.lblTotalQty.AutoSize = True
        Me.lblTotalQty.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalQty.ForeColor = System.Drawing.Color.Red
        Me.lblTotalQty.Location = New System.Drawing.Point(1013, 131)
        Me.lblTotalQty.Name = "lblTotalQty"
        Me.lblTotalQty.Size = New System.Drawing.Size(35, 40)
        Me.lblTotalQty.TabIndex = 77
        Me.lblTotalQty.Text = "0"
        '
        'btnComplete
        '
        Me.btnComplete.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComplete.ForeColor = System.Drawing.Color.Red
        Me.btnComplete.Location = New System.Drawing.Point(16, 28)
        Me.btnComplete.Name = "btnComplete"
        Me.btnComplete.Size = New System.Drawing.Size(108, 42)
        Me.btnComplete.TabIndex = 28
        Me.btnComplete.Text = "Complete"
        Me.btnComplete.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.Location = New System.Drawing.Point(25, 18)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(1062, 64)
        Me.GroupBox7.TabIndex = 83
        Me.GroupBox7.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(451, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(206, 29)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "AREATION SCAN"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnComplete)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 401)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(530, 101)
        Me.GroupBox1.TabIndex = 82
        Me.GroupBox1.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Red
        Me.btnClear.Location = New System.Drawing.Point(202, 28)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(108, 42)
        Me.btnClear.TabIndex = 30
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 12.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(970, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 18)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = "Total Lot Qty"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Lot_SrNo, Me.Model_Name, Me.Power, Me.Btc_no, Me.Areation_scan})
        Me.DataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView2.Location = New System.Drawing.Point(582, 180)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView2.Size = New System.Drawing.Size(508, 491)
        Me.DataGridView2.TabIndex = 81
        '
        'Lot_SrNo
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.Lot_SrNo.DefaultCellStyle = DataGridViewCellStyle1
        Me.Lot_SrNo.HeaderText = "Lot_SrNo"
        Me.Lot_SrNo.Name = "Lot_SrNo"
        Me.Lot_SrNo.Width = 170
        '
        'Model_Name
        '
        Me.Model_Name.HeaderText = "Model_Name"
        Me.Model_Name.Name = "Model_Name"
        '
        'Power
        '
        Me.Power.HeaderText = "Power"
        Me.Power.Name = "Power"
        '
        'Btc_no
        '
        Me.Btc_no.HeaderText = "Btc_no"
        Me.Btc_no.Name = "Btc_no"
        '
        'Areation_scan
        '
        Me.Areation_scan.HeaderText = "Areation_scan"
        Me.Areation_scan.Name = "Areation_scan"
        '
        'lblbtcQty
        '
        Me.lblbtcQty.AutoSize = True
        Me.lblbtcQty.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbtcQty.ForeColor = System.Drawing.Color.Red
        Me.lblbtcQty.Location = New System.Drawing.Point(820, 131)
        Me.lblbtcQty.Name = "lblbtcQty"
        Me.lblbtcQty.Size = New System.Drawing.Size(35, 40)
        Me.lblbtcQty.TabIndex = 84
        Me.lblbtcQty.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(792, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 18)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "Total Batch Qty"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblAreationNo)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Location = New System.Drawing.Point(23, 82)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(532, 64)
        Me.GroupBox4.TabIndex = 94
        Me.GroupBox4.TabStop = False
        '
        'lblAreationNo
        '
        Me.lblAreationNo.AutoSize = True
        Me.lblAreationNo.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAreationNo.ForeColor = System.Drawing.Color.Blue
        Me.lblAreationNo.Location = New System.Drawing.Point(184, 22)
        Me.lblAreationNo.Name = "lblAreationNo"
        Me.lblAreationNo.Size = New System.Drawing.Size(151, 33)
        Me.lblAreationNo.TabIndex = 30
        Me.lblAreationNo.Text = "Lot No. "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(39, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 18)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Areation Scan No"
        '
        'FrmSterilization_After_Scan_PMMA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1115, 697)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.lblbtcQty)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblScannedQty)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblTotalQty)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DataGridView2)
        Me.Name = "FrmSterilization_After_Scan_PMMA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblScannedQty As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbBatch As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLotSrNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTotalQty As System.Windows.Forms.Label
    Friend WithEvents btnComplete As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents cmbLot_No As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lot_SrNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Model_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Power As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Btc_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Areation_scan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblbtcQty As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblAreationNo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
