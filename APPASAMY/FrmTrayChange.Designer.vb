<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTrayChange
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTrayChange))
        Me.txtlotbarno = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GRID2 = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnClear = New System.Windows.Forms.Button
        Me.BtnComplete = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblcount = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rdLotSerial = New System.Windows.Forms.RadioButton
        Me.rdUDICode = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GroupBox11 = New System.Windows.Forms.GroupBox
        Me.toTrayGRID2 = New System.Windows.Forms.DataGridView
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblToTrayCount = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.rdTrayBased = New System.Windows.Forms.RadioButton
        Me.rdSerialBased = New System.Windows.Forms.RadioButton
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbltoTrayCount1 = New System.Windows.Forms.Label
        Me.lblcount1 = New System.Windows.Forms.Label
        Me.toTrayGRID1 = New System.Windows.Forms.DataGridView
        Me.GRID1 = New System.Windows.Forms.DataGridView
        Me.cmbTrayTo_TrayBased = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbTrayFrom_TrayBased = New System.Windows.Forms.ComboBox
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnComplete_trayBased = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblTrayNo = New System.Windows.Forms.Label
        Me.cmbTrayNo = New System.Windows.Forms.ComboBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        CType(Me.toTrayGRID2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.toTrayGRID1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRID1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox10.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtlotbarno
        '
        Me.txtlotbarno.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlotbarno.Location = New System.Drawing.Point(179, 24)
        Me.txtlotbarno.Name = "txtlotbarno"
        Me.txtlotbarno.Size = New System.Drawing.Size(317, 48)
        Me.txtlotbarno.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(10, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 29)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Scan Lot No"
        '
        'GRID2
        '
        Me.GRID2.AllowUserToDeleteRows = False
        Me.GRID2.BackgroundColor = System.Drawing.Color.White
        Me.GRID2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GRID2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.GRID2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GRID2.Location = New System.Drawing.Point(6, 18)
        Me.GRID2.Name = "GRID2"
        Me.GRID2.Size = New System.Drawing.Size(329, 299)
        Me.GRID2.TabIndex = 45
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnClear)
        Me.GroupBox2.Controls.Add(Me.BtnComplete)
        Me.GroupBox2.Controls.Add(Me.BtnExit)
        Me.GroupBox2.Location = New System.Drawing.Point(35, 204)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(519, 91)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.Red
        Me.BtnClear.Location = New System.Drawing.Point(199, 28)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(108, 42)
        Me.BtnClear.TabIndex = 20
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnComplete
        '
        Me.BtnComplete.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnComplete.ForeColor = System.Drawing.Color.Red
        Me.BtnComplete.Location = New System.Drawing.Point(18, 28)
        Me.BtnComplete.Name = "BtnComplete"
        Me.BtnComplete.Size = New System.Drawing.Size(108, 42)
        Me.BtnComplete.TabIndex = 3
        Me.BtnComplete.Text = "Complete"
        Me.BtnComplete.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.Red
        Me.BtnExit.Location = New System.Drawing.Point(380, 28)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(108, 42)
        Me.BtnExit.TabIndex = 19
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label7)
        Me.GroupBox8.Controls.Add(Me.lblcount)
        Me.GroupBox8.Location = New System.Drawing.Point(773, 17)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(154, 89)
        Me.GroupBox8.TabIndex = 68
        Me.GroupBox8.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(39, 15)
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
        Me.lblcount.Location = New System.Drawing.Point(59, 37)
        Me.lblcount.Name = "lblcount"
        Me.lblcount.Size = New System.Drawing.Size(35, 40)
        Me.lblcount.TabIndex = 32
        Me.lblcount.Text = "0"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdLotSerial)
        Me.GroupBox3.Controls.Add(Me.rdUDICode)
        Me.GroupBox3.Location = New System.Drawing.Point(577, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(205, 89)
        Me.GroupBox3.TabIndex = 67
        Me.GroupBox3.TabStop = False
        '
        'rdLotSerial
        '
        Me.rdLotSerial.AutoSize = True
        Me.rdLotSerial.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdLotSerial.ForeColor = System.Drawing.Color.Red
        Me.rdLotSerial.Location = New System.Drawing.Point(29, 55)
        Me.rdLotSerial.Name = "rdLotSerial"
        Me.rdLotSerial.Size = New System.Drawing.Size(89, 19)
        Me.rdLotSerial.TabIndex = 72
        Me.rdLotSerial.Text = "Lot Serial"
        Me.rdLotSerial.UseVisualStyleBackColor = True
        '
        'rdUDICode
        '
        Me.rdUDICode.AutoSize = True
        Me.rdUDICode.Checked = True
        Me.rdUDICode.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdUDICode.ForeColor = System.Drawing.Color.Red
        Me.rdUDICode.Location = New System.Drawing.Point(29, 19)
        Me.rdUDICode.Name = "rdUDICode"
        Me.rdUDICode.Size = New System.Drawing.Size(93, 19)
        Me.rdUDICode.TabIndex = 71
        Me.rdUDICode.TabStop = True
        Me.rdUDICode.Text = "UDI Serial"
        Me.rdUDICode.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtlotbarno)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(519, 89)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GRID2)
        Me.GroupBox4.Location = New System.Drawing.Point(598, 115)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(339, 329)
        Me.GroupBox4.TabIndex = 69
        Me.GroupBox4.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox11)
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Controls.Add(Me.GroupBox3)
        Me.GroupBox5.Controls.Add(Me.GroupBox4)
        Me.GroupBox5.Controls.Add(Me.GroupBox2)
        Me.GroupBox5.Controls.Add(Me.GroupBox1)
        Me.GroupBox5.Controls.Add(Me.GroupBox12)
        Me.GroupBox5.Controls.Add(Me.GroupBox8)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 455)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1334, 467)
        Me.GroupBox5.TabIndex = 70
        Me.GroupBox5.TabStop = False
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.toTrayGRID2)
        Me.GroupBox11.Location = New System.Drawing.Point(953, 115)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(339, 329)
        Me.GroupBox11.TabIndex = 71
        Me.GroupBox11.TabStop = False
        '
        'toTrayGRID2
        '
        Me.toTrayGRID2.AllowUserToDeleteRows = False
        Me.toTrayGRID2.BackgroundColor = System.Drawing.Color.White
        Me.toTrayGRID2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.toTrayGRID2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.toTrayGRID2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.toTrayGRID2.Location = New System.Drawing.Point(6, 18)
        Me.toTrayGRID2.Name = "toTrayGRID2"
        Me.toTrayGRID2.Size = New System.Drawing.Size(329, 299)
        Me.toTrayGRID2.TabIndex = 45
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.Label6)
        Me.GroupBox12.Controls.Add(Me.lblToTrayCount)
        Me.GroupBox12.Location = New System.Drawing.Point(1055, 17)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(154, 89)
        Me.GroupBox12.TabIndex = 68
        Me.GroupBox12.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(39, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Total Count"
        '
        'lblToTrayCount
        '
        Me.lblToTrayCount.AutoSize = True
        Me.lblToTrayCount.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToTrayCount.ForeColor = System.Drawing.Color.Red
        Me.lblToTrayCount.Location = New System.Drawing.Point(59, 37)
        Me.lblToTrayCount.Name = "lblToTrayCount"
        Me.lblToTrayCount.Size = New System.Drawing.Size(35, 40)
        Me.lblToTrayCount.TabIndex = 32
        Me.lblToTrayCount.Text = "0"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.rdTrayBased)
        Me.GroupBox7.Controls.Add(Me.rdSerialBased)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 51)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(794, 71)
        Me.GroupBox7.TabIndex = 71
        Me.GroupBox7.TabStop = False
        '
        'rdTrayBased
        '
        Me.rdTrayBased.AutoSize = True
        Me.rdTrayBased.Checked = True
        Me.rdTrayBased.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdTrayBased.ForeColor = System.Drawing.Color.Red
        Me.rdTrayBased.Location = New System.Drawing.Point(56, 32)
        Me.rdTrayBased.Name = "rdTrayBased"
        Me.rdTrayBased.Size = New System.Drawing.Size(118, 19)
        Me.rdTrayBased.TabIndex = 72
        Me.rdTrayBased.TabStop = True
        Me.rdTrayBased.Text = "Tray No Based"
        Me.rdTrayBased.UseVisualStyleBackColor = True
        '
        'rdSerialBased
        '
        Me.rdSerialBased.AutoSize = True
        Me.rdSerialBased.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdSerialBased.ForeColor = System.Drawing.Color.Red
        Me.rdSerialBased.Location = New System.Drawing.Point(308, 32)
        Me.rdSerialBased.Name = "rdSerialBased"
        Me.rdSerialBased.Size = New System.Drawing.Size(126, 19)
        Me.rdSerialBased.TabIndex = 71
        Me.rdSerialBased.Text = "Serial No Based"
        Me.rdSerialBased.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label9)
        Me.GroupBox9.Controls.Add(Me.Label3)
        Me.GroupBox9.Controls.Add(Me.lbltoTrayCount1)
        Me.GroupBox9.Controls.Add(Me.lblcount1)
        Me.GroupBox9.Controls.Add(Me.toTrayGRID1)
        Me.GroupBox9.Controls.Add(Me.GRID1)
        Me.GroupBox9.Controls.Add(Me.cmbTrayTo_TrayBased)
        Me.GroupBox9.Controls.Add(Me.Label2)
        Me.GroupBox9.Controls.Add(Me.cmbTrayFrom_TrayBased)
        Me.GroupBox9.Controls.Add(Me.GroupBox10)
        Me.GroupBox9.Controls.Add(Me.Label1)
        Me.GroupBox9.Location = New System.Drawing.Point(12, 141)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(1334, 308)
        Me.GroupBox9.TabIndex = 71
        Me.GroupBox9.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(1055, 271)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Total Count"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(745, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Total Count"
        '
        'lbltoTrayCount1
        '
        Me.lbltoTrayCount1.AutoSize = True
        Me.lbltoTrayCount1.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltoTrayCount1.ForeColor = System.Drawing.Color.Red
        Me.lbltoTrayCount1.Location = New System.Drawing.Point(1141, 261)
        Me.lbltoTrayCount1.Name = "lbltoTrayCount1"
        Me.lbltoTrayCount1.Size = New System.Drawing.Size(35, 40)
        Me.lbltoTrayCount1.TabIndex = 61
        Me.lbltoTrayCount1.Text = "0"
        '
        'lblcount1
        '
        Me.lblcount1.AutoSize = True
        Me.lblcount1.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcount1.ForeColor = System.Drawing.Color.Red
        Me.lblcount1.Location = New System.Drawing.Point(831, 265)
        Me.lblcount1.Name = "lblcount1"
        Me.lblcount1.Size = New System.Drawing.Size(35, 40)
        Me.lblcount1.TabIndex = 61
        Me.lblcount1.Text = "0"
        '
        'toTrayGRID1
        '
        Me.toTrayGRID1.AllowUserToDeleteRows = False
        Me.toTrayGRID1.BackgroundColor = System.Drawing.Color.White
        Me.toTrayGRID1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.toTrayGRID1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.toTrayGRID1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.toTrayGRID1.Location = New System.Drawing.Point(987, 19)
        Me.toTrayGRID1.Name = "toTrayGRID1"
        Me.toTrayGRID1.Size = New System.Drawing.Size(266, 239)
        Me.toTrayGRID1.TabIndex = 59
        '
        'GRID1
        '
        Me.GRID1.AllowUserToDeleteRows = False
        Me.GRID1.BackgroundColor = System.Drawing.Color.White
        Me.GRID1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GRID1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.GRID1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GRID1.Location = New System.Drawing.Point(636, 19)
        Me.GRID1.Name = "GRID1"
        Me.GRID1.Size = New System.Drawing.Size(266, 239)
        Me.GRID1.TabIndex = 59
        '
        'cmbTrayTo_TrayBased
        '
        Me.cmbTrayTo_TrayBased.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTrayTo_TrayBased.FormattingEnabled = True
        Me.cmbTrayTo_TrayBased.Location = New System.Drawing.Point(269, 85)
        Me.cmbTrayTo_TrayBased.Name = "cmbTrayTo_TrayBased"
        Me.cmbTrayTo_TrayBased.Size = New System.Drawing.Size(317, 32)
        Me.cmbTrayTo_TrayBased.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(30, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 29)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Tray Number To"
        '
        'cmbTrayFrom_TrayBased
        '
        Me.cmbTrayFrom_TrayBased.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTrayFrom_TrayBased.FormattingEnabled = True
        Me.cmbTrayFrom_TrayBased.Location = New System.Drawing.Point(269, 25)
        Me.cmbTrayFrom_TrayBased.Name = "cmbTrayFrom_TrayBased"
        Me.cmbTrayFrom_TrayBased.Size = New System.Drawing.Size(317, 32)
        Me.cmbTrayFrom_TrayBased.TabIndex = 51
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Button1)
        Me.GroupBox10.Controls.Add(Me.btnComplete_trayBased)
        Me.GroupBox10.Controls.Add(Me.Button3)
        Me.GroupBox10.Location = New System.Drawing.Point(56, 132)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(519, 91)
        Me.GroupBox10.TabIndex = 58
        Me.GroupBox10.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(199, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 42)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnComplete_trayBased
        '
        Me.btnComplete_trayBased.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComplete_trayBased.ForeColor = System.Drawing.Color.Red
        Me.btnComplete_trayBased.Location = New System.Drawing.Point(18, 28)
        Me.btnComplete_trayBased.Name = "btnComplete_trayBased"
        Me.btnComplete_trayBased.Size = New System.Drawing.Size(108, 42)
        Me.btnComplete_trayBased.TabIndex = 3
        Me.btnComplete_trayBased.Text = "Complete"
        Me.btnComplete_trayBased.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(380, 28)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 42)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(30, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 29)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Tray Number From"
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(315, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(297, 26)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Tray Number Change Form"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(1351, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 76
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'lblTrayNo
        '
        Me.lblTrayNo.AutoSize = True
        Me.lblTrayNo.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrayNo.ForeColor = System.Drawing.Color.Blue
        Me.lblTrayNo.Location = New System.Drawing.Point(10, 14)
        Me.lblTrayNo.Name = "lblTrayNo"
        Me.lblTrayNo.Size = New System.Drawing.Size(156, 29)
        Me.lblTrayNo.TabIndex = 44
        Me.lblTrayNo.Text = "Tray Number"
        '
        'cmbTrayNo
        '
        Me.cmbTrayNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTrayNo.FormattingEnabled = True
        Me.cmbTrayNo.Location = New System.Drawing.Point(179, 11)
        Me.cmbTrayNo.Name = "cmbTrayNo"
        Me.cmbTrayNo.Size = New System.Drawing.Size(317, 32)
        Me.cmbTrayNo.TabIndex = 51
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cmbTrayNo)
        Me.GroupBox6.Controls.Add(Me.lblTrayNo)
        Me.GroupBox6.Location = New System.Drawing.Point(35, 123)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(519, 72)
        Me.GroupBox6.TabIndex = 70
        Me.GroupBox6.TabStop = False
        '
        'FrmTrayChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1403, 954)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmTrayChange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        CType(Me.toTrayGRID2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.toTrayGRID1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRID1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox10.ResumeLayout(False)
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtlotbarno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GRID2 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnComplete As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblcount As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdLotSerial As System.Windows.Forms.RadioButton
    Friend WithEvents rdUDICode As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbTrayTo_TrayBased As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbTrayFrom_TrayBased As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnComplete_trayBased As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdTrayBased As System.Windows.Forms.RadioButton
    Friend WithEvents rdSerialBased As System.Windows.Forms.RadioButton
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GRID1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblcount1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents toTrayGRID2 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblToTrayCount As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbltoTrayCount1 As System.Windows.Forms.Label
    Friend WithEvents toTrayGRID1 As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbTrayNo As System.Windows.Forms.ComboBox
    Friend WithEvents lblTrayNo As System.Windows.Forms.Label
End Class
