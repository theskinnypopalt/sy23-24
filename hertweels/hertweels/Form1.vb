Public Class Form1
    Private Sub Mainlinebutton_Click(sender As Object, e As EventArgs) Handles Mainlinebutton.Click
        mainlineform.ShowDialog()
    End Sub

    Private Sub thbutton_Click(sender As Object, e As EventArgs) Handles thbutton.Click
        THform.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles sthbutton.Click
        STHform.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        rlcform.ShowDialog()
        Me.Hide()
    End Sub
End Class
