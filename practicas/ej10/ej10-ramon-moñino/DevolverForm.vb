Public Class DevolverForm

    Private Sub btnDevolver_Click(sender As Object, e As EventArgs) Handles btnDevolver.Click
        If Colecciones.dvdAlquilado.Contains(txtDevolverCodDVD.Text) Then
            devolverDVD()
        Else
            MsgBox("El dvd no se encuentra en la db")
            clearFields()
        End If
    End Sub

    Private Sub devolverDVD()
        Colecciones.dvds(txtDevolverCodDVD.Text).alquilado = False
        txtDevolverFechaDevolucion.Text = Today.Date
        Dim fechaAlquiler As Date = Colecciones.dvdAlquilado(txtDevolverCodDVD.Text).fechaAlquiler
        Dim diasAlquiler As Integer = DateDiff(DateInterval.Day, fechaAlquiler, Today.Date)
        txtDevolverDiasAlquilado.Text = CStr(diasAlquiler)
        If diasAlquiler > dvds(txtDevolverCodDVD.Text).diasAlquiler Then
            MsgBox("Tiene una penalización de :" & diasAlquiler & "€")
        End If
        Colecciones.clientes(Colecciones.dvdAlquilado(txtDevolverCodDVD.Text).codClienAlqui).alquileres -= 1
        Colecciones.dvdAlquilado.Remove(txtDevolverCodDVD.Text)
        MsgBox("DVD Devuelto")
    End Sub

    Private Sub btnDevolverSalir_Click(sender As Object, e As EventArgs) Handles btnDevolverSalir.Click
        Me.Close()
    End Sub

    Private Sub clearFields()
        txtDevolverCodDVD.Clear()
        txtDevolverDiasAlquilado.Clear()
        txtDevolverFechaDevolucion.Clear()
    End Sub
End Class