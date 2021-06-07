Public Class ConsultasPaciente

    Dim Us As New Paciente

    Private Sub vButtonConsultar_Click(sender As Object, e As EventArgs) Handles vButtonConsultar.Click
        ConsultarPaciente(vtxtBuscar.Text)
    End Sub

    Private Sub vButtonActualizar_Click(sender As Object, e As EventArgs) Handles vButtonActualizar.Click
        Try
            Us.Name = vTextNombre.Text
            Us.LastName = vTextApellido.Text
            Us.Phone = vTextTelefono.Text
            Us.Email = vTextCorreo.Text
            If ActualizarPaciente(Us, vtxtBuscar.Text) Then
                MsgBox("Usuario Actualizado")
            Else
                MsgBox("Error al Actualizar")
            End If
        Catch ex As Exception
            MsgBox("Error de Excepción: " + ex.ToString)
        End Try
        Limpiar()
        rellenarTablaPaciente()
        vtxtBuscar.Enabled = True
    End Sub

    Sub Limpiar()
        vtxtBuscar.Text = ""
        vTextNombre.Text = ""
        vTextApellido.Text = ""
        vTextTelefono.Text = ""
        vTextCorreo.Text = ""
    End Sub

    Private Sub vButtonCancelar_Click(sender As Object, e As EventArgs) Handles vButtonCancelar.Click
        Limpiar()
    End Sub

    Private Sub vtxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles vtxtBuscar.TextChanged
        If vtxtBuscar.Text <> "" Then
            filtrarTablaPacientes(vtxtBuscar.Text)
        Else
            rellenarTablaPaciente()
        End If
    End Sub
End Class