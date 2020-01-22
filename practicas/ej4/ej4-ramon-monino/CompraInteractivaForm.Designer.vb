<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompraInteractivaForm
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbEquipoNecesario = New System.Windows.Forms.GroupBox()
        Me.rbPortatil = New System.Windows.Forms.RadioButton()
        Me.rbMacintosh = New System.Windows.Forms.RadioButton()
        Me.rbPC = New System.Windows.Forms.RadioButton()
        Me.gbEquipoOficina = New System.Windows.Forms.GroupBox()
        Me.cbCalculadora = New System.Windows.Forms.CheckBox()
        Me.cbFotocopiadora = New System.Windows.Forms.CheckBox()
        Me.cbContestador = New System.Windows.Forms.CheckBox()
        Me.lbPerifericos = New System.Windows.Forms.ListBox()
        Me.lblPerifericos = New System.Windows.Forms.Label()
        Me.comboBoxCurrency = New System.Windows.Forms.ComboBox()
        Me.lblProductosPedidos = New System.Windows.Forms.Label()
        Me.btnPresupuesto = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.pbEquipo = New System.Windows.Forms.PictureBox()
        Me.pbContestador = New System.Windows.Forms.PictureBox()
        Me.pbPerifericos = New System.Windows.Forms.PictureBox()
        Me.pbCalculadora = New System.Windows.Forms.PictureBox()
        Me.pbCurrency = New System.Windows.Forms.PictureBox()
        Me.pbFotocopiadora = New System.Windows.Forms.PictureBox()
        Me.gbEquipoNecesario.SuspendLayout()
        Me.gbEquipoOficina.SuspendLayout()
        CType(Me.pbEquipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbContestador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPerifericos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCalculadora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFotocopiadora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(27, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(194, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Compra Interactiva"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(306, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Actualice su oficina comprando los productos que necesite con" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "casillas de verifi" &
    "cación, botones de opción y cuadros de lista."
        '
        'gbEquipoNecesario
        '
        Me.gbEquipoNecesario.Controls.Add(Me.rbPortatil)
        Me.gbEquipoNecesario.Controls.Add(Me.rbMacintosh)
        Me.gbEquipoNecesario.Controls.Add(Me.rbPC)
        Me.gbEquipoNecesario.Location = New System.Drawing.Point(51, 119)
        Me.gbEquipoNecesario.Name = "gbEquipoNecesario"
        Me.gbEquipoNecesario.Size = New System.Drawing.Size(200, 100)
        Me.gbEquipoNecesario.TabIndex = 2
        Me.gbEquipoNecesario.TabStop = False
        Me.gbEquipoNecesario.Text = "Equipo (Necesario)"
        '
        'rbPortatil
        '
        Me.rbPortatil.AutoSize = True
        Me.rbPortatil.Location = New System.Drawing.Point(11, 66)
        Me.rbPortatil.Name = "rbPortatil"
        Me.rbPortatil.Size = New System.Drawing.Size(90, 17)
        Me.rbPortatil.TabIndex = 2
        Me.rbPortatil.TabStop = True
        Me.rbPortatil.Text = "Portátil (500€)"
        Me.rbPortatil.UseVisualStyleBackColor = True
        '
        'rbMacintosh
        '
        Me.rbMacintosh.AutoSize = True
        Me.rbMacintosh.Location = New System.Drawing.Point(11, 43)
        Me.rbMacintosh.Name = "rbMacintosh"
        Me.rbMacintosh.Size = New System.Drawing.Size(113, 17)
        Me.rbMacintosh.TabIndex = 1
        Me.rbMacintosh.TabStop = True
        Me.rbMacintosh.Text = "Macintosh (1000€)"
        Me.rbMacintosh.UseVisualStyleBackColor = True
        '
        'rbPC
        '
        Me.rbPC.AutoSize = True
        Me.rbPC.Location = New System.Drawing.Point(11, 20)
        Me.rbPC.Name = "rbPC"
        Me.rbPC.Size = New System.Drawing.Size(72, 17)
        Me.rbPC.TabIndex = 0
        Me.rbPC.TabStop = True
        Me.rbPC.Text = "PC (700€)"
        Me.rbPC.UseVisualStyleBackColor = True
        '
        'gbEquipoOficina
        '
        Me.gbEquipoOficina.Controls.Add(Me.cbCalculadora)
        Me.gbEquipoOficina.Controls.Add(Me.cbFotocopiadora)
        Me.gbEquipoOficina.Controls.Add(Me.cbContestador)
        Me.gbEquipoOficina.Location = New System.Drawing.Point(51, 265)
        Me.gbEquipoOficina.Name = "gbEquipoOficina"
        Me.gbEquipoOficina.Size = New System.Drawing.Size(200, 100)
        Me.gbEquipoOficina.TabIndex = 3
        Me.gbEquipoOficina.TabStop = False
        Me.gbEquipoOficina.Text = "Equipos de oficina (0-3)"
        '
        'cbCalculadora
        '
        Me.cbCalculadora.AutoSize = True
        Me.cbCalculadora.Location = New System.Drawing.Point(12, 44)
        Me.cbCalculadora.Name = "cbCalculadora"
        Me.cbCalculadora.Size = New System.Drawing.Size(109, 17)
        Me.cbCalculadora.TabIndex = 5
        Me.cbCalculadora.Text = "Calculadora (20€)"
        Me.cbCalculadora.UseVisualStyleBackColor = True
        '
        'cbFotocopiadora
        '
        Me.cbFotocopiadora.AutoSize = True
        Me.cbFotocopiadora.Location = New System.Drawing.Point(11, 67)
        Me.cbFotocopiadora.Name = "cbFotocopiadora"
        Me.cbFotocopiadora.Size = New System.Drawing.Size(127, 17)
        Me.cbFotocopiadora.TabIndex = 6
        Me.cbFotocopiadora.Text = "Fotocopiadora (100€)"
        Me.cbFotocopiadora.UseVisualStyleBackColor = True
        '
        'cbContestador
        '
        Me.cbContestador.AutoSize = True
        Me.cbContestador.Location = New System.Drawing.Point(12, 19)
        Me.cbContestador.Name = "cbContestador"
        Me.cbContestador.Size = New System.Drawing.Size(110, 17)
        Me.cbContestador.TabIndex = 4
        Me.cbContestador.Text = "Contestador (50€)"
        Me.cbContestador.UseVisualStyleBackColor = True
        '
        'lbPerifericos
        '
        Me.lbPerifericos.FormattingEnabled = True
        Me.lbPerifericos.Items.AddRange(New Object() {"Disco duro adicional (75€)", "Impresora (90€)", "Antena (50€)"})
        Me.lbPerifericos.Location = New System.Drawing.Point(325, 124)
        Me.lbPerifericos.Name = "lbPerifericos"
        Me.lbPerifericos.Size = New System.Drawing.Size(120, 95)
        Me.lbPerifericos.TabIndex = 4
        '
        'lblPerifericos
        '
        Me.lblPerifericos.AutoSize = True
        Me.lblPerifericos.Location = New System.Drawing.Point(331, 108)
        Me.lblPerifericos.Name = "lblPerifericos"
        Me.lblPerifericos.Size = New System.Drawing.Size(105, 13)
        Me.lblPerifericos.TabIndex = 5
        Me.lblPerifericos.Text = "Periféricos (sólo uno)"
        '
        'comboBoxCurrency
        '
        Me.comboBoxCurrency.FormattingEnabled = True
        Me.comboBoxCurrency.Items.AddRange(New Object() {"Dólares EEUU", "Cheque", "Bolsa"})
        Me.comboBoxCurrency.Location = New System.Drawing.Point(324, 280)
        Me.comboBoxCurrency.Name = "comboBoxCurrency"
        Me.comboBoxCurrency.Size = New System.Drawing.Size(121, 21)
        Me.comboBoxCurrency.TabIndex = 6
        '
        'lblProductosPedidos
        '
        Me.lblProductosPedidos.AutoSize = True
        Me.lblProductosPedidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductosPedidos.Location = New System.Drawing.Point(572, 20)
        Me.lblProductosPedidos.Name = "lblProductosPedidos"
        Me.lblProductosPedidos.Size = New System.Drawing.Size(193, 25)
        Me.lblProductosPedidos.TabIndex = 7
        Me.lblProductosPedidos.Text = "Productos Pedidos"
        '
        'btnPresupuesto
        '
        Me.btnPresupuesto.Location = New System.Drawing.Point(345, 332)
        Me.btnPresupuesto.Name = "btnPresupuesto"
        Me.btnPresupuesto.Size = New System.Drawing.Size(75, 23)
        Me.btnPresupuesto.TabIndex = 8
        Me.btnPresupuesto.Text = "Presupuesto"
        Me.btnPresupuesto.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(345, 381)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'pbEquipo
        '
        Me.pbEquipo.Location = New System.Drawing.Point(546, 66)
        Me.pbEquipo.Name = "pbEquipo"
        Me.pbEquipo.Size = New System.Drawing.Size(100, 100)
        Me.pbEquipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbEquipo.TabIndex = 10
        Me.pbEquipo.TabStop = False
        '
        'pbContestador
        '
        Me.pbContestador.Image = Global.ej4_ramon_monino.My.Resources.Resources.AnswMach
        Me.pbContestador.Location = New System.Drawing.Point(665, 66)
        Me.pbContestador.Name = "pbContestador"
        Me.pbContestador.Size = New System.Drawing.Size(100, 100)
        Me.pbContestador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbContestador.TabIndex = 11
        Me.pbContestador.TabStop = False
        Me.pbContestador.Visible = False
        '
        'pbPerifericos
        '
        Me.pbPerifericos.Location = New System.Drawing.Point(546, 185)
        Me.pbPerifericos.Name = "pbPerifericos"
        Me.pbPerifericos.Size = New System.Drawing.Size(100, 100)
        Me.pbPerifericos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPerifericos.TabIndex = 12
        Me.pbPerifericos.TabStop = False
        '
        'pbCalculadora
        '
        Me.pbCalculadora.Image = Global.ej4_ramon_monino.My.Resources.Resources.Calcultr
        Me.pbCalculadora.Location = New System.Drawing.Point(665, 185)
        Me.pbCalculadora.Name = "pbCalculadora"
        Me.pbCalculadora.Size = New System.Drawing.Size(100, 100)
        Me.pbCalculadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCalculadora.TabIndex = 13
        Me.pbCalculadora.TabStop = False
        Me.pbCalculadora.Visible = False
        '
        'pbCurrency
        '
        Me.pbCurrency.Location = New System.Drawing.Point(546, 313)
        Me.pbCurrency.Name = "pbCurrency"
        Me.pbCurrency.Size = New System.Drawing.Size(100, 100)
        Me.pbCurrency.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCurrency.TabIndex = 14
        Me.pbCurrency.TabStop = False
        '
        'pbFotocopiadora
        '
        Me.pbFotocopiadora.Image = Global.ej4_ramon_monino.My.Resources.Resources.CopyMach
        Me.pbFotocopiadora.Location = New System.Drawing.Point(665, 313)
        Me.pbFotocopiadora.Name = "pbFotocopiadora"
        Me.pbFotocopiadora.Size = New System.Drawing.Size(100, 100)
        Me.pbFotocopiadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFotocopiadora.TabIndex = 15
        Me.pbFotocopiadora.TabStop = False
        Me.pbFotocopiadora.Visible = False
        '
        'CompraInteractivaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pbFotocopiadora)
        Me.Controls.Add(Me.pbCurrency)
        Me.Controls.Add(Me.pbCalculadora)
        Me.Controls.Add(Me.pbPerifericos)
        Me.Controls.Add(Me.pbContestador)
        Me.Controls.Add(Me.pbEquipo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnPresupuesto)
        Me.Controls.Add(Me.lblProductosPedidos)
        Me.Controls.Add(Me.comboBoxCurrency)
        Me.Controls.Add(Me.lblPerifericos)
        Me.Controls.Add(Me.lbPerifericos)
        Me.Controls.Add(Me.gbEquipoOficina)
        Me.Controls.Add(Me.gbEquipoNecesario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "CompraInteractivaForm"
        Me.Text = "Tienda Electronica"
        Me.gbEquipoNecesario.ResumeLayout(False)
        Me.gbEquipoNecesario.PerformLayout()
        Me.gbEquipoOficina.ResumeLayout(False)
        Me.gbEquipoOficina.PerformLayout()
        CType(Me.pbEquipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbContestador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPerifericos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCalculadora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFotocopiadora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents gbEquipoNecesario As GroupBox
    Friend WithEvents rbPortatil As RadioButton
    Friend WithEvents rbMacintosh As RadioButton
    Friend WithEvents rbPC As RadioButton
    Friend WithEvents gbEquipoOficina As GroupBox
    Friend WithEvents cbCalculadora As CheckBox
    Friend WithEvents cbFotocopiadora As CheckBox
    Friend WithEvents cbContestador As CheckBox
    Friend WithEvents lbPerifericos As ListBox
    Friend WithEvents lblPerifericos As Label
    Friend WithEvents comboBoxCurrency As ComboBox
    Friend WithEvents lblProductosPedidos As Label
    Friend WithEvents btnPresupuesto As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents pbEquipo As PictureBox
    Friend WithEvents pbContestador As PictureBox
    Friend WithEvents pbPerifericos As PictureBox
    Friend WithEvents pbCalculadora As PictureBox
    Friend WithEvents pbCurrency As PictureBox
    Friend WithEvents pbFotocopiadora As PictureBox
End Class
