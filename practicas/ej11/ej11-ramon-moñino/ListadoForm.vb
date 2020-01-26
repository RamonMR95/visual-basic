Public Class ListadoForm
    Private Sub btnSalirListado_Click(sender As Object, e As EventArgs) Handles btnSalirListado.Click
        If Not (DBForm.miDataR Is Nothing) Then
            DBForm.miDataR.Close()
        End If
        Me.Close()
    End Sub
End Class