<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Me.panel1 = New System.Windows.Forms.Panel
        Me.label4 = New System.Windows.Forms.Label
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.btnclose = New System.Windows.Forms.Button
        Me.label2 = New System.Windows.Forms.Label
        Me.dtpdcfrom = New System.Windows.Forms.DateTimePicker
        Me.dtpdcto = New System.Windows.Forms.DateTimePicker
        Me.label1 = New System.Windows.Forms.Label
        Me.btngo = New System.Windows.Forms.Button
        Me.btnconvert = New System.Windows.Forms.Button
        Me.dtgexport = New System.Windows.Forms.DataGridView
        Me.groupBox2 = New System.Windows.Forms.GroupBox
        Me.label3 = New System.Windows.Forms.Label
        Me.cmbdcno = New System.Windows.Forms.ComboBox
        Me.btnsearch = New System.Windows.Forms.Button
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.btncsvexport = New System.Windows.Forms.Button
        Me.panel1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        CType(Me.dtgexport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.panel1.Controls.Add(Me.label4)
        Me.panel1.Location = New System.Drawing.Point(1, 1)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1128, 54)
        Me.panel1.TabIndex = 13
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.SystemColors.Highlight
        Me.label4.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Black
        Me.label4.Location = New System.Drawing.Point(345, 18)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(266, 24)
        Me.label4.TabIndex = 0
        Me.label4.Text = "Dispacth Note Generator"
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.White
        Me.groupBox1.Controls.Add(Me.btnclose)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.dtpdcfrom)
        Me.groupBox1.Controls.Add(Me.dtpdcto)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.btngo)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.ForeColor = System.Drawing.Color.Blue
        Me.groupBox1.Location = New System.Drawing.Point(1, 74)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(1076, 85)
        Me.groupBox1.TabIndex = 14
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Date Choose to Export"
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.White
        Me.btnclose.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.Red
        Me.btnclose.Location = New System.Drawing.Point(860, 28)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(92, 32)
        Me.btnclose.TabIndex = 7
        Me.btnclose.Text = "Exit"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Californian FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(452, 36)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(98, 16)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Dispatch Date To"
        '
        'dtpdcfrom
        '
        Me.dtpdcfrom.CustomFormat = "MM/dd/yyyy"
        Me.dtpdcfrom.Font = New System.Drawing.Font("Californian FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdcfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdcfrom.Location = New System.Drawing.Point(254, 34)
        Me.dtpdcfrom.Name = "dtpdcfrom"
        Me.dtpdcfrom.Size = New System.Drawing.Size(146, 22)
        Me.dtpdcfrom.TabIndex = 0
        '
        'dtpdcto
        '
        Me.dtpdcto.CustomFormat = "MM/dd/yyyy"
        Me.dtpdcto.Font = New System.Drawing.Font("Californian FB", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdcto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdcto.Location = New System.Drawing.Point(564, 34)
        Me.dtpdcto.Name = "dtpdcto"
        Me.dtpdcto.Size = New System.Drawing.Size(143, 22)
        Me.dtpdcto.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Californian FB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(134, 38)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(112, 16)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Dispatch Date From"
        '
        'btngo
        '
        Me.btngo.BackColor = System.Drawing.Color.White
        Me.btngo.Font = New System.Drawing.Font("Californian FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngo.Location = New System.Drawing.Point(731, 28)
        Me.btngo.Name = "btngo"
        Me.btngo.Size = New System.Drawing.Size(106, 31)
        Me.btngo.TabIndex = 6
        Me.btngo.Text = "Go"
        Me.btngo.UseVisualStyleBackColor = False
        '
        'btnconvert
        '
        Me.btnconvert.BackColor = System.Drawing.Color.White
        Me.btnconvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconvert.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnconvert.Location = New System.Drawing.Point(398, 243)
        Me.btnconvert.Name = "btnconvert"
        Me.btnconvert.Size = New System.Drawing.Size(159, 33)
        Me.btnconvert.TabIndex = 15
        Me.btnconvert.Text = "Export To Excel file"
        Me.btnconvert.UseVisualStyleBackColor = False
        '
        'dtgexport
        '
        Me.dtgexport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgexport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgexport.Location = New System.Drawing.Point(1, 292)
        Me.dtgexport.Name = "dtgexport"
        Me.dtgexport.Size = New System.Drawing.Size(1076, 455)
        Me.dtgexport.TabIndex = 16
        '
        'groupBox2
        '
        Me.groupBox2.BackColor = System.Drawing.Color.White
        Me.groupBox2.Controls.Add(Me.label3)
        Me.groupBox2.Controls.Add(Me.cmbdcno)
        Me.groupBox2.Controls.Add(Me.btnsearch)
        Me.groupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox2.ForeColor = System.Drawing.Color.Blue
        Me.groupBox2.Location = New System.Drawing.Point(26, 165)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(974, 66)
        Me.groupBox2.TabIndex = 18
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Dispatch No"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(320, 24)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(51, 16)
        Me.label3.TabIndex = 5
        Me.label3.Text = "DC. No"
        '
        'cmbdcno
        '
        Me.cmbdcno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdcno.ForeColor = System.Drawing.Color.Navy
        Me.cmbdcno.FormattingEnabled = True
        Me.cmbdcno.Location = New System.Drawing.Point(401, 23)
        Me.cmbdcno.Name = "cmbdcno"
        Me.cmbdcno.Size = New System.Drawing.Size(200, 24)
        Me.cmbdcno.TabIndex = 4
        Me.cmbdcno.Text = "Select Dc No"
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.White
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Location = New System.Drawing.Point(624, 19)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 28)
        Me.btnsearch.TabIndex = 9
        Me.btnsearch.Text = "Go"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(624, 253)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(352, 23)
        Me.ProgressBar1.TabIndex = 19
        '
        'btncsvexport
        '
        Me.btncsvexport.BackColor = System.Drawing.Color.White
        Me.btncsvexport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncsvexport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btncsvexport.Location = New System.Drawing.Point(196, 243)
        Me.btncsvexport.Name = "btncsvexport"
        Me.btncsvexport.Size = New System.Drawing.Size(159, 33)
        Me.btncsvexport.TabIndex = 20
        Me.btncsvexport.Text = "Export To CSV file"
        Me.btncsvexport.UseVisualStyleBackColor = False
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1079, 751)
        Me.ControlBox = False
        Me.Controls.Add(Me.btncsvexport)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.dtgexport)
        Me.Controls.Add(Me.btnconvert)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Report"
        Me.Text = "Report"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.dtgexport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents btnclose As System.Windows.Forms.Button
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents dtpdcfrom As System.Windows.Forms.DateTimePicker
    Private WithEvents dtpdcto As System.Windows.Forms.DateTimePicker
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents btngo As System.Windows.Forms.Button
    Private WithEvents btnconvert As System.Windows.Forms.Button
    Private WithEvents dtgexport As System.Windows.Forms.DataGridView
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents cmbdcno As System.Windows.Forms.ComboBox
    Private WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Private WithEvents btncsvexport As System.Windows.Forms.Button
End Class
