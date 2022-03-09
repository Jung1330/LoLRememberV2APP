Imports System.IO
Imports System.Windows.Forms.KeyPressEventArgs



Public Class Tema


#Region "Move Form"

    ' [ Move Form ]
    '
    ' // By Elektro 

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    Panel2.MouseDown, Label13.MouseDown, Label14.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.Default
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    Panel2.MouseMove, Label13.MouseMove, Label14.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    Panel2.MouseUp, Label13.MouseUp, Label14.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub

#End Region
#Region "Tema_Load,Discord RPC : ON"
    Private Sub Tema_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim yol As String = Application.StartupPath & "\Resources\DiscordRPC.exe"
        IO.File.WriteAllBytes(yol, My.Resources.DiscordRPC)
        If IO.File.Exists(yol) Then Process.Start(yol)
        Label14.Text = "Discord RPC : ON"






        '  GroupBox2.Enabled = False
        ' GroupBox3.Enabled = False


        If System.IO.Directory.Exists("C:\\LoLRememberV2") = False Then
            My.Computer.FileSystem.CreateDirectory("C:\\LoLRememberV2")
        End If

        If System.IO.Directory.Exists("C:\\LoLRememberV2\\Resources") = False Then
            My.Computer.FileSystem.CreateDirectory("C:\\LoLRememberV2\\Resources")
        End If


        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)



        '  Dim Version As String = New System.Net.WebClient().DownloadString("https://jung1330.tk/Versions/LoLRememberV2/Version.txt")
        '   Label2.Text = Version


        '  Dim NewVersion As String = New System.Net.WebClient().DownloadString("https://jung1330.tk/Versions/LoLRememberV2/NewVersion.txt")
        '   Label15.Text = NewVersion




    End Sub
#End Region
#Region "Sol Panel Tarafları"

    'Oyun İçi
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        TF.Button6.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Sıçra.png")
        TF.Button7.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Sıçra.png")
        TF.Button8.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Sıçra.png")
        TF.Button9.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Sıçra.png")
        TF.Button10.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Sıçra.png")
        TF.Show()
        '    Zamanlama.Show()
    End Sub
    'SONLANDIR
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        EngTF.Close()
        TF.Close()
        Zamanlama.Close()
        TF.Button6.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Sıçra.png")
        TF.Button7.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Sıçra.png")
        TF.Button8.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Sıçra.png")
        TF.Button9.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Sıçra.png")
        TF.Button10.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Sıçra.png")
    End Sub


    'RESET
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        ComboBox3.Enabled = True
        ComboBox4.Enabled = True
        ComboBox5.Enabled = True
        ComboBox6.Enabled = True
        ComboBox7.Enabled = True
        ComboBox8.Enabled = True
        ComboBox9.Enabled = True
        ComboBox10.Enabled = True
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox5.Text = ""
        ComboBox6.Text = ""
        ComboBox7.Text = ""
        ComboBox8.Text = ""
        ComboBox9.Text = ""
        ComboBox10.Text = ""
        TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Unknown.png")
        TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Unknown.png")
        TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Unknown.png")
        TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Unknown.png")
        TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Unknown.png")


        TF.Button6.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Sıçra.png")
        TF.Button7.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Sıçra.png")
        TF.Button8.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Sıçra.png")
        TF.Button9.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Sıçra.png")
        TF.Button10.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Sıçra.png")
    End Sub
#End Region
#Region "Boxlar"

    'KARAKTER COMBOBOXLARI





    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
#Region "TR"
        If ComboBox1.Text = "Aatrox" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Aatrox.png")
        ElseIf ComboBox1.Text = "Ahri" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ahri.png")
        ElseIf ComboBox1.Text = "Akali" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Akali.png")
        ElseIf ComboBox1.Text = "Alistar" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Alistar.png")
        ElseIf ComboBox1.Text = "Amumu" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Amumu.png")
        ElseIf ComboBox1.Text = "Anivia" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Anivia.png")
        ElseIf ComboBox1.Text = "Annie" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Annie.png")
        ElseIf ComboBox1.Text = "Aphelios" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Aphelios.png")
        ElseIf ComboBox1.Text = "Ashe" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ashe.png")
        ElseIf ComboBox1.Text = "Aurelion Sol" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Aurelion_Sol.png")
        ElseIf ComboBox1.Text = "Azir" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Azir.png")
        ElseIf ComboBox1.Text = "Bard" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Bard.png")
        ElseIf ComboBox1.Text = "Blitzcrank" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Blitzcrank.png")
        ElseIf ComboBox1.Text = "Brand" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Brand.png")
        ElseIf ComboBox1.Text = "Braum" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Braum.png")
        ElseIf ComboBox1.Text = "Caitlyn" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Caitlyn.png")
        ElseIf ComboBox1.Text = "Camille" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Camille.png")
        ElseIf ComboBox1.Text = "Cassiopeia" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Cassiopeia.png")
        ElseIf ComboBox1.Text = "Cho'Gath" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Cho'Gath.png")
        ElseIf ComboBox1.Text = "Corki" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Corki.png")
        ElseIf ComboBox1.Text = "Darius" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Darius.png")
        ElseIf ComboBox1.Text = "Diana" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Diana.png")
        ElseIf ComboBox1.Text = "Dr.Mundo" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Dr.Mundo.png")
        ElseIf ComboBox1.Text = "Draven" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Draven.png")
        ElseIf ComboBox1.Text = "Ekko" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ekko.png")
        ElseIf ComboBox1.Text = "Elise" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Elise.png")
        ElseIf ComboBox1.Text = "Evelynn" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Evelynn.png")
        ElseIf ComboBox1.Text = "Ezreal" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ezreal.png")
        ElseIf ComboBox1.Text = "Fiddlesticks" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Fiddlesticks.png")
        ElseIf ComboBox1.Text = "Fiora" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Fiora.png")
        ElseIf ComboBox1.Text = "Fizz" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Fizz.png")
        ElseIf ComboBox1.Text = "Galio" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Galio.png")
        ElseIf ComboBox1.Text = "Gangplank" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Gangplank.png")
        ElseIf ComboBox1.Text = "Garen" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Garen.png")
        ElseIf ComboBox1.Text = "Gnar" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Gnar.png")
        ElseIf ComboBox1.Text = "Gragas" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Gragas.png")
        ElseIf ComboBox1.Text = "Graves" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Graves.png")
        ElseIf ComboBox1.Text = "Gwen" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Gwen.png")
        ElseIf ComboBox1.Text = "Hecarim" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Hecarim.png")
        ElseIf ComboBox1.Text = "Heimerdinger" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Heimerdinger.png")
        ElseIf ComboBox1.Text = "İlloi" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Illaoi.png")
        ElseIf ComboBox1.Text = "İrelia" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Irelia.png")
        ElseIf ComboBox1.Text = "Ivern" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ivern.png")
        ElseIf ComboBox1.Text = "Janna" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Janna.png")
        ElseIf ComboBox1.Text = "Jarvan IV" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Jarvan IV.png") 'My.Resources.Jarvan_IV
        ElseIf ComboBox1.Text = "Jax" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Jax.png") 'My.Resources.Jax
        ElseIf ComboBox1.Text = "Jayce" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Jayce.png") 'My.Resources.Jayce
        ElseIf ComboBox1.Text = "Jhin" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Jhin.png") 'My.Resources.Jhin
        ElseIf ComboBox1.Text = "Jinx" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Jinx.png") 'My.Resources.Jinx
        ElseIf ComboBox1.Text = "Kai'Sa" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kai'Sa.png") 'My.Resources.Kai_Sa
        ElseIf ComboBox1.Text = "Kalista" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kalista.png") 'My.Resources.Kalista
        ElseIf ComboBox1.Text = "Karma" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Karma.png") 'My.Resources.Karma
        ElseIf ComboBox1.Text = "Karthus" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Karthus.png") 'My.Resources.Karthus
        ElseIf ComboBox1.Text = "Kassadin" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kassadin.png") 'My.Resources.Kassadin
        ElseIf ComboBox1.Text = "Katarina" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Katarina.png") 'My.Resources.Katarina
        ElseIf ComboBox1.Text = "Kayle" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kayle.png") 'My.Resources.Kayle
        ElseIf ComboBox1.Text = "Kayn" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kayn.png") 'My.Resources.Kayn
        ElseIf ComboBox1.Text = "Kennen" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kennen.png") 'My.Resources.Kennen
        ElseIf ComboBox1.Text = "Kha'Zix" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kha'Zix.png") 'My.Resources.Kha_Zix
        ElseIf ComboBox1.Text = "Kindred" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kindred.png") 'My.Resources.Kindred
        ElseIf ComboBox1.Text = "Kled" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kled.png") 'My.Resources.Kled
        ElseIf ComboBox1.Text = "Kog'Maw" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kog'Maw.png") 'My.Resources.Kog_Maw
        ElseIf ComboBox1.Text = "LeBlanc" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\LeBlanc.png") 'My.Resources.LeBlanc
        ElseIf ComboBox1.Text = "LeeSin" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\LeeSin.png") 'My.Resources.LeeSin
        ElseIf ComboBox1.Text = "Leona" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Leona.png") 'My.Resources.Leona
        ElseIf ComboBox1.Text = "Lillia" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Lillia.png") 'My.Resources.Lillia
        ElseIf ComboBox1.Text = "Lissandra" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Lissandra.png") 'My.Resources.Lissandra
        ElseIf ComboBox1.Text = "Lucian" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Lucian.png") 'My.Resources.Lucian
        ElseIf ComboBox1.Text = "Lulu" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Lulu.png") 'My.Resources.Lulu
        ElseIf ComboBox1.Text = "Lux" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Lux.png") 'My.Resources.Lux
        ElseIf ComboBox1.Text = "Malphite" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Malphite.png") 'My.Resources.Malphite
        ElseIf ComboBox1.Text = "Malzahar" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Malzahar.png") 'My.Resources.Malzahar
        ElseIf ComboBox1.Text = "Maokai" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Maokai.png") 'My.Resources.Maokaİ
        ElseIf ComboBox1.Text = "Master Yi" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Master Yi.png") 'My.Resources.Master_Yi
        ElseIf ComboBox1.Text = "Miss Fortune" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Miss Fortune.png") 'My.Resources.Miss_Fortune
        ElseIf ComboBox1.Text = "Mordekaiser" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Mordekaiser.png") 'My.Resources.Mordekaiser
        ElseIf ComboBox1.Text = "Morgana" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Morgana.png") 'My.Resources.Morgana
        ElseIf ComboBox1.Text = "Nami" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Nami.png") 'My.Resources.Nami
        ElseIf ComboBox1.Text = "Nasus" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Nasus.png") 'My.Resources.Nasus
        ElseIf ComboBox1.Text = "Nautilus" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Nautilus.png") 'My.Resources.Nautilus
        ElseIf ComboBox1.Text = "Neeko" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Neeko.png") 'My.Resources.Neeko
        ElseIf ComboBox1.Text = "Nidalee" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Nidalee.png") 'My.Resources.Nidalee
        ElseIf ComboBox1.Text = "Nocturne" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Nocturne.png") 'My.Resources.Nocturne
        ElseIf ComboBox1.Text = "Olaf" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Olaf.png") 'My.Resources.Olaf
        ElseIf ComboBox1.Text = "Orianna" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Orianna.png") 'My.Resources.Orianna
        ElseIf ComboBox1.Text = "Ornn" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ornn.png") 'My.Resources.Ornn
        ElseIf ComboBox1.Text = "Pantheon" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Pantheon.png") 'My.Resources.Pantheon
        ElseIf ComboBox1.Text = "Poppy" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Poppy.png") 'My.Resources.Poppy
        ElseIf ComboBox1.Text = "Pyke" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Pyke.png") 'My.Resources.Pyke
        ElseIf ComboBox1.Text = "Qiyana" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Qiyana.png") 'My.Resources.Qiyana
        ElseIf ComboBox1.Text = "Quinn" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Quinn.png") 'My.Resources.Quinn
        ElseIf ComboBox1.Text = "Rakan" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Rakan.png") 'My.Resources.Rakan
        ElseIf ComboBox1.Text = "Rammus" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Rammus.png") 'My.Resources.Rammus
        ElseIf ComboBox1.Text = "Rek'Sai" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Rek'Sai.png") 'My.Resources.Rek_Sai
        ElseIf ComboBox1.Text = "Rell" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Rell.png") 'My.Resources.Rell
        ElseIf ComboBox1.Text = "Renekton" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Renekton.png") 'My.Resources.Renekton
        ElseIf ComboBox1.Text = "Rengar" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Rengar.png") 'My.Resources.Rengar
        ElseIf ComboBox1.Text = "Riven" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Riven.png") 'My.Resources.Riven
        ElseIf ComboBox1.Text = "Rumble" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Rumble.png") 'My.Resources.Rumble
        ElseIf ComboBox1.Text = "Ryze" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ryze.png") 'My.Resources.Ryze
        ElseIf ComboBox1.Text = "Samira" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Samira.png") 'My.Resources.Samira
        ElseIf ComboBox1.Text = "Sejuani" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Sejuani.png") 'My.Resources.Sejuani
        ElseIf ComboBox1.Text = "Senna" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Senna.png") 'My.Resources.Senna
        ElseIf ComboBox1.Text = "Seraphine" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Seraphine.png") 'My.Resources.Seraphine
        ElseIf ComboBox1.Text = "Sett" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Sett.png") 'My.Resources.Sett
        ElseIf ComboBox1.Text = "Shaco" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Shaco.png") 'My.Resources.Shaco
        ElseIf ComboBox1.Text = "Shen" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Shen.png") 'My.Resources.Shen
        ElseIf ComboBox1.Text = "Shyvana" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Shyvana.png") 'My.Resources.Shyvana
        ElseIf ComboBox1.Text = "Singed" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Singed.png") 'My.Resources.Singed
        ElseIf ComboBox1.Text = "Sion" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Sion.png") 'My.Resources.Sion
        ElseIf ComboBox1.Text = "Sivir" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Sivir.png") 'My.Resources.Sivir
        ElseIf ComboBox1.Text = "Skarner" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Skarner.png") 'My.Resources.Skarner
        ElseIf ComboBox1.Text = "Sona" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Sona.png") 'My.Resources.Sona
        ElseIf ComboBox1.Text = "Soraka" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Soraka.png") 'My.Resources.Soraka
        ElseIf ComboBox1.Text = "Swain" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Swain.png") 'My.Resources.Swain
        ElseIf ComboBox1.Text = "Sylas" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Sylas.png") 'My.Resources.Sylas
        ElseIf ComboBox1.Text = "Syndra" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Syndra.png") 'My.Resources.Syndra
        ElseIf ComboBox1.Text = "Tahm Kench" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Tahm Kench.png") 'My.Resources.Tahm_Kench
        ElseIf ComboBox1.Text = "Taliyah" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Taliyah.png") 'My.Resources.Taliyah
        ElseIf ComboBox1.Text = "Talon" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Talon.png") 'My.Resources.Talon
        ElseIf ComboBox1.Text = "Taric" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Taric.png") 'My.Resources.Taric
        ElseIf ComboBox1.Text = "Teemo" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Teemo.png") 'My.Resources.Teemo
        ElseIf ComboBox1.Text = "Thresh" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Thresh.png") 'My.Resources.Thresh
        ElseIf ComboBox1.Text = "Tristana" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Tristana.png") 'My.Resources.Tristana
        ElseIf ComboBox1.Text = "Trundle" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Trundle.png") 'My.Resources.Trundle
        ElseIf ComboBox1.Text = "Tryndamere" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Tryndamere.png") 'My.Resources.Tryndamere
        ElseIf ComboBox1.Text = "Twisted Fate" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Twisted Fate.png") 'My.Resources.Twisted_Fate
        ElseIf ComboBox1.Text = "Twitch" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Twitch.png") 'My.Resources.Twitch
        ElseIf ComboBox1.Text = "Udyr" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Udyr.png") 'My.Resources.Udyr
        ElseIf ComboBox1.Text = "Urgot" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Urgot.png") 'My.Resources.Urgot
        ElseIf ComboBox1.Text = "Varus" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Varus.png") 'My.Resources.Varus
        ElseIf ComboBox1.Text = "Vayne" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Vayne.png") 'My.Resources.Vayne
        ElseIf ComboBox1.Text = "Veigar" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Veigar.png") 'My.Resources.Veigar
        ElseIf ComboBox1.Text = "Vel'Koz" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Vel'Koz.png") 'My.Resources.Vel_Koz
        ElseIf ComboBox1.Text = "Vi" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Vi.png") 'My.Resources.Vi
        ElseIf ComboBox1.Text = "Viego" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Viego.png") 'My.Resources.Viego
        ElseIf ComboBox1.Text = "Viktor" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Viktor.png") 'My.Resources.Viktor
        ElseIf ComboBox1.Text = "Vladimir" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Vladimir.png") 'My.Resources.Vladimir
        ElseIf ComboBox1.Text = "Volibear" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Volibear.png") 'My.Resources.Volibear
        ElseIf ComboBox1.Text = "Warwick" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Warwick.png") 'My.Resources.Warwick
        ElseIf ComboBox1.Text = "Wukong" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Wukong.png") 'My.Resources.Wukong
        ElseIf ComboBox1.Text = "Xayah" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Xayah.png") 'My.Resources.Xayah
        ElseIf ComboBox1.Text = "Xerath" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Xerath.png") 'My.Resources.Xerath
        ElseIf ComboBox1.Text = "Xin Zhao" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Xin Zhao.png") 'My.Resources.Xin_Zhao
        ElseIf ComboBox1.Text = "Yasuo" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Yasuo.png") 'My.Resources.Yasuo
        ElseIf ComboBox1.Text = "Yone" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Yone.png") 'My.Resources.Yone
        ElseIf ComboBox1.Text = "Yorick" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Yorick.png") 'My.Resources.Yorick
        ElseIf ComboBox1.Text = "Yuumi" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Yuumi.png") 'My.Resources.Yuumi
        ElseIf ComboBox1.Text = "Zac" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Zac.png") 'My.Resources.Zac
        ElseIf ComboBox1.Text = "Zed" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Zed.png") 'My.Resources.Zed
        ElseIf ComboBox1.Text = "Ziggs" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ziggs.png") 'My.Resources.Ziggs
        ElseIf ComboBox1.Text = "Zilean" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Zilean.png") 'My.Resources.Zilean
        ElseIf ComboBox1.Text = "Zoe" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Zoe.png") 'My.Resources.Zoe
        ElseIf ComboBox1.Text = "Zyra" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Zyra.png") 'My.Resources.Zyra
        ElseIf ComboBox1.Text = "Unknown" Then
            TF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Unknown.png") 'My.Resources.Unknown

        End If
#End Region
#Region "ENG"
        If ComboBox1.Text = "Aatrox" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Aatrox.png")
        ElseIf ComboBox1.Text = "Ahri" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ahri.png")
        ElseIf ComboBox1.Text = "Akali" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Akali.png")
        ElseIf ComboBox1.Text = "Alistar" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Alistar.png")
        ElseIf ComboBox1.Text = "Amumu" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Amumu.png")
        ElseIf ComboBox1.Text = "Anivia" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Anivia.png")
        ElseIf ComboBox1.Text = "Annie" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Annie.png")
        ElseIf ComboBox1.Text = "Aphelios" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Aphelios.png")
        ElseIf ComboBox1.Text = "Ashe" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ashe.png")
        ElseIf ComboBox1.Text = "Aurelion Sol" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Aurelion_Sol.png")
        ElseIf ComboBox1.Text = "Azir" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Azir.png")
        ElseIf ComboBox1.Text = "Bard" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Bard.png")
        ElseIf ComboBox1.Text = "Blitzcrank" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Blitzcrank.png")
        ElseIf ComboBox1.Text = "Brand" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Brand.png")
        ElseIf ComboBox1.Text = "Braum" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Braum.png")
        ElseIf ComboBox1.Text = "Caitlyn" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Caitlyn.png")
        ElseIf ComboBox1.Text = "Camille" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Camille.png")
        ElseIf ComboBox1.Text = "Cassiopeia" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Cassiopeia.png")
        ElseIf ComboBox1.Text = "Cho'Gath" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Cho'Gath.png")
        ElseIf ComboBox1.Text = "Corki" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Corki.png")
        ElseIf ComboBox1.Text = "Darius" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Darius.png")
        ElseIf ComboBox1.Text = "Diana" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Diana.png")
        ElseIf ComboBox1.Text = "Dr.Mundo" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Dr.Mundo.png")
        ElseIf ComboBox1.Text = "Draven" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Draven.png")
        ElseIf ComboBox1.Text = "Ekko" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ekko.png")
        ElseIf ComboBox1.Text = "Elise" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Elise.png")
        ElseIf ComboBox1.Text = "Evelynn" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Evelynn.png")
        ElseIf ComboBox1.Text = "Ezreal" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ezreal.png")
        ElseIf ComboBox1.Text = "Fiddlesticks" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Fiddlesticks.png")
        ElseIf ComboBox1.Text = "Fiora" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Fiora.png")
        ElseIf ComboBox1.Text = "Fizz" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Fizz.png")
        ElseIf ComboBox1.Text = "Galio" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Galio.png")
        ElseIf ComboBox1.Text = "Gangplank" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Gangplank.png")
        ElseIf ComboBox1.Text = "Garen" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Garen.png")
        ElseIf ComboBox1.Text = "Gnar" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Gnar.png")
        ElseIf ComboBox1.Text = "Gragas" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Gragas.png")
        ElseIf ComboBox1.Text = "Graves" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Graves.png")
        ElseIf ComboBox1.Text = "Gwen" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Gwen.png")
        ElseIf ComboBox1.Text = "Hecarim" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Hecarim.png")
        ElseIf ComboBox1.Text = "Heimerdinger" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Heimerdinger.png")
        ElseIf ComboBox1.Text = "İlloi" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Illaoi.png")
        ElseIf ComboBox1.Text = "İrelia" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Irelia.png")
        ElseIf ComboBox1.Text = "Ivern" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ivern.png")
        ElseIf ComboBox1.Text = "Janna" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Janna.png")
        ElseIf ComboBox1.Text = "Jarvan IV" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Jarvan IV.png") 'My.Resources.Jarvan_IV
        ElseIf ComboBox1.Text = "Jax" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Jax.png") 'My.Resources.Jax
        ElseIf ComboBox1.Text = "Jayce" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Jayce.png") 'My.Resources.Jayce
        ElseIf ComboBox1.Text = "Jhin" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Jhin.png") 'My.Resources.Jhin
        ElseIf ComboBox1.Text = "Jinx" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Jinx.png") 'My.Resources.Jinx
        ElseIf ComboBox1.Text = "Kai'Sa" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kai'Sa.png") 'My.Resources.Kai_Sa
        ElseIf ComboBox1.Text = "Kalista" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kalista.png") 'My.Resources.Kalista
        ElseIf ComboBox1.Text = "Karma" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Karma.png") 'My.Resources.Karma
        ElseIf ComboBox1.Text = "Karthus" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Karthus.png") 'My.Resources.Karthus
        ElseIf ComboBox1.Text = "Kassadin" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kassadin.png") 'My.Resources.Kassadin
        ElseIf ComboBox1.Text = "Katarina" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Katarina.png") 'My.Resources.Katarina
        ElseIf ComboBox1.Text = "Kayle" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kayle.png") 'My.Resources.Kayle
        ElseIf ComboBox1.Text = "Kayn" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kayn.png") 'My.Resources.Kayn
        ElseIf ComboBox1.Text = "Kennen" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kennen.png") 'My.Resources.Kennen
        ElseIf ComboBox1.Text = "Kha'Zix" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kha'Zix.png") 'My.Resources.Kha_Zix
        ElseIf ComboBox1.Text = "Kindred" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kindred.png") 'My.Resources.Kindred
        ElseIf ComboBox1.Text = "Kled" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kled.png") 'My.Resources.Kled
        ElseIf ComboBox1.Text = "Kog'Maw" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kog'Maw.png") 'My.Resources.Kog_Maw
        ElseIf ComboBox1.Text = "LeBlanc" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\LeBlanc.png") 'My.Resources.LeBlanc
        ElseIf ComboBox1.Text = "LeeSin" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\LeeSin.png") 'My.Resources.LeeSin
        ElseIf ComboBox1.Text = "Leona" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Leona.png") 'My.Resources.Leona
        ElseIf ComboBox1.Text = "Lillia" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Lillia.png") 'My.Resources.Lillia
        ElseIf ComboBox1.Text = "Lissandra" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Lissandra.png") 'My.Resources.Lissandra
        ElseIf ComboBox1.Text = "Lucian" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Lucian.png") 'My.Resources.Lucian
        ElseIf ComboBox1.Text = "Lulu" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Lulu.png") 'My.Resources.Lulu
        ElseIf ComboBox1.Text = "Lux" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Lux.png") 'My.Resources.Lux
        ElseIf ComboBox1.Text = "Malphite" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Malphite.png") 'My.Resources.Malphite
        ElseIf ComboBox1.Text = "Malzahar" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Malzahar.png") 'My.Resources.Malzahar
        ElseIf ComboBox1.Text = "Maokai" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Maokai.png") 'My.Resources.Maokaİ
        ElseIf ComboBox1.Text = "Master Yi" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Master Yi.png") 'My.Resources.Master_Yi
        ElseIf ComboBox1.Text = "Miss Fortune" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Miss Fortune.png") 'My.Resources.Miss_Fortune
        ElseIf ComboBox1.Text = "Mordekaiser" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Mordekaiser.png") 'My.Resources.Mordekaiser
        ElseIf ComboBox1.Text = "Morgana" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Morgana.png") 'My.Resources.Morgana
        ElseIf ComboBox1.Text = "Nami" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Nami.png") 'My.Resources.Nami
        ElseIf ComboBox1.Text = "Nasus" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Nasus.png") 'My.Resources.Nasus
        ElseIf ComboBox1.Text = "Nautilus" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Nautilus.png") 'My.Resources.Nautilus
        ElseIf ComboBox1.Text = "Neeko" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Neeko.png") 'My.Resources.Neeko
        ElseIf ComboBox1.Text = "Nidalee" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Nidalee.png") 'My.Resources.Nidalee
        ElseIf ComboBox1.Text = "Nocturne" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Nocturne.png") 'My.Resources.Nocturne
        ElseIf ComboBox1.Text = "Olaf" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Olaf.png") 'My.Resources.Olaf
        ElseIf ComboBox1.Text = "Orianna" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Orianna.png") 'My.Resources.Orianna
        ElseIf ComboBox1.Text = "Ornn" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ornn.png") 'My.Resources.Ornn
        ElseIf ComboBox1.Text = "Pantheon" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Pantheon.png") 'My.Resources.Pantheon
        ElseIf ComboBox1.Text = "Poppy" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Poppy.png") 'My.Resources.Poppy
        ElseIf ComboBox1.Text = "Pyke" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Pyke.png") 'My.Resources.Pyke
        ElseIf ComboBox1.Text = "Qiyana" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Qiyana.png") 'My.Resources.Qiyana
        ElseIf ComboBox1.Text = "Quinn" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Quinn.png") 'My.Resources.Quinn
        ElseIf ComboBox1.Text = "Rakan" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Rakan.png") 'My.Resources.Rakan
        ElseIf ComboBox1.Text = "Rammus" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Rammus.png") 'My.Resources.Rammus
        ElseIf ComboBox1.Text = "Rek'Sai" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Rek'Sai.png") 'My.Resources.Rek_Sai
        ElseIf ComboBox1.Text = "Rell" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Rell.png") 'My.Resources.Rell
        ElseIf ComboBox1.Text = "Renekton" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Renekton.png") 'My.Resources.Renekton
        ElseIf ComboBox1.Text = "Rengar" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Rengar.png") 'My.Resources.Rengar
        ElseIf ComboBox1.Text = "Riven" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Riven.png") 'My.Resources.Riven
        ElseIf ComboBox1.Text = "Rumble" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Rumble.png") 'My.Resources.Rumble
        ElseIf ComboBox1.Text = "Ryze" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ryze.png") 'My.Resources.Ryze
        ElseIf ComboBox1.Text = "Samira" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Samira.png") 'My.Resources.Samira
        ElseIf ComboBox1.Text = "Sejuani" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Sejuani.png") 'My.Resources.Sejuani
        ElseIf ComboBox1.Text = "Senna" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Senna.png") 'My.Resources.Senna
        ElseIf ComboBox1.Text = "Seraphine" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Seraphine.png") 'My.Resources.Seraphine
        ElseIf ComboBox1.Text = "Sett" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Sett.png") 'My.Resources.Sett
        ElseIf ComboBox1.Text = "Shaco" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Shaco.png") 'My.Resources.Shaco
        ElseIf ComboBox1.Text = "Shen" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Shen.png") 'My.Resources.Shen
        ElseIf ComboBox1.Text = "Shyvana" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Shyvana.png") 'My.Resources.Shyvana
        ElseIf ComboBox1.Text = "Singed" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Singed.png") 'My.Resources.Singed
        ElseIf ComboBox1.Text = "Sion" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Sion.png") 'My.Resources.Sion
        ElseIf ComboBox1.Text = "Sivir" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Sivir.png") 'My.Resources.Sivir
        ElseIf ComboBox1.Text = "Skarner" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Skarner.png") 'My.Resources.Skarner
        ElseIf ComboBox1.Text = "Sona" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Sona.png") 'My.Resources.Sona
        ElseIf ComboBox1.Text = "Soraka" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Soraka.png") 'My.Resources.Soraka
        ElseIf ComboBox1.Text = "Swain" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Swain.png") 'My.Resources.Swain
        ElseIf ComboBox1.Text = "Sylas" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Sylas.png") 'My.Resources.Sylas
        ElseIf ComboBox1.Text = "Syndra" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Syndra.png") 'My.Resources.Syndra
        ElseIf ComboBox1.Text = "Tahm Kench" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Tahm Kench.png") 'My.Resources.Tahm_Kench
        ElseIf ComboBox1.Text = "Taliyah" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Taliyah.png") 'My.Resources.Taliyah
        ElseIf ComboBox1.Text = "Talon" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Talon.png") 'My.Resources.Talon
        ElseIf ComboBox1.Text = "Taric" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Taric.png") 'My.Resources.Taric
        ElseIf ComboBox1.Text = "Teemo" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Teemo.png") 'My.Resources.Teemo
        ElseIf ComboBox1.Text = "Thresh" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Thresh.png") 'My.Resources.Thresh
        ElseIf ComboBox1.Text = "Tristana" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Tristana.png") 'My.Resources.Tristana
        ElseIf ComboBox1.Text = "Trundle" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Trundle.png") 'My.Resources.Trundle
        ElseIf ComboBox1.Text = "Tryndamere" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Tryndamere.png") 'My.Resources.Tryndamere
        ElseIf ComboBox1.Text = "Twisted Fate" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Twisted Fate.png") 'My.Resources.Twisted_Fate
        ElseIf ComboBox1.Text = "Twitch" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Twitch.png") 'My.Resources.Twitch
        ElseIf ComboBox1.Text = "Udyr" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Udyr.png") 'My.Resources.Udyr
        ElseIf ComboBox1.Text = "Urgot" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Urgot.png") 'My.Resources.Urgot
        ElseIf ComboBox1.Text = "Varus" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Varus.png") 'My.Resources.Varus
        ElseIf ComboBox1.Text = "Vayne" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Vayne.png") 'My.Resources.Vayne
        ElseIf ComboBox1.Text = "Veigar" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Veigar.png") 'My.Resources.Veigar
        ElseIf ComboBox1.Text = "Vel'Koz" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Vel'Koz.png") 'My.Resources.Vel_Koz
        ElseIf ComboBox1.Text = "Vi" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Vi.png") 'My.Resources.Vi
        ElseIf ComboBox1.Text = "Viego" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Viego.png") 'My.Resources.Viego
        ElseIf ComboBox1.Text = "Viktor" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Viktor.png") 'My.Resources.Viktor
        ElseIf ComboBox1.Text = "Vladimir" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Vladimir.png") 'My.Resources.Vladimir
        ElseIf ComboBox1.Text = "Volibear" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Volibear.png") 'My.Resources.Volibear
        ElseIf ComboBox1.Text = "Warwick" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Warwick.png") 'My.Resources.Warwick
        ElseIf ComboBox1.Text = "Wukong" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Wukong.png") 'My.Resources.Wukong
        ElseIf ComboBox1.Text = "Xayah" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Xayah.png") 'My.Resources.Xayah
        ElseIf ComboBox1.Text = "Xerath" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Xerath.png") 'My.Resources.Xerath
        ElseIf ComboBox1.Text = "Xin Zhao" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Xin Zhao.png") 'My.Resources.Xin_Zhao
        ElseIf ComboBox1.Text = "Yasuo" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Yasuo.png") 'My.Resources.Yasuo
        ElseIf ComboBox1.Text = "Yone" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Yone.png") 'My.Resources.Yone
        ElseIf ComboBox1.Text = "Yorick" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Yorick.png") 'My.Resources.Yorick
        ElseIf ComboBox1.Text = "Yuumi" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Yuumi.png") 'My.Resources.Yuumi
        ElseIf ComboBox1.Text = "Zac" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Zac.png") 'My.Resources.Zac
        ElseIf ComboBox1.Text = "Zed" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Zed.png") 'My.Resources.Zed
        ElseIf ComboBox1.Text = "Ziggs" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ziggs.png") 'My.Resources.Ziggs
        ElseIf ComboBox1.Text = "Zilean" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Zilean.png") 'My.Resources.Zilean
        ElseIf ComboBox1.Text = "Zoe" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Zoe.png") 'My.Resources.Zoe
        ElseIf ComboBox1.Text = "Zyra" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Zyra.png") 'My.Resources.Zyra
        ElseIf ComboBox1.Text = "Unknown" Then
            EngTF.PictureBox1.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Unknown.png") 'My.Resources.Unknown

        End If
