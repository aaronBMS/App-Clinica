Imports System.Data.SqlClient

Module ModPaciente

    Public Function CrearNuevoPaciente(ByVal Pacient As Paciente) As Boolean
        Try
            Conex.Open()
            Comando = New SqlClient.SqlCommand("INSERT INTO PACIENTE VALUES(@ID,@NOMBRE,@APELLIDO,@TELEFONO,@CORREO,@FOTO)", Conex)
            Comando.Parameters.AddWithValue("@ID", Pacient.Ident)
            Comando.Parameters.AddWithValue("@NOMBRE", Pacient.Name)
            Comando.Parameters.AddWithValue("@APELLIDO", Pacient.LastName)
            Comando.Parameters.AddWithValue("@TELEFONO", Pacient.Phone)
            Comando.Parameters.AddWithValue("@CORREO", Pacient.Email)
            Comando.Parameters.AddWithValue("@FOTO", Pacient.Photo)
            Comando.ExecuteNonQuery()
            Conex.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Sub rellenarTablaPaciente()
        Dim CU As ConsultasPaciente = New ConsultasPaciente
        Try
            Dim da As New SqlDataAdapter(“SELECT ID_PACIENTE,NOMBRE,APELLIDO,TELEFONO,CORREO FROM PACIENTE”, Conex)
            Dim ds As New DataSet
            da.Fill(ds)
            ConsultasPaciente.vDataTableUser.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString)
        End Try
    End Sub

    Sub ConsultarPaciente(ByVal Codigo As Char())
        Try
            Conex.Open()
            Comando = New SqlClient.SqlCommand("SELECT * FROM PACIENTE WHERE ID_PACIENTE='" + Codigo + "'", Conex)
            Dim reader As SqlDataReader
            reader = Comando.ExecuteReader
            While reader.Read
                ConsultasPaciente.vTextNombre.Text = reader.GetString(1)
                ConsultasPaciente.vTextApellido.Text = reader.GetString(2)
                ConsultasPaciente.vTextTelefono.Text = reader.GetInt32(3)
                ConsultasPaciente.vTextCorreo.Text = reader.GetString(4)
            End While
            ConsultasPaciente.vComboBuscar.Enabled = False
            Conex.Close()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString)
        End Try
    End Sub

    Sub RellenarComboBoxPaciente()
        Try
            Conex.Open()
            Comando = New SqlClient.SqlCommand("SELECT * FROM PACIENTE", Conex)
            Dim reader As SqlDataReader
            reader = Comando.ExecuteReader
            While reader.Read
                ConsultasPaciente.vComboBuscar.Items.Add(reader.GetString(0))
            End While
            Conex.Close()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString)
        End Try
    End Sub

    Public Function ActualizarPaciente(ByVal Pacient As Paciente, ByVal Code As Char()) As Boolean
        Try
            Conex.Open()
            Comando = New SqlClient.SqlCommand("UPDATE PACIENTE SET NOMBRE='" + Pacient.Name + "',APELLIDO='" + Pacient.LastName + "',TELEFONO=" + Pacient.Phone.ToString + ",CORREO='" + Pacient.Email + "' WHERE ID_PACIENTE='" + Code + "'", Conex)
            Comando.ExecuteNonQuery()
            Conex.Close()
            Return True
        Catch ex As Exception
            MsgBox("Error:" + ex.ToString)
        End Try
    End Function

End Module
