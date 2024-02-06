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
        Me.ClickerControl11 = New WindowsAppfeb5.ClickerControl1()
        Me.ClickerControl12 = New WindowsAppfeb5.ClickerControl1()
        Me.ClickerControl13 = New WindowsAppfeb5.ClickerControl1()
        Me.ClickerControl14 = New WindowsAppfeb5.ClickerControl1()
        Me.ClickerControl15 = New WindowsAppfeb5.ClickerControl1()
        Me.SuspendLayout()
        '
        'ClickerControl11
        '
        Me.ClickerControl11.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClickerControl11.Location = New System.Drawing.Point(60, 63)
        Me.ClickerControl11.Name = "ClickerControl11"
        Me.ClickerControl11.Size = New System.Drawing.Size(310, 152)
        Me.ClickerControl11.TabIndex = 0
        '
        'ClickerControl12
        '
        Me.ClickerControl12.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClickerControl12.Location = New System.Drawing.Point(473, 63)
        Me.ClickerControl12.Name = "ClickerControl12"
        Me.ClickerControl12.Size = New System.Drawing.Size(310, 152)
        Me.ClickerControl12.TabIndex = 1
        '
        'ClickerControl13
        '
        Me.ClickerControl13.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClickerControl13.Location = New System.Drawing.Point(60, 231)
        Me.ClickerControl13.Name = "ClickerControl13"
        Me.ClickerControl13.Size = New System.Drawing.Size(310, 152)
        Me.ClickerControl13.TabIndex = 2
        '
        'ClickerControl14
        '
        Me.ClickerControl14.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClickerControl14.Location = New System.Drawing.Point(473, 231)
        Me.ClickerControl14.Name = "ClickerControl14"
        Me.ClickerControl14.Size = New System.Drawing.Size(310, 152)
        Me.ClickerControl14.TabIndex = 3
        '
        'ClickerControl15
        '
        Me.ClickerControl15.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClickerControl15.Location = New System.Drawing.Point(60, 403)
        Me.ClickerControl15.Name = "ClickerControl15"
        Me.ClickerControl15.Size = New System.Drawing.Size(310, 152)
        Me.ClickerControl15.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1202, 876)
        Me.Controls.Add(Me.ClickerControl15)
        Me.Controls.Add(Me.ClickerControl14)
        Me.Controls.Add(Me.ClickerControl13)
        Me.Controls.Add(Me.ClickerControl12)
        Me.Controls.Add(Me.ClickerControl11)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ClickerControl11 As ClickerControl1
    Friend WithEvents ClickerControl12 As ClickerControl1
    Friend WithEvents ClickerControl13 As ClickerControl1
    Friend WithEvents ClickerControl14 As ClickerControl1
    Friend WithEvents ClickerControl15 As ClickerControl1
End Class
