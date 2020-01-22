<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VideoClubForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuVideoClub = New System.Windows.Forms.MenuStrip()
        Me.DVDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DVDsAlquiladosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlquilarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodosLosDvdsAlquiladosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodosLosDvdsNOAlquiladosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QueClienteTieneAlquiladoEnEsteMomentoCiertoDvdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SiUnDeterminadoClienteHaAlquiladoYaCiertoDvdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuVideoClub.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuVideoClub
        '
        Me.MenuVideoClub.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DVDToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.DVDsAlquiladosToolStripMenuItem, Me.ListadosToolStripMenuItem})
        Me.MenuVideoClub.Location = New System.Drawing.Point(0, 0)
        Me.MenuVideoClub.Name = "MenuVideoClub"
        Me.MenuVideoClub.Size = New System.Drawing.Size(800, 24)
        Me.MenuVideoClub.TabIndex = 0
        Me.MenuVideoClub.Text = "MenuStrip1"
        '
        'DVDToolStripMenuItem
        '
        Me.DVDToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.ConsultaToolStripMenuItem})
        Me.DVDToolStripMenuItem.Name = "DVDToolStripMenuItem"
        Me.DVDToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.DVDToolStripMenuItem.Text = "DVD"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.AltaToolStripMenuItem.Text = "Alta"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.ConsultaToolStripMenuItem.Text = "Consulta"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem1, Me.ConsultaToolStripMenuItem1})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'AltaToolStripMenuItem1
        '
        Me.AltaToolStripMenuItem1.Name = "AltaToolStripMenuItem1"
        Me.AltaToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
        Me.AltaToolStripMenuItem1.Text = "Alta"
        '
        'ConsultaToolStripMenuItem1
        '
        Me.ConsultaToolStripMenuItem1.Name = "ConsultaToolStripMenuItem1"
        Me.ConsultaToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
        Me.ConsultaToolStripMenuItem1.Text = "Consulta"
        '
        'DVDsAlquiladosToolStripMenuItem
        '
        Me.DVDsAlquiladosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlquilarToolStripMenuItem, Me.DevolverToolStripMenuItem})
        Me.DVDsAlquiladosToolStripMenuItem.Name = "DVDsAlquiladosToolStripMenuItem"
        Me.DVDsAlquiladosToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.DVDsAlquiladosToolStripMenuItem.Text = "Alquiler"
        '
        'AlquilarToolStripMenuItem
        '
        Me.AlquilarToolStripMenuItem.Name = "AlquilarToolStripMenuItem"
        Me.AlquilarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.AlquilarToolStripMenuItem.Text = "Alquilar"
        '
        'DevolverToolStripMenuItem
        '
        Me.DevolverToolStripMenuItem.Name = "DevolverToolStripMenuItem"
        Me.DevolverToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.DevolverToolStripMenuItem.Text = "Devolver"
        '
        'ListadosToolStripMenuItem
        '
        Me.ListadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DToolStripMenuItem, Me.TodosLosDvdsAlquiladosToolStripMenuItem, Me.TodosLosDvdsNOAlquiladosToolStripMenuItem, Me.QueClienteTieneAlquiladoEnEsteMomentoCiertoDvdToolStripMenuItem, Me.SiUnDeterminadoClienteHaAlquiladoYaCiertoDvdToolStripMenuItem})
        Me.ListadosToolStripMenuItem.Name = "ListadosToolStripMenuItem"
        Me.ListadosToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ListadosToolStripMenuItem.Text = "Listados"
        '
        'DToolStripMenuItem
        '
        Me.DToolStripMenuItem.Name = "DToolStripMenuItem"
        Me.DToolStripMenuItem.Size = New System.Drawing.Size(368, 22)
        Me.DToolStripMenuItem.Text = "Dvd's alquilados en este momento por un cliente"
        '
        'TodosLosDvdsAlquiladosToolStripMenuItem
        '
        Me.TodosLosDvdsAlquiladosToolStripMenuItem.Name = "TodosLosDvdsAlquiladosToolStripMenuItem"
        Me.TodosLosDvdsAlquiladosToolStripMenuItem.Size = New System.Drawing.Size(368, 22)
        Me.TodosLosDvdsAlquiladosToolStripMenuItem.Text = "Todos los Dvd's alquilados"
        '
        'TodosLosDvdsNOAlquiladosToolStripMenuItem
        '
        Me.TodosLosDvdsNOAlquiladosToolStripMenuItem.Name = "TodosLosDvdsNOAlquiladosToolStripMenuItem"
        Me.TodosLosDvdsNOAlquiladosToolStripMenuItem.Size = New System.Drawing.Size(368, 22)
        Me.TodosLosDvdsNOAlquiladosToolStripMenuItem.Text = "Todos los Dvd's NO alquilados"
        '
        'QueClienteTieneAlquiladoEnEsteMomentoCiertoDvdToolStripMenuItem
        '
        Me.QueClienteTieneAlquiladoEnEsteMomentoCiertoDvdToolStripMenuItem.Name = "QueClienteTieneAlquiladoEnEsteMomentoCiertoDvdToolStripMenuItem"
        Me.QueClienteTieneAlquiladoEnEsteMomentoCiertoDvdToolStripMenuItem.Size = New System.Drawing.Size(368, 22)
        Me.QueClienteTieneAlquiladoEnEsteMomentoCiertoDvdToolStripMenuItem.Text = "Que cliente tiene alquilado en este momento cierto Dvd"
        '
        'SiUnDeterminadoClienteHaAlquiladoYaCiertoDvdToolStripMenuItem
        '
        Me.SiUnDeterminadoClienteHaAlquiladoYaCiertoDvdToolStripMenuItem.Name = "SiUnDeterminadoClienteHaAlquiladoYaCiertoDvdToolStripMenuItem"
        Me.SiUnDeterminadoClienteHaAlquiladoYaCiertoDvdToolStripMenuItem.Size = New System.Drawing.Size(368, 22)
        Me.SiUnDeterminadoClienteHaAlquiladoYaCiertoDvdToolStripMenuItem.Text = "Si un determinado cliente ha alquilado ya cierto Dvd"
        '
        'VideoClubForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuVideoClub)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuVideoClub
        Me.Name = "VideoClubForm"
        Me.Text = "VideoClub"
        Me.MenuVideoClub.ResumeLayout(False)
        Me.MenuVideoClub.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuVideoClub As MenuStrip
    Friend WithEvents DVDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DVDsAlquiladosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AlquilarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DevolverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TodosLosDvdsAlquiladosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TodosLosDvdsNOAlquiladosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QueClienteTieneAlquiladoEnEsteMomentoCiertoDvdToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SiUnDeterminadoClienteHaAlquiladoYaCiertoDvdToolStripMenuItem As ToolStripMenuItem
End Class
