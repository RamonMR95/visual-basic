<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnConsultaSalir = New System.Windows.Forms.Button()
        Me.btnConsultaBuscar = New System.Windows.Forms.Button()
        Me.txtConsultaCodArt = New System.Windows.Forms.TextBox()
        Me.lblConsultaCodArt = New System.Windows.Forms.Label()
        Me.btnConsultaEliminar = New System.Windows.Forms.Button()
        Me.btnConsultaModificar = New System.Windows.Forms.Button()
        Me.txtConsultaRebaja = New System.Windows.Forms.TextBox()
        Me.txtConsultaPrecio = New System.Windows.Forms.TextBox()
        Me.txtConsultaExistencias = New System.Windows.Forms.TextBox()
        Me.txtConsultaNombre = New System.Windows.Forms.TextBox()
        Me.lblConsultaRebaja = New System.Windows.Forms.Label()
        Me.lblConsultaPrecio = New System.Windows.Forms.Label()
        Me.lblConsultaExistencias = New System.Windows.Forms.Label()
        Me.lblConsultaNombre = New System.Windows.Forms.Label()
        Me.btnConsultaLimpiar = New System.Windows.Forms.Button()
        Me.txtConsultaCategoria = New System.Windows.Forms.TextBox()
        Me.lblConsultaCategoria = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnConsultaSalir
        '
        Me.btnConsultaSalir.Location = New System.Drawing.Point(508, 237)
        Me.btnConsultaSalir.Name = "btnConsultaSalir"
        Me.btnConsultaSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultaSalir.TabIndex = 11
        Me.btnConsultaSalir.Text = "Salir"
        Me.btnConsultaSalir.UseVisualStyleBackColor = True
        '
        'btnConsultaBuscar
        '
        Me.btnConsultaBuscar.Location = New System.Drawing.Point(35, 237)
        Me.btnConsultaBuscar.Name = "btnConsultaBuscar"
        Me.btnConsultaBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultaBuscar.TabIndex = 10
        Me.btnConsultaBuscar.Text = "Buscar"
        Me.btnConsultaBuscar.UseVisualStyleBackColor = True
        '
        'txtConsultaCodArt
        '
        Me.txtConsultaCodArt.Location = New System.Drawing.Point(116, 38)
        Me.txtConsultaCodArt.Name = "txtConsultaCodArt"
        Me.txtConsultaCodArt.Size = New System.Drawing.Size(100, 20)
        Me.txtConsultaCodArt.TabIndex = 8
        '
        'lblConsultaCodArt
        '
        Me.lblConsultaCodArt.AutoSize = True
        Me.lblConsultaCodArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultaCodArt.Location = New System.Drawing.Point(34, 41)
        Me.lblConsultaCodArt.Name = "lblConsultaCodArt"
        Me.lblConsultaCodArt.Size = New System.Drawing.Size(46, 13)
        Me.lblConsultaCodArt.TabIndex = 6
        Me.lblConsultaCodArt.Text = "Código"
        '
        'btnConsultaEliminar
        '
        Me.btnConsultaEliminar.Location = New System.Drawing.Point(197, 237)
        Me.btnConsultaEliminar.Name = "btnConsultaEliminar"
        Me.btnConsultaEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultaEliminar.TabIndex = 12
        Me.btnConsultaEliminar.Text = "Eliminar"
        Me.btnConsultaEliminar.UseVisualStyleBackColor = True
        '
        'btnConsultaModificar
        '
        Me.btnConsultaModificar.Location = New System.Drawing.Point(116, 237)
        Me.btnConsultaModificar.Name = "btnConsultaModificar"
        Me.btnConsultaModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultaModificar.TabIndex = 14
        Me.btnConsultaModificar.Text = "Modificar"
        Me.btnConsultaModificar.UseVisualStyleBackColor = True
        '
        'txtConsultaRebaja
        '
        Me.txtConsultaRebaja.Location = New System.Drawing.Point(315, 156)
        Me.txtConsultaRebaja.Name = "txtConsultaRebaja"
        Me.txtConsultaRebaja.ReadOnly = True
        Me.txtConsultaRebaja.Size = New System.Drawing.Size(100, 20)
        Me.txtConsultaRebaja.TabIndex = 22
        '
        'txtConsultaPrecio
        '
        Me.txtConsultaPrecio.Location = New System.Drawing.Point(116, 159)
        Me.txtConsultaPrecio.Name = "txtConsultaPrecio"
        Me.txtConsultaPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtConsultaPrecio.TabIndex = 21
        '
        'txtConsultaExistencias
        '
        Me.txtConsultaExistencias.Location = New System.Drawing.Point(116, 118)
        Me.txtConsultaExistencias.Name = "txtConsultaExistencias"
        Me.txtConsultaExistencias.Size = New System.Drawing.Size(100, 20)
        Me.txtConsultaExistencias.TabIndex = 20
        '
        'txtConsultaNombre
        '
        Me.txtConsultaNombre.Location = New System.Drawing.Point(116, 76)
        Me.txtConsultaNombre.Name = "txtConsultaNombre"
        Me.txtConsultaNombre.ReadOnly = True
        Me.txtConsultaNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtConsultaNombre.TabIndex = 19
        '
        'lblConsultaRebaja
        '
        Me.lblConsultaRebaja.AutoSize = True
        Me.lblConsultaRebaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultaRebaja.Location = New System.Drawing.Point(257, 159)
        Me.lblConsultaRebaja.Name = "lblConsultaRebaja"
        Me.lblConsultaRebaja.Size = New System.Drawing.Size(47, 13)
        Me.lblConsultaRebaja.TabIndex = 18
        Me.lblConsultaRebaja.Text = "Rebaja"
        '
        'lblConsultaPrecio
        '
        Me.lblConsultaPrecio.AutoSize = True
        Me.lblConsultaPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultaPrecio.Location = New System.Drawing.Point(34, 160)
        Me.lblConsultaPrecio.Name = "lblConsultaPrecio"
        Me.lblConsultaPrecio.Size = New System.Drawing.Size(43, 13)
        Me.lblConsultaPrecio.TabIndex = 17
        Me.lblConsultaPrecio.Text = "Precio"
        '
        'lblConsultaExistencias
        '
        Me.lblConsultaExistencias.AutoSize = True
        Me.lblConsultaExistencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultaExistencias.Location = New System.Drawing.Point(34, 121)
        Me.lblConsultaExistencias.Name = "lblConsultaExistencias"
        Me.lblConsultaExistencias.Size = New System.Drawing.Size(71, 13)
        Me.lblConsultaExistencias.TabIndex = 16
        Me.lblConsultaExistencias.Text = "Existencias"
        '
        'lblConsultaNombre
        '
        Me.lblConsultaNombre.AutoSize = True
        Me.lblConsultaNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultaNombre.Location = New System.Drawing.Point(34, 79)
        Me.lblConsultaNombre.Name = "lblConsultaNombre"
        Me.lblConsultaNombre.Size = New System.Drawing.Size(50, 13)
        Me.lblConsultaNombre.TabIndex = 15
        Me.lblConsultaNombre.Text = "Nombre"
        '
        'btnConsultaLimpiar
        '
        Me.btnConsultaLimpiar.Location = New System.Drawing.Point(376, 237)
        Me.btnConsultaLimpiar.Name = "btnConsultaLimpiar"
        Me.btnConsultaLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultaLimpiar.TabIndex = 23
        Me.btnConsultaLimpiar.Text = "Limpiar"
        Me.btnConsultaLimpiar.UseVisualStyleBackColor = True
        '
        'txtConsultaCategoria
        '
        Me.txtConsultaCategoria.Location = New System.Drawing.Point(116, 197)
        Me.txtConsultaCategoria.Name = "txtConsultaCategoria"
        Me.txtConsultaCategoria.ReadOnly = True
        Me.txtConsultaCategoria.Size = New System.Drawing.Size(100, 20)
        Me.txtConsultaCategoria.TabIndex = 25
        '
        'lblConsultaCategoria
        '
        Me.lblConsultaCategoria.AutoSize = True
        Me.lblConsultaCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultaCategoria.Location = New System.Drawing.Point(34, 198)
        Me.lblConsultaCategoria.Name = "lblConsultaCategoria"
        Me.lblConsultaCategoria.Size = New System.Drawing.Size(63, 13)
        Me.lblConsultaCategoria.TabIndex = 24
        Me.lblConsultaCategoria.Text = "Categoría"
        '
        'ConsultaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 287)
        Me.Controls.Add(Me.txtConsultaCategoria)
        Me.Controls.Add(Me.lblConsultaCategoria)
        Me.Controls.Add(Me.btnConsultaLimpiar)
        Me.Controls.Add(Me.txtConsultaRebaja)
        Me.Controls.Add(Me.txtConsultaPrecio)
        Me.Controls.Add(Me.txtConsultaExistencias)
        Me.Controls.Add(Me.txtConsultaNombre)
        Me.Controls.Add(Me.lblConsultaRebaja)
        Me.Controls.Add(Me.lblConsultaPrecio)
        Me.Controls.Add(Me.lblConsultaExistencias)
        Me.Controls.Add(Me.lblConsultaNombre)
        Me.Controls.Add(Me.btnConsultaModificar)
        Me.Controls.Add(Me.btnConsultaEliminar)
        Me.Controls.Add(Me.btnConsultaSalir)
        Me.Controls.Add(Me.btnConsultaBuscar)
        Me.Controls.Add(Me.txtConsultaCodArt)
        Me.Controls.Add(Me.lblConsultaCodArt)
        Me.Name = "ConsultaForm"
        Me.Text = "ConsultaForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConsultaSalir As Button
    Friend WithEvents btnConsultaBuscar As Button
    Friend WithEvents txtConsultaCodArt As TextBox
    Friend WithEvents lblConsultaCodArt As Label
    Friend WithEvents btnConsultaEliminar As Button
    Friend WithEvents btnConsultaModificar As Button
    Friend WithEvents txtConsultaRebaja As TextBox
    Friend WithEvents txtConsultaPrecio As TextBox
    Friend WithEvents txtConsultaExistencias As TextBox
    Friend WithEvents txtConsultaNombre As TextBox
    Friend WithEvents lblConsultaRebaja As Label
    Friend WithEvents lblConsultaPrecio As Label
    Friend WithEvents lblConsultaExistencias As Label
    Friend WithEvents lblConsultaNombre As Label
    Friend WithEvents btnConsultaLimpiar As Button
    Friend WithEvents txtConsultaCategoria As TextBox
    Friend WithEvents lblConsultaCategoria As Label
End Class
