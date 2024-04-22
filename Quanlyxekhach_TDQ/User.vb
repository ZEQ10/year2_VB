Public Class User
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Book.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Notify.Show()
        Me.Hide()
    End Sub
    Private Sub User_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Application.Exit()
    End Sub

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class