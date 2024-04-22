Public Class Quy_19_Bai22
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim so% = 0
        Dim ip As String = InputBox("Nhập số lượng số: ")
        If Integer.TryParse(ip, so) Then
            Label2.Text = fnbai22(ip)
        Else
            MsgBox("Vui lòng nhập số!")
        End If
    End Sub
End Class