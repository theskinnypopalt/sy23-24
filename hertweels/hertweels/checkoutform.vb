Public Class checkoutform
    Private Sub checkoutform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        STHform.Hide()

        If STHform.TextBox1.Text = "1" Then
            carname.Text = "Mercedes-Benz 300SL"
            carpb.Image = ImageList1.Images(0)
            Quantitytb.Text = STHform.checkoutpricetb.Text
            pricetb.Text = STHform.checkoutpricepagetb.Text
        End If
        If STHform.TextBox1.Text = "2" Then
            carname.Text = "Corvette Grand Sport Roadster"
            carpb.Image = ImageList1.Images(1)
            Quantitytb.Text = STHform.checkoutpricetb.Text
            pricetb.Text = STHform.checkoutpricepagetb.Text
        End If
        If STHform.TextBox1.Text = "3" Then
            carname.Text = "Pagani Huayra Roadster"
            carpb.Image = ImageList1.Images(2)
            Quantitytb.Text = STHform.checkoutpricetb.Text
            pricetb.Text = STHform.checkoutpricepagetb.Text
        End If
        If STHform.TextBox1.Text = "4" Then
            carname.Text = "Lamborghini Sesto Elemental"
            carpb.Image = ImageList1.Images(3)
            Quantitytb.Text = STHform.checkoutpricetb.Text
            pricetb.Text = STHform.checkoutpricepagetb.Text
        End If
        If STHform.TextBox1.Text = "5" Then
            carname.Text = "Ford GT40"
            carpb.Image = ImageList1.Images(4)
            Quantitytb.Text = STHform.checkoutpricetb.Text
            pricetb.Text = STHform.checkoutpricepagetb.Text
        End If
        If STHform.TextBox1.Text = "6" Then
            carname.Text = "Ferrari 599XX"
            carpb.Image = ImageList1.Images(5)
            Quantitytb.Text = STHform.checkoutpricetb.Text
            pricetb.Text = STHform.checkoutpricepagetb.Text
        End If
        If STHform.TextBox1.Text = "7" Then
            carname.Text = "Porsche 918 Spyder"
            carpb.Image = ImageList1.Images(6)
            Quantitytb.Text = STHform.checkoutpricetb.Text
            pricetb.Text = STHform.checkoutpricepagetb.Text
        End If
        If STHform.TextBox1.Text = "8" Then
            carname.Text = "Ford Shelby GT500"
            carpb.Image = ImageList1.Images(7)
            Quantitytb.Text = STHform.checkoutpricetb.Text
            pricetb.Text = STHform.checkoutpricepagetb.Text
        End If
        If STHform.TextBox1.Text = "9" Then
            carname.Text = "Lamborghini Miura"
            carpb.Image = ImageList1.Images(8)
            Quantitytb.Text = STHform.checkoutpricetb.Text
            pricetb.Text = STHform.checkoutpricepagetb.Text
        End If
        If STHform.TextBox1.Text = "10" Then
            carname.Text = "Ford RS2000"
            carpb.Image = ImageList1.Images(9)
            Quantitytb.Text = STHform.checkoutpricetb.Text
            pricetb.Text = STHform.checkoutpricepagetb.Text
        End If
        If STHform.TextBox1.Text = "11" Then
            carname.Text = "Camaro SS"
            carpb.Image = ImageList1.Images(10)
            Quantitytb.Text = STHform.checkoutpricetb.Text
            pricetb.Text = STHform.checkoutpricepagetb.Text
        End If
        If STHform.TextBox1.Text = "12" Then
            carname.Text = "Lamborghini Miura Edtion"
            carpb.Image = ImageList1.Images(11)
            Quantitytb.Text = STHform.checkoutpricetb.Text
            pricetb.Text = STHform.checkoutpricepagetb.Text
        End If
        If mainlineform.idtextbox.Text = "13" Then
            carname.Text = "Nissan GT-R"
            carpb.Image = ImageList1.Images(0)
            Quantitytb.Text = mainlineform.pricetb.Text
            pricetb.Text = mainlineform.quantitytb.Text
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        STHform.Show()
        Me.Hide()
    End Sub
End Class