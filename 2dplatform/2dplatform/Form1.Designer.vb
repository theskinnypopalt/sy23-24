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
        Me.Mover1 = New _2dplatform.Mover()
        Me.Moverupdown1 = New _2dplatform.moverupdown()
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
        Me.PictureBox1.Location = New System.Drawing.Point(524, 187)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 10)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "bound"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Gold
        Me.PictureBox2.Location = New System.Drawing.Point(191, 211)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(112, 10)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "bound"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Gold
        Me.PictureBox3.Location = New System.Drawing.Point(762, 416)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(112, 10)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "bound"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Gold
        Me.PictureBox4.Location = New System.Drawing.Point(170, 367)
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
        'Mover1
        '
        Me.Mover1.BackColor = System.Drawing.Color.Transparent
        Me.Mover1.ForeColor = System.Drawing.Color.Transparent
        Me.Mover1.interval = 500
        Me.Mover1.Location = New System.Drawing.Point(672, 356)
        Me.Mover1.Name = "Mover1"
        Me.Mover1.Size = New System.Drawing.Size(102, 58)
        Me.Mover1.speed = 10
        Me.Mover1.sprite = Me.PictureBox3
        Me.Mover1.TabIndex = 7
        '
        'Moverupdown1
        '
        Me.Moverupdown1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Moverupdown1.interval = 500
        Me.Moverupdown1.Location = New System.Drawing.Point(488, 172)
        Me.Moverupdown1.Name = "Moverupdown1"
        Me.Moverupdown1.Size = New System.Drawing.Size(14, 228)
        Me.Moverupdown1.speed = 10
        Me.Moverupdown1.sprite = Me.PictureBox1
        Me.Moverupdown1.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1087, 653)
        Me.Controls.Add(Me.Moverupdown1)
        Me.Controls.Add(Me.leftboundry)
        Me.Controls.Add(Me.rightboundry)
        Me.Controls.Add(Me.topboundry)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picplayer)
        Me.Controls.Add(Me.picground)
        Me.Controls.Add(Me.Mover1)
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
    Friend WithEvents Moverupdown1 As moverupdown
End Class
