<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSterileBTupdate
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
        Me.btnAdd = New System.Windows.Forms.Button
        Me.ComboLotTo = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbLotNo = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbLotPrefix = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.lblno = New System.Windows.Forms.Label
        Me.txtbtno = New System.Windows.Forms.TextBox
        Me.GRID2 = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnClear = New System.Windows.Forms.Button
        Me.BtnComplete = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblcount = New System.Windows.Forms.Label
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.cmb_Order_Country = New System.Windows.Forms.ComboBox
        Me.cmb_Order_Type = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(557, 161)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Red
        Me.btnAdd.Location = New System.Drawing.Point(465, 84)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(86, 28)
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
        Me.ComboLotTo.Location = New System.Drawing.Point(329, 88)
        Me.ComboLotTo.Name = "ComboLotTo"
        Me.ComboLotTo.Size = New System.Drawing.Size(130, 24)
        Me.ComboLotTo.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(246, 91)
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
        Me.cmbLotNo.Location = New System.Drawing.Point(88, 85)
        Me.cmbLotNo.Name = "cmbLotNo"
        Me.cmbLotNo.Size = New System.Drawing.Size(128, 24)
        Me.cmbLotNo.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(3, 88)
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
        Me.cmbLotPrefix.Location = New System.Drawing.Point(210, 31)
        Me.cmbLotPrefix.Name = "cmbLotPrefix"
        Me.cmbLotPrefix.Size = New System.Drawing.Size(134, 24)
        Me.cmbLotPrefix.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(135, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 16)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Lot Prefix"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label28)
        Me.GroupBox6.Controls.Add(Me.Label27)
        Me.GroupBox6.Controls.Add(Me.cmb_Order_Country)
        Me.GroupBox6.Controls.Add(Me.cmb_Order_Type)
        Me.GroupBox6.Controls.Add(Me.lblno)
        Me.GroupBox6.Controls.Add(Me.txtbtno)
        Me.GroupBox6.Controls.Add(Me.GRID2)
        Me.GroupBox6.Location = New System.Drawing.Point(575, 12)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(348, 472)
        Me.GroupBox6.TabIndex = 55
        Me.GroupBox6.TabStop = False
        '
        'lblno
        '
        Me.lblno.AutoSize = True
        Me.lblno.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblno.ForeColor = System.Drawing.Color.Blue
        Me.lblno.Location = New System.Drawing.Point(15, 92)
        Me.lblno.Name = "lblno"
        Me.lblno.Size = New System.Drawing.Size(125, 29)
        Me.lblno.TabIndex = 44
        Me.lblno.Text = "Batch No"
        '
        'txtbtno
        '
        Me.txtbtno.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbtno.Location = New System.Drawing.Point(169, 91)
        Me.txtbtno.Name = "txtbtno"
        Me.txtbtno.Size = New System.Drawing.Size(168, 35)
        Me.txtbtno.TabIndex = 45
        '
        'GRID2
        '
        Me.GRID2.AllowUserToDeleteRows = False
        Me.GRID2.BackgroundColor = System.Drawing.Color.White
        Me.GRID2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GRID2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.GRID2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GRID2.Location = New System.Drawing.Point(12, 135)
        Me.GRID2.Name = "GRID2"
        Me.GRID2.Size = New System.Drawing.Size(330, 327)
        Me.GRID2.TabIndex = 42
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnClear)
        Me.GroupBox2.Controls.Add(Me.BtnComplete)
        Me.GroupBox2.Controls.Add(Me.BtnExit)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 388)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(553, 90)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
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
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.lblcount)
        Me.GroupBox5.Location = New System.Drawing.Point(405, 225)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(158, 125)
        Me.GroupBox5.TabIndex = 57
        Me.GroupBox5.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(39, 28)
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
        Me.lblcount.Location = New System.Drawing.Point(59, 59)
        Me.lblcount.Name = "lblcount"
        Me.lblcount.Size = New System.Drawing.Size(35, 40)
        Me.lblcount.TabIndex = 32
        Me.lblcount.Text = "0"
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Blue
        Me.Label28.Location = New System.Drawing.Point(37, 56)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(103, 16)
        Me.Label28.TabIndex = 48
        Me.Label28.Text = "Order_Country"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Blue
        Me.Label27.Location = New System.Drawing.Point(37, 29)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(83, 16)
        Me.Label27.TabIndex = 49
        Me.Label27.Text = "Order_Type"
        '
        'cmb_Order_Country
        '
        Me.cmb_Order_Country.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Order_Country.ForeColor = System.Drawing.Color.Red
        Me.cmb_Order_Country.FormattingEnabled = True
        Me.cmb_Order_Country.Location = New System.Drawing.Point(169, 51)
        Me.cmb_Order_Country.Name = "cmb_Order_Country"
        Me.cmb_Order_Country.Size = New System.Drawing.Size(164, 26)
        Me.cmb_Order_Country.TabIndex = 46
        '
        'cmb_Order_Type
        '
        Me.cmb_Order_Type.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Order_Type.ForeColor = System.Drawing.Color.Red
        Me.cmb_Order_Type.FormattingEnabled = True
        Me.cmb_Order_Type.Items.AddRange(New Object() {"Domestic", "Export"})
        Me.cmb_Order_Type.Location = New System.Drawing.Point(169, 23)
        Me.cmb_Order_Type.Name = "cmb_Order_Type"
        Me.cmb_Order_Type.Size = New System.Drawing.Size(164, 26)
        Me.cmb_Order_Type.TabIndex = 47
        '
        'frmSterileBTupdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(924, 556)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmSterileBTupdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents ComboLotTo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbLotNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbLotPrefix As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents lblno As System.Windows.Forms.Label
    Friend WithEvents txtbtno As System.Windows.Forms.TextBox
    Friend WithEvents GRID2 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnComplete As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblcount As System.Windows.Forms.Label
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cmb_Order_Country As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Order_Type As System.Windows.Forms.ComboBox
End Class
