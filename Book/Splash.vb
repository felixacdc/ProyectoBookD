Public Class Splash
    Private pict As PictureBox()
    Private count As Integer = 0

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        pict = New PictureBox(9) {PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6, PictureBox7, PictureBox8, PictureBox9, PictureBox10, PictureBox11}
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If count < 10 Then
            pict(count).BackgroundImage = Book.My.Resources.Punto2()
            count += 1
            lblLoading.Text = "Loading " & (count * 10) & " %"
        Else
            Timer1.Enabled = False
            Me.Hide()
            Dim lg As New Registro()
            lg.Show()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub
End Class