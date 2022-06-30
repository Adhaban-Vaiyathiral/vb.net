Public Class BMI
    Dim w, h As Double
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        w = Val(TextBox1.Text)
        h = Val(TextBox2.Text)
        TextBox3.Text = w / (h * h)

        If (TextBox3.Text < 18.5) Then
            MsgBox("UNDER WEIGHT")
        ElseIf (TextBox3.Text > 18.5) And (TextBox3.Text < 24.9) Then
            MsgBox("NORMAL WEIGHT")
        ElseIf (TextBox3.Text > 25) And (TextBox3.Text < 29.9) Then
            MsgBox("OVER WEIGHT")
        ElseIf (TextBox3.Text > 30) And (TextBox3.Text < 34.9) Then
            MsgBox("OBESITY CLASS 1")
        ElseIf (TextBox3.Text > 35) And (TextBox3.Text < 39.9) Then
            MsgBox("OBESITY CLASS 2")
        Else
            MsgBox("OBESITY CLASS 3")
        End If

    End Sub
End Class