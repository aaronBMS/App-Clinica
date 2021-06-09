Public Class Detalle_Cita
    Dim ID_Cita As Char()
    Dim Especialidad As String
    Dim Consultorio As String
    Dim Turno As Integer
    Dim Costo As Double

    Public Property Ident As Char()
        Get
            Return ID_Cita
        End Get
        Set(value As Char())
            ID_Cita = value
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

    Public Property Surgery As String
        Get
            Return Consultorio
        End Get
        Set(value As String)
            Consultorio = value
        End Set
    End Property

    Public Property Turn As Integer
        Get
            Return Turno
        End Get
        Set(value As Integer)
            Turno = value
        End Set
    End Property

    Public Property Cost As Double
        Get
            Return Costo
        End Get
        Set(value As Double)
            Costo = value
        End Set
    End Property

End Class
