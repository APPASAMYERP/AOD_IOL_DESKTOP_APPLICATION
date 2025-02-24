<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewTrayAllot
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
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnPreview = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GRID2 = New System.Windows.Forms.DataGridView
        Me.Model_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Power = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Batch = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Lot_No = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Serial_From = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Serial_To = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TrayNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Rack_Location = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblMovementNo = New System.Windows.Forms.Label
        Me.btn_Clear = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbStbatch
        '
        Me.cmbStbatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStbatch.FormattingEnabled = True
        Me.cmbStbatch.Location = New System.Drawing.Point(165, 86)
        Me.cmbStbatch.Name = "cmbStbatch"
        Me.cmbStbatch.Size = New System.Drawing.Size(336, 32)
        Me.cmbStbatch.TabIndex = 50
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Red
        Me.btnSave.Location = New System.Drawing.Point(279, 138)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(108, 42)
        Me.btnSave.TabIndex = 53
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(161, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 20)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Sterile Batch"
        '
        'BtnPreview
        '
        Me.BtnPreview.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPreview.ForeColor = System.Drawing.Color.Red
        Me.BtnPreview.Location = New System.Drawing.Point(165, 138)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(108, 42)
        Me.BtnPreview.TabIndex = 52
        Me.BtnPreview.Text = "Preview"
        Me.BtnPreview.UseVisualStyleBackColor = True
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
        Me.DataGridView1.Location = New System.Drawing.Point(692, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(613, 541)
        Me.DataGridView1.TabIndex = 57
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
        Me.GRID2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Model_name, Me.Power, Me.Batch, Me.Lot_No, Me.Serial_From, Me.Serial_To, Me.Qty, Me.TrayNo, Me.Rack_Location})
        Me.GRID2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GRID2.Location = New System.Drawing.Point(12, 201)
        Me.GRID2.Name = "GRID2"
        Me.GRID2.RowTemplate.Height = 24
        Me.GRID2.Size = New System.Drawing.Size(662, 321)
        Me.GRID2.TabIndex = 55
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
        'Rack_Location
        '
        Me.Rack_Location.HeaderText = "Rack_Location"
        Me.Rack_Location.Name = "Rack_Location"
        Me.Rack_Location.Width = 105
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(549, 543)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(125, 20)
        Me.TextBox1.TabIndex = 73
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(484, 543)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 20)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Total"
        '
        'lblMovementNo
        '
        Me.lblMovementNo.AutoSize = True
        Me.lblMovementNo.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovementNo.ForeColor = System.Drawing.Color.Blue
        Me.lblMovementNo.Location = New System.Drawing.Point(24, 9)
        Me.lblMovementNo.Name = "lblMovementNo"
        Me.lblMovementNo.Size = New System.Drawing.Size(151, 33)
        Me.lblMovementNo.TabIndex = 74
        Me.lblMovementNo.Text = "Lot No. "
        '
        'btn_Clear
        '
        Me.btn_Clear.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clear.ForeColor = System.Drawing.Color.Red
        Me.btn_Clear.Location = New System.Drawing.Point(393, 138)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(108, 42)
        Me.btn_Clear.TabIndex = 53
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'frmNewTrayAllot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1317, 592)
        Me.Controls.Add(Me.lblMovementNo)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GRID2)
        Me.Controls.Add(Me.cmbStbatch)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnPreview)
        Me.Name = "frmNewTrayAllot"
        Me.Text = "frmNewTrayAllot"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbStbatch As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnPreview As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GRID2 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Model_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Power As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Batch As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lot_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Serial_From As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Serial_To As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrayNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rack_Location As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblMovementNo As System.Windows.Forms.Label
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
End Class
