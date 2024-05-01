Class MainWindow
    Dim m As Integer
    Dim d As Integer

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        label1.Content = calender1.SelectedDate
        m = calender1.SelectedDate.Value.Month
        d = calender1.SelectedDate.Value.Day
        If m = 3 And d > 20 Or m = 4 And d < 20 Then
            astrosignlabel.Content = "Aries"
            piclabel.Content = "♈️"
        End If
        If m = 4 And d > 20 Or m = 5 And d < 20 Then
            astrosignlabel.Content = "Taurus"
            piclabel.Content = "♉️"
        End If
        If m = 5 And d > 20 Or m = 6 And d < 20 Then
            astrosignlabel.Content = "Gemini"
            piclabel.Content = "♊️"
        End If
        If m = 6 And d > 20 Or m = 7 And d < 22 Then
            astrosignlabel.Content = "Cancer"
            piclabel.Content = "♋️"
        End If
        If m = 7 And d > 23 Or m = 8 And d < 22 Then
            astrosignlabel.Content = "leo"
            piclabel.Content = "♌️"
        End If
        If m = 8 And d > 22 Or m = 9 And d < 22 Then
            astrosignlabel.Content = "Virgo"
            piclabel.Content = "♍️"
        End If
        If m = 9 And d > 22 Or m = 10 And d < 21 Then
            astrosignlabel.Content = "Libra"
            piclabel.Content = "♎️"
        End If
        If m = 10 And d > 21 Or m = 11 And d < 21 Then
            astrosignlabel.Content = "Scorpio"
            piclabel.Content = "♏️"
        End If
        If m = 11 And d > 21 Or m = 12 And d < 21 Then
            astrosignlabel.Content = "Sagittarius"
            piclabel.Content = "♐️"
        End If
        If m = 12 And d > 21 Or m = 1 And d < 19 Then
            astrosignlabel.Content = "Capricorn"
            piclabel.Content = "♑️"
        End If
        If m = 1 And d > 19 Or m = 2 And d < 18 Then
            astrosignlabel.Content = "Aquarius"
            piclabel.Content = "♒️"
        End If
        If m = 2 And d > 18 Or m = 3 And d < 20 Then
            astrosignlabel.Content = "Pisces"
            piclabel.Content = "♓️"
        End If
    End Sub
End Class