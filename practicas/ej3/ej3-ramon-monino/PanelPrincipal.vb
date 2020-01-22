Public Class PanelPrincipal
    Private Sub txtOpcion_TextChanged(sender As Object, e As EventArgs) Handles txtOpcion.TextChanged
        Select Case txtOpcion.Text
            Case "1"
                Hide()
                clearOpciones()
                PanelMiniCalc.Show()
            Case "2"
                Hide()
                clearOpciones()
                PanelAreas.Show()
            Case "3"
                Hide()
                PanelFactFibo.Show()
                clearOpciones()
            Case "4"
                Application.Exit()
            Case ""
            Case Else
                clearOpciones()
                MsgBox("Introduzca un número 1-4")
        End Select
    End Sub

    Private Sub clearOpciones()
        txtOpcion.Clear()
    End Sub
End Class
