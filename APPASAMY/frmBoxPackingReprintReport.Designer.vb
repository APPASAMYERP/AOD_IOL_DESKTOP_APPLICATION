<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBoxPackingReprintReport
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
        Me.btnView = New System.Windows.Forms.Button
        Me.ToDate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.FromDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.btn_download = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(646, 38)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(111, 37)
        Me.btnView.TabIndex = 48
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'ToDate
        '
        Me.ToDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToDate.CustomFormat = "yyyy-MM-dd hh:mm:ss"
        Me.ToDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDate.Location = New System.Drawing.Point(419, 43)
        Me.ToDate.Name = "ToDate"
        Me.ToDate.Size = New System.Drawing.Size(114, 29)
        Me.ToDate.TabIndex = 93
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(336, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "To Date"
        '
        'FromDate
        '
        Me.FromDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FromDate.CustomFormat = "yyyy-MM-dd hh:mm:ss"
        Me.FromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDate.Location = New System.Drawing.Point(160, 43)
        Me.FromDate.Name = "FromDate"
        Me.FromDate.Size = New System.Drawing.Size(114, 29)
        Me.FromDate.TabIndex = 91
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(50, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "From Date"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 128)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(996, 485)
        Me.DataGridView1.TabIndex = 94
        '
        'btn_download
        '
        Me.btn_download.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_download.ForeColor = System.Drawing.Color.ForestGreen
        Me.btn_download.Location = New System.Drawing.Point(359, 642)
        Me.btn_download.Name = "btn_download"
        Me.btn_download.Size = New System.Drawing.Size(174, 38)
        Me.btn_download.TabIndex = 95
        Me.btn_download.Text = "Download"
        Me.btn_download.UseVisualStyleBackColor = True
        '
        'frmBoxPackingReprintReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 726)
        Me.Controls.Add(Me.btn_download)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FromDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnView)
        Me.Name = "frmBoxPackingReprintReport"
        Me.Text = "frmBoxPackingReprintReport"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents ToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_download As System.Windows.Forms.Button
End Class
