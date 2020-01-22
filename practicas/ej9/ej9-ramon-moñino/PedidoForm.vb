Public Class PedidoForm

    Dim albaran As Albaran

    Private Sub PedidoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nAlbaran += 1
        albaran = New Albaran(nAlbaran)
    End Sub

    Private Sub btnPedidoAceptar_Click(sender As Object, e As EventArgs) Handles btnPedidoAceptar.Click
        actualizarExistencias()
    End Sub

    Private Sub actualizarExistencias()
        Try
            If Not CInt(txtPedidoCantidad.Text) > 0 Then
                MsgBox("Valores inválidos")
                Return
            End If

            If articulos.Contains(txtPedidoCodArt.Text) Then
                If articulos(txtPedidoCodArt.Text).existencias >= CInt(txtPedidoCantidad.Text) Then
                    articulos(txtPedidoCodArt.Text).existencias -= CInt(txtPedidoCantidad.Text)
                    albaran.addArticulo(articulos.Item(txtPedidoCodArt.Text))
                    MsgBox("Pedido realizado del Cod Art" & txtPedidoCodArt.Text & " con una cantidad de : " & CInt(txtPedidoCantidad.Text) &
                           " articulos" & vbNewLine & "Quedan : " & articulos(txtPedidoCodArt.Text).existencias)
                Else
                    MsgBox("NO hay suficientes ExistenciasArticulo: " & articulos(txtPedidoCodArt.Text).existencias)
                End If
            Else
                MsgBox("El articulo no existe en la db")
            End If
        Catch ex As Exception
            MsgBox("Valores inválidos")
        End Try
    End Sub

    Private Sub btnPedidoCancelar_Click(sender As Object, e As EventArgs) Handles btnPedidoCancelar.Click
        albaranes.Add(albaran, albaran.numero)
        Me.Close()
    End Sub
End Class