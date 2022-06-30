Public Class ARITHMETIC
    Dim n1, n2 As Double
    'ADD button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        n1 = Val(TextBox1.Text)
        n2 = Val(TextBox2.Text)
        TextBox3.Text = n1 + n2
    End Sub
    'MUL button
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        n1 = Val(TextBox1.Text)
        n2 = Val(TextBox2.Text)
        TextBox3.Text = n1 * n2
    End Sub
    'DIV button
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        n1 = Val(TextBox1.Text)
        n2 = Val(TextBox2.Text)
        TextBox3.Text = n1 / n2
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        End
    End Sub
    'SUB button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        n1 = Val(TextBox1.Text)
        n2 = Val(TextBox2.Text)
        TextBox3.Text = n1 - n2
    End Sub
End Class