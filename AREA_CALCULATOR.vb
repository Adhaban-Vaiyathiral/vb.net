Public Class AREA_CALCULATOR
    Dim area As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        area = Val(TextBox1.Text) * Val(TextBox1.Text)
        TextBox2.Text = area
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        area = Math.PI * Val(TextBox3.Text) * Val(TextBox3.Text)
        TextBox4.Text = area
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        area = 0.5 * Val(TextBox5.Text) * Val(TextBox6.Text)
        TextBox7.Text = area
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        area = Val(TextBox8.Text) * Val(TextBox9.Text)
        TextBox10.Text = area
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        End
    End Sub

End Class
