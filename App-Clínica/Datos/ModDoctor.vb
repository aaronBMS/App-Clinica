Imports System.Data.SqlClient
Module ModDoctor

    Public Function CrearDoctor(ByVal Doctor As Doctor) As Boolean
        Try
            Conex.Open()
            Comando = New SqlClient.SqlCommand("EXECUTE SP_INSERTAR_DOCTOR @DNI,@NACIONALIDAD,@ESPECIALIDAD", Conex)
            Comando.Parameters.AddWithValue("@DNI", Doctor.Ident)
            Comando.Parameters.AddWithValue("@NACIONALIDAD", Doctor.Nacionality)
            Comando.Parameters.AddWithValue("@ESPECIALIDAD", Doctor.Especiality)
            Comando.ExecuteNonQuery()
            Conex.Close()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString)
        End Try
        Return True
    End Function

    Public Function RellenarComboBoxDoctor(ByVal Especialidad As String)
        Try
            Conex.Open()
            Comando = New SqlClient.SqlCommand("EXECUTE SP_BOXDOCTOR " + Especialidad, Conex)
            Dim reader As SqlDataReader
            reader = Comando.ExecuteReader
            While reader.Read
                RegistrarCita.vComboBoxDoctor.Items.Add(reader.GetString(0) + " - " + reader.GetString(1) + " " + reader.GetString(2))
            End While
            Conex.Close()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString)
        End Try
    End Function

End Module
