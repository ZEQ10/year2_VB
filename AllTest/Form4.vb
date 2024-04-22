Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer = InputBox("Nhap n")
        Dim i%
        For i = 1 To n
            Dim x As Integer = InputBox("Nhap")
            CheckedListBox1.Items.Add(x)
        Next

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As ItemCheckEventArgs) Handles CheckedListBox1.ItemCheck
        For Each k As Object In CheckedListBox1.CheckedItems
            Dim p As Integer
            Integer.TryParse(k.ToString, p)
            If p Mod 2 = 0 Then
                RichTextBox1.Text = RichTextBox1.Text & p & vbNewLine
            End If
        Next
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        RichTextBox1.Multiline = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each k As Object In CheckedListBox1.CheckedItems
            Dim p As Integer
            Integer.TryParse(k.ToString, p)
            If p Mod 2 = 0 Then
                RichTextBox1.Text = RichTextBox1.Text & p & vbNewLine
            End If
        Next
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub
End Class