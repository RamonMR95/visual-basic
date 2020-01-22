Public Class ArticuloRebajado
    Inherits Articulo

    Public Property rebaja() As Short

    Public Sub New()
        MyBase.New
    End Sub

    Public Sub New(codigo As String, nombre As String, categoria As String, precio As Double, existencias As Integer, rebajaSobrePrecio As Short)
        MyBase.New(codigo, nombre, categoria, precio, existencias)
        precio -= rebajaSobrePrecio
    End Sub

    Public Overrides Function imprimirArticulo() As String
        Return MyBase.imprimirArticulo() & vbTab & rebaja
    End Function
End Class
