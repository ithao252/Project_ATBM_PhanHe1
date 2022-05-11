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
GRANT SELECT ON view_HSBA_QLCSYT TO CSYT;
GRANT INSERT ON view_HSBA_QLCSYT TO CSYT;
GRANT DELETE ON view_HSBA_QLCSYT TO CSYT;

GRANT SELECT ON view_HSBADV_QLCSYT TO CSYT;
GRANT INSERT ON view_HSBADV_QLCSYT TO CSYT;
GRANT DELETE ON view_HSBADV_QLCSYT TO CSYT;

-------------------------------------------------------------

-- Test for adQLCSYT.view_HSBA_QLCSYT voi NV0007
--Select
SELECT * FROM adQLCSYT.view_HSBA_QLCSYT;

--Insert
INSERT INTO adQLCSYT.view_HSBA_QLCSYT
VALUES ('HS0112', 'BN0006', TO_DATE('2020-07-23', 'yyyy-mm-dd'), 'Viêm mũi họng', 'NV0007', 'CK0005', 'CS0002', 'Viêm mũi họng dị ứng');

--Delete
DELETE FROM adQLCSYT.view_HSBA_QLCSYT WHERE MAHSBA = 'HS0112';
------------------------------------------------------
-- Test adQLCSYT.view_HSBADV_QLCSYT voi NV0007
SELECT * FROM adQLCSYT.view_HSBADV_QLCSYT;

--Insert
INSERT INTO adQLCSYT.view_HSBADV_QLCSYT
VALUES ('HS0002', 'DV0003',TO_DATE('2022-12-05', 'yyyy-mm-dd'), 'NV0015', 'Sad');

--Delete
DELETE FROM adQLCSYT.view_HSBADV_QLCSYT
WHERE mahsba = 'HS0002' AND madv ='DV0003' AND TO_CHAR(ngay, 'YYYY-MM-DD') = '2022-12-05';
