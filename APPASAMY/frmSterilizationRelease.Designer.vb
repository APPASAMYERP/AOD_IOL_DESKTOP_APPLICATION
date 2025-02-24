<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSterilizationRelease
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
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbBatchNo = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpReleaseDate = New System.Windows.Forms.DateTimePicker
        Me.btnRelease = New System.Windows.Forms.Button
        Me.gridSterlization = New System.Windows.Forms.DataGridView
        Me.dtpReleaseDateSearch = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        CType(Me.gridSterlization, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(50, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Batch No"
        '
        'cmbBatchNo
        '
        Me.cmbBatchNo.FormattingEnabled = True
        Me.cmbBatchNo.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbBatchNo.Location = New System.Drawing.Point(155, 45)
        Me.cmbBatchNo.Name = "cmbBatchNo"
        Me.cmbBatchNo.Size = New System.Drawing.Size(137, 21)
        Me.cmbBatchNo.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(50, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Release Date"
        '
        'dtpReleaseDate
        '
        Me.dtpReleaseDate.CustomFormat = "yyyy-MM-dd hh:mm:ss"
        Me.dtpReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReleaseDate.Location = New System.Drawing.Point(155, 85)
        Me.dtpReleaseDate.Name = "dtpReleaseDate"
        Me.dtpReleaseDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpReleaseDate.TabIndex = 55
        '
        'btnRelease
        '
        Me.btnRelease.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRelease.Location = New System.Drawing.Point(155, 130)
        Me.btnRelease.Name = "btnRelease"
        Me.btnRelease.Size = New System.Drawing.Size(88, 39)
        Me.btnRelease.TabIndex = 56
        Me.btnRelease.Text = "Release"
        Me.btnRelease.UseVisualStyleBackColor = True
        '
        'gridSterlization
        '
        Me.gridSterlization.AllowUserToAddRows = False
        Me.gridSterlization.AllowUserToDeleteRows = False
        Me.gridSterlization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridSterlization.Location = New System.Drawing.Point(393, 55)
        Me.gridSterlization.Name = "gridSterlization"
        Me.gridSterlization.ReadOnly = True
        Me.gridSterlization.Size = New System.Drawing.Size(467, 529)
        Me.gridSterlization.TabIndex = 57
        '
        'dtpReleaseDateSearch
        '
        Me.dtpReleaseDateSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReleaseDateSearch.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReleaseDateSearch.Location = New System.Drawing.Point(513, 25)
        Me.dtpReleaseDateSearch.Name = "dtpReleaseDateSearch"
        Me.dtpReleaseDateSearch.Size = New System.Drawing.Size(200, 24)
        Me.dtpReleaseDateSearch.TabIndex = 59
        Me.dtpReleaseDateSearch.Value = New Date(2023, 3, 30, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(408, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Release Date"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(719, 22)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(88, 27)
        Me.btnSearch.TabIndex = 60
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(138, 558)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 39)
        Me.btnClose.TabIndex = 61
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmSterilizationRelease
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(872, 625)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dtpReleaseDateSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gridSterlization)
        Me.Controls.Add(Me.btnRelease)
        Me.Controls.Add(Me.dtpReleaseDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbBatchNo)
        Me.Name = "frmSterilizationRelease"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.gridSterlization, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbBatchNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpReleaseDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnRelease As System.Windows.Forms.Button
    Friend WithEvents gridSterlization As System.Windows.Forms.DataGridView
    Friend WithEvents dtpReleaseDateSearch As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
