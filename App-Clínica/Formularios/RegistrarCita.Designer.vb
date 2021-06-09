<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarCita
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.vTextTurno = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.vtxtBuscar = New System.Windows.Forms.TextBox()
        Me.vLabelCargo = New System.Windows.Forms.Label()
        Me.vLabelCorreo = New System.Windows.Forms.Label()
        Me.vLabelApellido = New System.Windows.Forms.Label()
        Me.vLabelNombre = New System.Windows.Forms.Label()
        Me.vLabelID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.vComboBoxDoctor = New System.Windows.Forms.ComboBox()
        Me.vButtonSalir = New System.Windows.Forms.Button()
        Me.vComboEspecialidad = New System.Windows.Forms.ComboBox()
        Me.vComboConsultorio = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.vTextCosto = New System.Windows.Forms.TextBox()
        Me.vTextPaciente = New System.Windows.Forms.TextBox()
        Me.vDataTablePaciente = New System.Windows.Forms.DataGridView()
        Me.vCodigo = New System.Windows.Forms.TextBox()
        Me.vTextCodigo = New System.Windows.Forms.Label()
        Me.vLag = New System.Windows.Forms.Label()
        CType(Me.vDataTablePaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vTextTurno
        '
        Me.vTextTurno.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.vTextTurno.Location = New System.Drawing.Point(265, 446)
        Me.vTextTurno.Name = "vTextTurno"
        Me.vTextTurno.Size = New System.Drawing.Size(195, 25)
        Me.vTextTurno.TabIndex = 49
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightCyan
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(89, 426)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 45)
        Me.Button2.TabIndex = 48
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightCyan
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(89, 365)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 45)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Generar Cita"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'vtxtBuscar
        '
        Me.vtxtBuscar.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.vtxtBuscar.Location = New System.Drawing.Point(89, 320)
        Me.vtxtBuscar.Name = "vtxtBuscar"
        Me.vtxtBuscar.Size = New System.Drawing.Size(140, 25)
        Me.vtxtBuscar.TabIndex = 43
        '
        'vLabelCargo
        '
        Me.vLabelCargo.AutoSize = True
        Me.vLabelCargo.BackColor = System.Drawing.Color.Transparent
        Me.vLabelCargo.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vLabelCargo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vLabelCargo.Location = New System.Drawing.Point(262, 426)
        Me.vLabelCargo.Name = "vLabelCargo"
        Me.vLabelCargo.Size = New System.Drawing.Size(45, 17)
        Me.vLabelCargo.TabIndex = 42
        Me.vLabelCargo.Text = "Turno"
        '
        'vLabelCorreo
        '
        Me.vLabelCorreo.AutoSize = True
        Me.vLabelCorreo.BackColor = System.Drawing.Color.Transparent
        Me.vLabelCorreo.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vLabelCorreo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vLabelCorreo.Location = New System.Drawing.Point(470, 300)
        Me.vLabelCorreo.Name = "vLabelCorreo"
        Me.vLabelCorreo.Size = New System.Drawing.Size(84, 17)
        Me.vLabelCorreo.TabIndex = 41
        Me.vLabelCorreo.Text = "Especialidad"
        '
        'vLabelApellido
        '
        Me.vLabelApellido.AutoSize = True
        Me.vLabelApellido.BackColor = System.Drawing.Color.Transparent
        Me.vLabelApellido.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vLabelApellido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vLabelApellido.Location = New System.Drawing.Point(262, 365)
        Me.vLabelApellido.Name = "vLabelApellido"
        Me.vLabelApellido.Size = New System.Drawing.Size(50, 17)
        Me.vLabelApellido.TabIndex = 40
        Me.vLabelApellido.Text = "Doctor"
        '
        'vLabelNombre
        '
        Me.vLabelNombre.AutoSize = True
        Me.vLabelNombre.BackColor = System.Drawing.Color.Transparent
        Me.vLabelNombre.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vLabelNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vLabelNombre.Location = New System.Drawing.Point(262, 300)
        Me.vLabelNombre.Name = "vLabelNombre"
        Me.vLabelNombre.Size = New System.Drawing.Size(60, 17)
        Me.vLabelNombre.TabIndex = 39
        Me.vLabelNombre.Text = "Paciente"
        '
        'vLabelID
        '
        Me.vLabelID.AutoSize = True
        Me.vLabelID.BackColor = System.Drawing.Color.Transparent
        Me.vLabelID.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vLabelID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vLabelID.Location = New System.Drawing.Point(86, 299)
        Me.vLabelID.Name = "vLabelID"
        Me.vLabelID.Size = New System.Drawing.Size(22, 17)
        Me.vLabelID.TabIndex = 38
        Me.vLabelID.Text = "ID"
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
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "REGISTRAR CITA"
        '
        'vComboBoxDoctor
        '
        Me.vComboBoxDoctor.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vComboBoxDoctor.FormattingEnabled = True
        Me.vComboBoxDoctor.Location = New System.Drawing.Point(265, 385)
        Me.vComboBoxDoctor.Name = "vComboBoxDoctor"
        Me.vComboBoxDoctor.Size = New System.Drawing.Size(195, 25)
        Me.vComboBoxDoctor.TabIndex = 51
        '
        'vButtonSalir
        '
        Me.vButtonSalir.BackColor = System.Drawing.Color.LightCoral
        Me.vButtonSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vButtonSalir.Location = New System.Drawing.Point(701, -1)
        Me.vButtonSalir.Name = "vButtonSalir"
        Me.vButtonSalir.Size = New System.Drawing.Size(69, 38)
        Me.vButtonSalir.TabIndex = 52
        Me.vButtonSalir.Text = "Salir"
        Me.vButtonSalir.UseVisualStyleBackColor = False
        '
        'vComboEspecialidad
        '
        Me.vComboEspecialidad.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vComboEspecialidad.FormattingEnabled = True
        Me.vComboEspecialidad.Items.AddRange(New Object() {"ALERGIAS", "CARDIOLOGÍA", "DERMATOLOGÍA", "ENDOCRINOLOGÍA", "GASTROENTEROLOGÍA", "GERIATRÍA", "GINECOLOGÍA", "MEDICINA", "NEUMOLOGÍA", "NUTRICIÓN", "ODONTOLOGÍA", "OFTALMOLOGÍA", "PEDIATRÍA", "PSICOLOGÍA", "PSIQUIATRÍA", "REUMATOLOGÍA", "TRAUMATOLOGÍA", "UROLOGÍA"})
        Me.vComboEspecialidad.Location = New System.Drawing.Point(473, 320)
        Me.vComboEspecialidad.Name = "vComboEspecialidad"
        Me.vComboEspecialidad.Size = New System.Drawing.Size(195, 25)
        Me.vComboEspecialidad.TabIndex = 53
        '
        'vComboConsultorio
        '
        Me.vComboConsultorio.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vComboConsultorio.FormattingEnabled = True
        Me.vComboConsultorio.Location = New System.Drawing.Point(475, 385)
        Me.vComboConsultorio.Name = "vComboConsultorio"
        Me.vComboConsultorio.Size = New System.Drawing.Size(195, 25)
        Me.vComboConsultorio.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(472, 365)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Consultorio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(476, 426)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Precio"
        '
        'vTextCosto
        '
        Me.vTextCosto.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.vTextCosto.Location = New System.Drawing.Point(475, 446)
        Me.vTextCosto.Name = "vTextCosto"
        Me.vTextCosto.Size = New System.Drawing.Size(195, 25)
        Me.vTextCosto.TabIndex = 57
        '
        'vTextPaciente
        '
        Me.vTextPaciente.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.vTextPaciente.Location = New System.Drawing.Point(265, 320)
        Me.vTextPaciente.Name = "vTextPaciente"
        Me.vTextPaciente.Size = New System.Drawing.Size(195, 25)
        Me.vTextPaciente.TabIndex = 58
        '
        'vDataTablePaciente
        '
        Me.vDataTablePaciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.vDataTablePaciente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.vDataTablePaciente.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.vDataTablePaciente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.vDataTablePaciente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.vDataTablePaciente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.vDataTablePaciente.ColumnHeadersHeight = 30
        Me.vDataTablePaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.vDataTablePaciente.EnableHeadersVisualStyles = False
        Me.vDataTablePaciente.GridColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.vDataTablePaciente.Location = New System.Drawing.Point(74, 68)
        Me.vDataTablePaciente.Name = "vDataTablePaciente"
        Me.vDataTablePaciente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.vDataTablePaciente.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.vDataTablePaciente.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.vDataTablePaciente.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.vDataTablePaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.vDataTablePaciente.Size = New System.Drawing.Size(619, 218)
        Me.vDataTablePaciente.TabIndex = 59
        '
        'vCodigo
        '
        Me.vCodigo.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.vCodigo.Location = New System.Drawing.Point(500, 37)
        Me.vCodigo.Name = "vCodigo"
        Me.vCodigo.Size = New System.Drawing.Size(168, 25)
        Me.vCodigo.TabIndex = 61
        '
        'vTextCodigo
        '
        Me.vTextCodigo.AutoSize = True
        Me.vTextCodigo.BackColor = System.Drawing.Color.Transparent
        Me.vTextCodigo.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vTextCodigo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vTextCodigo.Location = New System.Drawing.Point(446, 40)
        Me.vTextCodigo.Name = "vTextCodigo"
        Me.vTextCodigo.Size = New System.Drawing.Size(52, 17)
        Me.vTextCodigo.TabIndex = 60
        Me.vTextCodigo.Text = "Código"
        '
        'vLag
        '
        Me.vLag.AutoSize = True
        Me.vLag.Location = New System.Drawing.Point(13, 331)
        Me.vLag.Name = "vLag"
        Me.vLag.Size = New System.Drawing.Size(0, 13)
        Me.vLag.TabIndex = 62
        '
        'RegistrarCita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(769, 530)
        Me.Controls.Add(Me.vLag)
        Me.Controls.Add(Me.vCodigo)
        Me.Controls.Add(Me.vTextCodigo)
        Me.Controls.Add(Me.vDataTablePaciente)
        Me.Controls.Add(Me.vTextPaciente)
        Me.Controls.Add(Me.vTextCosto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.vComboConsultorio)
        Me.Controls.Add(Me.vComboEspecialidad)
        Me.Controls.Add(Me.vButtonSalir)
        Me.Controls.Add(Me.vComboBoxDoctor)
        Me.Controls.Add(Me.vTextTurno)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.vtxtBuscar)
        Me.Controls.Add(Me.vLabelCargo)
        Me.Controls.Add(Me.vLabelCorreo)
        Me.Controls.Add(Me.vLabelApellido)
        Me.Controls.Add(Me.vLabelNombre)
        Me.Controls.Add(Me.vLabelID)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegistrarCita"
        Me.Text = "RegistrarCita"
        CType(Me.vDataTablePaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents vTextTurno As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents vtxtBuscar As TextBox
    Friend WithEvents vLabelCargo As Label
    Friend WithEvents vLabelCorreo As Label
    Friend WithEvents vLabelApellido As Label
    Friend WithEvents vLabelNombre As Label
    Friend WithEvents vLabelID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents vComboBoxDoctor As ComboBox
    Friend WithEvents vButtonSalir As Button
    Friend WithEvents vComboEspecialidad As ComboBox
    Friend WithEvents vComboConsultorio As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents vTextCosto As TextBox
    Friend WithEvents vTextPaciente As TextBox
    Friend WithEvents vDataTablePaciente As DataGridView
    Friend WithEvents vCodigo As TextBox
    Friend WithEvents vTextCodigo As Label
    Friend WithEvents vLag As Label
End Class
