Public Class Form1

    Private Sub butSalirV_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TratamientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TratamientoToolStripMenuItem.Click
        Dim cli As String = InputBox("Introduce el cod cliente", "Pedidos mes")
        Dim encontrado As Boolean = False

        For i = 1 To colecPedidos.Count
            If colecPedidos(i).pedClienteID = cli Then
                colecCliente(colecPedidos(i).pedClienteID).p_comprasMes += colecPedidos(i).cantidad * colecPedidos(i).precioUni
                encontrado = True
            End If
        Next

        If encontrado Then
            MsgBox("El campo compras mes del cliente '" & cli & "' ha sido actualizado")
        End If
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        'Inicializar campo compraMes de colecCliente
        For i = 1 To colecCliente.Count
            colecCliente(i).p_comprasMes = 0
        Next
        MsgBox("Reestablecido el campo compras mes de los clientes")
    End Sub

    Private Sub ComisiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComisiónToolStripMenuItem.Click
        If colecCliente.Count > 0 Then
            grbComision.Visible = True
            grbPedido.Visible = False
        Else
            MsgBox("Primer tiene que dar de alta a los clientes y los vendedores")
        End If
    End Sub

    Private Sub VentaTotalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaTotalToolStripMenuItem.Click
        'ventas totales de cada uno de los vendedores, 1 por linea y en la última linea el total ventas de todos los vendedores
        If colecVendedor.Count > 0 Then
            Dim totalVentas As Double = 0
            Form3.rtbVentas.Text = "vendedorID" & vbTab & "nombre" & vbTab & "zona" & vbTab & "ventas" & vbNewLine

            For i = 1 To colecVendedor.Count
                Dim nVentas As Integer = 0
                For j = 1 To colecPedidos.Count
                    If colecCliente(colecPedidos(j).pedClienteID).p_cliVendeID = colecVendedor(i).p_vendedorID Then
                        nVentas += 1
                        totalVentas += 1
                    End If
                Next
                Form3.rtbVentas.Text += colecVendedor(i).p_vendedorID & vbTab & colecVendedor(i).p_nombre & vbTab & colecVendedor(i).p_zona & vbTab & nVentas & vbNewLine
            Next
            Form3.rtbVentas.Text += "TOTAL VENTAS" & vbTab & vbTab & totalVentas
            Form3.Show()
        Else
            MsgBox("Primero debe dar de alta a los vendedores!")
        End If
    End Sub



    Private Sub clienteYvendedor_Click(sender As Object, e As EventArgs) Handles clienteYvendedor.Click
        'Alta Cliente
        For i = 1 To 5
            Dim oCliente As New Cliente
            With oCliente
                .p_clienteID = "c" & i
                .p_cliVendeID = "v" & i
                .p_comisionV = 2 + i
                .p_comprasMes = 0
                colecCliente.Add(oCliente, .p_clienteID)
            End With
        Next

        'Alta  Vendedor
        For i = 1 To 5
            Dim oVendedor As New Vendedor
            With oVendedor
                .p_vendedorID = "v" & i
                .p_nombre = "vendedor" & i
                .p_zona = "zona" & i
                .p_retencion = 10 + i
                colecVendedor.Add(oVendedor, .p_vendedorID)
            End With
        Next
        MsgBox("altas creadas")

        For i = 1 To colecVendedor.Count
            cmbVend.Items.Add(colecVendedor(i).p_vendedorID)
        Next
    End Sub

    Private Sub PedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidoToolStripMenuItem.Click
        grbPedido.Visible = True
    End Sub

    Private Sub butGuardarC_Click(sender As Object, e As EventArgs) Handles butGuardarC.Click
        If Module1.colecCliente.Contains(txtClienteID.Text) Then
            If cobProducto.SelectedIndex <> -1 Then
                If Not String.IsNullOrEmpty(txtCantidad.Text) And IsNumeric(txtCantidad.Text) Then
                    If Not String.IsNullOrEmpty(txtPrecio.Text) And IsNumeric(txtPrecio.Text) Then
                        altaPedido()
                    Else
                        MsgBox("Error: Precio uni formato incorrecto!")
                    End If
                Else
                    MsgBox("Error: Cantidad formato incorrecto!")
                End If
            Else
                MsgBox("El producto es requerido!")
            End If
        Else
            MsgBox("Error: No se encuentra cliente!")
        End If
    End Sub

    Private Sub altaPedido()
        If CInt(txtCantidad.Text) > 0 And CDbl(txtPrecio.Text) > 0 Then
            Dim pedido As New Pedido
            pedido.pedidoId = numPedido
            pedido.pedClienteID = txtClienteID.Text
            pedido.producto = cobProducto.SelectedItem
            pedido.cantidad = CInt(txtCantidad.Text)
            pedido.precioUni = CDbl(txtPrecio.Text)
            colecPedidos.Add(pedido, CStr(pedido.pedidoId))
            colecCliente(pedido.pedClienteID).p_comprasMes += pedido.cantidad * pedido.precioUni
            MsgBox("Pedido creado con num: " & pedido.pedidoId)
            numPedido += 1
        Else
            MsgBox("Precio y cantidad deben ser > 0!")
        End If
    End Sub

    Private Sub butCalcular_Click(sender As Object, e As EventArgs) Handles butCalcular.Click

        If cmbVend.SelectedIndex <> -1 And cmbVend.SelectedItem IsNot Nothing Then
            Dim totalComprasMes As Double
            Dim totalACobrar As Double
            Dim vendSeleccionado As String = cmbVend.SelectedItem

            Dim vend As Vendedor = colecVendedor(vendSeleccionado)
            Form2.rtbComision.Text = Today & vbTab & vend.p_vendedorID & vbTab & vend.p_nombre & vbTab & vend.p_zona & vbNewLine

            For i = 1 To colecPedidos.Count
                If colecCliente(colecPedidos(i).pedClienteID).p_cliVendeID = vendSeleccionado Then
                    Dim comisionACobrar As Double = colecCliente(i).p_comprasMes * colecCliente(i).p_comisionV
                    totalComprasMes += colecCliente(i).p_comprasMes
                    Form2.rtbComision.Text += colecCliente(i).p_clienteID & vbTab & colecCliente(i).p_comprasMes & vbTab & colecCliente(i).p_comisionV & vbTab & comisionACobrar & vbNewLine
                    totalACobrar = totalComprasMes - (totalComprasMes * (vend.p_retencion / 100))
                    Form2.rtbComision.Text += "Totales" & vbTab & totalComprasMes & vbTab & vbTab & totalACobrar & vbNewLine
                    Form2.rtbComision.Text += vbTab & vbTab & "%retencion" & vbTab & "Total a cobrar€"
                End If
            Next
        Else
            MsgBox("Selecciona un vendedor para poder calcular la comisión")
        End If
        Form2.Show()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub BBDDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BBDDToolStripMenuItem.Click
        Form4.Show()
    End Sub
End Class
