Public Class DienTichHinhThang


    Private Sub Tinh_Click(sender As Object, e As EventArgs) Handles Tinh.Click
        ketQua.Text = S_HinhThang1(nhapA.Text, nhapB.Text, nhapH.Text)
    End Sub

    Private Sub Tinh2_Click(sender As Object, e As EventArgs) Handles Tinh2.Click
        Call S_HinhThang2(nhapA2.Text, nhapB2.Text, nhapH2.Text)
    End Sub

    Private Sub Tinh3_Click(sender As Object, e As EventArgs) Handles Tinh3.Click
        ketQua2.Text = bai14(nhapN.Text)
    End Sub

    Private Sub Tinh4_Click(sender As Object, e As EventArgs) Handles Tinh4.Click
        ketQua3.Text = bai15(nhapN2.Text)
    End Sub

    Private Sub Nhap1_Click(sender As Object, e As EventArgs) Handles Nhap1.Click
        Dim n As Integer
        n = InputBox("Nhập số lượng phần tử của dãy: ")
        solenhonhat.Text = bai30(n)
    End Sub

    Private Sub nhap2_Click(sender As Object, e As EventArgs) Handles nhap2.Click
        Dim n As Integer
        n = InputBox("Nhập số lượng phần tử của dãy: ")
        tbcongSoChan.Text = bai31(n)
    End Sub

    Private Sub nhap3_Click(sender As Object, e As EventArgs) Handles nhap3.Click
        Dim n As Integer
        n = InputBox("Nhập số: ")
        tongcacsoCuaSoNguyen.Text = bai38(n)
    End Sub

    Private Sub Tinh5_Click(sender As Object, e As EventArgs) Handles Tinh5.Click
        UCLN.Text = TimUSCLN_BaSo(nhapA3.Text, nhapB3.Text, nhapC3.Text)
    End Sub
End Class