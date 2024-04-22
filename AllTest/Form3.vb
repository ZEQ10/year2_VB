Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer = InputBox("nhap sl")
        Dim i%
        For i = 1 To n
            Dim a As Integer = InputBox("nhap")
            ListBox1.Items.Add(a)
        Next
        Dim p = ListBox1.SelectionMode.MultiSimple

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim p = ListBox1.SelectionMode.MultiSimple
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim s% = 0
        For Each ok As Integer In ListBox1.SelectedIndices
            s += ListBox1.Items(ok)
        Next
        MsgBox(s)
    End Sub
End Class