Imports System.Drawing.Drawing2D

Public Class MenuAdmin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ConsultasUsuario.vComboBuscar.Items.Clear()
        ConsultasUsuario.Hide()
        CrearUsuario.TopLevel = False
        CrearUsuario.Show()
        Me.vPanelAdmin.Controls.Add(CrearUsuario)
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim Login As New Login
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub MenuAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vLabelConectado.Text = Login.vTextUsuario.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ConsultasUsuario.vComboBuscar.Items.Clear()
        Me.Hide()
        Login.Show()
        Login.vTextUsuario.Text = ""
        Login.vTextContraseña.Text = ""
        Login.vTextUsuario.Focus()
        Conex.Open()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CrearUsuario.Hide()
        ConsultasUsuario.TopLevel = False
        ConsultasUsuario.Show()
        Me.vPanelAdmin.Controls.Add(ConsultasUsuario)
        rellenarTabla()
        RellenarComboBox()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ConsultasUsuario.vComboBuscar.Items.Clear()
    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        'e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        'Dim p = New GraphicsPath
        'Dim x = 0
        'Dim y = 0
        'Dim ancho = 0
        'Dim alto = 0
        'x = PictureBox1.Width - 24
        'y = PictureBox1.Top - 24
        'ancho = PictureBox1.Width - 24
        'alto = PictureBox1.Height - 24
        'p.AddEllipse(New Rectangle(x, y, ancho, alto))
        'Dim reg = New Region
        'reg = New Region(p)
        'PictureBox1.Region = reg
    End Sub

    Private Sub vLabelConectado_Click(sender As Object, e As EventArgs) Handles vLabelConectado.Click

    End Sub

    Private Sub MenuAdmin_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim imagen As Image
        Try
            imagen = BytesToImage(stringToByte(vLabelConectado.Text))
            PictureBox1.Image = imagen
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class