<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOverReserve_to_BPL
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
        Me.CmbOrderContry = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txt_orderId = New System.Windows.Forms.TextBox
        Me.CmbTyPacking = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.cmbReserve_id = New System.Windows.Forms.ComboBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.btnView = New System.Windows.Forms.Button
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.DataGridView3 = New System.Windows.Forms.DataGridView
        Me.GRID2 = New System.Windows.Forms.DataGridView
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.BPL_No1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Model = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Qty1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnSave = New System.Windows.Forms.Button
        Me.Detail_Id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Header_Id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Brand_Name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Model_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Power = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BPL_No = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbOrderContry
        '
        Me.CmbOrderContry.Enabled = False
        Me.CmbOrderContry.FormattingEnabled = True
        Me.CmbOrderContry.Items.AddRange(New Object() {"EXPORT", "LOCAL"})
        Me.CmbOrderContry.Location = New System.Drawing.Point(343, 96)
        Me.CmbOrderContry.Name = "CmbOrderContry"
        Me.CmbOrderContry.Size = New System.Drawing.Size(109, 21)
        Me.CmbOrderContry.TabIndex = 96
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Navy
        Me.Label20.Location = New System.Drawing.Point(341, 77)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(109, 18)
        Me.Label20.TabIndex = 98
        Me.Label20.Text = "      Country          "
        '
        'txt_orderId
        '
        Me.txt_orderId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_orderId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_orderId.Enabled = False
        Me.txt_orderId.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_orderId.Location = New System.Drawing.Point(20, 96)
        Me.txt_orderId.Name = "txt_orderId"
        Me.txt_orderId.Size = New System.Drawing.Size(207, 22)
        Me.txt_orderId.TabIndex = 100
        '
        'CmbTyPacking
        '
        Me.CmbTyPacking.Enabled = False
        Me.CmbTyPacking.FormattingEnabled = True
        Me.CmbTyPacking.Items.AddRange(New Object() {"Export"})
        Me.CmbTyPacking.Location = New System.Drawing.Point(227, 95)
        Me.CmbTyPacking.Name = "CmbTyPacking"
        Me.CmbTyPacking.Size = New System.Drawing.Size(114, 21)
        Me.CmbTyPacking.TabIndex = 95
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(228, 77)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(113, 18)
        Me.Label18.TabIndex = 97
        Me.Label18.Text = "Ty of Packing       "
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label25.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Navy
        Me.Label25.Location = New System.Drawing.Point(20, 77)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(207, 18)
        Me.Label25.TabIndex = 99
        Me.Label25.Text = "                         Order Id                       "
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(22, 202)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(430, 416)
        Me.DataGridView1.TabIndex = 94
        '
        'cmbReserve_id
        '
        Me.cmbReserve_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReserve_id.FormattingEnabled = True
        Me.cmbReserve_id.Location = New System.Drawing.Point(168, 26)
        Me.cmbReserve_id.Name = "cmbReserve_id"
        Me.cmbReserve_id.Size = New System.Drawing.Size(284, 32)
        Me.cmbReserve_id.TabIndex = 93
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Blue
        Me.Label27.Location = New System.Drawing.Point(17, 33)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(134, 18)
        Me.Label27.TabIndex = 92
        Me.Label27.Text = "Reserved_Ord_No"
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.White
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnView.Location = New System.Drawing.Point(73, 138)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(106, 35)
        Me.btnView.TabIndex = 101
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView2.Location = New System.Drawing.Point(913, 12)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(522, 573)
        Me.DataGridView2.TabIndex = 102
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BPL_No1, Me.Model, Me.Qty1})
        Me.DataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView3.Location = New System.Drawing.Point(469, 12)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(438, 238)
        Me.DataGridView3.TabIndex = 104
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
        Me.GRID2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Detail_Id, Me.Header_Id, Me.Brand_Name, Me.Model_name, Me.Power, Me.Qty, Me.BPL_No})
        Me.GRID2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GRID2.Location = New System.Drawing.Point(469, 256)
        Me.GRID2.Name = "GRID2"
        Me.GRID2.RowTemplate.Height = 24
        Me.GRID2.Size = New System.Drawing.Size(438, 329)
        Me.GRID2.TabIndex = 103
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(553, 598)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(125, 20)
        Me.TextBox1.TabIndex = 106
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(469, 599)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 20)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Total"
        '
        'BPL_No1
        '
        Me.BPL_No1.HeaderText = "BPL_No"
        Me.BPL_No1.Name = "BPL_No1"
        Me.BPL_No1.ReadOnly = True
        Me.BPL_No1.Width = 130
        '
        'Model
        '
        Me.Model.HeaderText = "Model"
        Me.Model.Name = "Model"
        Me.Model.Width = 80
        '
        'Qty1
        '
        Me.Qty1.HeaderText = "Qty"
        Me.Qty1.Name = "Qty1"
        Me.Qty1.ReadOnly = True
        Me.Qty1.Width = 60
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnSave.Location = New System.Drawing.Point(209, 138)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(106, 35)
        Me.btnSave.TabIndex = 101
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Detail_Id
        '
        Me.Detail_Id.HeaderText = "Detail_Id"
        Me.Detail_Id.Name = "Detail_Id"
        Me.Detail_Id.Width = 74
        '
        'Header_Id
        '
        Me.Header_Id.HeaderText = "Header_Id"
        Me.Header_Id.Name = "Header_Id"
        Me.Header_Id.Width = 82
        '
        'Brand_Name
        '
        Me.Brand_Name.HeaderText = "Brand_Name"
        Me.Brand_Name.Name = "Brand_Name"
        Me.Brand_Name.Width = 94
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
        'Qty
        '
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.Width = 48
        '
        'BPL_No
        '
        Me.BPL_No.HeaderText = "BPL_No"
        Me.BPL_No.Name = "BPL_No"
        Me.BPL_No.Width = 72
        '
        'FrmOverReserve_to_BPL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1447, 630)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.GRID2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.CmbOrderContry)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txt_orderId)
        Me.Controls.Add(Me.CmbTyPacking)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmbReserve_id)
        Me.Controls.Add(Me.Label27)
        Me.Name = "FrmOverReserve_to_BPL"
        Me.Text = "FrmOverReserve_to_BPL"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbOrderContry As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_orderId As System.Windows.Forms.TextBox
    Friend WithEvents CmbTyPacking As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmbReserve_id As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents GRID2 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BPL_No1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Model As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Detail_Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Header_Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Brand_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Model_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Power As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BPL_No As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
