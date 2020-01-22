<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoForm
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
        Me.rtbListado = New System.Windows.Forms.RichTextBox()
        Me.btnListadoGuardar = New System.Windows.Forms.Button()
        Me.btnListadoAbrir = New System.Windows.Forms.Button()
        Me.btnListadoSalir = New System.Windows.Forms.Button()
        Me.comboBoxListadoCat = New System.Windows.Forms.ComboBox()
        Me.lblListadoCat = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rtbListado
        '
        Me.rtbListado.Location = New System.Drawing.Point(0, 0)
        Me.rtbListado.Name = "rtbListado"
        Me.rtbListado.ReadOnly = True
        Me.rtbListado.Size = New System.Drawing.Size(579, 233)
        Me.rtbListado.TabIndex = 0
        Me.rtbListado.Text = ""
        '
        'btnListadoGuardar
        '
        Me.btnListadoGuardar.Location = New System.Drawing.Point(48, 253)
        Me.btnListadoGuardar.Name = "btnListadoGuardar"
        Me.btnListadoGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnListadoGuardar.TabIndex = 1
        Me.btnListadoGuardar.Text = "Guardar"
        Me.btnListadoGuardar.UseVisualStyleBackColor = True
        '
        'btnListadoAbrir
        '
        Me.btnListadoAbrir.Location = New System.Drawing.Point(140, 253)
        Me.btnListadoAbrir.Name = "btnListadoAbrir"
        Me.btnListadoAbrir.Size = New System.Drawing.Size(75, 23)
        Me.btnListadoAbrir.TabIndex = 2
        Me.btnListadoAbrir.Text = "Abrir"
        Me.btnListadoAbrir.UseVisualStyleBackColor = True
        '
        'btnListadoSalir
        '
        Me.btnListadoSalir.Location = New System.Drawing.Point(492, 253)
        Me.btnListadoSalir.Name = "btnListadoSalir"
        Me.btnListadoSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnListadoSalir.TabIndex = 3
        Me.btnListadoSalir.Text = "Salir"
        Me.btnListadoSalir.UseVisualStyleBackColor = True
        '
        'comboBoxListadoCat
        '
        Me.comboBoxListadoCat.FormattingEnabled = True
        Me.comboBoxListadoCat.Location = New System.Drawing.Point(338, 255)
        Me.comboBoxListadoCat.Name = "comboBoxListadoCat"
        Me.comboBoxListadoCat.Size = New System.Drawing.Size(121, 21)
        Me.comboBoxListadoCat.TabIndex = 4
        Me.comboBoxListadoCat.Visible = False
        '
        'lblListadoCat
        '
        Me.lblListadoCat.AutoSize = True
        Me.lblListadoCat.Location = New System.Drawing.Point(373, 239)
        Me.lblListadoCat.Name = "lblListadoCat"
        Me.lblListadoCat.Size = New System.Drawing.Size(54, 13)
        Me.lblListadoCat.TabIndex = 5
        Me.lblListadoCat.Text = "Categoría"
        Me.lblListadoCat.Visible = False
        '
        'ListadoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 288)
        Me.Controls.Add(Me.lblListadoCat)
        Me.Controls.Add(Me.comboBoxListadoCat)
        Me.Controls.Add(Me.btnListadoSalir)
        Me.Controls.Add(Me.btnListadoAbrir)
        Me.Controls.Add(Me.btnListadoGuardar)
        Me.Controls.Add(Me.rtbListado)
        Me.Name = "ListadoForm"
        Me.Text = "Listado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rtbListado As RichTextBox
    Friend WithEvents btnListadoGuardar As Button
    Friend WithEvents btnListadoAbrir As Button
    Friend WithEvents btnListadoSalir As Button
    Friend WithEvents comboBoxListadoCat As ComboBox
    Friend WithEvents lblListadoCat As Label
End Class