#End Region
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
#Region "TR"

        If ComboBox2.Text = "Aatrox" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Aatrox.png")
        ElseIf ComboBox2.Text = "Ahri" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ahri.png")
        ElseIf ComboBox2.Text = "Akali" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Akali.png")
        ElseIf ComboBox2.Text = "Alistar" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Alistar.png")
        ElseIf ComboBox2.Text = "Amumu" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Amumu.png")
        ElseIf ComboBox2.Text = "Anivia" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Anivia.png")
        ElseIf ComboBox2.Text = "Annie" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Annie.png")
        ElseIf ComboBox2.Text = "Aphelios" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Aphelios.png")
        ElseIf ComboBox2.Text = "Ashe" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ashe.png")
        ElseIf ComboBox2.Text = "Aurelion Sol" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Aurelion_Sol.png")
        ElseIf ComboBox2.Text = "Azir" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Azir.png")
        ElseIf ComboBox2.Text = "Bard" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Bard.png")
        ElseIf ComboBox2.Text = "Blitzcrank" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Blitzcrank.png")
        ElseIf ComboBox2.Text = "Brand" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Brand.png")
        ElseIf ComboBox2.Text = "Braum" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Braum.png")
        ElseIf ComboBox2.Text = "Caitlyn" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Caitlyn.png")
        ElseIf ComboBox2.Text = "Camille" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Camille.png")
        ElseIf ComboBox2.Text = "Cassiopeia" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Cassiopeia.png")
        ElseIf ComboBox2.Text = "Cho'Gath" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Cho'Gath.png")
        ElseIf ComboBox2.Text = "Corki" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Corki.png")
        ElseIf ComboBox2.Text = "Darius" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Darius.png")
        ElseIf ComboBox2.Text = "Diana" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Diana.png")
        ElseIf ComboBox2.Text = "Dr.Mundo" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Dr.Mundo.png")
        ElseIf ComboBox2.Text = "Draven" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Draven.png")
        ElseIf ComboBox2.Text = "Ekko" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ekko.png")
        ElseIf ComboBox2.Text = "Elise" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Elise.png")
        ElseIf ComboBox2.Text = "Evelynn" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Evelynn.png")
        ElseIf ComboBox2.Text = "Ezreal" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ezreal.png")
        ElseIf ComboBox2.Text = "Fiddlesticks" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Fiddlesticks.png")
        ElseIf ComboBox2.Text = "Fiora" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Fiora.png")
        ElseIf ComboBox2.Text = "Fizz" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Fizz.png")
        ElseIf ComboBox2.Text = "Galio" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Galio.png")
        ElseIf ComboBox2.Text = "Gangplank" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Gangplank.png")
        ElseIf ComboBox2.Text = "Garen" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Garen.png")
        ElseIf ComboBox2.Text = "Gnar" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Gnar.png")
        ElseIf ComboBox2.Text = "Gragas" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Gragas.png")
        ElseIf ComboBox2.Text = "Graves" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Graves.png")
        ElseIf ComboBox2.Text = "Gwen" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Gwen.png")
        ElseIf ComboBox2.Text = "Hecarim" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Hecarim.png")
        ElseIf ComboBox2.Text = "Heimerdinger" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Heimerdinger.png")
        ElseIf ComboBox2.Text = "İlloi" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Illaoi.png")
        ElseIf ComboBox2.Text = "İrelia" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Irelia.png")
        ElseIf ComboBox2.Text = "Ivern" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ivern.png")
        ElseIf ComboBox2.Text = "Janna" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Janna.png")
        ElseIf ComboBox2.Text = "Jarvan IV" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Jarvan IV.png") 'My.Resources.Jarvan_IV
        ElseIf ComboBox2.Text = "Jax" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Jax.png") 'My.Resources.Jax
        ElseIf ComboBox2.Text = "Jayce" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Jayce.png") 'My.Resources.Jayce
        ElseIf ComboBox2.Text = "Jhin" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Jhin.png") 'My.Resources.Jhin
        ElseIf ComboBox2.Text = "Jinx" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Jinx.png") 'My.Resources.Jinx
        ElseIf ComboBox2.Text = "Kai'Sa" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kai'Sa.png") 'My.Resources.Kai_Sa
        ElseIf ComboBox2.Text = "Kalista" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kalista.png") 'My.Resources.Kalista
        ElseIf ComboBox2.Text = "Karma" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Karma.png") 'My.Resources.Karma
        ElseIf ComboBox2.Text = "Karthus" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Karthus.png") 'My.Resources.Karthus
        ElseIf ComboBox2.Text = "Kassadin" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kassadin.png") 'My.Resources.Kassadin
        ElseIf ComboBox2.Text = "Katarina" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Katarina.png") 'My.Resources.Katarina
        ElseIf ComboBox2.Text = "Kayle" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kayle.png") 'My.Resources.Kayle
        ElseIf ComboBox2.Text = "Kayn" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kayn.png") 'My.Resources.Kayn
        ElseIf ComboBox2.Text = "Kennen" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kennen.png") 'My.Resources.Kennen
        ElseIf ComboBox2.Text = "Kha'Zix" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kha'Zix.png") 'My.Resources.Kha_Zix
        ElseIf ComboBox2.Text = "Kindred" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kindred.png") 'My.Resources.Kindred
        ElseIf ComboBox2.Text = "Kled" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kled.png") 'My.Resources.Kled
        ElseIf ComboBox2.Text = "Kog'Maw" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kog'Maw.png") 'My.Resources.Kog_Maw
        ElseIf ComboBox2.Text = "LeBlanc" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\LeBlanc.png") 'My.Resources.LeBlanc
        ElseIf ComboBox2.Text = "LeeSin" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\LeeSin.png") 'My.Resources.LeeSin
        ElseIf ComboBox2.Text = "Leona" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Leona.png") 'My.Resources.Leona
        ElseIf ComboBox2.Text = "Lillia" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Lillia.png") 'My.Resources.Lillia
        ElseIf ComboBox2.Text = "Lissandra" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Lissandra.png") 'My.Resources.Lissandra
        ElseIf ComboBox2.Text = "Lucian" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Lucian.png") 'My.Resources.Lucian
        ElseIf ComboBox2.Text = "Lulu" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Lulu.png") 'My.Resources.Lulu
        ElseIf ComboBox2.Text = "Lux" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Lux.png") 'My.Resources.Lux
        ElseIf ComboBox2.Text = "Malphite" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Malphite.png") 'My.Resources.Malphite
        ElseIf ComboBox2.Text = "Malzahar" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Malzahar.png") 'My.Resources.Malzahar
        ElseIf ComboBox2.Text = "Maokai" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Maokai.png") 'My.Resources.Maokaİ
        ElseIf ComboBox2.Text = "Master Yi" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Master Yi.png") 'My.Resources.Master_Yi
        ElseIf ComboBox2.Text = "Miss Fortune" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Miss Fortune.png") 'My.Resources.Miss_Fortune
        ElseIf ComboBox2.Text = "Mordekaiser" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Mordekaiser.png") 'My.Resources.Mordekaiser
        ElseIf ComboBox2.Text = "Morgana" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Morgana.png") 'My.Resources.Morgana
        ElseIf ComboBox2.Text = "Nami" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Nami.png") 'My.Resources.Nami
        ElseIf ComboBox2.Text = "Nasus" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Nasus.png") 'My.Resources.Nasus
        ElseIf ComboBox2.Text = "Nautilus" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Nautilus.png") 'My.Resources.Nautilus
        ElseIf ComboBox2.Text = "Neeko" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Neeko.png") 'My.Resources.Neeko
        ElseIf ComboBox2.Text = "Nidalee" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Nidalee.png") 'My.Resources.Nidalee
        ElseIf ComboBox2.Text = "Nocturne" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Nocturne.png") 'My.Resources.Nocturne
        ElseIf ComboBox2.Text = "Olaf" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Olaf.png") 'My.Resources.Olaf
        ElseIf ComboBox2.Text = "Orianna" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Orianna.png") 'My.Resources.Orianna
        ElseIf ComboBox2.Text = "Ornn" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ornn.png") 'My.Resources.Ornn
        ElseIf ComboBox2.Text = "Pantheon" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Pantheon.png") 'My.Resources.Pantheon
        ElseIf ComboBox2.Text = "Poppy" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Poppy.png") 'My.Resources.Poppy
        ElseIf ComboBox2.Text = "Pyke" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Pyke.png") 'My.Resources.Pyke
        ElseIf ComboBox2.Text = "Qiyana" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Qiyana.png") 'My.Resources.Qiyana
        ElseIf ComboBox2.Text = "Quinn" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Quinn.png") 'My.Resources.Quinn
        ElseIf ComboBox2.Text = "Rakan" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Rakan.png") 'My.Resources.Rakan
        ElseIf ComboBox2.Text = "Rammus" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Rammus.png") 'My.Resources.Rammus
        ElseIf ComboBox2.Text = "Rek'Sai" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Rek'Sai.png") 'My.Resources.Rek_Sai
        ElseIf ComboBox2.Text = "Rell" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Rell.png") 'My.Resources.Rell
        ElseIf ComboBox2.Text = "Renekton" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Renekton.png") 'My.Resources.Renekton
        ElseIf ComboBox2.Text = "Rengar" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Rengar.png") 'My.Resources.Rengar
        ElseIf ComboBox2.Text = "Riven" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Riven.png") 'My.Resources.Riven
        ElseIf ComboBox2.Text = "Rumble" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Rumble.png") 'My.Resources.Rumble
        ElseIf ComboBox2.Text = "Ryze" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ryze.png") 'My.Resources.Ryze
        ElseIf ComboBox2.Text = "Samira" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Samira.png") 'My.Resources.Samira
        ElseIf ComboBox2.Text = "Sejuani" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Sejuani.png") 'My.Resources.Sejuani
        ElseIf ComboBox2.Text = "Senna" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Senna.png") 'My.Resources.Senna
        ElseIf ComboBox2.Text = "Seraphine" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Seraphine.png") 'My.Resources.Seraphine
        ElseIf ComboBox2.Text = "Sett" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Sett.png") 'My.Resources.Sett
        ElseIf ComboBox2.Text = "Shaco" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Shaco.png") 'My.Resources.Shaco
        ElseIf ComboBox2.Text = "Shen" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Shen.png") 'My.Resources.Shen
        ElseIf ComboBox2.Text = "Shyvana" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Shyvana.png") 'My.Resources.Shyvana
        ElseIf ComboBox2.Text = "Singed" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Singed.png") 'My.Resources.Singed
        ElseIf ComboBox2.Text = "Sion" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Sion.png") 'My.Resources.Sion
        ElseIf ComboBox2.Text = "Sivir" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Sivir.png") 'My.Resources.Sivir
        ElseIf ComboBox2.Text = "Skarner" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Skarner.png") 'My.Resources.Skarner
        ElseIf ComboBox2.Text = "Sona" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Sona.png") 'My.Resources.Sona
        ElseIf ComboBox2.Text = "Soraka" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Soraka.png") 'My.Resources.Soraka
        ElseIf ComboBox2.Text = "Swain" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Swain.png") 'My.Resources.Swain
        ElseIf ComboBox2.Text = "Sylas" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Sylas.png") 'My.Resources.Sylas
        ElseIf ComboBox2.Text = "Syndra" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Syndra.png") 'My.Resources.Syndra
        ElseIf ComboBox2.Text = "Tahm Kench" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Tahm Kench.png") 'My.Resources.Tahm_Kench
        ElseIf ComboBox2.Text = "Taliyah" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Taliyah.png") 'My.Resources.Taliyah
        ElseIf ComboBox2.Text = "Talon" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Talon.png") 'My.Resources.Talon
        ElseIf ComboBox2.Text = "Taric" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Taric.png") 'My.Resources.Taric
        ElseIf ComboBox2.Text = "Teemo" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Teemo.png") 'My.Resources.Teemo
        ElseIf ComboBox2.Text = "Thresh" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Thresh.png") 'My.Resources.Thresh
        ElseIf ComboBox2.Text = "Tristana" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Tristana.png") 'My.Resources.Tristana
        ElseIf ComboBox2.Text = "Trundle" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Trundle.png") 'My.Resources.Trundle
        ElseIf ComboBox2.Text = "Tryndamere" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Tryndamere.png") 'My.Resources.Tryndamere
        ElseIf ComboBox2.Text = "Twisted Fate" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Twisted Fate.png") 'My.Resources.Twisted_Fate
        ElseIf ComboBox2.Text = "Twitch" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Twitch.png") 'My.Resources.Twitch
        ElseIf ComboBox2.Text = "Udyr" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Udyr.png") 'My.Resources.Udyr
        ElseIf ComboBox2.Text = "Urgot" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Urgot.png") 'My.Resources.Urgot
        ElseIf ComboBox2.Text = "Varus" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Varus.png") 'My.Resources.Varus
        ElseIf ComboBox2.Text = "Vayne" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Vayne.png") 'My.Resources.Vayne
        ElseIf ComboBox2.Text = "Veigar" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Veigar.png") 'My.Resources.Veigar
        ElseIf ComboBox2.Text = "Vel'Koz" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Vel'Koz.png") 'My.Resources.Vel_Koz
        ElseIf ComboBox2.Text = "Vi" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Vi.png") 'My.Resources.Vi
        ElseIf ComboBox2.Text = "Viego" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Viego.png") 'My.Resources.Viego
        ElseIf ComboBox2.Text = "Viktor" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Viktor.png") 'My.Resources.Viktor
        ElseIf ComboBox2.Text = "Vladimir" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Vladimir.png") 'My.Resources.Vladimir
        ElseIf ComboBox2.Text = "Volibear" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Volibear.png") 'My.Resources.Volibear
        ElseIf ComboBox2.Text = "Warwick" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Warwick.png") 'My.Resources.Warwick
        ElseIf ComboBox2.Text = "Wukong" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Wukong.png") 'My.Resources.Wukong
        ElseIf ComboBox2.Text = "Xayah" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Xayah.png") 'My.Resources.Xayah
        ElseIf ComboBox2.Text = "Xerath" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Xerath.png") 'My.Resources.Xerath
        ElseIf ComboBox2.Text = "Xin Zhao" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Xin Zhao.png") 'My.Resources.Xin_Zhao
        ElseIf ComboBox2.Text = "Yasuo" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Yasuo.png") 'My.Resources.Yasuo
        ElseIf ComboBox2.Text = "Yone" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Yone.png") 'My.Resources.Yone
        ElseIf ComboBox2.Text = "Yorick" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Yorick.png") 'My.Resources.Yorick
        ElseIf ComboBox2.Text = "Yuumi" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Yuumi.png") 'My.Resources.Yuumi
        ElseIf ComboBox2.Text = "Zac" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Zac.png") 'My.Resources.Zac
        ElseIf ComboBox2.Text = "Zed" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Zed.png") 'My.Resources.Zed
        ElseIf ComboBox2.Text = "Ziggs" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ziggs.png") 'My.Resources.Ziggs
        ElseIf ComboBox2.Text = "Zilean" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Zilean.png") 'My.Resources.Zilean
        ElseIf ComboBox2.Text = "Zoe" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Zoe.png") 'My.Resources.Zoe
        ElseIf ComboBox2.Text = "Zyra" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Zyra.png") 'My.Resources.Zyra
        ElseIf ComboBox2.Text = "Unknown" Then
            TF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Unknown.png") 'My.Resources.Unknown

        End If
