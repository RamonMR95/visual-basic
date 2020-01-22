Public Class CalculadoraForm
    Public isOn As Boolean
    Public operador1 As Double
    Public operador2 As Double
    Public operando As String
    Public digitoPulsado As Boolean
    Public igualPulsado As Boolean
    Public repiteIgual As Boolean
    Public operadorPulsado As Boolean


    Private Sub CalculadoraForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        txtResultado.Text = "0"
        resetAll()
        digitoPulsado = True
    End Sub

    Private Sub CalculadoraForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyData
            Case Keys.NumPad0, Keys.D0
                btn0.PerformClick()
            Case Keys.NumPad1, Keys.D1
                btn1.PerformClick()
            Case Keys.NumPad2, Keys.D2
                btn2.PerformClick()
            Case Keys.NumPad3, Keys.D3
                btn3.PerformClick()
            Case Keys.NumPad4, Keys.D4
                btn4.PerformClick()
            Case Keys.NumPad5, Keys.D5
                btn5.PerformClick()
            Case Keys.NumPad6, Keys.D6
                btn6.PerformClick()
            Case Keys.NumPad7, Keys.D7
                btn7.PerformClick()
            Case Keys.NumPad8, Keys.D8
                btn8.PerformClick()
            Case Keys.NumPad9, Keys.D9
                btn9.PerformClick()
            Case Keys.Add, Keys.Oemplus
                btnSumar.PerformClick()
            Case Keys.Subtract, Keys.OemMinus
                btnRestar.PerformClick()
            Case Keys.Multiply, (Keys.Shift + Keys.Oemplus)
                btnMultiplicar.PerformClick()
            Case Keys.Divide, (Keys.Shift + Keys.D7)
                btnDividir.PerformClick()
            Case Keys.OemPeriod, Keys.Oemcomma, Keys.Decimal
                btnComa.PerformClick()
            Case Keys.Return, Keys.Separator, (Keys.D0 + Keys.Shift)
                btnIgual.PerformClick()
            Case Keys.Back
                If txtResultado.Text.Length = 1 Then
                    txtResultado.Text = "0"
                ElseIf txtResultado.Text.Length > 1 Then
                    txtResultado.Text = txtResultado.Text.Remove(txtResultado.Text.Length - 1)
                End If
        End Select
    End Sub

    Private Sub btnOn_Click(sender As Object, e As EventArgs) Handles btnOn.Click
        If isOn = False Then
            cambiarEstadoBotones(True, "OFF")
            txtResultado.Focus()
            isOn = True
        Else
            cambiarEstadoBotones(False, "ON")
            resetAll()
            txtResultado.Text = "0"
            isOn = False
        End If
    End Sub

    Private Sub cambiarEstadoBotones(estado As Boolean, texto As String)
        gbPanel.Enabled = estado
        btnOn.Text = texto
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        crearNumero(sender.text)
    End Sub

    Private Sub operacion(ByVal sender As Object, ByVal e As EventArgs) Handles btnSumar.Click, btnRestar.Click, btnMultiplicar.Click, btnDividir.Click, btnModulo.Click
        If digitoPulsado Or igualPulsado Then
            Select Case sender.tag
                Case btnSumar.Tag
                    operar("suma")
                Case btnRestar.Tag
                    operar("resta")
                Case btnMultiplicar.Tag
                    operar("multip")
                Case btnDividir.Tag
                    operar("division")
                Case btnModulo.Tag
                    operar("modulo")
            End Select
            operadorPulsado = True
        Else
            operando = sender.tag
        End If
    End Sub

    Private Sub operar(operacion As String)
        If operacion <> "=" Then
            operador2 = CDbl(txtResultado.Text)
        End If

        If digitoPulsado Or operacion = "=" Then
            Select Case operando
                Case "1º"
                    operador1 = operador2
                Case "suma"
                    operador1 += operador2
                Case "resta"
                    operador1 -= operador2
                Case "multip"
                    operador1 *= operador2
                Case "division"
                    If operador2 = 0 Then
                        resetAll()
                        txtResultado.Text = "ERROR"
                    Else
                        operador1 /= operador2
                    End If
                Case "modulo"
                    operador1 = operador1 Mod operador2
            End Select
        End If

        If operando <> "1º" Then
            txtResultado.Text = CStr(operador1)
        End If

        If operacion = "=" Then
            igualPulsado = True
        Else
            operando = operacion
            igualPulsado = False
        End If
        digitoPulsado = False
    End Sub

    Private Sub crearNumero(numero As String)
        If igualPulsado Then
            reset()
            txtResultado.Text = "0"
            operando = "1º"
        ElseIf operadorPulsado Then
            txtResultado.Clear()
        End If

        If txtResultado.Text = "0" Then
            txtResultado.Text = numero
        Else
            txtResultado.Text &= numero
        End If
        igualPulsado = False
        digitoPulsado = True
        operadorPulsado = False
    End Sub


    Private Sub btnComa_Click(sender As Object, e As EventArgs) Handles btnComa.Click
        If txtResultado.Text = "0" Then
            txtResultado.Text = "0,"
        ElseIf Not txtResultado.Text.Contains(",") Then
            txtResultado.Text &= ","
        End If
    End Sub

    Private Sub btnLimpiarText_Click(sender As Object, e As EventArgs) Handles btnLimpiarText.Click
        txtResultado.Text = "0"
        operando = "1º"
        reset()
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        If igualPulsado Then
            operar("=")
            repiteIgual = True
        ElseIf digitoPulsado Or repiteIgual Then
            operar(operando)
        End If
        igualPulsado = True
        operadorPulsado = False
        digitoPulsado = False
    End Sub

    Private Sub btnCambiarSigno_Click(sender As Object, e As EventArgs) Handles btnCambiarSigno.Click
        If txtResultado.Text.Length > 0 Then
            If txtResultado.Text.Contains("-") Then
                txtResultado.Text = txtResultado.Text.Replace("-", "")
            Else
                txtResultado.Text = "-" & txtResultado.Text
            End If
        End If
    End Sub

    Private Sub reset()
        operador1 = 0
        operador2 = 0
        digitoPulsado = False
    End Sub

    Private Sub resetAll()
        operador1 = 0
        operador2 = 0
        operando = "1º"
        digitoPulsado = False
        operadorPulsado = False
        igualPulsado = False
        repiteIgual = False
    End Sub

    Private Sub txtResultado_LostFocus(sender As Object, e As EventArgs) Handles txtResultado.Leave
        txtResultado.Focus()
    End Sub
End Class
