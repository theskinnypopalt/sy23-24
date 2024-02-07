Public Class Form1
    Dim cs As New coinslot

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.insertQuarter()
        TextBox1.Text = cs.total
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs.insertDimes()
        TextBox1.Text = cs.total
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cs.insertDollars()
        TextBox1.Text = cs.total
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.insertPennies()
        TextBox1.Text = cs.total
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cs.insertNickles()
        TextBox1.Text = cs.total
    End Sub


End Class
