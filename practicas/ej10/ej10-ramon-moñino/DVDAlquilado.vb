Public Class DVDAlquilado

    Public Property codDvdAlqui() As String

    Public Property fechaAlquiler() As Date

    Public Property fechaDevolucion() As Date

    Public Property codClienAlqui() As String

    Public Sub New(cod As String, fechaAlq As Date, fechaDev As Date, codCliente As String)
        codDvdAlqui = cod
        fechaAlquiler = fechaAlq
        fechaDevolucion = fechaDev
        codClienAlqui = codCliente
    End Sub
End Class
