<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArticulosForm
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
        Me.MenuStripArticulos = New System.Windows.Forms.MenuStrip()
        Me.ArtículoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaBajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedirArticuloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarAlbaránToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarTodosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticulosMinimosStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticulosCatStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AbrirListadoAlbaránToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripArticulos.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripArticulos
        '
        Me.MenuStripArticulos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArtículoToolStripMenuItem, Me.PedidoToolStripMenuItem, Me.ListadoToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStripArticulos.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripArticulos.Name = "MenuStripArticulos"
        Me.MenuStripArticulos.Size = New System.Drawing.Size(800, 24)
        Me.MenuStripArticulos.TabIndex = 0
        Me.MenuStripArticulos.Text = "MenuStrip1"
        '
        'ArtículoToolStripMenuItem
        '
        Me.ArtículoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.ConsultaBajaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArtículoToolStripMenuItem.Name = "ArtículoToolStripMenuItem"
        Me.ArtículoToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ArtículoToolStripMenuItem.Text = "Artículo"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AltaToolStripMenuItem.Text = "Alta"
        '
        'ConsultaBajaToolStripMenuItem
        '
        Me.ConsultaBajaToolStripMenuItem.Name = "ConsultaBajaToolStripMenuItem"
        Me.ConsultaBajaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConsultaBajaToolStripMenuItem.Text = "Consulta/Baja"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'PedidoToolStripMenuItem
        '
        Me.PedidoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PedirArticuloToolStripMenuItem, Me.GenerarAlbaránToolStripMenuItem})
        Me.PedidoToolStripMenuItem.Name = "PedidoToolStripMenuItem"
        Me.PedidoToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.PedidoToolStripMenuItem.Text = "Pedido"
        '
        'PedirArticuloToolStripMenuItem
        '
        Me.PedirArticuloToolStripMenuItem.Name = "PedirArticuloToolStripMenuItem"
        Me.PedirArticuloToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.PedirArticuloToolStripMenuItem.Text = "Pedir Articulo"
        '
        'GenerarAlbaránToolStripMenuItem
        '
        Me.GenerarAlbaránToolStripMenuItem.Name = "GenerarAlbaránToolStripMenuItem"
        Me.GenerarAlbaránToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.GenerarAlbaránToolStripMenuItem.Text = "Generar Albarán"
        '
        'ListadoToolStripMenuItem
        '
        Me.ListadoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MostrarTodosToolStripMenuItem, Me.ArticulosMinimosStripMenuItem, Me.ArticulosCatStripMenuItem, Me.ToolStripSeparator1, Me.AbrirListadoAlbaránToolStripMenuItem})
        Me.ListadoToolStripMenuItem.Name = "ListadoToolStripMenuItem"
        Me.ListadoToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.ListadoToolStripMenuItem.Text = "Listado"
        '
        'MostrarTodosToolStripMenuItem
        '
        Me.MostrarTodosToolStripMenuItem.Name = "MostrarTodosToolStripMenuItem"
        Me.MostrarTodosToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.MostrarTodosToolStripMenuItem.Text = "Todos los artículos"
        '
        'ArticulosMinimosStripMenuItem
        '
        Me.ArticulosMinimosStripMenuItem.Name = "ArticulosMinimosStripMenuItem"
        Me.ArticulosMinimosStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ArticulosMinimosStripMenuItem.Text = "Artículos en mínimos"
        '
        'ArticulosCatStripMenuItem
        '
        Me.ArticulosCatStripMenuItem.Name = "ArticulosCatStripMenuItem"
        Me.ArticulosCatStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ArticulosCatStripMenuItem.Text = "Artículos por categoría"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(191, 6)
        '
        'AbrirListadoAlbaránToolStripMenuItem
        '
        Me.AbrirListadoAlbaránToolStripMenuItem.Name = "AbrirListadoAlbaránToolStripMenuItem"
        Me.AbrirListadoAlbaránToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.AbrirListadoAlbaránToolStripMenuItem.Text = "Abrir listado / albarán"
        '
        'ArticulosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStripArticulos)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStripArticulos
        Me.Name = "ArticulosForm"
        Me.Text = "Articulos"
        Me.MenuStripArticulos.ResumeLayout(False)
        Me.MenuStripArticulos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStripArticulos As MenuStrip
    Friend WithEvents ArtículoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaBajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PedidoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarTodosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArticulosMinimosStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArticulosCatStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PedirArticuloToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerarAlbaránToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AbrirListadoAlbaránToolStripMenuItem As ToolStripMenuItem
End Class
