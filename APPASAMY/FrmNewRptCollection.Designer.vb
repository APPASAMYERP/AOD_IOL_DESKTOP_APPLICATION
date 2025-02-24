<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewRptCollection
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.NotorReadyStockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2 = New APPASAMY_SOFT.DataSet2
        Me.CmbType = New System.Windows.Forms.ComboBox
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnSerch = New System.Windows.Forms.Button
        Me.dtpto = New System.Windows.Forms.DateTimePicker
        Me.lbl = New System.Windows.Forms.Label
        Me.dtpfrom = New System.Windows.Forms.DateTimePicker
        Me.lblfrm = New System.Windows.Forms.Label
        Me.CmbShModel = New System.Windows.Forms.ComboBox
        Me.Cmbgscode = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Cmbtopower = New System.Windows.Forms.ComboBox
        Me.cmbfrmpower = New System.Windows.Forms.ComboBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.ChkModel = New System.Windows.Forms.CheckBox
        Me.ChkType = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.RdoArStkRpt = New System.Windows.Forms.RadioButton
        Me.rdoColl = New System.Windows.Forms.RadioButton
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.NotorReadyStockTableAdapter = New APPASAMY_SOFT.DataSet2TableAdapters.NotorReadyStockTableAdapter
        CType(Me.NotorReadyStockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotorReadyStockBindingSource
        '
        Me.NotorReadyStockBindingSource.DataMember = "NotorReadyStock"
        Me.NotorReadyStockBindingSource.DataSource = Me.DataSet2
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CmbType
        '
        Me.CmbType.Enabled = False
        Me.CmbType.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbType.ForeColor = System.Drawing.Color.Blue
        Me.CmbType.FormattingEnabled = True
        Me.CmbType.Items.AddRange(New Object() {"LOCAL", "SQUARE EDGE", "EXPORT"})
        Me.CmbType.Location = New System.Drawing.Point(204, 20)
        Me.CmbType.Name = "CmbType"
        Me.CmbType.Size = New System.Drawing.Size(202, 24)
        Me.CmbType.TabIndex = 46
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.White
        Me.BtnClose.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClose.Location = New System.Drawing.Point(266, 19)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(87, 32)
        Me.BtnClose.TabIndex = 45
        Me.BtnClose.Text = "CLOSE"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnSerch
        '
        Me.BtnSerch.BackColor = System.Drawing.Color.White
        Me.BtnSerch.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSerch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSerch.Location = New System.Drawing.Point(95, 19)
        Me.BtnSerch.Name = "BtnSerch"
        Me.BtnSerch.Size = New System.Drawing.Size(93, 32)
        Me.BtnSerch.TabIndex = 44
        Me.BtnSerch.Text = "SUBMIT"
        Me.BtnSerch.UseVisualStyleBackColor = False
        '
        'dtpto
        '
        Me.dtpto.CustomFormat = "dd/MM/yyyy"
        Me.dtpto.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpto.Location = New System.Drawing.Point(204, 77)
        Me.dtpto.Name = "dtpto"
        Me.dtpto.Size = New System.Drawing.Size(124, 22)
        Me.dtpto.TabIndex = 43
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.Blue
        Me.lbl.Location = New System.Drawing.Point(48, 82)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(63, 16)
        Me.lbl.TabIndex = 42
        Me.lbl.Text = "TO DATE"
        '
        'dtpfrom
        '
        Me.dtpfrom.CalendarForeColor = System.Drawing.Color.Navy
        Me.dtpfrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpfrom.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfrom.Location = New System.Drawing.Point(204, 30)
        Me.dtpfrom.Name = "dtpfrom"
        Me.dtpfrom.Size = New System.Drawing.Size(124, 22)
        Me.dtpfrom.TabIndex = 41
        '
        'lblfrm
        '
        Me.lblfrm.AutoSize = True
        Me.lblfrm.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfrm.ForeColor = System.Drawing.Color.Blue
        Me.lblfrm.Location = New System.Drawing.Point(48, 30)
        Me.lblfrm.Name = "lblfrm"
        Me.lblfrm.Size = New System.Drawing.Size(84, 16)
        Me.lblfrm.TabIndex = 40
        Me.lblfrm.Text = "FROM DATE"
        '
        'CmbShModel
        '
        Me.CmbShModel.Enabled = False
        Me.CmbShModel.FormattingEnabled = True
        Me.CmbShModel.Items.AddRange(New Object() {"1", "2", "3"})
        Me.CmbShModel.Location = New System.Drawing.Point(204, 76)
        Me.CmbShModel.Name = "CmbShModel"
        Me.CmbShModel.Size = New System.Drawing.Size(202, 21)
        Me.CmbShModel.TabIndex = 50
        '
        'Cmbgscode
        '
        Me.Cmbgscode.Enabled = False
        Me.Cmbgscode.FormattingEnabled = True
        Me.Cmbgscode.Items.AddRange(New Object() {"A", "B", "C"})
        Me.Cmbgscode.Location = New System.Drawing.Point(204, 227)
        Me.Cmbgscode.Name = "Cmbgscode"
        Me.Cmbgscode.Size = New System.Drawing.Size(202, 21)
        Me.Cmbgscode.TabIndex = 51
        Me.Cmbgscode.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Cmbtopower)
        Me.GroupBox1.Controls.Add(Me.cmbfrmpower)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.ChkModel)
        Me.GroupBox1.Controls.Add(Me.ChkType)
        Me.GroupBox1.Controls.Add(Me.CmbType)
        Me.GroupBox1.Controls.Add(Me.CmbShModel)
        Me.GroupBox1.Controls.Add(Me.Cmbgscode)
        Me.GroupBox1.Location = New System.Drawing.Point(52, 209)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(495, 273)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"A", "B", "C"})
        Me.ComboBox1.Location = New System.Drawing.Point(204, 125)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(202, 21)
        Me.ComboBox1.TabIndex = 63
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Red
        Me.CheckBox1.Location = New System.Drawing.Point(51, 125)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(128, 20)
        Me.CheckBox1.TabIndex = 62
        Me.CheckBox1.Text = "Reference Name"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Cmbtopower
        '
        Me.Cmbtopower.Enabled = False
        Me.Cmbtopower.FormattingEnabled = True
        Me.Cmbtopower.Location = New System.Drawing.Point(319, 177)
        Me.Cmbtopower.Name = "Cmbtopower"
        Me.Cmbtopower.Size = New System.Drawing.Size(87, 21)
        Me.Cmbtopower.TabIndex = 61
        '
        'cmbfrmpower
        '
        Me.cmbfrmpower.Enabled = False
        Me.cmbfrmpower.FormattingEnabled = True
        Me.cmbfrmpower.Location = New System.Drawing.Point(204, 177)
        Me.cmbfrmpower.Name = "cmbfrmpower"
        Me.cmbfrmpower.Size = New System.Drawing.Size(95, 21)
        Me.cmbfrmpower.TabIndex = 60
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.ForeColor = System.Drawing.Color.Red
        Me.CheckBox3.Location = New System.Drawing.Point(51, 177)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(66, 20)
        Me.CheckBox3.TabIndex = 58
        Me.CheckBox3.Text = "Power"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Label1"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.Red
        Me.CheckBox2.Location = New System.Drawing.Point(51, 227)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(111, 20)
        Me.CheckBox2.TabIndex = 54
        Me.CheckBox2.Text = "Type GS Code"
        Me.CheckBox2.UseVisualStyleBackColor = True
        Me.CheckBox2.Visible = False
        '
        'ChkModel
        '
        Me.ChkModel.AutoSize = True
        Me.ChkModel.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkModel.ForeColor = System.Drawing.Color.Red
        Me.ChkModel.Location = New System.Drawing.Point(51, 76)
        Me.ChkModel.Name = "ChkModel"
        Me.ChkModel.Size = New System.Drawing.Size(66, 20)
        Me.ChkModel.TabIndex = 53
        Me.ChkModel.Text = "Model"
        Me.ChkModel.UseVisualStyleBackColor = True
        '
        'ChkType
        '
        Me.ChkType.AutoSize = True
        Me.ChkType.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkType.ForeColor = System.Drawing.Color.Red
        Me.ChkType.Location = New System.Drawing.Point(51, 20)
        Me.ChkType.Name = "ChkType"
        Me.ChkType.Size = New System.Drawing.Size(58, 20)
        Me.ChkType.TabIndex = 52
        Me.ChkType.Text = "Type"
        Me.ChkType.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpto)
        Me.GroupBox2.Controls.Add(Me.lblfrm)
        Me.GroupBox2.Controls.Add(Me.dtpfrom)
        Me.GroupBox2.Controls.Add(Me.lbl)
        Me.GroupBox2.Location = New System.Drawing.Point(52, 82)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(495, 121)
        Me.GroupBox2.TabIndex = 70
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnClose)
        Me.GroupBox3.Controls.Add(Me.BtnSerch)
        Me.GroupBox3.Location = New System.Drawing.Point(40, 488)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(507, 72)
        Me.GroupBox3.TabIndex = 71
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RdoArStkRpt)
        Me.GroupBox4.Controls.Add(Me.rdoColl)
        Me.GroupBox4.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Red
        Me.GroupBox4.Location = New System.Drawing.Point(52, 27)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(493, 55)
        Me.GroupBox4.TabIndex = 72
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Report Type"
        '
        'RdoArStkRpt
        '
        Me.RdoArStkRpt.AutoSize = True
        Me.RdoArStkRpt.Checked = True
        Me.RdoArStkRpt.Location = New System.Drawing.Point(51, 21)
        Me.RdoArStkRpt.Name = "RdoArStkRpt"
        Me.RdoArStkRpt.Size = New System.Drawing.Size(170, 19)
        Me.RdoArStkRpt.TabIndex = 36
        Me.RdoArStkRpt.TabStop = True
        Me.RdoArStkRpt.Text = "Aeration Stock Report"
        Me.RdoArStkRpt.UseVisualStyleBackColor = True
        '
        'rdoColl
        '
        Me.rdoColl.AutoSize = True
        Me.rdoColl.Location = New System.Drawing.Point(284, 21)
        Me.rdoColl.Name = "rdoColl"
        Me.rdoColl.Size = New System.Drawing.Size(139, 19)
        Me.rdoColl.TabIndex = 35
        Me.rdoColl.Text = "Collection Report"
        Me.rdoColl.UseVisualStyleBackColor = True
        Me.rdoColl.Visible = False
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet2_NotorReadyStock"
        ReportDataSource1.Value = Me.NotorReadyStockBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "APPASAMY_SOFT.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(573, 36)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(663, 464)
        Me.ReportViewer1.TabIndex = 73
        '
        'NotorReadyStockTableAdapter
        '
        Me.NotorReadyStockTableAdapter.ClearBeforeFill = True
        '
        'FrmNewRptCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1455, 894)
        Me.ControlBox = False
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmNewRptCollection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.NotorReadyStockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents CmbType As System.Windows.Forms.ComboBox
    Private WithEvents BtnClose As System.Windows.Forms.Button
    Private WithEvents BtnSerch As System.Windows.Forms.Button
    Private WithEvents dtpto As System.Windows.Forms.DateTimePicker
    Private WithEvents lbl As System.Windows.Forms.Label
    Private WithEvents dtpfrom As System.Windows.Forms.DateTimePicker
    Private WithEvents lblfrm As System.Windows.Forms.Label
    Friend WithEvents CmbShModel As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbgscode As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkType As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents ChkModel As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RdoArStkRpt As System.Windows.Forms.RadioButton
    Friend WithEvents rdoColl As System.Windows.Forms.RadioButton
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents NotorReadyStockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet2 As APPASAMY_SOFT.DataSet2
    Friend WithEvents NotorReadyStockTableAdapter As APPASAMY_SOFT.DataSet2TableAdapters.NotorReadyStockTableAdapter
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cmbtopower As System.Windows.Forms.ComboBox
    Friend WithEvents cmbfrmpower As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
