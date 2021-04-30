Imports System.Data.SqlClient

Public Class ConsultasUsuario

    Dim Us As New Usuario
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ConsultasUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles vButtonConsultar.Click
        ConsultarUsuario(vComboBuscar.Text)
    End Sub

    Private Sub vButtonCancelar_Click(sender As Object, e As EventArgs) Handles vButtonCancelar.Click
        Limpiar()
        vComboBuscar.Enabled = True
    End Sub

    Sub Limpiar()
        vComboBuscar.Text = ""
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
            If ActualizarUsuario(Us, vComboBuscar.Text) Then
                MsgBox("Usuario Actualizado")
            Else
                MsgBox("Error al Actualizar")
            End If
        Catch ex As Exception
            MsgBox("Error de Excepción: " + ex.ToString)
        End Try
        Limpiar()
        rellenarTabla()
        vComboBuscar.Enabled = True
    End Sub

    Private Sub vButtonEliminar_Click(sender As Object, e As EventArgs) Handles vButtonEliminar.Click
        Try
            If EliminarUsuario(vComboBuscar.Text) Then
                MsgBox("Usuario Eliminado")
            Else
                MsgBox("Error al Eliminar")
            End If
        Catch ex As Exception
            MsgBox("Error de Excepción: " + ex.ToString)
        End Try
        Limpiar()
        rellenarTabla()
        vComboBuscar.Enabled = True
    End Sub

    Private Sub vDataTableUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles vDataTableUser.CellContentClick

    End Sub
End Class