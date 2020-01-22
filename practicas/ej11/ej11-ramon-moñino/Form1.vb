Imports System.Data.SqlClient
Public Class SQLForm
    Dim sqlClient As SqlClient.SqlConnection
    Dim miDataR As SqlDataReader

    Private Sub SQLForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        sqlClient = New SqlClient.SqlConnection()
        sqlClient.ConnectionString =
            "Data Source=(LocalDB)\MSSQLocalDB;AttachDbFilename=|DataDirectory|\bbddsql.mdf;Integrated Security=True;Connect Timeout=30"
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
        Dim miDataA As SqlDataAdapter = New SqlDataAdapter("Select * from Products limit 4", sqlClient)

        Dim miDT As New DataTable, miDR As DataRow
        miDataA.Fill(miDT)
        For Each miDR In miDT.Rows
            MsgBox(miDR("CustomerID") & " - " & miDR("CompanyName"))
        Next
    End Sub

    Private Sub btnDataReader_Click(sender As Object, e As EventArgs) Handles btnDataReader.Click
        Dim miDT As New DataTable, miR As DataRow
        Dim miSqlCom As New SqlCommand("select * from Customers", sqlClient)

        miDataR = miSqlCom.ExecuteReader()
        miDT.Load(miDataR)
        For Each miR In miDT.Rows
            MsgBox(miR("CustomerID") & " - " & miR("CompanyName"))
        Next

        While miDataR.Read()
            Dim customerID As String = miDataR.GetString(0)
            Dim companyName As String = miDataR.GetString(1)
        End While
    End Sub

    Private Sub btnDataSet_Click(sender As Object, e As EventArgs) Handles btnDataSet.Click

    End Sub
End Class

