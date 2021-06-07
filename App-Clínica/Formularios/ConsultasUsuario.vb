Imports System.Data.SqlClient

Public Class ConsultasUsuario

    Dim Us As New Usuario

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles vButtonConsultar.Click
        ConsultarUsuario(vtxtBuscar.Text)
    End Sub

    Private Sub vButtonCancelar_Click(sender As Object, e As EventArgs) Handles vButtonCancelar.Click
        Limpiar()
        vtxtBuscar.Enabled = True
        vtxtBuscar.Focus()
    End Sub

    Sub Limpiar()
        vtxtBuscar.Text = ""
        vTextNombre.Text = ""
        vTextApellido.Text = ""
        vTextCorreo.Text = ""
        vComboCargo.Text = ""
        vTextUsuario.Text = ""
        vTextContraseña.Text = ""
    End Sub

    Private Sub vButtonActualizar_Click(sender As Object, e As EventArgs) Handles vButtonActualizar.Click
        Try
            Us.Name = vTextNombre.Text
            Us.LastName = vTextApellido.Text
            Us.Email = vTextCorreo.Text
            Us.Work = vComboCargo.Text
            Us.User = vTextUsuario.Text
            Us.Password = vTextContraseña.Text
            If ActualizarUsuario(Us, vtxtBuscar.Text) Then
                MsgBox("Usuario Actualizado")
            Else
                MsgBox("Error al Actualizar")
            End If
        Catch ex As Exception
            MsgBox("Error de Excepción: " + ex.ToString)
        End Try
        Limpiar()
        rellenarTabla()
        vtxtBuscar.Enabled = True
    End Sub

    Private Sub vButtonEliminar_Click(sender As Object, e As EventArgs) Handles vButtonEliminar.Click
        Try
            If EliminarUsuario(vtxtBuscar.Text) Then
                MsgBox("Usuario Eliminado")
            Else
                MsgBox("Error al Eliminar")
            End If
        Catch ex As Exception
            MsgBox("Error de Excepción: " + ex.ToString)
        End Try
        Limpiar()
        rellenarTabla()
        vtxtBuscar.Enabled = True
    End Sub

    Private Sub vtxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles vtxtBuscar.TextChanged
        If (vtxtBuscar.Text <> "") Then
            filtrarTablaUsuarios(vtxtBuscar.Text)
        Else
            rellenarTabla()
        End If
    End Sub
End Class