<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBIComplete
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
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbbtc = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.BI_StartDate = New System.Windows.Forms.DateTimePicker
        Me.BI_EndDate = New System.Windows.Forms.DateTimePicker
        Me.BtnClear = New System.Windows.Forms.Button
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label1)
        Me.GroupBox7.Location = New System.Drawing.Point(23, 23)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(623, 60)
        Me.GroupBox7.TabIndex = 58
        Me.GroupBox7.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(221, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 29)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "BI COMPLETE"
        '
        'cmbbtc
        '
        Me.cmbbtc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbtc.FormattingEnabled = True
        Me.cmbbtc.Location = New System.Drawing.Point(339, 113)
        Me.cmbbtc.Name = "cmbbtc"
        Me.cmbbtc.Size = New System.Drawing.Size(263, 33)
        Me.cmbbtc.TabIndex = 61
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(85, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 29)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Batch No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 18.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(85, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 29)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "BI Start Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 18.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(85, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 29)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "BI End Date"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(439, 325)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 42)
        Me.btnExit.TabIndex = 98
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(111, 325)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 42)
        Me.Button1.TabIndex = 97
        Me.Button1.Text = "Complete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BI_StartDate
        '
        Me.BI_StartDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BI_StartDate.CustomFormat = "yyyy-MM-dd hh:mm:ss"
        Me.BI_StartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BI_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.BI_StartDate.Location = New System.Drawing.Point(339, 171)
        Me.BI_StartDate.Name = "BI_StartDate"
        Me.BI_StartDate.Size = New System.Drawing.Size(263, 29)
        Me.BI_StartDate.TabIndex = 99
        '
        'BI_EndDate
        '
        Me.BI_EndDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BI_EndDate.CustomFormat = "yyyy-MM-dd hh:mm:ss"
        Me.BI_EndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BI_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.BI_EndDate.Location = New System.Drawing.Point(339, 225)
        Me.BI_EndDate.Name = "BI_EndDate"
        Me.BI_EndDate.Size = New System.Drawing.Size(263, 29)
        Me.BI_EndDate.TabIndex = 100
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.Red
        Me.BtnClear.Location = New System.Drawing.Point(281, 325)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(108, 42)
        Me.BtnClear.TabIndex = 101
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'frmBIComplete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(688, 464)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BI_EndDate)
        Me.Controls.Add(Me.BI_StartDate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbbtc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox7)
        Me.Name = "frmBIComplete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBIComplete"
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbbtc As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BI_StartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents BI_EndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnClear As System.Windows.Forms.Button
End Class
