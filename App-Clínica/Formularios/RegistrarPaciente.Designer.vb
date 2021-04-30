<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarPaciente
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.vTextCorreo = New System.Windows.Forms.TextBox()
        Me.vTextApellido = New System.Windows.Forms.TextBox()
        Me.vTextNombre = New System.Windows.Forms.TextBox()
        Me.vTextID = New System.Windows.Forms.TextBox()
        Me.vLabelCargo = New System.Windows.Forms.Label()
        Me.vLabelCorreo = New System.Windows.Forms.Label()
        Me.vLabelApellido = New System.Windows.Forms.Label()
        Me.vLabelNombre = New System.Windows.Forms.Label()
        Me.vLabelID = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.vPictureFoto = New System.Windows.Forms.PictureBox()
        Me.vTextTelefono = New System.Windows.Forms.TextBox()
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
        Me.Label1.Size = New System.Drawing.Size(232, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "REGISTRAR PACIENTE"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.OldLace
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(398, 389)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(234, 45)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.OldLace
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(139, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(234, 45)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Crear"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'vTextCorreo
        '
        Me.vTextCorreo.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.vTextCorreo.Location = New System.Drawing.Point(139, 282)
        Me.vTextCorreo.Name = "vTextCorreo"
        Me.vTextCorreo.Size = New System.Drawing.Size(235, 25)
        Me.vTextCorreo.TabIndex = 28
        '
        'vTextApellido
        '
        Me.vTextApellido.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.vTextApellido.Location = New System.Drawing.Point(139, 226)
        Me.vTextApellido.Name = "vTextApellido"
        Me.vTextApellido.Size = New System.Drawing.Size(235, 25)
        Me.vTextApellido.TabIndex = 27
        '
        'vTextNombre
        '
        Me.vTextNombre.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.vTextNombre.Location = New System.Drawing.Point(139, 168)
        Me.vTextNombre.Name = "vTextNombre"
        Me.vTextNombre.Size = New System.Drawing.Size(235, 25)
        Me.vTextNombre.TabIndex = 26
        '
        'vTextID
        '
        Me.vTextID.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.vTextID.Location = New System.Drawing.Point(139, 113)
        Me.vTextID.Name = "vTextID"
        Me.vTextID.Size = New System.Drawing.Size(235, 25)
        Me.vTextID.TabIndex = 25
        '
        'vLabelCargo
        '
        Me.vLabelCargo.AutoSize = True
        Me.vLabelCargo.BackColor = System.Drawing.Color.Transparent
        Me.vLabelCargo.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vLabelCargo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vLabelCargo.Location = New System.Drawing.Point(136, 322)
        Me.vLabelCargo.Name = "vLabelCargo"
        Me.vLabelCargo.Size = New System.Drawing.Size(63, 17)
        Me.vLabelCargo.TabIndex = 24
        Me.vLabelCargo.Text = "Teléfono"
        '
        'vLabelCorreo
        '
        Me.vLabelCorreo.AutoSize = True
        Me.vLabelCorreo.BackColor = System.Drawing.Color.Transparent
        Me.vLabelCorreo.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vLabelCorreo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vLabelCorreo.Location = New System.Drawing.Point(136, 262)
        Me.vLabelCorreo.Name = "vLabelCorreo"
        Me.vLabelCorreo.Size = New System.Drawing.Size(49, 17)
        Me.vLabelCorreo.TabIndex = 23
        Me.vLabelCorreo.Text = "Correo"
        '
        'vLabelApellido
        '
        Me.vLabelApellido.AutoSize = True
        Me.vLabelApellido.BackColor = System.Drawing.Color.Transparent
        Me.vLabelApellido.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vLabelApellido.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vLabelApellido.Location = New System.Drawing.Point(136, 206)
        Me.vLabelApellido.Name = "vLabelApellido"
        Me.vLabelApellido.Size = New System.Drawing.Size(60, 17)
        Me.vLabelApellido.TabIndex = 22
        Me.vLabelApellido.Text = "Apellido"
        '
        'vLabelNombre
        '
        Me.vLabelNombre.AutoSize = True
        Me.vLabelNombre.BackColor = System.Drawing.Color.Transparent
        Me.vLabelNombre.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vLabelNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vLabelNombre.Location = New System.Drawing.Point(136, 148)
        Me.vLabelNombre.Name = "vLabelNombre"
        Me.vLabelNombre.Size = New System.Drawing.Size(58, 17)
        Me.vLabelNombre.TabIndex = 21
        Me.vLabelNombre.Text = "Nombre"
        '
        'vLabelID
        '
        Me.vLabelID.AutoSize = True
        Me.vLabelID.BackColor = System.Drawing.Color.Transparent
        Me.vLabelID.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vLabelID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vLabelID.Location = New System.Drawing.Point(136, 92)
        Me.vLabelID.Name = "vLabelID"
        Me.vLabelID.Size = New System.Drawing.Size(22, 17)
        Me.vLabelID.TabIndex = 20
        Me.vLabelID.Text = "ID"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'vPictureFoto
        '
        Me.vPictureFoto.BackColor = System.Drawing.Color.Gainsboro
        Me.vPictureFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.vPictureFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.vPictureFoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.vPictureFoto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.vPictureFoto.Location = New System.Drawing.Point(398, 112)
        Me.vPictureFoto.Name = "vPictureFoto"
        Me.vPictureFoto.Size = New System.Drawing.Size(234, 254)
        Me.vPictureFoto.TabIndex = 29
        Me.vPictureFoto.TabStop = False
        '
        'vTextTelefono
        '
        Me.vTextTelefono.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.vTextTelefono.Location = New System.Drawing.Point(139, 342)
        Me.vTextTelefono.Name = "vTextTelefono"
        Me.vTextTelefono.Size = New System.Drawing.Size(235, 25)
        Me.vTextTelefono.TabIndex = 36
        '
        'RegistrarPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 530)
        Me.Controls.Add(Me.vTextTelefono)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
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
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegistrarPaciente"
        Me.Text = "Form1"
        CType(Me.vPictureFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents vPictureFoto As PictureBox
    Friend WithEvents vTextCorreo As TextBox
    Friend WithEvents vTextApellido As TextBox
    Friend WithEvents vTextNombre As TextBox
    Friend WithEvents vTextID As TextBox
    Friend WithEvents vLabelCargo As Label
    Friend WithEvents vLabelCorreo As Label
    Friend WithEvents vLabelApellido As Label
    Friend WithEvents vLabelNombre As Label
    Friend WithEvents vLabelID As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents vTextTelefono As TextBox
End Class
