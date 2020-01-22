<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaDVDForm
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
        Me.components = New System.ComponentModel.Container()
        Me.lblAltaDVDCod = New System.Windows.Forms.Label()
        Me.lblAltaDVDTitulo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAltaDVDCod = New System.Windows.Forms.TextBox()
        Me.txtAltaDVDTitulo = New System.Windows.Forms.TextBox()
        Me.txtAltaDVDDias = New System.Windows.Forms.TextBox()
        Me.btnAltaDVDGuardar = New System.Windows.Forms.Button()
        Me.btnAltaDVDCancelar = New System.Windows.Forms.Button()
        Me.ToolTipAltaDVD = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblAltaDVDCod
        '
        Me.lblAltaDVDCod.AutoSize = True
        Me.lblAltaDVDCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltaDVDCod.Location = New System.Drawing.Point(23, 29)
        Me.lblAltaDVDCod.Name = "lblAltaDVDCod"
        Me.lblAltaDVDCod.Size = New System.Drawing.Size(46, 13)
        Me.lblAltaDVDCod.TabIndex = 0
        Me.lblAltaDVDCod.Text = "Código"
        '
        'lblAltaDVDTitulo
        '
        Me.lblAltaDVDTitulo.AutoSize = True
        Me.lblAltaDVDTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltaDVDTitulo.Location = New System.Drawing.Point(23, 66)
        Me.lblAltaDVDTitulo.Name = "lblAltaDVDTitulo"
        Me.lblAltaDVDTitulo.Size = New System.Drawing.Size(41, 13)
        Me.lblAltaDVDTitulo.TabIndex = 1
        Me.lblAltaDVDTitulo.Text = "Título"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Dias alquiler"
        '
        'txtAltaDVDCod
        '
        Me.txtAltaDVDCod.Location = New System.Drawing.Point(120, 26)
        Me.txtAltaDVDCod.Name = "txtAltaDVDCod"
        Me.txtAltaDVDCod.Size = New System.Drawing.Size(100, 20)
        Me.txtAltaDVDCod.TabIndex = 3
        Me.ToolTipAltaDVD.SetToolTip(Me.txtAltaDVDCod, "Código del DVD")
        '
        'txtAltaDVDTitulo
        '
        Me.txtAltaDVDTitulo.Location = New System.Drawing.Point(120, 63)
        Me.txtAltaDVDTitulo.Name = "txtAltaDVDTitulo"
        Me.txtAltaDVDTitulo.Size = New System.Drawing.Size(100, 20)
        Me.txtAltaDVDTitulo.TabIndex = 4
        Me.ToolTipAltaDVD.SetToolTip(Me.txtAltaDVDTitulo, "Titulo del DVD")
        '
        'txtAltaDVDDias
        '
        Me.txtAltaDVDDias.Location = New System.Drawing.Point(120, 99)
        Me.txtAltaDVDDias.Name = "txtAltaDVDDias"
        Me.txtAltaDVDDias.Size = New System.Drawing.Size(100, 20)
        Me.txtAltaDVDDias.TabIndex = 5
        Me.ToolTipAltaDVD.SetToolTip(Me.txtAltaDVDDias, "Dias de alquiler")
        '
        'btnAltaDVDGuardar
        '
        Me.btnAltaDVDGuardar.Location = New System.Drawing.Point(204, 161)
        Me.btnAltaDVDGuardar.Name = "btnAltaDVDGuardar"
        Me.btnAltaDVDGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnAltaDVDGuardar.TabIndex = 6
        Me.btnAltaDVDGuardar.Text = "Guardar"
        Me.btnAltaDVDGuardar.UseVisualStyleBackColor = True
        '
        'btnAltaDVDCancelar
        '
        Me.btnAltaDVDCancelar.Location = New System.Drawing.Point(301, 161)
        Me.btnAltaDVDCancelar.Name = "btnAltaDVDCancelar"
        Me.btnAltaDVDCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnAltaDVDCancelar.TabIndex = 8
        Me.btnAltaDVDCancelar.Text = "Cancelar"
        Me.btnAltaDVDCancelar.UseVisualStyleBackColor = True
        '
        'AltaDVDForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 210)
        Me.Controls.Add(Me.btnAltaDVDCancelar)
        Me.Controls.Add(Me.btnAltaDVDGuardar)
        Me.Controls.Add(Me.txtAltaDVDDias)
        Me.Controls.Add(Me.txtAltaDVDTitulo)
        Me.Controls.Add(Me.txtAltaDVDCod)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAltaDVDTitulo)
        Me.Controls.Add(Me.lblAltaDVDCod)
        Me.Name = "AltaDVDForm"
        Me.Text = "Alta de DVDs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAltaDVDCod As Label
    Friend WithEvents lblAltaDVDTitulo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAltaDVDCod As TextBox
    Friend WithEvents txtAltaDVDTitulo As TextBox
    Friend WithEvents txtAltaDVDDias As TextBox
    Friend WithEvents btnAltaDVDGuardar As Button
    Friend WithEvents btnAltaDVDCancelar As Button
    Friend WithEvents ToolTipAltaDVD As ToolTip
End Class
