Public Class Vendedor
    Public Sub New()

    End Sub

    Public Sub New(vendID As String, nom As String, zone As String, ret As Single)
        vendedorID = vendID
        nombre = nom
        zona = zone
        retencion = ret
    End Sub

    Private vendedorID As String
    Public Property p_vendedorID() As String
        Get
            Return vendedorID
        End Get
        Set(ByVal value As String)
            vendedorID = value
        End Set
    End Property
    Private nombre As String
    Public Property p_nombre() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property

    Private zona As String
    Public Property p_zona() As String
        Get
            Return zona
        End Get
        Set(ByVal value As String)
            zona = value
        End Set
    End Property
    Private retencion As Single
    Public Property p_retencion() As Single
        Get
            Return retencion
        End Get
        Set(ByVal value As Single)
            retencion = value
        End Set
    End Property

    
End Class
