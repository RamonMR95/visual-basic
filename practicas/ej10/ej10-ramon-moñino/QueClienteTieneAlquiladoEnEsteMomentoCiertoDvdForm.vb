Public Class QueClienteTieneAlquiladoEnEsteMomentoCiertoDvdForm

    Public errorProvider As New ErrorProvider

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If isValido() Then
            If Colecciones.dvds.Contains(txtCodigoDVD.Text) Then
                If Colecciones.dvds(txtCodigoDVD.Text).alquilado Then
                    txtCodCliente.Text = Colecciones.dvdAlquilado(txtCodigoDVD.Text).codClienAlqui
                Else
                    MsgBox("El dvd no está alquilado")
                    txtCodCliente.Clear()
                End If
            Else
                MsgBox("No existe el cod de dvd")
            End If
        End If
    End Sub

    Private Function isValido() As Boolean
        If String.IsNullOrEmpty(txtCodigoDVD.Text) Or String.IsNullOrWhiteSpace(txtCodigoDVD.Text) Then
            ErrorProvider.SetError(txtCodigoDVD, "Formato inválido")
            Return False
        End If
        Return True
    End Function

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class