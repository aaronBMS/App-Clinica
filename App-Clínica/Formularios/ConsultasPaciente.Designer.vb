<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultasPaciente
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
        Me.vButtonCancelar = New System.Windows.Forms.Button()
        Me.vButtonActualizar = New System.Windows.Forms.Button()
        Me.vTextTelefono = New System.Windows.Forms.TextBox()
        Me.vLabelUsuario = New System.Windows.Forms.Label()
        Me.vTextCorreo = New System.Windows.Forms.TextBox()
        Me.vTextApellido = New System.Windows.Forms.TextBox()
        Me.vTextNombre = New System.Windows.Forms.TextBox()
        Me.vLabelCorreo = New System.Windows.Forms.Label()
        Me.vLabelApellido = New System.Windows.Forms.Label()
        Me.vLabelNombre = New System.Windows.Forms.Label()
        Me.vButtonConsultar = New System.Windows.Forms.Button()
        Me.vLabelID = New System.Windows.Forms.Label()
        Me.vComboBuscar = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.vDataTableUser = New System.Windows.Forms.DataGridView()
        CType(Me.vDataTableUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vButtonCancelar
        '
        Me.vButtonCancelar.BackColor = System.Drawing.Color.OldLace
        Me.vButtonCancelar.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vButtonCancelar.Location = New System.Drawing.Point(552, 431)
        Me.vButtonCancelar.Name = "vButtonCancelar"
        Me.vButtonCancelar.Size = New System.Drawing.Size(105, 43)
        Me.vButtonCancelar.TabIndex = 54
        Me.vButtonCancelar.Text = "Cancelar"
        Me.vButtonCancelar.UseVisualStyleBackColor = False
        '
        'vButtonActualizar
        '
        Me.vButtonActualizar.BackColor = System.Drawing.Color.OldLace
        Me.vButtonActualizar.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vButtonActualizar.Location = New System.Drawing.Point(552, 381)
        Me.vButtonActualizar.Name = "vButtonActualizar"
        Me.vButtonActualizar.Size = New System.Drawing.Size(105, 44)
        Me.vButtonActualizar.TabIndex = 52
        Me.vButtonActualizar.Text = "Actualizar"
        Me.vButtonActualizar.UseVisualStyleBackColor = False
        '
        'vTextTelefono
        '
        Me.vTextTelefono.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.vTextTelefono.Location = New System.Drawing.Point(331, 387)
        Me.vTextTelefono.Name = "vTextTelefono"
        Me.vTextTelefono.Size = New System.Drawing.Size(200, 25)
        Me.vTextTelefono.TabIndex = 49
        '
        'vLabelUsuario
        '
        Me.vLabelUsuario.AutoSize = True
        Me.vLabelUsuario.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vLabelUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vLabelUsuario.Location = New System.Drawing.Point(331, 367)
        Me.vLabelUsuario.Name = "vLabelUsuario"
        Me.vLabelUsuario.Size = New System.Drawing.Size(63, 17)
        Me.vLabelUsuario.TabIndex = 47
        Me.vLabelUsuario.Text = "Teléfono"
        '
        'vTextCorreo
        '
        Me.vTextCorreo.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.vTextCorreo.Location = New System.Drawing.Point(331, 445)
        Me.vTextCorreo.Name = "vTextCorreo"
        Me.vTextCorreo.Size = New System.Drawing.Size(199, 25)
        Me.vTextCorreo.TabIndex = 46
        '
        'vTextApellido
        '
        Me.vTextApellido.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.vTextApellido.Location = New System.Drawing.Point(115, 445)
        Me.vTextApellido.Name = "vTextApellido"
        Me.vTextApellido.Size = New System.Drawing.Size(199, 25)
        Me.vTextApellido.TabIndex = 45
        '
        'vTextNombre
        '
        Me.vTextNombre.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.vTextNombre.Location = New System.Drawing.Point(114, 388)
        Me.vTextNombre.Name = "vTextNombre"
        Me.vTextNombre.Size = New System.Drawing.Size(200, 25)
        Me.vTextNombre.TabIndex = 44
        '
        'vLabelCorreo
        '
        Me.vLabelCorreo.AutoSize = True
        Me.vLabelCorreo.BackColor = System.Drawing.Color.Transparent
        Me.vLabelCorreo.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vLabelCorreo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vLabelCorreo.Location = New System.Drawing.Point(328, 425)
        Me.vLabelCorreo.Name = "vLabelCorreo"
        Me.vLabelCorreo.Size = New System.Drawing.Size(49, 17)
        Me.vLabelCorreo.TabIndex = 42
        Me.vLabelCorreo.Text = "Correo"
        '
        'vLabelApellido
        '
        Me.vLabelApellido.AutoSize = True
        Me.vLabelApellido.BackColor = System.Drawing.Color.Transparent
        Me.vLabelApellido.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vLabelApellido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vLabelApellido.Location = New System.Drawing.Point(112, 425)
        Me.vLabelApellido.Name = "vLabelApellido"
        Me.vLabelApellido.Size = New System.Drawing.Size(60, 17)
        Me.vLabelApellido.TabIndex = 41
        Me.vLabelApellido.Text = "Apellido"
        '
        'vLabelNombre
        '
        Me.vLabelNombre.AutoSize = True
        Me.vLabelNombre.BackColor = System.Drawing.Color.Transparent
        Me.vLabelNombre.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vLabelNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vLabelNombre.Location = New System.Drawing.Point(111, 368)
        Me.vLabelNombre.Name = "vLabelNombre"
        Me.vLabelNombre.Size = New System.Drawing.Size(58, 17)
        Me.vLabelNombre.TabIndex = 40
        Me.vLabelNombre.Text = "Nombre"
        '
        'vButtonConsultar
        '
        Me.vButtonConsultar.BackColor = System.Drawing.Color.OldLace
        Me.vButtonConsultar.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vButtonConsultar.Location = New System.Drawing.Point(273, 329)
        Me.vButtonConsultar.Name = "vButtonConsultar"
        Me.vButtonConsultar.Size = New System.Drawing.Size(77, 32)
        Me.vButtonConsultar.TabIndex = 39
        Me.vButtonConsultar.Text = "Consultar"
        Me.vButtonConsultar.UseVisualStyleBackColor = False
        '
        'vLabelID
        '
        Me.vLabelID.AutoSize = True
        Me.vLabelID.BackColor = System.Drawing.Color.Transparent
        Me.vLabelID.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vLabelID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vLabelID.Location = New System.Drawing.Point(111, 314)
        Me.vLabelID.Name = "vLabelID"
        Me.vLabelID.Size = New System.Drawing.Size(121, 17)
        Me.vLabelID.TabIndex = 38
        Me.vLabelID.Text = "Buscar por Código"
        '
        'vComboBuscar
        '
        Me.vComboBuscar.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vComboBuscar.FormattingEnabled = True
        Me.vComboBuscar.Location = New System.Drawing.Point(114, 334)
        Me.vComboBuscar.Name = "vComboBuscar"
        Me.vComboBuscar.Size = New System.Drawing.Size(149, 25)
        Me.vComboBuscar.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 30)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "LISTA DE PACIENTES"
        '
        'vDataTableUser
        '
        Me.vDataTableUser.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.vDataTableUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.vDataTableUser.Enabled = False
        Me.vDataTableUser.Location = New System.Drawing.Point(114, 79)
        Me.vDataTableUser.Name = "vDataTableUser"
        Me.vDataTableUser.Size = New System.Drawing.Size(543, 219)
        Me.vDataTableUser.TabIndex = 35
        '
        'ConsultasPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 530)
        Me.Controls.Add(Me.vButtonCancelar)
        Me.Controls.Add(Me.vButtonActualizar)
        Me.Controls.Add(Me.vTextTelefono)
        Me.Controls.Add(Me.vLabelUsuario)
        Me.Controls.Add(Me.vTextCorreo)
        Me.Controls.Add(Me.vTextApellido)
        Me.Controls.Add(Me.vTextNombre)
        Me.Controls.Add(Me.vLabelCorreo)
        Me.Controls.Add(Me.vLabelApellido)
        Me.Controls.Add(Me.vLabelNombre)
        Me.Controls.Add(Me.vButtonConsultar)
        Me.Controls.Add(Me.vLabelID)
        Me.Controls.Add(Me.vComboBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.vDataTableUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ConsultasPaciente"
        Me.Text = "ConsultasPaciente"
        CType(Me.vDataTableUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents vButtonCancelar As Button
    Friend WithEvents vButtonActualizar As Button
    Friend WithEvents vTextTelefono As TextBox
    Friend WithEvents vLabelUsuario As Label
    Friend WithEvents vTextCorreo As TextBox
    Friend WithEvents vTextApellido As TextBox
    Friend WithEvents vTextNombre As TextBox
    Friend WithEvents vLabelCorreo As Label
    Friend WithEvents vLabelApellido As Label
    Friend WithEvents vLabelNombre As Label
    Friend WithEvents vButtonConsultar As Button
    Friend WithEvents vLabelID As Label
    Friend WithEvents vComboBuscar As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents vDataTableUser As DataGridView
End Class
