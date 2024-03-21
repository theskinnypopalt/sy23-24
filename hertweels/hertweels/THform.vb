Public Class THform
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles homebutton.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub THform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
    End Sub
End Class