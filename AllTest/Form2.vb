Public Class Form2


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = bcnn(TextBox1.Text, TextBox2.Text)
    End Sub
End Class
