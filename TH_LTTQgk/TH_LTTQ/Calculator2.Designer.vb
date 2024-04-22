<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TieuDe = New System.Windows.Forms.Label()
        Me.PhepTinh = New System.Windows.Forms.GroupBox()
        Me.Chia = New System.Windows.Forms.Button()
        Me.Nhan = New System.Windows.Forms.Button()
        Me.Tru = New System.Windows.Forms.Button()
        Me.Cong = New System.Windows.Forms.Button()
        Me.kqua = New System.Windows.Forms.TextBox()
        Me.Dong = New System.Windows.Forms.Button()
        Me.Xoa = New System.Windows.Forms.Button()
        Me.Bang = New System.Windows.Forms.Button()
        Me.KetQua = New System.Windows.Forms.Label()
        Me.So = New System.Windows.Forms.GroupBox()
        Me.HienThi = New System.Windows.Forms.TextBox()
        Me.three = New System.Windows.Forms.Button()
        Me.one = New System.Windows.Forms.Button()
        Me.two = New System.Windows.Forms.Button()
        Me.four = New System.Windows.Forms.Button()
        Me.nine = New System.Windows.Forms.Button()
        Me.five = New System.Windows.Forms.Button()
        Me.zero = New System.Windows.Forms.Button()
        Me.six = New System.Windows.Forms.Button()
        Me.eight = New System.Windows.Forms.Button()
        Me.seven = New System.Windows.Forms.Button()
        Me.PhepTinh.SuspendLayout()
        Me.So.SuspendLayout()
        Me.SuspendLayout()
        '
        'TieuDe
        '
        Me.TieuDe.Font = New System.Drawing.Font("Ravie", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TieuDe.ForeColor = System.Drawing.SystemColors.Highlight
        Me.TieuDe.Location = New System.Drawing.Point(295, 9)
        Me.TieuDe.Name = "TieuDe"
        Me.TieuDe.Size = New System.Drawing.Size(209, 61)
        Me.TieuDe.TabIndex = 1
        Me.TieuDe.Text = "Máy tính"
        Me.TieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PhepTinh
        '
        Me.PhepTinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PhepTinh.Controls.Add(Me.Chia)
        Me.PhepTinh.Controls.Add(Me.Nhan)
        Me.PhepTinh.Controls.Add(Me.Tru)
        Me.PhepTinh.Controls.Add(Me.Cong)
        Me.PhepTinh.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhepTinh.Location = New System.Drawing.Point(447, 61)
        Me.PhepTinh.Name = "PhepTinh"
        Me.PhepTinh.Size = New System.Drawing.Size(200, 248)
        Me.PhepTinh.TabIndex = 2
        Me.PhepTinh.TabStop = False
        Me.PhepTinh.Text = "Phép tính cơ bản"
        '
        'Chia
        '
        Me.Chia.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Chia.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Chia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Chia.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chia.Location = New System.Drawing.Point(60, 189)
        Me.Chia.Name = "Chia"
        Me.Chia.Size = New System.Drawing.Size(95, 32)
        Me.Chia.TabIndex = 0
        Me.Chia.Text = "/"
        Me.Chia.UseVisualStyleBackColor = False
        '
        'Nhan
        '
        Me.Nhan.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Nhan.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Nhan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Nhan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nhan.Location = New System.Drawing.Point(60, 141)
        Me.Nhan.Name = "Nhan"
        Me.Nhan.Size = New System.Drawing.Size(95, 32)
        Me.Nhan.TabIndex = 0
        Me.Nhan.Text = "*"
        Me.Nhan.UseVisualStyleBackColor = False
        '
        'Tru
        '
        Me.Tru.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Tru.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Tru.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Tru.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tru.Location = New System.Drawing.Point(59, 87)
        Me.Tru.Name = "Tru"
        Me.Tru.Size = New System.Drawing.Size(95, 32)
        Me.Tru.TabIndex = 0
        Me.Tru.Text = "-"
        Me.Tru.UseVisualStyleBackColor = False
        '
        'Cong
        '
        Me.Cong.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Cong.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Cong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Cong.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cong.Location = New System.Drawing.Point(59, 36)
        Me.Cong.Name = "Cong"
        Me.Cong.Size = New System.Drawing.Size(95, 32)
        Me.Cong.TabIndex = 0
        Me.Cong.Text = "+"
        Me.Cong.UseVisualStyleBackColor = False
        '
        'kqua
        '
        Me.kqua.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kqua.Location = New System.Drawing.Point(301, 333)
        Me.kqua.Multiline = True
        Me.kqua.Name = "kqua"
        Me.kqua.Size = New System.Drawing.Size(106, 32)
        Me.kqua.TabIndex = 9
        Me.kqua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Dong
        '
        Me.Dong.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Dong.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Dong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Dong.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dong.Location = New System.Drawing.Point(409, 381)
        Me.Dong.Name = "Dong"
        Me.Dong.Size = New System.Drawing.Size(95, 32)
        Me.Dong.TabIndex = 5
        Me.Dong.Text = "Đóng"
        Me.Dong.UseVisualStyleBackColor = False
        '
        'Xoa
        '
        Me.Xoa.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Xoa.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Xoa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Xoa.Location = New System.Drawing.Point(301, 381)
        Me.Xoa.Name = "Xoa"
        Me.Xoa.Size = New System.Drawing.Size(95, 32)
        Me.Xoa.TabIndex = 6
        Me.Xoa.Text = "Xóa"
        Me.Xoa.UseVisualStyleBackColor = False
        '
        'Bang
        '
        Me.Bang.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Bang.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Bang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bang.Location = New System.Drawing.Point(191, 381)
        Me.Bang.Name = "Bang"
        Me.Bang.Size = New System.Drawing.Size(95, 32)
        Me.Bang.TabIndex = 7
        Me.Bang.Text = "="
        Me.Bang.UseVisualStyleBackColor = False
        '
        'KetQua
        '
        Me.KetQua.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KetQua.Location = New System.Drawing.Point(200, 330)
        Me.KetQua.Name = "KetQua"
        Me.KetQua.Size = New System.Drawing.Size(119, 41)
        Me.KetQua.TabIndex = 8
        Me.KetQua.Text = "Kết quả : "
        Me.KetQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'So
        '
        Me.So.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.So.Controls.Add(Me.HienThi)
        Me.So.Controls.Add(Me.three)
        Me.So.Controls.Add(Me.one)
        Me.So.Controls.Add(Me.two)
        Me.So.Controls.Add(Me.four)
        Me.So.Controls.Add(Me.nine)
        Me.So.Controls.Add(Me.five)
        Me.So.Controls.Add(Me.zero)
        Me.So.Controls.Add(Me.six)
        Me.So.Controls.Add(Me.eight)
        Me.So.Controls.Add(Me.seven)
        Me.So.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.So.Location = New System.Drawing.Point(125, 61)
        Me.So.Name = "So"
        Me.So.Size = New System.Drawing.Size(240, 248)
        Me.So.TabIndex = 2
        Me.So.TabStop = False
        Me.So.Text = "Số"
        '
        'HienThi
        '
        Me.HienThi.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HienThi.Location = New System.Drawing.Point(104, 198)
        Me.HienThi.Multiline = True
        Me.HienThi.Name = "HienThi"
        Me.HienThi.Size = New System.Drawing.Size(106, 32)
        Me.HienThi.TabIndex = 9
        Me.HienThi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'three
        '
        Me.three.BackColor = System.Drawing.Color.LightGray
        Me.three.Location = New System.Drawing.Point(165, 29)
        Me.three.Name = "three"
        Me.three.Size = New System.Drawing.Size(53, 38)
        Me.three.TabIndex = 10
        Me.three.Text = "3"
        Me.three.UseVisualStyleBackColor = False
        '
        'one
        '
        Me.one.BackColor = System.Drawing.Color.LightGray
        Me.one.Location = New System.Drawing.Point(21, 29)
        Me.one.Name = "one"
        Me.one.Size = New System.Drawing.Size(53, 38)
        Me.one.TabIndex = 19
        Me.one.Text = "1"
        Me.one.UseVisualStyleBackColor = False
        '
        'two
        '
        Me.two.BackColor = System.Drawing.Color.LightGray
        Me.two.Location = New System.Drawing.Point(93, 29)
        Me.two.Name = "two"
        Me.two.Size = New System.Drawing.Size(53, 38)
        Me.two.TabIndex = 11
        Me.two.Text = "2"
        Me.two.UseVisualStyleBackColor = False
        '
        'four
        '
        Me.four.BackColor = System.Drawing.Color.LightGray
        Me.four.Location = New System.Drawing.Point(21, 86)
        Me.four.Name = "four"
        Me.four.Size = New System.Drawing.Size(53, 38)
        Me.four.TabIndex = 18
        Me.four.Text = "4"
        Me.four.UseVisualStyleBackColor = False
        '
        'nine
        '
        Me.nine.BackColor = System.Drawing.Color.LightGray
        Me.nine.Location = New System.Drawing.Point(165, 140)
        Me.nine.Name = "nine"
        Me.nine.Size = New System.Drawing.Size(53, 38)
        Me.nine.TabIndex = 12
        Me.nine.Text = "9"
        Me.nine.UseVisualStyleBackColor = False
        '
        'five
        '
        Me.five.BackColor = System.Drawing.Color.LightGray
        Me.five.Location = New System.Drawing.Point(93, 86)
        Me.five.Name = "five"
        Me.five.Size = New System.Drawing.Size(53, 38)
        Me.five.TabIndex = 17
        Me.five.Text = "5"
        Me.five.UseVisualStyleBackColor = False
        '
        'zero
        '
        Me.zero.BackColor = System.Drawing.Color.LightGray
        Me.zero.Location = New System.Drawing.Point(21, 196)
        Me.zero.Name = "zero"
        Me.zero.Size = New System.Drawing.Size(53, 38)
        Me.zero.TabIndex = 13
        Me.zero.Text = "0"
        Me.zero.UseVisualStyleBackColor = False
        '
        'six
        '
        Me.six.BackColor = System.Drawing.Color.LightGray
        Me.six.Location = New System.Drawing.Point(165, 86)
        Me.six.Name = "six"
        Me.six.Size = New System.Drawing.Size(53, 38)
        Me.six.TabIndex = 16
        Me.six.Text = "6"
        Me.six.UseVisualStyleBackColor = False
        '
        'eight
        '
        Me.eight.BackColor = System.Drawing.Color.LightGray
        Me.eight.Location = New System.Drawing.Point(93, 140)
        Me.eight.Name = "eight"
        Me.eight.Size = New System.Drawing.Size(53, 38)
        Me.eight.TabIndex = 14
        Me.eight.Text = "8"
        Me.eight.UseVisualStyleBackColor = False
        '
        'seven
        '
        Me.seven.BackColor = System.Drawing.Color.LightGray
        Me.seven.Location = New System.Drawing.Point(21, 140)
        Me.seven.Name = "seven"
        Me.seven.Size = New System.Drawing.Size(53, 38)
        Me.seven.TabIndex = 15
        Me.seven.Text = "7"
        Me.seven.UseVisualStyleBackColor = False
        '
        'Calculator2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 450)
        Me.Controls.Add(Me.kqua)
        Me.Controls.Add(Me.Dong)
        Me.Controls.Add(Me.Xoa)
        Me.Controls.Add(Me.Bang)
        Me.Controls.Add(Me.KetQua)
        Me.Controls.Add(Me.So)
        Me.Controls.Add(Me.PhepTinh)
        Me.Controls.Add(Me.TieuDe)
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "Calculator2"
        Me.Text = "Calculator2"
        Me.PhepTinh.ResumeLayout(False)
        Me.So.ResumeLayout(False)
        Me.So.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TieuDe As Label
    Friend WithEvents PhepTinh As GroupBox
    Friend WithEvents Chia As Button
    Friend WithEvents Nhan As Button
    Friend WithEvents Tru As Button
    Friend WithEvents Cong As Button
    Friend WithEvents kqua As TextBox
    Friend WithEvents Dong As Button
    Friend WithEvents Xoa As Button
    Friend WithEvents Bang As Button
    Friend WithEvents KetQua As Label
    Friend WithEvents So As GroupBox
    Friend WithEvents three As Button
    Friend WithEvents two As Button
    Friend WithEvents nine As Button
    Friend WithEvents zero As Button
    Friend WithEvents eight As Button
    Friend WithEvents seven As Button
    Friend WithEvents six As Button
    Friend WithEvents five As Button
    Friend WithEvents four As Button
    Friend WithEvents one As Button
    Friend WithEvents HienThi As TextBox
End Class
