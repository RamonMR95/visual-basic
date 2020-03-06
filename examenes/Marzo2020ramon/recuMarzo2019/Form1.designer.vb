<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.clienteYvendedor = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TratamientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComisiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaTotalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BBDDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grbPedido = New System.Windows.Forms.GroupBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.butSalirC = New System.Windows.Forms.Button()
        Me.cobProducto = New System.Windows.Forms.ComboBox()
        Me.butGuardarC = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtClienteID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grbComision = New System.Windows.Forms.GroupBox()
        Me.butSalirComi = New System.Windows.Forms.Button()
        Me.butCalcular = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbVend = New System.Windows.Forms.ComboBox()
        Me.RamónMoñino9ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.grbPedido.SuspendLayout()
        Me.grbComision.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.ConsultaToolStripMenuItem, Me.FacturaToolStripMenuItem, Me.BBDDToolStripMenuItem, Me.AcercaDeToolStripMenuItem1, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(391, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.clienteYvendedor, Me.PedidoToolStripMenuItem})
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.AltaToolStripMenuItem.Text = "Alta"
        '
        'clienteYvendedor
        '
        Me.clienteYvendedor.Name = "clienteYvendedor"
        Me.clienteYvendedor.Size = New System.Drawing.Size(173, 22)
        Me.clienteYvendedor.Text = "Cliente y Vendedor"
        '
        'PedidoToolStripMenuItem
        '
        Me.PedidoToolStripMenuItem.Name = "PedidoToolStripMenuItem"
        Me.PedidoToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.PedidoToolStripMenuItem.Text = "Pedido"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem, Me.TratamientoToolStripMenuItem})
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.ConsultaToolStripMenuItem.Text = "Compras Mes"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.ClienteToolStripMenuItem.Text = "Inicializar "
        '
        'TratamientoToolStripMenuItem
        '
        Me.TratamientoToolStripMenuItem.Name = "TratamientoToolStripMenuItem"
        Me.TratamientoToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.TratamientoToolStripMenuItem.Text = "Actualizar "
        '
        'FacturaToolStripMenuItem
        '
        Me.FacturaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComisiónToolStripMenuItem, Me.VentaTotalToolStripMenuItem})
        Me.FacturaToolStripMenuItem.Name = "FacturaToolStripMenuItem"
        Me.FacturaToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.FacturaToolStripMenuItem.Text = "Vendedor"
        '
        'ComisiónToolStripMenuItem
        '
        Me.ComisiónToolStripMenuItem.Name = "ComisiónToolStripMenuItem"
        Me.ComisiónToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ComisiónToolStripMenuItem.Text = "Comisión"
        '
        'VentaTotalToolStripMenuItem
        '
        Me.VentaTotalToolStripMenuItem.Name = "VentaTotalToolStripMenuItem"
        Me.VentaTotalToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.VentaTotalToolStripMenuItem.Text = "Ventas totales"
        '
        'BBDDToolStripMenuItem
        '
        Me.BBDDToolStripMenuItem.Name = "BBDDToolStripMenuItem"
        Me.BBDDToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.BBDDToolStripMenuItem.Text = "BBDD"
        '
        'AcercaDeToolStripMenuItem1
        '
        Me.AcercaDeToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RamónMoñino9ToolStripMenuItem})
        Me.AcercaDeToolStripMenuItem1.Name = "AcercaDeToolStripMenuItem1"
        Me.AcercaDeToolStripMenuItem1.Size = New System.Drawing.Size(80, 20)
        Me.AcercaDeToolStripMenuItem1.Text = "Acerca de..."
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.AcercaDeToolStripMenuItem.Text = "Salir"
        '
        'grbPedido
        '
        Me.grbPedido.Controls.Add(Me.txtPrecio)
        Me.grbPedido.Controls.Add(Me.lblPrecio)
        Me.grbPedido.Controls.Add(Me.butSalirC)
        Me.grbPedido.Controls.Add(Me.cobProducto)
        Me.grbPedido.Controls.Add(Me.butGuardarC)
        Me.grbPedido.Controls.Add(Me.txtCantidad)
        Me.grbPedido.Controls.Add(Me.txtClienteID)
        Me.grbPedido.Controls.Add(Me.Label4)
        Me.grbPedido.Controls.Add(Me.Label2)
        Me.grbPedido.Controls.Add(Me.Label1)
        Me.grbPedido.Location = New System.Drawing.Point(43, 93)
        Me.grbPedido.Name = "grbPedido"
        Me.grbPedido.Size = New System.Drawing.Size(313, 191)
        Me.grbPedido.TabIndex = 1
        Me.grbPedido.TabStop = False
        Me.grbPedido.Text = "Alta Pedido"
        Me.grbPedido.Visible = False
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(99, 98)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 13
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(11, 105)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(37, 13)
        Me.lblPrecio.TabIndex = 12
        Me.lblPrecio.Text = "Precio"
        '
        'butSalirC
        '
        Me.butSalirC.Location = New System.Drawing.Point(53, 146)
        Me.butSalirC.Name = "butSalirC"
        Me.butSalirC.Size = New System.Drawing.Size(46, 24)
        Me.butSalirC.TabIndex = 11
        Me.butSalirC.Text = "Salir"
        Me.butSalirC.UseVisualStyleBackColor = True
        '
        'cobProducto
        '
        Me.cobProducto.FormattingEnabled = True
        Me.cobProducto.Items.AddRange(New Object() {"monitor", "portatil", "pc", "teclado", "raton"})
        Me.cobProducto.Location = New System.Drawing.Point(99, 45)
        Me.cobProducto.Name = "cobProducto"
        Me.cobProducto.Size = New System.Drawing.Size(100, 21)
        Me.cobProducto.TabIndex = 10
        '
        'butGuardarC
        '
        Me.butGuardarC.Location = New System.Drawing.Point(143, 146)
        Me.butGuardarC.Name = "butGuardarC"
        Me.butGuardarC.Size = New System.Drawing.Size(56, 23)
        Me.butGuardarC.TabIndex = 8
        Me.butGuardarC.Text = "Guardar"
        Me.butGuardarC.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(99, 72)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 7
        '
        'txtClienteID
        '
        Me.txtClienteID.Location = New System.Drawing.Point(99, 23)
        Me.txtClienteID.Name = "txtClienteID"
        Me.txtClienteID.Size = New System.Drawing.Size(100, 20)
        Me.txtClienteID.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Producto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente ID"
        '
        'grbComision
        '
        Me.grbComision.Controls.Add(Me.butSalirComi)
        Me.grbComision.Controls.Add(Me.butCalcular)
        Me.grbComision.Controls.Add(Me.Label3)
        Me.grbComision.Controls.Add(Me.cmbVend)
        Me.grbComision.Location = New System.Drawing.Point(43, 27)
        Me.grbComision.Name = "grbComision"
        Me.grbComision.Size = New System.Drawing.Size(313, 60)
        Me.grbComision.TabIndex = 7
        Me.grbComision.TabStop = False
        Me.grbComision.Text = "Comisión"
        Me.grbComision.Visible = False
        '
        'butSalirComi
        '
        Me.butSalirComi.Location = New System.Drawing.Point(227, 19)
        Me.butSalirComi.Name = "butSalirComi"
        Me.butSalirComi.Size = New System.Drawing.Size(49, 23)
        Me.butSalirComi.TabIndex = 3
        Me.butSalirComi.Text = "Salir"
        Me.butSalirComi.UseVisualStyleBackColor = True
        '
        'butCalcular
        '
        Me.butCalcular.Location = New System.Drawing.Point(160, 19)
        Me.butCalcular.Name = "butCalcular"
        Me.butCalcular.Size = New System.Drawing.Size(53, 23)
        Me.butCalcular.TabIndex = 2
        Me.butCalcular.Text = "Calcular"
        Me.butCalcular.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Código vendedor"
        '
        'cmbVend
        '
        Me.cmbVend.FormattingEnabled = True
        Me.cmbVend.Location = New System.Drawing.Point(105, 19)
        Me.cmbVend.Name = "cmbVend"
        Me.cmbVend.Size = New System.Drawing.Size(49, 21)
        Me.cmbVend.TabIndex = 0
        '
        'RamónMoñino9ToolStripMenuItem
        '
        Me.RamónMoñino9ToolStripMenuItem.Name = "RamónMoñino9ToolStripMenuItem"
        Me.RamónMoñino9ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RamónMoñino9ToolStripMenuItem.Text = "Ramón Moñino 9"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 310)
        Me.Controls.Add(Me.grbComision)
        Me.Controls.Add(Me.grbPedido)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Examen recuperación Marzo 2020"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grbPedido.ResumeLayout(False)
        Me.grbPedido.PerformLayout()
        Me.grbComision.ResumeLayout(False)
        Me.grbComision.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AltaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents clienteYvendedor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TratamientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grbPedido As System.Windows.Forms.GroupBox
    Friend WithEvents butGuardarC As System.Windows.Forms.Button
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtClienteID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComisiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentaTotalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cobProducto As System.Windows.Forms.ComboBox
    Friend WithEvents butSalirC As System.Windows.Forms.Button
    Friend WithEvents grbComision As System.Windows.Forms.GroupBox
    Friend WithEvents butCalcular As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbVend As System.Windows.Forms.ComboBox
    Friend WithEvents butSalirComi As System.Windows.Forms.Button
    Friend WithEvents PedidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BBDDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents RamónMoñino9ToolStripMenuItem As ToolStripMenuItem
End Class
