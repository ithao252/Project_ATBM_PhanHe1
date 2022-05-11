-- INSERT DATA CHUYENKHOA
INSERT INTO CHUYENKHOA(MAKHOA,TENKHOA) VALUES ('CK0001', N'Sản phụ khoa');
INSERT INTO CHUYENKHOA(MAKHOA,TENKHOA) VALUES ('CK0002', N'Tim mạch');
INSERT INTO CHUYENKHOA(MAKHOA,TENKHOA) VALUES ('CK0003', N'Nhi');
INSERT INTO CHUYENKHOA(MAKHOA,TENKHOA) VALUES ('CK0004', N'Ung bướu - Xạ trị');
INSERT INTO CHUYENKHOA(MAKHOA,TENKHOA) VALUES ('CK0005', N'Sức khỏe tổng quát');
INSERT INTO CHUYENKHOA(MAKHOA,TENKHOA) VALUES ('CK0006', N'Tiêu hóa - Gan mật');
INSERT INTO CHUYENKHOA(MAKHOA,TENKHOA) VALUES ('CK0007', N'Cơ xương khớp');
INSERT INTO CHUYENKHOA(MAKHOA,TENKHOA) VALUES ('CK0008', N'Tế bào gốc');
INSERT INTO CHUYENKHOA(MAKHOA,TENKHOA) VALUES ('CK0009', N'Ngân hàng Mô');
INSERT INTO CHUYENKHOA(MAKHOA,TENKHOA) VALUES ('CK0010', N'Y Học Cổ Truyền');

-- INSERT DATA DICHVU
INSERT INTO DICHVU(MADV,TENDICHVU) VALUES ('DV0001', N'Thai sản trọn gói');
INSERT INTO DICHVU(MADV,TENDICHVU) VALUES ('DV0002', N'Gói sàng lọc giáp');
INSERT INTO DICHVU(MADV,TENDICHVU) VALUES ('DV0003', N'Máu cuống rốn');
INSERT INTO DICHVU(MADV,TENDICHVU) VALUES ('DV0004', N'Khám sức khỏe tổng quát');
INSERT INTO DICHVU(MADV,TENDICHVU) VALUES ('DV0005', N'Sàng lọc ung thư');
INSERT INTO DICHVU(MADV,TENDICHVU) VALUES ('DV0006', N'Bảo hiểm & Chương trình hội viên');
INSERT INTO DICHVU(MADV,TENDICHVU) VALUES ('DV0007', N'Sàng lọc gan mật');
INSERT INTO DICHVU(MADV,TENDICHVU) VALUES ('DV0008', N'Nha khoa');
INSERT INTO DICHVU(MADV,TENDICHVU) VALUES ('DV0009', N'Sàng lọc tim mạch');
INSERT INTO DICHVU(MADV,TENDICHVU) VALUES ('DV0010', N'Các gói dịch vụ khác');
INSERT INTO DICHVU(MADV,TENDICHVU) VALUES ('DV0011', N'Ưu đãi');

-- INSERT DATA CSYT
INSERT INTO CSYT (MACSYT, TENCSYT, DCCSYT, SDTCSYT) values ('CS0001', 'Bệnh viện Đa khoa Quốc tế Central Park', '208 Nguyễn Hữu Cảnh, Phường 22, Q.Bình Thạnh, Hồ Chí Minh', '1900232389');
INSERT INTO CSYT (MACSYT, TENCSYT, DCCSYT, SDTCSYT) values ('CS0002', 'Phòng khám Đa khoa Quốc tế Sài Gòn', '2 - 2 Bis Trần Cao Vân, P. Đa Kao, Q. 1, TP. Hồ Chí Minh', '1900232389');
INSERT INTO CSYT (MACSYT, TENCSYT, DCCSYT, SDTCSYT) values ('CS0003', 'Bệnh viện Đa khoa Quốc tế Times City', '458 Minh Khai, Q. Hai Bà Trưng, Hà Nội', '1900232389');
INSERT INTO CSYT (MACSYT, TENCSYT, DCCSYT, SDTCSYT) values ('CS0004', 'Phòng khám Quốc tế Royal City', 'Tầng 1, tòa R2, Khu Đô thị Royal City 72A Nguyễn Trãi, Q. Thanh Xuân, Hà Nội', '1900232389');
INSERT INTO CSYT (MACSYT, TENCSYT, DCCSYT, SDTCSYT) values ('CS0005', 'Phòng khám Đa khoa Quốc tế Times City', 'Số 458 Minh Khai, P. Vĩnh Tuy, Q. Hai Bà Trưng, Hà Nội', '1900232389');
INSERT INTO CSYT (MACSYT, TENCSYT, DCCSYT, SDTCSYT) values ('CS0006', 'Bệnh viện Đa khoa Quốc tế Đà Nẵng', 'Đường 30 Tháng 4, Khu dân cư số 4 Nguyễn Tri Phương, P. Hòa Cường Bắc, Q. Hải Châu, TP Đà Nẵng', '1900232389');
INSERT INTO CSYT (MACSYT, TENCSYT, DCCSYT, SDTCSYT) values ('CS0007', 'Bệnh viện Đa khoa Quốc tế Nha Trang', '42A Trần Phú, Vĩnh Nguyên, Nha Trang', '1900232389');
INSERT INTO CSYT (MACSYT, TENCSYT, DCCSYT, SDTCSYT) values ('CS0008', 'Bệnh viện Đa khoa Quốc tế Hải Phòng', 'Võ Nguyên Giáp, Q. Lê Chân, TP. Hải Phòng', '1900232389');
INSERT INTO CSYT (MACSYT, TENCSYT, DCCSYT, SDTCSYT) values ('CS0009', 'Bệnh viện Đa khoa Quốc tế Hạ Long', '10A Lê Thánh Tông, Hồng Gai, TP. Hạ Long', '1900232389');
INSERT INTO CSYT (MACSYT, TENCSYT, DCCSYT, SDTCSYT) values ('CS0010', 'Bệnh viện Đa khoa Quốc tế Phú Quốc', 'Khu Bãi Dài, X. Gành Dầu, Phú Quốc', '1900232389');
--select * from csyt;

