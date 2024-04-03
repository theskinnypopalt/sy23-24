Imports System.Reflection.Emit
Imports System.Windows
Imports System.Windows.Forms.DataFormats

Public Class STH
    Public Property price As Integer

    Public count As Integer
    Public Property picture As Image
    Public Property carname As String
    Public Property ID As Integer

    Dim total As Decimal

    Private Sub quantityupdown_ValueChanged(sender As Object, e As EventArgs) Handles quantityupdown.ValueChanged
        pricelabel.Text = price * quantityupdown.Value
        STHform.checkoutpricetb.Text = quantityupdown.Value
    End Sub

    Private Sub checkoutbutton_Click(sender As Object, e As EventArgs) Handles checkoutbutton.Click
        If quantityupdown.Value >= 1 And STHform.Visible = True Then
            STHform.TextBox1.Text = ID
            STHform.checkoutpricepagetb.Text = pricelabel.Text
            checkoutform.ShowDialog()
            Me.Hide()
            STHform.Hide()
        End If
        If quantityupdown.Value >= 1 And mainlineform.Visible = True Then
            mainlineform.idtextbox.Text = ID
            mainlineform.pricetb.Text = pricelabel.Text
            mainlineform.quantitytb.Text = quantityupdown.Value
            checkoutform.ShowDialog()
            Me.Hide()
            mainlineform.Hide()
        End If
        If quantityupdown.Value >= 1 And THform.Visible = True Then
            THform.idtextbox.Text = ID
            THform.pricetb.Text = pricelabel.Text
            THform.quantitytb.Text = quantityupdown.Value
            checkoutform.ShowDialog()
            Me.Hide()
            THform.Hide()
        End If
        If quantityupdown.Value >= 1 And rlcform.Visible = True Then
            rlcform.idtb.Text = ID
            rlcform.pricetb.Text = pricelabel.Text
            rlcform.quantitytb.Text = quantityupdown.Value
            checkoutform.ShowDialog()
            Me.Hide()
            rlcform.Hide()
        End If
    End Sub

    Private Sub STH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carpb.Image = picture
        namelabel.Text = carname
        pricelabel.Text = price
        If THform.Visible = True Then
            Me.Visible = True
        End If
        If STHform.Visible = True Then
            Me.Visible = True
        End If
        If mainlineform.Visible = True Then
            Me.Visible = True
        End If
    End Sub
End Class
