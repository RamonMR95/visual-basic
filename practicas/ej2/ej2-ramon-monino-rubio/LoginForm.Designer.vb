<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.lblNombreLogin = New System.Windows.Forms.Label()
        Me.lblPasswordLogin = New System.Windows.Forms.Label()
        Me.txtNombreLogin = New System.Windows.Forms.TextBox()
        Me.txtPasswordLogin = New System.Windows.Forms.TextBox()
        Me.btnEntrarLogin = New System.Windows.Forms.Button()
        Me.btnSalirLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNombreLogin
        '
        Me.lblNombreLogin.AutoSize = True
        Me.lblNombreLogin.Location = New System.Drawing.Point(114, 96)
        Me.lblNombreLogin.Name = "lblNombreLogin"
        Me.lblNombreLogin.Size = New System.Drawing.Size(44, 13)
        Me.lblNombreLogin.TabIndex = 0
        Me.lblNombreLogin.Text = "Nombre"
        '
        'lblPasswordLogin
        '
        Me.lblPasswordLogin.AutoSize = True
        Me.lblPasswordLogin.Location = New System.Drawing.Point(114, 151)
        Me.lblPasswordLogin.Name = "lblPasswordLogin"
        Me.lblPasswordLogin.Size = New System.Drawing.Size(53, 13)
        Me.lblPasswordLogin.TabIndex = 1
        Me.lblPasswordLogin.Text = "Password"
        '
        'txtNombreLogin
        '
        Me.txtNombreLogin.Location = New System.Drawing.Point(196, 93)
        Me.txtNombreLogin.Name = "txtNombreLogin"
        Me.txtNombreLogin.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreLogin.TabIndex = 2
        '
        'txtPasswordLogin
        '
        Me.txtPasswordLogin.Location = New System.Drawing.Point(196, 148)
        Me.txtPasswordLogin.Name = "txtPasswordLogin"
        Me.txtPasswordLogin.Size = New System.Drawing.Size(100, 20)
        Me.txtPasswordLogin.TabIndex = 3
        '
        'btnEntrarLogin
        '
        Me.btnEntrarLogin.Location = New System.Drawing.Point(205, 229)
        Me.btnEntrarLogin.Name = "btnEntrarLogin"
        Me.btnEntrarLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnEntrarLogin.TabIndex = 4
        Me.btnEntrarLogin.Text = "Entrar"
        Me.btnEntrarLogin.UseVisualStyleBackColor = True
        '
        'btnSalirLogin
        '
        Me.btnSalirLogin.Location = New System.Drawing.Point(398, 269)
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
        Me.ClientSize = New System.Drawing.Size(494, 315)
        Me.Controls.Add(Me.btnSalirLogin)
        Me.Controls.Add(Me.btnEntrarLogin)
        Me.Controls.Add(Me.txtPasswordLogin)
        Me.Controls.Add(Me.txtNombreLogin)
        Me.Controls.Add(Me.lblPasswordLogin)
        Me.Controls.Add(Me.lblNombreLogin)
        Me.Name = "LoginForm"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombreLogin As Label
    Friend WithEvents lblPasswordLogin As Label
    Friend WithEvents txtNombreLogin As TextBox
    Friend WithEvents txtPasswordLogin As TextBox
    Friend WithEvents btnEntrarLogin As Button
    Friend WithEvents btnSalirLogin As Button
End Class
