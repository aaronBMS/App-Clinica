Imports System.Data.SqlClient
Imports System.IO

Module ModUsuario

    Public Function CrearNuevoUsuario(ByVal User As Usuario) As Boolean
        Try
            Conex.Open()
            Comando = New SqlClient.SqlCommand("INSERT INTO USUARIOS VALUES(@ID,@NOMBRE,@APELLIDO,@CORREO,@CARGO,@USUARIO,@CONTRASEÑA,@FOTO)", Conex)
            Comando.Parameters.AddWithValue("@ID", User.Ident)
            Comando.Parameters.AddWithValue("@NOMBRE", User.Name)
            Comando.Parameters.AddWithValue("@APELLIDO", User.LastName)
            Comando.Parameters.AddWithValue("@CORREO", User.Email)
            Comando.Parameters.AddWithValue("@CARGO", User.Work)
            Comando.Parameters.AddWithValue("@USUARIO", User.User)
            Comando.Parameters.AddWithValue("@CONTRASEÑA", User.Password)
            Comando.Parameters.AddWithValue("@FOTO", User.Photo)
            Comando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function bytesToString(ByVal arr As Byte()) As String
        Dim retorno As String = ""
        Dim x As Integer = 0
        Try
            For x = 0 To arr.Length - 1
                retorno += arr(x).ToString + ","
            Next
        Catch ex As Exception
            MsgBox("Error al convertir a String: " + ex.ToString)
        End Try
        Return retorno
    End Function

    Function imageToBytes(ByVal Imagen As Image) As Byte()
        Dim arr As Byte() = Nothing
        Try
            If Not Imagen Is Nothing Then
                Dim Bin As New MemoryStream
                Imagen.Save(Bin, Imaging.ImageFormat.Png)
                arr = Bin.GetBuffer
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("Error al Convertir a Bytes: " + ex.ToString)
        End Try
        Return arr
    End Function

    Function validarUsuario(ByVal Usuario As String, ByVal Contra As String) As Boolean
        Try
            Comando = New SqlClient.SqlCommand("SELECT * FROM USUARIOS WHERE USUARIO='" + Usuario + "' AND CONTRASEÑA='" + Contra + "'", Conex)
            Dim reader As SqlDataReader
            reader = Comando.ExecuteReader
            If reader.HasRows <> False Then
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

End Module
