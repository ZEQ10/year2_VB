Public Class Quy_19
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            Label5.Text = "Tính diện tích hình thang." & vbNewLine & "Việc tính diện tích được xây dựng ở chương trình con dạng thủ tục."
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Label5.Text = "Tính tổng S= 1-1/(2!)+1/(3!)-...+-1/(n!)."
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Label5.Text = "	Nhập dãy số gồm n số nguyên dương bất kỳ." & vbNewLine & "Tính tổng các số chẵn trong dãy số."
        ElseIf ComboBox1.SelectedIndex = 3 Then
            Label5.Text = "Cho biết một số có thuộc dãy Fibonaci hay không?"
        ElseIf ComboBox1.SelectedIndex = 4 Then
            Label5.Text = "Đổi một số từ hệ thập phân sang hệ nhị phân."
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x% = ComboBox1.SelectedIndex
        Select Case x
            Case 0
                Quy_19_Bai02.Show()
            Case 1
                Quy_19_Bai19.Show()
            Case 2
                Quy_19_Bai22.Show()
            Case 3
                Quy_19_Bai33.Show()
            Case 4
                Quy_19_Bai42.Show()
            Case Else
                MsgBox("Vui lòng chọn bài để thực hiện!")
        End Select



    End Sub
End Class
