<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewDC2D
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
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnprint = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbxdcno = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(419, 290)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 36)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(295, 290)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 36)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Location = New System.Drawing.Point(174, 290)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(85, 36)
        Me.btnprint.TabIndex = 7
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(171, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "DC NO"
        '
        'cbxdcno
        '
        Me.cbxdcno.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxdcno.FormattingEnabled = True
        Me.cbxdcno.Location = New System.Drawing.Point(295, 187)
        Me.cbxdcno.Name = "cbxdcno"
        Me.cbxdcno.Size = New System.Drawing.Size(188, 26)
        Me.cbxdcno.TabIndex = 5
        '
        'FrmNewDC2D
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(675, 513)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxdcno)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmNewDC2D"
        Me.Text = "FrmNewDC2D"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxdcno As System.Windows.Forms.ComboBox
End Class
