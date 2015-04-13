<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmquanly
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
        Me.lblma = New System.Windows.Forms.Label()
        Me.lblten = New System.Windows.Forms.Label()
        Me.lbldongia = New System.Windows.Forms.Label()
        Me.lblsoluong = New System.Windows.Forms.Label()
        Me.lblchitiet = New System.Windows.Forms.Label()
        Me.lblloai = New System.Windows.Forms.Label()
        Me.txtma = New System.Windows.Forms.TextBox()
        Me.txtten = New System.Windows.Forms.TextBox()
        Me.txtdongia = New System.Windows.Forms.TextBox()
        Me.txtsoluong = New System.Windows.Forms.TextBox()
        Me.txtchitiet = New System.Windows.Forms.TextBox()
        Me.txtloai = New System.Windows.Forms.TextBox()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.dataview = New System.Windows.Forms.DataGridView()
        CType(Me.dataview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblma
        '
        Me.lblma.AutoSize = True
        Me.lblma.Location = New System.Drawing.Point(12, 19)
        Me.lblma.Name = "lblma"
        Me.lblma.Size = New System.Drawing.Size(22, 13)
        Me.lblma.TabIndex = 1
        Me.lblma.Text = "Mã"
        '
        'lblten
        '
        Me.lblten.AutoSize = True
        Me.lblten.Location = New System.Drawing.Point(12, 58)
        Me.lblten.Name = "lblten"
        Me.lblten.Size = New System.Drawing.Size(26, 13)
        Me.lblten.TabIndex = 2
        Me.lblten.Text = "Tên"
        '
        'lbldongia
        '
        Me.lbldongia.AutoSize = True
        Me.lbldongia.Location = New System.Drawing.Point(12, 94)
        Me.lbldongia.Name = "lbldongia"
        Me.lbldongia.Size = New System.Drawing.Size(44, 13)
        Me.lbldongia.TabIndex = 3
        Me.lbldongia.Text = "Đơn giá"
        '
        'lblsoluong
        '
        Me.lblsoluong.AutoSize = True
        Me.lblsoluong.Location = New System.Drawing.Point(12, 130)
        Me.lblsoluong.Name = "lblsoluong"
        Me.lblsoluong.Size = New System.Drawing.Size(49, 13)
        Me.lblsoluong.TabIndex = 4
        Me.lblsoluong.Text = "Số lượng"
        '
        'lblchitiet
        '
        Me.lblchitiet.AutoSize = True
        Me.lblchitiet.Location = New System.Drawing.Point(12, 166)
        Me.lblchitiet.Name = "lblchitiet"
        Me.lblchitiet.Size = New System.Drawing.Size(39, 13)
        Me.lblchitiet.TabIndex = 5
        Me.lblchitiet.Text = "Chi tiết"
        '
        'lblloai
        '
        Me.lblloai.AutoSize = True
        Me.lblloai.Location = New System.Drawing.Point(12, 206)
        Me.lblloai.Name = "lblloai"
        Me.lblloai.Size = New System.Drawing.Size(27, 13)
        Me.lblloai.TabIndex = 6
        Me.lblloai.Text = "Loại"
        '
        'txtma
        '
        Me.txtma.Location = New System.Drawing.Point(113, 12)
        Me.txtma.Name = "txtma"
        Me.txtma.Size = New System.Drawing.Size(100, 20)
        Me.txtma.TabIndex = 0
        '
        'txtten
        '
        Me.txtten.Location = New System.Drawing.Point(113, 51)
        Me.txtten.Name = "txtten"
        Me.txtten.Size = New System.Drawing.Size(100, 20)
        Me.txtten.TabIndex = 1
        '
        'txtdongia
        '
        Me.txtdongia.Location = New System.Drawing.Point(113, 87)
        Me.txtdongia.Name = "txtdongia"
        Me.txtdongia.Size = New System.Drawing.Size(100, 20)
        Me.txtdongia.TabIndex = 2
        '
        'txtsoluong
        '
        Me.txtsoluong.Location = New System.Drawing.Point(113, 123)
        Me.txtsoluong.Name = "txtsoluong"
        Me.txtsoluong.Size = New System.Drawing.Size(100, 20)
        Me.txtsoluong.TabIndex = 3
        '
        'txtchitiet
        '
        Me.txtchitiet.Location = New System.Drawing.Point(113, 163)
        Me.txtchitiet.Name = "txtchitiet"
        Me.txtchitiet.Size = New System.Drawing.Size(100, 20)
        Me.txtchitiet.TabIndex = 4
        '
        'txtloai
        '
        Me.txtloai.Location = New System.Drawing.Point(113, 199)
        Me.txtloai.Name = "txtloai"
        Me.txtloai.Size = New System.Drawing.Size(100, 20)
        Me.txtloai.TabIndex = 5
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(15, 266)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 23)
        Me.btnthem.TabIndex = 7
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(138, 266)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(75, 23)
        Me.btnsua.TabIndex = 8
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(284, 266)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.TabIndex = 9
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnthoat
        '
        Me.btnthoat.Location = New System.Drawing.Point(406, 266)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(75, 23)
        Me.btnthoat.TabIndex = 10
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'dataview
        '
        Me.dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataview.Location = New System.Drawing.Point(12, 307)
        Me.dataview.Name = "dataview"
        Me.dataview.Size = New System.Drawing.Size(717, 150)
        Me.dataview.TabIndex = 11
        '
        'frmquanly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 469)
        Me.Controls.Add(Me.dataview)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.txtloai)
        Me.Controls.Add(Me.txtchitiet)
        Me.Controls.Add(Me.txtsoluong)
        Me.Controls.Add(Me.txtdongia)
        Me.Controls.Add(Me.txtten)
        Me.Controls.Add(Me.txtma)
        Me.Controls.Add(Me.lblloai)
        Me.Controls.Add(Me.lblchitiet)
        Me.Controls.Add(Me.lblsoluong)
        Me.Controls.Add(Me.lbldongia)
        Me.Controls.Add(Me.lblten)
        Me.Controls.Add(Me.lblma)
        Me.Name = "frmquanly"
        Me.Text = "Quản Lý"
        CType(Me.dataview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblma As System.Windows.Forms.Label
    Friend WithEvents lblten As System.Windows.Forms.Label
    Friend WithEvents lbldongia As System.Windows.Forms.Label
    Friend WithEvents lblsoluong As System.Windows.Forms.Label
    Friend WithEvents lblchitiet As System.Windows.Forms.Label
    Friend WithEvents lblloai As System.Windows.Forms.Label
    Friend WithEvents txtma As System.Windows.Forms.TextBox
    Friend WithEvents txtten As System.Windows.Forms.TextBox
    Friend WithEvents txtdongia As System.Windows.Forms.TextBox
    Friend WithEvents txtsoluong As System.Windows.Forms.TextBox
    Friend WithEvents txtchitiet As System.Windows.Forms.TextBox
    Friend WithEvents txtloai As System.Windows.Forms.TextBox
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnthoat As System.Windows.Forms.Button
    Friend WithEvents dataview As System.Windows.Forms.DataGridView
End Class
