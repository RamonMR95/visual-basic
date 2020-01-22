<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArrastrarSoltarForm
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
        Me.lb1 = New System.Windows.Forms.ListBox()
        Me.lb2 = New System.Windows.Forms.ListBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lb1
        '
        Me.lb1.AllowDrop = True
        Me.lb1.FormattingEnabled = True
        Me.lb1.Items.AddRange(New Object() {"aa", "bb", "cc", "dd", "ee", "ff"})
        Me.lb1.Location = New System.Drawing.Point(29, 38)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(70, 173)
        Me.lb1.TabIndex = 0
        '
        'lb2
        '
        Me.lb2.AllowDrop = True
        Me.lb2.FormattingEnabled = True
        Me.lb2.Items.AddRange(New Object() {"11", "22", "33", "44", "55"})
        Me.lb2.Location = New System.Drawing.Point(202, 38)
        Me.lb2.Name = "lb2"
        Me.lb2.Size = New System.Drawing.Size(70, 173)
        Me.lb2.TabIndex = 1
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(135, 38)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(30, 30)
        Me.btn1.TabIndex = 2
        Me.btn1.Text = ">"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(135, 85)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(30, 30)
        Me.btn2.TabIndex = 3
        Me.btn2.Text = ">>"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(135, 136)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(30, 30)
        Me.btn3.TabIndex = 4
        Me.btn3.Text = "<<"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(135, 181)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(30, 30)
        Me.btn4.TabIndex = 5
        Me.btn4.Text = "<"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'ArrastrarSoltarForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 299)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.lb2)
        Me.Controls.Add(Me.lb1)
        Me.Name = "ArrastrarSoltarForm"
        Me.Text = "Arrastrar y Soltar"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lb1 As ListBox
    Friend WithEvents lb2 As ListBox
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
End Class
