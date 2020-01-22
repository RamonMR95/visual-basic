Public Class OpcionesForm
    Private Sub listarAlumnos()
        Dim msg As String = ""
        If alumnosArray.Length = 1 Then
            MsgBox("Introduzca un alumno antes listar")
        Else
            For i = 1 To alumnosArray.Length - 1
                msg += "Código: " & alumnosArray(i).codAlum & vbCrLf &
                       "Nickname: " & alumnosArray(i).nicknameAlum & vbCrLf &
                       "Nombre: " & alumnosArray(i).nomAlum & vbCrLf &
                       "Apellido: " & alumnosArray(i).apellAlum & vbCrLf &
                       "Teléfono: " & alumnosArray(i).telfAlum & vbCrLf &
                       "Email: " & alumnosArray(i).emailAlum & vbCrLf &
                       "Curso: " & alumnosArray(i).cursoAlum & vbCrLf
            Next
            MsgBox(msg)
        End If

    End Sub

    Private Sub ordenarArray()
        Dim aux As alumno

        For i = 1 To alumnosArray.Length - 1
            For j = i + 1 To alumnosArray.Length - 1
                If alumnosArray(i).apellAlum > alumnosArray(j).apellAlum Then
                    aux = alumnosArray(i)
                    alumnosArray(i) = alumnosArray(j)
                    alumnosArray(j) = aux
                End If
            Next
        Next
    End Sub


    Private Sub btnEnviarOpcion_Click(sender As Object, e As EventArgs) Handles btnEnviarOpcion.Click
        Select Case txtOpcion.Text
            Case "1"
                Hide()
                AltaAlumnoForm.Show()
                clearOpcion()
            Case "2"
                ConsultaForm1.Show()
                clearOpcion()
            Case "3"
                ordenarArray()
                clearOpcion()
            Case "4"
                listarAlumnos()
                clearOpcion()
            Case "5"
                Application.Exit()
            Case Else
                clearOpcion()
                MsgBox("Introduce un valor correcto 1-5")
        End Select
    End Sub
    Private Sub clearOpcion()
        txtOpcion.Clear()
    End Sub
End Class