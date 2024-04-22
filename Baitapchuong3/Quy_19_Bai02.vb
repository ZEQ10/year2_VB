Public Class Quy_19_Bai02
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim so%
        If TextBox1.Text <> "" Or TextBox2.Text <> "" Or TextBox3.Text <> "" Or Integer.TryParse(TextBox1.Text, so) Or Integer.TryParse(TextBox2.Text, so) Or Integer.TryParse(TextBox3.Text, so) Then
            subbai2(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        Else
            MsgBox("Vui lòng nhập số!")
        End If
    End Sub
End Class