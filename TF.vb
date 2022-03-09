Imports System.Media


Public Class TF

#Region "Dim ile Ses verdirtmeler"

    Dim SoloSıçra As New SoundPlayer()
    Dim SoloArındır As New SoundPlayer()
    Dim SoloBariyer As New SoundPlayer()
    Dim SoloBitkinlik As New SoundPlayer()
    Dim SoloHayalet As New SoundPlayer()
    Dim SoloIşınlan As New SoundPlayer()
    Dim SoloŞifa As New SoundPlayer()
    Dim SoloTutuştur As New SoundPlayer()
    Dim MidSıçra As New SoundPlayer()
    Dim MidArındır As New SoundPlayer()
    Dim MidBariyer As New SoundPlayer()
    Dim MidBitkinlik As New SoundPlayer()
    Dim MidHayalet As New SoundPlayer()
    Dim MidIşınlan As New SoundPlayer()
    Dim MidŞifa As New SoundPlayer()
    Dim MidTutuştur As New SoundPlayer()
    Dim JungSıçra As New SoundPlayer()
    Dim JungArındır As New SoundPlayer()
    Dim JungBariyer As New SoundPlayer()
    Dim JungBitkinlik As New SoundPlayer()
    Dim JungHayalet As New SoundPlayer()
    Dim JungIşınlan As New SoundPlayer()
    Dim JungŞifa As New SoundPlayer()
    Dim JungTutuştur As New SoundPlayer()
    Dim JungÇarp As New SoundPlayer()
    Dim SupSıçra As New SoundPlayer()
    Dim SupArındır As New SoundPlayer()
    Dim SupBariyer As New SoundPlayer()
    Dim SupBitkinlik As New SoundPlayer()
    Dim SupHayalet As New SoundPlayer()
    Dim SupIşınlan As New SoundPlayer()
    Dim SupŞifa As New SoundPlayer()
    Dim SupTutuştur As New SoundPlayer()
    Dim AdcSıçra As New SoundPlayer()
    Dim AdcArındır As New SoundPlayer()
    Dim AdcBariyer As New SoundPlayer()
    Dim AdcBitkinlik As New SoundPlayer()
    Dim AdcHayalet As New SoundPlayer()
    Dim AdcIşınlan As New SoundPlayer()
    Dim AdcŞifa As New SoundPlayer()
    Dim AdcTutuştur As New SoundPlayer()

    '2.POSTA
    Dim SoloSıçra2 As New SoundPlayer()
    Dim SoloArındır2 As New SoundPlayer()
    Dim SoloBariyer2 As New SoundPlayer()
    Dim SoloBitkinlik2 As New SoundPlayer()
    Dim SoloHayalet2 As New SoundPlayer()
    Dim SoloIşınlan2 As New SoundPlayer()
    Dim SoloŞifa2 As New SoundPlayer()
    Dim SoloTutuştur2 As New SoundPlayer()
    Dim MidSıçra2 As New SoundPlayer()
    Dim MidArındır2 As New SoundPlayer()
    Dim MidBariyer2 As New SoundPlayer()
    Dim MidBitkinlik2 As New SoundPlayer()
    Dim MidHayalet2 As New SoundPlayer()
    Dim MidIşınlan2 As New SoundPlayer()
    Dim MidŞifa2 As New SoundPlayer()
    Dim MidTutuştur2 As New SoundPlayer()
    Dim JungSıçra2 As New SoundPlayer()
    Dim JungArındır2 As New SoundPlayer()
    Dim JungBariyer2 As New SoundPlayer()
    Dim JungBitkinlik2 As New SoundPlayer()
    Dim JungHayalet2 As New SoundPlayer()
    Dim JungIşınlan2 As New SoundPlayer()
    Dim JungŞifa2 As New SoundPlayer()
    Dim JungTutuştur2 As New SoundPlayer()
    Dim JungÇarp2 As New SoundPlayer()
    Dim SupSıçra2 As New SoundPlayer()
    Dim SupArındır2 As New SoundPlayer()
    Dim SupBariyer2 As New SoundPlayer()
    Dim SupBitkinlik2 As New SoundPlayer()
    Dim SupHayalet2 As New SoundPlayer()
    Dim SupIşınlan2 As New SoundPlayer()
    Dim SupŞifa2 As New SoundPlayer()
    Dim SupTutuştur2 As New SoundPlayer()
    Dim AdcSıçra2 As New SoundPlayer()
    Dim AdcArındır2 As New SoundPlayer()
    Dim AdcBariyer2 As New SoundPlayer()
    Dim AdcBitkinlik2 As New SoundPlayer()
    Dim AdcHayalet2 As New SoundPlayer()
    Dim AdcIşınlan2 As New SoundPlayer()
    Dim AdcŞifa2 As New SoundPlayer()
    Dim AdcTutuştur2 As New SoundPlayer()
#End Region


    Private Sub TF_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.TopMost = True

        Me.TransparencyKey = Color.LightBlue
        Me.BackColor = Color.LightBlue



        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button4.BackgroundImageLayout = ImageLayout.Stretch
        Button5.BackgroundImageLayout = ImageLayout.Stretch

        Button6.BackgroundImageLayout = ImageLayout.Stretch
        Button7.BackgroundImageLayout = ImageLayout.Stretch
        Button8.BackgroundImageLayout = ImageLayout.Stretch
        Button9.BackgroundImageLayout = ImageLayout.Stretch
        Button10.BackgroundImageLayout = ImageLayout.Stretch



