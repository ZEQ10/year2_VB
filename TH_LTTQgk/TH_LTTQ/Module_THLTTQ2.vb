Module Module_THLTTQ2
    '==================================Bài 3======================================'
    Function bai3(r As Double)
        Const PI = 3.14
        Dim S As Double
        S = PI * Math.Pow(r, 2)
        Return S
    End Function
    '==================================Bài 4======================================'
    Sub bai4(r As Double)
        Const PI = 3.14
        Dim S As Double
        S = PI * Math.Pow(r, 2)
        MsgBox("Diện tích hình tròn là: " & S)
    End Sub
    '==================================Bài 5======================================'
    Function bai5(canhday As Double, chieucao As Double)
        Dim S As Double
        S = (canhday * chieucao) / 2
        Return S
    End Function
    '==================================Bài 6======================================'
    Sub bai6(canhday2 As Double, chieucao2 As Double)
        Dim S As Double
        S = (canhday2 * chieucao2) / 2
        MsgBox("Diện tích tam giác là: " & S)
    End Sub
    '==================================Bài 7======================================'
    Function bai7(a As Double, b As Double, c As Double)
        Dim p As Double
        Dim S As Double
        p = (a + b + c) / 2
        S = Math.Sqrt(p * (p - a) * (p - b) * (p - c))
        Return S
    End Function
    '==================================Bài 8======================================'
    Sub bai8(a As Double, b As Double, c As Double)
        Dim p As Double
        Dim S As Double
        p = (a + b + c) / 2
        S = Math.Sqrt(p * (p - a) * (p - b) * (p - c))
        MsgBox("Diện tích tam giác là: " & S)
    End Sub
    '==================================Bài 9======================================'
    Function bai9(r As Double)
        Dim C As Double
        Const PI = 3.14
        C = 2 * PI * r
        Return C
    End Function
    '==================================Bài 10====================================='
    Sub bai10(r As Double)
        Dim C As Double
        Const PI = 3.14
        C = 2 * PI * r
        MsgBox("Chu vi hình tròn là: " & C)
    End Sub
    '==================================Bài 11====================================='
    Function bai11(n As Double)
        Dim S As Double
        Dim i As Integer
        S = 0
        For i = 1 To n
            S = S + i
        Next i
        Return S
    End Function
    '==================================Bài 12====================================='
    Function bai12(n As Double)
        Dim S As Double
        Dim i As Integer
        S = 0
        For i = 1 To n
            If (i Mod 2 = 0) Then
                S = S - i
            Else S = S + i
            End If
        Next i
        Return S
    End Function
    '==================================Bài 13====================================='
    Function bai13(n As Double)
        Dim S As Double
        Dim i As Integer
        S = 0
        For i = 1 To n
            If (i Mod 2 <> 0) Then
                S = S - i
            Else S = S + i
            End If
        Next i
        Return S
    End Function
    '==================================Bài 16====================================='
    Function bai16(n As Double)
        Dim S As Double
        Dim i As Integer
        S = 0
        For i = 1 To n
            If (i Mod 2 <> 0) Then
                S = S - 1 / i
            Else S = S + 1 / i
            End If
        Next i
        Return S
    End Function
    '==================================Bài 17====================================='
    Function bai17(n As Double)
        Dim i As Integer
        Dim gt As Double
        gt = 1
        For i = 1 To n
            gt = gt * i
        Next i
        Return gt
    End Function
    '==================================Bài 18====================================='
    Function bai18(n As Double)
        Dim i As Integer
        Dim gt As Double
        gt = 1
        For i = 1 To n
            gt = gt * i
        Next i
        Return gt
    End Function
    Function bai18_2(n As Double)
        Dim i As Integer
        Dim S As Double
        S = 0
        For i = 1 To n
            S = S + 1 / bai18(i)
        Next i
        Return S
    End Function
    '==================================Bài 19====================================='
    Function bai19(n As Double)
        Dim i As Integer
        Dim gt As Double
        gt = 1
        For i = 1 To n
            gt = gt * i
        Next i
        Return gt
    End Function
    Function bai19_2(n As Double)
        Dim i As Integer
        Dim S As Double
        S = 0
        For i = 1 To n
            If (i Mod 2 <> 0) Then
                S = S + 1 / bai19(i)
            Else S = S - 1 / bai19(i)
            End If
        Next i
        Return S
    End Function
    '==================================Bài 20====================================='
    Function bai20(n As Double)
        Dim i As Integer
        Dim gt As Double
        gt = 1
        For i = 1 To n
            gt = gt * i
        Next i
        Return gt
    End Function
    Function bai20_2(n As Double)
        Dim i As Integer
        Dim S As Double
        S = 0
        For i = 1 To n
            If (i Mod 2 = 0) Then
                S = S + 1 / bai20(i)
            Else S = S - 1 / bai20(i)
            End If
        Next i
        Return S
    End Function
    '==================================Bài 21====================================='
    Function bai21(n As Integer)
        Dim i As Integer
        Dim so As Integer
        Dim S As Integer
        S = 0
        For i = 1 To n
            so = InputBox("Nhập vào số thứ " & i & ":")
            S = S + so
        Next i
        Return S
    End Function
    '==================================Bài 22====================================='
    Function bai22(n As Integer)
        Dim i As Integer
        Dim so As Integer
        Dim S As Integer
        S = 0
        For i = 1 To n
            so = InputBox("Nhập vào số thứ " & i & ":")
            If (so Mod 2 = 0) Then
                S = S + so
            End If
        Next i
        Return S
    End Function
    '==================================Bài 23====================================='
    Function bai23(n As Integer)
        Dim i As Integer
        Dim so As Integer
        Dim S As Integer
        S = 0
        For i = 1 To n
            so = InputBox("Nhập vào số thứ " & i & ":")
            If (so Mod 2 <> 0) Then
                S = S + so
            End If
        Next i
        Return S
    End Function
    '==================================Bài 24====================================='
    Function bai24(n As Integer)
        Dim i As Integer
        Dim so As Integer
        Dim S As Integer
        S = 0
        For i = 1 To n
            so = InputBox("Nhập vào số thứ " & i & ":")
            If (so < 0) Then
                S = S + so
            End If
        Next i
        Return S
    End Function
    '==================================Bài 25====================================='
    Function bai25(n As Integer)
        Dim i As Integer
        Dim so As Integer
        Dim S As Integer
        S = 0
        For i = 1 To n
            so = InputBox("Nhập vào số thứ " & i & ":")
            If (so > 0) Then
                S = S + so
            End If
        Next i
        Return S
    End Function
    '==================================Bài 26====================================='
    Function bai26(n As Integer)
        Dim i As Integer
        Dim so As Integer
        Dim S As Integer
        S = 0
        For i = 1 To n
            so = InputBox("Nhập vào số thứ " & i & ":")
            If (so Mod 5 = 0) Then
                S = S + so
            End If
        Next i
        Return S
    End Function
    '==================================Bài 27====================================='
    Function bai27(n As Integer)
        Dim so As Integer
        Dim soLonNhat As Integer
        Dim i As Integer
        soLonNhat = Integer.MinValue
        For i = 1 To n
            so = InputBox("Nhập số nguyên thứ " & i & ":")
            If so > soLonNhat Then
                soLonNhat = so
            End If
        Next i
        Return soLonNhat
    End Function
    '==================================Bài 28====================================='
    Function bai28(n As Integer)
        Dim so As Integer
        Dim soNhoNhat As Integer
        Dim i As Integer
        soNhoNhat = Integer.MaxValue
        For i = 1 To n
            so = InputBox("Nhập số nguyên thứ " & i & ":")
            If so < soNhoNhat Then
                soNhoNhat = so
            End If
        Next i
        Return soNhoNhat
    End Function
    '==================================Bài 29====================================='
    Function bai29(n As Integer)
        Dim so As Integer
        Dim soChanLonNhat As Integer
        Dim i As Integer
        soChanLonNhat = Integer.MinValue
        For i = 1 To n
            so = InputBox("Nhập số nguyên thứ " & i & ":")
            If so Mod 2 = 0 And (so > soChanLonNhat) Then
                soChanLonNhat = so
            End If
        Next i
        If soChanLonNhat <> 0 Then
            Return soChanLonNhat
        Else
            Return MsgBox("Không có số chẵn trong dãy.")
        End If
    End Function
    '==================================Bài 32====================================='
    Function bai32(n As Integer)
        Dim phanTuchanDautien As Integer
        Dim i As Integer
        Dim so As Integer
        phanTuchanDautien = 0
        For i = 1 To n
            so = InputBox("Nhập số nguyên thứ " & i & ":")
            If so Mod 2 = 0 Then
                phanTuchanDautien = so
                Exit For
            End If
        Next i
        If phanTuchanDautien <> 0 Then
            Return phanTuchanDautien
        Else
            Return MsgBox("Không có phần tử chẵn trong dãy.")
        End If
    End Function
    '==================================Bài 33====================================='
    Function bai33(n As Integer) As Boolean
        If n <= 1 Then
            bai33 = False
        ElseIf n <= 3 Then
            bai33 = True
        ElseIf n Mod 2 = 0 Or n Mod 3 = 0 Then
            bai33 = False
        Else
            Dim i As Integer
            i = 5
            While i * i <= n
                If n Mod i = 0 Or n Mod (i + 2) = 0 Then
                    bai33 = False
                    Exit Function
                End If
                i = i + 6
            End While
            bai33 = True
        End If
    End Function
    Function bai33_2(n As Integer)
        Dim dem As Integer
        Dim i As Integer
        Dim so As Integer
        dem = 0
        For i = 1 To n
            so = InputBox("Nhập số nguyên thứ " & i & ":")
            If bai33(so) Then
                dem = dem + 1
            End If
        Next i
        Return dem
    End Function
    '==================================Bài 34====================================='
    Function bai34(tuSo1 As Double, mauSo1 As Double, tuSo2 As Double, mauSo2 As Double)
        Dim ketQua1 As Double
        'Dim ketQua2 As Double
        'Dim ketQua3 As Double
        If mauSo1 = mauSo2 Then
            ketQua1 = tuSo1 + tuSo2
            'Return mauSo1 = mauSo2
        Else
            ketQua1 = tuSo1 * mauSo2 + tuSo2 * mauSo1
            'Return ketQua2 = mauSo1 * mauSo2
        End If
        Return ketQua1
        'Return ketQua3 = ketQua1 / ketQua2
    End Function
    Function bai34_2(tuSo1 As Double, mauSo1 As Double, tuSo2 As Double, mauSo2 As Double)
        'Dim ketQua1 As Double
        Dim ketQua2 As Double
        'Dim ketQua3 As Double
        If mauSo1 = mauSo2 Then
            'Return ketQua1 = tuSo1 + tuSo2
            ketQua2 = mauSo1
        Else
            'Return ketQua1 = tuSo1 * mauSo2 + tuSo2 * mauSo1
            ketQua2 = mauSo1 * mauSo2
        End If
        Return ketQua2
        'Return ketQua3 = ketQua1 / ketQua2
    End Function
    Function bai34_3(tuSo1 As Double, mauSo1 As Double, tuSo2 As Double, mauSo2 As Double)
        'Dim ketQua1 As Double
        'Dim ketQua2 As Double
        Dim ketQua3 As Double
        'If mauSo1 = mauSo2 Then
        'ketQua1 = tuSo1 + tuSo2
        'mauSo1 = mauSo2
        'Else
        'ketQua1 = tuSo1 * mauSo2 + tuSo2 * mauSo1
        'ketQua2 = mauSo1 * mauSo2
        'End If
        Return ketQua3 = bai34(tuSo1, mauSo1, tuSo2, mauSo2) / bai34_2(tuSo1, mauSo1, tuSo2, mauSo2)
    End Function
    '==================================Bài 35====================================='
    Function bai35(n As Integer) As Boolean
        Dim i As Integer
        If n <= 1 Then
            Return False
        End If
        For i = 2 To Math.Sqrt(n)
            If n Mod i = 0 Then
                Return False
            End If
        Next
        Return True
    End Function
    '==================================Bài 36====================================='
    Function bai36(n As Integer) As Boolean
        Dim a As Integer
        Dim b As Integer
        a = 0
        b = 1
        While b < n
            Dim temp As Integer = a
            a = b
            b = temp + b
        End While
        If b = n Then
            Return True
        Else
            Return False
        End If
    End Function
    '==================================Bài 37====================================='
    Function bai37(n As Integer) As Boolean
        Dim S As Integer = 0
        For i As Integer = 1 To n \ 2
            If n Mod i = 0 Then
                S = S + i
            End If
        Next
        Return S = n
    End Function
    '==================================Bài 39====================================='
    Function bai39(n As Integer) As Integer
        Dim dem As Integer
        dem = 0
        While n <> 0
            n = n \ 10
            dem = dem + 1
        End While
        Return dem
    End Function
    '==================================Bài 40====================================='
    Function bai40(a As Integer, b As Integer) As Integer
        Dim max As Integer = Math.Max(a, b)
        Dim min As Integer = Math.Min(a, b)
        Dim i As Integer = max
        Do While (i Mod min <> 0)
            i = i + max
        Loop
        Return i
    End Function
    '==================================Bài 41====================================='
    Function bai41(a As Integer, b As Integer) As Integer
        While (a <> b)
            If a > b Then
                a = a - b
            Else
                b = b - a
            End If
        End While
        Return a
    End Function
    '==================================Bài 43====================================='
    Function bai43(tuSo1 As Double, mauSo1 As Double, tuSo2 As Double, mauSo2 As Double)
        Dim ketQua1 As Double
        'Dim ketQua2 As Double
        'Dim ketQua3 As Double
        If mauSo1 = mauSo2 Then
            ketQua1 = tuSo1 - tuSo2
            'Return mauSo1 = mauSo2
        Else
            ketQua1 = tuSo1 * mauSo2 - tuSo2 * mauSo1
            'Return ketQua2 = mauSo1 * mauSo2
        End If
        Return ketQua1
        'Return ketQua3 = ketQua1 / ketQua2
    End Function
    Function bai43_2(tuSo1 As Double, mauSo1 As Double, tuSo2 As Double, mauSo2 As Double)
        'Dim ketQua1 As Double
        Dim ketQua2 As Double
        'Dim ketQua3 As Double
        If mauSo1 = mauSo2 Then
            'Return ketQua1 = tuSo1 + tuSo2
            ketQua2 = mauSo1
        Else
            'Return ketQua1 = tuSo1 * mauSo2 + tuSo2 * mauSo1
            ketQua2 = mauSo1 * mauSo2
        End If
        Return ketQua2
        'Return ketQua3 = ketQua1 / ketQua2
    End Function
End Module
