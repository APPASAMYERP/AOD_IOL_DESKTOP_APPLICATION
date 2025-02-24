<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnquiry_to_order_reserve
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
        Me.cmbReserve_id = New System.Windows.Forms.ComboBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CmbOrderContry = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txt_orderId = New System.Windows.Forms.TextBox
        Me.CmbTyPacking = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.cmb_Change_Ord_Country = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnChange = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbReserve_id
        '
        Me.cmbReserve_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReserve_id.FormattingEnabled = True
        Me.cmbReserve_id.Location = New System.Drawing.Point(159, 63)
        Me.cmbReserve_id.Name = "cmbReserve_id"
        Me.cmbReserve_id.Size = New System.Drawing.Size(284, 32)
        Me.cmbReserve_id.TabIndex = 83
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Blue
        Me.Label27.Location = New System.Drawing.Point(8, 70)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(134, 18)
        Me.Label27.TabIndex = 82
        Me.Label27.Text = "Reserved_Ord_No"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(464, 63)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(654, 416)
        Me.DataGridView1.TabIndex = 85
        '
        'CmbOrderContry
        '
        Me.CmbOrderContry.Enabled = False
        Me.CmbOrderContry.FormattingEnabled = True
        Me.CmbOrderContry.Items.AddRange(New Object() {"EXPORT", "LOCAL"})
        Me.CmbOrderContry.Location = New System.Drawing.Point(334, 133)
        Me.CmbOrderContry.Name = "CmbOrderContry"
        Me.CmbOrderContry.Size = New System.Drawing.Size(109, 21)
        Me.CmbOrderContry.TabIndex = 87
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Navy
        Me.Label20.Location = New System.Drawing.Point(332, 114)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(109, 18)
        Me.Label20.TabIndex = 89
        Me.Label20.Text = "      Country          "
        '
        'txt_orderId
        '
        Me.txt_orderId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_orderId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_orderId.Enabled = False
        Me.txt_orderId.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_orderId.Location = New System.Drawing.Point(11, 133)
        Me.txt_orderId.Name = "txt_orderId"
        Me.txt_orderId.Size = New System.Drawing.Size(207, 22)
        Me.txt_orderId.TabIndex = 91
        '
        'CmbTyPacking
        '
        Me.CmbTyPacking.Enabled = False
        Me.CmbTyPacking.FormattingEnabled = True
        Me.CmbTyPacking.Items.AddRange(New Object() {"Export"})
        Me.CmbTyPacking.Location = New System.Drawing.Point(218, 132)
        Me.CmbTyPacking.Name = "CmbTyPacking"
        Me.CmbTyPacking.Size = New System.Drawing.Size(114, 21)
        Me.CmbTyPacking.TabIndex = 86
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(219, 114)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(113, 18)
        Me.Label18.TabIndex = 88
        Me.Label18.Text = "Ty of Packing       "
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label25.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Navy
        Me.Label25.Location = New System.Drawing.Point(11, 114)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(207, 18)
        Me.Label25.TabIndex = 90
        Me.Label25.Text = "                         Order Id                       "
        '
        'cmb_Change_Ord_Country
        '
        Me.cmb_Change_Ord_Country.FormattingEnabled = True
        Me.cmb_Change_Ord_Country.Items.AddRange(New Object() {"EXPORT", "LOCAL"})
        Me.cmb_Change_Ord_Country.Location = New System.Drawing.Point(191, 208)
        Me.cmb_Change_Ord_Country.Name = "cmb_Change_Ord_Country"
        Me.cmb_Change_Ord_Country.Size = New System.Drawing.Size(179, 21)
        Me.cmb_Change_Ord_Country.TabIndex = 87
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(15, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 18)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Order Country Change"
        '
        'btnChange
        '
        Me.btnChange.BackColor = System.Drawing.Color.White
        Me.btnChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChange.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnChange.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnChange.Location = New System.Drawing.Point(132, 260)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(106, 35)
        Me.btnChange.TabIndex = 92
        Me.btnChange.Text = "CHANGE"
        Me.btnChange.UseVisualStyleBackColor = False
        '
        'frmEnquiry_to_order_reserve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 573)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.cmb_Change_Ord_Country)
        Me.Controls.Add(Me.CmbOrderContry)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txt_orderId)
        Me.Controls.Add(Me.CmbTyPacking)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmbReserve_id)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label27)
        Me.Name = "frmEnquiry_to_order_reserve"
        Me.Text = "frmEnquiry_to_order_reserve"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbReserve_id As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CmbOrderContry As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_orderId As System.Windows.Forms.TextBox
    Friend WithEvents CmbTyPacking As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cmb_Change_Ord_Country As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnChange As System.Windows.Forms.Button
End Class
