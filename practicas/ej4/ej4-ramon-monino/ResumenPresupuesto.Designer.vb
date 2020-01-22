<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResumenPresupuesto
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
        Me.components = New System.ComponentModel.Container()
        Me.txtPresupuesto = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lblResumenPresupuesto = New System.Windows.Forms.Label()
        Me.btnVolverPresupuesto = New System.Windows.Forms.Button()
        Me.btnSalirPresupuesto = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPresupuesto
        '
        Me.txtPresupuesto.Location = New System.Drawing.Point(12, 71)
        Me.txtPresupuesto.Name = "txtPresupuesto"
        Me.txtPresupuesto.Size = New System.Drawing.Size(606, 284)
        Me.txtPresupuesto.TabIndex = 0
        Me.txtPresupuesto.Text = ""
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'lblResumenPresupuesto
        '
        Me.lblResumenPresupuesto.AutoSize = True
        Me.lblResumenPresupuesto.Location = New System.Drawing.Point(24, 23)
        Me.lblResumenPresupuesto.Name = "lblResumenPresupuesto"
        Me.lblResumenPresupuesto.Size = New System.Drawing.Size(114, 13)
        Me.lblResumenPresupuesto.TabIndex = 2
        Me.lblResumenPresupuesto.Text = "Resumen Presupuesto"
        '
        'btnVolverPresupuesto
        '
        Me.btnVolverPresupuesto.Location = New System.Drawing.Point(262, 382)
        Me.btnVolverPresupuesto.Name = "btnVolverPresupuesto"
        Me.btnVolverPresupuesto.Size = New System.Drawing.Size(75, 23)
        Me.btnVolverPresupuesto.TabIndex = 3
        Me.btnVolverPresupuesto.Text = "Volver"
        Me.btnVolverPresupuesto.UseVisualStyleBackColor = True
        '
        'btnSalirPresupuesto
        '
        Me.btnSalirPresupuesto.Location = New System.Drawing.Point(692, 397)
        Me.btnSalirPresupuesto.Name = "btnSalirPresupuesto"
        Me.btnSalirPresupuesto.Size = New System.Drawing.Size(75, 23)
        Me.btnSalirPresupuesto.TabIndex = 4
        Me.btnSalirPresupuesto.Text = "Salir"
        Me.btnSalirPresupuesto.UseVisualStyleBackColor = True
        '
        'ResumenPresupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSalirPresupuesto)
        Me.Controls.Add(Me.btnVolverPresupuesto)
        Me.Controls.Add(Me.lblResumenPresupuesto)
        Me.Controls.Add(Me.txtPresupuesto)
        Me.Name = "ResumenPresupuesto"
        Me.Text = "ResumenPresupuesto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPresupuesto As RichTextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents lblResumenPresupuesto As Label
    Friend WithEvents btnVolverPresupuesto As Button
    Friend WithEvents btnSalirPresupuesto As Button
End Class