#Region "Ses Dosyaları"
        'Ses Dosyaları

        Me.SoloArındır = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SoloArındır.wav")
        Me.SoloBariyer = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SoloBariyer.wav")
        Me.SoloBitkinlik = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SoloBitkinlik.wav")
        Me.SoloHayalet = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SoloHayalet.wav")
        Me.SoloIşınlan = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SoloIşınlan.wav")
        Me.SoloSıçra = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SoloSıçra.wav")
        Me.SoloŞifa = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SoloŞifa.wav")
        Me.SoloTutuştur = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SoloTutuştur.wav")
        Me.MidArındır = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\MidArındır.wav")
        Me.MidBariyer = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\MidBariyer.wav")
        Me.MidBitkinlik = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\MidBitkinlik.wav")
        Me.MidHayalet = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\MidHayalet.wav")
        Me.MidIşınlan = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\MidIşınlan.wav")
        Me.MidSıçra = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\MidSıçra.wav")
        Me.MidŞifa = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\MidŞifa.wav")
        Me.MidTutuştur = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\MidTutuştur.wav")
        Me.JungArındır = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\JungleArındır.wav")
        Me.JungBariyer = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\JungleBariyer.wav")
        Me.JungBitkinlik = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\JungleBitkinlik.wav")
        Me.JungHayalet = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\JungleHayalet.wav")
        Me.JungIşınlan = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\JungleIşınlan.wav")
        Me.JungSıçra = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\JungleSıçra.wav")
        Me.JungŞifa = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\JungleŞifa.wav")
        Me.JungTutuştur = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\JungleTutuştur.wav")
        Me.JungÇarp = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\JungleÇarp.wav")
        Me.SupArındır = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SupArındır.wav")
        Me.SupBariyer = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SupBariyer.wav")
        Me.SupBitkinlik = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SupBitkinlik.wav")
        Me.SupHayalet = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SupHayalet.wav")
        Me.SupIşınlan = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SupIşınlan.wav")
        Me.SupSıçra = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SupSıçra.wav")
        Me.SupŞifa = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SupŞifa.wav")
        Me.SupTutuştur = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SupTutuştur.wav")
        Me.AdcArındır = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\AdcArındır.wav")
        Me.AdcBariyer = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\AdcBariyer.wav")
        Me.AdcBitkinlik = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\AdcBariyer.wav")
        Me.AdcHayalet = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\AdcHayalet.wav")
        Me.AdcIşınlan = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\AdcIşınlan.wav")
        Me.AdcSıçra = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\AdcSıçra.wav")
        Me.AdcŞifa = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\AdcŞifa.wav")
        Me.AdcTutuştur = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\AdcTutuştur.wav")

        '2.Tur

        Me.SoloArındır2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SoloArındır2.wav")
        Me.SoloBariyer2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SoloBariyer2.wav")
        Me.SoloBitkinlik2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SoloBitkinlik2.wav")
        Me.SoloHayalet2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SoloHayalet2.wav")
        Me.SoloIşınlan2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SoloIşınlan2.wav")
        Me.SoloSıçra2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SoloSıçra2.wav")
        Me.SoloŞifa2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SoloŞifa2.wav")
        Me.SoloTutuştur2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SoloTutuştur2.wav")
        Me.MidArındır2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\MidArındır2.wav")
        Me.MidBariyer2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\MidBariyer2.wav")
        Me.MidBitkinlik2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\MidBitkinlik2.wav")
        Me.MidHayalet2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\MidHayalet2.wav")
        Me.MidIşınlan2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\MidIşınlan2.wav")
        Me.MidSıçra2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\MidSıçra2.wav")
        Me.MidŞifa2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\MidŞifa2.wav")
        Me.MidTutuştur2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\MidTutuştur2.wav")
        Me.JungArındır2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\JungleArındır2.wav")
        Me.JungBariyer2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\JungleBariyer2.wav")
        Me.JungBitkinlik2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\JungleBitkinlik2.wav")
        Me.JungHayalet2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\JungleHayalet2.wav")
        Me.JungIşınlan2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\JungleIşınlan2.wav")
        Me.JungSıçra2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\JungleSıçra2.wav")
        Me.JungŞifa2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\JungleŞifa2.wav")
        Me.JungTutuştur2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\JungleTutuştur2.wav")
        Me.JungÇarp2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\JungleÇarp2.wav")
        Me.SupArındır2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SupArındır2.wav")
        Me.SupBariyer2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SupBariyer2.wav")
        Me.SupBitkinlik2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SupBitkinlik2.wav")
        Me.SupHayalet2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SupHayalet2.wav")
        Me.SupIşınlan2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SupIşınlan2.wav")
        Me.SupSıçra2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SupSıçra2.wav")
        Me.SupŞifa2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SupŞifa2.wav")
        Me.SupTutuştur2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\SupTutuştur2.wav")
        Me.AdcArındır2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\AdcArındır2.wav")
        Me.AdcBariyer2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\AdcBariyer2.wav")
        Me.AdcBitkinlik2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\AdcBariyer2.wav")
        Me.AdcHayalet2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\AdcHayalet2.wav")
        Me.AdcIşınlan2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\AdcIşınlan2.wav")
        Me.AdcSıçra2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\AdcSıçra2.wav")
        Me.AdcŞifa2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\AdcŞifa2.wav")
        Me.AdcTutuştur2 = New SoundPlayer("Resources\LeagueOfLegendsTR\Voice\AdcTutuştur2.wav")
#End Region
    End Sub




    '                   SESLER

