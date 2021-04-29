Public Class MenuAdmin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ConsultasUsuario.vComboBuscar.Items.Clear()
        ConsultasUsuario.Hide()
        CrearUsuario.TopLevel = False
        CrearUsuario.Show()
        Me.vPanelAdmin.Controls.Add(CrearUsuario)
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim Login As New Login
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub MenuAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ConsultasUsuario.vComboBuscar.Items.Clear()
        Me.Hide()
        Login.Show()
        Conex.Open()
        Dim Log As Login
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CrearUsuario.Hide()
        ConsultasUsuario.TopLevel = False
        ConsultasUsuario.Show()
        Me.vPanelAdmin.Controls.Add(ConsultasUsuario)
        rellenarTabla()
        RellenarComboBox()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ConsultasUsuario.vComboBuscar.Items.Clear()
    End Sub
End Class