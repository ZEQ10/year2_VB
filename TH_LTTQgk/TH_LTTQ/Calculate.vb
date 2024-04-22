Public Class Calculate
    Dim A As Double
    Dim ExitYN As System.Windows.Forms.DialogResult

    Private Sub Cong_Click(sender As Object, e As EventArgs) Handles Cong.Click
        A = CDbl(TextBox1.Text) + TextBox2.Text
    End Sub

    Private Sub Tru_Click(sender As Object, e As EventArgs) Handles Tru.Click
        A = TextBox1.Text - TextBox2.Text
    End Sub

    Private Sub Nhan_Click(sender As Object, e As EventArgs) Handles Nhan.Click
        A = TextBox1.Text * TextBox2.Text
    End Sub

    Private Sub Chia_Click(sender As Object, e As EventArgs) Handles Chia.Click
        If (CDbl(TextBox2.Text) <> 0) Then
            A = TextBox1.Text / TextBox2.Text
        Else MsgBox("mẫu phải khác số 0!")
        End If
    End Sub

    Private Sub Chia_lay_du_Click(sender As Object, e As EventArgs) Handles Chia_lay_du.Click
        A = TextBox1.Text Mod TextBox2.Text
    End Sub

    Private Sub Bang_Click(sender As Object, e As EventArgs) Handles Bang.Click
        TextBox3.Text = A
    End Sub

    Private Sub Xoa_Click(sender As Object, e As EventArgs) Handles Xoa.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Dong_Click(sender As Object, e As EventArgs) Handles Dong.Click
        ExitYN = MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo)
        If ExitYN = MsgBoxResult.Yes Then
            Close()
        Else
        End If
    End Sub

    'HẾT CÂU 1
    '//============================================================================================//
    'TỚI CÂU 2

    Private Sub CanBac2_Click(sender As Object, e As EventArgs) Handles CanBac2.Click
        If (TextBox4.Text > 0) Then
            'A = Val(TextBox1.Text)
            A = Math.Sqrt(TextBox4.Text)
        Else MsgBox("số trong căn phải dương!")
        End If
    End Sub


    Private Sub Bang_2_Click(sender As Object, e As EventArgs) Handles Bang_2.Click
        TextBox8.Text = A

    End Sub

    Private Sub Xoa_2_Click(sender As Object, e As EventArgs) Handles Xoa_2.Click
        TextBox8.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Dong_2_Click(sender As Object, e As EventArgs) Handles Dong_2.Click
        ExitYN = MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo)
        If ExitYN = MsgBoxResult.Yes Then
            Close()
        Else
        End If
    End Sub

    Private Sub Luythua_Click(sender As Object, e As EventArgs) Handles Luythua.Click
        A = Math.Pow(TextBox4.Text, 2)
    End Sub

    'HẾT CÂU 2
    '//============================================================================================//
    'TỚI CÂU 3

    Private Sub Circle_Click(sender As Object, e As EventArgs) Handles Circle.Click
        Dim pi = System.Math.PI
        A = Math.Pow(TextBox7.Text, 2) * pi
    End Sub

    Private Sub bang_3_Click(sender As Object, e As EventArgs) Handles bang_3.Click
        TextBox9.Text = A
    End Sub

    Private Sub Rectangle_Click(sender As Object, e As EventArgs) Handles Rectangle.Click
        A = TextBox5.Text * TextBox6.Text
    End Sub

    Private Sub Square_Click(sender As Object, e As EventArgs) Handles Square.Click
        A = Math.Pow(TextBox12.Text, 2)
    End Sub

    Private Sub Xoa_3_Click(sender As Object, e As EventArgs) Handles Xoa_3.Click
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox9.Text = ""
    End Sub

    Private Sub Dong_3_Click(sender As Object, e As EventArgs) Handles Dong_3.Click
        ExitYN = MsgBox("Do you want to exit?", MsgBoxStyle.YesNo)
        If ExitYN = MsgBoxResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub Quadrilateral_Click(sender As Object, e As EventArgs) Handles Quadrilateral.Click
        A = TextBox10.Text * TextBox11.Text
    End Sub

    Private Sub Triangle_Click(sender As Object, e As EventArgs) Handles Triangle.Click
        A = (1 / 2.0) * TextBox10.Text * TextBox11.Text
    End Sub

    Private Sub Calculate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class