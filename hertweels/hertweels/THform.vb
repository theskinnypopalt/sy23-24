﻿Public Class THform
    Private Sub THform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.ShowDialog()
    End Sub
End Class