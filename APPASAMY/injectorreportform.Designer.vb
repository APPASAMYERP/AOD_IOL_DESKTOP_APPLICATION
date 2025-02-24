<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class injectorreportform
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
        Me.Btnstock = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'Btnstock
        '
        Me.Btnstock.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnstock.ForeColor = System.Drawing.Color.Red
        Me.Btnstock.Location = New System.Drawing.Point(410, 12)
        Me.Btnstock.Name = "Btnstock"
        Me.Btnstock.Size = New System.Drawing.Size(148, 42)
        Me.Btnstock.TabIndex = 4
        Me.Btnstock.Text = "View Injector Stock"
        Me.Btnstock.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(12, 73)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1142, 610)
        Me.CrystalReportViewer1.TabIndex = 5
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'injectorreportform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1166, 711)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Btnstock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "injectorreportform"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "injectorreportform"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btnstock As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer

End Class
