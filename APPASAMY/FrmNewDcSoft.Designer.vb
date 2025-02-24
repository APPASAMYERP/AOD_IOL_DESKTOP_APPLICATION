<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewDcSoft
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
        Me.lblSterNo = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txttwodBarcode = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.CmbDclNo = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.CmbCusName = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.CmbMode = New System.Windows.Forms.ComboBox
        Me.txtremarks = New System.Windows.Forms.TextBox
        Me.txtindent = New System.Windows.Forms.TextBox
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblbgbox = New System.Windows.Forms.Label
        Me.lblsmbox = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.cbxdcno = New System.Windows.Forms.ComboBox
        Me.txtnoofsmbxinbbx = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtnoofbgbox = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtnooflens = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtnoofsmbox = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.cmbYourOrder = New System.Windows.Forms.ComboBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.LblScanBalanceQty = New System.Windows.Forms.Label
        Me.LblScancedQty = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblTotBplQty = New System.Windows.Forms.Label
        Me.GRID2 = New System.Windows.Forms.DataGridView
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.btnsave = New System.Windows.Forms.Button
        Me.BtnClear = New System.Windows.Forms.Button
        Me.BtnComplete = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.SerScaner = New System.IO.Ports.SerialPort(Me.components)
        Me.SerPLC = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rdbtold = New System.Windows.Forms.RadioButton
        Me.rdbtnew = New System.Windows.Forms.RadioButton
        Me.pgbcmp = New System.Windows.Forms.ProgressBar
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSterNo
        '
        Me.lblSterNo.AutoSize = True
        Me.lblSterNo.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSterNo.ForeColor = System.Drawing.Color.Blue
        Me.lblSterNo.Location = New System.Drawing.Point(137, 19)
        Me.lblSterNo.Name = "lblSterNo"
        Me.lblSterNo.Size = New System.Drawing.Size(88, 18)
        Me.lblSterNo.TabIndex = 30
        Me.lblSterNo.Text = "Lot No. "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(16, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 14)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "DC No"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txttwodBarcode)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.CmbDclNo)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 276)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(858, 70)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        '
        'txttwodBarcode
        '
        Me.txttwodBarcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttwodBarcode.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttwodBarcode.Location = New System.Drawing.Point(490, 29)
        Me.txttwodBarcode.Name = "txttwodBarcode"
        Me.txttwodBarcode.Size = New System.Drawing.Size(303, 22)
        Me.txttwodBarcode.TabIndex = 75
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(354, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 14)
        Me.Label11.TabIndex = 69
        Me.Label11.Text = "Scan 2D Barcod"
        '
        'CmbDclNo
        '
        Me.CmbDclNo.FormattingEnabled = True
        Me.CmbDclNo.Items.AddRange(New Object() {"1", "2", "3"})
        Me.CmbDclNo.Location = New System.Drawing.Point(80, 27)
        Me.CmbDclNo.Name = "CmbDclNo"
        Me.CmbDclNo.Size = New System.Drawing.Size(156, 21)
        Me.CmbDclNo.TabIndex = 66
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(14, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 14)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "DCL No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(10, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 14)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Address1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(10, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 14)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Customer Name"
        '
        'CmbCusName
        '
        Me.CmbCusName.FormattingEnabled = True
        Me.CmbCusName.Items.AddRange(New Object() {"1", "2", "3"})
        Me.CmbCusName.Location = New System.Drawing.Point(122, 48)
        Me.CmbCusName.Name = "CmbCusName"
        Me.CmbCusName.Size = New System.Drawing.Size(165, 22)
        Me.CmbCusName.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(330, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 14)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Dc Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(330, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 14)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Mode"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(330, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 14)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Remarks"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(330, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 14)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Indent No"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(410, 57)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(104, 20)
        Me.DateTimePicker1.TabIndex = 72
        '
        'CmbMode
        '
        Me.CmbMode.FormattingEnabled = True
        Me.CmbMode.Items.AddRange(New Object() {"Office Van", "By Courier"})
        Me.CmbMode.Location = New System.Drawing.Point(410, 84)
        Me.CmbMode.Name = "CmbMode"
        Me.CmbMode.Size = New System.Drawing.Size(104, 22)
        Me.CmbMode.TabIndex = 73
        '
        'txtremarks
        '
        Me.txtremarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtremarks.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtremarks.Location = New System.Drawing.Point(410, 113)
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.Size = New System.Drawing.Size(104, 22)
        Me.txtremarks.TabIndex = 74
        '
        'txtindent
        '
        Me.txtindent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtindent.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtindent.Location = New System.Drawing.Point(410, 28)
        Me.txtindent.Name = "txtindent"
        Me.txtindent.Size = New System.Drawing.Size(104, 22)
        Me.txtindent.TabIndex = 75
        '
        'txtaddress
        '
        Me.txtaddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtaddress.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(82, 79)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(233, 85)
        Me.txtaddress.TabIndex = 76
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblbgbox)
        Me.GroupBox1.Controls.Add(Me.lblsmbox)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.cbxdcno)
        Me.GroupBox1.Controls.Add(Me.txtnoofsmbxinbbx)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtnoofbgbox)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtnooflens)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtnoofsmbox)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cmbYourOrder)
        Me.GroupBox1.Controls.Add(Me.lblSterNo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtaddress)
        Me.GroupBox1.Controls.Add(Me.txtindent)
        Me.GroupBox1.Controls.Add(Me.txtremarks)
        Me.GroupBox1.Controls.Add(Me.CmbMode)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CmbCusName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(997, 195)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        '
        'lblbgbox
        '
        Me.lblbgbox.AutoSize = True
        Me.lblbgbox.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbgbox.ForeColor = System.Drawing.Color.Blue
        Me.lblbgbox.Location = New System.Drawing.Point(872, 162)
        Me.lblbgbox.Name = "lblbgbox"
        Me.lblbgbox.Size = New System.Drawing.Size(48, 14)
        Me.lblbgbox.TabIndex = 100
        Me.lblbgbox.Text = "Big Box"
        '
        'lblsmbox
        '
        Me.lblsmbox.AutoSize = True
        Me.lblsmbox.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsmbox.ForeColor = System.Drawing.Color.Blue
        Me.lblsmbox.Location = New System.Drawing.Point(650, 162)
        Me.lblsmbox.Name = "lblsmbox"
        Me.lblsmbox.Size = New System.Drawing.Size(64, 14)
        Me.lblsmbox.TabIndex = 99
        Me.lblsmbox.Text = "Small Box"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Blue
        Me.Label19.Location = New System.Drawing.Point(784, 162)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(48, 14)
        Me.Label19.TabIndex = 98
        Me.Label19.Text = "Big Box"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Blue
        Me.Label20.Location = New System.Drawing.Point(533, 161)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 14)
        Me.Label20.TabIndex = 97
        Me.Label20.Text = "Small Box"
        '
        'cbxdcno
        '
        Me.cbxdcno.FormattingEnabled = True
        Me.cbxdcno.Location = New System.Drawing.Point(122, 19)
        Me.cbxdcno.Name = "cbxdcno"
        Me.cbxdcno.Size = New System.Drawing.Size(148, 22)
        Me.cbxdcno.TabIndex = 96
        '
        'txtnoofsmbxinbbx
        '
        Me.txtnoofsmbxinbbx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnoofsmbxinbbx.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnoofsmbxinbbx.Location = New System.Drawing.Point(915, 104)
        Me.txtnoofsmbxinbbx.Name = "txtnoofsmbxinbbx"
        Me.txtnoofsmbxinbbx.Size = New System.Drawing.Size(56, 22)
        Me.txtnoofsmbxinbbx.TabIndex = 95
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Blue
        Me.Label17.Location = New System.Drawing.Point(739, 107)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(168, 14)
        Me.Label17.TabIndex = 94
        Me.Label17.Text = "No Of Small Boxes in Big Box"
        '
        'txtnoofbgbox
        '
        Me.txtnoofbgbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnoofbgbox.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnoofbgbox.Location = New System.Drawing.Point(653, 104)
        Me.txtnoofbgbox.Name = "txtnoofbgbox"
        Me.txtnoofbgbox.Size = New System.Drawing.Size(56, 22)
        Me.txtnoofbgbox.TabIndex = 93
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(533, 108)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 14)
        Me.Label15.TabIndex = 92
        Me.Label15.Text = "No Of Big Box"
        '
        'txtnooflens
        '
        Me.txtnooflens.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnooflens.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnooflens.Location = New System.Drawing.Point(915, 52)
        Me.txtnooflens.Name = "txtnooflens"
        Me.txtnooflens.Size = New System.Drawing.Size(53, 22)
        Me.txtnooflens.TabIndex = 91
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(737, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(142, 14)
        Me.Label13.TabIndex = 90
        Me.Label13.Text = "No Of Lens in Small Box"
        '
        'txtnoofsmbox
        '
        Me.txtnoofsmbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnoofsmbox.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnoofsmbox.Location = New System.Drawing.Point(653, 53)
        Me.txtnoofsmbox.Name = "txtnoofsmbox"
        Me.txtnoofsmbox.Size = New System.Drawing.Size(56, 22)
        Me.txtnoofsmbox.TabIndex = 89
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(533, 55)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 14)
        Me.Label16.TabIndex = 88
        Me.Label16.Text = "No Of Small Box"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(330, 145)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 14)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "Your Order"
        '
        'cmbYourOrder
        '
        Me.cmbYourOrder.FormattingEnabled = True
        Me.cmbYourOrder.Items.AddRange(New Object() {"Phone", "Email"})
        Me.cmbYourOrder.Location = New System.Drawing.Point(410, 142)
        Me.cmbYourOrder.Name = "cmbYourOrder"
        Me.cmbYourOrder.Size = New System.Drawing.Size(104, 22)
        Me.cmbYourOrder.TabIndex = 79
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.LblScanBalanceQty)
        Me.GroupBox6.Controls.Add(Me.LblScancedQty)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.lblTotBplQty)
        Me.GroupBox6.Controls.Add(Me.GRID2)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 352)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(855, 282)
        Me.GroupBox6.TabIndex = 63
        Me.GroupBox6.TabStop = False
        '
        'LblScanBalanceQty
        '
        Me.LblScanBalanceQty.AutoSize = True
        Me.LblScanBalanceQty.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblScanBalanceQty.ForeColor = System.Drawing.Color.Blue
        Me.LblScanBalanceQty.Location = New System.Drawing.Point(661, 240)
        Me.LblScanBalanceQty.Name = "LblScanBalanceQty"
        Me.LblScanBalanceQty.Size = New System.Drawing.Size(30, 31)
        Me.LblScanBalanceQty.TabIndex = 66
        Me.LblScanBalanceQty.Text = "0"
        '
        'LblScancedQty
        '
        Me.LblScancedQty.AutoSize = True
        Me.LblScancedQty.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblScancedQty.ForeColor = System.Drawing.Color.Blue
        Me.LblScancedQty.Location = New System.Drawing.Point(499, 240)
        Me.LblScancedQty.Name = "LblScancedQty"
        Me.LblScancedQty.Size = New System.Drawing.Size(30, 31)
        Me.LblScancedQty.TabIndex = 66
        Me.LblScancedQty.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(574, 245)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 16)
        Me.Label14.TabIndex = 65
        Me.Label14.Text = "Balance Qty"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Blue
        Me.Label18.Location = New System.Drawing.Point(384, 245)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 16)
        Me.Label18.TabIndex = 65
        Me.Label18.Text = "Total Sacned Qty"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(219, 245)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 16)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Total DCL Qty"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(150, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(348, 14)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "* Delete Row : Select Particular Row and click Delete Button  in keyboard"
        '
        'lblTotBplQty
        '
        Me.lblTotBplQty.AutoSize = True
        Me.lblTotBplQty.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotBplQty.ForeColor = System.Drawing.Color.Blue
        Me.lblTotBplQty.Location = New System.Drawing.Point(308, 240)
        Me.lblTotBplQty.Name = "lblTotBplQty"
        Me.lblTotBplQty.Size = New System.Drawing.Size(30, 31)
        Me.lblTotBplQty.TabIndex = 44
        Me.lblTotBplQty.Text = "0"
        '
        'GRID2
        '
        Me.GRID2.AllowUserToOrderColumns = True
        Me.GRID2.BackgroundColor = System.Drawing.Color.White
        Me.GRID2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GRID2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.GRID2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GRID2.Location = New System.Drawing.Point(104, 15)
        Me.GRID2.Name = "GRID2"
        Me.GRID2.Size = New System.Drawing.Size(632, 190)
        Me.GRID2.TabIndex = 42
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnsave)
        Me.GroupBox5.Controls.Add(Me.BtnClear)
        Me.GroupBox5.Controls.Add(Me.BtnComplete)
        Me.GroupBox5.Controls.Add(Me.BtnExit)
        Me.GroupBox5.Location = New System.Drawing.Point(881, 287)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(122, 347)
        Me.GroupBox5.TabIndex = 64
        Me.GroupBox5.TabStop = False
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.Red
        Me.btnsave.Location = New System.Drawing.Point(15, 29)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(94, 42)
        Me.btnsave.TabIndex = 22
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.Red
        Me.BtnClear.Location = New System.Drawing.Point(15, 201)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(94, 42)
        Me.BtnClear.TabIndex = 20
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnComplete
        '
        Me.BtnComplete.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnComplete.ForeColor = System.Drawing.Color.Red
        Me.BtnComplete.Location = New System.Drawing.Point(15, 112)
        Me.BtnComplete.Name = "BtnComplete"
        Me.BtnComplete.Size = New System.Drawing.Size(94, 42)
        Me.BtnComplete.TabIndex = 3
        Me.BtnComplete.Text = "Complete"
        Me.BtnComplete.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.Red
        Me.BtnExit.Location = New System.Drawing.Point(15, 284)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(94, 42)
        Me.BtnExit.TabIndex = 19
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'SerPLC
        '
        Me.SerPLC.DataBits = 7
        Me.SerPLC.Parity = System.IO.Ports.Parity.Even
        Me.SerPLC.PortName = "COM20"
        Me.SerPLC.StopBits = System.IO.Ports.StopBits.Two
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdbtold)
        Me.GroupBox3.Controls.Add(Me.rdbtnew)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Red
        Me.GroupBox3.Location = New System.Drawing.Point(9, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(994, 49)
        Me.GroupBox3.TabIndex = 66
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DC TYPE"
        '
        'rdbtold
        '
        Me.rdbtold.AutoSize = True
        Me.rdbtold.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbtold.ForeColor = System.Drawing.Color.Blue
        Me.rdbtold.Location = New System.Drawing.Point(434, 19)
        Me.rdbtold.Name = "rdbtold"
        Me.rdbtold.Size = New System.Drawing.Size(65, 17)
        Me.rdbtold.TabIndex = 1
        Me.rdbtold.TabStop = True
        Me.rdbtold.Text = "OLD DC"
        Me.rdbtold.UseVisualStyleBackColor = True
        '
        'rdbtnew
        '
        Me.rdbtnew.AutoSize = True
        Me.rdbtnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbtnew.ForeColor = System.Drawing.Color.Blue
        Me.rdbtnew.Location = New System.Drawing.Point(137, 19)
        Me.rdbtnew.Name = "rdbtnew"
        Me.rdbtnew.Size = New System.Drawing.Size(69, 17)
        Me.rdbtnew.TabIndex = 0
        Me.rdbtnew.TabStop = True
        Me.rdbtnew.Text = "NEW DC"
        Me.rdbtnew.UseVisualStyleBackColor = True
        '
        'pgbcmp
        '
        Me.pgbcmp.Location = New System.Drawing.Point(903, 654)
        Me.pgbcmp.Name = "pgbcmp"
        Me.pgbcmp.Size = New System.Drawing.Size(100, 23)
        Me.pgbcmp.TabIndex = 67
        '
        'FrmNewDcSoft
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1015, 689)
        Me.ControlBox = False
        Me.Controls.Add(Me.pgbcmp)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmNewDcSoft"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSterNo As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbDclNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmbCusName As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbMode As System.Windows.Forms.ComboBox
    Friend WithEvents txtremarks As System.Windows.Forms.TextBox
    Friend WithEvents txtindent As System.Windows.Forms.TextBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblTotBplQty As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GRID2 As System.Windows.Forms.DataGridView
    Friend WithEvents txttwodBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LblScanBalanceQty As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnComplete As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents LblScancedQty As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbYourOrder As System.Windows.Forms.ComboBox
    Friend WithEvents SerScaner As System.IO.Ports.SerialPort
    Friend WithEvents SerPLC As System.IO.Ports.SerialPort
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbtold As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnew As System.Windows.Forms.RadioButton
    Friend WithEvents txtnoofsmbxinbbx As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtnoofbgbox As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtnooflens As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtnoofsmbox As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents cbxdcno As System.Windows.Forms.ComboBox
    Friend WithEvents lblbgbox As System.Windows.Forms.Label
    Friend WithEvents lblsmbox As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents pgbcmp As System.Windows.Forms.ProgressBar
End Class
