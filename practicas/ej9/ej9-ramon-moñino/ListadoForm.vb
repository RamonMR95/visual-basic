Imports System.IO

Public Class ListadoForm
    Public ruta As String
    Public cadenaGrabar As StreamWriter
    Public cadenaMostrar As StreamReader

    Private Sub btnListadoGuardar_Click(sender As Object, e As EventArgs) Handles btnListadoGuardar.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        saveFileDialog.FileName = Me.Name
        saveFileDialog.DefaultExt = ".txt"
        saveFileDialog.RestoreDirectory = True

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim streamWriter As New StreamWriter(saveFileDialog.FileName)
            Dim urlPlusfilename() = saveFileDialog.FileName.Split("\")
            Dim filename As String = urlPlusfilename(urlPlusfilename.Length - 1)
            Me.Text = filename
            Me.ruta = saveFileDialog.FileName
            Me.Name = filename
            streamWriter.Write(Me.rtbListado.Text)
            streamWriter.Close()
        End If
    End Sub

    Private Sub btnListadoAbrir_Click(sender As Object, e As EventArgs) Handles btnListadoAbrir.Click
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
            Me.rtbListado.Text = cadenaMostrar.ReadToEnd
            Me.Name = fileName
            Me.Text = fileName
            Me.Show()
            cadenaMostrar.Close()
        End If
    End Sub

    Private Sub btnListadoSalir_Click(sender As Object, e As EventArgs) Handles btnListadoSalir.Click
        Me.Close()
    End Sub

    Private Sub comboBoxListadoCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxListadoCat.SelectedIndexChanged
        If articulos.Count > 0 Then
            Me.rtbListado.Text = "Código" & vbTab & "Nombre" & vbTab & "Categoría" & vbTab & vbTab & "Precio" & vbTab & "Existencias" & vbTab & "Rebaja" & vbNewLine

            For index = 1 To articulos.Count
                If articulos(index).categoria = comboBoxListadoCat.SelectedItem.ToString Then
                    Me.rtbListado.Text += articulos(index).imprimirArticulo()
                End If
            Next
        End If
    End Sub
End Class