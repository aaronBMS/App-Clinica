Public Class Doctor
    Dim DNI_Doctor As Char()
    Dim Nacionalidad As String
    Dim Especialidad As String

    Public Property Ident As Char()
        Get
            Return DNI_Doctor
        End Get
        Set(value As Char())
            DNI_Doctor = value
        End Set
    End Property

    Public Property Nacionality As String
        Get
            Return Nacionalidad
        End Get
        Set(value As String)
            Nacionalidad = value
        End Set
    End Property

    Public Property Especiality As String
        Get
            Return Especialidad
        End Get
        Set(value As String)
            Especialidad = value
        End Set
    End Property

End Class
