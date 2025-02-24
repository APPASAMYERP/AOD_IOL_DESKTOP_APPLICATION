<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent1))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.LotNoCreationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BarcodePrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LotNoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UniqueNoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PowerWiseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PackingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 536)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1247, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(38, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LotNoCreationToolStripMenuItem, Me.BarcodePrintToolStripMenuItem, Me.UniqueNoToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.PackingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1247, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LotNoCreationToolStripMenuItem
        '
        Me.LotNoCreationToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LotNoCreationToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue
        Me.LotNoCreationToolStripMenuItem.Name = "LotNoCreationToolStripMenuItem"
        Me.LotNoCreationToolStripMenuItem.Size = New System.Drawing.Size(118, 20)
        Me.LotNoCreationToolStripMenuItem.Text = "Lot No Creation"
        '
        'BarcodePrintToolStripMenuItem
        '
        Me.BarcodePrintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LotNoToolStripMenuItem})
        Me.BarcodePrintToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarcodePrintToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue
        Me.BarcodePrintToolStripMenuItem.Name = "BarcodePrintToolStripMenuItem"
        Me.BarcodePrintToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.BarcodePrintToolStripMenuItem.Text = "Barcode Print"
        '
        'LotNoToolStripMenuItem
        '
        Me.LotNoToolStripMenuItem.Name = "LotNoToolStripMenuItem"
        Me.LotNoToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.LotNoToolStripMenuItem.Text = "Lot No "
        '
        'UniqueNoToolStripMenuItem
        '
        Me.UniqueNoToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UniqueNoToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue
        Me.UniqueNoToolStripMenuItem.Name = "UniqueNoToolStripMenuItem"
        Me.UniqueNoToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.UniqueNoToolStripMenuItem.Text = "Sterilization"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PowerWiseToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportsToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'PowerWiseToolStripMenuItem
        '
        Me.PowerWiseToolStripMenuItem.Name = "PowerWiseToolStripMenuItem"
        Me.PowerWiseToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.PowerWiseToolStripMenuItem.Text = "Power Wise"
        '
        'PackingToolStripMenuItem
        '
        Me.PackingToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PackingToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue
        Me.PackingToolStripMenuItem.Name = "PackingToolStripMenuItem"
        Me.PackingToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.PackingToolStripMenuItem.Text = "Packing"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1247, 558)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MDIParent1"
        Me.Text = "MDIParent1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents LotNoCreationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarcodePrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LotNoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UniqueNoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PowerWiseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PackingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
