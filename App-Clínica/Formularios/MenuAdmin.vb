Public Class MenuAdmin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
        Conex.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
    End Sub
End Class