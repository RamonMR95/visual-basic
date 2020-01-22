Imports System.ComponentModel

Public Class Form3
    Public errorProvider As ErrorProvider
    Public isModificado As Boolean
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load
        init()
    End Sub

    Private Sub txtUsu_Validating(sender As Object, e As CancelEventArgs) Handles txtUsu.Validating
        If IsNumeric(txtUsu.Text) Or String.IsNullOrEmpty(txtUsu.Text) Then
            errorProvider.SetError(txtUsu, "El campo debe ser una cadena de texto obligatoriamente")
            'e.Cancel = True'
        Else
            errorProvider.SetError(txtUsu, "")
        End If
    End Sub

    Private Sub txtClave_Validating(sender As Object, e As CancelEventArgs) Handles txtClave.Validating
        If String.IsNullOrEmpty(txtClave.Text) Then
            errorProvider.SetError(txtClave, "El campo no debe estar vacío")
            'e.Cancel = True'
        Else
            errorProvider.SetError(txtClave, "")
        End If
    End Sub





    Private Sub init()
        errorProvider = New ErrorProvider
        isModificado = False
    End Sub

    Private Sub alta()
        Dim usuarioExiste As Boolean = False
        Dim counter As Integer = 0

        While counter < altasUsuario.Length And Not usuarioExiste
            If Module1.altasUsuario(counter).Usuario = txtUsu.Text Then
                usuarioExiste = True
            End If
            counter += 1
        End While

        If usuarioExiste Then
            MsgBox("El usuario ya existe en la db")
        Else
            Try
                Dim usr As New USUARIO
                usr.Usuario = txtUsu.Text
                usr.Nombre = txtNombre.Text
                usr.Email = txtEmail.Text
                usr.Clave = txtClave.Text
                usr.Direccion = txtDirec.Text
                usr.Telefono = CDbl(txtTelef.Text)
                usr.TotCompAcum = 0
                altasUsuario(counter - 1) = usr
                ReDim Preserve altasUsuario(counter + 1)
                MsgBox("Usuario dado de alta")
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub modificar()
        Dim counter As Integer = 0

        While counter < altasUsuario.Length
            If Module1.altasUsuario(counter).Usuario = txtUsu.Text And Module1.altasUsuario(counter).Clave = txtClave.Text Then
                Dim usr As New USUARIO
                usr.Usuario = txtUsu.Text
                usr.Nombre = txtNombre.Text
                usr.Email = txtEmail.Text
                usr.Clave = txtClave.Text
                usr.Direccion = txtDirec.Text
                usr.Telefono = CDbl(txtTelef.Text)
                altasUsuario(counter) = usr
            End If
            counter += 1
        End While
    End Sub

    Private Sub butGuardar_Click(sender As Object, e As EventArgs) Handles butGuardar.Click
        isModificado = False
        If butGuardar.Text = "Modificar" Then
            modificar()
        Else
            alta()
        End If
    End Sub


    Private Sub butCerrar_Click(sender As Object, e As EventArgs) Handles butCerrar.Click
        If isModificado Then
            Dim result As DialogResult = MessageBox.Show("¿Desea guardarlos cambios?", “Guardar?”, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If result = DialogResult.Yes Then
                butGuardar.PerformClick()
            End If
        End If
        Me.Hide()
    End Sub

    Private Sub textChanged(sender As Object, e As EventArgs) Handles txtClave.TextChanged, txtDirec.TextChanged, txtEmail.TextChanged, TextBox1.TextChanged, txtUsu.TextChanged, txtTelef.TextChanged, txtTelef.TextChanged
        isModificado = True
    End Sub

    Private Sub butAceptar_Click(sender As Object, e As EventArgs) Handles butAceptar.Click
        Dim usuarioEncontrado As Boolean = False

        For index = 0 To altasUsuario.Length - 1
            If txtUsu.Text = altasUsuario(index).Usuario And txtClave.Text = altasUsuario(index).Clave Then
                GroupBox1.Visible = True
                txtNombre.Text = altasUsuario(index).Nombre
                txtDirec.Text = altasUsuario(index).Direccion
                txtEmail.Text = altasUsuario(index).Email
                txtTelef.Text = altasUsuario(index).Telefono
                TextBox1.Text = altasUsuario(index).TotCompAcum
                Me.isModificado = False
                usuarioEncontrado = True
            End If
        Next

        If Not usuarioEncontrado Then
            MsgBox("Usuario no encontrado")
        End If
    End Sub

    Private Sub chkVer_CheckedChanged(sender As Object, e As EventArgs) Handles chkVer.CheckedChanged
        If chkVer.Checked Then
            TextBox1.PasswordChar = ""
        Else
            TextBox1.PasswordChar = "*"
        End If
    End Sub
End Class