-- INSERT DATA NHANVIEN
exec INSERTNHANVIEN ('NV0001', N'Hồ Quang Danh', N'Nam', '1970-07-07', '106143818423', N'Yên Bái', '', 'CS0001', N'Thanh tra', 'CK0001', '1234');
exec INSERTNHANVIEN ('NV0002', N'Biên Bình Ðạt', N'Nữ', NULL, '518255758747', N'Quảng Ninh', '', 'CS0002', N'Thanh tra', 'CK0005', '1234');
exec INSERTNHANVIEN ('NV0003', N'Phong Thái Dương', N'Nam', NULL, '799192604508', N'Tuyên Quang', '', 'CS0003', N'Thanh tra', 'CK0010', '1234');
exec INSERTNHANVIEN ('NV0004', N'Quán Anh Khôi', N'Nam', NULL, '496355483978', N'Kiên Giang', '', 'CS0004', N'Thanh tra', 'CK0002','1234');
exec INSERTNHANVIEN ('NV0005', N'Tông Phi Hai', N'Nam', NULL, '122646930083', N'Vĩnh Long', '', 'CS0005', N'Thanh tra', 'CK0003', '1234');

exec INSERTNHANVIEN ('NV0006', N'Thành Tân Phu', N'Nam', '1970-07-07', '106143818423', N'Yên Bái', '', 'CS0001', N'Cơ sở y tế', 'CK0001', '1234');
exec INSERTNHANVIEN ('NV0007', N'Ninh Vinh Quốc', N'Nữ', NULL, '518255758747', N'Quảng Ninh', '', 'CS0002', N'Cơ sở y tế', 'CK0005', '1234');
exec INSERTNHANVIEN ('NV0008', N'Bo Ðac Tu', N'Nam', NULL, '799192604508', N'Tuyên Quang', '', 'CS0003', N'Cơ sở y tế', 'CK0009', '1234');
exec INSERTNHANVIEN ('NV0009', N'Lộc Minh Thiên', N'Nam', NULL, '496355483978', N'Kiên Giang', '', 'CS0004', N'Cơ sở y tế', 'CK0008', '1234');
exec INSERTNHANVIEN ('NV0010', N'Lai Xuân Thiên', N'Nam', NULL, '122646930083', N'Vĩnh Long', '', 'CS0005', N'Cơ sở y tế', 'CK0006', '1234');
exec INSERTNHANVIEN ('NV0011', N'Chính Thuận', N'Nam', '1970-07-07', '106143818423', N'Yên Bái', '', 'CS0001', N'Cơ sở y tế', 'CK0003', '1234');
exec INSERTNHANVIEN ('NV0012', N'Đinh Vang Việt', N'Nữ', NULL, '518255758747', N'Quảng Ninh', '', 'CS0002', N'Cơ sở y tế', 'CK0010', '1234');
exec INSERTNHANVIEN ('NV0013', N'Đoàn Thiên Ân', N'Nam', NULL, '799192604508', N'Tuyên Quang', '', 'CS0003', N'Cơ sở y tế', 'CK0004', '1234');
exec INSERTNHANVIEN ('NV0014', N'Diêm Vân Anh', N'Nam', NULL, '496355483978', N'Kiên Giang', '', 'CS0004', N'Cơ sở y tế', 'CK0007', '1234');
exec INSERTNHANVIEN ('NV0015', N'Giàng Tân Bình', N'Nam', NULL, '122646930083', N'Vĩnh Long', '', 'CS0005', N'Cơ sở y tế', 'CK0002', '1234');
exec INSERTNHANVIEN ('NV0112', N'Le Van Binh', N'Nam', NULL, '133646931183', N'Vĩnh Phúc', '', 'CS0001', N'Cơ sở y tế', 'CK0002', '1234');

