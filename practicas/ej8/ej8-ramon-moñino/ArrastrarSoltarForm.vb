Public Class ArrastrarSoltarForm

    Public errorProvider As ErrorProvider

    Private Sub ArrastrarSoltarForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        errorProvider = New ErrorProvider
    End Sub

    Private Sub lb1_DragEnter(sender As Object, e As DragEventArgs) Handles lb1.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.All
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub


    Private Sub lb1_MouseMove(sender As Object, e As MouseEventArgs) Handles lb1.MouseMove
        If e.Button = MouseButtons.Left Then
            lb1.AllowDrop = False
            lb2.AllowDrop = True
            lb1.DoDragDrop(lb1.GetItemText(lb1.SelectedItem), DragDropEffects.All)
        End If
    End Sub


    Private Sub lb2_MouseMove(sender As Object, e As MouseEventArgs) Handles lb2.MouseMove
        If e.Button = MouseButtons.Left Then
            lb1.AllowDrop = True
            lb2.AllowDrop = False
            lb2.DoDragDrop(lb2.GetItemText(lb2.SelectedItem), DragDropEffects.All)
        End If
    End Sub


    Private Sub lb2_DragEnter(sender As Object, e As DragEventArgs) Handles lb2.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.All
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub


    Private Sub intercambiarListItem(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click
        Select Case sender.text
            Case ">"
                If lb1.SelectedIndex <> -1 Then
                    lb2.Items.Add(lb1.SelectedItem)
                    lb1.Items.Remove(lb1.SelectedItem)
                    errorProvider.SetError(lb1, "")
                Else
                    errorProvider.SetError(lb1, "Nada seleccionado")
                End If
            Case ">>"
                For index = 0 To lb1.Items.Count - 1
                    lb2.Items.Add(lb1.Items(index))
                Next
                lb1.Items.Clear()
            Case "<<"
                For index = 0 To lb2.Items.Count - 1
                    lb1.Items.Add(lb2.Items(index))
                Next
                lb2.Items.Clear()
            Case "<"
                If lb2.SelectedIndex <> -1 Then
                    lb1.Items.Add(lb2.SelectedItem)
                    lb2.Items.Remove(lb2.SelectedItem)
                    errorProvider.SetError(lb2, "")
                Else
                    errorProvider.SetError(lb2, "Nada seleccionado")
                End If
        End Select
    End Sub


    Private Sub lb1_DragDrop(sender As Object, e As DragEventArgs) Handles lb1.DragDrop
        lb1.Items.Add(lb2.SelectedItem)
        lb2.Items.Remove(lb2.SelectedItem)
    End Sub


    Private Sub lb2_DragDrop(sender As Object, e As DragEventArgs) Handles lb2.DragDrop
        lb2.Items.Add(lb1.SelectedItem)
        lb1.Items.Remove(lb1.SelectedItem)
    End Sub


End Class
