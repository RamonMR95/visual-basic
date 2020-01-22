<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TodosLosDVDsNoAlquiladosForm
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
        Me.lblDvdsnoalquilados = New System.Windows.Forms.Label()
        Me.btnListadoSalir = New System.Windows.Forms.Button()
        Me.rtbListadoNoAlquilados = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'lblDvdsnoalquilados
        '
        Me.lblDvdsnoalquilados.AutoSize = True
        Me.lblDvdsnoalquilados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDvdsnoalquilados.Location = New System.Drawing.Point(30, 21)
        Me.lblDvdsnoalquilados.Name = "lblDvdsnoalquilados"
        Me.lblDvdsnoalquilados.Size = New System.Drawing.Size(118, 13)
        Me.lblDvdsnoalquilados.TabIndex = 15
        Me.lblDvdsnoalquilados.Text = "DVDs no alquilados"
        '
        'btnListadoSalir
        '
        Me.btnListadoSalir.Location = New System.Drawing.Point(454, 314)
        Me.btnListadoSalir.Name = "btnListadoSalir"
        Me.btnListadoSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnListadoSalir.TabIndex = 14
        Me.btnListadoSalir.Text = "Salir"
        Me.btnListadoSalir.UseVisualStyleBackColor = True
        '
        'rtbListadoNoAlquilados
        '
        Me.rtbListadoNoAlquilados.Location = New System.Drawing.Point(30, 47)
        Me.rtbListadoNoAlquilados.Name = "rtbListadoNoAlquilados"
        Me.rtbListadoNoAlquilados.Size = New System.Drawing.Size(524, 249)
        Me.rtbListadoNoAlquilados.TabIndex = 13
        Me.rtbListadoNoAlquilados.Text = ""
        '
        'TodosLosDVDsNoAlquiladosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 379)
        Me.Controls.Add(Me.lblDvdsnoalquilados)
        Me.Controls.Add(Me.btnListadoSalir)
        Me.Controls.Add(Me.rtbListadoNoAlquilados)
        Me.Name = "TodosLosDVDsNoAlquiladosForm"
        Me.Text = "Listado DVDs no alquilados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDvdsnoalquilados As Label
    Friend WithEvents btnListadoSalir As Button
    Friend WithEvents rtbListadoNoAlquilados As RichTextBox
End Class
