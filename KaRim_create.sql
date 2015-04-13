-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2015-04-13 02:29:49.057




-- tables
-- Table: Chitiethoadon
CREATE TABLE Chitiethoadon (
    soluong int  NOT NULL,
    loaihoadon nvarchar(30)  NOT NULL,
    HoaDon_MaHD nvarchar(30)  NOT NULL,
    Sanpham_MaSP nvarchar(30)  NOT NULL,
    CONSTRAINT Chitiethoadon_pk PRIMARY KEY (soluong)
)
;





-- Table: HoaDon
CREATE TABLE HoaDon (
    MaHD nvarchar(30)  NOT NULL,
    Tongtien money  NOT NULL,
    Ngaylap date  NOT NULL,
    KH_MaKH nvarchar(30)  NOT NULL,
    KhachHang_MaKH nvarchar(30)  NOT NULL,
    Nhanvien_tennhanvien nvarchar(50)  NOT NULL,
    CONSTRAINT HoaDon_pk PRIMARY KEY (MaHD)
)
;





-- Table: KhachHang
CREATE TABLE KhachHang (
    MaKH nvarchar(30)  NOT NULL,
    TenKH nvarchar(50)  NOT NULL,
    Diachi nvarchar(50)  NOT NULL,
    SDT text  NOT NULL,
    Mail nvarchar(30)  NOT NULL,
    Gioitinh nvarchar(30)  NOT NULL,
    CONSTRAINT KhachHang_pk PRIMARY KEY (MaKH)
)
;





-- Table: LoaiSP
CREATE TABLE LoaiSP (
    MaSP nvarchar(30)  NOT NULL,
    Tenloai nvarchar(50)  NOT NULL,
    xuatxu nvarchar(30)  NOT NULL,
    CONSTRAINT LoaiSP_pk PRIMARY KEY (MaSP)
)
;





-- Table: Nhanvien
CREATE TABLE Nhanvien (
    tennhanvien nvarchar(50)  NOT NULL,
    tendangnhap nvarchar(50)  NOT NULL,
    matkhau nvarchar(50)  NOT NULL,
    CONSTRAINT Nhanvien_pk PRIMARY KEY (tennhanvien)
)
;





-- Table: Sanpham
CREATE TABLE Sanpham (
    MaSP nvarchar(30)  NOT NULL,
    TenSP nvarchar(50)  NOT NULL,
    Dongia nvarchar(50)  NOT NULL,
    Soluong int  NOT NULL,
    chitietsp nvarchar(50)  NOT NULL,
    LoaiSP_Maloai nvarchar(30)  NOT NULL,
    CONSTRAINT Sanpham_pk PRIMARY KEY (MaSP)
)
;









-- foreign keys
-- Reference:  Chitiethoadon_HoaDon (table: Chitiethoadon)


ALTER TABLE Chitiethoadon ADD CONSTRAINT Chitiethoadon_HoaDon 
    FOREIGN KEY (HoaDon_MaHD)
    REFERENCES HoaDon (MaHD)
;

-- Reference:  Chitiethoadon_Sanpham (table: Chitiethoadon)


ALTER TABLE Chitiethoadon ADD CONSTRAINT Chitiethoadon_Sanpham 
    FOREIGN KEY (Sanpham_MaSP)
    REFERENCES Sanpham (MaSP)
;

-- Reference:  HoaDon_KhachHang (table: HoaDon)


ALTER TABLE HoaDon ADD CONSTRAINT HoaDon_KhachHang 
    FOREIGN KEY (KhachHang_MaKH)
    REFERENCES KhachHang (MaKH)
;

-- Reference:  HoaDon_Nhanvien (table: HoaDon)


ALTER TABLE HoaDon ADD CONSTRAINT HoaDon_Nhanvien 
    FOREIGN KEY (Nhanvien_tennhanvien)
    REFERENCES Nhanvien (tennhanvien)
;

-- Reference:  Sanpham_LoaiSP (table: Sanpham)


ALTER TABLE Sanpham ADD CONSTRAINT Sanpham_LoaiSP 
    FOREIGN KEY (LoaiSP_Maloai)
    REFERENCES LoaiSP (MaSP)
;





-- End of file.

