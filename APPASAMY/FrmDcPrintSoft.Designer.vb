<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDcPrintSoft
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
        Me.CmbBPLNo = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.CryViewDC = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.BtnView = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'CmbBPLNo
        '
        Me.CmbBPLNo.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBPLNo.FormattingEnabled = True
        Me.CmbBPLNo.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.CmbBPLNo.Location = New System.Drawing.Point(176, 6)
        Me.CmbBPLNo.Name = "CmbBPLNo"
        Me.CmbBPLNo.Size = New System.Drawing.Size(151, 24)
        Me.CmbBPLNo.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(42, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 16)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "DC_No"
        '
        'CryViewDC
        '
        Me.CryViewDC.ActiveViewIndex = -1
        Me.CryViewDC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CryViewDC.Location = New System.Drawing.Point(11, 39)
        Me.CryViewDC.Name = "CryViewDC"
        Me.CryViewDC.SelectionFormula = ""
        Me.CryViewDC.Size = New System.Drawing.Size(488, 464)
        Me.CryViewDC.TabIndex = 37
        Me.CryViewDC.ViewTimeSelectionFormula = ""
        '
        'BtnView
        '
        Me.BtnView.Location = New System.Drawing.Point(374, 9)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(75, 23)
        Me.BtnView.TabIndex = 36
        Me.BtnView.Text = "View"
        Me.BtnView.UseVisualStyleBackColor = True
        '
        'FrmDcPrintSoft
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 554)
        Me.Controls.Add(Me.CmbBPLNo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CryViewDC)
        Me.Controls.Add(Me.BtnView)
        Me.Name = "FrmDcPrintSoft"
        Me.Text = "FrmDcPrintSoft"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbBPLNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CryViewDC As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BtnView As System.Windows.Forms.Button
End Class
