<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultasUsuario
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
        Me.vDataTableUser = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.vComboBuscar = New System.Windows.Forms.ComboBox()
        Me.vLabelID = New System.Windows.Forms.Label()
        Me.vButtonConsultar = New System.Windows.Forms.Button()
        Me.vComboCargo = New System.Windows.Forms.ComboBox()
        Me.vTextContraseña = New System.Windows.Forms.TextBox()
        Me.vTextUsuario = New System.Windows.Forms.TextBox()
        Me.vLabelContraseña = New System.Windows.Forms.Label()
        Me.vLabelUsuario = New System.Windows.Forms.Label()
        Me.vTextCorreo = New System.Windows.Forms.TextBox()
        Me.vTextApellido = New System.Windows.Forms.TextBox()
        Me.vTextNombre = New System.Windows.Forms.TextBox()
        Me.vLabelCargo = New System.Windows.Forms.Label()
        Me.vLabelCorreo = New System.Windows.Forms.Label()
        Me.vLabelApellido = New System.Windows.Forms.Label()
        Me.vLabelNombre = New System.Windows.Forms.Label()
        Me.vButtonActualizar = New System.Windows.Forms.Button()
        Me.vButtonEliminar = New System.Windows.Forms.Button()
        Me.vButtonCancelar = New System.Windows.Forms.Button()
        CType(Me.vDataTableUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vDataTableUser
        '
        Me.vDataTableUser.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.vDataTableUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.vDataTableUser.Enabled = False
        Me.vDataTableUser.Location = New System.Drawing.Point(114, 53)
        Me.vDataTableUser.Name = "vDataTableUser"
        Me.vDataTableUser.Size = New System.Drawing.Size(543, 219)
        Me.vDataTableUser.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 30)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "LISTA DE USUARIOS"
        '
        'vComboBuscar
        '
        Me.vComboBuscar.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vComboBuscar.FormattingEnabled = True
        Me.vComboBuscar.Location = New System.Drawing.Point(114, 308)
        Me.vComboBuscar.Name = "vComboBuscar"
        Me.vComboBuscar.Size = New System.Drawing.Size(149, 25)
        Me.vComboBuscar.TabIndex = 4
        '
        'vLabelID
        '
        Me.vLabelID.AutoSize = True
        Me.vLabelID.BackColor = System.Drawing.Color.Transparent
        Me.vLabelID.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vLabelID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vLabelID.Location = New System.Drawing.Point(111, 288)
        Me.vLabelID.Name = "vLabelID"
        Me.vLabelID.Size = New System.Drawing.Size(121, 17)
        Me.vLabelID.TabIndex = 5
        Me.vLabelID.Text = "Buscar por Código"
        '
        'vButtonConsultar
        '
        Me.vButtonConsultar.BackColor = System.Drawing.Color.OldLace
        Me.vButtonConsultar.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vButtonConsultar.Location = New System.Drawing.Point(273, 303)
        Me.vButtonConsultar.Name = "vButtonConsultar"
        Me.vButtonConsultar.Size = New System.Drawing.Size(77, 32)
        Me.vButtonConsultar.TabIndex = 6
        Me.vButtonConsultar.Text = "Consultar"
        Me.vButtonConsultar.UseVisualStyleBackColor = False
        '
        'vComboCargo
        '
        Me.vComboCargo.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.vComboCargo.FormattingEnabled = True
        Me.vComboCargo.Items.AddRange(New Object() {"Administrador", "Doctor", "Recepcionista", "Farmacéutica", "Atención al Cliente"})
        Me.vComboCargo.Location = New System.Drawing.Point(331, 361)
        Me.vComboCargo.Name = "vComboCargo"
        Me.vComboCargo.Size = New System.Drawing.Size(200, 25)
        Me.vComboCargo.TabIndex = 31
        '
        'vTextContraseña
        '
        Me.vTextContraseña.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.vTextContraseña.Location = New System.Drawing.Point(334, 476)
        Me.vTextContraseña.Name = "vTextContraseña"
        Me.vTextContraseña.Size = New System.Drawing.Size(197, 25)
        Me.vTextContraseña.TabIndex = 30
        Me.vTextContraseña.UseSystemPasswordChar = True
        '
        'vTextUsuario
        '
        Me.vTextUsuario.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.vTextUsuario.Location = New System.Drawing.Point(331, 419)
        Me.vTextUsuario.Name = "vTextUsuario"
        Me.vTextUsuario.Size = New System.Drawing.Size(200, 25)
        Me.vTextUsuario.TabIndex = 29
        '
        'vLabelContraseña
        '
        Me.vLabelContraseña.AutoSize = True
        Me.vLabelContraseña.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vLabelContraseña.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vLabelContraseña.Location = New System.Drawing.Point(331, 456)
        Me.vLabelContraseña.Name = "vLabelContraseña"
        Me.vLabelContraseña.Size = New System.Drawing.Size(77, 17)
        Me.vLabelContraseña.TabIndex = 28
        Me.vLabelContraseña.Text = "Contraseña"
        '
        'vLabelUsuario
        '
        Me.vLabelUsuario.AutoSize = True
        Me.vLabelUsuario.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vLabelUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vLabelUsuario.Location = New System.Drawing.Point(331, 399)
        Me.vLabelUsuario.Name = "vLabelUsuario"
        Me.vLabelUsuario.Size = New System.Drawing.Size(55, 17)
        Me.vLabelUsuario.TabIndex = 27
        Me.vLabelUsuario.Text = "Usuario"
        '
        'vTextCorreo
        '
        Me.vTextCorreo.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.vTextCorreo.Location = New System.Drawing.Point(115, 476)
        Me.vTextCorreo.Name = "vTextCorreo"
        Me.vTextCorreo.Size = New System.Drawing.Size(199, 25)
        Me.vTextCorreo.TabIndex = 26
        '
        'vTextApellido
        '
        Me.vTextApellido.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.vTextApellido.Location = New System.Drawing.Point(115, 419)
        Me.vTextApellido.Name = "vTextApellido"
        Me.vTextApellido.Size = New System.Drawing.Size(199, 25)
        Me.vTextApellido.TabIndex = 25
        '
        'vTextNombre
        '
        Me.vTextNombre.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.vTextNombre.Location = New System.Drawing.Point(114, 362)
        Me.vTextNombre.Name = "vTextNombre"
        Me.vTextNombre.Size = New System.Drawing.Size(200, 25)
        Me.vTextNombre.TabIndex = 24
        '
        'vLabelCargo
        '
        Me.vLabelCargo.AutoSize = True
        Me.vLabelCargo.BackColor = System.Drawing.Color.Transparent
        Me.vLabelCargo.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vLabelCargo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vLabelCargo.Location = New System.Drawing.Point(328, 341)
        Me.vLabelCargo.Name = "vLabelCargo"
        Me.vLabelCargo.Size = New System.Drawing.Size(44, 17)
        Me.vLabelCargo.TabIndex = 23
        Me.vLabelCargo.Text = "Cargo"
        '
        'vLabelCorreo
        '
        Me.vLabelCorreo.AutoSize = True
        Me.vLabelCorreo.BackColor = System.Drawing.Color.Transparent
        Me.vLabelCorreo.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vLabelCorreo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vLabelCorreo.Location = New System.Drawing.Point(112, 456)
        Me.vLabelCorreo.Name = "vLabelCorreo"
        Me.vLabelCorreo.Size = New System.Drawing.Size(49, 17)
        Me.vLabelCorreo.TabIndex = 22
        Me.vLabelCorreo.Text = "Correo"
        '
        'vLabelApellido
        '
        Me.vLabelApellido.AutoSize = True
        Me.vLabelApellido.BackColor = System.Drawing.Color.Transparent
        Me.vLabelApellido.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vLabelApellido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vLabelApellido.Location = New System.Drawing.Point(112, 399)
        Me.vLabelApellido.Name = "vLabelApellido"
        Me.vLabelApellido.Size = New System.Drawing.Size(60, 17)
        Me.vLabelApellido.TabIndex = 21
        Me.vLabelApellido.Text = "Apellido"
        '
        'vLabelNombre
        '
        Me.vLabelNombre.AutoSize = True
        Me.vLabelNombre.BackColor = System.Drawing.Color.Transparent
        Me.vLabelNombre.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vLabelNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vLabelNombre.Location = New System.Drawing.Point(111, 342)
        Me.vLabelNombre.Name = "vLabelNombre"
        Me.vLabelNombre.Size = New System.Drawing.Size(58, 17)
        Me.vLabelNombre.TabIndex = 20
        Me.vLabelNombre.Text = "Nombre"
        '
        'vButtonActualizar
        '
        Me.vButtonActualizar.BackColor = System.Drawing.Color.OldLace
        Me.vButtonActualizar.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vButtonActualizar.Location = New System.Drawing.Point(552, 359)
        Me.vButtonActualizar.Name = "vButtonActualizar"
        Me.vButtonActualizar.Size = New System.Drawing.Size(105, 44)
        Me.vButtonActualizar.TabIndex = 32
        Me.vButtonActualizar.Text = "Actualizar"
        Me.vButtonActualizar.UseVisualStyleBackColor = False
        '
        'vButtonEliminar
        '
        Me.vButtonEliminar.BackColor = System.Drawing.Color.OldLace
        Me.vButtonEliminar.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vButtonEliminar.Location = New System.Drawing.Point(552, 409)
        Me.vButtonEliminar.Name = "vButtonEliminar"
        Me.vButtonEliminar.Size = New System.Drawing.Size(105, 43)
        Me.vButtonEliminar.TabIndex = 33
        Me.vButtonEliminar.Text = "Eliminar"
        Me.vButtonEliminar.UseVisualStyleBackColor = False
        '
        'vButtonCancelar
        '
        Me.vButtonCancelar.BackColor = System.Drawing.Color.OldLace
        Me.vButtonCancelar.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vButtonCancelar.Location = New System.Drawing.Point(552, 458)
        Me.vButtonCancelar.Name = "vButtonCancelar"
        Me.vButtonCancelar.Size = New System.Drawing.Size(105, 43)
        Me.vButtonCancelar.TabIndex = 34
        Me.vButtonCancelar.Text = "Cancelar"
        Me.vButtonCancelar.UseVisualStyleBackColor = False
        '
        'ConsultasUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(769, 530)
        Me.Controls.Add(Me.vButtonCancelar)
        Me.Controls.Add(Me.vButtonEliminar)
        Me.Controls.Add(Me.vButtonActualizar)
        Me.Controls.Add(Me.vComboCargo)
        Me.Controls.Add(Me.vTextContraseña)
        Me.Controls.Add(Me.vTextUsuario)
        Me.Controls.Add(Me.vLabelContraseña)
        Me.Controls.Add(Me.vLabelUsuario)
        Me.Controls.Add(Me.vTextCorreo)
        Me.Controls.Add(Me.vTextApellido)
        Me.Controls.Add(Me.vTextNombre)
        Me.Controls.Add(Me.vLabelCargo)
        Me.Controls.Add(Me.vLabelCorreo)
        Me.Controls.Add(Me.vLabelApellido)
        Me.Controls.Add(Me.vLabelNombre)
        Me.Controls.Add(Me.vButtonConsultar)
        Me.Controls.Add(Me.vLabelID)
        Me.Controls.Add(Me.vComboBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.vDataTableUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ConsultasUsuario"
        Me.Text = "ConsultasUsuario"
        CType(Me.vDataTableUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vDataTableUser As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents vComboBuscar As ComboBox
    Friend WithEvents vLabelID As Label
    Friend WithEvents vButtonConsultar As Button
    Friend WithEvents vComboCargo As ComboBox
    Friend WithEvents vTextContraseña As TextBox
    Friend WithEvents vTextUsuario As TextBox
    Friend WithEvents vLabelContraseña As Label
    Friend WithEvents vLabelUsuario As Label
    Friend WithEvents vTextCorreo As TextBox
    Friend WithEvents vTextApellido As TextBox
    Friend WithEvents vTextNombre As TextBox
    Friend WithEvents vLabelCargo As Label
    Friend WithEvents vLabelCorreo As Label
    Friend WithEvents vLabelApellido As Label
    Friend WithEvents vLabelNombre As Label
    Friend WithEvents vButtonActualizar As Button
    Friend WithEvents vButtonEliminar As Button
    Friend WithEvents vButtonCancelar As Button
End Class