#Region "TR SES SOLO"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Tema.ComboBox6.Text = "Tutuştur" Then
            Me.SoloTutuştur.Play()
            B1.Start()
            Button1.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox6.Text = "Işınlan" Then
            Me.SoloIşınlan.Play()
            B1.Start()
            Button1.BackColor = Color.FromArgb(0, 255, 0)


        ElseIf Tema.ComboBox6.Text = "1 Lv" Then
            Me.SoloIşınlan.Play()
            B1.Start()
            Button1.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox6.Text = "2 Lv" Then
            Me.SoloIşınlan.Play()
            B1.Start()
            Button1.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox6.Text = "3 Lv" Then
            Me.SoloIşınlan.Play()
            B1.Start()
            Button1.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox6.Text = "4 Lv" Then
            Me.SoloIşınlan.Play()
            B1.Start()
            Button1.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox6.Text = "5 Lv" Then
            Me.SoloIşınlan.Play()
            B1.Start()
            Button1.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox6.Text = "6 Lv" Then
            Me.SoloIşınlan.Play()
            B1.Start()
            Button1.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox6.Text = "7 Lv" Then
            Me.SoloIşınlan.Play()
            B1.Start()
            Button1.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox6.Text = "8 Lv" Then
            Me.SoloIşınlan.Play()
            B1.Start()
            Button1.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox6.Text = "9 Lv" Then
            Me.SoloIşınlan.Play()
            B1.Start()
            Button1.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox6.Text = "10 Lv" Then
            Me.SoloIşınlan.Play()
            B1.Start()
            Button1.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox6.Text = "11 Lv" Then
            Me.SoloIşınlan.Play()
            B1.Start()
            Button1.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox6.Text = "12 Lv" Then
            Me.SoloIşınlan.Play()
            B1.Start()
            Button1.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox6.Text = "13 Lv" Then
            Me.SoloIşınlan.Play()
            B1.Start()
            Button1.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox6.Text = "14 Lv" Then
            Me.SoloIşınlan.Play()
            B1.Start()
            Button1.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox6.Text = "15 Lv" Then
            Me.SoloIşınlan.Play()
            B1.Start()
            Button1.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox6.Text = "16 Lv" Then
            Me.SoloIşınlan.Play()
            B1.Start()
            Button1.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox6.Text = "17 Lv" Then
            Me.SoloIşınlan.Play()
            B1.Start()
            Button1.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox6.Text = "18 Lv" Then
            Me.SoloIşınlan.Play()
            B1.Start()
            Button1.BackColor = Color.FromArgb(0, 255, 0)







        ElseIf Tema.ComboBox6.Text = "Şifa" Then
            Me.SoloŞifa.Play()
            B1.Start()
            Button1.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox6.Text = "Arındır" Then
            Me.SoloArındır.Play()
            B1.Start()
            Button1.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox6.Text = "Bariyer" Then
            Me.SoloBariyer.Play()
            B1.Start()
            Button1.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox6.Text = "Hayalet" Then
            Me.SoloHayalet.Play()
            B1.Start()
            Button1.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox6.Text = "Bitkinlik" Then
            Me.SoloBitkinlik.Play()
            B1.Start()
            Button1.BackColor = Color.FromArgb(0, 255, 0)
        End If
#End Region
    End Sub
#Region "TR SES JUNG"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Tema.ComboBox7.Text = "Tutuştur" Then
            Me.JungTutuştur.Play()
            B2.Start()
            Button2.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox7.Text = "Işınlan" Then
            Me.JungIşınlan.Play()
            B2.Start()
            Button2.BackColor = Color.FromArgb(0, 255, 0)

        ElseIf Tema.ComboBox7.Text = "1 Lv" Then
            Me.JungIşınlan.Play()
            B2.Start()
            Button2.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox7.Text = "2 Lv" Then
            Me.JungIşınlan.Play()
            B2.Start()
            Button2.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox7.Text = "3 Lv" Then
            Me.JungIşınlan.Play()
            B2.Start()
            Button2.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox7.Text = "4 Lv" Then
            Me.JungIşınlan.Play()
            B2.Start()
            Button2.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox7.Text = "5 Lv" Then
            Me.JungIşınlan.Play()
            B2.Start()
            Button2.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox7.Text = "6 Lv" Then
            Me.JungIşınlan.Play()
            B2.Start()
            Button2.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox7.Text = "7 Lv" Then
            Me.JungIşınlan.Play()
            B2.Start()
            Button2.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox7.Text = "8 Lv" Then
            Me.JungIşınlan.Play()
            B2.Start()
            Button2.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox7.Text = "9 Lv" Then
            Me.JungIşınlan.Play()
            B2.Start()
            Button2.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox7.Text = "10 Lv" Then
            Me.JungIşınlan.Play()
            B2.Start()
            Button2.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox7.Text = "11 Lv" Then
            Me.JungIşınlan.Play()
            B2.Start()
            Button2.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox7.Text = "12 Lv" Then
            Me.JungIşınlan.Play()
            B2.Start()
            Button2.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox7.Text = "13 Lv" Then
            Me.JungIşınlan.Play()
            B2.Start()
            Button2.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox7.Text = "14 Lv" Then
            Me.JungIşınlan.Play()
            B2.Start()
            Button2.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox7.Text = "15 Lv" Then
            Me.JungIşınlan.Play()
            B2.Start()
            Button2.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox7.Text = "16 Lv" Then
            Me.JungIşınlan.Play()
            B2.Start()
            Button2.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox7.Text = "17 Lv" Then
            Me.JungIşınlan.Play()
            B2.Start()
            Button2.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox7.Text = "18 Lv" Then
            Me.JungIşınlan.Play()
            B2.Start()
            Button2.BackColor = Color.FromArgb(0, 255, 0)






        ElseIf Tema.ComboBox7.Text = "Şifa" Then
            Me.JungŞifa.Play()
            B2.Start()
            Button2.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox7.Text = "Arındır" Then
            Me.JungArındır.Play()
            B2.Start()
            Button2.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox7.Text = "Bariyer" Then
            Me.JungBariyer.Play()
            B2.Start()
            Button2.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox7.Text = "Hayalet" Then
            Me.JungHayalet.Play()
            B2.Start()
            Button2.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox7.Text = "Çarp" Then
            Me.JungÇarp.Play()
            B2.Start()
            Button2.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox7.Text = "Bitkinlik" Then
            Me.JungBitkinlik.Play()
            B2.Start()
            Button2.BackColor = Color.FromArgb(0, 255, 0)
        End If
#End Region
    End Sub
