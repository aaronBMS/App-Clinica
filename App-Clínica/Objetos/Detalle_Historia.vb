Public Class Detalle_Historia
    Dim ID_Historia As Char()
    Dim Descripcion As String

    Public Property Ident As Char()
        Get
            Return ID_Historia
        End Get
        Set(value As Char())
            ID_Historia = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return Descripcion
        End Get
        Set(value As String)
            Descripcion = value
        End Set
    End Property

End Class
