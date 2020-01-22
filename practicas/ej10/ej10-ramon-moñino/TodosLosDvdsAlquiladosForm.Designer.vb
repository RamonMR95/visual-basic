<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TodosLosDvdsAlquiladosForm
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
        Me.btnListadoSalir = New System.Windows.Forms.Button()
        Me.rtbListadoAlquilados = New System.Windows.Forms.RichTextBox()
        Me.lblDvdsnoalquilados = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnListadoSalir
        '
        Me.btnListadoSalir.Location = New System.Drawing.Point(436, 312)
        Me.btnListadoSalir.Name = "btnListadoSalir"
        Me.btnListadoSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnListadoSalir.TabIndex = 11
        Me.btnListadoSalir.Text = "Salir"
        Me.btnListadoSalir.UseVisualStyleBackColor = True
        '
        'rtbListadoAlquilados
        '
        Me.rtbListadoAlquilados.Location = New System.Drawing.Point(12, 45)
        Me.rtbListadoAlquilados.Name = "rtbListadoAlquilados"
        Me.rtbListadoAlquilados.Size = New System.Drawing.Size(524, 249)
        Me.rtbListadoAlquilados.TabIndex = 7
        Me.rtbListadoAlquilados.Text = ""
        '
        'lblDvdsnoalquilados
        '
        Me.lblDvdsnoalquilados.AutoSize = True
        Me.lblDvdsnoalquilados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDvdsnoalquilados.Location = New System.Drawing.Point(12, 19)
        Me.lblDvdsnoalquilados.Name = "lblDvdsnoalquilados"
        Me.lblDvdsnoalquilados.Size = New System.Drawing.Size(100, 13)
        Me.lblDvdsnoalquilados.TabIndex = 12
        Me.lblDvdsnoalquilados.Text = "DVDs alquilados"
        '
        'TodosLosDvdsAlquiladosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 353)
        Me.Controls.Add(Me.lblDvdsnoalquilados)
        Me.Controls.Add(Me.btnListadoSalir)
        Me.Controls.Add(Me.rtbListadoAlquilados)
        Me.Name = "TodosLosDvdsAlquiladosForm"
        Me.Text = "Listado DVDs Alquilados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnListadoSalir As Button
    Friend WithEvents rtbListadoAlquilados As RichTextBox
    Friend WithEvents lblDvdsnoalquilados As Label
End Class
