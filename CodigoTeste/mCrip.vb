Public Class mCrip
    Private Function fncInvert(texto As String) As String
        'VAriáveis
        Dim sTemp As String
        sTemp = ""
        Dim x As Integer
        'Step aumenta ou diminui derminados valores no for
        For x = Len(texto) To 1 Step -1
            'Mid pega um intervalo predefinido de caracteres
            sTemp = sTemp & Mid(texto, x, 1)
        Next
        'Resultado passado para função
        fncInvert = sTemp
    End Function

    Private Function fncMudarparaChar(texto As String) As String
        'Variveis
        Dim i As Integer
        Dim sTemp As String
        sTemp = ""
        For i = 1 To Len(texto)
            'Carregar valores em Chr
            sTemp = sTemp & Chr(Mid(texto, i, 1) + 80)
        Next
        'Passar resultado para função
        fncMudarparaChar = sTemp
    End Function
    Private Function fncMudarParaAsc(texto As String) As String
        Dim i As Integer
        Dim sTemp As String
        sTemp = ""
        'Laço de repetição
        For i = 1 To Len(texto)
            'Carregar os valores em Asc
            sTemp = sTemp & Asc(Mid(texto, i, 1)) - 80
        Next
        fncMudarParaAsc = Me.fncInvert(sTemp)
    End Function
    Public Function fncDescrip(texto As String, Optional chave As Object = "111111")
        Dim i As Integer
        Dim sTemp As String
        Dim sSenha As String
        Dim iContarComprimento As Integer
        Dim sText As String
        sTemp = ""
        sSenha = ""
        sText = fncMudarParaAsc(texto)
        iContarComprimento = Len(chave)
        For i = 1 To Len(sText) + 1
            If Len(sTemp) = iContarComprimento Then
                sSenha = sSenha & Chr(sTemp - chave)
                sTemp = Mid(sText, i, 1)
            Else
                sTemp = sTemp & Mid(sText, i, 1)
            End If
        Next
        fncDescrip = sSenha
    End Function
    Private Function fncChave() As String
        Dim sTemp As String
        Dim i As Integer
        sTemp = ""
        For i = 1 To 6
            sTemp = sTemp & Int((7 * Rnd()) * 1)
            If sTemp = "0" Then
                sTemp = 1
            End If
        Next
        fncChave = sTemp
    End Function


End Class
