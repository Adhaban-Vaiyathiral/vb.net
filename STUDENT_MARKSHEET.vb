Public Class MARKSHEET
    'CALCULATE
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'TOTAL
        TextBox8.Text = Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox6.Text) + Val(TextBox7.Text)
        'AVERAGE
        TextBox9.Text = Val(TextBox8.Text) / 5
        'RESULT
        If Val(TextBox3.Text) > 39 And Val(TextBox4.Text) > 39 And Val(TextBox5.Text) > 39 And Val(TextBox6.Text) > 39 And Val(TextBox7.Text) > 39 Then
            TextBox10.Text = "PASS"
        Else TextBox10.Text = "FAIL"
        End If
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
        TextBox10.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
