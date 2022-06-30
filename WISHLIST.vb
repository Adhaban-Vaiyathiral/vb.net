Public Class WISHLIST
    Private Sub WISHLIST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Going to Gym")
        ComboBox1.Items.Add("Spending some Time with Family")
        ComboBox1.Items.Add("Going To College")
        ComboBox1.Items.Add("Doing A Online Course")
        ComboBox1.Items.Add("Wacth IPL in Stadium")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(ComboBox1.Text)
        TextBox1.Text = ListBox1.Items.Count
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (ListBox1.SelectedIndex = -1) Then
            MsgBox("First Select the Item to get Removed")
        Else
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        End If
        TextBox1.Text = ListBox1.Items.Count
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        TextBox1.Text = ListBox1.Items.Count
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Sorted = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub
End Class