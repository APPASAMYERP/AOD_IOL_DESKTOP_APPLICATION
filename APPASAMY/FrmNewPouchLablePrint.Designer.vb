<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewPouchLablePrint
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblShowLotPrefix = New System.Windows.Forms.Label
        Me.LblShowLotNo = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblShowMaxQty = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.LblShowPrintedQty = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.LblBalanceQty = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtquantity = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.CmbShModel = New System.Windows.Forms.ComboBox
        Me.CmbShBrand = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.LblShowLength = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.LblShowOptic = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.LblShowRefName = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.LblShowGSCode = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.BtnExit = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnClear = New System.Windows.Forms.Button
        Me.LblShowPower = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.LblShowGSType = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.LblshAConstant = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RdoRef = New System.Windows.Forms.RadioButton
        Me.rdobrand = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtcylsize = New System.Windows.Forms.TextBox
        Me.lblcylsz = New System.Windows.Forms.Label
        Me.txtrpwr = New System.Windows.Forms.TextBox
        Me.lblrpwr = New System.Windows.Forms.Label
        Me.txtbtc = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.CmbShPower = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.CmbShType = New System.Windows.Forms.ComboBox
        Me.LblShowExpDate = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.LblShowMfdDate = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.pnl = New System.Windows.Forms.GroupBox
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.CmbType = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.pnl.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(15, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Lot_Prefix"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(15, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Lot_No"
        '
        'LblShowLotPrefix
        '
        Me.LblShowLotPrefix.AutoSize = True
        Me.LblShowLotPrefix.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowLotPrefix.ForeColor = System.Drawing.Color.Navy
        Me.LblShowLotPrefix.Location = New System.Drawing.Point(126, 29)
        Me.LblShowLotPrefix.Name = "LblShowLotPrefix"
        Me.LblShowLotPrefix.Size = New System.Drawing.Size(72, 17)
        Me.LblShowLotPrefix.TabIndex = 26
        Me.LblShowLotPrefix.Text = "Lot_Prefix"
        '
        'LblShowLotNo
        '
        Me.LblShowLotNo.AutoSize = True
        Me.LblShowLotNo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowLotNo.ForeColor = System.Drawing.Color.Navy
        Me.LblShowLotNo.Location = New System.Drawing.Point(126, 66)
        Me.LblShowLotNo.Name = "LblShowLotNo"
        Me.LblShowLotNo.Size = New System.Drawing.Size(54, 17)
        Me.LblShowLotNo.TabIndex = 27
        Me.LblShowLotNo.Text = "Lot_No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(50, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "No.Of Lable"
        '
        'lblShowMaxQty
        '
        Me.lblShowMaxQty.AutoSize = True
        Me.lblShowMaxQty.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowMaxQty.ForeColor = System.Drawing.Color.Navy
        Me.lblShowMaxQty.Location = New System.Drawing.Point(345, 66)
        Me.lblShowMaxQty.Name = "lblShowMaxQty"
        Me.lblShowMaxQty.Size = New System.Drawing.Size(54, 17)
        Me.lblShowMaxQty.TabIndex = 30
        Me.lblShowMaxQty.Text = "Lot_No"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(234, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 16)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Max.Qty"
        '
        'LblShowPrintedQty
        '
        Me.LblShowPrintedQty.AutoSize = True
        Me.LblShowPrintedQty.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowPrintedQty.ForeColor = System.Drawing.Color.Navy
        Me.LblShowPrintedQty.Location = New System.Drawing.Point(345, 30)
        Me.LblShowPrintedQty.Name = "LblShowPrintedQty"
        Me.LblShowPrintedQty.Size = New System.Drawing.Size(54, 17)
        Me.LblShowPrintedQty.TabIndex = 32
        Me.LblShowPrintedQty.Text = "Lot_No"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(234, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 16)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Printed Qty"
        '
        'LblBalanceQty
        '
        Me.LblBalanceQty.AutoSize = True
        Me.LblBalanceQty.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBalanceQty.ForeColor = System.Drawing.Color.Navy
        Me.LblBalanceQty.Location = New System.Drawing.Point(563, 37)
        Me.LblBalanceQty.Name = "LblBalanceQty"
        Me.LblBalanceQty.Size = New System.Drawing.Size(35, 40)
        Me.LblBalanceQty.TabIndex = 34
        Me.LblBalanceQty.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(425, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 16)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Balance Qty"
        '
        'txtquantity
        '
        Me.txtquantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtquantity.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquantity.Location = New System.Drawing.Point(165, 260)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(138, 22)
        Me.txtquantity.TabIndex = 5
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
        'LblShowLength
        '
        Me.LblShowLength.AutoSize = True
        Me.LblShowLength.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowLength.ForeColor = System.Drawing.Color.Navy
        Me.LblShowLength.Location = New System.Drawing.Point(154, 158)
        Me.LblShowLength.Name = "LblShowLength"
        Me.LblShowLength.Size = New System.Drawing.Size(58, 17)
        Me.LblShowLength.TabIndex = 45
        Me.LblShowLength.Text = "Lot_No"
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
        'LblShowOptic
        '
        Me.LblShowOptic.AutoSize = True
        Me.LblShowOptic.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowOptic.ForeColor = System.Drawing.Color.Navy
        Me.LblShowOptic.Location = New System.Drawing.Point(154, 126)
        Me.LblShowOptic.Name = "LblShowOptic"
        Me.LblShowOptic.Size = New System.Drawing.Size(58, 17)
        Me.LblShowOptic.TabIndex = 43
        Me.LblShowOptic.Text = "Lot_No"
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
        'LblShowRefName
        '
        Me.LblShowRefName.AutoSize = True
        Me.LblShowRefName.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowRefName.ForeColor = System.Drawing.Color.Navy
        Me.LblShowRefName.Location = New System.Drawing.Point(154, 94)
        Me.LblShowRefName.Name = "LblShowRefName"
        Me.LblShowRefName.Size = New System.Drawing.Size(58, 17)
        Me.LblShowRefName.TabIndex = 41
        Me.LblShowRefName.Text = "Lot_No"
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
        'LblShowGSCode
        '
        Me.LblShowGSCode.AutoSize = True
        Me.LblShowGSCode.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowGSCode.ForeColor = System.Drawing.Color.Navy
        Me.LblShowGSCode.Location = New System.Drawing.Point(154, 30)
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
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.White
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.Red
        Me.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExit.Location = New System.Drawing.Point(466, 15)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(94, 32)
        Me.BtnExit.TabIndex = 50
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.White
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnSave.Location = New System.Drawing.Point(216, 15)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(94, 32)
        Me.BtnSave.TabIndex = 6
        Me.BtnSave.Text = " SAVE"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.White
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.Navy
        Me.BtnClear.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnClear.Location = New System.Drawing.Point(341, 15)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(94, 32)
        Me.BtnClear.TabIndex = 49
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'LblShowPower
        '
        Me.LblShowPower.AutoSize = True
        Me.LblShowPower.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowPower.ForeColor = System.Drawing.Color.Navy
        Me.LblShowPower.Location = New System.Drawing.Point(154, 62)
        Me.LblShowPower.Name = "LblShowPower"
        Me.LblShowPower.Size = New System.Drawing.Size(58, 17)
        Me.LblShowPower.TabIndex = 52
        Me.LblShowPower.Text = "Lot_No"
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
        'LblShowGSType
        '
        Me.LblShowGSType.AutoSize = True
        Me.LblShowGSType.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowGSType.ForeColor = System.Drawing.Color.Navy
        Me.LblShowGSType.Location = New System.Drawing.Point(154, 190)
        Me.LblShowGSType.Name = "LblShowGSType"
        Me.LblShowGSType.Size = New System.Drawing.Size(58, 17)
        Me.LblShowGSType.TabIndex = 54
        Me.LblShowGSType.Text = "Lot_No"
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
        'LblshAConstant
        '
        Me.LblshAConstant.AutoSize = True
        Me.LblshAConstant.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblshAConstant.ForeColor = System.Drawing.Color.Navy
        Me.LblshAConstant.Location = New System.Drawing.Point(154, 222)
        Me.LblshAConstant.Name = "LblshAConstant"
        Me.LblshAConstant.Size = New System.Drawing.Size(58, 17)
        Me.LblshAConstant.TabIndex = 56
        Me.LblshAConstant.Text = "Lot_No"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdoRef)
        Me.GroupBox1.Controls.Add(Me.rdobrand)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LblShowLotNo)
        Me.GroupBox1.Controls.Add(Me.LblShowLotPrefix)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblShowMaxQty)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.LblShowPrintedQty)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.LblBalanceQty)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(12, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(827, 87)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lot Details"
        '
        'RdoRef
        '
        Me.RdoRef.AutoSize = True
        Me.RdoRef.Location = New System.Drawing.Point(624, 66)
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
        Me.rdobrand.Location = New System.Drawing.Point(624, 30)
        Me.rdobrand.Name = "rdobrand"
        Me.rdobrand.Size = New System.Drawing.Size(107, 19)
        Me.rdobrand.TabIndex = 35
        Me.rdobrand.TabStop = True
        Me.rdobrand.Text = "Brand Name"
        Me.rdobrand.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtcylsize)
        Me.GroupBox2.Controls.Add(Me.lblcylsz)
        Me.GroupBox2.Controls.Add(Me.txtrpwr)
        Me.GroupBox2.Controls.Add(Me.lblrpwr)
        Me.GroupBox2.Controls.Add(Me.txtbtc)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.CmbShPower)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.CmbShType)
        Me.GroupBox2.Controls.Add(Me.LblShowExpDate)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.LblShowMfdDate)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.CmbShModel)
        Me.GroupBox2.Controls.Add(Me.CmbShBrand)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtquantity)
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(12, 132)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(477, 292)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Details"
        '
        'txtcylsize
        '
        Me.txtcylsize.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcylsize.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcylsize.Location = New System.Drawing.Point(386, 203)
        Me.txtcylsize.Name = "txtcylsize"
        Me.txtcylsize.Size = New System.Drawing.Size(71, 22)
        Me.txtcylsize.TabIndex = 56
        '
        'lblcylsz
        '
        Me.lblcylsz.AutoSize = True
        Me.lblcylsz.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcylsz.ForeColor = System.Drawing.Color.Blue
        Me.lblcylsz.Location = New System.Drawing.Point(323, 206)
        Me.lblcylsz.Name = "lblcylsz"
        Me.lblcylsz.Size = New System.Drawing.Size(57, 16)
        Me.lblcylsz.TabIndex = 55
        Me.lblcylsz.Text = "Adl/Cyl"
        '
        'txtrpwr
        '
        Me.txtrpwr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtrpwr.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrpwr.Location = New System.Drawing.Point(386, 176)
        Me.txtrpwr.Name = "txtrpwr"
        Me.txtrpwr.Size = New System.Drawing.Size(71, 22)
        Me.txtrpwr.TabIndex = 54
        '
        'lblrpwr
        '
        Me.lblrpwr.AutoSize = True
        Me.lblrpwr.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrpwr.ForeColor = System.Drawing.Color.Blue
        Me.lblrpwr.Location = New System.Drawing.Point(323, 179)
        Me.lblrpwr.Name = "lblrpwr"
        Me.lblrpwr.Size = New System.Drawing.Size(61, 16)
        Me.lblrpwr.TabIndex = 53
        Me.lblrpwr.Text = "A.Power"
        '
        'txtbtc
        '
        Me.txtbtc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbtc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbtc.Location = New System.Drawing.Point(164, 230)
        Me.txtbtc.Name = "txtbtc"
        Me.txtbtc.Size = New System.Drawing.Size(138, 22)
        Me.txtbtc.TabIndex = 49
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Blue
        Me.Label18.Location = New System.Drawing.Point(50, 233)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 16)
        Me.Label18.TabIndex = 48
        Me.Label18.Text = "BatchNo"
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
        'LblShowExpDate
        '
        Me.LblShowExpDate.AutoSize = True
        Me.LblShowExpDate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowExpDate.ForeColor = System.Drawing.Color.Navy
        Me.LblShowExpDate.Location = New System.Drawing.Point(165, 209)
        Me.LblShowExpDate.Name = "LblShowExpDate"
        Me.LblShowExpDate.Size = New System.Drawing.Size(54, 17)
        Me.LblShowExpDate.TabIndex = 43
        Me.LblShowExpDate.Text = "Lot_No"
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
        Me.LblShowMfdDate.Location = New System.Drawing.Point(164, 178)
        Me.LblShowMfdDate.Name = "LblShowMfdDate"
        Me.LblShowMfdDate.Size = New System.Drawing.Size(54, 17)
        Me.LblShowMfdDate.TabIndex = 41
        Me.LblShowMfdDate.Text = "Lot_No"
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
        Me.GroupBox3.Location = New System.Drawing.Point(495, 133)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(345, 292)
        Me.GroupBox3.TabIndex = 59
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lens Details"
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.BtnClear)
        Me.pnl.Controls.Add(Me.BtnSave)
        Me.pnl.Controls.Add(Me.BtnExit)
        Me.pnl.Location = New System.Drawing.Point(13, 424)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(826, 69)
        Me.pnl.TabIndex = 60
        Me.pnl.TabStop = False
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.CmbType)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 1)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(827, 43)
        Me.GroupBox4.TabIndex = 61
        Me.GroupBox4.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(256, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 16)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Type"
        '
        'CmbType
        '
        Me.CmbType.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbType.ForeColor = System.Drawing.Color.Red
        Me.CmbType.FormattingEnabled = True
        Me.CmbType.Items.AddRange(New Object() {"1", "2", "3"})
        Me.CmbType.Location = New System.Drawing.Point(371, 11)
        Me.CmbType.Name = "CmbType"
        Me.CmbType.Size = New System.Drawing.Size(164, 26)
        Me.CmbType.TabIndex = 0
        '
        'FrmNewPouchLablePrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(852, 510)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmNewPouchLablePrint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.pnl.ResumeLayout(False)
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblShowLotPrefix As System.Windows.Forms.Label
    Friend WithEvents LblShowLotNo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblShowMaxQty As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblShowPrintedQty As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LblBalanceQty As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtquantity As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmbShModel As System.Windows.Forms.ComboBox
    Friend WithEvents CmbShBrand As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblShowLength As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LblShowOptic As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LblShowRefName As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LblShowGSCode As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents LblShowPower As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LblShowGSType As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LblshAConstant As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents pnl As System.Windows.Forms.GroupBox
    Friend WithEvents LblShowExpDate As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents LblShowMfdDate As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents CmbShType As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents CmbShPower As System.Windows.Forms.ComboBox
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents rdobrand As System.Windows.Forms.RadioButton
    Friend WithEvents RdoRef As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CmbType As System.Windows.Forms.ComboBox
    Friend WithEvents txtbtc As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtcylsize As System.Windows.Forms.TextBox
    Friend WithEvents lblcylsz As System.Windows.Forms.Label
    Friend WithEvents txtrpwr As System.Windows.Forms.TextBox
    Friend WithEvents lblrpwr As System.Windows.Forms.Label
End Class
