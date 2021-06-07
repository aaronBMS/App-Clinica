<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAtencion
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
        Me.vPanelOpciones = New System.Windows.Forms.Panel()
        Me.vLabelConectado = New System.Windows.Forms.Label()
        Me.vLabelEstado = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.vPanelAdmin = New System.Windows.Forms.Panel()
        Me.vPanelOpciones.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'vPanelOpciones
        '
        Me.vPanelOpciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.vPanelOpciones.Controls.Add(Me.vLabelConectado)
        Me.vPanelOpciones.Controls.Add(Me.vLabelEstado)
        Me.vPanelOpciones.Controls.Add(Me.PictureBox1)
        Me.vPanelOpciones.Controls.Add(Me.Button4)
        Me.vPanelOpciones.Controls.Add(Me.Button3)
        Me.vPanelOpciones.Controls.Add(Me.Button2)
        Me.vPanelOpciones.Controls.Add(Me.Button1)
        Me.vPanelOpciones.Location = New System.Drawing.Point(0, 26)
        Me.vPanelOpciones.Name = "vPanelOpciones"
        Me.vPanelOpciones.Size = New System.Drawing.Size(290, 530)
        Me.vPanelOpciones.TabIndex = 2
        '
        'vLabelConectado
        '
        Me.vLabelConectado.AutoSize = True
        Me.vLabelConectado.Font = New System.Drawing.Font("Leelawadee UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLabelConectado.Location = New System.Drawing.Point(132, 288)
        Me.vLabelConectado.Name = "vLabelConectado"
        Me.vLabelConectado.Size = New System.Drawing.Size(0, 15)
        Me.vLabelConectado.TabIndex = 9
        '
        'vLabelEstado
        '
        Me.vLabelEstado.AutoSize = True
        Me.vLabelEstado.Font = New System.Drawing.Font("Leelawadee UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLabelEstado.Location = New System.Drawing.Point(21, 288)
        Me.vLabelEstado.Name = "vLabelEstado"
        Me.vLabelEstado.Size = New System.Drawing.Size(109, 15)
        Me.vLabelEstado.TabIndex = 8
        Me.vLabelEstado.Text = "Usuario conectado:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(33, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(217, 224)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(3, 479)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(283, 47)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Salir"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(3, 430)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(283, 47)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Generar Cita"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(3, 379)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(283, 49)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Lista de Pacientes"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(3, 325)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(283, 52)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Registrar Paciente"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.HerramientasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1057, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AyudaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'vPanelAdmin
        '
        Me.vPanelAdmin.BackgroundImage = Global.App_Clínica.My.Resources.Resources.FondoSec
        Me.vPanelAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.vPanelAdmin.Location = New System.Drawing.Point(290, 26)
        Me.vPanelAdmin.Name = "vPanelAdmin"
        Me.vPanelAdmin.Size = New System.Drawing.Size(767, 530)
        Me.vPanelAdmin.TabIndex = 4
        '
        'MenuAtencion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 556)
        Me.Controls.Add(Me.vPanelAdmin)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.vPanelOpciones)
        Me.Name = "MenuAtencion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Centro de Salud Lima - Menu"
        Me.vPanelOpciones.ResumeLayout(False)
        Me.vPanelOpciones.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents vPanelOpciones As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents vPanelAdmin As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents vLabelConectado As Label
    Friend WithEvents vLabelEstado As Label
End Class
