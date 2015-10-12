Public Class Registro
    Private Sub Register_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        txtPassword.Focus()
    End Sub
    Private Sub Register_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Splash.Close()
    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        If txtUsuario.Text = "ProyectoBook" And txtPassword.Text = "Book2015" And txtSerial.Text = "A1B2C3" Then
            Me.Hide()
            Dim dsk As New Desktop()
            dsk.Show()
        Else
            If txtUsuario.Text = "" And txtPassword.Text = "" And txtSerial.Text = "" Then
                MsgBox("Usuario o Password estan vacios", MsgBoxStyle.Critical, "Error")
            Else
                If txtUsuario.Text = "" Then
                    MsgBox("Ingrese su Usuario", MsgBoxStyle.Critical, "Error")
                Else
                    If txtPassword.Text = "" Then
                        MsgBox("Password esta vacio", MsgBoxStyle.Critical, "Error")
                    Else
                        If txtSerial.Text = "" Then
                            MsgBox("Inserte el Serial del Producto", MsgBoxStyle.Critical, "Error")
                        Else
                            MsgBox("Usuario, Contraseña o Serial Invalido", MsgBoxStyle.Critical, "Error")
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub
End Class