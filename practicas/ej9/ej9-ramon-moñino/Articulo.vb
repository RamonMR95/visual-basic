Public Class Articulo
    Public Property codigo() As String
    Public Property nombre() As String
    Public Property categoria() As String
    Public Property precio() As Double
    Public Property existencias() As Integer

    Public Sub New()

    End Sub

    Public Sub New(cod As String, nom As String, cat As String, prec As Double, exist As Integer)
        codigo = cod
        nombre = nom
        categoria = cat
        precio = prec
        existencias = exist
    End Sub

    Public Overridable Function imprimirArticulo() As String
        Return codigo & vbTab & nombre & vbTab & categoria & vbTab & precio & vbTab & existencias
    End Function

End Class
