<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUniqueno
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txttoslno = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.GRID2 = New System.Windows.Forms.DataGridView
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtfrmslno = New System.Windows.Forms.TextBox
        Me.cmbTolotno = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnClear = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lbldate = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblUser = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtlotbarno = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblSterNo = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblcount = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.CmbStType = New System.Windows.Forms.ComboBox
        Me.CmbStOvenid = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(19, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Lot_Slno To"
        '
        'txttoslno
        '
        Me.txttoslno.Location = New System.Drawing.Point(150, 131)
        Me.txttoslno.Name = "txttoslno"
        Me.txttoslno.Size = New System.Drawing.Size(138, 20)
        Me.txttoslno.TabIndex = 20
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(322, 7)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 42)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GRID2
        '
        Me.GRID2.AllowUserToDeleteRows = False
        Me.GRID2.BackgroundColor = System.Drawing.Color.White
        Me.GRID2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GRID2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.GRID2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GRID2.Location = New System.Drawing.Point(570, 73)
        Me.GRID2.Name = "GRID2"
        Me.GRID2.Size = New System.Drawing.Size(230, 300)
        Me.GRID2.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(320, 535)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Ok"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(180, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 42)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(19, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Lot_Slno From"
        '
        'txtfrmslno
        '
        Me.txtfrmslno.Location = New System.Drawing.Point(150, 94)
        Me.txtfrmslno.Name = "txtfrmslno"
        Me.txtfrmslno.Size = New System.Drawing.Size(138, 20)
        Me.txtfrmslno.TabIndex = 14
        '
        'cmbTolotno
        '
        Me.cmbTolotno.FormattingEnabled = True
        Me.cmbTolotno.Location = New System.Drawing.Point(150, 16)
        Me.cmbTolotno.Name = "cmbTolotno"
        Me.cmbTolotno.Size = New System.Drawing.Size(138, 21)
        Me.cmbTolotno.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(19, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Lot No. "
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnClear)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(12, 386)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(762, 67)
        Me.Panel1.TabIndex = 22
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.Red
        Me.BtnClear.Location = New System.Drawing.Point(464, 7)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(108, 42)
        Me.BtnClear.TabIndex = 20
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtfrmslno)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txttoslno)
        Me.Panel2.Controls.Add(Me.cmbTolotno)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(872, 22)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(60, 50)
        Me.Panel2.TabIndex = 23
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Navy
        Me.Panel3.Controls.Add(Me.lbldate)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.lblUser)
        Me.Panel3.Location = New System.Drawing.Point(3, 20)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(798, 52)
        Me.Panel3.TabIndex = 24
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.Color.Blue
        Me.lbldate.Location = New System.Drawing.Point(723, 34)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(40, 16)
        Me.lbldate.TabIndex = 28
        Me.lbldate.Text = "User "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(269, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(220, 43)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Sterilization"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Blue
        Me.lblUser.Location = New System.Drawing.Point(721, 7)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(40, 16)
        Me.lblUser.TabIndex = 27
        Me.lblUser.Text = "User "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(29, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 29)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Scan Lot No"
        '
        'txtlotbarno
        '
        Me.txtlotbarno.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlotbarno.Location = New System.Drawing.Point(198, 34)
        Me.txtlotbarno.Name = "txtlotbarno"
        Me.txtlotbarno.Size = New System.Drawing.Size(317, 48)
        Me.txtlotbarno.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(11, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 18)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Sterilization No"
        '
        'lblSterNo
        '
        Me.lblSterNo.AutoSize = True
        Me.lblSterNo.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSterNo.ForeColor = System.Drawing.Color.Blue
        Me.lblSterNo.Location = New System.Drawing.Point(132, 17)
        Me.lblSterNo.Name = "lblSterNo"
        Me.lblSterNo.Size = New System.Drawing.Size(151, 33)
        Me.lblSterNo.TabIndex = 30
        Me.lblSterNo.Text = "Lot No. "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(73, 27)
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
        Me.lblcount.Location = New System.Drawing.Point(95, 67)
        Me.lblcount.Name = "lblcount"
        Me.lblcount.Size = New System.Drawing.Size(35, 40)
        Me.lblcount.TabIndex = 32
        Me.lblcount.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(11, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 16)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Type"
        '
        'CmbStType
        '
        Me.CmbStType.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbStType.FormattingEnabled = True
        Me.CmbStType.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.CmbStType.Location = New System.Drawing.Point(135, 86)
        Me.CmbStType.Name = "CmbStType"
        Me.CmbStType.Size = New System.Drawing.Size(151, 24)
        Me.CmbStType.TabIndex = 0
        '
        'CmbStOvenid
        '
        Me.CmbStOvenid.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbStOvenid.FormattingEnabled = True
        Me.CmbStOvenid.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.CmbStOvenid.Location = New System.Drawing.Point(135, 118)
        Me.CmbStOvenid.Name = "CmbStOvenid"
        Me.CmbStOvenid.Size = New System.Drawing.Size(151, 24)
        Me.CmbStOvenid.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(11, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 16)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Oven ID"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lblSterNo)
        Me.Panel4.Controls.Add(Me.CmbStOvenid)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.CmbStType)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Location = New System.Drawing.Point(12, 78)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(326, 156)
        Me.Panel4.TabIndex = 37
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.lblcount)
        Me.Panel5.Location = New System.Drawing.Point(346, 80)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(219, 156)
        Me.Panel5.TabIndex = 38
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.txtlotbarno)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Location = New System.Drawing.Point(12, 242)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(553, 136)
        Me.Panel7.TabIndex = 40
        '
        'FrmUniqueno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(803, 475)
        Me.Controls.Add(Me.GRID2)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmUniqueno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txttoslno As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GRID2 As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtfrmslno As System.Windows.Forms.TextBox
    Friend WithEvents cmbTolotno As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtlotbarno As System.Windows.Forms.TextBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblSterNo As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblcount As System.Windows.Forms.Label
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CmbStType As System.Windows.Forms.ComboBox
    Friend WithEvents CmbStOvenid As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
End Class
