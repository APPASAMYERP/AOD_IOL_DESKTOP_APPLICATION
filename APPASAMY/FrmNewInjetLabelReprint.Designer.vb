<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewInjetLabelReprint
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
        Me.BtnClear = New System.Windows.Forms.Button
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.pnl = New System.Windows.Forms.GroupBox
        Me.txtlotno = New System.Windows.Forms.TextBox
        Me.txtLotNoPrefix = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtcrFromQty = New System.Windows.Forms.TextBox
        Me.txtcrToQty = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtbatno = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.CmbShModel = New System.Windows.Forms.ComboBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RdoIntBIg = New System.Windows.Forms.RadioButton
        Me.RdoInA = New System.Windows.Forms.RadioButton
        Me.rdoInt = New System.Windows.Forms.RadioButton
        Me.rdosupra = New System.Windows.Forms.RadioButton
        Me.RdoExportturkey = New System.Windows.Forms.RadioButton
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.White
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.Navy
        Me.BtnClear.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnClear.Location = New System.Drawing.Point(272, 394)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(94, 32)
        Me.BtnClear.TabIndex = 3
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.Color.White
        Me.BtnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnPrint.Location = New System.Drawing.Point(147, 394)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(94, 32)
        Me.BtnPrint.TabIndex = 2
        Me.BtnPrint.Text = "Print"
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.White
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.Red
        Me.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExit.Location = New System.Drawing.Point(397, 394)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(94, 32)
        Me.BtnExit.TabIndex = 4
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(312, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "To Sr no "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(17, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "From Sr no"
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.txtlotno)
        Me.pnl.Controls.Add(Me.txtLotNoPrefix)
        Me.pnl.Controls.Add(Me.Label5)
        Me.pnl.Controls.Add(Me.Label7)
        Me.pnl.Controls.Add(Me.txtcrFromQty)
        Me.pnl.Controls.Add(Me.Label2)
        Me.pnl.Controls.Add(Me.txtcrToQty)
        Me.pnl.Controls.Add(Me.Label4)
        Me.pnl.Location = New System.Drawing.Point(14, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(604, 151)
        Me.pnl.TabIndex = 69
        Me.pnl.TabStop = False
        '
        'txtlotno
        '
        Me.txtlotno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtlotno.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlotno.Location = New System.Drawing.Point(141, 53)
        Me.txtlotno.Name = "txtlotno"
        Me.txtlotno.Size = New System.Drawing.Size(179, 29)
        Me.txtlotno.TabIndex = 71
        '
        'txtLotNoPrefix
        '
        Me.txtLotNoPrefix.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLotNoPrefix.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLotNoPrefix.Location = New System.Drawing.Point(141, 16)
        Me.txtLotNoPrefix.Name = "txtLotNoPrefix"
        Me.txtLotNoPrefix.Size = New System.Drawing.Size(179, 29)
        Me.txtLotNoPrefix.TabIndex = 70
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(31, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Lot_Prefix"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(31, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 16)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Lot_No"
        '
        'txtcrFromQty
        '
        Me.txtcrFromQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcrFromQty.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcrFromQty.Location = New System.Drawing.Point(125, 104)
        Me.txtcrFromQty.Name = "txtcrFromQty"
        Me.txtcrFromQty.Size = New System.Drawing.Size(179, 29)
        Me.txtcrFromQty.TabIndex = 0
        '
        'txtcrToQty
        '
        Me.txtcrToQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcrToQty.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcrToQty.Location = New System.Drawing.Point(409, 104)
        Me.txtcrToQty.Name = "txtcrToQty"
        Me.txtcrToQty.Size = New System.Drawing.Size(179, 29)
        Me.txtcrToQty.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtbatno)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.CmbShModel)
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(107, 237)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(410, 119)
        Me.GroupBox2.TabIndex = 70
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(50, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Batch No"
        '
        'txtbatno
        '
        Me.txtbatno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbatno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbatno.Location = New System.Drawing.Point(165, 86)
        Me.txtbatno.Name = "txtbatno"
        Me.txtbatno.Size = New System.Drawing.Size(138, 22)
        Me.txtbatno.TabIndex = 40
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
        Me.CmbShModel.Items.AddRange(New Object() {"1.0", "1.8", "2.0", "2.2", "2.8", "3.0"})
        Me.CmbShModel.Location = New System.Drawing.Point(165, 30)
        Me.CmbShModel.Name = "CmbShModel"
        Me.CmbShModel.Size = New System.Drawing.Size(137, 23)
        Me.CmbShModel.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdosupra)
        Me.GroupBox3.Controls.Add(Me.RdoExportturkey)
        Me.GroupBox3.Controls.Add(Me.RdoIntBIg)
        Me.GroupBox3.Controls.Add(Me.RdoInA)
        Me.GroupBox3.Controls.Add(Me.rdoInt)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 169)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(694, 68)
        Me.GroupBox3.TabIndex = 71
        Me.GroupBox3.TabStop = False
        '
        'RdoIntBIg
        '
        Me.RdoIntBIg.AutoSize = True
        Me.RdoIntBIg.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoIntBIg.ForeColor = System.Drawing.Color.Red
        Me.RdoIntBIg.Location = New System.Drawing.Point(258, 19)
        Me.RdoIntBIg.Name = "RdoIntBIg"
        Me.RdoIntBIg.Size = New System.Drawing.Size(152, 20)
        Me.RdoIntBIg.TabIndex = 38
        Me.RdoIntBIg.Text = "Injet Single Lable"
        Me.RdoIntBIg.UseVisualStyleBackColor = True
        '
        'RdoInA
        '
        Me.RdoInA.AutoSize = True
        Me.RdoInA.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoInA.ForeColor = System.Drawing.Color.Red
        Me.RdoInA.Location = New System.Drawing.Point(117, 19)
        Me.RdoInA.Name = "RdoInA"
        Me.RdoInA.Size = New System.Drawing.Size(127, 20)
        Me.RdoInA.TabIndex = 36
        Me.RdoInA.Text = "Injet Label - A"
        Me.RdoInA.UseVisualStyleBackColor = True
        '
        'rdoInt
        '
        Me.rdoInt.AutoSize = True
        Me.rdoInt.Checked = True
        Me.rdoInt.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoInt.ForeColor = System.Drawing.Color.Red
        Me.rdoInt.Location = New System.Drawing.Point(6, 19)
        Me.rdoInt.Name = "rdoInt"
        Me.rdoInt.Size = New System.Drawing.Size(105, 20)
        Me.rdoInt.TabIndex = 35
        Me.rdoInt.TabStop = True
        Me.rdoInt.Text = "Injet Label"
        Me.rdoInt.UseVisualStyleBackColor = True
        '
        'rdosupra
        '
        Me.rdosupra.AutoSize = True
        Me.rdosupra.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdosupra.ForeColor = System.Drawing.Color.Red
        Me.rdosupra.Location = New System.Drawing.Point(561, 19)
        Me.rdosupra.Name = "rdosupra"
        Me.rdosupra.Size = New System.Drawing.Size(106, 20)
        Me.rdosupra.TabIndex = 42
        Me.rdosupra.Text = "Injet supra"
        Me.rdosupra.UseVisualStyleBackColor = True
        '
        'RdoExportturkey
        '
        Me.RdoExportturkey.AutoSize = True
        Me.RdoExportturkey.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoExportturkey.ForeColor = System.Drawing.Color.Red
        Me.RdoExportturkey.Location = New System.Drawing.Point(436, 19)
        Me.RdoExportturkey.Name = "RdoExportturkey"
        Me.RdoExportturkey.Size = New System.Drawing.Size(119, 20)
        Me.RdoExportturkey.TabIndex = 41
        Me.RdoExportturkey.Text = "Injet Turkey"
        Me.RdoExportturkey.UseVisualStyleBackColor = True
        '
        'FrmNewInjetLabelReprint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(735, 527)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.BtnExit)
        Me.Name = "FrmNewInjetLabelReprint"
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents pnl As System.Windows.Forms.GroupBox
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents txtcrFromQty As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcrToQty As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtbatno As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CmbShModel As System.Windows.Forms.ComboBox
    Friend WithEvents txtLotNoPrefix As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtlotno As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RdoIntBIg As System.Windows.Forms.RadioButton
    Friend WithEvents RdoInA As System.Windows.Forms.RadioButton
    Friend WithEvents rdoInt As System.Windows.Forms.RadioButton
    Friend WithEvents rdosupra As System.Windows.Forms.RadioButton
    Friend WithEvents RdoExportturkey As System.Windows.Forms.RadioButton
End Class
