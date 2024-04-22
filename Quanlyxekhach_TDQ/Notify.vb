Public Class Notify


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Book.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Notity_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Application.Exit()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        User.Show()
        Me.Hide()
    End Sub

    Private Sub Notify_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class