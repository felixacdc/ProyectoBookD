<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro))
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblBienvenido = New System.Windows.Forms.Label()
        Me.btnRegistro = New System.Windows.Forms.Button()
        Me.txtSerial = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblSerial = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblClose
        '
        resources.ApplyResources(Me.lblClose, "lblClose")
        Me.lblClose.BackColor = System.Drawing.Color.Transparent
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Name = "lblClose"
        '
        'lblBienvenido
        '
        resources.ApplyResources(Me.lblBienvenido, "lblBienvenido")
        Me.lblBienvenido.BackColor = System.Drawing.Color.Transparent
        Me.lblBienvenido.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblBienvenido.Name = "lblBienvenido"
        '
        'btnRegistro
        '
        resources.ApplyResources(Me.btnRegistro, "btnRegistro")
        Me.btnRegistro.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.UseVisualStyleBackColor = True
        '
        'txtSerial
        '
        resources.ApplyResources(Me.txtSerial, "txtSerial")
        Me.txtSerial.Name = "txtSerial"
        '
        'txtPassword
        '
        resources.ApplyResources(Me.txtPassword, "txtPassword")
        Me.txtPassword.Name = "txtPassword"
        '
        'txtUsuario
        '
        resources.ApplyResources(Me.txtUsuario, "txtUsuario")
        Me.txtUsuario.Name = "txtUsuario"
        '
        'lblSerial
        '
        resources.ApplyResources(Me.lblSerial, "lblSerial")
        Me.lblSerial.BackColor = System.Drawing.Color.Transparent
        Me.lblSerial.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblSerial.Name = "lblSerial"
        '
        'lblPassword
        '
        resources.ApplyResources(Me.lblPassword, "lblPassword")
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblPassword.Name = "lblPassword"
        '
        'lblUsuario
        '
        resources.ApplyResources(Me.lblUsuario, "lblUsuario")
        Me.lblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuario.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblUsuario.Name = "lblUsuario"
        '
        'Registro
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Book.My.Resources.Resources.register
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblBienvenido)
        Me.Controls.Add(Me.btnRegistro)
        Me.Controls.Add(Me.txtSerial)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblSerial)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents lblBienvenido As System.Windows.Forms.Label
    Friend WithEvents btnRegistro As System.Windows.Forms.Button
    Friend WithEvents txtSerial As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblSerial As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
End Class
