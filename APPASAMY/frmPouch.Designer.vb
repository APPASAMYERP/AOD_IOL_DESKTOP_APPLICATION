<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPouch
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
        Me.cmbModelNo = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbTypeName = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbLabelName = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnShowbtwPreview = New System.Windows.Forms.Button
        Me.lblFileName = New System.Windows.Forms.Label
        Me.btnFileName = New System.Windows.Forms.Button
        Me.cmbDepartment = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cmbModelNo
        '
        Me.cmbModelNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbModelNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbModelNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModelNo.FormattingEnabled = True
        Me.cmbModelNo.Location = New System.Drawing.Point(104, 40)
        Me.cmbModelNo.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbModelNo.Name = "cmbModelNo"
        Me.cmbModelNo.Size = New System.Drawing.Size(206, 25)
        Me.cmbModelNo.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(19, 40)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Model No"
        '
        'cmbTypeName
        '
        Me.cmbTypeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbTypeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTypeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTypeName.FormattingEnabled = True
        Me.cmbTypeName.Items.AddRange(New Object() {"LOCAL", "EXPORT"})
        Me.cmbTypeName.Location = New System.Drawing.Point(384, 23)
        Me.cmbTypeName.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbTypeName.Name = "cmbTypeName"
        Me.cmbTypeName.Size = New System.Drawing.Size(97, 25)
        Me.cmbTypeName.TabIndex = 7
        Me.cmbTypeName.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(319, 23)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Type"
        Me.Label3.Visible = False
        '
        'cmbLabelName
        '
        Me.cmbLabelName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbLabelName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbLabelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLabelName.FormattingEnabled = True
        Me.cmbLabelName.Location = New System.Drawing.Point(104, 81)
        Me.cmbLabelName.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbLabelName.Name = "cmbLabelName"
        Me.cmbLabelName.Size = New System.Drawing.Size(206, 25)
        Me.cmbLabelName.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(19, 84)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Label"
        '
        'btnShowbtwPreview
        '
        Me.btnShowbtwPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowbtwPreview.Location = New System.Drawing.Point(253, 137)
        Me.btnShowbtwPreview.Margin = New System.Windows.Forms.Padding(2)
        Me.btnShowbtwPreview.Name = "btnShowbtwPreview"
        Me.btnShowbtwPreview.Size = New System.Drawing.Size(185, 29)
        Me.btnShowbtwPreview.TabIndex = 17
        Me.btnShowbtwPreview.Text = "Show btw Preview"
        Me.btnShowbtwPreview.UseVisualStyleBackColor = True
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileName.ForeColor = System.Drawing.Color.Blue
        Me.lblFileName.Location = New System.Drawing.Point(81, 180)
        Me.lblFileName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(71, 17)
        Me.lblFileName.TabIndex = 18
        Me.lblFileName.Text = "File Name"
        '
        'btnFileName
        '
        Me.btnFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFileName.Location = New System.Drawing.Point(84, 137)
        Me.btnFileName.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFileName.Name = "btnFileName"
        Me.btnFileName.Size = New System.Drawing.Size(165, 29)
        Me.btnFileName.TabIndex = 19
        Me.btnFileName.Text = "Show File Name"
        Me.btnFileName.UseVisualStyleBackColor = True
        '
        'cmbDepartment
        '
        Me.cmbDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDepartment.FormattingEnabled = True
        Me.cmbDepartment.Items.AddRange(New Object() {"POUCH", "BOX"})
        Me.cmbDepartment.Location = New System.Drawing.Point(105, 6)
        Me.cmbDepartment.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(205, 25)
        Me.cmbDepartment.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(19, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Department"
        '
        'frmPouch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(527, 237)
        Me.Controls.Add(Me.cmbDepartment)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFileName)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.btnShowbtwPreview)
        Me.Controls.Add(Me.cmbLabelName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbTypeName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbModelNo)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmPouch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPouch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbModelNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbTypeName As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbLabelName As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnShowbtwPreview As System.Windows.Forms.Button
    Friend WithEvents lblFileName As System.Windows.Forms.Label
    Friend WithEvents btnFileName As System.Windows.Forms.Button
    Friend WithEvents cmbDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
