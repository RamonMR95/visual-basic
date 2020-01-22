<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelAreaCuadrado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PanelAreaCuadrado))
        Me.btnVolverCuadrado = New System.Windows.Forms.Button()
        Me.btnAreaCalcularCuadrado = New System.Windows.Forms.Button()
        Me.lblAreaCuadrado = New System.Windows.Forms.Label()
        Me.txtAreaCuadrado = New System.Windows.Forms.TextBox()
        Me.lblLado1Cuadrado = New System.Windows.Forms.Label()
        Me.txtLado1Cuadrado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnVolverCuadrado
        '
        Me.btnVolverCuadrado.Location = New System.Drawing.Point(236, 150)
        Me.btnVolverCuadrado.Name = "btnVolverCuadrado"
        Me.btnVolverCuadrado.Size = New System.Drawing.Size(75, 23)
        Me.btnVolverCuadrado.TabIndex = 0
        Me.btnVolverCuadrado.Text = "Volver"
        Me.btnVolverCuadrado.UseVisualStyleBackColor = True
        '
        'btnAreaCalcularCuadrado
        '
        Me.btnAreaCalcularCuadrado.Location = New System.Drawing.Point(78, 140)
        Me.btnAreaCalcularCuadrado.Name = "btnAreaCalcularCuadrado"
        Me.btnAreaCalcularCuadrado.Size = New System.Drawing.Size(75, 23)
        Me.btnAreaCalcularCuadrado.TabIndex = 16
        Me.btnAreaCalcularCuadrado.Text = "Calcular"
        Me.btnAreaCalcularCuadrado.UseVisualStyleBackColor = True
        '
        'lblAreaCuadrado
        '
        Me.lblAreaCuadrado.AutoSize = True
        Me.lblAreaCuadrado.Location = New System.Drawing.Point(18, 93)
        Me.lblAreaCuadrado.Name = "lblAreaCuadrado"
        Me.lblAreaCuadrado.Size = New System.Drawing.Size(29, 13)
        Me.lblAreaCuadrado.TabIndex = 15
        Me.lblAreaCuadrado.Text = "Area"
        '
        'txtAreaCuadrado
        '
        Me.txtAreaCuadrado.Enabled = False
        Me.txtAreaCuadrado.Location = New System.Drawing.Point(78, 86)
        Me.txtAreaCuadrado.Name = "txtAreaCuadrado"
        Me.txtAreaCuadrado.Size = New System.Drawing.Size(55, 20)
        Me.txtAreaCuadrado.TabIndex = 14
        '
        'lblLado1Cuadrado
        '
        Me.lblLado1Cuadrado.AutoSize = True
        Me.lblLado1Cuadrado.Location = New System.Drawing.Point(18, 48)
        Me.lblLado1Cuadrado.Name = "lblLado1Cuadrado"
        Me.lblLado1Cuadrado.Size = New System.Drawing.Size(40, 13)
        Me.lblLado1Cuadrado.TabIndex = 12
        Me.lblLado1Cuadrado.Text = "Lado 1"
        '
        'txtLado1Cuadrado
        '
        Me.txtLado1Cuadrado.Location = New System.Drawing.Point(78, 48)
        Me.txtLado1Cuadrado.Name = "txtLado1Cuadrado"
        Me.txtLado1Cuadrado.Size = New System.Drawing.Size(55, 20)
        Me.txtLado1Cuadrado.TabIndex = 11
        '
        'PanelAreaCuadrado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 195)
        Me.Controls.Add(Me.btnAreaCalcularCuadrado)
        Me.Controls.Add(Me.lblAreaCuadrado)
        Me.Controls.Add(Me.txtAreaCuadrado)
        Me.Controls.Add(Me.lblLado1Cuadrado)
        Me.Controls.Add(Me.txtLado1Cuadrado)
        Me.Controls.Add(Me.btnVolverCuadrado)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PanelAreaCuadrado"
        Me.Text = "Area cuadrado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVolverCuadrado As Button
    Friend WithEvents btnAreaCalcularCuadrado As Button
    Friend WithEvents lblAreaCuadrado As Label
    Friend WithEvents txtAreaCuadrado As TextBox
    Friend WithEvents lblLado1Cuadrado As Label
    Friend WithEvents txtLado1Cuadrado As TextBox
End Class
