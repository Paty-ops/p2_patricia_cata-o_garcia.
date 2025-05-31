CREATE DATABASE Parcial2pcg;
GO
USE [master]
GO
CREATE LOGIN [usrparcial2pcg] WITH PASSWORD = N'12345678',
	DEFAULT_DATABASE = [Parcial2pcg],
	CHECK_EXPIRATION = OFF,
	CHECK_POLICY = ON
GO
USE [Parcial2pcg]
GO
CREATE USER [usrparcial2pcg] FOR LOGIN [usrparcial2pcg]
GO
ALTER ROLE [db_owner] ADD MEMBER [usrparcial2pcg]
GO

DROP TABLE Serie;

CREATE TABLE Serie (
    id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    titulo VARCHAR(250) NOT NULL,
    sinopsis VARCHAR(5000) NOT NULL,
    director VARCHAR(100) NOT NULL,
    episodios INT NOT NULL,
    urlPortada VARCHAR(500) NOT NULL,
    idiomaOriginal VARCHAR(100) NOT NULL,
    fechaEstreno DATE NOT NULL DEFAULT GETDATE(),
    estado SMALLINT NOT NULL
);
select*from Serie
go
alter PROC paSerieListar @parametro VARCHAR(100)
AS
  SELECT * FROM Serie
  WHERE estado<>-1 and titulo+sinopsis+director LIKE '%'+REPLACE(@parametro,' ','%')+'%'
  ORDER BY estado desc, titulo ASC;
  
  exec paSerieListar '';

insert into Serie(titulo,sinopsis,director,episodios,fechaEstreno,estado,urlPortada,idiomaOriginal)
values('Stranger Thing','Serie','Duffer',3,'2025-08-03',4,'www.example.jpg','Ingles')