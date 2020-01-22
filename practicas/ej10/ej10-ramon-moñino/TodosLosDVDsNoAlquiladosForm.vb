Public Class TodosLosDVDsNoAlquiladosForm
    Private Sub TodosLosDVDsNoAlquiladosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Colecciones.dvds.Count = Colecciones.dvdAlquilado.Count Then
            rtbListadoNoAlquilados.Text = "No existe ningún DVD no alquilado"
        Else
            mostrarNoAlquilados()
        End If
    End Sub

    Private Sub mostrarNoAlquilados()
        For index = 1 To Colecciones.dvds.Count
            If Colecciones.dvds(index).alquilado = False Then
                rtbListadoNoAlquilados.Text += Colecciones.dvds(index).mostrarDatos() & vbNewLine
            End If
        Next
    End Sub

    Private Sub btnListadoSalir_Click(sender As Object, e As EventArgs) Handles btnListadoSalir.Click
        Me.Close()
    End Sub
End Class