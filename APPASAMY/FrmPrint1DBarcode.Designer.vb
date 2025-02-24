<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrint1DBarcode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrint1DBarcode))
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtquantity = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmbmodel = New System.Windows.Forms.ComboBox
        Me.cmblotno = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblmaxno = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lbllastsrno = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lbldate = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblUser = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(23, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "No. of Quantity"
        '
        'txtquantity
        '
        Me.txtquantity.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquantity.Location = New System.Drawing.Point(151, 144)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(71, 22)
        Me.txtquantity.TabIndex = 14
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(188, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 30)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(71, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 30)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbmodel
        '
        Me.cmbmodel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbmodel.FormattingEnabled = True
        Me.cmbmodel.Location = New System.Drawing.Point(300, 390)
        Me.cmbmodel.Name = "cmbmodel"
        Me.cmbmodel.Size = New System.Drawing.Size(138, 23)
        Me.cmbmodel.TabIndex = 11
        Me.cmbmodel.Visible = False
        '
        'cmblotno
        '
        Me.cmblotno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmblotno.FormattingEnabled = True
        Me.cmblotno.Location = New System.Drawing.Point(151, 21)
        Me.cmblotno.Name = "cmblotno"
        Me.cmblotno.Size = New System.Drawing.Size(138, 23)
        Me.cmblotno.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(172, 388)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Select Model"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(23, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Select Lot No"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lblmaxno)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lbllastsrno)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtquantity)
        Me.Panel1.Controls.Add(Me.cmblotno)
        Me.Panel1.Location = New System.Drawing.Point(160, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(338, 202)
        Me.Panel1.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(23, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 16)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Max.No"
        '
        'lblmaxno
        '
        Me.lblmaxno.AutoSize = True
        Me.lblmaxno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmaxno.ForeColor = System.Drawing.Color.Blue
        Me.lblmaxno.Location = New System.Drawing.Point(151, 107)
        Me.lblmaxno.Name = "lblmaxno"
        Me.lblmaxno.Size = New System.Drawing.Size(33, 19)
        Me.lblmaxno.TabIndex = 18
        Me.lblmaxno.Text = "300"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(23, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Last  Sr.No"
        '
        'lbllastsrno
        '
        Me.lbllastsrno.AutoSize = True
        Me.lbllastsrno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllastsrno.ForeColor = System.Drawing.Color.Blue
        Me.lbllastsrno.Location = New System.Drawing.Point(151, 70)
        Me.lbllastsrno.Name = "lbllastsrno"
        Me.lbllastsrno.Size = New System.Drawing.Size(17, 19)
        Me.lbllastsrno.TabIndex = 16
        Me.lbllastsrno.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Location = New System.Drawing.Point(160, 290)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(341, 69)
        Me.Panel2.TabIndex = 17
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(16, 86)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(135, 134)
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 228)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(137, 136)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Navy
        Me.Panel3.Controls.Add(Me.lbldate)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.lblUser)
        Me.Panel3.Location = New System.Drawing.Point(4, 8)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(501, 52)
        Me.Panel3.TabIndex = 45
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(100, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(324, 43)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Lot No Label Print"
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
        'FrmPrint1DBarcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(512, 398)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbmodel)
        Me.MaximizeBox = False
        Me.Name = "FrmPrint1DBarcode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lot No Print"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtquantity As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmbmodel As System.Windows.Forms.ComboBox
    Friend WithEvents cmblotno As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblmaxno As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbllastsrno As System.Windows.Forms.Label
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
End Class
