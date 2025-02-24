<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAerationStockStatus
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
        Me.Label22 = New System.Windows.Forms.Label
        Me.cmbPower = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbModel = New System.Windows.Forms.ComboBox
        Me.btnView = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTotalLens = New System.Windows.Forms.TextBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.chkSterilization = New System.Windows.Forms.CheckBox
        Me.dtpYear = New System.Windows.Forms.DateTimePicker
        Me.chkBefore_Sterilization = New System.Windows.Forms.CheckBox
        Me.chkAfter_Sterilization = New System.Windows.Forms.CheckBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Blue
        Me.Label22.Location = New System.Drawing.Point(442, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(47, 16)
        Me.Label22.TabIndex = 53
        Me.Label22.Text = "Power"
        '
        'cmbPower
        '
        Me.cmbPower.FormattingEnabled = True
        Me.cmbPower.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbPower.Location = New System.Drawing.Point(495, 16)
        Me.cmbPower.Name = "cmbPower"
        Me.cmbPower.Size = New System.Drawing.Size(137, 21)
        Me.cmbPower.TabIndex = 49
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Blue
        Me.Label21.Location = New System.Drawing.Point(251, 17)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(39, 16)
        Me.Label21.TabIndex = 52
        Me.Label21.Text = "Type"
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"AOD"})
        Me.cmbType.Location = New System.Drawing.Point(299, 15)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(137, 21)
        Me.cmbType.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(32, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 16)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Model"
        '
        'cmbModel
        '
        Me.cmbModel.FormattingEnabled = True
        Me.cmbModel.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbModel.Location = New System.Drawing.Point(108, 14)
        Me.cmbModel.Name = "cmbModel"
        Me.cmbModel.Size = New System.Drawing.Size(137, 21)
        Me.cmbModel.TabIndex = 48
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.White
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.Navy
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnView.Location = New System.Drawing.Point(108, 61)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(94, 32)
        Me.btnView.TabIndex = 54
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(34, 99)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1322, 653)
        Me.DataGridView1.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(86, 766)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Total Lens"
        '
        'txtTotalLens
        '
        Me.txtTotalLens.Location = New System.Drawing.Point(165, 766)
        Me.txtTotalLens.Name = "txtTotalLens"
        Me.txtTotalLens.Size = New System.Drawing.Size(105, 20)
        Me.txtTotalLens.TabIndex = 58
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Navy
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnClose.Location = New System.Drawing.Point(298, 758)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(94, 32)
        Me.btnClose.TabIndex = 59
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'chkSterilization
        '
        Me.chkSterilization.AutoSize = True
        Me.chkSterilization.Font = New System.Drawing.Font("Georgia", 9.75!)
        Me.chkSterilization.ForeColor = System.Drawing.Color.Blue
        Me.chkSterilization.Location = New System.Drawing.Point(666, 17)
        Me.chkSterilization.Name = "chkSterilization"
        Me.chkSterilization.Size = New System.Drawing.Size(89, 20)
        Me.chkSterilization.TabIndex = 60
        Me.chkSterilization.Text = "MFD Year"
        Me.chkSterilization.UseVisualStyleBackColor = True
        '
        'dtpYear
        '
        Me.dtpYear.CustomFormat = "yyyy"
        Me.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYear.Location = New System.Drawing.Point(805, 15)
        Me.dtpYear.Name = "dtpYear"
        Me.dtpYear.Size = New System.Drawing.Size(110, 20)
        Me.dtpYear.TabIndex = 61
        '
        'chkBefore_Sterilization
        '
        Me.chkBefore_Sterilization.AutoSize = True
        Me.chkBefore_Sterilization.Font = New System.Drawing.Font("Georgia", 9.75!)
        Me.chkBefore_Sterilization.ForeColor = System.Drawing.Color.Blue
        Me.chkBefore_Sterilization.Location = New System.Drawing.Point(950, 18)
        Me.chkBefore_Sterilization.Name = "chkBefore_Sterilization"
        Me.chkBefore_Sterilization.Size = New System.Drawing.Size(145, 20)
        Me.chkBefore_Sterilization.TabIndex = 62
        Me.chkBefore_Sterilization.Text = "Before Sterilization"
        Me.chkBefore_Sterilization.UseVisualStyleBackColor = True
        '
        'chkAfter_Sterilization
        '
        Me.chkAfter_Sterilization.AutoSize = True
        Me.chkAfter_Sterilization.Font = New System.Drawing.Font("Georgia", 9.75!)
        Me.chkAfter_Sterilization.ForeColor = System.Drawing.Color.Blue
        Me.chkAfter_Sterilization.Location = New System.Drawing.Point(1112, 18)
        Me.chkAfter_Sterilization.Name = "chkAfter_Sterilization"
        Me.chkAfter_Sterilization.Size = New System.Drawing.Size(137, 20)
        Me.chkAfter_Sterilization.TabIndex = 63
        Me.chkAfter_Sterilization.Text = "After Sterilization"
        Me.chkAfter_Sterilization.UseVisualStyleBackColor = True
        '
        'frmAerationStockStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1381, 802)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkAfter_Sterilization)
        Me.Controls.Add(Me.chkBefore_Sterilization)
        Me.Controls.Add(Me.dtpYear)
        Me.Controls.Add(Me.chkSterilization)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtTotalLens)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cmbPower)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbModel)
        Me.Name = "frmAerationStockStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cmbPower As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbModel As System.Windows.Forms.ComboBox
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTotalLens As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents chkSterilization As System.Windows.Forms.CheckBox
    Friend WithEvents dtpYear As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkBefore_Sterilization As System.Windows.Forms.CheckBox
    Friend WithEvents chkAfter_Sterilization As System.Windows.Forms.CheckBox
End Class
