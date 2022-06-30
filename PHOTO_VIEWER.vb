Public Class PHOTO_VIEWER
    Dim loc, first, last As Integer

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        loc = last
        PictureBox1.Image = ImageList1.Images(loc)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If loc <> first Then
            loc = loc - 1
        End If
        PictureBox1.Image = ImageList1.Images(loc)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If loc <> last Then
            loc = loc + 1
        End If
        PictureBox1.Image = ImageList1.Images(loc)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Timer1.Enabled = True
            Timer1.Interval = 1000
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Call Button3_Click(sender, e)

        If loc <> last Then
            loc = loc + 1
        Else
            loc = first
        End If

        PictureBox1.Image = ImageList1.Images(loc)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loc = first
        PictureBox1.Image = ImageList1.Images(loc)
    End Sub

    Private Sub PHOTO_VIEWER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        first = 0
        last = ImageList1.Images.Count - 1
    End Sub
End Class
