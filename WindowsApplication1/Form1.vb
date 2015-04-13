Imports System.Data.SqlClient
Public Class frmdangnhap

    Private Sub frmdangnhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btndangnhap_Click(sender As Object, e As EventArgs) Handles btndangnhap.Click
        Dim chuoiketnoi As String = "workstation id=rim123456.mssql.somee.com;packet size=4096;user id=karim2015;pwd=Aa9971441;data source=rim123456.mssql.somee.com;persist security info=False;initial catalog=rim123456"

        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from Nhanvien where tendangnhap='" & txtname.Text & "' and matkhau='" & txtpass.Text & "' ", KetNoi)
        Dim tb As New DataTable

        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Đăng nhập thành công ^^!")
                frmmain.Show()
                Me.Hide()
            Else
                MessageBox.Show("Wrong: Username or password")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        If MessageBox.Show("Bạn có muốn thoát không", "Thoát", MessageBoxButtons.YesNo) Then
            Me.Close()

        End If

    End Sub

    Private Sub txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged

    End Sub

    Private Sub txtname_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged

    End Sub

    Private Sub ptblogin_Click(sender As Object, e As EventArgs) Handles ptblogin.Click

    End Sub
End Class
