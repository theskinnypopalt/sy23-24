Imports System.IO

Class MainWindow


    Private Sub clearbutton_Click(sender As Object, e As RoutedEventArgs) Handles clearbutton.Click
        usdtb.Text = ""
        convertedtb.Text = ""

    End Sub

    Private Sub yenbutton_Click(sender As Object, e As RoutedEventArgs) Handles yenbutton.Click
        Dim usd As Boolean = (usdtb.Text Like "#") OrElse (usdtb.Text Like "##") OrElse (usdtb.Text Like "###") OrElse (usdtb.Text Like "####") OrElse (usdtb.Text Like "#####") OrElse (usdtb.Text Like "######") OrElse (usdtb.Text Like "#######") OrElse (usdtb.Text Like "########") OrElse (usdtb.Text Like "#########") OrElse (usdtb.Text Like "##########") OrElse (usdtb.Text Like "###########") OrElse (usdtb.Text Like "############") OrElse (usdtb.Text Like "#############") OrElse (usdtb.Text Like "##############") OrElse (usdtb.Text Like "##############")
        If usd = True Then
            convertedtb.Text = usdtb.Text * 154.77
            convertedlabel.Content = "Yen:  ¥"
            multiblierlabel.Content = "154.77 X USD"
        End If
    End Sub

    Private Sub eurobutton_Click(sender As Object, e As RoutedEventArgs) Handles eurobutton.Click
        Dim usd As Boolean = (usdtb.Text Like "#") OrElse (usdtb.Text Like "##") OrElse (usdtb.Text Like "###") OrElse (usdtb.Text Like "####") OrElse (usdtb.Text Like "#####") OrElse (usdtb.Text Like "######") OrElse (usdtb.Text Like "#######") OrElse (usdtb.Text Like "########") OrElse (usdtb.Text Like "#########") OrElse (usdtb.Text Like "##########") OrElse (usdtb.Text Like "###########") OrElse (usdtb.Text Like "############") OrElse (usdtb.Text Like "#############") OrElse (usdtb.Text Like "##############") OrElse (usdtb.Text Like "##############")
        If usd = True Then
            convertedtb.Text = usdtb.Text * 0.93
            convertedlabel.Content = "Euro €"
            multiblierlabel.Content = "0.93 X USD"
        End If
    End Sub

    Private Sub Austrailiandollarbutton_Click(sender As Object, e As RoutedEventArgs) Handles Austrailiandollarbutton.Click
        Dim usd As Boolean = (usdtb.Text Like "#") OrElse (usdtb.Text Like "##") OrElse (usdtb.Text Like "###") OrElse (usdtb.Text Like "####") OrElse (usdtb.Text Like "#####") OrElse (usdtb.Text Like "######") OrElse (usdtb.Text Like "#######") OrElse (usdtb.Text Like "########") OrElse (usdtb.Text Like "#########") OrElse (usdtb.Text Like "##########") OrElse (usdtb.Text Like "###########") OrElse (usdtb.Text Like "############") OrElse (usdtb.Text Like "#############") OrElse (usdtb.Text Like "##############") OrElse (usdtb.Text Like "##############")
        If usd = True Then
            convertedtb.Text = usdtb.Text * 1.54
            convertedlabel.Content = "Austrailian Dollar $"
            multiblierlabel.Content = "1.54 X USD"
        End If
    End Sub

    Private Sub Canadiandollarbutton_Click(sender As Object, e As RoutedEventArgs) Handles Canadiandollarbutton.Click
        Dim usd As Boolean = (usdtb.Text Like "#") OrElse (usdtb.Text Like "##") OrElse (usdtb.Text Like "###") OrElse (usdtb.Text Like "####") OrElse (usdtb.Text Like "#####") OrElse (usdtb.Text Like "######") OrElse (usdtb.Text Like "#######") OrElse (usdtb.Text Like "########") OrElse (usdtb.Text Like "#########") OrElse (usdtb.Text Like "##########") OrElse (usdtb.Text Like "###########") OrElse (usdtb.Text Like "############") OrElse (usdtb.Text Like "#############") OrElse (usdtb.Text Like "##############") OrElse (usdtb.Text Like "##############")
        If usd = True Then
            convertedtb.Text = usdtb.Text * 1.37
            convertedlabel.Content = "Canadian Dollar $"
            multiblierlabel.Content = "1.37 X USD"
        End If
    End Sub

    Private Sub wonbutton_Click(sender As Object, e As RoutedEventArgs) Handles wonbutton.Click
        Dim usd As Boolean = (usdtb.Text Like "#") OrElse (usdtb.Text Like "##") OrElse (usdtb.Text Like "###") OrElse (usdtb.Text Like "####") OrElse (usdtb.Text Like "#####") OrElse (usdtb.Text Like "######") OrElse (usdtb.Text Like "#######") OrElse (usdtb.Text Like "########") OrElse (usdtb.Text Like "#########") OrElse (usdtb.Text Like "##########") OrElse (usdtb.Text Like "###########") OrElse (usdtb.Text Like "############") OrElse (usdtb.Text Like "#############") OrElse (usdtb.Text Like "##############") OrElse (usdtb.Text Like "##############")
        If usd = True Then
            convertedtb.Text = usdtb.Text * 1373.8
            convertedlabel.Content = "South Korean won ₩"
            multiblierlabel.Content = "1373.80 X USD"
        End If
    End Sub

    Private Sub Newzelanddollarbutton_Click(sender As Object, e As RoutedEventArgs) Handles Newzelanddollarbutton.Click
        Dim usd As Boolean = (usdtb.Text Like "#") OrElse (usdtb.Text Like "##") OrElse (usdtb.Text Like "###") OrElse (usdtb.Text Like "####") OrElse (usdtb.Text Like "#####") OrElse (usdtb.Text Like "######") OrElse (usdtb.Text Like "#######") OrElse (usdtb.Text Like "########") OrElse (usdtb.Text Like "#########") OrElse (usdtb.Text Like "##########") OrElse (usdtb.Text Like "###########") OrElse (usdtb.Text Like "############") OrElse (usdtb.Text Like "#############") OrElse (usdtb.Text Like "##############") OrElse (usdtb.Text Like "##############")
        If usd = True Then
            convertedtb.Text = usdtb.Text * 1.69
            convertedlabel.Content = "New Zealand Dollar $"
            multiblierlabel.Content = "1.69 X USD"
        End If
    End Sub
End Class
