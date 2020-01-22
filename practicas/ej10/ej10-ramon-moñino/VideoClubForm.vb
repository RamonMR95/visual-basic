Public Class VideoClubForm
    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        AltaDVDForm.MdiParent = Me
        AltaDVDForm.Show()
    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click
        ConsultaDVDForm.MdiParent = Me
        ConsultaDVDForm.Show()
    End Sub

    Private Sub AltaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem1.Click
        If clientes.Count = 0 Then
            For index = 1 To 3
                Dim cliente As New Cliente("C" & index, "C/" & index, "00000" & index, "C" & index & "@gmail.com")
                clientes.Add(cliente, cliente.codigo)
            Next
        End If
    End Sub

    Private Sub ConsultaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem1.Click
        If clientes.Count > 0 Then
            ConsultaClienteForm.MdiParent = Me
            ConsultaClienteForm.Show()
        Else
            MsgBox("La base de datos no contiene ningún cliente")
        End If
    End Sub

    Private Sub AlquilarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlquilarToolStripMenuItem.Click
        AlquilarForm.MdiParent = Me
        AlquilarForm.Show()
    End Sub

    Private Sub DevolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevolverToolStripMenuItem.Click
        DevolverForm.MdiParent = Me
        DevolverForm.Show()
    End Sub

    Private Sub dvdsAlquiladosPorCliente(sender As Object, e As EventArgs) Handles DToolStripMenuItem.Click
        DvdsAlquiladosPorClienteForm.MdiParent = Me
        DvdsAlquiladosPorClienteForm.Show()
    End Sub

    Private Sub TodosLosDvdsAlquiladosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodosLosDvdsAlquiladosToolStripMenuItem.Click
        TodosLosDvdsAlquiladosForm.MdiParent = Me
        TodosLosDvdsAlquiladosForm.Show()
    End Sub

    Private Sub TodosLosDvdsNOAlquiladosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodosLosDvdsNOAlquiladosToolStripMenuItem.Click
        TodosLosDVDsNoAlquiladosForm.MdiParent = Me
        TodosLosDVDsNoAlquiladosForm.Show()
    End Sub

    Private Sub QueClienteTieneAlquiladoEnEsteMomentoCiertoDvdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QueClienteTieneAlquiladoEnEsteMomentoCiertoDvdToolStripMenuItem.Click
        QueClienteTieneAlquiladoEnEsteMomentoCiertoDvdForm.MdiParent = Me
        QueClienteTieneAlquiladoEnEsteMomentoCiertoDvdForm.Show()
    End Sub

    Private Sub SiUnDeterminadoClienteHaAlquiladoYaCiertoDvdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SiUnDeterminadoClienteHaAlquiladoYaCiertoDvdToolStripMenuItem.Click
        SiUnDeterminadoClienteHaAlquiladoYaCiertoDvdForm.MdiParent = Me
        SiUnDeterminadoClienteHaAlquiladoYaCiertoDvdForm.Show()
    End Sub
End Class
