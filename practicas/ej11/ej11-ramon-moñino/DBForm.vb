Imports System.Data.SqlClient
Public Class DBForm
    Public sqlClient As SqlClient.SqlConnection
    Public miDataR As SqlDataReader

    Private Sub SQLForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        sqlClient = New SqlClient.SqlConnection()
        sqlClient.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\bbddsql.mdf';
Integrated Security=True;Connect Timeout=5"
    End Sub

    Private Sub btnAbrirConexion_Click(sender As Object, e As EventArgs) Handles btnAbrirConexion.Click
        Try
            If sqlClient.State <> ConnectionState.Open Then
                sqlClient.Open()
                MsgBox("Conexión a base de datos exitosa")
            Else
                MsgBox("La base de datos ya está en online")
            End If
        Catch ex As Exception
            MsgBox("Error al conectar a la db")
        End Try
    End Sub

    Private Sub btnCerrarConexion_Click(sender As Object, e As EventArgs) Handles btnCerrarConexion.Click
        If Not (miDataR Is Nothing) Then
            miDataR.Close()
        End If

        Try
            If sqlClient.State = ConnectionState.Open Then
                sqlClient.Close()
                MsgBox("Conexión a base de datos exitosa")
            Else
                MsgBox("La db está offline")
            End If
        Catch ex As Exception
            MsgBox("Error al cerrar la conexión")
        End Try
    End Sub

    Private Sub btnDataAdapter_Click(sender As Object, e As EventArgs) Handles btnDataAdapter.Click
        If sqlClient.State = ConnectionState.Open Then
            Dim miDataA As SqlDataAdapter = New SqlDataAdapter("Select top 4 * from Products", sqlClient)
            Dim miDT As New DataTable, miDR As DataRow
            miDataA.Fill(miDT)

            ListadoForm.DataGridViewDatos.ColumnCount = 2
            ListadoForm.DataGridViewDatos.Columns(0).Name = "ProductID"
            ListadoForm.DataGridViewDatos.Columns(1).Name = "ProductName"

            For Each miDR In miDT.Rows
                ListadoForm.DataGridViewDatos.Rows.Add(miDR("ProductID"), miDR("ProductName"))
            Next
            ListadoForm.Show()
        Else
            MsgBox("Error: Abre la conexión a la db antes")
        End If
    End Sub

    Private Sub btnDataReader_Click(sender As Object, e As EventArgs) Handles btnDataReader.Click
        If sqlClient.State = ConnectionState.Open Then
            Dim miDT As New DataTable, miR As DataRow
            Dim miSqlCom As New SqlCommand("select top 5 * from Customers", sqlClient)
            miDataR = miSqlCom.ExecuteReader()

            ListadoForm.DataGridViewDatos.ColumnCount = 2
            ListadoForm.DataGridViewDatos.Columns(0).Name = "CustomerID"
            ListadoForm.DataGridViewDatos.Columns(1).Name = "CompanyName"

            While miDataR.Read()
                Dim customerID As String = miDataR.GetString(0)
                Dim companyName As String = miDataR.GetString(1)
                ListadoForm.DataGridViewDatos.Rows.Add(customerID, companyName)
            End While
            ListadoForm.Show()
        Else
            MsgBox("Error: Abre la conexión a la db antes")
        End If
    End Sub

    Private Sub btnDataSet_Click(sender As Object, e As EventArgs) Handles btnDataSet.Click

    End Sub
End Class

