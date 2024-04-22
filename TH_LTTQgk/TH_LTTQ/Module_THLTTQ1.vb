Module Module_THLTTQ1
    Function S_HinhThang1(a As Double, b As Double, h As Double) As Double
        S_HinhThang1 = (a + b) * h / 2
    End Function
    Sub S_HinhThang2(a2 As Double, b2 As Double, h2 As Double)
        Dim S As Double
        S = (a2 + b2) * h2 / 2
        MsgBox("Diện tích hình thang là: " & S)
    End Sub
    Function bai14(n As Integer) As Double
        Dim S As Double
        S = 0
        Dim i As Integer
        For i = 1 To n
            S = S + 1 / i
        Next i
        Return S
    End Function
    Function bai15(n As Integer) As Double
        Dim S As Double
        S = 0
        For i = 1 To n
            If i Mod 2 = 0 Then
                S = S - 1 / i
            Else S = S + 1 / i
            End If
        Next i
        Return S
    End Function
    Function bai30(n As Integer)
        Dim so As Integer
        Dim soLeNhoNhat As Integer
        Dim i As Integer
        soLeNhoNhat = 0
        For i = 1 To n
            so = InputBox("Nhập số nguyên thứ " & i & ":")
            If so Mod 2 <> 0 And (so < soLeNhoNhat Or soLeNhoNhat = 0) Then
                soLeNhoNhat = so
            End If
        Next i
        If soLeNhoNhat <> 0 Then
            'MsgBox("Số lẻ nhỏ nhất trong dãy là: " & soLeNhoNhat)
            Return soLeNhoNhat
        Else
            Return MsgBox("Không có số lẻ trong dãy.")
        End If
    End Function
    Function bai31(n As Integer)
        Dim soLuongsoChan As Integer
        Dim tongSochan As Integer
        Dim tbCong As Double
        Dim i As Integer
        Dim so As Integer
        tongSochan = 0
        soLuongsoChan = 0
        For i = 1 To n
            so = InputBox("Nhập vào số thứ" & i & ":")
            If so Mod 2 = 0 Then
                tongSochan = tongSochan + so
                soLuongsoChan = soLuongsoChan + 1
            End If
        Next i
        If (soLuongsoChan > 0) Then
            tbCong = tongSochan / soLuongsoChan
            'MsgBox "Trung bình cộng các số chẵn trong dãy là: " & trungBinh
            Return tbCong
        Else
            Return MsgBox("Không có số chẵn trong dãy.")
        End If
    End Function
    Function bai38(n As Integer)
        Dim tong As Integer
        tong = 0
        Do While n > 0
            tong = tong + (n Mod 10)
            n = n \ 10
        Loop
        Return tong
    End Function
    Function TimUSCLN(ByVal a As Integer, ByVal b As Integer) As Integer
        While b <> 0
            Dim r As Integer = a Mod b
            a = b
            b = r
        End While
        TimUSCLN = a
    End Function
    Function TimUSCLN_BaSo(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer) As Integer
        Dim uscln_ab As Integer
        uscln_ab = TimUSCLN(a, b)
        Dim uscln_abc As Integer
        uscln_abc = TimUSCLN(uscln_ab, c)
        TimUSCLN_BaSo = uscln_abc
    End Function

End Module
