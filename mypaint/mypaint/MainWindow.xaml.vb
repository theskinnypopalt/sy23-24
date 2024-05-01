Class MainWindow
    Private Sub drawingCanvas_MouseMove(sender As Object, e As MouseEventArgs) Handles drawingCanvas.MouseMove
        Dim el As New Ellipse
        el.Width = widthSlider.Value
        el.Height = heightSlider.Value
        el.Fill = color1Rectangle.Fill

        Dim p As Point = Mouse.GetPosition(drawingCanvas)
        Canvas.SetLeft(el, p.X)
        Canvas.SetTop(el, p.Y)
        If e.MouseDevice.LeftButton = MouseButtonState.Pressed Then
            mainCanvas.Children.Add(el)
        End If
    End Sub

    Private Sub color1Rectangle_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles color1Rectangle.MouseDown, color2rectangle.MouseDown, color3rectangle.MouseDown, color4rectangle.MouseDown, color5rectangle.MouseDown, color6rectangle.MouseDown
        color1Rectangle.Fill = sender.fill
    End Sub

    Private Sub clearbutton_Click(sender As Object, e As RoutedEventArgs) Handles clearbutton.Click
        mainCanvas.Children.RemoveRange(1, mainCanvas.Children.Count - 1)
    End Sub

    Private Sub undobutton_Click(sender As Object, e As RoutedEventArgs) Handles undobutton.Click
        mainCanvas.Children.RemoveAt(mainCanvas.Children.Count - 1)
    End Sub

    Private Sub elipsebutton_Click(sender As Object, e As RoutedEventArgs) Handles elipsebutton.Click
        shapelabel.Content = sender.content
    End Sub

    Private Sub rectanglebutton_Click(sender As Object, e As RoutedEventArgs) Handles rectanglebutton.Click
        shapelabel.Content = sender.content
    End Sub
End Class

