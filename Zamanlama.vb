Public Class Zamanlama
    Private Sub Zamanlama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TransparencyKey = Color.LightBlue
        Me.BackColor = Color.LightBlue




    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Tema.CheckBox5.Checked = True Then
            TextBox1.Text = "[Solo]" + "Sıçra" + ":"
            TextBox2.Text = "[Solo]" + Tema.ComboBox6.Text + ":"
            Me.MaximumSize = New Size(197, 107)
            Me.MinimumSize = New Size(197, 107)


            TextBox4.Text = TF.B1.Interval / 1000
            TextBox3.Text = TF.S1.Interval / 1000

            TextBox5.Visible = False
            TextBox6.Visible = False
            TextBox7.Visible = False
            TextBox8.Visible = False

        End If


        If Tema.CheckBox6.Checked = True Then
            TextBox1.Text = "[Mid]" + "Sıçra" + ":"
            TextBox2.Text = "[Mid]" + Tema.ComboBox8.Text + ":"
            Me.MaximumSize = New Size(197, 107)
            Me.MinimumSize = New Size(197, 107)

            TextBox3.Text = TF.S3.Interval / 1000
            TextBox4.Text = TF.B3.Interval / 1000

        End If


        If Tema.CheckBox7.Checked = True Then
            TextBox1.Text = "[Jung]" + "Sıçra" + ":"
            TextBox2.Text = "[Jung]" + Tema.ComboBox7.Text + ":"
            Me.MaximumSize = New Size(197, 107)
            Me.MinimumSize = New Size(197, 107)
            TextBox3.Text = TF.S2.Interval / 1000
            TextBox4.Text = TF.B2.Interval / 1000

        End If



        If Tema.CheckBox8.Checked = True Then

            TextBox5.Visible = True
            TextBox6.Visible = True
            TextBox7.Visible = True
            TextBox8.Visible = True



            Me.MaximumSize = New Size(197, 171)
            Me.MinimumSize = New Size(197, 171)

            TextBox1.Text = "[Sup]" + "Sıçra" + ":"
            TextBox2.Text = "[Sup]" + Tema.ComboBox9.Text + ":"

            TextBox5.Text = "[Adc]" + "Sıçra" + ":"
            TextBox6.Text = "[Adc]" + Tema.ComboBox10.Text + ":"

            TextBox3.Text = TF.S4.Interval / 1000
            TextBox4.Text = TF.B4.Interval / 1000

            TextBox7.Text = TF.S5.Interval / 1000
            TextBox8.Text = TF.B5.Interval / 1000

        End If

    End Sub

End Class