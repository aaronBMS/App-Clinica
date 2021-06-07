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
            Return False
        End Try
    End Function

End Module
