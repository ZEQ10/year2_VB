Public Class RichTextBox
    Private Sub RichTextBox1_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles RichTextBox1.LinkClicked
        System.Diagnostics.Process.Start("chrome.exe", e.LinkText)
    End Sub
End Class