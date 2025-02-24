<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCheckPendingLotsToScan
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
        Me.GRID2 = New System.Windows.Forms.DataGridView
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnView = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.ChkModel = New System.Windows.Forms.CheckBox
        Me.CmbShModel = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnDownload = New System.Windows.Forms.Button
        Me.btnTest = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GRID2
        '
        Me.GRID2.AllowUserToDeleteRows = False
        Me.GRID2.BackgroundColor = System.Drawing.Color.White
        Me.GRID2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GRID2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.GRID2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GRID2.Location = New System.Drawing.Point(449, 134)
        Me.GRID2.Name = "GRID2"
        Me.GRID2.Size = New System.Drawing.Size(410, 611)
        Me.GRID2.TabIndex = 46
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.btnClear)
        Me.GroupBox10.Controls.Add(Me.btnView)
        Me.GroupBox10.Controls.Add(Me.btnExit)
        Me.GroupBox10.Location = New System.Drawing.Point(12, 234)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(419, 91)
        Me.GroupBox10.TabIndex = 59
        Me.GroupBox10.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Red
        Me.btnClear.Location = New System.Drawing.Point(157, 28)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(108, 42)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.Red
        Me.btnView.Location = New System.Drawing.Point(18, 28)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(108, 42)
        Me.btnView.TabIndex = 3
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(294, 28)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 42)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'ChkModel
        '
        Me.ChkModel.AutoSize = True
        Me.ChkModel.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkModel.ForeColor = System.Drawing.Color.Red
        Me.ChkModel.Location = New System.Drawing.Point(31, 166)
        Me.ChkModel.Name = "ChkModel"
        Me.ChkModel.Size = New System.Drawing.Size(66, 20)
        Me.ChkModel.TabIndex = 61
        Me.ChkModel.Text = "Model"
        Me.ChkModel.UseVisualStyleBackColor = True
        '
        'CmbShModel
        '
        Me.CmbShModel.Enabled = False
        Me.CmbShModel.FormattingEnabled = True
        Me.CmbShModel.Items.AddRange(New Object() {"1", "2", "3"})
        Me.CmbShModel.Location = New System.Drawing.Point(184, 166)
        Me.CmbShModel.Name = "CmbShModel"
        Me.CmbShModel.Size = New System.Drawing.Size(202, 21)
        Me.CmbShModel.TabIndex = 60
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(30, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(696, 100)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(244, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(258, 29)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "PENDING LOTS SCAN"
        '
        'btnDownload
        '
        Me.btnDownload.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDownload.ForeColor = System.Drawing.Color.Red
        Me.btnDownload.Location = New System.Drawing.Point(751, 86)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(108, 42)
        Me.btnDownload.TabIndex = 65
        Me.btnDownload.Text = "Export to Excel"
        Me.btnDownload.UseVisualStyleBackColor = True
        Me.btnDownload.Visible = False
        '
        'btnTest
        '
        Me.btnTest.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTest.ForeColor = System.Drawing.Color.Red
        Me.btnTest.Location = New System.Drawing.Point(12, 331)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(108, 42)
        Me.btnTest.TabIndex = 20
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(12, 393)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(322, 300)
        Me.DataGridView1.TabIndex = 66
        '
        'FrmCheckPendingLotsToScan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(981, 763)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ChkModel)
        Me.Controls.Add(Me.CmbShModel)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.GRID2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmCheckPendingLotsToScan"
        CType(Me.GRID2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GRID2 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents ChkModel As System.Windows.Forms.CheckBox
    Friend WithEvents CmbShModel As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnDownload As System.Windows.Forms.Button
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
