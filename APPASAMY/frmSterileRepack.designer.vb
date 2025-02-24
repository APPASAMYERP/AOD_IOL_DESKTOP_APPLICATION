<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSterileRepack
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.btc_cont = New System.Windows.Forms.TextBox
        Me.cmbbtc = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblcount = New System.Windows.Forms.Label
        Me.GRID2 = New System.Windows.Forms.DataGridView
        Me.BtnClear = New System.Windows.Forms.Button
        Me.BtnComplete = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.Repack_lot_txt = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.Lot_SrNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Model_Name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Power = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Btc_no = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Repk_Scanned = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label9 = New System.Windows.Forms.Label
        Me.btc_count = New System.Windows.Forms.TextBox
        Me.cmbbtc1 = New System.Windows.Forms.ComboBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblCoutReturn = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnClear1 = New System.Windows.Forms.Button
        Me.btnCompleteRepackRemove = New System.Windows.Forms.Button
        Me.btnExit1 = New System.Windows.Forms.Button
        Me.txtScanRepackRemove = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.rdrepackReturn = New System.Windows.Forms.RadioButton
        Me.rdRepack = New System.Windows.Forms.RadioButton
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.rdLotSerial = New System.Windows.Forms.RadioButton
        Me.rdUDICode = New System.Windows.Forms.RadioButton
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label1)
        Me.GroupBox7.Location = New System.Drawing.Point(51, 27)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(1062, 64)
        Me.GroupBox7.TabIndex = 57
        Me.GroupBox7.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(451, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 29)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "REPACK SCAN"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btc_cont)
        Me.GroupBox1.Controls.Add(Me.cmbbtc)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GRID2)
        Me.GroupBox1.Controls.Add(Me.BtnClear)
        Me.GroupBox1.Controls.Add(Me.BtnComplete)
        Me.GroupBox1.Controls.Add(Me.BtnExit)
        Me.GroupBox1.Controls.Add(Me.Repack_lot_txt)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(51, 207)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(523, 586)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 12.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(397, 321)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 18)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Total Batch Qty"
        Me.Label8.Visible = False
        '
        'btc_cont
        '
        Me.btc_cont.Enabled = False
        Me.btc_cont.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btc_cont.Location = New System.Drawing.Point(408, 353)
        Me.btc_cont.Name = "btc_cont"
        Me.btc_cont.Size = New System.Drawing.Size(100, 22)
        Me.btc_cont.TabIndex = 58
        Me.btc_cont.Visible = False
        '
        'cmbbtc
        '
        Me.cmbbtc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbtc.FormattingEnabled = True
        Me.cmbbtc.Location = New System.Drawing.Point(175, 19)
        Me.cmbbtc.Name = "cmbbtc"
        Me.cmbbtc.Size = New System.Drawing.Size(342, 33)
        Me.cmbbtc.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(18, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 29)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Batch No"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.lblcount)
        Me.GroupBox5.Location = New System.Drawing.Point(418, 152)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(99, 138)
        Me.GroupBox5.TabIndex = 55
        Me.GroupBox5.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(10, 28)
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
        Me.lblcount.Location = New System.Drawing.Point(30, 59)
        Me.lblcount.Name = "lblcount"
        Me.lblcount.Size = New System.Drawing.Size(35, 40)
        Me.lblcount.TabIndex = 32
        Me.lblcount.Text = "0"
        '
        'GRID2
        '
        Me.GRID2.AllowUserToDeleteRows = False
        Me.GRID2.BackgroundColor = System.Drawing.Color.White
        Me.GRID2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GRID2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.GRID2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GRID2.Location = New System.Drawing.Point(23, 152)
        Me.GRID2.Name = "GRID2"
        Me.GRID2.Size = New System.Drawing.Size(364, 356)
        Me.GRID2.TabIndex = 43
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.Red
        Me.BtnClear.Location = New System.Drawing.Point(209, 525)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(108, 42)
        Me.BtnClear.TabIndex = 30
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnComplete
        '
        Me.BtnComplete.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnComplete.ForeColor = System.Drawing.Color.Red
        Me.BtnComplete.Location = New System.Drawing.Point(34, 525)
        Me.BtnComplete.Name = "BtnComplete"
        Me.BtnComplete.Size = New System.Drawing.Size(108, 42)
        Me.BtnComplete.TabIndex = 28
        Me.BtnComplete.Text = "Complete"
        Me.BtnComplete.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.Red
        Me.BtnExit.Location = New System.Drawing.Point(387, 525)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(108, 42)
        Me.BtnExit.TabIndex = 29
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Repack_lot_txt
        '
        Me.Repack_lot_txt.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Repack_lot_txt.Location = New System.Drawing.Point(175, 74)
        Me.Repack_lot_txt.Name = "Repack_lot_txt"
        Me.Repack_lot_txt.Size = New System.Drawing.Size(342, 48)
        Me.Repack_lot_txt.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(18, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 29)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Scan Lot No"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.btc_count)
        Me.GroupBox2.Controls.Add(Me.cmbbtc1)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.btnClear1)
        Me.GroupBox2.Controls.Add(Me.btnCompleteRepackRemove)
        Me.GroupBox2.Controls.Add(Me.btnExit1)
        Me.GroupBox2.Controls.Add(Me.txtScanRepackRemove)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(590, 207)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(523, 586)
        Me.GroupBox2.TabIndex = 59
        Me.GroupBox2.TabStop = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Lot_SrNo, Me.Model_Name, Me.Power, Me.Btc_no, Me.Repk_Scanned})
        Me.DataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView2.Location = New System.Drawing.Point(15, 148)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView2.Size = New System.Drawing.Size(381, 371)
        Me.DataGridView2.TabIndex = 73
        '
        'Lot_SrNo
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.Lot_SrNo.DefaultCellStyle = DataGridViewCellStyle3
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
        'Repk_Scanned
        '
        Me.Repk_Scanned.HeaderText = "Repk_Scanned"
        Me.Repk_Scanned.Name = "Repk_Scanned"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 12.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(397, 321)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 18)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Total Batch Qty"
        '
        'btc_count
        '
        Me.btc_count.Enabled = False
        Me.btc_count.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btc_count.Location = New System.Drawing.Point(408, 353)
        Me.btc_count.Name = "btc_count"
        Me.btc_count.Size = New System.Drawing.Size(100, 22)
        Me.btc_count.TabIndex = 60
        '
        'cmbbtc1
        '
        Me.cmbbtc1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbtc1.FormattingEnabled = True
        Me.cmbbtc1.Location = New System.Drawing.Point(160, 22)
        Me.cmbbtc1.Name = "cmbbtc1"
        Me.cmbbtc1.Size = New System.Drawing.Size(335, 33)
        Me.cmbbtc1.TabIndex = 59
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.lblCoutReturn)
        Me.GroupBox3.Location = New System.Drawing.Point(409, 152)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(99, 138)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(10, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Total Count"
        '
        'lblCoutReturn
        '
        Me.lblCoutReturn.AutoSize = True
        Me.lblCoutReturn.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoutReturn.ForeColor = System.Drawing.Color.Red
        Me.lblCoutReturn.Location = New System.Drawing.Point(30, 59)
        Me.lblCoutReturn.Name = "lblCoutReturn"
        Me.lblCoutReturn.Size = New System.Drawing.Size(35, 40)
        Me.lblCoutReturn.TabIndex = 32
        Me.lblCoutReturn.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(18, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 29)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Batch No"
        '
        'btnClear1
        '
        Me.btnClear1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear1.ForeColor = System.Drawing.Color.Red
        Me.btnClear1.Location = New System.Drawing.Point(207, 525)
        Me.btnClear1.Name = "btnClear1"
        Me.btnClear1.Size = New System.Drawing.Size(108, 42)
        Me.btnClear1.TabIndex = 30
        Me.btnClear1.Text = "Clear"
        Me.btnClear1.UseVisualStyleBackColor = True
        '
        'btnCompleteRepackRemove
        '
        Me.btnCompleteRepackRemove.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompleteRepackRemove.ForeColor = System.Drawing.Color.Red
        Me.btnCompleteRepackRemove.Location = New System.Drawing.Point(21, 525)
        Me.btnCompleteRepackRemove.Name = "btnCompleteRepackRemove"
        Me.btnCompleteRepackRemove.Size = New System.Drawing.Size(108, 42)
        Me.btnCompleteRepackRemove.TabIndex = 28
        Me.btnCompleteRepackRemove.Text = "Complete"
        Me.btnCompleteRepackRemove.UseVisualStyleBackColor = True
        '
        'btnExit1
        '
        Me.btnExit1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit1.ForeColor = System.Drawing.Color.Red
        Me.btnExit1.Location = New System.Drawing.Point(376, 525)
        Me.btnExit1.Name = "btnExit1"
        Me.btnExit1.Size = New System.Drawing.Size(108, 42)
        Me.btnExit1.TabIndex = 29
        Me.btnExit1.Text = "Exit"
        Me.btnExit1.UseVisualStyleBackColor = True
        '
        'txtScanRepackRemove
        '
        Me.txtScanRepackRemove.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScanRepackRemove.Location = New System.Drawing.Point(160, 74)
        Me.txtScanRepackRemove.Name = "txtScanRepackRemove"
        Me.txtScanRepackRemove.Size = New System.Drawing.Size(342, 48)
        Me.txtScanRepackRemove.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(16, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 29)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Scan Lot No"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(1187, 43)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(121, 356)
        Me.DataGridView1.TabIndex = 43
        Me.DataGridView1.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rdrepackReturn)
        Me.GroupBox4.Controls.Add(Me.rdRepack)
        Me.GroupBox4.Location = New System.Drawing.Point(51, 145)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1062, 63)
        Me.GroupBox4.TabIndex = 57
        Me.GroupBox4.TabStop = False
        '
        'rdrepackReturn
        '
        Me.rdrepackReturn.AutoSize = True
        Me.rdrepackReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdrepackReturn.ForeColor = System.Drawing.Color.Red
        Me.rdrepackReturn.Location = New System.Drawing.Point(539, 19)
        Me.rdrepackReturn.Name = "rdrepackReturn"
        Me.rdrepackReturn.Size = New System.Drawing.Size(129, 20)
        Me.rdrepackReturn.TabIndex = 1
        Me.rdrepackReturn.Text = "Return Repack"
        Me.rdrepackReturn.UseVisualStyleBackColor = True
        '
        'rdRepack
        '
        Me.rdRepack.AutoSize = True
        Me.rdRepack.Checked = True
        Me.rdRepack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdRepack.ForeColor = System.Drawing.Color.Red
        Me.rdRepack.Location = New System.Drawing.Point(23, 19)
        Me.rdRepack.Name = "rdRepack"
        Me.rdRepack.Size = New System.Drawing.Size(119, 20)
        Me.rdRepack.TabIndex = 0
        Me.rdRepack.TabStop = True
        Me.rdRepack.Text = "Repack Scan"
        Me.rdRepack.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rdLotSerial)
        Me.GroupBox6.Controls.Add(Me.rdUDICode)
        Me.GroupBox6.Location = New System.Drawing.Point(50, 97)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(368, 47)
        Me.GroupBox6.TabIndex = 62
        Me.GroupBox6.TabStop = False
        '
        'rdLotSerial
        '
        Me.rdLotSerial.AutoSize = True
        Me.rdLotSerial.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdLotSerial.ForeColor = System.Drawing.Color.Red
        Me.rdLotSerial.Location = New System.Drawing.Point(209, 19)
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
        Me.rdUDICode.Location = New System.Drawing.Point(25, 16)
        Me.rdUDICode.Name = "rdUDICode"
        Me.rdUDICode.Size = New System.Drawing.Size(93, 19)
        Me.rdUDICode.TabIndex = 71
        Me.rdUDICode.TabStop = True
        Me.rdUDICode.Text = "UDI Serial"
        Me.rdUDICode.UseVisualStyleBackColor = True
        '
        'frmSterileRepack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1372, 835)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.DataGridView1)
        Me.MinimizeBox = False
        Me.Name = "frmSterileRepack"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Repack_lot_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnComplete As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents GRID2 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblcount As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCoutReturn As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnClear1 As System.Windows.Forms.Button
    Friend WithEvents btnCompleteRepackRemove As System.Windows.Forms.Button
    Friend WithEvents btnExit1 As System.Windows.Forms.Button
    Friend WithEvents txtScanRepackRemove As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rdrepackReturn As System.Windows.Forms.RadioButton
    Friend WithEvents rdRepack As System.Windows.Forms.RadioButton
    Friend WithEvents cmbbtc As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbbtc1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btc_cont As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btc_count As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Lot_SrNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Model_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Power As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Btc_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Repk_Scanned As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rdLotSerial As System.Windows.Forms.RadioButton
    Friend WithEvents rdUDICode As System.Windows.Forms.RadioButton
End Class
