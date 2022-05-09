-- Tao user admin quan li co so y te
CREATE USER adQLCSYT IDENTIFIED BY adQLCSYT;
GRANT ALL PRIVILEGES TO adQLCSYT;

GRANT EXECUTE ON SYS.DBMS_CRYPTO to adQLCSYT; -- de su dung ham ma hoa
GRANT EXECUTE ON SYS.DBMS_RLS to adQLCSYT;  --De co the add policy cho VPD


