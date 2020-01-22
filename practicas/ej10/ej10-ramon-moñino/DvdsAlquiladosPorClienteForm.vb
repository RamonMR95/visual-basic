Public Class DvdsAlquiladosPorClienteForm

    Public errorProvider As New ErrorProvider

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        If isValido() Then
            If Colecciones.clientes.Contains(txtListadoClienteCod.Text) Then
                If Colecciones.clientes(txtListadoClienteCod.Text).alquileres = 0 Then
                    rtbAlquiladoPorCliente.Text = "El cliente no tiene ningún alquiler"
                Else
                    listarDVDsAlquilados()
                End If
            Else
                MsgBox("No existe ningún cliente con el código: " & txtListadoClienteCod.Text)
            End If

        End If
    End Sub

    Private Sub btnListadoSalir_Click(sender As Object, e As EventArgs) Handles btnListadoSalir.Click
        Me.Close()
    End Sub

    Private Sub listarDVDsAlquilados()
        For index = 1 To Colecciones.dvdAlquilado.Count
            If Colecciones.dvdAlquilado(index).codClienAlqui.Equals(txtListadoClienteCod.Text) Then
                rtbAlquiladoPorCliente.Text += Colecciones.dvds(Colecciones.dvdAlquilado(index).codDvdAlqui).titulo & vbNewLine
            End If
        Next
    End Sub

    Private Function isValido() As Boolean
        If String.IsNullOrEmpty(txtListadoClienteCod.Text) Or String.IsNullOrWhiteSpace(txtListadoClienteCod.Text) Then
            errorProvider.SetError(txtListadoClienteCod, "Formato inválido")
            Return False
        End If
        Return True
    End Function
End Class