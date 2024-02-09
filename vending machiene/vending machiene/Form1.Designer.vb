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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.dollarpb = New System.Windows.Forms.PictureBox()
        Me.pennypb = New System.Windows.Forms.PictureBox()
        Me.nicklepb = New System.Windows.Forms.PictureBox()
        Me.dimepb = New System.Windows.Forms.PictureBox()
        Me.quarterpb = New System.Windows.Forms.PictureBox()
        Me.ProductControl1 = New vending_machiene.productControl()
        CType(Me.dollarpb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pennypb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nicklepb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dimepb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quarterpb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(38, 446)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 67)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(207, 446)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 66)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(118, 446)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 67)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(371, 446)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(66, 67)
        Me.Button4.TabIndex = 3
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Location = New System.Drawing.Point(287, 446)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(78, 67)
        Me.Button5.TabIndex = 4
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(453, 474)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 5
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(582, 463)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 44)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "COIN RETURN"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'dollarpb
        '
        Me.dollarpb.Image = CType(resources.GetObject("dollarpb.Image"), System.Drawing.Image)
        Me.dollarpb.Location = New System.Drawing.Point(940, 56)
        Me.dollarpb.Name = "dollarpb"
        Me.dollarpb.Size = New System.Drawing.Size(75, 32)
        Me.dollarpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dollarpb.TabIndex = 7
        Me.dollarpb.TabStop = False
        '
        'pennypb
        '
        Me.pennypb.Image = CType(resources.GetObject("pennypb.Image"), System.Drawing.Image)
        Me.pennypb.Location = New System.Drawing.Point(940, 339)
        Me.pennypb.Name = "pennypb"
        Me.pennypb.Size = New System.Drawing.Size(75, 32)
        Me.pennypb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pennypb.TabIndex = 8
        Me.pennypb.TabStop = False
        '
        'nicklepb
        '
        Me.nicklepb.Image = CType(resources.GetObject("nicklepb.Image"), System.Drawing.Image)
        Me.nicklepb.Location = New System.Drawing.Point(940, 272)
        Me.nicklepb.Name = "nicklepb"
        Me.nicklepb.Size = New System.Drawing.Size(75, 32)
        Me.nicklepb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.nicklepb.TabIndex = 9
        Me.nicklepb.TabStop = False
        '
        'dimepb
        '
        Me.dimepb.Image = CType(resources.GetObject("dimepb.Image"), System.Drawing.Image)
        Me.dimepb.Location = New System.Drawing.Point(940, 205)
        Me.dimepb.Name = "dimepb"
        Me.dimepb.Size = New System.Drawing.Size(75, 32)
        Me.dimepb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dimepb.TabIndex = 10
        Me.dimepb.TabStop = False
        '
        'quarterpb
        '
        Me.quarterpb.Image = CType(resources.GetObject("quarterpb.Image"), System.Drawing.Image)
        Me.quarterpb.Location = New System.Drawing.Point(940, 127)
        Me.quarterpb.Name = "quarterpb"
        Me.quarterpb.Size = New System.Drawing.Size(75, 32)
        Me.quarterpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.quarterpb.TabIndex = 11
        Me.quarterpb.TabStop = False
        '
        'ProductControl1
        '
        Me.ProductControl1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ProductControl1.count = 0
        Me.ProductControl1.Location = New System.Drawing.Point(57, 37)
        Me.ProductControl1.Name = "ProductControl1"
        Me.ProductControl1.picture = CType(resources.GetObject("ProductControl1.picture"), System.Drawing.Image)
        Me.ProductControl1.price = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.ProductControl1.productid = Nothing
        Me.ProductControl1.Size = New System.Drawing.Size(119, 93)
        Me.ProductControl1.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1128, 630)
        Me.Controls.Add(Me.ProductControl1)
        Me.Controls.Add(Me.quarterpb)
        Me.Controls.Add(Me.dimepb)
        Me.Controls.Add(Me.nicklepb)
        Me.Controls.Add(Me.pennypb)
        Me.Controls.Add(Me.dollarpb)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dollarpb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pennypb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nicklepb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dimepb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quarterpb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents dollarpb As PictureBox
    Friend WithEvents pennypb As PictureBox
    Friend WithEvents nicklepb As PictureBox
    Friend WithEvents dimepb As PictureBox
    Friend WithEvents quarterpb As PictureBox
    Friend WithEvents ProductControl1 As productControl
End Class
