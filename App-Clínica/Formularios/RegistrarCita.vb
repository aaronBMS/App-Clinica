Public Class RegistrarCita

    Dim Ci As New Cita
    Dim Dci As New Detalle_Cita
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles vComboEspecialidad.SelectedIndexChanged
        If vComboEspecialidad.Text = "ALERGIAS" Then
            vComboConsultorio.Items.Clear()
            vComboConsultorio.Items.Add("102-A")
            vComboConsultorio.Items.Add("102-B")
            vComboConsultorio.Items.Add("103-A")
            vComboConsultorio.Items.Add("103-B")
            vTextCosto.Text = ""
            vTextCosto.Text = "35.00"
        ElseIf vComboEspecialidad.Text = "CARDIOLOGÍA" Then
            vComboConsultorio.Items.Clear()
            vComboConsultorio.Items.Add("104-A")
            vComboConsultorio.Items.Add("104-B")
            vComboConsultorio.Items.Add("105-A")
            vComboConsultorio.Items.Add("105-B")
            vTextCosto.Text = ""
            vTextCosto.Text = "45.00"
        ElseIf vComboEspecialidad.Text = "DERMATOLOGÍA" Then
            vComboConsultorio.Items.Clear()
            vComboConsultorio.Items.Add("106-A")
            vComboConsultorio.Items.Add("106-B")
            vComboConsultorio.Items.Add("107-A")
            vComboConsultorio.Items.Add("107-B")
            vTextCosto.Text = ""
            vTextCosto.Text = "30.00"
        ElseIf vComboEspecialidad.Text = "ENDOCRINOLOGÍA" Then
            vComboConsultorio.Items.Clear()
            vComboConsultorio.Items.Add("108-A")
            vComboConsultorio.Items.Add("108-B")
            vComboConsultorio.Items.Add("109-A")
            vComboConsultorio.Items.Add("109-B")
            vTextCosto.Text = ""
            vTextCosto.Text = "35.00"
        ElseIf vComboEspecialidad.Text = "GASTROENTEROLOGÍA" Then
            vComboConsultorio.Items.Clear()
            vComboConsultorio.Items.Add("110-A")
            vComboConsultorio.Items.Add("110-B")
            vComboConsultorio.Items.Add("111-A")
            vComboConsultorio.Items.Add("111-B")
            vTextCosto.Text = ""
            vTextCosto.Text = "35.00"
        ElseIf vComboEspecialidad.Text = "GERIATRÍA" Then
            vComboConsultorio.Items.Clear()
            vComboConsultorio.Items.Add("112-A")
            vComboConsultorio.Items.Add("112-B")
            vComboConsultorio.Items.Add("113-A")
            vComboConsultorio.Items.Add("113-B")
            vTextCosto.Text = ""
            vTextCosto.Text = "30.00"
        ElseIf vComboEspecialidad.Text = "GINECOLOGÍA" Then
            vComboConsultorio.Items.Clear()
            vComboConsultorio.Items.Add("114-A")
            vComboConsultorio.Items.Add("114-B")
            vComboConsultorio.Items.Add("115-A")
            vComboConsultorio.Items.Add("115-B")
            vTextCosto.Text = ""
            vTextCosto.Text = "35.00"
        ElseIf vComboEspecialidad.Text = "MEDICINA" Then
            vComboConsultorio.Items.Clear()
            vComboConsultorio.Items.Add("116-A")
            vComboConsultorio.Items.Add("116-B")
            vComboConsultorio.Items.Add("117-A")
            vTextCosto.Text = ""
            vTextCosto.Text = "30.00"
            vComboConsultorio.Items.Add("117-B")
        ElseIf vComboEspecialidad.Text = "NEUMOLOGÍA" Then
            vComboConsultorio.Items.Clear()
            vComboConsultorio.Items.Add("118-A")
            vComboConsultorio.Items.Add("118-B")
            vComboConsultorio.Items.Add("119-A")
            vComboConsultorio.Items.Add("119-B")
            vTextCosto.Text = ""
            vTextCosto.Text = "45.00"
        ElseIf vComboEspecialidad.Text = "NUTRICIÓN" Then
            vComboConsultorio.Items.Clear()
            vComboConsultorio.Items.Add("120-A")
            vComboConsultorio.Items.Add("120-B")
            vComboConsultorio.Items.Add("121-A")
            vComboConsultorio.Items.Add("121-B")
            vTextCosto.Text = ""
            vTextCosto.Text = "25.00"
        ElseIf vComboEspecialidad.Text = "ODONTOLOGÍA" Then
            vComboConsultorio.Items.Clear()
            vComboConsultorio.Items.Add("122-A")
            vComboConsultorio.Items.Add("122-B")
            vComboConsultorio.Items.Add("123-A")
            vComboConsultorio.Items.Add("123-B")
            vTextCosto.Text = ""
            vTextCosto.Text = "30.00"
        ElseIf vComboEspecialidad.Text = "OFTALMOLOGÍA" Then
            vComboConsultorio.Items.Clear()
            vComboConsultorio.Items.Add("124-A")
            vComboConsultorio.Items.Add("124-B")
            vComboConsultorio.Items.Add("125-A")
            vComboConsultorio.Items.Add("125-B")
            vTextCosto.Text = ""
            vTextCosto.Text = "35.00"
        ElseIf vComboEspecialidad.Text = "PEDIATRÍA" Then
            vComboConsultorio.Items.Clear()
            vComboConsultorio.Items.Add("126-A")
            vComboConsultorio.Items.Add("126-B")
            vComboConsultorio.Items.Add("127-A")
            vComboConsultorio.Items.Add("127-B")
            vTextCosto.Text = ""
            vTextCosto.Text = "30.00"
        ElseIf vComboEspecialidad.Text = "PSICOLOGÍA" Then
            vComboConsultorio.Items.Clear()
            vComboConsultorio.Items.Add("128-A")
            vComboConsultorio.Items.Add("128-B")
            vComboConsultorio.Items.Add("129-A")
            vComboConsultorio.Items.Add("129-B")
            vTextCosto.Text = ""
            vTextCosto.Text = "35.00"
        ElseIf vComboEspecialidad.Text = "PSIQUIATRÍA" Then
            vComboConsultorio.Items.Clear()
            vComboConsultorio.Items.Add("130-A")
            vComboConsultorio.Items.Add("130-B")
            vComboConsultorio.Items.Add("131-A")
            vComboConsultorio.Items.Add("131-B")
            vTextCosto.Text = ""
            vTextCosto.Text = "40.00"
        ElseIf vComboEspecialidad.Text = "REUMATOLOGÍA" Then
            vComboConsultorio.Items.Clear()
            vComboConsultorio.Items.Add("132-A")
            vComboConsultorio.Items.Add("132-B")
            vComboConsultorio.Items.Add("133-A")
            vComboConsultorio.Items.Add("133-B")
            vTextCosto.Text = ""
            vTextCosto.Text = "35.00"
        ElseIf vComboEspecialidad.Text = "TRAUMATOLOGÍA" Then
            vComboConsultorio.Items.Clear()
            vComboConsultorio.Items.Add("134-A")
            vComboConsultorio.Items.Add("134-B")
            vComboConsultorio.Items.Add("135-A")
            vComboConsultorio.Items.Add("135-B")
            vTextCosto.Text = ""
            vTextCosto.Text = "45.00"
        ElseIf vComboEspecialidad.Text = "UROLOGÍA" Then
            vComboConsultorio.Items.Clear()
            vComboConsultorio.Items.Add("136-A")
            vComboConsultorio.Items.Add("136-B")
            vComboConsultorio.Items.Add("137-A")
            vComboConsultorio.Items.Add("137-B")
            vTextCosto.Text = ""
            vTextCosto.Text = "35.00"
        End If

        vComboBoxDoctor.Items.Clear()
        RellenarComboBoxDoctor(vComboEspecialidad.Text)

    End Sub

    Private Sub vComboBoxDoctor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles vComboBoxDoctor.SelectedIndexChanged

    End Sub

    Private Sub vTextID_TextChanged(sender As Object, e As EventArgs) Handles vtxtBuscar.TextChanged
        If vtxtBuscar.Text <> "" Then
            filtrarTablaPacientes(vtxtBuscar.Text)
        Else
            rellenarTablaPaciente()
            vTextPaciente.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Ci.Ident = vTextCodigo.Text
            Ci.Ident_Paciente = vtxtBuscar.Text
            Ci.Ident_Doctor = vComboBoxDoctor.Text
            Ci.Ident_Atencion = MenuAtencion.vLabelConectado.Text
            Ci.Datee = DateTime.Now
            Dci.Especiality = vComboEspecialidad.Text
            Dci.Surgery = vComboConsultorio.Text
            If RegistrarNuevaCita(Ci, Dci) Then
                MsgBox("Cita Registrada Correctamente")
            Else
                MsgBox("Error al Registrar")
            End If
        Catch ex As Exception
            MsgBox("Error de Excepción: " + ex.ToString)
        End Try
    End Sub

End Class