Imports System.Reflection.Emit
Imports System.Windows
Imports System.Windows.Forms.DataFormats

Public Class STH
    Public Property price As Integer

    Public count As Integer
    Public Property picture As Image
    Public Property carname As String
    Public Property ID As Integer

    Dim total As Decimal

    Private Sub quantityupdown_ValueChanged(sender As Object, e As EventArgs) Handles quantityupdown.ValueChanged
        pricelabel.Text = price * quantityupdown.Value
        STHform.checkoutpricetb.Text = quantityupdown.Value
    End Sub

    Private Sub checkoutbutton_Click(sender As Object, e As EventArgs) Handles checkoutbutton.Click
        If quantityupdown.Value >= 1 Then
            STHform.TextBox1.Text = ID
            STHform.checkoutpricepagetb.Text = pricelabel.Text
            checkoutform.ShowDialog()
            Me.Hide()
            STHform.Hide()

        End If
    End Sub

    Private Sub STH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carpb.Image = picture
        namelabel.Text = carname
        pricelabel.Text = price
    End Sub
End Class