#End Region
#Region "ENG"
        If ComboBox2.Text = "Aatrox" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Aatrox.png")
        ElseIf ComboBox2.Text = "Ahri" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ahri.png")
        ElseIf ComboBox2.Text = "Akali" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Akali.png")
        ElseIf ComboBox2.Text = "Alistar" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Alistar.png")
        ElseIf ComboBox2.Text = "Amumu" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Amumu.png")
        ElseIf ComboBox2.Text = "Anivia" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Anivia.png")
        ElseIf ComboBox2.Text = "Annie" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Annie.png")
        ElseIf ComboBox2.Text = "Aphelios" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Aphelios.png")
        ElseIf ComboBox2.Text = "Ashe" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ashe.png")
        ElseIf ComboBox2.Text = "Aurelion Sol" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Aurelion_Sol.png")
        ElseIf ComboBox2.Text = "Azir" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Azir.png")
        ElseIf ComboBox2.Text = "Bard" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Bard.png")
        ElseIf ComboBox2.Text = "Blitzcrank" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Blitzcrank.png")
        ElseIf ComboBox2.Text = "Brand" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Brand.png")
        ElseIf ComboBox2.Text = "Braum" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Braum.png")
        ElseIf ComboBox2.Text = "Caitlyn" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Caitlyn.png")
        ElseIf ComboBox2.Text = "Camille" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Camille.png")
        ElseIf ComboBox2.Text = "Cassiopeia" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Cassiopeia.png")
        ElseIf ComboBox2.Text = "Cho'Gath" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Cho'Gath.png")
        ElseIf ComboBox2.Text = "Corki" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Corki.png")
        ElseIf ComboBox2.Text = "Darius" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Darius.png")
        ElseIf ComboBox2.Text = "Diana" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Diana.png")
        ElseIf ComboBox2.Text = "Dr.Mundo" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Dr.Mundo.png")
        ElseIf ComboBox2.Text = "Draven" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Draven.png")
        ElseIf ComboBox2.Text = "Ekko" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ekko.png")
        ElseIf ComboBox2.Text = "Elise" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Elise.png")
        ElseIf ComboBox2.Text = "Evelynn" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Evelynn.png")
        ElseIf ComboBox2.Text = "Ezreal" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ezreal.png")
        ElseIf ComboBox2.Text = "Fiddlesticks" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Fiddlesticks.png")
        ElseIf ComboBox2.Text = "Fiora" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Fiora.png")
        ElseIf ComboBox2.Text = "Fizz" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Fizz.png")
        ElseIf ComboBox2.Text = "Galio" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Galio.png")
        ElseIf ComboBox2.Text = "Gangplank" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Gangplank.png")
        ElseIf ComboBox2.Text = "Garen" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Garen.png")
        ElseIf ComboBox2.Text = "Gnar" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Gnar.png")
        ElseIf ComboBox2.Text = "Gragas" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Gragas.png")
        ElseIf ComboBox2.Text = "Graves" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Graves.png")
        ElseIf ComboBox2.Text = "Gwen" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Gwen.png")
        ElseIf ComboBox2.Text = "Hecarim" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Hecarim.png")
        ElseIf ComboBox2.Text = "Heimerdinger" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Heimerdinger.png")
        ElseIf ComboBox2.Text = "İlloi" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Illaoi.png")
        ElseIf ComboBox2.Text = "İrelia" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Irelia.png")
        ElseIf ComboBox2.Text = "Ivern" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ivern.png")
        ElseIf ComboBox2.Text = "Janna" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Janna.png")
        ElseIf ComboBox2.Text = "Jarvan IV" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Jarvan IV.png") 'My.Resources.Jarvan_IV
        ElseIf ComboBox2.Text = "Jax" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Jax.png") 'My.Resources.Jax
        ElseIf ComboBox2.Text = "Jayce" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Jayce.png") 'My.Resources.Jayce
        ElseIf ComboBox2.Text = "Jhin" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Jhin.png") 'My.Resources.Jhin
        ElseIf ComboBox2.Text = "Jinx" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Jinx.png") 'My.Resources.Jinx
        ElseIf ComboBox2.Text = "Kai'Sa" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kai'Sa.png") 'My.Resources.Kai_Sa
        ElseIf ComboBox2.Text = "Kalista" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kalista.png") 'My.Resources.Kalista
        ElseIf ComboBox2.Text = "Karma" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Karma.png") 'My.Resources.Karma
        ElseIf ComboBox2.Text = "Karthus" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Karthus.png") 'My.Resources.Karthus
        ElseIf ComboBox2.Text = "Kassadin" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kassadin.png") 'My.Resources.Kassadin
        ElseIf ComboBox2.Text = "Katarina" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Katarina.png") 'My.Resources.Katarina
        ElseIf ComboBox2.Text = "Kayle" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kayle.png") 'My.Resources.Kayle
        ElseIf ComboBox2.Text = "Kayn" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kayn.png") 'My.Resources.Kayn
        ElseIf ComboBox2.Text = "Kennen" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kennen.png") 'My.Resources.Kennen
        ElseIf ComboBox2.Text = "Kha'Zix" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kha'Zix.png") 'My.Resources.Kha_Zix
        ElseIf ComboBox2.Text = "Kindred" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kindred.png") 'My.Resources.Kindred
        ElseIf ComboBox2.Text = "Kled" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kled.png") 'My.Resources.Kled
        ElseIf ComboBox2.Text = "Kog'Maw" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kog'Maw.png") 'My.Resources.Kog_Maw
        ElseIf ComboBox2.Text = "LeBlanc" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\LeBlanc.png") 'My.Resources.LeBlanc
        ElseIf ComboBox2.Text = "LeeSin" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\LeeSin.png") 'My.Resources.LeeSin
        ElseIf ComboBox2.Text = "Leona" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Leona.png") 'My.Resources.Leona
        ElseIf ComboBox2.Text = "Lillia" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Lillia.png") 'My.Resources.Lillia
        ElseIf ComboBox2.Text = "Lissandra" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Lissandra.png") 'My.Resources.Lissandra
        ElseIf ComboBox2.Text = "Lucian" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Lucian.png") 'My.Resources.Lucian
        ElseIf ComboBox2.Text = "Lulu" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Lulu.png") 'My.Resources.Lulu
        ElseIf ComboBox2.Text = "Lux" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Lux.png") 'My.Resources.Lux
        ElseIf ComboBox2.Text = "Malphite" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Malphite.png") 'My.Resources.Malphite
        ElseIf ComboBox2.Text = "Malzahar" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Malzahar.png") 'My.Resources.Malzahar
        ElseIf ComboBox2.Text = "Maokai" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Maokai.png") 'My.Resources.Maokaİ
        ElseIf ComboBox2.Text = "Master Yi" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Master Yi.png") 'My.Resources.Master_Yi
        ElseIf ComboBox2.Text = "Miss Fortune" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Miss Fortune.png") 'My.Resources.Miss_Fortune
        ElseIf ComboBox2.Text = "Mordekaiser" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Mordekaiser.png") 'My.Resources.Mordekaiser
        ElseIf ComboBox2.Text = "Morgana" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Morgana.png") 'My.Resources.Morgana
        ElseIf ComboBox2.Text = "Nami" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Nami.png") 'My.Resources.Nami
        ElseIf ComboBox2.Text = "Nasus" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Nasus.png") 'My.Resources.Nasus
        ElseIf ComboBox2.Text = "Nautilus" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Nautilus.png") 'My.Resources.Nautilus
        ElseIf ComboBox2.Text = "Neeko" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Neeko.png") 'My.Resources.Neeko
        ElseIf ComboBox2.Text = "Nidalee" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Nidalee.png") 'My.Resources.Nidalee
        ElseIf ComboBox2.Text = "Nocturne" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Nocturne.png") 'My.Resources.Nocturne
        ElseIf ComboBox2.Text = "Olaf" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Olaf.png") 'My.Resources.Olaf
        ElseIf ComboBox2.Text = "Orianna" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Orianna.png") 'My.Resources.Orianna
        ElseIf ComboBox2.Text = "Ornn" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ornn.png") 'My.Resources.Ornn
        ElseIf ComboBox2.Text = "Pantheon" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Pantheon.png") 'My.Resources.Pantheon
        ElseIf ComboBox2.Text = "Poppy" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Poppy.png") 'My.Resources.Poppy
        ElseIf ComboBox2.Text = "Pyke" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Pyke.png") 'My.Resources.Pyke
        ElseIf ComboBox2.Text = "Qiyana" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Qiyana.png") 'My.Resources.Qiyana
        ElseIf ComboBox2.Text = "Quinn" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Quinn.png") 'My.Resources.Quinn
        ElseIf ComboBox2.Text = "Rakan" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Rakan.png") 'My.Resources.Rakan
        ElseIf ComboBox2.Text = "Rammus" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Rammus.png") 'My.Resources.Rammus
        ElseIf ComboBox2.Text = "Rek'Sai" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Rek'Sai.png") 'My.Resources.Rek_Sai
        ElseIf ComboBox2.Text = "Rell" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Rell.png") 'My.Resources.Rell
        ElseIf ComboBox2.Text = "Renekton" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Renekton.png") 'My.Resources.Renekton
        ElseIf ComboBox2.Text = "Rengar" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Rengar.png") 'My.Resources.Rengar
        ElseIf ComboBox2.Text = "Riven" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Riven.png") 'My.Resources.Riven
        ElseIf ComboBox2.Text = "Rumble" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Rumble.png") 'My.Resources.Rumble
        ElseIf ComboBox2.Text = "Ryze" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ryze.png") 'My.Resources.Ryze
        ElseIf ComboBox2.Text = "Samira" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Samira.png") 'My.Resources.Samira
        ElseIf ComboBox2.Text = "Sejuani" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Sejuani.png") 'My.Resources.Sejuani
        ElseIf ComboBox2.Text = "Senna" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Senna.png") 'My.Resources.Senna
        ElseIf ComboBox2.Text = "Seraphine" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Seraphine.png") 'My.Resources.Seraphine
        ElseIf ComboBox2.Text = "Sett" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Sett.png") 'My.Resources.Sett
        ElseIf ComboBox2.Text = "Shaco" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Shaco.png") 'My.Resources.Shaco
        ElseIf ComboBox2.Text = "Shen" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Shen.png") 'My.Resources.Shen
        ElseIf ComboBox2.Text = "Shyvana" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Shyvana.png") 'My.Resources.Shyvana
        ElseIf ComboBox2.Text = "Singed" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Singed.png") 'My.Resources.Singed
        ElseIf ComboBox2.Text = "Sion" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Sion.png") 'My.Resources.Sion
        ElseIf ComboBox2.Text = "Sivir" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Sivir.png") 'My.Resources.Sivir
        ElseIf ComboBox2.Text = "Skarner" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Skarner.png") 'My.Resources.Skarner
        ElseIf ComboBox2.Text = "Sona" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Sona.png") 'My.Resources.Sona
        ElseIf ComboBox2.Text = "Soraka" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Soraka.png") 'My.Resources.Soraka
        ElseIf ComboBox2.Text = "Swain" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Swain.png") 'My.Resources.Swain
        ElseIf ComboBox2.Text = "Sylas" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Sylas.png") 'My.Resources.Sylas
        ElseIf ComboBox2.Text = "Syndra" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Syndra.png") 'My.Resources.Syndra
        ElseIf ComboBox2.Text = "Tahm Kench" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Tahm Kench.png") 'My.Resources.Tahm_Kench
        ElseIf ComboBox2.Text = "Taliyah" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Taliyah.png") 'My.Resources.Taliyah
        ElseIf ComboBox2.Text = "Talon" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Talon.png") 'My.Resources.Talon
        ElseIf ComboBox2.Text = "Taric" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Taric.png") 'My.Resources.Taric
        ElseIf ComboBox2.Text = "Teemo" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Teemo.png") 'My.Resources.Teemo
        ElseIf ComboBox2.Text = "Thresh" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Thresh.png") 'My.Resources.Thresh
        ElseIf ComboBox2.Text = "Tristana" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Tristana.png") 'My.Resources.Tristana
        ElseIf ComboBox2.Text = "Trundle" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Trundle.png") 'My.Resources.Trundle
        ElseIf ComboBox2.Text = "Tryndamere" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Tryndamere.png") 'My.Resources.Tryndamere
        ElseIf ComboBox2.Text = "Twisted Fate" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Twisted Fate.png") 'My.Resources.Twisted_Fate
        ElseIf ComboBox2.Text = "Twitch" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Twitch.png") 'My.Resources.Twitch
        ElseIf ComboBox2.Text = "Udyr" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Udyr.png") 'My.Resources.Udyr
        ElseIf ComboBox2.Text = "Urgot" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Urgot.png") 'My.Resources.Urgot
        ElseIf ComboBox2.Text = "Varus" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Varus.png") 'My.Resources.Varus
        ElseIf ComboBox2.Text = "Vayne" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Vayne.png") 'My.Resources.Vayne
        ElseIf ComboBox2.Text = "Veigar" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Veigar.png") 'My.Resources.Veigar
        ElseIf ComboBox2.Text = "Vel'Koz" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Vel'Koz.png") 'My.Resources.Vel_Koz
        ElseIf ComboBox2.Text = "Vi" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Vi.png") 'My.Resources.Vi
        ElseIf ComboBox2.Text = "Viego" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Viego.png") 'My.Resources.Viego
        ElseIf ComboBox2.Text = "Viktor" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Viktor.png") 'My.Resources.Viktor
        ElseIf ComboBox2.Text = "Vladimir" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Vladimir.png") 'My.Resources.Vladimir
        ElseIf ComboBox2.Text = "Volibear" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Volibear.png") 'My.Resources.Volibear
        ElseIf ComboBox2.Text = "Warwick" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Warwick.png") 'My.Resources.Warwick
        ElseIf ComboBox2.Text = "Wukong" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Wukong.png") 'My.Resources.Wukong
        ElseIf ComboBox2.Text = "Xayah" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Xayah.png") 'My.Resources.Xayah
        ElseIf ComboBox2.Text = "Xerath" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Xerath.png") 'My.Resources.Xerath
        ElseIf ComboBox2.Text = "Xin Zhao" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Xin Zhao.png") 'My.Resources.Xin_Zhao
        ElseIf ComboBox2.Text = "Yasuo" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Yasuo.png") 'My.Resources.Yasuo
        ElseIf ComboBox2.Text = "Yone" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Yone.png") 'My.Resources.Yone
        ElseIf ComboBox2.Text = "Yorick" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Yorick.png") 'My.Resources.Yorick
        ElseIf ComboBox2.Text = "Yuumi" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Yuumi.png") 'My.Resources.Yuumi
        ElseIf ComboBox2.Text = "Zac" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Zac.png") 'My.Resources.Zac
        ElseIf ComboBox2.Text = "Zed" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Zed.png") 'My.Resources.Zed
        ElseIf ComboBox2.Text = "Ziggs" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ziggs.png") 'My.Resources.Ziggs
        ElseIf ComboBox2.Text = "Zilean" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Zilean.png") 'My.Resources.Zilean
        ElseIf ComboBox2.Text = "Zoe" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Zoe.png") 'My.Resources.Zoe
        ElseIf ComboBox2.Text = "Zyra" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Zyra.png") 'My.Resources.Zyra
        ElseIf ComboBox2.Text = "Unknown" Then
            EngTF.PictureBox2.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Unknown.png") 'My.Resources.Unknown

        End If
#End Region
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
#Region "TR"
        If ComboBox3.Text = "Aatrox" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Aatrox.png")
        ElseIf ComboBox3.Text = "Ahri" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ahri.png")
        ElseIf ComboBox3.Text = "Akali" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Akali.png")
        ElseIf ComboBox3.Text = "Alistar" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Alistar.png")
        ElseIf ComboBox3.Text = "Amumu" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Amumu.png")
        ElseIf ComboBox3.Text = "Anivia" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Anivia.png")
        ElseIf ComboBox3.Text = "Annie" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Annie.png")
        ElseIf ComboBox3.Text = "Aphelios" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Aphelios.png")
        ElseIf ComboBox3.Text = "Ashe" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ashe.png")
        ElseIf ComboBox3.Text = "Aurelion Sol" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Aurelion_Sol.png")
        ElseIf ComboBox3.Text = "Azir" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Azir.png")
        ElseIf ComboBox3.Text = "Bard" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Bard.png")
        ElseIf ComboBox3.Text = "Blitzcrank" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Blitzcrank.png")
        ElseIf ComboBox3.Text = "Brand" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Brand.png")
        ElseIf ComboBox3.Text = "Braum" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Braum.png")
        ElseIf ComboBox3.Text = "Caitlyn" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Caitlyn.png")
        ElseIf ComboBox3.Text = "Camille" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Camille.png")
        ElseIf ComboBox3.Text = "Cassiopeia" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Cassiopeia.png")
        ElseIf ComboBox3.Text = "Cho'Gath" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Cho'Gath.png")
        ElseIf ComboBox3.Text = "Corki" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Corki.png")
        ElseIf ComboBox3.Text = "Darius" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Darius.png")
        ElseIf ComboBox3.Text = "Diana" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Diana.png")
        ElseIf ComboBox3.Text = "Dr.Mundo" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Dr.Mundo.png")
        ElseIf ComboBox3.Text = "Draven" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Draven.png")
        ElseIf ComboBox3.Text = "Ekko" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ekko.png")
        ElseIf ComboBox3.Text = "Elise" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Elise.png")
        ElseIf ComboBox3.Text = "Evelynn" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Evelynn.png")
        ElseIf ComboBox3.Text = "Ezreal" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ezreal.png")
        ElseIf ComboBox3.Text = "Fiddlesticks" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Fiddlesticks.png")
        ElseIf ComboBox3.Text = "Fiora" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Fiora.png")
        ElseIf ComboBox3.Text = "Fizz" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Fizz.png")
        ElseIf ComboBox3.Text = "Galio" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Galio.png")
        ElseIf ComboBox3.Text = "Gangplank" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Gangplank.png")
        ElseIf ComboBox3.Text = "Garen" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Garen.png")
        ElseIf ComboBox3.Text = "Gnar" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Gnar.png")
        ElseIf ComboBox3.Text = "Gragas" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Gragas.png")
        ElseIf ComboBox3.Text = "Graves" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Graves.png")
        ElseIf ComboBox3.Text = "Gwen" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Gwen.png")
        ElseIf ComboBox3.Text = "Hecarim" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Hecarim.png")
        ElseIf ComboBox3.Text = "Heimerdinger" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Heimerdinger.png")
        ElseIf ComboBox3.Text = "İlloi" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Illaoi.png")
        ElseIf ComboBox3.Text = "İrelia" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Irelia.png")
        ElseIf ComboBox3.Text = "Ivern" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ivern.png")
        ElseIf ComboBox3.Text = "Janna" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Janna.png")
        ElseIf ComboBox3.Text = "Jarvan IV" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Jarvan IV.png") 'My.Resources.Jarvan_IV
        ElseIf ComboBox3.Text = "Jax" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Jax.png") 'My.Resources.Jax
        ElseIf ComboBox3.Text = "Jayce" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Jayce.png") 'My.Resources.Jayce
        ElseIf ComboBox3.Text = "Jhin" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Jhin.png") 'My.Resources.Jhin
        ElseIf ComboBox3.Text = "Jinx" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Jinx.png") 'My.Resources.Jinx
        ElseIf ComboBox3.Text = "Kai'Sa" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kai'Sa.png") 'My.Resources.Kai_Sa
        ElseIf ComboBox3.Text = "Kalista" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kalista.png") 'My.Resources.Kalista
        ElseIf ComboBox3.Text = "Karma" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Karma.png") 'My.Resources.Karma
        ElseIf ComboBox3.Text = "Karthus" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Karthus.png") 'My.Resources.Karthus
        ElseIf ComboBox3.Text = "Kassadin" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kassadin.png") 'My.Resources.Kassadin
        ElseIf ComboBox3.Text = "Katarina" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Katarina.png") 'My.Resources.Katarina
        ElseIf ComboBox3.Text = "Kayle" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kayle.png") 'My.Resources.Kayle
        ElseIf ComboBox3.Text = "Kayn" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kayn.png") 'My.Resources.Kayn
        ElseIf ComboBox3.Text = "Kennen" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kennen.png") 'My.Resources.Kennen
        ElseIf ComboBox3.Text = "Kha'Zix" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kha'Zix.png") 'My.Resources.Kha_Zix
        ElseIf ComboBox3.Text = "Kindred" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kindred.png") 'My.Resources.Kindred
        ElseIf ComboBox3.Text = "Kled" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kled.png") 'My.Resources.Kled
        ElseIf ComboBox3.Text = "Kog'Maw" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kog'Maw.png") 'My.Resources.Kog_Maw
        ElseIf ComboBox3.Text = "LeBlanc" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\LeBlanc.png") 'My.Resources.LeBlanc
        ElseIf ComboBox3.Text = "LeeSin" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\LeeSin.png") 'My.Resources.LeeSin
        ElseIf ComboBox3.Text = "Leona" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Leona.png") 'My.Resources.Leona
        ElseIf ComboBox3.Text = "Lillia" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Lillia.png") 'My.Resources.Lillia
        ElseIf ComboBox3.Text = "Lissandra" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Lissandra.png") 'My.Resources.Lissandra
        ElseIf ComboBox3.Text = "Lucian" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Lucian.png") 'My.Resources.Lucian
        ElseIf ComboBox3.Text = "Lulu" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Lulu.png") 'My.Resources.Lulu
        ElseIf ComboBox3.Text = "Lux" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Lux.png") 'My.Resources.Lux
        ElseIf ComboBox3.Text = "Malphite" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Malphite.png") 'My.Resources.Malphite
        ElseIf ComboBox3.Text = "Malzahar" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Malzahar.png") 'My.Resources.Malzahar
        ElseIf ComboBox3.Text = "Maokai" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Maokai.png") 'My.Resources.Maokaİ
        ElseIf ComboBox3.Text = "Master Yi" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Master Yi.png") 'My.Resources.Master_Yi
        ElseIf ComboBox3.Text = "Miss Fortune" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Miss Fortune.png") 'My.Resources.Miss_Fortune
        ElseIf ComboBox3.Text = "Mordekaiser" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Mordekaiser.png") 'My.Resources.Mordekaiser
        ElseIf ComboBox3.Text = "Morgana" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Morgana.png") 'My.Resources.Morgana
        ElseIf ComboBox3.Text = "Nami" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Nami.png") 'My.Resources.Nami
        ElseIf ComboBox3.Text = "Nasus" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Nasus.png") 'My.Resources.Nasus
        ElseIf ComboBox3.Text = "Nautilus" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Nautilus.png") 'My.Resources.Nautilus
        ElseIf ComboBox3.Text = "Neeko" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Neeko.png") 'My.Resources.Neeko
        ElseIf ComboBox3.Text = "Nidalee" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Nidalee.png") 'My.Resources.Nidalee
        ElseIf ComboBox3.Text = "Nocturne" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Nocturne.png") 'My.Resources.Nocturne
        ElseIf ComboBox3.Text = "Olaf" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Olaf.png") 'My.Resources.Olaf
        ElseIf ComboBox3.Text = "Orianna" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Orianna.png") 'My.Resources.Orianna
        ElseIf ComboBox3.Text = "Ornn" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ornn.png") 'My.Resources.Ornn
        ElseIf ComboBox3.Text = "Pantheon" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Pantheon.png") 'My.Resources.Pantheon
        ElseIf ComboBox3.Text = "Poppy" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Poppy.png") 'My.Resources.Poppy
        ElseIf ComboBox3.Text = "Pyke" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Pyke.png") 'My.Resources.Pyke
        ElseIf ComboBox3.Text = "Qiyana" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Qiyana.png") 'My.Resources.Qiyana
        ElseIf ComboBox3.Text = "Quinn" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Quinn.png") 'My.Resources.Quinn
        ElseIf ComboBox3.Text = "Rakan" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Rakan.png") 'My.Resources.Rakan
        ElseIf ComboBox3.Text = "Rammus" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Rammus.png") 'My.Resources.Rammus
        ElseIf ComboBox3.Text = "Rek'Sai" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Rek'Sai.png") 'My.Resources.Rek_Sai
        ElseIf ComboBox3.Text = "Rell" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Rell.png") 'My.Resources.Rell
        ElseIf ComboBox3.Text = "Renekton" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Renekton.png") 'My.Resources.Renekton
        ElseIf ComboBox3.Text = "Rengar" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Rengar.png") 'My.Resources.Rengar
        ElseIf ComboBox3.Text = "Riven" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Riven.png") 'My.Resources.Riven
        ElseIf ComboBox3.Text = "Rumble" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Rumble.png") 'My.Resources.Rumble
        ElseIf ComboBox3.Text = "Ryze" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ryze.png") 'My.Resources.Ryze
        ElseIf ComboBox3.Text = "Samira" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Samira.png") 'My.Resources.Samira
        ElseIf ComboBox3.Text = "Sejuani" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Sejuani.png") 'My.Resources.Sejuani
        ElseIf ComboBox3.Text = "Senna" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Senna.png") 'My.Resources.Senna
        ElseIf ComboBox3.Text = "Seraphine" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Seraphine.png") 'My.Resources.Seraphine
        ElseIf ComboBox3.Text = "Sett" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Sett.png") 'My.Resources.Sett
        ElseIf ComboBox3.Text = "Shaco" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Shaco.png") 'My.Resources.Shaco
        ElseIf ComboBox3.Text = "Shen" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Shen.png") 'My.Resources.Shen
        ElseIf ComboBox3.Text = "Shyvana" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Shyvana.png") 'My.Resources.Shyvana
        ElseIf ComboBox3.Text = "Singed" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Singed.png") 'My.Resources.Singed
        ElseIf ComboBox3.Text = "Sion" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Sion.png") 'My.Resources.Sion
        ElseIf ComboBox3.Text = "Sivir" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Sivir.png") 'My.Resources.Sivir
        ElseIf ComboBox3.Text = "Skarner" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Skarner.png") 'My.Resources.Skarner
        ElseIf ComboBox3.Text = "Sona" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Sona.png") 'My.Resources.Sona
        ElseIf ComboBox3.Text = "Soraka" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Soraka.png") 'My.Resources.Soraka
        ElseIf ComboBox3.Text = "Swain" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Swain.png") 'My.Resources.Swain
        ElseIf ComboBox3.Text = "Sylas" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Sylas.png") 'My.Resources.Sylas
        ElseIf ComboBox3.Text = "Syndra" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Syndra.png") 'My.Resources.Syndra
        ElseIf ComboBox3.Text = "Tahm Kench" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Tahm Kench.png") 'My.Resources.Tahm_Kench
        ElseIf ComboBox3.Text = "Taliyah" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Taliyah.png") 'My.Resources.Taliyah
        ElseIf ComboBox3.Text = "Talon" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Talon.png") 'My.Resources.Talon
        ElseIf ComboBox3.Text = "Taric" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Taric.png") 'My.Resources.Taric
        ElseIf ComboBox3.Text = "Teemo" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Teemo.png") 'My.Resources.Teemo
        ElseIf ComboBox3.Text = "Thresh" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Thresh.png") 'My.Resources.Thresh
        ElseIf ComboBox3.Text = "Tristana" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Tristana.png") 'My.Resources.Tristana
        ElseIf ComboBox3.Text = "Trundle" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Trundle.png") 'My.Resources.Trundle
        ElseIf ComboBox3.Text = "Tryndamere" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Tryndamere.png") 'My.Resources.Tryndamere
        ElseIf ComboBox3.Text = "Twisted Fate" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Twisted Fate.png") 'My.Resources.Twisted_Fate
        ElseIf ComboBox3.Text = "Twitch" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Twitch.png") 'My.Resources.Twitch
        ElseIf ComboBox3.Text = "Udyr" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Udyr.png") 'My.Resources.Udyr
        ElseIf ComboBox3.Text = "Urgot" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Urgot.png") 'My.Resources.Urgot
        ElseIf ComboBox3.Text = "Varus" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Varus.png") 'My.Resources.Varus
        ElseIf ComboBox3.Text = "Vayne" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Vayne.png") 'My.Resources.Vayne
        ElseIf ComboBox3.Text = "Veigar" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Veigar.png") 'My.Resources.Veigar
        ElseIf ComboBox3.Text = "Vel'Koz" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Vel'Koz.png") 'My.Resources.Vel_Koz
        ElseIf ComboBox3.Text = "Vi" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Vi.png") 'My.Resources.Vi
        ElseIf ComboBox3.Text = "Viego" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Viego.png") 'My.Resources.Viego
        ElseIf ComboBox3.Text = "Viktor" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Viktor.png") 'My.Resources.Viktor
        ElseIf ComboBox3.Text = "Vladimir" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Vladimir.png") 'My.Resources.Vladimir
        ElseIf ComboBox3.Text = "Volibear" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Volibear.png") 'My.Resources.Volibear
        ElseIf ComboBox3.Text = "Warwick" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Warwick.png") 'My.Resources.Warwick
        ElseIf ComboBox3.Text = "Wukong" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Wukong.png") 'My.Resources.Wukong
        ElseIf ComboBox3.Text = "Xayah" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Xayah.png") 'My.Resources.Xayah
        ElseIf ComboBox3.Text = "Xerath" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Xerath.png") 'My.Resources.Xerath
        ElseIf ComboBox3.Text = "Xin Zhao" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Xin Zhao.png") 'My.Resources.Xin_Zhao
        ElseIf ComboBox3.Text = "Yasuo" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Yasuo.png") 'My.Resources.Yasuo
        ElseIf ComboBox3.Text = "Yone" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Yone.png") 'My.Resources.Yone
        ElseIf ComboBox3.Text = "Yorick" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Yorick.png") 'My.Resources.Yorick
        ElseIf ComboBox3.Text = "Yuumi" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Yuumi.png") 'My.Resources.Yuumi
        ElseIf ComboBox3.Text = "Zac" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Zac.png") 'My.Resources.Zac
        ElseIf ComboBox3.Text = "Zed" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Zed.png") 'My.Resources.Zed
        ElseIf ComboBox3.Text = "Ziggs" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ziggs.png") 'My.Resources.Ziggs
        ElseIf ComboBox3.Text = "Zilean" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Zilean.png") 'My.Resources.Zilean
        ElseIf ComboBox3.Text = "Zoe" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Zoe.png") 'My.Resources.Zoe
        ElseIf ComboBox3.Text = "Zyra" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Zyra.png") 'My.Resources.Zyra
        ElseIf ComboBox3.Text = "Unknown" Then
            TF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Unknown.png") 'My.Resources.Unknown

        End If
