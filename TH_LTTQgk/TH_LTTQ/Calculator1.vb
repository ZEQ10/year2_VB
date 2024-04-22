Public Class Calculator1
    Dim A As Double
    Dim ExitYN As System.Windows.Forms.DialogResult

    Private Sub Cong_Click(sender As Object, e As EventArgs) Handles Cong.Click
        A = CDbl(nhap1.Text) + nhap2.Text

    End Sub

    Private Sub Tru_Click(sender As Object, e As EventArgs) Handles Tru.Click
        A = nhap1.Text - nhap2.Text

    End Sub

    Private Sub Nhan_Click(sender As Object, e As EventArgs) Handles Nhan.Click
        A = nhap1.Text * nhap2.Text
    End Sub

    Private Sub Chia_Click(sender As Object, e As EventArgs) Handles Chia.Click
        If (CInt(nhap2.Text) <> 0) Then
            A = nhap1.Text / nhap2.Text
        Else MsgBox("mẫu phải khác số 0!")
        End If
    End Sub

    Private Sub Bang_Click(sender As Object, e As EventArgs) Handles Bang.Click
        kqua.Text = A
    End Sub

    Private Sub Dong_Click(sender As Object, e As EventArgs) Handles Dong.Click
        ExitYN = MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo)
        If ExitYN = MsgBoxResult.Yes Then
            Close()
        Else
        End If
    End Sub

    Private Sub Xoa_Click(sender As Object, e As EventArgs) Handles Xoa.Click
        nhap1.Text = ""
        nhap2.Text = ""
        kqua.Text = ""
    End Sub
End Class
