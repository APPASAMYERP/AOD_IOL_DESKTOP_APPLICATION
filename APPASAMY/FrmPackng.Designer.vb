<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPackng
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbbrand = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtref = New System.Windows.Forms.TextBox
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.txtlotbarno = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lbldate = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblUser = New System.Windows.Forms.Label
        Me.Panel7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(34, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Brand Name "
        '
        'cmbbrand
        '
        Me.cmbbrand.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbrand.FormattingEnabled = True
        Me.cmbbrand.Items.AddRange(New Object() {"ACRYFOLD", "APPALENS", "GALAXY FOLD", "LIBERTY LENS", "SWISS FOLD - HD", "SWISS LENS"})
        Me.cmbbrand.Location = New System.Drawing.Point(162, 22)
        Me.cmbbrand.Name = "cmbbrand"
        Me.cmbbrand.Size = New System.Drawing.Size(138, 23)
        Me.cmbbrand.Sorted = True
        Me.cmbbrand.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(34, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "REF"
        '
        'txtref
        '
        Me.txtref.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtref.Location = New System.Drawing.Point(162, 59)
        Me.txtref.Name = "txtref"
        Me.txtref.Size = New System.Drawing.Size(138, 22)
        Me.txtref.TabIndex = 16
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.txtlotbarno)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Location = New System.Drawing.Point(10, 219)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(549, 136)
        Me.Panel7.TabIndex = 41
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
        Me.Label5.Size = New System.Drawing.Size(141, 29)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Scan Lot No"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmbbrand)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtref)
        Me.Panel1.Location = New System.Drawing.Point(11, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(548, 136)
        Me.Panel1.TabIndex = 42
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Navy
        Me.Panel3.Controls.Add(Me.lbldate)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.lblUser)
        Me.Panel3.Location = New System.Drawing.Point(1, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(565, 52)
        Me.Panel3.TabIndex = 43
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(203, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 43)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Packing"
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
        'FrmPackng
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(569, 372)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel7)
        Me.MaximizeBox = False
        Me.Name = "FrmPackng"
        Me.Text = "Packing"
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbbrand As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtref As System.Windows.Forms.TextBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents txtlotbarno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
End Class
