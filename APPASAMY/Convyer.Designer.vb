<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Convyer
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
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.txtlotbarno = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbldate = New System.Windows.Forms.Label
        Me.lblUser = New System.Windows.Forms.Label
        Me.Panel7.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.txtlotbarno)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Location = New System.Drawing.Point(8, 291)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(562, 136)
        Me.Panel7.TabIndex = 42
        '
        'txtlotbarno
        '
        Me.txtlotbarno.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlotbarno.Location = New System.Drawing.Point(198, 34)
        Me.txtlotbarno.Name = "txtlotbarno"
        Me.txtlotbarno.Size = New System.Drawing.Size(317, 48)
        Me.txtlotbarno.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(29, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 29)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Scan 2D No"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Navy
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.lbldate)
        Me.Panel3.Controls.Add(Me.lblUser)
        Me.Panel3.Location = New System.Drawing.Point(7, 17)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(571, 52)
        Me.Panel3.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(186, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 43)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Conveyor"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.Color.Blue
        Me.lbldate.Location = New System.Drawing.Point(723, 34)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(40, 16)
        Me.lbldate.TabIndex = 28
        Me.lbldate.Text = "User "
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Blue
        Me.lblUser.Location = New System.Drawing.Point(721, 7)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(40, 16)
        Me.lblUser.TabIndex = 27
        Me.lblUser.Text = "User "
        '
        'Convyer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(582, 469)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel7)
        Me.Name = "Convyer"
        Me.Text = "Conveyar"
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents txtlotbarno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
