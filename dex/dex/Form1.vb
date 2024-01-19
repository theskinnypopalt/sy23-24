Imports System.IO
Imports System.Web

Public Class Form1
    Dim records(50) As String
    Dim count As Integer
    Dim current As Integer
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        nametb.Text = ""
        pricetb.Text = ""
        zerosixtytb.Text = ""
        toptb.Text = ""
        hptb.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveToFile()
    End Sub
    Sub SaveToFile()
        Dim r As String
        r += nametb.Text
        r += "|"
        r += pricetb.Text
        r += "|"
        r += zerosixtytb.Text
        r += "|"
        r += toptb.Text
        r += "|"
        r += hptb.Text
        r += "|"
        r += PictureBox1.ImageLocation
        If count = 0 Then count = 1
        records(current) = r

        Dim outFile As New StreamWriter("data.txt")
        For index = 0 To count - 1
            outFile.WriteLine(records(index))
        Next
        outFile.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists("data.txt") Then
            Dim inFile As New StreamReader("data.txt")
            While (Not inFile.EndOfStream)
                records(count) = inFile.ReadLine
                count = count + 1
            End While
            inFile.Close()
            ShowRecord(0)
        End If
    End Sub
    Public Sub ShowRecord(index As Integer)
        PictureBox1.Image = Nothing
        If records(index) <> Nothing Then
            Dim Fields() As String
            Fields = records(index).Split("|")
            nametb.Text = Fields(0)
            pricetb.Text = Fields(1)
            zerosixtytb.Text = Fields(2)
            toptb.Text = Fields(3)
            hptb.Text = Fields(4)
            If File.Exists(Fields(5)) Then
                PictureBox1.Load(Fields(5))
            End If
        End If
    End Sub

    Private Sub FirstButton_Click(sender As Object, e As EventArgs) Handles firstbutton.Click
        SaveToFile()
        current = 0
        ShowRecord(current)
    End Sub

    Private Sub PrevButton_Click(sender As Object, e As EventArgs) Handles prevbutton.Click
        SaveToFile()
        If current > 0 Then
            current = current - 1
        End If
        ShowRecord(current)
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles nextbutton.Click
        SaveToFile()
        If current < count - 1 Then
            current = current + 1
        End If
        ShowRecord(current)
    End Sub

    Private Sub LastButton_Click(sender As Object, e As EventArgs) Handles lastbutton.Click
        SaveToFile()
        If count > 0 Then
            current = count - 1
            ShowRecord(current)
        End If
    End Sub
End Class