<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculadoraForm
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
        Me.btnOn = New System.Windows.Forms.Button()
        Me.gbPanel = New System.Windows.Forms.GroupBox()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.btnModulo = New System.Windows.Forms.Button()
        Me.btnDividir = New System.Windows.Forms.Button()
        Me.btnMultiplicar = New System.Windows.Forms.Button()
        Me.btnRestar = New System.Windows.Forms.Button()
        Me.btnSumar = New System.Windows.Forms.Button()
        Me.btnIgual = New System.Windows.Forms.Button()
        Me.btnLimpiarText = New System.Windows.Forms.Button()
        Me.btnCambiarSigno = New System.Windows.Forms.Button()
        Me.btnComa = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.gbPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOn
        '
        Me.btnOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOn.Location = New System.Drawing.Point(13, 0)
        Me.btnOn.Name = "btnOn"
        Me.btnOn.Size = New System.Drawing.Size(50, 23)
        Me.btnOn.TabIndex = 4
        Me.btnOn.Text = "ON"
        Me.btnOn.UseVisualStyleBackColor = True
        '
        'gbPanel
        '
        Me.gbPanel.Controls.Add(Me.txtResultado)
        Me.gbPanel.Controls.Add(Me.btnModulo)
        Me.gbPanel.Controls.Add(Me.btnDividir)
        Me.gbPanel.Controls.Add(Me.btnMultiplicar)
        Me.gbPanel.Controls.Add(Me.btnRestar)
        Me.gbPanel.Controls.Add(Me.btnSumar)
        Me.gbPanel.Controls.Add(Me.btnIgual)
        Me.gbPanel.Controls.Add(Me.btnLimpiarText)
        Me.gbPanel.Controls.Add(Me.btnCambiarSigno)
        Me.gbPanel.Controls.Add(Me.btnComa)
        Me.gbPanel.Controls.Add(Me.btn0)
        Me.gbPanel.Controls.Add(Me.btn3)
        Me.gbPanel.Controls.Add(Me.btn2)
        Me.gbPanel.Controls.Add(Me.btn1)
        Me.gbPanel.Controls.Add(Me.btn6)
        Me.gbPanel.Controls.Add(Me.btn5)
        Me.gbPanel.Controls.Add(Me.btn4)
        Me.gbPanel.Controls.Add(Me.btn9)
        Me.gbPanel.Controls.Add(Me.btn8)
        Me.gbPanel.Controls.Add(Me.btn7)
        Me.gbPanel.Enabled = False
        Me.gbPanel.Location = New System.Drawing.Point(13, 29)
        Me.gbPanel.Name = "gbPanel"
        Me.gbPanel.Size = New System.Drawing.Size(243, 354)
        Me.gbPanel.TabIndex = 59
        Me.gbPanel.TabStop = False
        '
        'txtResultado
        '
        Me.txtResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultado.Location = New System.Drawing.Point(25, 36)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.ReadOnly = True
        Me.txtResultado.Size = New System.Drawing.Size(195, 31)
        Me.txtResultado.TabIndex = 79
        Me.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnModulo
        '
        Me.btnModulo.Location = New System.Drawing.Point(180, 288)
        Me.btnModulo.Name = "btnModulo"
        Me.btnModulo.Size = New System.Drawing.Size(40, 40)
        Me.btnModulo.TabIndex = 78
        Me.btnModulo.Text = "%"
        Me.btnModulo.UseVisualStyleBackColor = True
        '
        'btnDividir
        '
        Me.btnDividir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDividir.Location = New System.Drawing.Point(180, 242)
        Me.btnDividir.Name = "btnDividir"
        Me.btnDividir.Size = New System.Drawing.Size(40, 40)
        Me.btnDividir.TabIndex = 76
        Me.btnDividir.Tag = "division"
        Me.btnDividir.Text = "/"
        Me.btnDividir.UseVisualStyleBackColor = True
        '
        'btnMultiplicar
        '
        Me.btnMultiplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplicar.Location = New System.Drawing.Point(180, 196)
        Me.btnMultiplicar.Name = "btnMultiplicar"
        Me.btnMultiplicar.Size = New System.Drawing.Size(40, 40)
        Me.btnMultiplicar.TabIndex = 75
        Me.btnMultiplicar.Tag = "multip"
        Me.btnMultiplicar.Text = "*"
        Me.btnMultiplicar.UseVisualStyleBackColor = True
        '
        'btnRestar
        '
        Me.btnRestar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestar.Location = New System.Drawing.Point(180, 150)
        Me.btnRestar.Name = "btnRestar"
        Me.btnRestar.Size = New System.Drawing.Size(40, 40)
        Me.btnRestar.TabIndex = 74
        Me.btnRestar.Tag = "resta"
        Me.btnRestar.Text = "-"
        Me.btnRestar.UseVisualStyleBackColor = True
        '
        'btnSumar
        '
        Me.btnSumar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSumar.Location = New System.Drawing.Point(180, 104)
        Me.btnSumar.Name = "btnSumar"
        Me.btnSumar.Size = New System.Drawing.Size(40, 40)
        Me.btnSumar.TabIndex = 73
        Me.btnSumar.Tag = "suma"
        Me.btnSumar.Text = "+"
        Me.btnSumar.UseVisualStyleBackColor = True
        '
        'btnIgual
        '
        Me.btnIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIgual.Location = New System.Drawing.Point(71, 288)
        Me.btnIgual.Name = "btnIgual"
        Me.btnIgual.Size = New System.Drawing.Size(86, 40)
        Me.btnIgual.TabIndex = 72
        Me.btnIgual.Text = "="
        Me.btnIgual.UseVisualStyleBackColor = True
        '
        'btnLimpiarText
        '
        Me.btnLimpiarText.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarText.Location = New System.Drawing.Point(25, 288)
        Me.btnLimpiarText.Name = "btnLimpiarText"
        Me.btnLimpiarText.Size = New System.Drawing.Size(40, 40)
        Me.btnLimpiarText.TabIndex = 71
        Me.btnLimpiarText.Text = "C"
        Me.btnLimpiarText.UseVisualStyleBackColor = True
        '
        'btnCambiarSigno
        '
        Me.btnCambiarSigno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarSigno.Location = New System.Drawing.Point(117, 242)
        Me.btnCambiarSigno.Name = "btnCambiarSigno"
        Me.btnCambiarSigno.Size = New System.Drawing.Size(40, 40)
        Me.btnCambiarSigno.TabIndex = 70
        Me.btnCambiarSigno.Text = "+/-"
        Me.btnCambiarSigno.UseVisualStyleBackColor = True
        '
        'btnComa
        '
        Me.btnComa.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComa.Location = New System.Drawing.Point(71, 242)
        Me.btnComa.Name = "btnComa"
        Me.btnComa.Size = New System.Drawing.Size(40, 40)
        Me.btnComa.TabIndex = 69
        Me.btnComa.Text = "."
        Me.btnComa.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.Location = New System.Drawing.Point(25, 242)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(40, 40)
        Me.btn0.TabIndex = 68
        Me.btn0.Tag = "0"
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(117, 196)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(40, 40)
        Me.btn3.TabIndex = 67
        Me.btn3.Tag = "3"
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(71, 196)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(40, 40)
        Me.btn2.TabIndex = 66
        Me.btn2.Tag = "2"
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(25, 196)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(40, 40)
        Me.btn1.TabIndex = 65
        Me.btn1.Tag = "1"
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(117, 150)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(40, 40)
        Me.btn6.TabIndex = 64
        Me.btn6.Tag = "6"
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(71, 150)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(40, 40)
        Me.btn5.TabIndex = 63
        Me.btn5.Tag = "5"
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(25, 150)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(40, 40)
        Me.btn4.TabIndex = 62
        Me.btn4.Tag = "4"
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(117, 104)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(40, 40)
        Me.btn9.TabIndex = 61
        Me.btn9.Tag = "9"
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(71, 103)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(40, 40)
        Me.btn8.TabIndex = 60
        Me.btn8.Tag = "8"
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(25, 103)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(40, 40)
        Me.btn7.TabIndex = 59
        Me.btn7.Tag = "7"
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'CalculadoraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(268, 395)
        Me.Controls.Add(Me.gbPanel)
        Me.Controls.Add(Me.btnOn)
        Me.KeyPreview = True
        Me.Name = "CalculadoraForm"
        Me.Text = "CALCULADORA"
        Me.gbPanel.ResumeLayout(False)
        Me.gbPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOn As Button
    Friend WithEvents gbPanel As GroupBox
    Friend WithEvents btnDividir As Button
    Friend WithEvents btnMultiplicar As Button
    Friend WithEvents btnRestar As Button
    Friend WithEvents btnSumar As Button
    Friend WithEvents btnIgual As Button
    Friend WithEvents btnLimpiarText As Button
    Friend WithEvents btnCambiarSigno As Button
    Friend WithEvents btnComa As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btnModulo As Button
    Friend WithEvents txtResultado As TextBox
End Class
