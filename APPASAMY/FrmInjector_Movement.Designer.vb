<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInjector_Movement
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
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMoved_qty = New System.Windows.Forms.TextBox
        Me.txtAvailable_Qty = New System.Windows.Forms.TextBox
        Me.txtProduct_Name = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.BtnClear = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.Save = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtInj_ref = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtmfd_date = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtExp_date = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.CmbBatch = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.CmbLocation = New System.Windows.Forms.ComboBox
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtMTS_NO = New System.Windows.Forms.TextBox
        Me.GRID2 = New System.Windows.Forms.DataGridView
        Me.btn_Add = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblTotBplQty = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Inj_Batch = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Inj_Ref = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Mfd_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Exp_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Product_Name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Total_Qty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Moved_Qty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Moved_Location = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox5.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(343, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 16)
        Me.Label5.TabIndex = 131
        Me.Label5.Text = " Qty"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(81, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Available Qty"
        '
        'txtMoved_qty
        '
        Me.txtMoved_qty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMoved_qty.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMoved_qty.Location = New System.Drawing.Point(383, 243)
        Me.txtMoved_qty.Name = "txtMoved_qty"
        Me.txtMoved_qty.Size = New System.Drawing.Size(112, 22)
        Me.txtMoved_qty.TabIndex = 129
        '
        'txtAvailable_Qty
        '
        Me.txtAvailable_Qty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAvailable_Qty.Enabled = False
        Me.txtAvailable_Qty.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailable_Qty.Location = New System.Drawing.Point(179, 243)
        Me.txtAvailable_Qty.Name = "txtAvailable_Qty"
        Me.txtAvailable_Qty.Size = New System.Drawing.Size(112, 22)
        Me.txtAvailable_Qty.TabIndex = 130
        '
        'txtProduct_Name
        '
        Me.txtProduct_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProduct_Name.Enabled = False
        Me.txtProduct_Name.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduct_Name.Location = New System.Drawing.Point(686, 283)
        Me.txtProduct_Name.Name = "txtProduct_Name"
        Me.txtProduct_Name.Size = New System.Drawing.Size(255, 22)
        Me.txtProduct_Name.TabIndex = 128
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnClear)
        Me.GroupBox5.Controls.Add(Me.BtnExit)
        Me.GroupBox5.Controls.Add(Me.Save)
        Me.GroupBox5.Location = New System.Drawing.Point(81, 568)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(847, 80)
        Me.GroupBox5.TabIndex = 127
        Me.GroupBox5.TabStop = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.White
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.Navy
        Me.BtnClear.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnClear.Location = New System.Drawing.Point(360, 29)
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
        Me.BtnExit.Location = New System.Drawing.Point(672, 29)
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
        Me.Label9.Location = New System.Drawing.Point(582, 285)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 16)
        Me.Label9.TabIndex = 126
        Me.Label9.Text = "Product Name"
        '
        'txtInj_ref
        '
        Me.txtInj_ref.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInj_ref.Enabled = False
        Me.txtInj_ref.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInj_ref.Location = New System.Drawing.Point(688, 184)
        Me.txtInj_ref.Name = "txtInj_ref"
        Me.txtInj_ref.Size = New System.Drawing.Size(252, 22)
        Me.txtInj_ref.TabIndex = 125
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(582, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 124
        Me.Label3.Text = "Mfd Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(582, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "Injector Ref."
        '
        'txtmfd_date
        '
        Me.txtmfd_date.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmfd_date.Enabled = False
        Me.txtmfd_date.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmfd_date.Location = New System.Drawing.Point(688, 213)
        Me.txtmfd_date.Name = "txtmfd_date"
        Me.txtmfd_date.Size = New System.Drawing.Size(252, 22)
        Me.txtmfd_date.TabIndex = 123
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(582, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 121
        Me.Label4.Text = "Exp Date"
        '
        'txtExp_date
        '
        Me.txtExp_date.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtExp_date.Enabled = False
        Me.txtExp_date.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExp_date.Location = New System.Drawing.Point(688, 246)
        Me.txtExp_date.Name = "txtExp_date"
        Me.txtExp_date.Size = New System.Drawing.Size(252, 22)
        Me.txtExp_date.TabIndex = 120
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(79, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 119
        Me.Label8.Text = "Batch No"
        '
        'CmbBatch
        '
        Me.CmbBatch.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBatch.ForeColor = System.Drawing.Color.Red
        Me.CmbBatch.FormattingEnabled = True
        Me.CmbBatch.Items.AddRange(New Object() {"1", "2", "3"})
        Me.CmbBatch.Location = New System.Drawing.Point(179, 204)
        Me.CmbBatch.Name = "CmbBatch"
        Me.CmbBatch.Size = New System.Drawing.Size(316, 26)
        Me.CmbBatch.TabIndex = 118
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(79, 282)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 16)
        Me.Label6.TabIndex = 134
        Me.Label6.Text = "Location"
        '
        'CmbLocation
        '
        Me.CmbLocation.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbLocation.ForeColor = System.Drawing.Color.Red
        Me.CmbLocation.FormattingEnabled = True
        Me.CmbLocation.Items.AddRange(New Object() {"Box_Packing", "Despatch"})
        Me.CmbLocation.Location = New System.Drawing.Point(179, 276)
        Me.CmbLocation.Name = "CmbLocation"
        Me.CmbLocation.Size = New System.Drawing.Size(316, 26)
        Me.CmbLocation.TabIndex = 133
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(84, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(845, 100)
        Me.GroupBox1.TabIndex = 135
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(229, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(366, 29)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "INJECTOR STOCK MOVEMENT"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(81, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 16)
        Me.Label10.TabIndex = 137
        Me.Label10.Text = "MTS No"
        '
        'txtMTS_NO
        '
        Me.txtMTS_NO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMTS_NO.Enabled = False
        Me.txtMTS_NO.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMTS_NO.Location = New System.Drawing.Point(179, 153)
        Me.txtMTS_NO.Name = "txtMTS_NO"
        Me.txtMTS_NO.Size = New System.Drawing.Size(316, 22)
        Me.txtMTS_NO.TabIndex = 136
        '
        'GRID2
        '
        Me.GRID2.AllowUserToOrderColumns = True
        Me.GRID2.BackgroundColor = System.Drawing.Color.White
        Me.GRID2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GRID2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.GRID2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Inj_Batch, Me.Inj_Ref, Me.Mfd_date, Me.Exp_date, Me.Product_Name, Me.Total_Qty, Me.Moved_Qty, Me.Moved_Location})
        Me.GRID2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GRID2.Location = New System.Drawing.Point(84, 372)
        Me.GRID2.Name = "GRID2"
        Me.GRID2.Size = New System.Drawing.Size(857, 167)
        Me.GRID2.TabIndex = 138
        '
        'btn_Add
        '
        Me.btn_Add.BackColor = System.Drawing.Color.White
        Me.btn_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add.ForeColor = System.Drawing.Color.DarkGreen
        Me.btn_Add.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_Add.Location = New System.Drawing.Point(179, 320)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(94, 32)
        Me.btn_Add.TabIndex = 86
        Me.btn_Add.Text = "ADD"
        Me.btn_Add.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(163, 551)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(348, 14)
        Me.Label11.TabIndex = 141
        Me.Label11.Text = "* Delete Row : Select Particular Row and click Delete Button  in keyboard"
        '
        'lblTotBplQty
        '
        Me.lblTotBplQty.AutoSize = True
        Me.lblTotBplQty.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotBplQty.ForeColor = System.Drawing.Color.Blue
        Me.lblTotBplQty.Location = New System.Drawing.Point(696, 542)
        Me.lblTotBplQty.Name = "lblTotBplQty"
        Me.lblTotBplQty.Size = New System.Drawing.Size(30, 31)
        Me.lblTotBplQty.TabIndex = 140
        Me.lblTotBplQty.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(603, 547)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 18)
        Me.Label12.TabIndex = 139
        Me.Label12.Text = "Total Qty"
        '
        'Inj_Batch
        '
        Me.Inj_Batch.HeaderText = "Inj_Batch"
        Me.Inj_Batch.Name = "Inj_Batch"
        '
        'Inj_Ref
        '
        Me.Inj_Ref.HeaderText = "Inj_Ref"
        Me.Inj_Ref.Name = "Inj_Ref"
        '
        'Mfd_date
        '
        Me.Mfd_date.HeaderText = "Mfd_date"
        Me.Mfd_date.Name = "Mfd_date"
        '
        'Exp_date
        '
        Me.Exp_date.HeaderText = "Exp_date"
        Me.Exp_date.Name = "Exp_date"
        '
        'Product_Name
        '
        Me.Product_Name.HeaderText = "Product_Name"
        Me.Product_Name.Name = "Product_Name"
        '
        'Total_Qty
        '
        Me.Total_Qty.HeaderText = "Total_Qty"
        Me.Total_Qty.Name = "Total_Qty"
        '
        'Moved_Qty
        '
        Me.Moved_Qty.HeaderText = "Moved_Qty"
        Me.Moved_Qty.Name = "Moved_Qty"
        '
        'Moved_Location
        '
        Me.Moved_Location.HeaderText = "Moved_Location"
        Me.Moved_Location.Name = "Moved_Location"
        '
        'FrmInjector_Movement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1015, 673)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblTotBplQty)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GRID2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.txtMTS_NO)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CmbLocation)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMoved_qty)
        Me.Controls.Add(Me.txtAvailable_Qty)
        Me.Controls.Add(Me.txtProduct_Name)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtInj_ref)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtmfd_date)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtExp_date)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CmbBatch)
        Me.Name = "FrmInjector_Movement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMoved_qty As System.Windows.Forms.TextBox
    Friend WithEvents txtAvailable_Qty As System.Windows.Forms.TextBox
    Friend WithEvents txtProduct_Name As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtInj_ref As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtmfd_date As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtExp_date As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CmbBatch As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CmbLocation As System.Windows.Forms.ComboBox
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtMTS_NO As System.Windows.Forms.TextBox
    Friend WithEvents GRID2 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Add As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblTotBplQty As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Inj_Batch As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Inj_Ref As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mfd_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Exp_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Product_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total_Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Moved_Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Moved_Location As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
