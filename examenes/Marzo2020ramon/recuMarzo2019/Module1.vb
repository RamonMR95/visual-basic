Module Module1

    Public colecCliente As New Collection
    Public colecVendedor As New Collection

    'Definir estuctura Pedido
    Public Structure Pedido
        Public pedidoId As Integer
        Public pedClienteID As String
        Public producto As String
        Public cantidad As Integer
        Public precioUni As Double
    End Structure

    'Definir ArrayPedidos del tipo Pedido
    Public colecPedidos As New Collection

    'Definir variables las necesarias  
    Public numPedido As Integer = 0

End Module
