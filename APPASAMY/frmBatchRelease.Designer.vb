<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBatchRelease
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Releasedate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Prntext = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtLot_size = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Steriledate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Batch = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblno = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Releasedate)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Prntext)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtLot_size)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Steriledate)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnExit)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Batch)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(82, 93)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(703, 269)
        Me.GroupBox2.TabIndex = 81
        Me.GroupBox2.TabStop = False
        '
        'Releasedate
        '
        Me.Releasedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Releasedate.Location = New System.Drawing.Point(269, 131)
        Me.Releasedate.Name = "Releasedate"
        Me.Releasedate.Size = New System.Drawing.Size(142, 23)
        Me.Releasedate.TabIndex = 100
        Me.Releasedate.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(174, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Release Date"
        Me.Label2.Visible = False
        '
        'Prntext
        '
        Me.Prntext.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prntext.Location = New System.Drawing.Point(392, 86)
        Me.Prntext.Name = "Prntext"
        Me.Prntext.Size = New System.Drawing.Size(132, 23)
        Me.Prntext.TabIndex = 98
        Me.Prntext.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(314, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "PRN No"
        Me.Label5.Visible = False
        '
        'txtLot_size
        '
        Me.txtLot_size.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLot_size.Location = New System.Drawing.Point(128, 89)
        Me.txtLot_size.Name = "txtLot_size"
        Me.txtLot_size.Size = New System.Drawing.Size(132, 23)
        Me.txtLot_size.TabIndex = 94
        Me.txtLot_size.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(39, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Lot Size"
        Me.Label4.Visible = False
        '
        'Steriledate
        '
        Me.Steriledate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Steriledate.Location = New System.Drawing.Point(392, 34)
        Me.Steriledate.Name = "Steriledate"
        Me.Steriledate.Size = New System.Drawing.Size(142, 23)
        Me.Steriledate.TabIndex = 92
        Me.Steriledate.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(300, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Sterile Date"
        Me.Label3.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(303, 197)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 42)
        Me.btnExit.TabIndex = 47
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(158, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 42)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Release"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Batch
        '
        Me.Batch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Batch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Batch.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Batch.FormattingEnabled = True
        Me.Batch.Location = New System.Drawing.Point(128, 36)
        Me.Batch.Name = "Batch"
        Me.Batch.Size = New System.Drawing.Size(152, 24)
        Me.Batch.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(39, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Batch No"
        '
        'lblno
        '
        Me.lblno.AutoSize = True
        Me.lblno.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblno.ForeColor = System.Drawing.Color.Blue
        Me.lblno.Location = New System.Drawing.Point(235, 36)
        Me.lblno.Name = "lblno"
        Me.lblno.Size = New System.Drawing.Size(258, 29)
        Me.lblno.TabIndex = 82
        Me.lblno.Text = "Batch Release Form"
        '
        'frmBatchRelease
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(814, 456)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblno)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmBatchRelease"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Batch As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblno As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Steriledate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLot_size As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Prntext As System.Windows.Forms.TextBox
    Friend WithEvents Releasedate As System.Windows.Forms.DateTimePicker
End Class
