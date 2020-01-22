<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelAreas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAreaCuadrado = New System.Windows.Forms.Button()
        Me.btnAreaTriangulo = New System.Windows.Forms.Button()
        Me.btnAreaRectangulo = New System.Windows.Forms.Button()
        Me.btnVolverArea = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAreaCuadrado
        '
        Me.btnAreaCuadrado.Location = New System.Drawing.Point(59, 64)
        Me.btnAreaCuadrado.Name = "btnAreaCuadrado"
        Me.btnAreaCuadrado.Size = New System.Drawing.Size(75, 23)
        Me.btnAreaCuadrado.TabIndex = 0
        Me.btnAreaCuadrado.Text = "Cuadrado"
        Me.btnAreaCuadrado.UseVisualStyleBackColor = True
        '
        'btnAreaTriangulo
        '
        Me.btnAreaTriangulo.Location = New System.Drawing.Point(149, 64)
        Me.btnAreaTriangulo.Name = "btnAreaTriangulo"
        Me.btnAreaTriangulo.Size = New System.Drawing.Size(75, 23)
        Me.btnAreaTriangulo.TabIndex = 1
        Me.btnAreaTriangulo.Text = "Triangulo"
        Me.btnAreaTriangulo.UseVisualStyleBackColor = True
        '
        'btnAreaRectangulo
        '
        Me.btnAreaRectangulo.Location = New System.Drawing.Point(241, 64)
        Me.btnAreaRectangulo.Name = "btnAreaRectangulo"
        Me.btnAreaRectangulo.Size = New System.Drawing.Size(75, 23)
        Me.btnAreaRectangulo.TabIndex = 2
        Me.btnAreaRectangulo.Text = "Rectangulo"
        Me.btnAreaRectangulo.UseVisualStyleBackColor = True
        '
        'btnVolverArea
        '
        Me.btnVolverArea.Location = New System.Drawing.Point(241, 142)
        Me.btnVolverArea.Name = "btnVolverArea"
        Me.btnVolverArea.Size = New System.Drawing.Size(75, 23)
        Me.btnVolverArea.TabIndex = 10
        Me.btnVolverArea.Text = "Volver"
        Me.btnVolverArea.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(160, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Area"
        '
        'PanelAreas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 204)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnVolverArea)
        Me.Controls.Add(Me.btnAreaRectangulo)
        Me.Controls.Add(Me.btnAreaTriangulo)
        Me.Controls.Add(Me.btnAreaCuadrado)
        Me.Name = "PanelAreas"
        Me.Text = "Area figuras geometricas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAreaCuadrado As Button
    Friend WithEvents btnAreaTriangulo As Button
    Friend WithEvents btnAreaRectangulo As Button
    Friend WithEvents btnVolverArea As Button
    Friend WithEvents Label1 As Label
End Class
