<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class STH
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.carpb = New System.Windows.Forms.PictureBox()
        Me.pricelabel = New System.Windows.Forms.Label()
        Me.quantityupdown = New System.Windows.Forms.NumericUpDown()
        Me.namelabel = New System.Windows.Forms.Label()
        Me.checkoutbutton = New System.Windows.Forms.Button()
        CType(Me.carpb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quantityupdown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'carpb
        '
        Me.carpb.Location = New System.Drawing.Point(3, 3)
        Me.carpb.Name = "carpb"
        Me.carpb.Size = New System.Drawing.Size(70, 80)
        Me.carpb.TabIndex = 0
        Me.carpb.TabStop = False
        '
        'pricelabel
        '
        Me.pricelabel.AutoSize = True
        Me.pricelabel.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pricelabel.Location = New System.Drawing.Point(80, 51)
        Me.pricelabel.Name = "pricelabel"
        Me.pricelabel.Size = New System.Drawing.Size(52, 20)
        Me.pricelabel.TabIndex = 1
        Me.pricelabel.Text = "price"
        '
        'quantityupdown
        '
        Me.quantityupdown.Location = New System.Drawing.Point(79, 26)
        Me.quantityupdown.Name = "quantityupdown"
        Me.quantityupdown.Size = New System.Drawing.Size(91, 22)
        Me.quantityupdown.TabIndex = 2
        '
        'namelabel
        '
        Me.namelabel.AutoSize = True
        Me.namelabel.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namelabel.Location = New System.Drawing.Point(79, 3)
        Me.namelabel.Name = "namelabel"
        Me.namelabel.Size = New System.Drawing.Size(53, 20)
        Me.namelabel.TabIndex = 3
        Me.namelabel.Text = "name"
        '
        'checkoutbutton
        '
        Me.checkoutbutton.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkoutbutton.Location = New System.Drawing.Point(79, 74)
        Me.checkoutbutton.Name = "checkoutbutton"
        Me.checkoutbutton.Size = New System.Drawing.Size(72, 27)
        Me.checkoutbutton.TabIndex = 4
        Me.checkoutbutton.Text = "Button1"
        Me.checkoutbutton.UseVisualStyleBackColor = True
        '
        'STH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Controls.Add(Me.checkoutbutton)
        Me.Controls.Add(Me.namelabel)
        Me.Controls.Add(Me.quantityupdown)
        Me.Controls.Add(Me.pricelabel)
        Me.Controls.Add(Me.carpb)
        Me.Name = "STH"
        Me.Size = New System.Drawing.Size(204, 109)
        CType(Me.carpb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quantityupdown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents carpb As PictureBox
    Friend WithEvents pricelabel As Label
    Friend WithEvents quantityupdown As NumericUpDown
    Friend WithEvents namelabel As Label
    Friend WithEvents checkoutbutton As Button
End Class
