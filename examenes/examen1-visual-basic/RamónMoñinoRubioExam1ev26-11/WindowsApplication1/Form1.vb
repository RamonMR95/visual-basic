Imports System.IO
Public Class Form1
    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        Dim formAlta = New Form3
        formAlta.butGuardar.Text = "Guardar"
        formAlta.butAceptar.Visible = False
        formAlta.Show()
    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click
        Dim formAlta = New Form3
        formAlta.GroupBox1.Visible = False
        formAlta.butAceptar.Visible = True
        formAlta.butGuardar.Text = "Modificar"
        formAlta.Show()
    End Sub

    Private Sub ModificarClaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarClaveToolStripMenuItem.Click
        CambiarClaveForm.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem.Click
        LoginForm.Show()
    End Sub
End Class
