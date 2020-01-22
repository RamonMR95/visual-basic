Public Class LoginForm

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        For index = 0 To altasUsuario.Length - 1
            If altasUsuario(index).Usuario <> Nothing Then
                comboBoxUsuarios.Items.Add(altasUsuario(index).Usuario)
            End If
        Next
    End Sub

    Private Sub comboBoxUsuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxUsuarios.SelectedIndexChanged
        If comboBoxUsuarios.SelectedIndex <> -1 Then
            lblClaveLogin.Visible = True
            txtClaveLogin.Visible = True
        Else
            lblClaveLogin.Visible = False
            txtClaveLogin.Visible = False
        End If
    End Sub

    Private Sub btnSalirLogin_Click(sender As Object, e As EventArgs) Handles btnSalirLogin.Click
        Me.Hide()
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        If Not String.IsNullOrEmpty(txtClaveLogin.Text) And txtClaveLogin.Visible Then
            Dim usr As String = comboBoxUsuarios.SelectedItem
            Dim clave As String = txtClaveLogin.Text
            Dim usuarioEncontrado As Boolean = False

            For index = 0 To altasUsuario.Length - 1
                If usr = altasUsuario(index).Usuario And clave = altasUsuario(index).Clave Then
                    usuarioLogeado = altasUsuario(index)
                    usuarioEncontrado = True
                End If
            Next

            If usuarioEncontrado Then
                Me.Hide()
                Form2.Show()
            Else
                MsgBox("Contraseña incorrecta")
            End If
        End If
    End Sub
End Class