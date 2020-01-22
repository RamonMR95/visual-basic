Imports System.ComponentModel
Imports System.IO
Public Class WordForm
    Dim cadenaGrabar As StreamWriter
    Dim cadenaMostrar As StreamReader
    Dim hijo As HijoForm

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click, NewToolStripButton.Click
        hijo = New HijoForm()
        hijo.MdiParent = Me
        hijo.Name = "nuevo-documento"
        hijo.Text = "nuevo-documento"

        If contador > 0 Then
            hijo.Name = "nuevo-documento" & contador
            hijo.Text = "nuevo-documento" & contador
        End If

        hijo.Show()
        contador += 1
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click, SaveToolStripButton.Click
        If Me.ActiveMdiChild IsNot Nothing Then
            Me.ActiveMdiChild.Text = hijo.Text.Replace("*", "")

            If getMdiChildActual.isNuevo Then
                GuardarComoToolStripMenuItem.PerformClick()
            Else
                cadenaGrabar = New StreamWriter(getMdiChildActual.ruta)
                cadenaGrabar.Write(getMdiChildActual.txtHijo.Text)
                getMdiChildActual.isGuardado = True
                getMdiChildActual.isNuevo = False
                cadenaGrabar.Close()
            End If
        End If
    End Sub

    Private Sub GuardarComoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarComoToolStripMenuItem.Click
        If Me.ActiveMdiChild IsNot Nothing Then
            Me.ActiveMdiChild.Text = hijo.Text.Replace("*", "")

            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            saveFileDialog.FileName = Me.ActiveMdiChild.Name
            saveFileDialog.DefaultExt = ".txt"
            saveFileDialog.RestoreDirectory = True

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim streamWriter As New StreamWriter(saveFileDialog.FileName)
                Dim urlPlusfilename() = saveFileDialog.FileName.Split("\")
                Dim filename As String = urlPlusfilename(urlPlusfilename.Length - 1)
                getMdiChildActual.Text = filename
                getMdiChildActual.ruta = saveFileDialog.FileName
                getMdiChildActual.Name = filename
                streamWriter.Write(getMdiChildActual.txtHijo.Text)
                streamWriter.Close()
                getMdiChildActual.isGuardado = True
                getMdiChildActual.isNuevo = False
            End If
        End If
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim dlgo As New OpenFileDialog()
        dlgo.Title = "Seleccione una Fichero..."
        dlgo.FileName = "Documento"
        dlgo.DefaultExt = ".txt"
        dlgo.Filter = "*Text documents (.txt)|*.txt"

        Dim result As DialogResult = dlgo.ShowDialog()

        If result = DialogResult.OK Then
            Dim pathFileName As String = dlgo.FileName
            Dim fileName As String = dlgo.SafeFileName
            cadenaMostrar = New StreamReader(pathFileName)
            hijo = New HijoForm()
            hijo.txtHijo.Text = cadenaMostrar.ReadToEnd
            hijo.MdiParent = Me
            hijo.Name = fileName
            hijo.ruta = pathFileName
            hijo.Text = fileName
            hijo.isNuevo = False
            hijo.isGuardado = True
            hijo.Show()
            cadenaMostrar.Close()
        End If
    End Sub

    Private Sub Copiar(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click, CopyToolStripButton.Click
        If Me.ActiveMdiChild IsNot Nothing Then
            getMdiChildActual.txtHijo.Copy()
        End If
    End Sub

    Private Sub Cortar(sender As Object, e As EventArgs) Handles CortarToolStripMenuItem.Click, CutToolStripButton.Click
        If Me.ActiveMdiChild IsNot Nothing Then
            getMdiChildActual.txtHijo.Cut()
        End If
    End Sub

    Private Sub Pegar(sender As Object, e As EventArgs) Handles PegarToolStripMenuItem.Click, PasteToolStripButton.Click
        If Me.ActiveMdiChild IsNot Nothing Then
            getMdiChildActual.txtHijo.Paste()
        End If
    End Sub

    Private Sub SeleccionarTodo(sender As Object, e As EventArgs) Handles SeleccionarTodoToolStripMenuItem.Click
        If Me.ActiveMdiChild IsNot Nothing Then
            getMdiChildActual().txtHijo.SelectAll()
        End If
    End Sub

    Private Sub RehacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RehacerToolStripMenuItem.Click
        If Me.ActiveMdiChild IsNot Nothing Then
            getMdiChildActual().txtHijo.Redo()
        End If
    End Sub

    Private Sub DeshacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeshacerToolStripMenuItem.Click
        If Me.ActiveMdiChild IsNot Nothing Then
            getMdiChildActual().txtHijo.Undo()
        End If
    End Sub

    Private Sub ColorTextoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorTextoToolStripMenuItem.Click
        If Me.ActiveMdiChild IsNot Nothing Then
            Dim dlgC As New ColorDialog()
            Dim result As DialogResult
            result = dlgC.ShowDialog()

            If result = DialogResult.OK Then
                getMdiChildActual.txtHijo.SelectionColor = dlgC.Color
            End If
        End If
    End Sub

    Private Sub ColorFondoTextoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorFondoTextoToolStripMenuItem.Click
        If Me.ActiveMdiChild IsNot Nothing Then
            Dim dlgC As New ColorDialog()
            Dim result As DialogResult
            result = dlgC.ShowDialog()

            If result = DialogResult.OK Then
                getMdiChildActual.txtHijo.SelectionBackColor = dlgC.Color
            End If
        End If
    End Sub

    Private Sub ColorFondoFormularioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorFondoFormularioToolStripMenuItem.Click
        If Me.ActiveMdiChild IsNot Nothing Then
            Dim dlgC As New ColorDialog()
            Dim result As DialogResult
            result = dlgC.ShowDialog()

            If result = DialogResult.OK Then
                getMdiChildActual.txtHijo.BackColor = dlgC.Color
            End If
        End If

    End Sub
    Private Sub FormatoTextoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormatoTextoToolStripMenuItem.Click
        If Me.ActiveMdiChild IsNot Nothing Then
            Dim dlgF As New FontDialog()
            Dim result As DialogResult
            result = dlgF.ShowDialog()

            If result = DialogResult.OK Then
                getMdiChildActual.txtHijo.SelectionFont = dlgF.Font
            End If
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub CascadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadaToolStripMenuItem.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade)
    End Sub

    Private Sub HorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorizontalToolStripMenuItem.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal)
    End Sub

    Private Sub VerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerticalToolStripMenuItem.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical)
    End Sub

    Private Sub HelpToolStripButton_Click(sender As Object, e As EventArgs) Handles HelpToolStripButton.Click
        Process.Start("https://docs.microsoft.com/es-es/dotnet/?view=netframework-4.8")
    End Sub

    Private Sub WordForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If getMdiChildActual() IsNot Nothing Then
            getMdiChildActual.Close()
        End If
    End Sub

    Private Function getMdiChildActual() As HijoForm
        Dim hijoActual As HijoForm
        hijoActual = Me.ActiveMdiChild
        Return hijoActual
    End Function
End Class
