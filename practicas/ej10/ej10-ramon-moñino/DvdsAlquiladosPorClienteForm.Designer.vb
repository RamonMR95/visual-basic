<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DvdsAlquiladosPorClienteForm
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
        Me.rtbAlquiladoPorCliente = New System.Windows.Forms.RichTextBox()
        Me.lblListadoClienteCod = New System.Windows.Forms.Label()
        Me.txtListadoClienteCod = New System.Windows.Forms.TextBox()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnListadoSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rtbAlquiladoPorCliente
        '
        Me.rtbAlquiladoPorCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbAlquiladoPorCliente.Location = New System.Drawing.Point(200, 55)
        Me.rtbAlquiladoPorCliente.Name = "rtbAlquiladoPorCliente"
        Me.rtbAlquiladoPorCliente.ReadOnly = True
        Me.rtbAlquiladoPorCliente.Size = New System.Drawing.Size(321, 249)
        Me.rtbAlquiladoPorCliente.TabIndex = 0
        Me.rtbAlquiladoPorCliente.Text = ""
        '
        'lblListadoClienteCod
        '
        Me.lblListadoClienteCod.AutoSize = True
        Me.lblListadoClienteCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListadoClienteCod.Location = New System.Drawing.Point(21, 26)
        Me.lblListadoClienteCod.Name = "lblListadoClienteCod"
        Me.lblListadoClienteCod.Size = New System.Drawing.Size(88, 13)
        Me.lblListadoClienteCod.TabIndex = 1
        Me.lblListadoClienteCod.Text = "Código cliente"
        '
        'txtListadoClienteCod
        '
        Me.txtListadoClienteCod.Location = New System.Drawing.Point(24, 55)
        Me.txtListadoClienteCod.Name = "txtListadoClienteCod"
        Me.txtListadoClienteCod.Size = New System.Drawing.Size(100, 20)
        Me.txtListadoClienteCod.TabIndex = 2
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(34, 96)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(75, 23)
        Me.btnListar.TabIndex = 3
        Me.btnListar.Text = "Buscar"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'btnListadoSalir
        '
        Me.btnListadoSalir.Location = New System.Drawing.Point(446, 321)
        Me.btnListadoSalir.Name = "btnListadoSalir"
        Me.btnListadoSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnListadoSalir.TabIndex = 4
        Me.btnListadoSalir.Text = "Salir"
        Me.btnListadoSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(197, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(203, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Títulos de DVDs"
        '
        'DvdsAlquiladosPorClienteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 356)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnListadoSalir)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.txtListadoClienteCod)
        Me.Controls.Add(Me.lblListadoClienteCod)
        Me.Controls.Add(Me.rtbAlquiladoPorCliente)
        Me.Name = "DvdsAlquiladosPorClienteForm"
        Me.Text = "DVDs alquilados por Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rtbAlquiladoPorCliente As RichTextBox
    Friend WithEvents lblListadoClienteCod As Label
    Friend WithEvents txtListadoClienteCod As TextBox
    Friend WithEvents btnListar As Button
    Friend WithEvents btnListadoSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
