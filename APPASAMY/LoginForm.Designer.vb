<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.PasswordLabel = New System.Windows.Forms.Label
        Me.txtUsername = New System.Windows.Forms.TextBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.OK = New System.Windows.Forms.Button
        Me.Cancel = New System.Windows.Forms.Button
        Me.errLogin = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbProductLine = New System.Windows.Forms.ComboBox
        Me.cmbStation = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.chkIsBoxPacking = New System.Windows.Forms.CheckBox
        Me.txtUsername2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_MachineName = New System.Windows.Forms.TextBox
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        CType(Me.errLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.Navy
        Me.UsernameLabel.Location = New System.Drawing.Point(223, 149)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.Color.Navy
        Me.PasswordLabel.Location = New System.Drawing.Point(223, 206)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(224, 169)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(220, 20)
        Me.txtUsername.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(224, 226)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(220, 20)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'OK
        '
        Me.OK.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(226, 257)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&OK"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(329, 257)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Cancel"
        '
        'errLogin
        '
        Me.errLogin.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(221, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Product Line"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbProductLine
        '
        Me.cmbProductLine.FormattingEnabled = True
        Me.cmbProductLine.Items.AddRange(New Object() {"PMMA", "PHILIC", "PHOBIC", "PHOBIC NONPRELOADED", "SUPERPHOB"})
        Me.cmbProductLine.Location = New System.Drawing.Point(224, 71)
        Me.cmbProductLine.Name = "cmbProductLine"
        Me.cmbProductLine.Size = New System.Drawing.Size(214, 21)
        Me.cmbProductLine.TabIndex = 7
        '
        'cmbStation
        '
        Me.cmbStation.FormattingEnabled = True
        Me.cmbStation.Location = New System.Drawing.Point(226, 116)
        Me.cmbStation.Name = "cmbStation"
        Me.cmbStation.Size = New System.Drawing.Size(214, 21)
        Me.cmbStation.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(223, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Station"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkIsBoxPacking
        '
        Me.chkIsBoxPacking.AutoSize = True
        Me.chkIsBoxPacking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.chkIsBoxPacking.Location = New System.Drawing.Point(13, 213)
        Me.chkIsBoxPacking.Margin = New System.Windows.Forms.Padding(2)
        Me.chkIsBoxPacking.Name = "chkIsBoxPacking"
        Me.chkIsBoxPacking.Size = New System.Drawing.Size(91, 17)
        Me.chkIsBoxPacking.TabIndex = 10
        Me.chkIsBoxPacking.Text = "IsBoxPacking"
        Me.chkIsBoxPacking.UseVisualStyleBackColor = True
        Me.chkIsBoxPacking.Visible = False
        '
        'txtUsername2
        '
        Me.txtUsername2.Location = New System.Drawing.Point(11, 260)
        Me.txtUsername2.Name = "txtUsername2"
        Me.txtUsername2.Size = New System.Drawing.Size(197, 20)
        Me.txtUsername2.TabIndex = 12
        Me.txtUsername2.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(10, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(196, 23)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "&Packed By"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(224, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(220, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Machine Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_MachineName
        '
        Me.txt_MachineName.Enabled = False
        Me.txt_MachineName.Location = New System.Drawing.Point(223, 29)
        Me.txt_MachineName.MaxLength = 100000
        Me.txt_MachineName.Name = "txt_MachineName"
        Me.txt_MachineName.Size = New System.Drawing.Size(221, 20)
        Me.txt_MachineName.TabIndex = 1
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(23, 24)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(123, 122)
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'LoginForm
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(473, 299)
        Me.Controls.Add(Me.txtUsername2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkIsBoxPacking)
        Me.Controls.Add(Me.cmbStation)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbProductLine)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txt_MachineName)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Login"
        CType(Me.errLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents errLogin As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbProductLine As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbStation As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUsername2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkIsBoxPacking As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_MachineName As System.Windows.Forms.TextBox

End Class
