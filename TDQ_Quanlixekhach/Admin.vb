Public Class Admin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cx As String = InputBox("Nhập tên chuyến xe:")
        If cx <> "" Then
            ListBox1.Items.Add(cx)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedIndex <> -1 Then
            Dim ok = MsgBox("Xác nhận xóa?", vbYesNo)
            If ok.Yes Then
                ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
                MsgBox("Đã xóa thành công!")
            End If
        Else
            MsgBox("Vui lòng chọn chuyến xe cần xóa!")
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        User.Show()
        Me.Hide()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cx As String = InputBox("Nhập tên chuyến xe:")
        If cx <> "" Then
            ListBox2.Items.Add(cx)
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ListBox2.SelectedIndex <> -1 Then
            Dim ok = MsgBox("Xác nhận xóa?", vbYesNo)
            If ok.Yes Then
                ListBox2.Items.RemoveAt(ListBox1.SelectedIndex)
                MsgBox("Đã xóa thành công!")
            End If
        Else
            MsgBox("Vui lòng chọn khung giờ cần xóa!")
        End If
    End Sub
    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        For Each line As Object In Notify.RichTextBox1.Lines
            If line = "" Then
                Exit For
            Else
                Dim its As String = ""
                its = line.ToString
                Dim editem As String = "(" & User.TextBox1.Text & ") " & its
                Dim ob As Object = editem
                ListBox3.Items.Add(ob)
            End If
        Next
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim cx As String = InputBox("Nhập tên người dùng:")
        If cx <> "" Then
            ListBox4.Items.Add(cx)
        End If
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If ListBox4.SelectedIndex <> -1 Then
            Dim editedItem As String = InputBox("Nhập giá trị mới cho mục:", "Chỉnh Sửa", ListBox4.SelectedItem.ToString())

            If editedItem <> "" Then
                Dim selectedIndex As Integer = ListBox4.SelectedIndex
                ListBox4.Items(selectedIndex) = editedItem
            End If
        Else
            MsgBox("Vui lòng chọn một mục để chỉnh sửa.")
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If ListBox4.SelectedIndex <> -1 Then
            Dim ok = MsgBox("Xác nhận xóa?", vbYesNo)
            If ok.Yes Then
                ListBox4.Items.RemoveAt(ListBox1.SelectedIndex)
                MsgBox("Đã xóa thành công!")
            End If
        Else
            MsgBox("Vui lòng chọn người dùng cần xóa!")
        End If
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If ListBox1.SelectedIndex <> -1 Then
            Dim editedItem As String = InputBox("Nhập giá trị mới cho mục:", "Chỉnh Sửa", ListBox1.SelectedItem.ToString())

            If editedItem <> "" Then
                Dim selectedIndex As Integer = ListBox1.SelectedIndex
                ListBox1.Items(selectedIndex) = editedItem
            End If
        Else
            MsgBox("Vui lòng chọn một mục để chỉnh sửa.")
        End If
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If ListBox2.SelectedIndex <> -1 Then
            Dim editedItem As String = InputBox("Nhập giá trị mới cho mục:", "Chỉnh Sửa", ListBox2.SelectedItem.ToString())
            If editedItem <> "" Then
                Dim selectedIndex As Integer = ListBox2.SelectedIndex
                ListBox2.Items(selectedIndex) = editedItem
            End If
        Else
            MsgBox("Vui lòng chọn một mục để chỉnh sửa.")
        End If
    End Sub
End Class