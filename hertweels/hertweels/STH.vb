Public Class STH
    Public Property price As Integer
    Dim total As Decimal
    Public Property picture As Image

    Private Sub quantityupdown_ValueChanged(sender As Object, e As EventArgs) Handles quantityupdown.ValueChanged
        pricelabel.Text = price * quantityupdown.Value
    End Sub

    Private Sub checkoutbutton_Click(sender As Object, e As EventArgs) Handles checkoutbutton.Click

    End Sub
End Class