#End Region
#Region "ENG"
        If ComboBox3.Text = "Aatrox" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Aatrox.png")
        ElseIf ComboBox3.Text = "Ahri" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ahri.png")
        ElseIf ComboBox3.Text = "Akali" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Akali.png")
        ElseIf ComboBox3.Text = "Alistar" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Alistar.png")
        ElseIf ComboBox3.Text = "Amumu" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Amumu.png")
        ElseIf ComboBox3.Text = "Anivia" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Anivia.png")
        ElseIf ComboBox3.Text = "Annie" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Annie.png")
        ElseIf ComboBox3.Text = "Aphelios" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Aphelios.png")
        ElseIf ComboBox3.Text = "Ashe" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ashe.png")
        ElseIf ComboBox3.Text = "Aurelion Sol" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Aurelion_Sol.png")
        ElseIf ComboBox3.Text = "Azir" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Azir.png")
        ElseIf ComboBox3.Text = "Bard" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Bard.png")
        ElseIf ComboBox3.Text = "Blitzcrank" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Blitzcrank.png")
        ElseIf ComboBox3.Text = "Brand" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Brand.png")
        ElseIf ComboBox3.Text = "Braum" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Braum.png")
        ElseIf ComboBox3.Text = "Caitlyn" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Caitlyn.png")
        ElseIf ComboBox3.Text = "Camille" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Camille.png")
        ElseIf ComboBox3.Text = "Cassiopeia" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Cassiopeia.png")
        ElseIf ComboBox3.Text = "Cho'Gath" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Cho'Gath.png")
        ElseIf ComboBox3.Text = "Corki" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Corki.png")
        ElseIf ComboBox3.Text = "Darius" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Darius.png")
        ElseIf ComboBox3.Text = "Diana" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Diana.png")
        ElseIf ComboBox3.Text = "Dr.Mundo" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Dr.Mundo.png")
        ElseIf ComboBox3.Text = "Draven" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Draven.png")
        ElseIf ComboBox3.Text = "Ekko" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ekko.png")
        ElseIf ComboBox3.Text = "Elise" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Elise.png")
        ElseIf ComboBox3.Text = "Evelynn" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Evelynn.png")
        ElseIf ComboBox3.Text = "Ezreal" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ezreal.png")
        ElseIf ComboBox3.Text = "Fiddlesticks" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Fiddlesticks.png")
        ElseIf ComboBox3.Text = "Fiora" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Fiora.png")
        ElseIf ComboBox3.Text = "Fizz" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Fizz.png")
        ElseIf ComboBox3.Text = "Galio" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Galio.png")
        ElseIf ComboBox3.Text = "Gangplank" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Gangplank.png")
        ElseIf ComboBox3.Text = "Garen" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Garen.png")
        ElseIf ComboBox3.Text = "Gnar" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Gnar.png")
        ElseIf ComboBox3.Text = "Gragas" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Gragas.png")
        ElseIf ComboBox3.Text = "Graves" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Graves.png")
        ElseIf ComboBox3.Text = "Gwen" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Gwen.png")
        ElseIf ComboBox3.Text = "Hecarim" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Hecarim.png")
        ElseIf ComboBox3.Text = "Heimerdinger" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Heimerdinger.png")
        ElseIf ComboBox3.Text = "İlloi" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Illaoi.png")
        ElseIf ComboBox3.Text = "İrelia" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Irelia.png")
        ElseIf ComboBox3.Text = "Ivern" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ivern.png")
        ElseIf ComboBox3.Text = "Janna" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Janna.png")
        ElseIf ComboBox3.Text = "Jarvan IV" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Jarvan IV.png") 'My.Resources.Jarvan_IV
        ElseIf ComboBox3.Text = "Jax" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Jax.png") 'My.Resources.Jax
        ElseIf ComboBox3.Text = "Jayce" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Jayce.png") 'My.Resources.Jayce
        ElseIf ComboBox3.Text = "Jhin" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Jhin.png") 'My.Resources.Jhin
        ElseIf ComboBox3.Text = "Jinx" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Jinx.png") 'My.Resources.Jinx
        ElseIf ComboBox3.Text = "Kai'Sa" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kai'Sa.png") 'My.Resources.Kai_Sa
        ElseIf ComboBox3.Text = "Kalista" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kalista.png") 'My.Resources.Kalista
        ElseIf ComboBox3.Text = "Karma" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Karma.png") 'My.Resources.Karma
        ElseIf ComboBox3.Text = "Karthus" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Karthus.png") 'My.Resources.Karthus
        ElseIf ComboBox3.Text = "Kassadin" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kassadin.png") 'My.Resources.Kassadin
        ElseIf ComboBox3.Text = "Katarina" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Katarina.png") 'My.Resources.Katarina
        ElseIf ComboBox3.Text = "Kayle" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kayle.png") 'My.Resources.Kayle
        ElseIf ComboBox3.Text = "Kayn" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kayn.png") 'My.Resources.Kayn
        ElseIf ComboBox3.Text = "Kennen" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kennen.png") 'My.Resources.Kennen
        ElseIf ComboBox3.Text = "Kha'Zix" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kha'Zix.png") 'My.Resources.Kha_Zix
        ElseIf ComboBox3.Text = "Kindred" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kindred.png") 'My.Resources.Kindred
        ElseIf ComboBox3.Text = "Kled" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kled.png") 'My.Resources.Kled
        ElseIf ComboBox3.Text = "Kog'Maw" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kog'Maw.png") 'My.Resources.Kog_Maw
        ElseIf ComboBox3.Text = "LeBlanc" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\LeBlanc.png") 'My.Resources.LeBlanc
        ElseIf ComboBox3.Text = "LeeSin" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\LeeSin.png") 'My.Resources.LeeSin
        ElseIf ComboBox3.Text = "Leona" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Leona.png") 'My.Resources.Leona
        ElseIf ComboBox3.Text = "Lillia" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Lillia.png") 'My.Resources.Lillia
        ElseIf ComboBox3.Text = "Lissandra" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Lissandra.png") 'My.Resources.Lissandra
        ElseIf ComboBox3.Text = "Lucian" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Lucian.png") 'My.Resources.Lucian
        ElseIf ComboBox3.Text = "Lulu" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Lulu.png") 'My.Resources.Lulu
        ElseIf ComboBox3.Text = "Lux" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Lux.png") 'My.Resources.Lux
        ElseIf ComboBox3.Text = "Malphite" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Malphite.png") 'My.Resources.Malphite
        ElseIf ComboBox3.Text = "Malzahar" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Malzahar.png") 'My.Resources.Malzahar
        ElseIf ComboBox3.Text = "Maokai" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Maokai.png") 'My.Resources.Maokaİ
        ElseIf ComboBox3.Text = "Master Yi" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Master Yi.png") 'My.Resources.Master_Yi
        ElseIf ComboBox3.Text = "Miss Fortune" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Miss Fortune.png") 'My.Resources.Miss_Fortune
        ElseIf ComboBox3.Text = "Mordekaiser" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Mordekaiser.png") 'My.Resources.Mordekaiser
        ElseIf ComboBox3.Text = "Morgana" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Morgana.png") 'My.Resources.Morgana
        ElseIf ComboBox3.Text = "Nami" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Nami.png") 'My.Resources.Nami
        ElseIf ComboBox3.Text = "Nasus" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Nasus.png") 'My.Resources.Nasus
        ElseIf ComboBox3.Text = "Nautilus" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Nautilus.png") 'My.Resources.Nautilus
        ElseIf ComboBox3.Text = "Neeko" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Neeko.png") 'My.Resources.Neeko
        ElseIf ComboBox3.Text = "Nidalee" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Nidalee.png") 'My.Resources.Nidalee
        ElseIf ComboBox3.Text = "Nocturne" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Nocturne.png") 'My.Resources.Nocturne
        ElseIf ComboBox3.Text = "Olaf" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Olaf.png") 'My.Resources.Olaf
        ElseIf ComboBox3.Text = "Orianna" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Orianna.png") 'My.Resources.Orianna
        ElseIf ComboBox3.Text = "Ornn" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ornn.png") 'My.Resources.Ornn
        ElseIf ComboBox3.Text = "Pantheon" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Pantheon.png") 'My.Resources.Pantheon
        ElseIf ComboBox3.Text = "Poppy" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Poppy.png") 'My.Resources.Poppy
        ElseIf ComboBox3.Text = "Pyke" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Pyke.png") 'My.Resources.Pyke
        ElseIf ComboBox3.Text = "Qiyana" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Qiyana.png") 'My.Resources.Qiyana
        ElseIf ComboBox3.Text = "Quinn" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Quinn.png") 'My.Resources.Quinn
        ElseIf ComboBox3.Text = "Rakan" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Rakan.png") 'My.Resources.Rakan
        ElseIf ComboBox3.Text = "Rammus" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Rammus.png") 'My.Resources.Rammus
        ElseIf ComboBox3.Text = "Rek'Sai" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Rek'Sai.png") 'My.Resources.Rek_Sai
        ElseIf ComboBox3.Text = "Rell" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Rell.png") 'My.Resources.Rell
        ElseIf ComboBox3.Text = "Renekton" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Renekton.png") 'My.Resources.Renekton
        ElseIf ComboBox3.Text = "Rengar" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Rengar.png") 'My.Resources.Rengar
        ElseIf ComboBox3.Text = "Riven" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Riven.png") 'My.Resources.Riven
        ElseIf ComboBox3.Text = "Rumble" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Rumble.png") 'My.Resources.Rumble
        ElseIf ComboBox3.Text = "Ryze" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ryze.png") 'My.Resources.Ryze
        ElseIf ComboBox3.Text = "Samira" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Samira.png") 'My.Resources.Samira
        ElseIf ComboBox3.Text = "Sejuani" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Sejuani.png") 'My.Resources.Sejuani
        ElseIf ComboBox3.Text = "Senna" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Senna.png") 'My.Resources.Senna
        ElseIf ComboBox3.Text = "Seraphine" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Seraphine.png") 'My.Resources.Seraphine
        ElseIf ComboBox3.Text = "Sett" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Sett.png") 'My.Resources.Sett
        ElseIf ComboBox3.Text = "Shaco" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Shaco.png") 'My.Resources.Shaco
        ElseIf ComboBox3.Text = "Shen" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Shen.png") 'My.Resources.Shen
        ElseIf ComboBox3.Text = "Shyvana" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Shyvana.png") 'My.Resources.Shyvana
        ElseIf ComboBox3.Text = "Singed" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Singed.png") 'My.Resources.Singed
        ElseIf ComboBox3.Text = "Sion" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Sion.png") 'My.Resources.Sion
        ElseIf ComboBox3.Text = "Sivir" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Sivir.png") 'My.Resources.Sivir
        ElseIf ComboBox3.Text = "Skarner" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Skarner.png") 'My.Resources.Skarner
        ElseIf ComboBox3.Text = "Sona" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Sona.png") 'My.Resources.Sona
        ElseIf ComboBox3.Text = "Soraka" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Soraka.png") 'My.Resources.Soraka
        ElseIf ComboBox3.Text = "Swain" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Swain.png") 'My.Resources.Swain
        ElseIf ComboBox3.Text = "Sylas" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Sylas.png") 'My.Resources.Sylas
        ElseIf ComboBox3.Text = "Syndra" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Syndra.png") 'My.Resources.Syndra
        ElseIf ComboBox3.Text = "Tahm Kench" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Tahm Kench.png") 'My.Resources.Tahm_Kench
        ElseIf ComboBox3.Text = "Taliyah" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Taliyah.png") 'My.Resources.Taliyah
        ElseIf ComboBox3.Text = "Talon" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Talon.png") 'My.Resources.Talon
        ElseIf ComboBox3.Text = "Taric" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Taric.png") 'My.Resources.Taric
        ElseIf ComboBox3.Text = "Teemo" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Teemo.png") 'My.Resources.Teemo
        ElseIf ComboBox3.Text = "Thresh" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Thresh.png") 'My.Resources.Thresh
        ElseIf ComboBox3.Text = "Tristana" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Tristana.png") 'My.Resources.Tristana
        ElseIf ComboBox3.Text = "Trundle" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Trundle.png") 'My.Resources.Trundle
        ElseIf ComboBox3.Text = "Tryndamere" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Tryndamere.png") 'My.Resources.Tryndamere
        ElseIf ComboBox3.Text = "Twisted Fate" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Twisted Fate.png") 'My.Resources.Twisted_Fate
        ElseIf ComboBox3.Text = "Twitch" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Twitch.png") 'My.Resources.Twitch
        ElseIf ComboBox3.Text = "Udyr" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Udyr.png") 'My.Resources.Udyr
        ElseIf ComboBox3.Text = "Urgot" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Urgot.png") 'My.Resources.Urgot
        ElseIf ComboBox3.Text = "Varus" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Varus.png") 'My.Resources.Varus
        ElseIf ComboBox3.Text = "Vayne" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Vayne.png") 'My.Resources.Vayne
        ElseIf ComboBox3.Text = "Veigar" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Veigar.png") 'My.Resources.Veigar
        ElseIf ComboBox3.Text = "Vel'Koz" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Vel'Koz.png") 'My.Resources.Vel_Koz
        ElseIf ComboBox3.Text = "Vi" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Vi.png") 'My.Resources.Vi
        ElseIf ComboBox3.Text = "Viego" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Viego.png") 'My.Resources.Viego
        ElseIf ComboBox3.Text = "Viktor" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Viktor.png") 'My.Resources.Viktor
        ElseIf ComboBox3.Text = "Vladimir" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Vladimir.png") 'My.Resources.Vladimir
        ElseIf ComboBox3.Text = "Volibear" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Volibear.png") 'My.Resources.Volibear
        ElseIf ComboBox3.Text = "Warwick" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Warwick.png") 'My.Resources.Warwick
        ElseIf ComboBox3.Text = "Wukong" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Wukong.png") 'My.Resources.Wukong
        ElseIf ComboBox3.Text = "Xayah" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Xayah.png") 'My.Resources.Xayah
        ElseIf ComboBox3.Text = "Xerath" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Xerath.png") 'My.Resources.Xerath
        ElseIf ComboBox3.Text = "Xin Zhao" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Xin Zhao.png") 'My.Resources.Xin_Zhao
        ElseIf ComboBox3.Text = "Yasuo" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Yasuo.png") 'My.Resources.Yasuo
        ElseIf ComboBox3.Text = "Yone" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Yone.png") 'My.Resources.Yone
        ElseIf ComboBox3.Text = "Yorick" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Yorick.png") 'My.Resources.Yorick
        ElseIf ComboBox3.Text = "Yuumi" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Yuumi.png") 'My.Resources.Yuumi
        ElseIf ComboBox3.Text = "Zac" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Zac.png") 'My.Resources.Zac
        ElseIf ComboBox3.Text = "Zed" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Zed.png") 'My.Resources.Zed
        ElseIf ComboBox3.Text = "Ziggs" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ziggs.png") 'My.Resources.Ziggs
        ElseIf ComboBox3.Text = "Zilean" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Zilean.png") 'My.Resources.Zilean
        ElseIf ComboBox3.Text = "Zoe" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Zoe.png") 'My.Resources.Zoe
        ElseIf ComboBox3.Text = "Zyra" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Zyra.png") 'My.Resources.Zyra
        ElseIf ComboBox3.Text = "Unknown" Then
            EngTF.PictureBox3.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Unknown.png") 'My.Resources.Unknown

        End If
#End Region
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
#Region "TR"
        If ComboBox4.Text = "Aatrox" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Aatrox.png")
        ElseIf ComboBox4.Text = "Ahri" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ahri.png")
        ElseIf ComboBox4.Text = "Akali" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Akali.png")
        ElseIf ComboBox4.Text = "Alistar" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Alistar.png")
        ElseIf ComboBox4.Text = "Amumu" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Amumu.png")
        ElseIf ComboBox4.Text = "Anivia" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Anivia.png")
        ElseIf ComboBox4.Text = "Annie" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Annie.png")
        ElseIf ComboBox4.Text = "Aphelios" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Aphelios.png")
        ElseIf ComboBox4.Text = "Ashe" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ashe.png")
        ElseIf ComboBox4.Text = "Aurelion Sol" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Aurelion_Sol.png")
        ElseIf ComboBox4.Text = "Azir" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Azir.png")
        ElseIf ComboBox4.Text = "Bard" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Bard.png")
        ElseIf ComboBox4.Text = "Blitzcrank" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Blitzcrank.png")
        ElseIf ComboBox4.Text = "Brand" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Brand.png")
        ElseIf ComboBox4.Text = "Braum" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Braum.png")
        ElseIf ComboBox4.Text = "Caitlyn" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Caitlyn.png")
        ElseIf ComboBox4.Text = "Camille" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Camille.png")
        ElseIf ComboBox4.Text = "Cassiopeia" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Cassiopeia.png")
        ElseIf ComboBox4.Text = "Cho'Gath" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Cho'Gath.png")
        ElseIf ComboBox4.Text = "Corki" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Corki.png")
        ElseIf ComboBox4.Text = "Darius" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Darius.png")
        ElseIf ComboBox4.Text = "Diana" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Diana.png")
        ElseIf ComboBox4.Text = "Dr.Mundo" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Dr.Mundo.png")
        ElseIf ComboBox4.Text = "Draven" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Draven.png")
        ElseIf ComboBox4.Text = "Ekko" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ekko.png")
        ElseIf ComboBox4.Text = "Elise" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Elise.png")
        ElseIf ComboBox4.Text = "Evelynn" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Evelynn.png")
        ElseIf ComboBox4.Text = "Ezreal" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ezreal.png")
        ElseIf ComboBox4.Text = "Fiddlesticks" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Fiddlesticks.png")
        ElseIf ComboBox4.Text = "Fiora" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Fiora.png")
        ElseIf ComboBox4.Text = "Fizz" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Fizz.png")
        ElseIf ComboBox4.Text = "Galio" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Galio.png")
        ElseIf ComboBox4.Text = "Gangplank" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Gangplank.png")
        ElseIf ComboBox4.Text = "Garen" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Garen.png")
        ElseIf ComboBox4.Text = "Gnar" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Gnar.png")
        ElseIf ComboBox4.Text = "Gragas" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Gragas.png")
        ElseIf ComboBox4.Text = "Graves" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Graves.png")
        ElseIf ComboBox4.Text = "Gwen" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Gwen.png")
        ElseIf ComboBox4.Text = "Hecarim" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Hecarim.png")
        ElseIf ComboBox4.Text = "Heimerdinger" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Heimerdinger.png")
        ElseIf ComboBox4.Text = "İlloi" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Illaoi.png")
        ElseIf ComboBox4.Text = "İrelia" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Irelia.png")
        ElseIf ComboBox4.Text = "Ivern" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ivern.png")
        ElseIf ComboBox4.Text = "Janna" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Janna.png")
        ElseIf ComboBox4.Text = "Jarvan IV" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Jarvan IV.png") 'My.Resources.Jarvan_IV
        ElseIf ComboBox4.Text = "Jax" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Jax.png") 'My.Resources.Jax
        ElseIf ComboBox4.Text = "Jayce" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Jayce.png") 'My.Resources.Jayce
        ElseIf ComboBox4.Text = "Jhin" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Jhin.png") 'My.Resources.Jhin
        ElseIf ComboBox4.Text = "Jinx" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Jinx.png") 'My.Resources.Jinx
        ElseIf ComboBox4.Text = "Kai'Sa" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kai'Sa.png") 'My.Resources.Kai_Sa
        ElseIf ComboBox4.Text = "Kalista" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kalista.png") 'My.Resources.Kalista
        ElseIf ComboBox4.Text = "Karma" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Karma.png") 'My.Resources.Karma
        ElseIf ComboBox4.Text = "Karthus" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Karthus.png") 'My.Resources.Karthus
        ElseIf ComboBox4.Text = "Kassadin" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kassadin.png") 'My.Resources.Kassadin
        ElseIf ComboBox4.Text = "Katarina" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Katarina.png") 'My.Resources.Katarina
        ElseIf ComboBox4.Text = "Kayle" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kayle.png") 'My.Resources.Kayle
        ElseIf ComboBox4.Text = "Kayn" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kayn.png") 'My.Resources.Kayn
        ElseIf ComboBox4.Text = "Kennen" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kennen.png") 'My.Resources.Kennen
        ElseIf ComboBox4.Text = "Kha'Zix" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kha'Zix.png") 'My.Resources.Kha_Zix
        ElseIf ComboBox4.Text = "Kindred" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kindred.png") 'My.Resources.Kindred
        ElseIf ComboBox4.Text = "Kled" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kled.png") 'My.Resources.Kled
        ElseIf ComboBox4.Text = "Kog'Maw" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kog'Maw.png") 'My.Resources.Kog_Maw
        ElseIf ComboBox4.Text = "LeBlanc" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\LeBlanc.png") 'My.Resources.LeBlanc
        ElseIf ComboBox4.Text = "LeeSin" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\LeeSin.png") 'My.Resources.LeeSin
        ElseIf ComboBox4.Text = "Leona" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Leona.png") 'My.Resources.Leona
        ElseIf ComboBox4.Text = "Lillia" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Lillia.png") 'My.Resources.Lillia
        ElseIf ComboBox4.Text = "Lissandra" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Lissandra.png") 'My.Resources.Lissandra
        ElseIf ComboBox4.Text = "Lucian" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Lucian.png") 'My.Resources.Lucian
        ElseIf ComboBox4.Text = "Lulu" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Lulu.png") 'My.Resources.Lulu
        ElseIf ComboBox4.Text = "Lux" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Lux.png") 'My.Resources.Lux
        ElseIf ComboBox4.Text = "Malphite" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Malphite.png") 'My.Resources.Malphite
        ElseIf ComboBox4.Text = "Malzahar" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Malzahar.png") 'My.Resources.Malzahar
        ElseIf ComboBox4.Text = "Maokai" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Maokai.png") 'My.Resources.Maokaİ
        ElseIf ComboBox4.Text = "Master Yi" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Master Yi.png") 'My.Resources.Master_Yi
        ElseIf ComboBox4.Text = "Miss Fortune" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Miss Fortune.png") 'My.Resources.Miss_Fortune
        ElseIf ComboBox4.Text = "Mordekaiser" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Mordekaiser.png") 'My.Resources.Mordekaiser
        ElseIf ComboBox4.Text = "Morgana" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Morgana.png") 'My.Resources.Morgana
        ElseIf ComboBox4.Text = "Nami" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Nami.png") 'My.Resources.Nami
        ElseIf ComboBox4.Text = "Nasus" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Nasus.png") 'My.Resources.Nasus
        ElseIf ComboBox4.Text = "Nautilus" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Nautilus.png") 'My.Resources.Nautilus
        ElseIf ComboBox4.Text = "Neeko" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Neeko.png") 'My.Resources.Neeko
        ElseIf ComboBox4.Text = "Nidalee" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Nidalee.png") 'My.Resources.Nidalee
        ElseIf ComboBox4.Text = "Nocturne" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Nocturne.png") 'My.Resources.Nocturne
        ElseIf ComboBox4.Text = "Olaf" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Olaf.png") 'My.Resources.Olaf
        ElseIf ComboBox4.Text = "Orianna" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Orianna.png") 'My.Resources.Orianna
        ElseIf ComboBox4.Text = "Ornn" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ornn.png") 'My.Resources.Ornn
        ElseIf ComboBox4.Text = "Pantheon" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Pantheon.png") 'My.Resources.Pantheon
        ElseIf ComboBox4.Text = "Poppy" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Poppy.png") 'My.Resources.Poppy
        ElseIf ComboBox4.Text = "Pyke" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Pyke.png") 'My.Resources.Pyke
        ElseIf ComboBox4.Text = "Qiyana" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Qiyana.png") 'My.Resources.Qiyana
        ElseIf ComboBox4.Text = "Quinn" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Quinn.png") 'My.Resources.Quinn
        ElseIf ComboBox4.Text = "Rakan" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Rakan.png") 'My.Resources.Rakan
        ElseIf ComboBox4.Text = "Rammus" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Rammus.png") 'My.Resources.Rammus
        ElseIf ComboBox4.Text = "Rek'Sai" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Rek'Sai.png") 'My.Resources.Rek_Sai
        ElseIf ComboBox4.Text = "Rell" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Rell.png") 'My.Resources.Rell
        ElseIf ComboBox4.Text = "Renekton" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Renekton.png") 'My.Resources.Renekton
        ElseIf ComboBox4.Text = "Rengar" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Rengar.png") 'My.Resources.Rengar
        ElseIf ComboBox4.Text = "Riven" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Riven.png") 'My.Resources.Riven
        ElseIf ComboBox4.Text = "Rumble" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Rumble.png") 'My.Resources.Rumble
        ElseIf ComboBox4.Text = "Ryze" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ryze.png") 'My.Resources.Ryze
        ElseIf ComboBox4.Text = "Samira" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Samira.png") 'My.Resources.Samira
        ElseIf ComboBox4.Text = "Sejuani" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Sejuani.png") 'My.Resources.Sejuani
        ElseIf ComboBox4.Text = "Senna" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Senna.png") 'My.Resources.Senna
        ElseIf ComboBox4.Text = "Seraphine" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Seraphine.png") 'My.Resources.Seraphine
        ElseIf ComboBox4.Text = "Sett" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Sett.png") 'My.Resources.Sett
        ElseIf ComboBox4.Text = "Shaco" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Shaco.png") 'My.Resources.Shaco
        ElseIf ComboBox4.Text = "Shen" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Shen.png") 'My.Resources.Shen
        ElseIf ComboBox4.Text = "Shyvana" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Shyvana.png") 'My.Resources.Shyvana
        ElseIf ComboBox4.Text = "Singed" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Singed.png") 'My.Resources.Singed
        ElseIf ComboBox4.Text = "Sion" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Sion.png") 'My.Resources.Sion
        ElseIf ComboBox4.Text = "Sivir" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Sivir.png") 'My.Resources.Sivir
        ElseIf ComboBox4.Text = "Skarner" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Skarner.png") 'My.Resources.Skarner
        ElseIf ComboBox4.Text = "Sona" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Sona.png") 'My.Resources.Sona
        ElseIf ComboBox4.Text = "Soraka" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Soraka.png") 'My.Resources.Soraka
        ElseIf ComboBox4.Text = "Swain" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Swain.png") 'My.Resources.Swain
        ElseIf ComboBox4.Text = "Sylas" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Sylas.png") 'My.Resources.Sylas
        ElseIf ComboBox4.Text = "Syndra" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Syndra.png") 'My.Resources.Syndra
        ElseIf ComboBox4.Text = "Tahm Kench" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Tahm Kench.png") 'My.Resources.Tahm_Kench
        ElseIf ComboBox4.Text = "Taliyah" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Taliyah.png") 'My.Resources.Taliyah
        ElseIf ComboBox4.Text = "Talon" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Talon.png") 'My.Resources.Talon
        ElseIf ComboBox4.Text = "Taric" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Taric.png") 'My.Resources.Taric
        ElseIf ComboBox4.Text = "Teemo" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Teemo.png") 'My.Resources.Teemo
        ElseIf ComboBox4.Text = "Thresh" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Thresh.png") 'My.Resources.Thresh
        ElseIf ComboBox4.Text = "Tristana" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Tristana.png") 'My.Resources.Tristana
        ElseIf ComboBox4.Text = "Trundle" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Trundle.png") 'My.Resources.Trundle
        ElseIf ComboBox4.Text = "Tryndamere" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Tryndamere.png") 'My.Resources.Tryndamere
        ElseIf ComboBox4.Text = "Twisted Fate" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Twisted Fate.png") 'My.Resources.Twisted_Fate
        ElseIf ComboBox4.Text = "Twitch" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Twitch.png") 'My.Resources.Twitch
        ElseIf ComboBox4.Text = "Udyr" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Udyr.png") 'My.Resources.Udyr
        ElseIf ComboBox4.Text = "Urgot" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Urgot.png") 'My.Resources.Urgot
        ElseIf ComboBox4.Text = "Varus" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Varus.png") 'My.Resources.Varus
        ElseIf ComboBox4.Text = "Vayne" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Vayne.png") 'My.Resources.Vayne
        ElseIf ComboBox4.Text = "Veigar" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Veigar.png") 'My.Resources.Veigar
        ElseIf ComboBox4.Text = "Vel'Koz" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Vel'Koz.png") 'My.Resources.Vel_Koz
        ElseIf ComboBox4.Text = "Vi" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Vi.png") 'My.Resources.Vi
        ElseIf ComboBox4.Text = "Viego" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Viego.png") 'My.Resources.Viego
        ElseIf ComboBox4.Text = "Viktor" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Viktor.png") 'My.Resources.Viktor
        ElseIf ComboBox4.Text = "Vladimir" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Vladimir.png") 'My.Resources.Vladimir
        ElseIf ComboBox4.Text = "Volibear" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Volibear.png") 'My.Resources.Volibear
        ElseIf ComboBox4.Text = "Warwick" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Warwick.png") 'My.Resources.Warwick
        ElseIf ComboBox4.Text = "Wukong" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Wukong.png") 'My.Resources.Wukong
        ElseIf ComboBox4.Text = "Xayah" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Xayah.png") 'My.Resources.Xayah
        ElseIf ComboBox4.Text = "Xerath" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Xerath.png") 'My.Resources.Xerath
        ElseIf ComboBox4.Text = "Xin Zhao" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Xin Zhao.png") 'My.Resources.Xin_Zhao
        ElseIf ComboBox4.Text = "Yasuo" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Yasuo.png") 'My.Resources.Yasuo
        ElseIf ComboBox4.Text = "Yone" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Yone.png") 'My.Resources.Yone
        ElseIf ComboBox4.Text = "Yorick" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Yorick.png") 'My.Resources.Yorick
        ElseIf ComboBox4.Text = "Yuumi" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Yuumi.png") 'My.Resources.Yuumi
        ElseIf ComboBox4.Text = "Zac" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Zac.png") 'My.Resources.Zac
        ElseIf ComboBox4.Text = "Zed" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Zed.png") 'My.Resources.Zed
        ElseIf ComboBox4.Text = "Ziggs" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ziggs.png") 'My.Resources.Ziggs
        ElseIf ComboBox4.Text = "Zilean" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Zilean.png") 'My.Resources.Zilean
        ElseIf ComboBox4.Text = "Zoe" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Zoe.png") 'My.Resources.Zoe
        ElseIf ComboBox4.Text = "Zyra" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Zyra.png") 'My.Resources.Zyra
        ElseIf ComboBox4.Text = "Unknown" Then
            TF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Unknown.png") 'My.Resources.Unknown

        End If
