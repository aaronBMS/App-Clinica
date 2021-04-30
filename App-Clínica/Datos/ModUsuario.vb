Imports System.Data.SqlClient
Imports System.IO

Module ModUsuario

    Public Function CrearNuevoUsuario(ByVal User As Usuario) As Boolean
        Try
            Conex.Open()
            Comando = New SqlClient.SqlCommand("INSERT INTO USUARIO VALUES(@ID,@NOMBRE,@APELLIDO,@CORREO,@CARGO,@USUARIO,@CONTRASEÑA,@FOTO)", Conex)
            Comando.Parameters.AddWithValue("@ID", User.Ident)
            Comando.Parameters.AddWithValue("@NOMBRE", User.Name)
            Comando.Parameters.AddWithValue("@APELLIDO", User.LastName)
            Comando.Parameters.AddWithValue("@CORREO", User.Email)
            Comando.Parameters.AddWithValue("@CARGO", User.Work)
            Comando.Parameters.AddWithValue("@USUARIO", User.User)
            Comando.Parameters.AddWithValue("@CONTRASEÑA", User.Password)
            Comando.Parameters.AddWithValue("@FOTO", User.Photo)
            Comando.ExecuteNonQuery()
            Conex.Close()
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

    Function validarUsuario(ByVal Usuario As String, ByVal Contra As String) As String
        Try
            Comando = New SqlClient.SqlCommand("SELECT * FROM USUARIO WHERE USUARIO='" + Usuario + "' AND CONTRASEÑA='" + Contra + "'", Conex)
            Dim reader As SqlDataReader
            reader = Comando.ExecuteReader
            If reader.HasRows <> False Then
                While reader.Read
                    Return reader.GetString(4)
                End While
            End If
        Catch ex As Exception
            Return MsgBox("Error: " + ex.ToString)
        End Try
    End Function

    Sub rellenarTabla()
        Dim CU As ConsultasUsuario = New ConsultasUsuario
        Try
            Dim da As New SqlDataAdapter(“SELECT ID,NOMBRE,APELLIDO,CORREO,CARGO FROM USUARIO”, Conex)
            Dim ds As New DataSet
            da.Fill(ds)
            ConsultasUsuario.vDataTableUser.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Sub ConsultarUsuario(ByVal Codigo As Char())
        Try
            Conex.Open()
            Comando = New SqlClient.SqlCommand("SELECT * FROM USUARIO WHERE ID='" + Codigo + "'", Conex)
            Dim reader As SqlDataReader
            reader = Comando.ExecuteReader
            While reader.Read
                ConsultasUsuario.vTextNombre.Text = reader.GetString(1)
                ConsultasUsuario.vTextApellido.Text = reader.GetString(2)
                ConsultasUsuario.vTextCorreo.Text = reader.GetString(3)
                ConsultasUsuario.vComboCargo.SelectedItem = reader.GetString(4)
                ConsultasUsuario.vTextUsuario.Text = reader.GetString(5)
                ConsultasUsuario.vTextContraseña.Text = reader.GetString(6)
            End While
            ConsultasUsuario.vComboBuscar.Enabled = False
            Conex.Close()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString)
        End Try
    End Sub

    Sub RellenarComboBox()
        Try
            Conex.Open()
            Comando = New SqlClient.SqlCommand("SELECT * FROM USUARIO", Conex)
            Dim reader As SqlDataReader
            reader = Comando.ExecuteReader
            While reader.Read
                ConsultasUsuario.vComboBuscar.Items.Add(reader.GetString(0))
            End While
            Conex.Close()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString)
        End Try
    End Sub

    Public Function ActualizarUsuario(ByVal User As Usuario, ByVal Code As Char()) As Boolean
        Try
            Conex.Open()
            Comando = New SqlClient.SqlCommand("UPDATE USUARIO SET NOMBRE='" + User.Name + "',APELLIDO='" + User.LastName + "',CORREO='" + User.Email + "',CARGO='" + User.Work + "',USUARIO='" + User.User + "',CONTRASEÑA='" + User.Password + "' WHERE ID='" + Code + "'", Conex)
            Comando.ExecuteNonQuery()
            Conex.Close()
            Return True
        Catch ex As Exception
            MsgBox("Error:" + ex.ToString)
        End Try
    End Function

    Public Function EliminarUsuario(ByVal Code As Char()) As Boolean
        Try
            Conex.Open()
            Comando = New SqlClient.SqlCommand("DELETE USUARIO WHERE ID=" + Code + "", Conex)
            Comando.ExecuteNonQuery()
            Conex.Close()
            Return True
        Catch ex As Exception
            MsgBox("Error:" + ex.ToString)
        End Try
    End Function

End Module
