<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.vLabelUsuario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.vTextUsuario = New System.Windows.Forms.TextBox()
        Me.vTextContraseña = New System.Windows.Forms.TextBox()
        Me.vButtonIngresar = New System.Windows.Forms.Button()
        Me.vLabelRecuperar = New System.Windows.Forms.Label()
        Me.vLabelTitulo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'vLabelUsuario
        '
        Me.vLabelUsuario.AutoSize = True
        Me.vLabelUsuario.BackColor = System.Drawing.Color.Transparent
        Me.vLabelUsuario.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLabelUsuario.Location = New System.Drawing.Point(47, 115)
        Me.vLabelUsuario.Name = "vLabelUsuario"
        Me.vLabelUsuario.Size = New System.Drawing.Size(55, 17)
        Me.vLabelUsuario.TabIndex = 1
        Me.vLabelUsuario.Text = "Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Contraseña"
        '
        'vTextUsuario
        '
        Me.vTextUsuario.Font = New System.Drawing.Font("Leelawadee UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vTextUsuario.Location = New System.Drawing.Point(50, 135)
        Me.vTextUsuario.Name = "vTextUsuario"
        Me.vTextUsuario.Size = New System.Drawing.Size(249, 27)
        Me.vTextUsuario.TabIndex = 3
        '
        'vTextContraseña
        '
        Me.vTextContraseña.Font = New System.Drawing.Font("Leelawadee UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vTextContraseña.Location = New System.Drawing.Point(50, 185)
        Me.vTextContraseña.Name = "vTextContraseña"
        Me.vTextContraseña.Size = New System.Drawing.Size(249, 27)
        Me.vTextContraseña.TabIndex = 4
        Me.vTextContraseña.UseSystemPasswordChar = True
        '
        'vButtonIngresar
        '
        Me.vButtonIngresar.BackColor = System.Drawing.SystemColors.Control
        Me.vButtonIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.vButtonIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.vButtonIngresar.Location = New System.Drawing.Point(305, 135)
        Me.vButtonIngresar.Name = "vButtonIngresar"
        Me.vButtonIngresar.Size = New System.Drawing.Size(95, 77)
        Me.vButtonIngresar.TabIndex = 5
        Me.vButtonIngresar.Text = "Ingresar"
        Me.vButtonIngresar.UseVisualStyleBackColor = False
        '
        'vLabelRecuperar
        '
        Me.vLabelRecuperar.AutoSize = True
        Me.vLabelRecuperar.BackColor = System.Drawing.Color.Transparent
        Me.vLabelRecuperar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.vLabelRecuperar.Font = New System.Drawing.Font("Leelawadee UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLabelRecuperar.Location = New System.Drawing.Point(170, 235)
        Me.vLabelRecuperar.Name = "vLabelRecuperar"
        Me.vLabelRecuperar.Size = New System.Drawing.Size(99, 13)
        Me.vLabelRecuperar.TabIndex = 6
        Me.vLabelRecuperar.Text = "Recuperar Cuenta"
        '
        'vLabelTitulo
        '
        Me.vLabelTitulo.AutoSize = True
        Me.vLabelTitulo.BackColor = System.Drawing.Color.Transparent
        Me.vLabelTitulo.Font = New System.Drawing.Font("Leelawadee UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLabelTitulo.Location = New System.Drawing.Point(59, 28)
        Me.vLabelTitulo.Name = "vLabelTitulo"
        Me.vLabelTitulo.Size = New System.Drawing.Size(334, 37)
        Me.vLabelTitulo.TabIndex = 0
        Me.vLabelTitulo.Text = "CENTRO DE SALUD LIMA"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PowderBlue
        Me.Panel1.Controls.Add(Me.vLabelTitulo)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(445, 91)
        Me.Panel1.TabIndex = 7
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.App_Clínica.My.Resources.Resources.FondoLogin
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(446, 271)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.vLabelRecuperar)
        Me.Controls.Add(Me.vButtonIngresar)
        Me.Controls.Add(Me.vTextContraseña)
        Me.Controls.Add(Me.vTextUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.vLabelUsuario)
        Me.DoubleBuffered = True
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Centro de Salud Lima - Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vLabelUsuario As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents vTextUsuario As TextBox
    Friend WithEvents vTextContraseña As TextBox
    Friend WithEvents vButtonIngresar As Button
    Friend WithEvents vLabelRecuperar As Label
    Friend WithEvents vLabelTitulo As Label
    Friend WithEvents Panel1 As Panel
End Class
