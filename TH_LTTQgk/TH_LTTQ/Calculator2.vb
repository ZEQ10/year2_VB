Public Class Calculator2
    Dim A As Double, B As Double, KQ As Double
    Dim C As String
    Dim ExitYN As System.Windows.Forms.DialogResult
    Private Sub Bang_Click(sender As Object, e As EventArgs) Handles Bang.Click
        B = HienThi.Text
        Select Case C
            Case "+"
                KQ = A + B
            Case "-"
                KQ = A - B
            Case "*"
                KQ = A * B
            Case "/"
                If (B <> 0) Then
                    KQ = A / B
                Else MsgBox("mẫu phải khác số 0!")
                End If
        End Select

        kqua.Text = KQ
    End Sub

    Private Sub Xoa_Click(sender As Object, e As EventArgs) Handles Xoa.Click
        kqua.Text = ""
        HienThi.Text = ""
    End Sub

    Private Sub Dong_Click(sender As Object, e As EventArgs) Handles Dong.Click
        ExitYN = MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo)
        If ExitYN = MsgBoxResult.Yes Then
            Close()
        Else
        End If
    End Sub

    Private Sub Cong_Click(sender As Object, e As EventArgs) Handles Cong.Click
        A = HienThi.Text
        C = "+"
        HienThi.Text = ""
    End Sub

    Private Sub Tru_Click(sender As Object, e As EventArgs) Handles Tru.Click
        A = HienThi.Text
        C = "-"
        HienThi.Text = ""
    End Sub

    Private Sub Nhan_Click(sender As Object, e As EventArgs) Handles Nhan.Click
        A = HienThi.Text
        C = "*"
        HienThi.Text = ""
    End Sub

    Private Sub Chia_Click(sender As Object, e As EventArgs) Handles Chia.Click
        A = HienThi.Text
        C = "/"
        HienThi.Text = ""
    End Sub
    Private Sub one_Click(sender As Object, e As EventArgs) Handles one.Click
        HienThi.Text = HienThi.Text & 1
    End Sub

    Private Sub two_Click(sender As Object, e As EventArgs) Handles two.Click
        HienThi.Text = HienThi.Text & 2
    End Sub

    Private Sub three_Click(sender As Object, e As EventArgs) Handles three.Click
        HienThi.Text = HienThi.Text & 3
    End Sub

    Private Sub four_Click(sender As Object, e As EventArgs) Handles four.Click
        HienThi.Text = HienThi.Text & 4
    End Sub

    Private Sub five_Click(sender As Object, e As EventArgs) Handles five.Click
        HienThi.Text = HienThi.Text & 5
    End Sub

    Private Sub six_Click(sender As Object, e As EventArgs) Handles six.Click
        HienThi.Text = HienThi.Text & 6
    End Sub

    Private Sub seven_Click(sender As Object, e As EventArgs) Handles seven.Click
        HienThi.Text = HienThi.Text & 7
    End Sub

    Private Sub eight_Click(sender As Object, e As EventArgs) Handles eight.Click
        HienThi.Text = HienThi.Text & 8
    End Sub

    Private Sub nine_Click(sender As Object, e As EventArgs) Handles nine.Click
        HienThi.Text = HienThi.Text & 9
    End Sub

    Private Sub zero_Click(sender As Object, e As EventArgs) Handles zero.Click
        HienThi.Text = HienThi.Text & 0
    End Sub

End Class