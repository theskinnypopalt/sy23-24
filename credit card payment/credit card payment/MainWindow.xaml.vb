Class MainWindow
    Private Sub confirm_purchase_button_Click(sender As Object, e As RoutedEventArgs) Handles confirm_purchase_button.Click
        If first_name_textbox.Text = "" Then
            first_name_textbox.Text = "THIS MUST BE FILLED IN!"
        End If
    End Sub
End Class
