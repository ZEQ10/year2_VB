Public Class Quy_19_Bai33
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim so_19%
        If TextBox1.Text <> "" Or Integer.TryParse(TextBox1.Text, so_19) Then
            If fnbai33(TextBox1.Text) Then
                Label2.Text = "Có"
            Else
                Label2.Text = "Không"
            End If
        Else
            MsgBox("Vui lòng nhập số!")
        End If
    End Sub


End Class