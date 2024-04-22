Public Class bai2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            Label5.Text = Label5.Text & fnbai2(TextBox1.Text)
        End If
    End Sub
End Class