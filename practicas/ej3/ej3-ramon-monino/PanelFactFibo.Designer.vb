<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelFactFibo
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
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.btnCalcularFactorial = New System.Windows.Forms.Button()
        Me.btnCalcularFibo = New System.Windows.Forms.Button()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.txtExpositor = New System.Windows.Forms.RichTextBox()
        Me.btnVolverFactFibo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(72, 48)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(75, 20)
        Me.txtNumero.TabIndex = 0
        '
        'btnCalcularFactorial
        '
        Me.btnCalcularFactorial.Location = New System.Drawing.Point(241, 271)
        Me.btnCalcularFactorial.Name = "btnCalcularFactorial"
        Me.btnCalcularFactorial.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcularFactorial.TabIndex = 1
        Me.btnCalcularFactorial.Text = "Factorial"
        Me.btnCalcularFactorial.UseVisualStyleBackColor = True
        '
        'btnCalcularFibo
        '
        Me.btnCalcularFibo.Location = New System.Drawing.Point(334, 271)
        Me.btnCalcularFibo.Name = "btnCalcularFibo"
        Me.btnCalcularFibo.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcularFibo.TabIndex = 2
        Me.btnCalcularFibo.Text = "Fibonacci"
        Me.btnCalcularFibo.UseVisualStyleBackColor = True
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(22, 51)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(44, 13)
        Me.lblNumero.TabIndex = 3
        Me.lblNumero.Text = "Numero"
        '
        'txtExpositor
        '
        Me.txtExpositor.Location = New System.Drawing.Point(241, 48)
        Me.txtExpositor.Name = "txtExpositor"
        Me.txtExpositor.Size = New System.Drawing.Size(311, 185)
        Me.txtExpositor.TabIndex = 4
        Me.txtExpositor.Text = ""
        '
        'btnVolverFactFibo
        '
        Me.btnVolverFactFibo.Location = New System.Drawing.Point(490, 297)
        Me.btnVolverFactFibo.Name = "btnVolverFactFibo"
        Me.btnVolverFactFibo.Size = New System.Drawing.Size(75, 23)
        Me.btnVolverFactFibo.TabIndex = 5
        Me.btnVolverFactFibo.Text = "Volver"
        Me.btnVolverFactFibo.UseVisualStyleBackColor = True
        '
        'PanelFactFibo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 342)
        Me.Controls.Add(Me.btnVolverFactFibo)
        Me.Controls.Add(Me.txtExpositor)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.btnCalcularFibo)
        Me.Controls.Add(Me.btnCalcularFactorial)
        Me.Controls.Add(Me.txtNumero)
        Me.Name = "PanelFactFibo"
        Me.Text = "Factorial y Fibonacci"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNumero As TextBox
    Friend WithEvents btnCalcularFactorial As Button
    Friend WithEvents btnCalcularFibo As Button
    Friend WithEvents lblNumero As Label
    Friend WithEvents txtExpositor As RichTextBox
    Friend WithEvents btnVolverFactFibo As Button
End Class
