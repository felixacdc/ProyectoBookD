﻿Public Class Splash
    Private pict As PictureBox()
    Private count As Integer = 0

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        pict = New PictureBox(4) {PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5}
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If count < 5 Then
            pict(count).BackgroundImage = Book.My.Resources.Punto2
            count += 1
            Loading.Text = "Loading " & (count * 20) & " %"
        Else
            Timer1.Enabled = False
            Me.Hide()
            Dim pr As New frmContenidos()
            pr.Show()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub
End Class
