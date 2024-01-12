﻿Imports System.IO

Public Class Form1
    Dim records(50) As String
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim outFile As New IO.StreamWriter("data.txt")
        outFile.Write(nametb.Text)
        outFile.Write("|")
        outFile.Write(pricetb.Text)
        outFile.Write("|")
        outFile.Write(zerosixtytb.Text)
        outFile.Write("|")
        outFile.Write(toptb.Text)
        outFile.Write("|")
        outFile.Write(hptb.Text)
        outFile.Write("|")
        outFile.Write(PictureBox1.ImageLocation)
        outFile.WriteLine()
        outFile.Close()
    End Sub

    Private Sub NewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem1.Click
        PictureBox1.Image = Nothing
        nametb.Text = ""
        pricetb.Text = ""
        zerosixtytb.Text = ""
        toptb.Text = ""
        hptb.Text = ""

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim inFile As New StreamReader("data.txt")
        If IO.File.Exists("data.txt") Then
            records(0) = inFile.ReadLine
            records(1) = inFile.ReadLine
            inFile.Close()
        End If

    End Sub
End Class
