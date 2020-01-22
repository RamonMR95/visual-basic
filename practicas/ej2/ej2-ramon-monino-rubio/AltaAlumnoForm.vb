Public Class AltaAlumnoForm
    Private Sub btnVolverAlta_Click(sender As Object, e As EventArgs) Handles btnVolverAlta.Click
        Hide()
        OpcionesForm.Show()
    End Sub

    Private Sub btnAltaAlum_Click(sender As Object, e As EventArgs) Handles btnAltaAlum.Click
        alumnosArray(0).nicknameAlum = "test"
        Static contador = 1


        If Not (String.IsNullOrEmpty(txtNicknameAlumAlta.Text) Or
            String.IsNullOrEmpty(txtNombreAlumAlta.Text) Or
            String.IsNullOrEmpty(txtApellidoAlumAlta.Text) Or
            String.IsNullOrEmpty(txtEmailAlumAlta.Text) Or
            String.IsNullOrEmpty(txtCursoAlumAlta.Text)) And
            IsNumeric(txtTelefonoAlumAlta.Text) Then

            ReDim Preserve alumnosArray(contador)

            For i = 1 To alumnosArray.Length - 1
                If alumnosArray(i).nicknameAlum = txtNicknameAlumAlta.Text Then
                    MsgBox("El usuario ya está registrado en la app")
                    Return
                End If
            Next

            Dim alumno As alumno
            alumno.codAlum = alumnosArray.Length - 1
            alumno.nicknameAlum = txtNicknameAlumAlta.Text
            alumno.nomAlum = txtNombreAlumAlta.Text
            alumno.apellAlum = txtApellidoAlumAlta.Text
            alumno.telfAlum = CDbl(txtTelefonoAlumAlta.Text)
            alumno.emailAlum = txtEmailAlumAlta.Text
            alumno.cursoAlum = txtCursoAlumAlta.Text


            Module1.alumnosArray(alumnosArray.Length - 1) = alumno

            MsgBox("Código del alumno: " & alumnosArray.Length - 1 & vbCrLf &
                        "Nickname del alumno: " & txtNicknameAlumAlta.Text & vbCrLf &
                        "Nombre del alumno: " & txtNombreAlumAlta.Text & vbCrLf &
                        "Apellido del alumno: " & txtApellidoAlumAlta.Text & vbCrLf &
                        "Teléfono del alumno: " & txtTelefonoAlumAlta.Text & vbCrLf &
                        "Email del alumno: " & txtEmailAlumAlta.Text & vbCrLf &
                        "Curso del alumno: " & txtCursoAlumAlta.Text & vbCrLf)
            contador += 1

            AltaConfirmForm.Show()
        Else
            MsgBox("Datos no válidos")
        End If
    End Sub
End Class