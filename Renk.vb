Public Class Renk
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Renk1 As DialogResult
        Renk1 = ColorDialog1.ShowDialog()
        If Renk1 = Windows.Forms.DialogResult.OK Then
            Tema.Panel1.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Renk2 As DialogResult
        Renk2 = ColorDialog2.ShowDialog()
        If Renk2 = Windows.Forms.DialogResult.OK Then
            Tema.Panel2.BackColor = ColorDialog2.Color
        End If
    End Sub

    Private Sub Renk_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class