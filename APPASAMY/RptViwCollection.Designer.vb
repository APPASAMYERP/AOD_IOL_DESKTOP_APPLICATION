<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RptViwCollection
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
        Me.CryViewCollectList = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CryViewCollectList
        '
        Me.CryViewCollectList.ActiveViewIndex = -1
        Me.CryViewCollectList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CryViewCollectList.Location = New System.Drawing.Point(5, 1)
        Me.CryViewCollectList.Name = "CryViewCollectList"
        Me.CryViewCollectList.SelectionFormula = ""
        Me.CryViewCollectList.Size = New System.Drawing.Size(1479, 742)
        Me.CryViewCollectList.TabIndex = 38
        Me.CryViewCollectList.ViewTimeSelectionFormula = ""
        '
        'RptViwCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 620)
        Me.Controls.Add(Me.CryViewCollectList)
        Me.Name = "RptViwCollection"
        Me.Text = "RptViwCollection"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CryViewCollectList As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
