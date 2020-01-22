Public Class PanelAreas
    Private Sub btnAreaCuadrado_Click(sender As Object, e As EventArgs) Handles btnAreaCuadrado.Click
        Hide()
        PanelAreaCuadrado.Show()
    End Sub

    Private Sub btnAreaTriangulo_Click(sender As Object, e As EventArgs) Handles btnAreaTriangulo.Click
        Hide()
        PanelAreaTriangulo.Show()
    End Sub

    Private Sub btnAreaRectangulo_Click(sender As Object, e As EventArgs) Handles btnAreaRectangulo.Click
        Hide()
        PanelAreaRectangulo.Show()
    End Sub

    Private Sub btnVolverArea_Click(sender As Object, e As EventArgs) Handles btnVolverArea.Click
        Hide()
        PanelPrincipal.Show()
    End Sub
End Class