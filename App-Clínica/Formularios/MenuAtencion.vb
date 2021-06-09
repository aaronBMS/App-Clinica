Public Class MenuAtencion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RegistrarCita.vComboBoxDoctor.Items.Clear()
        ConsultasPaciente.Hide()
        RegistrarCita.Hide()
        RegistrarPaciente.TopLevel = False
        RegistrarPaciente.Show()
        Me.vPanelAdmin.Controls.Add(RegistrarPaciente)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RegistrarCita.vComboBoxDoctor.Items.Clear()
        RegistrarPaciente.Hide()
        RegistrarCita.Hide()
        ConsultasPaciente.TopLevel = False
        ConsultasPaciente.Show()
        Me.vPanelAdmin.Controls.Add(ConsultasPaciente)
        rellenarTablaPaciente()
    End Sub

    Private Sub MenuAtencion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vLabelConectado.Text = Login.vTextUsuario.Text
    End Sub

    Private Sub MenuAtencion_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim imagen As Image
        Try
            imagen = BytesToImage(stringToByte(vLabelConectado.Text))
            PictureBox1.Image = imagen
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RegistrarPaciente.Hide()
        ConsultasPaciente.Hide()
        RegistrarCita.TopLevel = False
        RegistrarCita.Show()
        RegistrarCita.vLag.Text = vLabelConectado.Text
        Me.vPanelAdmin.Controls.Add(RegistrarCita)
        rellenarTablaPaciente()
        RegistrarCita.vCodigo.Focus()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Login.Show()
        Login.vTextUsuario.Text = ""
        Login.vTextContraseña.Text = ""
        Login.vTextUsuario.Focus()
        Conex.Open()
    End Sub
End Class