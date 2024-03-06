Public Class Form1
    Dim movespeed As Integer = 15
    Dim isjumping As Boolean
    Dim score As Integer
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                tmrright.Start()
            Case Keys.Left
                tmrleft.Start()
            Case Keys.Up
                tmrup.Start()
                isjumping = True
        End Select
        If Keys.Right.Down = True And picplayer.Bounds.IntersectsWith(rightboundry.Bounds) Then
            tmrright.Stop()
        End If
        If Keys.Left.Down = True And picplayer.Bounds.IntersectsWith(leftboundry.Bounds) Then
            tmrleft.Stop()
        End If
        If Keys.Right.Down = True And Not picplayer.Bounds.IntersectsWith(rightboundry.Bounds) Then
            tmrright.Start()
        End If
        If Keys.Left.Down = True And Not picplayer.Bounds.IntersectsWith(rightboundry.Bounds) Then
            tmrleft.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrright.Tick
        picplayer.Left += movespeed
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                tmrright.Stop()
            Case Keys.Left
                tmrleft.Stop()
            Case Keys.Up
                tmrup.Stop()
                isjumping = False
        End Select
    End Sub

    Private Sub tmrleft_Tick(sender As Object, e As EventArgs) Handles tmrleft.Tick
        picplayer.Left -= movespeed
    End Sub

    Private Sub tmrup_Tick(sender As Object, e As EventArgs) Handles tmrup.Tick
        picplayer.Top -= movespeed
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrgamelogic.Start()
        TextBox1.Select()
    End Sub

    Private Sub tmrgamelogic_Tick(sender As Object, e As EventArgs) Handles tmrgamelogic.Tick
        If picplayer.Bounds.IntersectsWith(picair.Bounds) Then
            If isjumping = False Then
                tmrgravity.Start()
            End If
        ElseIf picplayer.Bounds.IntersectsWith(picground.Bounds) Then
            tmrgravity.Stop()
        End If
        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If picplayer.Bounds.IntersectsWith(b.Bounds) Then
                        tmrgravity.Stop()
                    End If
                End If
            End If
        Next
        If picplayer.Bounds.IntersectsWith(topboundry.Bounds) Then
            tmrgravity.Start()
        End If
        If picplayer.Bounds.IntersectsWith(rightboundry.Bounds) Then
            tmrright.Stop()
        End If
        If picplayer.Bounds.IntersectsWith(leftboundry.Bounds) Then
            tmrleft.Stop()
        End If
        If picplayer.Bounds.IntersectsWith(coin1.Bounds) And coin1.Visible = True Then
            score = score + 1
            scoretb.Text = score
            coin1.Visible = False
        End If
        If picplayer.Bounds.IntersectsWith(coin2.Bounds) And coin2.Visible = True Then
            score = score + 1
            scoretb.Text = score
            coin2.Visible = False
        End If
        If picplayer.Bounds.IntersectsWith(coin3.Bounds) And coin3.Visible = True Then
            score = score + 1
            scoretb.Text = score
            coin3.Visible = False
        End If
        If picplayer.Bounds.IntersectsWith(coin4.Bounds) And coin4.Visible = True Then
            score = score + 1
            scoretb.Text = score
            coin4.Visible = False
        End If
        If picplayer.Bounds.IntersectsWith(coin5.Bounds) And coin5.Visible = True Then
            score = score + 1
            scoretb.Text = score
            coin5.Visible = False
        End If
        If picplayer.Bounds.IntersectsWith(coin6.Bounds) And coin6.Visible = True Then
            score = score + 1
            scoretb.Text = score
            coin6.Visible = False
        End If
        If nextlevel.Visible = True And picplayer.Bounds.IntersectsWith(nextlevel.Bounds) Then
            level2.ShowDialog()
        End If
        If picplayer.Bounds.IntersectsWith(wizardpb.Bounds) And score < 6 Then

        End If
    End Sub

    Private Sub tmrgravity_Tick(sender As Object, e As EventArgs) Handles tmrgravity.Tick
        picplayer.Top += movespeed
    End Sub
End Class
