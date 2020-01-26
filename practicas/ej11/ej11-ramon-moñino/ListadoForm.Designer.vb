<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoForm
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
        Me.btnSalirListado = New System.Windows.Forms.Button()
        Me.DataGridViewDatos = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalirListado
        '
        Me.btnSalirListado.Location = New System.Drawing.Point(544, 378)
        Me.btnSalirListado.Name = "btnSalirListado"
        Me.btnSalirListado.Size = New System.Drawing.Size(75, 23)
        Me.btnSalirListado.TabIndex = 1
        Me.btnSalirListado.Text = "Salir"
        Me.btnSalirListado.UseVisualStyleBackColor = True
        '
        'DataGridViewDatos
        '
        Me.DataGridViewDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDatos.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewDatos.Name = "DataGridViewDatos"
        Me.DataGridViewDatos.Size = New System.Drawing.Size(631, 362)
        Me.DataGridViewDatos.TabIndex = 2
        '
        'ListadoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 413)
        Me.Controls.Add(Me.DataGridViewDatos)
        Me.Controls.Add(Me.btnSalirListado)
        Me.Name = "ListadoForm"
        Me.Text = "Listado"
        CType(Me.DataGridViewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSalirListado As Button
    Friend WithEvents DataGridViewDatos As DataGridView
End Class
