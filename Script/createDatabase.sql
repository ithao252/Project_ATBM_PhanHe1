-- HE THONG THONG TIN QUAN LI S

CREATE TABLE HSBA
(
    MAHSBA NUMBER(5),
    MABN NUMBER(5),
    NGAY DATE,
    CHANDOAN NVARCHAR2(250),
    MABS NUMBER(5),
    MAKHOA NUMBER(5),
    MACSYT NUMBER(5),
    KETLUAN NVARCHAR2(250),
    CONSTRAINT PK_HSBA PRIMARY KEY (MAHSBA) 
);

CREATE TABLE HSBA_DV
(
    MAHSBA NUMBER(5),
    MADV NUMBER(5),
    NGAY DATE,
    MAKTV NUMBER(5),
    KETQUA NVARCHAR2(250),
    CONSTRAINT PK_HSBADV PRIMARY KEY (MAHSBA, MADV, NGAY) 
);

CREATE TABLE BENHNHAN
(
    MABN NUMBER(5),
    MACSYT NUMBER(5),
    TENBN NVARCHAR2(150), 
    CMND VARCHAR2(15),
    NGAYSINH DATE,
    SONHA VARCHAR2(10),
    TENDUONG NVARCHAR2(50),
    QUANHUYEN NVARCHAR2(50),
    TINHTP NVARCHAR2(50),
    TIENSUBENH NVARCHAR2(250),
    TIENSUBENHGD NVARCHAR2(250),
    DIUNGTHUOC NVARCHAR2(250),
    CONSTRAINT PK_BENHNHAN PRIMARY KEY (MABN) 
);

CREATE TABLE CSYT
(
    MACSYT NUMBER(5),
    TENCSYT NVARCHAR2(150), 
    DCCSYT NVARCHAR2(250),
    SDTCSYT NVARCHAR2(12),
    CONSTRAINT PK_CSYT PRIMARY KEY (MACSYT) 
);

CREATE TABLE NHANVIEN
(
    MANV NUMBER(5),
    HOTEN NVARCHAR2(150), 
    PHAI NVARCHAR2(4),
    NGAYSINH DATE,
    CMND VARCHAR2(15),
    QUEQUAN NVARCHAR2(250),
    SODT VARCHAR2(12),
    CSYT NUMBER(5),
    VAITRO NVARCHAR2(100),
    CHUYENKHOA NVARCHAR2(100),
    CONSTRAINT PK_NHANVIEN PRIMARY KEY (MANV) 
);

ALTER TABLE HSBA ADD
    CONSTRAINT FK_HSBA_BENHNHAN FOREIGN KEY(MABN) REFERENCES BENHNHAN(MABN);
ALTER TABLE HSBA ADD
    CONSTRAINT FK_HSBA_NHANVIEN FOREIGN KEY(MABS) REFERENCES NHANVIEN(MANV);
ALTER TABLE HSBA ADD
    CONSTRAINT FK_HSBA_CSYT FOREIGN KEY(MACSYT) REFERENCES CSYT(MACSYT);

ALTER TABLE HSBA_DV ADD
    CONSTRAINT FK_HSBADV_HSBA FOREIGN KEY(MAHSBA) REFERENCES HSBA(MAHSBA);
ALTER TABLE HSBA_DV ADD
    CONSTRAINT FK_HSBADV_NHANVIEN FOREIGN KEY(MAKTV) REFERENCES NHANVIEN(MANV);
    
ALTER TABLE BENHNHAN ADD
    CONSTRAINT FK_BENHNHAN_CSYT FOREIGN KEY(MACSYT) REFERENCES CSYT(MACSYT);
    
ALTER TABLE NHANVIEN ADD
    CONSTRAINT FK_NHANVIEN_CSYT FOREIGN KEY(CSYT) REFERENCES CSYT(MACSYT);
