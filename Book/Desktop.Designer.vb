<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Desktop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Desktop))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.CursosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MicrosoftWordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MicrosoftExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MicrosoftPowerPointToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MicrosoftAccessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirProgramasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirMicrosoftWordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SkinEngine1 = New Sunisoft.IrisSkin.SkinEngine(CType(Me, System.ComponentModel.Component))
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(681, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CursosToolStripMenuItem, Me.AbrirProgramasToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(681, 24)
        Me.MenuStrip2.TabIndex = 12
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'CursosToolStripMenuItem
        '
        Me.CursosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MicrosoftWordToolStripMenuItem, Me.MicrosoftExcelToolStripMenuItem, Me.MicrosoftPowerPointToolStripMenuItem, Me.MicrosoftAccessToolStripMenuItem})
        Me.CursosToolStripMenuItem.Name = "CursosToolStripMenuItem"
        Me.CursosToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.CursosToolStripMenuItem.Text = "Cursos"
        '
        'MicrosoftWordToolStripMenuItem
        '
        Me.MicrosoftWordToolStripMenuItem.Image = Global.Book.My.Resources.Resources.miniWord
        Me.MicrosoftWordToolStripMenuItem.Name = "MicrosoftWordToolStripMenuItem"
        Me.MicrosoftWordToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.MicrosoftWordToolStripMenuItem.Text = "Microsoft Word"
        '
        'MicrosoftExcelToolStripMenuItem
        '
        Me.MicrosoftExcelToolStripMenuItem.Name = "MicrosoftExcelToolStripMenuItem"
        Me.MicrosoftExcelToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.MicrosoftExcelToolStripMenuItem.Text = "Microsoft Excel"
        '
        'MicrosoftPowerPointToolStripMenuItem
        '
        Me.MicrosoftPowerPointToolStripMenuItem.Name = "MicrosoftPowerPointToolStripMenuItem"
        Me.MicrosoftPowerPointToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.MicrosoftPowerPointToolStripMenuItem.Text = "Microsoft PowerPoint"
        '
        'MicrosoftAccessToolStripMenuItem
        '
        Me.MicrosoftAccessToolStripMenuItem.Name = "MicrosoftAccessToolStripMenuItem"
        Me.MicrosoftAccessToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.MicrosoftAccessToolStripMenuItem.Text = "Microsoft Access"
        '
        'AbrirProgramasToolStripMenuItem
        '
        Me.AbrirProgramasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirMicrosoftWordToolStripMenuItem})
        Me.AbrirProgramasToolStripMenuItem.Name = "AbrirProgramasToolStripMenuItem"
        Me.AbrirProgramasToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.AbrirProgramasToolStripMenuItem.Text = "Abrir Programas"
        '
        'AbrirMicrosoftWordToolStripMenuItem
        '
        Me.AbrirMicrosoftWordToolStripMenuItem.Name = "AbrirMicrosoftWordToolStripMenuItem"
        Me.AbrirMicrosoftWordToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.AbrirMicrosoftWordToolStripMenuItem.Text = "Abrir Microsoft Word"
        '
        'SkinEngine1
        '
        Me.SkinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA=="
        Me.SkinEngine1.SkinFile = Nothing
        Me.SkinEngine1.SkinStreamMain = CType(resources.GetObject("SkinEngine1.SkinStreamMain"), System.IO.Stream)
        '
        'Desktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = Global.Book.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(681, 276)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Desktop"
        Me.Text = "Project Book"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents CursosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MicrosoftWordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MicrosoftExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MicrosoftPowerPointToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MicrosoftAccessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirProgramasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirMicrosoftWordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
End Class
