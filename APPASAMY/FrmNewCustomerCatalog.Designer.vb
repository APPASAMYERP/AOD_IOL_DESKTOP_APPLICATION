<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewCustomerCatalog
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
        Me.txtcountry = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtadd1 = New System.Windows.Forms.TextBox
        Me.txtstate = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtcompanyName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtadd2 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtlocation = New System.Windows.Forms.TextBox
        Me.txtpincode = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtcontactperson = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtmobileno = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txttelno = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtemailid = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnClear = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtcountry
        '
        Me.txtcountry.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcountry.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcountry.Location = New System.Drawing.Point(124, 214)
        Me.txtcountry.Name = "txtcountry"
        Me.txtcountry.Size = New System.Drawing.Size(256, 22)
        Me.txtcountry.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(12, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Country"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(12, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Address1"
        '
        'txtadd1
        '
        Me.txtadd1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtadd1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtadd1.Location = New System.Drawing.Point(125, 62)
        Me.txtadd1.Name = "txtadd1"
        Me.txtadd1.Size = New System.Drawing.Size(256, 22)
        Me.txtadd1.TabIndex = 2
        '
        'txtstate
        '
        Me.txtstate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtstate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstate.Location = New System.Drawing.Point(125, 176)
        Me.txtstate.Name = "txtstate"
        Me.txtstate.Size = New System.Drawing.Size(256, 22)
        Me.txtstate.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(12, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "State"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(12, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 16)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Customer Name"
        '
        'txtcompanyName
        '
        Me.txtcompanyName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcompanyName.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcompanyName.Location = New System.Drawing.Point(125, 24)
        Me.txtcompanyName.Name = "txtcompanyName"
        Me.txtcompanyName.Size = New System.Drawing.Size(256, 22)
        Me.txtcompanyName.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(12, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 16)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Address1"
        '
        'txtadd2
        '
        Me.txtadd2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtadd2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtadd2.Location = New System.Drawing.Point(125, 100)
        Me.txtadd2.Name = "txtadd2"
        Me.txtadd2.Size = New System.Drawing.Size(256, 22)
        Me.txtadd2.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(12, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 16)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Location"
        '
        'txtlocation
        '
        Me.txtlocation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtlocation.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlocation.Location = New System.Drawing.Point(125, 138)
        Me.txtlocation.Name = "txtlocation"
        Me.txtlocation.Size = New System.Drawing.Size(256, 22)
        Me.txtlocation.TabIndex = 4
        '
        'txtpincode
        '
        Me.txtpincode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtpincode.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpincode.Location = New System.Drawing.Point(125, 252)
        Me.txtpincode.Name = "txtpincode"
        Me.txtpincode.Size = New System.Drawing.Size(256, 22)
        Me.txtpincode.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(12, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Pincode"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(399, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 16)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Contact Person"
        '
        'txtcontactperson
        '
        Me.txtcontactperson.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcontactperson.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontactperson.Location = New System.Drawing.Point(532, 26)
        Me.txtcontactperson.Name = "txtcontactperson"
        Me.txtcontactperson.Size = New System.Drawing.Size(138, 22)
        Me.txtcontactperson.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(399, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 16)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Tel.No"
        '
        'txtmobileno
        '
        Me.txtmobileno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmobileno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmobileno.Location = New System.Drawing.Point(532, 59)
        Me.txtmobileno.Name = "txtmobileno"
        Me.txtmobileno.Size = New System.Drawing.Size(138, 22)
        Me.txtmobileno.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(399, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 16)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Mobile No"
        '
        'txttelno
        '
        Me.txttelno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttelno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelno.Location = New System.Drawing.Point(532, 92)
        Me.txttelno.Name = "txttelno"
        Me.txttelno.Size = New System.Drawing.Size(138, 22)
        Me.txttelno.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(399, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 16)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Email Id"
        '
        'txtemailid
        '
        Me.txtemailid.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemailid.Location = New System.Drawing.Point(532, 125)
        Me.txtemailid.Name = "txtemailid"
        Me.txtemailid.Size = New System.Drawing.Size(138, 22)
        Me.txtemailid.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtemailid)
        Me.GroupBox1.Controls.Add(Me.txtstate)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtadd1)
        Me.GroupBox1.Controls.Add(Me.txttelno)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtmobileno)
        Me.GroupBox1.Controls.Add(Me.txtcountry)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtcontactperson)
        Me.GroupBox1.Controls.Add(Me.txtcompanyName)
        Me.GroupBox1.Controls.Add(Me.txtadd2)
        Me.GroupBox1.Controls.Add(Me.txtpincode)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtlocation)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(678, 284)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnClear)
        Me.GroupBox2.Controls.Add(Me.BtnSave)
        Me.GroupBox2.Controls.Add(Me.BtnExit)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 293)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(677, 70)
        Me.GroupBox2.TabIndex = 62
        Me.GroupBox2.TabStop = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.White
        Me.BtnClear.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.Navy
        Me.BtnClear.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnClear.Location = New System.Drawing.Point(281, 26)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(94, 32)
        Me.BtnClear.TabIndex = 13
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.White
        Me.BtnSave.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnSave.Location = New System.Drawing.Point(118, 26)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(94, 32)
        Me.BtnSave.TabIndex = 12
        Me.BtnSave.Text = " SAVE"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.White
        Me.BtnExit.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.Red
        Me.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExit.Location = New System.Drawing.Point(425, 26)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(94, 32)
        Me.BtnExit.TabIndex = 14
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'FrmNewCustomerCatalog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(694, 408)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmNewCustomerCatalog"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtcountry As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtadd1 As System.Windows.Forms.TextBox
    Friend WithEvents txtstate As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcompanyName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtadd2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtlocation As System.Windows.Forms.TextBox
    Friend WithEvents txtpincode As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtcontactperson As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtmobileno As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txttelno As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtemailid As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
End Class
