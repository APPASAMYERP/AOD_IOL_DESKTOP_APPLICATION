<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPowerUpdation
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
        Me.txtlotsrno = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbnewpower = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtBrand = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtModel = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtoldpower = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblgscode = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(230, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LotSrNo"
        '
        'txtlotsrno
        '
        Me.txtlotsrno.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlotsrno.Location = New System.Drawing.Point(308, 31)
        Me.txtlotsrno.Name = "txtlotsrno"
        Me.txtlotsrno.Size = New System.Drawing.Size(199, 25)
        Me.txtlotsrno.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(19, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "New Power"
        '
        'cmbnewpower
        '
        Me.cmbnewpower.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbnewpower.FormattingEnabled = True
        Me.cmbnewpower.Location = New System.Drawing.Point(111, 178)
        Me.cmbnewpower.Name = "cmbnewpower"
        Me.cmbnewpower.Size = New System.Drawing.Size(75, 24)
        Me.cmbnewpower.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(124, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 46)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtBrand
        '
        Me.txtBrand.Enabled = False
        Me.txtBrand.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtBrand.Location = New System.Drawing.Point(75, 112)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.Size = New System.Drawing.Size(194, 22)
        Me.txtBrand.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(19, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Brand"
        '
        'txtModel
        '
        Me.txtModel.Enabled = False
        Me.txtModel.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtModel.Location = New System.Drawing.Point(373, 112)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(158, 22)
        Me.txtModel.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(305, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Model"
        '
        'txtoldpower
        '
        Me.txtoldpower.Enabled = False
        Me.txtoldpower.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtoldpower.Location = New System.Drawing.Point(624, 114)
        Me.txtoldpower.Name = "txtoldpower"
        Me.txtoldpower.Size = New System.Drawing.Size(51, 22)
        Me.txtoldpower.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(568, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Power"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(624, 216)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 25)
        Me.TextBox5.TabIndex = 12
        Me.TextBox5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(541, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 18)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "New LotSrNo"
        Me.Label6.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.Navy
        Me.Button2.Location = New System.Drawing.Point(280, 49)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 46)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(411, 49)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 46)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(109, 301)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(619, 141)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Action"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.txtlotsrno)
        Me.GroupBox2.Controls.Add(Me.txtoldpower)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtModel)
        Me.GroupBox2.Controls.Add(Me.cmbnewpower)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtBrand)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(56, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(750, 254)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Details"
        '
        'lblgscode
        '
        Me.lblgscode.AutoSize = True
        Me.lblgscode.Location = New System.Drawing.Point(455, 193)
        Me.lblgscode.Name = "lblgscode"
        Me.lblgscode.Size = New System.Drawing.Size(0, 13)
        Me.lblgscode.TabIndex = 17
        Me.lblgscode.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"AI", "AOD"})
        Me.ComboBox1.Location = New System.Drawing.Point(402, 176)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(99, 26)
        Me.ComboBox1.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(283, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 18)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Type GS Code"
        '
        'FrmPowerUpdation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(949, 534)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblgscode)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPowerUpdation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtlotsrno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbnewpower As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtBrand As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtoldpower As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblgscode As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
