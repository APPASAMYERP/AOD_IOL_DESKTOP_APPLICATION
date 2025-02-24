<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSterileMachineReport
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
        Me.txtSterileBatch = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnView = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnDownload = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSterileBatch
        '
        Me.txtSterileBatch.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSterileBatch.Location = New System.Drawing.Point(180, 12)
        Me.txtSterileBatch.Name = "txtSterileBatch"
        Me.txtSterileBatch.Size = New System.Drawing.Size(342, 48)
        Me.txtSterileBatch.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(25, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 29)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Sterile Batch"
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.Red
        Me.btnView.Location = New System.Drawing.Point(576, 11)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(108, 42)
        Me.btnView.TabIndex = 30
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(30, 81)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(934, 604)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'btnDownload
        '
        Me.btnDownload.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDownload.ForeColor = System.Drawing.Color.Red
        Me.btnDownload.Location = New System.Drawing.Point(770, 12)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(108, 42)
        Me.btnDownload.TabIndex = 30
        Me.btnDownload.Text = "Download"
        Me.btnDownload.UseVisualStyleBackColor = True
        '
        'FrmSterileMachineReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 697)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.txtSterileBatch)
        Me.Controls.Add(Me.Label4)
        Me.Name = "FrmSterileMachineReport"
        Me.Text = "FrmSterileMachineReport"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSterileBatch As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnDownload As System.Windows.Forms.Button
End Class
