<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splash))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblPercentage = New System.Windows.Forms.Label()
        Me.lblLoading = New System.Windows.Forms.Label()
        Me.PictureBox20 = New System.Windows.Forms.PictureBox()
        Me.PictureBox19 = New System.Windows.Forms.PictureBox()
        Me.PictureBox18 = New System.Windows.Forms.PictureBox()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.Transparent
        Me.lblClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(448, 9)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(17, 16)
        Me.lblClose.TabIndex = 50
        Me.lblClose.Text = "X"
        '
        'lblPercentage
        '
        Me.lblPercentage.AutoSize = True
        Me.lblPercentage.BackColor = System.Drawing.Color.Transparent
        Me.lblPercentage.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentage.ForeColor = System.Drawing.Color.White
        Me.lblPercentage.Location = New System.Drawing.Point(382, 214)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(87, 31)
        Me.lblPercentage.TabIndex = 49
        Me.lblPercentage.Text = "000%"
        Me.lblPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPercentage.UseMnemonic = False
        '
        'lblLoading
        '
        Me.lblLoading.AutoSize = True
        Me.lblLoading.BackColor = System.Drawing.Color.Transparent
        Me.lblLoading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoading.ForeColor = System.Drawing.Color.White
        Me.lblLoading.Location = New System.Drawing.Point(314, 216)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(73, 20)
        Me.lblLoading.TabIndex = 48
        Me.lblLoading.Text = "Loading"
        '
        'PictureBox20
        '
        Me.PictureBox20.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox20.BackgroundImage = CType(resources.GetObject("PictureBox20.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox20.Location = New System.Drawing.Point(450, 202)
        Me.PictureBox20.Name = "PictureBox20"
        Me.PictureBox20.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox20.TabIndex = 47
        Me.PictureBox20.TabStop = False
        '
        'PictureBox19
        '
        Me.PictureBox19.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox19.BackgroundImage = CType(resources.GetObject("PictureBox19.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox19.Location = New System.Drawing.Point(434, 202)
        Me.PictureBox19.Name = "PictureBox19"
        Me.PictureBox19.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox19.TabIndex = 46
        Me.PictureBox19.TabStop = False
        '
        'PictureBox18
        '
        Me.PictureBox18.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox18.BackgroundImage = CType(resources.GetObject("PictureBox18.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox18.Location = New System.Drawing.Point(418, 202)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox18.TabIndex = 45
        Me.PictureBox18.TabStop = False
        '
        'PictureBox17
        '
        Me.PictureBox17.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox17.BackgroundImage = CType(resources.GetObject("PictureBox17.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox17.Location = New System.Drawing.Point(402, 202)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox17.TabIndex = 44
        Me.PictureBox17.TabStop = False
        '
        'PictureBox16
        '
        Me.PictureBox16.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox16.BackgroundImage = CType(resources.GetObject("PictureBox16.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox16.Location = New System.Drawing.Point(386, 202)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox16.TabIndex = 43
        Me.PictureBox16.TabStop = False
        '
        'PictureBox15
        '
        Me.PictureBox15.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox15.BackgroundImage = CType(resources.GetObject("PictureBox15.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox15.Location = New System.Drawing.Point(370, 202)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox15.TabIndex = 42
        Me.PictureBox15.TabStop = False
        '
        'PictureBox14
        '
        Me.PictureBox14.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox14.BackgroundImage = CType(resources.GetObject("PictureBox14.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox14.Location = New System.Drawing.Point(354, 202)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox14.TabIndex = 41
        Me.PictureBox14.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox13.BackgroundImage = CType(resources.GetObject("PictureBox13.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox13.Location = New System.Drawing.Point(338, 202)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox13.TabIndex = 40
        Me.PictureBox13.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox12.BackgroundImage = CType(resources.GetObject("PictureBox12.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(322, 202)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox12.TabIndex = 39
        Me.PictureBox12.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox11.BackgroundImage = CType(resources.GetObject("PictureBox11.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(306, 202)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox11.TabIndex = 38
        Me.PictureBox11.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.BackgroundImage = CType(resources.GetObject("PictureBox10.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(290, 202)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox10.TabIndex = 37
        Me.PictureBox10.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.BackgroundImage = CType(resources.GetObject("PictureBox9.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(274, 202)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox9.TabIndex = 36
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(258, 202)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox8.TabIndex = 35
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(242, 202)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox7.TabIndex = 34
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(226, 202)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox6.TabIndex = 33
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(210, 202)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox5.TabIndex = 32
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(194, 202)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox4.TabIndex = 31
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(178, 202)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox3.TabIndex = 30
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(162, 202)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(146, 202)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImage = Global.Book.My.Resources.Resources.portadaMiniatura
        Me.ClientSize = New System.Drawing.Size(465, 256)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblPercentage)
        Me.Controls.Add(Me.lblLoading)
        Me.Controls.Add(Me.PictureBox20)
        Me.Controls.Add(Me.PictureBox19)
        Me.Controls.Add(Me.PictureBox18)
        Me.Controls.Add(Me.PictureBox17)
        Me.Controls.Add(Me.PictureBox16)
        Me.Controls.Add(Me.PictureBox15)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Splash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.DimGray
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents lblPercentage As System.Windows.Forms.Label
    Friend WithEvents lblLoading As System.Windows.Forms.Label
    Friend WithEvents PictureBox20 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox19 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox18 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox17 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox16 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox15 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox14 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
