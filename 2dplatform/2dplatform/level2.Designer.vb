<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class level2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(level2))
        Me.picground = New System.Windows.Forms.PictureBox()
        Me.picair = New System.Windows.Forms.PictureBox()
        Me.picplayer = New System.Windows.Forms.PictureBox()
        Me.tmrright = New System.Windows.Forms.Timer(Me.components)
        Me.tmrleft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrup = New System.Windows.Forms.Timer(Me.components)
        Me.tmrgamelogic = New System.Windows.Forms.Timer(Me.components)
        Me.tmrgravity = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.topboundry = New System.Windows.Forms.PictureBox()
        Me.rightboundry = New System.Windows.Forms.PictureBox()
        Me.leftboundry = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.coin1 = New System.Windows.Forms.PictureBox()
        Me.coin4 = New System.Windows.Forms.PictureBox()
        Me.coin2 = New System.Windows.Forms.PictureBox()
        Me.coin3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.scoretb = New System.Windows.Forms.Label()
        Me.Mover1 = New _2dplatform.Mover()
        Me.Mover2 = New _2dplatform.Mover()
        Me.nextlevelpb = New System.Windows.Forms.PictureBox()
        Me.spikes1 = New System.Windows.Forms.PictureBox()
        Me.spikes2 = New System.Windows.Forms.PictureBox()
        Me.spikes6 = New System.Windows.Forms.PictureBox()
        Me.spikes5 = New System.Windows.Forms.PictureBox()
        Me.spikes4 = New System.Windows.Forms.PictureBox()
        Me.spikes3 = New System.Windows.Forms.PictureBox()
        CType(Me.picground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picplayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.topboundry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rightboundry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leftboundry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coin1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coin4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coin2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coin3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nextlevelpb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spikes1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spikes2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spikes6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spikes5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spikes4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spikes3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picground
        '
        Me.picground.BackColor = System.Drawing.Color.Transparent
        Me.picground.Location = New System.Drawing.Point(-10, 482)
        Me.picground.Name = "picground"
        Me.picground.Size = New System.Drawing.Size(1118, 173)
        Me.picground.TabIndex = 0
        Me.picground.TabStop = False
        '
        'picair
        '
        Me.picair.BackColor = System.Drawing.Color.Transparent
        Me.picair.Location = New System.Drawing.Point(-69, -65)
        Me.picair.Name = "picair"
        Me.picair.Size = New System.Drawing.Size(1263, 532)
        Me.picair.TabIndex = 1
        Me.picair.TabStop = False
        '
        'picplayer
        '
        Me.picplayer.BackColor = System.Drawing.Color.Red
        Me.picplayer.Location = New System.Drawing.Point(22, 66)
        Me.picplayer.Name = "picplayer"
        Me.picplayer.Size = New System.Drawing.Size(33, 33)
        Me.picplayer.TabIndex = 2
        Me.picplayer.TabStop = False
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1129, 225)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 3
        '
        'topboundry
        '
        Me.topboundry.BackColor = System.Drawing.Color.Transparent
        Me.topboundry.Location = New System.Drawing.Point(-1, -20)
        Me.topboundry.Name = "topboundry"
        Me.topboundry.Size = New System.Drawing.Size(1095, 36)
        Me.topboundry.TabIndex = 4
        Me.topboundry.TabStop = False
        '
        'rightboundry
        '
        Me.rightboundry.BackColor = System.Drawing.Color.Transparent
        Me.rightboundry.Location = New System.Drawing.Point(1074, 0)
        Me.rightboundry.Name = "rightboundry"
        Me.rightboundry.Size = New System.Drawing.Size(110, 607)
        Me.rightboundry.TabIndex = 5
        Me.rightboundry.TabStop = False
        '
        'leftboundry
        '
        Me.leftboundry.BackColor = System.Drawing.Color.Transparent
        Me.leftboundry.Location = New System.Drawing.Point(-46, 0)
        Me.leftboundry.Name = "leftboundry"
        Me.leftboundry.Size = New System.Drawing.Size(62, 612)
        Me.leftboundry.TabIndex = 6
        Me.leftboundry.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gold
        Me.PictureBox1.Location = New System.Drawing.Point(462, 333)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 15)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "bound"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Gold
        Me.PictureBox2.Location = New System.Drawing.Point(589, 160)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(109, 15)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "bound"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Gold
        Me.PictureBox3.Location = New System.Drawing.Point(749, 166)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(109, 15)
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "bound"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Gold
        Me.PictureBox4.Location = New System.Drawing.Point(308, 264)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(109, 15)
        Me.PictureBox4.TabIndex = 10
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "bound"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.SaddleBrown
        Me.PictureBox5.Location = New System.Drawing.Point(12, 105)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(265, 30)
        Me.PictureBox5.TabIndex = 13
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "bound"
        '
        'coin1
        '
        Me.coin1.BackColor = System.Drawing.Color.Transparent
        Me.coin1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.coin1.Image = CType(resources.GetObject("coin1.Image"), System.Drawing.Image)
        Me.coin1.Location = New System.Drawing.Point(401, 66)
        Me.coin1.Name = "coin1"
        Me.coin1.Size = New System.Drawing.Size(34, 29)
        Me.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.coin1.TabIndex = 14
        Me.coin1.TabStop = False
        '
        'coin4
        '
        Me.coin4.BackColor = System.Drawing.Color.Transparent
        Me.coin4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.coin4.Image = CType(resources.GetObject("coin4.Image"), System.Drawing.Image)
        Me.coin4.Location = New System.Drawing.Point(845, 414)
        Me.coin4.Name = "coin4"
        Me.coin4.Size = New System.Drawing.Size(34, 29)
        Me.coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.coin4.TabIndex = 15
        Me.coin4.TabStop = False
        '
        'coin2
        '
        Me.coin2.BackColor = System.Drawing.Color.Transparent
        Me.coin2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.coin2.Image = CType(resources.GetObject("coin2.Image"), System.Drawing.Image)
        Me.coin2.Location = New System.Drawing.Point(636, 125)
        Me.coin2.Name = "coin2"
        Me.coin2.Size = New System.Drawing.Size(34, 29)
        Me.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.coin2.TabIndex = 16
        Me.coin2.TabStop = False
        '
        'coin3
        '
        Me.coin3.BackColor = System.Drawing.Color.Transparent
        Me.coin3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.coin3.Image = CType(resources.GetObject("coin3.Image"), System.Drawing.Image)
        Me.coin3.Location = New System.Drawing.Point(795, 177)
        Me.coin3.Name = "coin3"
        Me.coin3.Size = New System.Drawing.Size(34, 29)
        Me.coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.coin3.TabIndex = 17
        Me.coin3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(837, 506)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 46)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "SCORE:"
        '
        'scoretb
        '
        Me.scoretb.AutoSize = True
        Me.scoretb.BackColor = System.Drawing.Color.Transparent
        Me.scoretb.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoretb.Location = New System.Drawing.Point(998, 506)
        Me.scoretb.Name = "scoretb"
        Me.scoretb.Size = New System.Drawing.Size(42, 46)
        Me.scoretb.TabIndex = 19
        Me.scoretb.Text = "0"
        '
        'Mover1
        '
        Me.Mover1.BackColor = System.Drawing.Color.Transparent
        Me.Mover1.ForeColor = System.Drawing.Color.Transparent
        Me.Mover1.interval = 500
        Me.Mover1.Location = New System.Drawing.Point(759, 136)
        Me.Mover1.Name = "Mover1"
        Me.Mover1.Size = New System.Drawing.Size(150, 150)
        Me.Mover1.speed = 10
        Me.Mover1.sprite = Me.PictureBox3
        Me.Mover1.TabIndex = 11
        '
        'Mover2
        '
        Me.Mover2.BackColor = System.Drawing.Color.Transparent
        Me.Mover2.ForeColor = System.Drawing.Color.Transparent
        Me.Mover2.interval = 500
        Me.Mover2.Location = New System.Drawing.Point(303, 219)
        Me.Mover2.Name = "Mover2"
        Me.Mover2.Size = New System.Drawing.Size(43, 41)
        Me.Mover2.speed = 5
        Me.Mover2.sprite = Me.PictureBox4
        Me.Mover2.TabIndex = 12
        '
        'nextlevelpb
        '
        Me.nextlevelpb.BackColor = System.Drawing.Color.Transparent
        Me.nextlevelpb.Image = CType(resources.GetObject("nextlevelpb.Image"), System.Drawing.Image)
        Me.nextlevelpb.Location = New System.Drawing.Point(46, 414)
        Me.nextlevelpb.Name = "nextlevelpb"
        Me.nextlevelpb.Size = New System.Drawing.Size(56, 100)
        Me.nextlevelpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.nextlevelpb.TabIndex = 20
        Me.nextlevelpb.TabStop = False
        '
        'spikes1
        '
        Me.spikes1.BackColor = System.Drawing.Color.Transparent
        Me.spikes1.Image = CType(resources.GetObject("spikes1.Image"), System.Drawing.Image)
        Me.spikes1.Location = New System.Drawing.Point(462, 287)
        Me.spikes1.Name = "spikes1"
        Me.spikes1.Size = New System.Drawing.Size(100, 50)
        Me.spikes1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.spikes1.TabIndex = 21
        Me.spikes1.TabStop = False
        '
        'spikes2
        '
        Me.spikes2.BackColor = System.Drawing.Color.Transparent
        Me.spikes2.Image = CType(resources.GetObject("spikes2.Image"), System.Drawing.Image)
        Me.spikes2.Location = New System.Drawing.Point(167, 464)
        Me.spikes2.Name = "spikes2"
        Me.spikes2.Size = New System.Drawing.Size(100, 50)
        Me.spikes2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.spikes2.TabIndex = 22
        Me.spikes2.TabStop = False
        '
        'spikes6
        '
        Me.spikes6.BackColor = System.Drawing.Color.Transparent
        Me.spikes6.Image = CType(resources.GetObject("spikes6.Image"), System.Drawing.Image)
        Me.spikes6.Location = New System.Drawing.Point(542, 464)
        Me.spikes6.Name = "spikes6"
        Me.spikes6.Size = New System.Drawing.Size(100, 50)
        Me.spikes6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.spikes6.TabIndex = 23
        Me.spikes6.TabStop = False
        '
        'spikes5
        '
        Me.spikes5.BackColor = System.Drawing.Color.Transparent
        Me.spikes5.Image = CType(resources.GetObject("spikes5.Image"), System.Drawing.Image)
        Me.spikes5.Location = New System.Drawing.Point(448, 464)
        Me.spikes5.Name = "spikes5"
        Me.spikes5.Size = New System.Drawing.Size(100, 50)
        Me.spikes5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.spikes5.TabIndex = 24
        Me.spikes5.TabStop = False
        '
        'spikes4
        '
        Me.spikes4.BackColor = System.Drawing.Color.Transparent
        Me.spikes4.Image = CType(resources.GetObject("spikes4.Image"), System.Drawing.Image)
        Me.spikes4.Location = New System.Drawing.Point(358, 464)
        Me.spikes4.Name = "spikes4"
        Me.spikes4.Size = New System.Drawing.Size(100, 50)
        Me.spikes4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.spikes4.TabIndex = 25
        Me.spikes4.TabStop = False
        '
        'spikes3
        '
        Me.spikes3.BackColor = System.Drawing.Color.Transparent
        Me.spikes3.Image = CType(resources.GetObject("spikes3.Image"), System.Drawing.Image)
        Me.spikes3.Location = New System.Drawing.Point(262, 464)
        Me.spikes3.Name = "spikes3"
        Me.spikes3.Size = New System.Drawing.Size(100, 50)
        Me.spikes3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.spikes3.TabIndex = 26
        Me.spikes3.TabStop = False
        '
        'level2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1090, 653)
        Me.Controls.Add(Me.picplayer)
        Me.Controls.Add(Me.spikes3)
        Me.Controls.Add(Me.spikes4)
        Me.Controls.Add(Me.spikes5)
        Me.Controls.Add(Me.spikes6)
        Me.Controls.Add(Me.spikes2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.spikes1)
        Me.Controls.Add(Me.nextlevelpb)
        Me.Controls.Add(Me.scoretb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.coin3)
        Me.Controls.Add(Me.coin2)
        Me.Controls.Add(Me.coin4)
        Me.Controls.Add(Me.coin1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.rightboundry)
        Me.Controls.Add(Me.topboundry)
        Me.Controls.Add(Me.leftboundry)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.picground)
        Me.Controls.Add(Me.Mover1)
        Me.Controls.Add(Me.Mover2)
        Me.Controls.Add(Me.picair)
        Me.Name = "level2"
        Me.Text = "level2"
        CType(Me.picground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picplayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.topboundry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rightboundry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leftboundry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coin1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coin4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coin2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coin3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nextlevelpb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spikes1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spikes2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spikes6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spikes5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spikes4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spikes3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picground As PictureBox
    Friend WithEvents picair As PictureBox
    Friend WithEvents picplayer As PictureBox
    Friend WithEvents tmrright As Timer
    Friend WithEvents tmrleft As Timer
    Friend WithEvents tmrup As Timer
    Friend WithEvents tmrgamelogic As Timer
    Friend WithEvents tmrgravity As Timer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents topboundry As PictureBox
    Friend WithEvents rightboundry As PictureBox
    Friend WithEvents leftboundry As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Mover1 As Mover
    Friend WithEvents Mover2 As Mover
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents coin1 As PictureBox
    Friend WithEvents coin4 As PictureBox
    Friend WithEvents coin2 As PictureBox
    Friend WithEvents coin3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents scoretb As Label
    Friend WithEvents nextlevelpb As PictureBox
    Friend WithEvents spikes1 As PictureBox
    Friend WithEvents spikes2 As PictureBox
    Friend WithEvents spikes6 As PictureBox
    Friend WithEvents spikes5 As PictureBox
    Friend WithEvents spikes4 As PictureBox
    Friend WithEvents spikes3 As PictureBox
End Class
