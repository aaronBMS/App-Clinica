Public Class Paciente
    Dim DNI_Paciente As Char()
    Dim Nombre As String
    Dim Apellido As String
    Dim Telefono As Integer
    Dim Correo As String
    Dim Foto As String

    Public Property Ident As Char()
        Get
            Return DNI_Paciente
        End Get
        Set(value As Char())
            DNI_Paciente = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property

    Public Property LastName As String
        Get
            Return Apellido
        End Get
        Set(value As String)
            Apellido = value
        End Set
    End Property

    Public Property Phone As Integer
        Get
            Return Telefono
        End Get
        Set(value As Integer)
            Telefono = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return Correo
        End Get
        Set(value As String)
            Correo = value
        End Set
    End Property

    Public Property Photo As String
        Get
            Return Foto
        End Get
        Set(value As String)
            Foto = value
        End Set
    End Property
End Class
