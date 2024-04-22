Class MainWindow
    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        confirm_purchase_button.Visibility = False
    End Sub
    Private Sub clearbutton_Click(sender As Object, e As RoutedEventArgs) Handles clearbutton.Click
        first_name_textbox.Text = ""
        last_name_textbox.Text = ""
        address_textbox.Text = ""
        phone_text_box.Text = ""
        card_number_textbox.Text = ""
        ccv_textbox.Text = ""
        exp_date_textbox.Text = ""
    End Sub
    Private Sub phone_text_box_TextChanged(sender As Object, e As TextChangedEventArgs) Handles phone_text_box.TextChanged
        Dim phonenumber As Boolean = (phone_text_box.Text Like "(###)###-####") OrElse (phone_text_box.Text Like "##########")
        Dim firstname As Boolean = (first_name_textbox.Text Like "*")
        Dim lastname As Boolean = (last_name_textbox.Text Like "*")
        Dim address As Boolean = (address_textbox.Text Like "*")
        Dim cardnumber As Boolean = (card_number_textbox.Text Like "################")
        Dim ccv As Boolean = (ccv_textbox.Text Like "###")
        Dim expdate As Boolean = (exp_date_textbox.Text Like "#/##") OrElse (exp_date_textbox.Text Like "##/##")
        If firstname = True And phonenumber = True And lastname = True And address = True And cardnumber = True And
         ccv = True And expdate = True Then
            confirm_purchase_button.IsEnabled = True
        End If
    End Sub

    Private Sub first_name_textbox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles first_name_textbox.TextChanged
        Dim phonenumber As Boolean = (phone_text_box.Text Like "(###)###-####") OrElse (phone_text_box.Text Like "##########")
        Dim firstname As Boolean = (first_name_textbox.Text Like "*")
        Dim lastname As Boolean = (last_name_textbox.Text Like "*")
        Dim address As Boolean = (address_textbox.Text Like "*")
        Dim cardnumber As Boolean = (card_number_textbox.Text Like "################")
        Dim ccv As Boolean = (ccv_textbox.Text Like "###")
        Dim expdate As Boolean = (exp_date_textbox.Text Like "#/##") OrElse (exp_date_textbox.Text Like "##/##")
        If firstname = True And phonenumber = True And lastname = True And address = True And cardnumber = True And
         ccv = True And expdate = True Then
            confirm_purchase_button.IsEnabled = True
        End If
    End Sub

    Private Sub last_name_textbox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles last_name_textbox.TextChanged
        Dim phonenumber As Boolean = (phone_text_box.Text Like "(###)###-####") OrElse (phone_text_box.Text Like "##########")
        Dim firstname As Boolean = (first_name_textbox.Text Like "*")
        Dim lastname As Boolean = (last_name_textbox.Text Like "*")
        Dim address As Boolean = (address_textbox.Text Like "*")
        Dim cardnumber As Boolean = (card_number_textbox.Text Like "################")
        Dim ccv As Boolean = (ccv_textbox.Text Like "###")
        Dim expdate As Boolean = (exp_date_textbox.Text Like "#/##") OrElse (exp_date_textbox.Text Like "##/##")
        If firstname = True And phonenumber = True And lastname = True And address = True And cardnumber = True And
         ccv = True And expdate = True Then
            confirm_purchase_button.IsEnabled = True
        End If
    End Sub

    Private Sub address_textbox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles address_textbox.TextChanged
        Dim phonenumber As Boolean = (phone_text_box.Text Like "(###)###-####") OrElse (phone_text_box.Text Like "##########")
        Dim firstname As Boolean = (first_name_textbox.Text Like "*")
        Dim lastname As Boolean = (last_name_textbox.Text Like "*")
        Dim address As Boolean = (address_textbox.Text Like "*")
        Dim cardnumber As Boolean = (card_number_textbox.Text Like "################")
        Dim ccv As Boolean = (ccv_textbox.Text Like "###")
        Dim expdate As Boolean = (exp_date_textbox.Text Like "#/##") OrElse (exp_date_textbox.Text Like "##/##")
        If firstname = True And phonenumber = True And lastname = True And address = True And cardnumber = True And
         ccv = True And expdate = True Then
            confirm_purchase_button.IsEnabled = True
        End If
    End Sub

    Private Sub card_number_textbox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles card_number_textbox.TextChanged
        Dim phonenumber As Boolean = (phone_text_box.Text Like "(###)###-####") OrElse (phone_text_box.Text Like "##########")
        Dim firstname As Boolean = (first_name_textbox.Text Like "*")
        Dim lastname As Boolean = (last_name_textbox.Text Like "*")
        Dim address As Boolean = (address_textbox.Text Like "*")
        Dim cardnumber As Boolean = (card_number_textbox.Text Like "################")
        Dim ccv As Boolean = (ccv_textbox.Text Like "###")
        Dim expdate As Boolean = (exp_date_textbox.Text Like "#/##") OrElse (exp_date_textbox.Text Like "##/##")
        If firstname = True And phonenumber = True And lastname = True And address = True And cardnumber = True And
         ccv = True And expdate = True Then
            confirm_purchase_button.IsEnabled = True
        End If
    End Sub

    Private Sub ccv_textbox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles ccv_textbox.TextChanged
        Dim phonenumber As Boolean = (phone_text_box.Text Like "(###)###-####") OrElse (phone_text_box.Text Like "##########")
        Dim firstname As Boolean = (first_name_textbox.Text Like "*")
        Dim lastname As Boolean = (last_name_textbox.Text Like "*")
        Dim address As Boolean = (address_textbox.Text Like "*")
        Dim cardnumber As Boolean = (card_number_textbox.Text Like "################")
        Dim ccv As Boolean = (ccv_textbox.Text Like "###")
        Dim expdate As Boolean = (exp_date_textbox.Text Like "#/##") OrElse (exp_date_textbox.Text Like "##/##")
        If firstname = True And phonenumber = True And lastname = True And address = True And cardnumber = True And
         ccv = True And expdate = True Then
            confirm_purchase_button.IsEnabled = True
        End If
    End Sub

    Private Sub exp_date_textbox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles exp_date_textbox.TextChanged
        Dim phonenumber As Boolean = (phone_text_box.Text Like "(###)###-####") OrElse (phone_text_box.Text Like "##########")
        Dim firstname As Boolean = (first_name_textbox.Text Like "*")
        Dim lastname As Boolean = (last_name_textbox.Text Like "*")
        Dim address As Boolean = (address_textbox.Text Like "*")
        Dim cardnumber As Boolean = (card_number_textbox.Text Like "################")
        Dim ccv As Boolean = (ccv_textbox.Text Like "###")
        Dim expdate As Boolean = (exp_date_textbox.Text Like "#/##") OrElse (exp_date_textbox.Text Like "##/##")
        If firstname = True And phonenumber = True And lastname = True And address = True And cardnumber = True And
         ccv = True And expdate = True Then
            confirm_purchase_button.IsEnabled = True
        End If
    End Sub
End Class
