Public Class Detalle_Receta
    Dim ID_Receta As Char()
    Dim Descripcion As String
    Dim Cantidad As Integer
    Dim Observaciones As String

    Public Property Ident As Char()
        Get
            Return ID_Receta
        End Get
        Set(value As Char())
            ID_Receta = value
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

    Public Property Amount As Integer
        Get
            Return Cantidad
        End Get
        Set(value As Integer)
            Cantidad = value
        End Set
    End Property

    Public Property Observations As String
        Get
            Return Observaciones
        End Get
        Set(value As String)
            Observaciones = value
        End Set
    End Property

End Class
