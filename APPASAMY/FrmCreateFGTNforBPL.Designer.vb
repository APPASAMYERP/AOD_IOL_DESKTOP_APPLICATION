<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCreateFGTNforBPL
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
        Me.cmbBPL = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblFGTN_No = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.DataGridView3 = New System.Windows.Forms.DataGridView
        Me.btn_Save = New System.Windows.Forms.Button
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbBPL
        '
        Me.cmbBPL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBPL.FormattingEnabled = True
        Me.cmbBPL.Location = New System.Drawing.Point(37, 103)
        Me.cmbBPL.Name = "cmbBPL"
        Me.cmbBPL.Size = New System.Drawing.Size(288, 32)
        Me.cmbBPL.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(33, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "BPL NO"
        '
        'lblFGTN_No
        '
        Me.lblFGTN_No.AutoSize = True
        Me.lblFGTN_No.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFGTN_No.ForeColor = System.Drawing.Color.Blue
        Me.lblFGTN_No.Location = New System.Drawing.Point(150, 20)
        Me.lblFGTN_No.Name = "lblFGTN_No"
        Me.lblFGTN_No.Size = New System.Drawing.Size(124, 27)
        Me.lblFGTN_No.TabIndex = 82
        Me.lblFGTN_No.Text = "Lot No. "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(34, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 18)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "FGTN Number"
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView3.Location = New System.Drawing.Point(410, 25)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(514, 356)
        Me.DataGridView3.TabIndex = 83
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(133, 177)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(78, 42)
        Me.btn_Save.TabIndex = 84
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'FrmCreateFGTNforBPL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 691)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.lblFGTN_No)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbBPL)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmCreateFGTNforBPL"
        Me.Text = "FrmCreateFGTNforBPL"
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbBPL As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFGTN_No As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Save As System.Windows.Forms.Button
End Class