#Region "TR SES MİD"
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Tema.ComboBox8.Text = "Tutuştur" Then
            Me.MidTutuştur.Play()
            B3.Start()
            Button3.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox8.Text = "Işınlan" Then
            Me.MidIşınlan.Play()
            B3.Start()
            Button3.BackColor = Color.FromArgb(0, 255, 0)




        ElseIf Tema.ComboBox8.Text = "1 Lv" Then
            Me.MidIşınlan.Play()
            B3.Start()
            Button3.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox8.Text = "2 Lv" Then
            Me.MidIşınlan.Play()
            B3.Start()
            Button3.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox8.Text = "3 Lv" Then
            Me.MidIşınlan.Play()
            B3.Start()
            Button3.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox8.Text = "4 Lv" Then
            Me.MidIşınlan.Play()
            B3.Start()
            Button3.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox8.Text = "5 Lv" Then
            Me.MidIşınlan.Play()
            B3.Start()
            Button3.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox8.Text = "6 Lv" Then
            Me.MidIşınlan.Play()
            B3.Start()
            Button3.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox8.Text = "7 Lv" Then
            Me.MidIşınlan.Play()
            B3.Start()
            Button3.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox8.Text = "8 Lv" Then
            Me.MidIşınlan.Play()
            B3.Start()
            Button3.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox8.Text = "9 Lv" Then
            Me.MidIşınlan.Play()
            B3.Start()
            Button3.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox8.Text = "10 Lv" Then
            Me.MidIşınlan.Play()
            B3.Start()
            Button3.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox8.Text = "11 Lv" Then
            Me.MidIşınlan.Play()
            B3.Start()
            Button3.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox8.Text = "12 Lv" Then
            Me.MidIşınlan.Play()
            B3.Start()
            Button3.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox8.Text = "13 Lv" Then
            Me.MidIşınlan.Play()
            B3.Start()
            Button3.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox8.Text = "14 Lv" Then
            Me.MidIşınlan.Play()
            B3.Start()
            Button3.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox8.Text = "15 Lv" Then
            Me.MidIşınlan.Play()
            B3.Start()
            Button3.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox8.Text = "16 Lv" Then
            Me.MidIşınlan.Play()
            B3.Start()
            Button3.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox8.Text = "17 Lv" Then
            Me.MidIşınlan.Play()
            B3.Start()
            Button3.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox8.Text = "18 Lv" Then
            Me.MidIşınlan.Play()
            B3.Start()
            Button3.BackColor = Color.FromArgb(0, 255, 0)








        ElseIf Tema.ComboBox8.Text = "Şifa" Then
            Me.MidŞifa.Play()
            B3.Start()
            Button3.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox8.Text = "Arındır" Then
            Me.MidArındır.Play()
            B3.Start()
            Button3.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox8.Text = "Bariyer" Then
            Me.MidBariyer.Play()
            B3.Start()
            Button3.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox8.Text = "Hayalet" Then
            Me.MidHayalet.Play()
            B3.Start()
            Button3.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox8.Text = "Bitkinlik" Then
            Me.MidBitkinlik.Play()
            B3.Start()
            Button3.BackColor = Color.FromArgb(0, 255, 0)
        End If
#End Region
    End Sub
#Region "TR SES SUP"
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Tema.ComboBox9.Text = "Tutuştur" Then
            Me.SupTutuştur.Play()
            B4.Start()
            Button4.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox9.Text = "Işınlan" Then
            Me.SupIşınlan.Play()
            B4.Start()
            Button4.BackColor = Color.FromArgb(0, 255, 0)





        ElseIf Tema.ComboBox9.Text = "1 Lv" Then
            Me.SupIşınlan.Play()
            B4.Start()
            Button4.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox9.Text = "2 Lv" Then
            Me.SupIşınlan.Play()
            B4.Start()
            Button4.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox9.Text = "3 Lv" Then
            Me.SupIşınlan.Play()
            B4.Start()
            Button4.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox9.Text = "4 Lv" Then
            Me.SupIşınlan.Play()
            B4.Start()
            Button4.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox9.Text = "5 Lv" Then
            Me.SupIşınlan.Play()
            B4.Start()
            Button4.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox9.Text = "6 Lv" Then
            Me.SupIşınlan.Play()
            B4.Start()
            Button4.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox9.Text = "7 Lv" Then
            Me.SupIşınlan.Play()
            B4.Start()
            Button4.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox9.Text = "8 Lv" Then
            Me.SupIşınlan.Play()
            B4.Start()
            Button4.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox9.Text = "9 Lv" Then
            Me.SupIşınlan.Play()
            B4.Start()
            Button4.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox9.Text = "10 Lv" Then
            Me.SupIşınlan.Play()
            B4.Start()
            Button4.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox9.Text = "11 Lv" Then
            Me.SupIşınlan.Play()
            B4.Start()
            Button4.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox9.Text = "12 Lv" Then
            Me.SupIşınlan.Play()
            B4.Start()
            Button4.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox9.Text = "13 Lv" Then
            Me.SupIşınlan.Play()
            B4.Start()
            Button4.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox9.Text = "14 Lv" Then
            Me.SupIşınlan.Play()
            B4.Start()
            Button4.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox9.Text = "15 Lv" Then
            Me.SupIşınlan.Play()
            B4.Start()
            Button4.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox9.Text = "16 Lv" Then
            Me.SupIşınlan.Play()
            B4.Start()
            Button4.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox9.Text = "17 Lv" Then
            Me.SupIşınlan.Play()
            B4.Start()
            Button4.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox9.Text = "18 Lv" Then
            Me.SupIşınlan.Play()
            B4.Start()
            Button4.BackColor = Color.FromArgb(0, 255, 0)









        ElseIf Tema.ComboBox9.Text = "Şifa" Then
            Me.SupŞifa.Play()
            B4.Start()
            Button4.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox9.Text = "Arındır" Then
            Me.SupArındır.Play()
            B4.Start()
            Button4.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox9.Text = "Bariyer" Then
            Me.SupBariyer.Play()
            B4.Start()
            Button4.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox9.Text = "Hayalet" Then
            Me.SupHayalet.Play()
            B4.Start()
            Button4.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox9.Text = "Bitkinlik" Then
            Me.SupBitkinlik.Play()
            B4.Start()
            Button4.BackColor = Color.FromArgb(0, 255, 0)
        End If
