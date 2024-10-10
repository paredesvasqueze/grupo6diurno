<<<<<<< HEAD
USE [Biblioteca]
GO
CREATE PROCEDURE [dbo].[USP_GET_Usuario_Todos]
AS
BEGIN
    SELECT * FROM Usuario;
=======
CREATE PROCEDURE USP_GET_Usuario_Todos
AS
BEGIN
    SELECT nId_Usuario, cNombre, cCorreo, cTelefono, cDocumentoIdentidad
    FROM Usuarios
>>>>>>> ac1f886e50cc18d8ee7457efdfeb12c9a7c83127
END
