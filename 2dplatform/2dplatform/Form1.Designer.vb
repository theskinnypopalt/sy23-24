<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picplayer = New System.Windows.Forms.PictureBox()
        Me.picair = New System.Windows.Forms.PictureBox()
        Me.picground = New System.Windows.Forms.PictureBox()
        Me.tmrright = New System.Windows.Forms.Timer(Me.components)
        Me.tmrleft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrup = New System.Windows.Forms.Timer(Me.components)
        Me.tmrgamelogic = New System.Windows.Forms.Timer(Me.components)
        Me.tmrgravity = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.topboundry = New System.Windows.Forms.PictureBox()
        Me.rightboundry = New System.Windows.Forms.PictureBox()
        Me.leftboundry = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.nextlevel = New System.Windows.Forms.PictureBox()
        Me.coin1 = New System.Windows.Forms.PictureBox()
        Me.coin4 = New System.Windows.Forms.PictureBox()
        Me.coin2 = New System.Windows.Forms.PictureBox()
        Me.coin3 = New System.Windows.Forms.PictureBox()
        Me.coin5 = New System.Windows.Forms.PictureBox()
        Me.coin6 = New System.Windows.Forms.PictureBox()
        Me.scoretb = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Mover1 = New _2dplatform.Mover()
        Me.Mover2 = New _2dplatform.Mover()
        Me.Mover4 = New _2dplatform.Mover()
        Me.Mover3 = New _2dplatform.Mover()
        Me.wizardpb = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        CType(Me.picplayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.topboundry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rightboundry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leftboundry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nextlevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coin1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coin4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coin2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coin3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coin5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coin6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wizardpb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picplayer
        '
        Me.picplayer.BackColor = System.Drawing.Color.Red
        Me.picplayer.Location = New System.Drawing.Point(59, 476)
        Me.picplayer.Name = "picplayer"
        Me.picplayer.Size = New System.Drawing.Size(33, 33)
        Me.picplayer.TabIndex = 0
        Me.picplayer.TabStop = False
        '
        'picair
        '
        Me.picair.BackColor = System.Drawing.Color.Transparent
        Me.picair.Location = New System.Drawing.Point(1, -201)
        Me.picair.Name = "picair"
        Me.picair.Size = New System.Drawing.Size(1112, 671)
        Me.picair.TabIndex = 1
        Me.picair.TabStop = False
        '
        'picground
        '
        Me.picground.BackColor = System.Drawing.Color.Transparent
        Me.picground.Location = New System.Drawing.Point(1, 476)
        Me.picground.Name = "picground"
        Me.picground.Size = New System.Drawing.Size(1112, 179)
        Me.picground.TabIndex = 2
        Me.picground.TabStop = False
        '
        'tmrright
        '
        Me.tmrright.Interval = 30
        '
        'tmrleft
        '
        Me.tmrleft.Interval = 30
        '
        'tmrup
        '
        Me.tmrup.Interval = 30
        '
        'tmrgamelogic
        '
        Me.tmrgamelogic.Interval = 30
        '
        'tmrgravity
        '
        Me.tmrgravity.Interval = 30
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gold
        Me.PictureBox1.Location = New System.Drawing.Point(627, 99)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 10)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "bound"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Gold
        Me.PictureBox2.Location = New System.Drawing.Point(231, 399)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(112, 10)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "bound"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Gold
        Me.PictureBox3.Location = New System.Drawing.Point(579, 446)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(112, 10)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "bound"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Gold
        Me.PictureBox4.Location = New System.Drawing.Point(887, 348)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(112, 10)
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "bound"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1093, 164)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 8
        '
        'topboundry
        '
        Me.topboundry.BackColor = System.Drawing.Color.Transparent
        Me.topboundry.Location = New System.Drawing.Point(1, -30)
        Me.topboundry.Name = "topboundry"
        Me.topboundry.Size = New System.Drawing.Size(1095, 48)
        Me.topboundry.TabIndex = 9
        Me.topboundry.TabStop = False
        '
        'rightboundry
        '
        Me.rightboundry.BackColor = System.Drawing.Color.Transparent
        Me.rightboundry.Location = New System.Drawing.Point(1080, 12)
        Me.rightboundry.Name = "rightboundry"
        Me.rightboundry.Size = New System.Drawing.Size(61, 657)
        Me.rightboundry.TabIndex = 10
        Me.rightboundry.TabStop = False
        '
        'leftboundry
        '
        Me.leftboundry.BackColor = System.Drawing.Color.Transparent
        Me.leftboundry.Location = New System.Drawing.Point(-25, 12)
        Me.leftboundry.Name = "leftboundry"
        Me.leftboundry.Size = New System.Drawing.Size(38, 660)
        Me.leftboundry.TabIndex = 11
        Me.leftboundry.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.SaddleBrown
        Me.PictureBox5.Location = New System.Drawing.Point(766, 143)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(308, 23)
        Me.PictureBox5.TabIndex = 15
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "bound"
        '
        'nextlevel
        '
        Me.nextlevel.BackColor = System.Drawing.Color.Transparent
        Me.nextlevel.BackgroundImage = CType(resources.GetObject("nextlevel.BackgroundImage"), System.Drawing.Image)
        Me.nextlevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.nextlevel.Location = New System.Drawing.Point(1022, 74)
        Me.nextlevel.Name = "nextlevel"
        Me.nextlevel.Size = New System.Drawing.Size(53, 78)
        Me.nextlevel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.nextlevel.TabIndex = 16
        Me.nextlevel.TabStop = False
        Me.nextlevel.Visible = False
        '
        'coin1
        '
        Me.coin1.BackColor = System.Drawing.Color.Transparent
        Me.coin1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.coin1.Image = CType(resources.GetObject("coin1.Image"), System.Drawing.Image)
        Me.coin1.Location = New System.Drawing.Point(122, 298)
        Me.coin1.Name = "coin1"
        Me.coin1.Size = New System.Drawing.Size(34, 29)
        Me.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.coin1.TabIndex = 17
        Me.coin1.TabStop = False
        '
        'coin4
        '
        Me.coin4.BackColor = System.Drawing.Color.Transparent
        Me.coin4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.coin4.Image = CType(resources.GetObject("coin4.Image"), System.Drawing.Image)
        Me.coin4.Location = New System.Drawing.Point(705, 210)
        Me.coin4.Name = "coin4"
        Me.coin4.Size = New System.Drawing.Size(34, 29)
        Me.coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.coin4.TabIndex = 18
        Me.coin4.TabStop = False
        '
        'coin2
        '
        Me.coin2.BackColor = System.Drawing.Color.Transparent
        Me.coin2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.coin2.Image = CType(resources.GetObject("coin2.Image"), System.Drawing.Image)
        Me.coin2.Location = New System.Drawing.Point(219, 90)
        Me.coin2.Name = "coin2"
        Me.coin2.Size = New System.Drawing.Size(34, 29)
        Me.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.coin2.TabIndex = 19
        Me.coin2.TabStop = False
        '
        'coin3
        '
        Me.coin3.BackColor = System.Drawing.Color.Transparent
        Me.coin3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.coin3.Image = CType(resources.GetObject("coin3.Image"), System.Drawing.Image)
        Me.coin3.Location = New System.Drawing.Point(396, 143)
        Me.coin3.Name = "coin3"
        Me.coin3.Size = New System.Drawing.Size(34, 29)
        Me.coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.coin3.TabIndex = 20
        Me.coin3.TabStop = False
        '
        'coin5
        '
        Me.coin5.BackColor = System.Drawing.Color.Transparent
        Me.coin5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.coin5.Image = CType(resources.GetObject("coin5.Image"), System.Drawing.Image)
        Me.coin5.Location = New System.Drawing.Point(705, 461)
        Me.coin5.Name = "coin5"
        Me.coin5.Size = New System.Drawing.Size(34, 29)
        Me.coin5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.coin5.TabIndex = 21
        Me.coin5.TabStop = False
        '
        'coin6
        '
        Me.coin6.BackColor = System.Drawing.Color.Transparent
        Me.coin6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.coin6.Image = CType(resources.GetObject("coin6.Image"), System.Drawing.Image)
        Me.coin6.Location = New System.Drawing.Point(986, 346)
        Me.coin6.Name = "coin6"
        Me.coin6.Size = New System.Drawing.Size(34, 29)
        Me.coin6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.coin6.TabIndex = 22
        Me.coin6.TabStop = False
        '
        'scoretb
        '
        Me.scoretb.AutoSize = True
        Me.scoretb.BackColor = System.Drawing.Color.Transparent
        Me.scoretb.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoretb.Location = New System.Drawing.Point(960, 523)
        Me.scoretb.Name = "scoretb"
        Me.scoretb.Size = New System.Drawing.Size(42, 46)
        Me.scoretb.TabIndex = 23
        Me.scoretb.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(793, 523)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 46)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "SCORE:"
        '
        'Mover1
        '
        Me.Mover1.BackColor = System.Drawing.Color.Transparent
        Me.Mover1.ForeColor = System.Drawing.Color.Transparent
        Me.Mover1.interval = 500
        Me.Mover1.Location = New System.Drawing.Point(559, 386)
        Me.Mover1.Name = "Mover1"
        Me.Mover1.Size = New System.Drawing.Size(102, 58)
        Me.Mover1.speed = 10
        Me.Mover1.sprite = Me.PictureBox3
        Me.Mover1.TabIndex = 7
        '
        'Mover2
        '
        Me.Mover2.BackColor = System.Drawing.Color.Transparent
        Me.Mover2.ForeColor = System.Drawing.Color.Transparent
        Me.Mover2.interval = 500
        Me.Mover2.Location = New System.Drawing.Point(417, 109)
        Me.Mover2.Name = "Mover2"
        Me.Mover2.Size = New System.Drawing.Size(200, 10)
        Me.Mover2.speed = 10
        Me.Mover2.sprite = Me.PictureBox1
        Me.Mover2.TabIndex = 12
        '
        'Mover4
        '
        Me.Mover4.BackColor = System.Drawing.Color.Transparent
        Me.Mover4.ForeColor = System.Drawing.Color.Transparent
        Me.Mover4.interval = 500
        Me.Mover4.Location = New System.Drawing.Point(837, 298)
        Me.Mover4.Name = "Mover4"
        Me.Mover4.Size = New System.Drawing.Size(43, 42)
        Me.Mover4.speed = 10
        Me.Mover4.sprite = Me.PictureBox4
        Me.Mover4.TabIndex = 14
        '
        'Mover3
        '
        Me.Mover3.BackColor = System.Drawing.Color.Transparent
        Me.Mover3.ForeColor = System.Drawing.Color.Transparent
        Me.Mover3.interval = 500
        Me.Mover3.Location = New System.Drawing.Point(91, 59)
        Me.Mover3.Name = "Mover3"
        Me.Mover3.Size = New System.Drawing.Size(224, 331)
        Me.Mover3.speed = 10
        Me.Mover3.sprite = Me.PictureBox2
        Me.Mover3.TabIndex = 13
        '
        'wizardpb
        '
        Me.wizardpb.BackColor = System.Drawing.Color.Transparent
        Me.wizardpb.BackgroundImage = CType(resources.GetObject("wizardpb.BackgroundImage"), System.Drawing.Image)
        Me.wizardpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.wizardpb.Location = New System.Drawing.Point(870, 78)
        Me.wizardpb.Name = "wizardpb"
        Me.wizardpb.Size = New System.Drawing.Size(97, 61)
        Me.wizardpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.wizardpb.TabIndex = 25
        Me.wizardpb.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(763, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = " "
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(705, 24)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(159, 95)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 27
        Me.PictureBox6.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1087, 653)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.wizardpb)
        Me.Controls.Add(Me.picplayer)
        Me.Controls.Add(Me.scoretb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.leftboundry)
        Me.Controls.Add(Me.rightboundry)
        Me.Controls.Add(Me.topboundry)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Mover1)
        Me.Controls.Add(Me.Mover2)
        Me.Controls.Add(Me.Mover4)
        Me.Controls.Add(Me.coin6)
        Me.Controls.Add(Me.coin5)
        Me.Controls.Add(Me.coin3)
        Me.Controls.Add(Me.coin2)
        Me.Controls.Add(Me.coin4)
        Me.Controls.Add(Me.coin1)
        Me.Controls.Add(Me.Mover3)
        Me.Controls.Add(Me.picground)
        Me.Controls.Add(Me.nextlevel)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.picair)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picplayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.topboundry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rightboundry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leftboundry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nextlevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coin1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coin4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coin2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coin3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coin5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coin6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wizardpb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picplayer As PictureBox
    Friend WithEvents picair As PictureBox
    Friend WithEvents picground As PictureBox
    Friend WithEvents tmrright As Timer
    Friend WithEvents tmrleft As Timer
    Friend WithEvents tmrup As Timer
    Friend WithEvents tmrgamelogic As Timer
    Friend WithEvents tmrgravity As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Mover1 As Mover
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents topboundry As PictureBox
    Friend WithEvents rightboundry As PictureBox
    Friend WithEvents leftboundry As PictureBox
    Friend WithEvents Mover2 As Mover
    Friend WithEvents Mover3 As Mover
    Friend WithEvents Mover4 As Mover
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents nextlevel As PictureBox
    Friend WithEvents coin1 As PictureBox
    Friend WithEvents coin4 As PictureBox
    Friend WithEvents coin2 As PictureBox
    Friend WithEvents coin3 As PictureBox
    Friend WithEvents coin5 As PictureBox
    Friend WithEvents coin6 As PictureBox
    Friend WithEvents scoretb As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents wizardpb As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox6 As PictureBox
End Class
