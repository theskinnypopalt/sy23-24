Public Class Form1
    Private Sub Mainlinebutton_Click(sender As Object, e As EventArgs) Handles Mainlinebutton.Click
        mainlineform.ShowDialog()
    End Sub

    Private Sub thbutton_Click(sender As Object, e As EventArgs) Handles thbutton.Click
        THform.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        STHform.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If mainlineform.ShowDialog = True Then
        '    mainlineform.Hide()
        'End If
        'If THform.ShowDialog = True Then
        '    THform.Hide()
        'End If
        'If STHform.ShowDialog = True Then
        '    STHform.Hide()
        'End If
    End Sub
End Class
