CREATE OR REPLACE FUNCTION MA_HOA(p_string nvarchar2, p_key VARCHAR2)

return raw
as 
    source_raw RAW(200);
    encrypted_data RAW(200);
    r_key RAW(200) := UTL_RAW.CAST_TO_RAW (convert (p_key, 'AL32UTF8', 'US7ASCII'));
BEGIN   
    source_raw := UTL_RAW.CAST_TO_RAW (p_string);
     encrypted_data := DBMS_CRYPTO.Encrypt(src=> source_raw,
                                        typ => DBMS_CRYPTO.DES_CBC_PKCS5, 
                                        key => r_key);
    RETURN  encrypted_data;
END;
/
-- 2. HAM GIAI MA
CREATE OR REPLACE FUNCTION GIAI_MA (data_encrypt_raw raw, p_key VARCHAR2)
RETURN NVARCHAR2
AS
    r_key RAW(200) := UTL_RAW.CAST_TO_RAW (convert (p_key, 'AL32UTF8', 'US7ASCII'));
    r_decrypt RAW(500);
    decrypted_data VARCHAR2(100);
BEGIN
    r_decrypt := dbms_crypto.Decrypt(src => data_encrypt_raw, 
                                        typ => DBMS_CRYPTO.DES_CBC_PKCS5,
                                        key => r_key);
   
    decrypted_data := UTL_RAW.CAST_TO_NVARCHAR2(r_decrypt);
    
    
    RETURN decrypted_data;
END;
/


-- Procedure thêm nhân viên
CREATE OR REPLACE PROCEDURE  InsertNhanVien(
    manv IN NHANVIEN.MANV%TYPE,
    hoten  IN NHANVIEN.HOTEN%TYPE,
    phai  IN NHANVIEN.PHAI%TYPE,
    ngaysinh  IN VARCHAR2,
    cmnd  IN NHANVIEN.CMND%TYPE,
    quequan  IN NHANVIEN.QUEQUAN%TYPE,
    sodt  IN NHANVIEN.SODT%TYPE,
    csyt  IN NHANVIEN.CSYT%TYPE,
    vaitro  IN NHANVIEN.VAITRO%TYPE,
    chuyenkhoa  IN NHANVIEN.CHUYENKHOA%TYPE,
    pass varchar2
    )
AS
    khoa varchar2(100);
BEGIN
    khoa := 'A1A2A3A4A5A6CAFE';
    INSERT INTO NHANVIEN  VALUES 
    (manv, hoten, phai, TO_DATE(ngaysinh,'yyyy-mm-dd'), cmnd,quequan, MA_HOA( sodt,khoa), csyt, vaitro, chuyenkhoa);
    EXECUTE IMMEDIATE 'CREATE USER "' || MANV || '" IDENTIFIED BY "' || pass || '"';
    EXECUTE IMMEDIATE 'GRANT NHANVIEN TO "' || MANV || '"';
    
    IF (vaitro = N'Y sĩ/ bác sĩ') THEN
        EXECUTE IMMEDIATE 'GRANT Y_BACSI TO "' || MANV || '"';
    END IF;
    
    IF (vaitro = N'Thanh tra') THEN
        EXECUTE IMMEDIATE 'GRANT THANHTRA TO "' || MANV || '"';     
    END IF;
    
    IF (vaitro = N'Cơ sở y tế') THEN
        EXECUTE IMMEDIATE 'GRANT CSYT TO "' || MANV || '"';
    END IF;
    
    IF (vaitro = N'Nghiên cứu') THEN
        EXECUTE IMMEDIATE 'GRANT NGHIENCUU TO "' || MANV || '"';
    END IF;
    
END;
/

-- Procedure thêm bệnh nhân
CREATE OR REPLACE PROCEDURE InsertBenhNhan(
    mabn IN BENHNHAN.MABN%TYPE,
    macsyt IN BENHNHAN.MACSYT%TYPE,
    tenbn IN BENHNHAN.TENBN%TYPE,
    cmnd IN BENHNHAN.CMND%TYPE,
    ngaysinh  IN VARCHAR2,
    sonha IN BENHNHAN.SONHA%TYPE,
    tenduong IN BENHNHAN.TENDUONG%TYPE,
    quanhuyen IN BENHNHAN.QUANHUYEN%TYPE,
    tinhtp IN BENHNHAN.TINHTP%TYPE,
    tiensubenh IN BENHNHAN.TIENSUBENH%TYPE,
    tiensubenhgd IN BENHNHAN.TIENSUBENHGD%TYPE,
    diungthuoc IN BENHNHAN.DIUNGTHUOC%TYPE,
    pass VARCHAR2)
AS
    khoa varchar2(30);
BEGIN
    khoa := 'A1A2A3A4A5A6CAFE';
    INSERT INTO BENHNHAN VALUES 
    (mabn,macsyt,tenbn,cmnd,TO_DATE(ngaysinh,'yyyy-mm-dd'),MA_HOA(sonha,khoa),tenduong,quanhuyen,tinhtp,tiensubenh,tiensubenhgd,diungthuoc);
    EXECUTE IMMEDIATE 'CREATE USER "' || MABN || '" IDENTIFIED BY "' || pass || '"';
    EXECUTE IMMEDIATE 'GRANT BENHNHAN TO "' || MABN || '"';
END;
/

CREATE OR REPLACE PROCEDURE DeleteBenhNhan(mabn IN BENHNHAN.MABN%TYPE)
AS
BEGIN
    EXECUTE IMMEDIATE 'DROP USER "' || mabn || '" CASCADE';
    DELETE FROM BENHNHAN WHERE MABN = mabn;
END;
/

CREATE OR REPLACE PROCEDURE DeleteNhanVien(manv IN NHANVIEN.MANV%TYPE)
AS
BEGIN
    EXECUTE IMMEDIATE 'DROP USER "' || manv || '" CASCADE';
    DELETE FROM NHANVIEN WHERE MANV = manv;
END;
/

CREATE OR REPLACE TRIGGER UPDATE_BENHNHAN
BEFORE UPDATE ON BENHNHAN
FOR EACH ROW
DECLARE
   
   v_soNha NVARCHAR2(100);
   khoa VARCHAR(30);

BEGIN
   
  
   
        khoa := 'A1A2A3A4A5A6CAFE';
       
        -- Update sonha --> Chỉ cần mã hóa lại sonha mới
        IF (:old.sonha != :new.sonha) THEN
            
            :new.sonha := MA_HOA(TRIM(:new.sonha), khoa);        
        END IF;

   
END UPDATE_BENHNHAN;
/

CREATE OR REPLACE TRIGGER UPDATE_NHANVIEN
BEFORE UPDATE ON NHANVIEN
FOR EACH ROW
DECLARE
   v_sdt CHAR(12);   
   khoa VARCHAR(30);

BEGIN
  
        khoa := 'A1A2A3A4A5A6CAFE';
        
        IF (:old.sodt != :new.sodt) THEN
        
            :new.CMND := MA_HOA(TRIM(:new.sodt), khoa);        
        END IF;
      
    
END UPDATE_NHANVIEN;
