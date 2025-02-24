<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewBPL_Dashboard
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.grid = New System.Windows.Forms.DataGridView
        Me.lblProduct = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnFetch = New System.Windows.Forms.Button
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(4, 26)
        Me.grid.Margin = New System.Windows.Forms.Padding(2)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.grid.RowTemplate.Height = 24
        Me.grid.Size = New System.Drawing.Size(1693, 507)
        Me.grid.TabIndex = 5
        '
        'lblProduct
        '
        Me.lblProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduct.Location = New System.Drawing.Point(425, 0)
        Me.lblProduct.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(410, 24)
        Me.lblProduct.TabIndex = 6
        Me.lblProduct.Text = "BPL DASHBOARD"
        Me.lblProduct.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1200000
        '
        'btnFetch
        '
        Me.btnFetch.Location = New System.Drawing.Point(12, 2)
        Me.btnFetch.Name = "btnFetch"
        Me.btnFetch.Size = New System.Drawing.Size(75, 23)
        Me.btnFetch.TabIndex = 7
        Me.btnFetch.Text = "Fetch"
        Me.btnFetch.UseVisualStyleBackColor = True
        '
        'frmNewBPL_Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1708, 596)
        Me.Controls.Add(Me.btnFetch)
        Me.Controls.Add(Me.lblProduct)
        Me.Controls.Add(Me.grid)
        Me.Name = "frmNewBPL_Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BPL DASHBOARD REFRESH IN EVERY 60 SECONDS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents lblProduct As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnFetch As System.Windows.Forms.Button
End Class
