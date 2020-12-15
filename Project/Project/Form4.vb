Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Breakdown_Click(sender As Object, e As EventArgs) Handles Breakdown.Click
        Form2.Show()
        Call Form1.breakdwn()
    End Sub


End Class