Public Class ConsultaForm1
    Private Sub btnVolverListar_Click(sender As Object, e As EventArgs) Handles btnVolverListar.Click
        Hide()
        OpcionesForm.Show()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim counter As Integer = 1
        Dim nickname = txtNicknameAlumListar.Text
        Dim encontrado As Boolean = False

        Do
            If alumnosArray(counter).nicknameAlum = nickname Then
                encontrado = True
            Else
                counter += 1
            End If
        Loop While counter < Module1.alumnosArray.Length And Not encontrado

        If encontrado Then
            Hide()
            ConsultaForm2.Show()
        Else
            MsgBox("Alumno no encontrado")
        End If

    End Sub
End Class