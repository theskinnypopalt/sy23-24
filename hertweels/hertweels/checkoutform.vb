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
            carpb.Image = ImageList1.Images(12)
            Quantitytb.Text = mainlineform.pricetb.Text
            pricetb.Text = mainlineform.quantitytb.Text
        End If
        If mainlineform.idtextbox.Text = "14" Then
            carname.Text = "Peak Tacoma"
            carpb.Image = ImageList1.Images(13)
            Quantitytb.Text = mainlineform.pricetb.Text
            pricetb.Text = mainlineform.quantitytb.Text
        End If
        If mainlineform.idtextbox.Text = "15" Then
            carname.Text = "Czinger 21C"
            carpb.Image = ImageList1.Images(14)
            Quantitytb.Text = mainlineform.pricetb.Text
            pricetb.Text = mainlineform.quantitytb.Text
        End If
        If mainlineform.idtextbox.Text = "16" Then
            carname.Text = "Saleen S7 Blue"
            carpb.Image = ImageList1.Images(15)
            Quantitytb.Text = mainlineform.pricetb.Text
            pricetb.Text = mainlineform.quantitytb.Text
        End If
        If mainlineform.idtextbox.Text = "17" Then
            carname.Text = "Porsche 911 GT3"
            carpb.Image = ImageList1.Images(16)
            Quantitytb.Text = mainlineform.pricetb.Text
            pricetb.Text = mainlineform.quantitytb.Text
        End If
        If mainlineform.idtextbox.Text = "18" Then
            carname.Text = "GT Scorcher"
            carpb.Image = ImageList1.Images(17)
            Quantitytb.Text = mainlineform.pricetb.Text
            pricetb.Text = mainlineform.quantitytb.Text
        End If
        If mainlineform.idtextbox.Text = "19" Then
            carname.Text = "71 El Camino"
            carpb.Image = ImageList1.Images(18)
            Quantitytb.Text = mainlineform.pricetb.Text
            pricetb.Text = mainlineform.quantitytb.Text
        End If
        If mainlineform.idtextbox.Text = "20" Then
            carname.Text = "81 Camaro"
            carpb.Image = ImageList1.Images(19)
            Quantitytb.Text = mainlineform.pricetb.Text
            pricetb.Text = mainlineform.quantitytb.Text
        End If
        If mainlineform.idtextbox.Text = "21" Then
            carname.Text = "Ice Charger"
            carpb.Image = ImageList1.Images(20)
            Quantitytb.Text = mainlineform.pricetb.Text
            pricetb.Text = mainlineform.quantitytb.Text
        End If
        If mainlineform.idtextbox.Text = "22" Then
            carname.Text = "Lamborghini Diablo"
            carpb.Image = ImageList1.Images(21)
            Quantitytb.Text = mainlineform.pricetb.Text
            pricetb.Text = mainlineform.quantitytb.Text
        End If
        If mainlineform.idtextbox.Text = "23" Then
            carname.Text = "57 Plymouth Fury"
            carpb.Image = ImageList1.Images(22)
            Quantitytb.Text = mainlineform.pricetb.Text
            pricetb.Text = mainlineform.quantitytb.Text
        End If
        If mainlineform.idtextbox.Text = "24" Then
            carname.Text = "10 Pro Stock Camaro"
            carpb.Image = ImageList1.Images(23)
            Quantitytb.Text = mainlineform.pricetb.Text
            pricetb.Text = mainlineform.quantitytb.Text
        End If
        If mainlineform.idtextbox.Text = "25" Then
            carname.Text = "Batman: Arkham Knight Batmobile"
            carpb.Image = ImageList1.Images(24)

            Quantitytb.Text = mainlineform.pricetb.Text
            pricetb.Text = mainlineform.quantitytb.Text
        End If
        If mainlineform.idtextbox.Text = "26" Then
            carname.Text = "16 Bugatti Chiron"
            carpb.Image = ImageList1.Images(25)
            Quantitytb.Text = mainlineform.pricetb.Text
            pricetb.Text = mainlineform.quantitytb.Text
        End If
        If mainlineform.idtextbox.Text = "27" Then
            carname.Text = "The Nash"
            carpb.Image = ImageList1.Images(26)

            Quantitytb.Text = mainlineform.pricetb.Text
            pricetb.Text = mainlineform.quantitytb.Text
        End If
        If mainlineform.idtextbox.Text = "26" Then
            carname.Text = "16 Bugatti Chiron"
            carpb.Image = ImageList1.Images(25)
            Quantitytb.Text = mainlineform.pricetb.Text
            pricetb.Text = mainlineform.quantitytb.Text
        End If
        If mainlineform.idtextbox.Text = "27" Then
            carname.Text = "The Nash"
            carpb.Image = ImageList1.Images(26)
            Quantitytb.Text = mainlineform.pricetb.Text
            pricetb.Text = mainlineform.quantitytb.Text
        End If
        If THform.idtextbox.Text = "28" Then
            carname.Text = "Tesla Roadster"
            carpb.Image = ImageList1.Images(27)
            Quantitytb.Text = THform.quantitytb.Text
            pricetb.Text = THform.pricetb.Text
        End If
        If THform.idtextbox.Text = "29" Then   'copy and paste for kevin'
            carname.Text = "Draftnator"
            carpb.Image = ImageList1.Images(28)
            Quantitytb.Text = THform.quantitytb.Text
            pricetb.Text = THform.pricetb.Text
        End If
        If THform.idtextbox.Text = "30" Then
            carname.Text = "67-Custom Mustang"
            carpb.Image = ImageList1.Images(29)
            Quantitytb.Text = THform.quantitytb.Text
            pricetb.Text = THform.pricetb.Text
        End If
        If THform.idtextbox.Text = "31" Then
            carname.Text = "Pontiac-GTO"
            carpb.Image = ImageList1.Images(30)
            Quantitytb.Text = THform.quantitytb.Text
            pricetb.Text = THform.pricetb.Text
        End If
        If THform.idtextbox.Text = "32" Then
            carname.Text = "Muscle-N-Blown"
            carpb.Image = ImageList1.Images(31)
            Quantitytb.Text = THform.quantitytb.Text
            pricetb.Text = THform.pricetb.Text
        End If
        If THform.idtextbox.Text = "33" Then
            carname.Text = "47-Chevy Fleetline"
            carpb.Image = ImageList1.Images(32)
            Quantitytb.Text = THform.quantitytb.Text
            pricetb.Text = THform.pricetb.Text
        End If
        If THform.idtextbox.Text = "34" Then
            carname.Text = "Duck-N-Roll"
            carpb.Image = ImageList1.Images(33)
            Quantitytb.Text = THform.quantitytb.Text
            pricetb.Text = THform.pricetb.Text
        End If
        If THform.idtextbox.Text = "35" Then
            carname.Text = "65-Ford Galaxie"
            carpb.Image = ImageList1.Images(34)
            Quantitytb.Text = THform.quantitytb.Text
            pricetb.Text = THform.pricetb.Text
        End If
        If THform.idtextbox.Text = "36" Then
            carname.Text = "Mercedes-Benz 504K"
            carpb.Image = ImageList1.Images(35)
            Quantitytb.Text = THform.quantitytb.Text
            pricetb.Text = THform.pricetb.Text
        End If
        If THform.idtextbox.Text = "37" Then
            carname.Text = "Twin-Mill"
            carpb.Image = ImageList1.Images(36)
            Quantitytb.Text = THform.quantitytb.Text
            pricetb.Text = THform.pricetb.Text
        End If
        If THform.idtextbox.Text = "38" Then
            carname.Text = "Mig-Rig"
            carpb.Image = ImageList1.Images(37)
            Quantitytb.Text = THform.quantitytb.Text
            pricetb.Text = THform.pricetb.Text
        End If
        If THform.idtextbox.Text = "39" Then
            carname.Text = "Batman-Car"
            carpb.Image = ImageList1.Images(38)
            Quantitytb.Text = THform.quantitytb.Text
            pricetb.Text = THform.pricetb.Text
        End If
        If rlcform.idtb.Text = "40" Then
            carname.Text = "Porsche 959"
            carpb.Image = ImageList1.Images(39)
            Quantitytb.Text = rlcform.quantitytb.Text
            pricetb.Text = rlcform.pricetb.Text
        End If
        If rlcform.idtb.Text = "41" Then
            carname.Text = "Nissan GT-R R34"
            carpb.Image = ImageList1.Images(40)
            Quantitytb.Text = rlcform.quantitytb.Text
            pricetb.Text = rlcform.pricetb.Text
        End If
        If rlcform.idtb.Text = "42" Then
            carname.Text = "Lamborghini Countach"
            carpb.Image = ImageList1.Images(41)
            Quantitytb.Text = rlcform.quantitytb.Text
            pricetb.Text = rlcform.pricetb.Text
        End If
        If rlcform.idtb.Text = "43" Then
            carname.Text = "McLaren F1"
            carpb.Image = ImageList1.Images(42)
            Quantitytb.Text = rlcform.quantitytb.Text
            pricetb.Text = rlcform.pricetb.Text
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

    Private Sub pricetb_Click(sender As Object, e As EventArgs) Handles pricetb.Click

    End Sub
End Class