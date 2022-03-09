

Public Class Foto
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer2.Start()
        Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        Tema.Show()
        Me.Close()
    End Sub

    Private Sub Foto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.Background

        If System.IO.Directory.Exists("C:\\LoLRememberV2") = False Then
            My.Computer.FileSystem.CreateDirectory("C:\\LoLRememberV2")
            On Error Resume Next
        End If
        On Error Resume Next

        If System.IO.Directory.Exists("C:\\LoLRememberV2\\Resources") = False Then
            My.Computer.FileSystem.CreateDirectory("C:\\LoLRememberV2\\Resources")
            On Error Resume Next
        End If
        On Error Resume Next
    End Sub
End Class