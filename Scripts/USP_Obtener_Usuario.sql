<<<<<<< HEAD
USE [Biblioteca]
GO
CREATE PROCEDURE [dbo].[USP_Obtener_Usuario]
    @nId_Usuario INT
AS
BEGIN
    SELECT * FROM Usuario
    WHERE nId_Usuario = @nId_Usuario;
=======
CREATE PROCEDURE USP_Obtener_Usuario
    @nId_Usuario INT
AS
BEGIN
    SELECT nId_Usuario, cNombre, cCorreo, cTelefono, cDocumentoIdentidad
    FROM Usuarios
    WHERE nId_Usuario = @nId_Usuario
>>>>>>> ac1f886e50cc18d8ee7457efdfeb12c9a7c83127
END
