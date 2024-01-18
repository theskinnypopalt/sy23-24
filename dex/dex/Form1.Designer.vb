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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UploadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nametb = New System.Windows.Forms.TextBox()
        Me.pricetb = New System.Windows.Forms.TextBox()
        Me.zerosixtytb = New System.Windows.Forms.TextBox()
        Me.toptb = New System.Windows.Forms.TextBox()
        Me.hptb = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.firstbutton = New System.Windows.Forms.Button()
        Me.prevbutton = New System.Windows.Forms.Button()
        Me.nextbutton = New System.Windows.Forms.Button()
        Me.lastbutton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(492, 91)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(314, 234)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1092, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem1, Me.SaveToolStripMenuItem, Me.UploadToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.NewToolStripMenuItem.Text = "file"
        '
        'NewToolStripMenuItem1
        '
        Me.NewToolStripMenuItem1.Name = "NewToolStripMenuItem1"
        Me.NewToolStripMenuItem1.Size = New System.Drawing.Size(141, 26)
        Me.NewToolStripMenuItem1.Text = "new"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(141, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'UploadToolStripMenuItem
        '
        Me.UploadToolStripMenuItem.Name = "UploadToolStripMenuItem"
        Me.UploadToolStripMenuItem.Size = New System.Drawing.Size(141, 26)
        Me.UploadToolStripMenuItem.Text = "Upload"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(141, 26)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 298)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Horsepower:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(144, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "0-60:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(103, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Top Speed:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(142, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Price:"
        '
        'nametb
        '
        Me.nametb.Location = New System.Drawing.Point(217, 91)
        Me.nametb.Name = "nametb"
        Me.nametb.Size = New System.Drawing.Size(125, 27)
        Me.nametb.TabIndex = 7
        '
        'pricetb
        '
        Me.pricetb.Location = New System.Drawing.Point(217, 142)
        Me.pricetb.Name = "pricetb"
        Me.pricetb.Size = New System.Drawing.Size(125, 27)
        Me.pricetb.TabIndex = 8
        '
        'zerosixtytb
        '
        Me.zerosixtytb.Location = New System.Drawing.Point(217, 189)
        Me.zerosixtytb.Name = "zerosixtytb"
        Me.zerosixtytb.Size = New System.Drawing.Size(125, 27)
        Me.zerosixtytb.TabIndex = 9
        '
        'toptb
        '
        Me.toptb.Location = New System.Drawing.Point(217, 240)
        Me.toptb.Name = "toptb"
        Me.toptb.Size = New System.Drawing.Size(125, 27)
        Me.toptb.TabIndex = 10
        '
        'hptb
        '
        Me.hptb.Location = New System.Drawing.Point(217, 298)
        Me.hptb.Name = "hptb"
        Me.hptb.Size = New System.Drawing.Size(125, 27)
        Me.hptb.TabIndex = 11
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'firstbutton
        '
        Me.firstbutton.Location = New System.Drawing.Point(217, 409)
        Me.firstbutton.Name = "firstbutton"
        Me.firstbutton.Size = New System.Drawing.Size(94, 29)
        Me.firstbutton.TabIndex = 12
        Me.firstbutton.Text = "First"
        Me.firstbutton.UseVisualStyleBackColor = True
        '
        'prevbutton
        '
        Me.prevbutton.Location = New System.Drawing.Point(364, 409)
        Me.prevbutton.Name = "prevbutton"
        Me.prevbutton.Size = New System.Drawing.Size(94, 29)
        Me.prevbutton.TabIndex = 13
        Me.prevbutton.Text = "Prevous"
        Me.prevbutton.UseVisualStyleBackColor = True
        '
        'nextbutton
        '
        Me.nextbutton.Location = New System.Drawing.Point(511, 409)
        Me.nextbutton.Name = "nextbutton"
        Me.nextbutton.Size = New System.Drawing.Size(94, 29)
        Me.nextbutton.TabIndex = 14
        Me.nextbutton.Text = "Next"
        Me.nextbutton.UseVisualStyleBackColor = True
        '
        'lastbutton
        '
        Me.lastbutton.Location = New System.Drawing.Point(658, 409)
        Me.lastbutton.Name = "lastbutton"
        Me.lastbutton.Size = New System.Drawing.Size(94, 29)
        Me.lastbutton.TabIndex = 15
        Me.lastbutton.Text = "Last"
        Me.lastbutton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 550)
        Me.Controls.Add(Me.lastbutton)
        Me.Controls.Add(Me.nextbutton)
        Me.Controls.Add(Me.prevbutton)
        Me.Controls.Add(Me.firstbutton)
        Me.Controls.Add(Me.hptb)
        Me.Controls.Add(Me.toptb)
        Me.Controls.Add(Me.zerosixtytb)
        Me.Controls.Add(Me.pricetb)
        Me.Controls.Add(Me.nametb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents nametb As TextBox
    Friend WithEvents pricetb As TextBox
    Friend WithEvents zerosixtytb As TextBox
    Friend WithEvents toptb As TextBox
    Friend WithEvents hptb As TextBox
    Friend WithEvents NewToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents UploadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents firstbutton As Button
    Friend WithEvents prevbutton As Button
    Friend WithEvents nextbutton As Button
    Friend WithEvents lastbutton As Button
End Class
