<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLensReservation
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
        Me.Label12 = New System.Windows.Forms.Label
        Me.LblShowOptic = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.LblShowPower = New System.Windows.Forms.Label
        Me.LblShowExpDate = New System.Windows.Forms.Label
        Me.LblshAConstant = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtyear = New System.Windows.Forms.TextBox
        Me.txtmonth = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.LblShowMfdDate = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.LblShowLength = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.LblShowGSType = New System.Windows.Forms.Label
        Me.LblShowGSCode = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.LblShowRefName = New System.Windows.Forms.Label
        Me.txTbplQty = New System.Windows.Forms.TextBox
        Me.BtnClear = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.CmbOrderContry = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.CmbTyPacking = New System.Windows.Forms.ComboBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.lblSterNo = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_orderId = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.cbxpname = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cbxtype = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ckBatchBased = New System.Windows.Forms.CheckBox
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.Label24 = New System.Windows.Forms.Label
        Me.cmb_Batch = New System.Windows.Forms.ComboBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.TxtShowAvlQty = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.CmbShPower = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.CmbShType = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbShModel = New System.Windows.Forms.ComboBox
        Me.CmbShBrand = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblTotBplQty1 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.cmbReserve_id = New System.Windows.Forms.ComboBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.GRID2 = New System.Windows.Forms.DataGridView
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(27, 99)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 16)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Optic"
        '
        'LblShowOptic
        '
        Me.LblShowOptic.AutoSize = True
        Me.LblShowOptic.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowOptic.ForeColor = System.Drawing.Color.Navy
        Me.LblShowOptic.Location = New System.Drawing.Point(170, 99)
        Me.LblShowOptic.Name = "LblShowOptic"
        Me.LblShowOptic.Size = New System.Drawing.Size(58, 17)
        Me.LblShowOptic.TabIndex = 43
        Me.LblShowOptic.Text = "Lot_No"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(27, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 16)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Length"
        '
        'LblShowPower
        '
        Me.LblShowPower.AutoSize = True
        Me.LblShowPower.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowPower.ForeColor = System.Drawing.Color.Navy
        Me.LblShowPower.Location = New System.Drawing.Point(170, 37)
        Me.LblShowPower.Name = "LblShowPower"
        Me.LblShowPower.Size = New System.Drawing.Size(58, 17)
        Me.LblShowPower.TabIndex = 52
        Me.LblShowPower.Text = "Lot_No"
        '
        'LblShowExpDate
        '
        Me.LblShowExpDate.AutoSize = True
        Me.LblShowExpDate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowExpDate.ForeColor = System.Drawing.Color.Navy
        Me.LblShowExpDate.Location = New System.Drawing.Point(170, 254)
        Me.LblShowExpDate.Name = "LblShowExpDate"
        Me.LblShowExpDate.Size = New System.Drawing.Size(58, 17)
        Me.LblShowExpDate.TabIndex = 43
        Me.LblShowExpDate.Text = "Lot_No"
        '
        'LblshAConstant
        '
        Me.LblshAConstant.AutoSize = True
        Me.LblshAConstant.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblshAConstant.ForeColor = System.Drawing.Color.Navy
        Me.LblshAConstant.Location = New System.Drawing.Point(170, 192)
        Me.LblshAConstant.Name = "LblshAConstant"
        Me.LblshAConstant.Size = New System.Drawing.Size(58, 17)
        Me.LblshAConstant.TabIndex = 56
        Me.LblshAConstant.Text = "Lot_No"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Blue
        Me.Label19.Location = New System.Drawing.Point(27, 254)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 16)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "Exp.Date"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(222, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(113, 18)
        Me.Label18.TabIndex = 64
        Me.Label18.Text = "Ty of Packing       "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(27, 37)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 16)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Power"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Blue
        Me.Label17.Location = New System.Drawing.Point(27, 223)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 16)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "Mfd.Date"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Navy
        Me.Label23.Location = New System.Drawing.Point(532, 21)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(60, 18)
        Me.Label23.TabIndex = 74
        Me.Label23.Text = "Mf.Year"
        '
        'txtyear
        '
        Me.txtyear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtyear.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtyear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtyear.Location = New System.Drawing.Point(600, 17)
        Me.txtyear.Name = "txtyear"
        Me.txtyear.Size = New System.Drawing.Size(93, 22)
        Me.txtyear.TabIndex = 67
        '
        'txtmonth
        '
        Me.txtmonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmonth.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmonth.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmonth.Location = New System.Drawing.Point(601, 42)
        Me.txtmonth.Name = "txtmonth"
        Me.txtmonth.Size = New System.Drawing.Size(92, 22)
        Me.txtmonth.TabIndex = 68
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.LblShowOptic)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.LblShowPower)
        Me.GroupBox3.Controls.Add(Me.LblShowExpDate)
        Me.GroupBox3.Controls.Add(Me.LblshAConstant)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.LblShowMfdDate)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.LblShowLength)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.LblShowGSType)
        Me.GroupBox3.Controls.Add(Me.LblShowGSCode)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.LblShowRefName)
        Me.GroupBox3.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Red
        Me.GroupBox3.Location = New System.Drawing.Point(1439, 586)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(10, 20)
        Me.GroupBox3.TabIndex = 71
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lens Details"
        '
        'LblShowMfdDate
        '
        Me.LblShowMfdDate.AutoSize = True
        Me.LblShowMfdDate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowMfdDate.ForeColor = System.Drawing.Color.Navy
        Me.LblShowMfdDate.Location = New System.Drawing.Point(170, 223)
        Me.LblShowMfdDate.Name = "LblShowMfdDate"
        Me.LblShowMfdDate.Size = New System.Drawing.Size(58, 17)
        Me.LblShowMfdDate.TabIndex = 41
        Me.LblShowMfdDate.Text = "Lot_No"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(27, 192)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 16)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "A.Constant"
        '
        'LblShowLength
        '
        Me.LblShowLength.AutoSize = True
        Me.LblShowLength.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowLength.ForeColor = System.Drawing.Color.Navy
        Me.LblShowLength.Location = New System.Drawing.Point(170, 130)
        Me.LblShowLength.Name = "LblShowLength"
        Me.LblShowLength.Size = New System.Drawing.Size(58, 17)
        Me.LblShowLength.TabIndex = 45
        Me.LblShowLength.Text = "Lot_No"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(27, 161)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 16)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "Type"
        '
        'LblShowGSType
        '
        Me.LblShowGSType.AutoSize = True
        Me.LblShowGSType.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowGSType.ForeColor = System.Drawing.Color.Navy
        Me.LblShowGSType.Location = New System.Drawing.Point(170, 161)
        Me.LblShowGSType.Name = "LblShowGSType"
        Me.LblShowGSType.Size = New System.Drawing.Size(58, 17)
        Me.LblShowGSType.TabIndex = 54
        Me.LblShowGSType.Text = "Lot_No"
        '
        'LblShowGSCode
        '
        Me.LblShowGSCode.AutoSize = True
        Me.LblShowGSCode.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowGSCode.ForeColor = System.Drawing.Color.Navy
        Me.LblShowGSCode.Location = New System.Drawing.Point(170, 6)
        Me.LblShowGSCode.Name = "LblShowGSCode"
        Me.LblShowGSCode.Size = New System.Drawing.Size(58, 17)
        Me.LblShowGSCode.TabIndex = 47
        Me.LblShowGSCode.Text = "Lot_No"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(27, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 16)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "GS1 Code"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(27, 68)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(109, 16)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Reference Name"
        '
        'LblShowRefName
        '
        Me.LblShowRefName.AutoSize = True
        Me.LblShowRefName.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowRefName.ForeColor = System.Drawing.Color.Navy
        Me.LblShowRefName.Location = New System.Drawing.Point(170, 68)
        Me.LblShowRefName.Name = "LblShowRefName"
        Me.LblShowRefName.Size = New System.Drawing.Size(58, 17)
        Me.LblShowRefName.TabIndex = 41
        Me.LblShowRefName.Text = "Lot_No"
        '
        'txTbplQty
        '
        Me.txTbplQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txTbplQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txTbplQty.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txTbplQty.Location = New System.Drawing.Point(232, 162)
        Me.txTbplQty.Name = "txTbplQty"
        Me.txTbplQty.Size = New System.Drawing.Size(62, 22)
        Me.txTbplQty.TabIndex = 9
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.White
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.Navy
        Me.BtnClear.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnClear.Location = New System.Drawing.Point(410, 25)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(94, 32)
        Me.BtnClear.TabIndex = 49
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.White
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.Red
        Me.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExit.Location = New System.Drawing.Point(554, 25)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(94, 32)
        Me.BtnExit.TabIndex = 50
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.BtnClear)
        Me.GroupBox1.Controls.Add(Me.BtnExit)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 559)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 70)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnSave.Location = New System.Drawing.Point(275, 25)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(106, 35)
        Me.btnSave.TabIndex = 76
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'CmbOrderContry
        '
        Me.CmbOrderContry.FormattingEnabled = True
        Me.CmbOrderContry.Items.AddRange(New Object() {"EXPORT", "LOCAL"})
        Me.CmbOrderContry.Location = New System.Drawing.Point(337, 43)
        Me.CmbOrderContry.Name = "CmbOrderContry"
        Me.CmbOrderContry.Size = New System.Drawing.Size(109, 23)
        Me.CmbOrderContry.TabIndex = 6
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Navy
        Me.Label20.Location = New System.Drawing.Point(335, 24)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(109, 18)
        Me.Label20.TabIndex = 65
        Me.Label20.Text = "      Country          "
        '
        'CmbTyPacking
        '
        Me.CmbTyPacking.FormattingEnabled = True
        Me.CmbTyPacking.Items.AddRange(New Object() {"Export"})
        Me.CmbTyPacking.Location = New System.Drawing.Point(221, 42)
        Me.CmbTyPacking.Name = "CmbTyPacking"
        Me.CmbTyPacking.Size = New System.Drawing.Size(114, 23)
        Me.CmbTyPacking.TabIndex = 5
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblSterNo)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(25, 52)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(631, 58)
        Me.GroupBox4.TabIndex = 70
        Me.GroupBox4.TabStop = False
        '
        'lblSterNo
        '
        Me.lblSterNo.AutoSize = True
        Me.lblSterNo.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSterNo.ForeColor = System.Drawing.Color.Blue
        Me.lblSterNo.Location = New System.Drawing.Point(160, 16)
        Me.lblSterNo.Name = "lblSterNo"
        Me.lblSterNo.Size = New System.Drawing.Size(151, 33)
        Me.lblSterNo.TabIndex = 30
        Me.lblSterNo.Text = "Lot No. "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(13, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 18)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Reserved_Ord_No"
        '
        'txt_orderId
        '
        Me.txt_orderId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_orderId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_orderId.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_orderId.Location = New System.Drawing.Point(14, 43)
        Me.txt_orderId.Name = "txt_orderId"
        Me.txt_orderId.Size = New System.Drawing.Size(207, 22)
        Me.txt_orderId.TabIndex = 76
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label25.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Navy
        Me.Label25.Location = New System.Drawing.Point(14, 24)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(207, 18)
        Me.Label25.TabIndex = 66
        Me.Label25.Text = "                         Order Id                       "
        '
        'cbxpname
        '
        Me.cbxpname.FormattingEnabled = True
        Me.cbxpname.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cbxpname.Location = New System.Drawing.Point(346, 109)
        Me.cbxpname.Name = "cbxpname"
        Me.cbxpname.Size = New System.Drawing.Size(140, 23)
        Me.cbxpname.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(345, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 18)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "      Print_Name             "
        '
        'cbxtype
        '
        Me.cbxtype.FormattingEnabled = True
        Me.cbxtype.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cbxtype.Location = New System.Drawing.Point(487, 109)
        Me.cbxtype.Name = "cbxtype"
        Me.cbxtype.Size = New System.Drawing.Size(127, 23)
        Me.cbxtype.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(486, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 18)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "                Type             "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ckBatchBased)
        Me.GroupBox2.Controls.Add(Me.CmbOrderContry)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.txtyear)
        Me.GroupBox2.Controls.Add(Me.txt_orderId)
        Me.GroupBox2.Controls.Add(Me.txtmonth)
        Me.GroupBox2.Controls.Add(Me.CmbTyPacking)
        Me.GroupBox2.Controls.Add(Me.BtnAdd)
        Me.GroupBox2.Controls.Add(Me.cbxpname)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.cmb_Batch)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.cbxtype)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TxtShowAvlQty)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.CmbShPower)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.CmbShType)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.CmbShModel)
        Me.GroupBox2.Controls.Add(Me.CmbShBrand)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txTbplQty)
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(10, 130)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(768, 210)
        Me.GroupBox2.TabIndex = 69
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Details"
        '
        'ckBatchBased
        '
        Me.ckBatchBased.AutoSize = True
        Me.ckBatchBased.Location = New System.Drawing.Point(630, 70)
        Me.ckBatchBased.Name = "ckBatchBased"
        Me.ckBatchBased.Size = New System.Drawing.Size(105, 19)
        Me.ckBatchBased.TabIndex = 77
        Me.ckBatchBased.Text = "Batch Based"
        Me.ckBatchBased.UseMnemonic = False
        Me.ckBatchBased.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.White
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.RoyalBlue
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnAdd.Location = New System.Drawing.Point(401, 149)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(106, 35)
        Me.BtnAdd.TabIndex = 10
        Me.BtnAdd.Text = "ADD"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label24.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Navy
        Me.Label24.Location = New System.Drawing.Point(522, 46)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(74, 18)
        Me.Label24.TabIndex = 75
        Me.Label24.Text = "Mf. Month"
        '
        'cmb_Batch
        '
        Me.cmb_Batch.FormattingEnabled = True
        Me.cmb_Batch.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cmb_Batch.Location = New System.Drawing.Point(614, 110)
        Me.cmb_Batch.Name = "cmb_Batch"
        Me.cmb_Batch.Size = New System.Drawing.Size(131, 23)
        Me.cmb_Batch.TabIndex = 4
        Me.cmb_Batch.Visible = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label26.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Navy
        Me.Label26.Location = New System.Drawing.Point(613, 92)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(132, 18)
        Me.Label26.TabIndex = 49
        Me.Label26.Text = "                Batch             "
        Me.Label26.Visible = False
        '
        'TxtShowAvlQty
        '
        Me.TxtShowAvlQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtShowAvlQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtShowAvlQty.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtShowAvlQty.Location = New System.Drawing.Point(138, 162)
        Me.TxtShowAvlQty.Name = "TxtShowAvlQty"
        Me.TxtShowAvlQty.Size = New System.Drawing.Size(93, 22)
        Me.TxtShowAvlQty.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(137, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 18)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Available Qty"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Navy
        Me.Label22.Location = New System.Drawing.Point(138, 91)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(73, 18)
        Me.Label22.TabIndex = 47
        Me.Label22.Text = "    Power    "
        '
        'CmbShPower
        '
        Me.CmbShPower.FormattingEnabled = True
        Me.CmbShPower.Items.AddRange(New Object() {"1", "2", "3"})
        Me.CmbShPower.Location = New System.Drawing.Point(140, 109)
        Me.CmbShPower.Name = "CmbShPower"
        Me.CmbShPower.Size = New System.Drawing.Size(70, 23)
        Me.CmbShPower.TabIndex = 1
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Navy
        Me.Label21.Location = New System.Drawing.Point(15, 143)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(122, 18)
        Me.Label21.TabIndex = 45
        Me.Label21.Text = "         GS_Type          "
        '
        'CmbShType
        '
        Me.CmbShType.FormattingEnabled = True
        Me.CmbShType.Items.AddRange(New Object() {"AOD"})
        Me.CmbShType.Location = New System.Drawing.Point(18, 161)
        Me.CmbShType.Name = "CmbShType"
        Me.CmbShType.Size = New System.Drawing.Size(119, 23)
        Me.CmbShType.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(211, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 18)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "                Brand             "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(14, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 18)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "              Model           "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbShModel
        '
        Me.CmbShModel.FormattingEnabled = True
        Me.CmbShModel.Items.AddRange(New Object() {"1", "2", "3"})
        Me.CmbShModel.Location = New System.Drawing.Point(14, 109)
        Me.CmbShModel.Name = "CmbShModel"
        Me.CmbShModel.Size = New System.Drawing.Size(126, 23)
        Me.CmbShModel.TabIndex = 0
        '
        'CmbShBrand
        '
        Me.CmbShBrand.FormattingEnabled = True
        Me.CmbShBrand.Items.AddRange(New Object() {"A", "B", "C"})
        Me.CmbShBrand.Location = New System.Drawing.Point(211, 109)
        Me.CmbShBrand.Name = "CmbShBrand"
        Me.CmbShBrand.Size = New System.Drawing.Size(133, 23)
        Me.CmbShBrand.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(232, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "      Qty    "
        '
        'lblTotBplQty1
        '
        Me.lblTotBplQty1.AutoSize = True
        Me.lblTotBplQty1.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotBplQty1.ForeColor = System.Drawing.Color.Blue
        Me.lblTotBplQty1.Location = New System.Drawing.Point(688, 525)
        Me.lblTotBplQty1.Name = "lblTotBplQty1"
        Me.lblTotBplQty1.Size = New System.Drawing.Size(30, 31)
        Me.lblTotBplQty1.TabIndex = 79
        Me.lblTotBplQty1.Text = "0"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Blue
        Me.Label28.Location = New System.Drawing.Point(595, 530)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(71, 18)
        Me.Label28.TabIndex = 78
        Me.Label28.Text = "Total Qty"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(12, 537)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(348, 14)
        Me.Label29.TabIndex = 80
        Me.Label29.Text = "* Delete Row : Select Particular Row and click Delete Button  in keyboard"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(822, 62)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(72, 17)
        Me.CheckBox1.TabIndex = 77
        Me.CheckBox1.Text = "Reserved"
        Me.CheckBox1.UseMnemonic = False
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'cmbReserve_id
        '
        Me.cmbReserve_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReserve_id.FormattingEnabled = True
        Me.cmbReserve_id.Location = New System.Drawing.Point(1079, 52)
        Me.cmbReserve_id.Name = "cmbReserve_id"
        Me.cmbReserve_id.Size = New System.Drawing.Size(317, 32)
        Me.cmbReserve_id.TabIndex = 81
        Me.cmbReserve_id.Visible = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Blue
        Me.Label27.Location = New System.Drawing.Point(928, 59)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(134, 18)
        Me.Label27.TabIndex = 29
        Me.Label27.Text = "Reserved_Ord_No"
        Me.Label27.Visible = False
        '
        'GRID2
        '
        Me.GRID2.AllowUserToOrderColumns = True
        Me.GRID2.BackgroundColor = System.Drawing.Color.White
        Me.GRID2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GRID2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.GRID2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GRID2.Location = New System.Drawing.Point(10, 346)
        Me.GRID2.Name = "GRID2"
        Me.GRID2.Size = New System.Drawing.Size(768, 176)
        Me.GRID2.TabIndex = 42
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(804, 90)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(682, 300)
        Me.DataGridView1.TabIndex = 42
        '
        'frmLensReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1498, 652)
        Me.Controls.Add(Me.cmbReserve_id)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GRID2)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.lblTotBplQty1)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmLensReservation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLensReservation"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LblShowOptic As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LblShowPower As System.Windows.Forms.Label
    Friend WithEvents LblShowExpDate As System.Windows.Forms.Label
    Friend WithEvents LblshAConstant As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtyear As System.Windows.Forms.TextBox
    Friend WithEvents txtmonth As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LblShowMfdDate As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LblShowLength As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LblShowGSType As System.Windows.Forms.Label
    Friend WithEvents LblShowGSCode As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LblShowRefName As System.Windows.Forms.Label
    Friend WithEvents txTbplQty As System.Windows.Forms.TextBox
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbOrderContry As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents CmbTyPacking As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSterNo As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbxpname As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbxtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtShowAvlQty As System.Windows.Forms.TextBox
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents CmbShPower As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents CmbShType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbShModel As System.Windows.Forms.ComboBox
    Friend WithEvents CmbShBrand As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txt_orderId As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cmb_Batch As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents ckBatchBased As System.Windows.Forms.CheckBox
    Friend WithEvents lblTotBplQty1 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents cmbReserve_id As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents GRID2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
