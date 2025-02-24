<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cstreportform
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
        Me.lblno = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Batch = New System.Windows.Forms.ComboBox
        Me.samplecombo = New System.Windows.Forms.ComboBox
        Me.showbtn = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'lblno
        '
        Me.lblno.AutoSize = True
        Me.lblno.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblno.ForeColor = System.Drawing.Color.Blue
        Me.lblno.Location = New System.Drawing.Point(234, 38)
        Me.lblno.Name = "lblno"
        Me.lblno.Size = New System.Drawing.Size(0, 29)
        Me.lblno.TabIndex = 83
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(462, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 29)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Sample Report Form"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(357, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Batch No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(612, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 16)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "Type Sample"
        '
        'Batch
        '
        Me.Batch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Batch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Batch.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Batch.FormattingEnabled = True
        Me.Batch.Location = New System.Drawing.Point(436, 122)
        Me.Batch.Name = "Batch"
        Me.Batch.Size = New System.Drawing.Size(130, 24)
        Me.Batch.TabIndex = 87
        '
        'samplecombo
        '
        Me.samplecombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.samplecombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.samplecombo.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.samplecombo.FormattingEnabled = True
        Me.samplecombo.Items.AddRange(New Object() {"CST", "SST"})
        Me.samplecombo.Location = New System.Drawing.Point(720, 117)
        Me.samplecombo.Name = "samplecombo"
        Me.samplecombo.Size = New System.Drawing.Size(130, 24)
        Me.samplecombo.TabIndex = 88
        '
        'showbtn
        '
        Me.showbtn.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showbtn.ForeColor = System.Drawing.Color.Red
        Me.showbtn.Location = New System.Drawing.Point(544, 172)
        Me.showbtn.Name = "showbtn"
        Me.showbtn.Size = New System.Drawing.Size(108, 42)
        Me.showbtn.TabIndex = 89
        Me.showbtn.Text = "Show"
        Me.showbtn.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(-1, 220)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1382, 597)
        Me.CrystalReportViewer1.TabIndex = 90
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'cstreportform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1439, 818)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.showbtn)
        Me.Controls.Add(Me.samplecombo)
        Me.Controls.Add(Me.Batch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblno)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Name = "cstreportform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cstreportform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblno As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Batch As System.Windows.Forms.ComboBox
    Friend WithEvents samplecombo As System.Windows.Forms.ComboBox
    Friend WithEvents showbtn As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
