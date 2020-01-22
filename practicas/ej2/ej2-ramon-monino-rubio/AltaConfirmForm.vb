Public Class AltaConfirmForm
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Hide()
        AltaAlumnoForm.Show()
    End Sub

    Private Sub btnNO_Click(sender As Object, e As EventArgs) Handles btnNO.Click
        Hide()
        AltaAlumnoForm.Hide()
        OpcionesForm.Show()
    End Sub
End Class