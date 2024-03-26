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
        Me.carpb = New System.Windows.Forms.PictureBox()
        Me.carname = New System.Windows.Forms.Label()
        CType(Me.carpb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'carpb
        '
        Me.carpb.Location = New System.Drawing.Point(12, 12)
        Me.carpb.Name = "carpb"
        Me.carpb.Size = New System.Drawing.Size(400, 514)
        Me.carpb.TabIndex = 0
        Me.carpb.TabStop = False
        '
        'carname
        '
        Me.carname.AutoSize = True
        Me.carname.Font = New System.Drawing.Font("Rockwell", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.carname.Location = New System.Drawing.Point(575, 9)
        Me.carname.Name = "carname"
        Me.carname.Size = New System.Drawing.Size(466, 49)
        Me.carname.TabIndex = 1
        Me.carname.Text = "Mercedes-Benz 300SL"
        '
        'checkoutform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1220, 646)
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
End Class
