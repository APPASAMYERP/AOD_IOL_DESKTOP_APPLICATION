<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class overall_stock
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
        Me.Btnview = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'Btnview
        '
        Me.Btnview.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnview.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Btnview.Location = New System.Drawing.Point(419, 38)
        Me.Btnview.Name = "Btnview"
        Me.Btnview.Size = New System.Drawing.Size(361, 42)
        Me.Btnview.TabIndex = 91
        Me.Btnview.Text = "Stock"
        Me.Btnview.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(3, 86)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1338, 511)
        Me.CrystalReportViewer1.TabIndex = 92
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'overall_stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 682)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Btnview)
        Me.Name = "overall_stock"
        Me.Text = "overall_stock"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btnview As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
