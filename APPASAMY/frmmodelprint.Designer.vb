<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmodelprint
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbxmodel = New System.Windows.Forms.ComboBox
        Me.cbxpname = New System.Windows.Forms.ComboBox
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.btnexit = New System.Windows.Forms.Button
        Me.txtfilename = New System.Windows.Forms.TextBox
        Me.Err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        CType(Me.Err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Model_Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Printe_Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "File Name"
        '
        'cbxmodel
        '
        Me.cbxmodel.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxmodel.FormattingEnabled = True
        Me.cbxmodel.Location = New System.Drawing.Point(231, 51)
        Me.cbxmodel.Name = "cbxmodel"
        Me.cbxmodel.Size = New System.Drawing.Size(172, 24)
        Me.cbxmodel.TabIndex = 6
        '
        'cbxpname
        '
        Me.cbxpname.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxpname.FormattingEnabled = True
        Me.cbxpname.Location = New System.Drawing.Point(231, 95)
        Me.cbxpname.Name = "cbxpname"
        Me.cbxpname.Size = New System.Drawing.Size(172, 24)
        Me.cbxpname.TabIndex = 7
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(73, 222)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(81, 40)
        Me.btnsave.TabIndex = 9
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(194, 222)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(83, 40)
        Me.btnclear.TabIndex = 10
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(316, 222)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(87, 40)
        Me.btnexit.TabIndex = 11
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'txtfilename
        '
        Me.txtfilename.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfilename.Location = New System.Drawing.Point(231, 137)
        Me.txtfilename.Name = "txtfilename"
        Me.txtfilename.Size = New System.Drawing.Size(172, 22)
        Me.txtfilename.TabIndex = 12
        '
        'Err
        '
        Me.Err.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtfilename)
        Me.GroupBox1.Controls.Add(Me.btnexit)
        Me.GroupBox1.Controls.Add(Me.btnclear)
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Controls.Add(Me.cbxpname)
        Me.GroupBox1.Controls.Add(Me.cbxmodel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(104, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(517, 328)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'frmmodelprint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(732, 521)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmmodelprint"
        CType(Me.Err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbxmodel As System.Windows.Forms.ComboBox
    Friend WithEvents cbxpname As System.Windows.Forms.ComboBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents txtfilename As System.Windows.Forms.TextBox
    Friend WithEvents Err As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
