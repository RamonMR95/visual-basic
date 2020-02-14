Public Class EmployeeForm
    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BbddsqlDataSet)
    End Sub

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BbddsqlDataSet.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.BbddsqlDataSet.Employees)
        'TODO: This line of code loads data into the 'BbddsqlDataSet.Orders' table. You can move, or remove it, as needed.
        Me.OrdersTableAdapter.Fill(Me.BbddsqlDataSet.Orders)
        'TODO: This line of code loads data into the 'BbddsqlDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.BbddsqlDataSet.Customers)
    End Sub

    Private Sub FillByEmployeeByIDToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByEmployeeByIDToolStripButton.Click
        Try
            Me.OrdersTableAdapter.FillByEmployeeByID(Me.BbddsqlDataSet.Orders, New System.Nullable(Of Integer)(CType(EmployeeIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class