<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlquilarForm
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
        Me.txtAlquilarCodigoCliente = New System.Windows.Forms.TextBox()
        Me.txtAlquilarCodigoDVD = New System.Windows.Forms.TextBox()
        Me.lblAlquilarCodCliente = New System.Windows.Forms.Label()
        Me.lblAlquilarCodigoDVD = New System.Windows.Forms.Label()
        Me.btnAlquilarAceptar = New System.Windows.Forms.Button()
        Me.txtAlquilerFecha = New System.Windows.Forms.TextBox()
        Me.lblAlquilarFecha = New System.Windows.Forms.Label()
        Me.btnAlquilarSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAlquilarCodigoCliente
        '
        Me.txtAlquilarCodigoCliente.Location = New System.Drawing.Point(109, 76)
        Me.txtAlquilarCodigoCliente.Name = "txtAlquilarCodigoCliente"
        Me.txtAlquilarCodigoCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtAlquilarCodigoCliente.TabIndex = 41
        '
        'txtAlquilarCodigoDVD
        '
        Me.txtAlquilarCodigoDVD.Location = New System.Drawing.Point(109, 40)
        Me.txtAlquilarCodigoDVD.Name = "txtAlquilarCodigoDVD"
        Me.txtAlquilarCodigoDVD.Size = New System.Drawing.Size(100, 20)
        Me.txtAlquilarCodigoDVD.TabIndex = 40
        '
        'lblAlquilarCodCliente
        '
        Me.lblAlquilarCodCliente.AutoSize = True
        Me.lblAlquilarCodCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlquilarCodCliente.Location = New System.Drawing.Point(12, 79)
        Me.lblAlquilarCodCliente.Name = "lblAlquilarCodCliente"
        Me.lblAlquilarCodCliente.Size = New System.Drawing.Size(89, 13)
        Me.lblAlquilarCodCliente.TabIndex = 39
        Me.lblAlquilarCodCliente.Text = "Código Cliente"
        '
        'lblAlquilarCodigoDVD
        '
        Me.lblAlquilarCodigoDVD.AutoSize = True
        Me.lblAlquilarCodigoDVD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlquilarCodigoDVD.Location = New System.Drawing.Point(12, 43)
        Me.lblAlquilarCodigoDVD.Name = "lblAlquilarCodigoDVD"
        Me.lblAlquilarCodigoDVD.Size = New System.Drawing.Size(76, 13)
        Me.lblAlquilarCodigoDVD.TabIndex = 38
        Me.lblAlquilarCodigoDVD.Text = "Código DVD"
        '
        'btnAlquilarAceptar
        '
        Me.btnAlquilarAceptar.Location = New System.Drawing.Point(15, 165)
        Me.btnAlquilarAceptar.Name = "btnAlquilarAceptar"
        Me.btnAlquilarAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAlquilarAceptar.TabIndex = 42
        Me.btnAlquilarAceptar.Text = "Aceptar"
        Me.btnAlquilarAceptar.UseVisualStyleBackColor = True
        '
        'txtAlquilerFecha
        '
        Me.txtAlquilerFecha.Location = New System.Drawing.Point(109, 116)
        Me.txtAlquilerFecha.Name = "txtAlquilerFecha"
        Me.txtAlquilerFecha.ReadOnly = True
        Me.txtAlquilerFecha.Size = New System.Drawing.Size(64, 20)
        Me.txtAlquilerFecha.TabIndex = 44
        '
        'lblAlquilarFecha
        '
        Me.lblAlquilarFecha.AutoSize = True
        Me.lblAlquilarFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlquilarFecha.Location = New System.Drawing.Point(40, 119)
        Me.lblAlquilarFecha.Name = "lblAlquilarFecha"
        Me.lblAlquilarFecha.Size = New System.Drawing.Size(42, 13)
        Me.lblAlquilarFecha.TabIndex = 43
        Me.lblAlquilarFecha.Text = "Fecha"
        '
        'btnAlquilarSalir
        '
        Me.btnAlquilarSalir.Location = New System.Drawing.Point(156, 179)
        Me.btnAlquilarSalir.Name = "btnAlquilarSalir"
        Me.btnAlquilarSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnAlquilarSalir.TabIndex = 45
        Me.btnAlquilarSalir.Text = "Salir"
        Me.btnAlquilarSalir.UseVisualStyleBackColor = True
        '
        'AlquilarForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 214)
        Me.Controls.Add(Me.btnAlquilarSalir)
        Me.Controls.Add(Me.txtAlquilerFecha)
        Me.Controls.Add(Me.lblAlquilarFecha)
        Me.Controls.Add(Me.btnAlquilarAceptar)
        Me.Controls.Add(Me.txtAlquilarCodigoCliente)
        Me.Controls.Add(Me.txtAlquilarCodigoDVD)
        Me.Controls.Add(Me.lblAlquilarCodCliente)
        Me.Controls.Add(Me.lblAlquilarCodigoDVD)
        Me.Name = "AlquilarForm"
        Me.Text = "Alquiler DVD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAlquilarCodigoCliente As TextBox
    Friend WithEvents txtAlquilarCodigoDVD As TextBox
    Friend WithEvents lblAlquilarCodCliente As Label
    Friend WithEvents lblAlquilarCodigoDVD As Label
    Friend WithEvents btnAlquilarAceptar As Button
    Friend WithEvents txtAlquilerFecha As TextBox
    Friend WithEvents lblAlquilarFecha As Label
    Friend WithEvents btnAlquilarSalir As Button
End Class
