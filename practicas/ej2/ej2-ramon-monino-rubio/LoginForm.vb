Public Class LoginForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        addUsuarios()
    End Sub

    Private Sub addUsuarios()
        For i = 0 To UBound(usuariosAPP, 1)
            usuariosAPP(i, 0) = i
            usuariosAPP(i, 1) = i
        Next
    End Sub

    Private Sub btnEntrarLogin_Click(sender As Object, e As EventArgs) Handles btnEntrarLogin.Click
        Dim nombreUsuario As String = txtNombreLogin.Text
        Dim passwordUsuario As String = txtPasswordLogin.Text
        Dim encontrado = False
        Dim counter = 0

        If Not String.IsNullOrEmpty(nombreUsuario) Or Not String.IsNullOrEmpty(passwordUsuario) Then
            While Not encontrado And (counter < UBound(usuariosAPP, 1))
                If usuariosAPP(counter, 0) = nombreUsuario Then
                    If usuariosAPP(counter, 0) = passwordUsuario Then
                        encontrado = True
                    End If
                End If
                counter += 1
            End While

            If encontrado = True Then
                Hide()
                OpcionesForm.Show()
            Else
                MsgBox("Credenciales incorrectas")
            End If
        Else
            MsgBox("Los campos usuario y/o password no pueden estar vacios")
        End If
    End Sub

    Private Sub btnSalirLogin_Click(sender As Object, e As EventArgs) Handles btnSalirLogin.Click
        Application.Exit()
    End Sub
End Class
