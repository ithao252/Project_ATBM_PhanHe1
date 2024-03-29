CREATE OR REPLACE VIEW view_HSBA_BS
AS 
SELECT MAHSBA, MABN, NGAY, CHANDOAN, MABS, MAKHOA, MACSYT, KETLUAN
FROM HSBA 
WHERE MABS IN (SELECT MANV 
                FROM NHANVIEN 
                WHERE MANV = SYS_CONTEXT('userenv', 'session_user')) WITH CHECK OPTION;
                        
CREATE OR REPLACE VIEW view_HSBADV_BS
AS 
SELECT MAHSBA, MADV, NGAY, MAKTV, KETQUA
FROM HSBA_DV
WHERE MAHSBA IN (SELECT MAHSBA 
                        FROM HSBA 
                        WHERE MABS IN (SELECT MANV 
                                        FROM NHANVIEN 
                                        WHERE MANV = SYS_CONTEXT('userenv', 'session_user'))) WITH CHECK OPTION;

GRANT SELECT ON view_HSBA_BS TO Y_BACSI;
GRANT SELECT ON view_HSBADV_BS TO Y_BACSI;
--------------------------------------------
-- Test for NV0016
SELECT * FROM adQLCSYT.view_HSBA_BS;
SELECT * FROM adQLCSYT.view_HSBADV_BS;


