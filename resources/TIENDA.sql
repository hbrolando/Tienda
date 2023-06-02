set language spanish
set language english
select @@LANGUAGE

CREATE DATABASE TIENDA
USE TIENDA
CREATE TABLE CLIENTES
(
	CODIGO_CI INT IDENTITY PRIMARY KEY,
	NOMBRE_COMPLETO NVARCHAR(80) NOT NULL,
	APELLIDO_PATERNO NVARCHAR (80) NOT NULL,
	APELLIDO_MATERNO NVARCHAR (80) NOT NULL,
	FECHA_NACIMIENTO DATE NOT NULL,
	CELULAR INT NOT NULL,
	CORREO NVARCHAR (50)
);
INSERT INTO CLIENTES VALUES('JUAN','APAZA','CONDORI','01/05/1988','76556543','juan@gmai.com');
INSERT INTO CLIENTES VALUES('JONNY','ALARCON','SARSURI','20/03/1983','76556543','juan@gmai.com');
INSERT INTO CLIENTES VALUES('ROGER','BLANCO','LEON','23/03/1978','76654543','roger@gmai.com');
INSERT INTO CLIENTES VALUES('NATALY','APAZA','CONDORI','12/06/1968','67788943','nataly@gmai.com');
INSERT INTO CLIENTES VALUES('EDGAR','CALLIZAYA','CONDORI','18/09/1983','75332123','edgar@gmai.com');
INSERT INTO CLIENTES VALUES('EDWIN','CHOQUE','CONDORI','03/07/1982','78452745','edwin@gmai.com');
INSERT INTO CLIENTES VALUES('ANDREA','MAMANI','CONDORI','10/05/1986','67112343','andrea@gmai.com');
INSERT INTO CLIENTES VALUES('ESTEFANY','ZERNA','CONDORI','21/04/1987','78132345','estefany@gmai.com');
INSERT INTO CLIENTES VALUES('CARLOS','GUTIERREZ','CONDORI','28/07/1988','73254343','juan@gmai.com');
INSERT INTO CLIENTES VALUES('ESPERANZA','LIMA','CONDORI','15/01/1948','78956745','esperanza@gmai.com');

SELECT * FROM CLIENTES


select SERVERPROPERTY('errorlogfilename')