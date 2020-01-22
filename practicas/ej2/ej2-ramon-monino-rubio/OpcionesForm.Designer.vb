<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OpcionesForm
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
        Me.lblIntroducirAlumnos = New System.Windows.Forms.Label()
        Me.lblConsultarAlumno = New System.Windows.Forms.Label()
        Me.lblOrdenarArray = New System.Windows.Forms.Label()
        Me.lblListarArray = New System.Windows.Forms.Label()
        Me.lblFin = New System.Windows.Forms.Label()
        Me.lblOpcion = New System.Windows.Forms.Label()
        Me.txtOpcion = New System.Windows.Forms.TextBox()
        Me.btnEnviarOpcion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblIntroducirAlumnos
        '
        Me.lblIntroducirAlumnos.AutoSize = True
        Me.lblIntroducirAlumnos.Location = New System.Drawing.Point(68, 85)
        Me.lblIntroducirAlumnos.Name = "lblIntroducirAlumnos"
        Me.lblIntroducirAlumnos.Size = New System.Drawing.Size(108, 13)
        Me.lblIntroducirAlumnos.TabIndex = 0
        Me.lblIntroducirAlumnos.Text = "1.- Introducir alumnos"
        '
        'lblConsultarAlumno
        '
        Me.lblConsultarAlumno.AutoSize = True
        Me.lblConsultarAlumno.Location = New System.Drawing.Point(68, 121)
        Me.lblConsultarAlumno.Name = "lblConsultarAlumno"
        Me.lblConsultarAlumno.Size = New System.Drawing.Size(103, 13)
        Me.lblConsultarAlumno.TabIndex = 1
        Me.lblConsultarAlumno.Text = "2.- Consultar alumno"
        '
        'lblOrdenarArray
        '
        Me.lblOrdenarArray.AutoSize = True
        Me.lblOrdenarArray.Location = New System.Drawing.Point(68, 156)
        Me.lblOrdenarArray.Name = "lblOrdenarArray"
        Me.lblOrdenarArray.Size = New System.Drawing.Size(86, 13)
        Me.lblOrdenarArray.TabIndex = 2
        Me.lblOrdenarArray.Text = "3.- Ordenar array"
        '
        'lblListarArray
        '
        Me.lblListarArray.AutoSize = True
        Me.lblListarArray.Location = New System.Drawing.Point(68, 192)
        Me.lblListarArray.Name = "lblListarArray"
        Me.lblListarArray.Size = New System.Drawing.Size(73, 13)
        Me.lblListarArray.TabIndex = 3
        Me.lblListarArray.Text = "4.- Listar array"
        '
        'lblFin
        '
        Me.lblFin.AutoSize = True
        Me.lblFin.Location = New System.Drawing.Point(68, 230)
        Me.lblFin.Name = "lblFin"
        Me.lblFin.Size = New System.Drawing.Size(36, 13)
        Me.lblFin.TabIndex = 4
        Me.lblFin.Text = "5.- Fin"
        '
        'lblOpcion
        '
        Me.lblOpcion.AutoSize = True
        Me.lblOpcion.Location = New System.Drawing.Point(37, 332)
        Me.lblOpcion.Name = "lblOpcion"
        Me.lblOpcion.Size = New System.Drawing.Size(86, 13)
        Me.lblOpcion.TabIndex = 5
        Me.lblOpcion.Text = "Introducir opción"
        '
        'txtOpcion
        '
        Me.txtOpcion.Location = New System.Drawing.Point(129, 329)
        Me.txtOpcion.Name = "txtOpcion"
        Me.txtOpcion.Size = New System.Drawing.Size(42, 20)
        Me.txtOpcion.TabIndex = 6
        '
        'btnEnviarOpcion
        '
        Me.btnEnviarOpcion.Location = New System.Drawing.Point(187, 327)
        Me.btnEnviarOpcion.Name = "btnEnviarOpcion"
        Me.btnEnviarOpcion.Size = New System.Drawing.Size(47, 23)
        Me.btnEnviarOpcion.TabIndex = 7
        Me.btnEnviarOpcion.Text = "Enviar"
        Me.btnEnviarOpcion.UseVisualStyleBackColor = True
        '
        'OpcionesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 424)
        Me.Controls.Add(Me.btnEnviarOpcion)
        Me.Controls.Add(Me.txtOpcion)
        Me.Controls.Add(Me.lblOpcion)
        Me.Controls.Add(Me.lblFin)
        Me.Controls.Add(Me.lblListarArray)
        Me.Controls.Add(Me.lblOrdenarArray)
        Me.Controls.Add(Me.lblConsultarAlumno)
        Me.Controls.Add(Me.lblIntroducirAlumnos)
        Me.Name = "OpcionesForm"
        Me.Text = "Formulario opciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIntroducirAlumnos As Label
    Friend WithEvents lblConsultarAlumno As Label
    Friend WithEvents lblOrdenarArray As Label
    Friend WithEvents lblListarArray As Label
    Friend WithEvents lblFin As Label
    Friend WithEvents lblOpcion As Label
    Friend WithEvents txtOpcion As TextBox
    Friend WithEvents btnEnviarOpcion As Button
End Class
