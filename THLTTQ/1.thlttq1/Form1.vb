Public Class Form1



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer = CInt(TextBox1.Text)
        Dim b As Integer = CInt(TextBox2.Text)
        TextBox3.Text = CStr(a + b)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As Integer = CInt(TextBox1.Text)
        Dim b As Integer = CInt(TextBox2.Text)
        TextBox3.Text = CStr(a - b)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As Integer = CInt(TextBox1.Text)
        Dim b As Integer = CInt(TextBox2.Text)
        TextBox3.Text = CStr(a * b)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a As Integer = CInt(TextBox1.Text)
        Dim b As Integer = CInt(TextBox2.Text)
        TextBox3.Text = CStr(a / b)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        End
    End Sub
End Class
