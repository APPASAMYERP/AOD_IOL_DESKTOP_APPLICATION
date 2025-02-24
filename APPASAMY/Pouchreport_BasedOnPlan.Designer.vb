<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pouchreport_BasedOnPlan
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
        Me.cmbMonth = New System.Windows.Forms.ComboBox
        Me.cmbYear = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_download = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmbMonth
        '
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cmbMonth.Location = New System.Drawing.Point(175, 89)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(121, 21)
        Me.cmbMonth.TabIndex = 6
        '
        'cmbYear
        '
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(175, 47)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(121, 21)
        Me.cmbYear.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Month"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Year"
        '
        'btn_download
        '
        Me.btn_download.Location = New System.Drawing.Point(103, 158)
        Me.btn_download.Name = "btn_download"
        Me.btn_download.Size = New System.Drawing.Size(174, 38)
        Me.btn_download.TabIndex = 3
        Me.btn_download.Text = "Download"
        Me.btn_download.UseVisualStyleBackColor = True
        '
        'Pouchreport_BasedOnPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 322)
        Me.Controls.Add(Me.cmbMonth)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_download)
        Me.Name = "Pouchreport_BasedOnPlan"
        Me.Text = "Pouchreport_BasedOnPlan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_download As System.Windows.Forms.Button
End Class
