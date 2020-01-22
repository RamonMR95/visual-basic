Public Class ConsultaClienteForm
    Private Sub btnConsultaClienteBuscar_Click(sender As Object, e As EventArgs) Handles btnConsultaClienteBuscar.Click
        If Not String.IsNullOrEmpty(txtConsultaClienteCodigo2.Text) And Not String.IsNullOrWhiteSpace(txtConsultaClienteCodigo2.Text) Then
            If clientes.Contains(txtConsultaClienteCodigo2.Text) Then
                mostrarDatosCliente()
            Else
                MsgBox("La base de datos no contiene el código: " & txtConsultaClienteCodigo2.Text)
                clearData()
            End If
        Else
            MsgBox("Código de cliente invalido")
        End If
    End Sub

    Private Sub mostrarDatosCliente()
        txtConsultaClienteDireccion.Text = clientes(txtConsultaClienteCodigo2.Text).direccion
        txtConsultaClienteTelefono.Text = clientes(txtConsultaClienteCodigo2.Text).telefono
        txtConsultaClienteAlquileres.Text = clientes(txtConsultaClienteCodigo2.Text).alquileres
        txtConsultaClienteEmail.Text = clientes(txtConsultaClienteCodigo2.Text).email
    End Sub

    Private Sub btnConsultaClienteSalir_Click(sender As Object, e As EventArgs) Handles btnConsultaClienteSalir.Click
        Me.Close()
    End Sub
    Private Sub clearData()
        txtConsultaClienteDireccion.Clear()
        txtConsultaClienteTelefono.Clear()
        txtConsultaClienteCodigo2.Clear()
        txtConsultaClienteAlquileres.Clear()
        txtConsultaClienteEmail.Clear()
    End Sub
End Class