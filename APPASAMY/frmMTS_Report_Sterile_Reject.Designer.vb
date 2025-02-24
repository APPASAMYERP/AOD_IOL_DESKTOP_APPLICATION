<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMTS_Report_Sterile_Reject
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
        Me.Label8 = New System.Windows.Forms.Label
        Me.CmbMTSNo = New System.Windows.Forms.ComboBox
        Me.CryViewMTSReport = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(416, 29)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(94, 37)
        Me.btnView.TabIndex = 52
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(58, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 16)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "MMS_NO"
        '
        'CmbMTSNo
        '
        Me.CmbMTSNo.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMTSNo.FormattingEnabled = True
        Me.CmbMTSNo.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.CmbMTSNo.Location = New System.Drawing.Point(153, 36)
        Me.CmbMTSNo.Name = "CmbMTSNo"
        Me.CmbMTSNo.Size = New System.Drawing.Size(236, 24)
        Me.CmbMTSNo.TabIndex = 50
        '
        'CryViewMTSReport
        '
        Me.CryViewMTSReport.ActiveViewIndex = -1
        Me.CryViewMTSReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CryViewMTSReport.Location = New System.Drawing.Point(43, 94)
        Me.CryViewMTSReport.Name = "CryViewMTSReport"
        Me.CryViewMTSReport.SelectionFormula = ""
        Me.CryViewMTSReport.Size = New System.Drawing.Size(878, 519)
        Me.CryViewMTSReport.TabIndex = 49
        Me.CryViewMTSReport.ViewTimeSelectionFormula = ""
        '
        'frmMTS_Report_Sterile_Reject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 642)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CmbMTSNo)
        Me.Controls.Add(Me.CryViewMTSReport)
        Me.Name = "frmMTS_Report_Sterile_Reject"
        Me.Text = "frmMTS_Report_Sterile_Reject"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CmbMTSNo As System.Windows.Forms.ComboBox
    Friend WithEvents CryViewMTSReport As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
