<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewLotNo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNewLotNo))
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCreLotPrefix = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCrlotNo = New System.Windows.Forms.TextBox
        Me.ErrFrmNewLot = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CmbType = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtcrMaxQty = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ComboType = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtMaxBatch = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_SterileBatch = New System.Windows.Forms.TextBox
        Me.ErrWarning = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrOk = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.rdLot = New System.Windows.Forms.RadioButton
        Me.rdBatch = New System.Windows.Forms.RadioButton
        CType(Me.ErrFrmNewLot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrWarning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrOk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(39, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Lot_Prefix"
        '
        'txtCreLotPrefix
        '
        Me.txtCreLotPrefix.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCreLotPrefix.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreLotPrefix.Location = New System.Drawing.Point(120, 74)
        Me.txtCreLotPrefix.Name = "txtCreLotPrefix"
        Me.txtCreLotPrefix.Size = New System.Drawing.Size(138, 22)
        Me.txtCreLotPrefix.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(39, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Lot_No"
        '
        'txtCrlotNo
        '
        Me.txtCrlotNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCrlotNo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCrlotNo.Location = New System.Drawing.Point(120, 116)
        Me.txtCrlotNo.Name = "txtCrlotNo"
        Me.txtCrlotNo.Size = New System.Drawing.Size(138, 22)
        Me.txtCrlotNo.TabIndex = 20
        '
        'ErrFrmNewLot
        '
        Me.ErrFrmNewLot.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbType)
        Me.GroupBox1.Controls.Add(Me.txtCrlotNo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtcrMaxQty)
        Me.GroupBox1.Controls.Add(Me.txtCreLotPrefix)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.BtnExit)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(54, 125)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(295, 280)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'CmbType
        '
        Me.CmbType.FormattingEnabled = True
        Me.CmbType.Location = New System.Drawing.Point(125, 39)
        Me.CmbType.Name = "CmbType"
        Me.CmbType.Size = New System.Drawing.Size(132, 21)
        Me.CmbType.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(39, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Type"
        '
        'txtcrMaxQty
        '
        Me.txtcrMaxQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcrMaxQty.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcrMaxQty.Location = New System.Drawing.Point(119, 156)
        Me.txtcrMaxQty.Name = "txtcrMaxQty"
        Me.txtcrMaxQty.Size = New System.Drawing.Size(138, 22)
        Me.txtcrMaxQty.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(38, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Max.Qty"
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.White
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnSave.Location = New System.Drawing.Point(42, 207)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(94, 32)
        Me.BtnSave.TabIndex = 24
        Me.BtnSave.Text = "OPEN"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.White
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.Red
        Me.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExit.Location = New System.Drawing.Point(152, 207)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(94, 32)
        Me.BtnExit.TabIndex = 25
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboType)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.txtMaxBatch)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_SterileBatch)
        Me.GroupBox2.Location = New System.Drawing.Point(427, 125)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(298, 280)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
        '
        'ComboType
        '
        Me.ComboType.FormattingEnabled = True
        Me.ComboType.Location = New System.Drawing.Point(121, 36)
        Me.ComboType.Name = "ComboType"
        Me.ComboType.Size = New System.Drawing.Size(132, 21)
        Me.ComboType.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(26, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 16)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Sterile_Batch"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(26, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 16)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Type"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(139, 204)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 32)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button2.Location = New System.Drawing.Point(29, 204)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 32)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "OPEN"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtMaxBatch
        '
        Me.txtMaxBatch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMaxBatch.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaxBatch.Location = New System.Drawing.Point(121, 116)
        Me.txtMaxBatch.Name = "txtMaxBatch"
        Me.txtMaxBatch.Size = New System.Drawing.Size(138, 22)
        Me.txtMaxBatch.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(25, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 16)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Max.Qty"
        '
        'txt_SterileBatch
        '
        Me.txt_SterileBatch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SterileBatch.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SterileBatch.Location = New System.Drawing.Point(122, 71)
        Me.txt_SterileBatch.Name = "txt_SterileBatch"
        Me.txt_SterileBatch.Size = New System.Drawing.Size(138, 22)
        Me.txt_SterileBatch.TabIndex = 18
        '
        'ErrWarning
        '
        Me.ErrWarning.ContainerControl = Me
        Me.ErrWarning.Icon = CType(resources.GetObject("ErrWarning.Icon"), System.Drawing.Icon)
        '
        'ErrOk
        '
        Me.ErrOk.ContainerControl = Me
        Me.ErrOk.Icon = CType(resources.GetObject("ErrOk.Icon"), System.Drawing.Icon)
        '
        'rdLot
        '
        Me.rdLot.AutoSize = True
        Me.rdLot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdLot.ForeColor = System.Drawing.Color.Red
        Me.rdLot.Location = New System.Drawing.Point(159, 65)
        Me.rdLot.MaximumSize = New System.Drawing.Size(200, 0)
        Me.rdLot.Name = "rdLot"
        Me.rdLot.Size = New System.Drawing.Size(53, 24)
        Me.rdLot.TabIndex = 36
        Me.rdLot.Text = "Lot"
        Me.rdLot.UseVisualStyleBackColor = True
        '
        'rdBatch
        '
        Me.rdBatch.AutoSize = True
        Me.rdBatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdBatch.ForeColor = System.Drawing.Color.Red
        Me.rdBatch.Location = New System.Drawing.Point(482, 65)
        Me.rdBatch.MaximumSize = New System.Drawing.Size(200, 0)
        Me.rdBatch.Name = "rdBatch"
        Me.rdBatch.Size = New System.Drawing.Size(74, 24)
        Me.rdBatch.TabIndex = 36
        Me.rdBatch.Text = "Batch"
        Me.rdBatch.UseVisualStyleBackColor = True
        '
        'FrmNewLotNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(821, 566)
        Me.ControlBox = False
        Me.Controls.Add(Me.rdBatch)
        Me.Controls.Add(Me.rdLot)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmNewLotNo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ErrFrmNewLot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrWarning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrOk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCreLotPrefix As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCrlotNo As System.Windows.Forms.TextBox
    Friend WithEvents ErrFrmNewLot As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents ErrWarning As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrOk As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtcrMaxQty As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rdLot As System.Windows.Forms.RadioButton
    Friend WithEvents rdBatch As System.Windows.Forms.RadioButton
    Friend WithEvents ComboType As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtMaxBatch As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_SterileBatch As System.Windows.Forms.TextBox
End Class
