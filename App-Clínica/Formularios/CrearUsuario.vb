Public Class CrearUsuario

    Dim Imagen As String
    Dim Us As New Usuario
    Private Sub vButtonSalir_Click(sender As Object, e As EventArgs) Handles vButtonSalir.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ImgStr As String
        Dim Img As Image
        Img = vPictureFoto.Image
        ImgStr = bytesToString(imageToBytes(Img))

        Try
            Us.Ident = vTextID.Text
            Us.Name = vTextNombre.Text
            Us.LastName = vTextApellido.Text
            Us.Email = vTextCorreo.Text
            Us.Work = vComboCargo.Text
            Us.User = vTextUsuario.Text
            Us.Password = vTextContraseña.Text
            Us.Photo = ImgStr
            If CrearNuevoUsuario(Us) Then
                MsgBox("Usuario Registrado Correctamente")
            Else
                MsgBox("Error al Registrar")
            End If
        Catch ex As Exception
            MsgBox("Error de Excepción: " + ex.ToString)
        End Try
        Limpiar()

    End Sub

    Private Sub vPictureFoto_Click(sender As Object, e As EventArgs) Handles vPictureFoto.Click
        Try
            Me.OpenFileDialog1.ShowDialog()
            Imagen = OpenFileDialog1.FileName
        Catch ex As Exception
            MsgBox("Error")
        End Try
        vPictureFoto.Load(Imagen)
        vPictureFoto.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Sub Limpiar()
        vTextID.Text = ""
        vTextNombre.Text = ""
        vTextApellido.Text = ""
        vTextCorreo.Text = ""
        vComboCargo.Text = ""
        vTextUsuario.Text = ""
        vTextContraseña.Text = Nothing
        vPictureFoto.Image.Dispose()
        vPictureFoto.Image = Nothing
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Limpiar()
    End Sub

    Private Sub CrearUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class