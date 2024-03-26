Public Class STHform
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles homebutton.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub STHform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
    End Sub

    Private Sub Sth5_Load(sender As Object, e As EventArgs) Handles Sth5.Load

    End Sub



End Class