#End Region
    End Sub
#Region "TR SES ADC"
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Tema.ComboBox10.Text = "Tutuştur" Then
            Me.AdcTutuştur.Play()
            B5.Start()
            Button5.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox10.Text = "Işınlan" Then
            Me.AdcIşınlan.Play()
            B5.Start()
            Button5.BackColor = Color.FromArgb(0, 255, 0)



        ElseIf Tema.ComboBox10.Text = "1 Lv" Then
            Me.AdcIşınlan.Play()
            B5.Start()
            Button5.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox10.Text = "2 Lv" Then
            Me.AdcIşınlan.Play()
            B5.Start()
            Button5.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox10.Text = "3 Lv" Then
            Me.AdcIşınlan.Play()
            B5.Start()
            Button5.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox10.Text = "4 Lv" Then
            Me.AdcIşınlan.Play()
            B5.Start()
            Button5.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox10.Text = "5 Lv" Then
            Me.AdcIşınlan.Play()
            B5.Start()
            Button5.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox10.Text = "6 Lv" Then
            Me.AdcIşınlan.Play()
            B5.Start()
            Button5.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox10.Text = "7 Lv" Then
            Me.AdcIşınlan.Play()
            B5.Start()
            Button5.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox10.Text = "8 Lv" Then
            Me.AdcIşınlan.Play()
            B5.Start()
            Button5.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox10.Text = "9 Lv" Then
            Me.AdcIşınlan.Play()
            B5.Start()
            Button5.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox10.Text = "10 Lv" Then
            Me.AdcIşınlan.Play()
            B5.Start()
            Button5.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox10.Text = "11 Lv" Then
            Me.AdcIşınlan.Play()
            B5.Start()
            Button5.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox10.Text = "12 Lv" Then
            Me.AdcIşınlan.Play()
            B5.Start()
            Button5.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox10.Text = "13 Lv" Then
            Me.AdcIşınlan.Play()
            B5.Start()
            Button5.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox10.Text = "14 Lv" Then
            Me.AdcIşınlan.Play()
            B5.Start()
            Button5.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox10.Text = "15 Lv" Then
            Me.AdcIşınlan.Play()
            B5.Start()
            Button5.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox10.Text = "16 Lv" Then
            Me.AdcIşınlan.Play()
            B5.Start()
            Button5.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox10.Text = "17 Lv" Then
            Me.AdcIşınlan.Play()
            B5.Start()
            Button5.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox10.Text = "18 Lv" Then
            Me.AdcIşınlan.Play()
            B5.Start()
            Button5.BackColor = Color.FromArgb(0, 255, 0)




        ElseIf Tema.ComboBox10.Text = "Şifa" Then
            Me.AdcŞifa.Play()
            B5.Start()
            Button5.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox10.Text = "Arındır" Then
            Me.AdcArındır.Play()
            B5.Start()
            Button5.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox10.Text = "Bariyer" Then
            Me.AdcBariyer.Play()
            B5.Start()
            Button5.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox10.Text = "Hayalet" Then
            Me.AdcHayalet.Play()
            B5.Start()
            Button5.BackColor = Color.FromArgb(0, 255, 0)
        ElseIf Tema.ComboBox10.Text = "Bitkinlik" Then
            Me.AdcBitkinlik.Play()
            B5.Start()
            Button5.BackColor = Color.FromArgb(0, 255, 0)
        End If
#End Region
    End Sub


    '                 TİMERLAR


#Region "Ses Timer TR SOLO"
    Private Sub B1_Tick(sender As Object, e As EventArgs) Handles B1.Tick

        If Tema.ComboBox6.Text = "Tutuştur" Then
            Me.SoloTutuştur2.Play()
            B1.Stop()
        ElseIf Tema.ComboBox6.Text = "Işınlan" Then
            Me.SoloIşınlan2.Play()
            B1.Stop()

        ElseIf Tema.ComboBox6.Text = "1 Lv" Then
            Me.SoloIşınlan2.Play()
            B1.Stop()
        ElseIf Tema.ComboBox6.Text = "2 Lv" Then
            Me.SoloIşınlan2.Play()
            B1.Stop()
        ElseIf Tema.ComboBox6.Text = "3 Lv" Then
            Me.SoloIşınlan2.Play()
            B1.Stop()
        ElseIf Tema.ComboBox6.Text = "4 Lv" Then
            Me.SoloIşınlan2.Play()
            B1.Stop()
        ElseIf Tema.ComboBox6.Text = "5 Lv" Then
            Me.SoloIşınlan2.Play()
            B1.Stop()
        ElseIf Tema.ComboBox6.Text = "6 Lv" Then
            Me.SoloIşınlan2.Play()
            B1.Stop()
        ElseIf Tema.ComboBox6.Text = "7 Lv" Then
            Me.SoloIşınlan2.Play()
            B1.Stop()
        ElseIf Tema.ComboBox6.Text = "8 Lv" Then
            Me.SoloIşınlan2.Play()
            B1.Stop()
        ElseIf Tema.ComboBox6.Text = "9 Lv" Then
            Me.SoloIşınlan2.Play()
            B1.Stop()
        ElseIf Tema.ComboBox6.Text = "10 Lv" Then
            Me.SoloIşınlan2.Play()
            B1.Stop()
        ElseIf Tema.ComboBox6.Text = "11 Lv" Then
            Me.SoloIşınlan2.Play()
            B1.Stop()
        ElseIf Tema.ComboBox6.Text = "12 Lv" Then
            Me.SoloIşınlan2.Play()
            B1.Stop()
        ElseIf Tema.ComboBox6.Text = "13 Lv" Then
            Me.SoloIşınlan2.Play()
            B1.Stop()
        ElseIf Tema.ComboBox6.Text = "14 Lv" Then
            Me.SoloIşınlan2.Play()
            B1.Stop()
        ElseIf Tema.ComboBox6.Text = "15 Lv" Then
            Me.SoloIşınlan2.Play()
            B1.Stop()
        ElseIf Tema.ComboBox6.Text = "16 Lv" Then
            Me.SoloIşınlan2.Play()
            B1.Stop()
        ElseIf Tema.ComboBox6.Text = "17 Lv" Then
            Me.SoloIşınlan2.Play()
            B1.Stop()
        ElseIf Tema.ComboBox6.Text = "18 Lv" Then
            Me.SoloIşınlan2.Play()
            B1.Stop()





        ElseIf Tema.ComboBox6.Text = "Şifa" Then
            Me.SoloŞifa2.Play()
            B1.Stop()
        ElseIf Tema.ComboBox6.Text = "Arındır" Then
            Me.SoloArındır2.Play()
            B1.Stop()
        ElseIf Tema.ComboBox6.Text = "Bariyer" Then
            Me.SoloBariyer2.Play()
            B1.Stop()
        ElseIf Tema.ComboBox6.Text = "Hayalet" Then
            Me.SoloHayalet2.Play()
            B1.Stop()
        ElseIf Tema.ComboBox6.Text = "Bitkinlik" Then
            Me.SoloBitkinlik2.Play()
            B1.Stop()
        End If
