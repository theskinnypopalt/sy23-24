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
        CType(Me.picground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picplayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.topboundry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rightboundry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leftboundry, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.picplayer.Location = New System.Drawing.Point(22, 482)
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
        'level2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1090, 653)
        Me.Controls.Add(Me.picplayer)
        Me.Controls.Add(Me.rightboundry)
        Me.Controls.Add(Me.topboundry)
        Me.Controls.Add(Me.leftboundry)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.picair)
        Me.Controls.Add(Me.picground)
        Me.Name = "level2"
        Me.Text = "level2"
        CType(Me.picground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picplayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.topboundry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rightboundry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leftboundry, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
