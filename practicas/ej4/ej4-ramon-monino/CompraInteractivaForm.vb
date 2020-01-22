Public Class CompraInteractivaForm
    Private Sub CompraInteractivaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboBoxCurrency.SelectedIndex = 0
        rbPC.Checked = True
    End Sub
    Private Sub lbPerifericos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbPerifericos.SelectedIndexChanged
        Select Case lbPerifericos.SelectedIndex
            Case "0"
                pbPerifericos.Image = My.Resources.Harddisk
            Case "1"
                pbPerifericos.Image = My.Resources.Printer
            Case "2"
                pbPerifericos.Image = My.Resources.SateDish
        End Select
    End Sub

    Private Sub ListBoxPerifericoSeleccionado()
        Select Case lbPerifericos.SelectedIndex
            Case "0"
                presupuesto += 75
                cadenaPerifericos = "Disco Duro: 75€"
            Case "1"
                presupuesto += 90
                cadenaPerifericos = "Impresora: 90€"
            Case "2"
                presupuesto += 50
                cadenaPerifericos = "Antena: 75€"
        End Select
    End Sub

    Private Sub rbPC_CheckedChanged(sender As Object, e As EventArgs) Handles rbPC.CheckedChanged
        If rbPC.Checked Then
            pbEquipo.Image = My.Resources.PComputr
        End If
    End Sub

    Private Sub rbMacintosh_CheckedChanged(sender As Object, e As EventArgs) Handles rbMacintosh.CheckedChanged
        If rbMacintosh.Checked Then
            pbEquipo.Image = My.Resources.Computer
        End If
    End Sub

    Private Sub rbPortatil_CheckedChanged(sender As Object, e As EventArgs) Handles rbPortatil.CheckedChanged
        If rbPortatil.Checked Then
            pbEquipo.Image = My.Resources.Laptop1
        End If
    End Sub

    Private Sub rbEquipoOficinaRequeridoSeleccionado()
        If rbPC.Checked Then
            presupuesto += 700
            cadenaEquiposRequeridos = "PC: 700"
        ElseIf rbMacintosh.Checked Then
            presupuesto += 1000
            cadenaEquiposRequeridos = "Macintosh: 1000"
        ElseIf rbPortatil.Checked Then
            presupuesto += 500
            cadenaEquiposRequeridos = "Portatil: 500"
        End If
    End Sub



    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

    Private Sub cbContestador_CheckStateChanged(sender As Object, e As EventArgs) Handles cbContestador.CheckStateChanged
        If cbContestador.Checked Then
            pbContestador.Visible = True
        Else
            pbContestador.Visible = False
        End If
    End Sub

    Private Sub cbCalculadora_CheckStateChanged(sender As Object, e As EventArgs) Handles cbCalculadora.CheckStateChanged
        If cbCalculadora.Checked Then
            pbCalculadora.Visible = True
        Else
            pbCalculadora.Visible = False
        End If
    End Sub

    Private Sub cbFotocopiadora_CheckStateChanged(sender As Object, e As EventArgs) Handles cbFotocopiadora.CheckStateChanged
        If cbFotocopiadora.Checked Then
            pbFotocopiadora.Visible = True
        Else
            pbFotocopiadora.Visible = False
        End If
    End Sub

    Private Sub checkBoxEquiposOficinaSeleccionados()
        If cbContestador.Checked Then
            cadenaEquiposOficina = cadenaEquiposOficina & "Contestador: 50€ " & vbTab
            presupuesto += 50
        End If
        If cbCalculadora.Checked Then
            cadenaEquiposOficina = cadenaEquiposOficina & "Calculadora: 20€ " & vbTab
            presupuesto += 20
        End If
        If cbFotocopiadora.Checked Then
            cadenaEquiposOficina = cadenaEquiposOficina & "fotocopiadora: 100€ " & vbTab
            presupuesto += 100
        End If
    End Sub

    Private Sub comboBoxCurrency_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxCurrency.SelectedIndexChanged
        Select Case comboBoxCurrency.SelectedIndex
            Case "0"
                pbCurrency.Image = My.Resources.Dollar
            Case "1"
                pbCurrency.Image = My.Resources.Check
            Case "2"
                pbCurrency.Image = My.Resources.PoundBag
        End Select
    End Sub

    Private Sub comboBoxMetodoDePagoSeleccionado()
        cadenaMetodosPago = comboBoxCurrency.SelectedItem
    End Sub

    Private Sub btnPresupuesto_Click(sender As Object, e As EventArgs) Handles btnPresupuesto.Click
        rbEquipoOficinaRequeridoSeleccionado()
        checkBoxEquiposOficinaSeleccionados()
        comboBoxMetodoDePagoSeleccionado()
        ListBoxPerifericoSeleccionado()
        ResumenPresupuesto.txtPresupuesto.AppendText("Equipo (Necesario): " & vbTab & cadenaEquiposRequeridos & vbCrLf &
                                                      "Periféricos (sólo uno): " & vbTab & cadenaPerifericos & vbCrLf &
                                                      "Equipos de oficina: (1-3) " & vbTab & cadenaEquiposOficina & vbCrLf &
                                                      "Método de pago: " & vbTab & vbTab & cadenaMetodosPago & vbCrLf &
                                                      "------------------------------------------------------------" & vbCrLf &
                                                      "Tiene un precio de: " & vbTab & presupuesto & vbCrLf & vbCrLf)
        Hide()
        ResumenPresupuesto.Show()
    End Sub
End Class
