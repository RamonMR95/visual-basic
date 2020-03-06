Public Class Cliente
    Public Sub New()

    End Sub

    Public Sub New(cliId As String, vendId As String, compMes As Double, com As Single)
        clienteID = cliId
        cliVendeID = vendId
        comprasMes = compMes
        comisionV = com
    End Sub

    Private clienteID As String
    Public Property p_clienteID() As String
        Get
            Return clienteID
        End Get
        Set(ByVal value As String)
            clienteID = value
        End Set
    End Property
    Private cliVendeID As String
    Public Property p_cliVendeID() As String
        Get
            Return cliVendeID
        End Get
        Set(ByVal value As String)
            cliVendeID = value
        End Set
    End Property
    Private comprasMes As Double
    Public Property p_comprasMes As Double
        Get
            Return comprasMes
        End Get
        Set(ByVal value As Double)
            comprasMes = value
        End Set
    End Property
    Private comisionV As Single
    Public Property p_comisionV As Single
        Get
            Return comisionV
        End Get
        Set(ByVal value As Single)
            comisionV = value
        End Set
    End Property
End Class
