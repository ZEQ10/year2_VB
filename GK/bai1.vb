Public Class bai1

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" Then
            subbai1(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        End If
    End Sub
End Class