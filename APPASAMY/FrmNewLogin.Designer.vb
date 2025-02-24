<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewLogin
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtUsername = New System.Windows.Forms.TextBox
        Me.PasswordLabel = New System.Windows.Forms.Label
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.errLogin = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.errLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cancel)
        Me.GroupBox1.Controls.Add(Me.OK)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.PasswordLabel)
        Me.GroupBox1.Controls.Add(Me.UsernameLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(67, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(468, 173)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Login"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(225, 128)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 18
        Me.Cancel.Text = "&Cancel"
        '
        'OK
        '
        Me.OK.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(122, 128)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 17
        Me.OK.Text = "&OK"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(198, 78)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(220, 22)
        Me.txtPassword.TabIndex = 16
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(198, 40)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(220, 22)
        Me.txtUsername.TabIndex = 14
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.Color.Navy
        Me.PasswordLabel.Location = New System.Drawing.Point(81, 78)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(74, 23)
        Me.PasswordLabel.TabIndex = 15
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.Navy
        Me.UsernameLabel.Location = New System.Drawing.Point(81, 37)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(110, 23)
        Me.UsernameLabel.TabIndex = 13
        Me.UsernameLabel.Text = "&User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'errLogin
        '
        Me.errLogin.ContainerControl = Me
        '
        'FrmNewLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(728, 458)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmNewLogin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.errLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents errLogin As System.Windows.Forms.ErrorProvider
End Class
