Public Class BTChuong3
    '==================================Bài 3======================================'
    Private Sub Tinh3_Click(sender As Object, e As EventArgs) Handles Tinh3.Click
        If (nhapR.Text < 0) Then
            MsgBox("Bán kính phải lớn hơn 0")
        Else
            ketQua3.Text = bai3(nhapR.Text)
        End If
    End Sub
    '==================================Bài 4======================================'
    Private Sub Tinh4_Click(sender As Object, e As EventArgs) Handles Tinh4.Click
        If (nhapR2.Text < 0) Then
            MsgBox("Bán kính phải lớn hơn 0")
        Else
            Call bai4(nhapR2.Text)
        End If
    End Sub
    '==================================Bài 5======================================'
    Private Sub Tinh5_Click(sender As Object, e As EventArgs) Handles Tinh5.Click
        If canhDay.Text < 0 And chieuCao.Text < 0 Then
            MsgBox("Cạnh đáy và chiều cao phải lớn hơn 0")
        ElseIf (chieuCao.Text < 0) Then
            MsgBox("Chiều cao phải lớn hơn 0")
        ElseIf (canhDay.Text < 0) Then
            MsgBox("Cạnh đáy phải lớn hơn 0")
        Else
            ketQua5.Text = bai5(canhDay.Text, chieuCao.Text)
        End If
    End Sub
    '==================================Bài 6======================================'
    Private Sub Tinh6_Click(sender As Object, e As EventArgs) Handles Tinh6.Click
        If canhDay2.Text < 0 And chieuCao2.Text < 0 Then
            MsgBox("Cạnh đáy và chiều cao phải lớn hơn 0")
        ElseIf (chieuCao2.Text < 0) Then
            MsgBox("Chiều cao phải lớn hơn 0")
        ElseIf (canhDay2.Text < 0) Then
            MsgBox("Cạnh đáy phải lớn hơn 0")
        Else
            Call bai6(canhDay2.Text, chieuCao2.Text)
        End If

    End Sub
    '==================================Bài 7======================================'
    Private Sub Tinh7_Click(sender As Object, e As EventArgs) Handles Tinh7.Click
        If nhapA.Text < 0 And nhapB.Text < 0 And nhapC.Text < 0 Then
            MsgBox("Các cạnh phải lớn hơn 0")
        ElseIf nhapA.Text < 0 Then
            MsgBox("cạnh a phải lớn hơn 0")
        ElseIf nhapB.Text < 0 Then
            MsgBox("cạnh b phải lớn hơn 0")
        ElseIf nhapC.Text < 0 Then
            MsgBox("cạnh c phải lớn hơn 0")
        Else
            ketQua7.Text = bai7(nhapA.Text, nhapB.Text, nhapC.Text)
        End If
    End Sub
    '==================================Bài 8======================================'
    Private Sub Tinh8_Click(sender As Object, e As EventArgs) Handles Tinh8.Click
        If nhapA2.Text < 0 And nhapB2.Text < 0 And nhapC2.Text < 0 Then
            MsgBox("Các cạnh phải lớn hơn 0")
        ElseIf nhapA2.Text < 0 Then
            MsgBox("cạnh a phải lớn hơn 0")
        ElseIf nhapB2.Text < 0 Then
            MsgBox("cạnh b phải lớn hơn 0")
        ElseIf nhapC2.Text < 0 Then
            MsgBox("cạnh c phải lớn hơn 0")
        Else
            Call bai8(nhapA2.Text, nhapB2.Text, nhapC2.Text)
        End If
    End Sub
    '==================================Bài 9======================================'
    Private Sub Tinh9_Click(sender As Object, e As EventArgs) Handles Tinh9.Click
        If (nhapR3.Text < 0) Then
            MsgBox("Bán kính phải lớn hơn 0")
        Else
            ketQua9.Text = bai9(nhapR3.Text)
        End If
    End Sub
    '==================================Bài 10====================================='
    Private Sub Tinh10_Click(sender As Object, e As EventArgs) Handles Tinh10.Click
        If (nhapR4.Text < 0) Then
            MsgBox("Bán kính phải lớn hơn 0")
        Else
            Call bai10(nhapR4.Text)
        End If
    End Sub
    '==================================Bài 11====================================='
    Private Sub Tinh11_Click(sender As Object, e As EventArgs) Handles Tinh11.Click
        If (nhapN11.Text < 0) Then
            MsgBox("Số nhập vào phải dương")
        Else
            ketQua11.Text = bai11(nhapN11.Text)
        End If

    End Sub
    '==================================Bài 12====================================='
    Private Sub Tinh12_Click(sender As Object, e As EventArgs) Handles Tinh12.Click
        If (nhapN12.Text < 0) Then
            MsgBox("Số nhập vào phải dương")
        Else
            ketQua12.Text = bai12(nhapN12.Text)
        End If
    End Sub
    '==================================Bài 13====================================='
    Private Sub Tinh13_Click(sender As Object, e As EventArgs) Handles Tinh13.Click
        If (nhapN13.Text < 0) Then
            MsgBox("Số nhập vào phải dương")
        Else
            ketQua13.Text = bai13(nhapN13.Text)
        End If
    End Sub
    '==================================Bài 16====================================='
    Private Sub Tinh16_Click(sender As Object, e As EventArgs) Handles Tinh16.Click
        If (nhapN16.Text < 0) Then
            MsgBox("Số nhập vào phải dương")
        Else
            ketQua16.Text = bai16(nhapN16.Text)
        End If
    End Sub
    '==================================Bài 17====================================='
    Private Sub Tinh17_Click(sender As Object, e As EventArgs) Handles Tinh17.Click
        If (nhapN17.Text < 0) Then
            MsgBox("Số nhập vào phải lớn hơn 0")
        Else
            ketQua17.Text = bai17(nhapN17.Text)
        End If
    End Sub
    '==================================Bài 18====================================='
    Private Sub Tinh18_Click(sender As Object, e As EventArgs) Handles Tinh18.Click
        If (nhapN18.Text < 0) Then
            MsgBox("Số nhập vào phải lớn hơn 0")
        Else
            ketQua18.Text = bai18_2(nhapN18.Text)
        End If
    End Sub
    '==================================Bài 19====================================='
    Private Sub Tinh19_Click(sender As Object, e As EventArgs) Handles Tinh19.Click
        If (nhapN19.Text < 0) Then
            MsgBox("Số nhập vào phải lớn hơn 0")
        Else
            ketQua19.Text = bai19_2(nhapN19.Text)
        End If
    End Sub
    '==================================Bài 20====================================='
    Private Sub Tinh20_Click(sender As Object, e As EventArgs) Handles Tinh20.Click
        If (nhapN20.Text < 0) Then
            MsgBox("Số nhập vào phải lớn hơn 0")
        Else
            ketQua20.Text = bai20_2(nhapN20.Text)
        End If
    End Sub
    '==================================Bài 21====================================='
    Private Sub Tinh21_Click(sender As Object, e As EventArgs) Handles Tinh21.Click
        Dim n As Integer
        n = InputBox("Nhập bao nhiêu phần tử?")
        If (n < 0) Then
            MsgBox("Số nhập vào phải lớn hơn 0")
        Else
            ketQua21.Text = "Tổng là: " & bai21(n)
        End If
    End Sub
    '==================================Bài 22====================================='
    Private Sub Tinh22_Click(sender As Object, e As EventArgs) Handles Tinh22.Click
        Dim n As Integer
        n = InputBox("Nhập bao nhiêu phần tử?")
        If (n < 0) Then
            MsgBox("Số nhập vào phải lớn hơn 0")
        Else
            ketQua22.Text = "Tổng là: " & bai22(n)
        End If
    End Sub
    '==================================Bài 23====================================='
    Private Sub Tinh23_Click(sender As Object, e As EventArgs) Handles Tinh23.Click
        Dim n As Integer
        n = InputBox("Nhập bao nhiêu phần tử?")
        If (n < 0) Then
            MsgBox("Số nhập vào phải lớn hơn 0")
        Else
            ketQua23.Text = "Tổng là: " & bai23(n)
        End If
    End Sub
    '==================================Bài 24====================================='
    Private Sub Tinh24_Click(sender As Object, e As EventArgs) Handles Tinh24.Click
        Dim n As Integer
        n = InputBox("Nhập bao nhiêu phần tử?")
        If (n < 0) Then
            MsgBox("Số nhập vào phải lớn hơn 0")
        Else
            ketQua24.Text = "Tổng là: " & bai24(n)
        End If
    End Sub
    '==================================Bài 25====================================='
    Private Sub Tinh25_Click(sender As Object, e As EventArgs) Handles Tinh25.Click
        Dim n As Integer
        n = InputBox("Nhập bao nhiêu phần tử?")
        If (n < 0) Then
            MsgBox("Số nhập vào phải lớn hơn 0")
        Else
            ketQua25.Text = "Tổng là: " & bai25(n)
        End If
    End Sub
    '==================================Bài 26====================================='
    Private Sub Tinh26_Click(sender As Object, e As EventArgs) Handles Tinh26.Click
        Dim n As Integer
        n = InputBox("Nhập bao nhiêu phần tử?")
        If (n < 0) Then
            MsgBox("Số nhập vào phải lớn hơn 0")
        Else
            ketQua26.Text = "Tổng là: " & bai26(n)
        End If
    End Sub
    '==================================Bài 27====================================='
    Private Sub Tim27_Click(sender As Object, e As EventArgs) Handles Tim27.Click
        Dim n As Integer
        n = InputBox("Nhập bao nhiêu phần tử?")
        If (n < 0) Then
            MsgBox("Số nhập vào phải lớn hơn 0")
        Else
            ketQua27.Text = "Số lớn nhất là: " & bai27(n)
        End If
    End Sub
    '==================================Bài 28====================================='
    Private Sub Tim28_Click(sender As Object, e As EventArgs) Handles Tim28.Click
        Dim n As Integer
        n = InputBox("Nhập bao nhiêu phần tử?")
        If (n < 0) Then
            MsgBox("Số nhập vào phải lớn hơn 0")
        Else
            ketQua28.Text = "Số nhỏ nhất là: " & bai28(n)
        End If
    End Sub
    '==================================Bài 29====================================='
    Private Sub Tim29_Click(sender As Object, e As EventArgs) Handles Tim29.Click
        Dim n As Integer
        n = InputBox("Nhập bao nhiêu phần tử?")
        If (n < 0) Then
            MsgBox("Số nhập vào phải lớn hơn 0")
        Else
            ketQua29.Text = "Số chẳn lớn nhất là: " & bai29(n)
        End If
    End Sub
    '==================================Bài 32====================================='
    Private Sub Tim32_Click(sender As Object, e As EventArgs) Handles Tim32.Click
        Dim n As Integer
        n = InputBox("Nhập bao nhiêu phần tử?")
        If (n < 0) Then
            MsgBox("Số nhập vào phải lớn hơn 0")
        Else
            ketQua32.Text = "Số chẳn đầu tiên trong dãy là: " & bai32(n)
        End If
    End Sub
    '==================================Bài 33====================================='
    Private Sub Tim33_Click(sender As Object, e As EventArgs) Handles Tim33.Click
        Dim n As Integer
        n = InputBox("Nhập bao nhiêu phần tử?")
        If (n < 0) Then
            MsgBox("Số nhập vào phải lớn hơn 0")
        Else
            ketQua33.Text = "Số lượng số nguyên tố là: " & bai33_2(n)
        End If
    End Sub
    '==================================Bài 34====================================='
    Private Sub Tinh34_Click(sender As Object, e As EventArgs) Handles Tinh34.Click
        Dim tu1 As Double
        Dim mau1 As Double
        Dim tu2 As Double
        Dim mau2 As Double
        Dim kq1 As Double
        Dim kq2 As Double
        Dim kq3 As Double
        tu1 = Convert.ToInt32(tuSo1.Text)
        mau1 = Convert.ToInt32(mauSo1.Text)
        tu2 = Convert.ToInt32(tuSo2.Text)
        mau2 = Convert.ToInt32(mauSo2.Text)
        If mauSo2.Text = 0 And mauSo1.Text = 0 Then
            MsgBox("Mẫu số không được là số 0")
        ElseIf mauSo1.Text = 0 Then
            MsgBox("Mẫu số không được là số 0")
        ElseIf mauSo2.Text = 0 Then
            MsgBox("Mẫu số không được là số 0")
        Else
            kq1 = bai34(tu1, mau1, tu2, mau2)
            kq2 = bai34_2(tu1, mau1, tu2, mau2)
            kq3 = kq1 / kq2
        End If
        ketQua34_1.Text = Convert.ToString(kq1)
        ketQua34_2.Text = Convert.ToString(kq2)
        ketQua34_3.Text = kq3.ToString("F4")
    End Sub
    '==================================Bài 35====================================='
    Private Sub kiemTra35_Click(sender As Object, e As EventArgs) Handles kiemTra35.Click
        If (nhapN35.Text < 0) Then
            MsgBox("Số nhập vào phải lớn hơn 0")
        ElseIf bai35(nhapN35.Text) Then
            MsgBox("Số " & nhapN35.Text & " là số nguyên tố")
        Else
            MsgBox("Số " & nhapN35.Text & " không là số nguyên tố")
        End If

    End Sub
    '==================================Bài 36====================================='
    Private Sub kiemTra36_Click(sender As Object, e As EventArgs) Handles kiemTra36.Click
        If (nhapN36.Text < 0) Then
            MsgBox("Số nhập vào phải lớn hơn 0")
        ElseIf bai36(nhapN36.Text) Then
            MsgBox("Số " & nhapN36.Text & " thuộc Fibonacci")
        Else
            MsgBox("Số " & nhapN36.Text & " không thuộc Fibonacci")
        End If
    End Sub
    '==================================Bài 37====================================='
    Private Sub kiemTra37_Click(sender As Object, e As EventArgs) Handles kiemTra37.Click
        If (nhapN37.Text < 0) Then
            MsgBox("Số nhập vào phải lớn hơn 0")
        ElseIf bai37(nhapN37.Text) Then
            MsgBox("Số " & nhapN37.Text & " là số hoàn hảo")
        Else
            MsgBox("Số " & nhapN37.Text & " không là số hoàn hảo")
        End If
    End Sub
    '==================================Bài 39====================================='
    Private Sub ketQua39_Click(sender As Object, e As EventArgs) Handles ketQua39.Click
        'Dim n As Integer
        'nhapN39.Text = n
        MsgBox("Số " & nhapN39.Text & " Có " & bai39(nhapN39.Text) & " chữ số")
    End Sub
    '==================================Bài 40====================================='
    Private Sub kiemTra40_Click(sender As Object, e As EventArgs) Handles kiemTra40.Click
        MsgBox("Bội chung nhỏ nhất là: " & bai40(nhapN40_1.Text, nhapN40_2.Text))
    End Sub
    '==================================Bài 41====================================='
    Private Sub Tim41_Click(sender As Object, e As EventArgs) Handles Tim41.Click
        Dim a, b, c, ucln, n As Integer
        a = soA.Text
        b = soB.Text
        c = soC.Text
        ucln = bai41(a, b)
        ucln = bai41(ucln, c)
        MsgBox("Ước chung lớn nhất là: " & ucln)
    End Sub

    '==================================Bài 43====================================='
    Private Sub Tinh43_Click(sender As Object, e As EventArgs) Handles Tinh43.Click
        Dim tu1 As Double
        Dim mau1 As Double
        Dim tu2 As Double
        Dim mau2 As Double
        Dim kq1 As Double
        Dim kq2 As Double
        Dim kq3 As Double
        tu1 = Convert.ToInt32(num1.Text)
        mau1 = Convert.ToInt32(den1.Text)
        tu2 = Convert.ToInt32(num2.Text)
        mau2 = Convert.ToInt32(den2.Text)
        If den2.Text = 0 And den1.Text = 0 Then
            MsgBox("Mẫu số không được là số 0")
        ElseIf den1.Text = 0 Then
            MsgBox("Mẫu số không được là số 0")
        ElseIf den2.Text = 0 Then
            MsgBox("Mẫu số không được là số 0")
        Else
            kq1 = bai43(tu1, mau1, tu2, mau2)
            kq2 = bai43_2(tu1, mau1, tu2, mau2)
            kq3 = kq1 / kq2
        End If
        numA.Text = Convert.ToString(kq1)
        denA.Text = Convert.ToString(kq2)
        decA.Text = kq3.ToString()
    End Sub
End Class