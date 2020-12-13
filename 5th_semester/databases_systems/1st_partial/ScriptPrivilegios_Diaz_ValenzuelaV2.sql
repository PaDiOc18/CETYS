CREATE USER 'JEFE'@'localhost' IDENTIFIED BY '123';
CREATE USER 'JEFE_CONSULTAS'@'localhost' IDENTIFIED BY '1234';
CREATE USER 'JEFE_PRIVILEGIOS'@'localhost' IDENTIFIED BY '12345';
CREATE USER 'JEFE_INSERCION'@'localhost' IDENTIFIED BY '123456';
CREATE USER 'JEFE_PERFILES'@'localhost' IDENTIFIED BY '1234567';


grant all privileges on farmacia3.* to 'JEFE'@'localhost';
grant select on farmacia3.* to 'JEFE_CONSULTAS'@'localhost';
grant grant option on farmacia3.* to 'JEFE_PRIVILEGIOS'@'localhost';
grant insert on farmacia3.* to 'JEFE_INSERCION'@'localhost';
grant create on farmacia.* to 'JEFE_PERFILES'@'localhost';
