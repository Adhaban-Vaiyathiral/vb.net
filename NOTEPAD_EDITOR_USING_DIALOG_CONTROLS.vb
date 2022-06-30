Public Class NOTEPAD_EDITOR_USING_DIALOG_CONTROLS
    Dim a As Form2
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        RichTextBox1.Clear()
        Me.Text = "UNTITLED"
    End Sub

    Private Sub OpenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem1.Click
        OpenFileDialog1.Filter = "Text Files|*.text"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            RichTextBox1.LoadFile(OpenFileDialog1.FileName)
            Me.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.Filter = "Text Files|*.text"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            RichTextBox1.SaveFile(SaveFileDialog1.FileName)
            Me.Text = SaveFileDialog1.FileName
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub OPENToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPENToolStripMenuItem.Click
        If RichTextBox1.CanUndo Then
            RichTextBox1.Undo()
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CoyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        If FontDialog1.ShowDialog = DialogResult.OK Then
            RichTextBox1.SelectionFont = FontDialog1.Font
        End If
    End Sub

    Private Sub TextColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextColorToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            RichTextBox1.SelectionColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub AboutMyEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutMyEditorToolStripMenuItem.Click
        Dim a As Form = New AboutMyEditor()
        a.Show()
    End Sub
End Class