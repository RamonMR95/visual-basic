Public Class CrearMenusForm

    Public tsmiAzulF As ToolStripMenuItem
    Public tsmiAzulC As ToolStripMenuItem
    Public tsmiRojoF As ToolStripMenuItem
    Public tsmiRojoC As ToolStripMenuItem
    Public tsmiVerdeF As ToolStripMenuItem
    Public tsmiVerdeC As ToolStripMenuItem
    Public miPegar As MenuItem
    Public miSeleccionarTodo As MenuItem
    Public miCortar As MenuItem
    Public miCopiar As MenuItem
    Public cMenu As ContextMenu

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        cMenu = New ContextMenu
        rtbTexto.ContextMenu = cMenu
        miCopiar = New MenuItem("Copiar")
        miCortar = New MenuItem("Cortar")
        miPegar = New MenuItem("Pegar")
        miSeleccionarTodo = New MenuItem("Seleccionar todo")
        addHandlersContextMenuItems()
        rtbTexto.AutoWordSelection = False
    End Sub

    Private Sub CBAzul_CheckStateChanged(sender As Object, e As EventArgs) Handles CBAzul.CheckStateChanged
        If CBAzul.Checked Then
            tsmiAzulF = New ToolStripMenuItem("Azul")
            tsmiAzulC = New ToolStripMenuItem("Azul")
            AddHandler tsmiAzulF.Click, AddressOf cambiarColorFondoFormulario
            addItem(FondoFormularioToolStripMenuItem, tsmiAzulF)
            AddHandler tsmiAzulC.Click, AddressOf cambiarColorTexto
            addItem(ColorFuenteToolStripMenuItem, tsmiAzulC)
        Else
            removeItem(FondoFormularioToolStripMenuItem, tsmiAzulF)
            removeItem(ColorFuenteToolStripMenuItem, tsmiAzulC)
        End If
    End Sub

    Private Sub CBRojo_CheckStateChanged(sender As Object, e As EventArgs) Handles CBRojo.CheckStateChanged
        If CBRojo.Checked Then
            tsmiRojoF = New ToolStripMenuItem("Rojo")
            tsmiRojoC = New ToolStripMenuItem("Rojo")
            AddHandler tsmiRojoF.Click, AddressOf cambiarColorFondoFormulario
            addItem(FondoFormularioToolStripMenuItem, tsmiRojoF)
            AddHandler tsmiRojoC.Click, AddressOf cambiarColorTexto
            addItem(ColorFuenteToolStripMenuItem, tsmiRojoC)
        Else
            removeItem(FondoFormularioToolStripMenuItem, tsmiRojoF)
            removeItem(ColorFuenteToolStripMenuItem, tsmiRojoC)
        End If
    End Sub

    Private Sub CBVerde_CheckStateChanged(sender As Object, e As EventArgs) Handles CBVerde.CheckStateChanged
        If CBVerde.Checked Then
            tsmiVerdeF = New ToolStripMenuItem("Verde")
            tsmiVerdeC = New ToolStripMenuItem("Verde")
            AddHandler tsmiVerdeF.Click, AddressOf cambiarColorFondoFormulario
            addItem(FondoFormularioToolStripMenuItem, tsmiVerdeF)
            AddHandler tsmiVerdeC.Click, AddressOf cambiarColorTexto
            addItem(ColorFuenteToolStripMenuItem, tsmiVerdeC)
        Else
            removeItem(FondoFormularioToolStripMenuItem, tsmiVerdeF)
            removeItem(ColorFuenteToolStripMenuItem, tsmiVerdeC)
        End If
    End Sub

    Private Sub addItem(Menu As ToolStripMenuItem, item As ToolStripMenuItem)
        Menu.DropDownItems.Add(item)
    End Sub

    Private Sub removeItem(Menu As ToolStripMenuItem, item As ToolStripMenuItem)
        Menu.DropDownItems.Remove(item)
    End Sub

    Private Sub cambiarColorFondoFormulario(sender As Object, e As EventArgs)
        Select Case sender.text
            Case "Azul"
                Me.BackColor = Color.Blue
            Case "Rojo"
                Me.BackColor = Color.Red
            Case "Verde"
                Me.BackColor = Color.Green
        End Select
    End Sub

    Private Sub cambiarColorTexto(sender As Object, e As EventArgs)
        Select Case sender.text
            Case "Azul"
                rtbTexto.ForeColor = Color.Blue
            Case "Rojo"
                rtbTexto.ForeColor = Color.Red
            Case "Verde"
                rtbTexto.ForeColor = Color.Green
        End Select
    End Sub

    Private Sub rtbTexto_SelectionChanged(sender As Object, e As EventArgs) Handles rtbTexto.SelectionChanged
        If rtbTexto.SelectionLength > 0 Then
            addMenuItem(miCortar)
            addMenuItem(miCopiar)
            addMenuItem(miPegar)
            removeMenuItem(miSeleccionarTodo)
        Else
            addMenuItem(miSeleccionarTodo)
            addMenuItem(miPegar)
            removeMenuItem(miCortar)
            removeMenuItem(miCopiar)
        End If
    End Sub

    Private Sub addMenuItem(item As MenuItem)
        If Not cMenu.MenuItems.Contains(item) Then
            cMenu.MenuItems.Add(item)
        End If
    End Sub
    Private Sub removeMenuItem(item As MenuItem)
        If cMenu.MenuItems.Contains(item) Then
            cMenu.MenuItems.Remove(item)
        End If
    End Sub

    Private Sub addHandlersContextMenuItems()
        AddHandler miSeleccionarTodo.Click, AddressOf seleccionarTodo
        AddHandler miCortar.Click, AddressOf cortar
        AddHandler miCopiar.Click, AddressOf copiar
        AddHandler miPegar.Click, AddressOf pegar
    End Sub

    Private Sub cortar()
        rtbTexto.Cut()
    End Sub
    Private Sub copiar()
        rtbTexto.Copy()
    End Sub

    Private Sub pegar()
        rtbTexto.Paste()
    End Sub

    Private Sub seleccionarTodo()
        rtbTexto.SelectAll()
    End Sub

End Class
