Public Class EMPLOYEE
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'DA
        TextBox5.Text = Val(TextBox4.Text) * 0.3
        'HRA
        TextBox6.Text = Val(TextBox4.Text) * 0.1
        'PF
        TextBox7.Text = Val(TextBox4.Text) * 0.08
        'GROSS PAY
        TextBox8.Text = Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox6.Text)
        'NET PAY
        TextBox9.Text = Val(TextBox4.Text) - Val(TextBox7.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
