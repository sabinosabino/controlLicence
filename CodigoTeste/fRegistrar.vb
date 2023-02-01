Imports System.ComponentModel
Imports System.Configuration
Imports System.Runtime

Public Class fRegistrar
    Private _form As Form1
    Public Sub New(form As Form1)
        InitializeComponent()
        _form = form
        _form.Visible = False
    End Sub
    Private Sub fRegistrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub fRegistrar_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If _form.Validar() Then
            _form.Visible = True
        Else
            MsgBox("Licença não válida...")
            e.Cancel = True
        End If
    End Sub

    Private Sub btFechar_Click(sender As Object, e As EventArgs) Handles btFechar.Click
        If MsgBox("Deseja fechar o sistema?", MsgBoxStyle.YesNo, "Atenção") = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        Registrar()
    End Sub
    Private Sub Registrar()
        On Error GoTo 1
        Dim configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim settings = configFile.AppSettings
        Dim key As String = "thiskey"
        If settings.Settings.Item(key) Is Nothing Then
            settings.Settings.Add(key, Me.txtChave.Text)
        Else
            settings.Settings.Item(key).Value = Me.txtChave.Text
        End If
        configFile.Save(ConfigurationSaveMode.Modified)
        ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name)
        MsgBox("Salvo...")
        Return
1:
        MsgBox("Erro ao registrar chave")
    End Sub
End Class