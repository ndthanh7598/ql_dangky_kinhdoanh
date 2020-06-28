--=============================================================================================================================
									--THIẾT KẾ VẬT LÝ - TẠO CƠ SỞ DỮ LIỆU --


/*________========TẠO DATABASE========________*/

CREATE DATABASE ql_dangky_kinhdoanh;

USE ql_dangky_kinhdoanh;

/*________========TẠO BẢNG========________*/

CREATE TABLE tbl_hosodangky(
	iMaHoSo INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	sSoHoSo NVARCHAR(50) NOT NULL,
	sTenCongTy NVARCHAR(100),
	sDiaChi NVARCHAR(255),
	sNguoiLienHe NVARCHAR(50),
	sSDTLienHe NVARCHAR(11),
	sEmail NVARCHAR(255),
	sNgaylap NVARCHAR(10),
	sTrangThai NVARCHAR(255),
	FK_iLoaiHinh INT,
	FK_iMaCB INT NOT NULL
);

CREATE TABLE dm_loaihinh(
	iMaLH INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	sTenLH NVARCHAR(255),
	sVietTat NVARCHAR(50)
);

CREATE TABLE dm_quyen(
	iMaQuyen INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	sTenQuyen NVARCHAR(255)
);

CREATE TABLE tbl_canbo(
	iMaCanBo INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	sTenCB NVARCHAR(255),
	sNgaySinh NVARCHAR(10),
	sGioiTinh NVARCHAR(3),
	sCMT NVARCHAR(12),
	sEmail NVARCHAR(255),
	sSDT NVARCHAR(11)
);

CREATE TABLE tbl_dangnhap(
	sTenDangNhap NVARCHAR(255) NOT NULL PRIMARY KEY,
	sMatKhau NVARCHAR(255) NOT NULL,
	FK_iMaQuyen INT NOT NULL,
	FK_iMaCB INT NOT NULL,
	sTrangthai NVARCHAR(255)
);

CREATE TABLE session(
	PK_iMa INT NOT NULL PRIMARY KEY,
	sTenDangNhap NVARCHAR(255),
	FK_iMaQuyen INT NOT NULL,
	FK_iMaCB INT NOT NULL
);

--ALTER TABLE tbl_hosodangky ADD sNgaylap DATE;

ALTER TABLE tbl_dangnhap ADD CONSTRAINT FK_quyen FOREIGN KEY (FK_iMaQuyen) REFERENCES dm_quyen(iMaQuyen);

ALTER TABLE tbl_dangnhap ADD CONSTRAINT FK_canbo FOREIGN KEY (FK_iMaCB) REFERENCES tbl_canbo(iMaCanBo);

ALTER TABLE tbl_hosodangky ADD CONSTRAINT FK_loaihinhdoanhnghiep FOREIGN KEY (FK_iLoaiHinh) REFERENCES dm_loaihinh(iMaLH);

ALTER TABLE tbl_hosodangky ADD CONSTRAINT FK_canbolaphoso FOREIGN KEY (FK_iMaCB) REFERENCES tbl_canbo(iMaCanBo);

/*________================NHẬP DỮ LIỆU================________*/


-- THÊM QUYỀN
INSERT INTO dm_quyen VALUES (N'Quản lý'),
							(N'Nhân viên');

-- THÊM CÁN BỘ
INSERT INTO tbl_canbo VALUES (N'Nguyễn Duy Thành',N'07/05/1998',N'Nam',N'012345678',N'ndthanh.7598@gmail.com',N'0961787598'),
							 (N'Tuyên Đỗ',N'22/10/1998',N'Nữ',N'122291639',N'dotuyen221098@gmail.com',N'0353924400');

-- THÊM TÀI KHOẢN
INSERT INTO tbl_dangnhap VALUES (N'tuyendo',N'123',2,2,N'bình thường'),
								(N'duythanh',N'456',1,1,N'bình thường');

-- THÊM LOẠI HÌNH
INSERT INTO dm_loaihinh VALUES (N'Doanh nghiệp tư nhân',N'DNTN'),
							   (N'Công ty cổ phần',N'CTCP'),
							   (N'Công ty trách nhiệm hữu hạn',N'CTTNHH');

