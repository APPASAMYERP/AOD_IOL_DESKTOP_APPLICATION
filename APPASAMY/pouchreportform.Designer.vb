<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pouchreportform
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.FromDate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.ToDate = New System.Windows.Forms.DateTimePicker
        Me.Btnview = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.power = New System.Windows.Forms.ComboBox
        Me.type = New System.Windows.Forms.ComboBox
        Me.MODEL_NAME = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(632, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 29)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Pouch Report Form"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(498, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "From Date"
        '
        'FromDate
        '
        Me.FromDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FromDate.CustomFormat = "yyyy-MM-dd hh:mm:ss"
        Me.FromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDate.Location = New System.Drawing.Point(603, 139)
        Me.FromDate.Name = "FromDate"
        Me.FromDate.Size = New System.Drawing.Size(114, 29)
        Me.FromDate.TabIndex = 87
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(779, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "To Date"
        '
        'ToDate
        '
        Me.ToDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToDate.CustomFormat = "yyyy-MM-dd hh:mm:ss"
        Me.ToDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDate.Location = New System.Drawing.Point(859, 142)
        Me.ToDate.Name = "ToDate"
        Me.ToDate.Size = New System.Drawing.Size(114, 29)
        Me.ToDate.TabIndex = 89
        '
        'Btnview
        '
        Me.Btnview.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnview.ForeColor = System.Drawing.Color.Red
        Me.Btnview.Location = New System.Drawing.Point(694, 272)
        Me.Btnview.Name = "Btnview"
        Me.Btnview.Size = New System.Drawing.Size(108, 42)
        Me.Btnview.TabIndex = 90
        Me.Btnview.Text = "View"
        Me.Btnview.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(12, 331)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1338, 511)
        Me.CrystalReportViewer1.TabIndex = 91
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(372, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Model_Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(634, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 16)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "Power"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(856, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 16)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Type"
        '
        'power
        '
        Me.power.FormattingEnabled = True
        Me.power.Location = New System.Drawing.Point(687, 188)
        Me.power.Name = "power"
        Me.power.Size = New System.Drawing.Size(121, 21)
        Me.power.TabIndex = 99
        '
        'type
        '
        Me.type.FormattingEnabled = True
        Me.type.Location = New System.Drawing.Point(920, 187)
        Me.type.Name = "type"
        Me.type.Size = New System.Drawing.Size(121, 21)
        Me.type.TabIndex = 100
        '
        'MODEL_NAME
        '
        Me.MODEL_NAME.FormattingEnabled = True
        Me.MODEL_NAME.Location = New System.Drawing.Point(483, 193)
        Me.MODEL_NAME.Name = "MODEL_NAME"
        Me.MODEL_NAME.Size = New System.Drawing.Size(121, 21)
        Me.MODEL_NAME.TabIndex = 101
        '
        'pouchreportform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1464, 854)
        Me.Controls.Add(Me.MODEL_NAME)
        Me.Controls.Add(Me.type)
        Me.Controls.Add(Me.power)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Btnview)
        Me.Controls.Add(Me.ToDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FromDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "pouchreportform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pouchreportform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Btnview As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents power As System.Windows.Forms.ComboBox
    Friend WithEvents type As System.Windows.Forms.ComboBox
    Friend WithEvents MODEL_NAME As System.Windows.Forms.ComboBox
End Class
