Public Class Cliente
    Public Property codigo() As String

    Public Property direccion() As String

    Public Property telefono() As Double

    Public Property email() As String

    Public Property alquileres() As Integer

    Public Property historicoAlquiler() As Collection

    Public Sub New(cod As String, dir As String, tel As Double, em As String)
        codigo = cod
        direccion = dir
        telefono = tel
        email = em
        alquileres = 0
        historicoAlquiler = New Collection
    End Sub
End Class
