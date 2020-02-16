Public Class EmployeeForm

    Private Sub EmployeeForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.EmployeesTableAdapter.Fill(Me.BbddsqlDataSet.Employees)
    End Sub

    Private Sub FillByEmployeeOrder()
        Try
            Me.OrdersTableAdapter.FillByEmployeeOrder(Me.BbddsqlDataSet.Orders, New System.Nullable(Of Integer)(CType(EmployeeIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub EmployeeIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles EmployeeIDTextBox.TextChanged
        FillByEmployeeOrder()
    End Sub
End Class