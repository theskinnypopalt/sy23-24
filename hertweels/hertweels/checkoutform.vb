Public Class checkoutform
    Private Sub checkoutform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        STHform.Hide()

        If STHform.TextBox1.Text = "1" Then
            carname.Text = "Mercedes-Benz 300SL"
            carpb.Image = ImageList1.Images(0)
        End If
        If STHform.TextBox1.Text = "2" Then
            carname.Text = "Corvette Grand Sport Roadster"
        End If
        If STHform.TextBox1.Text = "3" Then
            carname.Text = "Pagani Huayra Roadster"
        End If
        If STHform.TextBox1.Text = "4" Then
            carname.Text = "Lamborghini Sesto Elemental"
        End If
        If STHform.TextBox1.Text = "5" Then
            carname.Text = "Ford GT40"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class