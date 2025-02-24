<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPouch_MMS_Report
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
        Me.btn_Save = New System.Windows.Forms.Button
        Me.btn_clear = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.DataGridView3 = New System.Windows.Forms.DataGridView
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.chkBtc = New System.Windows.Forms.DataGridViewCheckBoxColumn
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMovementNo
        '
        Me.lblMovementNo.AutoSize = True
        Me.lblMovementNo.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovementNo.ForeColor = System.Drawing.Color.Blue
        Me.lblMovementNo.Location = New System.Drawing.Point(180, 51)
        Me.lblMovementNo.Name = "lblMovementNo"
        Me.lblMovementNo.Size = New System.Drawing.Size(151, 33)
        Me.lblMovementNo.TabIndex = 70
        Me.lblMovementNo.Text = "Lot No. "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(35, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 18)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Movement No"
        '
        'lbl_ToLocation
        '
        Me.lbl_ToLocation.AutoSize = True
        Me.lbl_ToLocation.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ToLocation.ForeColor = System.Drawing.Color.Blue
        Me.lbl_ToLocation.Location = New System.Drawing.Point(816, 75)
        Me.lbl_ToLocation.Name = "lbl_ToLocation"
        Me.lbl_ToLocation.Size = New System.Drawing.Size(151, 33)
        Me.lbl_ToLocation.TabIndex = 76
        Me.lbl_ToLocation.Text = "Areation"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(671, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 18)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "To Location"
        '
        'lbl_FromLocation
        '
        Me.lbl_FromLocation.AutoSize = True
        Me.lbl_FromLocation.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FromLocation.ForeColor = System.Drawing.Color.Blue
        Me.lbl_FromLocation.Location = New System.Drawing.Point(816, 42)
        Me.lbl_FromLocation.Name = "lbl_FromLocation"
        Me.lbl_FromLocation.Size = New System.Drawing.Size(134, 33)
        Me.lbl_FromLocation.TabIndex = 74
        Me.lbl_FromLocation.Text = "Sterile"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(671, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 18)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "From Location"
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(926, 507)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(78, 42)
        Me.btn_Save.TabIndex = 80
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(502, 507)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(78, 42)
        Me.btn_clear.TabIndex = 81
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(157, 507)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(78, 42)
        Me.btnAdd.TabIndex = 82
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView3.Location = New System.Drawing.Point(761, 145)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(434, 356)
        Me.DataGridView3.TabIndex = 79
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView2.Location = New System.Drawing.Point(459, 145)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(216, 356)
        Me.DataGridView2.TabIndex = 78
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chkBtc})
        Me.DataGridView1.Location = New System.Drawing.Point(21, 145)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(348, 356)
        Me.DataGridView1.TabIndex = 77
        '
        'chkBtc
        '
        Me.chkBtc.HeaderText = "Select Batch"
        Me.chkBtc.Name = "chkBtc"
        '
        'frmPouch_MMS_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1225, 611)
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
        Me.Name = "frmPouch_MMS_Report"
        Me.Text = "frmPouch_MMS_Report"
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMovementNo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_ToLocation As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_FromLocation As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents chkBtc As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
