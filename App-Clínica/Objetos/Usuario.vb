Public Class Usuario
    Dim ID As Integer
    Dim Nombre As String
    Dim Apellido As String
    Dim Correo As String
    Dim Cargo As String
    Dim Usuario As String
    Dim Contraseña As String
    Dim Foto As String

    Public Property Ident As Integer
        Get
            Return ID
        End Get
        Set(value As Integer)
            ID = value
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

    Public Property Email As String
        Get
            Return Correo
        End Get
        Set(value As String)
            Correo = value
        End Set
    End Property

    Public Property Work As String
        Get
            Return Cargo
        End Get
        Set(value As String)
            Cargo = value
        End Set
    End Property

    Public Property User As String
        Get
            Return Usuario
        End Get
        Set(value As String)
            Usuario = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return Contraseña
        End Get
        Set(value As String)
            Contraseña = value
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
