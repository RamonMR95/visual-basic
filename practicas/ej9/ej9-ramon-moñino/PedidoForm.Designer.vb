<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidoForm
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
        Me.lblPedidoCodArt = New System.Windows.Forms.Label()
        Me.lblPedidoCantidad = New System.Windows.Forms.Label()
        Me.txtPedidoCodArt = New System.Windows.Forms.TextBox()
        Me.txtPedidoCantidad = New System.Windows.Forms.TextBox()
        Me.btnPedidoAceptar = New System.Windows.Forms.Button()
        Me.btnPedidoCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPedidoCodArt
        '
        Me.lblPedidoCodArt.AutoSize = True
        Me.lblPedidoCodArt.Location = New System.Drawing.Point(12, 45)
        Me.lblPedidoCodArt.Name = "lblPedidoCodArt"
        Me.lblPedidoCodArt.Size = New System.Drawing.Size(80, 13)
        Me.lblPedidoCodArt.TabIndex = 0
        Me.lblPedidoCodArt.Text = "Codigo Artículo"
        '
        'lblPedidoCantidad
        '
        Me.lblPedidoCantidad.AutoSize = True
        Me.lblPedidoCantidad.Location = New System.Drawing.Point(43, 102)
        Me.lblPedidoCantidad.Name = "lblPedidoCantidad"
        Me.lblPedidoCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lblPedidoCantidad.TabIndex = 1
        Me.lblPedidoCantidad.Text = "Cantidad"
        '
        'txtPedidoCodArt
        '
        Me.txtPedidoCodArt.Location = New System.Drawing.Point(98, 42)
        Me.txtPedidoCodArt.Name = "txtPedidoCodArt"
        Me.txtPedidoCodArt.Size = New System.Drawing.Size(100, 20)
        Me.txtPedidoCodArt.TabIndex = 2
        '
        'txtPedidoCantidad
        '
        Me.txtPedidoCantidad.Location = New System.Drawing.Point(98, 99)
        Me.txtPedidoCantidad.Name = "txtPedidoCantidad"
        Me.txtPedidoCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtPedidoCantidad.TabIndex = 3
        '
        'btnPedidoAceptar
        '
        Me.btnPedidoAceptar.Location = New System.Drawing.Point(110, 163)
        Me.btnPedidoAceptar.Name = "btnPedidoAceptar"
        Me.btnPedidoAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnPedidoAceptar.TabIndex = 4
        Me.btnPedidoAceptar.Text = "Aceptar"
        Me.btnPedidoAceptar.UseVisualStyleBackColor = True
        '
        'btnPedidoCancelar
        '
        Me.btnPedidoCancelar.Location = New System.Drawing.Point(166, 229)
        Me.btnPedidoCancelar.Name = "btnPedidoCancelar"
        Me.btnPedidoCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnPedidoCancelar.TabIndex = 5
        Me.btnPedidoCancelar.Text = "Cancelar"
        Me.btnPedidoCancelar.UseVisualStyleBackColor = True
        '
        'PedidoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 275)
        Me.Controls.Add(Me.btnPedidoCancelar)
        Me.Controls.Add(Me.btnPedidoAceptar)
        Me.Controls.Add(Me.txtPedidoCantidad)
        Me.Controls.Add(Me.txtPedidoCodArt)
        Me.Controls.Add(Me.lblPedidoCantidad)
        Me.Controls.Add(Me.lblPedidoCodArt)
        Me.Name = "PedidoForm"
        Me.Text = "Pedido"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPedidoCodArt As Label
    Friend WithEvents lblPedidoCantidad As Label
    Friend WithEvents txtPedidoCodArt As TextBox
    Friend WithEvents txtPedidoCantidad As TextBox
    Friend WithEvents btnPedidoAceptar As Button
    Friend WithEvents btnPedidoCancelar As Button
End Class
