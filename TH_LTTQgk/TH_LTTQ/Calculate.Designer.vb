<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculate
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
        Me.Nhap_a = New System.Windows.Forms.Label()
        Me.Nhap_b = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Basic_calculate = New System.Windows.Forms.GroupBox()
        Me.Dong = New System.Windows.Forms.Button()
        Me.Xoa = New System.Windows.Forms.Button()
        Me.Bang = New System.Windows.Forms.Button()
        Me.Chia_lay_du = New System.Windows.Forms.Button()
        Me.Chia = New System.Windows.Forms.Button()
        Me.Nhan = New System.Windows.Forms.Button()
        Me.Tru = New System.Windows.Forms.Button()
        Me.Cong = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Ketqua1 = New System.Windows.Forms.Label()
        Me.number = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.SquareRoot_Power = New System.Windows.Forms.GroupBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dong_2 = New System.Windows.Forms.Button()
        Me.Xoa_2 = New System.Windows.Forms.Button()
        Me.Bang_2 = New System.Windows.Forms.Button()
        Me.Luythua = New System.Windows.Forms.Button()
        Me.CanBac2 = New System.Windows.Forms.Button()
        Me.Nhap_chieudai = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Nhap_chieurong = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Nhap_bankinh = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Square = New System.Windows.Forms.Button()
        Me.Circle = New System.Windows.Forms.Button()
        Me.Rectangle = New System.Windows.Forms.Button()
        Me.bang_3 = New System.Windows.Forms.Button()
        Me.Xoa_3 = New System.Windows.Forms.Button()
        Me.Dong_3 = New System.Windows.Forms.Button()
        Me.Quadrilateral = New System.Windows.Forms.Button()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Triangle = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Basic_calculate.SuspendLayout()
        Me.SquareRoot_Power.SuspendLayout()
        Me.SuspendLayout()
        '
        'Nhap_a
        '
        Me.Nhap_a.Location = New System.Drawing.Point(44, 52)
        Me.Nhap_a.Name = "Nhap_a"
        Me.Nhap_a.Size = New System.Drawing.Size(100, 23)
        Me.Nhap_a.TabIndex = 0
        Me.Nhap_a.Text = "Nhập a:"
        '
        'Nhap_b
        '
        Me.Nhap_b.Location = New System.Drawing.Point(44, 90)
        Me.Nhap_b.Name = "Nhap_b"
        Me.Nhap_b.Size = New System.Drawing.Size(100, 23)
        Me.Nhap_b.TabIndex = 1
        Me.Nhap_b.Text = "Nhập b: "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(111, 49)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(112, 22)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(111, 90)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(112, 22)
        Me.TextBox2.TabIndex = 3
        '
        'Basic_calculate
        '
        Me.Basic_calculate.Controls.Add(Me.Dong)
        Me.Basic_calculate.Controls.Add(Me.Xoa)
        Me.Basic_calculate.Controls.Add(Me.Bang)
        Me.Basic_calculate.Controls.Add(Me.Chia_lay_du)
        Me.Basic_calculate.Controls.Add(Me.Chia)
        Me.Basic_calculate.Controls.Add(Me.Nhan)
        Me.Basic_calculate.Controls.Add(Me.Tru)
        Me.Basic_calculate.Controls.Add(Me.Cong)
        Me.Basic_calculate.Controls.Add(Me.TextBox3)
        Me.Basic_calculate.Controls.Add(Me.Ketqua1)
        Me.Basic_calculate.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Basic_calculate.Location = New System.Drawing.Point(12, 21)
        Me.Basic_calculate.Name = "Basic_calculate"
        Me.Basic_calculate.Size = New System.Drawing.Size(776, 213)
        Me.Basic_calculate.TabIndex = 4
        Me.Basic_calculate.TabStop = False
        Me.Basic_calculate.Text = "+, -, *, /, %"
        '
        'Dong
        '
        Me.Dong.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Dong.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Dong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Dong.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dong.Location = New System.Drawing.Point(252, 157)
        Me.Dong.Name = "Dong"
        Me.Dong.Size = New System.Drawing.Size(95, 32)
        Me.Dong.TabIndex = 11
        Me.Dong.Text = "Đóng"
        Me.Dong.UseVisualStyleBackColor = False
        '
        'Xoa
        '
        Me.Xoa.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Xoa.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Xoa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Xoa.Location = New System.Drawing.Point(135, 157)
        Me.Xoa.Name = "Xoa"
        Me.Xoa.Size = New System.Drawing.Size(95, 32)
        Me.Xoa.TabIndex = 10
        Me.Xoa.Text = "Xóa"
        Me.Xoa.UseVisualStyleBackColor = False
        '
        'Bang
        '
        Me.Bang.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Bang.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Bang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bang.Location = New System.Drawing.Point(19, 157)
        Me.Bang.Name = "Bang"
        Me.Bang.Size = New System.Drawing.Size(95, 32)
        Me.Bang.TabIndex = 5
        Me.Bang.Text = "="
        Me.Bang.UseVisualStyleBackColor = False
        '
        'Chia_lay_du
        '
        Me.Chia_lay_du.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Chia_lay_du.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Chia_lay_du.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Chia_lay_du.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chia_lay_du.Location = New System.Drawing.Point(493, 172)
        Me.Chia_lay_du.Name = "Chia_lay_du"
        Me.Chia_lay_du.Size = New System.Drawing.Size(95, 32)
        Me.Chia_lay_du.TabIndex = 9
        Me.Chia_lay_du.Text = "%"
        Me.Chia_lay_du.UseVisualStyleBackColor = False
        '
        'Chia
        '
        Me.Chia.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Chia.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Chia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Chia.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chia.Location = New System.Drawing.Point(493, 132)
        Me.Chia.Name = "Chia"
        Me.Chia.Size = New System.Drawing.Size(95, 32)
        Me.Chia.TabIndex = 8
        Me.Chia.Text = "/"
        Me.Chia.UseVisualStyleBackColor = False
        '
        'Nhan
        '
        Me.Nhan.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Nhan.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Nhan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Nhan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nhan.Location = New System.Drawing.Point(493, 94)
        Me.Nhan.Name = "Nhan"
        Me.Nhan.Size = New System.Drawing.Size(95, 32)
        Me.Nhan.TabIndex = 7
        Me.Nhan.Text = "*"
        Me.Nhan.UseVisualStyleBackColor = False
        '
        'Tru
        '
        Me.Tru.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Tru.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Tru.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Tru.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tru.Location = New System.Drawing.Point(493, 56)
        Me.Tru.Name = "Tru"
        Me.Tru.Size = New System.Drawing.Size(95, 32)
        Me.Tru.TabIndex = 6
        Me.Tru.Text = "-"
        Me.Tru.UseVisualStyleBackColor = False
        '
        'Cong
        '
        Me.Cong.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Cong.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Cong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Cong.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cong.Location = New System.Drawing.Point(493, 18)
        Me.Cong.Name = "Cong"
        Me.Cong.Size = New System.Drawing.Size(95, 32)
        Me.Cong.TabIndex = 5
        Me.Cong.Text = "+"
        Me.Cong.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(99, 113)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(112, 22)
        Me.TextBox3.TabIndex = 1
        '
        'Ketqua1
        '
        Me.Ketqua1.AutoSize = True
        Me.Ketqua1.Location = New System.Drawing.Point(35, 113)
        Me.Ketqua1.Name = "Ketqua1"
        Me.Ketqua1.Size = New System.Drawing.Size(55, 16)
        Me.Ketqua1.TabIndex = 0
        Me.Ketqua1.Text = "Kết quả:"
        '
        'number
        '
        Me.number.AutoSize = True
        Me.number.Location = New System.Drawing.Point(44, 309)
        Me.number.Name = "number"
        Me.number.Size = New System.Drawing.Size(89, 16)
        Me.number.TabIndex = 5
        Me.number.Text = "Nhập một số: "
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(147, 309)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 22)
        Me.TextBox4.TabIndex = 6
        '
        'SquareRoot_Power
        '
        Me.SquareRoot_Power.Controls.Add(Me.TextBox8)
        Me.SquareRoot_Power.Controls.Add(Me.Label1)
        Me.SquareRoot_Power.Controls.Add(Me.Dong_2)
        Me.SquareRoot_Power.Controls.Add(Me.Xoa_2)
        Me.SquareRoot_Power.Controls.Add(Me.Bang_2)
        Me.SquareRoot_Power.Controls.Add(Me.Luythua)
        Me.SquareRoot_Power.Controls.Add(Me.CanBac2)
        Me.SquareRoot_Power.Location = New System.Drawing.Point(12, 270)
        Me.SquareRoot_Power.Name = "SquareRoot_Power"
        Me.SquareRoot_Power.Size = New System.Drawing.Size(776, 113)
        Me.SquareRoot_Power.TabIndex = 7
        Me.SquareRoot_Power.TabStop = False
        Me.SquareRoot_Power.Text = "Căn bậc 2 & lũy thừa"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(323, 39)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(112, 22)
        Me.TextBox8.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(259, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Kết quả:"
        '
        'Dong_2
        '
        Me.Dong_2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Dong_2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Dong_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Dong_2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dong_2.Location = New System.Drawing.Point(252, 75)
        Me.Dong_2.Name = "Dong_2"
        Me.Dong_2.Size = New System.Drawing.Size(95, 32)
        Me.Dong_2.TabIndex = 11
        Me.Dong_2.Text = "Đóng"
        Me.Dong_2.UseVisualStyleBackColor = False
        '
        'Xoa_2
        '
        Me.Xoa_2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Xoa_2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Xoa_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Xoa_2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Xoa_2.Location = New System.Drawing.Point(135, 75)
        Me.Xoa_2.Name = "Xoa_2"
        Me.Xoa_2.Size = New System.Drawing.Size(95, 32)
        Me.Xoa_2.TabIndex = 12
        Me.Xoa_2.Text = "Xóa"
        Me.Xoa_2.UseVisualStyleBackColor = False
        '
        'Bang_2
        '
        Me.Bang_2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Bang_2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bang_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Bang_2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bang_2.Location = New System.Drawing.Point(19, 75)
        Me.Bang_2.Name = "Bang_2"
        Me.Bang_2.Size = New System.Drawing.Size(95, 32)
        Me.Bang_2.TabIndex = 10
        Me.Bang_2.Text = "="
        Me.Bang_2.UseVisualStyleBackColor = False
        '
        'Luythua
        '
        Me.Luythua.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Luythua.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Luythua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Luythua.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Luythua.Location = New System.Drawing.Point(493, 59)
        Me.Luythua.Name = "Luythua"
        Me.Luythua.Size = New System.Drawing.Size(95, 32)
        Me.Luythua.TabIndex = 9
        Me.Luythua.Text = "x^2"
        Me.Luythua.UseVisualStyleBackColor = False
        '
        'CanBac2
        '
        Me.CanBac2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CanBac2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CanBac2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.CanBac2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CanBac2.Location = New System.Drawing.Point(493, 21)
        Me.CanBac2.Name = "CanBac2"
        Me.CanBac2.Size = New System.Drawing.Size(95, 32)
        Me.CanBac2.TabIndex = 9
        Me.CanBac2.Text = "√"
        Me.CanBac2.UseVisualStyleBackColor = False
        '
        'Nhap_chieudai
        '
        Me.Nhap_chieudai.AutoSize = True
        Me.Nhap_chieudai.Location = New System.Drawing.Point(28, 437)
        Me.Nhap_chieudai.Name = "Nhap_chieudai"
        Me.Nhap_chieudai.Size = New System.Drawing.Size(100, 16)
        Me.Nhap_chieudai.TabIndex = 8
        Me.Nhap_chieudai.Text = "Nhập chiều dài:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(147, 433)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 22)
        Me.TextBox5.TabIndex = 9
        '
        'Nhap_chieurong
        '
        Me.Nhap_chieurong.AutoSize = True
        Me.Nhap_chieurong.Location = New System.Drawing.Point(28, 471)
        Me.Nhap_chieurong.Name = "Nhap_chieurong"
        Me.Nhap_chieurong.Size = New System.Drawing.Size(108, 16)
        Me.Nhap_chieurong.TabIndex = 8
        Me.Nhap_chieurong.Text = "Nhập chiều rộng:"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(147, 467)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 22)
        Me.TextBox6.TabIndex = 9
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(534, 433)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 22)
        Me.TextBox7.TabIndex = 11
        '
        'Nhap_bankinh
        '
        Me.Nhap_bankinh.AutoSize = True
        Me.Nhap_bankinh.Location = New System.Drawing.Point(432, 437)
        Me.Nhap_bankinh.Name = "Nhap_bankinh"
        Me.Nhap_bankinh.Size = New System.Drawing.Size(96, 16)
        Me.Nhap_bankinh.TabIndex = 10
        Me.Nhap_bankinh.Text = "Nhập bán kính:"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(364, 566)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(150, 22)
        Me.TextBox9.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(303, 570)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Kết quả:"
        '
        'Square
        '
        Me.Square.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Square.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Square.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Square.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Square.Location = New System.Drawing.Point(263, 508)
        Me.Square.Name = "Square"
        Me.Square.Size = New System.Drawing.Size(95, 32)
        Me.Square.TabIndex = 14
        Me.Square.Text = "Vuông"
        Me.Square.UseVisualStyleBackColor = False
        '
        'Circle
        '
        Me.Circle.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Circle.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Circle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Circle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Circle.Location = New System.Drawing.Point(656, 427)
        Me.Circle.Name = "Circle"
        Me.Circle.Size = New System.Drawing.Size(95, 32)
        Me.Circle.TabIndex = 15
        Me.Circle.Text = "Tròn"
        Me.Circle.UseVisualStyleBackColor = False
        '
        'Rectangle
        '
        Me.Rectangle.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Rectangle.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Rectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Rectangle.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rectangle.Location = New System.Drawing.Point(263, 445)
        Me.Rectangle.Name = "Rectangle"
        Me.Rectangle.Size = New System.Drawing.Size(95, 32)
        Me.Rectangle.TabIndex = 16
        Me.Rectangle.Text = "Chữ nhật"
        Me.Rectangle.UseVisualStyleBackColor = False
        '
        'bang_3
        '
        Me.bang_3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.bang_3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.bang_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.bang_3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bang_3.Location = New System.Drawing.Point(240, 605)
        Me.bang_3.Name = "bang_3"
        Me.bang_3.Size = New System.Drawing.Size(95, 32)
        Me.bang_3.TabIndex = 17
        Me.bang_3.Text = "="
        Me.bang_3.UseVisualStyleBackColor = False
        '
        'Xoa_3
        '
        Me.Xoa_3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Xoa_3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Xoa_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Xoa_3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Xoa_3.Location = New System.Drawing.Point(352, 605)
        Me.Xoa_3.Name = "Xoa_3"
        Me.Xoa_3.Size = New System.Drawing.Size(95, 32)
        Me.Xoa_3.TabIndex = 18
        Me.Xoa_3.Text = "Xóa"
        Me.Xoa_3.UseVisualStyleBackColor = False
        '
        'Dong_3
        '
        Me.Dong_3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Dong_3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Dong_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Dong_3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dong_3.Location = New System.Drawing.Point(461, 605)
        Me.Dong_3.Name = "Dong_3"
        Me.Dong_3.Size = New System.Drawing.Size(95, 32)
        Me.Dong_3.TabIndex = 19
        Me.Dong_3.Text = "Đóng"
        Me.Dong_3.UseVisualStyleBackColor = False
        '
        'Quadrilateral
        '
        Me.Quadrilateral.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Quadrilateral.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Quadrilateral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Quadrilateral.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quadrilateral.Location = New System.Drawing.Point(656, 513)
        Me.Quadrilateral.Name = "Quadrilateral"
        Me.Quadrilateral.Size = New System.Drawing.Size(95, 32)
        Me.Quadrilateral.TabIndex = 20
        Me.Quadrilateral.Text = "Tứ giác"
        Me.Quadrilateral.UseVisualStyleBackColor = False
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(534, 481)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(100, 22)
        Me.TextBox10.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(427, 484)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Nhập cạnh đáy:"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(534, 515)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(100, 22)
        Me.TextBox11.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(427, 519)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Nhập chiều cao:"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(147, 515)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(100, 22)
        Me.TextBox12.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 518)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Nhập một cạnh:"
        '
        'Triangle
        '
        Me.Triangle.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Triangle.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Triangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Triangle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Triangle.Location = New System.Drawing.Point(655, 475)
        Me.Triangle.Name = "Triangle"
        Me.Triangle.Size = New System.Drawing.Size(95, 32)
        Me.Triangle.TabIndex = 35
        Me.Triangle.Text = "Tam giác"
        Me.Triangle.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 415)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 234)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Geometry"
        '
        'Calculate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 660)
        Me.Controls.Add(Me.Triangle)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Quadrilateral)
        Me.Controls.Add(Me.Dong_3)
        Me.Controls.Add(Me.Xoa_3)
        Me.Controls.Add(Me.bang_3)
        Me.Controls.Add(Me.Rectangle)
        Me.Controls.Add(Me.Circle)
        Me.Controls.Add(Me.Square)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Nhap_bankinh)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Nhap_chieurong)
        Me.Controls.Add(Me.Nhap_chieudai)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.number)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Nhap_b)
        Me.Controls.Add(Me.Nhap_a)
        Me.Controls.Add(Me.Basic_calculate)
        Me.Controls.Add(Me.SquareRoot_Power)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Calculate"
        Me.Text = "Calculate"
        Me.Basic_calculate.ResumeLayout(False)
        Me.Basic_calculate.PerformLayout()
        Me.SquareRoot_Power.ResumeLayout(False)
        Me.SquareRoot_Power.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Nhap_a As Label
    Friend WithEvents Nhap_b As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Basic_calculate As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Ketqua1 As Label
    Friend WithEvents Cong As Button
    Friend WithEvents Tru As Button
    Friend WithEvents Nhan As Button
    Friend WithEvents Chia_lay_du As Button
    Friend WithEvents Chia As Button
    Friend WithEvents Bang As Button
    Friend WithEvents Xoa As Button
    Friend WithEvents Dong As Button
    Friend WithEvents number As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents SquareRoot_Power As GroupBox
    Friend WithEvents Dong_2 As Button
    Friend WithEvents Xoa_2 As Button
    Friend WithEvents Bang_2 As Button
    Friend WithEvents Luythua As Button
    Friend WithEvents CanBac2 As Button
    Friend WithEvents Nhap_chieudai As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Nhap_chieurong As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Nhap_bankinh As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Square As Button
    Friend WithEvents Circle As Button
    Friend WithEvents Rectangle As Button
    Friend WithEvents bang_3 As Button
    Friend WithEvents Xoa_3 As Button
    Friend WithEvents Dong_3 As Button
    Friend WithEvents Quadrilateral As Button
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Triangle As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
