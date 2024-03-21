<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Mainlinebutton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.thbutton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sthbutton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Coral
        Me.Label1.Location = New System.Drawing.Point(456, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 69)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WarmTires"
        '
        'Mainlinebutton
        '
        Me.Mainlinebutton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Mainlinebutton.BackgroundImage = CType(resources.GetObject("Mainlinebutton.BackgroundImage"), System.Drawing.Image)
        Me.Mainlinebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Mainlinebutton.Location = New System.Drawing.Point(97, 330)
        Me.Mainlinebutton.Name = "Mainlinebutton"
        Me.Mainlinebutton.Size = New System.Drawing.Size(261, 117)
        Me.Mainlinebutton.TabIndex = 1
        Me.Mainlinebutton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(141, 281)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 46)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mainline"
        '
        'thbutton
        '
        Me.thbutton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.thbutton.BackgroundImage = CType(resources.GetObject("thbutton.BackgroundImage"), System.Drawing.Image)
        Me.thbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.thbutton.Location = New System.Drawing.Point(468, 330)
        Me.thbutton.Name = "thbutton"
        Me.thbutton.Size = New System.Drawing.Size(261, 117)
        Me.thbutton.TabIndex = 3
        Me.thbutton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(447, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(293, 46)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Treasure Hunts"
        '
        'sthbutton
        '
        Me.sthbutton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.sthbutton.BackgroundImage = CType(resources.GetObject("sthbutton.BackgroundImage"), System.Drawing.Image)
        Me.sthbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sthbutton.Location = New System.Drawing.Point(813, 330)
        Me.sthbutton.Name = "sthbutton"
        Me.sthbutton.Size = New System.Drawing.Size(261, 117)
        Me.sthbutton.TabIndex = 5
        Me.sthbutton.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(805, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(293, 46)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Treasure Hunts"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(889, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 46)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Super"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1220, 646)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.sthbutton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.thbutton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Mainlinebutton)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Mainlinebutton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents thbutton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents sthbutton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
