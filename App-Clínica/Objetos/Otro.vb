Public Class Otro
    Dim DNI_Empleado As Char()
    Dim Descripcion As String
    Dim Telefono As Integer

    Public Property Ident As Char()
        Get
            Return DNI_Empleado
        End Get
        Set(value As Char())
            DNI_Empleado = value
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

    Public Property Phone As Integer
        Get
            Return Telefono
        End Get
        Set(value As Integer)
            Telefono = value
        End Set
    End Property

End Class
