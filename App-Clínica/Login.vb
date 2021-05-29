Public Class Login
    Private Sub vButtonIngresar_Click(sender As Object, e As EventArgs) Handles vButtonIngresar.Click
        Select Case validarUsuario(vTextUsuario.Text, vTextContraseña.Text)
            Case "Administrador"
                Dim Menu As MenuAdmin = New MenuAdmin
                MsgBox("Bienvenido")
                Me.Hide()
                Menu.Show()
            Case "Atención al Cliente"
                Dim Menu2 As MenuAtencion = New MenuAtencion
                MsgBox("Bienvenido")
                Me.Hide()
                Menu2.Show()
            Case "Doctor"
                Dim Menu3 As MenuDoctor = New MenuDoctor
                MsgBox("Bienvenido")
                Me.Hide()
                Menu3.Show()
        End Select

        Conex.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecction()
        vTextUsuario.Text = ""
        vTextContraseña.Text = ""
    End Sub

    Private Sub Login_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Conex.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
