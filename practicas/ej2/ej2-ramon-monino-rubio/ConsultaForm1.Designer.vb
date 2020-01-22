<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaForm1
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
        Me.txtNicknameAlumListar = New System.Windows.Forms.TextBox()
        Me.lblNicknameAlumLista = New System.Windows.Forms.Label()
        Me.btnVolverListar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNicknameAlumListar
        '
        Me.txtNicknameAlumListar.Location = New System.Drawing.Point(87, 25)
        Me.txtNicknameAlumListar.Name = "txtNicknameAlumListar"
        Me.txtNicknameAlumListar.Size = New System.Drawing.Size(100, 20)
        Me.txtNicknameAlumListar.TabIndex = 26
        '
        'lblNicknameAlumLista
        '
        Me.lblNicknameAlumLista.AutoSize = True
        Me.lblNicknameAlumLista.Location = New System.Drawing.Point(12, 28)
        Me.lblNicknameAlumLista.Name = "lblNicknameAlumLista"
        Me.lblNicknameAlumLista.Size = New System.Drawing.Size(55, 13)
        Me.lblNicknameAlumLista.TabIndex = 25
        Me.lblNicknameAlumLista.Text = "Nickname"
        '
        'btnVolverListar
        '
        Me.btnVolverListar.Location = New System.Drawing.Point(112, 76)
        Me.btnVolverListar.Name = "btnVolverListar"
        Me.btnVolverListar.Size = New System.Drawing.Size(75, 23)
        Me.btnVolverListar.TabIndex = 27
        Me.btnVolverListar.Text = "Volver"
        Me.btnVolverListar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(15, 76)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 28
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'ConsultaForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(217, 133)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnVolverListar)
        Me.Controls.Add(Me.txtNicknameAlumListar)
        Me.Controls.Add(Me.lblNicknameAlumLista)
        Me.Name = "ConsultaForm1"
        Me.Text = "Busqueda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNicknameAlumListar As TextBox
    Friend WithEvents lblNicknameAlumLista As Label
    Friend WithEvents btnVolverListar As Button
    Friend WithEvents btnBuscar As Button
End Class
