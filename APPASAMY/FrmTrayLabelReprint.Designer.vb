<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTrayLabelReprint
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
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnView = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmbRack = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.dataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label4 = New System.Windows.Forms.Label
        Me.CryViewRackBin = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 565)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 25)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "From Date"
        Me.Label1.Visible = False
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFromDate.Location = New System.Drawing.Point(238, 560)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(246, 31)
        Me.dtpFromDate.TabIndex = 50
        Me.dtpFromDate.Visible = False
        '
        'dtpToDate
        '
        Me.dtpToDate.Enabled = False
        Me.dtpToDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpToDate.Location = New System.Drawing.Point(160, 31)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(246, 31)
        Me.dtpToDate.TabIndex = 50
        Me.dtpToDate.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 25)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Date"
        Me.Label2.Visible = False
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(30, 615)
        Me.btnView.Margin = New System.Windows.Forms.Padding(2)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(141, 32)
        Me.btnView.TabIndex = 61
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        Me.btnView.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CmbRack)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.dtpToDate)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 284)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 98)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 25)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Rack"
        '
        'CmbRack
        '
        Me.CmbRack.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbRack.FormattingEnabled = True
        Me.CmbRack.Location = New System.Drawing.Point(160, 100)
        Me.CmbRack.Name = "CmbRack"
        Me.CmbRack.Size = New System.Drawing.Size(246, 26)
        Me.CmbRack.TabIndex = 65
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnExit)
        Me.GroupBox2.Controls.Add(Me.btnPrint)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 148)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(408, 112)
        Me.GroupBox2.TabIndex = 64
        Me.GroupBox2.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(271, 43)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 32)
        Me.btnExit.TabIndex = 61
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(35, 43)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(120, 32)
        Me.btnPrint.TabIndex = 61
        Me.btnPrint.Text = "View"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.AllowUserToDeleteRows = False
        Me.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dataGridView1.Location = New System.Drawing.Point(266, 597)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.RowTemplate.Height = 24
        Me.dataGridView1.Size = New System.Drawing.Size(218, 142)
        Me.dataGridView1.TabIndex = 63
        Me.dataGridView1.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(60, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(328, 26)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Daily Rack Bin Card Updation"
        '
        'CryViewRackBin
        '
        Me.CryViewRackBin.ActiveViewIndex = -1
        Me.CryViewRackBin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CryViewRackBin.Location = New System.Drawing.Point(500, 19)
        Me.CryViewRackBin.Name = "CryViewRackBin"
        Me.CryViewRackBin.SelectionFormula = ""
        Me.CryViewRackBin.Size = New System.Drawing.Size(1014, 709)
        Me.CryViewRackBin.TabIndex = 62
        Me.CryViewRackBin.ViewTimeSelectionFormula = ""
        '
        'FrmTrayLabelReprint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1544, 740)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.CryViewRackBin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpFromDate)
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmTrayLabelReprint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CryViewRackBin As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmbRack As System.Windows.Forms.ComboBox
End Class
