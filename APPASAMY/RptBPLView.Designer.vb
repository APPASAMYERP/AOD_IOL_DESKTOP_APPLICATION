<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RptBPLView
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
        Me.BtnView = New System.Windows.Forms.Button
        Me.CryViewBPLList = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.CmbBPLNo = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnView
        '
        Me.BtnView.Location = New System.Drawing.Point(565, 19)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(75, 23)
        Me.BtnView.TabIndex = 0
        Me.BtnView.Text = "View"
        Me.BtnView.UseVisualStyleBackColor = True
        Me.BtnView.Visible = False
        '
        'CryViewBPLList
        '
        Me.CryViewBPLList.ActiveViewIndex = -1
        Me.CryViewBPLList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CryViewBPLList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CryViewBPLList.Location = New System.Drawing.Point(0, 45)
        Me.CryViewBPLList.Name = "CryViewBPLList"
        Me.CryViewBPLList.SelectionFormula = ""
        Me.CryViewBPLList.Size = New System.Drawing.Size(1061, 611)
        Me.CryViewBPLList.TabIndex = 1
        Me.CryViewBPLList.ViewTimeSelectionFormula = ""
        '
        'CmbBPLNo
        '
        Me.CmbBPLNo.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBPLNo.FormattingEnabled = True
        Me.CmbBPLNo.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.CmbBPLNo.Location = New System.Drawing.Point(148, 16)
        Me.CmbBPLNo.Name = "CmbBPLNo"
        Me.CmbBPLNo.Size = New System.Drawing.Size(151, 24)
        Me.CmbBPLNo.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(14, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 16)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "BPL_No"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.CmbBPLNo)
        Me.Panel1.Controls.Add(Me.BtnView)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1061, 45)
        Me.Panel1.TabIndex = 36
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(328, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "View"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RptBPLView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 656)
        Me.Controls.Add(Me.CryViewBPLList)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "RptBPLView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BPL Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnView As System.Windows.Forms.Button
    Friend WithEvents CryViewBPLList As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CmbBPLNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
