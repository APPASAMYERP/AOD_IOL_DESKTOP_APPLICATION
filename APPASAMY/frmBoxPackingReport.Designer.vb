<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBoxPackingReport
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
        Me.dtpto = New System.Windows.Forms.DateTimePicker
        Me.lblfrm = New System.Windows.Forms.Label
        Me.dtpfrom = New System.Windows.Forms.DateTimePicker
        Me.lbl = New System.Windows.Forms.Label
        Me.BtnSerch = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpto
        '
        Me.dtpto.CustomFormat = "dd/MM/yyyy"
        Me.dtpto.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpto.Location = New System.Drawing.Point(332, 16)
        Me.dtpto.Name = "dtpto"
        Me.dtpto.Size = New System.Drawing.Size(115, 22)
        Me.dtpto.TabIndex = 47
        Me.dtpto.Value = New Date(2023, 3, 28, 0, 0, 0, 0)
        '
        'lblfrm
        '
        Me.lblfrm.AutoSize = True
        Me.lblfrm.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfrm.ForeColor = System.Drawing.Color.Blue
        Me.lblfrm.Location = New System.Drawing.Point(17, 19)
        Me.lblfrm.Name = "lblfrm"
        Me.lblfrm.Size = New System.Drawing.Size(84, 16)
        Me.lblfrm.TabIndex = 44
        Me.lblfrm.Text = "FROM DATE"
        '
        'dtpfrom
        '
        Me.dtpfrom.CalendarForeColor = System.Drawing.Color.Navy
        Me.dtpfrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpfrom.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfrom.Location = New System.Drawing.Point(115, 15)
        Me.dtpfrom.Name = "dtpfrom"
        Me.dtpfrom.Size = New System.Drawing.Size(124, 22)
        Me.dtpfrom.TabIndex = 45
        Me.dtpfrom.Value = New Date(2023, 3, 28, 0, 0, 0, 0)
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.Blue
        Me.lbl.Location = New System.Drawing.Point(261, 19)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(63, 16)
        Me.lbl.TabIndex = 46
        Me.lbl.Text = "TO DATE"
        '
        'BtnSerch
        '
        Me.BtnSerch.BackColor = System.Drawing.Color.White
        Me.BtnSerch.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSerch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSerch.Location = New System.Drawing.Point(453, 15)
        Me.BtnSerch.Name = "BtnSerch"
        Me.BtnSerch.Size = New System.Drawing.Size(93, 32)
        Me.BtnSerch.TabIndex = 48
        Me.BtnSerch.Text = "SUBMIT"
        Me.BtnSerch.UseVisualStyleBackColor = False
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 53)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1338, 746)
        Me.CrystalReportViewer1.TabIndex = 49
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblfrm)
        Me.Panel1.Controls.Add(Me.lbl)
        Me.Panel1.Controls.Add(Me.BtnSerch)
        Me.Panel1.Controls.Add(Me.dtpfrom)
        Me.Panel1.Controls.Add(Me.dtpto)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1338, 53)
        Me.Panel1.TabIndex = 50
        '
        'frmBoxPackingReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1338, 799)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmBoxPackingReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBoxPackingReport"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents dtpto As System.Windows.Forms.DateTimePicker
    Private WithEvents lblfrm As System.Windows.Forms.Label
    Private WithEvents dtpfrom As System.Windows.Forms.DateTimePicker
    Private WithEvents lbl As System.Windows.Forms.Label
    Private WithEvents BtnSerch As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