exec INSERTNHANVIEN ('NV0016', N'Huệ Hương', N'Nữ', NULL, '518255758747', N'Quảng Ninh', '', 'CS0002', N'Y sĩ/Bác sĩ', 'CK0001','1234');
exec INSERTNHANVIEN ('NV0017', N'Ninh Vinh Quốc', N'Nữ', NULL, '518255758747', N'Quảng Ninh', '', 'CS0002', N'Y sĩ/Bác sĩ', 'CK0002','1234');
exec INSERTNHANVIEN ('NV0018', N'Tán Khánh Mai', N'Nam', NULL, '799192604508', N'Tuyên Quang', '', 'CS0003', N'Y sĩ/Bác sĩ', 'CK0003', '1234');
exec INSERTNHANVIEN ('NV0019', N'Lôc Minh Thiên', N'Nam', NULL, '496355483978', N'Kiên Giang', '', 'CS0004', N'Y sĩ/Bác sĩ', 'CK0004','1234');
exec INSERTNHANVIEN ('NV0020', N'Lộc Minh', N'Nam', NULL, '496355483543', N'Kiên Giang', '', 'CS0004', N'Y sĩ/Bác sĩ', 'CK0005','1234');
exec INSERTNHANVIEN ('NV0021', N'Hàn Kim Thủy', N'Nam', NULL, '496355483543', 'Kiên Giang', '', 'CS0004', N'Y sĩ/Bác sĩ', 'CK0006','1234');
exec INSERTNHANVIEN ('NV0022', N'Lâm Oanh', N'Nữ', NULL, '518255758747', N'Quảng Ninh', '', 'CS0002', N'Y sĩ/Bác sĩ', 'CK0007', '1234');
exec INSERTNHANVIEN ('NV0023', N'Chung Lệ Chi', N'Nam', NULL, '799192604508', N'Tuyên Quang', '', 'CS0003', N'Y sĩ/Bác sĩ', 'CK0008', '1234');
exec INSERTNHANVIEN ('NV0024', N'Phù Linh Châu', N'Nam', NULL, '496355483978', N'Kiên Giang', '', 'CS0004', N'Y sĩ/Bác sĩ', 'CK0009', '1234');
exec INSERTNHANVIEN ('NV0025', N'Hùng Kièu Nương', N'Nam', NULL, '122646930083', N'Vĩnh Long', '', 'CS0005', N'Y sĩ/Bác sĩ', 'CK0010','1234');

exec INSERTNHANVIEN ('NV0026', N'Chung Quang Thành', N'Nữ', NULL, '716299399663', N'Đắk Nông', '', 'CS0001', N'Nghiên cứu', 'CK0005', '1234');
exec INSERTNHANVIEN ('NV0027', N'Giao Anh Việt', N'Nam', NULL, '728016968058', N'Trà Vinh', '',  'CS0003', N'Nghiên cứu', 'CK0003', '1234');
exec INSERTNHANVIEN ('NV0028', N'Trà Quốc Việt', N'Nữ', NULL, '818705368116', N'Hậu Giang', '', 'CS0004', N'Nghiên cứu', 'CK0006','1234');
exec INSERTNHANVIEN ('NV0029', N'Lộc Minh', N'Nam', NULL, '496355483543', N'Kiên Giang', '', 'CS0001', N'Nghiên cứu', 'CK0009','1234');
exec INSERTNHANVIEN ('NV0030', N'Hàn Kim Thủy', N'Nam', NULL, '496355483543', N'Kiên Giang', '', 'CS0005', N'Nghiên cứu', 'CK0010','1234');
--select * from dba_users;
--select * from nhanvien;

