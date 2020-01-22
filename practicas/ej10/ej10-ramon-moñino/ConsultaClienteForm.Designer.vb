<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaClienteForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConsultaClienteCodigo2 = New System.Windows.Forms.TextBox()
        Me.btnConsultaClienteBuscar = New System.Windows.Forms.Button()
        Me.btnConsultaClienteSalir = New System.Windows.Forms.Button()
        Me.gbCliente = New System.Windows.Forms.GroupBox()
        Me.txtConsultaClienteAlquileres = New System.Windows.Forms.TextBox()
        Me.lblConsultaClienteAlquileres = New System.Windows.Forms.Label()
        Me.txtConsultaClienteEmail = New System.Windows.Forms.TextBox()
        Me.lblConsultaClienteEmail = New System.Windows.Forms.Label()
        Me.txtConsultaClienteTelefono = New System.Windows.Forms.TextBox()
        Me.txtConsultaClienteDireccion = New System.Windows.Forms.TextBox()
        Me.lblConsultaClienteTelefono = New System.Windows.Forms.Label()
        Me.lblConsultaClienteDireccion = New System.Windows.Forms.Label()
        Me.gbCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'txtConsultaClienteCodigo2
        '
        Me.txtConsultaClienteCodigo2.Location = New System.Drawing.Point(84, 25)
        Me.txtConsultaClienteCodigo2.Name = "txtConsultaClienteCodigo2"
        Me.txtConsultaClienteCodigo2.Size = New System.Drawing.Size(100, 20)
        Me.txtConsultaClienteCodigo2.TabIndex = 1
        '
        'btnConsultaClienteBuscar
        '
        Me.btnConsultaClienteBuscar.Location = New System.Drawing.Point(97, 87)
        Me.btnConsultaClienteBuscar.Name = "btnConsultaClienteBuscar"
        Me.btnConsultaClienteBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultaClienteBuscar.TabIndex = 2
        Me.btnConsultaClienteBuscar.Text = "Buscar"
        Me.btnConsultaClienteBuscar.UseVisualStyleBackColor = True
        '
        'btnConsultaClienteSalir
        '
        Me.btnConsultaClienteSalir.Location = New System.Drawing.Point(372, 262)
        Me.btnConsultaClienteSalir.Name = "btnConsultaClienteSalir"
        Me.btnConsultaClienteSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultaClienteSalir.TabIndex = 3
        Me.btnConsultaClienteSalir.Text = "Salir"
        Me.btnConsultaClienteSalir.UseVisualStyleBackColor = True
        '
        'gbCliente
        '
        Me.gbCliente.Controls.Add(Me.txtConsultaClienteAlquileres)
        Me.gbCliente.Controls.Add(Me.lblConsultaClienteAlquileres)
        Me.gbCliente.Controls.Add(Me.txtConsultaClienteEmail)
        Me.gbCliente.Controls.Add(Me.lblConsultaClienteEmail)
        Me.gbCliente.Controls.Add(Me.txtConsultaClienteTelefono)
        Me.gbCliente.Controls.Add(Me.txtConsultaClienteDireccion)
        Me.gbCliente.Controls.Add(Me.lblConsultaClienteTelefono)
        Me.gbCliente.Controls.Add(Me.lblConsultaClienteDireccion)
        Me.gbCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCliente.Location = New System.Drawing.Point(215, 28)
        Me.gbCliente.Name = "gbCliente"
        Me.gbCliente.Size = New System.Drawing.Size(232, 206)
        Me.gbCliente.TabIndex = 4
        Me.gbCliente.TabStop = False
        Me.gbCliente.Text = "Cliente"
        '
        'txtConsultaClienteAlquileres
        '
        Me.txtConsultaClienteAlquileres.Location = New System.Drawing.Point(115, 140)
        Me.txtConsultaClienteAlquileres.Name = "txtConsultaClienteAlquileres"
        Me.txtConsultaClienteAlquileres.ReadOnly = True
        Me.txtConsultaClienteAlquileres.Size = New System.Drawing.Size(100, 20)
        Me.txtConsultaClienteAlquileres.TabIndex = 41
        '
        'lblConsultaClienteAlquileres
        '
        Me.lblConsultaClienteAlquileres.AutoSize = True
        Me.lblConsultaClienteAlquileres.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultaClienteAlquileres.Location = New System.Drawing.Point(18, 143)
        Me.lblConsultaClienteAlquileres.Name = "lblConsultaClienteAlquileres"
        Me.lblConsultaClienteAlquileres.Size = New System.Drawing.Size(62, 13)
        Me.lblConsultaClienteAlquileres.TabIndex = 40
        Me.lblConsultaClienteAlquileres.Text = "Alquileres"
        '
        'txtConsultaClienteEmail
        '
        Me.txtConsultaClienteEmail.Location = New System.Drawing.Point(115, 104)
        Me.txtConsultaClienteEmail.Name = "txtConsultaClienteEmail"
        Me.txtConsultaClienteEmail.ReadOnly = True
        Me.txtConsultaClienteEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtConsultaClienteEmail.TabIndex = 39
        '
        'lblConsultaClienteEmail
        '
        Me.lblConsultaClienteEmail.AutoSize = True
        Me.lblConsultaClienteEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultaClienteEmail.Location = New System.Drawing.Point(18, 107)
        Me.lblConsultaClienteEmail.Name = "lblConsultaClienteEmail"
        Me.lblConsultaClienteEmail.Size = New System.Drawing.Size(37, 13)
        Me.lblConsultaClienteEmail.TabIndex = 38
        Me.lblConsultaClienteEmail.Text = "Email"
        '
        'txtConsultaClienteTelefono
        '
        Me.txtConsultaClienteTelefono.Location = New System.Drawing.Point(115, 66)
        Me.txtConsultaClienteTelefono.Name = "txtConsultaClienteTelefono"
        Me.txtConsultaClienteTelefono.ReadOnly = True
        Me.txtConsultaClienteTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtConsultaClienteTelefono.TabIndex = 37
        '
        'txtConsultaClienteDireccion
        '
        Me.txtConsultaClienteDireccion.Location = New System.Drawing.Point(115, 30)
        Me.txtConsultaClienteDireccion.Name = "txtConsultaClienteDireccion"
        Me.txtConsultaClienteDireccion.ReadOnly = True
        Me.txtConsultaClienteDireccion.Size = New System.Drawing.Size(100, 20)
        Me.txtConsultaClienteDireccion.TabIndex = 36
        '
        'lblConsultaClienteTelefono
        '
        Me.lblConsultaClienteTelefono.AutoSize = True
        Me.lblConsultaClienteTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultaClienteTelefono.Location = New System.Drawing.Point(18, 69)
        Me.lblConsultaClienteTelefono.Name = "lblConsultaClienteTelefono"
        Me.lblConsultaClienteTelefono.Size = New System.Drawing.Size(57, 13)
        Me.lblConsultaClienteTelefono.TabIndex = 35
        Me.lblConsultaClienteTelefono.Text = "Teléfono"
        '
        'lblConsultaClienteDireccion
        '
        Me.lblConsultaClienteDireccion.AutoSize = True
        Me.lblConsultaClienteDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultaClienteDireccion.Location = New System.Drawing.Point(18, 33)
        Me.lblConsultaClienteDireccion.Name = "lblConsultaClienteDireccion"
        Me.lblConsultaClienteDireccion.Size = New System.Drawing.Size(61, 13)
        Me.lblConsultaClienteDireccion.TabIndex = 34
        Me.lblConsultaClienteDireccion.Text = "Dirección"
        '
        'ConsultaClienteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 297)
        Me.Controls.Add(Me.gbCliente)
        Me.Controls.Add(Me.btnConsultaClienteSalir)
        Me.Controls.Add(Me.btnConsultaClienteBuscar)
        Me.Controls.Add(Me.txtConsultaClienteCodigo2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ConsultaClienteForm"
        Me.Text = "Consulta cliente"
        Me.gbCliente.ResumeLayout(False)
        Me.gbCliente.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtConsultaClienteCodigo2 As TextBox
    Friend WithEvents btnConsultaClienteBuscar As Button
    Friend WithEvents btnConsultaClienteSalir As Button
    Friend WithEvents gbCliente As GroupBox
    Friend WithEvents txtConsultaClienteAlquileres As TextBox
    Friend WithEvents lblConsultaClienteAlquileres As Label
    Friend WithEvents txtConsultaClienteEmail As TextBox
    Friend WithEvents lblConsultaClienteEmail As Label
    Friend WithEvents txtConsultaClienteTelefono As TextBox
    Friend WithEvents txtConsultaClienteDireccion As TextBox
    Friend WithEvents lblConsultaClienteTelefono As Label
    Friend WithEvents lblConsultaClienteDireccion As Label
End Class
