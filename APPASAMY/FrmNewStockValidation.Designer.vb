<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewStockValidation
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNewStockValidation))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTrayNo = New System.Windows.Forms.TextBox
        Me.txtRackLocation = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.CmbShPower = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.CmbShModel = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtstartqty = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.LblShowExpDate = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.LblShowOptic = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.LblShowPower = New System.Windows.Forms.Label
        Me.LblshAConstant = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.LblShowMfdDate = New System.Windows.Forms.Label
        Me.LblShowLength = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.LblShowGSType = New System.Windows.Forms.Label
        Me.LblShowGSCode = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.LblShowRefName = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtlotno = New System.Windows.Forms.ComboBox
        Me.txtlotprefix = New System.Windows.Forms.ComboBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.rdLotSerial = New System.Windows.Forms.RadioButton
        Me.rdUDICode = New System.Windows.Forms.RadioButton
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.rbExport = New System.Windows.Forms.RadioButton
        Me.rbLocal = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpMFDDate = New System.Windows.Forms.DateTimePicker
        Me.GRID2 = New System.Windows.Forms.DataGridView
        Me.Lot_SrNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Inward_No = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblcount = New System.Windows.Forms.Label
        Me.BtnComplete = New System.Windows.Forms.Button
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblScanedCount = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtTrayNo)
        Me.GroupBox2.Controls.Add(Me.txtRackLocation)
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(15, 180)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(385, 93)
        Me.GroupBox2.TabIndex = 64
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rack Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(48, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 16)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Tray No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(48, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Rack Location"
        '
        'txtTrayNo
        '
        Me.txtTrayNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTrayNo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrayNo.Location = New System.Drawing.Point(163, 60)
        Me.txtTrayNo.Name = "txtTrayNo"
        Me.txtTrayNo.Size = New System.Drawing.Size(189, 22)
        Me.txtTrayNo.TabIndex = 6
        '
        'txtRackLocation
        '
        Me.txtRackLocation.FormattingEnabled = True
        Me.txtRackLocation.Items.AddRange(New Object() {"1", "2", "3"})
        Me.txtRackLocation.Location = New System.Drawing.Point(165, 20)
        Me.txtRackLocation.Name = "txtRackLocation"
        Me.txtRackLocation.Size = New System.Drawing.Size(187, 23)
        Me.txtRackLocation.TabIndex = 1
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Blue
        Me.Label22.Location = New System.Drawing.Point(50, 87)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(47, 16)
        Me.Label22.TabIndex = 47
        Me.Label22.Text = "Power"
        '
        'CmbShPower
        '
        Me.CmbShPower.FormattingEnabled = True
        Me.CmbShPower.Items.AddRange(New Object() {"1", "2", "3"})
        Me.CmbShPower.Location = New System.Drawing.Point(165, 87)
        Me.CmbShPower.Name = "CmbShPower"
        Me.CmbShPower.Size = New System.Drawing.Size(137, 23)
        Me.CmbShPower.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(50, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 16)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Model"
        '
        'CmbShModel
        '
        Me.CmbShModel.FormattingEnabled = True
        Me.CmbShModel.Items.AddRange(New Object() {"1", "2", "3"})
        Me.CmbShModel.Location = New System.Drawing.Point(165, 50)
        Me.CmbShModel.Name = "CmbShModel"
        Me.CmbShModel.Size = New System.Drawing.Size(137, 23)
        Me.CmbShModel.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtstartqty)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(15, 493)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(788, 101)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(42, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 24)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Scan Lot Serial"
        '
        'txtstartqty
        '
        Me.txtstartqty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtstartqty.Font = New System.Drawing.Font("Times New Roman", 26.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstartqty.Location = New System.Drawing.Point(217, 30)
        Me.txtstartqty.Name = "txtstartqty"
        Me.txtstartqty.Size = New System.Drawing.Size(544, 48)
        Me.txtstartqty.TabIndex = 7
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Blue
        Me.Label20.Location = New System.Drawing.Point(48, 173)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(50, 16)
        Me.Label20.TabIndex = 42
        Me.Label20.Text = "Lot No"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Blue
        Me.Label18.Location = New System.Drawing.Point(48, 127)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 16)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "Lot Prefix"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LblShowExpDate)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.LblShowOptic)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.LblShowPower)
        Me.GroupBox3.Controls.Add(Me.LblshAConstant)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.LblShowMfdDate)
        Me.GroupBox3.Controls.Add(Me.LblShowLength)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.LblShowGSType)
        Me.GroupBox3.Controls.Add(Me.LblShowGSCode)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.LblShowRefName)
        Me.GroupBox3.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Red
        Me.GroupBox3.Location = New System.Drawing.Point(406, 179)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(397, 308)
        Me.GroupBox3.TabIndex = 66
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lens Details"
        '
        'LblShowExpDate
        '
        Me.LblShowExpDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.LblShowExpDate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowExpDate.Location = New System.Drawing.Point(173, 271)
        Me.LblShowExpDate.Name = "LblShowExpDate"
        Me.LblShowExpDate.Size = New System.Drawing.Size(71, 22)
        Me.LblShowExpDate.TabIndex = 73
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
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Blue
        Me.Label19.Location = New System.Drawing.Point(27, 271)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 16)
        Me.Label19.TabIndex = 72
        Me.Label19.Text = "Exp.Date"
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
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Blue
        Me.Label17.Location = New System.Drawing.Point(26, 247)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 16)
        Me.Label17.TabIndex = 70
        Me.Label17.Text = "Mfd.Date"
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
        'LblShowMfdDate
        '
        Me.LblShowMfdDate.AutoSize = True
        Me.LblShowMfdDate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowMfdDate.ForeColor = System.Drawing.Color.Navy
        Me.LblShowMfdDate.Location = New System.Drawing.Point(172, 251)
        Me.LblShowMfdDate.Name = "LblShowMfdDate"
        Me.LblShowMfdDate.Size = New System.Drawing.Size(54, 17)
        Me.LblShowMfdDate.TabIndex = 71
        Me.LblShowMfdDate.Text = "Lot_No"
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.txtlotno)
        Me.GroupBox4.Controls.Add(Me.CmbShPower)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtlotprefix)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.CmbShModel)
        Me.GroupBox4.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Red
        Me.GroupBox4.Location = New System.Drawing.Point(15, 279)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(385, 208)
        Me.GroupBox4.TabIndex = 67
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Lot Details"
        '
        'txtlotno
        '
        Me.txtlotno.FormattingEnabled = True
        Me.txtlotno.Items.AddRange(New Object() {"1", "2", "3"})
        Me.txtlotno.Location = New System.Drawing.Point(165, 164)
        Me.txtlotno.Name = "txtlotno"
        Me.txtlotno.Size = New System.Drawing.Size(137, 23)
        Me.txtlotno.TabIndex = 2
        '
        'txtlotprefix
        '
        Me.txtlotprefix.FormattingEnabled = True
        Me.txtlotprefix.Items.AddRange(New Object() {"1", "2", "3"})
        Me.txtlotprefix.Location = New System.Drawing.Point(165, 127)
        Me.txtlotprefix.Name = "txtlotprefix"
        Me.txtlotprefix.Size = New System.Drawing.Size(137, 23)
        Me.txtlotprefix.TabIndex = 1
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rdLotSerial)
        Me.GroupBox5.Controls.Add(Me.rdUDICode)
        Me.GroupBox5.Location = New System.Drawing.Point(15, 26)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(566, 83)
        Me.GroupBox5.TabIndex = 68
        Me.GroupBox5.TabStop = False
        '
        'rdLotSerial
        '
        Me.rdLotSerial.AutoSize = True
        Me.rdLotSerial.Checked = True
        Me.rdLotSerial.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdLotSerial.ForeColor = System.Drawing.Color.Red
        Me.rdLotSerial.Location = New System.Drawing.Point(165, 28)
        Me.rdLotSerial.Name = "rdLotSerial"
        Me.rdLotSerial.Size = New System.Drawing.Size(89, 19)
        Me.rdLotSerial.TabIndex = 72
        Me.rdLotSerial.TabStop = True
        Me.rdLotSerial.Text = "Lot Serial"
        Me.rdLotSerial.UseVisualStyleBackColor = True
        '
        'rdUDICode
        '
        Me.rdUDICode.AutoSize = True
        Me.rdUDICode.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdUDICode.ForeColor = System.Drawing.Color.Red
        Me.rdUDICode.Location = New System.Drawing.Point(21, 25)
        Me.rdUDICode.Name = "rdUDICode"
        Me.rdUDICode.Size = New System.Drawing.Size(93, 19)
        Me.rdUDICode.TabIndex = 71
        Me.rdUDICode.Text = "UDI Serial"
        Me.rdUDICode.UseVisualStyleBackColor = True
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rbExport)
        Me.GroupBox6.Controls.Add(Me.rbLocal)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.dtpMFDDate)
        Me.GroupBox6.Location = New System.Drawing.Point(15, 130)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(788, 43)
        Me.GroupBox6.TabIndex = 70
        Me.GroupBox6.TabStop = False
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
        'GRID2
        '
        Me.GRID2.AllowUserToDeleteRows = False
        Me.GRID2.BackgroundColor = System.Drawing.Color.White
        Me.GRID2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GRID2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.GRID2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Lot_SrNo, Me.Inward_No})
        Me.GRID2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GRID2.Location = New System.Drawing.Point(829, 174)
        Me.GRID2.Name = "GRID2"
        Me.GRID2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GRID2.Size = New System.Drawing.Size(247, 371)
        Me.GRID2.TabIndex = 72
        '
        'Lot_SrNo
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.Lot_SrNo.DefaultCellStyle = DataGridViewCellStyle1
        Me.Lot_SrNo.HeaderText = "Lot_SrNo"
        Me.Lot_SrNo.Name = "Lot_SrNo"
        Me.Lot_SrNo.Width = 200
        '
        'Inward_No
        '
        Me.Inward_No.HeaderText = "Inward_No"
        Me.Inward_No.Name = "Inward_No"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label7)
        Me.GroupBox7.Controls.Add(Me.lblcount)
        Me.GroupBox7.Location = New System.Drawing.Point(829, 57)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(109, 105)
        Me.GroupBox7.TabIndex = 73
        Me.GroupBox7.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(16, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Total Count"
        '
        'lblcount
        '
        Me.lblcount.AutoSize = True
        Me.lblcount.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcount.ForeColor = System.Drawing.Color.Red
        Me.lblcount.Location = New System.Drawing.Point(36, 53)
        Me.lblcount.Name = "lblcount"
        Me.lblcount.Size = New System.Drawing.Size(35, 40)
        Me.lblcount.TabIndex = 32
        Me.lblcount.Text = "0"
        '
        'BtnComplete
        '
        Me.BtnComplete.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnComplete.ForeColor = System.Drawing.Color.Red
        Me.BtnComplete.Location = New System.Drawing.Point(830, 567)
        Me.BtnComplete.Name = "BtnComplete"
        Me.BtnComplete.Size = New System.Drawing.Size(108, 42)
        Me.BtnComplete.TabIndex = 74
        Me.BtnComplete.Text = "Complete"
        Me.BtnComplete.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label4)
        Me.GroupBox8.Controls.Add(Me.lblScanedCount)
        Me.GroupBox8.Location = New System.Drawing.Point(967, 57)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(109, 105)
        Me.GroupBox8.TabIndex = 73
        Me.GroupBox8.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(12, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 16)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Scaned Lens"
        '
        'lblScanedCount
        '
        Me.lblScanedCount.AutoSize = True
        Me.lblScanedCount.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScanedCount.ForeColor = System.Drawing.Color.Red
        Me.lblScanedCount.Location = New System.Drawing.Point(36, 53)
        Me.lblScanedCount.Name = "lblScanedCount"
        Me.lblScanedCount.Size = New System.Drawing.Size(35, 40)
        Me.lblScanedCount.TabIndex = 32
        Me.lblScanedCount.Text = "0"
        '
        'PictureBox2
        '
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(1023, 1)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(41, 33)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 75
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(648, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Red
        Me.btnSave.Location = New System.Drawing.Point(968, 567)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(108, 42)
        Me.btnSave.TabIndex = 74
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'FrmNewStockValidation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1086, 630)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnComplete)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GRID2)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmNewStockValidation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents CmbShPower As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CmbShModel As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtstartqty As System.Windows.Forms.TextBox
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
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rdLotSerial As System.Windows.Forms.RadioButton
    Friend WithEvents rdUDICode As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTrayNo As System.Windows.Forms.TextBox
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents LblShowExpDate As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents LblShowMfdDate As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rbExport As System.Windows.Forms.RadioButton
    Friend WithEvents rbLocal As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpMFDDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GRID2 As System.Windows.Forms.DataGridView
    Friend WithEvents txtRackLocation As System.Windows.Forms.ComboBox
    Friend WithEvents txtlotno As System.Windows.Forms.ComboBox
    Friend WithEvents txtlotprefix As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblcount As System.Windows.Forms.Label
    Friend WithEvents Lot_SrNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnComplete As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblScanedCount As System.Windows.Forms.Label
    Friend WithEvents Inward_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
