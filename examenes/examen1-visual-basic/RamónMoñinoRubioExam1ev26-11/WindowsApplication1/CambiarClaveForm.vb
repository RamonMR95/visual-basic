Imports System.ComponentModel

Public Class CambiarClaveForm
    Public errorProvider As New ErrorProvider
    Public pos As Integer = 0

    Private Sub txtUsuarioCambiarClave_Validating(sender As Object, e As CancelEventArgs) Handles txtUsuarioCambiarClave.Validating
        If String.IsNullOrEmpty(txtUsuarioCambiarClave.Text) Then
            ErrorProvider.SetError(txtUsuarioCambiarClave, "El campo no debe estar vacío")
            'e.Cancel = True'
        Else
            ErrorProvider.SetError(txtUsuarioCambiarClave, "")
        End If
    End Sub

    Private Sub txtClaveCambiarClave_Validating(sender As Object, e As CancelEventArgs) Handles txtClaveCambiarClave.Validating
        If String.IsNullOrEmpty(txtClaveCambiarClave.Text) Then
            errorProvider.SetError(txtClaveCambiarClave, "El campo no debe estar vacío")
            'e.Cancel = True'
        Else
            errorProvider.SetError(txtClaveCambiarClave, "")
        End If
    End Sub

    Private Sub btnCambiarClave_Click(sender As Object, e As EventArgs) Handles btnCambiarClave.Click
        Dim usuarioEncontrado As Boolean = False

        For index = 0 To altasUsuario.Length - 1
            If txtUsuarioCambiarClave.Text = altasUsuario(index).Usuario And txtClaveCambiarClave.Text = altasUsuario(index).Clave Then
                pos = index
                usuarioEncontrado = True
            End If
        Next

        If usuarioEncontrado Then
            lblIntroduceclavedenuevo.Visible = True
            lblIntroducir2Clave.Visible = True
            txtNuevaClave1.Visible = True
            txtNuevaClave2.Visible = True
        Else
            lblIntroduceclavedenuevo.Visible = False
            lblIntroducir2Clave.Visible = False
            txtNuevaClave1.Visible = False
            txtNuevaClave2.Visible = False
        End If
    End Sub

    Private Sub btnGuardarNuevaClave_Click(sender As Object, e As EventArgs) Handles btnGuardarNuevaClave.Click
        If txtNuevaClave1.Text = txtNuevaClave2.Text Then
            altasUsuario(pos).Clave = txtNuevaClave2.Text
            MsgBox("Usuario Guardado")
        Else
            MsgBox("Las contraseñas no coinciden")
        End If
    End Sub
End Class