<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelAreaTriangulo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PanelAreaTriangulo))
        Me.lblLado2Triangulo = New System.Windows.Forms.Label()
        Me.txtLado2Triangulo = New System.Windows.Forms.TextBox()
        Me.btnAreaCalcularTriangulo = New System.Windows.Forms.Button()
        Me.lblAreaTriangulo = New System.Windows.Forms.Label()
        Me.txtAreaTriangulo = New System.Windows.Forms.TextBox()
        Me.lblLado1Triangulo = New System.Windows.Forms.Label()
        Me.txtLado1Triangulo = New System.Windows.Forms.TextBox()
        Me.btnVolverTriangulo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblLado2Triangulo
        '
        Me.lblLado2Triangulo.AutoSize = True
        Me.lblLado2Triangulo.Location = New System.Drawing.Point(55, 78)
        Me.lblLado2Triangulo.Name = "lblLado2Triangulo"
        Me.lblLado2Triangulo.Size = New System.Drawing.Size(40, 13)
        Me.lblLado2Triangulo.TabIndex = 32
        Me.lblLado2Triangulo.Text = "Lado 2"
        '
        'txtLado2Triangulo
        '
        Me.txtLado2Triangulo.Location = New System.Drawing.Point(115, 75)
        Me.txtLado2Triangulo.Name = "txtLado2Triangulo"
        Me.txtLado2Triangulo.Size = New System.Drawing.Size(55, 20)
        Me.txtLado2Triangulo.TabIndex = 31
        '
        'btnAreaCalcularTriangulo
        '
        Me.btnAreaCalcularTriangulo.Location = New System.Drawing.Point(112, 186)
        Me.btnAreaCalcularTriangulo.Name = "btnAreaCalcularTriangulo"
        Me.btnAreaCalcularTriangulo.Size = New System.Drawing.Size(75, 24)
        Me.btnAreaCalcularTriangulo.TabIndex = 30
        Me.btnAreaCalcularTriangulo.Text = "Calcular"
        Me.btnAreaCalcularTriangulo.UseVisualStyleBackColor = True
        '
        'lblAreaTriangulo
        '
        Me.lblAreaTriangulo.AutoSize = True
        Me.lblAreaTriangulo.Location = New System.Drawing.Point(55, 135)
        Me.lblAreaTriangulo.Name = "lblAreaTriangulo"
        Me.lblAreaTriangulo.Size = New System.Drawing.Size(29, 13)
        Me.lblAreaTriangulo.TabIndex = 29
        Me.lblAreaTriangulo.Text = "Area"
        '
        'txtAreaTriangulo
        '
        Me.txtAreaTriangulo.Enabled = False
        Me.txtAreaTriangulo.Location = New System.Drawing.Point(112, 132)
        Me.txtAreaTriangulo.Name = "txtAreaTriangulo"
        Me.txtAreaTriangulo.Size = New System.Drawing.Size(58, 20)
        Me.txtAreaTriangulo.TabIndex = 28
        '
        'lblLado1Triangulo
        '
        Me.lblLado1Triangulo.AutoSize = True
        Me.lblLado1Triangulo.Location = New System.Drawing.Point(55, 36)
        Me.lblLado1Triangulo.Name = "lblLado1Triangulo"
        Me.lblLado1Triangulo.Size = New System.Drawing.Size(40, 13)
        Me.lblLado1Triangulo.TabIndex = 27
        Me.lblLado1Triangulo.Text = "Lado 1"
        '
        'txtLado1Triangulo
        '
        Me.txtLado1Triangulo.Location = New System.Drawing.Point(115, 33)
        Me.txtLado1Triangulo.Name = "txtLado1Triangulo"
        Me.txtLado1Triangulo.Size = New System.Drawing.Size(55, 20)
        Me.txtLado1Triangulo.TabIndex = 26
        '
        'btnVolverTriangulo
        '
        Me.btnVolverTriangulo.Location = New System.Drawing.Point(290, 218)
        Me.btnVolverTriangulo.Name = "btnVolverTriangulo"
        Me.btnVolverTriangulo.Size = New System.Drawing.Size(75, 24)
        Me.btnVolverTriangulo.TabIndex = 25
        Me.btnVolverTriangulo.Text = "Volver"
        Me.btnVolverTriangulo.UseVisualStyleBackColor = True
        '
        'PanelAreaTriangulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 276)
        Me.Controls.Add(Me.lblLado2Triangulo)
        Me.Controls.Add(Me.txtLado2Triangulo)
        Me.Controls.Add(Me.btnAreaCalcularTriangulo)
        Me.Controls.Add(Me.lblAreaTriangulo)
        Me.Controls.Add(Me.txtAreaTriangulo)
        Me.Controls.Add(Me.lblLado1Triangulo)
        Me.Controls.Add(Me.txtLado1Triangulo)
        Me.Controls.Add(Me.btnVolverTriangulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PanelAreaTriangulo"
        Me.Text = "Area triangulo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLado2Triangulo As Label
    Friend WithEvents txtLado2Triangulo As TextBox
    Friend WithEvents btnAreaCalcularTriangulo As Button
    Friend WithEvents lblAreaTriangulo As Label
    Friend WithEvents txtAreaTriangulo As TextBox
    Friend WithEvents lblLado1Triangulo As Label
    Friend WithEvents txtLado1Triangulo As TextBox
    Friend WithEvents btnVolverTriangulo As Button
End Class
