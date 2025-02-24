Public Class CustomMessageBox

    Public Sub New(ByVal message As String)
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        InitializeComponent()
        Label1.Text = message
    End Sub

   


End Class