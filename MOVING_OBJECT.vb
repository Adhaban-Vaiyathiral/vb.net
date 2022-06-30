Public Class MOVING_OBJECT
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'LEFT
        If (RadioButton1.Checked) Then
            If (PictureBox1.Left > 0) Then
                PictureBox1.Left -= 10
            Else
                PictureBox1.Left = Me.Width
            End If
        End If
        'RIGTH
        If (RadioButton2.Checked) Then
            If (PictureBox1.Left < Me.Width) Then
                PictureBox1.Left += 10
            Else
                PictureBox1.Left = 0
            End If
        End If
        'UP
        If (RadioButton3.Checked) Then
            If (PictureBox1.Top > 0) Then
                PictureBox1.Top -= 10
            Else
                PictureBox1.Top = Me.Height
            End If
        End If
        'DOWN
        If (RadioButton4.Checked) Then
            If (PictureBox1.Top < Me.Height) Then
                PictureBox1.Top += 10
            Else
                PictureBox1.Top = 0
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
