Public Class Form2

    Public productos As String = ""

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtTotal.Text = "0.0"
    End Sub

    Private Sub picIphone_DoubleClick(sender As Object, e As EventArgs) Handles picIphone.DoubleClick
        lstCompra.Items.Add("IPhone")
        productos += "IPhone: 790€" & vbNewLine
        txtTotal.Text = CStr(CDbl(txtTotal.Text) + 790)
    End Sub

    Private Sub picSamsung_DoubleClick(sender As Object, e As EventArgs) Handles picSamsung.DoubleClick
        lstCompra.Items.Add("Samsung")
        productos += "Samsung: 350€" & vbNewLine
        txtTotal.Text = CStr(CDbl(txtTotal.Text) + 350)
    End Sub

    Private Sub picLg_DoubleClick(sender As Object, e As EventArgs) Handles picLg.DoubleClick
        lstCompra.Items.Add("Xiaomi")
        productos += "Xiaomi: 365" & vbNewLine
        txtTotal.Text = CStr(CDbl(txtTotal.Text) + 365)
    End Sub

    Private Sub picSony_DoubleClick(sender As Object, e As EventArgs) Handles picSony.DoubleClick
        lstCompra.Items.Add("Huawei")
        productos += "Huawei: 365" & vbNewLine
        txtTotal.Text = CStr(CDbl(txtTotal.Text) + 230)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Module1.usuarioLogeado.TotCompAcum += CDbl(txtTotal.Text)
        Me.Hide()
        Form4.Show()
        Dim nombre As String = "Nombre: " & usuarioLogeado.Nombre & vbNewLine
        Dim total As String = "Total: " & txtTotal.Text
        Form4.rtxPedido.Text = nombre & productos & total
    End Sub

End Class