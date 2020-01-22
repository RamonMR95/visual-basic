<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.comboBoxUsuarios = New System.Windows.Forms.ComboBox()
        Me.lblUsuarioLogin = New System.Windows.Forms.Label()
        Me.lblClaveLogin = New System.Windows.Forms.Label()
        Me.txtClaveLogin = New System.Windows.Forms.TextBox()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.btnSalirLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'comboBoxUsuarios
        '
        Me.comboBoxUsuarios.FormattingEnabled = True
        Me.comboBoxUsuarios.Location = New System.Drawing.Point(104, 58)
        Me.comboBoxUsuarios.Name = "comboBoxUsuarios"
        Me.comboBoxUsuarios.Size = New System.Drawing.Size(121, 21)
        Me.comboBoxUsuarios.TabIndex = 0
        '
        'lblUsuarioLogin
        '
        Me.lblUsuarioLogin.AutoSize = True
        Me.lblUsuarioLogin.Location = New System.Drawing.Point(31, 61)
        Me.lblUsuarioLogin.Name = "lblUsuarioLogin"
        Me.lblUsuarioLogin.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuarioLogin.TabIndex = 1
        Me.lblUsuarioLogin.Text = "Usuario"
        '
        'lblClaveLogin
        '
        Me.lblClaveLogin.AutoSize = True
        Me.lblClaveLogin.Location = New System.Drawing.Point(40, 137)
        Me.lblClaveLogin.Name = "lblClaveLogin"
        Me.lblClaveLogin.Size = New System.Drawing.Size(34, 13)
        Me.lblClaveLogin.TabIndex = 2
        Me.lblClaveLogin.Text = "Clave"
        Me.lblClaveLogin.Visible = False
        '
        'txtClaveLogin
        '
        Me.txtClaveLogin.Location = New System.Drawing.Point(104, 137)
        Me.txtClaveLogin.Name = "txtClaveLogin"
        Me.txtClaveLogin.Size = New System.Drawing.Size(100, 20)
        Me.txtClaveLogin.TabIndex = 3
        Me.txtClaveLogin.Visible = False
        '
        'btnLogIn
        '
        Me.btnLogIn.Location = New System.Drawing.Point(116, 213)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(75, 23)
        Me.btnLogIn.TabIndex = 4
        Me.btnLogIn.Text = "Login"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'btnSalirLogin
        '
        Me.btnSalirLogin.Location = New System.Drawing.Point(159, 289)
        Me.btnSalirLogin.Name = "btnSalirLogin"
        Me.btnSalirLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnSalirLogin.TabIndex = 5
        Me.btnSalirLogin.Text = "Salir"
        Me.btnSalirLogin.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 338)
        Me.Controls.Add(Me.btnSalirLogin)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.txtClaveLogin)
        Me.Controls.Add(Me.lblClaveLogin)
        Me.Controls.Add(Me.lblUsuarioLogin)
        Me.Controls.Add(Me.comboBoxUsuarios)
        Me.Name = "LoginForm"
        Me.Text = "LoginForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents comboBoxUsuarios As ComboBox
    Friend WithEvents lblUsuarioLogin As Label
    Friend WithEvents lblClaveLogin As Label
    Friend WithEvents txtClaveLogin As TextBox
    Friend WithEvents btnLogIn As Button
    Friend WithEvents btnSalirLogin As Button
End Class
