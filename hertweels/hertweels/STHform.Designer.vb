﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.homebutton = New System.Windows.Forms.Button()
        Me.Sth1 = New hertweels.STH()
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
        'Sth1
        '
        Me.Sth1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Sth1.Location = New System.Drawing.Point(12, 70)
        Me.Sth1.Name = "Sth1"
        Me.Sth1.price = 0
        Me.Sth1.Size = New System.Drawing.Size(204, 109)
        Me.Sth1.TabIndex = 1
        '
        'STHform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1220, 646)
        Me.Controls.Add(Me.Sth1)
        Me.Controls.Add(Me.homebutton)
        Me.Name = "STHform"
        Me.Text = "STHform"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents homebutton As Button
    Friend WithEvents Sth1 As STH
End Class
