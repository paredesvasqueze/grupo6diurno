<<<<<<< HEAD
USE [Biblioteca]
GO
CREATE PROCEDURE [dbo].[USP_Borrar_Usuario]
    @nId_Usuario INT
AS
BEGIN
    DELETE FROM Usuario
    WHERE nId_Usuario = @nId_Usuario;
=======
CREATE PROCEDURE USP_Borrar_Usuario
    @nId_Usuario INT
AS
BEGIN
    DELETE FROM Usuarios
    WHERE nId_Usuario = @nId_Usuario
>>>>>>> ac1f886e50cc18d8ee7457efdfeb12c9a7c83127
END
