<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BPL_Dashboard
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.BPL_Dashboard1 = New System.Windows.Forms.DataGridView
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpdate = New System.Windows.Forms.DateTimePicker
        Me.btnSubmit = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.reason1 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Reason = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.BPL_Dashboard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(608, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(696, 100)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(279, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(216, 29)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "BPL DASHBOARD"
        '
        'BPL_Dashboard1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BPL_Dashboard1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.BPL_Dashboard1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BPL_Dashboard1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.reason1})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BPL_Dashboard1.DefaultCellStyle = DataGridViewCellStyle3
        Me.BPL_Dashboard1.Location = New System.Drawing.Point(42, 118)
        Me.BPL_Dashboard1.Name = "BPL_Dashboard1"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BPL_Dashboard1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.BPL_Dashboard1.Size = New System.Drawing.Size(846, 657)
        Me.BPL_Dashboard1.TabIndex = 64
        '
        'DataGridView1
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Reason})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.Location = New System.Drawing.Point(913, 118)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(817, 657)
        Me.DataGridView1.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 25)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Date"
        '
        'dtpdate
        '
        Me.dtpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdate.Location = New System.Drawing.Point(140, 36)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(246, 31)
        Me.dtpdate.TabIndex = 66
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.Red
        Me.btnSubmit.Location = New System.Drawing.Point(391, 34)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(79, 32)
        Me.btnSubmit.TabIndex = 68
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(475, 34)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 32)
        Me.Button1.TabIndex = 69
        Me.Button1.Text = "VIEW ALL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(430, 81)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(145, 31)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Update Reason"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'reason1
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue
        Me.reason1.DefaultCellStyle = DataGridViewCellStyle2
        Me.reason1.HeaderText = "Reason"
        Me.reason1.Items.AddRange(New Object() {"Holiday", "Injector Shortage", "Material Shortage"})
        Me.reason1.Name = "reason1"
        '
        'Reason
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Blue
        Me.Reason.DefaultCellStyle = DataGridViewCellStyle6
        Me.Reason.HeaderText = "Reason"
        Me.Reason.Items.AddRange(New Object() {"Holiday", "Injector Shortage", "Material Shortage"})
        Me.Reason.Name = "Reason"
        '
        'BPL_Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1770, 817)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpdate)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BPL_Dashboard1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "BPL_Dashboard"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BPL_Dashboard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BPL_Dashboard1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents reason1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Reason As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
