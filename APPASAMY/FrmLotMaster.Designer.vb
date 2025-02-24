<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLotMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLotMaster))
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbExYear = New System.Windows.Forms.ComboBox
        Me.CmbExMonth = New System.Windows.Forms.ComboBox
        Me.CmbMDYear = New System.Windows.Forms.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CmbMDMonth = New System.Windows.Forms.ComboBox
        Me.txtLotno = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtpower = New System.Windows.Forms.TextBox
        Me.txtlotwidth = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtlotheight = New System.Windows.Forms.TextBox
        Me.cmbunit = New System.Windows.Forms.ComboBox
        Me.txtmodelname = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BtnClear = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lbldate = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblUser = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(9, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Unit"
        '
        'CmbExYear
        '
        Me.CmbExYear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbExYear.FormattingEnabled = True
        Me.CmbExYear.Items.AddRange(New Object() {"2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050", "", "2025", "2026", "2027", "2028", "2029", "2030", "2031"})
        Me.CmbExYear.Location = New System.Drawing.Point(445, 151)
        Me.CmbExYear.Name = "CmbExYear"
        Me.CmbExYear.Size = New System.Drawing.Size(89, 23)
        Me.CmbExYear.TabIndex = 10
        '
        'CmbExMonth
        '
        Me.CmbExMonth.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbExMonth.FormattingEnabled = True
        Me.CmbExMonth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.CmbExMonth.Location = New System.Drawing.Point(388, 151)
        Me.CmbExMonth.Name = "CmbExMonth"
        Me.CmbExMonth.Size = New System.Drawing.Size(51, 23)
        Me.CmbExMonth.TabIndex = 9
        '
        'CmbMDYear
        '
        Me.CmbMDYear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMDYear.FormattingEnabled = True
        Me.CmbMDYear.Items.AddRange(New Object() {"2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050", "", "2025", "2026", "2027", "2028", "2029", "2030", "2031"})
        Me.CmbMDYear.Location = New System.Drawing.Point(447, 104)
        Me.CmbMDYear.Name = "CmbMDYear"
        Me.CmbMDYear.Size = New System.Drawing.Size(89, 23)
        Me.CmbMDYear.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CmbExYear)
        Me.Panel1.Controls.Add(Me.CmbExMonth)
        Me.Panel1.Controls.Add(Me.CmbMDYear)
        Me.Panel1.Controls.Add(Me.CmbMDMonth)
        Me.Panel1.Controls.Add(Me.txtLotno)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtpower)
        Me.Panel1.Controls.Add(Me.txtlotwidth)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtlotheight)
        Me.Panel1.Controls.Add(Me.cmbunit)
        Me.Panel1.Location = New System.Drawing.Point(237, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(546, 202)
        Me.Panel1.TabIndex = 20
        '
        'CmbMDMonth
        '
        Me.CmbMDMonth.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMDMonth.FormattingEnabled = True
        Me.CmbMDMonth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.CmbMDMonth.Location = New System.Drawing.Point(388, 105)
        Me.CmbMDMonth.Name = "CmbMDMonth"
        Me.CmbMDMonth.Size = New System.Drawing.Size(51, 23)
        Me.CmbMDMonth.TabIndex = 7
        '
        'txtLotno
        '
        Me.txtLotno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLotno.Location = New System.Drawing.Point(97, 15)
        Me.txtLotno.Name = "txtLotno"
        Me.txtLotno.Size = New System.Drawing.Size(135, 22)
        Me.txtLotno.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(9, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Lot No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(9, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Power"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(255, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Length"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label5.Location = New System.Drawing.Point(255, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Manufacturing Date"
        '
        'txtpower
        '
        Me.txtpower.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpower.Location = New System.Drawing.Point(97, 62)
        Me.txtpower.Name = "txtpower"
        Me.txtpower.Size = New System.Drawing.Size(135, 22)
        Me.txtpower.TabIndex = 2
        '
        'txtlotwidth
        '
        Me.txtlotwidth.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlotwidth.Location = New System.Drawing.Point(388, 60)
        Me.txtlotwidth.Name = "txtlotwidth"
        Me.txtlotwidth.Size = New System.Drawing.Size(143, 22)
        Me.txtlotwidth.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label7.Location = New System.Drawing.Point(255, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Expiry Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label6.Location = New System.Drawing.Point(255, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Optic"
        '
        'txtlotheight
        '
        Me.txtlotheight.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlotheight.Location = New System.Drawing.Point(388, 15)
        Me.txtlotheight.Name = "txtlotheight"
        Me.txtlotheight.Size = New System.Drawing.Size(143, 22)
        Me.txtlotheight.TabIndex = 5
        '
        'cmbunit
        '
        Me.cmbunit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbunit.FormattingEnabled = True
        Me.cmbunit.Items.AddRange(New Object() {"mm", "cm", "inch"})
        Me.cmbunit.Location = New System.Drawing.Point(97, 106)
        Me.cmbunit.Name = "cmbunit"
        Me.cmbunit.Size = New System.Drawing.Size(92, 23)
        Me.cmbunit.TabIndex = 4
        '
        'txtmodelname
        '
        Me.txtmodelname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmodelname.Location = New System.Drawing.Point(335, 370)
        Me.txtmodelname.Name = "txtmodelname"
        Me.txtmodelname.Size = New System.Drawing.Size(135, 22)
        Me.txtmodelname.TabIndex = 3
        Me.txtmodelname.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label8.Location = New System.Drawing.Point(247, 370)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Model Name"
        Me.Label8.Visible = False
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(77, 12)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 34)
        Me.BtnSave.TabIndex = 9
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(228, 413)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.Location = New System.Drawing.Point(231, 12)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 34)
        Me.BtnClear.TabIndex = 11
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BtnClear)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.BtnSave)
        Me.Panel2.Location = New System.Drawing.Point(238, 289)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(545, 62)
        Me.Panel2.TabIndex = 21
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(389, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 34)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
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
        Me.Panel3.Location = New System.Drawing.Point(233, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(560, 52)
        Me.Panel3.TabIndex = 44
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
        Me.Label9.Location = New System.Drawing.Point(144, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(282, 43)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Lot No Creation"
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
        'FrmLotMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(797, 362)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtmodelname)
        Me.Controls.Add(Me.Label8)
        Me.MaximizeBox = False
        Me.Name = "FrmLotMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lot No Creation"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbExYear As System.Windows.Forms.ComboBox
    Friend WithEvents CmbExMonth As System.Windows.Forms.ComboBox
    Friend WithEvents CmbMDYear As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CmbMDMonth As System.Windows.Forms.ComboBox
    Friend WithEvents txtLotno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtmodelname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtpower As System.Windows.Forms.TextBox
    Friend WithEvents txtlotwidth As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtlotheight As System.Windows.Forms.TextBox
    Friend WithEvents cmbunit As System.Windows.Forms.ComboBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label

End Class
