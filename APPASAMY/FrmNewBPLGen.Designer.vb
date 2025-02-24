<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewBPLGen
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.lblSterNo = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CmbOrderContry = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.CmbTyPacking = New System.Windows.Forms.ComboBox
        Me.cbxpname = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cbxtype = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtShowAvlQty = New System.Windows.Forms.TextBox
        Me.BtnAdd = New System.Windows.Forms.Button
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
        Me.txTbplQty = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.LblShowExpDate = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.LblShowMfdDate = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.LblShowOptic = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.LblShowPower = New System.Windows.Forms.Label
        Me.LblshAConstant = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.LblShowLength = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.LblShowGSType = New System.Windows.Forms.Label
        Me.LblShowGSCode = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.LblShowRefName = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnClear = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblTotBplQty = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GRID2 = New System.Windows.Forms.DataGridView
        Me.txtyear = New System.Windows.Forms.TextBox
        Me.txtmonth = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.rdReservedStock = New System.Windows.Forms.RadioButton
        Me.rdFreeStock = New System.Windows.Forms.RadioButton
        Me.Label25 = New System.Windows.Forms.Label
        Me.cmbReserved_id = New System.Windows.Forms.ComboBox
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblSterNo)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 72)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1084, 48)
        Me.GroupBox4.TabIndex = 53
        Me.GroupBox4.TabStop = False
        '
        'lblSterNo
        '
        Me.lblSterNo.AutoSize = True
        Me.lblSterNo.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSterNo.ForeColor = System.Drawing.Color.Blue
        Me.lblSterNo.Location = New System.Drawing.Point(135, 12)
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
        Me.Label6.Location = New System.Drawing.Point(14, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 18)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "BPL No"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmbOrderContry)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.CmbTyPacking)
        Me.GroupBox2.Controls.Add(Me.cbxpname)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cbxtype)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TxtShowAvlQty)
        Me.GroupBox2.Controls.Add(Me.BtnAdd)
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
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(12, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1271, 68)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Details"
        '
        'CmbOrderContry
        '
        Me.CmbOrderContry.FormattingEnabled = True
        Me.CmbOrderContry.Items.AddRange(New Object() {"EXPORT", "LOCAL"})
        Me.CmbOrderContry.Location = New System.Drawing.Point(720, 38)
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
        Me.Label20.Location = New System.Drawing.Point(718, 19)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(109, 18)
        Me.Label20.TabIndex = 65
        Me.Label20.Text = "      Country          "
        '
        'CmbTyPacking
        '
        Me.CmbTyPacking.FormattingEnabled = True
        Me.CmbTyPacking.Items.AddRange(New Object() {"Export", "Local"})
        Me.CmbTyPacking.Location = New System.Drawing.Point(604, 37)
        Me.CmbTyPacking.Name = "CmbTyPacking"
        Me.CmbTyPacking.Size = New System.Drawing.Size(114, 23)
        Me.CmbTyPacking.TabIndex = 5
        '
        'cbxpname
        '
        Me.cbxpname.FormattingEnabled = True
        Me.cbxpname.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cbxpname.Location = New System.Drawing.Point(338, 36)
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
        Me.Label9.Location = New System.Drawing.Point(337, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 18)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "      Print_Name             "
        '
        'cbxtype
        '
        Me.cbxtype.FormattingEnabled = True
        Me.cbxtype.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cbxtype.Location = New System.Drawing.Point(479, 36)
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
        Me.Label8.Location = New System.Drawing.Point(478, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 18)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "                Type             "
        '
        'TxtShowAvlQty
        '
        Me.TxtShowAvlQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtShowAvlQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtShowAvlQty.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtShowAvlQty.Location = New System.Drawing.Point(950, 39)
        Me.TxtShowAvlQty.Name = "TxtShowAvlQty"
        Me.TxtShowAvlQty.Size = New System.Drawing.Size(93, 22)
        Me.TxtShowAvlQty.TabIndex = 11
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.White
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.RoyalBlue
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnAdd.Location = New System.Drawing.Point(1117, 20)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(55, 41)
        Me.BtnAdd.TabIndex = 10
        Me.BtnAdd.Text = "ADD "
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(949, 20)
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
        Me.Label22.Location = New System.Drawing.Point(130, 18)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(73, 18)
        Me.Label22.TabIndex = 47
        Me.Label22.Text = "    Power    "
        '
        'CmbShPower
        '
        Me.CmbShPower.FormattingEnabled = True
        Me.CmbShPower.Items.AddRange(New Object() {"1", "2", "3"})
        Me.CmbShPower.Location = New System.Drawing.Point(132, 36)
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
        Me.Label21.Location = New System.Drawing.Point(827, 20)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(122, 18)
        Me.Label21.TabIndex = 45
        Me.Label21.Text = "         GS_Type          "
        '
        'CmbShType
        '
        Me.CmbShType.FormattingEnabled = True
        Me.CmbShType.Items.AddRange(New Object() {"AOD"})
        Me.CmbShType.Location = New System.Drawing.Point(830, 38)
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
        Me.Label4.Location = New System.Drawing.Point(203, 18)
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
        Me.Label1.Location = New System.Drawing.Point(6, 18)
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
        Me.CmbShModel.Location = New System.Drawing.Point(6, 36)
        Me.CmbShModel.Name = "CmbShModel"
        Me.CmbShModel.Size = New System.Drawing.Size(126, 23)
        Me.CmbShModel.TabIndex = 0
        '
        'CmbShBrand
        '
        Me.CmbShBrand.FormattingEnabled = True
        Me.CmbShBrand.Items.AddRange(New Object() {"A", "B", "C"})
        Me.CmbShBrand.Location = New System.Drawing.Point(203, 36)
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
        Me.Label2.Location = New System.Drawing.Point(1044, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "      Qty    "
        '
        'txTbplQty
        '
        Me.txTbplQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txTbplQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txTbplQty.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txTbplQty.Location = New System.Drawing.Point(1044, 39)
        Me.txTbplQty.Name = "txTbplQty"
        Me.txTbplQty.Size = New System.Drawing.Size(62, 22)
        Me.txTbplQty.TabIndex = 9
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(605, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(113, 18)
        Me.Label18.TabIndex = 64
        Me.Label18.Text = "Ty of Packing       "
        '
        'LblShowExpDate
        '
        Me.LblShowExpDate.AutoSize = True
        Me.LblShowExpDate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowExpDate.ForeColor = System.Drawing.Color.Navy
        Me.LblShowExpDate.Location = New System.Drawing.Point(170, 271)
        Me.LblShowExpDate.Name = "LblShowExpDate"
        Me.LblShowExpDate.Size = New System.Drawing.Size(58, 17)
        Me.LblShowExpDate.TabIndex = 43
        Me.LblShowExpDate.Text = "Lot_No"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Blue
        Me.Label19.Location = New System.Drawing.Point(27, 271)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 16)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "Exp.Date"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Blue
        Me.Label17.Location = New System.Drawing.Point(27, 240)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 16)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "Mfd.Date"
        '
        'LblShowMfdDate
        '
        Me.LblShowMfdDate.AutoSize = True
        Me.LblShowMfdDate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowMfdDate.ForeColor = System.Drawing.Color.Navy
        Me.LblShowMfdDate.Location = New System.Drawing.Point(170, 240)
        Me.LblShowMfdDate.Name = "LblShowMfdDate"
        Me.LblShowMfdDate.Size = New System.Drawing.Size(58, 17)
        Me.LblShowMfdDate.TabIndex = 41
        Me.LblShowMfdDate.Text = "Lot_No"
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
        Me.GroupBox3.Location = New System.Drawing.Point(1184, 415)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(34, 20)
        Me.GroupBox3.TabIndex = 60
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lens Details"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(27, 116)
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
        Me.LblShowOptic.Location = New System.Drawing.Point(170, 116)
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
        Me.Label10.Location = New System.Drawing.Point(27, 147)
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
        Me.LblShowPower.Location = New System.Drawing.Point(170, 54)
        Me.LblShowPower.Name = "LblShowPower"
        Me.LblShowPower.Size = New System.Drawing.Size(58, 17)
        Me.LblShowPower.TabIndex = 52
        Me.LblShowPower.Text = "Lot_No"
        '
        'LblshAConstant
        '
        Me.LblshAConstant.AutoSize = True
        Me.LblshAConstant.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblshAConstant.ForeColor = System.Drawing.Color.Navy
        Me.LblshAConstant.Location = New System.Drawing.Point(170, 209)
        Me.LblshAConstant.Name = "LblshAConstant"
        Me.LblshAConstant.Size = New System.Drawing.Size(58, 17)
        Me.LblshAConstant.TabIndex = 56
        Me.LblshAConstant.Text = "Lot_No"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(27, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 16)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Power"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(27, 209)
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
        Me.LblShowLength.Location = New System.Drawing.Point(170, 147)
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
        Me.Label15.Location = New System.Drawing.Point(27, 178)
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
        Me.LblShowGSType.Location = New System.Drawing.Point(170, 178)
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
        Me.LblShowGSCode.Location = New System.Drawing.Point(170, 23)
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
        Me.Label11.Location = New System.Drawing.Point(27, 23)
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
        Me.Label14.Location = New System.Drawing.Point(27, 85)
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
        Me.LblShowRefName.Location = New System.Drawing.Point(170, 85)
        Me.LblShowRefName.Name = "LblShowRefName"
        Me.LblShowRefName.Size = New System.Drawing.Size(58, 17)
        Me.LblShowRefName.TabIndex = 41
        Me.LblShowRefName.Text = "Lot_No"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnClear)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.BtnExit)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 447)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1083, 70)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.White
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.Navy
        Me.BtnClear.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnClear.Location = New System.Drawing.Point(409, 19)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(94, 32)
        Me.BtnClear.TabIndex = 49
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.White
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnSave.Location = New System.Drawing.Point(246, 19)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(94, 32)
        Me.BtnSave.TabIndex = 48
        Me.BtnSave.Text = " SAVE"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.White
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.Red
        Me.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExit.Location = New System.Drawing.Point(553, 19)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(94, 32)
        Me.BtnExit.TabIndex = 50
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.lblTotBplQty)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.GRID2)
        Me.GroupBox6.Location = New System.Drawing.Point(15, 200)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1237, 241)
        Me.GroupBox6.TabIndex = 62
        Me.GroupBox6.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(163, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(348, 14)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "* Delete Row : Select Particular Row and click Delete Button  in keyboard"
        '
        'lblTotBplQty
        '
        Me.lblTotBplQty.AutoSize = True
        Me.lblTotBplQty.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotBplQty.ForeColor = System.Drawing.Color.Blue
        Me.lblTotBplQty.Location = New System.Drawing.Point(696, 207)
        Me.lblTotBplQty.Name = "lblTotBplQty"
        Me.lblTotBplQty.Size = New System.Drawing.Size(30, 31)
        Me.lblTotBplQty.TabIndex = 44
        Me.lblTotBplQty.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(603, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 18)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Total Qty"
        '
        'GRID2
        '
        Me.GRID2.AllowUserToOrderColumns = True
        Me.GRID2.BackgroundColor = System.Drawing.Color.White
        Me.GRID2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GRID2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.GRID2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GRID2.Location = New System.Drawing.Point(7, 16)
        Me.GRID2.Name = "GRID2"
        Me.GRID2.Size = New System.Drawing.Size(1224, 190)
        Me.GRID2.TabIndex = 42
        '
        'txtyear
        '
        Me.txtyear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtyear.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtyear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtyear.Location = New System.Drawing.Point(1183, 73)
        Me.txtyear.Name = "txtyear"
        Me.txtyear.Size = New System.Drawing.Size(93, 22)
        Me.txtyear.TabIndex = 1
        '
        'txtmonth
        '
        Me.txtmonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmonth.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmonth.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmonth.Location = New System.Drawing.Point(1184, 98)
        Me.txtmonth.Name = "txtmonth"
        Me.txtmonth.Size = New System.Drawing.Size(94, 22)
        Me.txtmonth.TabIndex = 2
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Navy
        Me.Label23.Location = New System.Drawing.Point(1115, 77)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(60, 18)
        Me.Label23.TabIndex = 65
        Me.Label23.Text = "Mf.Year"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label24.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Navy
        Me.Label24.Location = New System.Drawing.Point(1105, 102)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(74, 18)
        Me.Label24.TabIndex = 66
        Me.Label24.Text = "Mf. Month"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rdReservedStock)
        Me.GroupBox5.Controls.Add(Me.rdFreeStock)
        Me.GroupBox5.Location = New System.Drawing.Point(22, 7)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(708, 59)
        Me.GroupBox5.TabIndex = 67
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "GroupBox5"
        '
        'rdReservedStock
        '
        Me.rdReservedStock.AutoSize = True
        Me.rdReservedStock.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdReservedStock.ForeColor = System.Drawing.Color.Red
        Me.rdReservedStock.Location = New System.Drawing.Point(375, 19)
        Me.rdReservedStock.Name = "rdReservedStock"
        Me.rdReservedStock.Size = New System.Drawing.Size(164, 19)
        Me.rdReservedStock.TabIndex = 74
        Me.rdReservedStock.Text = "Reserved Stock Based"
        Me.rdReservedStock.UseVisualStyleBackColor = True
        '
        'rdFreeStock
        '
        Me.rdFreeStock.AutoSize = True
        Me.rdFreeStock.Checked = True
        Me.rdFreeStock.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdFreeStock.ForeColor = System.Drawing.Color.Red
        Me.rdFreeStock.Location = New System.Drawing.Point(39, 19)
        Me.rdFreeStock.Name = "rdFreeStock"
        Me.rdFreeStock.Size = New System.Drawing.Size(133, 19)
        Me.rdFreeStock.TabIndex = 73
        Me.rdFreeStock.TabStop = True
        Me.rdFreeStock.Text = "Free Stock Based"
        Me.rdFreeStock.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label25.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Navy
        Me.Label25.Location = New System.Drawing.Point(777, 26)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(160, 18)
        Me.Label25.TabIndex = 65
        Me.Label25.Text = "             Reserved Id            "
        '
        'cmbReserved_id
        '
        Me.cmbReserved_id.FormattingEnabled = True
        Me.cmbReserved_id.Items.AddRange(New Object() {"EXPORT", "LOCAL"})
        Me.cmbReserved_id.Location = New System.Drawing.Point(779, 45)
        Me.cmbReserved_id.Name = "cmbReserved_id"
        Me.cmbReserved_id.Size = New System.Drawing.Size(158, 21)
        Me.cmbReserved_id.TabIndex = 6
        '
        'FrmNewBPLGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1295, 574)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmbReserved_id)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtyear)
        Me.Controls.Add(Me.txtmonth)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmNewBPLGen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSterNo As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents CmbShPower As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents CmbShType As System.Windows.Forms.ComboBox
    Friend WithEvents LblShowExpDate As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents LblShowMfdDate As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbShModel As System.Windows.Forms.ComboBox
    Friend WithEvents CmbShBrand As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txTbplQty As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LblShowOptic As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LblShowPower As System.Windows.Forms.Label
    Friend WithEvents LblshAConstant As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LblShowLength As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LblShowGSType As System.Windows.Forms.Label
    Friend WithEvents LblShowGSCode As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LblShowRefName As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GRID2 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents TxtShowAvlQty As System.Windows.Forms.TextBox
    Friend WithEvents lblTotBplQty As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbxtype As System.Windows.Forms.ComboBox
    Friend WithEvents cbxpname As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CmbTyPacking As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents CmbOrderContry As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtyear As System.Windows.Forms.TextBox
    Friend WithEvents txtmonth As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rdReservedStock As System.Windows.Forms.RadioButton
    Friend WithEvents rdFreeStock As System.Windows.Forms.RadioButton
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cmbReserved_id As System.Windows.Forms.ComboBox
End Class