#End Region
#Region "ENG"
        If ComboBox4.Text = "Aatrox" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Aatrox.png")
        ElseIf ComboBox4.Text = "Ahri" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ahri.png")
        ElseIf ComboBox4.Text = "Akali" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Akali.png")
        ElseIf ComboBox4.Text = "Alistar" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Alistar.png")
        ElseIf ComboBox4.Text = "Amumu" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Amumu.png")
        ElseIf ComboBox4.Text = "Anivia" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Anivia.png")
        ElseIf ComboBox4.Text = "Annie" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Annie.png")
        ElseIf ComboBox4.Text = "Aphelios" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Aphelios.png")
        ElseIf ComboBox4.Text = "Ashe" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ashe.png")
        ElseIf ComboBox4.Text = "Aurelion Sol" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Aurelion_Sol.png")
        ElseIf ComboBox4.Text = "Azir" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Azir.png")
        ElseIf ComboBox4.Text = "Bard" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Bard.png")
        ElseIf ComboBox4.Text = "Blitzcrank" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Blitzcrank.png")
        ElseIf ComboBox4.Text = "Brand" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Brand.png")
        ElseIf ComboBox4.Text = "Braum" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Braum.png")
        ElseIf ComboBox4.Text = "Caitlyn" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Caitlyn.png")
        ElseIf ComboBox4.Text = "Camille" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Camille.png")
        ElseIf ComboBox4.Text = "Cassiopeia" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Cassiopeia.png")
        ElseIf ComboBox4.Text = "Cho'Gath" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Cho'Gath.png")
        ElseIf ComboBox4.Text = "Corki" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Corki.png")
        ElseIf ComboBox4.Text = "Darius" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Darius.png")
        ElseIf ComboBox4.Text = "Diana" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Diana.png")
        ElseIf ComboBox4.Text = "Dr.Mundo" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Dr.Mundo.png")
        ElseIf ComboBox4.Text = "Draven" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Draven.png")
        ElseIf ComboBox4.Text = "Ekko" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ekko.png")
        ElseIf ComboBox4.Text = "Elise" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Elise.png")
        ElseIf ComboBox4.Text = "Evelynn" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Evelynn.png")
        ElseIf ComboBox4.Text = "Ezreal" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ezreal.png")
        ElseIf ComboBox4.Text = "Fiddlesticks" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Fiddlesticks.png")
        ElseIf ComboBox4.Text = "Fiora" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Fiora.png")
        ElseIf ComboBox4.Text = "Fizz" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Fizz.png")
        ElseIf ComboBox4.Text = "Galio" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Galio.png")
        ElseIf ComboBox4.Text = "Gangplank" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Gangplank.png")
        ElseIf ComboBox4.Text = "Garen" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Garen.png")
        ElseIf ComboBox4.Text = "Gnar" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Gnar.png")
        ElseIf ComboBox4.Text = "Gragas" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Gragas.png")
        ElseIf ComboBox4.Text = "Graves" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Graves.png")
        ElseIf ComboBox4.Text = "Gwen" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Gwen.png")
        ElseIf ComboBox4.Text = "Hecarim" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Hecarim.png")
        ElseIf ComboBox4.Text = "Heimerdinger" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Heimerdinger.png")
        ElseIf ComboBox4.Text = "İlloi" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Illaoi.png")
        ElseIf ComboBox4.Text = "İrelia" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Irelia.png")
        ElseIf ComboBox4.Text = "Ivern" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ivern.png")
        ElseIf ComboBox4.Text = "Janna" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Janna.png")
        ElseIf ComboBox4.Text = "Jarvan IV" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Jarvan IV.png") 'My.Resources.Jarvan_IV
        ElseIf ComboBox4.Text = "Jax" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Jax.png") 'My.Resources.Jax
        ElseIf ComboBox4.Text = "Jayce" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Jayce.png") 'My.Resources.Jayce
        ElseIf ComboBox4.Text = "Jhin" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Jhin.png") 'My.Resources.Jhin
        ElseIf ComboBox4.Text = "Jinx" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Jinx.png") 'My.Resources.Jinx
        ElseIf ComboBox4.Text = "Kai'Sa" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kai'Sa.png") 'My.Resources.Kai_Sa
        ElseIf ComboBox4.Text = "Kalista" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kalista.png") 'My.Resources.Kalista
        ElseIf ComboBox4.Text = "Karma" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Karma.png") 'My.Resources.Karma
        ElseIf ComboBox4.Text = "Karthus" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Karthus.png") 'My.Resources.Karthus
        ElseIf ComboBox4.Text = "Kassadin" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kassadin.png") 'My.Resources.Kassadin
        ElseIf ComboBox4.Text = "Katarina" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Katarina.png") 'My.Resources.Katarina
        ElseIf ComboBox4.Text = "Kayle" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kayle.png") 'My.Resources.Kayle
        ElseIf ComboBox4.Text = "Kayn" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kayn.png") 'My.Resources.Kayn
        ElseIf ComboBox4.Text = "Kennen" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kennen.png") 'My.Resources.Kennen
        ElseIf ComboBox4.Text = "Kha'Zix" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kha'Zix.png") 'My.Resources.Kha_Zix
        ElseIf ComboBox4.Text = "Kindred" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kindred.png") 'My.Resources.Kindred
        ElseIf ComboBox4.Text = "Kled" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kled.png") 'My.Resources.Kled
        ElseIf ComboBox4.Text = "Kog'Maw" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kog'Maw.png") 'My.Resources.Kog_Maw
        ElseIf ComboBox4.Text = "LeBlanc" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\LeBlanc.png") 'My.Resources.LeBlanc
        ElseIf ComboBox4.Text = "LeeSin" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\LeeSin.png") 'My.Resources.LeeSin
        ElseIf ComboBox4.Text = "Leona" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Leona.png") 'My.Resources.Leona
        ElseIf ComboBox4.Text = "Lillia" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Lillia.png") 'My.Resources.Lillia
        ElseIf ComboBox4.Text = "Lissandra" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Lissandra.png") 'My.Resources.Lissandra
        ElseIf ComboBox4.Text = "Lucian" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Lucian.png") 'My.Resources.Lucian
        ElseIf ComboBox4.Text = "Lulu" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Lulu.png") 'My.Resources.Lulu
        ElseIf ComboBox4.Text = "Lux" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Lux.png") 'My.Resources.Lux
        ElseIf ComboBox4.Text = "Malphite" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Malphite.png") 'My.Resources.Malphite
        ElseIf ComboBox4.Text = "Malzahar" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Malzahar.png") 'My.Resources.Malzahar
        ElseIf ComboBox4.Text = "Maokai" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Maokai.png") 'My.Resources.Maokaİ
        ElseIf ComboBox4.Text = "Master Yi" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Master Yi.png") 'My.Resources.Master_Yi
        ElseIf ComboBox4.Text = "Miss Fortune" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Miss Fortune.png") 'My.Resources.Miss_Fortune
        ElseIf ComboBox4.Text = "Mordekaiser" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Mordekaiser.png") 'My.Resources.Mordekaiser
        ElseIf ComboBox4.Text = "Morgana" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Morgana.png") 'My.Resources.Morgana
        ElseIf ComboBox4.Text = "Nami" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Nami.png") 'My.Resources.Nami
        ElseIf ComboBox4.Text = "Nasus" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Nasus.png") 'My.Resources.Nasus
        ElseIf ComboBox4.Text = "Nautilus" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Nautilus.png") 'My.Resources.Nautilus
        ElseIf ComboBox4.Text = "Neeko" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Neeko.png") 'My.Resources.Neeko
        ElseIf ComboBox4.Text = "Nidalee" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Nidalee.png") 'My.Resources.Nidalee
        ElseIf ComboBox4.Text = "Nocturne" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Nocturne.png") 'My.Resources.Nocturne
        ElseIf ComboBox4.Text = "Olaf" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Olaf.png") 'My.Resources.Olaf
        ElseIf ComboBox4.Text = "Orianna" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Orianna.png") 'My.Resources.Orianna
        ElseIf ComboBox4.Text = "Ornn" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ornn.png") 'My.Resources.Ornn
        ElseIf ComboBox4.Text = "Pantheon" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Pantheon.png") 'My.Resources.Pantheon
        ElseIf ComboBox4.Text = "Poppy" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Poppy.png") 'My.Resources.Poppy
        ElseIf ComboBox4.Text = "Pyke" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Pyke.png") 'My.Resources.Pyke
        ElseIf ComboBox4.Text = "Qiyana" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Qiyana.png") 'My.Resources.Qiyana
        ElseIf ComboBox4.Text = "Quinn" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Quinn.png") 'My.Resources.Quinn
        ElseIf ComboBox4.Text = "Rakan" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Rakan.png") 'My.Resources.Rakan
        ElseIf ComboBox4.Text = "Rammus" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Rammus.png") 'My.Resources.Rammus
        ElseIf ComboBox4.Text = "Rek'Sai" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Rek'Sai.png") 'My.Resources.Rek_Sai
        ElseIf ComboBox4.Text = "Rell" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Rell.png") 'My.Resources.Rell
        ElseIf ComboBox4.Text = "Renekton" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Renekton.png") 'My.Resources.Renekton
        ElseIf ComboBox4.Text = "Rengar" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Rengar.png") 'My.Resources.Rengar
        ElseIf ComboBox4.Text = "Riven" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Riven.png") 'My.Resources.Riven
        ElseIf ComboBox4.Text = "Rumble" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Rumble.png") 'My.Resources.Rumble
        ElseIf ComboBox4.Text = "Ryze" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ryze.png") 'My.Resources.Ryze
        ElseIf ComboBox4.Text = "Samira" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Samira.png") 'My.Resources.Samira
        ElseIf ComboBox4.Text = "Sejuani" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Sejuani.png") 'My.Resources.Sejuani
        ElseIf ComboBox4.Text = "Senna" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Senna.png") 'My.Resources.Senna
        ElseIf ComboBox4.Text = "Seraphine" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Seraphine.png") 'My.Resources.Seraphine
        ElseIf ComboBox4.Text = "Sett" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Sett.png") 'My.Resources.Sett
        ElseIf ComboBox4.Text = "Shaco" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Shaco.png") 'My.Resources.Shaco
        ElseIf ComboBox4.Text = "Shen" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Shen.png") 'My.Resources.Shen
        ElseIf ComboBox4.Text = "Shyvana" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Shyvana.png") 'My.Resources.Shyvana
        ElseIf ComboBox4.Text = "Singed" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Singed.png") 'My.Resources.Singed
        ElseIf ComboBox4.Text = "Sion" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Sion.png") 'My.Resources.Sion
        ElseIf ComboBox4.Text = "Sivir" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Sivir.png") 'My.Resources.Sivir
        ElseIf ComboBox4.Text = "Skarner" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Skarner.png") 'My.Resources.Skarner
        ElseIf ComboBox4.Text = "Sona" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Sona.png") 'My.Resources.Sona
        ElseIf ComboBox4.Text = "Soraka" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Soraka.png") 'My.Resources.Soraka
        ElseIf ComboBox4.Text = "Swain" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Swain.png") 'My.Resources.Swain
        ElseIf ComboBox4.Text = "Sylas" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Sylas.png") 'My.Resources.Sylas
        ElseIf ComboBox4.Text = "Syndra" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Syndra.png") 'My.Resources.Syndra
        ElseIf ComboBox4.Text = "Tahm Kench" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Tahm Kench.png") 'My.Resources.Tahm_Kench
        ElseIf ComboBox4.Text = "Taliyah" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Taliyah.png") 'My.Resources.Taliyah
        ElseIf ComboBox4.Text = "Talon" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Talon.png") 'My.Resources.Talon
        ElseIf ComboBox4.Text = "Taric" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Taric.png") 'My.Resources.Taric
        ElseIf ComboBox4.Text = "Teemo" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Teemo.png") 'My.Resources.Teemo
        ElseIf ComboBox4.Text = "Thresh" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Thresh.png") 'My.Resources.Thresh
        ElseIf ComboBox4.Text = "Tristana" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Tristana.png") 'My.Resources.Tristana
        ElseIf ComboBox4.Text = "Trundle" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Trundle.png") 'My.Resources.Trundle
        ElseIf ComboBox4.Text = "Tryndamere" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Tryndamere.png") 'My.Resources.Tryndamere
        ElseIf ComboBox4.Text = "Twisted Fate" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Twisted Fate.png") 'My.Resources.Twisted_Fate
        ElseIf ComboBox4.Text = "Twitch" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Twitch.png") 'My.Resources.Twitch
        ElseIf ComboBox4.Text = "Udyr" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Udyr.png") 'My.Resources.Udyr
        ElseIf ComboBox4.Text = "Urgot" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Urgot.png") 'My.Resources.Urgot
        ElseIf ComboBox4.Text = "Varus" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Varus.png") 'My.Resources.Varus
        ElseIf ComboBox4.Text = "Vayne" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Vayne.png") 'My.Resources.Vayne
        ElseIf ComboBox4.Text = "Veigar" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Veigar.png") 'My.Resources.Veigar
        ElseIf ComboBox4.Text = "Vel'Koz" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Vel'Koz.png") 'My.Resources.Vel_Koz
        ElseIf ComboBox4.Text = "Vi" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Vi.png") 'My.Resources.Vi
        ElseIf ComboBox4.Text = "Viego" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Viego.png") 'My.Resources.Viego
        ElseIf ComboBox4.Text = "Viktor" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Viktor.png") 'My.Resources.Viktor
        ElseIf ComboBox4.Text = "Vladimir" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Vladimir.png") 'My.Resources.Vladimir
        ElseIf ComboBox4.Text = "Volibear" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Volibear.png") 'My.Resources.Volibear
        ElseIf ComboBox4.Text = "Warwick" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Warwick.png") 'My.Resources.Warwick
        ElseIf ComboBox4.Text = "Wukong" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Wukong.png") 'My.Resources.Wukong
        ElseIf ComboBox4.Text = "Xayah" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Xayah.png") 'My.Resources.Xayah
        ElseIf ComboBox4.Text = "Xerath" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Xerath.png") 'My.Resources.Xerath
        ElseIf ComboBox4.Text = "Xin Zhao" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Xin Zhao.png") 'My.Resources.Xin_Zhao
        ElseIf ComboBox4.Text = "Yasuo" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Yasuo.png") 'My.Resources.Yasuo
        ElseIf ComboBox4.Text = "Yone" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Yone.png") 'My.Resources.Yone
        ElseIf ComboBox4.Text = "Yorick" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Yorick.png") 'My.Resources.Yorick
        ElseIf ComboBox4.Text = "Yuumi" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Yuumi.png") 'My.Resources.Yuumi
        ElseIf ComboBox4.Text = "Zac" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Zac.png") 'My.Resources.Zac
        ElseIf ComboBox4.Text = "Zed" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Zed.png") 'My.Resources.Zed
        ElseIf ComboBox4.Text = "Ziggs" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ziggs.png") 'My.Resources.Ziggs
        ElseIf ComboBox4.Text = "Zilean" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Zilean.png") 'My.Resources.Zilean
        ElseIf ComboBox4.Text = "Zoe" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Zoe.png") 'My.Resources.Zoe
        ElseIf ComboBox4.Text = "Zyra" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Zyra.png") 'My.Resources.Zyra
        ElseIf ComboBox4.Text = "Unknown" Then
            EngTF.PictureBox4.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Unknown.png") 'My.Resources.Unknown

        End If
#End Region
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
#Region "TR"
        If ComboBox5.Text = "Aatrox" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Aatrox.png")
        ElseIf ComboBox5.Text = "Ahri" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ahri.png")
        ElseIf ComboBox5.Text = "Akali" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Akali.png")
        ElseIf ComboBox5.Text = "Alistar" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Alistar.png")
        ElseIf ComboBox5.Text = "Amumu" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Amumu.png")
        ElseIf ComboBox5.Text = "Anivia" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Anivia.png")
        ElseIf ComboBox5.Text = "Annie" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Annie.png")
        ElseIf ComboBox5.Text = "Aphelios" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Aphelios.png")
        ElseIf ComboBox5.Text = "Ashe" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ashe.png")
        ElseIf ComboBox5.Text = "Aurelion Sol" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Aurelion_Sol.png")
        ElseIf ComboBox5.Text = "Azir" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Azir.png")
        ElseIf ComboBox5.Text = "Bard" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Bard.png")
        ElseIf ComboBox5.Text = "Blitzcrank" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Blitzcrank.png")
        ElseIf ComboBox5.Text = "Brand" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Brand.png")
        ElseIf ComboBox5.Text = "Braum" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Braum.png")
        ElseIf ComboBox5.Text = "Caitlyn" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Caitlyn.png")
        ElseIf ComboBox5.Text = "Camille" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Camille.png")
        ElseIf ComboBox5.Text = "Cassiopeia" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Cassiopeia.png")
        ElseIf ComboBox5.Text = "Cho'Gath" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Cho'Gath.png")
        ElseIf ComboBox5.Text = "Corki" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Corki.png")
        ElseIf ComboBox5.Text = "Darius" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Darius.png")
        ElseIf ComboBox5.Text = "Diana" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Diana.png")
        ElseIf ComboBox5.Text = "Dr.Mundo" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Dr.Mundo.png")
        ElseIf ComboBox5.Text = "Draven" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Draven.png")
        ElseIf ComboBox5.Text = "Ekko" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ekko.png")
        ElseIf ComboBox5.Text = "Elise" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Elise.png")
        ElseIf ComboBox5.Text = "Evelynn" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Evelynn.png")
        ElseIf ComboBox5.Text = "Ezreal" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ezreal.png")
        ElseIf ComboBox5.Text = "Fiddlesticks" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Fiddlesticks.png")
        ElseIf ComboBox5.Text = "Fiora" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Fiora.png")
        ElseIf ComboBox5.Text = "Fizz" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Fizz.png")
        ElseIf ComboBox5.Text = "Galio" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Galio.png")
        ElseIf ComboBox5.Text = "Gangplank" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Gangplank.png")
        ElseIf ComboBox5.Text = "Garen" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Garen.png")
        ElseIf ComboBox5.Text = "Gnar" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Gnar.png")
        ElseIf ComboBox5.Text = "Gragas" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Gragas.png")
        ElseIf ComboBox5.Text = "Graves" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Graves.png")
        ElseIf ComboBox5.Text = "Gwen" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Gwen.png")
        ElseIf ComboBox5.Text = "Hecarim" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Hecarim.png")
        ElseIf ComboBox5.Text = "Heimerdinger" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Heimerdinger.png")
        ElseIf ComboBox5.Text = "İlloi" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Illaoi.png")
        ElseIf ComboBox5.Text = "İrelia" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Irelia.png")
        ElseIf ComboBox5.Text = "Ivern" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ivern.png")
        ElseIf ComboBox5.Text = "Janna" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Janna.png")
        ElseIf ComboBox5.Text = "Jarvan IV" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Jarvan IV.png") 'My.Resources.Jarvan_IV
        ElseIf ComboBox5.Text = "Jax" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Jax.png") 'My.Resources.Jax
        ElseIf ComboBox5.Text = "Jayce" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Jayce.png") 'My.Resources.Jayce
        ElseIf ComboBox5.Text = "Jhin" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Jhin.png") 'My.Resources.Jhin
        ElseIf ComboBox5.Text = "Jinx" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Jinx.png") 'My.Resources.Jinx
        ElseIf ComboBox5.Text = "Kai'Sa" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kai'Sa.png") 'My.Resources.Kai_Sa
        ElseIf ComboBox5.Text = "Kalista" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kalista.png") 'My.Resources.Kalista
        ElseIf ComboBox5.Text = "Karma" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Karma.png") 'My.Resources.Karma
        ElseIf ComboBox5.Text = "Karthus" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Karthus.png") 'My.Resources.Karthus
        ElseIf ComboBox5.Text = "Kassadin" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kassadin.png") 'My.Resources.Kassadin
        ElseIf ComboBox5.Text = "Katarina" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Katarina.png") 'My.Resources.Katarina
        ElseIf ComboBox5.Text = "Kayle" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kayle.png") 'My.Resources.Kayle
        ElseIf ComboBox5.Text = "Kayn" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kayn.png") 'My.Resources.Kayn
        ElseIf ComboBox5.Text = "Kennen" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kennen.png") 'My.Resources.Kennen
        ElseIf ComboBox5.Text = "Kha'Zix" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kha'Zix.png") 'My.Resources.Kha_Zix
        ElseIf ComboBox5.Text = "Kindred" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kindred.png") 'My.Resources.Kindred
        ElseIf ComboBox5.Text = "Kled" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kled.png") 'My.Resources.Kled
        ElseIf ComboBox5.Text = "Kog'Maw" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Kog'Maw.png") 'My.Resources.Kog_Maw
        ElseIf ComboBox5.Text = "LeBlanc" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\LeBlanc.png") 'My.Resources.LeBlanc
        ElseIf ComboBox5.Text = "LeeSin" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\LeeSin.png") 'My.Resources.LeeSin
        ElseIf ComboBox5.Text = "Leona" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Leona.png") 'My.Resources.Leona
        ElseIf ComboBox5.Text = "Lillia" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Lillia.png") 'My.Resources.Lillia
        ElseIf ComboBox5.Text = "Lissandra" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Lissandra.png") 'My.Resources.Lissandra
        ElseIf ComboBox5.Text = "Lucian" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Lucian.png") 'My.Resources.Lucian
        ElseIf ComboBox5.Text = "Lulu" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Lulu.png") 'My.Resources.Lulu
        ElseIf ComboBox5.Text = "Lux" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Lux.png") 'My.Resources.Lux
        ElseIf ComboBox5.Text = "Malphite" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Malphite.png") 'My.Resources.Malphite
        ElseIf ComboBox5.Text = "Malzahar" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Malzahar.png") 'My.Resources.Malzahar
        ElseIf ComboBox5.Text = "Maokai" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Maokai.png") 'My.Resources.Maokaİ
        ElseIf ComboBox5.Text = "Master Yi" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Master Yi.png") 'My.Resources.Master_Yi
        ElseIf ComboBox5.Text = "Miss Fortune" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Miss Fortune.png") 'My.Resources.Miss_Fortune
        ElseIf ComboBox5.Text = "Mordekaiser" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Mordekaiser.png") 'My.Resources.Mordekaiser
        ElseIf ComboBox5.Text = "Morgana" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Morgana.png") 'My.Resources.Morgana
        ElseIf ComboBox5.Text = "Nami" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Nami.png") 'My.Resources.Nami
        ElseIf ComboBox5.Text = "Nasus" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Nasus.png") 'My.Resources.Nasus
        ElseIf ComboBox5.Text = "Nautilus" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Nautilus.png") 'My.Resources.Nautilus
        ElseIf ComboBox5.Text = "Neeko" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Neeko.png") 'My.Resources.Neeko
        ElseIf ComboBox5.Text = "Nidalee" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Nidalee.png") 'My.Resources.Nidalee
        ElseIf ComboBox5.Text = "Nocturne" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Nocturne.png") 'My.Resources.Nocturne
        ElseIf ComboBox5.Text = "Olaf" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Olaf.png") 'My.Resources.Olaf
        ElseIf ComboBox5.Text = "Orianna" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Orianna.png") 'My.Resources.Orianna
        ElseIf ComboBox5.Text = "Ornn" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ornn.png") 'My.Resources.Ornn
        ElseIf ComboBox5.Text = "Pantheon" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Pantheon.png") 'My.Resources.Pantheon
        ElseIf ComboBox5.Text = "Poppy" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Poppy.png") 'My.Resources.Poppy
        ElseIf ComboBox5.Text = "Pyke" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Pyke.png") 'My.Resources.Pyke
        ElseIf ComboBox5.Text = "Qiyana" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Qiyana.png") 'My.Resources.Qiyana
        ElseIf ComboBox5.Text = "Quinn" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Quinn.png") 'My.Resources.Quinn
        ElseIf ComboBox5.Text = "Rakan" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Rakan.png") 'My.Resources.Rakan
        ElseIf ComboBox5.Text = "Rammus" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Rammus.png") 'My.Resources.Rammus
        ElseIf ComboBox5.Text = "Rek'Sai" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Rek'Sai.png") 'My.Resources.Rek_Sai
        ElseIf ComboBox5.Text = "Rell" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Rell.png") 'My.Resources.Rell
        ElseIf ComboBox5.Text = "Renekton" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Renekton.png") 'My.Resources.Renekton
        ElseIf ComboBox5.Text = "Rengar" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Rengar.png") 'My.Resources.Rengar
        ElseIf ComboBox5.Text = "Riven" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Riven.png") 'My.Resources.Riven
        ElseIf ComboBox5.Text = "Rumble" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Rumble.png") 'My.Resources.Rumble
        ElseIf ComboBox5.Text = "Ryze" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ryze.png") 'My.Resources.Ryze
        ElseIf ComboBox5.Text = "Samira" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Samira.png") 'My.Resources.Samira
        ElseIf ComboBox5.Text = "Sejuani" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Sejuani.png") 'My.Resources.Sejuani
        ElseIf ComboBox5.Text = "Senna" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Senna.png") 'My.Resources.Senna
        ElseIf ComboBox5.Text = "Seraphine" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Seraphine.png") 'My.Resources.Seraphine
        ElseIf ComboBox5.Text = "Sett" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Sett.png") 'My.Resources.Sett
        ElseIf ComboBox5.Text = "Shaco" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Shaco.png") 'My.Resources.Shaco
        ElseIf ComboBox5.Text = "Shen" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Shen.png") 'My.Resources.Shen
        ElseIf ComboBox5.Text = "Shyvana" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Shyvana.png") 'My.Resources.Shyvana
        ElseIf ComboBox5.Text = "Singed" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Singed.png") 'My.Resources.Singed
        ElseIf ComboBox5.Text = "Sion" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Sion.png") 'My.Resources.Sion
        ElseIf ComboBox5.Text = "Sivir" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Sivir.png") 'My.Resources.Sivir
        ElseIf ComboBox5.Text = "Skarner" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Skarner.png") 'My.Resources.Skarner
        ElseIf ComboBox5.Text = "Sona" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Sona.png") 'My.Resources.Sona
        ElseIf ComboBox5.Text = "Soraka" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Soraka.png") 'My.Resources.Soraka
        ElseIf ComboBox5.Text = "Swain" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Swain.png") 'My.Resources.Swain
        ElseIf ComboBox5.Text = "Sylas" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Sylas.png") 'My.Resources.Sylas
        ElseIf ComboBox5.Text = "Syndra" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Syndra.png") 'My.Resources.Syndra
        ElseIf ComboBox5.Text = "Tahm Kench" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Tahm Kench.png") 'My.Resources.Tahm_Kench
        ElseIf ComboBox5.Text = "Taliyah" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Taliyah.png") 'My.Resources.Taliyah
        ElseIf ComboBox5.Text = "Talon" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Talon.png") 'My.Resources.Talon
        ElseIf ComboBox5.Text = "Taric" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Taric.png") 'My.Resources.Taric
        ElseIf ComboBox5.Text = "Teemo" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Teemo.png") 'My.Resources.Teemo
        ElseIf ComboBox5.Text = "Thresh" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Thresh.png") 'My.Resources.Thresh
        ElseIf ComboBox5.Text = "Tristana" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Tristana.png") 'My.Resources.Tristana
        ElseIf ComboBox5.Text = "Trundle" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Trundle.png") 'My.Resources.Trundle
        ElseIf ComboBox5.Text = "Tryndamere" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Tryndamere.png") 'My.Resources.Tryndamere
        ElseIf ComboBox5.Text = "Twisted Fate" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Twisted Fate.png") 'My.Resources.Twisted_Fate
        ElseIf ComboBox5.Text = "Twitch" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Twitch.png") 'My.Resources.Twitch
        ElseIf ComboBox5.Text = "Udyr" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Udyr.png") 'My.Resources.Udyr
        ElseIf ComboBox5.Text = "Urgot" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Urgot.png") 'My.Resources.Urgot
        ElseIf ComboBox5.Text = "Varus" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Varus.png") 'My.Resources.Varus
        ElseIf ComboBox5.Text = "Vayne" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Vayne.png") 'My.Resources.Vayne
        ElseIf ComboBox5.Text = "Veigar" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Veigar.png") 'My.Resources.Veigar
        ElseIf ComboBox5.Text = "Vel'Koz" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Vel'Koz.png") 'My.Resources.Vel_Koz
        ElseIf ComboBox5.Text = "Vi" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Vi.png") 'My.Resources.Vi
        ElseIf ComboBox5.Text = "Viego" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Viego.png") 'My.Resources.Viego
        ElseIf ComboBox5.Text = "Viktor" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Viktor.png") 'My.Resources.Viktor
        ElseIf ComboBox5.Text = "Vladimir" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Vladimir.png") 'My.Resources.Vladimir
        ElseIf ComboBox5.Text = "Volibear" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Volibear.png") 'My.Resources.Volibear
        ElseIf ComboBox5.Text = "Warwick" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Warwick.png") 'My.Resources.Warwick
        ElseIf ComboBox5.Text = "Wukong" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Wukong.png") 'My.Resources.Wukong
        ElseIf ComboBox5.Text = "Xayah" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Xayah.png") 'My.Resources.Xayah
        ElseIf ComboBox5.Text = "Xerath" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Xerath.png") 'My.Resources.Xerath
        ElseIf ComboBox5.Text = "Xin Zhao" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Xin Zhao.png") 'My.Resources.Xin_Zhao
        ElseIf ComboBox5.Text = "Yasuo" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Yasuo.png") 'My.Resources.Yasuo
        ElseIf ComboBox5.Text = "Yone" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Yone.png") 'My.Resources.Yone
        ElseIf ComboBox5.Text = "Yorick" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Yorick.png") 'My.Resources.Yorick
        ElseIf ComboBox5.Text = "Yuumi" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Yuumi.png") 'My.Resources.Yuumi
        ElseIf ComboBox5.Text = "Zac" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Zac.png") 'My.Resources.Zac
        ElseIf ComboBox5.Text = "Zed" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Zed.png") 'My.Resources.Zed
        ElseIf ComboBox5.Text = "Ziggs" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Ziggs.png") 'My.Resources.Ziggs
        ElseIf ComboBox5.Text = "Zilean" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Zilean.png") 'My.Resources.Zilean
        ElseIf ComboBox5.Text = "Zoe" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Zoe.png") 'My.Resources.Zoe
        ElseIf ComboBox5.Text = "Zyra" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Zyra.png") 'My.Resources.Zyra
        ElseIf ComboBox5.Text = "Unknown" Then
            TF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsTR\Karakter\Unknown.png") 'My.Resources.Unknown

        End If
