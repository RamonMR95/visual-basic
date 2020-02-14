Public Class OrdersForm
    Private Sub OrdersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles OrdersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OrdersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BbddsqlDataSet)
    End Sub

    Private Sub Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EmployeesTableAdapter.Fill(Me.BbddsqlDataSet.Employees)
        Me.OrdersTableAdapter.Fill(Me.BbddsqlDataSet.Orders)
        Me.CustomersTableAdapter.Fill(Me.BbddsqlDataSet.Customers)
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

    Private Sub FillByOrderID()
        Try
            Me.OrdersTableAdapter.FillByOrderID(Me.BbddsqlDataSet.Orders, CType(OrderIDTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        BindingNavigatorAddNewItem.PerformClick()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        'Definimos vista del DataRow
        Dim vistaFilaActual As DataRowView
        'Le asignamos la fila actual
        vistaFilaActual = OrdersBindingSource.Current
        'Borramos la fila
        vistaFilaActual.Row.Delete()
        'Actualizamos DataAdapter
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            OrdersBindingSource.AddNew()
            'Terminamos la edición
            OrdersBindingSource.EndEdit()
            'Si ha habido cambios en DataSet actualizamos DataAdapter
            If BbddsqlDataSet.HasChanges Then
                Me.TableAdapterManager.UpdateAll(Me.BbddsqlDataSet)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnFindOrderByID_Click(sender As Object, e As EventArgs) Handles btnFindOrderByID.Click
        DataGridView.DataSource = OrdersBindingSource
        FillByOrderID()
    End Sub
End Class
