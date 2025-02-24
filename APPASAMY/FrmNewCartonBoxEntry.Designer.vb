<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewCartonBoxEntry
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.GridSmall = New System.Windows.Forms.DataGridView
        Me.GridBig = New System.Windows.Forms.DataGridView
        Me.ChkSmallBox = New System.Windows.Forms.CheckBox
        Me.ChkBigBox = New System.Windows.Forms.CheckBox
        Me.txtsmallnoofBox = New System.Windows.Forms.TextBox
        Me.txtBignoofBox = New System.Windows.Forms.TextBox
        Me.txttotbox = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtBigEach = New System.Windows.Forms.TextBox
        Me.txtSmallEach = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnNext = New System.Windows.Forms.Button
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridSmall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridBig, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.GridSmall)
        Me.GroupBox3.Location = New System.Drawing.Point(53, 139)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(872, 305)
        Me.GroupBox3.TabIndex = 68
        Me.GroupBox3.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(281, 242)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 31)
        Me.Label15.TabIndex = 66
        Me.Label15.Text = "0"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Blue
        Me.Label19.Location = New System.Drawing.Point(151, 247)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(112, 16)
        Me.Label19.TabIndex = 65
        Me.Label19.Text = "Total Sacned Qty"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Blue
        Me.Label20.Location = New System.Drawing.Point(25, 247)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 16)
        Me.Label20.TabIndex = 43
        Me.Label20.Text = "Total Qty"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(9, 216)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(348, 14)
        Me.Label21.TabIndex = 45
        Me.Label21.Text = "* Delete Row : Select Particular Row and click Delete Button  in keyboard"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Blue
        Me.Label22.Location = New System.Drawing.Point(96, 242)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(30, 31)
        Me.Label22.TabIndex = 44
        Me.Label22.Text = "0"
        '
        'GridSmall
        '
        Me.GridSmall.AllowUserToOrderColumns = True
        Me.GridSmall.BackgroundColor = System.Drawing.Color.White
        Me.GridSmall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridSmall.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.GridSmall.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GridSmall.Location = New System.Drawing.Point(7, 15)
        Me.GridSmall.Name = "GridSmall"
        Me.GridSmall.Size = New System.Drawing.Size(406, 190)
        Me.GridSmall.TabIndex = 42
        '
        'GridBig
        '
        Me.GridBig.AllowUserToOrderColumns = True
        Me.GridBig.BackgroundColor = System.Drawing.Color.White
        Me.GridBig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridBig.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.GridBig.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GridBig.Location = New System.Drawing.Point(952, 83)
        Me.GridBig.Name = "GridBig"
        Me.GridBig.Size = New System.Drawing.Size(406, 190)
        Me.GridBig.TabIndex = 67
        '
        'ChkSmallBox
        '
        Me.ChkSmallBox.AutoSize = True
        Me.ChkSmallBox.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkSmallBox.Location = New System.Drawing.Point(69, 54)
        Me.ChkSmallBox.Name = "ChkSmallBox"
        Me.ChkSmallBox.Size = New System.Drawing.Size(88, 20)
        Me.ChkSmallBox.TabIndex = 1
        Me.ChkSmallBox.Text = "Small Box"
        Me.ChkSmallBox.UseVisualStyleBackColor = True
        '
        'ChkBigBox
        '
        Me.ChkBigBox.AutoSize = True
        Me.ChkBigBox.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBigBox.Location = New System.Drawing.Point(69, 83)
        Me.ChkBigBox.Name = "ChkBigBox"
        Me.ChkBigBox.Size = New System.Drawing.Size(73, 20)
        Me.ChkBigBox.TabIndex = 70
        Me.ChkBigBox.Text = "Big Box"
        Me.ChkBigBox.UseVisualStyleBackColor = True
        '
        'txtsmallnoofBox
        '
        Me.txtsmallnoofBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsmallnoofBox.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsmallnoofBox.Location = New System.Drawing.Point(290, 53)
        Me.txtsmallnoofBox.Name = "txtsmallnoofBox"
        Me.txtsmallnoofBox.Size = New System.Drawing.Size(104, 22)
        Me.txtsmallnoofBox.TabIndex = 2
        '
        'txtBignoofBox
        '
        Me.txtBignoofBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBignoofBox.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBignoofBox.Location = New System.Drawing.Point(290, 83)
        Me.txtBignoofBox.Name = "txtBignoofBox"
        Me.txtBignoofBox.Size = New System.Drawing.Size(104, 22)
        Me.txtBignoofBox.TabIndex = 76
        '
        'txttotbox
        '
        Me.txttotbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttotbox.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotbox.Location = New System.Drawing.Point(172, 26)
        Me.txttotbox.Name = "txttotbox"
        Me.txttotbox.Size = New System.Drawing.Size(104, 22)
        Me.txttotbox.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(70, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 14)
        Me.Label12.TabIndex = 81
        Me.Label12.Text = "Total Items"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(185, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 14)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "No of Small Box"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(185, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 14)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "No of Small Box"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(425, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 14)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Each Box Contain"
        '
        'txtBigEach
        '
        Me.txtBigEach.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBigEach.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBigEach.Location = New System.Drawing.Point(541, 83)
        Me.txtBigEach.Name = "txtBigEach"
        Me.txtBigEach.Size = New System.Drawing.Size(104, 22)
        Me.txtBigEach.TabIndex = 85
        '
        'txtSmallEach
        '
        Me.txtSmallEach.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSmallEach.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSmallEach.Location = New System.Drawing.Point(541, 53)
        Me.txtSmallEach.Name = "txtSmallEach"
        Me.txtSmallEach.Size = New System.Drawing.Size(104, 22)
        Me.txtSmallEach.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(425, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 14)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Each Box Contain"
        '
        'BtnNext
        '
        Me.BtnNext.Location = New System.Drawing.Point(744, 60)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(75, 23)
        Me.BtnNext.TabIndex = 4
        Me.BtnNext.Text = "Button1"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'FrmNewCartonBoxEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 520)
        Me.Controls.Add(Me.GridBig)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBigEach)
        Me.Controls.Add(Me.txtSmallEach)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txttotbox)
        Me.Controls.Add(Me.txtBignoofBox)
        Me.Controls.Add(Me.txtsmallnoofBox)
        Me.Controls.Add(Me.ChkBigBox)
        Me.Controls.Add(Me.ChkSmallBox)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "FrmNewCartonBoxEntry"
        Me.Text = "FrmNewCartonBoxEntry"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.GridSmall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridBig, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GridSmall As System.Windows.Forms.DataGridView
    Friend WithEvents ChkSmallBox As System.Windows.Forms.CheckBox
    Friend WithEvents ChkBigBox As System.Windows.Forms.CheckBox
    Friend WithEvents txtsmallnoofBox As System.Windows.Forms.TextBox
    Friend WithEvents txtBignoofBox As System.Windows.Forms.TextBox
    Friend WithEvents txttotbox As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBigEach As System.Windows.Forms.TextBox
    Friend WithEvents txtSmallEach As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GridBig As System.Windows.Forms.DataGridView
    Friend WithEvents BtnNext As System.Windows.Forms.Button
End Class
