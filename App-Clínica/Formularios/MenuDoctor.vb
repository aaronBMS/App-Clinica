Public Class MenuDoctor
    Private Sub MenuDoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub vPanelOpciones_Paint(sender As Object, e As PaintEventArgs) Handles vPanelOpciones.Paint

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