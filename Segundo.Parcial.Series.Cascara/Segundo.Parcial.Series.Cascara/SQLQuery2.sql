CREATE DATABASE [20240701-SP];
GO
USE [20240701-SP];
GO
CREATE TABLE [20240701-SP].dbo.series
(
nombre VARCHAR(255) NOT NULL,
genero VARCHAR(255) NOT NULL,
alumno VARCHAR(255)
);
GO
INSERT INTO series (nombre, genero, alumno) VALUES ('The Sopranos', 'Drama criminal', NULL);
GO
INSERT INTO series (nombre, genero, alumno) VALUES ('Vinland Saga', 'Anime seinen', NULL);
GO
INSERT INTO series (nombre, genero, alumno) VALUES ('Brooklyn99', 'Comedia', NULL);
GO
INSERT INTO series (nombre, genero, alumno) VALUES ('The Boys', 'Comedia negra', NULL);
GO
INSERT INTO series (nombre, genero, alumno) VALUES ('Smiling friends', 'Animación', NULL);
GO
