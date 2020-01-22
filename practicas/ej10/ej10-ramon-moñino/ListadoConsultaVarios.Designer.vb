<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoConsultaVarios
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
        Me.rtbListadoConsulta = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'rtbListadoConsulta
        '
        Me.rtbListadoConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbListadoConsulta.Location = New System.Drawing.Point(0, 0)
        Me.rtbListadoConsulta.Name = "rtbListadoConsulta"
        Me.rtbListadoConsulta.Size = New System.Drawing.Size(801, 449)
        Me.rtbListadoConsulta.TabIndex = 0
        Me.rtbListadoConsulta.Text = ""
        '
        'ListadoConsultaVarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.rtbListadoConsulta)
        Me.Name = "ListadoConsultaVarios"
        Me.Text = "Consulta"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rtbListadoConsulta As RichTextBox
End Class
