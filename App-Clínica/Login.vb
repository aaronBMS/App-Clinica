Public Class Login
    Private Sub vButtonIngresar_Click(sender As Object, e As EventArgs) Handles vButtonIngresar.Click
        Dim Menu As MenuAdmin = New MenuAdmin
        Me.Hide()
        Menu.Show()
    End Sub
End Class
