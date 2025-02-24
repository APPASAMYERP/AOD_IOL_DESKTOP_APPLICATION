<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInjectorInspection
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
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.BtnClear = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.Save = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtMTS_NO = New System.Windows.Forms.TextBox
        Me.txtReceived_qty = New System.Windows.Forms.TextBox
        Me.txtInj_ref = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtmfd_date = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtExp_date = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.CmbBatch = New System.Windows.Forms.ComboBox
        Me.txtProduct_Name = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTotal_Qty = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtAccepted_Qty = New System.Windows.Forms.TextBox
        Me.txtRejected_qty = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox5.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnClear)
        Me.GroupBox5.Controls.Add(Me.BtnExit)
        Me.GroupBox5.Controls.Add(Me.Save)
        Me.GroupBox5.Location = New System.Drawing.Point(81, 439)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(849, 80)
        Me.GroupBox5.TabIndex = 95
        Me.GroupBox5.TabStop = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.White
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.Navy
        Me.BtnClear.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnClear.Location = New System.Drawing.Point(362, 29)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(94, 32)
        Me.BtnClear.TabIndex = 87
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.White
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.Red
        Me.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExit.Location = New System.Drawing.Point(677, 29)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(94, 32)
        Me.BtnExit.TabIndex = 88
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'Save
        '
        Me.Save.BackColor = System.Drawing.Color.White
        Me.Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save.ForeColor = System.Drawing.Color.DarkGreen
        Me.Save.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Save.Location = New System.Drawing.Point(66, 29)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(94, 32)
        Me.Save.TabIndex = 86
        Me.Save.Text = " SAVE"
        Me.Save.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(572, 293)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 16)
        Me.Label9.TabIndex = 94
        Me.Label9.Text = "Product Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(323, 333)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "MTS No"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(86, 286)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 16)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Received Qty"
        '
        'txtMTS_NO
        '
        Me.txtMTS_NO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMTS_NO.Enabled = False
        Me.txtMTS_NO.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMTS_NO.Location = New System.Drawing.Point(425, 327)
        Me.txtMTS_NO.Name = "txtMTS_NO"
        Me.txtMTS_NO.Size = New System.Drawing.Size(340, 22)
        Me.txtMTS_NO.TabIndex = 89
        '
        'txtReceived_qty
        '
        Me.txtReceived_qty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReceived_qty.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceived_qty.Location = New System.Drawing.Point(192, 284)
        Me.txtReceived_qty.Name = "txtReceived_qty"
        Me.txtReceived_qty.Size = New System.Drawing.Size(112, 22)
        Me.txtReceived_qty.TabIndex = 90
        '
        'txtInj_ref
        '
        Me.txtInj_ref.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInj_ref.Enabled = False
        Me.txtInj_ref.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInj_ref.Location = New System.Drawing.Point(678, 192)
        Me.txtInj_ref.Name = "txtInj_ref"
        Me.txtInj_ref.Size = New System.Drawing.Size(252, 22)
        Me.txtInj_ref.TabIndex = 84
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(572, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Mfd Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(572, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Injector Ref."
        '
        'txtmfd_date
        '
        Me.txtmfd_date.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmfd_date.Enabled = False
        Me.txtmfd_date.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmfd_date.Location = New System.Drawing.Point(678, 221)
        Me.txtmfd_date.Name = "txtmfd_date"
        Me.txtmfd_date.Size = New System.Drawing.Size(252, 22)
        Me.txtmfd_date.TabIndex = 82
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(572, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Exp Date"
        '
        'txtExp_date
        '
        Me.txtExp_date.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtExp_date.Enabled = False
        Me.txtExp_date.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExp_date.Location = New System.Drawing.Point(678, 254)
        Me.txtExp_date.Name = "txtExp_date"
        Me.txtExp_date.Size = New System.Drawing.Size(252, 22)
        Me.txtExp_date.TabIndex = 79
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(86, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 78
        Me.Label8.Text = "Batch No"
        '
        'CmbBatch
        '
        Me.CmbBatch.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBatch.ForeColor = System.Drawing.Color.Red
        Me.CmbBatch.FormattingEnabled = True
        Me.CmbBatch.Items.AddRange(New Object() {"1", "2", "3"})
        Me.CmbBatch.Location = New System.Drawing.Point(192, 192)
        Me.CmbBatch.Name = "CmbBatch"
        Me.CmbBatch.Size = New System.Drawing.Size(270, 26)
        Me.CmbBatch.TabIndex = 77
        '
        'txtProduct_Name
        '
        Me.txtProduct_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProduct_Name.Enabled = False
        Me.txtProduct_Name.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduct_Name.Location = New System.Drawing.Point(676, 291)
        Me.txtProduct_Name.Name = "txtProduct_Name"
        Me.txtProduct_Name.Size = New System.Drawing.Size(255, 22)
        Me.txtProduct_Name.TabIndex = 96
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(88, 241)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "Total Qty"
        '
        'txtTotal_Qty
        '
        Me.txtTotal_Qty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotal_Qty.Enabled = False
        Me.txtTotal_Qty.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal_Qty.Location = New System.Drawing.Point(192, 239)
        Me.txtTotal_Qty.Name = "txtTotal_Qty"
        Me.txtTotal_Qty.Size = New System.Drawing.Size(112, 22)
        Me.txtTotal_Qty.TabIndex = 97
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(323, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 16)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Accepted Qty"
        '
        'txtAccepted_Qty
        '
        Me.txtAccepted_Qty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAccepted_Qty.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccepted_Qty.Location = New System.Drawing.Point(425, 284)
        Me.txtAccepted_Qty.Name = "txtAccepted_Qty"
        Me.txtAccepted_Qty.Size = New System.Drawing.Size(112, 22)
        Me.txtAccepted_Qty.TabIndex = 99
        '
        'txtRejected_qty
        '
        Me.txtRejected_qty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRejected_qty.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRejected_qty.Location = New System.Drawing.Point(192, 331)
        Me.txtRejected_qty.Name = "txtRejected_qty"
        Me.txtRejected_qty.Size = New System.Drawing.Size(112, 22)
        Me.txtRejected_qty.TabIndex = 99
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(90, 333)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 16)
        Me.Label10.TabIndex = 100
        Me.Label10.Text = "Rejected Qty"
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(89, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(841, 100)
        Me.GroupBox1.TabIndex = 136
        Me.GroupBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(232, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(362, 29)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "INJECTOR INSPECTION FORM"
        '
        'FrmInjectorInspection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1015, 617)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRejected_qty)
        Me.Controls.Add(Me.txtAccepted_Qty)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotal_Qty)
        Me.Controls.Add(Me.txtProduct_Name)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMTS_NO)
        Me.Controls.Add(Me.txtReceived_qty)
        Me.Controls.Add(Me.txtInj_ref)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtmfd_date)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtExp_date)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CmbBatch)
        Me.Name = "FrmInjectorInspection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMTS_NO As System.Windows.Forms.TextBox
    Friend WithEvents txtReceived_qty As System.Windows.Forms.TextBox
    Friend WithEvents txtInj_ref As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtmfd_date As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtExp_date As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CmbBatch As System.Windows.Forms.ComboBox
    Friend WithEvents txtProduct_Name As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTotal_Qty As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAccepted_Qty As System.Windows.Forms.TextBox
    Friend WithEvents txtRejected_qty As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