-- THÊM HỒ SƠ ĐĂNG KÝ KINH DOANH
INSERT INTO tbl_hosodangky VALUES (N'HS01',N'SAMSUNG',N'Bắc Ninh',N'Linh Nguyễn',N'0343641916',N'linhnguyen@gmail.com',N'22/10/2018',N'chờ duyệt',1,2),
								  (N'HS02',N'ĐIỆN TỬ',N'Vĩnh Phúc',N'Minh Anh',N'0353974366',N'minhanh@gmail.com',N'10/10/2018',N'chờ duyệt',3,2);

INSERT INTO tbl_hosodangky VALUES (N'HS03',N'CT MAY',N'Hà Nội',N'Nam Nguyễn',N'0397086390',N'nam@gmail.com',N'05/09/2018',N'đã duyệt',2,2);
INSERT INTO tbl_hosodangky VALUES (N'HS05',N'CT MÁY LẠNH',N'Bắc Ninh',N'Minh Duy',N'0353999666',N'minhduy@gmail.com',N'11/11/2017',N'đã duyệt',2,4);
INSERT INTO tbl_hosodangky VALUES (N'HS05',N'TNHH Việt An',N'TP.HCM',N'Nguyễn Khánh',N'0978777321',N'khanh@gmail.com',N'02/12/2017',N'đã duyệt',2,3);




/*________================TẠO PROCEDURE================________*/

--Tạo thủ tục kiểm tra check đăng nhập
CREATE PROC sp_check_dangnhap
	@sTaikhoan NVARCHAR(50),
	@sMatKhau NVARCHAR(50)
AS
	BEGIN
		SELECT * FROM tbl_dangnhap WHERE sTenDangNhap LIKE @sTaikhoan AND sMatKhau = @sMatKhau AND sTrangthai != N'khoá'
	END
GO 
	EXECUTE sp_check_dangnhap N'tuyendo',N'123';

-- Tạo thủ tục lưu session
CREATE PROC sp_session
	@sTenDangNhap NVARCHAR(50),
	@FK_iMaQuyen INT,
	@FK_iMaCB INT
AS
	BEGIN
		DELETE FROM session WHERE 1=1;
		INSERT INTO session VALUES(1,@sTenDangNhap,@FK_iMaQuyen,@FK_iMaCB);
	END

--Tạo thủ tục lấy session
CREATE PROC get_session
AS
	BEGIN
		SELECT * FROM session WHERE PK_iMa = 1;
	END

-- Tạo thủ tục lấy ra danh sách loại hình
CREATE PROC sp_get_loaihinh
AS
	BEGIN
		SELECT * FROM dm_loaihinh
	END

--Tạo thủ tục cho bảng hồ sơ đăng ký
ALTER PROC sp_hosodangky
	@iMaHS INT = null,
	@sSoHS NVARCHAR(50) = NULL,
	@sTenCongTy NVARCHAR(100) = NULL,
	@sDiaChi NVARCHAR(100) = NULL,
	@sNguoiLienHe NVARCHAR(50) = NULL,
	@sSDTLienHe NVARCHAR(10) = NULL,
	@sEmail NVARCHAR(100) = NULL,
	@iLoaiHinh INT = NULL,
	@iMaCB INT = NULL,
	@iQuyen INT = NULL,
	@Action NVARCHAR(50) = NULL
