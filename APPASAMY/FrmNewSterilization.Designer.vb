<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewSterilization
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
        Me.lblSterNo = New System.Windows.Forms.Label
        Me.CmbStOvenid = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblcount = New System.Windows.Forms.Label
        Me.CmbStType = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.BtnExit = New System.Windows.Forms.Button
        Me.BtnComplete = New System.Windows.Forms.Button
        Me.BtnClear = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnAdd = New System.Windows.Forms.Button
        Me.ComboLotTo = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbLotNo = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbLotPrefix = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GRID2 = New System.Windows.Forms.DataGridView
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblno = New System.Windows.Forms.Label
        Me.txtbtno = New System.Windows.Forms.TextBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.RdoASt = New System.Windows.Forms.RadioButton
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSterNo
        '
        Me.lblSterNo.AutoSize = True
        Me.lblSterNo.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSterNo.ForeColor = System.Drawing.Color.Blue
        Me.lblSterNo.Location = New System.Drawing.Point(160, 23)
        Me.lblSterNo.Name = "lblSterNo"
        Me.lblSterNo.Size = New System.Drawing.Size(151, 33)
        Me.lblSterNo.TabIndex = 30
        Me.lblSterNo.Text = "Lot No. "
        '
        'CmbStOvenid
        '
        Me.CmbStOvenid.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbStOvenid.FormattingEnabled = True
        Me.CmbStOvenid.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.CmbStOvenid.Location = New System.Drawing.Point(71, 80)
        Me.CmbStOvenid.Name = "CmbStOvenid"
        Me.CmbStOvenid.Size = New System.Drawing.Size(151, 24)
        Me.CmbStOvenid.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(28, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Total Count"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(6, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 16)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Oven ID"
        '
        'lblcount
        '
        Me.lblcount.AutoSize = True
        Me.lblcount.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcount.ForeColor = System.Drawing.Color.Red
        Me.lblcount.Location = New System.Drawing.Point(48, 51)
        Me.lblcount.Name = "lblcount"
        Me.lblcount.Size = New System.Drawing.Size(35, 40)
        Me.lblcount.TabIndex = 32
        Me.lblcount.Text = "0"
        '
        'CmbStType
        '
        Me.CmbStType.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbStType.FormattingEnabled = True
        Me.CmbStType.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.CmbStType.Location = New System.Drawing.Point(71, 48)
        Me.CmbStType.Name = "CmbStType"
        Me.CmbStType.Size = New System.Drawing.Size(151, 24)
        Me.CmbStType.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(39, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 18)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Sterilization No"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(6, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 16)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Type"
        '
        'BtnExit
        '
        Me.BtnExit.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.Red
        Me.BtnExit.Location = New System.Drawing.Point(380, 23)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(108, 42)
        Me.BtnExit.TabIndex = 19
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnComplete
        '
        Me.BtnComplete.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnComplete.ForeColor = System.Drawing.Color.Red
        Me.BtnComplete.Location = New System.Drawing.Point(18, 29)
        Me.BtnComplete.Name = "BtnComplete"
        Me.BtnComplete.Size = New System.Drawing.Size(108, 42)
        Me.BtnComplete.TabIndex = 3
        Me.BtnComplete.Text = "Complete"
        Me.BtnComplete.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.Red
        Me.BtnClear.Location = New System.Drawing.Point(199, 29)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(108, 42)
        Me.BtnClear.TabIndex = 20
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.ComboLotTo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbLotNo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbLotPrefix)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 303)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(555, 153)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Red
        Me.btnAdd.Location = New System.Drawing.Point(210, 106)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(96, 32)
        Me.btnAdd.TabIndex = 38
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'ComboLotTo
        '
        Me.ComboLotTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboLotTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboLotTo.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboLotTo.FormattingEnabled = True
        Me.ComboLotTo.Location = New System.Drawing.Point(337, 65)
        Me.ComboLotTo.Name = "ComboLotTo"
        Me.ComboLotTo.Size = New System.Drawing.Size(130, 24)
        Me.ComboLotTo.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(252, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Lot NoTo"
        '
        'cmbLotNo
        '
        Me.cmbLotNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbLotNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbLotNo.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLotNo.FormattingEnabled = True
        Me.cmbLotNo.Location = New System.Drawing.Point(94, 62)
        Me.cmbLotNo.Name = "cmbLotNo"
        Me.cmbLotNo.Size = New System.Drawing.Size(128, 24)
        Me.cmbLotNo.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(9, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 16)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Lot NoFrom"
        '
        'cmbLotPrefix
        '
        Me.cmbLotPrefix.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbLotPrefix.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbLotPrefix.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLotPrefix.FormattingEnabled = True
        Me.cmbLotPrefix.Location = New System.Drawing.Point(210, 21)
        Me.cmbLotPrefix.Name = "cmbLotPrefix"
        Me.cmbLotPrefix.Size = New System.Drawing.Size(134, 24)
        Me.cmbLotPrefix.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(135, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 16)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Lot Prefix"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnClear)
        Me.GroupBox2.Controls.Add(Me.BtnComplete)
        Me.GroupBox2.Controls.Add(Me.BtnExit)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 462)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(553, 90)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CmbStType)
        Me.GroupBox3.Controls.Add(Me.CmbStOvenid)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Red
        Me.GroupBox3.Location = New System.Drawing.Point(12, 141)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(242, 156)
        Me.GroupBox3.TabIndex = 51
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sterilization"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblSterNo)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 73)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(557, 64)
        Me.GroupBox4.TabIndex = 52
        Me.GroupBox4.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.lblcount)
        Me.GroupBox5.Location = New System.Drawing.Point(783, 24)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(133, 105)
        Me.GroupBox5.TabIndex = 53
        Me.GroupBox5.TabStop = False
        '
        'GRID2
        '
        Me.GRID2.AllowUserToDeleteRows = False
        Me.GRID2.BackgroundColor = System.Drawing.Color.White
        Me.GRID2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GRID2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.GRID2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GRID2.Location = New System.Drawing.Point(12, 115)
        Me.GRID2.Name = "GRID2"
        Me.GRID2.Size = New System.Drawing.Size(330, 302)
        Me.GRID2.TabIndex = 42
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.dtpDate)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.lblno)
        Me.GroupBox6.Controls.Add(Me.txtbtno)
        Me.GroupBox6.Controls.Add(Me.GRID2)
        Me.GroupBox6.Location = New System.Drawing.Point(574, 128)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(348, 426)
        Me.GroupBox6.TabIndex = 54
        Me.GroupBox6.TabStop = False
        '
        'dtpDate
        '
        Me.dtpDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.CustomFormat = "yyyy-MM-dd hh:mm:ss"
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(174, 19)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(114, 29)
        Me.dtpDate.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(20, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 29)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Date"
        '
        'lblno
        '
        Me.lblno.AutoSize = True
        Me.lblno.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblno.ForeColor = System.Drawing.Color.Blue
        Me.lblno.Location = New System.Drawing.Point(20, 64)
        Me.lblno.Name = "lblno"
        Me.lblno.Size = New System.Drawing.Size(125, 29)
        Me.lblno.TabIndex = 44
        Me.lblno.Text = "Batch No"
        '
        'txtbtno
        '
        Me.txtbtno.Enabled = False
        Me.txtbtno.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbtno.Location = New System.Drawing.Point(174, 63)
        Me.txtbtno.Name = "txtbtno"
        Me.txtbtno.Size = New System.Drawing.Size(168, 35)
        Me.txtbtno.TabIndex = 45
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.RdoASt)
        Me.GroupBox7.Location = New System.Drawing.Point(7, 12)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(557, 64)
        Me.GroupBox7.TabIndex = 56
        Me.GroupBox7.TabStop = False
        '
        'RdoASt
        '
        Me.RdoASt.AutoSize = True
        Me.RdoASt.Checked = True
        Me.RdoASt.Enabled = False
        Me.RdoASt.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoASt.ForeColor = System.Drawing.Color.Red
        Me.RdoASt.Location = New System.Drawing.Point(28, 24)
        Me.RdoASt.Name = "RdoASt"
        Me.RdoASt.Size = New System.Drawing.Size(177, 22)
        Me.RdoASt.TabIndex = 1
        Me.RdoASt.TabStop = True
        Me.RdoASt.Text = "After Sterilization"
        Me.RdoASt.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.TextBox1)
        Me.GroupBox8.Controls.Add(Me.btnBrowse)
        Me.GroupBox8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.Red
        Me.GroupBox8.Location = New System.Drawing.Point(260, 141)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(307, 156)
        Me.GroupBox8.TabIndex = 61
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Batch Report Upload"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 25)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(286, 52)
        Me.TextBox1.TabIndex = 0
        '
        'btnBrowse
        '
        Me.btnBrowse.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.Red
        Me.btnBrowse.Location = New System.Drawing.Point(132, 95)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(79, 42)
        Me.btnBrowse.TabIndex = 28
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FrmNewSterilization
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(944, 593)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmNewSterilization"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSterNo As System.Windows.Forms.Label
    Friend WithEvents CmbStOvenid As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblcount As System.Windows.Forms.Label
    Friend WithEvents CmbStType As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnComplete As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GRID2 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents RdoASt As System.Windows.Forms.RadioButton
    Friend WithEvents lblno As System.Windows.Forms.Label
    Friend WithEvents txtbtno As System.Windows.Forms.TextBox
    Friend WithEvents cmbLotNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbLotPrefix As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboLotTo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
