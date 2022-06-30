Public Class DRAWING_SHAPES
    Dim c As String
    Dim g As Graphics
    Dim x1, x2, y1, y2, w, h As Integer

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        c = "FE"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        c = "E"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        c = "FR"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        c = "R"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        c = "L"
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        x1 = e.X
        y1 = e.Y

    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        g = PictureBox1.CreateGraphics
        x2 = e.X
        y2 = e.Y
        w = x2 - x1
        h = y2 - y1

        Select Case c
            Case "L"
                g.DrawLine(Pens.BlueViolet, x1, y1, x2, y2)
            Case "R"
                g.DrawRectangle(Pens.CornflowerBlue, x1, y1, w, h)
            Case "FR"
                g.FillRectangle(Brushes.CornflowerBlue, x1, y1, w, h)
            Case "E"
                g.DrawEllipse(Pens.Gold, x1, y1, w, h)
            Case "FE"
                g.FillEllipse(Brushes.Gold, x1, y1, w, h)
        End Select
    End Sub
End Class