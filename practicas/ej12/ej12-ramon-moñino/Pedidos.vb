Public Class Pedidos
    Private Sub OrdersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles OrdersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OrdersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BbddsqlDataSet)
    End Sub

    Private Sub Pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BbddsqlDataSet.Employees' Puede moverla o quitarla según sea necesario.
        Me.EmployeesTableAdapter.Fill(Me.BbddsqlDataSet.Employees)
        'TODO: esta línea de código carga datos en la tabla 'BbddsqlDataSet.Orders' Puede moverla o quitarla según sea necesario.
        Me.OrdersTableAdapter.Fill(Me.BbddsqlDataSet.Orders)
        FillByIDCustomer()
    End Sub

    Private Sub FillByIDCustomer()
        Try
            If Not String.IsNullOrEmpty(CustomerIDTextBox.Text) Then
                Me.CustomersTableAdapter.FillByIDCustomer(Me.BbddsqlDataSet.Customers, CustomerIDTextBox.Text)
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CustomerIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles CustomerIDTextBox.TextChanged
        If String.IsNullOrEmpty(CustomerIDTextBox.Text) Then
            FillByIDCustomer()
        End If
    End Sub

    Private Sub rbCustomers_CheckedChanged(sender As Object, e As EventArgs) Handles rbCustomers.CheckedChanged
        If rbCustomers.Checked Then
            DataGridView.DataSource = CustomersBindingSource
            FillByIDCustomer()
        End If
    End Sub

    Private Sub rbEmployees_CheckedChanged(sender As Object, e As EventArgs) Handles rbEmployees.CheckedChanged
        If rbEmployees.Checked Then
            DataGridView.DataSource = EmployeesBindingSource
            FillByEmployeeID()
        End If
    End Sub

    Private Sub FillByEmployeeID()
        Try
            If Not String.IsNullOrEmpty(EmployeeIDTextBox.Text) Then
                Me.EmployeesTableAdapter.FillByEmployeeID(Me.BbddsqlDataSet.Employees, CType(EmployeeIDTextBox.Text, Integer))
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub EmployeeIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles EmployeeIDTextBox.TextChanged
        FillByEmployeeID()
    End Sub

    Private Sub FillByOrderIDToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.OrdersTableAdapter.FillByOrderID(Me.BbddsqlDataSet.Orders, CType(OrderIDTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
