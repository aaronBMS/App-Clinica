Imports System.Data.Sql
Imports System.Data.SqlClient
Module Conexion

    Public Conex As New SqlConnection
    Public Comando As New SqlCommand
    Public Sub Conecction()
        Try
            Conex.ConnectionString = "Data Source=DESKTOP-IL9RKGA;Initial Catalog=CLINICA_GDI;User ID=ucv;Password=ucv"
            Conex.Open()
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

End Module
