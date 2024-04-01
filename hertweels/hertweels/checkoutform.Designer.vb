<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checkoutform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(checkoutform))
        Me.carpb = New System.Windows.Forms.PictureBox()
        Me.carname = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.pricetb = New System.Windows.Forms.Label()
        Me.Quantitytb = New System.Windows.Forms.Label()
        CType(Me.carpb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'carpb
        '
        Me.carpb.Location = New System.Drawing.Point(12, 68)
        Me.carpb.Name = "carpb"
        Me.carpb.Size = New System.Drawing.Size(400, 514)
        Me.carpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.carpb.TabIndex = 0
        Me.carpb.TabStop = False
        '
        'carname
        '
        Me.carname.AutoSize = True
        Me.carname.Font = New System.Drawing.Font("Rockwell", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.carname.Location = New System.Drawing.Point(512, 68)
        Me.carname.Name = "carname"
        Me.carname.Size = New System.Drawing.Size(148, 49)
        Me.carname.TabIndex = 1
        Me.carname.Text = "NAME"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(93, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "HOME"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "23-Mercedes-Benz-300-SL-STH-US.jpg")
        Me.ImageList1.Images.SetKeyName(1, "81fkEYmpa8L.jpg")
        Me.ImageList1.Images.SetKeyName(2, "d47f80b5af12fa60192a8d84fe2674bb.jpg")
        Me.ImageList1.Images.SetKeyName(3, "810xPvYCoyL.jpg")
        Me.ImageList1.Images.SetKeyName(4, "10200359_1_1.jpg")
        Me.ImageList1.Images.SetKeyName(5, "s-l1600.jpg")
        Me.ImageList1.Images.SetKeyName(6, "images (2).jpg")
        Me.ImageList1.Images.SetKeyName(7, "71nSzkYIs7L.jpg")
        Me.ImageList1.Images.SetKeyName(8, "download (2).jpg")
        Me.ImageList1.Images.SetKeyName(9, "2024-hot-wheels-super-treasure-hunt-ford-rs2000.jpg")
        Me.ImageList1.Images.SetKeyName(10, "my-11134207-7r98v-lmsviww79ac6b4.jpg")
        Me.ImageList1.Images.SetKeyName(11, "images (3).jpg")
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "BACK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'pricetb
        '
        Me.pricetb.AutoSize = True
        Me.pricetb.Font = New System.Drawing.Font("Rockwell", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pricetb.Location = New System.Drawing.Point(514, 334)
        Me.pricetb.Name = "pricetb"
        Me.pricetb.Size = New System.Drawing.Size(115, 38)
        Me.pricetb.TabIndex = 4
        Me.pricetb.Text = "PRICE"
        '
        'Quantitytb
        '
        Me.Quantitytb.AutoSize = True
        Me.Quantitytb.Font = New System.Drawing.Font("Rockwell", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quantitytb.Location = New System.Drawing.Point(514, 214)
        Me.Quantitytb.Name = "Quantitytb"
        Me.Quantitytb.Size = New System.Drawing.Size(186, 38)
        Me.Quantitytb.TabIndex = 5
        Me.Quantitytb.Text = "QUANTITY"
        '
        'checkoutform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1220, 646)
        Me.Controls.Add(Me.Quantitytb)
        Me.Controls.Add(Me.pricetb)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.carname)
        Me.Controls.Add(Me.carpb)
        Me.Name = "checkoutform"
        Me.Text = "checkoutform"
        CType(Me.carpb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents carpb As PictureBox
    Friend WithEvents carname As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Button2 As Button
    Friend WithEvents pricetb As Label
    Friend WithEvents Quantitytb As Label
End Class