AS
	BEGIN
		IF(@Action = N'SELECT' AND @iQuyen = 1)
			BEGIN
				SELECT tbl_hosodangky.*,dm_loaihinh.sTenLH FROM tbl_hosodangky 
				INNER JOIN dm_loaihinh ON dm_loaihinh.iMaLH = tbl_hosodangky.FK_iLoaiHinh
				ORDER BY sTrangThai ASC
			END
		ELSE
			BEGIN
				SELECT tbl_hosodangky.*,dm_loaihinh.sTenLH FROM tbl_hosodangky 
				INNER JOIN dm_loaihinh ON dm_loaihinh.iMaLH = tbl_hosodangky.FK_iLoaiHinh
				WHERE tbl_hosodangky.sTrangThai = N'chờ duyệt'
			END
		IF(@Action = N'INSERT')
			BEGIN
				INSERT INTO tbl_hosodangky VALUES(@sSoHS,@sTenCongTy,@sDiaChi,@sNguoiLienHe,@sSDTLienHe,@sEmail,CONVERT(NVARCHAR(10),GETDATE(),103),N'chờ duyệt',@iLoaiHinh,@iMaCB);
			END
		IF(@Action = N'DELETE')
			BEGIN
				DELETE FROM tbl_hosodangky WHERE sSoHoSo = @sSoHS
			END
		IF(@Action = N'UPDATE')
			BEGIN
				UPDATE tbl_hosodangky 
				SET sTenCongTy = @sTenCongTy,sDiaChi = @sDiaChi, sNguoiLienHe = @sNguoiLienHe,sSDTLienHe = @sSDTLienHe,sEmail = @sEmail, FK_iLoaiHinh = @iLoaiHinh,FK_iMaCB = @iMaCB
				WHERE sSoHoSo = @sSoHS AND sTrangThai = N'chờ duyệt';
			END
	END


--select convert(varchar(10),getdate(),103) FROM tbl_hosodangky
-- Tạo thủ tục insert/update thông tin cán bộ
CREATE PROC sp_canbo
	@iMaCanBo INT = null,
	@sTenCB NVARCHAR(255) = NULL,
	@sNgaySinh NVARCHAR(10) = NULL,
	@sGioiTinh NVARCHAR(3) = NULL,
	@sCMT NVARCHAR(12) = NULL,
	@sEmail NVARCHAR(255) = NULL,
	@sSDT NVARCHAR(11) = NULL,
	@Action NVARCHAR(50) = NULL
AS
	BEGIN
		IF(@Action = N'SELECT')
			BEGIN
				SELECT * FROM tbl_canbo WHERE iMaCanBo = @iMaCanBo
			END
		IF(@Action = N'INSERT')
			BEGIN
				INSERT INTO tbl_canbo VALUES(@sTenCB,@sNgaySinh,@sGioiTinh,@sCMT,@sEmail,@sSDT);
			END
		IF(@Action = N'DELETE')
			BEGIN
				DELETE FROM tbl_canbo WHERE iMaCanBo = @iMaCanBo
			END
		IF(@Action = N'UPDATE')
			BEGIN
				UPDATE tbl_canbo 
				SET sTenCB = @sTenCB,sNgaySinh = @sNgaySinh, sGioiTinh = @sGioiTinh,sCMT = @sCMT,sEmail = @sEmail, sSDT = @sSDT
				WHERE iMaCanBo = @iMaCanBo;
			END
	END

-- Tạo thủ tục lấy ra mã hồ sơ cao nhất
CREATE PROC sp_get_maxSoHS
AS
	BEGIN
		SELECT MAX(iMaHoSo) AS iMaHS_Max
		FROM tbl_hosodangky
	END
GO
	EXECUTE sp_get_maxSoHS

-- Tạo thủ tục update mật khẩu
CREATE PROC update_password
	@sTaikhoan NVARCHAR(50),
	@sMatKhau NVARCHAR(50)
AS
	BEGIN
		UPDATE tbl_dangnhap SET sMatKhau = @sMatKhau WHERE sTenDangNhap LIKE @sTaikhoan
	END

-- Update trạng thái hồ sơ
CREATE PROC sp_update_trangthai
	@sSoHS NVARCHAR(50) = NULL,
	@sTrangthai NVARCHAR(50) = NULL
AS
	BEGIN
		UPDATE tbl_hosodangky 
		SET sTrangThai = @sTrangthai
		WHERE sSoHoSo = @sSoHS
	END
GO
	EXECUTE sp_update_trangthai 2,N'HS02'

