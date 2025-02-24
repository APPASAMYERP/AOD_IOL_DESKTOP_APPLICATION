<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LotNoDataReport
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbLotNo = New System.Windows.Forms.ComboBox
        Me.BtnView = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Type = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(245, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lot No:"
        '
        'cmbLotNo
        '
        Me.cmbLotNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbLotNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbLotNo.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLotNo.FormattingEnabled = True
        Me.cmbLotNo.Location = New System.Drawing.Point(316, 11)
        Me.cmbLotNo.Name = "cmbLotNo"
        Me.cmbLotNo.Size = New System.Drawing.Size(139, 24)
        Me.cmbLotNo.TabIndex = 1
        '
        'BtnView
        '
        Me.BtnView.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnView.ForeColor = System.Drawing.Color.Blue
        Me.BtnView.Location = New System.Drawing.Point(471, 13)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(75, 23)
        Me.BtnView.TabIndex = 2
        Me.BtnView.Text = "VIEW"
        Me.BtnView.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 46)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1194, 689)
        Me.CrystalReportViewer1.TabIndex = 3
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(64, 10)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(139, 24)
        Me.ComboBox2.TabIndex = 4
        '
        'Type
        '
        Me.Type.AutoSize = True
        Me.Type.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Type.ForeColor = System.Drawing.Color.Blue
        Me.Type.Location = New System.Drawing.Point(13, 13)
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(45, 16)
        Me.Type.TabIndex = 5
        Me.Type.Text = "Type"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Type)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.cmbLotNo)
        Me.Panel1.Controls.Add(Me.BtnView)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1194, 46)
        Me.Panel1.TabIndex = 6
        '
        'LotNoDataReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1194, 735)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "LotNoDataReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LotNoDataReport"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbLotNo As System.Windows.Forms.ComboBox
    Friend WithEvents BtnView As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Type As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
