<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AlbaranForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.rtbAlbaran = New System.Windows.Forms.RichTextBox()
        Me.btnAlbaranGenerar = New System.Windows.Forms.Button()
        Me.btnAlbaranAbrir = New System.Windows.Forms.Button()
        Me.txtNAlbaran = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscarAlbaran = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtbAlbaran
        '
        Me.rtbAlbaran.Location = New System.Drawing.Point(-1, 41)
        Me.rtbAlbaran.Name = "rtbAlbaran"
        Me.rtbAlbaran.Size = New System.Drawing.Size(613, 196)
        Me.rtbAlbaran.TabIndex = 0
        Me.rtbAlbaran.Text = ""
        '
        'btnAlbaranGenerar
        '
        Me.btnAlbaranGenerar.Location = New System.Drawing.Point(47, 253)
        Me.btnAlbaranGenerar.Name = "btnAlbaranGenerar"
        Me.btnAlbaranGenerar.Size = New System.Drawing.Size(75, 23)
        Me.btnAlbaranGenerar.TabIndex = 1
        Me.btnAlbaranGenerar.Text = "Generar"
        Me.btnAlbaranGenerar.UseVisualStyleBackColor = True
        '
        'btnAlbaranAbrir
        '
        Me.btnAlbaranAbrir.Location = New System.Drawing.Point(147, 253)
        Me.btnAlbaranAbrir.Name = "btnAlbaranAbrir"
        Me.btnAlbaranAbrir.Size = New System.Drawing.Size(75, 23)
        Me.btnAlbaranAbrir.TabIndex = 2
        Me.btnAlbaranAbrir.Text = "Abrir"
        Me.btnAlbaranAbrir.UseVisualStyleBackColor = True
        '
        'txtNAlbaran
        '
        Me.txtNAlbaran.Location = New System.Drawing.Point(97, 12)
        Me.txtNAlbaran.Name = "txtNAlbaran"
        Me.txtNAlbaran.Size = New System.Drawing.Size(100, 20)
        Me.txtNAlbaran.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nº Albarán"
        '
        'btnBuscarAlbaran
        '
        Me.btnBuscarAlbaran.Location = New System.Drawing.Point(220, 10)
        Me.btnBuscarAlbaran.Name = "btnBuscarAlbaran"
        Me.btnBuscarAlbaran.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarAlbaran.TabIndex = 5
        Me.btnBuscarAlbaran.Text = "Buscar"
        Me.btnBuscarAlbaran.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(529, 253)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'AlbaranForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 284)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBuscarAlbaran)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNAlbaran)
        Me.Controls.Add(Me.btnAlbaranAbrir)
        Me.Controls.Add(Me.btnAlbaranGenerar)
        Me.Controls.Add(Me.rtbAlbaran)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "AlbaranForm"
        Me.Text = "Albaran"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rtbAlbaran As RichTextBox
    Friend WithEvents btnAlbaranGenerar As Button
    Friend WithEvents btnAlbaranAbrir As Button
    Friend WithEvents txtNAlbaran As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscarAlbaran As Button
    Friend WithEvents btnSalir As Button
End Class
