Public Class PanelAreaRectangulo
    Private Sub btnVolverRectangulo_Click(sender As Object, e As EventArgs) Handles btnVolverRectangulo.Click
        Hide()
        PanelAreas.Show()
    End Sub

    Private Sub btnAreaCalcularRectangulo_Click(sender As Object, e As EventArgs) Handles btnAreaCalcularRectangulo.Click
        txtAreaRectangulo.Text = calcularAreaRectangulo()
    End Sub

    Private Function calcularAreaRectangulo()
        Try
            Return (CDbl(txtLado1Rectangulo.Text) * CDbl(txtLado2Rectangulo.Text))
        Catch ex As Exception
            MsgBox("Introduzca sólo números")
            Return Nothing
        End Try
    End Function
End Class