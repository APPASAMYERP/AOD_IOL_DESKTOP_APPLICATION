<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBoxPackingRecord
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
        Me.CmbBPLNo = New System.Windows.Forms.ComboBox
        Me.CryViewBoxPackingRecord = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(328, 19)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 23)
        Me.btnView.TabIndex = 40
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(14, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 16)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "BPL_No"
        '
        'CmbBPLNo
        '
        Me.CmbBPLNo.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBPLNo.FormattingEnabled = True
        Me.CmbBPLNo.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.CmbBPLNo.Location = New System.Drawing.Point(148, 16)
        Me.CmbBPLNo.Name = "CmbBPLNo"
        Me.CmbBPLNo.Size = New System.Drawing.Size(151, 24)
        Me.CmbBPLNo.TabIndex = 38
        '
        'CryViewBoxPackingRecord
        '
        Me.CryViewBoxPackingRecord.ActiveViewIndex = -1
        Me.CryViewBoxPackingRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CryViewBoxPackingRecord.Location = New System.Drawing.Point(17, 62)
        Me.CryViewBoxPackingRecord.Name = "CryViewBoxPackingRecord"
        Me.CryViewBoxPackingRecord.SelectionFormula = ""
        Me.CryViewBoxPackingRecord.Size = New System.Drawing.Size(1061, 611)
        Me.CryViewBoxPackingRecord.TabIndex = 37
        Me.CryViewBoxPackingRecord.ViewTimeSelectionFormula = ""
        '
        'FrmBoxPackingRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 732)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CmbBPLNo)
        Me.Controls.Add(Me.CryViewBoxPackingRecord)
        Me.Name = "FrmBoxPackingRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBoxPackingRecord"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CmbBPLNo As System.Windows.Forms.ComboBox
    Friend WithEvents CryViewBoxPackingRecord As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
