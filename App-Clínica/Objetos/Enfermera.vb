Public Class Enfermera
    Dim DNI_Enfermera As Char()
    Dim Telefono As Integer
    Dim Nacionalidad As String
    Dim Especialidad As String

    Public Property Ident As Char()
        Get
            Return DNI_Enfermera
        End Get
        Set(value As Char())
            DNI_Enfermera = value
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
