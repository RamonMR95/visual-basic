<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelAreaRectangulo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PanelAreaRectangulo))
        Me.btnAreaCalcularRectangulo = New System.Windows.Forms.Button()
        Me.lblAreaRectangulo = New System.Windows.Forms.Label()
        Me.txtAreaRectangulo = New System.Windows.Forms.TextBox()
        Me.lblLado1Rectangulo = New System.Windows.Forms.Label()
        Me.txtLado1Rectangulo = New System.Windows.Forms.TextBox()
        Me.btnVolverRectangulo = New System.Windows.Forms.Button()
        Me.lblLado2Rectangulo = New System.Windows.Forms.Label()
        Me.txtLado2Rectangulo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAreaCalcularRectangulo
        '
        Me.btnAreaCalcularRectangulo.Location = New System.Drawing.Point(105, 166)
        Me.btnAreaCalcularRectangulo.Name = "btnAreaCalcularRectangulo"
        Me.btnAreaCalcularRectangulo.Size = New System.Drawing.Size(75, 24)
        Me.btnAreaCalcularRectangulo.TabIndex = 22
        Me.btnAreaCalcularRectangulo.Text = "Calcular"
        Me.btnAreaCalcularRectangulo.UseVisualStyleBackColor = True
        '
        'lblAreaRectangulo
        '
        Me.lblAreaRectangulo.AutoSize = True
        Me.lblAreaRectangulo.Location = New System.Drawing.Point(34, 126)
        Me.lblAreaRectangulo.Name = "lblAreaRectangulo"
        Me.lblAreaRectangulo.Size = New System.Drawing.Size(29, 13)
        Me.lblAreaRectangulo.TabIndex = 21
        Me.lblAreaRectangulo.Text = "Area"
        '
        'txtAreaRectangulo
        '
        Me.txtAreaRectangulo.Enabled = False
        Me.txtAreaRectangulo.Location = New System.Drawing.Point(94, 123)
        Me.txtAreaRectangulo.Name = "txtAreaRectangulo"
        Me.txtAreaRectangulo.Size = New System.Drawing.Size(58, 20)
        Me.txtAreaRectangulo.TabIndex = 20
        '
        'lblLado1Rectangulo
        '
        Me.lblLado1Rectangulo.AutoSize = True
        Me.lblLado1Rectangulo.Location = New System.Drawing.Point(34, 33)
        Me.lblLado1Rectangulo.Name = "lblLado1Rectangulo"
        Me.lblLado1Rectangulo.Size = New System.Drawing.Size(40, 13)
        Me.lblLado1Rectangulo.TabIndex = 19
        Me.lblLado1Rectangulo.Text = "Lado 1"
        '
        'txtLado1Rectangulo
        '
        Me.txtLado1Rectangulo.Location = New System.Drawing.Point(94, 33)
        Me.txtLado1Rectangulo.Name = "txtLado1Rectangulo"
        Me.txtLado1Rectangulo.Size = New System.Drawing.Size(55, 20)
        Me.txtLado1Rectangulo.TabIndex = 18
        '
        'btnVolverRectangulo
        '
        Me.btnVolverRectangulo.Location = New System.Drawing.Point(317, 197)
        Me.btnVolverRectangulo.Name = "btnVolverRectangulo"
        Me.btnVolverRectangulo.Size = New System.Drawing.Size(75, 24)
        Me.btnVolverRectangulo.TabIndex = 17
        Me.btnVolverRectangulo.Text = "Volver"
        Me.btnVolverRectangulo.UseVisualStyleBackColor = True
        '
        'lblLado2Rectangulo
        '
        Me.lblLado2Rectangulo.AutoSize = True
        Me.lblLado2Rectangulo.Location = New System.Drawing.Point(34, 70)
        Me.lblLado2Rectangulo.Name = "lblLado2Rectangulo"
        Me.lblLado2Rectangulo.Size = New System.Drawing.Size(40, 13)
        Me.lblLado2Rectangulo.TabIndex = 24
        Me.lblLado2Rectangulo.Text = "Lado 2"
        '
        'txtLado2Rectangulo
        '
        Me.txtLado2Rectangulo.Location = New System.Drawing.Point(94, 70)
        Me.txtLado2Rectangulo.Name = "txtLado2Rectangulo"
        Me.txtLado2Rectangulo.Size = New System.Drawing.Size(55, 20)
        Me.txtLado2Rectangulo.TabIndex = 23
        '
        'PanelAreaRectangulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 263)
        Me.Controls.Add(Me.lblLado2Rectangulo)
        Me.Controls.Add(Me.txtLado2Rectangulo)
        Me.Controls.Add(Me.btnAreaCalcularRectangulo)
        Me.Controls.Add(Me.lblAreaRectangulo)
        Me.Controls.Add(Me.txtAreaRectangulo)
        Me.Controls.Add(Me.lblLado1Rectangulo)
        Me.Controls.Add(Me.txtLado1Rectangulo)
        Me.Controls.Add(Me.btnVolverRectangulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PanelAreaRectangulo"
        Me.Text = "Area rectangulo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAreaCalcularRectangulo As Button
    Friend WithEvents lblAreaRectangulo As Label
    Friend WithEvents txtAreaRectangulo As TextBox
    Friend WithEvents lblLado1Rectangulo As Label
    Friend WithEvents txtLado1Rectangulo As TextBox
    Friend WithEvents btnVolverRectangulo As Button
    Friend WithEvents lblLado2Rectangulo As Label
    Friend WithEvents txtLado2Rectangulo As TextBox
End Class
