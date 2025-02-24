<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQC_To_boxPacking
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
        Me.lblMovementNo = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lbl_ToLocation = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbl_FromLocation = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.chkBPL = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridView3 = New System.Windows.Forms.DataGridView
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.btn_Save = New System.Windows.Forms.Button
        Me.btn_clear = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMovementNo
        '
        Me.lblMovementNo.AutoSize = True
        Me.lblMovementNo.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovementNo.ForeColor = System.Drawing.Color.Blue
        Me.lblMovementNo.Location = New System.Drawing.Point(122, 27)
        Me.lblMovementNo.Name = "lblMovementNo"
        Me.lblMovementNo.Size = New System.Drawing.Size(124, 27)
        Me.lblMovementNo.TabIndex = 84
        Me.lblMovementNo.Text = "Lot No. "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(12, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 18)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Movement No"
        '
        'lbl_ToLocation
        '
        Me.lbl_ToLocation.AutoSize = True
        Me.lbl_ToLocation.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ToLocation.ForeColor = System.Drawing.Color.Blue
        Me.lbl_ToLocation.Location = New System.Drawing.Point(793, 67)
        Me.lbl_ToLocation.Name = "lbl_ToLocation"
        Me.lbl_ToLocation.Size = New System.Drawing.Size(166, 27)
        Me.lbl_ToLocation.TabIndex = 94
        Me.lbl_ToLocation.Text = "Box PACKING"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(700, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 18)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "To Location"
        '
        'lbl_FromLocation
        '
        Me.lbl_FromLocation.AutoSize = True
        Me.lbl_FromLocation.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FromLocation.ForeColor = System.Drawing.Color.Blue
        Me.lbl_FromLocation.Location = New System.Drawing.Point(793, 27)
        Me.lbl_FromLocation.Name = "lbl_FromLocation"
        Me.lbl_FromLocation.Size = New System.Drawing.Size(40, 27)
        Me.lbl_FromLocation.TabIndex = 92
        Me.lbl_FromLocation.Text = "QC"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(680, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 18)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "From Location"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chkBPL})
        Me.DataGridView1.Location = New System.Drawing.Point(15, 109)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(499, 356)
        Me.DataGridView1.TabIndex = 95
        '
        'chkBPL
        '
        Me.chkBPL.HeaderText = "BatchNo"
        Me.chkBPL.Name = "chkBPL"
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView3.Location = New System.Drawing.Point(739, 109)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(460, 356)
        Me.DataGridView3.TabIndex = 97
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView2.Location = New System.Drawing.Point(517, 109)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(216, 356)
        Me.DataGridView2.TabIndex = 96
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(926, 503)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(118, 42)
        Me.btn_Save.TabIndex = 100
        Me.btn_Save.Text = "QC To Box Packing"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(604, 503)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(78, 42)
        Me.btn_clear.TabIndex = 99
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(136, 490)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(78, 42)
        Me.btnAdd.TabIndex = 98
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmQC_To_boxPacking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1237, 587)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lbl_ToLocation)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_FromLocation)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblMovementNo)
        Me.Controls.Add(Me.Label5)
        Me.Name = "frmQC_To_boxPacking"
        Me.Text = "frmqcmms_sterile"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMovementNo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_ToLocation As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_FromLocation As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents chkBPL As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
End Class
