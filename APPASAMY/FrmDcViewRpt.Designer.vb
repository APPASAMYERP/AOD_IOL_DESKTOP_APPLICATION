<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDcViewRpt
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
        Me.CryViewDCLList = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.BtnView = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'CmbBPLNo
        '
        Me.CmbBPLNo.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBPLNo.FormattingEnabled = True
        Me.CmbBPLNo.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.CmbBPLNo.Location = New System.Drawing.Point(171, 9)
        Me.CmbBPLNo.Name = "CmbBPLNo"
        Me.CmbBPLNo.Size = New System.Drawing.Size(151, 24)
        Me.CmbBPLNo.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(37, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 16)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "DCL_No"
        '
        'CryViewDCLList
        '
        Me.CryViewDCLList.ActiveViewIndex = -1
        Me.CryViewDCLList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CryViewDCLList.Location = New System.Drawing.Point(6, 42)
        Me.CryViewDCLList.Name = "CryViewDCLList"
        Me.CryViewDCLList.SelectionFormula = ""
        Me.CryViewDCLList.Size = New System.Drawing.Size(948, 485)
        Me.CryViewDCLList.TabIndex = 37
        Me.CryViewDCLList.ViewTimeSelectionFormula = ""
        '
        'BtnView
        '
        Me.BtnView.Location = New System.Drawing.Point(369, 12)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(75, 23)
        Me.BtnView.TabIndex = 36
        Me.BtnView.Text = "View"
        Me.BtnView.UseVisualStyleBackColor = True
        '
        'FrmDcViewRpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 337)
        Me.Controls.Add(Me.CmbBPLNo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CryViewDCLList)
        Me.Controls.Add(Me.BtnView)
        Me.Name = "FrmDcViewRpt"
        Me.Text = "FrmDcViewRpt"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbBPLNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CryViewDCLList As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BtnView As System.Windows.Forms.Button
End Class
