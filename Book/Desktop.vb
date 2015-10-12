Public Class Desktop

    Private Sub Desktop_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Registro.Close() ' Cierra Formulario Register
        Splash.Close()
    End Sub

    Private Sub MicrosoftWordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MicrosoftWordToolStripMenuItem.Click
        Dim w As New Word  ' Creacion de Variable que tomara las propiedades del Objeto Word
        w.MdiParent = Me  ' Asignamos control primario
        w.Show()  ' Mostramos el Formulario
    End Sub

    Private Sub AbrirMicrosoftWordToolStripMenuItem_Click(sender As Object, e As EventArgs)
        GetAttr("C:\Program Files\Microsoft Office\Office15\WINWORD.exe")
        Shell("C:\Program Files\Microsoft Office\Office15\WINWORD.exe")
    End Sub

    Private Sub Desktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class