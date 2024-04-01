Public Class STHform
    Public picture(11) As Image
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles homebutton.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub STHform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub checkoutpricetb_TextChanged(sender As Object, e As EventArgs) Handles checkoutpricetb.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class