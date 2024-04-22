Imports Microsoft.VisualBasic.CompilerServices


Public Class Maytinh


    Private Sub nhap_TextChanged(sender As Object, e As EventArgs) Handles nhap.TextChanged

    End Sub

    Private Sub n1_Click(sender As Object, e As EventArgs) Handles n1.Click
        nhap.Text = nhap.Text & "1"
    End Sub

    Private Sub n2_Click(sender As Object, e As EventArgs) Handles n2.Click
        nhap.Text = nhap.Text & "2"
    End Sub

    Private Sub n3_Click(sender As Object, e As EventArgs) Handles n3.Click
        nhap.Text = nhap.Text & "3"
    End Sub

    Private Sub n4_Click(sender As Object, e As EventArgs) Handles n4.Click
        nhap.Text = nhap.Text & "4"
    End Sub

    Private Sub n5_Click(sender As Object, e As EventArgs) Handles n5.Click
        nhap.Text = nhap.Text & "5"
    End Sub

    Private Sub n6_Click(sender As Object, e As EventArgs) Handles n6.Click
        nhap.Text = nhap.Text & "6"
    End Sub

    Private Sub n7_Click(sender As Object, e As EventArgs) Handles n7.Click
        nhap.Text = nhap.Text & "7"
    End Sub

    Private Sub n8_Click(sender As Object, e As EventArgs) Handles n8.Click
        nhap.Text = nhap.Text & "8"
    End Sub

    Private Sub n9_Click(sender As Object, e As EventArgs) Handles n9.Click
        nhap.Text = nhap.Text & "9"
    End Sub

    Private Sub cong_Click(sender As Object, e As EventArgs) Handles cong.Click
        nhap.Text = nhap.Text & "+"
    End Sub

    Private Sub tru_Click(sender As Object, e As EventArgs) Handles tru.Click
        nhap.Text = nhap.Text & "-"
    End Sub

    Private Sub nhan_Click(sender As Object, e As EventArgs) Handles nhan.Click
        nhap.Text = nhap.Text & "*"
    End Sub

    Private Sub chia_Click(sender As Object, e As EventArgs) Handles chia.Click
        nhap.Text = nhap.Text & "/"
    End Sub

    Private Sub luythua_Click(sender As Object, e As EventArgs) Handles luythua.Click
        nhap.Text = nhap.Text & "^"
    End Sub

    Private Sub cb2_Click(sender As Object, e As EventArgs) Handles cb2.Click
        nhap.Text = nhap.Text & "√"
    End Sub

    Private Sub xoa_Click(sender As Object, e As EventArgs) Handles xoa.Click
        nhap.Clear()
    End Sub

    Private Sub bang_Click(sender As Object, e As EventArgs) Handles bang.Click
        Dim KQs As String = nhap.Text
        Dim KQn As Double =
        ketqua.Text = KQn.ToString
    End Sub
End Class
