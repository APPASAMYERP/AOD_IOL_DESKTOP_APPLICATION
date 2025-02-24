<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDespatchrpt
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnview = New System.Windows.Forms.Button
        Me.Despatchbydate = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.dtpdesfrom = New System.Windows.Forms.DateTimePicker
        Me.dtpdesto = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbxmodel = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(295, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " DespatchFrom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(572, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Despatch To"
        '
        'btnview
        '
        Me.btnview.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnview.Location = New System.Drawing.Point(879, 21)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(75, 23)
        Me.btnview.TabIndex = 4
        Me.btnview.Text = "View"
        Me.btnview.UseVisualStyleBackColor = True
        '
        'Despatchbydate
        '
        Me.Despatchbydate.ActiveViewIndex = -1
        Me.Despatchbydate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Despatchbydate.Location = New System.Drawing.Point(12, 62)
        Me.Despatchbydate.Name = "Despatchbydate"
        Me.Despatchbydate.SelectionFormula = ""
        Me.Despatchbydate.Size = New System.Drawing.Size(1093, 647)
        Me.Despatchbydate.TabIndex = 5
        Me.Despatchbydate.ViewTimeSelectionFormula = ""
        '
        'dtpdesfrom
        '
        Me.dtpdesfrom.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdesfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdesfrom.Location = New System.Drawing.Point(416, 28)
        Me.dtpdesfrom.Name = "dtpdesfrom"
        Me.dtpdesfrom.Size = New System.Drawing.Size(123, 22)
        Me.dtpdesfrom.TabIndex = 6
        '
        'dtpdesto
        '
        Me.dtpdesto.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdesto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdesto.Location = New System.Drawing.Point(693, 23)
        Me.dtpdesto.Name = "dtpdesto"
        Me.dtpdesto.Size = New System.Drawing.Size(123, 22)
        Me.dtpdesto.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Model"
        '
        'cbxmodel
        '
        Me.cbxmodel.FormattingEnabled = True
        Me.cbxmodel.Location = New System.Drawing.Point(99, 23)
        Me.cbxmodel.Name = "cbxmodel"
        Me.cbxmodel.Size = New System.Drawing.Size(162, 21)
        Me.cbxmodel.TabIndex = 9
        '
        'frmDespatchrpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 698)
        Me.Controls.Add(Me.cbxmodel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpdesto)
        Me.Controls.Add(Me.dtpdesfrom)
        Me.Controls.Add(Me.Despatchbydate)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDespatchrpt"
        Me.Text = "frmDespatchrpt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnview As System.Windows.Forms.Button
    Friend WithEvents Despatchbydate As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents dtpdesfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpdesto As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbxmodel As System.Windows.Forms.ComboBox
End Class
