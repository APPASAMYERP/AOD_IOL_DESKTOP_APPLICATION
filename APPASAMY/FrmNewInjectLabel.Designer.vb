<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewInjectLabel
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblShowLotNo = New System.Windows.Forms.Label
        Me.LblShowLotPrefix = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblShowMaxQty = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.LblShowPrintedQty = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.LblBalanceQty = New System.Windows.Forms.Label
        Me.rdoInt = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtbatno = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.CmbShModel = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtquantity = New System.Windows.Forms.TextBox
        Me.BtnClear = New System.Windows.Forms.Button
        Me.pnl = New System.Windows.Forms.GroupBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblTypeGSCode = New System.Windows.Forms.Label
        Me.lblModel = New System.Windows.Forms.Label
        Me.lblExp = New System.Windows.Forms.Label
        Me.lblMfd = New System.Windows.Forms.Label
        Me.lblGsCode = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmbPrintLabel = New System.Windows.Forms.ComboBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.typegs1 = New System.Windows.Forms.ComboBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.rdBig = New System.Windows.Forms.RadioButton
        Me.rdSmall = New System.Windows.Forms.RadioButton
        Me.rdosupra = New System.Windows.Forms.RadioButton
        Me.RdoExportturkey = New System.Windows.Forms.RadioButton
        Me.RdoIntBIg = New System.Windows.Forms.RadioButton
        Me.RdoInA = New System.Windows.Forms.RadioButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.CmbType = New System.Windows.Forms.ComboBox
        Me.Chkreprint = New System.Windows.Forms.CheckBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.cmbBatch = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtReprintQty = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.cmbLotNo = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.pnl.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Location = New System.Drawing.Point(29, 86)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(912, 114)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lot Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(20, 36)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Lot_Prefix"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(20, 81)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Lot_No"
        '
        'LblShowLotNo
        '
        Me.LblShowLotNo.AutoSize = True
        Me.LblShowLotNo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowLotNo.ForeColor = System.Drawing.Color.Navy
        Me.LblShowLotNo.Location = New System.Drawing.Point(168, 81)
        Me.LblShowLotNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblShowLotNo.Name = "LblShowLotNo"
        Me.LblShowLotNo.Size = New System.Drawing.Size(69, 21)
        Me.LblShowLotNo.TabIndex = 27
        Me.LblShowLotNo.Text = "Lot_No"
        '
        'LblShowLotPrefix
        '
        Me.LblShowLotPrefix.AutoSize = True
        Me.LblShowLotPrefix.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowLotPrefix.ForeColor = System.Drawing.Color.Navy
        Me.LblShowLotPrefix.Location = New System.Drawing.Point(168, 36)
        Me.LblShowLotPrefix.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblShowLotPrefix.Name = "LblShowLotPrefix"
        Me.LblShowLotPrefix.Size = New System.Drawing.Size(90, 21)
        Me.LblShowLotPrefix.TabIndex = 26
        Me.LblShowLotPrefix.Text = "Lot_Prefix"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(312, 81)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 20)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Max.Qty"
        '
        'lblShowMaxQty
        '
        Me.lblShowMaxQty.AutoSize = True
        Me.lblShowMaxQty.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowMaxQty.ForeColor = System.Drawing.Color.Navy
        Me.lblShowMaxQty.Location = New System.Drawing.Point(460, 81)
        Me.lblShowMaxQty.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblShowMaxQty.Name = "lblShowMaxQty"
        Me.lblShowMaxQty.Size = New System.Drawing.Size(69, 21)
        Me.lblShowMaxQty.TabIndex = 30
        Me.lblShowMaxQty.Text = "Lot_No"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(312, 37)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 20)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Printed Qty"
        '
        'LblShowPrintedQty
        '
        Me.LblShowPrintedQty.AutoSize = True
        Me.LblShowPrintedQty.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowPrintedQty.ForeColor = System.Drawing.Color.Navy
        Me.LblShowPrintedQty.Location = New System.Drawing.Point(460, 37)
        Me.LblShowPrintedQty.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblShowPrintedQty.Name = "LblShowPrintedQty"
        Me.LblShowPrintedQty.Size = New System.Drawing.Size(69, 21)
        Me.LblShowPrintedQty.TabIndex = 32
        Me.LblShowPrintedQty.Text = "Lot_No"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(567, 63)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 20)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Balance Qty"
        '
        'LblBalanceQty
        '
        Me.LblBalanceQty.AutoSize = True
        Me.LblBalanceQty.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBalanceQty.ForeColor = System.Drawing.Color.Navy
        Me.LblBalanceQty.Location = New System.Drawing.Point(751, 46)
        Me.LblBalanceQty.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblBalanceQty.Name = "LblBalanceQty"
        Me.LblBalanceQty.Size = New System.Drawing.Size(44, 51)
        Me.LblBalanceQty.TabIndex = 34
        Me.LblBalanceQty.Text = "0"
        '
        'rdoInt
        '
        Me.rdoInt.AutoSize = True
        Me.rdoInt.Checked = True
        Me.rdoInt.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoInt.ForeColor = System.Drawing.Color.Red
        Me.rdoInt.Location = New System.Drawing.Point(5, 23)
        Me.rdoInt.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoInt.Name = "rdoInt"
        Me.rdoInt.Size = New System.Drawing.Size(130, 24)
        Me.rdoInt.TabIndex = 35
        Me.rdoInt.TabStop = True
        Me.rdoInt.Text = "Injet Label"
        Me.rdoInt.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtbatno)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.CmbShModel)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtquantity)
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(31, 332)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(464, 220)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(67, 108)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 20)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Batch No"
        '
        'txtbatno
        '
        Me.txtbatno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbatno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbatno.Location = New System.Drawing.Point(220, 106)
        Me.txtbatno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbatno.Name = "txtbatno"
        Me.txtbatno.Size = New System.Drawing.Size(183, 26)
        Me.txtbatno.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(67, 39)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 20)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Model"
        '
        'CmbShModel
        '
        Me.CmbShModel.FormattingEnabled = True
        Me.CmbShModel.Items.AddRange(New Object() {"DIS-1.0", "DIS-1.8", "DIS-2.0", "DIS-2.2", "DIS-2.8", "DIS-3.0"})
        Me.CmbShModel.Location = New System.Drawing.Point(220, 37)
        Me.CmbShModel.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbShModel.Name = "CmbShModel"
        Me.CmbShModel.Size = New System.Drawing.Size(181, 26)
        Me.CmbShModel.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(67, 175)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "No.Of Lable"
        '
        'txtquantity
        '
        Me.txtquantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtquantity.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquantity.Location = New System.Drawing.Point(220, 172)
        Me.txtquantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(183, 26)
        Me.txtquantity.TabIndex = 5
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.White
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.Navy
        Me.BtnClear.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnClear.Location = New System.Drawing.Point(359, 35)
        Me.BtnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(125, 39)
        Me.BtnClear.TabIndex = 49
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.Label17)
        Me.pnl.Controls.Add(Me.Label13)
        Me.pnl.Controls.Add(Me.Label16)
        Me.pnl.Controls.Add(Me.Label14)
        Me.pnl.Controls.Add(Me.Label12)
        Me.pnl.Controls.Add(Me.lblTypeGSCode)
        Me.pnl.Controls.Add(Me.lblModel)
        Me.pnl.Controls.Add(Me.lblExp)
        Me.pnl.Controls.Add(Me.lblMfd)
        Me.pnl.Controls.Add(Me.lblGsCode)
        Me.pnl.Location = New System.Drawing.Point(503, 332)
        Me.pnl.Margin = New System.Windows.Forms.Padding(4)
        Me.pnl.Name = "pnl"
        Me.pnl.Padding = New System.Windows.Forms.Padding(4)
        Me.pnl.Size = New System.Drawing.Size(438, 220)
        Me.pnl.TabIndex = 65
        Me.pnl.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Blue
        Me.Label17.Location = New System.Drawing.Point(20, 186)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 20)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Type_GS_Code"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(20, 152)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 20)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Model"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(20, 111)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 20)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Exp_Date"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(20, 66)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 20)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Mfd_Date"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(18, 19)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 20)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "GS_Code"
        '
        'lblTypeGSCode
        '
        Me.lblTypeGSCode.AutoSize = True
        Me.lblTypeGSCode.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypeGSCode.ForeColor = System.Drawing.Color.Navy
        Me.lblTypeGSCode.Location = New System.Drawing.Point(159, 186)
        Me.lblTypeGSCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTypeGSCode.Name = "lblTypeGSCode"
        Me.lblTypeGSCode.Size = New System.Drawing.Size(134, 21)
        Me.lblTypeGSCode.TabIndex = 26
        Me.lblTypeGSCode.Text = "Type_GS_Code"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.ForeColor = System.Drawing.Color.Navy
        Me.lblModel.Location = New System.Drawing.Point(159, 152)
        Me.lblModel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(58, 21)
        Me.lblModel.TabIndex = 26
        Me.lblModel.Text = "Model"
        '
        'lblExp
        '
        Me.lblExp.AutoSize = True
        Me.lblExp.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExp.ForeColor = System.Drawing.Color.Navy
        Me.lblExp.Location = New System.Drawing.Point(159, 111)
        Me.lblExp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExp.Name = "lblExp"
        Me.lblExp.Size = New System.Drawing.Size(84, 21)
        Me.lblExp.TabIndex = 26
        Me.lblExp.Text = "Exp_Date"
        '
        'lblMfd
        '
        Me.lblMfd.AutoSize = True
        Me.lblMfd.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMfd.ForeColor = System.Drawing.Color.Navy
        Me.lblMfd.Location = New System.Drawing.Point(159, 66)
        Me.lblMfd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMfd.Name = "lblMfd"
        Me.lblMfd.Size = New System.Drawing.Size(86, 21)
        Me.lblMfd.TabIndex = 26
        Me.lblMfd.Text = "Mfd_Date"
        '
        'lblGsCode
        '
        Me.lblGsCode.AutoSize = True
        Me.lblGsCode.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGsCode.ForeColor = System.Drawing.Color.Navy
        Me.lblGsCode.Location = New System.Drawing.Point(157, 19)
        Me.lblGsCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGsCode.Name = "lblGsCode"
        Me.lblGsCode.Size = New System.Drawing.Size(86, 21)
        Me.lblGsCode.TabIndex = 26
        Me.lblGsCode.Text = "GS_Code"
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.White
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnSave.Location = New System.Drawing.Point(71, 35)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(125, 39)
        Me.BtnSave.TabIndex = 6
        Me.BtnSave.Text = " SAVE"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.White
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.Red
        Me.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExit.Location = New System.Drawing.Point(635, 35)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(125, 39)
        Me.BtnExit.TabIndex = 50
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbPrintLabel)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.typegs1)
        Me.GroupBox3.Location = New System.Drawing.Point(31, 202)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(518, 123)
        Me.GroupBox3.TabIndex = 66
        Me.GroupBox3.TabStop = False
        '
        'cmbPrintLabel
        '
        Me.cmbPrintLabel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPrintLabel.ForeColor = System.Drawing.Color.Red
        Me.cmbPrintLabel.FormattingEnabled = True
        Me.cmbPrintLabel.Location = New System.Drawing.Point(122, 23)
        Me.cmbPrintLabel.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPrintLabel.Name = "cmbPrintLabel"
        Me.cmbPrintLabel.Size = New System.Drawing.Size(332, 32)
        Me.cmbPrintLabel.TabIndex = 70
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Blue
        Me.Label26.Location = New System.Drawing.Point(53, 29)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(42, 17)
        Me.Label26.TabIndex = 69
        Me.Label26.Text = "Label"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(51, 78)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 20)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Type GS Code"
        '
        'typegs1
        '
        Me.typegs1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typegs1.ForeColor = System.Drawing.Color.Red
        Me.typegs1.FormattingEnabled = True
        Me.typegs1.Items.AddRange(New Object() {"AOD", "AI", "TURKEY"})
        Me.typegs1.Location = New System.Drawing.Point(172, 71)
        Me.typegs1.Margin = New System.Windows.Forms.Padding(4)
        Me.typegs1.Name = "typegs1"
        Me.typegs1.Size = New System.Drawing.Size(283, 32)
        Me.typegs1.TabIndex = 42
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rdBig)
        Me.GroupBox5.Controls.Add(Me.rdSmall)
        Me.GroupBox5.Location = New System.Drawing.Point(39, 685)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(377, 64)
        Me.GroupBox5.TabIndex = 44
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Visible = False
        '
        'rdBig
        '
        Me.rdBig.AutoSize = True
        Me.rdBig.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdBig.ForeColor = System.Drawing.Color.Red
        Me.rdBig.Location = New System.Drawing.Point(231, 21)
        Me.rdBig.Margin = New System.Windows.Forms.Padding(4)
        Me.rdBig.Name = "rdBig"
        Me.rdBig.Size = New System.Drawing.Size(59, 24)
        Me.rdBig.TabIndex = 40
        Me.rdBig.Text = "Big"
        Me.rdBig.UseVisualStyleBackColor = True
        '
        'rdSmall
        '
        Me.rdSmall.AutoSize = True
        Me.rdSmall.Checked = True
        Me.rdSmall.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdSmall.ForeColor = System.Drawing.Color.Red
        Me.rdSmall.Location = New System.Drawing.Point(41, 20)
        Me.rdSmall.Margin = New System.Windows.Forms.Padding(4)
        Me.rdSmall.Name = "rdSmall"
        Me.rdSmall.Size = New System.Drawing.Size(81, 24)
        Me.rdSmall.TabIndex = 40
        Me.rdSmall.TabStop = True
        Me.rdSmall.Text = "Small"
        Me.rdSmall.UseVisualStyleBackColor = True
        '
        'rdosupra
        '
        Me.rdosupra.AutoSize = True
        Me.rdosupra.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdosupra.ForeColor = System.Drawing.Color.Red
        Me.rdosupra.Location = New System.Drawing.Point(270, 55)
        Me.rdosupra.Margin = New System.Windows.Forms.Padding(4)
        Me.rdosupra.Name = "rdosupra"
        Me.rdosupra.Size = New System.Drawing.Size(133, 24)
        Me.rdosupra.TabIndex = 40
        Me.rdosupra.Text = "Injet supra"
        Me.rdosupra.UseVisualStyleBackColor = True
        '
        'RdoExportturkey
        '
        Me.RdoExportturkey.AutoSize = True
        Me.RdoExportturkey.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoExportturkey.ForeColor = System.Drawing.Color.Red
        Me.RdoExportturkey.Location = New System.Drawing.Point(103, 55)
        Me.RdoExportturkey.Margin = New System.Windows.Forms.Padding(4)
        Me.RdoExportturkey.Name = "RdoExportturkey"
        Me.RdoExportturkey.Size = New System.Drawing.Size(144, 24)
        Me.RdoExportturkey.TabIndex = 39
        Me.RdoExportturkey.Text = "Injet Turkey"
        Me.RdoExportturkey.UseVisualStyleBackColor = True
        '
        'RdoIntBIg
        '
        Me.RdoIntBIg.AutoSize = True
        Me.RdoIntBIg.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoIntBIg.ForeColor = System.Drawing.Color.Red
        Me.RdoIntBIg.Location = New System.Drawing.Point(331, 23)
        Me.RdoIntBIg.Margin = New System.Windows.Forms.Padding(4)
        Me.RdoIntBIg.Name = "RdoIntBIg"
        Me.RdoIntBIg.Size = New System.Drawing.Size(190, 24)
        Me.RdoIntBIg.TabIndex = 38
        Me.RdoIntBIg.Text = "Injet Single Lable"
        Me.RdoIntBIg.UseVisualStyleBackColor = True
        '
        'RdoInA
        '
        Me.RdoInA.AutoSize = True
        Me.RdoInA.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoInA.ForeColor = System.Drawing.Color.Red
        Me.RdoInA.Location = New System.Drawing.Point(153, 23)
        Me.RdoInA.Margin = New System.Windows.Forms.Padding(4)
        Me.RdoInA.Name = "RdoInA"
        Me.RdoInA.Size = New System.Drawing.Size(157, 24)
        Me.RdoInA.TabIndex = 36
        Me.RdoInA.Text = "Injet Label - A"
        Me.RdoInA.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.CmbType)
        Me.GroupBox4.Location = New System.Drawing.Point(31, 30)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(621, 59)
        Me.GroupBox4.TabIndex = 67
        Me.GroupBox4.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(129, 22)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 20)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Type"
        '
        'CmbType
        '
        Me.CmbType.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbType.ForeColor = System.Drawing.Color.Red
        Me.CmbType.FormattingEnabled = True
        Me.CmbType.Items.AddRange(New Object() {"1", "2", "3"})
        Me.CmbType.Location = New System.Drawing.Point(189, 16)
        Me.CmbType.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbType.Name = "CmbType"
        Me.CmbType.Size = New System.Drawing.Size(217, 32)
        Me.CmbType.TabIndex = 0
        '
        'Chkreprint
        '
        Me.Chkreprint.AutoSize = True
        Me.Chkreprint.Location = New System.Drawing.Point(715, 52)
        Me.Chkreprint.Margin = New System.Windows.Forms.Padding(4)
        Me.Chkreprint.Name = "Chkreprint"
        Me.Chkreprint.Size = New System.Drawing.Size(109, 21)
        Me.Chkreprint.TabIndex = 42
        Me.Chkreprint.Text = "Chk Re-print"
        Me.Chkreprint.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.BtnExit)
        Me.GroupBox6.Controls.Add(Me.BtnClear)
        Me.GroupBox6.Controls.Add(Me.BtnSave)
        Me.GroupBox6.Location = New System.Drawing.Point(31, 578)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(910, 100)
        Me.GroupBox6.TabIndex = 68
        Me.GroupBox6.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.rdosupra)
        Me.GroupBox7.Controls.Add(Me.rdoInt)
        Me.GroupBox7.Controls.Add(Me.RdoInA)
        Me.GroupBox7.Controls.Add(Me.RdoExportturkey)
        Me.GroupBox7.Controls.Add(Me.RdoIntBIg)
        Me.GroupBox7.Location = New System.Drawing.Point(423, 685)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(529, 97)
        Me.GroupBox7.TabIndex = 44
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "GroupBox7"
        Me.GroupBox7.Visible = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.cmbLotNo)
        Me.GroupBox8.Controls.Add(Me.Label18)
        Me.GroupBox8.Controls.Add(Me.cmbBatch)
        Me.GroupBox8.Controls.Add(Me.Label11)
        Me.GroupBox8.Controls.Add(Me.txtReprintQty)
        Me.GroupBox8.Controls.Add(Me.Label15)
        Me.GroupBox8.Location = New System.Drawing.Point(576, 207)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(365, 118)
        Me.GroupBox8.TabIndex = 69
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Visible = False
        '
        'cmbBatch
        '
        Me.cmbBatch.FormattingEnabled = True
        Me.cmbBatch.Location = New System.Drawing.Point(141, 14)
        Me.cmbBatch.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbBatch.Name = "cmbBatch"
        Me.cmbBatch.Size = New System.Drawing.Size(181, 24)
        Me.cmbBatch.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(25, 16)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 20)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Batch No"
        '
        'txtReprintQty
        '
        Me.txtReprintQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReprintQty.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReprintQty.Location = New System.Drawing.Point(141, 83)
        Me.txtReprintQty.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReprintQty.Name = "txtReprintQty"
        Me.txtReprintQty.Size = New System.Drawing.Size(183, 26)
        Me.txtReprintQty.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(25, 86)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 20)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "No.Of Lable"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Blue
        Me.Label18.Location = New System.Drawing.Point(28, 48)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 20)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "Lot No"
        '
        'cmbLotNo
        '
        Me.cmbLotNo.FormattingEnabled = True
        Me.cmbLotNo.Location = New System.Drawing.Point(144, 46)
        Me.cmbLotNo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbLotNo.Name = "cmbLotNo"
        Me.cmbLotNo.Size = New System.Drawing.Size(181, 24)
        Me.cmbLotNo.TabIndex = 1
        '
        'FrmNewInjectLabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1067, 866)
        Me.ControlBox = False
        Me.Controls.Add(Me.Chkreprint)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.pnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmNewInjectLabel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoInt As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblShowLotNo As System.Windows.Forms.Label
    Friend WithEvents LblShowLotPrefix As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblShowMaxQty As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LblShowPrintedQty As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LblBalanceQty As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtquantity As System.Windows.Forms.TextBox
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents pnl As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtbatno As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CmbShModel As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RdoIntBIg As System.Windows.Forms.RadioButton
    Friend WithEvents RdoInA As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CmbType As System.Windows.Forms.ComboBox
    Friend WithEvents RdoExportturkey As System.Windows.Forms.RadioButton
    Friend WithEvents rdosupra As System.Windows.Forms.RadioButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents typegs1 As System.Windows.Forms.ComboBox
    Friend WithEvents Chkreprint As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rdBig As System.Windows.Forms.RadioButton
    Friend WithEvents rdSmall As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblExp As System.Windows.Forms.Label
    Friend WithEvents lblMfd As System.Windows.Forms.Label
    Friend WithEvents lblGsCode As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblModel As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbPrintLabel As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbBatch As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblTypeGSCode As System.Windows.Forms.Label
    Friend WithEvents txtReprintQty As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbLotNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
End Class
