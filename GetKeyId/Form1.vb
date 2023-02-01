Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim G As New GetId()
        Me.txtKey.Text = G.GetId()
    End Sub
End Class
