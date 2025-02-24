<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLotdetailsReport
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
        Me.components = New System.ComponentModel.Container
        Me.CryViewBoxPackingRecord = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.btnView = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Cmbreflot = New System.Windows.Forms.ComboBox
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtLensoID = New System.Windows.Forms.TextBox
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CryViewBoxPackingRecord
        '
        Me.CryViewBoxPackingRecord.ActiveViewIndex = -1
        Me.CryViewBoxPackingRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CryViewBoxPackingRecord.Location = New System.Drawing.Point(12, 89)
        Me.CryViewBoxPackingRecord.Name = "CryViewBoxPackingRecord"
        Me.CryViewBoxPackingRecord.SelectionFormula = ""
        Me.CryViewBoxPackingRecord.Size = New System.Drawing.Size(1115, 611)
        Me.CryViewBoxPackingRecord.TabIndex = 42
        Me.CryViewBoxPackingRecord.ViewTimeSelectionFormula = ""
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(384, 31)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(63, 23)
        Me.btnView.TabIndex = 47
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(37, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 16)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Reflot"
        '
        'Cmbreflot
        '
        Me.Cmbreflot.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbreflot.FormattingEnabled = True
        Me.Cmbreflot.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.Cmbreflot.Location = New System.Drawing.Point(143, 12)
        Me.Cmbreflot.Name = "Cmbreflot"
        Me.Cmbreflot.Size = New System.Drawing.Size(183, 24)
        Me.Cmbreflot.TabIndex = 45
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(37, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Lensometer ID"
        '
        'txtLensoID
        '
        Me.txtLensoID.Location = New System.Drawing.Point(143, 50)
        Me.txtLensoID.Name = "txtLensoID"
        Me.txtLensoID.Size = New System.Drawing.Size(183, 20)
        Me.txtLensoID.TabIndex = 49
        '
        'FrmLotdetailsReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1235, 712)
        Me.Controls.Add(Me.txtLensoID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Cmbreflot)
        Me.Controls.Add(Me.CryViewBoxPackingRecord)
        Me.Name = "FrmLotdetailsReport"
        Me.Text = "FrmLotdetailsReport"
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CryViewBoxPackingRecord As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Cmbreflot As System.Windows.Forms.ComboBox
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLensoID As System.Windows.Forms.TextBox
End Class
