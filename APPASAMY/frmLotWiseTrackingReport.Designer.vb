<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLotWiseTrackingReport
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.txtLotNumber = New System.Windows.Forms.TextBox
        Me.lbl_LotNumber = New System.Windows.Forms.Label
        Me.grid = New System.Windows.Forms.DataGridView
        Me.btnView = New System.Windows.Forms.Button
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.btn_Download = New System.Windows.Forms.Button
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLotNumber
        '
        Me.txtLotNumber.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLotNumber.Location = New System.Drawing.Point(165, 77)
        Me.txtLotNumber.Name = "txtLotNumber"
        Me.txtLotNumber.Size = New System.Drawing.Size(242, 48)
        Me.txtLotNumber.TabIndex = 87
        '
        'lbl_LotNumber
        '
        Me.lbl_LotNumber.AutoSize = True
        Me.lbl_LotNumber.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LotNumber.ForeColor = System.Drawing.Color.Blue
        Me.lbl_LotNumber.Location = New System.Drawing.Point(17, 88)
        Me.lbl_LotNumber.Name = "lbl_LotNumber"
        Me.lbl_LotNumber.Size = New System.Drawing.Size(142, 29)
        Me.lbl_LotNumber.TabIndex = 86
        Me.lbl_LotNumber.Text = "Lot Number"
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(11, 141)
        Me.grid.Margin = New System.Windows.Forms.Padding(2)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grid.RowTemplate.Height = 10
        Me.grid.Size = New System.Drawing.Size(1724, 547)
        Me.grid.TabIndex = 88
        '
        'btnView
        '
        Me.btnView.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Location = New System.Drawing.Point(465, 77)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(149, 40)
        Me.btnView.TabIndex = 89
        Me.btnView.Text = "View Report"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(419, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(862, 47)
        Me.GroupBox1.TabIndex = 137
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(322, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(228, 29)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Lot Tracking Report"
        '
        'btn_Download
        '
        Me.btn_Download.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_Download.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Download.Location = New System.Drawing.Point(693, 77)
        Me.btn_Download.Name = "btn_Download"
        Me.btn_Download.Size = New System.Drawing.Size(197, 40)
        Me.btn_Download.TabIndex = 89
        Me.btn_Download.Text = "Download Report"
        Me.btn_Download.UseVisualStyleBackColor = False
        '
        'frmLotWiseTrackingReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1756, 727)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_Download)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.txtLotNumber)
        Me.Controls.Add(Me.lbl_LotNumber)
        Me.Name = "frmLotWiseTrackingReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLotWiseTrackingReport"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLotNumber As System.Windows.Forms.TextBox
    Friend WithEvents lbl_LotNumber As System.Windows.Forms.Label
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_Download As System.Windows.Forms.Button
End Class
