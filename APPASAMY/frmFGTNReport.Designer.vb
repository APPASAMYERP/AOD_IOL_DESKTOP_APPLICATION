<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFGTNReport
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
        Me.CmbFGTN_No = New System.Windows.Forms.ComboBox
        Me.CryViewMTSReport = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(432, 13)
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
        Me.Label8.Location = New System.Drawing.Point(74, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 16)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "FGTN NO"
        '
        'CmbFGTN_No
        '
        Me.CmbFGTN_No.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbFGTN_No.FormattingEnabled = True
        Me.CmbFGTN_No.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.CmbFGTN_No.Location = New System.Drawing.Point(169, 20)
        Me.CmbFGTN_No.Name = "CmbFGTN_No"
        Me.CmbFGTN_No.Size = New System.Drawing.Size(236, 24)
        Me.CmbFGTN_No.TabIndex = 50
        '
        'CryViewMTSReport
        '
        Me.CryViewMTSReport.ActiveViewIndex = -1
        Me.CryViewMTSReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CryViewMTSReport.Location = New System.Drawing.Point(59, 78)
        Me.CryViewMTSReport.Name = "CryViewMTSReport"
        Me.CryViewMTSReport.SelectionFormula = ""
        Me.CryViewMTSReport.Size = New System.Drawing.Size(878, 475)
        Me.CryViewMTSReport.TabIndex = 49
        Me.CryViewMTSReport.ViewTimeSelectionFormula = ""
        '
        'frmFGTNReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 591)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CmbFGTN_No)
        Me.Controls.Add(Me.CryViewMTSReport)
        Me.Name = "frmFGTNReport"
        Me.Text = "frmFGTNReport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CmbFGTN_No As System.Windows.Forms.ComboBox
    Friend WithEvents CryViewMTSReport As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
