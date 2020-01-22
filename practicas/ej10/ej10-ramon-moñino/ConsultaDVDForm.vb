Public Class ConsultaDVDForm
    Private Sub ConsultaDVDForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearData()
    End Sub

    Private Sub btnConsultaBuscar_Click(sender As Object, e As EventArgs) Handles btnConsultaBuscar.Click
        buscarDVD()
    End Sub

    Private Sub buscarDVD()
        If rbCodigo.Checked Then
            If Colecciones.dvds.Contains(txtCod2.Text) Then
                mostrarDatosDVD(Colecciones.dvds(txtCod2.Text))
            Else
                MsgBox("No existe ningún DVD con el código: " & txtCod2.Text)
                clearData()
            End If
        Else
            Dim listado As New Collection
            buscarPorTitulo(listado)

            If listado.Count > 1 Then
                mostrarListado(listado)
            ElseIf listado.Count = 1 Then
                mostrarDatosDVD(listado(1))
            ElseIf listado.Count = 0 Then
                MsgBox("No existe ningún DVD con el título: " & txtTit2.Text)
                clearData()
            End If
        End If
    End Sub

    Private Sub mostrarDatosDVD(dvd As DVD)
        txtConsultaClienteCod.Text = dvd.codigo
        txtConsultaDVDTitulo.Text = dvd.titulo
        txtConsultaDVDDias.Text = dvd.diasAlquiler
        txtConsultaDVDAlquilado.Text = dvd.alquilado.ToString
    End Sub

    Private Sub mostrarListado(listado As Collection)
        ListadoConsultaVarios.rtbListadoConsulta.Text = "Listado" & vbNewLine
        For index = 1 To listado.Count
            ListadoConsultaVarios.rtbListadoConsulta.Text += listado(index).mostrarDatos() & vbNewLine
        Next
        ListadoConsultaVarios.Show()
    End Sub

    Private Sub buscarPorTitulo(listado As Collection)
        For index = 1 To Colecciones.dvds.Count
            Dim titulo As String = dvds(index).titulo

            If titulo.Contains(txtTit2.Text) Then
                listado.Add(dvds(index), dvds(index).codigo)
            End If
        Next
    End Sub

    Private Sub rbCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles rbCodigo.CheckedChanged
        If rbCodigo.Checked Then
            lblCod2.Visible = True
            txtCod2.Visible = True
        Else
            lblCod2.Visible = False
            txtCod2.Visible = False
            txtCod2.Clear()
        End If
        clearData()
    End Sub

    Private Sub rbTitulo_CheckedChanged(sender As Object, e As EventArgs) Handles rbTitulo.CheckedChanged
        If rbTitulo.Checked Then
            lbltit2.Visible = True
            txtTit2.Visible = True
        Else
            lbltit2.Visible = False
            txtTit2.Visible = False
            txtTit2.Clear()
        End If
        clearData()
    End Sub

    Private Sub clearData()
        txtConsultaClienteCod.Clear()
        txtConsultaDVDTitulo.Clear()
        txtConsultaDVDDias.Clear()
        txtConsultaDVDAlquilado.Clear()
    End Sub

    Private Sub btnConsultaSalir_Click(sender As Object, e As EventArgs) Handles btnConsultaSalir.Click
        Me.Close()
    End Sub
End Class