<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambiarClaveForm
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
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtUsuarioCambiarClave = New System.Windows.Forms.TextBox()
        Me.txtClaveCambiarClave = New System.Windows.Forms.TextBox()
        Me.txtNuevaClave1 = New System.Windows.Forms.TextBox()
        Me.txtNuevaClave2 = New System.Windows.Forms.TextBox()
        Me.lblClaveCambiarClave = New System.Windows.Forms.Label()
        Me.lblIntroducir2Clave = New System.Windows.Forms.Label()
        Me.lblIntroduceclavedenuevo = New System.Windows.Forms.Label()
        Me.btnCambiarClave = New System.Windows.Forms.Button()
        Me.btnGuardarNuevaClave = New System.Windows.Forms.Button()
        Me.btnCancelarNuevaClave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(30, 33)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Usuario"
        '
        'txtUsuarioCambiarClave
        '
        Me.txtUsuarioCambiarClave.Location = New System.Drawing.Point(92, 26)
        Me.txtUsuarioCambiarClave.Name = "txtUsuarioCambiarClave"
        Me.txtUsuarioCambiarClave.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuarioCambiarClave.TabIndex = 1
        '
        'txtClaveCambiarClave
        '
        Me.txtClaveCambiarClave.Location = New System.Drawing.Point(92, 63)
        Me.txtClaveCambiarClave.Name = "txtClaveCambiarClave"
        Me.txtClaveCambiarClave.Size = New System.Drawing.Size(100, 20)
        Me.txtClaveCambiarClave.TabIndex = 2
        '
        'txtNuevaClave1
        '
        Me.txtNuevaClave1.Location = New System.Drawing.Point(192, 167)
        Me.txtNuevaClave1.Name = "txtNuevaClave1"
        Me.txtNuevaClave1.Size = New System.Drawing.Size(100, 20)
        Me.txtNuevaClave1.TabIndex = 3
        Me.txtNuevaClave1.Visible = False
        '
        'txtNuevaClave2
        '
        Me.txtNuevaClave2.Location = New System.Drawing.Point(192, 208)
        Me.txtNuevaClave2.Name = "txtNuevaClave2"
        Me.txtNuevaClave2.Size = New System.Drawing.Size(100, 20)
        Me.txtNuevaClave2.TabIndex = 4
        Me.txtNuevaClave2.Visible = False
        '
        'lblClaveCambiarClave
        '
        Me.lblClaveCambiarClave.AutoSize = True
        Me.lblClaveCambiarClave.Location = New System.Drawing.Point(30, 66)
        Me.lblClaveCambiarClave.Name = "lblClaveCambiarClave"
        Me.lblClaveCambiarClave.Size = New System.Drawing.Size(34, 13)
        Me.lblClaveCambiarClave.TabIndex = 5
        Me.lblClaveCambiarClave.Text = "Clave"
        '
        'lblIntroducir2Clave
        '
        Me.lblIntroducir2Clave.AutoSize = True
        Me.lblIntroducir2Clave.Location = New System.Drawing.Point(30, 167)
        Me.lblIntroducir2Clave.Name = "lblIntroducir2Clave"
        Me.lblIntroducir2Clave.Size = New System.Drawing.Size(130, 13)
        Me.lblIntroducir2Clave.TabIndex = 6
        Me.lblIntroducir2Clave.Text = "Introduzca la nueva clave"
        Me.lblIntroducir2Clave.Visible = False
        '
        'lblIntroduceclavedenuevo
        '
        Me.lblIntroduceclavedenuevo.AutoSize = True
        Me.lblIntroduceclavedenuevo.Location = New System.Drawing.Point(30, 211)
        Me.lblIntroduceclavedenuevo.Name = "lblIntroduceclavedenuevo"
        Me.lblIntroduceclavedenuevo.Size = New System.Drawing.Size(145, 13)
        Me.lblIntroduceclavedenuevo.TabIndex = 7
        Me.lblIntroduceclavedenuevo.Text = "Introduzca la clave de nuevo"
        Me.lblIntroduceclavedenuevo.Visible = False
        '
        'btnCambiarClave
        '
        Me.btnCambiarClave.Location = New System.Drawing.Point(226, 43)
        Me.btnCambiarClave.Name = "btnCambiarClave"
        Me.btnCambiarClave.Size = New System.Drawing.Size(75, 23)
        Me.btnCambiarClave.TabIndex = 8
        Me.btnCambiarClave.Text = "Cambiar"
        Me.btnCambiarClave.UseVisualStyleBackColor = True
        '
        'btnGuardarNuevaClave
        '
        Me.btnGuardarNuevaClave.Location = New System.Drawing.Point(177, 261)
        Me.btnGuardarNuevaClave.Name = "btnGuardarNuevaClave"
        Me.btnGuardarNuevaClave.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarNuevaClave.TabIndex = 9
        Me.btnGuardarNuevaClave.Text = "Guardar"
        Me.btnGuardarNuevaClave.UseVisualStyleBackColor = True
        '
        'btnCancelarNuevaClave
        '
        Me.btnCancelarNuevaClave.Location = New System.Drawing.Point(274, 261)
        Me.btnCancelarNuevaClave.Name = "btnCancelarNuevaClave"
        Me.btnCancelarNuevaClave.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarNuevaClave.TabIndex = 10
        Me.btnCancelarNuevaClave.Text = "Cancelar"
        Me.btnCancelarNuevaClave.UseVisualStyleBackColor = True
        '
        'CambiarClaveForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 317)
        Me.Controls.Add(Me.btnCancelarNuevaClave)
        Me.Controls.Add(Me.btnGuardarNuevaClave)
        Me.Controls.Add(Me.btnCambiarClave)
        Me.Controls.Add(Me.lblIntroduceclavedenuevo)
        Me.Controls.Add(Me.lblIntroducir2Clave)
        Me.Controls.Add(Me.lblClaveCambiarClave)
        Me.Controls.Add(Me.txtNuevaClave2)
        Me.Controls.Add(Me.txtNuevaClave1)
        Me.Controls.Add(Me.txtClaveCambiarClave)
        Me.Controls.Add(Me.txtUsuarioCambiarClave)
        Me.Controls.Add(Me.lblUsuario)
        Me.Name = "CambiarClaveForm"
        Me.Text = "CambiarClaveForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtUsuarioCambiarClave As TextBox
    Friend WithEvents txtClaveCambiarClave As TextBox
    Friend WithEvents txtNuevaClave1 As TextBox
    Friend WithEvents txtNuevaClave2 As TextBox
    Friend WithEvents lblClaveCambiarClave As Label
    Friend WithEvents lblIntroducir2Clave As Label
    Friend WithEvents lblIntroduceclavedenuevo As Label
    Friend WithEvents btnCambiarClave As Button
    Friend WithEvents btnGuardarNuevaClave As Button
    Friend WithEvents btnCancelarNuevaClave As Button
End Class
