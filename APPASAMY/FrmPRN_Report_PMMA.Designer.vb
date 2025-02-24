<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPRN_Report_PMMA
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
        Me.btnView = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.CmbBatchNo = New System.Windows.Forms.ComboBox
        Me.CryViewBoxPackingRecord = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPRN_No = New System.Windows.Forms.TextBox
        Me.txtESR_No = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtp_ReleaseDate = New System.Windows.Forms.DateTimePicker
        Me.dtp_TestStartDate = New System.Windows.Forms.DateTimePicker
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(686, 75)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(63, 23)
        Me.btnView.TabIndex = 44
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(27, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 16)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Sterile Batch"
        '
        'CmbBatchNo
        '
        Me.CmbBatchNo.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBatchNo.FormattingEnabled = True
        Me.CmbBatchNo.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.CmbBatchNo.Location = New System.Drawing.Point(119, 18)
        Me.CmbBatchNo.Name = "CmbBatchNo"
        Me.CmbBatchNo.Size = New System.Drawing.Size(183, 24)
        Me.CmbBatchNo.TabIndex = 42
        '
        'CryViewBoxPackingRecord
        '
        Me.CryViewBoxPackingRecord.ActiveViewIndex = -1
        Me.CryViewBoxPackingRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CryViewBoxPackingRecord.Location = New System.Drawing.Point(12, 116)
        Me.CryViewBoxPackingRecord.Name = "CryViewBoxPackingRecord"
        Me.CryViewBoxPackingRecord.SelectionFormula = ""
        Me.CryViewBoxPackingRecord.Size = New System.Drawing.Size(1115, 611)
        Me.CryViewBoxPackingRecord.TabIndex = 41
        Me.CryViewBoxPackingRecord.ViewTimeSelectionFormula = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(338, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "PRN No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(27, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "ESR No"
        '
        'txtPRN_No
        '
        Me.txtPRN_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRN_No.Location = New System.Drawing.Point(410, 78)
        Me.txtPRN_No.Name = "txtPRN_No"
        Me.txtPRN_No.Size = New System.Drawing.Size(183, 23)
        Me.txtPRN_No.TabIndex = 77
        '
        'txtESR_No
        '
        Me.txtESR_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtESR_No.Location = New System.Drawing.Point(119, 78)
        Me.txtESR_No.Name = "txtESR_No"
        Me.txtESR_No.Size = New System.Drawing.Size(183, 23)
        Me.txtESR_No.TabIndex = 77
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(338, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Release Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(618, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 16)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Test Start Date"
        '
        'dtp_ReleaseDate
        '
        Me.dtp_ReleaseDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_ReleaseDate.Location = New System.Drawing.Point(431, 22)
        Me.dtp_ReleaseDate.Name = "dtp_ReleaseDate"
        Me.dtp_ReleaseDate.Size = New System.Drawing.Size(142, 23)
        Me.dtp_ReleaseDate.TabIndex = 78
        '
        'dtp_TestStartDate
        '
        Me.dtp_TestStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_TestStartDate.Location = New System.Drawing.Point(735, 20)
        Me.dtp_TestStartDate.Name = "dtp_TestStartDate"
        Me.dtp_TestStartDate.Size = New System.Drawing.Size(142, 23)
        Me.dtp_TestStartDate.TabIndex = 78
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'FrmPRN_Report_PMMA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1139, 741)
        Me.Controls.Add(Me.dtp_TestStartDate)
        Me.Controls.Add(Me.dtp_ReleaseDate)
        Me.Controls.Add(Me.txtESR_No)
        Me.Controls.Add(Me.txtPRN_No)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CmbBatchNo)
        Me.Controls.Add(Me.CryViewBoxPackingRecord)
        Me.Name = "FrmPRN_Report_PMMA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPRN_Report_PMMA"
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CmbBatchNo As System.Windows.Forms.ComboBox
    Friend WithEvents CryViewBoxPackingRecord As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPRN_No As System.Windows.Forms.TextBox
    Friend WithEvents txtESR_No As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtp_ReleaseDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_TestStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
End Class
