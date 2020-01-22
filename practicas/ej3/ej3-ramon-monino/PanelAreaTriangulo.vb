Public Class PanelAreaTriangulo
    Private Sub btnVolverTriangulo_Click(sender As Object, e As EventArgs) Handles btnVolverTriangulo.Click
        Hide()
        PanelAreas.Show()
    End Sub

    Private Sub btnAreaCalcularTriangulo_Click(sender As Object, e As EventArgs) Handles btnAreaCalcularTriangulo.Click
        txtAreaTriangulo.Text = calcularAreaTriangulo()
    End Sub

    Private Function calcularAreaTriangulo()
        Try
            Return (CDbl(txtLado1Triangulo.Text) * CDbl(txtLado2Triangulo.Text)) / 2
        Catch ex As Exception
            MsgBox("Introduzca sólo números")
            Return Nothing
        End Try
    End Function
End Class