#End Region
    End Sub
#Region "Ses Timer TR JUNG"
    Private Sub B2_Tick(sender As Object, e As EventArgs) Handles B2.Tick
        If Tema.ComboBox7.Text = "Tutuştur" Then
            Me.JungTutuştur2.Play()
            B2.Stop()
        ElseIf Tema.ComboBox7.Text = "Işınlan" Then
            Me.JungIşınlan2.Play()
            B2.Stop()

        ElseIf Tema.ComboBox7.Text = "1 Lv" Then
            Me.JungIşınlan2.Play()
            B2.Stop()
        ElseIf Tema.ComboBox7.Text = "2 Lv" Then
            Me.JungIşınlan2.Play()
            B2.Stop()
        ElseIf Tema.ComboBox7.Text = "3 Lv" Then
            Me.JungIşınlan2.Play()
            B2.Stop()
        ElseIf Tema.ComboBox7.Text = "4 Lv" Then
            Me.JungIşınlan2.Play()
            B2.Stop()
        ElseIf Tema.ComboBox7.Text = "5 Lv" Then
            Me.JungIşınlan2.Play()
            B2.Stop()
        ElseIf Tema.ComboBox7.Text = "6 Lv" Then
            Me.JungIşınlan2.Play()
            B2.Stop()
        ElseIf Tema.ComboBox7.Text = "7 Lv" Then
            Me.JungIşınlan2.Play()
            B2.Stop()
        ElseIf Tema.ComboBox7.Text = "8 Lv" Then
            Me.JungIşınlan2.Play()
            B2.Stop()
        ElseIf Tema.ComboBox7.Text = "9 Lv" Then
            Me.JungIşınlan2.Play()
            B2.Stop()
        ElseIf Tema.ComboBox7.Text = "10 Lv" Then
            Me.JungIşınlan2.Play()
            B2.Stop()
        ElseIf Tema.ComboBox7.Text = "11 Lv" Then
            Me.JungIşınlan2.Play()
            B2.Stop()
        ElseIf Tema.ComboBox7.Text = "12 Lv" Then
            Me.JungIşınlan2.Play()
            B2.Stop()
        ElseIf Tema.ComboBox7.Text = "13 Lv" Then
            Me.JungIşınlan2.Play()
            B2.Stop()
        ElseIf Tema.ComboBox7.Text = "14 Lv" Then
            Me.JungIşınlan2.Play()
            B2.Stop()
        ElseIf Tema.ComboBox7.Text = "15 Lv" Then
            Me.JungIşınlan2.Play()
            B2.Stop()
        ElseIf Tema.ComboBox7.Text = "16 Lv" Then
            Me.JungIşınlan2.Play()
            B2.Stop()
        ElseIf Tema.ComboBox7.Text = "17 Lv" Then
            Me.JungIşınlan2.Play()
            B2.Stop()
        ElseIf Tema.ComboBox7.Text = "18 Lv" Then
            Me.JungIşınlan2.Play()
            B2.Stop()


        ElseIf Tema.ComboBox7.Text = "Şifa" Then
            Me.JungŞifa2.Play()
            B2.Stop()
        ElseIf Tema.ComboBox7.Text = "Arındır" Then
            Me.JungArındır2.Play()
            B2.Stop()
        ElseIf Tema.ComboBox7.Text = "Bariyer" Then
            Me.JungBariyer2.Play()
            B2.Stop()
        ElseIf Tema.ComboBox7.Text = "Hayalet" Then
            Me.JungHayalet2.Play()
            B2.Stop()
        ElseIf Tema.ComboBox7.Text = "Bitkinlik" Then
            Me.JungBitkinlik2.Play()
            B2.Stop()
        ElseIf Tema.ComboBox7.Text = "Çarp" Then
            Me.JungÇarp2.Play()
            B2.Stop()
        End If
#End Region
    End Sub
