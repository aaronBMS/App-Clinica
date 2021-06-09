Public Class Cita_Archivo
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Cita_Archivo_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim S As String = Microsoft.VisualBasic.Left(RegistrarCita.vComboBoxDoctor.Text, 8)
        ConsultarDoctor(S)
        ReportView_Cita(RegistrarCita.vCodigo.Text)
        vTextDNI.Text = RegistrarCita.vtxtBuscar.Text
        Dim Fecha As String = Microsoft.VisualBasic.Left(DateTime.Now.ToString, 9)
        Dim Hora As String = Microsoft.VisualBasic.Left(DateTime.Now.TimeOfDay.ToString, 8)
        vTextFecha.Text = Fecha
        vTextHora.Text = Hora
        vTextImporte.Text = RegistrarCita.vTextCosto.Text
        vTextPVenta.Text = (Convert.ToDouble(RegistrarCita.vTextCosto.Text) - 5.34).ToString
    End Sub

End Class