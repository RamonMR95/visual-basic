<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaForm
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
        Me.lblCodigoAlta = New System.Windows.Forms.Label()
        Me.lblNombreAlta = New System.Windows.Forms.Label()
        Me.lblExistenciasAlta = New System.Windows.Forms.Label()
        Me.lblPrecioAlta = New System.Windows.Forms.Label()
        Me.lblCategoriaAlta = New System.Windows.Forms.Label()
        Me.lblRebajaAlta = New System.Windows.Forms.Label()
        Me.txtCodigoAlta = New System.Windows.Forms.TextBox()
        Me.txtNombreAlta = New System.Windows.Forms.TextBox()
        Me.txtExistenciasAlta = New System.Windows.Forms.TextBox()
        Me.txtPrecioAlta = New System.Windows.Forms.TextBox()
        Me.txtRebajaAlta = New System.Windows.Forms.TextBox()
        Me.comboBoxCategoriaAlta = New System.Windows.Forms.ComboBox()
        Me.gbArticuloAlta = New System.Windows.Forms.GroupBox()
        Me.rbArticuloRebajadoAlta = New System.Windows.Forms.RadioButton()
        Me.rbArticuloAlta = New System.Windows.Forms.RadioButton()
        Me.btnCancelarAlta = New System.Windows.Forms.Button()
        Me.btnAceptarAlta = New System.Windows.Forms.Button()
        Me.gbArticuloAlta.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCodigoAlta
        '
        Me.lblCodigoAlta.AutoSize = True
        Me.lblCodigoAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoAlta.Location = New System.Drawing.Point(48, 60)
        Me.lblCodigoAlta.Name = "lblCodigoAlta"
        Me.lblCodigoAlta.Size = New System.Drawing.Size(46, 13)
        Me.lblCodigoAlta.TabIndex = 0
        Me.lblCodigoAlta.Text = "Código"
        '
        'lblNombreAlta
        '
        Me.lblNombreAlta.AutoSize = True
        Me.lblNombreAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreAlta.Location = New System.Drawing.Point(48, 97)
        Me.lblNombreAlta.Name = "lblNombreAlta"
        Me.lblNombreAlta.Size = New System.Drawing.Size(50, 13)
        Me.lblNombreAlta.TabIndex = 1
        Me.lblNombreAlta.Text = "Nombre"
        '
        'lblExistenciasAlta
        '
        Me.lblExistenciasAlta.AutoSize = True
        Me.lblExistenciasAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExistenciasAlta.Location = New System.Drawing.Point(48, 139)
        Me.lblExistenciasAlta.Name = "lblExistenciasAlta"
        Me.lblExistenciasAlta.Size = New System.Drawing.Size(71, 13)
        Me.lblExistenciasAlta.TabIndex = 2
        Me.lblExistenciasAlta.Text = "Existencias"
        '
        'lblPrecioAlta
        '
        Me.lblPrecioAlta.AutoSize = True
        Me.lblPrecioAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioAlta.Location = New System.Drawing.Point(48, 178)
        Me.lblPrecioAlta.Name = "lblPrecioAlta"
        Me.lblPrecioAlta.Size = New System.Drawing.Size(43, 13)
        Me.lblPrecioAlta.TabIndex = 3
        Me.lblPrecioAlta.Text = "Precio"
        '
        'lblCategoriaAlta
        '
        Me.lblCategoriaAlta.AutoSize = True
        Me.lblCategoriaAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoriaAlta.Location = New System.Drawing.Point(48, 215)
        Me.lblCategoriaAlta.Name = "lblCategoriaAlta"
        Me.lblCategoriaAlta.Size = New System.Drawing.Size(63, 13)
        Me.lblCategoriaAlta.TabIndex = 4
        Me.lblCategoriaAlta.Text = "Categoría"
        '
        'lblRebajaAlta
        '
        Me.lblRebajaAlta.AutoSize = True
        Me.lblRebajaAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRebajaAlta.Location = New System.Drawing.Point(271, 177)
        Me.lblRebajaAlta.Name = "lblRebajaAlta"
        Me.lblRebajaAlta.Size = New System.Drawing.Size(47, 13)
        Me.lblRebajaAlta.TabIndex = 5
        Me.lblRebajaAlta.Text = "Rebaja"
        '
        'txtCodigoAlta
        '
        Me.txtCodigoAlta.Location = New System.Drawing.Point(130, 57)
        Me.txtCodigoAlta.Name = "txtCodigoAlta"
        Me.txtCodigoAlta.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoAlta.TabIndex = 6
        '
        'txtNombreAlta
        '
        Me.txtNombreAlta.Location = New System.Drawing.Point(130, 94)
        Me.txtNombreAlta.Name = "txtNombreAlta"
        Me.txtNombreAlta.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreAlta.TabIndex = 7
        '
        'txtExistenciasAlta
        '
        Me.txtExistenciasAlta.Location = New System.Drawing.Point(130, 136)
        Me.txtExistenciasAlta.Name = "txtExistenciasAlta"
        Me.txtExistenciasAlta.Size = New System.Drawing.Size(100, 20)
        Me.txtExistenciasAlta.TabIndex = 8
        '
        'txtPrecioAlta
        '
        Me.txtPrecioAlta.Location = New System.Drawing.Point(130, 177)
        Me.txtPrecioAlta.Name = "txtPrecioAlta"
        Me.txtPrecioAlta.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioAlta.TabIndex = 9
        '
        'txtRebajaAlta
        '
        Me.txtRebajaAlta.Location = New System.Drawing.Point(329, 174)
        Me.txtRebajaAlta.Name = "txtRebajaAlta"
        Me.txtRebajaAlta.Size = New System.Drawing.Size(100, 20)
        Me.txtRebajaAlta.TabIndex = 10
        '
        'comboBoxCategoriaAlta
        '
        Me.comboBoxCategoriaAlta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxCategoriaAlta.FormattingEnabled = True
        Me.comboBoxCategoriaAlta.Items.AddRange(New Object() {"Informática", "       Imagen", "     Telefonía", "        Sonido"})
        Me.comboBoxCategoriaAlta.Location = New System.Drawing.Point(130, 212)
        Me.comboBoxCategoriaAlta.Name = "comboBoxCategoriaAlta"
        Me.comboBoxCategoriaAlta.Size = New System.Drawing.Size(121, 21)
        Me.comboBoxCategoriaAlta.TabIndex = 11
        '
        'gbArticuloAlta
        '
        Me.gbArticuloAlta.Controls.Add(Me.rbArticuloRebajadoAlta)
        Me.gbArticuloAlta.Controls.Add(Me.rbArticuloAlta)
        Me.gbArticuloAlta.Location = New System.Drawing.Point(21, 258)
        Me.gbArticuloAlta.Name = "gbArticuloAlta"
        Me.gbArticuloAlta.Size = New System.Drawing.Size(261, 54)
        Me.gbArticuloAlta.TabIndex = 12
        Me.gbArticuloAlta.TabStop = False
        Me.gbArticuloAlta.Text = "Tipo de Artículo"
        '
        'rbArticuloRebajadoAlta
        '
        Me.rbArticuloRebajadoAlta.AutoSize = True
        Me.rbArticuloRebajadoAlta.Location = New System.Drawing.Point(144, 19)
        Me.rbArticuloRebajadoAlta.Name = "rbArticuloRebajadoAlta"
        Me.rbArticuloRebajadoAlta.Size = New System.Drawing.Size(111, 17)
        Me.rbArticuloRebajadoAlta.TabIndex = 14
        Me.rbArticuloRebajadoAlta.Text = "Artículo Rebajado"
        Me.rbArticuloRebajadoAlta.UseVisualStyleBackColor = True
        '
        'rbArticuloAlta
        '
        Me.rbArticuloAlta.AutoSize = True
        Me.rbArticuloAlta.Checked = True
        Me.rbArticuloAlta.Location = New System.Drawing.Point(30, 19)
        Me.rbArticuloAlta.Name = "rbArticuloAlta"
        Me.rbArticuloAlta.Size = New System.Drawing.Size(62, 17)
        Me.rbArticuloAlta.TabIndex = 13
        Me.rbArticuloAlta.TabStop = True
        Me.rbArticuloAlta.Text = "Artículo"
        Me.rbArticuloAlta.UseVisualStyleBackColor = True
        '
        'btnCancelarAlta
        '
        Me.btnCancelarAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarAlta.Location = New System.Drawing.Point(232, 335)
        Me.btnCancelarAlta.Name = "btnCancelarAlta"
        Me.btnCancelarAlta.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarAlta.TabIndex = 13
        Me.btnCancelarAlta.Text = "Cancelar"
        Me.btnCancelarAlta.UseVisualStyleBackColor = True
        '
        'btnAceptarAlta
        '
        Me.btnAceptarAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarAlta.Location = New System.Drawing.Point(329, 335)
        Me.btnAceptarAlta.Name = "btnAceptarAlta"
        Me.btnAceptarAlta.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptarAlta.TabIndex = 14
        Me.btnAceptarAlta.Text = "Aceptar"
        Me.btnAceptarAlta.UseVisualStyleBackColor = True
        '
        'AltaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 379)
        Me.Controls.Add(Me.btnAceptarAlta)
        Me.Controls.Add(Me.btnCancelarAlta)
        Me.Controls.Add(Me.gbArticuloAlta)
        Me.Controls.Add(Me.comboBoxCategoriaAlta)
        Me.Controls.Add(Me.txtRebajaAlta)
        Me.Controls.Add(Me.txtPrecioAlta)
        Me.Controls.Add(Me.txtExistenciasAlta)
        Me.Controls.Add(Me.txtNombreAlta)
        Me.Controls.Add(Me.txtCodigoAlta)
        Me.Controls.Add(Me.lblRebajaAlta)
        Me.Controls.Add(Me.lblCategoriaAlta)
        Me.Controls.Add(Me.lblPrecioAlta)
        Me.Controls.Add(Me.lblExistenciasAlta)
        Me.Controls.Add(Me.lblNombreAlta)
        Me.Controls.Add(Me.lblCodigoAlta)
        Me.Name = "AltaForm"
        Me.Text = "Alta"
        Me.gbArticuloAlta.ResumeLayout(False)
        Me.gbArticuloAlta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCodigoAlta As Label
    Friend WithEvents lblNombreAlta As Label
    Friend WithEvents lblExistenciasAlta As Label
    Friend WithEvents lblPrecioAlta As Label
    Friend WithEvents lblCategoriaAlta As Label
    Friend WithEvents lblRebajaAlta As Label
    Friend WithEvents txtCodigoAlta As TextBox
    Friend WithEvents txtNombreAlta As TextBox
    Friend WithEvents txtExistenciasAlta As TextBox
    Friend WithEvents txtPrecioAlta As TextBox
    Friend WithEvents txtRebajaAlta As TextBox
    Friend WithEvents comboBoxCategoriaAlta As ComboBox
    Friend WithEvents gbArticuloAlta As GroupBox
    Friend WithEvents rbArticuloRebajadoAlta As RadioButton
    Friend WithEvents rbArticuloAlta As RadioButton
    Friend WithEvents btnCancelarAlta As Button
    Friend WithEvents btnAceptarAlta As Button
End Class
