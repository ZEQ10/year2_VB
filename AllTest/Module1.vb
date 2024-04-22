

Module Module1


    Function dequy_tong(n As Integer) As Integer
        If n = 0 Then
            Return 0
        Else
            Return n + dequy_tong(n - 1)
        End If
    End Function

    Function fnbai22(n_19%) As Integer
        Dim i_19%
        Dim tong_19% = 0
        For i_19 = 1 To n_19
            Dim s_19 As String = InputBox("Nhập số thứ " & i_19 & " :")
            Dim x_19 As Integer = 0
            If Integer.TryParse(s_19, x_19) Then
                If (x_19 Mod 2) = 0 And x_19 > tong_19 Then
                    tong_19 = x_19
                End If
            Else
                MsgBox("Vui lòng nhập số !")
            End If
        Next
        Return tong_19
    End Function
    Function checkshh(n%) As Boolean
        Dim i%, s%
        s = 0
        For i = 1 To n - 1
            If (n Mod i) = 0 Then
                s += i
            End If
        Next
        If s = n Then
            Return True
        Else
            Return False
        End If
    End Function






    Function checkshh1(n As Integer) As Boolean
        Dim i As Integer
        Dim s As Integer
        s = 0
        For i = 1 To n \ 2 ' Chỉ cần kiểm tra đến nửa số n
            If (n Mod i) = 0 Then
                s += i
            End If
        Next
        If s = n Then
            Return True
        Else
            Return False
        End If
    End Function

    Function sum1so(n%) As Integer
        Dim s As Integer = 0
        Dim r As Integer
        While (n <> 0)
            r = n Mod 10
            s += r
            n = n \ 10
        End While
        Return s
    End Function

    Function ucln(a%, b%) As Integer
        While (a <> b)
            If a > b Then
                a = a - b
            Else
                b = b - a
            End If

        End While
        Return a


    End Function
    Function ucln2(a%, b%) As Integer
        Dim R%
        While (b <> 0)
            R = a Mod b
            a = b
            b = R

        End While
        Return a


    End Function

    Function bcnn(a%, b%) As Integer

        Return a * b / ucln(a, b)

    End Function

    Function sumlistbox(n%) As Double
        Dim i%, s%
        s = 0
        For i = 1 To n
            Dim a As Integer = InputBox("Nhap")

        Next
    End Function
End Module