#End Region
#Region "ENG"
        If ComboBox5.Text = "Aatrox" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Aatrox.png")
        ElseIf ComboBox5.Text = "Ahri" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ahri.png")
        ElseIf ComboBox5.Text = "Akali" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Akali.png")
        ElseIf ComboBox5.Text = "Alistar" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Alistar.png")
        ElseIf ComboBox5.Text = "Amumu" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Amumu.png")
        ElseIf ComboBox5.Text = "Anivia" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Anivia.png")
        ElseIf ComboBox5.Text = "Annie" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Annie.png")
        ElseIf ComboBox5.Text = "Aphelios" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Aphelios.png")
        ElseIf ComboBox5.Text = "Ashe" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ashe.png")
        ElseIf ComboBox5.Text = "Aurelion Sol" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Aurelion_Sol.png")
        ElseIf ComboBox5.Text = "Azir" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Azir.png")
        ElseIf ComboBox5.Text = "Bard" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Bard.png")
        ElseIf ComboBox5.Text = "Blitzcrank" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Blitzcrank.png")
        ElseIf ComboBox5.Text = "Brand" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Brand.png")
        ElseIf ComboBox5.Text = "Braum" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Braum.png")
        ElseIf ComboBox5.Text = "Caitlyn" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Caitlyn.png")
        ElseIf ComboBox5.Text = "Camille" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Camille.png")
        ElseIf ComboBox5.Text = "Cassiopeia" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Cassiopeia.png")
        ElseIf ComboBox5.Text = "Cho'Gath" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Cho'Gath.png")
        ElseIf ComboBox5.Text = "Corki" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Corki.png")
        ElseIf ComboBox5.Text = "Darius" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Darius.png")
        ElseIf ComboBox5.Text = "Diana" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Diana.png")
        ElseIf ComboBox5.Text = "Dr.Mundo" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Dr.Mundo.png")
        ElseIf ComboBox5.Text = "Draven" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Draven.png")
        ElseIf ComboBox5.Text = "Ekko" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ekko.png")
        ElseIf ComboBox5.Text = "Elise" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Elise.png")
        ElseIf ComboBox5.Text = "Evelynn" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Evelynn.png")
        ElseIf ComboBox5.Text = "Ezreal" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ezreal.png")
        ElseIf ComboBox5.Text = "Fiddlesticks" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Fiddlesticks.png")
        ElseIf ComboBox5.Text = "Fiora" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Fiora.png")
        ElseIf ComboBox5.Text = "Fizz" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Fizz.png")
        ElseIf ComboBox5.Text = "Galio" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Galio.png")
        ElseIf ComboBox5.Text = "Gangplank" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Gangplank.png")
        ElseIf ComboBox5.Text = "Garen" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Garen.png")
        ElseIf ComboBox5.Text = "Gnar" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Gnar.png")
        ElseIf ComboBox5.Text = "Gragas" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Gragas.png")
        ElseIf ComboBox5.Text = "Graves" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Graves.png")
        ElseIf ComboBox5.Text = "Gwen" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Gwen.png")
        ElseIf ComboBox5.Text = "Hecarim" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Hecarim.png")
        ElseIf ComboBox5.Text = "Heimerdinger" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Heimerdinger.png")
        ElseIf ComboBox5.Text = "İlloi" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Illaoi.png")
        ElseIf ComboBox5.Text = "İrelia" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Irelia.png")
        ElseIf ComboBox5.Text = "Ivern" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ivern.png")
        ElseIf ComboBox5.Text = "Janna" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Janna.png")
        ElseIf ComboBox5.Text = "Jarvan IV" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Jarvan IV.png") 'My.Resources.Jarvan_IV
        ElseIf ComboBox5.Text = "Jax" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Jax.png") 'My.Resources.Jax
        ElseIf ComboBox5.Text = "Jayce" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Jayce.png") 'My.Resources.Jayce
        ElseIf ComboBox5.Text = "Jhin" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Jhin.png") 'My.Resources.Jhin
        ElseIf ComboBox5.Text = "Jinx" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Jinx.png") 'My.Resources.Jinx
        ElseIf ComboBox5.Text = "Kai'Sa" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kai'Sa.png") 'My.Resources.Kai_Sa
        ElseIf ComboBox5.Text = "Kalista" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kalista.png") 'My.Resources.Kalista
        ElseIf ComboBox5.Text = "Karma" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Karma.png") 'My.Resources.Karma
        ElseIf ComboBox5.Text = "Karthus" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Karthus.png") 'My.Resources.Karthus
        ElseIf ComboBox5.Text = "Kassadin" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kassadin.png") 'My.Resources.Kassadin
        ElseIf ComboBox5.Text = "Katarina" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Katarina.png") 'My.Resources.Katarina
        ElseIf ComboBox5.Text = "Kayle" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kayle.png") 'My.Resources.Kayle
        ElseIf ComboBox5.Text = "Kayn" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kayn.png") 'My.Resources.Kayn
        ElseIf ComboBox5.Text = "Kennen" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kennen.png") 'My.Resources.Kennen
        ElseIf ComboBox5.Text = "Kha'Zix" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kha'Zix.png") 'My.Resources.Kha_Zix
        ElseIf ComboBox5.Text = "Kindred" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kindred.png") 'My.Resources.Kindred
        ElseIf ComboBox5.Text = "Kled" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kled.png") 'My.Resources.Kled
        ElseIf ComboBox5.Text = "Kog'Maw" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Kog'Maw.png") 'My.Resources.Kog_Maw
        ElseIf ComboBox5.Text = "LeBlanc" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\LeBlanc.png") 'My.Resources.LeBlanc
        ElseIf ComboBox5.Text = "LeeSin" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\LeeSin.png") 'My.Resources.LeeSin
        ElseIf ComboBox5.Text = "Leona" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Leona.png") 'My.Resources.Leona
        ElseIf ComboBox5.Text = "Lillia" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Lillia.png") 'My.Resources.Lillia
        ElseIf ComboBox5.Text = "Lissandra" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Lissandra.png") 'My.Resources.Lissandra
        ElseIf ComboBox5.Text = "Lucian" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Lucian.png") 'My.Resources.Lucian
        ElseIf ComboBox5.Text = "Lulu" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Lulu.png") 'My.Resources.Lulu
        ElseIf ComboBox5.Text = "Lux" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Lux.png") 'My.Resources.Lux
        ElseIf ComboBox5.Text = "Malphite" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Malphite.png") 'My.Resources.Malphite
        ElseIf ComboBox5.Text = "Malzahar" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Malzahar.png") 'My.Resources.Malzahar
        ElseIf ComboBox5.Text = "Maokai" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Maokai.png") 'My.Resources.Maokaİ
        ElseIf ComboBox5.Text = "Master Yi" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Master Yi.png") 'My.Resources.Master_Yi
        ElseIf ComboBox5.Text = "Miss Fortune" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Miss Fortune.png") 'My.Resources.Miss_Fortune
        ElseIf ComboBox5.Text = "Mordekaiser" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Mordekaiser.png") 'My.Resources.Mordekaiser
        ElseIf ComboBox5.Text = "Morgana" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Morgana.png") 'My.Resources.Morgana
        ElseIf ComboBox5.Text = "Nami" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Nami.png") 'My.Resources.Nami
        ElseIf ComboBox5.Text = "Nasus" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Nasus.png") 'My.Resources.Nasus
        ElseIf ComboBox5.Text = "Nautilus" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Nautilus.png") 'My.Resources.Nautilus
        ElseIf ComboBox5.Text = "Neeko" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Neeko.png") 'My.Resources.Neeko
        ElseIf ComboBox5.Text = "Nidalee" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Nidalee.png") 'My.Resources.Nidalee
        ElseIf ComboBox5.Text = "Nocturne" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Nocturne.png") 'My.Resources.Nocturne
        ElseIf ComboBox5.Text = "Olaf" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Olaf.png") 'My.Resources.Olaf
        ElseIf ComboBox5.Text = "Orianna" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Orianna.png") 'My.Resources.Orianna
        ElseIf ComboBox5.Text = "Ornn" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ornn.png") 'My.Resources.Ornn
        ElseIf ComboBox5.Text = "Pantheon" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Pantheon.png") 'My.Resources.Pantheon
        ElseIf ComboBox5.Text = "Poppy" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Poppy.png") 'My.Resources.Poppy
        ElseIf ComboBox5.Text = "Pyke" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Pyke.png") 'My.Resources.Pyke
        ElseIf ComboBox5.Text = "Qiyana" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Qiyana.png") 'My.Resources.Qiyana
        ElseIf ComboBox5.Text = "Quinn" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Quinn.png") 'My.Resources.Quinn
        ElseIf ComboBox5.Text = "Rakan" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Rakan.png") 'My.Resources.Rakan
        ElseIf ComboBox5.Text = "Rammus" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Rammus.png") 'My.Resources.Rammus
        ElseIf ComboBox5.Text = "Rek'Sai" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Rek'Sai.png") 'My.Resources.Rek_Sai
        ElseIf ComboBox5.Text = "Rell" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Rell.png") 'My.Resources.Rell
        ElseIf ComboBox5.Text = "Renekton" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Renekton.png") 'My.Resources.Renekton
        ElseIf ComboBox5.Text = "Rengar" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Rengar.png") 'My.Resources.Rengar
        ElseIf ComboBox5.Text = "Riven" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Riven.png") 'My.Resources.Riven
        ElseIf ComboBox5.Text = "Rumble" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Rumble.png") 'My.Resources.Rumble
        ElseIf ComboBox5.Text = "Ryze" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ryze.png") 'My.Resources.Ryze
        ElseIf ComboBox5.Text = "Samira" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Samira.png") 'My.Resources.Samira
        ElseIf ComboBox5.Text = "Sejuani" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Sejuani.png") 'My.Resources.Sejuani
        ElseIf ComboBox5.Text = "Senna" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Senna.png") 'My.Resources.Senna
        ElseIf ComboBox5.Text = "Seraphine" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Seraphine.png") 'My.Resources.Seraphine
        ElseIf ComboBox5.Text = "Sett" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Sett.png") 'My.Resources.Sett
        ElseIf ComboBox5.Text = "Shaco" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Shaco.png") 'My.Resources.Shaco
        ElseIf ComboBox5.Text = "Shen" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Shen.png") 'My.Resources.Shen
        ElseIf ComboBox5.Text = "Shyvana" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Shyvana.png") 'My.Resources.Shyvana
        ElseIf ComboBox5.Text = "Singed" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Singed.png") 'My.Resources.Singed
        ElseIf ComboBox5.Text = "Sion" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Sion.png") 'My.Resources.Sion
        ElseIf ComboBox5.Text = "Sivir" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Sivir.png") 'My.Resources.Sivir
        ElseIf ComboBox5.Text = "Skarner" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Skarner.png") 'My.Resources.Skarner
        ElseIf ComboBox5.Text = "Sona" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Sona.png") 'My.Resources.Sona
        ElseIf ComboBox5.Text = "Soraka" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Soraka.png") 'My.Resources.Soraka
        ElseIf ComboBox5.Text = "Swain" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Swain.png") 'My.Resources.Swain
        ElseIf ComboBox5.Text = "Sylas" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Sylas.png") 'My.Resources.Sylas
        ElseIf ComboBox5.Text = "Syndra" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Syndra.png") 'My.Resources.Syndra
        ElseIf ComboBox5.Text = "Tahm Kench" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Tahm Kench.png") 'My.Resources.Tahm_Kench
        ElseIf ComboBox5.Text = "Taliyah" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Taliyah.png") 'My.Resources.Taliyah
        ElseIf ComboBox5.Text = "Talon" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Talon.png") 'My.Resources.Talon
        ElseIf ComboBox5.Text = "Taric" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Taric.png") 'My.Resources.Taric
        ElseIf ComboBox5.Text = "Teemo" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Teemo.png") 'My.Resources.Teemo
        ElseIf ComboBox5.Text = "Thresh" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Thresh.png") 'My.Resources.Thresh
        ElseIf ComboBox5.Text = "Tristana" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Tristana.png") 'My.Resources.Tristana
        ElseIf ComboBox5.Text = "Trundle" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Trundle.png") 'My.Resources.Trundle
        ElseIf ComboBox5.Text = "Tryndamere" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Tryndamere.png") 'My.Resources.Tryndamere
        ElseIf ComboBox5.Text = "Twisted Fate" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Twisted Fate.png") 'My.Resources.Twisted_Fate
        ElseIf ComboBox5.Text = "Twitch" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Twitch.png") 'My.Resources.Twitch
        ElseIf ComboBox5.Text = "Udyr" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Udyr.png") 'My.Resources.Udyr
        ElseIf ComboBox5.Text = "Urgot" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Urgot.png") 'My.Resources.Urgot
        ElseIf ComboBox5.Text = "Varus" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Varus.png") 'My.Resources.Varus
        ElseIf ComboBox5.Text = "Vayne" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Vayne.png") 'My.Resources.Vayne
        ElseIf ComboBox5.Text = "Veigar" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Veigar.png") 'My.Resources.Veigar
        ElseIf ComboBox5.Text = "Vel'Koz" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Vel'Koz.png") 'My.Resources.Vel_Koz
        ElseIf ComboBox5.Text = "Vi" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Vi.png") 'My.Resources.Vi
        ElseIf ComboBox5.Text = "Viego" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Viego.png") 'My.Resources.Viego
        ElseIf ComboBox5.Text = "Viktor" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Viktor.png") 'My.Resources.Viktor
        ElseIf ComboBox5.Text = "Vladimir" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Vladimir.png") 'My.Resources.Vladimir
        ElseIf ComboBox5.Text = "Volibear" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Volibear.png") 'My.Resources.Volibear
        ElseIf ComboBox5.Text = "Warwick" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Warwick.png") 'My.Resources.Warwick
        ElseIf ComboBox5.Text = "Wukong" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Wukong.png") 'My.Resources.Wukong
        ElseIf ComboBox5.Text = "Xayah" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Xayah.png") 'My.Resources.Xayah
        ElseIf ComboBox5.Text = "Xerath" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Xerath.png") 'My.Resources.Xerath
        ElseIf ComboBox5.Text = "Xin Zhao" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Xin Zhao.png") 'My.Resources.Xin_Zhao
        ElseIf ComboBox5.Text = "Yasuo" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Yasuo.png") 'My.Resources.Yasuo
        ElseIf ComboBox5.Text = "Yone" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Yone.png") 'My.Resources.Yone
        ElseIf ComboBox5.Text = "Yorick" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Yorick.png") 'My.Resources.Yorick
        ElseIf ComboBox5.Text = "Yuumi" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Yuumi.png") 'My.Resources.Yuumi
        ElseIf ComboBox5.Text = "Zac" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Zac.png") 'My.Resources.Zac
        ElseIf ComboBox5.Text = "Zed" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Zed.png") 'My.Resources.Zed
        ElseIf ComboBox5.Text = "Ziggs" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Ziggs.png") 'My.Resources.Ziggs
        ElseIf ComboBox5.Text = "Zilean" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Zilean.png") 'My.Resources.Zilean
        ElseIf ComboBox5.Text = "Zoe" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Zoe.png") 'My.Resources.Zoe
        ElseIf ComboBox5.Text = "Zyra" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Zyra.png") 'My.Resources.Zyra
        ElseIf ComboBox5.Text = "Unknown" Then
            EngTF.PictureBox5.Image = Image.FromFile("Resources\LeagueOfLegendsENG\Karakter\Unknown.png") 'My.Resources.Unknown

        End If
#End Region
    End Sub
