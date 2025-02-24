<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RptVieUniq
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Button1 = New System.Windows.Forms.Button
        Me.CmbPower = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(178, 5)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(955, 542)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(39, 156)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 60)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "View"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CmbPower
        '
        Me.CmbPower.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPower.FormattingEnabled = True
        Me.CmbPower.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.CmbPower.Location = New System.Drawing.Point(24, 73)
        Me.CmbPower.Name = "CmbPower"
        Me.CmbPower.Size = New System.Drawing.Size(105, 29)
        Me.CmbPower.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(54, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 16)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Power"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CmbPower)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(9, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(157, 238)
        Me.Panel1.TabIndex = 36
        '
        'RptVieUniq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1316, 593)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "RptVieUniq"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CmbPower As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
