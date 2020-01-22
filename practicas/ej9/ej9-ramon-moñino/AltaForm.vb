Public Class AltaForm
    Private Sub AltaForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        clearData()
    End Sub

    Private Sub btnAceptarAlta_Click(sender As Object, e As EventArgs) Handles btnAceptarAlta.Click
        If Not articulos.Contains(txtCodigoAlta.Text) Then
            alta()
        Else
            clearData()
            MsgBox("El articulo ya existe en la db")
        End If
    End Sub

    Private Sub alta()
        Try
            crearArticulo()
            MsgBox("Articulo dado de alta con cod: " & txtCodigoAlta.Text)
            preguntarCrearDarDeAltaOtroArticulo()
        Catch ex As Exception
            MsgBox("Valores inválidos!")
        End Try
    End Sub

    Private Sub preguntarCrearDarDeAltaOtroArticulo()
        Dim result As DialogResult = MessageBox.Show("¿Desea crear otro articulo?", "Crear?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If result = DialogResult.Yes Then
            clearData()
        ElseIf result = DialogResult.No Then
            Me.Hide()
        End If
    End Sub

    Private Sub crearArticulo()
        Dim articulo
        If rbArticuloAlta.Checked Then
            articulo = New Articulo
        Else
            articulo = New ArticuloRebajado
            articulo.rebaja = CShort(txtRebajaAlta.Text)
        End If
        articulo.codigo = txtCodigoAlta.Text
        articulo.nombre = txtNombreAlta.Text
        articulo.existencias = CInt(txtExistenciasAlta.Text)
        articulo.precio = CDbl(txtPrecioAlta.Text)
        articulo.categoria = comboBoxCategoriaAlta.SelectedItem.ToString
        Module1.articulos.Add(articulo, articulo.codigo)
    End Sub

    Private Sub clearData()
        txtCodigoAlta.Clear()
        txtNombreAlta.Clear()
        txtExistenciasAlta.Clear()
        txtPrecioAlta.Clear()
        comboBoxCategoriaAlta.SelectedIndex = -1
        txtRebajaAlta.Clear()
        rbArticuloAlta.Select()
    End Sub

    Private Sub btnCancelarAlta_Click(sender As Object, e As EventArgs) Handles btnCancelarAlta.Click
        clearData()
        Me.Hide()
    End Sub

    Private Sub rbArticuloAlta_CheckedChanged(sender As Object, e As EventArgs) Handles rbArticuloAlta.CheckedChanged
        If rbArticuloAlta.Checked Then
            lblRebajaAlta.Visible = False
            txtRebajaAlta.Visible = False
            txtRebajaAlta.Clear()
        Else
            lblRebajaAlta.Visible = True
            txtRebajaAlta.Visible = True
        End If
    End Sub
End Class