-- INSERT DATA BENHNHAN
EXEC INSERTBENHNHAN('BN0001','CS0002', N'Hằng Bích Thảo','592218019912', NULL, '', N'Phươnng Canh', N'Quận Nam Từ Liêm', N'Hà Nội', NULL, NULL, NULL, '1234');
EXEC INSERTBENHNHAN('BN0002','CS0003', N'Quang Thái','3655745235324', '1945-02-03', '', N'Phươnng Canh', N'Quận Nam Từ Liêm', N'Hà Nội', NULL, NULL, NULL, '1234B');
EXEC INSERTBENHNHAN('BN0003','CS0004', N'Khắc Việt','536437346436', '1955-06-30', '', N'Thông Tây Hội', N'Quận Hai Châu', N'Đà Nẵng', NULL, NULL, NULL, '1234');
EXEC INSERTBENHNHAN('BN0004','CS0005', N'Tiến Ðức','634257654325', '1960-05-25', '', N'Lê Thanh Nghi', N'Quận Hai Châu', N'Đà Nẵng', NULL, NULL, NULL, '1234');
EXEC INSERTBENHNHAN('BN0005','CS0001', N'Hà Thị Lan','563454765352', '1975-09-06', '', N'Điện Biên Phủ', N'Quận Thanh Khê', N'Đà Nẵng', NULL, NULL, NULL, '1234');
EXEC INSERTBENHNHAN('BN0006','CS0001', N'Chấn Hùng', '966396551955','1999-11-01', '', N'Trần Cao Vân', N'Quận Thanh Khê', N'Đà Nẵng', NULL, NULL, NULL, '1234');
EXEC INSERTBENHNHAN('BN0007','CS0001', N'Lê Thị Hằng','09314225w334', '1955-05-22', '', N'Bà Huyện Thanh Quan', N'Q.Bình Thạnh', N'TP.HCM', NULL, NULL, NULL, '1234');
--select * from benhnhan;
--exec deletebenhnhan('BN002');

--INSERT DATA HSBA
INSERT INTO HSBA (MAHSBA, MABN, NGAY, CHANDOAN, MABS, MAKHOA, MACSYT, KETLUAN) values ('HS0001', 'BN0001', TO_DATE('2020-01-01', 'YYYY-MM-DD'), N'Ghi điện cơ cấp cứu', 'NV0016', 'CK0001', 'CS0001', N'Chấn thương dây chằng chéo trước');
INSERT INTO HSBA (MAHSBA, MABN, NGAY, CHANDOAN, MABS, MAKHOA, MACSYT, KETLUAN) values ('HS0002', 'BN0003', TO_DATE('2020-01-02', 'YYYY-MM-DD'), N'Chụp cắt lớp vi tính động mạch vành', 'NV0017', 'CK0002', 'CS0002', N'Sa trực tràng');
INSERT INTO HSBA (MAHSBA, MABN, NGAY, CHANDOAN, MABS, MAKHOA, MACSYT, KETLUAN) values ('HS0003', 'BN0004', TO_DATE('2020-01-02', 'YYYY-MM-DD'), N'Soi buồng tử cung với dung dịch Sorbitol', 'NV0018', 'CK0003', 'CS0003', N'Rối loạn xuất tinh');
INSERT INTO HSBA (MAHSBA, MABN, NGAY, CHANDOAN, MABS, MAKHOA, MACSYT, KETLUAN) values ('HS0004', 'BN0006', TO_DATE('2020-01-02', 'YYYY-MM-DD'), N'Nhuộm hóa mô miễn dịch cho mỗi một dấu ấn', 'NV0019', 'CK0004', 'CS0004', N'Sa sinh dục');
INSERT INTO HSBA (MAHSBA, MABN, NGAY, CHANDOAN, MABS, MAKHOA, MACSYT, KETLUAN) values ('HS0005', 'BN0007', TO_DATE('2020-01-02', 'YYYY-MM-DD'), N'Chọc dò tủy sống', 'NV0020', 'CK0005', 'CS0005', N'Đau nửa đầu');

--INSERT DATA HSBA_DV
INSERT INTO HSBA_DV (MAHSBA, MADV, NGAY, MAKTV, KETQUA) values ('HS0001', 'DV0001', TO_DATE('2020-01-01', 'YYYY-MM-DD'), 'NV0016', N'Chấn thương dây chằng chéo trước');
INSERT INTO HSBA_DV (MAHSBA, MADV, NGAY, MAKTV, KETQUA) values ('HS0002', 'DV0002', TO_DATE('2020-01-08', 'YYYY-MM-DD'), 'NV0017', N'Sa trực tràng');
INSERT INTO HSBA_DV (MAHSBA, MADV, NGAY, MAKTV, KETQUA) values ('HS0003', 'DV0003', TO_DATE('2020-01-07', 'YYYY-MM-DD'), 'NV0018', N'Rối loạn xuất tinh');
INSERT INTO HSBA_DV (MAHSBA, MADV, NGAY, MAKTV, KETQUA) values ('HS0004', 'DV0004', TO_DATE('2020-01-02', 'YYYY-MM-DD'), 'NV0019', N'Sa sinh dục');
INSERT INTO HSBA_DV (MAHSBA, MADV, NGAY, MAKTV, KETQUA) values ('HS0005', 'DV0005', TO_DATE('2020-01-10', 'YYYY-MM-DD'), 'NV0020', N'Đau nửa đầu');
INSERT INTO HSBA_DV (MAHSBA, MADV, NGAY, MAKTV, KETQUA) values ('HS0005', 'DV0004', TO_DATE('2020-01-03', 'YYYY-MM-DD'), 'NV0112', N'Đau đầu');
