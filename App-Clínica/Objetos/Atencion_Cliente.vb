Public Class Atencion_Cliente
    Dim DNI_Atencion As Char()
    Dim Telefono As Integer

    Public Property Ident As Char()
        Get
            Return DNI_Atencion
        End Get
        Set(value As Char())
            DNI_Atencion = value
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

End Class
