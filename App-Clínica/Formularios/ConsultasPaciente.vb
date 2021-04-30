Public Class ConsultasPaciente

    Dim Us As New Paciente
    Private Sub vTextUsuario_TextChanged(sender As Object, e As EventArgs) Handles vTextTelefono.TextChanged

    End Sub

    Private Sub vLabelUsuario_Click(sender As Object, e As EventArgs) Handles vLabelUsuario.Click

    End Sub

    Private Sub vLabelCorreo_Click(sender As Object, e As EventArgs) Handles vLabelCorreo.Click

    End Sub

    Private Sub vTextCorreo_TextChanged(sender As Object, e As EventArgs) Handles vTextCorreo.TextChanged

    End Sub

    Private Sub vButtonConsultar_Click(sender As Object, e As EventArgs) Handles vButtonConsultar.Click
        ConsultarPaciente(vComboBuscar.Text)
    End Sub

    Private Sub vButtonActualizar_Click(sender As Object, e As EventArgs) Handles vButtonActualizar.Click
        Try
            Us.Name = vTextNombre.Text
            Us.LastName = vTextApellido.Text
            Us.Phone = vTextTelefono.Text
            Us.Email = vTextCorreo.Text
            If ActualizarPaciente(Us, vComboBuscar.Text) Then
                MsgBox("Usuario Actualizado")
            Else
                MsgBox("Error al Actualizar")
            End If
        Catch ex As Exception
            MsgBox("Error de Excepción: " + ex.ToString)
        End Try
        Limpiar()
        rellenarTablaPaciente()
        vComboBuscar.Enabled = True
    End Sub

    Sub Limpiar()
        vComboBuscar.Text = ""
        vTextNombre.Text = ""
        vTextApellido.Text = ""
        vTextTelefono.Text = ""
        vTextCorreo.Text = ""
    End Sub

    Private Sub vButtonCancelar_Click(sender As Object, e As EventArgs) Handles vButtonCancelar.Click
        Limpiar()
    End Sub
End Class