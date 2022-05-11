insert into CSYT (MACSYT, TENCSYT, DCCSYT, SDTCSYT) values ('CS001', 'Phòng Y tế Quận Bình Tân ', '521 Kinh Dương Vương Phường An Lạc Quận Bình Tân', '22451045');
insert into CSYT (MACSYT, TENCSYT, DCCSYT, SDTCSYT) values ('CS002', 'B?nh viện Nhi Đồng Thành phố', ' Xã Tân Kiên Huyện Bình Chánh', '22536688');
insert into CSYT (MACSYT, TENCSYT, DCCSYT, SDTCSYT) values ('CS003', 'Phòng Y tế Quận 8', 'số 4 Phạm Thế Hiển Phường 5 Quận 8', '34314341');
insert into CSYT (MACSYT, TENCSYT, DCCSYT, SDTCSYT) values ('CS004', 'B?nh viện Quận Bình Thạnh', '112AB Đinh Tiên Hoàng Phường 1 Quận Bình Thạnh', '35108966');
insert into CSYT (MACSYT, TENCSYT, DCCSYT, SDTCSYT) values ('CS005', 'Trạm Y tế Phường 15', '22/1 ?i?n Biên Phủ Phường 15 Quận Bình Thạnh', '35122143');
select * from csyt;
--test
select * from dba_users;
select * from nhanvien;
exec INSERTNHANVIEN ('NV001', N'Hồ Quang Danh ', 'Nam', '1970-07-07', '106143818423', 'Yên Bái ', '654113305', 'CS001', N'Thanh tra', NULL,'1234');
exec INSERTNHANVIEN ('NV002', N'Biên Bình Ðạt ', 'Nữ', NULL, '518255758747', 'Quảng Ninh ', '897378822', 'CS002', N'Thanh tra', NULL,'1234');
exec INSERTNHANVIEN ('NV003', N'Phong Thái Dương ', 'Nam', NULL, '799192604508', 'Tuyên Quang ', '295910497', 'CS003', N'Thanh tra', NULL, '1234');
exec INSERTNHANVIEN ('NV004', N'Quán Anh Khôi ', 'Nam', NULL, '496355483978', 'Kiên Giang ', '713057827', 'CS004', N'Thanh tra', NULL,'1234');
exec INSERTNHANVIEN ('NV005', N'Tông Phi Hai ', 'Nam', NULL, '122646930083', 'Vĩnh Long ', '207161212', 'CS005', N'Thanh tra', NULL,'1234');
exec INSERTNHANVIEN ('NV006', N'Thành Tân Phu ', 'Nam', '1970-07-07', '106143818423', 'Yên Bái ', '654113305', 'CS001', N'Cơ sở y tế', NULL,'1234');
exec INSERTNHANVIEN ('NV007',N'Ninh Vinh Quoc ', 'N?', NULL, '518255758747', 'Quảng Ninh ', '897378822', 'CS002', N'Cơ sở y tế', NULL,'1234');
exec INSERTNHANVIEN ('NV008', 'Bo Ðac Tu ', 'Nam', NULL, '799192604508', 'Tuyên Quang ', '295910497', 'CS003', N'Cơ sở y tế', NULL, '1234');
exec INSERTNHANVIEN ('NV009', 'Lộc Minh Thiên ', 'Nam', NULL, '496355483978', 'Kiên Giang ', '713057827', 'CS004', N'Cơ sở y tế', NULL,'1234');
exec INSERTNHANVIEN ('NV010', 'Lai Xuân Thien ', 'Nam', NULL, '122646930083', 'Vĩnh Long ', '207161212', 'CS005', N'Cơ sở y tế', NULL,'1234');
exec INSERTNHANVIEN ('NV011', 'Chính Thuận ', 'Nam', '1970-07-07', '106143818423', 'Yên Bái ', '654113305', 'CS001', N'Cơ sở y tế', NULL,'1234');
exec INSERTNHANVIEN ('NV012', 'Đinh Vang Việt ', 'N?', NULL, '518255758747', 'Quảng Ninh ', '897378822', 'CS002', N'Cơ sở y tế', NULL,'1234');
exec INSERTNHANVIEN ('NV013', 'Đoàn Thiên Ân ', 'Nam', NULL, '799192604508', 'Tuyên Quang ', '295910497', 'CS003', N'Cơ sở y tế', NULL, '1234');
exec INSERTNHANVIEN ('NV014', 'Diêm Vân Anh ', 'Nam', NULL, '496355483978', 'Kiên Giang ', '713057827', 'CS004', N'Cơ sở y tế', NULL,'1234');
exec INSERTNHANVIEN ('NV015', 'Giàng Tân Bình ', 'Nam', NULL, '122646930083', 'Vĩnh Long ', '207161212', 'CS005', N'Cơ sở y tế', NULL,'1234');

