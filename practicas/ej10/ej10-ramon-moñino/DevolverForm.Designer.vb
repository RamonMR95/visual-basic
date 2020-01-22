<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DevolverForm
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
        Me.lblDevolverCodDVD = New System.Windows.Forms.Label()
        Me.txtDevolverCodDVD = New System.Windows.Forms.TextBox()
        Me.btnDevolver = New System.Windows.Forms.Button()
        Me.btnDevolverSalir = New System.Windows.Forms.Button()
        Me.txtDevolverFechaDevolucion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDevolverDiasAlquilado = New System.Windows.Forms.TextBox()
        Me.lblDevolverDiasAlquilado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblDevolverCodDVD
        '
        Me.lblDevolverCodDVD.AutoSize = True
        Me.lblDevolverCodDVD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDevolverCodDVD.Location = New System.Drawing.Point(24, 22)
        Me.lblDevolverCodDVD.Name = "lblDevolverCodDVD"
        Me.lblDevolverCodDVD.Size = New System.Drawing.Size(76, 13)
        Me.lblDevolverCodDVD.TabIndex = 0
        Me.lblDevolverCodDVD.Text = "Código DVD"
        '
        'txtDevolverCodDVD
        '
        Me.txtDevolverCodDVD.Location = New System.Drawing.Point(27, 52)
        Me.txtDevolverCodDVD.Name = "txtDevolverCodDVD"
        Me.txtDevolverCodDVD.Size = New System.Drawing.Size(100, 20)
        Me.txtDevolverCodDVD.TabIndex = 1
        '
        'btnDevolver
        '
        Me.btnDevolver.Location = New System.Drawing.Point(40, 104)
        Me.btnDevolver.Name = "btnDevolver"
        Me.btnDevolver.Size = New System.Drawing.Size(75, 23)
        Me.btnDevolver.TabIndex = 2
        Me.btnDevolver.Text = "Devolver"
        Me.btnDevolver.UseVisualStyleBackColor = True
        '
        'btnDevolverSalir
        '
        Me.btnDevolverSalir.Location = New System.Drawing.Point(281, 195)
        Me.btnDevolverSalir.Name = "btnDevolverSalir"
        Me.btnDevolverSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnDevolverSalir.TabIndex = 3
        Me.btnDevolverSalir.Text = "Salir"
        Me.btnDevolverSalir.UseVisualStyleBackColor = True
        '
        'txtDevolverFechaDevolucion
        '
        Me.txtDevolverFechaDevolucion.Location = New System.Drawing.Point(172, 52)
        Me.txtDevolverFechaDevolucion.Name = "txtDevolverFechaDevolucion"
        Me.txtDevolverFechaDevolucion.ReadOnly = True
        Me.txtDevolverFechaDevolucion.Size = New System.Drawing.Size(100, 20)
        Me.txtDevolverFechaDevolucion.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(169, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Fecha Devolución"
        '
        'txtDevolverDiasAlquilado
        '
        Me.txtDevolverDiasAlquilado.Location = New System.Drawing.Point(172, 134)
        Me.txtDevolverDiasAlquilado.Name = "txtDevolverDiasAlquilado"
        Me.txtDevolverDiasAlquilado.ReadOnly = True
        Me.txtDevolverDiasAlquilado.Size = New System.Drawing.Size(100, 20)
        Me.txtDevolverDiasAlquilado.TabIndex = 7
        '
        'lblDevolverDiasAlquilado
        '
        Me.lblDevolverDiasAlquilado.AutoSize = True
        Me.lblDevolverDiasAlquilado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDevolverDiasAlquilado.Location = New System.Drawing.Point(169, 104)
        Me.lblDevolverDiasAlquilado.Name = "lblDevolverDiasAlquilado"
        Me.lblDevolverDiasAlquilado.Size = New System.Drawing.Size(90, 13)
        Me.lblDevolverDiasAlquilado.TabIndex = 6
        Me.lblDevolverDiasAlquilado.Text = "Días Alquilado"
        '
        'DevolverForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 236)
        Me.Controls.Add(Me.txtDevolverDiasAlquilado)
        Me.Controls.Add(Me.lblDevolverDiasAlquilado)
        Me.Controls.Add(Me.txtDevolverFechaDevolucion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDevolverSalir)
        Me.Controls.Add(Me.btnDevolver)
        Me.Controls.Add(Me.txtDevolverCodDVD)
        Me.Controls.Add(Me.lblDevolverCodDVD)
        Me.Name = "DevolverForm"
        Me.Text = "Devolución de DVDs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDevolverCodDVD As Label
    Friend WithEvents txtDevolverCodDVD As TextBox
    Friend WithEvents btnDevolver As Button
    Friend WithEvents btnDevolverSalir As Button
    Friend WithEvents txtDevolverFechaDevolucion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDevolverDiasAlquilado As TextBox
    Friend WithEvents lblDevolverDiasAlquilado As Label
End Class
