<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.btnProp1 = New System.Windows.Forms.Button()
        Me.btnProp2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnProp1
        '
        Me.btnProp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProp1.Location = New System.Drawing.Point(66, 65)
        Me.btnProp1.Name = "btnProp1"
        Me.btnProp1.Size = New System.Drawing.Size(86, 23)
        Me.btnProp1.TabIndex = 0
        Me.btnProp1.Text = "Propuesta 1"
        Me.btnProp1.UseVisualStyleBackColor = True
        '
        'btnProp2
        '
        Me.btnProp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProp2.Location = New System.Drawing.Point(204, 65)
        Me.btnProp2.Name = "btnProp2"
        Me.btnProp2.Size = New System.Drawing.Size(85, 23)
        Me.btnProp2.TabIndex = 1
        Me.btnProp2.Text = "Propuesta 2"
        Me.btnProp2.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 168)
        Me.Controls.Add(Me.btnProp2)
        Me.Controls.Add(Me.btnProp1)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnProp1 As Button
    Friend WithEvents btnProp2 As Button
End Class
