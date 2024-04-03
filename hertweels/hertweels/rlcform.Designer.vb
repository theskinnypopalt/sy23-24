<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rlcform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rlcform))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pricetb = New System.Windows.Forms.TextBox()
        Me.quantitytb = New System.Windows.Forms.TextBox()
        Me.idtb = New System.Windows.Forms.TextBox()
        Me.Sth3 = New hertweels.STH()
        Me.Sth2 = New hertweels.STH()
        Me.Sth1 = New hertweels.STH()
        Me.Sth4 = New hertweels.STH()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "HOME"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pricetb
        '
        Me.pricetb.Location = New System.Drawing.Point(1108, 612)
        Me.pricetb.Name = "pricetb"
        Me.pricetb.Size = New System.Drawing.Size(100, 22)
        Me.pricetb.TabIndex = 2
        Me.pricetb.Visible = False
        '
        'quantitytb
        '
        Me.quantitytb.Location = New System.Drawing.Point(1002, 612)
        Me.quantitytb.Name = "quantitytb"
        Me.quantitytb.Size = New System.Drawing.Size(100, 22)
        Me.quantitytb.TabIndex = 3
        Me.quantitytb.Visible = False
        '
        'idtb
        '
        Me.idtb.Location = New System.Drawing.Point(896, 612)
        Me.idtb.Name = "idtb"
        Me.idtb.Size = New System.Drawing.Size(100, 22)
        Me.idtb.TabIndex = 4
        Me.idtb.Visible = False
        '
        'Sth3
        '
        Me.Sth3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Sth3.carname = "Lamborghini Countach"
        Me.Sth3.ID = 42
        Me.Sth3.Location = New System.Drawing.Point(534, 71)
        Me.Sth3.Name = "Sth3"
        Me.Sth3.picture = CType(resources.GetObject("Sth3.picture"), System.Drawing.Image)
        Me.Sth3.price = 45
        Me.Sth3.Size = New System.Drawing.Size(265, 109)
        Me.Sth3.TabIndex = 6
        '
        'Sth2
        '
        Me.Sth2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Sth2.carname = "Nissan GT-R R34"
        Me.Sth2.ID = 41
        Me.Sth2.Location = New System.Drawing.Point(286, 71)
        Me.Sth2.Name = "Sth2"
        Me.Sth2.picture = CType(resources.GetObject("Sth2.picture"), System.Drawing.Image)
        Me.Sth2.price = 400
        Me.Sth2.Size = New System.Drawing.Size(242, 109)
        Me.Sth2.TabIndex = 5
        '
        'Sth1
        '
        Me.Sth1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Sth1.carname = "Porsche 959"
        Me.Sth1.ID = 40
        Me.Sth1.Location = New System.Drawing.Point(12, 71)
        Me.Sth1.Name = "Sth1"
        Me.Sth1.picture = CType(resources.GetObject("Sth1.picture"), System.Drawing.Image)
        Me.Sth1.price = 60
        Me.Sth1.Size = New System.Drawing.Size(268, 109)
        Me.Sth1.TabIndex = 1
        '
        'Sth4
        '
        Me.Sth4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Sth4.carname = "Mclaren F1"
        Me.Sth4.ID = 43
        Me.Sth4.Location = New System.Drawing.Point(805, 71)
        Me.Sth4.Name = "Sth4"
        Me.Sth4.picture = CType(resources.GetObject("Sth4.picture"), System.Drawing.Image)
        Me.Sth4.price = 65
        Me.Sth4.Size = New System.Drawing.Size(264, 109)
        Me.Sth4.TabIndex = 7
        '
        'rlcform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1220, 646)
        Me.Controls.Add(Me.Sth4)
        Me.Controls.Add(Me.Sth3)
        Me.Controls.Add(Me.Sth2)
        Me.Controls.Add(Me.idtb)
        Me.Controls.Add(Me.quantitytb)
        Me.Controls.Add(Me.pricetb)
        Me.Controls.Add(Me.Sth1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "rlcform"
        Me.Text = "rlcform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Sth1 As STH
    Friend WithEvents pricetb As TextBox
    Friend WithEvents quantitytb As TextBox
    Friend WithEvents idtb As TextBox
    Friend WithEvents Sth2 As STH
    Friend WithEvents Sth3 As STH
    Friend WithEvents Sth4 As STH
End Class
