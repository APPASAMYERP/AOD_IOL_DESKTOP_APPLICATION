<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewMaster
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtBrdName = New System.Windows.Forms.TextBox
        Me.txtmdl = New System.Windows.Forms.TextBox
        Me.txtrefname = New System.Windows.Forms.TextBox
        Me.txtgscode = New System.Windows.Forms.TextBox
        Me.txtpwr = New System.Windows.Forms.TextBox
        Me.txtopt = New System.Windows.Forms.TextBox
        Me.txtlen = New System.Windows.Forms.TextBox
        Me.txtacon = New System.Windows.Forms.TextBox
        Me.txtexp = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnexit = New System.Windows.Forms.Button
        Me.Btnedit = New System.Windows.Forms.Button
        Me.Btnadd = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cbxtypegscode = New System.Windows.Forms.ComboBox
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(17, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Brand_Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(17, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Model_Name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(17, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Reference_Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(17, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "GS_Code"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(17, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Power"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(293, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Optic"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(293, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Length"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(293, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "A_Constant"
        '
        'txtBrdName
        '
        Me.txtBrdName.Location = New System.Drawing.Point(130, 34)
        Me.txtBrdName.Name = "txtBrdName"
        Me.txtBrdName.Size = New System.Drawing.Size(116, 20)
        Me.txtBrdName.TabIndex = 8
        '
        'txtmdl
        '
        Me.txtmdl.Location = New System.Drawing.Point(130, 80)
        Me.txtmdl.Name = "txtmdl"
        Me.txtmdl.Size = New System.Drawing.Size(116, 20)
        Me.txtmdl.TabIndex = 9
        '
        'txtrefname
        '
        Me.txtrefname.Location = New System.Drawing.Point(130, 125)
        Me.txtrefname.Name = "txtrefname"
        Me.txtrefname.Size = New System.Drawing.Size(116, 20)
        Me.txtrefname.TabIndex = 10
        '
        'txtgscode
        '
        Me.txtgscode.Location = New System.Drawing.Point(130, 181)
        Me.txtgscode.Name = "txtgscode"
        Me.txtgscode.Size = New System.Drawing.Size(116, 20)
        Me.txtgscode.TabIndex = 11
        '
        'txtpwr
        '
        Me.txtpwr.Location = New System.Drawing.Point(130, 226)
        Me.txtpwr.Name = "txtpwr"
        Me.txtpwr.Size = New System.Drawing.Size(116, 20)
        Me.txtpwr.TabIndex = 12
        '
        'txtopt
        '
        Me.txtopt.Location = New System.Drawing.Point(409, 28)
        Me.txtopt.Name = "txtopt"
        Me.txtopt.Size = New System.Drawing.Size(116, 20)
        Me.txtopt.TabIndex = 13
        '
        'txtlen
        '
        Me.txtlen.Location = New System.Drawing.Point(410, 77)
        Me.txtlen.Name = "txtlen"
        Me.txtlen.Size = New System.Drawing.Size(116, 20)
        Me.txtlen.TabIndex = 14
        '
        'txtacon
        '
        Me.txtacon.Location = New System.Drawing.Point(409, 122)
        Me.txtacon.Name = "txtacon"
        Me.txtacon.Size = New System.Drawing.Size(116, 20)
        Me.txtacon.TabIndex = 15
        '
        'txtexp
        '
        Me.txtexp.Location = New System.Drawing.Point(409, 226)
        Me.txtexp.Name = "txtexp"
        Me.txtexp.Size = New System.Drawing.Size(116, 20)
        Me.txtexp.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(293, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Tot_Exp"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(293, 184)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Type_GS_Code"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Btnexit)
        Me.Panel1.Controls.Add(Me.Btnedit)
        Me.Panel1.Controls.Add(Me.Btnadd)
        Me.Panel1.Location = New System.Drawing.Point(27, 328)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(574, 83)
        Me.Panel1.TabIndex = 20
        '
        'Btnexit
        '
        Me.Btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnexit.ForeColor = System.Drawing.Color.Red
        Me.Btnexit.Location = New System.Drawing.Point(367, 18)
        Me.Btnexit.Name = "Btnexit"
        Me.Btnexit.Size = New System.Drawing.Size(87, 46)
        Me.Btnexit.TabIndex = 22
        Me.Btnexit.Text = "Exit"
        Me.Btnexit.UseVisualStyleBackColor = True
        '
        'Btnedit
        '
        Me.Btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnedit.ForeColor = System.Drawing.Color.Blue
        Me.Btnedit.Location = New System.Drawing.Point(236, 18)
        Me.Btnedit.Name = "Btnedit"
        Me.Btnedit.Size = New System.Drawing.Size(87, 46)
        Me.Btnedit.TabIndex = 21
        Me.Btnedit.Text = "Edit"
        Me.Btnedit.UseVisualStyleBackColor = True
        '
        'Btnadd
        '
        Me.Btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnadd.ForeColor = System.Drawing.Color.DarkGreen
        Me.Btnadd.Location = New System.Drawing.Point(101, 18)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(87, 46)
        Me.Btnadd.TabIndex = 0
        Me.Btnadd.Text = "ADD New"
        Me.Btnadd.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cbxtypegscode)
        Me.Panel2.Controls.Add(Me.txtexp)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txtacon)
        Me.Panel2.Controls.Add(Me.txtlen)
        Me.Panel2.Controls.Add(Me.txtopt)
        Me.Panel2.Controls.Add(Me.txtpwr)
        Me.Panel2.Controls.Add(Me.txtgscode)
        Me.Panel2.Controls.Add(Me.txtrefname)
        Me.Panel2.Controls.Add(Me.txtmdl)
        Me.Panel2.Controls.Add(Me.txtBrdName)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(27, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(574, 282)
        Me.Panel2.TabIndex = 21
        '
        'cbxtypegscode
        '
        Me.cbxtypegscode.FormattingEnabled = True
        Me.cbxtypegscode.Items.AddRange(New Object() {"AI", "AOD", "TURKEY"})
        Me.cbxtypegscode.Location = New System.Drawing.Point(409, 179)
        Me.cbxtypegscode.Name = "cbxtypegscode"
        Me.cbxtypegscode.Size = New System.Drawing.Size(121, 22)
        Me.cbxtypegscode.TabIndex = 20
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'FrmNewMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(650, 479)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmNewMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBrdName As System.Windows.Forms.TextBox
    Friend WithEvents txtmdl As System.Windows.Forms.TextBox
    Friend WithEvents txtrefname As System.Windows.Forms.TextBox
    Friend WithEvents txtgscode As System.Windows.Forms.TextBox
    Friend WithEvents txtpwr As System.Windows.Forms.TextBox
    Friend WithEvents txtopt As System.Windows.Forms.TextBox
    Friend WithEvents txtlen As System.Windows.Forms.TextBox
    Friend WithEvents txtacon As System.Windows.Forms.TextBox
    Friend WithEvents txtexp As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnexit As System.Windows.Forms.Button
    Friend WithEvents Btnedit As System.Windows.Forms.Button
    Friend WithEvents Btnadd As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents cbxtypegscode As System.Windows.Forms.ComboBox
End Class
