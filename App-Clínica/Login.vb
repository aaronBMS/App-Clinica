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
        Conex.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecction()
    End Sub

    Private Sub Login_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Conex.Close()
    End Sub
End Class
