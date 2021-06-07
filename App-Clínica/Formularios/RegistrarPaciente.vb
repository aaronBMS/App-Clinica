Public Class RegistrarPaciente

    Dim Imagen As String
    Dim Us As New Paciente
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

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
            Us.Phone = vTextTelefono.Text
            Us.Email = vTextCorreo.Text
            Us.Photo = ImgStr
            If CrearNuevoPaciente(Us) Then
                MsgBox("Usuario Registrado Correctamente")
            Else
                MsgBox("Error al Registrar")
            End If
        Catch ex As Exception
            MsgBox("Error de Excepción: " + ex.ToString)
        End Try
        Limpiar()
    End Sub

    Sub Limpiar()
        vTextID.Text = ""
        vTextNombre.Text = ""
        vTextApellido.Text = ""
        vTextTelefono.Text = ""
        vTextCorreo.Text = ""
        vPictureFoto.Image.Dispose()
        vPictureFoto.Image = Nothing
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Limpiar()
    End Sub

    Private Sub RegistrarPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class