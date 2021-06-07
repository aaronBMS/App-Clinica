Public Class AdicionalDoctor

    Dim Doc As New Doctor
    Private Sub vGuardarDoctor_Click(sender As Object, e As EventArgs) Handles vGuardarDoctor.Click
        Try
            Doc.Ident = vEscondido.Text
            Doc.Nacionality = vNacionalidad.Text
            Doc.Especiality = vComboEspecialidad.Text
            If CrearDoctor(Doc) Then
                MsgBox("Doctor Registrado Correctamente")
                vEscondido.Text = ""
                vNacionalidad.Text = ""
                vComboEspecialidad.Text = ""
                Me.Hide()
            Else
                MsgBox("Error al Registrar")
            End If
        Catch ex As Exception
            MsgBox("Error de Excepción: " + ex.ToString)
        End Try
    End Sub

End Class