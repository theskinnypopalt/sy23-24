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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(STHform))
        Me.homebutton = New System.Windows.Forms.Button()
        Me.Sth4 = New hertweels.STH()
        Me.Sth3 = New hertweels.STH()
        Me.Sth2 = New hertweels.STH()
        Me.Sth1 = New hertweels.STH()
        Me.Sth5 = New hertweels.STH()
        Me.Sth6 = New hertweels.STH()
        Me.Sth7 = New hertweels.STH()
        Me.Sth8 = New hertweels.STH()
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
        'Sth4
        '
        Me.Sth4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Sth4.carname = "Lamborghini Sesto Elemental"
        Me.Sth4.Location = New System.Drawing.Point(12, 235)
        Me.Sth4.Name = "Sth4"
        Me.Sth4.picture = CType(resources.GetObject("Sth4.picture"), System.Drawing.Image)
        Me.Sth4.price = 200
        Me.Sth4.Size = New System.Drawing.Size(312, 109)
        Me.Sth4.TabIndex = 4
        '
        'Sth3
        '
        Me.Sth3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Sth3.carname = "Pagani Huayra"
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
        Me.Sth2.Location = New System.Drawing.Point(318, 81)
        Me.Sth2.Name = "Sth2"
        Me.Sth2.picture = CType(resources.GetObject("Sth2.picture"), System.Drawing.Image)
        Me.Sth2.price = 70
        Me.Sth2.Size = New System.Drawing.Size(266, 109)
        Me.Sth2.TabIndex = 2
        '
        'Sth1
        '
        Me.Sth1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Sth1.carname = "Mercedes-Benz 300SL"
        Me.Sth1.Location = New System.Drawing.Point(43, 81)
        Me.Sth1.Name = "Sth1"
        Me.Sth1.picture = CType(resources.GetObject("Sth1.picture"), System.Drawing.Image)
        Me.Sth1.price = 150
        Me.Sth1.Size = New System.Drawing.Size(269, 109)
        Me.Sth1.TabIndex = 1
        '
        'Sth5
        '
        Me.Sth5.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Sth5.carname = "Ford GT40"
        Me.Sth5.Location = New System.Drawing.Point(330, 235)
        Me.Sth5.Name = "Sth5"
        Me.Sth5.picture = CType(resources.GetObject("Sth5.picture"), System.Drawing.Image)
        Me.Sth5.price = 250
        Me.Sth5.Size = New System.Drawing.Size(254, 109)
        Me.Sth5.TabIndex = 5
        '
        'Sth6
        '
        Me.Sth6.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Sth6.carname = "Ferrari 599xx"
        Me.Sth6.Location = New System.Drawing.Point(590, 235)
        Me.Sth6.Name = "Sth6"
        Me.Sth6.picture = CType(resources.GetObject("Sth6.picture"), System.Drawing.Image)
        Me.Sth6.price = 300
        Me.Sth6.Size = New System.Drawing.Size(401, 109)
        Me.Sth6.TabIndex = 6
        '
        'Sth7
        '
        Me.Sth7.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Sth7.carname = "Porsche 918 Spyder"
        Me.Sth7.Location = New System.Drawing.Point(881, 81)
        Me.Sth7.Name = "Sth7"
        Me.Sth7.picture = CType(resources.GetObject("Sth7.picture"), System.Drawing.Image)
        Me.Sth7.price = 55
        Me.Sth7.Size = New System.Drawing.Size(294, 109)
        Me.Sth7.TabIndex = 7
        '
        'Sth8
        '
        Me.Sth8.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Sth8.carname = "Shelby GT500"
        Me.Sth8.Location = New System.Drawing.Point(881, 235)
        Me.Sth8.Name = "Sth8"
        Me.Sth8.picture = CType(resources.GetObject("Sth8.picture"), System.Drawing.Image)
        Me.Sth8.price = 120
        Me.Sth8.Size = New System.Drawing.Size(294, 109)
        Me.Sth8.TabIndex = 8
        '
        'STHform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1220, 646)
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
End Class
