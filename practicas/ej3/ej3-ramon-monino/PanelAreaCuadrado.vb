Public Class PanelAreaCuadrado
    Private Sub btnVolverCuadrado_Click(sender As Object, e As EventArgs) Handles btnVolverCuadrado.Click
        Hide()
        PanelAreas.Show()
    End Sub

    Private Sub btnAreaCalcular_Click(sender As Object, e As EventArgs) Handles btnAreaCalcularCuadrado.Click
        txtAreaCuadrado.Text = calcularAreaCuadrado()
    End Sub

    Private Function calcularAreaCuadrado()
        Try
            Return Math.Pow(CDbl(txtLado1Cuadrado.Text), 2)
        Catch ex As Exception
            MsgBox("Introduzca sólo números")
            Return Nothing
        End Try
    End Function
End Class