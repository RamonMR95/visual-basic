Public Class AlquilarForm

    Public errorProvider As New ErrorProvider
    Private Sub AlquilarForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtAlquilerFecha.Text = Date.Today
    End Sub

    Private Sub btnAlquilarAceptar_Click(sender As Object, e As EventArgs) Handles btnAlquilarAceptar.Click
        Dim isDvd As Boolean = False

        If isValido() Then
            If dvds.Contains(txtAlquilarCodigoDVD.Text) Then
                isDvd = True
                If dvds(txtAlquilarCodigoDVD.Text).alquilado Then
                    MsgBox("El dvd con cod: " & txtAlquilarCodigoDVD.Text & " ya está alquilado")
                ElseIf clientes.Contains(txtAlquilarCodigoCliente.Text) Then
                    If clientes(txtAlquilarCodigoCliente.Text).alquileres <= 5 Then
                        alquilarDVD()
                    Else
                        MsgBox("El cliente con cod: " & txtAlquilarCodigoCliente.Text & " ya posee 5 dvds en alquiler")
                        Return
                    End If
                Else
                    MsgBox("El cliente con cod: " & txtAlquilarCodigoCliente.Text & " no existe en la db")
                End If
            Else
                MsgBox("El dvd con cod: " & txtAlquilarCodigoDVD.Text & " no existe en la db")
            End If
        End If
    End Sub

    Private Sub alquilarDVD()
        Dim alquiler As New DVDAlquilado(txtAlquilarCodigoDVD.Text, Date.Today, Date.Today.AddDays(dvds(txtAlquilarCodigoDVD.Text).diasAlquiler), txtAlquilarCodigoCliente.Text)
        dvds(alquiler.codDvdAlqui).alquilado = True
        clientes(alquiler.codClienAlqui).alquileres += 1
        Colecciones.dvdAlquilado.Add(alquiler, alquiler.codDvdAlqui)
        If Not clientes(alquiler.codClienAlqui).historicoAlquiler.Contains(dvds(alquiler.codDvdAlqui).codigo) Then
            clientes(alquiler.codClienAlqui).historicoAlquiler.add(dvds(alquiler.codDvdAlqui), dvds(alquiler.codDvdAlqui).codigo)
        End If
        MsgBox("Alquiler realizado con éxito")
    End Sub

    Private Sub mostrarMsgError(isCliente As Boolean, isDVD As Boolean, isAlquilado As Boolean)
        If Not isAlquilado And (Not isDVD Or Not isCliente) Then
            Dim errorMsg As String = "Error: " & vbNewLine
            If Not isDVD Then
                errorMsg += "El cod de dvd no existe en la db. " & vbNewLine
            End If
            If Not isCliente Then
                errorMsg += "El cod de cliente no existe en la db"
            End If
            MsgBox(errorMsg)
        End If
    End Sub

    Private Sub datos_TextChanged(sender As Object, e As EventArgs) Handles txtAlquilarCodigoDVD.TextChanged, txtAlquilarCodigoCliente.TextChanged
        errorProvider.Clear()
    End Sub

    Private Function isValido() As Boolean
        Dim valido As Boolean = False
        If String.IsNullOrEmpty(txtAlquilarCodigoDVD.Text) Or String.IsNullOrWhiteSpace(txtAlquilarCodigoDVD.Text) Then
            errorProvider.SetError(txtAlquilarCodigoDVD, "Formato inválido")
        End If
        If String.IsNullOrEmpty(txtAlquilarCodigoCliente.Text) Or String.IsNullOrWhiteSpace(txtAlquilarCodigoDVD.Text) Then
            errorProvider.SetError(txtAlquilarCodigoCliente, "Formato inválido")
        End If
        valido = True
        Return valido
    End Function

    Private Sub btnAlquilarSalir_Click(sender As Object, e As EventArgs) Handles btnAlquilarSalir.Click
        Me.Close()
    End Sub
End Class