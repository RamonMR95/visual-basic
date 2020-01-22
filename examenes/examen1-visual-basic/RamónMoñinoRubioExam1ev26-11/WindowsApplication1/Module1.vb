Imports System.IO
Module Module1
    Public Structure USUARIO
        Public Usuario As String
        Public Nombre As String
        Public Email As String
        Public Clave As String
        Public Direccion As String
        Public Telefono As Double
        Public TotCompAcum As Double
    End Structure

    Public altasUsuario(0) As USUARIO

    Public usuarioLogeado As USUARIO
End Module
