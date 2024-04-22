Public Class Home
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Book.Show()
        Me.Hide()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Notify.Show()
        Me.Hide()
    End Sub
    Private Sub Home_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        User.Show()
        Me.Hide()
    End Sub
End Class
