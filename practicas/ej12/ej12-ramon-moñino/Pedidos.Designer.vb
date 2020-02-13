<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pedidos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim OrderIDLabel As System.Windows.Forms.Label
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim EmployeeIDLabel As System.Windows.Forms.Label
        Dim OrderDateLabel As System.Windows.Forms.Label
        Dim ShipAddressLabel As System.Windows.Forms.Label
        Dim ShipCityLabel As System.Windows.Forms.Label
        Dim ShipPostalCodeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pedidos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.OrdersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OrdersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.OrderIDTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeIDTextBox = New System.Windows.Forms.TextBox()
        Me.OrderDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ShipAddressTextBox = New System.Windows.Forms.TextBox()
        Me.ShipCityTextBox = New System.Windows.Forms.TextBox()
        Me.ShipPostalCodeTextBox = New System.Windows.Forms.TextBox()
        Me.gbShow = New System.Windows.Forms.GroupBox()
        Me.rbEmployees = New System.Windows.Forms.RadioButton()
        Me.rbCustomers = New System.Windows.Forms.RadioButton()
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BbddsqlDataSet = New ej12_ramon_moñino.bbddsqlDataSet()
        Me.EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdersTableAdapter = New ej12_ramon_moñino.bbddsqlDataSetTableAdapters.OrdersTableAdapter()
        Me.TableAdapterManager = New ej12_ramon_moñino.bbddsqlDataSetTableAdapters.TableAdapterManager()
        Me.CustomersTableAdapter = New ej12_ramon_moñino.bbddsqlDataSetTableAdapters.CustomersTableAdapter()
        Me.EmployeesTableAdapter = New ej12_ramon_moñino.bbddsqlDataSetTableAdapters.EmployeesTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        OrderIDLabel = New System.Windows.Forms.Label()
        CustomerIDLabel = New System.Windows.Forms.Label()
        EmployeeIDLabel = New System.Windows.Forms.Label()
        OrderDateLabel = New System.Windows.Forms.Label()
        ShipAddressLabel = New System.Windows.Forms.Label()
        ShipCityLabel = New System.Windows.Forms.Label()
        ShipPostalCodeLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OrdersBindingNavigator.SuspendLayout()
        Me.gbShow.SuspendLayout()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BbddsqlDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrderIDLabel
        '
        OrderIDLabel.AutoSize = True
        OrderIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OrderIDLabel.Location = New System.Drawing.Point(60, 53)
        OrderIDLabel.Name = "OrderIDLabel"
        OrderIDLabel.Size = New System.Drawing.Size(59, 13)
        OrderIDLabel.TabIndex = 2
        OrderIDLabel.Text = "Order ID:"
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CustomerIDLabel.Location = New System.Drawing.Point(60, 79)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(80, 13)
        CustomerIDLabel.TabIndex = 4
        CustomerIDLabel.Text = "Customer ID:"
        '
        'EmployeeIDLabel
        '
        EmployeeIDLabel.AutoSize = True
        EmployeeIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmployeeIDLabel.Location = New System.Drawing.Point(60, 105)
        EmployeeIDLabel.Name = "EmployeeIDLabel"
        EmployeeIDLabel.Size = New System.Drawing.Size(82, 13)
        EmployeeIDLabel.TabIndex = 6
        EmployeeIDLabel.Text = "Employee ID:"
        '
        'OrderDateLabel
        '
        OrderDateLabel.AutoSize = True
        OrderDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OrderDateLabel.Location = New System.Drawing.Point(60, 132)
        OrderDateLabel.Name = "OrderDateLabel"
        OrderDateLabel.Size = New System.Drawing.Size(73, 13)
        OrderDateLabel.TabIndex = 8
        OrderDateLabel.Text = "Order Date:"
        '
        'ShipAddressLabel
        '
        ShipAddressLabel.AutoSize = True
        ShipAddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ShipAddressLabel.Location = New System.Drawing.Point(427, 57)
        ShipAddressLabel.Name = "ShipAddressLabel"
        ShipAddressLabel.Size = New System.Drawing.Size(85, 13)
        ShipAddressLabel.TabIndex = 20
        ShipAddressLabel.Text = "Ship Address:"
        '
        'ShipCityLabel
        '
        ShipCityLabel.AutoSize = True
        ShipCityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ShipCityLabel.Location = New System.Drawing.Point(427, 83)
        ShipCityLabel.Name = "ShipCityLabel"
        ShipCityLabel.Size = New System.Drawing.Size(61, 13)
        ShipCityLabel.TabIndex = 22
        ShipCityLabel.Text = "Ship City:"
        '
        'ShipPostalCodeLabel
        '
        ShipPostalCodeLabel.AutoSize = True
        ShipPostalCodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ShipPostalCodeLabel.Location = New System.Drawing.Point(427, 109)
        ShipPostalCodeLabel.Name = "ShipPostalCodeLabel"
        ShipPostalCodeLabel.Size = New System.Drawing.Size(108, 13)
        ShipPostalCodeLabel.TabIndex = 26
        ShipPostalCodeLabel.Text = "Ship Postal Code:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView)
        Me.Panel1.Location = New System.Drawing.Point(24, 285)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(871, 303)
        Me.Panel1.TabIndex = 0
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToOrderColumns = True
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.Size = New System.Drawing.Size(871, 303)
        Me.DataGridView.TabIndex = 1
        '
        'OrdersBindingNavigator
        '
        Me.OrdersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.OrdersBindingNavigator.BindingSource = Me.OrdersBindingSource
        Me.OrdersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OrdersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.OrdersBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.OrdersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.OrdersBindingNavigatorSaveItem})
        Me.OrdersBindingNavigator.Location = New System.Drawing.Point(24, 246)
        Me.OrdersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OrdersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OrdersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OrdersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OrdersBindingNavigator.Name = "OrdersBindingNavigator"
        Me.OrdersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OrdersBindingNavigator.Size = New System.Drawing.Size(280, 25)
        Me.OrdersBindingNavigator.TabIndex = 1
        Me.OrdersBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'OrdersBindingNavigatorSaveItem
        '
        Me.OrdersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OrdersBindingNavigatorSaveItem.Image = CType(resources.GetObject("OrdersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OrdersBindingNavigatorSaveItem.Name = "OrdersBindingNavigatorSaveItem"
        Me.OrdersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.OrdersBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'OrderIDTextBox
        '
        Me.OrderIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "OrderID", True))
        Me.OrderIDTextBox.Location = New System.Drawing.Point(157, 50)
        Me.OrderIDTextBox.Name = "OrderIDTextBox"
        Me.OrderIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.OrderIDTextBox.TabIndex = 3
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "CustomerID", True))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(157, 76)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CustomerIDTextBox.TabIndex = 5
        '
        'EmployeeIDTextBox
        '
        Me.EmployeeIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "EmployeeID", True))
        Me.EmployeeIDTextBox.Location = New System.Drawing.Point(157, 102)
        Me.EmployeeIDTextBox.Name = "EmployeeIDTextBox"
        Me.EmployeeIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmployeeIDTextBox.TabIndex = 7
        '
        'OrderDateDateTimePicker
        '
        Me.OrderDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OrdersBindingSource, "OrderDate", True))
        Me.OrderDateDateTimePicker.Location = New System.Drawing.Point(157, 128)
        Me.OrderDateDateTimePicker.Name = "OrderDateDateTimePicker"
        Me.OrderDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.OrderDateDateTimePicker.TabIndex = 9
        '
        'ShipAddressTextBox
        '
        Me.ShipAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "ShipAddress", True))
        Me.ShipAddressTextBox.Location = New System.Drawing.Point(552, 54)
        Me.ShipAddressTextBox.Name = "ShipAddressTextBox"
        Me.ShipAddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ShipAddressTextBox.TabIndex = 21
        '
        'ShipCityTextBox
        '
        Me.ShipCityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "ShipCity", True))
        Me.ShipCityTextBox.Location = New System.Drawing.Point(552, 80)
        Me.ShipCityTextBox.Name = "ShipCityTextBox"
        Me.ShipCityTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ShipCityTextBox.TabIndex = 23
        '
        'ShipPostalCodeTextBox
        '
        Me.ShipPostalCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "ShipPostalCode", True))
        Me.ShipPostalCodeTextBox.Location = New System.Drawing.Point(552, 106)
        Me.ShipPostalCodeTextBox.Name = "ShipPostalCodeTextBox"
        Me.ShipPostalCodeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ShipPostalCodeTextBox.TabIndex = 27
        '
        'gbShow
        '
        Me.gbShow.Controls.Add(Me.rbEmployees)
        Me.gbShow.Controls.Add(Me.rbCustomers)
        Me.gbShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbShow.Location = New System.Drawing.Point(48, 170)
        Me.gbShow.Name = "gbShow"
        Me.gbShow.Size = New System.Drawing.Size(225, 53)
        Me.gbShow.TabIndex = 28
        Me.gbShow.TabStop = False
        Me.gbShow.Text = "Show"
        '
        'rbEmployees
        '
        Me.rbEmployees.AutoSize = True
        Me.rbEmployees.Location = New System.Drawing.Point(126, 19)
        Me.rbEmployees.Name = "rbEmployees"
        Me.rbEmployees.Size = New System.Drawing.Size(85, 17)
        Me.rbEmployees.TabIndex = 30
        Me.rbEmployees.Text = "Employees"
        Me.rbEmployees.UseVisualStyleBackColor = True
        '
        'rbCustomers
        '
        Me.rbCustomers.AutoSize = True
        Me.rbCustomers.Checked = True
        Me.rbCustomers.Location = New System.Drawing.Point(7, 19)
        Me.rbCustomers.Name = "rbCustomers"
        Me.rbCustomers.Size = New System.Drawing.Size(83, 17)
        Me.rbCustomers.TabIndex = 29
        Me.rbCustomers.TabStop = True
        Me.rbCustomers.Text = "Customers"
        Me.rbCustomers.UseVisualStyleBackColor = True
        '
        'OrdersBindingSource
        '
        Me.OrdersBindingSource.DataMember = "Orders"
        Me.OrdersBindingSource.DataSource = Me.BbddsqlDataSet
        '
        'BbddsqlDataSet
        '
        Me.BbddsqlDataSet.DataSetName = "bbddsqlDataSet"
        Me.BbddsqlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeesBindingSource
        '
        Me.EmployeesBindingSource.DataMember = "Employees"
        Me.EmployeesBindingSource.DataSource = Me.BbddsqlDataSet
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.BbddsqlDataSet
        '
        'OrdersTableAdapter
        '
        Me.OrdersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriesTableAdapter = Nothing
        Me.TableAdapterManager.CustomerCustomerDemoTableAdapter = Nothing
        Me.TableAdapterManager.CustomerDemographicsTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.dtpropertiesTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTerritoriesTableAdapter = Nothing
        Me.TableAdapterManager.Order_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.OrdersTableAdapter = Me.OrdersTableAdapter
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.RegionTableAdapter = Nothing
        Me.TableAdapterManager.ShippersTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.TerritoriesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ej12_ramon_moñino.bbddsqlDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'EmployeesTableAdapter
        '
        Me.EmployeesTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Order"
        '
        'Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 625)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbShow)
        Me.Controls.Add(Me.OrdersBindingNavigator)
        Me.Controls.Add(OrderIDLabel)
        Me.Controls.Add(Me.OrderIDTextBox)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(Me.CustomerIDTextBox)
        Me.Controls.Add(EmployeeIDLabel)
        Me.Controls.Add(Me.EmployeeIDTextBox)
        Me.Controls.Add(OrderDateLabel)
        Me.Controls.Add(Me.OrderDateDateTimePicker)
        Me.Controls.Add(ShipAddressLabel)
        Me.Controls.Add(Me.ShipAddressTextBox)
        Me.Controls.Add(ShipCityLabel)
        Me.Controls.Add(Me.ShipCityTextBox)
        Me.Controls.Add(ShipPostalCodeLabel)
        Me.Controls.Add(Me.ShipPostalCodeTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Pedidos"
        Me.Text = "Pedidos"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OrdersBindingNavigator.ResumeLayout(False)
        Me.OrdersBindingNavigator.PerformLayout()
        Me.gbShow.ResumeLayout(False)
        Me.gbShow.PerformLayout()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BbddsqlDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BbddsqlDataSet As bbddsqlDataSet
    Friend WithEvents OrdersBindingSource As BindingSource
    Friend WithEvents OrdersTableAdapter As bbddsqlDataSetTableAdapters.OrdersTableAdapter
    Friend WithEvents TableAdapterManager As bbddsqlDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OrdersBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents OrdersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents OrderIDTextBox As TextBox
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents EmployeeIDTextBox As TextBox
    Friend WithEvents OrderDateDateTimePicker As DateTimePicker
    Friend WithEvents ShipAddressTextBox As TextBox
    Friend WithEvents ShipCityTextBox As TextBox
    Friend WithEvents ShipPostalCodeTextBox As TextBox
    Friend WithEvents gbShow As GroupBox
    Friend WithEvents rbEmployees As RadioButton
    Friend WithEvents rbCustomers As RadioButton
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As bbddsqlDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents EmployeesBindingSource As BindingSource
    Friend WithEvents EmployeesTableAdapter As bbddsqlDataSetTableAdapters.EmployeesTableAdapter
    Friend WithEvents Label1 As Label
End Class
