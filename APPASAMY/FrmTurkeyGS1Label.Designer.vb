<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTurkeyGS1Label
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
        Me.lblBrand = New System.Windows.Forms.Label
        Me.cmbBrand = New System.Windows.Forms.ComboBox
        Me.lblModel = New System.Windows.Forms.Label
        Me.CmbModel = New System.Windows.Forms.ComboBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.LblShowModel = New System.Windows.Forms.Label
        Me.LblShowPower = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.LblShowGSCode = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmbPower = New System.Windows.Forms.ComboBox
        Me.lblPower = New System.Windows.Forms.Label
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblPrintedQty = New System.Windows.Forms.Label
        Me.GroupBox3.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrand.ForeColor = System.Drawing.Color.Blue
        Me.lblBrand.Location = New System.Drawing.Point(44, 40)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(84, 16)
        Me.lblBrand.TabIndex = 47
        Me.lblBrand.Text = "Brand Name"
        '
        'cmbBrand
        '
        Me.cmbBrand.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBrand.ForeColor = System.Drawing.Color.Red
        Me.cmbBrand.FormattingEnabled = True
        Me.cmbBrand.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbBrand.Location = New System.Drawing.Point(143, 35)
        Me.cmbBrand.Name = "cmbBrand"
        Me.cmbBrand.Size = New System.Drawing.Size(164, 26)
        Me.cmbBrand.TabIndex = 46
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.ForeColor = System.Drawing.Color.Blue
        Me.lblModel.Location = New System.Drawing.Point(44, 84)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(86, 16)
        Me.lblModel.TabIndex = 45
        Me.lblModel.Text = "Model Name"
        '
        'CmbModel
        '
        Me.CmbModel.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbModel.ForeColor = System.Drawing.Color.Red
        Me.CmbModel.FormattingEnabled = True
        Me.CmbModel.Items.AddRange(New Object() {"1", "2", "3"})
        Me.CmbModel.Location = New System.Drawing.Point(143, 79)
        Me.CmbModel.Name = "CmbModel"
        Me.CmbModel.Size = New System.Drawing.Size(164, 26)
        Me.CmbModel.TabIndex = 44
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.LblShowModel)
        Me.GroupBox3.Controls.Add(Me.LblShowPower)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.LblShowGSCode)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Red
        Me.GroupBox3.Location = New System.Drawing.Point(341, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(377, 174)
        Me.GroupBox3.TabIndex = 60
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lens Details"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(30, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 16)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Model Name"
        '
        'LblShowModel
        '
        Me.LblShowModel.AutoSize = True
        Me.LblShowModel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowModel.ForeColor = System.Drawing.Color.Navy
        Me.LblShowModel.Location = New System.Drawing.Point(141, 39)
        Me.LblShowModel.Name = "LblShowModel"
        Me.LblShowModel.Size = New System.Drawing.Size(58, 17)
        Me.LblShowModel.TabIndex = 43
        Me.LblShowModel.Text = "Lot_No"
        '
        'LblShowPower
        '
        Me.LblShowPower.AutoSize = True
        Me.LblShowPower.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowPower.ForeColor = System.Drawing.Color.Navy
        Me.LblShowPower.Location = New System.Drawing.Point(141, 112)
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
        Me.Label13.Location = New System.Drawing.Point(30, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 16)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Power"
        '
        'LblShowGSCode
        '
        Me.LblShowGSCode.AutoSize = True
        Me.LblShowGSCode.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowGSCode.ForeColor = System.Drawing.Color.Navy
        Me.LblShowGSCode.Location = New System.Drawing.Point(141, 71)
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
        Me.Label11.Location = New System.Drawing.Point(30, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 16)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "GS1 Code"
        '
        'cmbPower
        '
        Me.cmbPower.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPower.ForeColor = System.Drawing.Color.Red
        Me.cmbPower.FormattingEnabled = True
        Me.cmbPower.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbPower.Location = New System.Drawing.Point(143, 127)
        Me.cmbPower.Name = "cmbPower"
        Me.cmbPower.Size = New System.Drawing.Size(164, 26)
        Me.cmbPower.TabIndex = 46
        '
        'lblPower
        '
        Me.lblPower.AutoSize = True
        Me.lblPower.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPower.ForeColor = System.Drawing.Color.Blue
        Me.lblPower.Location = New System.Drawing.Point(44, 132)
        Me.lblPower.Name = "lblPower"
        Me.lblPower.Size = New System.Drawing.Size(47, 16)
        Me.lblPower.TabIndex = 47
        Me.lblPower.Text = "Power"
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.Color.White
        Me.BtnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnPrint.Location = New System.Drawing.Point(143, 249)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(94, 32)
        Me.BtnPrint.TabIndex = 61
        Me.BtnPrint.Text = "Print"
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'txtQty
        '
        Me.txtQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQty.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(143, 172)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(118, 29)
        Me.txtQty.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(44, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "No of label"
        '
        'LblPrintedQty
        '
        Me.LblPrintedQty.AutoSize = True
        Me.LblPrintedQty.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrintedQty.ForeColor = System.Drawing.Color.Navy
        Me.LblPrintedQty.Location = New System.Drawing.Point(457, 16)
        Me.LblPrintedQty.Name = "LblPrintedQty"
        Me.LblPrintedQty.Size = New System.Drawing.Size(35, 40)
        Me.LblPrintedQty.TabIndex = 71
        Me.LblPrintedQty.Text = "0"
        '
        'FrmTurkeyGS1Label
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(746, 314)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblPrintedQty)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblPower)
        Me.Controls.Add(Me.lblBrand)
        Me.Controls.Add(Me.cmbPower)
        Me.Controls.Add(Me.cmbBrand)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.CmbModel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmTurkeyGS1Label"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBrand As System.Windows.Forms.Label
    Friend WithEvents cmbBrand As System.Windows.Forms.ComboBox
    Friend WithEvents lblModel As System.Windows.Forms.Label
    Friend WithEvents CmbModel As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LblShowModel As System.Windows.Forms.Label
    Friend WithEvents LblShowPower As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LblShowGSCode As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbPower As System.Windows.Forms.ComboBox
    Friend WithEvents lblPower As System.Windows.Forms.Label
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblPrintedQty As System.Windows.Forms.Label
End Class
