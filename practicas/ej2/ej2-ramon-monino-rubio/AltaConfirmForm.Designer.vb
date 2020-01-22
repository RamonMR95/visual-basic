<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaConfirmForm
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
        Me.lblPreguntaAlta = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnNO = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPreguntaAlta
        '
        Me.lblPreguntaAlta.AutoSize = True
        Me.lblPreguntaAlta.Location = New System.Drawing.Point(112, 69)
        Me.lblPreguntaAlta.Name = "lblPreguntaAlta"
        Me.lblPreguntaAlta.Size = New System.Drawing.Size(176, 13)
        Me.lblPreguntaAlta.TabIndex = 0
        Me.lblPreguntaAlta.Text = "¿Quiere dar de alta a más alumnos?"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(115, 115)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "Si"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnNO
        '
        Me.btnNO.Location = New System.Drawing.Point(213, 115)
        Me.btnNO.Name = "btnNO"
        Me.btnNO.Size = New System.Drawing.Size(75, 23)
        Me.btnNO.TabIndex = 2
        Me.btnNO.Text = "No"
        Me.btnNO.UseVisualStyleBackColor = True
        '
        'AltaConfirmForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 213)
        Me.Controls.Add(Me.btnNO)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblPreguntaAlta)
        Me.Name = "AltaConfirmForm"
        Me.Text = "Alta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPreguntaAlta As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents btnNO As Button
End Class
