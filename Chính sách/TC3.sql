CREATE OR REPLACE VIEW view_HSBA_QLCSYT
AS 
SELECT MAHSBA,MABN, NGAY, CHANDOAN, MABS, MAKHOA, MACSYT, KETLUAN
FROM HSBA 
WHERE ((SELECT EXTRACT(DAY FROM sysdate) FROM dual) BETWEEN 5 AND 27) 
        AND (MACSYT IN (SELECT CSYT 
                        FROM NHANVIEN 
                        WHERE MANV = SYS_CONTEXT('userenv', 'session_user'))) WITH CHECK OPTION;


CREATE OR REPLACE VIEW view_HSBADV_QLCSYT
AS 
SELECT MAHSBA, MADV, NGAY, MAKTV, KETQUA
FROM HSBA_DV
WHERE  ((SELECT EXTRACT(DAY FROM sysdate) FROM dual) BETWEEN 5 AND 27) 
        AND (MAHSBA IN (SELECT MAHSBA 
                        FROM HSBA 
                        WHERE MACSYT IN (SELECT CSYT 
                                        FROM NHANVIEN 
                                        WHERE MANV = SYS_CONTEXT('userenv', 'session_user')))) WITH CHECK OPTION;

-- Cac CSYT chi duoc them, xoa du lieu cua chinh minh tren bang HSBA va HSBA_DV
GRANT INSERT ON view_HSBA_QLCSYT TO role_CSYT;
GRANT DELETE ON view_HSBA_QLCSYT TO role_CSYT;

GRANT INSERT ON view_HSBADV_QLCSYT TO role_CSYT;
GRANT DELETE ON view_HSBADV_QLCSYT TO role_CSYT;
