Public Class btthigk
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = 0 Then
            Dim b1 As New bai1()
            b1.Show()
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Dim b2 As New bai2()
            b2.Show()
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Dim b3 As New bai3()
            b3.Show()


        End If




    End Sub
End Class
