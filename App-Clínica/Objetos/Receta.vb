Public Class Receta
    Dim ID_Receta As Char()
    Dim DNI_Paciente As Char()
    Dim DNI_Doctor As Char()
    Dim Fecha As Date

    Public Property Ident As Char()
        Get
            Return ID_Receta
        End Get
        Set(value As Char())
            ID_Receta = value
        End Set
    End Property

    Public Property Ident_Paciente As Char()
        Get
            Return DNI_Paciente
        End Get
        Set(value As Char())
            DNI_Paciente = value
        End Set
    End Property

    Public Property Ident_Doctor As Char()
        Get
            Return DNI_Doctor
        End Get
        Set(value As Char())
            DNI_Doctor = value
        End Set
    End Property

    Public Property Datee As Date
        Get
            Return Fecha
        End Get
        Set(value As Date)
            Fecha = value
        End Set
    End Property

End Class
