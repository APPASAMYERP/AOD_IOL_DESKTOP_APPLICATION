<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlotallotprint
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
        Me.cmbStbatch = New System.Windows.Forms.ComboBox
        Me.GRID2 = New System.Windows.Forms.DataGridView
        Me.Model_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Power = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Batch = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Lot_No = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Serial_From = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Serial_To = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TrayNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnPreview = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.btnSave = New System.Windows.Forms.Button
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbTrayNo = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbStrBatchReprint = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.rdoReprint = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RdoPrint = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.BatchNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Qty1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TrayNo1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Model = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnPrintRackWise = New System.Windows.Forms.Button
        Me.cmbRackLocation = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbStbatch
        '
        Me.cmbStbatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStbatch.FormattingEnabled = True
        Me.cmbStbatch.Location = New System.Drawing.Point(49, 84)
        Me.cmbStbatch.Name = "cmbStbatch"
        Me.cmbStbatch.Size = New System.Drawing.Size(288, 32)
        Me.cmbStbatch.TabIndex = 0
        '
        'GRID2
        '
        Me.GRID2.AllowUserToAddRows = False
        Me.GRID2.AllowUserToDeleteRows = False
        Me.GRID2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.GRID2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.GRID2.BackgroundColor = System.Drawing.Color.White
        Me.GRID2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GRID2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.GRID2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Model_name, Me.Power, Me.Batch, Me.Lot_No, Me.Serial_From, Me.Serial_To, Me.Qty, Me.TrayNo})
        Me.GRID2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GRID2.Location = New System.Drawing.Point(398, 323)
        Me.GRID2.Name = "GRID2"
        Me.GRID2.RowTemplate.Height = 24
        Me.GRID2.Size = New System.Drawing.Size(522, 496)
        Me.GRID2.TabIndex = 43
        '
        'Model_name
        '
        Me.Model_name.HeaderText = "Model_Name"
        Me.Model_name.Name = "Model_name"
        Me.Model_name.Width = 95
        '
        'Power
        '
        Me.Power.HeaderText = "Power"
        Me.Power.Name = "Power"
        Me.Power.Width = 62
        '
        'Batch
        '
        Me.Batch.HeaderText = "Batch"
        Me.Batch.Name = "Batch"
        Me.Batch.Width = 60
        '
        'Lot_No
        '
        Me.Lot_No.HeaderText = "Lot_No"
        Me.Lot_No.Name = "Lot_No"
        Me.Lot_No.Width = 67
        '
        'Serial_From
        '
        Me.Serial_From.HeaderText = "Serial_From"
        Me.Serial_From.Name = "Serial_From"
        Me.Serial_From.Width = 87
        '
        'Serial_To
        '
        Me.Serial_To.HeaderText = "Serial_To"
        Me.Serial_To.Name = "Serial_To"
        Me.Serial_To.Width = 77
        '
        'Qty
        '
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.Width = 48
        '
        'TrayNo
        '
        Me.TrayNo.HeaderText = "TrayNo"
        Me.TrayNo.Name = "TrayNo"
        Me.TrayNo.Width = 67
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(22, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 20)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Sterile Batch"
        '
        'BtnPrint
        '
        Me.BtnPrint.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.ForeColor = System.Drawing.Color.Red
        Me.BtnPrint.Location = New System.Drawing.Point(246, 182)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(108, 42)
        Me.BtnPrint.TabIndex = 49
        Me.BtnPrint.Text = "Print"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'BtnPreview
        '
        Me.BtnPreview.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPreview.ForeColor = System.Drawing.Color.Red
        Me.BtnPreview.Location = New System.Drawing.Point(12, 182)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(108, 42)
        Me.BtnPreview.TabIndex = 47
        Me.BtnPreview.Text = "Preview"
        Me.BtnPreview.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.Red
        Me.BtnExit.Location = New System.Drawing.Point(144, 798)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(108, 42)
        Me.BtnExit.TabIndex = 48
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(928, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(522, 837)
        Me.DataGridView1.TabIndex = 50
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Red
        Me.btnSave.Location = New System.Drawing.Point(132, 182)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(108, 42)
        Me.btnSave.TabIndex = 49
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.cmbStbatch)
        Me.GroupBox7.Controls.Add(Me.btnSave)
        Me.GroupBox7.Controls.Add(Me.Label1)
        Me.GroupBox7.Controls.Add(Me.BtnPrint)
        Me.GroupBox7.Controls.Add(Me.BtnPreview)
        Me.GroupBox7.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Red
        Me.GroupBox7.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(380, 255)
        Me.GroupBox7.TabIndex = 64
        Me.GroupBox7.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbTrayNo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbStrBatchReprint)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(12, 317)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 258)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'cmbTrayNo
        '
        Me.cmbTrayNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTrayNo.FormattingEnabled = True
        Me.cmbTrayNo.Location = New System.Drawing.Point(47, 130)
        Me.cmbTrayNo.Name = "cmbTrayNo"
        Me.cmbTrayNo.Size = New System.Drawing.Size(288, 32)
        Me.cmbTrayNo.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(20, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Tray No"
        '
        'cmbStrBatchReprint
        '
        Me.cmbStrBatchReprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStrBatchReprint.FormattingEnabled = True
        Me.cmbStrBatchReprint.Location = New System.Drawing.Point(49, 56)
        Me.cmbStrBatchReprint.Name = "cmbStrBatchReprint"
        Me.cmbStrBatchReprint.Size = New System.Drawing.Size(288, 32)
        Me.cmbStrBatchReprint.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(22, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 20)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Sterile Batch"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(132, 186)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 42)
        Me.Button3.TabIndex = 49
        Me.Button3.Text = "Print"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'rdoReprint
        '
        Me.rdoReprint.AutoSize = True
        Me.rdoReprint.Location = New System.Drawing.Point(297, 20)
        Me.rdoReprint.Name = "rdoReprint"
        Me.rdoReprint.Size = New System.Drawing.Size(77, 19)
        Me.rdoReprint.TabIndex = 66
        Me.rdoReprint.Text = "Reprint"
        Me.rdoReprint.UseVisualStyleBackColor = True
        Me.rdoReprint.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RdoPrint)
        Me.GroupBox2.Controls.Add(Me.rdoReprint)
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(380, 50)
        Me.GroupBox2.TabIndex = 68
        Me.GroupBox2.TabStop = False
        '
        'RdoPrint
        '
        Me.RdoPrint.AutoSize = True
        Me.RdoPrint.Checked = True
        Me.RdoPrint.Location = New System.Drawing.Point(47, 20)
        Me.RdoPrint.Name = "RdoPrint"
        Me.RdoPrint.Size = New System.Drawing.Size(60, 19)
        Me.RdoPrint.TabIndex = 67
        Me.RdoPrint.TabStop = True
        Me.RdoPrint.Text = "Print"
        Me.RdoPrint.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(419, 838)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 20)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Total"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(503, 837)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(125, 20)
        Me.TextBox1.TabIndex = 71
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(12, 849)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(198, 20)
        Me.TextBox2.TabIndex = 72
        Me.TextBox2.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(240, 846)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 73
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BatchNo, Me.Qty1, Me.TrayNo1, Me.Model})
        Me.DataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView2.Location = New System.Drawing.Point(398, 20)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(522, 292)
        Me.DataGridView2.TabIndex = 43
        '
        'BatchNo
        '
        Me.BatchNo.HeaderText = "Batch"
        Me.BatchNo.Name = "BatchNo"
        Me.BatchNo.ReadOnly = True
        '
        'Qty1
        '
        Me.Qty1.HeaderText = "Qty"
        Me.Qty1.Name = "Qty1"
        Me.Qty1.ReadOnly = True
        Me.Qty1.Width = 60
        '
        'TrayNo1
        '
        Me.TrayNo1.HeaderText = "TrayNo"
        Me.TrayNo1.Name = "TrayNo1"
        Me.TrayNo1.ReadOnly = True
        Me.TrayNo1.Width = 130
        '
        'Model
        '
        Me.Model.HeaderText = "Model"
        Me.Model.Name = "Model"
        Me.Model.Width = 80
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnPrintRackWise)
        Me.GroupBox3.Controls.Add(Me.cmbRackLocation)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 592)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(374, 200)
        Me.GroupBox3.TabIndex = 74
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
        '
        'btnPrintRackWise
        '
        Me.btnPrintRackWise.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintRackWise.ForeColor = System.Drawing.Color.Red
        Me.btnPrintRackWise.Location = New System.Drawing.Point(132, 119)
        Me.btnPrintRackWise.Name = "btnPrintRackWise"
        Me.btnPrintRackWise.Size = New System.Drawing.Size(108, 42)
        Me.btnPrintRackWise.TabIndex = 52
        Me.btnPrintRackWise.Text = "Print"
        Me.btnPrintRackWise.UseVisualStyleBackColor = True
        '
        'cmbRackLocation
        '
        Me.cmbRackLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRackLocation.FormattingEnabled = True
        Me.cmbRackLocation.Location = New System.Drawing.Point(49, 61)
        Me.cmbRackLocation.Name = "cmbRackLocation"
        Me.cmbRackLocation.Size = New System.Drawing.Size(288, 32)
        Me.cmbRackLocation.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(22, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 20)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Rack Location"
        '
        'frmlotallotprint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1451, 869)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.GRID2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmlotallotprint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tray Label Print"
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbStbatch As System.Windows.Forms.ComboBox
    Friend WithEvents GRID2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnPreview As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Model_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Power As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Batch As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lot_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Serial_From As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Serial_To As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrayNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbTrayNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbStrBatchReprint As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents rdoReprint As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RdoPrint As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPrintRackWise As System.Windows.Forms.Button
    Friend WithEvents cmbRackLocation As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BatchNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrayNo1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Model As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
