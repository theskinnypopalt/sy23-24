﻿Public Class productControl
    Public Property productid As String
    Public Property price As Decimal
    Public Property count As Integer
    Public Property picture As Image

    Private Sub productControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = picture
        IDlabel.Text = productid
        Pricelabel.Text = price.ToString("c2")
    End Sub
End Class
