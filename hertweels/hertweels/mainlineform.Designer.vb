<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainlineform
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
        Me.homebutton = New System.Windows.Forms.Button()
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
        'mainlineform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1220, 646)
        Me.Controls.Add(Me.homebutton)
        Me.Name = "mainlineform"
        Me.Text = "mainlineform"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents homebutton As Button
End Class
