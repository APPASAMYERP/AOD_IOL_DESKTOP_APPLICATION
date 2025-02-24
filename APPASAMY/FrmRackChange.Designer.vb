<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRackChange
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRackChange))
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.toLocationGRID1 = New System.Windows.Forms.DataGridView
        Me.GRID1 = New System.Windows.Forms.DataGridView
        Me.cmbRackTo = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbRackFrom = New System.Windows.Forms.ComboBox
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.BtnComplete_rackBased = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnComplete_trayBased = New System.Windows.Forms.Button
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.rdTrayBased = New System.Windows.Forms.RadioButton
        Me.rdRackBased = New System.Windows.Forms.RadioButton
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.toLocationGRID2 = New System.Windows.Forms.DataGridView
        Me.GRID2 = New System.Windows.Forms.DataGridView
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.cmbrackLocation = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnClear = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbTrayNo = New System.Windows.Forms.ComboBox
        Me.lblTrayNo = New System.Windows.Forms.Label
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox9.SuspendLayout()
        CType(Me.toLocationGRID1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRID1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.toLocationGRID2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label7)
        Me.GroupBox9.Controls.Add(Me.Label5)
        Me.GroupBox9.Controls.Add(Me.toLocationGRID1)
        Me.GroupBox9.Controls.Add(Me.GRID1)
        Me.GroupBox9.Controls.Add(Me.cmbRackTo)
        Me.GroupBox9.Controls.Add(Me.Label2)
        Me.GroupBox9.Controls.Add(Me.cmbRackFrom)
        Me.GroupBox9.Controls.Add(Me.GroupBox10)
        Me.GroupBox9.Controls.Add(Me.Label1)
        Me.GroupBox9.Location = New System.Drawing.Point(16, 119)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(1274, 241)
        Me.GroupBox9.TabIndex = 73
        Me.GroupBox9.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(954, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(231, 29)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "To Location Tray No"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(615, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(261, 29)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "From Location Tray No"
        '
        'toLocationGRID1
        '
        Me.toLocationGRID1.AllowUserToDeleteRows = False
        Me.toLocationGRID1.BackgroundColor = System.Drawing.Color.White
        Me.toLocationGRID1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.toLocationGRID1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.toLocationGRID1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.toLocationGRID1.Location = New System.Drawing.Point(959, 70)
        Me.toLocationGRID1.Name = "toLocationGRID1"
        Me.toLocationGRID1.Size = New System.Drawing.Size(273, 152)
        Me.toLocationGRID1.TabIndex = 60
        '
        'GRID1
        '
        Me.GRID1.AllowUserToDeleteRows = False
        Me.GRID1.BackgroundColor = System.Drawing.Color.White
        Me.GRID1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GRID1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.GRID1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GRID1.Location = New System.Drawing.Point(620, 70)
        Me.GRID1.Name = "GRID1"
        Me.GRID1.Size = New System.Drawing.Size(273, 152)
        Me.GRID1.TabIndex = 60
        '
        'cmbRackTo
        '
        Me.cmbRackTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRackTo.FormattingEnabled = True
        Me.cmbRackTo.Location = New System.Drawing.Point(270, 84)
        Me.cmbRackTo.Name = "cmbRackTo"
        Me.cmbRackTo.Size = New System.Drawing.Size(317, 32)
        Me.cmbRackTo.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(31, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 29)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Rack Location To"
        '
        'cmbRackFrom
        '
        Me.cmbRackFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRackFrom.FormattingEnabled = True
        Me.cmbRackFrom.Location = New System.Drawing.Point(270, 24)
        Me.cmbRackFrom.Name = "cmbRackFrom"
        Me.cmbRackFrom.Size = New System.Drawing.Size(317, 32)
        Me.cmbRackFrom.TabIndex = 51
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Button1)
        Me.GroupBox10.Controls.Add(Me.BtnComplete_rackBased)
        Me.GroupBox10.Controls.Add(Me.Button3)
        Me.GroupBox10.Location = New System.Drawing.Point(57, 131)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(519, 91)
        Me.GroupBox10.TabIndex = 58
        Me.GroupBox10.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(199, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 42)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnComplete_rackBased
        '
        Me.BtnComplete_rackBased.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnComplete_rackBased.ForeColor = System.Drawing.Color.Red
        Me.BtnComplete_rackBased.Location = New System.Drawing.Point(34, 28)
        Me.BtnComplete_rackBased.Name = "BtnComplete_rackBased"
        Me.BtnComplete_rackBased.Size = New System.Drawing.Size(108, 42)
        Me.BtnComplete_rackBased.TabIndex = 3
        Me.BtnComplete_rackBased.Text = "Complete"
        Me.BtnComplete_rackBased.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(380, 28)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 42)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(31, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 29)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Rack Location From"
        '
        'btnComplete_trayBased
        '
        Me.btnComplete_trayBased.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComplete_trayBased.ForeColor = System.Drawing.Color.Red
        Me.btnComplete_trayBased.Location = New System.Drawing.Point(43, 28)
        Me.btnComplete_trayBased.Name = "btnComplete_trayBased"
        Me.btnComplete_trayBased.Size = New System.Drawing.Size(108, 42)
        Me.btnComplete_trayBased.TabIndex = 3
        Me.btnComplete_trayBased.Text = "Complete"
        Me.btnComplete_trayBased.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.rdTrayBased)
        Me.GroupBox7.Controls.Add(Me.rdRackBased)
        Me.GroupBox7.Location = New System.Drawing.Point(16, 42)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(931, 71)
        Me.GroupBox7.TabIndex = 74
        Me.GroupBox7.TabStop = False
        '
        'rdTrayBased
        '
        Me.rdTrayBased.AutoSize = True
        Me.rdTrayBased.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdTrayBased.ForeColor = System.Drawing.Color.Red
        Me.rdTrayBased.Location = New System.Drawing.Point(636, 32)
        Me.rdTrayBased.Name = "rdTrayBased"
        Me.rdTrayBased.Size = New System.Drawing.Size(118, 19)
        Me.rdTrayBased.TabIndex = 72
        Me.rdTrayBased.Text = "Tray No Based"
        Me.rdTrayBased.UseVisualStyleBackColor = True
        '
        'rdRackBased
        '
        Me.rdRackBased.AutoSize = True
        Me.rdRackBased.Checked = True
        Me.rdRackBased.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdRackBased.ForeColor = System.Drawing.Color.Red
        Me.rdRackBased.Location = New System.Drawing.Point(56, 32)
        Me.rdRackBased.Name = "rdRackBased"
        Me.rdRackBased.Size = New System.Drawing.Size(98, 19)
        Me.rdRackBased.TabIndex = 71
        Me.rdRackBased.TabStop = True
        Me.rdRackBased.Text = "Rack Based"
        Me.rdRackBased.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.toLocationGRID2)
        Me.GroupBox5.Controls.Add(Me.GRID2)
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Controls.Add(Me.GroupBox2)
        Me.GroupBox5.Controls.Add(Me.GroupBox1)
        Me.GroupBox5.Location = New System.Drawing.Point(16, 379)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1274, 371)
        Me.GroupBox5.TabIndex = 72
        Me.GroupBox5.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(969, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(231, 29)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "To Location Tray No"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(615, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(263, 29)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Previous Rack Location"
        '
        'toLocationGRID2
        '
        Me.toLocationGRID2.AllowUserToDeleteRows = False
        Me.toLocationGRID2.BackgroundColor = System.Drawing.Color.White
        Me.toLocationGRID2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.toLocationGRID2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.toLocationGRID2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.toLocationGRID2.Location = New System.Drawing.Point(984, 159)
        Me.toLocationGRID2.Name = "toLocationGRID2"
        Me.toLocationGRID2.Size = New System.Drawing.Size(273, 152)
        Me.toLocationGRID2.TabIndex = 59
        '
        'GRID2
        '
        Me.GRID2.AllowUserToDeleteRows = False
        Me.GRID2.BackgroundColor = System.Drawing.Color.White
        Me.GRID2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GRID2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.GRID2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GRID2.Location = New System.Drawing.Point(620, 159)
        Me.GRID2.Name = "GRID2"
        Me.GRID2.Size = New System.Drawing.Size(273, 152)
        Me.GRID2.TabIndex = 59
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cmbrackLocation)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Location = New System.Drawing.Point(18, 140)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(569, 89)
        Me.GroupBox6.TabIndex = 70
        Me.GroupBox6.TabStop = False
        '
        'cmbrackLocation
        '
        Me.cmbrackLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbrackLocation.FormattingEnabled = True
        Me.cmbrackLocation.Location = New System.Drawing.Point(234, 19)
        Me.cmbrackLocation.Name = "cmbrackLocation"
        Me.cmbrackLocation.Size = New System.Drawing.Size(317, 32)
        Me.cmbrackLocation.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(7, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 29)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Rack Location To"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnClear)
        Me.GroupBox2.Controls.Add(Me.btnComplete_trayBased)
        Me.GroupBox2.Controls.Add(Me.BtnExit)
        Me.GroupBox2.Location = New System.Drawing.Point(56, 252)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(519, 91)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.Red
        Me.BtnClear.Location = New System.Drawing.Point(199, 28)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(108, 42)
        Me.BtnClear.TabIndex = 20
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.Red
        Me.BtnExit.Location = New System.Drawing.Point(380, 28)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(108, 42)
        Me.BtnExit.TabIndex = 19
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbTrayNo)
        Me.GroupBox1.Controls.Add(Me.lblTrayNo)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(569, 86)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        '
        'cmbTrayNo
        '
        Me.cmbTrayNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTrayNo.FormattingEnabled = True
        Me.cmbTrayNo.Location = New System.Drawing.Point(234, 36)
        Me.cmbTrayNo.Name = "cmbTrayNo"
        Me.cmbTrayNo.Size = New System.Drawing.Size(317, 32)
        Me.cmbTrayNo.TabIndex = 51
        '
        'lblTrayNo
        '
        Me.lblTrayNo.AutoSize = True
        Me.lblTrayNo.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrayNo.ForeColor = System.Drawing.Color.Blue
        Me.lblTrayNo.Location = New System.Drawing.Point(7, 35)
        Me.lblTrayNo.Name = "lblTrayNo"
        Me.lblTrayNo.Size = New System.Drawing.Size(156, 29)
        Me.lblTrayNo.TabIndex = 44
        Me.lblTrayNo.Text = "Tray Number"
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(478, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(309, 26)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Rack Location Change Form"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(1249, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 75
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'FrmRackChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1301, 756)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label4)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmRackChange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.toLocationGRID1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRID1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.toLocationGRID2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbRackTo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbRackFrom As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnComplete_trayBased As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents rdTrayBased As System.Windows.Forms.RadioButton
    Friend WithEvents rdRackBased As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbTrayNo As System.Windows.Forms.ComboBox
    Friend WithEvents lblTrayNo As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnComplete_rackBased As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbrackLocation As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GRID1 As System.Windows.Forms.DataGridView
    Friend WithEvents GRID2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents toLocationGRID1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents toLocationGRID2 As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
