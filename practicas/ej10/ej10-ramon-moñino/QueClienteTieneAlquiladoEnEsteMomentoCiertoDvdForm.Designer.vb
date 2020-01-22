<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QueClienteTieneAlquiladoEnEsteMomentoCiertoDvdForm
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
        Me.txtCodigoDVD = New System.Windows.Forms.TextBox()
        Me.lblAlquilarCodigoDVD = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCodigoDVD
        '
        Me.txtCodigoDVD.Location = New System.Drawing.Point(130, 35)
        Me.txtCodigoDVD.Name = "txtCodigoDVD"
        Me.txtCodigoDVD.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoDVD.TabIndex = 42
        '
        'lblAlquilarCodigoDVD
        '
        Me.lblAlquilarCodigoDVD.AutoSize = True
        Me.lblAlquilarCodigoDVD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlquilarCodigoDVD.Location = New System.Drawing.Point(33, 38)
        Me.lblAlquilarCodigoDVD.Name = "lblAlquilarCodigoDVD"
        Me.lblAlquilarCodigoDVD.Size = New System.Drawing.Size(76, 13)
        Me.lblAlquilarCodigoDVD.TabIndex = 41
        Me.lblAlquilarCodigoDVD.Text = "Código DVD"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(36, 149)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 43
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtCodCliente
        '
        Me.txtCodCliente.Location = New System.Drawing.Point(132, 84)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.ReadOnly = True
        Me.txtCodCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtCodCliente.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Código Cliente"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(311, 173)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 46
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'QueClienteTieneAlquiladoEnEsteMomentoCiertoDvdForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 208)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtCodCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtCodigoDVD)
        Me.Controls.Add(Me.lblAlquilarCodigoDVD)
        Me.Name = "QueClienteTieneAlquiladoEnEsteMomentoCiertoDvdForm"
        Me.Text = "Búsqueda DVD alquilado por cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCodigoDVD As TextBox
    Friend WithEvents lblAlquilarCodigoDVD As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtCodCliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSalir As Button
End Class
