Public Class ResumenPresupuesto
    Private Sub btnVolverPresupuesto_Click(sender As Object, e As EventArgs) Handles btnVolverPresupuesto.Click
        reestablecerEstadoElementos()
        Hide()
        CompraInteractivaForm.Show()
    End Sub

    Private Sub reestablecerEstadoElementos()
        Module1.presupuesto = 0
        Module1.cadenaEquiposOficina = ""
        Module1.cadenaEquiposRequeridos = ""
        Module1.cadenaMetodosPago = ""
        Module1.cadenaPerifericos = ""
        txtPresupuesto.Text = ""
        CompraInteractivaForm.rbPC.Checked = True
        CompraInteractivaForm.cbContestador.Checked = False
        CompraInteractivaForm.cbCalculadora.Checked = False
        CompraInteractivaForm.cbFotocopiadora.Checked = False
        CompraInteractivaForm.lbPerifericos.SelectedItems.Clear()
    End Sub

    Private Sub btnSalirPresupuesto_Click(sender As Object, e As EventArgs) Handles btnSalirPresupuesto.Click
        Application.Exit()
    End Sub


End Class