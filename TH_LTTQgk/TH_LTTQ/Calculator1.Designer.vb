<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculator1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PhepTinh = New System.Windows.Forms.GroupBox()
        Me.Chia = New System.Windows.Forms.Button()
        Me.Nhan = New System.Windows.Forms.Button()
        Me.Tru = New System.Windows.Forms.Button()
        Me.Cong = New System.Windows.Forms.Button()
        Me.TieuDe = New System.Windows.Forms.Label()
        Me.SoThu1 = New System.Windows.Forms.Label()
        Me.nhap1 = New System.Windows.Forms.TextBox()
        Me.KetQua = New System.Windows.Forms.Label()
        Me.kqua = New System.Windows.Forms.TextBox()
        Me.SoThu2 = New System.Windows.Forms.Label()
        Me.nhap2 = New System.Windows.Forms.TextBox()
        Me.Bang = New System.Windows.Forms.Button()
        Me.Xoa = New System.Windows.Forms.Button()
        Me.Dong = New System.Windows.Forms.Button()
        Me.PhepTinh.SuspendLayout()
        Me.SuspendLayout()
        '
        'PhepTinh
        '
        Me.PhepTinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PhepTinh.Controls.Add(Me.Chia)
        Me.PhepTinh.Controls.Add(Me.Nhan)
        Me.PhepTinh.Controls.Add(Me.Tru)
        Me.PhepTinh.Controls.Add(Me.Cong)
        Me.PhepTinh.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhepTinh.Location = New System.Drawing.Point(527, 75)
        Me.PhepTinh.Name = "PhepTinh"
        Me.PhepTinh.Size = New System.Drawing.Size(200, 248)
        Me.PhepTinh.TabIndex = 1
        Me.PhepTinh.TabStop = False
        Me.PhepTinh.Text = "Phép tính"
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
        'TieuDe
        '
        Me.TieuDe.Font = New System.Drawing.Font("Ravie", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TieuDe.ForeColor = System.Drawing.SystemColors.Highlight
        Me.TieuDe.Location = New System.Drawing.Point(333, 9)
        Me.TieuDe.Name = "TieuDe"
        Me.TieuDe.Size = New System.Drawing.Size(209, 61)
        Me.TieuDe.TabIndex = 0
        Me.TieuDe.Text = "Máy tính"
        Me.TieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SoThu1
        '
        Me.SoThu1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoThu1.Location = New System.Drawing.Point(161, 75)
        Me.SoThu1.Name = "SoThu1"
        Me.SoThu1.Size = New System.Drawing.Size(119, 41)
        Me.SoThu1.TabIndex = 3
        Me.SoThu1.Text = "Số thứ nhất :"
        Me.SoThu1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nhap1
        '
        Me.nhap1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nhap1.Location = New System.Drawing.Point(286, 75)
        Me.nhap1.Multiline = True
        Me.nhap1.Name = "nhap1"
        Me.nhap1.Size = New System.Drawing.Size(106, 32)
        Me.nhap1.TabIndex = 4
        Me.nhap1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KetQua
        '
        Me.KetQua.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KetQua.Location = New System.Drawing.Point(161, 207)
        Me.KetQua.Name = "KetQua"
        Me.KetQua.Size = New System.Drawing.Size(119, 41)
        Me.KetQua.TabIndex = 3
        Me.KetQua.Text = "Kết quả : "
        Me.KetQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'kqua
        '
        Me.kqua.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kqua.Location = New System.Drawing.Point(286, 207)
        Me.kqua.Multiline = True
        Me.kqua.Name = "kqua"
        Me.kqua.Size = New System.Drawing.Size(106, 32)
        Me.kqua.TabIndex = 4
        Me.kqua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SoThu2
        '
        Me.SoThu2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoThu2.Location = New System.Drawing.Point(161, 142)
        Me.SoThu2.Name = "SoThu2"
        Me.SoThu2.Size = New System.Drawing.Size(119, 41)
        Me.SoThu2.TabIndex = 3
        Me.SoThu2.Text = "Số thứ hai :"
        Me.SoThu2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nhap2
        '
        Me.nhap2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nhap2.Location = New System.Drawing.Point(286, 142)
        Me.nhap2.Multiline = True
        Me.nhap2.Name = "nhap2"
        Me.nhap2.Size = New System.Drawing.Size(106, 32)
        Me.nhap2.TabIndex = 4
        Me.nhap2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Bang
        '
        Me.Bang.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Bang.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Bang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bang.Location = New System.Drawing.Point(144, 276)
        Me.Bang.Name = "Bang"
        Me.Bang.Size = New System.Drawing.Size(95, 32)
        Me.Bang.TabIndex = 0
        Me.Bang.Text = "="
        Me.Bang.UseVisualStyleBackColor = False
        '
        'Xoa
        '
        Me.Xoa.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Xoa.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Xoa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Xoa.Location = New System.Drawing.Point(268, 276)
        Me.Xoa.Name = "Xoa"
        Me.Xoa.Size = New System.Drawing.Size(95, 32)
        Me.Xoa.TabIndex = 0
        Me.Xoa.Text = "Xóa"
        Me.Xoa.UseVisualStyleBackColor = False
        '
        'Dong
        '
        Me.Dong.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Dong.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Dong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Dong.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dong.Location = New System.Drawing.Point(380, 276)
        Me.Dong.Name = "Dong"
        Me.Dong.Size = New System.Drawing.Size(95, 32)
        Me.Dong.TabIndex = 0
        Me.Dong.Text = "Đóng"
        Me.Dong.UseVisualStyleBackColor = False
        '
        'Calculator1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(918, 630)
        Me.Controls.Add(Me.nhap2)
        Me.Controls.Add(Me.kqua)
        Me.Controls.Add(Me.nhap1)
        Me.Controls.Add(Me.Dong)
        Me.Controls.Add(Me.Xoa)
        Me.Controls.Add(Me.Bang)
        Me.Controls.Add(Me.SoThu2)
        Me.Controls.Add(Me.KetQua)
        Me.Controls.Add(Me.SoThu1)
        Me.Controls.Add(Me.TieuDe)
        Me.Controls.Add(Me.PhepTinh)
        Me.Name = "Calculator1"
        Me.Text = "Calculator1"
        Me.PhepTinh.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PhepTinh As GroupBox
    Friend WithEvents TieuDe As Label
    Friend WithEvents Cong As Button
    Friend WithEvents Chia As Button
    Friend WithEvents Nhan As Button
    Friend WithEvents Tru As Button
    Friend WithEvents SoThu1 As Label
    Friend WithEvents nhap1 As TextBox
    Friend WithEvents KetQua As Label
    Friend WithEvents kqua As TextBox
    Friend WithEvents SoThu2 As Label
    Friend WithEvents nhap2 As TextBox
    Friend WithEvents Bang As Button
    Friend WithEvents Xoa As Button
    Friend WithEvents Dong As Button
End Class
