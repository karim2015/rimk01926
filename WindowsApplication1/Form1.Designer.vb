<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdangnhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmdangnhap))
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.btndangnhap = New System.Windows.Forms.Button()
        Me.ptblogin = New System.Windows.Forms.PictureBox()
        CType(Me.ptblogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(71, 42)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(55, 13)
        Me.lblname.TabIndex = 0
        Me.lblname.Text = "Username"
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.Location = New System.Drawing.Point(71, 75)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(53, 13)
        Me.lblpass.TabIndex = 1
        Me.lblpass.Text = "Password"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(142, 35)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(119, 20)
        Me.txtname.TabIndex = 2
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(142, 68)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(119, 20)
        Me.txtpass.TabIndex = 3
        Me.txtpass.UseSystemPasswordChar = True
        '
        'btnthoat
        '
        Me.btnthoat.Location = New System.Drawing.Point(227, 115)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(75, 39)
        Me.btnthoat.TabIndex = 4
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'btndangnhap
        '
        Me.btndangnhap.Location = New System.Drawing.Point(63, 115)
        Me.btndangnhap.Name = "btndangnhap"
        Me.btndangnhap.Size = New System.Drawing.Size(75, 39)
        Me.btndangnhap.TabIndex = 5
        Me.btndangnhap.Text = "Đăng nhập"
        Me.btndangnhap.UseVisualStyleBackColor = True
        '
        'ptblogin
        '
        Me.ptblogin.BackColor = System.Drawing.Color.Aqua
        Me.ptblogin.Image = CType(resources.GetObject("ptblogin.Image"), System.Drawing.Image)
        Me.ptblogin.Location = New System.Drawing.Point(74, 160)
        Me.ptblogin.Name = "ptblogin"
        Me.ptblogin.Size = New System.Drawing.Size(221, 198)
        Me.ptblogin.TabIndex = 6
        Me.ptblogin.TabStop = False
        '
        'frmdangnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(375, 370)
        Me.Controls.Add(Me.ptblogin)
        Me.Controls.Add(Me.btndangnhap)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.lblpass)
        Me.Controls.Add(Me.lblname)
        Me.Name = "frmdangnhap"
        Me.Text = "Form1"
        CType(Me.ptblogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lblpass As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents btnthoat As System.Windows.Forms.Button
    Friend WithEvents btndangnhap As System.Windows.Forms.Button
    Friend WithEvents ptblogin As System.Windows.Forms.PictureBox

End Class
