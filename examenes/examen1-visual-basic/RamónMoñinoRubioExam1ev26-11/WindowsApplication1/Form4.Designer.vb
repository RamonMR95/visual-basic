<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.rtxPedido = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'rtxPedido
        '
        Me.rtxPedido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtxPedido.Location = New System.Drawing.Point(0, 0)
        Me.rtxPedido.Name = "rtxPedido"
        Me.rtxPedido.Size = New System.Drawing.Size(284, 262)
        Me.rtxPedido.TabIndex = 0
        Me.rtxPedido.Text = ""
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.rtxPedido)
        Me.Name = "Form4"
        Me.Text = "Pedidos"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtxPedido As System.Windows.Forms.RichTextBox
End Class
