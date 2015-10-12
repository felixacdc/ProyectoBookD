Public Class Splash
    Private pict As PictureBox()
    Private count As Integer = 0

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        pict = New PictureBox(19) {PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6, PictureBox7, PictureBox8, PictureBox9, PictureBox10, PictureBox11, PictureBox12, PictureBox13, PictureBox14, PictureBox15, PictureBox16, PictureBox17, PictureBox18, PictureBox19, PictureBox20}
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If count < 20 Then
            pict(count).BackgroundImage = Book.My.Resources.punto2()
            count += 1

            If count <= 1 Then
                lblPercentage.Text = "  " & (count * 5) & "%"
            ElseIf count <= 19 Then
                lblPercentage.Text = " " & (count * 5) & "%"
            Else
                lblPercentage.Text = (count * 5) & "%"
            End If
        Else
            Timer1.Enabled = False
            Me.Hide()
            Dim rg As New Registro()
            rg.Show()
        End If
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub
End Class