#End Region
#Region "Sihirdar Büyüleri"
    'SİHİRDAR BÜYÜ BOXLARI
    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        '================================================TR Işınlan ========================

        If ComboBox6.Text = "Işınlan" Then
            ComboBox6.Items.Remove("Tutuştur")
            ComboBox6.Items.Remove("Şifa")
            ComboBox6.Items.Remove("Arındır")
            ComboBox6.Items.Remove("Bitkinlik")
            ComboBox6.Items.Remove("Hayalet")
            ComboBox6.Items.Remove("Bariyer")
            ComboBox6.Items.Remove("Işınlan")

            ComboBox6.Items.Add("1 Lv")
            ComboBox6.Items.Add("2 Lv")
            ComboBox6.Items.Add("3 Lv")
            ComboBox6.Items.Add("4 Lv")
            ComboBox6.Items.Add("5 Lv")
            ComboBox6.Items.Add("6 Lv")
            ComboBox6.Items.Add("7 Lv")
            ComboBox6.Items.Add("8 Lv")
            ComboBox6.Items.Add("9 Lv")
            ComboBox6.Items.Add("10 Lv")
            ComboBox6.Items.Add("11 Lv")
            ComboBox6.Items.Add("12 Lv")
            ComboBox6.Items.Add("13 Lv")
            ComboBox6.Items.Add("14 Lv")
            ComboBox6.Items.Add("15 Lv")
            ComboBox6.Items.Add("16 Lv")
            ComboBox6.Items.Add("17 Lv")
            ComboBox6.Items.Add("18 Lv")
            ComboBox6.Items.Add("Geri")

        ElseIf ComboBox6.Text = "Geri" Then
            ComboBox6.Items.Add("Tutuştur")
            ComboBox6.Items.Add("Şifa")
            ComboBox6.Items.Add("Arındır")
            ComboBox6.Items.Add("Bitkinlik")
            ComboBox6.Items.Add("Hayalet")
            ComboBox6.Items.Add("Bariyer")
            ComboBox6.Items.Add("Işınlan")

            ComboBox6.Items.Remove("1 Lv")
            ComboBox6.Items.Remove("2 Lv")
            ComboBox6.Items.Remove("3 Lv")
            ComboBox6.Items.Remove("4 Lv")
            ComboBox6.Items.Remove("5 Lv")
            ComboBox6.Items.Remove("6 Lv")
            ComboBox6.Items.Remove("7 Lv")
            ComboBox6.Items.Remove("8 Lv")
            ComboBox6.Items.Remove("9 Lv")
            ComboBox6.Items.Remove("10 Lv")
            ComboBox6.Items.Remove("11 Lv")
            ComboBox6.Items.Remove("12 Lv")
            ComboBox6.Items.Remove("13 Lv")
            ComboBox6.Items.Remove("14 Lv")
            ComboBox6.Items.Remove("15 Lv")
            ComboBox6.Items.Remove("16 Lv")
            ComboBox6.Items.Remove("17 Lv")
            ComboBox6.Items.Remove("18 Lv")
            ComboBox6.Items.Remove("Geri")


        End If

        '================================================TR Işınlan Bitiş ==============================
        '================================================İngilizce  Dili Ayarı  ========================
        If ComboBox6.Text = "Teleport" Then

            ComboBox6.Items.Remove("Ghost")
            ComboBox6.Items.Remove("Ignite")
            ComboBox6.Items.Remove("Teleport")
            ComboBox6.Items.Remove("Heal")
            ComboBox6.Items.Remove("Barrier")
            ComboBox6.Items.Remove("Cleanse")

            ComboBox6.Items.Add("1 Lv")
            ComboBox6.Items.Add("2 Lv")
            ComboBox6.Items.Add("3 Lv")
            ComboBox6.Items.Add("4 Lv")
            ComboBox6.Items.Add("5 Lv")
            ComboBox6.Items.Add("6 Lv")
            ComboBox6.Items.Add("7 Lv")
            ComboBox6.Items.Add("8 Lv")
            ComboBox6.Items.Add("9 Lv")
            ComboBox6.Items.Add("10 Lv")
            ComboBox6.Items.Add("11 Lv")
            ComboBox6.Items.Add("12 Lv")
            ComboBox6.Items.Add("13 Lv")
            ComboBox6.Items.Add("14 Lv")
            ComboBox6.Items.Add("15 Lv")
            ComboBox6.Items.Add("16 Lv")
            ComboBox6.Items.Add("17 Lv")
            ComboBox6.Items.Add("18 Lv")
            ComboBox6.Items.Add("Back")

        ElseIf ComboBox6.Text = "Back" Then
            ComboBox6.Items.Add("Ghost")
            ComboBox6.Items.Add("Ignite")
            ComboBox6.Items.Add("Teleport")
            ComboBox6.Items.Add("Heal")
            ComboBox6.Items.Add("Barrier")
            ComboBox6.Items.Add("Cleanse")

            ComboBox6.Items.Remove("1 Lv")
            ComboBox6.Items.Remove("2 Lv")
            ComboBox6.Items.Remove("3 Lv")
            ComboBox6.Items.Remove("4 Lv")
            ComboBox6.Items.Remove("5 Lv")
            ComboBox6.Items.Remove("6 Lv")
            ComboBox6.Items.Remove("7 Lv")
            ComboBox6.Items.Remove("8 Lv")
            ComboBox6.Items.Remove("9 Lv")
            ComboBox6.Items.Remove("10 Lv")
            ComboBox6.Items.Remove("11 Lv")
            ComboBox6.Items.Remove("12 Lv")
            ComboBox6.Items.Remove("13 Lv")
            ComboBox6.Items.Remove("14 Lv")
            ComboBox6.Items.Remove("15 Lv")
            ComboBox6.Items.Remove("16 Lv")
            ComboBox6.Items.Remove("17 Lv")
            ComboBox6.Items.Remove("18 Lv")
            ComboBox6.Items.Remove("Back")
            '================================================İngilizce  Dili Ayarı Bitiş ========================

        End If


        '================================================TR Timer Spell  ========================================

        If ComboBox6.Text = "Tutuştur" Then
            TF.B1.Interval = 180 * 1000
        ElseIf ComboBox6.Text = "Şifa" Then
            TF.B1.Interval = 240 * 1000
        ElseIf ComboBox6.Text = "Işınlan" Then
            TF.B1.Interval = 420 * 1000
        ElseIf ComboBox6.Text = "Teleport" Then
            TF.B1.Interval = 420 * 1000

        ElseIf ComboBox6.Text = "1 Lv" Then
            TF.B1.Interval = 420 * 1000
        ElseIf ComboBox6.Text = "2 Lv" Then
            TF.B1.Interval = 408 * 1000
        ElseIf ComboBox6.Text = "3 Lv" Then
            TF.B1.Interval = 395 * 1000
        ElseIf ComboBox6.Text = "4 Lv" Then
            TF.B1.Interval = 383 * 1000
        ElseIf ComboBox6.Text = "5 Lv" Then
            TF.B1.Interval = 371 * 1000
        ElseIf ComboBox6.Text = "6 Lv" Then
            TF.B1.Interval = 358 * 1000
        ElseIf ComboBox6.Text = "7 Lv" Then
            TF.B1.Interval = 346 * 1000
        ElseIf ComboBox6.Text = "8 Lv" Then
            TF.B1.Interval = 334 * 1000
        ElseIf ComboBox6.Text = "9 Lv" Then
            TF.B1.Interval = 321 * 1000
        ElseIf ComboBox6.Text = "10 Lv" Then
            TF.B1.Interval = 309 * 1000
        ElseIf ComboBox6.Text = "11 Lv" Then
            TF.B1.Interval = 296 * 1000
        ElseIf ComboBox6.Text = "12 Lv" Then
            TF.B1.Interval = 284 * 1000
        ElseIf ComboBox6.Text = "13 Lv" Then
            TF.B1.Interval = 272 * 1000
        ElseIf ComboBox6.Text = "14 Lv" Then
            TF.B1.Interval = 259 * 1000
        ElseIf ComboBox6.Text = "15 Lv" Then
            TF.B1.Interval = 247 * 1000
        ElseIf ComboBox6.Text = "16 Lv" Then
            TF.B1.Interval = 235 * 1000
        ElseIf ComboBox6.Text = "17 Lv" Then
            TF.B1.Interval = 222 * 1000
        ElseIf ComboBox6.Text = "18 Lv" Then
            TF.B1.Interval = 210 * 1000


        ElseIf ComboBox6.Text = "Hayalet" Then
            TF.B1.Interval = 210 * 1000
        ElseIf ComboBox6.Text = "Bitkinlik" Then
            TF.B1.Interval = 180 * 1000
        ElseIf ComboBox6.Text = "Bariyer" Then
            TF.B1.Interval = 180 * 1000
        ElseIf ComboBox6.Text = "Arındır" Then
            TF.B1.Interval = 210 * 1000
        End If

        '================================================TR Timer Spell Bitiş ==============================

        'Resimleri


        If ComboBox6.Text = "Tutuştur" Then
            TF.Button1.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Tutuştur.png")
        ElseIf ComboBox6.Text = "Şifa" Then
            TF.Button1.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Şifa.png")
        ElseIf ComboBox6.Text = "Işınlan" Then
            TF.Button1.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Işınlan.png")
        ElseIf ComboBox6.Text = "Hayalet" Then
            TF.Button1.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Hayalet.png")
        ElseIf ComboBox6.Text = "Bitkinlik" Then
            TF.Button1.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Bitkinlik.png")
        ElseIf ComboBox6.Text = "Bariyer" Then
            TF.Button1.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Bariyer.png")
        ElseIf ComboBox6.Text = "Arındır" Then
            TF.Button1.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Arındır.png")
        End If
    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged




        If ComboBox7.Text = "Işınlan" Then
            ComboBox7.Items.Remove("Tutuştur")
            ComboBox7.Items.Remove("Şifa")
            ComboBox7.Items.Remove("Arındır")
            ComboBox7.Items.Remove("Bitkinlik")
            ComboBox7.Items.Remove("Hayalet")
            ComboBox7.Items.Remove("Bariyer")
            ComboBox7.Items.Remove("Işınlan")
            ComboBox7.Items.Remove("Çarp")


            ComboBox7.Items.Add("1 Lv")
            ComboBox7.Items.Add("2 Lv")
            ComboBox7.Items.Add("3 Lv")
            ComboBox7.Items.Add("4 Lv")
            ComboBox7.Items.Add("5 Lv")
            ComboBox7.Items.Add("6 Lv")
            ComboBox7.Items.Add("7 Lv")
            ComboBox7.Items.Add("8 Lv")
            ComboBox7.Items.Add("9 Lv")
            ComboBox7.Items.Add("10 Lv")
            ComboBox7.Items.Add("11 Lv")
            ComboBox7.Items.Add("12 Lv")
            ComboBox7.Items.Add("13 Lv")
            ComboBox7.Items.Add("14 Lv")
            ComboBox7.Items.Add("15 Lv")
            ComboBox7.Items.Add("16 Lv")
            ComboBox7.Items.Add("17 Lv")
            ComboBox7.Items.Add("18 Lv")
            ComboBox7.Items.Add("Geri")

        ElseIf ComboBox7.Text = "Geri" Then
            ComboBox7.Items.Add("Tutuştur")
            ComboBox7.Items.Add("Şifa")
            ComboBox7.Items.Add("Arındır")
            ComboBox7.Items.Add("Bitkinlik")
            ComboBox7.Items.Add("Hayalet")
            ComboBox7.Items.Add("Bariyer")
            ComboBox7.Items.Add("Çarp")
            ComboBox7.Items.Add("Işınlan")

            ComboBox7.Items.Remove("1 Lv")
            ComboBox7.Items.Remove("2 Lv")
            ComboBox7.Items.Remove("3 Lv")
            ComboBox7.Items.Remove("4 Lv")
            ComboBox7.Items.Remove("5 Lv")
            ComboBox7.Items.Remove("6 Lv")
            ComboBox7.Items.Remove("7 Lv")
            ComboBox7.Items.Remove("8 Lv")
            ComboBox7.Items.Remove("9 Lv")
            ComboBox7.Items.Remove("10 Lv")
            ComboBox7.Items.Remove("11 Lv")
            ComboBox7.Items.Remove("12 Lv")
            ComboBox7.Items.Remove("13 Lv")
            ComboBox7.Items.Remove("14 Lv")
            ComboBox7.Items.Remove("15 Lv")
            ComboBox7.Items.Remove("16 Lv")
            ComboBox7.Items.Remove("17 Lv")
            ComboBox7.Items.Remove("18 Lv")
            ComboBox7.Items.Remove("Geri")


        End If

        If ComboBox7.Text = "Teleport" Then

            ComboBox7.Items.Remove("Smite")
            ComboBox7.Items.Remove("Ghost")
            ComboBox7.Items.Remove("Ignite")
            ComboBox7.Items.Remove("Teleport")
            ComboBox7.Items.Remove("Heal")
            ComboBox7.Items.Remove("Barrier")
            ComboBox7.Items.Remove("Cleanse")

            ComboBox7.Items.Add("1 Lv")
            ComboBox7.Items.Add("2 Lv")
            ComboBox7.Items.Add("3 Lv")
            ComboBox7.Items.Add("4 Lv")
            ComboBox7.Items.Add("5 Lv")
            ComboBox7.Items.Add("6 Lv")
            ComboBox7.Items.Add("7 Lv")
            ComboBox7.Items.Add("8 Lv")
            ComboBox7.Items.Add("9 Lv")
            ComboBox7.Items.Add("10 Lv")
            ComboBox7.Items.Add("11 Lv")
            ComboBox7.Items.Add("12 Lv")
            ComboBox7.Items.Add("13 Lv")
            ComboBox7.Items.Add("14 Lv")
            ComboBox7.Items.Add("15 Lv")
            ComboBox7.Items.Add("16 Lv")
            ComboBox7.Items.Add("17 Lv")
            ComboBox7.Items.Add("18 Lv")
            ComboBox7.Items.Add("Back")

        ElseIf ComboBox7.Text = "Back" Then
            ComboBox7.Items.Add("Ghost")
            ComboBox7.Items.Add("Ignite")
            ComboBox7.Items.Add("Teleport")
            ComboBox7.Items.Add("Heal")
            ComboBox7.Items.Add("Barrier")
            ComboBox7.Items.Add("Cleanse")

            ComboBox7.Items.Remove("1 Lv")
            ComboBox7.Items.Remove("2 Lv")
            ComboBox7.Items.Remove("3 Lv")
            ComboBox7.Items.Remove("4 Lv")
            ComboBox7.Items.Remove("5 Lv")
            ComboBox7.Items.Remove("6 Lv")
            ComboBox7.Items.Remove("7 Lv")
            ComboBox7.Items.Remove("8 Lv")
            ComboBox7.Items.Remove("9 Lv")
            ComboBox7.Items.Remove("10 Lv")
            ComboBox7.Items.Remove("11 Lv")
            ComboBox7.Items.Remove("12 Lv")
            ComboBox7.Items.Remove("13 Lv")
            ComboBox7.Items.Remove("14 Lv")
            ComboBox7.Items.Remove("15 Lv")
            ComboBox7.Items.Remove("16 Lv")
            ComboBox7.Items.Remove("17 Lv")
            ComboBox7.Items.Remove("18 Lv")
            ComboBox7.Items.Remove("Back")
        End If
        '================================================İngilizce  Dili Ayarı Bitiş ========================



        'Timer Ayarı

        If ComboBox7.Text = "Tutuştur" Then
            TF.B2.Interval = 180 * 1000
        ElseIf ComboBox7.Text = "Şifa" Then
            TF.B2.Interval = 240 * 1000
        ElseIf ComboBox7.Text = "Işınlan" Then
            TF.B2.Interval = 420 * 1000


        ElseIf ComboBox7.Text = "1 Lv" Then
            TF.B2.Interval = 420 * 1000
        ElseIf ComboBox7.Text = "2 Lv" Then
            TF.B2.Interval = 408 * 1000
        ElseIf ComboBox7.Text = "3 Lv" Then
            TF.B2.Interval = 395 * 1000
        ElseIf ComboBox7.Text = "4 Lv" Then
            TF.B2.Interval = 383 * 1000
        ElseIf ComboBox7.Text = "5 Lv" Then
            TF.B2.Interval = 371 * 1000
        ElseIf ComboBox7.Text = "6 Lv" Then
            TF.B2.Interval = 358 * 1000
        ElseIf ComboBox7.Text = "7 Lv" Then
            TF.B2.Interval = 346 * 1000
        ElseIf ComboBox7.Text = "8 Lv" Then
            TF.B2.Interval = 334 * 1000
        ElseIf ComboBox7.Text = "9 Lv" Then
            TF.B2.Interval = 321 * 1000
        ElseIf ComboBox7.Text = "10 Lv" Then
            TF.B2.Interval = 309 * 1000
        ElseIf ComboBox7.Text = "11 Lv" Then
            TF.B2.Interval = 296 * 1000
        ElseIf ComboBox7.Text = "12 Lv" Then
            TF.B2.Interval = 284 * 1000
        ElseIf ComboBox7.Text = "13 Lv" Then
            TF.B2.Interval = 272 * 1000
        ElseIf ComboBox7.Text = "14 Lv" Then
            TF.B2.Interval = 259 * 1000
        ElseIf ComboBox7.Text = "15 Lv" Then
            TF.B2.Interval = 247 * 1000
        ElseIf ComboBox7.Text = "16 Lv" Then
            TF.B2.Interval = 235 * 1000
        ElseIf ComboBox7.Text = "17 Lv" Then
            TF.B2.Interval = 222 * 1000
        ElseIf ComboBox7.Text = "18 Lv" Then
            TF.B2.Interval = 210 * 1000

        ElseIf ComboBox7.Text = "Hayalet" Then
            TF.B2.Interval = 210 * 1000
        ElseIf ComboBox7.Text = "Bitkinlik" Then
            TF.B2.Interval = 180 * 1000
        ElseIf ComboBox7.Text = "Bariyer" Then
            TF.B2.Interval = 180 * 1000
        ElseIf ComboBox7.Text = "Arındır" Then
            TF.B2.Interval = 210 * 1000
        ElseIf ComboBox7.Text = "Çarp" Then
            TF.B2.Interval = 15 * 1000
        End If




        'Resimleri



        If ComboBox7.Text = "Tutuştur" Then
            TF.Button2.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Tutuştur.png")
        ElseIf ComboBox7.Text = "Şifa" Then
            TF.Button2.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Şifa.png")
        ElseIf ComboBox7.Text = "Işınlan" Then
            TF.Button2.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Işınlan.png")
        ElseIf ComboBox7.Text = "Çarp" Then
            TF.Button2.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Çarp.png")
        ElseIf ComboBox7.Text = "Hayalet" Then
            TF.Button2.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Hayalet.png")
        ElseIf ComboBox7.Text = "Bitkinlik" Then
            TF.Button2.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Bitkinlik.png")
        ElseIf ComboBox7.Text = "Bariyer" Then
            TF.Button2.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Bariyer.png")
        ElseIf ComboBox7.Text = "Arındır" Then
            TF.Button2.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Arındır.png")
        End If
    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox8.SelectedIndexChanged





        If ComboBox8.Text = "Işınlan" Then
            ComboBox8.Items.Remove("Tutuştur")
            ComboBox8.Items.Remove("Şifa")
            ComboBox8.Items.Remove("Arındır")
            ComboBox8.Items.Remove("Bitkinlik")
            ComboBox8.Items.Remove("Hayalet")
            ComboBox8.Items.Remove("Bariyer")
            ComboBox8.Items.Remove("Işınlan")

            ComboBox8.Items.Add("1 Lv")
            ComboBox8.Items.Add("2 Lv")
            ComboBox8.Items.Add("3 Lv")
            ComboBox8.Items.Add("4 Lv")
            ComboBox8.Items.Add("5 Lv")
            ComboBox8.Items.Add("6 Lv")
            ComboBox8.Items.Add("7 Lv")
            ComboBox8.Items.Add("8 Lv")
            ComboBox8.Items.Add("9 Lv")
            ComboBox8.Items.Add("10 Lv")
            ComboBox8.Items.Add("11 Lv")
            ComboBox8.Items.Add("12 Lv")
            ComboBox8.Items.Add("13 Lv")
            ComboBox8.Items.Add("14 Lv")
            ComboBox8.Items.Add("15 Lv")
            ComboBox8.Items.Add("16 Lv")
            ComboBox8.Items.Add("17 Lv")
            ComboBox8.Items.Add("18 Lv")
            ComboBox8.Items.Add("Geri")

        ElseIf ComboBox8.Text = "Geri" Then
            ComboBox8.Items.Add("Tutuştur")
            ComboBox8.Items.Add("Şifa")
            ComboBox8.Items.Add("Arındır")
            ComboBox8.Items.Add("Bitkinlik")
            ComboBox8.Items.Add("Hayalet")
            ComboBox8.Items.Add("Bariyer")
            ComboBox8.Items.Add("Işınlan")

            ComboBox8.Items.Remove("1 Lv")
            ComboBox8.Items.Remove("2 Lv")
            ComboBox8.Items.Remove("3 Lv")
            ComboBox8.Items.Remove("4 Lv")
            ComboBox8.Items.Remove("5 Lv")
            ComboBox8.Items.Remove("6 Lv")
            ComboBox8.Items.Remove("7 Lv")
            ComboBox8.Items.Remove("8 Lv")
            ComboBox8.Items.Remove("9 Lv")
            ComboBox8.Items.Remove("10 Lv")
            ComboBox8.Items.Remove("11 Lv")
            ComboBox8.Items.Remove("12 Lv")
            ComboBox8.Items.Remove("13 Lv")
            ComboBox8.Items.Remove("14 Lv")
            ComboBox8.Items.Remove("15 Lv")
            ComboBox8.Items.Remove("16 Lv")
            ComboBox8.Items.Remove("17 Lv")
            ComboBox8.Items.Remove("18 Lv")
            ComboBox8.Items.Remove("Geri")


        End If

        If ComboBox8.Text = "Teleport" Then

            ComboBox8.Items.Remove("Ghost")
            ComboBox8.Items.Remove("Ignite")
            ComboBox8.Items.Remove("Teleport")
            ComboBox8.Items.Remove("Heal")
            ComboBox8.Items.Remove("Barrier")
            ComboBox8.Items.Remove("Cleanse")

            ComboBox8.Items.Add("1 Lv")
            ComboBox8.Items.Add("2 Lv")
            ComboBox8.Items.Add("3 Lv")
            ComboBox8.Items.Add("4 Lv")
            ComboBox8.Items.Add("5 Lv")
            ComboBox8.Items.Add("6 Lv")
            ComboBox8.Items.Add("7 Lv")
            ComboBox8.Items.Add("8 Lv")
            ComboBox8.Items.Add("9 Lv")
            ComboBox8.Items.Add("10 Lv")
            ComboBox8.Items.Add("11 Lv")
            ComboBox8.Items.Add("12 Lv")
            ComboBox8.Items.Add("13 Lv")
            ComboBox8.Items.Add("14 Lv")
            ComboBox8.Items.Add("15 Lv")
            ComboBox8.Items.Add("16 Lv")
            ComboBox8.Items.Add("17 Lv")
            ComboBox8.Items.Add("18 Lv")
            ComboBox8.Items.Add("Back")

        ElseIf ComboBox8.Text = "Back" Then
            ComboBox8.Items.Add("Ghost")
            ComboBox8.Items.Add("Ignite")
            ComboBox8.Items.Add("Teleport")
            ComboBox8.Items.Add("Heal")
            ComboBox8.Items.Add("Barrier")
            ComboBox8.Items.Add("Cleanse")

            ComboBox8.Items.Remove("1 Lv")
            ComboBox8.Items.Remove("2 Lv")
            ComboBox8.Items.Remove("3 Lv")
            ComboBox8.Items.Remove("4 Lv")
            ComboBox8.Items.Remove("5 Lv")
            ComboBox8.Items.Remove("6 Lv")
            ComboBox8.Items.Remove("7 Lv")
            ComboBox8.Items.Remove("8 Lv")
            ComboBox8.Items.Remove("9 Lv")
            ComboBox8.Items.Remove("10 Lv")
            ComboBox8.Items.Remove("11 Lv")
            ComboBox8.Items.Remove("12 Lv")
            ComboBox8.Items.Remove("13 Lv")
            ComboBox8.Items.Remove("14 Lv")
            ComboBox8.Items.Remove("15 Lv")
            ComboBox8.Items.Remove("16 Lv")
            ComboBox8.Items.Remove("17 Lv")
            ComboBox8.Items.Remove("18 Lv")
            ComboBox8.Items.Remove("Back")
        End If
        '================================================İngilizce  Dili Ayarı Bitiş ========================

        'Timer Ayarı
        If ComboBox8.Text = "Tutuştur" Then
            TF.B3.Interval = 180 * 1000
        ElseIf ComboBox8.Text = "Şifa" Then
            TF.B3.Interval = 240 * 1000
        ElseIf ComboBox8.Text = "Işınlan" Then
            TF.B3.Interval = 420 * 1000


        ElseIf ComboBox8.Text = "1 Lv" Then
            TF.B3.Interval = 420 * 1000
        ElseIf ComboBox8.Text = "2 Lv" Then
            TF.B3.Interval = 408 * 1000
        ElseIf ComboBox8.Text = "3 Lv" Then
            TF.B3.Interval = 395 * 1000
        ElseIf ComboBox8.Text = "4 Lv" Then
            TF.B3.Interval = 383 * 1000
        ElseIf ComboBox8.Text = "5 Lv" Then
            TF.B3.Interval = 371 * 1000
        ElseIf ComboBox8.Text = "6 Lv" Then
            TF.B3.Interval = 358 * 1000
        ElseIf ComboBox8.Text = "7 Lv" Then
            TF.B3.Interval = 346 * 1000
        ElseIf ComboBox8.Text = "8 Lv" Then
            TF.B3.Interval = 334 * 1000
        ElseIf ComboBox8.Text = "9 Lv" Then
            TF.B3.Interval = 321 * 1000
        ElseIf ComboBox8.Text = "10 Lv" Then
            TF.B3.Interval = 309 * 1000
        ElseIf ComboBox8.Text = "11 Lv" Then
            TF.B3.Interval = 296 * 1000
        ElseIf ComboBox8.Text = "12 Lv" Then
            TF.B3.Interval = 284 * 1000
        ElseIf ComboBox8.Text = "13 Lv" Then
            TF.B3.Interval = 272 * 1000
        ElseIf ComboBox8.Text = "14 Lv" Then
            TF.B3.Interval = 259 * 1000
        ElseIf ComboBox8.Text = "15 Lv" Then
            TF.B3.Interval = 247 * 1000
        ElseIf ComboBox8.Text = "16 Lv" Then
            TF.B3.Interval = 235 * 1000
        ElseIf ComboBox8.Text = "17 Lv" Then
            TF.B3.Interval = 222 * 1000
        ElseIf ComboBox8.Text = "18 Lv" Then
            TF.B3.Interval = 210 * 1000

        ElseIf ComboBox8.Text = "Hayalet" Then
            TF.B3.Interval = 210 * 1000
        ElseIf ComboBox8.Text = "Bitkinlik" Then
            TF.B3.Interval = 180 * 1000
        ElseIf ComboBox8.Text = "Bariyer" Then
            TF.B3.Interval = 180 * 1000
        ElseIf ComboBox8.Text = "Arındır" Then
            TF.B3.Interval = 210 * 1000
        End If



        'Resimleri



        If ComboBox8.Text = "Tutuştur" Then
            TF.Button3.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Tutuştur.png")
        ElseIf ComboBox8.Text = "Şifa" Then
            TF.Button3.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Şifa.png")
        ElseIf ComboBox8.Text = "Işınlan" Then
            TF.Button3.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Işınlan.png")
        ElseIf ComboBox8.Text = "Hayalet" Then
            TF.Button3.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Hayalet.png")
        ElseIf ComboBox8.Text = "Bitkinlik" Then
            TF.Button3.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Bitkinlik.png")
        ElseIf ComboBox8.Text = "Bariyer" Then
            TF.Button3.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Bariyer.png")
        ElseIf ComboBox8.Text = "Arındır" Then
            TF.Button3.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Arındır.png")
        End If
    End Sub

    Private Sub ComboBox9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox9.SelectedIndexChanged

        If ComboBox9.Text = "Işınlan" Then
            ComboBox9.Items.Remove("Tutuştur")
            ComboBox9.Items.Remove("Şifa")
            ComboBox9.Items.Remove("Arındır")
            ComboBox9.Items.Remove("Bitkinlik")
            ComboBox9.Items.Remove("Hayalet")
            ComboBox9.Items.Remove("Bariyer")
            ComboBox9.Items.Remove("Işınlan")

            ComboBox9.Items.Add("1 Lv")
            ComboBox9.Items.Add("2 Lv")
            ComboBox9.Items.Add("3 Lv")
            ComboBox9.Items.Add("4 Lv")
            ComboBox9.Items.Add("5 Lv")
            ComboBox9.Items.Add("6 Lv")
            ComboBox9.Items.Add("7 Lv")
            ComboBox9.Items.Add("8 Lv")
            ComboBox9.Items.Add("9 Lv")
            ComboBox9.Items.Add("10 Lv")
            ComboBox9.Items.Add("11 Lv")
            ComboBox9.Items.Add("12 Lv")
            ComboBox9.Items.Add("13 Lv")
            ComboBox9.Items.Add("14 Lv")
            ComboBox9.Items.Add("15 Lv")
            ComboBox9.Items.Add("16 Lv")
            ComboBox9.Items.Add("17 Lv")
            ComboBox9.Items.Add("18 Lv")
            ComboBox9.Items.Add("Geri")

        ElseIf ComboBox9.Text = "Geri" Then
            ComboBox9.Items.Add("Tutuştur")
            ComboBox9.Items.Add("Şifa")
            ComboBox9.Items.Add("Arındır")
            ComboBox9.Items.Add("Bitkinlik")
            ComboBox9.Items.Add("Hayalet")
            ComboBox9.Items.Add("Bariyer")
            ComboBox9.Items.Add("Işınlan")

            ComboBox9.Items.Remove("1 Lv")
            ComboBox9.Items.Remove("2 Lv")
            ComboBox9.Items.Remove("3 Lv")
            ComboBox9.Items.Remove("4 Lv")
            ComboBox9.Items.Remove("5 Lv")
            ComboBox9.Items.Remove("6 Lv")
            ComboBox9.Items.Remove("7 Lv")
            ComboBox9.Items.Remove("8 Lv")
            ComboBox9.Items.Remove("9 Lv")
            ComboBox9.Items.Remove("10 Lv")
            ComboBox9.Items.Remove("11 Lv")
            ComboBox9.Items.Remove("12 Lv")
            ComboBox9.Items.Remove("13 Lv")
            ComboBox9.Items.Remove("14 Lv")
            ComboBox9.Items.Remove("15 Lv")
            ComboBox9.Items.Remove("16 Lv")
            ComboBox9.Items.Remove("17 Lv")
            ComboBox9.Items.Remove("18 Lv")
            ComboBox9.Items.Remove("Geri")


        End If

        If ComboBox9.Text = "Teleport" Then

            ComboBox9.Items.Remove("Ghost")
            ComboBox9.Items.Remove("Ignite")
            ComboBox9.Items.Remove("Teleport")
            ComboBox9.Items.Remove("Heal")
            ComboBox9.Items.Remove("Barrier")
            ComboBox9.Items.Remove("Cleanse")

            ComboBox9.Items.Add("1 Lv")
            ComboBox9.Items.Add("2 Lv")
            ComboBox9.Items.Add("3 Lv")
            ComboBox9.Items.Add("4 Lv")
            ComboBox9.Items.Add("5 Lv")
            ComboBox9.Items.Add("6 Lv")
            ComboBox9.Items.Add("7 Lv")
            ComboBox9.Items.Add("8 Lv")
            ComboBox9.Items.Add("9 Lv")
            ComboBox9.Items.Add("10 Lv")
            ComboBox9.Items.Add("11 Lv")
            ComboBox9.Items.Add("12 Lv")
            ComboBox9.Items.Add("13 Lv")
            ComboBox9.Items.Add("14 Lv")
            ComboBox9.Items.Add("15 Lv")
            ComboBox9.Items.Add("16 Lv")
            ComboBox9.Items.Add("17 Lv")
            ComboBox9.Items.Add("18 Lv")
            ComboBox9.Items.Add("Back")

        ElseIf ComboBox9.Text = "Back" Then
            ComboBox9.Items.Add("Ghost")
            ComboBox9.Items.Add("Ignite")
            ComboBox9.Items.Add("Teleport")
            ComboBox9.Items.Add("Heal")
            ComboBox9.Items.Add("Barrier")
            ComboBox9.Items.Add("Cleanse")

            ComboBox9.Items.Remove("1 Lv")
            ComboBox9.Items.Remove("2 Lv")
            ComboBox9.Items.Remove("3 Lv")
            ComboBox9.Items.Remove("4 Lv")
            ComboBox9.Items.Remove("5 Lv")
            ComboBox9.Items.Remove("6 Lv")
            ComboBox9.Items.Remove("7 Lv")
            ComboBox9.Items.Remove("8 Lv")
            ComboBox9.Items.Remove("9 Lv")
            ComboBox9.Items.Remove("10 Lv")
            ComboBox9.Items.Remove("11 Lv")
            ComboBox9.Items.Remove("12 Lv")
            ComboBox9.Items.Remove("13 Lv")
            ComboBox9.Items.Remove("14 Lv")
            ComboBox9.Items.Remove("15 Lv")
            ComboBox9.Items.Remove("16 Lv")
            ComboBox9.Items.Remove("17 Lv")
            ComboBox9.Items.Remove("18 Lv")
            ComboBox9.Items.Remove("Back")
        End If
        '================================================İngilizce  Dili Ayarı Bitiş ========================

        'Timer Ayarı
        If ComboBox9.Text = "Tutuştur" Then
            TF.B4.Interval = 180 * 1000
        ElseIf ComboBox9.Text = "Şifa" Then
            TF.B4.Interval = 240 * 1000
        ElseIf ComboBox9.Text = "Işınlan" Then
            TF.B4.Interval = 420 * 1000


        ElseIf ComboBox9.Text = "1 Lv" Then
            TF.B4.Interval = 420 * 1000
        ElseIf ComboBox9.Text = "2 Lv" Then
            TF.B4.Interval = 408 * 1000
        ElseIf ComboBox9.Text = "3 Lv" Then
            TF.B4.Interval = 395 * 1000
        ElseIf ComboBox9.Text = "4 Lv" Then
            TF.B4.Interval = 383 * 1000
        ElseIf ComboBox9.Text = "5 Lv" Then
            TF.B4.Interval = 371 * 1000
        ElseIf ComboBox9.Text = "6 Lv" Then
            TF.B4.Interval = 358 * 1000
        ElseIf ComboBox9.Text = "7 Lv" Then
            TF.B4.Interval = 346 * 1000
        ElseIf ComboBox9.Text = "8 Lv" Then
            TF.B4.Interval = 334 * 1000
        ElseIf ComboBox9.Text = "9 Lv" Then
            TF.B4.Interval = 321 * 1000
        ElseIf ComboBox9.Text = "10 Lv" Then
            TF.B4.Interval = 309 * 1000
        ElseIf ComboBox9.Text = "11 Lv" Then
            TF.B4.Interval = 296 * 1000
        ElseIf ComboBox9.Text = "12 Lv" Then
            TF.B4.Interval = 284 * 1000
        ElseIf ComboBox9.Text = "13 Lv" Then
            TF.B4.Interval = 272 * 1000
        ElseIf ComboBox9.Text = "14 Lv" Then
            TF.B4.Interval = 259 * 1000
        ElseIf ComboBox9.Text = "15 Lv" Then
            TF.B4.Interval = 247 * 1000
        ElseIf ComboBox9.Text = "16 Lv" Then
            TF.B4.Interval = 235 * 1000
        ElseIf ComboBox9.Text = "17 Lv" Then
            TF.B4.Interval = 222 * 1000
        ElseIf ComboBox9.Text = "18 Lv" Then
            TF.B4.Interval = 210 * 1000

        ElseIf ComboBox9.Text = "Hayalet" Then
            TF.B4.Interval = 210 * 1000
        ElseIf ComboBox9.Text = "Bitkinlik" Then
            TF.B4.Interval = 180 * 1000
        ElseIf ComboBox9.Text = "Bariyer" Then
            TF.B4.Interval = 180 * 1000
        ElseIf ComboBox9.Text = "Arındır" Then
            TF.B4.Interval = 210 * 1000
        End If




        'Resimleri


        If ComboBox9.Text = "Tutuştur" Then
            TF.Button4.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Tutuştur.png")
        ElseIf ComboBox9.Text = "Şifa" Then
            TF.Button4.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Şifa.png")
        ElseIf ComboBox9.Text = "Işınlan" Then
            TF.Button4.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Işınlan.png")
        ElseIf ComboBox9.Text = "Hayalet" Then
            TF.Button4.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Hayalet.png")
        ElseIf ComboBox9.Text = "Bitkinlik" Then
            TF.Button4.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Bitkinlik.png")
        ElseIf ComboBox9.Text = "Bariyer" Then
            TF.Button4.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Bariyer.png")
        ElseIf ComboBox9.Text = "Arındır" Then
            TF.Button4.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Arındır.png")
        End If
    End Sub

    Private Sub ComboBox10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox10.SelectedIndexChanged

        If ComboBox10.Text = "Işınlan" Then
            ComboBox10.Items.Remove("Tutuştur")
            ComboBox10.Items.Remove("Şifa")
            ComboBox10.Items.Remove("Arındır")
            ComboBox10.Items.Remove("Bitkinlik")
            ComboBox10.Items.Remove("Hayalet")
            ComboBox10.Items.Remove("Bariyer")
            ComboBox10.Items.Remove("Işınlan")


            ComboBox10.Items.Add("1 Lv")
            ComboBox10.Items.Add("2 Lv")
            ComboBox10.Items.Add("3 Lv")
            ComboBox10.Items.Add("4 Lv")
            ComboBox10.Items.Add("5 Lv")
            ComboBox10.Items.Add("6 Lv")
            ComboBox10.Items.Add("7 Lv")
            ComboBox10.Items.Add("8 Lv")
            ComboBox10.Items.Add("9 Lv")
            ComboBox10.Items.Add("10 Lv")
            ComboBox10.Items.Add("11 Lv")
            ComboBox10.Items.Add("12 Lv")
            ComboBox10.Items.Add("13 Lv")
            ComboBox10.Items.Add("14 Lv")
            ComboBox10.Items.Add("15 Lv")
            ComboBox10.Items.Add("16 Lv")
            ComboBox10.Items.Add("17 Lv")
            ComboBox10.Items.Add("18 Lv")
            ComboBox10.Items.Add("Geri")

        ElseIf ComboBox10.Text = "Geri" Then
            ComboBox10.Items.Add("Tutuştur")
            ComboBox10.Items.Add("Şifa")
            ComboBox10.Items.Add("Arındır")
            ComboBox10.Items.Add("Bitkinlik")
            ComboBox10.Items.Add("Hayalet")
            ComboBox10.Items.Add("Bariyer")
            ComboBox10.Items.Add("Işınlan")

            ComboBox10.Items.Remove("1 Lv")
            ComboBox10.Items.Remove("2 Lv")
            ComboBox10.Items.Remove("3 Lv")
            ComboBox10.Items.Remove("4 Lv")
            ComboBox10.Items.Remove("5 Lv")
            ComboBox10.Items.Remove("6 Lv")
            ComboBox10.Items.Remove("7 Lv")
            ComboBox10.Items.Remove("8 Lv")
            ComboBox10.Items.Remove("9 Lv")
            ComboBox10.Items.Remove("10 Lv")
            ComboBox10.Items.Remove("11 Lv")
            ComboBox10.Items.Remove("12 Lv")
            ComboBox10.Items.Remove("13 Lv")
            ComboBox10.Items.Remove("14 Lv")
            ComboBox10.Items.Remove("15 Lv")
            ComboBox10.Items.Remove("16 Lv")
            ComboBox10.Items.Remove("17 Lv")
            ComboBox10.Items.Remove("18 Lv")
            ComboBox10.Items.Remove("Geri")


        End If

        If ComboBox10.Text = "Teleport" Then

            ComboBox10.Items.Remove("Ghost")
            ComboBox10.Items.Remove("Ignite")
            ComboBox10.Items.Remove("Teleport")
            ComboBox10.Items.Remove("Heal")
            ComboBox10.Items.Remove("Barrier")
            ComboBox10.Items.Remove("Cleanse")

            ComboBox10.Items.Add("1 Lv")
            ComboBox10.Items.Add("2 Lv")
            ComboBox10.Items.Add("3 Lv")
            ComboBox10.Items.Add("4 Lv")
            ComboBox10.Items.Add("5 Lv")
            ComboBox10.Items.Add("6 Lv")
            ComboBox10.Items.Add("7 Lv")
            ComboBox10.Items.Add("8 Lv")
            ComboBox10.Items.Add("9 Lv")
            ComboBox10.Items.Add("10 Lv")
            ComboBox10.Items.Add("11 Lv")
            ComboBox10.Items.Add("12 Lv")
            ComboBox10.Items.Add("13 Lv")
            ComboBox10.Items.Add("14 Lv")
            ComboBox10.Items.Add("15 Lv")
            ComboBox10.Items.Add("16 Lv")
            ComboBox10.Items.Add("17 Lv")
            ComboBox10.Items.Add("18 Lv")
            ComboBox10.Items.Add("Back")

        ElseIf ComboBox10.Text = "Back" Then
            ComboBox10.Items.Add("Ghost")
            ComboBox10.Items.Add("Ignite")
            ComboBox10.Items.Add("Teleport")
            ComboBox10.Items.Add("Heal")
            ComboBox10.Items.Add("Barrier")
            ComboBox10.Items.Add("Cleanse")

            ComboBox10.Items.Remove("1 Lv")
            ComboBox10.Items.Remove("2 Lv")
            ComboBox10.Items.Remove("3 Lv")
            ComboBox10.Items.Remove("4 Lv")
            ComboBox10.Items.Remove("5 Lv")
            ComboBox10.Items.Remove("6 Lv")
            ComboBox10.Items.Remove("7 Lv")
            ComboBox10.Items.Remove("8 Lv")
            ComboBox10.Items.Remove("9 Lv")
            ComboBox10.Items.Remove("10 Lv")
            ComboBox10.Items.Remove("11 Lv")
            ComboBox10.Items.Remove("12 Lv")
            ComboBox10.Items.Remove("13 Lv")
            ComboBox10.Items.Remove("14 Lv")
            ComboBox10.Items.Remove("15 Lv")
            ComboBox10.Items.Remove("16 Lv")
            ComboBox10.Items.Remove("17 Lv")
            ComboBox10.Items.Remove("18 Lv")
            ComboBox10.Items.Remove("Back")
        End If
        '================================================İngilizce  Dili Ayarı Bitiş ========================

        'Timer Ayarı
        If ComboBox10.Text = "Tutuştur" Then
            TF.B5.Interval = 180 * 1000
        ElseIf ComboBox10.Text = "Şifa" Then
            TF.B5.Interval = 240 * 1000
        ElseIf ComboBox10.Text = "Işınlan" Then
            TF.B5.Interval = 420 * 1000


        ElseIf ComboBox10.Text = "1 Lv" Then
            TF.B5.Interval = 420 * 1000
        ElseIf ComboBox10.Text = "2 Lv" Then
            TF.B5.Interval = 408 * 1000
        ElseIf ComboBox10.Text = "3 Lv" Then
            TF.B5.Interval = 395 * 1000
        ElseIf ComboBox10.Text = "4 Lv" Then
            TF.B5.Interval = 383 * 1000
        ElseIf ComboBox10.Text = "5 Lv" Then
            TF.B5.Interval = 371 * 1000
        ElseIf ComboBox10.Text = "6 Lv" Then
            TF.B5.Interval = 358 * 1000
        ElseIf ComboBox10.Text = "7 Lv" Then
            TF.B5.Interval = 346 * 1000
        ElseIf ComboBox10.Text = "8 Lv" Then
            TF.B5.Interval = 334 * 1000
        ElseIf ComboBox10.Text = "9 Lv" Then
            TF.B5.Interval = 321 * 1000
        ElseIf ComboBox10.Text = "10 Lv" Then
            TF.B5.Interval = 309 * 1000
        ElseIf ComboBox10.Text = "11 Lv" Then
            TF.B5.Interval = 296 * 1000
        ElseIf ComboBox10.Text = "12 Lv" Then
            TF.B5.Interval = 284 * 1000
        ElseIf ComboBox10.Text = "13 Lv" Then
            TF.B5.Interval = 272 * 1000
        ElseIf ComboBox10.Text = "14 Lv" Then
            TF.B5.Interval = 259 * 1000
        ElseIf ComboBox10.Text = "15 Lv" Then
            TF.B5.Interval = 247 * 1000
        ElseIf ComboBox10.Text = "16 Lv" Then
            TF.B5.Interval = 235 * 1000
        ElseIf ComboBox10.Text = "17 Lv" Then
            TF.B5.Interval = 222 * 1000
        ElseIf ComboBox10.Text = "18 Lv" Then
            TF.B5.Interval = 210 * 1000

        ElseIf ComboBox10.Text = "Hayalet" Then
            TF.B5.Interval = 210 * 1000
        ElseIf ComboBox10.Text = "Bitkinlik" Then
            TF.B5.Interval = 180 * 1000
        ElseIf ComboBox10.Text = "Bariyer" Then
            TF.B5.Interval = 180 * 1000
        ElseIf ComboBox10.Text = "Arındır" Then
            TF.B5.Interval = 210 * 1000
        End If



        'Resimleri


        If ComboBox10.Text = "Tutuştur" Then
            TF.Button5.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Tutuştur.png")
        ElseIf ComboBox10.Text = "Şifa" Then
            TF.Button5.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Şifa.png")
        ElseIf ComboBox10.Text = "Işınlan" Then
            TF.Button5.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Işınlan.png")
        ElseIf ComboBox10.Text = "Hayalet" Then
            TF.Button5.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Hayalet.png")
        ElseIf ComboBox10.Text = "Bitkinlik" Then
            TF.Button5.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Bitkinlik.png")
        ElseIf ComboBox10.Text = "Bariyer" Then
            TF.Button5.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Bariyer.png")
        ElseIf ComboBox10.Text = "Arındır" Then
            TF.Button5.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsTR\Spell\Arındır.png")
        End If
    End Sub
