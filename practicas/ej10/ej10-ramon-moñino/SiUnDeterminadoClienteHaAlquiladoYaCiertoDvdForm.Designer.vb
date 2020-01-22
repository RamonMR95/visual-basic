<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SiUnDeterminadoClienteHaAlquiladoYaCiertoDvdForm
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtCodigoDVD = New System.Windows.Forms.TextBox()
        Me.lblAlquilarCodigoDVD = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(319, 162)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 52
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtCodCliente
        '
        Me.txtCodCliente.Location = New System.Drawing.Point(140, 73)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtCodCliente.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Código Cliente"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(44, 138)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 49
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtCodigoDVD
        '
        Me.txtCodigoDVD.Location = New System.Drawing.Point(138, 24)
        Me.txtCodigoDVD.Name = "txtCodigoDVD"
        Me.txtCodigoDVD.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoDVD.TabIndex = 48
        '
        'lblAlquilarCodigoDVD
        '
        Me.lblAlquilarCodigoDVD.AutoSize = True
        Me.lblAlquilarCodigoDVD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlquilarCodigoDVD.Location = New System.Drawing.Point(41, 27)
        Me.lblAlquilarCodigoDVD.Name = "lblAlquilarCodigoDVD"
        Me.lblAlquilarCodigoDVD.Size = New System.Drawing.Size(76, 13)
        Me.lblAlquilarCodigoDVD.TabIndex = 47
        Me.lblAlquilarCodigoDVD.Text = "Código DVD"
        '
        'SiUnDeterminadoClienteHaAlquiladoYaCiertoDvdForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 203)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtCodCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtCodigoDVD)
        Me.Controls.Add(Me.lblAlquilarCodigoDVD)
        Me.Name = "SiUnDeterminadoClienteHaAlquiladoYaCiertoDvdForm"
        Me.Text = "Búsqueda historial DVD y cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents txtCodCliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtCodigoDVD As TextBox
    Friend WithEvents lblAlquilarCodigoDVD As Label
End Class
