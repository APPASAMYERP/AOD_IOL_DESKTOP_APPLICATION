<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBPLVIewFrm
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
        Me.CryViewBPLList = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.BtnView = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'CmbBPLNo
        '
        Me.CmbBPLNo.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBPLNo.FormattingEnabled = True
        Me.CmbBPLNo.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.CmbBPLNo.Location = New System.Drawing.Point(472, -1)
        Me.CmbBPLNo.Name = "CmbBPLNo"
        Me.CmbBPLNo.Size = New System.Drawing.Size(151, 24)
        Me.CmbBPLNo.TabIndex = 38
        Me.CmbBPLNo.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(382, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 16)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "BPL_No"
        Me.Label8.Visible = False
        '
        'CryViewBPLList
        '
        Me.CryViewBPLList.ActiveViewIndex = -1
        Me.CryViewBPLList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CryViewBPLList.Location = New System.Drawing.Point(2, -1)
        Me.CryViewBPLList.Name = "CryViewBPLList"
        Me.CryViewBPLList.SelectionFormula = ""
        Me.CryViewBPLList.Size = New System.Drawing.Size(653, 464)
        Me.CryViewBPLList.TabIndex = 37
        Me.CryViewBPLList.ViewTimeSelectionFormula = ""
        '
        'BtnView
        '
        Me.BtnView.Location = New System.Drawing.Point(385, 25)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(75, 23)
        Me.BtnView.TabIndex = 36
        Me.BtnView.Text = "View"
        Me.BtnView.UseVisualStyleBackColor = True
        Me.BtnView.Visible = False
        '
        'FrmBPLVIewFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 402)
        Me.Controls.Add(Me.CmbBPLNo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CryViewBPLList)
        Me.Controls.Add(Me.BtnView)
        Me.Name = "FrmBPLVIewFrm"
        Me.Text = "FrmBPLVIewFrm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbBPLNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CryViewBPLList As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BtnView As System.Windows.Forms.Button
End Class
