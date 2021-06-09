<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cita_Archivo
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.vLabelSeñor = New System.Windows.Forms.Label()
        Me.vLabelDNI = New System.Windows.Forms.Label()
        Me.vLabelFecha = New System.Windows.Forms.Label()
        Me.vLabelHora = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.vLabelPaciente = New System.Windows.Forms.Label()
        Me.vLabelTitular = New System.Windows.Forms.Label()
        Me.vLabelTipo = New System.Windows.Forms.Label()
        Me.vLabelMedico = New System.Windows.Forms.Label()
        Me.vLabelEspecialidad = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.vLabelCodigo = New System.Windows.Forms.Label()
        Me.vLabelDescripción = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.vLabelPVenta = New System.Windows.Forms.Label()
        Me.vLabelIGV = New System.Windows.Forms.Label()
        Me.vLabelImporte = New System.Windows.Forms.Label()
        Me.vTextMedico = New System.Windows.Forms.Label()
        Me.vTextSeñor = New System.Windows.Forms.Label()
        Me.vTextDNI = New System.Windows.Forms.Label()
        Me.vTextFecha = New System.Windows.Forms.Label()
        Me.vTextHora = New System.Windows.Forms.Label()
        Me.vTextPaciente = New System.Windows.Forms.Label()
        Me.vTextTitular = New System.Windows.Forms.Label()
        Me.vTextTipo = New System.Windows.Forms.Label()
        Me.vTextEspecialidad = New System.Windows.Forms.Label()
        Me.vTextCodigo = New System.Windows.Forms.Label()
        Me.vTextDescripcion = New System.Windows.Forms.Label()
        Me.vTextPVenta = New System.Windows.Forms.Label()
        Me.vTextIGV = New System.Windows.Forms.Label()
        Me.vTextImporte = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(0, -1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(459, 618)
        Me.ReportViewer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CENTRO DE SALUD LIMA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(348, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Distrito Cercado de Lima, Provincia de Lima, Departemento de Lima"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(190, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Telf: 204-2100"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(174, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "BOLETA DE VENTA"
        '
        'vLabelSeñor
        '
        Me.vLabelSeñor.AutoSize = True
        Me.vLabelSeñor.BackColor = System.Drawing.Color.White
        Me.vLabelSeñor.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLabelSeñor.Location = New System.Drawing.Point(118, 196)
        Me.vLabelSeñor.Name = "vLabelSeñor"
        Me.vLabelSeñor.Size = New System.Drawing.Size(54, 14)
        Me.vLabelSeñor.TabIndex = 5
        Me.vLabelSeñor.Text = "Señor(a):"
        '
        'vLabelDNI
        '
        Me.vLabelDNI.AutoSize = True
        Me.vLabelDNI.BackColor = System.Drawing.Color.White
        Me.vLabelDNI.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLabelDNI.Location = New System.Drawing.Point(142, 216)
        Me.vLabelDNI.Name = "vLabelDNI"
        Me.vLabelDNI.Size = New System.Drawing.Size(30, 14)
        Me.vLabelDNI.TabIndex = 6
        Me.vLabelDNI.Text = "DNI:"
        '
        'vLabelFecha
        '
        Me.vLabelFecha.AutoSize = True
        Me.vLabelFecha.BackColor = System.Drawing.Color.White
        Me.vLabelFecha.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLabelFecha.Location = New System.Drawing.Point(75, 235)
        Me.vLabelFecha.Name = "vLabelFecha"
        Me.vLabelFecha.Size = New System.Drawing.Size(97, 14)
        Me.vLabelFecha.TabIndex = 7
        Me.vLabelFecha.Text = "Ficha de Emisión:"
        '
        'vLabelHora
        '
        Me.vLabelHora.AutoSize = True
        Me.vLabelHora.BackColor = System.Drawing.Color.White
        Me.vLabelHora.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLabelHora.Location = New System.Drawing.Point(137, 254)
        Me.vLabelHora.Name = "vLabelHora"
        Me.vLabelHora.Size = New System.Drawing.Size(35, 14)
        Me.vLabelHora.TabIndex = 8
        Me.vLabelHora.Text = "Hora:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(83, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(295, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "---------------------------------------------------------------------------------" &
    "---------------"
        '
        'vLabelPaciente
        '
        Me.vLabelPaciente.AutoSize = True
        Me.vLabelPaciente.BackColor = System.Drawing.Color.White
        Me.vLabelPaciente.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLabelPaciente.Location = New System.Drawing.Point(119, 290)
        Me.vLabelPaciente.Name = "vLabelPaciente"
        Me.vLabelPaciente.Size = New System.Drawing.Size(54, 14)
        Me.vLabelPaciente.TabIndex = 10
        Me.vLabelPaciente.Text = "Paciente:"
        '
        'vLabelTitular
        '
        Me.vLabelTitular.AutoSize = True
        Me.vLabelTitular.BackColor = System.Drawing.Color.White
        Me.vLabelTitular.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLabelTitular.Location = New System.Drawing.Point(130, 310)
        Me.vLabelTitular.Name = "vLabelTitular"
        Me.vLabelTitular.Size = New System.Drawing.Size(43, 14)
        Me.vLabelTitular.TabIndex = 11
        Me.vLabelTitular.Text = "Titular:"
        '
        'vLabelTipo
        '
        Me.vLabelTipo.AutoSize = True
        Me.vLabelTipo.BackColor = System.Drawing.Color.White
        Me.vLabelTipo.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLabelTipo.Location = New System.Drawing.Point(140, 330)
        Me.vLabelTipo.Name = "vLabelTipo"
        Me.vLabelTipo.Size = New System.Drawing.Size(33, 14)
        Me.vLabelTipo.TabIndex = 12
        Me.vLabelTipo.Text = "Tipo:"
        '
        'vLabelMedico
        '
        Me.vLabelMedico.AutoSize = True
        Me.vLabelMedico.BackColor = System.Drawing.Color.White
        Me.vLabelMedico.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLabelMedico.Location = New System.Drawing.Point(124, 349)
        Me.vLabelMedico.Name = "vLabelMedico"
        Me.vLabelMedico.Size = New System.Drawing.Size(49, 14)
        Me.vLabelMedico.TabIndex = 13
        Me.vLabelMedico.Text = "Médico:"
        '
        'vLabelEspecialidad
        '
        Me.vLabelEspecialidad.AutoSize = True
        Me.vLabelEspecialidad.BackColor = System.Drawing.Color.White
        Me.vLabelEspecialidad.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLabelEspecialidad.Location = New System.Drawing.Point(100, 368)
        Me.vLabelEspecialidad.Name = "vLabelEspecialidad"
        Me.vLabelEspecialidad.Size = New System.Drawing.Size(74, 14)
        Me.vLabelEspecialidad.TabIndex = 14
        Me.vLabelEspecialidad.Text = "Especialidad:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(83, 388)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(295, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "---------------------------------------------------------------------------------" &
    "---------------"
        '
        'vLabelCodigo
        '
        Me.vLabelCodigo.AutoSize = True
        Me.vLabelCodigo.BackColor = System.Drawing.Color.White
        Me.vLabelCodigo.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLabelCodigo.Location = New System.Drawing.Point(125, 406)
        Me.vLabelCodigo.Name = "vLabelCodigo"
        Me.vLabelCodigo.Size = New System.Drawing.Size(48, 14)
        Me.vLabelCodigo.TabIndex = 16
        Me.vLabelCodigo.Text = "Código:"
        '
        'vLabelDescripción
        '
        Me.vLabelDescripción.AutoSize = True
        Me.vLabelDescripción.BackColor = System.Drawing.Color.White
        Me.vLabelDescripción.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLabelDescripción.Location = New System.Drawing.Point(103, 425)
        Me.vLabelDescripción.Name = "vLabelDescripción"
        Me.vLabelDescripción.Size = New System.Drawing.Size(70, 14)
        Me.vLabelDescripción.TabIndex = 17
        Me.vLabelDescripción.Text = "Descripción:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(75, 446)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(295, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "---------------------------------------------------------------------------------" &
    "---------------"
        '
        'vLabelPVenta
        '
        Me.vLabelPVenta.AutoSize = True
        Me.vLabelPVenta.BackColor = System.Drawing.Color.White
        Me.vLabelPVenta.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLabelPVenta.Location = New System.Drawing.Point(83, 463)
        Me.vLabelPVenta.Name = "vLabelPVenta"
        Me.vLabelPVenta.Size = New System.Drawing.Size(91, 14)
        Me.vLabelPVenta.TabIndex = 19
        Me.vLabelPVenta.Text = "Precio de Venta:"
        '
        'vLabelIGV
        '
        Me.vLabelIGV.AutoSize = True
        Me.vLabelIGV.BackColor = System.Drawing.Color.White
        Me.vLabelIGV.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLabelIGV.Location = New System.Drawing.Point(83, 484)
        Me.vLabelIGV.Name = "vLabelIGV"
        Me.vLabelIGV.Size = New System.Drawing.Size(91, 14)
        Me.vLabelIGV.TabIndex = 20
        Me.vLabelIGV.Text = "I.G.V (IGV: 18%):"
        '
        'vLabelImporte
        '
        Me.vLabelImporte.AutoSize = True
        Me.vLabelImporte.BackColor = System.Drawing.Color.White
        Me.vLabelImporte.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLabelImporte.Location = New System.Drawing.Point(94, 506)
        Me.vLabelImporte.Name = "vLabelImporte"
        Me.vLabelImporte.Size = New System.Drawing.Size(80, 14)
        Me.vLabelImporte.TabIndex = 21
        Me.vLabelImporte.Text = "Importe Total:"
        '
        'vTextMedico
        '
        Me.vTextMedico.AutoSize = True
        Me.vTextMedico.Location = New System.Drawing.Point(182, 350)
        Me.vTextMedico.Name = "vTextMedico"
        Me.vTextMedico.Size = New System.Drawing.Size(0, 13)
        Me.vTextMedico.TabIndex = 22
        '
        'vTextSeñor
        '
        Me.vTextSeñor.AutoSize = True
        Me.vTextSeñor.Location = New System.Drawing.Point(182, 197)
        Me.vTextSeñor.Name = "vTextSeñor"
        Me.vTextSeñor.Size = New System.Drawing.Size(39, 13)
        Me.vTextSeñor.TabIndex = 23
        Me.vTextSeñor.Text = "Label8"
        '
        'vTextDNI
        '
        Me.vTextDNI.AutoSize = True
        Me.vTextDNI.Location = New System.Drawing.Point(182, 216)
        Me.vTextDNI.Name = "vTextDNI"
        Me.vTextDNI.Size = New System.Drawing.Size(39, 13)
        Me.vTextDNI.TabIndex = 24
        Me.vTextDNI.Text = "Label8"
        '
        'vTextFecha
        '
        Me.vTextFecha.AutoSize = True
        Me.vTextFecha.Location = New System.Drawing.Point(182, 236)
        Me.vTextFecha.Name = "vTextFecha"
        Me.vTextFecha.Size = New System.Drawing.Size(39, 13)
        Me.vTextFecha.TabIndex = 25
        Me.vTextFecha.Text = "Label8"
        '
        'vTextHora
        '
        Me.vTextHora.AutoSize = True
        Me.vTextHora.Location = New System.Drawing.Point(182, 254)
        Me.vTextHora.Name = "vTextHora"
        Me.vTextHora.Size = New System.Drawing.Size(39, 13)
        Me.vTextHora.TabIndex = 26
        Me.vTextHora.Text = "Label8"
        '
        'vTextPaciente
        '
        Me.vTextPaciente.AutoSize = True
        Me.vTextPaciente.Location = New System.Drawing.Point(182, 291)
        Me.vTextPaciente.Name = "vTextPaciente"
        Me.vTextPaciente.Size = New System.Drawing.Size(39, 13)
        Me.vTextPaciente.TabIndex = 27
        Me.vTextPaciente.Text = "Label8"
        '
        'vTextTitular
        '
        Me.vTextTitular.AutoSize = True
        Me.vTextTitular.Location = New System.Drawing.Point(182, 311)
        Me.vTextTitular.Name = "vTextTitular"
        Me.vTextTitular.Size = New System.Drawing.Size(39, 13)
        Me.vTextTitular.TabIndex = 28
        Me.vTextTitular.Text = "Label8"
        '
        'vTextTipo
        '
        Me.vTextTipo.AutoSize = True
        Me.vTextTipo.Location = New System.Drawing.Point(182, 331)
        Me.vTextTipo.Name = "vTextTipo"
        Me.vTextTipo.Size = New System.Drawing.Size(55, 13)
        Me.vTextTipo.TabIndex = 29
        Me.vTextTipo.Text = "PRIVADO"
        '
        'vTextEspecialidad
        '
        Me.vTextEspecialidad.AutoSize = True
        Me.vTextEspecialidad.Location = New System.Drawing.Point(182, 368)
        Me.vTextEspecialidad.Name = "vTextEspecialidad"
        Me.vTextEspecialidad.Size = New System.Drawing.Size(39, 13)
        Me.vTextEspecialidad.TabIndex = 30
        Me.vTextEspecialidad.Text = "Label8"
        '
        'vTextCodigo
        '
        Me.vTextCodigo.AutoSize = True
        Me.vTextCodigo.Location = New System.Drawing.Point(180, 407)
        Me.vTextCodigo.Name = "vTextCodigo"
        Me.vTextCodigo.Size = New System.Drawing.Size(39, 13)
        Me.vTextCodigo.TabIndex = 31
        Me.vTextCodigo.Text = "Label8"
        '
        'vTextDescripcion
        '
        Me.vTextDescripcion.AutoSize = True
        Me.vTextDescripcion.Location = New System.Drawing.Point(180, 426)
        Me.vTextDescripcion.Name = "vTextDescripcion"
        Me.vTextDescripcion.Size = New System.Drawing.Size(145, 13)
        Me.vTextDescripcion.TabIndex = 32
        Me.vTextDescripcion.Text = "CONSULTA AMBULATORIA"
        '
        'vTextPVenta
        '
        Me.vTextPVenta.AutoSize = True
        Me.vTextPVenta.Location = New System.Drawing.Point(180, 464)
        Me.vTextPVenta.Name = "vTextPVenta"
        Me.vTextPVenta.Size = New System.Drawing.Size(39, 13)
        Me.vTextPVenta.TabIndex = 33
        Me.vTextPVenta.Text = "Label8"
        '
        'vTextIGV
        '
        Me.vTextIGV.AutoSize = True
        Me.vTextIGV.Location = New System.Drawing.Point(180, 485)
        Me.vTextIGV.Name = "vTextIGV"
        Me.vTextIGV.Size = New System.Drawing.Size(28, 13)
        Me.vTextIGV.TabIndex = 34
        Me.vTextIGV.Text = "5.34"
        '
        'vTextImporte
        '
        Me.vTextImporte.AutoSize = True
        Me.vTextImporte.Location = New System.Drawing.Point(180, 507)
        Me.vTextImporte.Name = "vTextImporte"
        Me.vTextImporte.Size = New System.Drawing.Size(39, 13)
        Me.vTextImporte.TabIndex = 35
        Me.vTextImporte.Text = "Label8"
        '
        'Cita_Archivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 617)
        Me.Controls.Add(Me.vTextImporte)
        Me.Controls.Add(Me.vTextIGV)
        Me.Controls.Add(Me.vTextPVenta)
        Me.Controls.Add(Me.vTextDescripcion)
        Me.Controls.Add(Me.vTextCodigo)
        Me.Controls.Add(Me.vTextEspecialidad)
        Me.Controls.Add(Me.vTextTipo)
        Me.Controls.Add(Me.vTextTitular)
        Me.Controls.Add(Me.vTextPaciente)
        Me.Controls.Add(Me.vTextHora)
        Me.Controls.Add(Me.vTextFecha)
        Me.Controls.Add(Me.vTextDNI)
        Me.Controls.Add(Me.vTextSeñor)
        Me.Controls.Add(Me.vTextMedico)
        Me.Controls.Add(Me.vLabelImporte)
        Me.Controls.Add(Me.vLabelIGV)
        Me.Controls.Add(Me.vLabelPVenta)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.vLabelDescripción)
        Me.Controls.Add(Me.vLabelCodigo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.vLabelEspecialidad)
        Me.Controls.Add(Me.vLabelMedico)
        Me.Controls.Add(Me.vLabelTipo)
        Me.Controls.Add(Me.vLabelTitular)
        Me.Controls.Add(Me.vLabelPaciente)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.vLabelHora)
        Me.Controls.Add(Me.vLabelFecha)
        Me.Controls.Add(Me.vLabelDNI)
        Me.Controls.Add(Me.vLabelSeñor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Cita_Archivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cita"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents vLabelSeñor As Label
    Friend WithEvents vLabelDNI As Label
    Friend WithEvents vLabelFecha As Label
    Friend WithEvents vLabelHora As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents vLabelPaciente As Label
    Friend WithEvents vLabelTitular As Label
    Friend WithEvents vLabelTipo As Label
    Friend WithEvents vLabelMedico As Label
    Friend WithEvents vLabelEspecialidad As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents vLabelCodigo As Label
    Friend WithEvents vLabelDescripción As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents vLabelPVenta As Label
    Friend WithEvents vLabelIGV As Label
    Friend WithEvents vLabelImporte As Label
    Friend WithEvents vTextMedico As Label
    Friend WithEvents vTextSeñor As Label
    Friend WithEvents vTextDNI As Label
    Friend WithEvents vTextFecha As Label
    Friend WithEvents vTextHora As Label
    Friend WithEvents vTextPaciente As Label
    Friend WithEvents vTextTitular As Label
    Friend WithEvents vTextTipo As Label
    Friend WithEvents vTextEspecialidad As Label
    Friend WithEvents vTextCodigo As Label
    Friend WithEvents vTextDescripcion As Label
    Friend WithEvents vTextPVenta As Label
    Friend WithEvents vTextIGV As Label
    Friend WithEvents vTextImporte As Label
End Class
