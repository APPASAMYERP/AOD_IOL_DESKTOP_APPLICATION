<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BPL_Cancellation
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
        Me.box_col_by = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbgetid = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.REASONLBL = New System.Windows.Forms.Label
        Me.addtxt = New System.Windows.Forms.TextBox
        Me.cmp_parbpl = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbpartial = New System.Windows.Forms.CheckBox
        Me.cmbfull = New System.Windows.Forms.CheckBox
        Me.DataGridView4 = New System.Windows.Forms.DataGridView
        Me.cmbreason = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.CmbBPLNo = New System.Windows.Forms.ComboBox
        Me.DataGridView3 = New System.Windows.Forms.DataGridView
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.Button3 = New System.Windows.Forms.Button
        Me.chkbpl_collect = New System.Windows.Forms.CheckBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.bplchk = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Button2 = New System.Windows.Forms.Button
        Me.chkbpl_cancel = New System.Windows.Forms.CheckBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'box_col_by
        '
        Me.box_col_by.FormattingEnabled = True
        Me.box_col_by.Location = New System.Drawing.Point(482, 435)
        Me.box_col_by.Name = "box_col_by"
        Me.box_col_by.Size = New System.Drawing.Size(183, 23)
        Me.box_col_by.TabIndex = 70
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(33, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(852, 100)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(279, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(374, 29)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "BPL COLLECTION AND CANCEL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(6, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(194, 29)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "SELECT EMP ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(263, 435)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(194, 29)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "SELECT EMP ID"
        '
        'cmbgetid
        '
        Me.cmbgetid.FormattingEnabled = True
        Me.cmbgetid.Location = New System.Drawing.Point(206, 40)
        Me.cmbgetid.Name = "cmbgetid"
        Me.cmbgetid.Size = New System.Drawing.Size(183, 23)
        Me.cmbgetid.TabIndex = 66
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(174, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 15)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "BPL LIST"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(10, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 29)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "BPL NO "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(414, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 15)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "SELECTED BPL TO COLLECT"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(153, 378)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 42)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "BPL Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(723, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 15)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "COLLECTED BPL"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.REASONLBL)
        Me.GroupBox2.Controls.Add(Me.addtxt)
        Me.GroupBox2.Controls.Add(Me.cmp_parbpl)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cmbpartial)
        Me.GroupBox2.Controls.Add(Me.cmbfull)
        Me.GroupBox2.Controls.Add(Me.DataGridView4)
        Me.GroupBox2.Controls.Add(Me.cmbreason)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cmbgetid)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.CmbBPLNo)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(1062, 153)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(837, 486)
        Me.GroupBox2.TabIndex = 69
        Me.GroupBox2.TabStop = False
        '
        'REASONLBL
        '
        Me.REASONLBL.AutoSize = True
        Me.REASONLBL.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REASONLBL.ForeColor = System.Drawing.Color.Blue
        Me.REASONLBL.Location = New System.Drawing.Point(10, 294)
        Me.REASONLBL.Name = "REASONLBL"
        Me.REASONLBL.Size = New System.Drawing.Size(169, 29)
        Me.REASONLBL.TabIndex = 77
        Me.REASONLBL.Text = "ADD REASON"
        Me.REASONLBL.Visible = False
        '
        'addtxt
        '
        Me.addtxt.Location = New System.Drawing.Point(206, 302)
        Me.addtxt.Name = "addtxt"
        Me.addtxt.Size = New System.Drawing.Size(183, 21)
        Me.addtxt.TabIndex = 76
        Me.addtxt.Visible = False
        '
        'cmp_parbpl
        '
        Me.cmp_parbpl.FormattingEnabled = True
        Me.cmp_parbpl.Location = New System.Drawing.Point(206, 194)
        Me.cmp_parbpl.Name = "cmp_parbpl"
        Me.cmp_parbpl.Size = New System.Drawing.Size(183, 23)
        Me.cmp_parbpl.TabIndex = 75
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(10, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 29)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "BPL NO"
        '
        'cmbpartial
        '
        Me.cmbpartial.AutoSize = True
        Me.cmbpartial.ForeColor = System.Drawing.Color.Red
        Me.cmbpartial.Location = New System.Drawing.Point(206, 95)
        Me.cmbpartial.Name = "cmbpartial"
        Me.cmbpartial.Size = New System.Drawing.Size(191, 19)
        Me.cmbpartial.TabIndex = 73
        Me.cmbpartial.Text = "PARTIAL CANCELLATON"
        Me.cmbpartial.UseVisualStyleBackColor = True
        '
        'cmbfull
        '
        Me.cmbfull.AutoSize = True
        Me.cmbfull.ForeColor = System.Drawing.Color.Red
        Me.cmbfull.Location = New System.Drawing.Point(15, 95)
        Me.cmbfull.Name = "cmbfull"
        Me.cmbfull.Size = New System.Drawing.Size(165, 19)
        Me.cmbfull.TabIndex = 72
        Me.cmbfull.Text = "FULL CANCELLATON"
        Me.cmbfull.UseVisualStyleBackColor = True
        '
        'DataGridView4
        '
        Me.DataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(419, 32)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(396, 356)
        Me.DataGridView4.TabIndex = 69
        '
        'cmbreason
        '
        Me.cmbreason.FormattingEnabled = True
        Me.cmbreason.Location = New System.Drawing.Point(206, 251)
        Me.cmbreason.Name = "cmbreason"
        Me.cmbreason.Size = New System.Drawing.Size(183, 23)
        Me.cmbreason.TabIndex = 68
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(10, 251)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 29)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "REASON"
        '
        'CmbBPLNo
        '
        Me.CmbBPLNo.FormattingEnabled = True
        Me.CmbBPLNo.Location = New System.Drawing.Point(206, 143)
        Me.CmbBPLNo.Name = "CmbBPLNo"
        Me.CmbBPLNo.Size = New System.Drawing.Size(183, 23)
        Me.CmbBPLNo.TabIndex = 63
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(674, 40)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(249, 356)
        Me.DataGridView3.TabIndex = 64
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(405, 40)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(216, 356)
        Me.DataGridView2.TabIndex = 63
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(95, 424)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 42)
        Me.Button3.TabIndex = 45
        Me.Button3.Text = "VIEW"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'chkbpl_collect
        '
        Me.chkbpl_collect.AutoSize = True
        Me.chkbpl_collect.Checked = True
        Me.chkbpl_collect.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkbpl_collect.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbpl_collect.ForeColor = System.Drawing.Color.Red
        Me.chkbpl_collect.Location = New System.Drawing.Point(33, 122)
        Me.chkbpl_collect.Name = "chkbpl_collect"
        Me.chkbpl_collect.Size = New System.Drawing.Size(139, 22)
        Me.chkbpl_collect.TabIndex = 70
        Me.chkbpl_collect.Text = "BPL COLLECT"
        Me.chkbpl_collect.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.box_col_by)
        Me.GroupBox7.Controls.Add(Me.Label7)
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.Controls.Add(Me.Label2)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.DataGridView3)
        Me.GroupBox7.Controls.Add(Me.DataGridView2)
        Me.GroupBox7.Controls.Add(Me.Button3)
        Me.GroupBox7.Controls.Add(Me.DataGridView1)
        Me.GroupBox7.Controls.Add(Me.Button2)
        Me.GroupBox7.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Red
        Me.GroupBox7.Location = New System.Drawing.Point(33, 145)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(974, 494)
        Me.GroupBox7.TabIndex = 67
        Me.GroupBox7.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bplchk})
        Me.DataGridView1.Location = New System.Drawing.Point(45, 40)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(319, 356)
        Me.DataGridView1.TabIndex = 44
        '
        'bplchk
        '
        Me.bplchk.HeaderText = "Select Bpl"
        Me.bplchk.Name = "bplchk"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(739, 420)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 42)
        Me.Button2.TabIndex = 43
        Me.Button2.Text = "BPL Collected"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'chkbpl_cancel
        '
        Me.chkbpl_cancel.AutoSize = True
        Me.chkbpl_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.chkbpl_cancel.ForeColor = System.Drawing.Color.Red
        Me.chkbpl_cancel.Location = New System.Drawing.Point(1077, 117)
        Me.chkbpl_cancel.Name = "chkbpl_cancel"
        Me.chkbpl_cancel.Size = New System.Drawing.Size(129, 22)
        Me.chkbpl_cancel.TabIndex = 71
        Me.chkbpl_cancel.Text = "BPL CANCEL"
        Me.chkbpl_cancel.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.Location = New System.Drawing.Point(958, 674)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(113, 42)
        Me.Button4.TabIndex = 72
        Me.Button4.Text = "EXIT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'BPL_Cancellation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1924, 1058)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.chkbpl_collect)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.chkbpl_cancel)
        Me.ForeColor = System.Drawing.Color.Red
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BPL_Cancellation"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents box_col_by As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbgetid As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbBPLNo As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents chkbpl_collect As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents bplchk As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents chkbpl_cancel As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbreason As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents cmbpartial As System.Windows.Forms.CheckBox
    Friend WithEvents cmbfull As System.Windows.Forms.CheckBox
    Friend WithEvents cmp_parbpl As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents REASONLBL As System.Windows.Forms.Label
    Friend WithEvents addtxt As System.Windows.Forms.TextBox
End Class
