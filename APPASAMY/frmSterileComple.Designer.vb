<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSterileComple
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Btc_no = New System.Windows.Forms.ComboBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label7 = New System.Windows.Forms.Label
        Me.bplchk = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.cmb_test = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnComplete = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(31, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(976, 100)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(373, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(273, 29)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "STERILITY COMPLETE"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnComplete)
        Me.GroupBox2.Controls.Add(Me.cmb_test)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Btc_no)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(31, 165)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(757, 498)
        Me.GroupBox2.TabIndex = 66
        Me.GroupBox2.TabStop = False
        '
        'Btc_no
        '
        Me.Btc_no.FormattingEnabled = True
        Me.Btc_no.Location = New System.Drawing.Point(235, 48)
        Me.Btc_no.Name = "Btc_no"
        Me.Btc_no.Size = New System.Drawing.Size(261, 23)
        Me.Btc_no.TabIndex = 75
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bplchk})
        Me.DataGridView1.Location = New System.Drawing.Point(62, 111)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(386, 333)
        Me.DataGridView1.TabIndex = 74
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(44, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 29)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Batch number"
        '
        'bplchk
        '
        Me.bplchk.HeaderText = "Select Srno"
        Me.bplchk.Name = "bplchk"
        '
        'cmb_test
        '
        Me.cmb_test.FormattingEnabled = True
        Me.cmb_test.Items.AddRange(New Object() {"LAL TEST"})
        Me.cmb_test.Location = New System.Drawing.Point(522, 172)
        Me.cmb_test.Name = "cmb_test"
        Me.cmb_test.Size = New System.Drawing.Size(183, 23)
        Me.cmb_test.TabIndex = 77
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(517, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 29)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Select Test Type"
        '
        'BtnComplete
        '
        Me.BtnComplete.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnComplete.ForeColor = System.Drawing.Color.Red
        Me.BtnComplete.Location = New System.Drawing.Point(547, 252)
        Me.BtnComplete.Name = "BtnComplete"
        Me.BtnComplete.Size = New System.Drawing.Size(108, 42)
        Me.BtnComplete.TabIndex = 78
        Me.BtnComplete.Text = "UPDATE"
        Me.BtnComplete.UseVisualStyleBackColor = True
        '
        'frmSterileComple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1036, 734)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSterileComple"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Btc_no As System.Windows.Forms.ComboBox
    Friend WithEvents bplchk As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cmb_test As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnComplete As System.Windows.Forms.Button
End Class
