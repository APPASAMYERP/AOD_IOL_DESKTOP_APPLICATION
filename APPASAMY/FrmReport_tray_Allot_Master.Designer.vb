<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReport_tray_Allot_Master
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.cmbModel = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Btnview = New System.Windows.Forms.Button
        Me.btnrefresh = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.DataGridView1.Location = New System.Drawing.Point(51, 74)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(964, 541)
        Me.DataGridView1.TabIndex = 58
        '
        'cmbModel
        '
        Me.cmbModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModel.FormattingEnabled = True
        Me.cmbModel.Location = New System.Drawing.Point(203, 16)
        Me.cmbModel.Name = "cmbModel"
        Me.cmbModel.Size = New System.Drawing.Size(288, 32)
        Me.cmbModel.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(117, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Model"
        '
        'Btnview
        '
        Me.Btnview.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnview.ForeColor = System.Drawing.Color.Red
        Me.Btnview.Location = New System.Drawing.Point(515, 12)
        Me.Btnview.Name = "Btnview"
        Me.Btnview.Size = New System.Drawing.Size(108, 42)
        Me.Btnview.TabIndex = 61
        Me.Btnview.Text = "View"
        Me.Btnview.UseVisualStyleBackColor = True
        '
        'btnrefresh
        '
        Me.btnrefresh.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.ForeColor = System.Drawing.Color.Red
        Me.btnrefresh.Location = New System.Drawing.Point(721, 12)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(108, 42)
        Me.btnrefresh.TabIndex = 61
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'FrmReport_tray_Allot_Master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1144, 627)
        Me.Controls.Add(Me.cmbModel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.Btnview)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmReport_tray_Allot_Master"
        Me.Text = "FrmReport_tray_Allot_Master"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmbModel As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btnview As System.Windows.Forms.Button
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
End Class
