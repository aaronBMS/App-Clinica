Public Class MenuAtencion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ConsultasPaciente.vComboBuscar.Items.Clear()
        ConsultasPaciente.Hide()
        RegistrarPaciente.TopLevel = False
        RegistrarPaciente.Show()
        Me.vPanelAdmin.Controls.Add(RegistrarPaciente)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RegistrarPaciente.Hide()
        ConsultasPaciente.TopLevel = False
        ConsultasPaciente.Show()
        Me.vPanelAdmin.Controls.Add(ConsultasPaciente)
        rellenarTablaPaciente()
        RellenarComboBoxPaciente()
    End Sub
End Class