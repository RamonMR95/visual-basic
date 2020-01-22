Imports System.ComponentModel

Public Class HijoForm
    Public isGuardado As Boolean = False
    Public isNuevo As Boolean = True
    Public ruta As String
    Private Sub HijoForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtHijo.ContextMenuStrip = ContextMenuStrip1
        txtHijo.SelectionStart = txtHijo.Text.Length
        txtHijo.SelectionLength = 0
    End Sub
    Private Sub HijoForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not isGuardado Then
            If Not isNuevo Then
                guardarClosing()
            Else
                If txtHijo.Text <> "" Then
                    WordForm.GuardarComoToolStripMenuItem.PerformClick()
                End If
            End If
        End If
    End Sub

    Private Sub guardarClosing()
        Dim result As DialogResult = MessageBox.Show("¿Desea guardarlos cambios?", “Guardar?”, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If result = DialogResult.Yes Then
            WordForm.GuardarToolStripMenuItem.PerformClick()
        End If
    End Sub

    Private Sub Copiar(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        txtHijo.Copy()
    End Sub

    Private Sub Cortar(sender As Object, e As EventArgs) Handles CortarToolStripMenuItem.Click
        txtHijo.Cut()
    End Sub

    Private Sub Pegar(sender As Object, e As EventArgs) Handles PegarToolStripMenuItem.Click
        txtHijo.Paste()
    End Sub

    Private Sub SeleccionarTodo(sender As Object, e As EventArgs) Handles SeleccionarTodoToolStripMenuItem.Click
        txtHijo.SelectAll()
    End Sub

    Private Sub RehacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RehacerToolStripMenuItem.Click
        txtHijo.Redo()
    End Sub

    Private Sub DeshacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeshacerToolStripMenuItem.Click
        txtHijo.Undo()
    End Sub

    Private Sub txtHijo_TextChanged(sender As Object, e As EventArgs) Handles txtHijo.TextChanged
        isGuardado = False
        If Not Me.Text.Contains("*") Then
            Me.Text &= "*"
        End If
    End Sub
End Class