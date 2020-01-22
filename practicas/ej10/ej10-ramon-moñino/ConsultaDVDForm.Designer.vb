<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaDVDForm
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
        Me.gbCriterioConsulta = New System.Windows.Forms.GroupBox()
        Me.rbTitulo = New System.Windows.Forms.RadioButton()
        Me.rbCodigo = New System.Windows.Forms.RadioButton()
        Me.txtTit2 = New System.Windows.Forms.TextBox()
        Me.txtCod2 = New System.Windows.Forms.TextBox()
        Me.lbltit2 = New System.Windows.Forms.Label()
        Me.lblCod2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtConsultaDVDAlquilado = New System.Windows.Forms.TextBox()
        Me.lblConsultaDVDAlquilado = New System.Windows.Forms.Label()
        Me.txtConsultaDVDDias = New System.Windows.Forms.TextBox()
        Me.txtConsultaDVDTitulo = New System.Windows.Forms.TextBox()
        Me.txtConsultaClienteCod = New System.Windows.Forms.TextBox()
        Me.lblConsultaDVDDias = New System.Windows.Forms.Label()
        Me.lblConsultaDVDTitulo = New System.Windows.Forms.Label()
        Me.lblConsultaDVDCod = New System.Windows.Forms.Label()
        Me.btnConsultaBuscar = New System.Windows.Forms.Button()
        Me.btnConsultaSalir = New System.Windows.Forms.Button()
        Me.gbCriterioConsulta.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCriterioConsulta
        '
        Me.gbCriterioConsulta.Controls.Add(Me.rbTitulo)
        Me.gbCriterioConsulta.Controls.Add(Me.rbCodigo)
        Me.gbCriterioConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCriterioConsulta.Location = New System.Drawing.Point(12, 44)
        Me.gbCriterioConsulta.Name = "gbCriterioConsulta"
        Me.gbCriterioConsulta.Size = New System.Drawing.Size(157, 78)
        Me.gbCriterioConsulta.TabIndex = 14
        Me.gbCriterioConsulta.TabStop = False
        Me.gbCriterioConsulta.Text = "Criterio de consulta"
        '
        'rbTitulo
        '
        Me.rbTitulo.AutoSize = True
        Me.rbTitulo.Location = New System.Drawing.Point(6, 46)
        Me.rbTitulo.Name = "rbTitulo"
        Me.rbTitulo.Size = New System.Drawing.Size(59, 17)
        Me.rbTitulo.TabIndex = 1
        Me.rbTitulo.TabStop = True
        Me.rbTitulo.Text = "Título"
        Me.rbTitulo.UseVisualStyleBackColor = True
        '
        'rbCodigo
        '
        Me.rbCodigo.AutoSize = True
        Me.rbCodigo.Location = New System.Drawing.Point(6, 23)
        Me.rbCodigo.Name = "rbCodigo"
        Me.rbCodigo.Size = New System.Drawing.Size(64, 17)
        Me.rbCodigo.TabIndex = 0
        Me.rbCodigo.TabStop = True
        Me.rbCodigo.Text = "Código"
        Me.rbCodigo.UseVisualStyleBackColor = True
        '
        'txtTit2
        '
        Me.txtTit2.Location = New System.Drawing.Point(80, 155)
        Me.txtTit2.Name = "txtTit2"
        Me.txtTit2.Size = New System.Drawing.Size(100, 20)
        Me.txtTit2.TabIndex = 18
        Me.txtTit2.Visible = False
        '
        'txtCod2
        '
        Me.txtCod2.Location = New System.Drawing.Point(80, 155)
        Me.txtCod2.Name = "txtCod2"
        Me.txtCod2.Size = New System.Drawing.Size(100, 20)
        Me.txtCod2.TabIndex = 17
        '
        'lbltit2
        '
        Me.lbltit2.AutoSize = True
        Me.lbltit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltit2.Location = New System.Drawing.Point(15, 158)
        Me.lbltit2.Name = "lbltit2"
        Me.lbltit2.Size = New System.Drawing.Size(41, 13)
        Me.lbltit2.TabIndex = 16
        Me.lbltit2.Text = "Título"
        Me.lbltit2.Visible = False
        '
        'lblCod2
        '
        Me.lblCod2.AutoSize = True
        Me.lblCod2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCod2.Location = New System.Drawing.Point(9, 158)
        Me.lblCod2.Name = "lblCod2"
        Me.lblCod2.Size = New System.Drawing.Size(46, 13)
        Me.lblCod2.TabIndex = 15
        Me.lblCod2.Text = "Código"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtConsultaDVDAlquilado)
        Me.GroupBox1.Controls.Add(Me.lblConsultaDVDAlquilado)
        Me.GroupBox1.Controls.Add(Me.txtConsultaDVDDias)
        Me.GroupBox1.Controls.Add(Me.txtConsultaDVDTitulo)
        Me.GroupBox1.Controls.Add(Me.txtConsultaClienteCod)
        Me.GroupBox1.Controls.Add(Me.lblConsultaDVDDias)
        Me.GroupBox1.Controls.Add(Me.lblConsultaDVDTitulo)
        Me.GroupBox1.Controls.Add(Me.lblConsultaDVDCod)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(267, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 192)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DVD"
        '
        'txtConsultaDVDAlquilado
        '
        Me.txtConsultaDVDAlquilado.Location = New System.Drawing.Point(127, 142)
        Me.txtConsultaDVDAlquilado.Name = "txtConsultaDVDAlquilado"
        Me.txtConsultaDVDAlquilado.ReadOnly = True
        Me.txtConsultaDVDAlquilado.Size = New System.Drawing.Size(100, 20)
        Me.txtConsultaDVDAlquilado.TabIndex = 21
        '
        'lblConsultaDVDAlquilado
        '
        Me.lblConsultaDVDAlquilado.AutoSize = True
        Me.lblConsultaDVDAlquilado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultaDVDAlquilado.Location = New System.Drawing.Point(30, 145)
        Me.lblConsultaDVDAlquilado.Name = "lblConsultaDVDAlquilado"
        Me.lblConsultaDVDAlquilado.Size = New System.Drawing.Size(59, 13)
        Me.lblConsultaDVDAlquilado.TabIndex = 20
        Me.lblConsultaDVDAlquilado.Text = "Alquilado"
        '
        'txtConsultaDVDDias
        '
        Me.txtConsultaDVDDias.Location = New System.Drawing.Point(127, 104)
        Me.txtConsultaDVDDias.Name = "txtConsultaDVDDias"
        Me.txtConsultaDVDDias.ReadOnly = True
        Me.txtConsultaDVDDias.Size = New System.Drawing.Size(100, 20)
        Me.txtConsultaDVDDias.TabIndex = 19
        '
        'txtConsultaDVDTitulo
        '
        Me.txtConsultaDVDTitulo.Location = New System.Drawing.Point(127, 68)
        Me.txtConsultaDVDTitulo.Name = "txtConsultaDVDTitulo"
        Me.txtConsultaDVDTitulo.ReadOnly = True
        Me.txtConsultaDVDTitulo.Size = New System.Drawing.Size(100, 20)
        Me.txtConsultaDVDTitulo.TabIndex = 18
        '
        'txtConsultaClienteCod
        '
        Me.txtConsultaClienteCod.Location = New System.Drawing.Point(127, 31)
        Me.txtConsultaClienteCod.Name = "txtConsultaClienteCod"
        Me.txtConsultaClienteCod.ReadOnly = True
        Me.txtConsultaClienteCod.Size = New System.Drawing.Size(100, 20)
        Me.txtConsultaClienteCod.TabIndex = 17
        '
        'lblConsultaDVDDias
        '
        Me.lblConsultaDVDDias.AutoSize = True
        Me.lblConsultaDVDDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultaDVDDias.Location = New System.Drawing.Point(30, 107)
        Me.lblConsultaDVDDias.Name = "lblConsultaDVDDias"
        Me.lblConsultaDVDDias.Size = New System.Drawing.Size(77, 13)
        Me.lblConsultaDVDDias.TabIndex = 16
        Me.lblConsultaDVDDias.Text = "Dias alquiler"
        '
        'lblConsultaDVDTitulo
        '
        Me.lblConsultaDVDTitulo.AutoSize = True
        Me.lblConsultaDVDTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultaDVDTitulo.Location = New System.Drawing.Point(30, 71)
        Me.lblConsultaDVDTitulo.Name = "lblConsultaDVDTitulo"
        Me.lblConsultaDVDTitulo.Size = New System.Drawing.Size(41, 13)
        Me.lblConsultaDVDTitulo.TabIndex = 15
        Me.lblConsultaDVDTitulo.Text = "Título"
        '
        'lblConsultaDVDCod
        '
        Me.lblConsultaDVDCod.AutoSize = True
        Me.lblConsultaDVDCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultaDVDCod.Location = New System.Drawing.Point(30, 34)
        Me.lblConsultaDVDCod.Name = "lblConsultaDVDCod"
        Me.lblConsultaDVDCod.Size = New System.Drawing.Size(46, 13)
        Me.lblConsultaDVDCod.TabIndex = 14
        Me.lblConsultaDVDCod.Text = "Código"
        '
        'btnConsultaBuscar
        '
        Me.btnConsultaBuscar.Location = New System.Drawing.Point(94, 211)
        Me.btnConsultaBuscar.Name = "btnConsultaBuscar"
        Me.btnConsultaBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultaBuscar.TabIndex = 20
        Me.btnConsultaBuscar.Text = "Buscar"
        Me.btnConsultaBuscar.UseVisualStyleBackColor = True
        '
        'btnConsultaSalir
        '
        Me.btnConsultaSalir.Location = New System.Drawing.Point(448, 247)
        Me.btnConsultaSalir.Name = "btnConsultaSalir"
        Me.btnConsultaSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultaSalir.TabIndex = 21
        Me.btnConsultaSalir.Text = "Salir"
        Me.btnConsultaSalir.UseVisualStyleBackColor = True
        '
        'ConsultaDVDForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 282)
        Me.Controls.Add(Me.btnConsultaSalir)
        Me.Controls.Add(Me.btnConsultaBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtTit2)
        Me.Controls.Add(Me.txtCod2)
        Me.Controls.Add(Me.lbltit2)
        Me.Controls.Add(Me.lblCod2)
        Me.Controls.Add(Me.gbCriterioConsulta)
        Me.Name = "ConsultaDVDForm"
        Me.Text = "Consulta DVDs"
        Me.gbCriterioConsulta.ResumeLayout(False)
        Me.gbCriterioConsulta.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbCriterioConsulta As GroupBox
    Friend WithEvents rbTitulo As RadioButton
    Friend WithEvents rbCodigo As RadioButton
    Friend WithEvents txtTit2 As TextBox
    Friend WithEvents txtCod2 As TextBox
    Friend WithEvents lbltit2 As Label
    Friend WithEvents lblCod2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtConsultaDVDAlquilado As TextBox
    Friend WithEvents lblConsultaDVDAlquilado As Label
    Friend WithEvents txtConsultaDVDDias As TextBox
    Friend WithEvents txtConsultaDVDTitulo As TextBox
    Friend WithEvents txtConsultaClienteCod As TextBox
    Friend WithEvents lblConsultaDVDDias As Label
    Friend WithEvents lblConsultaDVDTitulo As Label
    Friend WithEvents lblConsultaDVDCod As Label
    Friend WithEvents btnConsultaBuscar As Button
    Friend WithEvents btnConsultaSalir As Button
End Class
