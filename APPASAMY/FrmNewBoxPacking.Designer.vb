<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewBoxPacking
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
        Me.txtlotbarno = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.BtnExit = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RdoRef = New System.Windows.Forms.RadioButton
        Me.rdobrand = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Rdocolumbian = New System.Windows.Forms.RadioButton
        Me.RdoOt = New System.Windows.Forms.RadioButton
        Me.RdoSSL = New System.Windows.Forms.RadioButton
        Me.RdoFSL = New System.Windows.Forms.RadioButton
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.rbttype4 = New System.Windows.Forms.RadioButton
        Me.rbttype3 = New System.Windows.Forms.RadioButton
        Me.rbttype2 = New System.Windows.Forms.RadioButton
        Me.rbttype1 = New System.Windows.Forms.RadioButton
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.rdbttypeothers = New System.Windows.Forms.RadioButton
        Me.Rdbttypesfb = New System.Windows.Forms.RadioButton
        Me.gbxinject = New System.Windows.Forms.GroupBox
        Me.btnprint = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtsrno = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtexpdate = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtmfddate = New System.Windows.Forms.TextBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtinj_No = New System.Windows.Forms.TextBox
        Me.print_box = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.gbxinject.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtlotbarno
        '
        Me.txtlotbarno.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlotbarno.Location = New System.Drawing.Point(228, 25)
        Me.txtlotbarno.Name = "txtlotbarno"
        Me.txtlotbarno.Size = New System.Drawing.Size(317, 48)
        Me.txtlotbarno.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(6, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(207, 29)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Scan Lot No Sr.No"
        '
        'BtnExit
        '
        Me.BtnExit.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.Red
        Me.BtnExit.Location = New System.Drawing.Point(237, 22)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(108, 42)
        Me.BtnExit.TabIndex = 43
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdoRef)
        Me.GroupBox1.Controls.Add(Me.rdobrand)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(12, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(582, 55)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Disply Details"
        '
        'RdoRef
        '
        Me.RdoRef.AutoSize = True
        Me.RdoRef.Location = New System.Drawing.Point(286, 20)
        Me.RdoRef.Name = "RdoRef"
        Me.RdoRef.Size = New System.Drawing.Size(131, 19)
        Me.RdoRef.TabIndex = 36
        Me.RdoRef.Text = "Reference Name"
        Me.RdoRef.UseVisualStyleBackColor = True
        '
        'rdobrand
        '
        Me.rdobrand.AutoSize = True
        Me.rdobrand.Checked = True
        Me.rdobrand.Location = New System.Drawing.Point(108, 22)
        Me.rdobrand.Name = "rdobrand"
        Me.rdobrand.Size = New System.Drawing.Size(107, 19)
        Me.rdobrand.TabIndex = 35
        Me.rdobrand.TabStop = True
        Me.rdobrand.Text = "Brand Name"
        Me.rdobrand.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtlotbarno)
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(15, 325)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(582, 87)
        Me.GroupBox2.TabIndex = 59
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnExit)
        Me.GroupBox3.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Red
        Me.GroupBox3.Location = New System.Drawing.Point(15, 510)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(582, 77)
        Me.GroupBox3.TabIndex = 60
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Rdocolumbian)
        Me.GroupBox4.Controls.Add(Me.RdoOt)
        Me.GroupBox4.Controls.Add(Me.RdoSSL)
        Me.GroupBox4.Controls.Add(Me.RdoFSL)
        Me.GroupBox4.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Red
        Me.GroupBox4.Location = New System.Drawing.Point(15, 117)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(575, 87)
        Me.GroupBox4.TabIndex = 61
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Acry Fold"
        '
        'Rdocolumbian
        '
        Me.Rdocolumbian.AutoSize = True
        Me.Rdocolumbian.Location = New System.Drawing.Point(444, 43)
        Me.Rdocolumbian.Name = "Rdocolumbian"
        Me.Rdocolumbian.Size = New System.Drawing.Size(98, 19)
        Me.Rdocolumbian.TabIndex = 64
        Me.Rdocolumbian.TabStop = True
        Me.Rdocolumbian.Text = "Columbian"
        Me.Rdocolumbian.UseVisualStyleBackColor = True
        '
        'RdoOt
        '
        Me.RdoOt.AutoSize = True
        Me.RdoOt.Location = New System.Drawing.Point(344, 43)
        Me.RdoOt.Name = "RdoOt"
        Me.RdoOt.Size = New System.Drawing.Size(70, 19)
        Me.RdoOt.TabIndex = 37
        Me.RdoOt.Text = "Others"
        Me.RdoOt.UseVisualStyleBackColor = True
        '
        'RdoSSL
        '
        Me.RdoSSL.AutoSize = True
        Me.RdoSSL.Location = New System.Drawing.Point(217, 43)
        Me.RdoSSL.Name = "RdoSSL"
        Me.RdoSSL.Size = New System.Drawing.Size(96, 19)
        Me.RdoSSL.TabIndex = 36
        Me.RdoSSL.Text = "7 Set Label"
        Me.RdoSSL.UseVisualStyleBackColor = True
        '
        'RdoFSL
        '
        Me.RdoFSL.AutoSize = True
        Me.RdoFSL.Checked = True
        Me.RdoFSL.Location = New System.Drawing.Point(51, 43)
        Me.RdoFSL.Name = "RdoFSL"
        Me.RdoFSL.Size = New System.Drawing.Size(96, 19)
        Me.RdoFSL.TabIndex = 35
        Me.RdoFSL.TabStop = True
        Me.RdoFSL.Text = "5 Set Label"
        Me.RdoFSL.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rbttype4)
        Me.GroupBox5.Controls.Add(Me.rbttype3)
        Me.GroupBox5.Controls.Add(Me.rbttype2)
        Me.GroupBox5.Controls.Add(Me.rbttype1)
        Me.GroupBox5.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Red
        Me.GroupBox5.Location = New System.Drawing.Point(13, 117)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(581, 87)
        Me.GroupBox5.TabIndex = 62
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Swiss Fold"
        '
        'rbttype4
        '
        Me.rbttype4.AutoSize = True
        Me.rbttype4.Location = New System.Drawing.Point(447, 36)
        Me.rbttype4.Name = "rbttype4"
        Me.rbttype4.Size = New System.Drawing.Size(76, 19)
        Me.rbttype4.TabIndex = 39
        Me.rbttype4.Text = "Injector"
        Me.rbttype4.UseVisualStyleBackColor = True
        '
        'rbttype3
        '
        Me.rbttype3.AutoSize = True
        Me.rbttype3.Location = New System.Drawing.Point(319, 35)
        Me.rbttype3.Name = "rbttype3"
        Me.rbttype3.Size = New System.Drawing.Size(64, 19)
        Me.rbttype3.TabIndex = 38
        Me.rbttype3.Text = "Pouch"
        Me.rbttype3.UseVisualStyleBackColor = True
        '
        'rbttype2
        '
        Me.rbttype2.AutoSize = True
        Me.rbttype2.Location = New System.Drawing.Point(185, 35)
        Me.rbttype2.Name = "rbttype2"
        Me.rbttype2.Size = New System.Drawing.Size(64, 19)
        Me.rbttype2.TabIndex = 36
        Me.rbttype2.Text = "Outer"
        Me.rbttype2.UseVisualStyleBackColor = True
        '
        'rbttype1
        '
        Me.rbttype1.AutoSize = True
        Me.rbttype1.Checked = True
        Me.rbttype1.Location = New System.Drawing.Point(51, 35)
        Me.rbttype1.Name = "rbttype1"
        Me.rbttype1.Size = New System.Drawing.Size(62, 19)
        Me.rbttype1.TabIndex = 35
        Me.rbttype1.TabStop = True
        Me.rbttype1.Text = "Inner"
        Me.rbttype1.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rdbttypeothers)
        Me.GroupBox6.Controls.Add(Me.Rdbttypesfb)
        Me.GroupBox6.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Red
        Me.GroupBox6.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(582, 47)
        Me.GroupBox6.TabIndex = 59
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Label Type"
        '
        'rdbttypeothers
        '
        Me.rdbttypeothers.AutoSize = True
        Me.rdbttypeothers.Location = New System.Drawing.Point(330, 17)
        Me.rdbttypeothers.Name = "rdbttypeothers"
        Me.rdbttypeothers.Size = New System.Drawing.Size(70, 19)
        Me.rdbttypeothers.TabIndex = 36
        Me.rdbttypeothers.Text = "Others" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.rdbttypeothers.UseVisualStyleBackColor = True
        '
        'Rdbttypesfb
        '
        Me.Rdbttypesfb.AutoSize = True
        Me.Rdbttypesfb.Location = New System.Drawing.Point(106, 17)
        Me.Rdbttypesfb.Name = "Rdbttypesfb"
        Me.Rdbttypesfb.Size = New System.Drawing.Size(107, 19)
        Me.Rdbttypesfb.TabIndex = 35
        Me.Rdbttypesfb.Text = "SWISS FOLD" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Rdbttypesfb.UseVisualStyleBackColor = True
        '
        'gbxinject
        '
        Me.gbxinject.Controls.Add(Me.btnprint)
        Me.gbxinject.Controls.Add(Me.Label3)
        Me.gbxinject.Controls.Add(Me.txtsrno)
        Me.gbxinject.Controls.Add(Me.Label2)
        Me.gbxinject.Controls.Add(Me.txtexpdate)
        Me.gbxinject.Controls.Add(Me.Label1)
        Me.gbxinject.Controls.Add(Me.txtmfddate)
        Me.gbxinject.Location = New System.Drawing.Point(609, 4)
        Me.gbxinject.Name = "gbxinject"
        Me.gbxinject.Size = New System.Drawing.Size(213, 218)
        Me.gbxinject.TabIndex = 0
        Me.gbxinject.TabStop = False
        '
        'btnprint
        '
        Me.btnprint.Location = New System.Drawing.Point(68, 177)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(75, 23)
        Me.btnprint.TabIndex = 31
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(1, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 18)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "S NO"
        '
        'txtsrno
        '
        Me.txtsrno.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsrno.Location = New System.Drawing.Point(52, 131)
        Me.txtsrno.Name = "txtsrno"
        Me.txtsrno.Size = New System.Drawing.Size(149, 26)
        Me.txtsrno.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(-2, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 18)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "EXP DATE"
        '
        'txtexpdate
        '
        Me.txtexpdate.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtexpdate.Location = New System.Drawing.Point(98, 86)
        Me.txtexpdate.Name = "txtexpdate"
        Me.txtexpdate.Size = New System.Drawing.Size(100, 26)
        Me.txtexpdate.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(-2, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 18)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "MFD DATE"
        '
        'txtmfddate
        '
        Me.txtmfddate.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmfddate.Location = New System.Drawing.Point(98, 43)
        Me.txtmfddate.Name = "txtmfddate"
        Me.txtmfddate.Size = New System.Drawing.Size(100, 26)
        Me.txtmfddate.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.txtinj_No)
        Me.GroupBox7.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Red
        Me.GroupBox7.Location = New System.Drawing.Point(15, 223)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(582, 87)
        Me.GroupBox7.TabIndex = 63
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(47, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 29)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Scan Injector"
        '
        'txtinj_No
        '
        Me.txtinj_No.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinj_No.Location = New System.Drawing.Point(228, 25)
        Me.txtinj_No.Name = "txtinj_No"
        Me.txtinj_No.Size = New System.Drawing.Size(317, 48)
        Me.txtinj_No.TabIndex = 1
        '
        'print_box
        '
        Me.print_box.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.print_box.ForeColor = System.Drawing.Color.Red
        Me.print_box.Location = New System.Drawing.Point(161, 448)
        Me.print_box.Name = "print_box"
        Me.print_box.Size = New System.Drawing.Size(336, 42)
        Me.print_box.TabIndex = 64
        Me.print_box.Text = "Print"
        Me.print_box.UseVisualStyleBackColor = True
        Me.print_box.Visible = False
        '
        'FrmNewBoxPacking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(845, 648)
        Me.ControlBox = False
        Me.Controls.Add(Me.print_box)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.gbxinject)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmNewBoxPacking"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.gbxinject.ResumeLayout(False)
        Me.gbxinject.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtlotbarno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RdoRef As System.Windows.Forms.RadioButton
    Friend WithEvents rdobrand As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RdoSSL As System.Windows.Forms.RadioButton
    Friend WithEvents RdoFSL As System.Windows.Forms.RadioButton
    Friend WithEvents RdoOt As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rbttype2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbttype1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbttypeothers As System.Windows.Forms.RadioButton
    Friend WithEvents Rdbttypesfb As System.Windows.Forms.RadioButton
    Friend WithEvents rbttype4 As System.Windows.Forms.RadioButton
    Friend WithEvents rbttype3 As System.Windows.Forms.RadioButton
    Friend WithEvents gbxinject As System.Windows.Forms.GroupBox
    Friend WithEvents txtmfddate As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtexpdate As System.Windows.Forms.TextBox
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtsrno As System.Windows.Forms.TextBox
    Friend WithEvents Rdocolumbian As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtinj_No As System.Windows.Forms.TextBox
    Friend WithEvents print_box As System.Windows.Forms.Button
End Class
