Public Class CLOCK
    Private Sub CLOCK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = TimeString
        Timer1.Start()
        Timer1.Interval = 1000
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = TimeString
    End Sub
End Class