--Tạo thủ tục lấy ra nhân viên
CREATE PROC sp_get_nhanvien
	@iMaCanBo INT = null,
	@sTenCB NVARCHAR(255) = NULL,
	@sNgaySinh NVARCHAR(10) = NULL,
	@sGioiTinh NVARCHAR(3) = NULL,
	@sCMT NVARCHAR(12) = NULL,
	@sEmail NVARCHAR(255) = NULL,
	@sSDT NVARCHAR(11) = NULL,
	@Action NVARCHAR(50) = NULL
AS
	BEGIN
		SELECT tbl_canbo.*,tbl_dangnhap.sTrangthai FROM tbl_canbo 
		INNER JOIN tbl_dangnhap ON tbl_dangnhap.FK_iMaCB = tbl_canbo.iMaCanBo
		WHERE FK_iMaQuyen = 2
		ORDER BY iMaCanBo ASC
	END

-- Tạo thủ tục lấy ra mã nhân viên cao nhất
CREATE PROC sp_get_maNhanVienMax
AS
	BEGIN
		SELECT MAX(iMaCanBo) AS iMaCB_Max
		FROM tbl_canbo
	END
GO
	EXECUTE sp_get_maNhanVienMax

--Tạo thủ tục insert tài khoản với quyền nhân viên
CREATE PROC sp_insert_taikhoan
	@sTaikhoan NVARCHAR(50),
	@sMatKhau NVARCHAR(50),
	@iMaCB INT = NULL
AS
	BEGIN
		INSERT INTO tbl_dangnhap VALUES(@sTaikhoan,@sMatKhau,2,@iMaCB,N'bình thường');
	END
	
--Tạo thủ tục lấy ra tên đăng nhập theo mã nhân viên
CREATE PROC sp_get_tenDangNhapTheoMa
	@FK_iMaCB INT = null
AS
	BEGIN
		SELECT sTenDangNhap FROM tbl_dangnhap
		WHERE FK_iMaCB = @FK_iMaCB
	END

--Tạo thủ lấy ra mã nhân viên theo tên đăng nhập
CREATE PROC sp_get_maNhanVienTheoTen
	@sTenDangNhap NVARCHAR(50) = null
AS
	BEGIN
		SELECT FK_iMaCB FROM tbl_dangnhap
		WHERE sTenDangNhap = @sTenDangNhap
	END

--Tạo thủ tục update pass theo tên đăng nhập
CREATE PROC sp_update_passTheoTenDN
	@sTenDangNhap NVARCHAR(50) = null,
	@sMatKhau NVARCHAR(50) = NULL
AS
	BEGIN
		UPDATE tbl_dangnhap 
		SET sMatKhau = @sMatKhau
		WHERE sTenDangNhap = @sTenDangNhap
	END

--Tạo thủ tục update nhân viên
CREATE PROC sp_update_nhanvien
	@iMaCanBo INT = null,
	@sTenCB NVARCHAR(255) = NULL,
	@sNgaySinh NVARCHAR(10) = NULL,
	@sGioiTinh NVARCHAR(3) = NULL,
	@sCMT NVARCHAR(12) = NULL,
	@sEmail NVARCHAR(255) = NULL,
	@sSDT NVARCHAR(11) = NULL
AS
	BEGIN
		UPDATE tbl_canbo 
		SET sTenCB = @sTenCB,sNgaySinh = @sNgaySinh, sGioiTinh = @sGioiTinh,sCMT = @sCMT,sEmail = @sEmail, sSDT = @sSDT
		WHERE iMaCanBo = @iMaCanBo;
	END
GO
	EXECUTE sp_update_nhanvien 3,N'Thân Tuyết Minh',N'12/02/1998',N'Nữ',N'122291543',N'minh@gmail.com',N'0353621122'

-- Tạo thủ tục thay đổi trạng thái tài khoản
CREATE PROC sp_change_status
	@iMaCanBo INT = NULL,
	@sTrangthai NVARCHAR(50) = NULL
AS
	BEGIN
		UPDATE tbl_dangnhap 
		SET sTrangThai = @sTrangthai
		WHERE FK_iMaCB = @iMaCanBo
	END

-- Tạo thủ tục tra cứu hồ sơ theo tên công ty hoặc theo số hồ sơ
CREATE PROC sp_tracuuhoso
	@sSoHoSo NVARCHAR(50) = NULL,
	@sTenCongTy NVARCHAR(100) = NULL
