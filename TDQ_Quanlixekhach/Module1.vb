Module Module1
    Dim str As String
    Public Sub truyen_str()
        Dim time As Date = DateTime.Now
        Dim msgnoti As String
        msgnoti = "Đặt chuyến xe " & Book.ComboBox1.SelectedItem.ToString() & ", khung giờ: " & Book.ComboBox2.SelectedItem.ToString() & ". Vào lúc: " & time _
        & vbNewLine
        Notify.RichTextBox1.Text = msgnoti & Notify.RichTextBox1.Text
    End Sub
End Module
