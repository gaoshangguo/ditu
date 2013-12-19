--this script need run in oracle 12c

--Tablespace
create tablespace postgis datafile 'D:\app\Administrator\oradata\orcl\postgis01.dbf' size 1000M autoextend on;

-- USER SQL
Create USER postgis IDENTIFIED BY password 
DEFAULT TABLESPACE "POSTGIS"
TEMPORARY TABLESPACE "TEMP"
ACCOUNT UNLOCK ;

-- ROLES
GRANT "RESOURCE" TO postgis ;
GRANT "CONNECT" TO postgis ;
GRANT "DBA" TO postgis ;

-- SYSTEM PRIVILEGES

-- QUOTAS
ALTER USER postgis QUOTA UNLIMITED ON POSTGIS;
