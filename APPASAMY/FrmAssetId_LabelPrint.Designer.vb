<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAssetId_LabelPrint
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
        Me.txtSequence = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.to_Serial = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.from_serial = New System.Windows.Forms.TextBox
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtSequence
        '
        Me.txtSequence.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSequence.Location = New System.Drawing.Point(180, 84)
        Me.txtSequence.Name = "txtSequence"
        Me.txtSequence.Size = New System.Drawing.Size(267, 48)
        Me.txtSequence.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(49, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 29)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Sequence"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(307, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 29)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "To"
        '
        'to_Serial
        '
        Me.to_Serial.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.to_Serial.Location = New System.Drawing.Point(354, 183)
        Me.to_Serial.Name = "to_Serial"
        Me.to_Serial.Size = New System.Drawing.Size(106, 48)
        Me.to_Serial.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(32, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 29)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "From"
        '
        'from_serial
        '
        Me.from_serial.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.from_serial.Location = New System.Drawing.Point(124, 183)
        Me.from_serial.Name = "from_serial"
        Me.from_serial.Size = New System.Drawing.Size(92, 48)
        Me.from_serial.TabIndex = 26
        '
        'BtnPrint
        '
        Me.BtnPrint.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.ForeColor = System.Drawing.Color.Red
        Me.BtnPrint.Location = New System.Drawing.Point(180, 274)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(108, 42)
        Me.BtnPrint.TabIndex = 28
        Me.BtnPrint.Text = "Print"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(339, 274)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 42)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmAssetId_LabelPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 391)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.from_serial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.to_Serial)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSequence)
        Me.Controls.Add(Me.Label5)
        Me.Name = "FrmAssetId_LabelPrint"
        Me.Text = "FrmAssetId_LabelPrint"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSequence As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents to_Serial As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents from_serial As System.Windows.Forms.TextBox
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
