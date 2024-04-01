<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class STHform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(STHform))
        Me.homebutton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.checkoutpricetb = New System.Windows.Forms.TextBox()
        Me.Sth12 = New hertweels.STH()
        Me.Sth11 = New hertweels.STH()
        Me.Sth10 = New hertweels.STH()
        Me.Sth9 = New hertweels.STH()
        Me.Sth8 = New hertweels.STH()
        Me.Sth7 = New hertweels.STH()
        Me.Sth6 = New hertweels.STH()
        Me.Sth5 = New hertweels.STH()
        Me.Sth4 = New hertweels.STH()
        Me.Sth3 = New hertweels.STH()
        Me.Sth2 = New hertweels.STH()
        Me.Sth1 = New hertweels.STH()
        Me.checkoutpricepagetb = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'homebutton
        '
        Me.homebutton.Location = New System.Drawing.Point(12, 12)
        Me.homebutton.Name = "homebutton"
        Me.homebutton.Size = New System.Drawing.Size(75, 23)
        Me.homebutton.TabIndex = 0
        Me.homebutton.Text = "HOME"
        Me.homebutton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(961, 589)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 13
        '
        'checkoutpricetb
        '
        Me.checkoutpricetb.Location = New System.Drawing.Point(855, 589)
        Me.checkoutpricetb.Name = "checkoutpricetb"
        Me.checkoutpricetb.Size = New System.Drawing.Size(100, 22)
        Me.checkoutpricetb.TabIndex = 14
        '
        'Sth12
        '
        Me.Sth12.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Sth12.carname = "Aventador Mirua Homage"
        Me.Sth12.ID = 12
        Me.Sth12.Location = New System.Drawing.Point(876, 395)
        Me.Sth12.Name = "Sth12"
        Me.Sth12.picture = CType(resources.GetObject("Sth12.picture"), System.Drawing.Image)
        Me.Sth12.price = 140
        Me.Sth12.Size = New System.Drawing.Size(299, 109)
        Me.Sth12.TabIndex = 12
        '
        'Sth11
        '
        Me.Sth11.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Sth11.carname = "Camaro SS"
        Me.Sth11.ID = 11
        Me.Sth11.Location = New System.Drawing.Point(590, 395)
        Me.Sth11.Name = "Sth11"
        Me.Sth11.picture = CType(resources.GetObject("Sth11.picture"), System.Drawing.Image)
        Me.Sth11.price = 112
        Me.Sth11.Size = New System.Drawing.Size(280, 109)
        Me.Sth11.TabIndex = 11
        '
        'Sth10
        '
        Me.Sth10.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Sth10.carname = "Ford RS2000"
        Me.Sth10.ID = 10
        Me.Sth10.Location = New System.Drawing.Point(318, 395)
        Me.Sth10.Name = "Sth10"
        Me.Sth10.picture = CType(resources.GetObject("Sth10.picture"), System.Drawing.Image)
        Me.Sth10.price = 80
        Me.Sth10.Size = New System.Drawing.Size(266, 109)
        Me.Sth10.TabIndex = 10
        '
        'Sth9
        '
        Me.Sth9.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Sth9.carname = "Lamborghini Miura"
        Me.Sth9.ID = 9
        Me.Sth9.Location = New System.Drawing.Point(12, 395)
        Me.Sth9.Name = "Sth9"
        Me.Sth9.picture = CType(resources.GetObject("Sth9.picture"), System.Drawing.Image)
        Me.Sth9.price = 90
        Me.Sth9.Size = New System.Drawing.Size(300, 109)
        Me.Sth9.TabIndex = 9
        '
        'Sth8
        '
        Me.Sth8.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Sth8.carname = "Shelby GT500"
        Me.Sth8.ID = 8
        Me.Sth8.Location = New System.Drawing.Point(881, 235)
        Me.Sth8.Name = "Sth8"
        Me.Sth8.picture = CType(resources.GetObject("Sth8.picture"), System.Drawing.Image)
        Me.Sth8.price = 150
        Me.Sth8.Size = New System.Drawing.Size(294, 109)
        Me.Sth8.TabIndex = 8
        '
        'Sth7
        '
        Me.Sth7.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Sth7.carname = "Lamborghini Sesto Elemental"
        Me.Sth7.ID = 4
        Me.Sth7.Location = New System.Drawing.Point(881, 81)
        Me.Sth7.Name = "Sth7"
        Me.Sth7.picture = CType(resources.GetObject("Sth7.picture"), System.Drawing.Image)
        Me.Sth7.price = 199
        Me.Sth7.Size = New System.Drawing.Size(294, 109)
        Me.Sth7.TabIndex = 7
        '
        'Sth6
        '
        Me.Sth6.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Sth6.carname = "Porsche 918 Spyder"
        Me.Sth6.ID = 7
        Me.Sth6.Location = New System.Drawing.Point(590, 235)
        Me.Sth6.Name = "Sth6"
        Me.Sth6.picture = CType(resources.GetObject("Sth6.picture"), System.Drawing.Image)
        Me.Sth6.price = 80
        Me.Sth6.Size = New System.Drawing.Size(285, 109)
        Me.Sth6.TabIndex = 6
        '
        'Sth5
        '
        Me.Sth5.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Sth5.carname = "Ferrari 599XX"
        Me.Sth5.ID = 6
        Me.Sth5.Location = New System.Drawing.Point(330, 235)
        Me.Sth5.Name = "Sth5"
        Me.Sth5.picture = CType(resources.GetObject("Sth5.picture"), System.Drawing.Image)
        Me.Sth5.price = 350
        Me.Sth5.Size = New System.Drawing.Size(254, 109)
        Me.Sth5.TabIndex = 5
        '
        'Sth4
        '
        Me.Sth4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Sth4.carname = "Ford GT40"
        Me.Sth4.ID = 5
        Me.Sth4.Location = New System.Drawing.Point(12, 235)
        Me.Sth4.Name = "Sth4"
        Me.Sth4.picture = CType(resources.GetObject("Sth4.picture"), System.Drawing.Image)
        Me.Sth4.price = 250
        Me.Sth4.Size = New System.Drawing.Size(312, 109)
        Me.Sth4.TabIndex = 4
        '
        'Sth3
        '
        Me.Sth3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Sth3.carname = "Pagani Huayra Roadster"
        Me.Sth3.ID = 3
        Me.Sth3.Location = New System.Drawing.Point(604, 81)
        Me.Sth3.Name = "Sth3"
        Me.Sth3.picture = CType(resources.GetObject("Sth3.picture"), System.Drawing.Image)
        Me.Sth3.price = 60
        Me.Sth3.Size = New System.Drawing.Size(271, 109)
        Me.Sth3.TabIndex = 3
        '
        'Sth2
        '
        Me.Sth2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Sth2.carname = "Corvette Grand Sport Roadster"
        Me.Sth2.ID = 2
        Me.Sth2.Location = New System.Drawing.Point(318, 81)
        Me.Sth2.Name = "Sth2"
        Me.Sth2.picture = CType(resources.GetObject("Sth2.picture"), System.Drawing.Image)
        Me.Sth2.price = 130
        Me.Sth2.Size = New System.Drawing.Size(266, 109)
        Me.Sth2.TabIndex = 2
        '
        'Sth1
        '
        Me.Sth1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Sth1.carname = "Mercedes-Benz 300SL"
        Me.Sth1.ID = 1
        Me.Sth1.Location = New System.Drawing.Point(43, 81)
        Me.Sth1.Name = "Sth1"
        Me.Sth1.picture = CType(resources.GetObject("Sth1.picture"), System.Drawing.Image)
        Me.Sth1.price = 120
        Me.Sth1.Size = New System.Drawing.Size(269, 109)
        Me.Sth1.TabIndex = 1
        '
        'checkoutpricepagetb
        '
        Me.checkoutpricepagetb.Location = New System.Drawing.Point(749, 589)
        Me.checkoutpricepagetb.Name = "checkoutpricepagetb"
        Me.checkoutpricepagetb.Size = New System.Drawing.Size(100, 22)
        Me.checkoutpricepagetb.TabIndex = 15
        '
        'STHform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1220, 646)
        Me.Controls.Add(Me.checkoutpricepagetb)
        Me.Controls.Add(Me.checkoutpricetb)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Sth12)
        Me.Controls.Add(Me.Sth11)
        Me.Controls.Add(Me.Sth10)
        Me.Controls.Add(Me.Sth9)
        Me.Controls.Add(Me.Sth8)
        Me.Controls.Add(Me.Sth7)
        Me.Controls.Add(Me.Sth6)
        Me.Controls.Add(Me.Sth5)
        Me.Controls.Add(Me.Sth4)
        Me.Controls.Add(Me.Sth3)
        Me.Controls.Add(Me.Sth2)
        Me.Controls.Add(Me.Sth1)
        Me.Controls.Add(Me.homebutton)
        Me.Name = "STHform"
        Me.Text = "STHform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents homebutton As Button
    Friend WithEvents Sth1 As STH
    Friend WithEvents Sth2 As STH
    Friend WithEvents Sth3 As STH
    Friend WithEvents Sth4 As STH
    Friend WithEvents Sth5 As STH
    Friend WithEvents Sth6 As STH
    Friend WithEvents Sth7 As STH
    Friend WithEvents Sth8 As STH
    Friend WithEvents Sth9 As STH
    Friend WithEvents Sth10 As STH
    Friend WithEvents Sth11 As STH
    Friend WithEvents Sth12 As STH
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents checkoutpricetb As TextBox
    Friend WithEvents checkoutpricepagetb As TextBox
End Class