exec INSERTNHANVIEN ('NV016', 'Huệ Hương ', 'N?', NULL, '518255758747', 'Qu?ng Ninh ', '897378822', 'CS002', N'Y sĩ / Bác sĩ', 'Tai, mũi, họng','1234');
exec INSERTNHANVIEN ('NV017', 'Ninh Vinh Quốc ', 'N?', NULL, '518255758747', 'Qu?ng Ninh ', '897378822', 'CS002', N'Y sĩ / Bác sĩ', 'Tai, mũi, họng','1234');
exec INSERTNHANVIEN ('NV018', 'Tán Khánh Mai ', 'Nam', NULL, '799192604508', 'Tuyên Quang ', '295910497', 'CS003', 'Y sĩ / Bác sĩ','Tai, mũi, họng', '1234');
exec INSERTNHANVIEN ('NV019', 'Lôc Minh Thiên ', 'Nam', NULL, '496355483978', 'Kiên Giang ', '713057827', 'CS004', 'Y sĩ / Bác sĩ', 'Tai, m?i, h?ng','1234');
exec INSERTNHANVIEN ('NV020', 'Lộc Minh ', 'Nam', NULL, '496355483543', 'Kiên Giang ', '71304563', 'CS004', 'Y sĩ / Bác sĩ', 'Tr? em','1234');
exec INSERTNHANVIEN ('NV021', 'Hàn Kim Thủy ', 'Nam', NULL, '496355483543', 'Kiên Giang ', '71304563', 'CS004', 'Y sĩ / Bác sĩ', 'Th?n kinh','1234');
exec INSERTNHANVIEN ('NV022', 'Lâm Oanh ', 'N?', NULL, '518255758747', 'Qu?ng Ninh ', '897378822', 'CS002', 'Y sĩ / Bác sĩ', 'Tr? em','1234');
exec INSERTNHANVIEN ('NV023', 'Chung Lệ Chi ', 'Nam', NULL, '799192604508', 'Tuyên Quang ', '295910497', 'CS003', 'Y sĩ / Bác sĩ', 'Th?n kinh', '1234');
exec INSERTNHANVIEN ('NV024', 'Phù Linh Châu ', 'Nam', NULL, '496355483978', 'Kiên Giang ', '713057827', 'CS004', 'Y sĩ / Bác sĩ', 'Ung th?','1234');
exec INSERTNHANVIEN ('NV025', 'Hùng Kièu Nương ', 'Nam', NULL, '122646930083', 'Vĩnh Long ', '207161212', 'CS005', 'Y sĩ / Bác sĩ', 'Ung th?','1234');

exec INSERTNHANVIEN ('NV026', 'Chung Quang Th?nh ', 'N?',null, '716299399663', '??k Nông ', '416443922', 'CS001', 'Nghiên cứu', 'Vô tuy?n h?c can thi?p','1234');
exec INSERTNHANVIEN ('NV027', 'Giao Anh Vi?t ', 'Nam', NULL, '728016968058', 'Trà Vinh ', '173338081',  'CS003', 'Nghiên cứu', 'Nhi th?n', '1234');
exec INSERTNHANVIEN ('NV028', 'Trà Qu?c Vi?t ', 'N?',null, '818705368116', 'H?u Giang ', '176715229', 'CS004', 'Nghiên cứu', 'B?nh lý h?c','1234');
exec INSERTNHANVIEN ('NV029', 'L?c M?nh ', 'Nam', NULL, '496355483543', 'Kiên Giang ', '71304563', 'CS001', 'Nghiên cứu', 'B?nh lý h?c','1234');
exec INSERTNHANVIEN ('NV030', 'Hàn Kim Th?y ', 'Nam', NULL, '496355483543', 'Kiên Giang ', '71304563', 'CS005', 'Nghiên cứu', 'B?nh lý h?c','1234');
exec INSERTNHANVIEN ('NV031', '??i Lâm Oanh ', 'N?', NULL, '518255758747', 'Qu?ng Ninh ', '897378822', 'CS002', 'Nghiên cứu', 'B?nh lý h?c','1234');

