Imports System.Data.SqlClient

Public Class ConsultasUsuario
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

End Class