#Region "Ses Timer TR MİD"
    Private Sub B3_Tick(sender As Object, e As EventArgs) Handles B3.Tick
        If Tema.ComboBox8.Text = "Tutuştur" Then
            Me.MidTutuştur2.Play()
            B3.Stop()
        ElseIf Tema.ComboBox8.Text = "Işınlan" Then
            Me.MidIşınlan2.Play()
            B3.Stop()

        ElseIf Tema.ComboBox8.Text = "1 Lv" Then
            Me.MidIşınlan2.Play()
            B3.Stop()
        ElseIf Tema.ComboBox8.Text = "2 Lv" Then
            Me.MidIşınlan2.Play()
            B3.Stop()
        ElseIf Tema.ComboBox8.Text = "3 Lv" Then
            Me.MidIşınlan2.Play()
            B3.Stop()
        ElseIf Tema.ComboBox8.Text = "4 Lv" Then
            Me.MidIşınlan2.Play()
            B3.Stop()
        ElseIf Tema.ComboBox8.Text = "5 Lv" Then
            Me.MidIşınlan2.Play()
            B3.Stop()
        ElseIf Tema.ComboBox8.Text = "6 Lv" Then
            Me.MidIşınlan2.Play()
            B3.Stop()
        ElseIf Tema.ComboBox8.Text = "7 Lv" Then
            Me.MidIşınlan2.Play()
            B3.Stop()
        ElseIf Tema.ComboBox8.Text = "8 Lv" Then
            Me.MidIşınlan2.Play()
            B3.Stop()
        ElseIf Tema.ComboBox8.Text = "9 Lv" Then
            Me.MidIşınlan2.Play()
            B3.Stop()
        ElseIf Tema.ComboBox8.Text = "10 Lv" Then
            Me.MidIşınlan2.Play()
            B3.Stop()
        ElseIf Tema.ComboBox8.Text = "11 Lv" Then
            Me.MidIşınlan2.Play()
            B3.Stop()
        ElseIf Tema.ComboBox8.Text = "12 Lv" Then
            Me.MidIşınlan2.Play()
            B3.Stop()
        ElseIf Tema.ComboBox8.Text = "13 Lv" Then
            Me.MidIşınlan2.Play()
            B3.Stop()
        ElseIf Tema.ComboBox8.Text = "14 Lv" Then
            Me.MidIşınlan2.Play()
            B3.Stop()
        ElseIf Tema.ComboBox8.Text = "15 Lv" Then
            Me.MidIşınlan2.Play()
            B3.Stop()
        ElseIf Tema.ComboBox8.Text = "16 Lv" Then
            Me.MidIşınlan2.Play()
            B3.Stop()
        ElseIf Tema.ComboBox8.Text = "17 Lv" Then
            Me.MidIşınlan2.Play()
            B3.Stop()
        ElseIf Tema.ComboBox8.Text = "18 Lv" Then
            Me.MidIşınlan2.Play()
            B3.Stop()





        ElseIf Tema.ComboBox8.Text = "Şifa" Then
            Me.MidŞifa2.Play()
            B3.Stop()
        ElseIf Tema.ComboBox8.Text = "Arındır" Then
            Me.MidArındır2.Play()
            B3.Stop()
        ElseIf Tema.ComboBox8.Text = "Bariyer" Then
            Me.MidBariyer2.Play()
            B3.Stop()
        ElseIf Tema.ComboBox8.Text = "Hayalet" Then
            Me.MidHayalet2.Play()
            B3.Stop()
        ElseIf Tema.ComboBox8.Text = "Bitkinlik" Then
            Me.MidBitkinlik2.Play()
            B3.Stop()
        End If


#End Region
    End Sub
#Region "Ses Timer TR SUP"
    Private Sub B4_Tick(sender As Object, e As EventArgs) Handles B4.Tick
        If Tema.ComboBox9.Text = "Tutuştur" Then
            Me.SupTutuştur2.Play()
            B4.Stop()
        ElseIf Tema.ComboBox9.Text = "Işınlan" Then
            Me.SupIşınlan2.Play()
            B4.Stop()

        ElseIf Tema.ComboBox9.Text = "1 Lv" Then
            Me.SupIşınlan2.Play()
            B4.Stop()
        ElseIf Tema.ComboBox9.Text = "2 Lv" Then
            Me.SupIşınlan2.Play()
            B4.Stop()
        ElseIf Tema.ComboBox9.Text = "3 Lv" Then
            Me.SupIşınlan2.Play()
            B4.Stop()
        ElseIf Tema.ComboBox9.Text = "4 Lv" Then
            Me.SupIşınlan2.Play()
            B4.Stop()
        ElseIf Tema.ComboBox9.Text = "5 Lv" Then
            Me.SupIşınlan2.Play()
            B4.Stop()
        ElseIf Tema.ComboBox9.Text = "6 Lv" Then
            Me.SupIşınlan2.Play()
            B4.Stop()
        ElseIf Tema.ComboBox9.Text = "7 Lv" Then
            Me.SupIşınlan2.Play()
            B4.Stop()
        ElseIf Tema.ComboBox9.Text = "8 Lv" Then
            Me.SupIşınlan2.Play()
            B4.Stop()
        ElseIf Tema.ComboBox9.Text = "9 Lv" Then
            Me.SupIşınlan2.Play()
            B4.Stop()
        ElseIf Tema.ComboBox9.Text = "10 Lv" Then
            Me.SupIşınlan2.Play()
            B4.Stop()
        ElseIf Tema.ComboBox9.Text = "11 Lv" Then
            Me.SupIşınlan2.Play()
            B4.Stop()
        ElseIf Tema.ComboBox9.Text = "12 Lv" Then
            Me.SupIşınlan2.Play()
            B4.Stop()
        ElseIf Tema.ComboBox9.Text = "13 Lv" Then
            Me.SupIşınlan2.Play()
            B4.Stop()
        ElseIf Tema.ComboBox9.Text = "14 Lv" Then
            Me.SupIşınlan2.Play()
            B4.Stop()
        ElseIf Tema.ComboBox9.Text = "15 Lv" Then
            Me.SupIşınlan2.Play()
            B4.Stop()
        ElseIf Tema.ComboBox9.Text = "16 Lv" Then
            Me.SupIşınlan2.Play()
            B4.Stop()
        ElseIf Tema.ComboBox9.Text = "17 Lv" Then
            Me.SupIşınlan2.Play()
            B4.Stop()
        ElseIf Tema.ComboBox9.Text = "18 Lv" Then
            Me.SupIşınlan2.Play()
            B4.Stop()





        ElseIf Tema.ComboBox9.Text = "Şifa" Then
            Me.SupŞifa2.Play()
            B4.Stop()
        ElseIf Tema.ComboBox9.Text = "Arındır" Then
            Me.SupArındır2.Play()
            B4.Stop()
        ElseIf Tema.ComboBox9.Text = "Bariyer" Then
            Me.SupBariyer2.Play()
            B4.Stop()
        ElseIf Tema.ComboBox9.Text = "Hayalet" Then
            Me.SupHayalet2.Play()
            B4.Stop()
        ElseIf Tema.ComboBox9.Text = "Bitkinlik" Then
            Me.SupBitkinlik2.Play()
            B4.Stop()
        End If
