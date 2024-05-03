Imports Microsoft.Win32
Imports System.IO
Imports System.Windows.form
Class MainWindow
    Dim c1 As Color
    Dim c2 As Color

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

    Private Sub angleslider_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double)) Handles angleslider.ValueChanged
        color1Rectangle.Fill = New LinearGradientBrush(c1, c2, angleslider.Value)
    End Sub

    Public Sub ExportToPng(ByVal surface As Canvas)

        Dim sfd As New SaveFileDialog

        sfd.ShowDialog()

        If sfd.FileName Is Nothing Then Return

        Dim transform As Transform = surface.LayoutTransform

        surface.LayoutTransform = Nothing

        Dim size As Size = New Size(surface.Width, surface.Height)

        surface.Measure(size)

        surface.Arrange(New Rect(size))

        Dim renderBitmap As RenderTargetBitmap = New RenderTargetBitmap(CInt(size.Width), CInt(size.Height), 96.0R, 96.0R, PixelFormats.Pbgra32)

        renderBitmap.Render(surface)



        Using outStream As FileStream = New FileStream(sfd.FileName & ".png", FileMode.Create)

            Dim encoder As PngBitmapEncoder = New PngBitmapEncoder()

            encoder.Frames.Add(BitmapFrame.Create(renderBitmap))

            encoder.Save(outStream)

        End Using



        surface.LayoutTransform = transform

        Canvas.SetLeft(drawingCanvas, 5)

        Canvas.SetTop(drawingCanvas, 10)

    End Sub


    Private Sub grad1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles grad1.MouseDown
        grad1.Fill = New SolidColorBrush(Color.FromRgb(rslider.Value, gslider.Value, bslider.Value))
        c1 = (Color.FromRgb(rslider.Value, gslider.Value, bslider.Value))
    End Sub

    Private Sub grad2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles grad2.MouseDown
        grad2.Fill = New SolidColorBrush(Color.FromRgb(rslider.Value, gslider.Value, bslider.Value))
        c2 = (Color.FromRgb(rslider.Value, gslider.Value, bslider.Value))
    End Sub
End Class

