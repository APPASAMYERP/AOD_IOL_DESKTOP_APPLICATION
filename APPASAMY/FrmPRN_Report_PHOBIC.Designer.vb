<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPRN_Report_PHOBIC
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
        Me.dtp_ReleaseDate = New System.Windows.Forms.DateTimePicker
        Me.txtESR_No = New System.Windows.Forms.TextBox
        Me.txtPRN_No = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnView = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.CmbBatchNo = New System.Windows.Forms.ComboBox
        Me.CryViewBoxPackingRecord = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.txtLot_size = New System.Windows.Forms.TextBox
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtp_ReleaseDate
        '
        Me.dtp_ReleaseDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_ReleaseDate.Location = New System.Drawing.Point(431, 20)
        Me.dtp_ReleaseDate.Name = "dtp_ReleaseDate"
        Me.dtp_ReleaseDate.Size = New System.Drawing.Size(142, 23)
        Me.dtp_ReleaseDate.TabIndex = 90
        '
        'txtESR_No
        '
        Me.txtESR_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtESR_No.Location = New System.Drawing.Point(119, 76)
        Me.txtESR_No.Name = "txtESR_No"
        Me.txtESR_No.Size = New System.Drawing.Size(183, 23)
        Me.txtESR_No.TabIndex = 87
        '
        'txtPRN_No
        '
        Me.txtPRN_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRN_No.Location = New System.Drawing.Point(410, 76)
        Me.txtPRN_No.Name = "txtPRN_No"
        Me.txtPRN_No.Size = New System.Drawing.Size(183, 23)
        Me.txtPRN_No.TabIndex = 88
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(618, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Lot Size"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(338, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "Release Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(27, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "ESR No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(338, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "PRN No"
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(686, 73)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(63, 23)
        Me.btnView.TabIndex = 82
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(27, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 16)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Sterile Batch"
        '
        'CmbBatchNo
        '
        Me.CmbBatchNo.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBatchNo.FormattingEnabled = True
        Me.CmbBatchNo.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.CmbBatchNo.Location = New System.Drawing.Point(119, 16)
        Me.CmbBatchNo.Name = "CmbBatchNo"
        Me.CmbBatchNo.Size = New System.Drawing.Size(183, 24)
        Me.CmbBatchNo.TabIndex = 80
        '
        'CryViewBoxPackingRecord
        '
        Me.CryViewBoxPackingRecord.ActiveViewIndex = -1
        Me.CryViewBoxPackingRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CryViewBoxPackingRecord.Location = New System.Drawing.Point(12, 114)
        Me.CryViewBoxPackingRecord.Name = "CryViewBoxPackingRecord"
        Me.CryViewBoxPackingRecord.SelectionFormula = ""
        Me.CryViewBoxPackingRecord.Size = New System.Drawing.Size(1115, 611)
        Me.CryViewBoxPackingRecord.TabIndex = 79
        Me.CryViewBoxPackingRecord.ViewTimeSelectionFormula = ""
        '
        'txtLot_size
        '
        Me.txtLot_size.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLot_size.Location = New System.Drawing.Point(695, 16)
        Me.txtLot_size.Name = "txtLot_size"
        Me.txtLot_size.Size = New System.Drawing.Size(132, 23)
        Me.txtLot_size.TabIndex = 91
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'FrmPRN_Report_PHOBIC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1139, 741)
        Me.Controls.Add(Me.txtLot_size)
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
        Me.Name = "FrmPRN_Report_PHOBIC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPRN_Report_PHOBIC"
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtp_ReleaseDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtESR_No As System.Windows.Forms.TextBox
    Friend WithEvents txtPRN_No As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CmbBatchNo As System.Windows.Forms.ComboBox
    Friend WithEvents CryViewBoxPackingRecord As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents txtLot_size As System.Windows.Forms.TextBox
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
End Class
