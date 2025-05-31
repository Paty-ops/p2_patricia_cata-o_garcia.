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
    fechaEstreno DATE NOT NULL DEFAULT GETDATE(),
    estado SMALLINT NOT NULL
);
