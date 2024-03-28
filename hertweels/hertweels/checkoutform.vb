Public Class checkoutform
    Private Sub checkoutform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If STHform.TextBox1.Text = "1" Then
            carname.Text = "Mercedes-Benz 300SL"
        End If
        If STHform.TextBox1.Text = "2" Then
            carname.Text = "Corvette Grand Sport Roadster"
        End If
    End Sub


End Class