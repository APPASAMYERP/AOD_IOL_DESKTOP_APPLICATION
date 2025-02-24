<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRackLocationDetails
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
        Me.txtRackLocation = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GRID2 = New System.Windows.Forms.DataGridView
        Me.GRID1 = New System.Windows.Forms.DataGridView
        Me.Lot_SrNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Brand_Name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Model_Name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Power = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Scanned = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblScannedQty = New System.Windows.Forms.Label
        Me.lblTotalRack_Loc_Qty = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtLotSrNo = New System.Windows.Forms.TextBox
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.rdLotSerial = New System.Windows.Forms.RadioButton
        Me.rdUDICode = New System.Windows.Forms.RadioButton
        Me.txtScannedRack = New System.Windows.Forms.TextBox
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnVerified = New System.Windows.Forms.Button
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRID1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtRackLocation
        '
        Me.txtRackLocation.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRackLocation.ForeColor = System.Drawing.Color.Red
        Me.txtRackLocation.Location = New System.Drawing.Point(226, 100)
        Me.txtRackLocation.Name = "txtRackLocation"
        Me.txtRackLocation.Size = New System.Drawing.Size(245, 48)
        Me.txtRackLocation.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(0, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(220, 29)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Scan Rack Location"
        '
        'GRID2
        '
        Me.GRID2.AllowUserToDeleteRows = False
        Me.GRID2.BackgroundColor = System.Drawing.Color.White
        Me.GRID2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GRID2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.GRID2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GRID2.Location = New System.Drawing.Point(12, 240)
        Me.GRID2.Name = "GRID2"
        Me.GRID2.Size = New System.Drawing.Size(481, 395)
        Me.GRID2.TabIndex = 47
        '
        'GRID1
        '
        Me.GRID1.AllowUserToDeleteRows = False
        Me.GRID1.BackgroundColor = System.Drawing.Color.White
        Me.GRID1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GRID1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.GRID1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Lot_SrNo, Me.Brand_Name, Me.Model_Name, Me.Power, Me.Scanned})
        Me.GRID1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GRID1.Location = New System.Drawing.Point(525, 240)
        Me.GRID1.Name = "GRID1"
        Me.GRID1.Size = New System.Drawing.Size(549, 395)
        Me.GRID1.TabIndex = 48
        '
        'Lot_SrNo
        '
        Me.Lot_SrNo.HeaderText = "Lot_SrNo"
        Me.Lot_SrNo.Name = "Lot_SrNo"
        '
        'Brand_Name
        '
        Me.Brand_Name.HeaderText = "Brand_Name"
        Me.Brand_Name.Name = "Brand_Name"
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
        'Scanned
        '
        Me.Scanned.HeaderText = "Scanned"
        Me.Scanned.Name = "Scanned"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(407, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(230, 26)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Rack Location Detail"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(534, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 18)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Scanned Count"
        '
        'lblScannedQty
        '
        Me.lblScannedQty.AutoSize = True
        Me.lblScannedQty.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScannedQty.ForeColor = System.Drawing.Color.Red
        Me.lblScannedQty.Location = New System.Drawing.Point(573, 189)
        Me.lblScannedQty.Name = "lblScannedQty"
        Me.lblScannedQty.Size = New System.Drawing.Size(35, 40)
        Me.lblScannedQty.TabIndex = 83
        Me.lblScannedQty.Text = "0"
        '
        'lblTotalRack_Loc_Qty
        '
        Me.lblTotalRack_Loc_Qty.AutoSize = True
        Me.lblTotalRack_Loc_Qty.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRack_Loc_Qty.ForeColor = System.Drawing.Color.Red
        Me.lblTotalRack_Loc_Qty.Location = New System.Drawing.Point(986, 189)
        Me.lblTotalRack_Loc_Qty.Name = "lblTotalRack_Loc_Qty"
        Me.lblTotalRack_Loc_Qty.Size = New System.Drawing.Size(35, 40)
        Me.lblTotalRack_Loc_Qty.TabIndex = 82
        Me.lblTotalRack_Loc_Qty.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 12.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(904, 162)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(179, 18)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "Total Rack Location Qty"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(508, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 29)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Scan Lot SrNo"
        '
        'txtLotSrNo
        '
        Me.txtLotSrNo.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLotSrNo.ForeColor = System.Drawing.Color.Red
        Me.txtLotSrNo.Location = New System.Drawing.Point(678, 100)
        Me.txtLotSrNo.Name = "txtLotSrNo"
        Me.txtLotSrNo.Size = New System.Drawing.Size(383, 48)
        Me.txtLotSrNo.TabIndex = 45
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.rdLotSerial)
        Me.GroupBox8.Controls.Add(Me.rdUDICode)
        Me.GroupBox8.Location = New System.Drawing.Point(517, 44)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(544, 50)
        Me.GroupBox8.TabIndex = 85
        Me.GroupBox8.TabStop = False
        '
        'rdLotSerial
        '
        Me.rdLotSerial.AutoSize = True
        Me.rdLotSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdLotSerial.ForeColor = System.Drawing.Color.Red
        Me.rdLotSerial.Location = New System.Drawing.Point(385, 17)
        Me.rdLotSerial.Name = "rdLotSerial"
        Me.rdLotSerial.Size = New System.Drawing.Size(96, 21)
        Me.rdLotSerial.TabIndex = 69
        Me.rdLotSerial.Text = "Lot Serial"
        Me.rdLotSerial.UseVisualStyleBackColor = True
        '
        'rdUDICode
        '
        Me.rdUDICode.AutoSize = True
        Me.rdUDICode.Checked = True
        Me.rdUDICode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdUDICode.ForeColor = System.Drawing.Color.Red
        Me.rdUDICode.Location = New System.Drawing.Point(53, 17)
        Me.rdUDICode.Name = "rdUDICode"
        Me.rdUDICode.Size = New System.Drawing.Size(99, 21)
        Me.rdUDICode.TabIndex = 70
        Me.rdUDICode.TabStop = True
        Me.rdUDICode.Text = "UDI Serial"
        Me.rdUDICode.UseVisualStyleBackColor = True
        '
        'txtScannedRack
        '
        Me.txtScannedRack.Enabled = False
        Me.txtScannedRack.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScannedRack.ForeColor = System.Drawing.Color.Red
        Me.txtScannedRack.Location = New System.Drawing.Point(709, 181)
        Me.txtScannedRack.Name = "txtScannedRack"
        Me.txtScannedRack.Size = New System.Drawing.Size(157, 48)
        Me.txtScannedRack.TabIndex = 45
        Me.txtScannedRack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnVerified)
        Me.GroupBox1.Location = New System.Drawing.Point(570, 656)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(473, 101)
        Me.GroupBox1.TabIndex = 92
        Me.GroupBox1.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(288, 28)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 42)
        Me.btnExit.TabIndex = 29
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnVerified
        '
        Me.btnVerified.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerified.ForeColor = System.Drawing.Color.Red
        Me.btnVerified.Location = New System.Drawing.Point(66, 28)
        Me.btnVerified.Name = "btnVerified"
        Me.btnVerified.Size = New System.Drawing.Size(108, 42)
        Me.btnVerified.TabIndex = 28
        Me.btnVerified.Text = "Verified"
        Me.btnVerified.UseVisualStyleBackColor = True
        '
        'FrmRackLocationDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1111, 769)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblScannedQty)
        Me.Controls.Add(Me.lblTotalRack_Loc_Qty)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GRID1)
        Me.Controls.Add(Me.GRID2)
        Me.Controls.Add(Me.txtLotSrNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtScannedRack)
        Me.Controls.Add(Me.txtRackLocation)
        Me.Controls.Add(Me.Label5)
        Me.Name = "FrmRackLocationDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRID1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRackLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GRID2 As System.Windows.Forms.DataGridView
    Friend WithEvents GRID1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblScannedQty As System.Windows.Forms.Label
    Friend WithEvents lblTotalRack_Loc_Qty As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLotSrNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents rdLotSerial As System.Windows.Forms.RadioButton
    Friend WithEvents rdUDICode As System.Windows.Forms.RadioButton
    Friend WithEvents txtScannedRack As System.Windows.Forms.TextBox
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents Lot_SrNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Brand_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Model_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Power As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Scanned As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnVerified As System.Windows.Forms.Button
End Class