#End Region
#Region "Discord RPC Kapa"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Shell("TASKKILL /F /IM DiscordRichP.exe")
        On Error Resume Next
        File.Delete("C:\LoLRememberV2\Resources\LeagueOfLegendsTR\DiscordRichP.exe")
        File.Delete("C:\LoLRememberV2\DiscordRichP.exe")
        On Error Resume Next
        Foto.Close()

        Help.Close()
        TF.Close()
        Me.Close()
        Renk.Close()
        Zamanlama.Close()
    End Sub
#End Region
#Region "Tema Renkleri"
    'Tema Rengi

    Private Sub ComboBox11_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox11.SelectedIndexChanged

        If ComboBox11.Text = "Normal" Then
            Panel1.BackColor = Color.FromArgb(72, 52, 212)
            Panel2.BackColor = Color.FromArgb(104, 109, 224)
            Label13.ForeColor = Color.Lime
            Label14.ForeColor = Color.Lime

        ElseIf ComboBox11.Text = "Mavi" Then
            Panel1.BackColor = Color.FromArgb(25, 42, 86)
            Panel2.BackColor = Color.FromArgb(39, 60, 117)
            Label13.ForeColor = Color.Lime
            Label14.ForeColor = Color.Lime


        ElseIf ComboBox11.Text = "Special" Then
            Panel1.BackColor = Color.FromArgb(255, 0, 0)
            Panel2.BackColor = Color.FromArgb(0, 255, 232)
            Label13.ForeColor = Color.DarkRed
            Label14.ForeColor = Color.DarkRed

        ElseIf ComboBox11.Text = "Açık Mavi" Then
            Panel1.BackColor = Color.FromArgb(23, 192, 235)
            Panel2.BackColor = Color.FromArgb(126, 255, 245)
            Label13.ForeColor = Color.Red
            Label14.ForeColor = Color.Red



        ElseIf ComboBox11.Text = "Kırmızı" Then
            Panel1.BackColor = Color.FromArgb(194, 54, 22)
            Panel2.BackColor = Color.FromArgb(232, 65, 24)
            Label13.ForeColor = Color.Lime
            Label14.ForeColor = Color.Lime


        ElseIf ComboBox11.Text = "Yeşil" Then
            Panel1.BackColor = Color.FromArgb(39, 174, 96)
            Panel2.BackColor = Color.FromArgb(46, 204, 113)
            Label13.ForeColor = Color.Red
            Label14.ForeColor = Color.Red


        ElseIf ComboBox11.Text = "Gri" Then
            Panel1.BackColor = Color.FromArgb(132, 129, 122)
            Panel2.BackColor = Color.FromArgb(209, 204, 192)
            Label13.ForeColor = Color.Lime
            Label14.ForeColor = Color.Lime

        End If

    End Sub
#End Region
#Region "DiscordRPC"
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label14.Text = "Discord RPC : OFF"
        Shell("TASKKILL /F /IM DiscordRPC.exe")
        Shell("TASKKILL /F /IM  DesktopDiscordRPC.exe")
        Button5.Visible = False
        Button4.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim yol As String = Application.StartupPath & "\Resources\DiscordRPC.exe"
        IO.File.WriteAllBytes(yol, My.Resources.DiscordRPC)
        If IO.File.Exists(yol) Then Process.Start(yol)
        Label14.Text = "Discord RPC : ON"
        Button4.Visible = False
        Button5.Visible = True
    End Sub
#End Region
#Region "Laneler"
    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            CheckBox7.Enabled = False
            CheckBox6.Enabled = False
            CheckBox8.Enabled = False

        ElseIf CheckBox5.Checked = False Then
            CheckBox7.Enabled = True
            CheckBox6.Enabled = True
            CheckBox8.Enabled = True
        End If

    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            CheckBox5.Enabled = False
            CheckBox7.Enabled = False
            CheckBox8.Enabled = False


        ElseIf CheckBox6.Checked = False Then
            CheckBox5.Enabled = True
            CheckBox7.Enabled = True
            CheckBox8.Enabled = True

        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox8.Enabled = False

        ElseIf CheckBox7.Checked = False Then
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
            CheckBox8.Enabled = True

        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = True Then
            CheckBox5.Enabled = False
            CheckBox7.Enabled = False
            CheckBox6.Enabled = False
        ElseIf CheckBox8.Checked = False Then
            CheckBox5.Enabled = True
            CheckBox7.Enabled = True
            CheckBox6.Enabled = True
        End If
    End Sub
#End Region

#Region "TR Resources"
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim VerLRV As String = New System.Net.WebClient().DownloadString("https://jung1330.tk/Versions/LoLRememberV2/Resources.txt")
        My.Computer.Network.DownloadFile(VerLRV, "C:\LoLRememberV2\Resources.7z")
        Module1.UnRar("C:\LoLRememberV2\", "C:\LoLRememberV2\Resources.7z")
        Sil.Start()
    End Sub
#End Region
#Region "ENG Resources"
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim VerLRV2 As String = New System.Net.WebClient().DownloadString("https://jung1330.tk/Versions/LoLRememberV2/ENGResources.txt")
        My.Computer.Network.DownloadFile(VerLRV2, "C:\LoLRememberV2\ENGResources.7z")
        Module1.UnRar("C:\LoLRememberV2\", "C:\LoLRememberV2\ENGResources.7z")
        Sil2.Start()
    End Sub
#End Region

#Region "Dil Seçenekleri"
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then

            Button6.Visible = False
            Button7.Text = "Terminate"
            Button12.Visible = True
            AyarlarToolStripMenuItem.Text = "Options"
            ÇıkışToolStripMenuItem.Text = "Exit"
            YardımToolStripMenuItem.Text = "Help"

            BilgiToolStripMenuItem.Text = "Information"
            Me.Text = "[English Version]"
            CheckBox2.Text = "TR"

            'Combobox6
            ComboBox6.Items.Add("Ghost")
            ComboBox6.Items.Add("Ignite")
            ComboBox6.Items.Add("Teleport")
            ComboBox6.Items.Add("Heal")
            ComboBox6.Items.Add("Barrier")
            ComboBox6.Items.Add("Cleanse")
            ComboBox6.Items.Add("Exhaustion")

            ComboBox6.Items.Remove("Tutuştur")
            ComboBox6.Items.Remove("Şifa")
            ComboBox6.Items.Remove("Arındır")
            ComboBox6.Items.Remove("Bitkinlik")
            ComboBox6.Items.Remove("Hayalet")
            ComboBox6.Items.Remove("Bariyer")
            ComboBox6.Items.Remove("Işınlan")

            'Combobox7
            ComboBox7.Items.Add("Ghost")
            ComboBox7.Items.Add("Ignite")
            ComboBox7.Items.Add("Teleport")
            ComboBox7.Items.Add("Heal")
            ComboBox7.Items.Add("Barrier")
            ComboBox7.Items.Add("Cleanse")
            ComboBox7.Items.Add("Smite")
            ComboBox7.Items.Add("Exhaustion")

            ComboBox7.Items.Remove("Tutuştur")
            ComboBox7.Items.Remove("Şifa")
            ComboBox7.Items.Remove("Arındır")
            ComboBox7.Items.Remove("Bitkinlik")
            ComboBox7.Items.Remove("Hayalet")
            ComboBox7.Items.Remove("Bariyer")
            ComboBox7.Items.Remove("Işınlan")
            ComboBox7.Items.Remove("Çarp")

            'Combobox8

            ComboBox8.Items.Add("Ghost")
            ComboBox8.Items.Add("Ignite")
            ComboBox8.Items.Add("Teleport")
            ComboBox8.Items.Add("Heal")
            ComboBox8.Items.Add("Barrier")
            ComboBox8.Items.Add("Cleanse")
            ComboBox8.Items.Add("Exhaustion")

            ComboBox8.Items.Remove("Tutuştur")
            ComboBox8.Items.Remove("Şifa")
            ComboBox8.Items.Remove("Arındır")
            ComboBox8.Items.Remove("Bitkinlik")
            ComboBox8.Items.Remove("Hayalet")
            ComboBox8.Items.Remove("Bariyer")
            ComboBox8.Items.Remove("Işınlan")

            'Combobox9

            ComboBox9.Items.Add("Ghost")
            ComboBox9.Items.Add("Ignite")
            ComboBox9.Items.Add("Teleport")
            ComboBox9.Items.Add("Heal")
            ComboBox9.Items.Add("Barrier")
            ComboBox9.Items.Add("Cleanse")
            ComboBox9.Items.Add("Exhaustion")

            ComboBox9.Items.Remove("Tutuştur")
            ComboBox9.Items.Remove("Şifa")
            ComboBox9.Items.Remove("Arındır")
            ComboBox9.Items.Remove("Bitkinlik")
            ComboBox9.Items.Remove("Hayalet")
            ComboBox9.Items.Remove("Bariyer")
            ComboBox9.Items.Remove("Işınlan")

            'Combobox10

            ComboBox10.Items.Add("Ghost")
            ComboBox10.Items.Add("Ignite")
            ComboBox10.Items.Add("Teleport")
            ComboBox10.Items.Add("Heal")
            ComboBox10.Items.Add("Barrier")
            ComboBox10.Items.Add("Cleanse")
            ComboBox10.Items.Add("Exhaustion")

            ComboBox10.Items.Remove("Tutuştur")
            ComboBox10.Items.Remove("Şifa")
            ComboBox10.Items.Remove("Arındır")
            ComboBox10.Items.Remove("Bitkinlik")
            ComboBox10.Items.Remove("Hayalet")
            ComboBox10.Items.Remove("Bariyer")
            ComboBox10.Items.Remove("Işınlan")

        ElseIf CheckBox2.Checked = False Then
            Button6.Text = "Oyunİçi"
            Button7.Text = "Sonlandır"
            AyarlarToolStripMenuItem.Text = "Ayarlar"
            ÇıkışToolStripMenuItem.Text = "Çıkış"
            YardımToolStripMenuItem.Text = "Yardım"
            Button6.Visible = True
            Button12.Visible = False
            Me.Text = "[Türkçe Versionu]"
            CheckBox2.Text = "Eng"

            'Combobox6
            ComboBox6.Items.Remove("Ghost")
            ComboBox6.Items.Remove("Ignite")
            ComboBox6.Items.Remove("Teleport")
            ComboBox6.Items.Remove("Heal")
            ComboBox6.Items.Remove("Barrier")
            ComboBox6.Items.Remove("Cleanse")
            ComboBox6.Items.Remove("Exhaustion")

            ComboBox6.Items.Add("Tutuştur")
            ComboBox6.Items.Add("Şifa")
            ComboBox6.Items.Add("Arındır")
            ComboBox6.Items.Add("Bitkinlik")
            ComboBox6.Items.Add("Hayalet")
            ComboBox6.Items.Add("Bariyer")
            ComboBox6.Items.Add("Işınlan")

            'Combobox7
            ComboBox7.Items.Remove("Ghost")
            ComboBox7.Items.Remove("Ignite")
            ComboBox7.Items.Remove("Teleport")
            ComboBox7.Items.Remove("Heal")
            ComboBox7.Items.Remove("Barrier")
            ComboBox7.Items.Remove("Cleanse")
            ComboBox7.Items.Remove("Smite")
            ComboBox7.Items.Remove("Exhaustion")

            ComboBox7.Items.Add("Tutuştur")
            ComboBox7.Items.Add("Şifa")
            ComboBox7.Items.Add("Arındır")
            ComboBox7.Items.Add("Bitkinlik")
            ComboBox7.Items.Add("Hayalet")
            ComboBox7.Items.Add("Bariyer")
            ComboBox7.Items.Add("Işınlan")
            ComboBox7.Items.Add("Çarp")

            'Combobox8
            ComboBox8.Items.Remove("Ghost")
            ComboBox8.Items.Remove("Ignite")
            ComboBox8.Items.Remove("Teleport")
            ComboBox8.Items.Remove("Heal")
            ComboBox8.Items.Remove("Barrier")
            ComboBox8.Items.Remove("Cleanse")
            ComboBox8.Items.Remove("Exhaustion")

            ComboBox8.Items.Add("Tutuştur")
            ComboBox8.Items.Add("Şifa")
            ComboBox8.Items.Add("Arındır")
            ComboBox8.Items.Add("Bitkinlik")
            ComboBox8.Items.Add("Hayalet")
            ComboBox8.Items.Add("Bariyer")
            ComboBox8.Items.Add("Işınlan")

            'ComboBox9
            ComboBox9.Items.Remove("Ghost")
            ComboBox9.Items.Remove("Ignite")
            ComboBox9.Items.Remove("Teleport")
            ComboBox9.Items.Remove("Heal")
            ComboBox9.Items.Remove("Barrier")
            ComboBox9.Items.Remove("Cleanse")
            ComboBox9.Items.Remove("Exhaustion")

            ComboBox9.Items.Add("Tutuştur")
            ComboBox9.Items.Add("Şifa")
            ComboBox9.Items.Add("Arındır")
            ComboBox9.Items.Add("Bitkinlik")
            ComboBox9.Items.Add("Hayalet")
            ComboBox9.Items.Add("Bariyer")
            ComboBox9.Items.Add("Işınlan")

            'Combobox10
            ComboBox10.Items.Remove("Ghost")
            ComboBox10.Items.Remove("Ignite")
            ComboBox10.Items.Remove("Teleport")
            ComboBox10.Items.Remove("Heal")
            ComboBox10.Items.Remove("Barrier")
            ComboBox10.Items.Remove("Cleanse")
            ComboBox10.Items.Remove("Exhaustion")

            ComboBox10.Items.Add("Tutuştur")
            ComboBox10.Items.Add("Şifa")
            ComboBox10.Items.Add("Arındır")
            ComboBox10.Items.Add("Bitkinlik")
            ComboBox10.Items.Add("Hayalet")
            ComboBox10.Items.Add("Bariyer")
            ComboBox10.Items.Add("Işınlan")
        End If
    End Sub
#End Region
#Region "Dil Sürümleri"
    Private Sub TemaName_Tick(sender As Object, e As EventArgs) Handles TemaName.Tick
        If CheckBox2.Checked = True Then
            Label13.Text = "[English Version]"
            İki.Start()
            TemaName.Stop()
        ElseIf CheckBox2.Checked = False Then
            Label13.Text = "[Türkçe Versionu]"
            İki.Start()
            TemaName.Stop()

        End If
    End Sub

    Private Sub İki_Tick(sender As Object, e As EventArgs) Handles İki.Tick
        If CheckBox2.Checked = True Then
            Label13.Text = "Github/Jung1330"
            TemaName.Start()
            İki.Stop()
        ElseIf CheckBox2.Checked = False Then
            Label13.Text = "Github/Jung1330"
            TemaName.Start()
            İki.Stop()

        End If
    End Sub
#End Region

#Region "TopMost"
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Me.TopMost = True
        ElseIf CheckBox1.Checked = False Then
            Me.TopMost = False
        End If
    End Sub
#End Region
#Region "ENG İnGame"
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        EngTF.Button6.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsENG\Spell\Sıçra.png")
        EngTF.Button7.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsENG\Spell\Sıçra.png")
        EngTF.Button8.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsENG\Spell\Sıçra.png")
        EngTF.Button9.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsENG\Spell\Sıçra.png")
        EngTF.Button10.BackgroundImage = Image.FromFile("Resources\LeagueOfLegendsENG\Spell\Sıçra.png")
        EngTF.Show()
    End Sub



#End Region

#Region "Sil Buton"
    Private Sub Sil_Tick(sender As Object, e As EventArgs) Handles Sil.Tick
        File.Delete("C:\LoLRememberV2\Resources.7z")
        Sil.Stop()
    End Sub
#End Region
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Shell("TASKKILL /F /IM DiscordRPC.exe")
        Shell("TASKKILL /F /IM  DesktopDiscordRPC.exe")

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Help.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Renk.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Ayarlar.Show()
    End Sub

    Private Sub Sil2_Tick(sender As Object, e As EventArgs) Handles Sil2.Tick
        File.Delete("C:\LoLRememberV2\ENGResources.7z")
        Sil2.Stop()
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then

            EngTF.FormBorderStyle = FormBorderStyle.None
            TF.FormBorderStyle = FormBorderStyle.None

        ElseIf CheckBox4.Checked = False Then

            EngTF.FormBorderStyle = FormBorderStyle.FixedToolWindow
            TF.FormBorderStyle = FormBorderStyle.FixedToolWindow


        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then

            Zamanlama.Show()

        ElseIf CheckBox3.Checked = False Then

            Zamanlama.Hide()

        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked = True Then

            Zamanlama.FormBorderStyle = FormBorderStyle.None


        ElseIf CheckBox9.Checked = False Then

            Zamanlama.FormBorderStyle = FormBorderStyle.FixedToolWindow

        End If

    End Sub
End Class