select * from benhnhan;
exec deletebenhnhan('BN002');
-- INSERT DATA INTO BENHNHAN
EXEC INSERTBENHNHAN('BN001','CS002', N'H?ng B?ch Th?o','592218019912', NULL, '12', 'Ph??ng Canh', 'Qu?n Nam T? Liêm', 'Hà N?i', NULL, NULL,null,'1234');
EXEC INSERTBENHNHAN('BN002','CS003', N'Quang Thái','3655745235324', '1945-02-03', '421', 'Ph??ng Canh', 'Qu?n Nam T? Liêm', 'Hà N?i', NULL, NULL, NULL,'1234B');
EXEC INSERTBENHNHAN('BN003','CS004', N'Kh?c Vi?t','536437346436', '1955-06-30', '101','???ng H?i H?', 'Qu?n H?i Châu', '?à N?ng', NULL, 'R?i lo?n ch?y máu', NULL,'1234');
EXEC INSERTBENHNHAN('BN004','CS005', N'Ti?n Ð?c','634257654325', '1960-05-25', '235', '???ng Lê Thanh Ngh?', 'Qu?n H?i Châu', '?à N?ng', NULL, NULL, NULL,'1234');
EXEC INSERTBENHNHAN('BN005','CS001', N'H? Th? Lan','563454765352', '1975-09-06', '352','???ng ?i?n Biên Ph?', 'Qu?n Thanh Khê', '?à N?ng', NULL, NULL, NULL,'1234');
EXEC INSERTBENHNHAN('BN006','CS001', N'Ch?n Hùng', '966396551955','1999-11-01', '133', '???ng Tr?n Cao Vân', 'Qu?n Thanh Khê', '?à N?ng', 'R?i lo?n ch?y máu', NULL, NULL,'1234');
EXEC INSERTBENHNHAN('BN007','CS001', N'Lê Th? H?ng','09314225w334', '1955-05-22', '365', N'Bà HUy?n Thanh Quan', N'Q.Bình Th?nh', N'TPHCM', N'U x? t? cung', N'B?nh tim', N'Paracetamol','1234');

INSERT INTO HSBA(MAHSBA,MABN,NGAY,CHANDOAN,MABS,MAKHOA,MACSYT,KETLUAN) 
VALUES ('HSBA001', 'BN007', TO_DATE('2022-03-12', 'yyyy-mm-dd'), 'Ti?u ???ng', 'NV026', 'K001', 'CS001', 'Ti?u ???ng mãn tính');
INSERT INTO HSBA(MAHSBA,MABN,NGAY,CHANDOAN,MABS,MAKHOA,MACSYT,KETLUAN) 
VALUES ('HSBA002', 'BN002', TO_DATE('2022-05-05', 'yyyy-mm-dd'), 'Suy hô h?p  ', 'NV027', 'K002', 'CS002', 'Viêm ph?i c?ng ??ng');
INSERT INTO HSBA(MAHSBA,MABN,NGAY,CHANDOAN,MABS,MAKHOA,MACSYT,KETLUAN) 
VALUES ('HSBA003', 'BN003', TO_DATE('2022-05-08', 'yyyy-mm-dd'), '?au d? dày', 'NV028', 'K003', 'CS003', 'Viêm loát d? dày');
insert into HSBA (MAHSBA, MABN, NGAY, CHANDOAN, MABS, MAKHOA, MACSYT, KETLUAN) values ('HSBA004', 'BN001', TO_DATE('2020-12-01', 'YYYY-MM-DD'),'Sinh thi?t th?n ghép sau ghép th?n d??i h??ng d?n c?a siêu âm','NV016', 'K001', 'CS001','Nhi?m trùng do t? c?u vàng');

--INSERT DATA TO HSBA_DV
INSERT INTO HSBA_DV(MAHSBA,MADV,NGAY,MAKTV,KETQUA)
VALUES ('HSBA001', 'DV001',TO_DATE('2022-03-12', 'yyyy-mm-dd'), 'NV027', 'Ti?u ???ng');
INSERT INTO HSBA_DV(MAHSBA,MADV,NGAY,MAKTV,KETQUA)
VALUES ('HSBA002', 'DV002',TO_DATE('2022-05-12', 'yyyy-mm-dd'), 'NV025', 'Viêm ph?i');
INSERT INTO HSBA_DV(MAHSBA,MADV,NGAY,MAKTV,KETQUA)
VALUES ('HSBA003', 'DV003',TO_DATE('2022-05-12', 'yyyy-mm-dd'), 'NV020', 'Viêm d? dày');