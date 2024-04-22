Module Quy_19_Module
    Sub subbai2(a_19%, b_19%, h_19%)
        MsgBox("Diện tích hình thang: " & ((a_19 + b_19) * h_19 / 2))
    End Sub

    Function fngiaithua(n_19%) As Double
        If n_19 = 0 Or n_19 = 1 Then
            Return 1
        Else
            Return n_19 * fngiaithua(n_19 - 1)
        End If
    End Function

    Function fnbai19(n_19%) As Double
        Dim i_19%
        Dim s_19 As Double = 0
        For i_19 = 1 To n_19
            s_19 = s_19 + (Math.Pow(-1, i_19 + 1) / (fngiaithua(i_19)))
        Next
        Return s_19
    End Function

    Function fnbai22(n_19%) As Integer
        Dim i_19%
        Dim tong_19% = 0
        For i_19 = 1 To n_19
            Dim s_19 As String = InputBox("Nhập số thứ " & i_19 & " :")
            Dim x_19 As Integer = 0
            If Integer.TryParse(s_19, x_19) Then
                If x_19 Mod 2 = 0 Then
                    tong_19 += x_19
                End If
            Else
                MsgBox("Vui lòng nhập số !")
            End If
        Next
        Return tong_19
    End Function

    Function fnchecksqpf_bai33(n_19%) As Boolean
        Dim s_19 As Integer = Math.Sqrt(n_19)
        Return s_19 * s_19 = n_19
    End Function

    Function fnbai33(n_19%) As Boolean
        Return (fnchecksqpf_bai33(5 * n_19 * n_19 + 4) Or fnchecksqpf_bai33(5 * n_19 * n_19 - 4))
    End Function

    Function fnbai42(n_19%) As String

        Dim str_19 As String = ""
        Do

            If ((n_19 Mod 2) = 1) Then
                str_19 = "1" + str_19
            ElseIf (n_19 Mod 2) = 0 Then
                str_19 = "0" + str_19
            End If
            n_19 \= 2
        Loop While n_19 <> 0
        Return str_19
    End Function
End Module
