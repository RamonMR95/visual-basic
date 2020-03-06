Public Class Form4

    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BbddsqlDataSet)
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Order_DetailsTableAdapter.Fill(Me.BbddsqlDataSet.Order_Details)
        Me.CustomersTableAdapter.Fill(Me.BbddsqlDataSet.Customers)
        FillByCustomerID()
    End Sub

    Private Sub FillByCustomerID()
        Try
            Me.OrdersTableAdapter.FillByCustomerID(Me.BbddsqlDataSet.Orders, CustomerIDTextBox.Text)
            ' MsgBox(Me.OrdersDataGridView.CurrentRow.Cells(0).Value)
            Me.Order_DetailsTableAdapter.FillByOrderID(Me.BbddsqlDataSet.Order_Details, CType(Me.OrdersDataGridView.SelectedCells(0).Value, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CustomerIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles CustomerIDTextBox.TextChanged
        FillByCustomerID()
    End Sub

    Private Sub OrdersDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles OrdersDataGridView.SelectionChanged
        Try
            Me.Order_DetailsTableAdapter.FillByOrderID(Me.BbddsqlDataSet.Order_Details, CType(Me.OrdersDataGridView.SelectedCells(0).Value, Integer))
        Catch ex As Exception

        End Try
    End Sub
End Class