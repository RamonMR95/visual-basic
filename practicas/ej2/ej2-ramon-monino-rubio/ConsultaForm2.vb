Public Class ConsultaForm2
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNickname2.Text = ConsultaForm1.txtNicknameAlumListar.Text
        buscarAlumno()
    End Sub

    Public Function buscarAlumno() As Integer
        Dim counter As Integer = 0
        Dim nickname = ConsultaForm1.txtNicknameAlumListar.Text
        Dim encontrado As Boolean = False

        Do
            If alumnosArray(counter).nicknameAlum = nickname Then
                encontrado = True
            Else
                counter += 1
            End If
        Loop While counter < Module1.alumnosArray.Length And Not encontrado

        If encontrado Then
            txtNombreAlumConsulta.Text = alumnosArray(counter).nomAlum
            txtApellidoAlumConsulta.Text = alumnosArray(counter).apellAlum
            txtEmailAlumConsulta.Text = alumnosArray(counter).emailAlum
            txtTelefonoAlumConsulta.Text = alumnosArray(counter).telfAlum
            txtCursoAlumConsulta.Text = alumnosArray(counter).cursoAlum
            Return counter
        Else
            MsgBox("Alumno no encontrado")
            Return -1
        End If
    End Function

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim counter As Integer = 1
        Dim nickname = ConsultaForm1.txtNicknameAlumListar.Text
        Dim encontrado As Boolean = False

        Try
            Do
                If alumnosArray(counter).nicknameAlum = nickname Then
                    encontrado = True
                Else
                    counter += 1
                End If
            Loop While counter < Module1.alumnosArray.Length And Not encontrado

            If encontrado Then
                Dim alumno As alumno
                alumno.codAlum = counter
                alumno.nicknameAlum = txtNickname2.Text
                alumno.nomAlum = txtNombreAlumConsulta.Text
                alumno.apellAlum = txtApellidoAlumConsulta.Text
                alumno.telfAlum = CDbl(txtTelefonoAlumConsulta.Text)
                alumno.emailAlum = txtEmailAlumConsulta.Text
                alumno.cursoAlum = txtCursoAlumConsulta.Text

                Module1.alumnosArray(counter) = alumno

                MsgBox("Alumno Creado: " & vbCrLf &
                       "Código del alumno: " & alumno.codAlum & vbCrLf &
                       "Nickname del alumno: " & alumno.nicknameAlum & vbCrLf &
                       "Nombre del alumno: " & alumno.nomAlum & vbCrLf &
                       "Apellido del alumno: " & alumno.apellAlum & vbCrLf &
                       "Teléfono del alumno: " & alumno.telfAlum & vbCrLf &
                       "Email del alumno: " & alumno.emailAlum & vbCrLf &
                       "Curso del alumno: " & alumno.cursoAlum & vbCrLf)
            End If

        Catch ex As Exception
            MsgBox("Datos inválidos")
        End Try

    End Sub

    Private Sub btnVolverConsulta2_Click(sender As Object, e As EventArgs) Handles btnVolverConsulta2.Click
        Hide()
        OpcionesForm.Show()
    End Sub
End Class