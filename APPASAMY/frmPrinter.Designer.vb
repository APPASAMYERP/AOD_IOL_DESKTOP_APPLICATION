<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrinter
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtpntname = New System.Windows.Forms.TextBox
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.btnexit = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdbedit = New System.Windows.Forms.RadioButton
        Me.rdbnew = New System.Windows.Forms.RadioButton
        Me.gbxnew = New System.Windows.Forms.GroupBox
        Me.gbxedit = New System.Windows.Forms.GroupBox
        Me.txtpname = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbxpname = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.gbxnew.SuspendLayout()
        Me.gbxedit.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Printer Name"
        '
        'txtpntname
        '
        Me.txtpntname.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpntname.Location = New System.Drawing.Point(239, 25)
        Me.txtpntname.Name = "txtpntname"
        Me.txtpntname.Size = New System.Drawing.Size(181, 26)
        Me.txtpntname.TabIndex = 1
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(56, 32)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(92, 50)
        Me.btnsave.TabIndex = 2
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(225, 32)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(96, 50)
        Me.btnclear.TabIndex = 3
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(397, 32)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(91, 50)
        Me.btnexit.TabIndex = 4
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbedit)
        Me.GroupBox1.Controls.Add(Me.rdbnew)
        Me.GroupBox1.Location = New System.Drawing.Point(129, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(563, 45)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'rdbedit
        '
        Me.rdbedit.AutoSize = True
        Me.rdbedit.ForeColor = System.Drawing.Color.Red
        Me.rdbedit.Location = New System.Drawing.Point(330, 19)
        Me.rdbedit.Name = "rdbedit"
        Me.rdbedit.Size = New System.Drawing.Size(43, 17)
        Me.rdbedit.TabIndex = 1
        Me.rdbedit.TabStop = True
        Me.rdbedit.Text = "Edit"
        Me.rdbedit.UseVisualStyleBackColor = True
        '
        'rdbnew
        '
        Me.rdbnew.AutoSize = True
        Me.rdbnew.ForeColor = System.Drawing.Color.Red
        Me.rdbnew.Location = New System.Drawing.Point(112, 19)
        Me.rdbnew.Name = "rdbnew"
        Me.rdbnew.Size = New System.Drawing.Size(47, 17)
        Me.rdbnew.TabIndex = 0
        Me.rdbnew.TabStop = True
        Me.rdbnew.Text = "New"
        Me.rdbnew.UseVisualStyleBackColor = True
        '
        'gbxnew
        '
        Me.gbxnew.Controls.Add(Me.txtpntname)
        Me.gbxnew.Controls.Add(Me.Label1)
        Me.gbxnew.Location = New System.Drawing.Point(129, 166)
        Me.gbxnew.Name = "gbxnew"
        Me.gbxnew.Size = New System.Drawing.Size(550, 148)
        Me.gbxnew.TabIndex = 6
        Me.gbxnew.TabStop = False
        '
        'gbxedit
        '
        Me.gbxedit.Controls.Add(Me.txtpname)
        Me.gbxedit.Controls.Add(Me.Label3)
        Me.gbxedit.Controls.Add(Me.cbxpname)
        Me.gbxedit.Controls.Add(Me.Label2)
        Me.gbxedit.Location = New System.Drawing.Point(129, 166)
        Me.gbxedit.Name = "gbxedit"
        Me.gbxedit.Size = New System.Drawing.Size(557, 151)
        Me.gbxedit.TabIndex = 7
        Me.gbxedit.TabStop = False
        '
        'txtpname
        '
        Me.txtpname.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpname.Location = New System.Drawing.Point(253, 91)
        Me.txtpname.Name = "txtpname"
        Me.txtpname.Size = New System.Drawing.Size(181, 26)
        Me.txtpname.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Enter Printer Name"
        '
        'cbxpname
        '
        Me.cbxpname.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxpname.FormattingEnabled = True
        Me.cbxpname.Location = New System.Drawing.Point(253, 41)
        Me.cbxpname.Name = "cbxpname"
        Me.cbxpname.Size = New System.Drawing.Size(181, 24)
        Me.cbxpname.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Printer Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnexit)
        Me.GroupBox2.Controls.Add(Me.btnsave)
        Me.GroupBox2.Controls.Add(Me.btnclear)
        Me.GroupBox2.Location = New System.Drawing.Point(129, 336)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(557, 121)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'Err
        '
        Me.Err.ContainerControl = Me
        '
        'frmPrinter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(837, 544)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbxedit)
        Me.Controls.Add(Me.gbxnew)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPrinter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbxnew.ResumeLayout(False)
        Me.gbxnew.PerformLayout()
        Me.gbxedit.ResumeLayout(False)
        Me.gbxedit.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtpntname As System.Windows.Forms.TextBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbxnew As System.Windows.Forms.GroupBox
    Friend WithEvents txtpname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbxedit As System.Windows.Forms.GroupBox
    Friend WithEvents cbxpname As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rdbedit As System.Windows.Forms.RadioButton
    Friend WithEvents rdbnew As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Err As System.Windows.Forms.ErrorProvider
End Class
