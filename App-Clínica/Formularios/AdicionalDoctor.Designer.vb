<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdicionalDoctor
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
        Me.vNacionalidad = New System.Windows.Forms.TextBox()
        Me.vLabelNombre = New System.Windows.Forms.Label()
        Me.vLabelID = New System.Windows.Forms.Label()
        Me.vGuardarDoctor = New System.Windows.Forms.Button()
        Me.vEscondido = New System.Windows.Forms.Label()
        Me.vComboEspecialidad = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'vNacionalidad
        '
        Me.vNacionalidad.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.vNacionalidad.Location = New System.Drawing.Point(63, 55)
        Me.vNacionalidad.Name = "vNacionalidad"
        Me.vNacionalidad.Size = New System.Drawing.Size(195, 25)
        Me.vNacionalidad.TabIndex = 53
        '
        'vLabelNombre
        '
        Me.vLabelNombre.AutoSize = True
        Me.vLabelNombre.BackColor = System.Drawing.Color.Transparent
        Me.vLabelNombre.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vLabelNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vLabelNombre.Location = New System.Drawing.Point(60, 98)
        Me.vLabelNombre.Name = "vLabelNombre"
        Me.vLabelNombre.Size = New System.Drawing.Size(84, 17)
        Me.vLabelNombre.TabIndex = 52
        Me.vLabelNombre.Text = "Especialidad"
        '
        'vLabelID
        '
        Me.vLabelID.AutoSize = True
        Me.vLabelID.BackColor = System.Drawing.Color.Transparent
        Me.vLabelID.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vLabelID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vLabelID.Location = New System.Drawing.Point(60, 34)
        Me.vLabelID.Name = "vLabelID"
        Me.vLabelID.Size = New System.Drawing.Size(89, 17)
        Me.vLabelID.TabIndex = 51
        Me.vLabelID.Text = "Nacionalidad"
        '
        'vGuardarDoctor
        '
        Me.vGuardarDoctor.BackColor = System.Drawing.Color.LightCyan
        Me.vGuardarDoctor.Location = New System.Drawing.Point(63, 164)
        Me.vGuardarDoctor.Name = "vGuardarDoctor"
        Me.vGuardarDoctor.Size = New System.Drawing.Size(195, 46)
        Me.vGuardarDoctor.TabIndex = 55
        Me.vGuardarDoctor.Text = "Guardar"
        Me.vGuardarDoctor.UseVisualStyleBackColor = False
        '
        'vEscondido
        '
        Me.vEscondido.AutoSize = True
        Me.vEscondido.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.vEscondido.Location = New System.Drawing.Point(115, 9)
        Me.vEscondido.Name = "vEscondido"
        Me.vEscondido.Size = New System.Drawing.Size(0, 13)
        Me.vEscondido.TabIndex = 56
        '
        'vComboEspecialidad
        '
        Me.vComboEspecialidad.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vComboEspecialidad.FormattingEnabled = True
        Me.vComboEspecialidad.Items.AddRange(New Object() {"ALERGIAS", "CARDIOLOGÍA", "DERMATOLOGÍA", "ENDOCRINOLOGÍA", "GASTROENTEROLOGÍA", "GERIATRÍA", "GINECOLOGÍA", "MEDICINA", "NEUMOLOGÍA", "NUTRICIÓN", "ODONTOLOGÍA", "OFTALMOLOGÍA", "PEDIATRÍA", "PSICOLOGÍA", "PSIQUIATRÍA", "REUMATOLOGÍA", "TRAUMATOLOGÍA", "UROLOGÍA"})
        Me.vComboEspecialidad.Location = New System.Drawing.Point(63, 118)
        Me.vComboEspecialidad.Name = "vComboEspecialidad"
        Me.vComboEspecialidad.Size = New System.Drawing.Size(195, 25)
        Me.vComboEspecialidad.TabIndex = 57
        '
        'AdicionalDoctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(319, 244)
        Me.Controls.Add(Me.vComboEspecialidad)
        Me.Controls.Add(Me.vEscondido)
        Me.Controls.Add(Me.vGuardarDoctor)
        Me.Controls.Add(Me.vNacionalidad)
        Me.Controls.Add(Me.vLabelNombre)
        Me.Controls.Add(Me.vLabelID)
        Me.Name = "AdicionalDoctor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Información Adicional"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents vNacionalidad As TextBox
    Friend WithEvents vLabelNombre As Label
    Friend WithEvents vLabelID As Label
    Friend WithEvents vGuardarDoctor As Button
    Friend WithEvents vEscondido As Label
    Friend WithEvents vComboEspecialidad As ComboBox
End Class
