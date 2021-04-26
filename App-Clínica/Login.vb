Public Class Login
    Private Sub vButtonIngresar_Click(sender As Object, e As EventArgs) Handles vButtonIngresar.Click
        If validarUsuario(vTextUsuario.Text, vTextContraseña.Text) Then
            MsgBox("Bienvenido")
            Dim Menu As MenuAdmin = New MenuAdmin
            Me.Hide()
            Menu.Show()
        Else
            MsgBox("Datos Incorrectos")
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecction()
        Dim Menu As MenuAdmin = New MenuAdmin
        Menu.vLabelConectado.Text = Estado
    End Sub

    Private Sub Login_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub
End Class
