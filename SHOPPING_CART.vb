Public Class SHOPPING_CART
    Dim result As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        TextBox1.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then
            result += 10000
        End If
        If CheckBox2.Checked Then
            result += 30000
        End If
        If CheckBox3.Checked Then
            result += 4000
        End If
        If CheckBox4.Checked Then
            result += 1000
        End If
        If CheckBox5.Checked Then
            result += 2500
        End If
        If CheckBox6.Checked Then
            result += 2500
        End If
        If CheckBox7.Checked Then
            result += 60000
        End If
        TextBox1.Text = result
    End Sub
End Class
