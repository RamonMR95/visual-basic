Public Class DVD

    Public Property codigo() As String

    Public Property titulo() As String

    Public Property diasAlquiler() As Short

    Public Property alquilado() As Boolean

    Public Sub New(cod As String, tit As String, dias As Short)
        codigo = cod
        titulo = tit
        diasAlquiler = dias
        alquilado = False
    End Sub

    Public Function mostrarDatos() As String
        Return "Código: " & codigo & ", título: " & titulo & ", dias alquiler: " & diasAlquiler & ", alquilado: " & alquilado
    End Function
End Class
