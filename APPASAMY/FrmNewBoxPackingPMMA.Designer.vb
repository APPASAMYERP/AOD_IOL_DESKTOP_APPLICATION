<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewBoxPackingPMMA
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.txtlotbarno = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.BtnExit = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RdoRef = New System.Windows.Forms.RadioButton
        Me.rdobrand = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
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
        Me.radbtnnp = New System.Windows.Forms.RadioButton
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
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtlotsr_No = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_injetlot = New System.Windows.Forms.TextBox
        Me.grptype = New System.Windows.Forms.GroupBox
        Me.radtothers = New System.Windows.Forms.RadioButton
        Me.cmbPrintLabel = New System.Windows.Forms.ComboBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.ChkCST = New System.Windows.Forms.CheckBox
        Me.rdUDICode = New System.Windows.Forms.RadioButton
        Me.rdLotSerial = New System.Windows.Forms.RadioButton
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.ckReprint = New System.Windows.Forms.CheckBox
        Me.GroupBox11 = New System.Windows.Forms.GroupBox
        Me.Cmbbtc = New System.Windows.Forms.ComboBox
        Me.BTC = New System.Windows.Forms.Label
        Me.cmbBPL = New System.Windows.Forms.ComboBox
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.Lot_SrNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Model_Name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Power = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Btc_no = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Box_Packing = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.BtnStart = New System.Windows.Forms.Button
        Me.lblpackedQty = New System.Windows.Forms.Label
        Me.btn_complete = New System.Windows.Forms.Button
        Me.lblTotalQty = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblModel = New System.Windows.Forms.Label
        Me.cmbModel = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.gbxinject.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.grptype.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtlotbarno
        '
        Me.txtlotbarno.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlotbarno.Location = New System.Drawing.Point(224, 38)
        Me.txtlotbarno.Name = "txtlotbarno"
        Me.txtlotbarno.Size = New System.Drawing.Size(317, 48)
        Me.txtlotbarno.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(8, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(207, 29)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Scan Lot No Sr.No"
        '
        'BtnExit
        '
        Me.BtnExit.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.Red
        Me.BtnExit.Location = New System.Drawing.Point(87, 360)
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
        Me.GroupBox1.Location = New System.Drawing.Point(9, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(582, 55)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Disply Details"
        Me.GroupBox1.Visible = False
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
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(398, 519)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 42)
        Me.GroupBox2.TabIndex = 59
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Red
        Me.GroupBox3.Location = New System.Drawing.Point(27, 638)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(135, 77)
        Me.GroupBox3.TabIndex = 60
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(60, 498)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 42)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Rdocolumbian)
        Me.GroupBox4.Controls.Add(Me.RdoOt)
        Me.GroupBox4.Controls.Add(Me.RdoSSL)
        Me.GroupBox4.Controls.Add(Me.RdoFSL)
        Me.GroupBox4.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Red
        Me.GroupBox4.Location = New System.Drawing.Point(7, 564)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(575, 87)
        Me.GroupBox4.TabIndex = 61
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Acry Fold"
        Me.GroupBox4.Visible = False
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
        Me.GroupBox5.Location = New System.Drawing.Point(1, 38)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(581, 29)
        Me.GroupBox5.TabIndex = 62
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Swiss Fold"
        Me.GroupBox5.Visible = False
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
        Me.GroupBox6.Controls.Add(Me.radbtnnp)
        Me.GroupBox6.Controls.Add(Me.Rdbttypesfb)
        Me.GroupBox6.Controls.Add(Me.GroupBox5)
        Me.GroupBox6.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Red
        Me.GroupBox6.Location = New System.Drawing.Point(1, 0)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(590, 47)
        Me.GroupBox6.TabIndex = 59
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Label Type"
        Me.GroupBox6.Visible = False
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
        'radbtnnp
        '
        Me.radbtnnp.AutoSize = True
        Me.radbtnnp.Location = New System.Drawing.Point(106, 17)
        Me.radbtnnp.Name = "radbtnnp"
        Me.radbtnnp.Size = New System.Drawing.Size(121, 19)
        Me.radbtnnp.TabIndex = 35
        Me.radbtnnp.Text = "Non-Preloaded"
        Me.radbtnnp.UseVisualStyleBackColor = True
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
        Me.gbxinject.Location = New System.Drawing.Point(176, 519)
        Me.gbxinject.Name = "gbxinject"
        Me.gbxinject.Size = New System.Drawing.Size(216, 39)
        Me.gbxinject.TabIndex = 0
        Me.gbxinject.TabStop = False
        Me.gbxinject.Visible = False
        '
        'btnprint
        '
        Me.btnprint.Location = New System.Drawing.Point(66, 188)
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
        Me.Label2.Location = New System.Drawing.Point(4, 94)
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
        Me.Label1.Location = New System.Drawing.Point(3, 51)
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
        Me.GroupBox7.Controls.Add(Me.txtlotbarno)
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Red
        Me.GroupBox7.Location = New System.Drawing.Point(9, 227)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(582, 121)
        Me.GroupBox7.TabIndex = 60
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(20, 414)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(207, 29)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Scan Lot No Sr.No"
        Me.Label6.Visible = False
        '
        'txtlotsr_No
        '
        Me.txtlotsr_No.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlotsr_No.Location = New System.Drawing.Point(233, 383)
        Me.txtlotsr_No.Name = "txtlotsr_No"
        Me.txtlotsr_No.Size = New System.Drawing.Size(317, 48)
        Me.txtlotsr_No.TabIndex = 26
        Me.txtlotsr_No.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(23, 449)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 29)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Scan Inject Lot.No"
        Me.Label4.Visible = False
        '
        'txt_injetlot
        '
        Me.txt_injetlot.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_injetlot.Location = New System.Drawing.Point(233, 437)
        Me.txt_injetlot.Name = "txt_injetlot"
        Me.txt_injetlot.Size = New System.Drawing.Size(317, 48)
        Me.txt_injetlot.TabIndex = 2
        Me.txt_injetlot.Visible = False
        '
        'grptype
        '
        Me.grptype.Controls.Add(Me.radtothers)
        Me.grptype.Controls.Add(Me.GroupBox6)
        Me.grptype.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grptype.ForeColor = System.Drawing.Color.Red
        Me.grptype.Location = New System.Drawing.Point(7, 12)
        Me.grptype.Name = "grptype"
        Me.grptype.Size = New System.Drawing.Size(582, 47)
        Me.grptype.TabIndex = 60
        Me.grptype.TabStop = False
        Me.grptype.Text = "Type"
        Me.grptype.Visible = False
        '
        'radtothers
        '
        Me.radtothers.AutoSize = True
        Me.radtothers.Location = New System.Drawing.Point(330, 17)
        Me.radtothers.Name = "radtothers"
        Me.radtothers.Size = New System.Drawing.Size(70, 19)
        Me.radtothers.TabIndex = 36
        Me.radtothers.Text = "Others" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.radtothers.UseVisualStyleBackColor = True
        '
        'cmbPrintLabel
        '
        Me.cmbPrintLabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPrintLabel.ForeColor = System.Drawing.Color.Red
        Me.cmbPrintLabel.FormattingEnabled = True
        Me.cmbPrintLabel.Location = New System.Drawing.Point(56, 72)
        Me.cmbPrintLabel.Name = "cmbPrintLabel"
        Me.cmbPrintLabel.Size = New System.Drawing.Size(369, 26)
        Me.cmbPrintLabel.TabIndex = 63
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Blue
        Me.Label26.Location = New System.Drawing.Point(12, 82)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(38, 14)
        Me.Label26.TabIndex = 62
        Me.Label26.Text = "Label"
        '
        'ChkCST
        '
        Me.ChkCST.AutoSize = True
        Me.ChkCST.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkCST.ForeColor = System.Drawing.Color.Red
        Me.ChkCST.Location = New System.Drawing.Point(439, 70)
        Me.ChkCST.Name = "ChkCST"
        Me.ChkCST.Size = New System.Drawing.Size(111, 17)
        Me.ChkCST.TabIndex = 64
        Me.ChkCST.Text = "Control Sample"
        Me.ChkCST.UseVisualStyleBackColor = True
        '
        'rdUDICode
        '
        Me.rdUDICode.AutoSize = True
        Me.rdUDICode.Checked = True
        Me.rdUDICode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdUDICode.ForeColor = System.Drawing.Color.Red
        Me.rdUDICode.Location = New System.Drawing.Point(53, 17)
        Me.rdUDICode.Name = "rdUDICode"
        Me.rdUDICode.Size = New System.Drawing.Size(99, 21)
        Me.rdUDICode.TabIndex = 70
        Me.rdUDICode.TabStop = True
        Me.rdUDICode.Text = "UDI Serial"
        Me.rdUDICode.UseVisualStyleBackColor = True
        '
        'rdLotSerial
        '
        Me.rdLotSerial.AutoSize = True
        Me.rdLotSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdLotSerial.ForeColor = System.Drawing.Color.Red
        Me.rdLotSerial.Location = New System.Drawing.Point(385, 17)
        Me.rdLotSerial.Name = "rdLotSerial"
        Me.rdLotSerial.Size = New System.Drawing.Size(96, 21)
        Me.rdLotSerial.TabIndex = 69
        Me.rdLotSerial.Text = "Lot Serial"
        Me.rdLotSerial.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.rdLotSerial)
        Me.GroupBox8.Controls.Add(Me.rdUDICode)
        Me.GroupBox8.Location = New System.Drawing.Point(9, 171)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(582, 50)
        Me.GroupBox8.TabIndex = 71
        Me.GroupBox8.TabStop = False
        '
        'ckReprint
        '
        Me.ckReprint.AutoSize = True
        Me.ckReprint.Enabled = False
        Me.ckReprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckReprint.ForeColor = System.Drawing.Color.Red
        Me.ckReprint.Location = New System.Drawing.Point(439, 93)
        Me.ckReprint.Name = "ckReprint"
        Me.ckReprint.Size = New System.Drawing.Size(67, 17)
        Me.ckReprint.TabIndex = 72
        Me.ckReprint.Text = "Reprint"
        Me.ckReprint.UseVisualStyleBackColor = True
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.cmbModel)
        Me.GroupBox11.Controls.Add(Me.lblModel)
        Me.GroupBox11.Controls.Add(Me.Cmbbtc)
        Me.GroupBox11.Controls.Add(Me.BTC)
        Me.GroupBox11.Controls.Add(Me.cmbBPL)
        Me.GroupBox11.Controls.Add(Me.DataGridView2)
        Me.GroupBox11.Controls.Add(Me.Label7)
        Me.GroupBox11.Controls.Add(Me.Label8)
        Me.GroupBox11.Controls.Add(Me.BtnStart)
        Me.GroupBox11.Controls.Add(Me.lblpackedQty)
        Me.GroupBox11.Controls.Add(Me.btn_complete)
        Me.GroupBox11.Controls.Add(Me.lblTotalQty)
        Me.GroupBox11.Controls.Add(Me.Label9)
        Me.GroupBox11.Location = New System.Drawing.Point(624, 16)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(552, 699)
        Me.GroupBox11.TabIndex = 97
        Me.GroupBox11.TabStop = False
        '
        'Cmbbtc
        '
        Me.Cmbbtc.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbbtc.ForeColor = System.Drawing.Color.Red
        Me.Cmbbtc.FormattingEnabled = True
        Me.Cmbbtc.Location = New System.Drawing.Point(71, 73)
        Me.Cmbbtc.Name = "Cmbbtc"
        Me.Cmbbtc.Size = New System.Drawing.Size(342, 26)
        Me.Cmbbtc.TabIndex = 100
        Me.Cmbbtc.Visible = False
        '
        'BTC
        '
        Me.BTC.AutoSize = True
        Me.BTC.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTC.ForeColor = System.Drawing.Color.Blue
        Me.BTC.Location = New System.Drawing.Point(14, 78)
        Me.BTC.Name = "BTC"
        Me.BTC.Size = New System.Drawing.Size(50, 16)
        Me.BTC.TabIndex = 99
        Me.BTC.Text = "Batch"
        Me.BTC.UseWaitCursor = True
        Me.BTC.Visible = False
        '
        'cmbBPL
        '
        Me.cmbBPL.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBPL.ForeColor = System.Drawing.Color.Red
        Me.cmbBPL.FormattingEnabled = True
        Me.cmbBPL.Location = New System.Drawing.Point(70, 29)
        Me.cmbBPL.Name = "cmbBPL"
        Me.cmbBPL.Size = New System.Drawing.Size(342, 26)
        Me.cmbBPL.TabIndex = 66
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Lot_SrNo, Me.Model_Name, Me.Power, Me.Btc_no, Me.Box_Packing})
        Me.DataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView2.Location = New System.Drawing.Point(17, 285)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView2.Size = New System.Drawing.Size(516, 404)
        Me.DataGridView2.TabIndex = 95
        '
        'Lot_SrNo
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.Lot_SrNo.DefaultCellStyle = DataGridViewCellStyle1
        Me.Lot_SrNo.HeaderText = "Lot_SrNo"
        Me.Lot_SrNo.Name = "Lot_SrNo"
        Me.Lot_SrNo.Width = 170
        '
        'Model_Name
        '
        Me.Model_Name.HeaderText = "Model_Name"
        Me.Model_Name.Name = "Model_Name"
        '
        'Power
        '
        Me.Power.HeaderText = "Power"
        Me.Power.Name = "Power"
        '
        'Btc_no
        '
        Me.Btc_no.HeaderText = "Btc_no"
        Me.Btc_no.Name = "Btc_no"
        '
        'Box_Packing
        '
        Me.Box_Packing.HeaderText = "Box_Packing"
        Me.Box_Packing.Name = "Box_Packing"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(27, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 16)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "BPL"
        Me.Label7.UseWaitCursor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(37, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 18)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Packed Qty"
        '
        'BtnStart
        '
        Me.BtnStart.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStart.ForeColor = System.Drawing.Color.Red
        Me.BtnStart.Location = New System.Drawing.Point(114, 168)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(96, 28)
        Me.BtnStart.TabIndex = 76
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'lblpackedQty
        '
        Me.lblpackedQty.AutoSize = True
        Me.lblpackedQty.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpackedQty.ForeColor = System.Drawing.Color.Red
        Me.lblpackedQty.Location = New System.Drawing.Point(76, 242)
        Me.lblpackedQty.Name = "lblpackedQty"
        Me.lblpackedQty.Size = New System.Drawing.Size(35, 40)
        Me.lblpackedQty.TabIndex = 93
        Me.lblpackedQty.Text = "0"
        '
        'btn_complete
        '
        Me.btn_complete.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_complete.ForeColor = System.Drawing.Color.Red
        Me.btn_complete.Location = New System.Drawing.Point(261, 168)
        Me.btn_complete.Name = "btn_complete"
        Me.btn_complete.Size = New System.Drawing.Size(96, 28)
        Me.btn_complete.TabIndex = 76
        Me.btn_complete.Text = "Complete"
        Me.btn_complete.UseVisualStyleBackColor = True
        '
        'lblTotalQty
        '
        Me.lblTotalQty.AutoSize = True
        Me.lblTotalQty.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalQty.ForeColor = System.Drawing.Color.Red
        Me.lblTotalQty.Location = New System.Drawing.Point(390, 242)
        Me.lblTotalQty.Name = "lblTotalQty"
        Me.lblTotalQty.Size = New System.Drawing.Size(35, 40)
        Me.lblTotalQty.TabIndex = 92
        Me.lblTotalQty.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 12.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(347, 215)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 18)
        Me.Label9.TabIndex = 94
        Me.Label9.Text = "Total BPL Qty"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.ForeColor = System.Drawing.Color.Blue
        Me.lblModel.Location = New System.Drawing.Point(14, 112)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(53, 16)
        Me.lblModel.TabIndex = 99
        Me.lblModel.Text = "Model"
        Me.lblModel.UseWaitCursor = True
        Me.lblModel.Visible = False
        '
        'cmbModel
        '
        Me.cmbModel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModel.ForeColor = System.Drawing.Color.Red
        Me.cmbModel.FormattingEnabled = True
        Me.cmbModel.Location = New System.Drawing.Point(71, 107)
        Me.cmbModel.Name = "cmbModel"
        Me.cmbModel.Size = New System.Drawing.Size(342, 26)
        Me.cmbModel.TabIndex = 100
        Me.cmbModel.Visible = False
        '
        'FrmNewBoxPackingPMMA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1467, 727)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.ckReprint)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.ChkCST)
        Me.Controls.Add(Me.cmbPrintLabel)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grptype)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.txtlotsr_No)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.gbxinject)
        Me.Controls.Add(Me.txt_injetlot)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmNewBoxPackingPMMA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
        Me.grptype.ResumeLayout(False)
        Me.grptype.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents txt_injetlot As System.Windows.Forms.TextBox
    Friend WithEvents grptype As System.Windows.Forms.GroupBox
    Friend WithEvents radtothers As System.Windows.Forms.RadioButton
    Friend WithEvents radbtnnp As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtlotsr_No As System.Windows.Forms.TextBox
    Friend WithEvents cmbPrintLabel As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents ChkCST As System.Windows.Forms.CheckBox
    Friend WithEvents rdUDICode As System.Windows.Forms.RadioButton
    Friend WithEvents rdLotSerial As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents ckReprint As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbBPL As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Lot_SrNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Model_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Power As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Btc_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Box_Packing As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnStart As System.Windows.Forms.Button
    Friend WithEvents lblpackedQty As System.Windows.Forms.Label
    Friend WithEvents btn_complete As System.Windows.Forms.Button
    Friend WithEvents lblTotalQty As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Cmbbtc As System.Windows.Forms.ComboBox
    Friend WithEvents BTC As System.Windows.Forms.Label
    Friend WithEvents cmbModel As System.Windows.Forms.ComboBox
    Friend WithEvents lblModel As System.Windows.Forms.Label
End Class
