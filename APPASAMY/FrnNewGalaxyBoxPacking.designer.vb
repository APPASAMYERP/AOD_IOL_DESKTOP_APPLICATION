<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrnNewGalaxyBoxPacking
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
        Me.lblcylsz = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.rbExportNormal = New System.Windows.Forms.RadioButton
        Me.rbExport = New System.Windows.Forms.RadioButton
        Me.rbLocal = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpMFDDate = New System.Windows.Forms.DateTimePicker
        Me.Chkupdate = New System.Windows.Forms.CheckBox
        Me.txtrpwr = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblrpwr = New System.Windows.Forms.Label
        Me.txtcylsize = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtinj = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Txt_btc = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblShowExpDate = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.CmbShPower = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.CmbShType = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.LblShowMfdDate = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.CmbShModel = New System.Windows.Forms.ComboBox
        Me.CmbShBrand = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtlotno = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtlotprefix = New System.Windows.Forms.TextBox
        Me.txtstartqty = New System.Windows.Forms.TextBox
        Me.LblShowOptic = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.pnl = New System.Windows.Forms.GroupBox
        Me.BtnExit = New System.Windows.Forms.Button
        Me.BtnClear = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
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
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BtnSave = New System.Windows.Forms.Button
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtendqty = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnl.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblcylsz
        '
        Me.lblcylsz.AutoSize = True
        Me.lblcylsz.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcylsz.ForeColor = System.Drawing.Color.Blue
        Me.lblcylsz.Location = New System.Drawing.Point(269, 207)
        Me.lblcylsz.Name = "lblcylsz"
        Me.lblcylsz.Size = New System.Drawing.Size(52, 16)
        Me.lblcylsz.TabIndex = 51
        Me.lblcylsz.Text = "CylSize"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbExportNormal)
        Me.GroupBox4.Controls.Add(Me.rbExport)
        Me.GroupBox4.Controls.Add(Me.rbLocal)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.dtpMFDDate)
        Me.GroupBox4.Controls.Add(Me.Chkupdate)
        Me.GroupBox4.Location = New System.Drawing.Point(34, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(827, 43)
        Me.GroupBox4.TabIndex = 66
        Me.GroupBox4.TabStop = False
        '
        'rbExportNormal
        '
        Me.rbExportNormal.AutoSize = True
        Me.rbExportNormal.Location = New System.Drawing.Point(508, 14)
        Me.rbExportNormal.Name = "rbExportNormal"
        Me.rbExportNormal.Size = New System.Drawing.Size(55, 17)
        Me.rbExportNormal.TabIndex = 44
        Me.rbExportNormal.Text = "Export"
        Me.rbExportNormal.UseVisualStyleBackColor = True
        '
        'rbExport
        '
        Me.rbExport.AutoSize = True
        Me.rbExport.Location = New System.Drawing.Point(419, 14)
        Me.rbExport.Name = "rbExport"
        Me.rbExport.Size = New System.Drawing.Size(82, 17)
        Me.rbExport.TabIndex = 43
        Me.rbExport.Text = "Export 3 Yrs"
        Me.rbExport.UseVisualStyleBackColor = True
        '
        'rbLocal
        '
        Me.rbLocal.AutoSize = True
        Me.rbLocal.Checked = True
        Me.rbLocal.Location = New System.Drawing.Point(332, 14)
        Me.rbLocal.Name = "rbLocal"
        Me.rbLocal.Size = New System.Drawing.Size(51, 17)
        Me.rbLocal.TabIndex = 42
        Me.rbLocal.TabStop = True
        Me.rbLocal.Text = "Local"
        Me.rbLocal.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(31, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Mfd.Date"
        '
        'dtpMFDDate
        '
        Me.dtpMFDDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMFDDate.Location = New System.Drawing.Point(165, 12)
        Me.dtpMFDDate.Name = "dtpMFDDate"
        Me.dtpMFDDate.Size = New System.Drawing.Size(137, 20)
        Me.dtpMFDDate.TabIndex = 2
        Me.dtpMFDDate.Value = New Date(2023, 3, 16, 0, 0, 0, 0)
        '
        'Chkupdate
        '
        Me.Chkupdate.AutoSize = True
        Me.Chkupdate.Location = New System.Drawing.Point(748, 17)
        Me.Chkupdate.Name = "Chkupdate"
        Me.Chkupdate.Size = New System.Drawing.Size(66, 17)
        Me.Chkupdate.TabIndex = 1
        Me.Chkupdate.Text = "Re- print"
        Me.Chkupdate.UseVisualStyleBackColor = True
        '
        'txtrpwr
        '
        Me.txtrpwr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtrpwr.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrpwr.Location = New System.Drawing.Point(332, 177)
        Me.txtrpwr.Name = "txtrpwr"
        Me.txtrpwr.Size = New System.Drawing.Size(71, 22)
        Me.txtrpwr.TabIndex = 50
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(27, 126)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 16)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Optic"
        '
        'lblrpwr
        '
        Me.lblrpwr.AutoSize = True
        Me.lblrpwr.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrpwr.ForeColor = System.Drawing.Color.Blue
        Me.lblrpwr.Location = New System.Drawing.Point(269, 180)
        Me.lblrpwr.Name = "lblrpwr"
        Me.lblrpwr.Size = New System.Drawing.Size(60, 16)
        Me.lblrpwr.TabIndex = 49
        Me.lblrpwr.Text = "R.Power"
        '
        'txtcylsize
        '
        Me.txtcylsize.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcylsize.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcylsize.Location = New System.Drawing.Point(332, 204)
        Me.txtcylsize.Name = "txtcylsize"
        Me.txtcylsize.Size = New System.Drawing.Size(71, 22)
        Me.txtcylsize.TabIndex = 52
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtinj)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Txt_btc)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.LblShowExpDate)
        Me.GroupBox2.Controls.Add(Me.txtcylsize)
        Me.GroupBox2.Controls.Add(Me.lblcylsz)
        Me.GroupBox2.Controls.Add(Me.txtrpwr)
        Me.GroupBox2.Controls.Add(Me.lblrpwr)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.CmbShPower)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.CmbShType)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.LblShowMfdDate)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.CmbShModel)
        Me.GroupBox2.Controls.Add(Me.CmbShBrand)
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(34, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(413, 310)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Details"
        '
        'txtinj
        '
        Me.txtinj.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtinj.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinj.Location = New System.Drawing.Point(165, 279)
        Me.txtinj.Name = "txtinj"
        Me.txtinj.Size = New System.Drawing.Size(137, 22)
        Me.txtinj.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(50, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Inj_Lot"
        '
        'Txt_btc
        '
        Me.Txt_btc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_btc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_btc.Location = New System.Drawing.Point(165, 241)
        Me.Txt_btc.Name = "Txt_btc"
        Me.Txt_btc.Size = New System.Drawing.Size(137, 22)
        Me.Txt_btc.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(50, 243)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Streile_Lot"
        '
        'LblShowExpDate
        '
        Me.LblShowExpDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.LblShowExpDate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowExpDate.Location = New System.Drawing.Point(165, 205)
        Me.LblShowExpDate.Name = "LblShowExpDate"
        Me.LblShowExpDate.Size = New System.Drawing.Size(71, 22)
        Me.LblShowExpDate.TabIndex = 53
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Blue
        Me.Label22.Location = New System.Drawing.Point(50, 67)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(47, 16)
        Me.Label22.TabIndex = 47
        Me.Label22.Text = "Power"
        '
        'CmbShPower
        '
        Me.CmbShPower.FormattingEnabled = True
        Me.CmbShPower.Items.AddRange(New Object() {"1", "2", "3"})
        Me.CmbShPower.Location = New System.Drawing.Point(165, 67)
        Me.CmbShPower.Name = "CmbShPower"
        Me.CmbShPower.Size = New System.Drawing.Size(137, 23)
        Me.CmbShPower.TabIndex = 2
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Blue
        Me.Label21.Location = New System.Drawing.Point(50, 137)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(39, 16)
        Me.Label21.TabIndex = 45
        Me.Label21.Text = "Type"
        '
        'CmbShType
        '
        Me.CmbShType.FormattingEnabled = True
        Me.CmbShType.Items.AddRange(New Object() {"AOD"})
        Me.CmbShType.Location = New System.Drawing.Point(165, 141)
        Me.CmbShType.Name = "CmbShType"
        Me.CmbShType.Size = New System.Drawing.Size(137, 23)
        Me.CmbShType.TabIndex = 4
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Blue
        Me.Label19.Location = New System.Drawing.Point(50, 207)
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
        Me.Label17.Location = New System.Drawing.Point(50, 172)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 16)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "Mfd.Date"
        '
        'LblShowMfdDate
        '
        Me.LblShowMfdDate.AutoSize = True
        Me.LblShowMfdDate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowMfdDate.ForeColor = System.Drawing.Color.Navy
        Me.LblShowMfdDate.Location = New System.Drawing.Point(165, 178)
        Me.LblShowMfdDate.Name = "LblShowMfdDate"
        Me.LblShowMfdDate.Size = New System.Drawing.Size(54, 17)
        Me.LblShowMfdDate.TabIndex = 41
        Me.LblShowMfdDate.Text = "Lot_No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(50, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Brand"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(50, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 16)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Model"
        '
        'CmbShModel
        '
        Me.CmbShModel.FormattingEnabled = True
        Me.CmbShModel.Items.AddRange(New Object() {"1", "2", "3"})
        Me.CmbShModel.Location = New System.Drawing.Point(165, 30)
        Me.CmbShModel.Name = "CmbShModel"
        Me.CmbShModel.Size = New System.Drawing.Size(137, 23)
        Me.CmbShModel.TabIndex = 1
        '
        'CmbShBrand
        '
        Me.CmbShBrand.FormattingEnabled = True
        Me.CmbShBrand.Items.AddRange(New Object() {"A", "B", "C"})
        Me.CmbShBrand.Location = New System.Drawing.Point(165, 104)
        Me.CmbShBrand.Name = "CmbShBrand"
        Me.CmbShBrand.Size = New System.Drawing.Size(137, 23)
        Me.CmbShBrand.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(406, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Start Label"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtlotno)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtlotprefix)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtstartqty)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(34, 377)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(838, 89)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lot Details"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Blue
        Me.Label20.Location = New System.Drawing.Point(215, 40)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(50, 16)
        Me.Label20.TabIndex = 42
        Me.Label20.Text = "Lot No"
        '
        'txtlotno
        '
        Me.txtlotno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtlotno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlotno.Location = New System.Drawing.Point(286, 37)
        Me.txtlotno.Name = "txtlotno"
        Me.txtlotno.Size = New System.Drawing.Size(94, 22)
        Me.txtlotno.TabIndex = 6
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Blue
        Me.Label18.Location = New System.Drawing.Point(14, 42)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 16)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "Lot Prefix"
        '
        'txtlotprefix
        '
        Me.txtlotprefix.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtlotprefix.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlotprefix.Location = New System.Drawing.Point(89, 40)
        Me.txtlotprefix.Name = "txtlotprefix"
        Me.txtlotprefix.Size = New System.Drawing.Size(112, 22)
        Me.txtlotprefix.TabIndex = 5
        '
        'txtstartqty
        '
        Me.txtstartqty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtstartqty.Font = New System.Drawing.Font("Times New Roman", 26.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstartqty.Location = New System.Drawing.Point(487, 23)
        Me.txtstartqty.Name = "txtstartqty"
        Me.txtstartqty.Size = New System.Drawing.Size(312, 48)
        Me.txtstartqty.TabIndex = 7
        '
        'LblShowOptic
        '
        Me.LblShowOptic.AutoSize = True
        Me.LblShowOptic.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowOptic.ForeColor = System.Drawing.Color.Navy
        Me.LblShowOptic.Location = New System.Drawing.Point(170, 126)
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
        Me.Label10.Location = New System.Drawing.Point(27, 158)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 16)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Length"
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.BtnExit)
        Me.pnl.Controls.Add(Me.BtnClear)
        Me.pnl.Location = New System.Drawing.Point(34, 472)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(838, 58)
        Me.pnl.TabIndex = 65
        Me.pnl.TabStop = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.White
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.Red
        Me.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExit.Location = New System.Drawing.Point(419, 20)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(94, 32)
        Me.BtnExit.TabIndex = 50
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.White
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.Navy
        Me.BtnClear.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnClear.Location = New System.Drawing.Point(319, 20)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(94, 32)
        Me.BtnClear.TabIndex = 49
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.LblShowOptic)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.LblShowPower)
        Me.GroupBox3.Controls.Add(Me.LblshAConstant)
        Me.GroupBox3.Controls.Add(Me.Label13)
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
        Me.GroupBox3.Location = New System.Drawing.Point(443, 76)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(411, 268)
        Me.GroupBox3.TabIndex = 64
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lens Details"
        '
        'LblShowPower
        '
        Me.LblShowPower.AutoSize = True
        Me.LblShowPower.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowPower.ForeColor = System.Drawing.Color.Navy
        Me.LblShowPower.Location = New System.Drawing.Point(170, 62)
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
        Me.LblshAConstant.Location = New System.Drawing.Point(170, 222)
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
        Me.Label13.Location = New System.Drawing.Point(27, 62)
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
        Me.Label16.Location = New System.Drawing.Point(27, 222)
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
        Me.LblShowLength.Location = New System.Drawing.Point(170, 158)
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
        Me.Label15.Location = New System.Drawing.Point(27, 190)
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
        Me.LblShowGSType.Location = New System.Drawing.Point(170, 190)
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
        Me.LblShowGSCode.Location = New System.Drawing.Point(170, 30)
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
        Me.Label11.Location = New System.Drawing.Point(27, 30)
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
        Me.Label14.Location = New System.Drawing.Point(27, 94)
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
        Me.LblShowRefName.Location = New System.Drawing.Point(170, 94)
        Me.LblShowRefName.Name = "LblShowRefName"
        Me.LblShowRefName.Size = New System.Drawing.Size(58, 17)
        Me.LblShowRefName.TabIndex = 41
        Me.LblShowRefName.Text = "Lot_No"
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.White
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnSave.Location = New System.Drawing.Point(266, 47)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(94, 32)
        Me.BtnSave.TabIndex = 6
        Me.BtnSave.Text = " SAVE"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Blue
        Me.Label23.Location = New System.Drawing.Point(86, 17)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(69, 16)
        Me.Label23.TabIndex = 44
        Me.Label23.Text = "End Label"
        '
        'txtendqty
        '
        Me.txtendqty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtendqty.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtendqty.Location = New System.Drawing.Point(170, 22)
        Me.txtendqty.Name = "txtendqty"
        Me.txtendqty.Size = New System.Drawing.Size(77, 22)
        Me.txtendqty.TabIndex = 8
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtendqty)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.BtnSave)
        Me.GroupBox5.Location = New System.Drawing.Point(453, 350)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(395, 12)
        Me.GroupBox5.TabIndex = 67
        Me.GroupBox5.TabStop = False
        '
        'FrnNewGalaxyBoxPacking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1543, 798)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrnNewGalaxyBoxPacking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrnNewGalaxyBoxPacking"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnl.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblcylsz As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtrpwr As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblrpwr As System.Windows.Forms.Label
    Friend WithEvents txtcylsize As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents CmbShPower As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents CmbShType As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents LblShowMfdDate As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CmbShModel As System.Windows.Forms.ComboBox
    Friend WithEvents CmbShBrand As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblShowOptic As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents pnl As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
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
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtlotno As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtlotprefix As System.Windows.Forms.TextBox
    Friend WithEvents LblShowExpDate As System.Windows.Forms.TextBox
    Friend WithEvents Chkupdate As System.Windows.Forms.CheckBox
    Friend WithEvents Txt_btc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtinj As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtstartqty As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpMFDDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbExport As System.Windows.Forms.RadioButton
    Friend WithEvents rbLocal As System.Windows.Forms.RadioButton
    Friend WithEvents rbExportNormal As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtendqty As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
End Class
