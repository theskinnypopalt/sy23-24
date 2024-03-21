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
End Class
