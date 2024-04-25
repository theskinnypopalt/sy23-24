Class MainWindow
    Dim m As Integer
    Dim d As Integer

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        label1.Content = calender1.SelectedDate
        m = calender1.SelectedDate.Value.Month
        d = calender1.SelectedDate.Value.Day
        If m = 4 And d > 20 Or m = 5 And d < 20 Then
            astrosignlabel.Content = "Aries"
        End If
    End Sub
End Class
