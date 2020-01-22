<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelMiniCalc
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
        Me.lblNumero1 = New System.Windows.Forms.Label()
        Me.lblNumero2 = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.txtNumero1 = New System.Windows.Forms.TextBox()
        Me.txtNumero2 = New System.Windows.Forms.TextBox()
        Me.txtResultadoCalc = New System.Windows.Forms.TextBox()
        Me.btnSumarCalc = New System.Windows.Forms.Button()
        Me.btnRestarCalc = New System.Windows.Forms.Button()
        Me.btnMultiplicarCalc = New System.Windows.Forms.Button()
        Me.btnDividirCalc = New System.Windows.Forms.Button()
        Me.btnVolverCalc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNumero1
        '
        Me.lblNumero1.AutoSize = True
        Me.lblNumero1.Location = New System.Drawing.Point(32, 139)
        Me.lblNumero1.Name = "lblNumero1"
        Me.lblNumero1.Size = New System.Drawing.Size(53, 13)
        Me.lblNumero1.TabIndex = 0
        Me.lblNumero1.Text = "Numero 1"
        '
        'lblNumero2
        '
        Me.lblNumero2.AutoSize = True
        Me.lblNumero2.Location = New System.Drawing.Point(32, 178)
        Me.lblNumero2.Name = "lblNumero2"
        Me.lblNumero2.Size = New System.Drawing.Size(53, 13)
        Me.lblNumero2.TabIndex = 1
        Me.lblNumero2.Text = "Numero 2"
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(187, 158)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(55, 13)
        Me.lblResultado.TabIndex = 2
        Me.lblResultado.Text = "Resultado"
        '
        'txtNumero1
        '
        Me.txtNumero1.Location = New System.Drawing.Point(100, 136)
        Me.txtNumero1.Name = "txtNumero1"
        Me.txtNumero1.Size = New System.Drawing.Size(54, 20)
        Me.txtNumero1.TabIndex = 3
        '
        'txtNumero2
        '
        Me.txtNumero2.Location = New System.Drawing.Point(100, 178)
        Me.txtNumero2.Name = "txtNumero2"
        Me.txtNumero2.Size = New System.Drawing.Size(54, 20)
        Me.txtNumero2.TabIndex = 4
        '
        'txtResultadoCalc
        '
        Me.txtResultadoCalc.Enabled = False
        Me.txtResultadoCalc.Location = New System.Drawing.Point(248, 155)
        Me.txtResultadoCalc.Name = "txtResultadoCalc"
        Me.txtResultadoCalc.Size = New System.Drawing.Size(50, 20)
        Me.txtResultadoCalc.TabIndex = 5
        '
        'btnSumarCalc
        '
        Me.btnSumarCalc.Location = New System.Drawing.Point(49, 242)
        Me.btnSumarCalc.Name = "btnSumarCalc"
        Me.btnSumarCalc.Size = New System.Drawing.Size(24, 24)
        Me.btnSumarCalc.TabIndex = 6
        Me.btnSumarCalc.Text = "+"
        Me.btnSumarCalc.UseVisualStyleBackColor = True
        '
        'btnRestarCalc
        '
        Me.btnRestarCalc.Location = New System.Drawing.Point(90, 242)
        Me.btnRestarCalc.Name = "btnRestarCalc"
        Me.btnRestarCalc.Size = New System.Drawing.Size(24, 24)
        Me.btnRestarCalc.TabIndex = 7
        Me.btnRestarCalc.Text = "-"
        Me.btnRestarCalc.UseVisualStyleBackColor = True
        '
        'btnMultiplicarCalc
        '
        Me.btnMultiplicarCalc.Location = New System.Drawing.Point(130, 242)
        Me.btnMultiplicarCalc.Name = "btnMultiplicarCalc"
        Me.btnMultiplicarCalc.Size = New System.Drawing.Size(24, 24)
        Me.btnMultiplicarCalc.TabIndex = 8
        Me.btnMultiplicarCalc.Text = "*"
        Me.btnMultiplicarCalc.UseVisualStyleBackColor = True
        '
        'btnDividirCalc
        '
        Me.btnDividirCalc.Location = New System.Drawing.Point(176, 242)
        Me.btnDividirCalc.Name = "btnDividirCalc"
        Me.btnDividirCalc.Size = New System.Drawing.Size(24, 24)
        Me.btnDividirCalc.TabIndex = 9
        Me.btnDividirCalc.Text = "/"
        Me.btnDividirCalc.UseVisualStyleBackColor = True
        '
        'btnVolverCalc
        '
        Me.btnVolverCalc.Location = New System.Drawing.Point(79, 308)
        Me.btnVolverCalc.Name = "btnVolverCalc"
        Me.btnVolverCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnVolverCalc.TabIndex = 10
        Me.btnVolverCalc.Text = "Volver"
        Me.btnVolverCalc.UseVisualStyleBackColor = True
        '
        'PanelMiniCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 375)
        Me.Controls.Add(Me.btnVolverCalc)
        Me.Controls.Add(Me.btnDividirCalc)
        Me.Controls.Add(Me.btnMultiplicarCalc)
        Me.Controls.Add(Me.btnRestarCalc)
        Me.Controls.Add(Me.btnSumarCalc)
        Me.Controls.Add(Me.txtResultadoCalc)
        Me.Controls.Add(Me.txtNumero2)
        Me.Controls.Add(Me.txtNumero1)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.lblNumero2)
        Me.Controls.Add(Me.lblNumero1)
        Me.Name = "PanelMiniCalc"
        Me.Text = "MiniCalculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumero1 As Label
    Friend WithEvents lblNumero2 As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents txtNumero1 As TextBox
    Friend WithEvents txtNumero2 As TextBox
    Friend WithEvents txtResultadoCalc As TextBox
    Friend WithEvents btnSumarCalc As Button
    Friend WithEvents btnRestarCalc As Button
    Friend WithEvents btnMultiplicarCalc As Button
    Friend WithEvents btnDividirCalc As Button
    Friend WithEvents btnVolverCalc As Button
End Class
