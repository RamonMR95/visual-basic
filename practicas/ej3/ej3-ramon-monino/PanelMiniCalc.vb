Public Class PanelMiniCalc
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSumarCalc_Click(sender As Object, e As EventArgs) Handles btnSumarCalc.Click
        txtResultadoCalc.Text = sumar()
    End Sub

    Private Function sumar()
        Try
            Return CDbl(txtNumero1.Text) + CDbl(txtNumero2.Text)
        Catch ex As Exception
            MsgBox("Introduzca sólo números")
            Return Nothing
        End Try
    End Function

    Private Sub btnRestarCalc_Click(sender As Object, e As EventArgs) Handles btnRestarCalc.Click
        txtResultadoCalc.Text = restar()
    End Sub

    Private Function restar()
        Try
            Return CDbl(txtNumero1.Text) - CDbl(txtNumero2.Text)
        Catch ex As Exception
            MsgBox("Introduzca sólo números")
            Return Nothing
        End Try
    End Function

    Private Sub btnMultiplicarCalc_Click(sender As Object, e As EventArgs) Handles btnMultiplicarCalc.Click
        txtResultadoCalc.Text = multiplicar()
    End Sub

    Private Function multiplicar()
        Try
            Return CDbl(txtNumero1.Text) * CDbl(txtNumero2.Text)
        Catch ex As Exception
            MsgBox("Introduzca sólo números")
            Return Nothing
        End Try
    End Function

    Private Sub btnDividirCalc_Click(sender As Object, e As EventArgs) Handles btnDividirCalc.Click
        txtResultadoCalc.Text = dividir()
    End Sub

    Private Function dividir()
        Try
            If CDbl(txtNumero2.Text) = 0 Then
                MsgBox("Error: Division por 0")
            Else
                Return CDbl(txtNumero1.Text) / CDbl(txtNumero2.Text)
            End If
        Catch ex As Exception
            MsgBox("Introduzca sólo números")
            Return Nothing
        End Try
    End Function

    Private Sub btnVolverCalc_Click(sender As Object, e As EventArgs) Handles btnVolverCalc.Click
        Hide()
        PanelPrincipal.Show()
    End Sub

End Class