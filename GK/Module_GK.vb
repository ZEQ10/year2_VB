Module Module_GK
    Sub subbai1(a As Integer, b As Integer, c As Integer)
        Dim p As Double = (a + b + c) / 2.0
        Dim s As Double = Math.Sqrt(p * (p - a) * (p - b) * (p - c))
        MsgBox("Diện tích tam giác là: " & s)
    End Sub

    Function giaithua(n As Integer) As Integer
        Dim i As Integer
        Dim s As Integer = 1
        For i = 1 To n
            s *= i
        Next
        Return s
    End Function

    Function fnbai2(n As Integer) As Double
        Dim i As Integer
        Dim s As Double = 0
        For i = 1 To n
            s = s + ((Math.Pow((-1), (i + 1))) / giaithua(i))
        Next
        Return s
    End Function

    Function checkSNT(x As Integer) As Boolean
        Dim i As Integer
        Dim cnt As Integer = 0
        For i = 1 To x
            If x Mod i = 0 Then
                cnt += 1
            End If

        Next
        If cnt = 2 Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Function fnbai3(n As Integer) As Integer
        Dim i As Integer
        Dim dem As Integer = 0
        For i = 1 To n
            Dim a As Integer = InputBox("nhap: ")
            If checkSNT(a) Then

                dem += 1
            End If
        Next
        Return dem
    End Function


End Module
