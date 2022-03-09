<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Zamanlama
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Zamanlama))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SoloT = New System.Windows.Forms.Timer(Me.components)
        Me.MidT = New System.Windows.Forms.Timer(Me.components)
        Me.JungT = New System.Windows.Forms.Timer(Me.components)
        Me.AdcT = New System.Windows.Forms.Timer(Me.components)
        Me.BotT = New System.Windows.Forms.Timer(Me.components)
        Me.SoloT2 = New System.Windows.Forms.Timer(Me.components)
        Me.MidT2 = New System.Windows.Forms.Timer(Me.components)
        Me.JungT2 = New System.Windows.Forms.Timer(Me.components)
        Me.AdcT2 = New System.Windows.Forms.Timer(Me.components)
        Me.BotT2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'SoloT
        '
        Me.SoloT.Interval = 1000
        '
        'MidT
        '
        Me.MidT.Interval = 1000
        '
        'JungT
        '
        Me.JungT.Interval = 1000
        '
        'AdcT
        '
        Me.AdcT.Interval = 1000
        '
        'SoloT2
        '
        Me.SoloT2.Interval = 1000
        '
        'MidT2
        '
        Me.MidT2.Interval = 1000
        '
        'JungT2
        '
        Me.JungT2.Interval = 1000
        '
        'AdcT2
        '
        Me.AdcT2.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(81, 20)
        Me.TextBox1.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(12, 38)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(81, 20)
        Me.TextBox2.TabIndex = 9
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(115, 12)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(54, 20)
        Me.TextBox3.TabIndex = 10
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(115, 38)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(54, 20)
        Me.TextBox4.TabIndex = 11
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(12, 76)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(81, 20)
        Me.TextBox5.TabIndex = 12
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(12, 102)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(81, 20)
        Me.TextBox6.TabIndex = 13
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(115, 76)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(54, 20)
        Me.TextBox7.TabIndex = 14
        '
        'TextBox8
        '
        Me.TextBox8.Enabled = False
        Me.TextBox8.Location = New System.Drawing.Point(115, 102)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(54, 20)
        Me.TextBox8.TabIndex = 15
        '
        'Zamanlama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(181, 132)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Zamanlama"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SoloT As Timer
    Friend WithEvents MidT As Timer
    Friend WithEvents JungT As Timer
    Friend WithEvents AdcT As Timer
    Friend WithEvents BotT As Timer
    Friend WithEvents SoloT2 As Timer
    Friend WithEvents MidT2 As Timer
    Friend WithEvents JungT2 As Timer
    Friend WithEvents AdcT2 As Timer
    Friend WithEvents BotT2 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
End Class
