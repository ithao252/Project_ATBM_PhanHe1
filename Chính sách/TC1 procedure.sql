exec GRANT_ROLE_TO_USER('BENHNHAN','BN036','true');
CREATE OR REPLACE PROCEDURE GRANT_ROLE_TO_USER(role_name IN VARCHAR2, user_name IN VARCHAR2, n_option IN VARCHAR2)
authid current_user
IS
   	n_count INTEGER := 0;
BEGIN
    select count(*) into n_count from all_users where username = upper(user_name);
   	if n_count = 0 then
        RAISE_APPLICATION_ERROR(-20000,'User khong ton tai');
        return;
   	end if; 

    if n_option = 'TRUE' then
        EXECUTE IMMEDIATE ('grant ' || role_name || ' to ' || user_name || ' with admin option');
    else
        EXECUTE IMMEDIATE ('grant ' || role_name || ' to ' || user_name);
    end if;
END GRANT_ROLE_TO_USER;

/
-- Tạo user với vai trò
create or replace procedure Grant_NewUser(User_name in varchar2, Pass_Word in varchar2, vaitro in NVARCHAR2, CoSoYTe in VARCHAR2)
authid current_user 
is
    Tmp_count int;
    Tmp_query varchar2(100);
Begin
    select count(*) into Tmp_count from all_users where username=upper(User_name);
    if(Tmp_count!=0) then 
        RAISE_APPLICATION_ERROR(-20000,'User da ton tai');
    end if;
         
     -- Insert User in table
    if(vaitro = N'Bệnh Nhân') then
        Tmp_query:='insert into DBA_QLBV.BENHNHAN(MABN, MACSYT, NGAYSINH, SONHA) Values(:ma, :cs, TO_DATE(SYSDATE), 0)';
         execute immediate(Tmp_query)
            using User_name, CoSoYTe;
     else
        Tmp_query:='insert into DBA_QLBV.NHANVIEN(MANV, CSYT, VAITRO, NGAYSINH) Values(:ma, :cs, :vt, TO_DATE(SYSDATE))';
        execute immediate(Tmp_query)
            using User_name, CoSoYTe, vaitro;
    End if;
    
    -- Create User
    Tmp_query:='Create user '|| User_name||' identified by '||Pass_Word;
    --DBMS_OUTPUT.PUT_LINE(Tmp_query);
    execute immediate(Tmp_query);
    
    Tmp_query:='grant create session to '|| User_name;
    --DBMS_OUTPUT.PUT_LINE(Tmp_query);
    execute immediate(Tmp_query);
End;
/
exec DBA_QLBV.Grant_NewUser('BN032', 'CS001',TO_DATE('2003/07/09', 'yyyy/mm/dd'), '123');
select * from dba_QLBV.nhanvien;
insert into DBA_QLBV.BENHNHAN(MABN, MACSYT, NGAYSINH, SONHA) values ( 'BN032', 'CS001', TO_DATE('2003/07/09', 'yyyy/mm/dd'), '135');