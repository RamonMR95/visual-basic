Public Class PanelFactFibo
    Private Sub btnCalcularFactorial_Click(sender As Object, e As EventArgs) Handles btnCalcularFactorial.Click
        If CInt(txtNumero.Text) < 0 Then
            MsgBox("Introduce un número mayor que 0")
        Else
            txtExpositor.Text = factorialNumero(CInt(txtNumero.Text))
        End If
    End Sub

    Private Function factorialNumero(numero As Integer) As Integer
        Dim factorial As Integer = 1

        If numero = 0 Then
            factorial = 1
        Else
            factorial = numero * factorialNumero(numero - 1)
        End If

        Return factorial
    End Function

    Private Sub btnCalcularFibo_Click(sender As Object, e As EventArgs) Handles btnCalcularFibo.Click
        If CInt(txtNumero.Text) < 0 Then
            MsgBox("Introduce un número mayor que 0")
        Else
            txtExpositor.Text = FiboNumero(CInt(txtNumero.Text))
        End If
    End Sub

    Private Function FiboNumero(numero As Integer) As String
        Dim fibo As String = ""

        If numero = 0 Then
            fibo = "0"
        ElseIf numero = 1 Then
            fibo = "0-" & CStr(numero)
        Else
            fibo = "0-1-"
            Dim anterior As Integer = 0
            Dim actual As Integer = 1
            Dim counter As Integer = 2
            Dim aux As Integer

            While (counter < numero)
                aux = anterior + actual
                fibo += CStr(aux & "-")
                anterior = actual
                actual = aux
                counter += 1
            End While
        End If
        Return fibo
    End Function

    Private Sub btnVolverFactFibo_Click(sender As Object, e As EventArgs) Handles btnVolverFactFibo.Click
        Hide()
        PanelPrincipal.Show()
    End Sub
End Class