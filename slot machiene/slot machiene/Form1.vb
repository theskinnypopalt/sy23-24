Imports System.Reflection.Emit
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Dim WithEvents CS As New coinslot

    Public Property bankAccount As Decimal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bankAccount = 0
        TextBox1.Text = bankAccount.ToString("C2")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If bankAccount >= 1 Then
            bankAccount -= 1
            TextBox1.Text = bankAccount.ToString("C2")
            slot1.spin()
            slot2.spin()
            slot3.spin()
            Timer1.Enabled = True
        End If
    End Sub
    Public Sub Load_Winnings()
        If slot1.itemvalue = slot2.itemvalue And slot1.itemvalue = slot3.itemvalue And slot2.itemvalue = slot3.itemvalue Then
            bankAccount += 200
            TextBox1.Text = bankAccount.ToString("C2")
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = slot1.itemvalue
        Label2.Text = slot2.itemvalue
        Label3.Text = slot3.itemvalue
        Load_Winnings()
        Timer1.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CS.insertNickles()
        bankAccount = CS.Total
        TextBox1.Text = bankAccount.ToString("C2")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CS.insertDimes()
        bankAccount = CS.Total
        TextBox1.Text = bankAccount.ToString("C2")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CS.insertQuarter()
        bankAccount = CS.Total
        TextBox1.Text = bankAccount.ToString("C2")
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CS.insertDollars()
        bankAccount = CS.Total
        TextBox1.Text = bankAccount.ToString("C2")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        CS.insertten()
        bankAccount = CS.total
        TextBox1.Text = bankAccount
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs)

    End Sub
End Class