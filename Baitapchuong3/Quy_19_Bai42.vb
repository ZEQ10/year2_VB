Public Class Quy_19_Bai42
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim so_19%
        If TextBox1.Text <> "" Or Integer.TryParse(TextBox1.Text, so_19) Then

            Label3.Text = fnbai42(TextBox1.Text)
        Else
            MsgBox("Vui lòng nhập số!")
        End If
    End Sub
End Class