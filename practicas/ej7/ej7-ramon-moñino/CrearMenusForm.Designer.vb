<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearMenusForm
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
        Me.MSMenu = New System.Windows.Forms.MenuStrip()
        Me.FondoFormularioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorFuenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GBColores = New System.Windows.Forms.GroupBox()
        Me.CBRojo = New System.Windows.Forms.CheckBox()
        Me.CBVerde = New System.Windows.Forms.CheckBox()
        Me.CBAzul = New System.Windows.Forms.CheckBox()
        Me.rtbTexto = New System.Windows.Forms.RichTextBox()
        Me.MSMenu.SuspendLayout()
        Me.GBColores.SuspendLayout()
        Me.SuspendLayout()
        '
        'MSMenu
        '
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FondoFormularioToolStripMenuItem, Me.ColorFuenteToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(317, 24)
        Me.MSMenu.TabIndex = 0
        Me.MSMenu.Text = "MenuStrip1"
        '
        'FondoFormularioToolStripMenuItem
        '
        Me.FondoFormularioToolStripMenuItem.Name = "FondoFormularioToolStripMenuItem"
        Me.FondoFormularioToolStripMenuItem.Size = New System.Drawing.Size(112, 20)
        Me.FondoFormularioToolStripMenuItem.Text = "Fondo formulario"
        '
        'ColorFuenteToolStripMenuItem
        '
        Me.ColorFuenteToolStripMenuItem.Name = "ColorFuenteToolStripMenuItem"
        Me.ColorFuenteToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.ColorFuenteToolStripMenuItem.Text = "Color fuente"
        '
        'GBColores
        '
        Me.GBColores.Controls.Add(Me.CBRojo)
        Me.GBColores.Controls.Add(Me.CBVerde)
        Me.GBColores.Controls.Add(Me.CBAzul)
        Me.GBColores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBColores.Location = New System.Drawing.Point(12, 45)
        Me.GBColores.Name = "GBColores"
        Me.GBColores.Size = New System.Drawing.Size(293, 70)
        Me.GBColores.TabIndex = 1
        Me.GBColores.TabStop = False
        Me.GBColores.Text = "Colores"
        '
        'CBRojo
        '
        Me.CBRojo.AutoSize = True
        Me.CBRojo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBRojo.Location = New System.Drawing.Point(121, 31)
        Me.CBRojo.Name = "CBRojo"
        Me.CBRojo.Size = New System.Drawing.Size(52, 17)
        Me.CBRojo.TabIndex = 4
        Me.CBRojo.Text = "Rojo"
        Me.CBRojo.UseVisualStyleBackColor = True
        '
        'CBVerde
        '
        Me.CBVerde.AutoSize = True
        Me.CBVerde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBVerde.Location = New System.Drawing.Point(58, 31)
        Me.CBVerde.Name = "CBVerde"
        Me.CBVerde.Size = New System.Drawing.Size(59, 17)
        Me.CBVerde.TabIndex = 3
        Me.CBVerde.Text = "Verde"
        Me.CBVerde.UseVisualStyleBackColor = True
        '
        'CBAzul
        '
        Me.CBAzul.AutoSize = True
        Me.CBAzul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBAzul.Location = New System.Drawing.Point(6, 31)
        Me.CBAzul.Name = "CBAzul"
        Me.CBAzul.Size = New System.Drawing.Size(50, 17)
        Me.CBAzul.TabIndex = 2
        Me.CBAzul.Text = "Azul"
        Me.CBAzul.UseVisualStyleBackColor = True
        '
        'rtbTexto
        '
        Me.rtbTexto.Location = New System.Drawing.Point(12, 147)
        Me.rtbTexto.Name = "rtbTexto"
        Me.rtbTexto.Size = New System.Drawing.Size(293, 162)
        Me.rtbTexto.TabIndex = 5
        Me.rtbTexto.Text = ""
        '
        'CrearMenusForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 407)
        Me.Controls.Add(Me.rtbTexto)
        Me.Controls.Add(Me.GBColores)
        Me.Controls.Add(Me.MSMenu)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "CrearMenusForm"
        Me.Text = "Crear Menus"
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        Me.GBColores.ResumeLayout(False)
        Me.GBColores.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents FondoFormularioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GBColores As GroupBox
    Friend WithEvents CBAzul As CheckBox
    Friend WithEvents CBRojo As CheckBox
    Friend WithEvents CBVerde As CheckBox
    Friend WithEvents ColorFuenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents rtbTexto As RichTextBox
End Class
