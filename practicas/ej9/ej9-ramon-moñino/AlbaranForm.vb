Imports System.IO

Public Class AlbaranForm
    Public cadenaGrabar As StreamWriter
    Public cadenaMostrar As StreamReader
    Public ruta As String

    Private Sub btnBuscarAlbaran_Click(sender As Object, e As EventArgs) Handles btnBuscarAlbaran.Click
        Try
            If albaranes.Contains(CInt(txtNAlbaran.Text)) Then
                rtbAlbaran.Text = albaranes(txtNAlbaran.Text).mostrarDatos()
            Else
                rtbAlbaran.Text = "No existe ningun albaran con ese número"
            End If
        Catch ex As Exception
            MsgBox("Formato inválido, introduce un número")
        End Try
    End Sub

    Private Sub btnAlbaranGenerar_Click(sender As Object, e As EventArgs) Handles btnAlbaranGenerar.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        saveFileDialog.FileName = nAlbaran
        saveFileDialog.DefaultExt = ".txt"
        saveFileDialog.RestoreDirectory = True

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim streamWriter As New StreamWriter(saveFileDialog.FileName)
            Dim urlPlusfilename() = saveFileDialog.FileName.Split("\")
            Dim filename As String = urlPlusfilename(urlPlusfilename.Length - 1)
            Me.Text = filename
            Me.ruta = saveFileDialog.FileName
            Me.Name = filename
            streamWriter.Write(rtbAlbaran.Text)
            streamWriter.Close()
        End If
    End Sub

    Private Sub btnAlbaranAbrir_Click(sender As Object, e As EventArgs) Handles btnAlbaranAbrir.Click
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
            Me.rtbAlbaran.Text = cadenaMostrar.ReadToEnd
            Me.Name = fileName
            Me.Text = fileName
            Me.Show()
            cadenaMostrar.Close()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class