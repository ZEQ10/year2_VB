Public Class Book
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vch As String
        vch = InputBox("Mã khuyến mãi", "Nhập mã khuyến mãi: (Gồm dãy 5 số)")
        If IsNumeric(vch) = 0 Then
            MsgBox("Sai mã khuyến mại")
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Notify.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim MsgBoxResult = MsgBox("Xác nhận đặt xe?", vbYesNo)
        If MsgBoxResult = MsgBoxResult.Yes Then
            If ComboBox1.SelectedItem IsNot Nothing Or ComboBox2.SelectedItem IsNot Nothing Or ComboBox3.SelectedItem IsNot Nothing Or ComboBox4.SelectedItem IsNot Nothing Then
                truyen_str()
            Else
                MsgBox("Bạn chưa điền đủ các thông tin cần thiết để đặt xe !")
            End If


        End If
    End Sub

    Private Sub Book_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dc As String = InputBox("Nhập địa chỉ:")
        ComboBox3.Items.Add(dc)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim dc As String = InputBox("Nhập địa chỉ:")
        ComboBox4.Items.Add(dc)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        User.Show()
        Me.Hide()
    End Sub

    Private Sub Book_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class