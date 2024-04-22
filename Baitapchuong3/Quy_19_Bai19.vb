Public Class Quy_19_Bai19
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim so%
        If TextBox1.Text <> "" Or Integer.TryParse(TextBox1.Text, so) Then
            Label2.Text = fnbai19(TextBox1.Text)
        Else
            MsgBox("Vui lòng nhập số!")
        End If
    End Sub
End Class