#End Region
    End Sub
#Region "Ses Timer TR ADC"
    Private Sub B5_Tick(sender As Object, e As EventArgs) Handles B5.Tick
        If Tema.ComboBox10.Text = "Tutuştur" Then
            Me.AdcTutuştur2.Play()
            B5.Stop()
        ElseIf Tema.ComboBox10.Text = "Işınlan" Then
            Me.AdcIşınlan2.Play()
            B5.Stop()

        ElseIf Tema.ComboBox10.Text = "1 Lv" Then
            Me.AdcIşınlan2.Play()
            B5.Stop()
        ElseIf Tema.ComboBox10.Text = "2 Lv" Then
            Me.AdcIşınlan2.Play()
            B5.Stop()
        ElseIf Tema.ComboBox10.Text = "3 Lv" Then
            Me.AdcIşınlan2.Play()
            B5.Stop()
        ElseIf Tema.ComboBox10.Text = "4 Lv" Then
            Me.AdcIşınlan2.Play()
            B5.Stop()
        ElseIf Tema.ComboBox10.Text = "5 Lv" Then
            Me.AdcIşınlan2.Play()
            B5.Stop()
        ElseIf Tema.ComboBox10.Text = "6 Lv" Then
            Me.AdcIşınlan2.Play()
            B5.Stop()
        ElseIf Tema.ComboBox10.Text = "7 Lv" Then
            Me.AdcIşınlan2.Play()
            B5.Stop()
        ElseIf Tema.ComboBox10.Text = "8 Lv" Then
            Me.AdcIşınlan2.Play()
            B5.Stop()
        ElseIf Tema.ComboBox10.Text = "9 Lv" Then
            Me.AdcIşınlan2.Play()
            B5.Stop()
        ElseIf Tema.ComboBox10.Text = "10 Lv" Then
            Me.AdcIşınlan2.Play()
            B5.Stop()
        ElseIf Tema.ComboBox10.Text = "11 Lv" Then
            Me.AdcIşınlan2.Play()
            B5.Stop()
        ElseIf Tema.ComboBox10.Text = "12 Lv" Then
            Me.AdcIşınlan2.Play()
            B5.Stop()
        ElseIf Tema.ComboBox10.Text = "13 Lv" Then
            Me.AdcIşınlan2.Play()
            B5.Stop()
        ElseIf Tema.ComboBox10.Text = "14 Lv" Then
            Me.AdcIşınlan2.Play()
            B5.Stop()
        ElseIf Tema.ComboBox10.Text = "15 Lv" Then
            Me.AdcIşınlan2.Play()
            B5.Stop()
        ElseIf Tema.ComboBox10.Text = "16 Lv" Then
            Me.AdcIşınlan2.Play()
            B5.Stop()
        ElseIf Tema.ComboBox10.Text = "17 Lv" Then
            Me.AdcIşınlan2.Play()
            B5.Stop()
        ElseIf Tema.ComboBox10.Text = "18 Lv" Then
            Me.AdcIşınlan2.Play()
            B5.Stop()



        ElseIf Tema.ComboBox10.Text = "Şifa" Then
            Me.AdcŞifa2.Play()
            B5.Stop()
        ElseIf Tema.ComboBox10.Text = "Arındır" Then
            Me.AdcArındır2.Play()
            B5.Stop()
        ElseIf Tema.ComboBox10.Text = "Bariyer" Then
            Me.AdcBariyer2.Play()
            B5.Stop()
        ElseIf Tema.ComboBox10.Text = "Hayalet" Then
            Me.AdcHayalet2.Play()
            B5.Stop()
        ElseIf Tema.ComboBox10.Text = "Bitkinlik" Then
            Me.AdcBitkinlik2.Play()
            B5.Stop()
        End If
#End Region
    End Sub

#Region "Sesler 2 Butonlar için[Sıçra]"
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.SoloSıçra.Play()
        Me.S1.Start()
    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.JungSıçra.Play()
        Me.S2.Start()
    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.MidSıçra.Play()
        Me.S3.Start()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.SupSıçra.Play()
        Me.S4.Start()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.AdcSıçra.Play()
        Me.S5.Start()
    End Sub


    'SıçraTimer'



    Private Sub S1_Tick(sender As Object, e As EventArgs) Handles S1.Tick
        Me.SoloSıçra2.Play()
        Me.S1.Stop()
    End Sub
    Private Sub S2_Tick(sender As Object, e As EventArgs) Handles S2.Tick
        Me.JungSıçra2.Play()
        Me.S2.Stop()
    End Sub
    Private Sub S3_Tick(sender As Object, e As EventArgs) Handles S3.Tick
        Me.MidSıçra2.Play()
        Me.S3.Stop()
    End Sub
    Private Sub S4_Tick(sender As Object, e As EventArgs) Handles S4.Tick
        Me.SupSıçra2.Play()
        Me.S4.Stop()
    End Sub
    Private Sub S5_Tick(sender As Object, e As EventArgs) Handles S5.Tick
        Me.AdcSıçra2.Play()
        Me.S4.Stop()
    End Sub
#End Region


End Class