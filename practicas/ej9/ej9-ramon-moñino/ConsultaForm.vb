Public Class ConsultaForm

    Private Sub btnConsultaSalir_Click(sender As Object, e As EventArgs) Handles btnConsultaSalir.Click
        Me.Hide()
    End Sub

    Private Sub btnConsultaEliminar_Click(sender As Object, e As EventArgs) Handles btnConsultaEliminar.Click
        Try
            If articulos.Contains(txtConsultaCodArt.Text) Then
                Dim result As DialogResult = MessageBox.Show("¿Desea eliminar el articulo?", "Eliminar?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If result = DialogResult.Yes Then
                    articulos.Remove(CInt(txtConsultaCodArt.Text))
                    clearFields()
                End If
            Else
                MsgBox("El articulo no existe en la db")
            End If
        Catch ex As Exception
            MsgBox("Error al introducir cod art")
        End Try
    End Sub

    Private Sub btnConsultaBuscar_Click(sender As Object, e As EventArgs) Handles btnConsultaBuscar.Click
        Try
            If articulos.Contains(txtConsultaCodArt.Text) Then
                txtConsultaNombre.Text = articulos(txtConsultaCodArt.Text).nombre
                txtConsultaExistencias.Text = articulos(txtConsultaCodArt.Text).existencias
                txtConsultaPrecio.Text = articulos(txtConsultaCodArt.Text).precio
                txtConsultaCategoria.Text = articulos(txtConsultaCodArt.Text).categoria

                If TypeOf articulos(txtConsultaCodArt.Text) Is ArticuloRebajado Then
                    txtConsultaRebaja.Text = articulos(txtConsultaCodArt.Text).rebaja
                End If
            Else
                clearFields()
                MsgBox("El articulo no existe en la db")
            End If
        Catch ex As Exception
            MsgBox("Error al introducir cod art")
        End Try
    End Sub

    Private Sub ConsultaForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        clearFields()
    End Sub

    Private Sub btnConsultaModificar_Click(sender As Object, e As EventArgs) Handles btnConsultaModificar.Click
        Try
            If articulos.Count > 0 Then
                If articulos.Contains(txtConsultaCodArt.Text) Then
                    articulos(txtConsultaCodArt.Text).precio = CInt(txtConsultaPrecio.Text)
                    articulos(txtConsultaCodArt.Text).existencias = CInt(txtConsultaExistencias.Text)
                    MsgBox("Artículo con el código: " & txtConsultaCodArt.Text & " ha sido modificado correctamente")
                Else
                    MsgBox("No hay existe artículo dado de alta con el código: " & txtConsultaCodArt.Text)
                End If
            Else
                MsgBox("No hay ningún artículo dado de alta")
            End If
        Catch ex As Exception
            MsgBox("Valores inválido")
        End Try
    End Sub

    Private Sub btnConsultaLimpiar_Click(sender As Object, e As EventArgs) Handles btnConsultaLimpiar.Click
        clearFields()
    End Sub

    Private Sub clearFields()
        txtConsultaCodArt.Clear()
        txtConsultaNombre.Clear()
        txtConsultaExistencias.Clear()
        txtConsultaPrecio.Clear()
        txtConsultaRebaja.Clear()
        txtConsultaCategoria.Clear()
    End Sub
End Class