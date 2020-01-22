Public Class Albaran
    Public Property numero() As Integer
    Public Property productos() As Collection

    Public ruta As String

    Public Sub New(num As Integer)
        numero = num
        productos = New Collection
    End Sub

    Public Sub addArticulo(articulo As Articulo)
        productos.Add(articulo)
    End Sub

    Public Function mostrarDatos() As String
        Dim msg As String = "Numero: " & numero & vbNewLine & "Articulo: " & vbNewLine & "Código" & vbTab & "Nombre" & vbTab & "Categoría" & vbTab & vbTab & "Precio" & vbTab & "Existencias" & vbTab & "Rebaja" & vbNewLine
        For index = 1 To productos.Count
            msg += productos(index).imprimirArticulo() & vbNewLine
        Next
        Return msg
    End Function
End Class
