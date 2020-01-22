Public Class SiUnDeterminadoClienteHaAlquiladoYaCiertoDvdForm
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim isCliente As Boolean = False
        Dim isDvd As Boolean = False

        If clientes.Contains(txtCodCliente.Text) Then
            isCliente = True
        End If

        If dvds.Contains(txtCodigoDVD.Text) Then
            isDvd = True
        End If

        If Not isCliente Or Not isDvd Then
            mostrarError(isCliente, isDvd)
        Else
            mostrarSiClienteYaAAlquilado()
        End If
    End Sub

    Private Sub mostrarSiClienteYaAAlquilado()
        If clientes(txtCodCliente.Text).historicoAlquiler.Contains(dvds(txtCodigoDVD.Text).codigo) Then
            MsgBox("El cliente: " & txtCodCliente.Text & " ya ha alquilado el dvd: " & txtCodigoDVD.Text)
        Else
            MsgBox("El cliente: " & txtCodCliente.Text & " nunca ha alquilado el dvd: " & txtCodigoDVD.Text)
        End If
    End Sub

    Private Sub mostrarError(isCliente As Boolean, isDvd As Boolean)
        Dim errorMsg As String = "Error: " & vbNewLine
        If Not isCliente Then
            errorMsg += "Cliente no existe en la db." & vbNewLine
        End If
        If Not isDvd Then
            errorMsg += "Dvd no existe en la db"
        End If
        MsgBox(errorMsg)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class