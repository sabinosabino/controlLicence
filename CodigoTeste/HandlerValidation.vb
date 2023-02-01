Imports System.Configuration
Public Class HandlerValidation
    Private textoValidacao As String
    Public Sub setTextoValidacao(value As String)
        textoValidacao = value
    End Sub
    Public Function getTextoValidacao() As String
        getTextoValidacao = textoValidacao
    End Function

    Private Function separatorKey(value As String) As Object
        On Error GoTo 1

        Dim arr As Object

        arr = Split(value, "///")

        separatorKey = arr

        Exit Function
1:
        MsgBox(Err.Description, vbCritical, "Erro ao separar chave")
    End Function
    Public Sub writeKey(value As String)
        On Error GoTo 1
        Dim arr As Object

        arr = separatorKey(value)

        'Call ocultaTable

        'Call CurrentDb.Execute("update _checkin set user='" & value & "'")

        Exit Sub
1:
        MsgBox(Err.Description, vbCritical, "Erro ao separar chave")
    End Sub

    Public Function checkValidade(Optional user As String = "a") As Boolean
        On Error GoTo 1

        'Dim rs As DAO.Recordset
        Dim arr As Object
        'Set rs = CurrentDb.OpenRecordset("Select * from _checkin")

        'Call ocultaTable
        Dim mcrip = New mCrip()
        Dim thiskey As String
        thiskey = ConfigurationManager.AppSettings.Item("thiskey").ToString()
        arr = Split(mcrip.fncDescrip(thiskey), "///")

        'chamar classe com id
        If arr(0) = user Then

            If DateTime.Parse(arr(1).ToString()) >= DateTime.Now Then
                textoValidacao = "Licença válida até: " & arr(1)
                Return True
            End If

        End If

        Exit Function
1:
        textoValidacao = "Licença não está válida ou está vencida..."
    End Function

End Class
