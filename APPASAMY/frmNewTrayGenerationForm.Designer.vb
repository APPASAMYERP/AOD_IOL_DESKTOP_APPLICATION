<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewTrayGenerationForm
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
        Me.cmbBrand = New System.Windows.Forms.ComboBox
        Me.cmbModelNo = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cmbBrand
        '
        Me.cmbBrand.FormattingEnabled = True
        Me.cmbBrand.Location = New System.Drawing.Point(186, 50)
        Me.cmbBrand.Name = "cmbBrand"
        Me.cmbBrand.Size = New System.Drawing.Size(121, 21)
        Me.cmbBrand.TabIndex = 0
        '
        'cmbModelNo
        '
        Me.cmbModelNo.FormattingEnabled = True
        Me.cmbModelNo.Location = New System.Drawing.Point(186, 123)
        Me.cmbModelNo.Name = "cmbModelNo"
        Me.cmbModelNo.Size = New System.Drawing.Size(121, 21)
        Me.cmbModelNo.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(207, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "BRAND"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "MODEL"
        '
        'frmNewTrayGenerationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1607, 793)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbModelNo)
        Me.Controls.Add(Me.cmbBrand)
        Me.Name = "frmNewTrayGenerationForm"
        Me.Text = "frmNewTrayGenerationForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbBrand As System.Windows.Forms.ComboBox
    Friend WithEvents cmbModelNo As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