AS
	BEGIN
		SELECT tbl_hosodangky.* FROM tbl_hosodangky 
		WHERE sSoHoSo = @sSoHoSo OR sTenCongTy LIKE '%'+@sTenCongTy+'%'
	END

--Tạo thủ tục in ra những hồ sơ đã được duyệt
CREATE PROC sp_get_hosodaduyet
AS
	BEGIN
		SELECT tbl_hosodangky.*, sTenCB
		FROM tbl_hosodangky
		INNER JOIN tbl_canbo ON tbl_canbo.iMaCanBo = tbl_hosodangky.FK_iMaCB
		WHERE sTrangThai = N'đã duyệt'
	END

-- Tạo thủ tục in ra những nhân viên đã nghỉ hưu
CREATE PROC sp_get_nhanviennghihuu
AS
	BEGIN
		SELECT tbl_canbo.*, tbl_dangnhap.sTrangthai 
		FROM tbl_canbo
		INNER JOIN tbl_dangnhap ON tbl_dangnhap.FK_iMaCB = tbl_canbo.iMaCanBo
		WHERE sTrangthai = N'khoá';
	END

-- Tạo thủ tục lấy ra những hồ sơ được lập theo điều kiện
ALTER PROC sp_get_hosotheothang
	@Day NVARCHAR(10) = '',
	@Thang NVARCHAR(10) = '',
	@Year NVARCHAR(10) = ''
AS
	BEGIN
		DECLARE @date NVARCHAR(10)
		IF (@Day = '')
			BEGIN
				SET @date = CONCAT('%', @Thang, '/', @Year);
			END
		IF (@Day = '' AND @Thang = '')
			BEGIN
				SET @date = CONCAT('%', @Year);
			END
		IF (@Day != '' AND @Thang != '' AND @Year != '')
			BEGIN
				SET @date = CONCAT(@Day, '/', @Thang, '/', @Year);
			END
		SELECT * 
		FROM tbl_hosodangky
		WHERE sNgaylap LIKE @date;
	END

/*ALTER PROC sp_get_hosotheothang
	@Day NVARCHAR(10) = NULL,
	@Thang NVARCHAR(10) = NULL,
	@Year NVARCHAR(10) = NULL
AS
	BEGIN
		SELECT * FROM tbl_hosodangky WHERE (DAY(sNgaylap) = @Day AND MONTH(sNgaylap) = @Thang AND YEAR(sNgaylap) = @Year)
									OR (DAY(sNgaylap) = @Day AND MONTH(sNgaylap) = @Thang)
									OR (DAY(sNgaylap) = @Day AND YEAR(sNgaylap) = @Year)
									OR (MONTH(sNgaylap) = @Thang AND YEAR(sNgaylap) = @Year)
									OR (DAY(sNgaylap) = @Day)
									OR (MONTH(sNgaylap) = @Thang)
									OR (YEAR(sNgaylap) = @Year);
	END

*/
CREATE PROC sp_get_hosotheodieukien
	@Day NVARCHAR(10) = '',
	@Thang NVARCHAR(10) = '',
	@Year NVARCHAR(10) = ''
AS
	BEGIN
		DECLARE @date NVARCHAR(10)
		IF (@Day = '')
			BEGIN
				SET @date = CONCAT('%', @Thang, '/', @Year);
			END
		IF (@Day = '' AND @Thang = '')
			BEGIN
				SET @date = CONCAT('%', @Year);
			END
		IF (@Day != '' AND @Thang != '' AND @Year != '')
			BEGIN
				SET @date = CONCAT(@Day, '/', @Thang, '/', @Year);
			END
		SELECT * 
		FROM tbl_hosodangky
		WHERE sNgaylap LIKE @date;
	END

-- Lấy ra những hồ sơ chưa được duyệt trong tháng 10
SELECT * FROM tbl_hosodangky WHERE sTrangThai = N'chờ duyệt' AND MONTH(sNgaylap) = 10;

DBCC CHECKIDENT (tbl_hosodangky, RESEED, 5);