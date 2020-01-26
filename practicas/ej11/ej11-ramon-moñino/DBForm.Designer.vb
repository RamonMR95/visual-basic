<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DBForm
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
        Me.btnAbrirConexion = New System.Windows.Forms.Button()
        Me.btnCerrarConexion = New System.Windows.Forms.Button()
        Me.btnDataReader = New System.Windows.Forms.Button()
        Me.btnDataAdapter = New System.Windows.Forms.Button()
        Me.btnDataSet = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAbrirConexion
        '
        Me.btnAbrirConexion.Location = New System.Drawing.Point(56, 33)
        Me.btnAbrirConexion.Name = "btnAbrirConexion"
        Me.btnAbrirConexion.Size = New System.Drawing.Size(106, 23)
        Me.btnAbrirConexion.TabIndex = 0
        Me.btnAbrirConexion.Text = "Abrir conexión"
        Me.btnAbrirConexion.UseVisualStyleBackColor = True
        '
        'btnCerrarConexion
        '
        Me.btnCerrarConexion.Location = New System.Drawing.Point(195, 32)
        Me.btnCerrarConexion.Name = "btnCerrarConexion"
        Me.btnCerrarConexion.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrarConexion.TabIndex = 1
        Me.btnCerrarConexion.Text = "Cerrar conexión"
        Me.btnCerrarConexion.UseVisualStyleBackColor = True
        '
        'btnDataReader
        '
        Me.btnDataReader.Location = New System.Drawing.Point(56, 97)
        Me.btnDataReader.Name = "btnDataReader"
        Me.btnDataReader.Size = New System.Drawing.Size(214, 23)
        Me.btnDataReader.TabIndex = 2
        Me.btnDataReader.Text = "DataReader - Leer con sentencia SQL"
        Me.btnDataReader.UseVisualStyleBackColor = True
        '
        'btnDataAdapter
        '
        Me.btnDataAdapter.Location = New System.Drawing.Point(56, 126)
        Me.btnDataAdapter.Name = "btnDataAdapter"
        Me.btnDataAdapter.Size = New System.Drawing.Size(214, 23)
        Me.btnDataAdapter.TabIndex = 3
        Me.btnDataAdapter.Text = "DataAdapter - Leer con sentencia SQL"
        Me.btnDataAdapter.UseVisualStyleBackColor = True
        '
        'btnDataSet
        '
        Me.btnDataSet.Location = New System.Drawing.Point(56, 155)
        Me.btnDataSet.Name = "btnDataSet"
        Me.btnDataSet.Size = New System.Drawing.Size(214, 23)
        Me.btnDataSet.TabIndex = 4
        Me.btnDataSet.Text = "DataSet - Actualizar datos"
        Me.btnDataSet.UseVisualStyleBackColor = True
        '
        'DBForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 215)
        Me.Controls.Add(Me.btnDataSet)
        Me.Controls.Add(Me.btnDataAdapter)
        Me.Controls.Add(Me.btnDataReader)
        Me.Controls.Add(Me.btnCerrarConexion)
        Me.Controls.Add(Me.btnAbrirConexion)
        Me.Name = "DBForm"
        Me.Text = "DBForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAbrirConexion As Button
    Friend WithEvents btnCerrarConexion As Button
    Friend WithEvents btnDataReader As Button
    Friend WithEvents btnDataAdapter As Button
    Friend WithEvents btnDataSet As Button
End Class
