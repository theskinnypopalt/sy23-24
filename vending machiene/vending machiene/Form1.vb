﻿Public Class Form1
    Dim WithEvents cs As New coinslot

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.insertQuarter()
        TOTALLABEL.Text = cs.total
        If quarterpb.Visible = True Then
            quarterpb.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs.insertDimes()
        TOTALLABEL.Text = cs.total
        If dimepb.Visible = True Then
            dimepb.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cs.insertDollars()
        TOTALLABEL.Text = cs.total
        If dollarpb.Visible = True Then
            dollarpb.Visible = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.insertPennies()
        TOTALLABEL.Text = cs.total
        If pennypb.Visible = True Then
            pennypb.Visible = False
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cs.insertNickles()
        TOTALLABEL.Text = cs.total
        If nicklepb.Visible = True Then
            nicklepb.Visible = False
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        cs.coinReturn()
        TOTALLABEL.Text = cs.total.ToString("c2")
    End Sub

    Private Sub cs_coinReturnevent(d As Integer, q As Integer, dm As Integer, n As Integer, p As Integer) Handles cs.coinReturnevent
        If d > 0 Then
            dollarpb.Visible = True
        Else
            dollarpb.Visible = False
        End If
        If q > 0 Then
            quarterpb.Visible = True
        Else
            quarterpb.Visible = False
        End If
        If dm > 0 Then
            dimepb.Visible = True
        Else
            dimepb.Visible = False
        End If
        If n > 0 Then
            nicklepb.Visible = True
        Else
            nicklepb.Visible = False
        End If
        If p > 0 Then
            pennypb.Visible = True
        Else
            pennypb.Visible = False
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Select Case IDtextbox.Text
            Case ProductControl1.productid
                ProductControl1.buy()
            Case 2

            Case Else

        End Select
        TOTALLABEL.Text = cs.total.ToString("c2")
    End Sub
    Private Sub cs_dispense(p As Image) Handles cs.dispense
        productpicturebox.Image = p
    End Sub
End Class
