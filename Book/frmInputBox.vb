Public Class frmInputBox
    Private clave As String

    Public Property obtenerClave As String
        Get
            Return clave
        End Get
        Set(value As String)
            clave = value
        End Set

    End Property

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        obtenerClave = txtMaster.Text
        Me.Close()
    End Sub
End Class