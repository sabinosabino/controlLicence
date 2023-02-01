Public Class Form1
    Private texto As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Validar() Then
            Me.Text = texto
        Else
            Me.Text = texto
            Dim f As New fRegistrar(Me)
            f.ShowDialog()
        End If
    End Sub

    Public Function Validar() As Boolean
        Dim h As New HandlerValidation()
        Dim g As New GetId()
        Dim chave As String
        chave = g.GetId()
        If h.checkValidade(chave) Then
            texto = h.getTextoValidacao()
            Me.Text = texto
            Return True
        Else
            texto = h.getTextoValidacao()
            Return False
        End If
    End Function
End Class
