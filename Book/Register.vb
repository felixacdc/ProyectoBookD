Public Class Register
    Private clave As String = "A1B2C3"
    Private serial As String
    Private pict As PictureBox()

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        serial = txtSerial.Text

        If serial = clave Then
            PictureBox1.BackgroundImage = Book.My.Resources.Punto2

        End If
    End Sub
End Class