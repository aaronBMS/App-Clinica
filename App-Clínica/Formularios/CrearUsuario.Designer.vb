<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CrearUsuario
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.vButtonSalir = New System.Windows.Forms.Button()
        Me.vLabelID = New System.Windows.Forms.Label()
        Me.vLabelNombre = New System.Windows.Forms.Label()
        Me.vLabelApellido = New System.Windows.Forms.Label()
        Me.vLabelCorreo = New System.Windows.Forms.Label()
        Me.vLabelCargo = New System.Windows.Forms.Label()
        Me.vTextID = New System.Windows.Forms.TextBox()
        Me.vTextNombre = New System.Windows.Forms.TextBox()
        Me.vTextApellido = New System.Windows.Forms.TextBox()
        Me.vTextCorreo = New System.Windows.Forms.TextBox()
        Me.vLabelUsuario = New System.Windows.Forms.Label()
        Me.vLabelContraseña = New System.Windows.Forms.Label()
        Me.vTextUsuario = New System.Windows.Forms.TextBox()
        Me.vTextContraseña = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.vComboCargo = New System.Windows.Forms.ComboBox()
        Me.vPictureFoto = New System.Windows.Forms.PictureBox()
        CType(Me.vPictureFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CREAR USUARIO"
        '
        'vButtonSalir
        '
        Me.vButtonSalir.BackColor = System.Drawing.Color.LightCoral
        Me.vButtonSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vButtonSalir.Location = New System.Drawing.Point(701, 0)
        Me.vButtonSalir.Name = "vButtonSalir"
        Me.vButtonSalir.Size = New System.Drawing.Size(69, 38)
        Me.vButtonSalir.TabIndex = 1
        Me.vButtonSalir.Text = "Salir"
        Me.vButtonSalir.UseVisualStyleBackColor = False
        '
        'vLabelID
        '
        Me.vLabelID.AutoSize = True
        Me.vLabelID.BackColor = System.Drawing.Color.Transparent
        Me.vLabelID.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vLabelID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vLabelID.Location = New System.Drawing.Point(131, 68)
        Me.vLabelID.Name = "vLabelID"
        Me.vLabelID.Size = New System.Drawing.Size(22, 17)
        Me.vLabelID.TabIndex = 2
        Me.vLabelID.Text = "ID"
        '
        'vLabelNombre
        '
        Me.vLabelNombre.AutoSize = True
        Me.vLabelNombre.BackColor = System.Drawing.Color.Transparent
        Me.vLabelNombre.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vLabelNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vLabelNombre.Location = New System.Drawing.Point(131, 124)
        Me.vLabelNombre.Name = "vLabelNombre"
        Me.vLabelNombre.Size = New System.Drawing.Size(58, 17)
        Me.vLabelNombre.TabIndex = 3
        Me.vLabelNombre.Text = "Nombre"
        '
        'vLabelApellido
        '
        Me.vLabelApellido.AutoSize = True
        Me.vLabelApellido.BackColor = System.Drawing.Color.Transparent
        Me.vLabelApellido.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vLabelApellido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vLabelApellido.Location = New System.Drawing.Point(131, 182)
        Me.vLabelApellido.Name = "vLabelApellido"
        Me.vLabelApellido.Size = New System.Drawing.Size(60, 17)
        Me.vLabelApellido.TabIndex = 4
        Me.vLabelApellido.Text = "Apellido"
        '
        'vLabelCorreo
        '
        Me.vLabelCorreo.AutoSize = True
        Me.vLabelCorreo.BackColor = System.Drawing.Color.Transparent
        Me.vLabelCorreo.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vLabelCorreo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vLabelCorreo.Location = New System.Drawing.Point(131, 238)
        Me.vLabelCorreo.Name = "vLabelCorreo"
        Me.vLabelCorreo.Size = New System.Drawing.Size(49, 17)
        Me.vLabelCorreo.TabIndex = 5
        Me.vLabelCorreo.Text = "Correo"
        '
        'vLabelCargo
        '
        Me.vLabelCargo.AutoSize = True
        Me.vLabelCargo.BackColor = System.Drawing.Color.Transparent
        Me.vLabelCargo.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vLabelCargo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vLabelCargo.Location = New System.Drawing.Point(131, 298)
        Me.vLabelCargo.Name = "vLabelCargo"
        Me.vLabelCargo.Size = New System.Drawing.Size(44, 17)
        Me.vLabelCargo.TabIndex = 6
        Me.vLabelCargo.Text = "Cargo"
        '
        'vTextID
        '
        Me.vTextID.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.vTextID.Location = New System.Drawing.Point(134, 89)
        Me.vTextID.Name = "vTextID"
        Me.vTextID.Size = New System.Drawing.Size(235, 25)
        Me.vTextID.TabIndex = 7
        '
        'vTextNombre
        '
        Me.vTextNombre.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.vTextNombre.Location = New System.Drawing.Point(134, 144)
        Me.vTextNombre.Name = "vTextNombre"
        Me.vTextNombre.Size = New System.Drawing.Size(235, 25)
        Me.vTextNombre.TabIndex = 8
        '
        'vTextApellido
        '
        Me.vTextApellido.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.vTextApellido.Location = New System.Drawing.Point(134, 202)
        Me.vTextApellido.Name = "vTextApellido"
        Me.vTextApellido.Size = New System.Drawing.Size(235, 25)
        Me.vTextApellido.TabIndex = 9
        '
        'vTextCorreo
        '
        Me.vTextCorreo.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.vTextCorreo.Location = New System.Drawing.Point(134, 258)
        Me.vTextCorreo.Name = "vTextCorreo"
        Me.vTextCorreo.Size = New System.Drawing.Size(235, 25)
        Me.vTextCorreo.TabIndex = 10
        '
        'vLabelUsuario
        '
        Me.vLabelUsuario.AutoSize = True
        Me.vLabelUsuario.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vLabelUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vLabelUsuario.Location = New System.Drawing.Point(134, 359)
        Me.vLabelUsuario.Name = "vLabelUsuario"
        Me.vLabelUsuario.Size = New System.Drawing.Size(55, 17)
        Me.vLabelUsuario.TabIndex = 13
        Me.vLabelUsuario.Text = "Usuario"
        '
        'vLabelContraseña
        '
        Me.vLabelContraseña.AutoSize = True
        Me.vLabelContraseña.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vLabelContraseña.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vLabelContraseña.Location = New System.Drawing.Point(131, 418)
        Me.vLabelContraseña.Name = "vLabelContraseña"
        Me.vLabelContraseña.Size = New System.Drawing.Size(77, 17)
        Me.vLabelContraseña.TabIndex = 14
        Me.vLabelContraseña.Text = "Contraseña"
        '
        'vTextUsuario
        '
        Me.vTextUsuario.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.vTextUsuario.Location = New System.Drawing.Point(134, 379)
        Me.vTextUsuario.Name = "vTextUsuario"
        Me.vTextUsuario.Size = New System.Drawing.Size(235, 25)
        Me.vTextUsuario.TabIndex = 15
        '
        'vTextContraseña
        '
        Me.vTextContraseña.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.vTextContraseña.Location = New System.Drawing.Point(134, 438)
        Me.vTextContraseña.Name = "vTextContraseña"
        Me.vTextContraseña.Size = New System.Drawing.Size(235, 25)
        Me.vTextContraseña.TabIndex = 16
        Me.vTextContraseña.UseSystemPasswordChar = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.OldLace
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(393, 361)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(234, 45)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Crear"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.OldLace
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(393, 420)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(234, 45)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'vComboCargo
        '
        Me.vComboCargo.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.vComboCargo.FormattingEnabled = True
        Me.vComboCargo.Items.AddRange(New Object() {"Administrador", "Doctor", "Farmacéutica", "Atención al Cliente"})
        Me.vComboCargo.Location = New System.Drawing.Point(134, 319)
        Me.vComboCargo.Name = "vComboCargo"
        Me.vComboCargo.Size = New System.Drawing.Size(235, 25)
        Me.vComboCargo.TabIndex = 19
        '
        'vPictureFoto
        '
        Me.vPictureFoto.BackColor = System.Drawing.Color.Gainsboro
        Me.vPictureFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.vPictureFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.vPictureFoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.vPictureFoto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vPictureFoto.Location = New System.Drawing.Point(393, 88)
        Me.vPictureFoto.Name = "vPictureFoto"
        Me.vPictureFoto.Size = New System.Drawing.Size(234, 254)
        Me.vPictureFoto.TabIndex = 12
        Me.vPictureFoto.TabStop = False
        '
        'CrearUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(769, 530)
        Me.Controls.Add(Me.vComboCargo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.vTextContraseña)
        Me.Controls.Add(Me.vTextUsuario)
        Me.Controls.Add(Me.vLabelContraseña)
        Me.Controls.Add(Me.vLabelUsuario)
        Me.Controls.Add(Me.vPictureFoto)
        Me.Controls.Add(Me.vTextCorreo)
        Me.Controls.Add(Me.vTextApellido)
        Me.Controls.Add(Me.vTextNombre)
        Me.Controls.Add(Me.vTextID)
        Me.Controls.Add(Me.vLabelCargo)
        Me.Controls.Add(Me.vLabelCorreo)
        Me.Controls.Add(Me.vLabelApellido)
        Me.Controls.Add(Me.vLabelNombre)
        Me.Controls.Add(Me.vLabelID)
        Me.Controls.Add(Me.vButtonSalir)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CrearUsuario"
        Me.Text = "Clínica Lima - Crear Usuario"
        CType(Me.vPictureFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents vButtonSalir As Button
    Friend WithEvents vLabelID As Label
    Friend WithEvents vLabelNombre As Label
    Friend WithEvents vLabelApellido As Label
    Friend WithEvents vLabelCorreo As Label
    Friend WithEvents vLabelCargo As Label
    Friend WithEvents vTextID As TextBox
    Friend WithEvents vTextNombre As TextBox
    Friend WithEvents vTextApellido As TextBox
    Friend WithEvents vTextCorreo As TextBox
    Friend WithEvents vPictureFoto As PictureBox
    Friend WithEvents vLabelUsuario As Label
    Friend WithEvents vLabelContraseña As Label
    Friend WithEvents vTextUsuario As TextBox
    Friend WithEvents vTextContraseña As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents vComboCargo As ComboBox
End Class
