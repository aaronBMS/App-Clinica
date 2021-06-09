Imports System.Data.SqlClient

Module ModCita
    Public Function RegistrarNuevaCita(ByVal Cita As Cita, ByVal DCita As Detalle_Cita) As Boolean
        Try
            Conex.Open()
            Comando = New SqlClient.SqlCommand("EXECUTE SP_REGISTRAR_CITA @ID_CITA,@DNI_PACIENTE,@DNI_DOCTOR,@DNI_ATENCION,@FECHA,@ESPECIALIDAD,@CONSULTORIO,@TURNO,@COSTO", Conex)
            Comando.Parameters.AddWithValue("@ID_CITA", Cita.Ident)
            Comando.Parameters.AddWithValue("@DNI_PACIENTE", Cita.Ident_Paciente)
            Comando.Parameters.AddWithValue("@DNI_DOCTOR", Cita.Ident_Doctor)
            Comando.Parameters.AddWithValue("@DNI_ATENCION", Cita.Ident_Atencion)
            Comando.Parameters.AddWithValue("@FECHA", Cita.Datee)
            Comando.Parameters.AddWithValue("@ESPECIALIDAD", DCita.Especiality)
            Comando.Parameters.AddWithValue("@CONSULTORIO", DCita.Surgery)
            Comando.Parameters.AddWithValue("@TURNO", DCita.Turn)
            Comando.Parameters.AddWithValue("@COSTO", DCita.Cost)
            Comando.ExecuteNonQuery()
            Conex.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Function ReportView_Cita(ByVal Codigo As Char())
        Try
            Conex.Open()
            Comando = New SqlClient.SqlCommand("EXECUTE SP_REPORT_VIEW " + Codigo, Conex)
            Dim reader As SqlDataReader
            reader = Comando.ExecuteReader
            While reader.Read
                Cita_Archivo.vTextSeñor.Text = reader.GetString(1).ToUpper + "," + reader.GetString(0).ToUpper
                Cita_Archivo.vTextPaciente.Text = reader.GetString(1).ToUpper + "," + reader.GetString(0).ToUpper
                Cita_Archivo.vTextTitular.Text = reader.GetString(1).ToUpper + "," + reader.GetString(0).ToUpper
                Cita_Archivo.vTextEspecialidad.Text = reader.GetString(3).ToUpper
                Cita_Archivo.vTextCodigo.Text = reader.GetString(2)
            End While
            Conex.Close()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString)
        End Try
    End Function

End Module
