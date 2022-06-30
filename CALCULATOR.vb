Public Class CALCULATOR
    Dim n1, n2, result As Double
    Dim op, s As String
    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        TextBox1.Text += "0"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text += "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text += "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text += "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text += "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text += "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text += "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text += "7"
    End Sub

    Private Sub Button_SUB_Click(sender As Object, e As EventArgs) Handles Button_SUB.Click
        n1 = Val(TextBox1.Text)
        TextBox1.Clear()
        op = "-"

    End Sub

    Private Sub Button_MUL_Click(sender As Object, e As EventArgs) Handles Button_MUL.Click
        n1 = Val(TextBox1.Text)
        TextBox1.Clear()
        op = "*"

    End Sub

    Private Sub Button_DIV_Click(sender As Object, e As EventArgs) Handles Button_DIV.Click
        n1 = Val(TextBox1.Text)
        TextBox1.Clear()
        op = "/"
    End Sub

    Private Sub Button_EQUAL_Click(sender As Object, e As EventArgs) Handles Button_EQUAL.Click
        n2 = Val(TextBox1.Text)
        Select Case op
            Case "+"
                result = n1 + n2
            Case "-"
                result = n1 - n2
            Case "*"
                result = n1 * n2
            Case "/"
                result = n1 / n2
        End Select
        TextBox1.Text = result
    End Sub

    Private Sub Button_CLEAR_Click(sender As Object, e As EventArgs) Handles Button_CLEAR.Click
        TextBox1.Clear()
    End Sub

    Private Sub Button_BACK_Click(sender As Object, e As EventArgs) Handles Button_BACK.Click
        s = TextBox1.Text
        If (s.Length <> 0) Then
            TextBox1.Text = s.Substring(0, s.Length - 1)
        End If
    End Sub

    Private Sub Button_DOT_Click(sender As Object, e As EventArgs) Handles Button_DOT.Click
        If (Not TextBox1.Text.Contains(".")) Then
            TextBox1.Text += "."
        End If
    End Sub
    Private Sub CALCULATOR_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text += "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text += "9"
    End Sub

    Private Sub Button_ADD_Click(sender As Object, e As EventArgs) Handles Button_ADD.Click
        n1 = Val(TextBox1.Text)
        TextBox1.Clear()
        op = "+"
    End Sub
End Class
