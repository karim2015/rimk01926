Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmquanly
    'Private WithEvents reset As BindingManagerBase
    Dim tb As New DataTable
    Dim connect As String = "workstation id=rim123456.mssql.somee.com;packet size=4096;user id=karim2015;pwd=Aa9971441;data source=rim123456.mssql.somee.com;persist security info=False;initial catalog=rim123456"
    Private Sub frmQuanlysanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'tạo đối tượng kết nối tới Data Trên Somee.com thông qua chuỗi kết nối connectstr
        Dim KetNoi As New SqlConnection(connect)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select MaSP as 'Mã sản phẩm', TenSP as 'Tên sản phẩm', Dongia as 'Đơn giá', Soluong as 'Số lượng', chitietSP as 'Chi tiết sản phẩm', LoaiSP_Maloai as 'Loại sản phẩm' from SanPham", KetNoi)
        Try
            KetNoi.Open()
            'Đổ dữ liệu trên Table vào Datatable trên máy
            sqlAdapter.Fill(tb)
        Catch ex As Exception
        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        DataView.DataSource = tb
        KetNoi.Close()
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim ketnoi As New SqlConnection(connect)
        Dim stradd As String = "insert into Sanpham (MaSP,TenSP,Dongia,Soluong,chitietsp,LoaiSP_Maloai) values('" & txtma.Text & "','" & txtten.Text & "' ,'" & txtdongia.Text & "','" & txtsoluong.Text & "','" & txtchitiet.Text & "','" & txtloai.Text & "')"

        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            ketnoi.Open()
            com.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Thêm sản phẩm thành công")
        Catch ex As Exception
            MessageBox.Show("Lỗi!")
        End Try
        tb.Clear()
        DataView.DataSource = tb
        DataView.DataSource = Nothing
        xuat_lai_sql()


    End Sub
    Private Sub xuat_lai_sql()

        Dim KetNoi As New SqlConnection(connect)
        Dim sqlAdapter As New SqlDataAdapter("select MaSP as 'Mã sản phẩm', TenSP as 'Tên sản phẩm', Dongia as 'Đơn giá', Soluong as 'Số lượng', chitietsp as 'Chi tiết sản phẩm',LoaiSP_Maloai as 'Loại sản phẩm' from SanPham", KetNoi)

        Try
            sqlAdapter.Fill(tb)
        Catch ex As Exception

        End Try
        DataView.DataSource = tb
        KetNoi.Close()
    End Sub


    Private Sub DataView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataview.CellContentClick

        Dim dr As DataRow = tb.NewRow
        Dim index As Integer = DataView.CurrentCell.RowIndex
        txtma.Text = dataview.Item(0, index).Value
        txtten.Text = dataview.Item(1, index).Value
        txtDongia.Text = DataView.Item(2, index).Value
        txtSoluong.Text = DataView.Item(3, index).Value
        txtchitiet.Text = dataview.Item(4, index).Value
        txtLoai.Text = DataView.Item(5, index).Value
    End Sub


    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        End
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim ketnoi As New SqlConnection(connect)
        ketnoi.Open()
        Dim stradd As String = "Delete from  Sanpham where MaSP = @MaSP"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaSP", txtma.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Xóa dữ liệu thành công")
        Catch ex As Exception
            MessageBox.Show("Lỗi!")
        End Try
        tb.Clear()
        DataView.DataSource = tb
        DataView.DataSource = Nothing
        xuat_lai_sql()

    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim ketnoi As New SqlConnection(connect)
        ketnoi.Open()
        Dim stradd As String = "UPDATE Sanpham SET TenSP = @TenSP,  Dongia = @Dongia, Soluong = @Soluong, chitiesp = @chitietsp, LoaiSP_Maloai = @LoaiSP_Maloai where MaSP = @MaSP"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaSP", txtma.Text)
            com.Parameters.AddWithValue("@TenSP", txtten.Text)
            com.Parameters.AddWithValue("@LoaiSP_Maloai", txtloai.Text)
            com.Parameters.AddWithValue("@Dongia", txtDongia.Text)
            com.Parameters.AddWithValue("@Soluong", txtSoluong.Text)
            com.Parameters.AddWithValue("@ChitietSP", txtchitiet.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Sửa thành công")

        Catch ex As Exception
            MessageBox.Show("Lỗi! Nhập sai kiểu kí tự.")
        End Try
        tb.Clear()
        DataView.DataSource = tb
        DataView.DataSource = Nothing
        xuat_lai_sql()

    End Sub
End Class