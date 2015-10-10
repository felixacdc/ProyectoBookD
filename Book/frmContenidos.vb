Public Class frmContenidos

    Private Sub frmContenidos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Registro.Close()
    End Sub

    Private Sub limpiar()
        RBp101.ForeColor = Color.Black
        RBp102.ForeColor = Color.Black
        RBp103.ForeColor = Color.Black

        RBp11.ForeColor = Color.Black
        RBp12.ForeColor = Color.Black
        RBp13.ForeColor = Color.Black

        RBp21.ForeColor = Color.Black
        RBp22.ForeColor = Color.Black
        RBp23.ForeColor = Color.Black

        RBp31.ForeColor = Color.Black
        RBp32.ForeColor = Color.Black
        RBp33.ForeColor = Color.Black

        RBp41.ForeColor = Color.Black
        RBp42.ForeColor = Color.Black
        RBp43.ForeColor = Color.Black

        RBp51.ForeColor = Color.Black
        RBp52.ForeColor = Color.Black
        RBp53.ForeColor = Color.Black

        RBp61.ForeColor = Color.Black
        RBp62.ForeColor = Color.Black
        RBp63.ForeColor = Color.Black

        RBp71.ForeColor = Color.Black
        RBp72.ForeColor = Color.Black
        RBp73.ForeColor = Color.Black

        RBp81.ForeColor = Color.Black
        RBp82.ForeColor = Color.Black
        RBp83.ForeColor = Color.Black

        RBp91.ForeColor = Color.Black
        RBp92.ForeColor = Color.Black
        RBp93.ForeColor = Color.Black

    End Sub
    Private Sub Validar()
        Dim Punteo As Integer = 0
        Dim contadorC As Integer = 0

        If (RBp11.Checked = False And RBp12.Checked = False And RBp13.Checked = False) Or
            (RBp21.Checked = False And RBp22.Checked = False And RBp23.Checked = False) Or
            (RBp31.Checked = False And RBp32.Checked = False And RBp33.Checked = False) Or
            (RBp41.Checked = False And RBp42.Checked = False And RBp43.Checked = False) Or
            (RBp51.Checked = False And RBp52.Checked = False And RBp53.Checked = False) Or
            (RBp61.Checked = False And RBp62.Checked = False And RBp63.Checked = False) Or
            (RBp71.Checked = False And RBp72.Checked = False And RBp73.Checked = False) Or
            (RBp81.Checked = False And RBp82.Checked = False And RBp83.Checked = False) Or
            (RBp91.Checked = False And RBp92.Checked = False And RBp93.Checked = False) Or
            (RBp101.Checked = False And RBp102.Checked = False And RBp103.Checked = False) Then
            MsgBox("No Deje Preguntas Sin Responder", MsgBoxStyle.Information, "Evaluacion")
        Else
            limpiar()

            If RBp11.Checked = True Then
                Punteo = Punteo + 10
                RBp11.ForeColor = Color.FromArgb(3, 110, 3)
            ElseIf RBp12.Checked = True Then
                RBp12.ForeColor = Color.FromArgb(202, 12, 12)
                RBp11.ForeColor = Color.FromArgb(106, 73, 254)
            Else
                RBp13.ForeColor = Color.FromArgb(202, 12, 12)
                RBp11.ForeColor = Color.FromArgb(106, 73, 254)
            End If

            If RBp22.Checked = True Then
                Punteo = Punteo + 10
                RBp22.ForeColor = Color.FromArgb(3, 110, 3)
            ElseIf RBp21.Checked = True Then
                RBp21.ForeColor = Color.FromArgb(202, 12, 12)
                RBp22.ForeColor = Color.FromArgb(106, 73, 254)
            Else
                RBp23.ForeColor = Color.FromArgb(202, 12, 12)
                RBp23.ForeColor = Color.FromArgb(106, 73, 254)
            End If

            If RBp32.Checked = True Then
                Punteo = Punteo + 10
                RBp32.ForeColor = Color.FromArgb(3, 110, 3)
            ElseIf RBp31.Checked = True Then
                RBp31.ForeColor = Color.FromArgb(202, 12, 12)
                RBp32.ForeColor = Color.FromArgb(106, 73, 254)
            Else
                RBp33.ForeColor = Color.FromArgb(202, 12, 12)
                RBp32.ForeColor = Color.FromArgb(106, 73, 254)
            End If

            If RBp41.Checked = True Then
                Punteo = Punteo + 10
                RBp41.ForeColor = Color.FromArgb(3, 110, 3)
            ElseIf RBp42.Checked = True Then
                RBp42.ForeColor = Color.FromArgb(202, 12, 12)
                RBp41.ForeColor = Color.FromArgb(106, 73, 254)
            Else
                RBp43.ForeColor = Color.FromArgb(202, 12, 12)
                RBp41.ForeColor = Color.FromArgb(106, 73, 254)
            End If

            If RBp52.Checked = True Then
                Punteo = Punteo + 10
                RBp52.ForeColor = Color.FromArgb(3, 110, 3)
            ElseIf RBp51.Checked = True Then
                RBp51.ForeColor = Color.FromArgb(202, 12, 12)
                RBp52.ForeColor = Color.FromArgb(106, 73, 254)
            Else
                RBp53.ForeColor = Color.FromArgb(202, 12, 12)
                RBp52.ForeColor = Color.FromArgb(106, 73, 254)
            End If

            If RBp63.Checked = True Then
                Punteo = Punteo + 10
                RBp63.ForeColor = Color.FromArgb(3, 110, 3)
            ElseIf RBp61.Checked = True Then
                RBp61.ForeColor = Color.FromArgb(202, 12, 12)
                RBp63.ForeColor = Color.FromArgb(106, 73, 254)
            Else
                RBp62.ForeColor = Color.FromArgb(202, 12, 12)
                RBp63.ForeColor = Color.FromArgb(106, 73, 254)
            End If

            If RBp73.Checked = True Then
                Punteo = Punteo + 10
                RBp73.ForeColor = Color.FromArgb(3, 110, 3)
            ElseIf RBp71.Checked = True Then
                RBp71.ForeColor = Color.FromArgb(202, 12, 12)
                RBp73.ForeColor = Color.FromArgb(106, 73, 254)
            Else
                RBp72.ForeColor = Color.FromArgb(202, 12, 12)
                RBp73.ForeColor = Color.FromArgb(106, 73, 254)
            End If

            If RBp81.Checked = True Then
                Punteo = Punteo + 10
                RBp81.ForeColor = Color.FromArgb(3, 110, 3)
            ElseIf RBp82.Checked = True Then
                RBp82.ForeColor = Color.FromArgb(202, 12, 12)
                RBp81.ForeColor = Color.FromArgb(106, 73, 254)
            Else
                RBp83.ForeColor = Color.FromArgb(202, 12, 12)
                RBp81.ForeColor = Color.FromArgb(106, 73, 254)
            End If

            If RBp91.Checked = True Then
                Punteo = Punteo + 10
                RBp91.ForeColor = Color.FromArgb(3, 110, 3)
            ElseIf RBp92.Checked = True Then
                RBp92.ForeColor = Color.FromArgb(202, 12, 12)
                RBp91.ForeColor = Color.FromArgb(106, 73, 254)
            Else
                RBp93.ForeColor = Color.FromArgb(202, 12, 12)
                RBp91.ForeColor = Color.FromArgb(106, 73, 254)
            End If

            If RBp101.Checked = True Then
                Punteo = Punteo + 10
                RBp101.ForeColor = Color.FromArgb(3, 110, 3)
            ElseIf RBp102.Checked = True Then
                RBp102.ForeColor = Color.FromArgb(202, 12, 12)
                RBp101.ForeColor = Color.FromArgb(106, 73, 254)
            Else
                RBp103.ForeColor = Color.FromArgb(202, 12, 12)
                RBp101.ForeColor = Color.FromArgb(106, 73, 254)
            End If

            MsgBox("Su punteo es: " & Punteo, MsgBoxStyle.Information, "Puntuacion")
        End If
    End Sub

    Private Sub BtnCalificar_Click(sender As Object, e As EventArgs) Handles BtnCalificar.Click
        Validar()
    End Sub

    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click
        Dim punteo As Object
        Dim contra As New frmInputBox()


        contra.ShowDialog()

        If contra.obtenerClave = "master" Then
            punteo = InputBox("Ingrese la nota del alumno")
            If IsNumeric(punteo) Then
                MsgBox("La nota del alumno es: " & punteo & " puede pasar al siguiente ejercicio")
            Else
                MsgBox("Ingrese un numero para guardar la nota")
            End If
        Else
            MsgBox("Contraseña equivocada", MsgBoxStyle.Information, "Validacion")
        End If
    End Sub
End Class