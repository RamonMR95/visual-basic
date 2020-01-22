Imports System.IO
Public Class ArticulosForm
    Public articulo As Articulo
    Public articuloRebajado As ArticuloRebajado
    Public cadenaGrabar As StreamWriter
    Public cadenaMostrar As StreamReader

    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        AltaForm.MdiParent = Me
        AltaForm.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub PedirArticuloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedirArticuloToolStripMenuItem.Click
        PedidoForm.MdiParent = Me
        PedidoForm.Show()
    End Sub

    Private Sub GenerarAlbaránToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarAlbaránToolStripMenuItem.Click
        AlbaranForm.MdiParent = Me
        AlbaranForm.Show()
    End Sub

    Private Sub MostrarTodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarTodosToolStripMenuItem.Click
        ListadoForm.MdiParent = Me

        If articulos.Count > 0 Then
            ListadoForm.rtbListado.Text = "Código" & vbTab & "Nombre" & vbTab & "Categoría" & vbTab & vbTab & "Precio" & vbTab & "Existencias" & vbTab & "Rebaja" & vbNewLine

            For index = 1 To articulos.Count
                ListadoForm.rtbListado.Text += articulos(index).imprimirArticulo() & vbNewLine
            Next
        End If
        ListadoForm.Show()
    End Sub

    Private Sub ConsultaBajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaBajaToolStripMenuItem.Click
        ConsultaForm.MdiParent = Me
        ConsultaForm.Show()
    End Sub


    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        MsgBox("Ramón Moñino Rubio" & vbNewLine & "v1.0")
    End Sub

    Private Sub ArticulosMinimosStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArticulosMinimosStripMenuItem.Click
        ListadoForm.MdiParent = Me

        If articulos.Count > 0 Then
            ListadoForm.rtbListado.Text = "Código" & vbTab & "Nombre" & vbTab & "Categoría" & vbTab & vbTab & "Precio" & vbTab & "Existencias" & vbTab & "Rebaja" & vbNewLine

            For index = 1 To articulos.Count
                If articulos(index).existencias < 10 Then
                    ListadoForm.rtbListado.Text += articulos(index).imprimirArticulo() & vbNewLine
                End If
            Next
        End If
        ListadoForm.Show()
    End Sub

    Private Sub ArticulosCatStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArticulosCatStripMenuItem.Click
        ListadoForm.lblListadoCat.Visible = True
        ListadoForm.comboBoxListadoCat.Visible = True

        If articulos.Count > 0 Then
            For index = 1 To articulos.Count
                ListadoForm.comboBoxListadoCat.Items.Add(articulos(index).categoria)
            Next
        End If
        ListadoForm.MdiParent = Me
        ListadoForm.Show()
    End Sub

    Private Sub AbrirListadoAlbaránToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirListadoAlbaránToolStripMenuItem.Click
        Dim dlgo As New OpenFileDialog()
        dlgo.Title = "Seleccione una Fichero..."
        dlgo.FileName = "Documento"
        dlgo.DefaultExt = ".txt"
        dlgo.Filter = "*Text documents (.txt)|*.txt"

        Dim result As DialogResult = dlgo.ShowDialog()
        ListadoForm.MdiParent = Me
        If result = DialogResult.OK Then
            Dim pathFileName As String = dlgo.FileName
            Dim fileName As String = dlgo.SafeFileName
            cadenaMostrar = New StreamReader(pathFileName)
            ListadoForm.rtbListado.Text = cadenaMostrar.ReadToEnd
            ListadoForm.Name = fileName
            ListadoForm.Text = fileName
            ListadoForm.Show()
            cadenaMostrar.Close()
        End If
    End Sub

    Private Function getMdiChildActual() As ListadoForm
        Dim listadoActual As ListadoForm
        listadoActual = Me.ActiveMdiChild
        Return listadoActual
    End Function

End Class
