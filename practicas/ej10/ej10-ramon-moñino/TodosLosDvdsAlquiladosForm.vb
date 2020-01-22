Public Class TodosLosDvdsAlquiladosForm
    Private Sub TodosLosDvdsAlquiladosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Colecciones.dvdAlquilado.Count > 0 Then
            mostrarAlquilados()
        Else
            rtbListadoAlquilados.Text = "No existe ningún DVD alquilado"
        End If
    End Sub

    Private Sub mostrarAlquilados()
        For index = 1 To Colecciones.dvds.Count
            If Colecciones.dvds(index).alquilado Then
                rtbListadoAlquilados.Text += Colecciones.dvds(index).mostrarDatos() & vbNewLine
            End If
        Next
    End Sub

    Private Sub btnListadoSalir_Click(sender As Object, e As EventArgs) Handles btnListadoSalir.Click
        Me.Close()
    End Sub

End Class