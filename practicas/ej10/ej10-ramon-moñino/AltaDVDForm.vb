Public Class AltaDVDForm

    Public errorProvider As ErrorProvider

    Private Sub VideoClub_Load(sender As Object, e As EventArgs) Handles Me.Load
        clearData()
        errorProvider = New ErrorProvider
    End Sub

    Private Sub btnAltaDVDCancelar_Click(sender As Object, e As EventArgs) Handles btnAltaDVDCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAltaDVDGuardar_Click(sender As Object, e As EventArgs) Handles btnAltaDVDGuardar.Click
        If Not dvds.Contains(txtAltaDVDCod.Text) Then
            If isValido() Then
                alta()
                preguntarDarDeAlta()
            End If
        Else
            MsgBox("Ya existe un dvd con el código: " & txtAltaDVDCod.Text)
        End If
    End Sub

    Private Function isValido() As Boolean
        Dim valido As Boolean = True
        If String.IsNullOrEmpty(txtAltaDVDCod.Text) Or String.IsNullOrWhiteSpace(txtAltaDVDCod.Text) Then
            errorProvider.SetError(txtAltaDVDCod, "Código inválido")
            valido = False
        End If
        If String.IsNullOrEmpty(txtAltaDVDTitulo.Text) Or String.IsNullOrWhiteSpace(txtAltaDVDTitulo.Text) Then
            errorProvider.SetError(txtAltaDVDTitulo, "Título inválido")
            valido = False
        End If
        If String.IsNullOrEmpty(txtAltaDVDTitulo.Text) Or String.IsNullOrWhiteSpace(txtAltaDVDTitulo.Text) Or Not IsNumeric(txtAltaDVDDias.Text) Then
            errorProvider.SetError(txtAltaDVDDias, "Días inválido")
            valido = False
        End If
        Return valido
    End Function

    Private Sub alta()
        Dim dvd As New DVD(txtAltaDVDCod.Text, txtAltaDVDTitulo.Text, CInt(txtAltaDVDDias.Text))
        Colecciones.dvds.Add(dvd, dvd.codigo)
    End Sub

    Private Sub clearData()
        txtAltaDVDCod.Clear()
        txtAltaDVDTitulo.Clear()
        txtAltaDVDDias.Clear()
    End Sub

    Private Sub datos_TextChanged(sender As Object, e As EventArgs) Handles txtAltaDVDCod.TextChanged, txtAltaDVDTitulo.TextChanged, txtAltaDVDDias.TextChanged
        errorProvider.Clear()
    End Sub

    Private Sub preguntarDarDeAlta()
        Dim result As DialogResult = MessageBox.Show("¿Desea dar de alta otro DVD?", "Dar de alta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If result = DialogResult.Yes Then
            clearData()
        ElseIf result = DialogResult.No Then
            Me.Hide()
        End If
    End Sub
End Class