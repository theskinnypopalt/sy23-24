Public Class mainlineform
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles homebutton.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub mainlineform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
    End Sub
End Class