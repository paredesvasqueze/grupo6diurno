<<<<<<< HEAD
USE [Biblioteca]
GO
CREATE PROCEDURE [dbo].[USP_Actualizar_Usuario]
    @nId_Usuario INT,
    @cNombre VARCHAR(150),
    @cCorreo VARCHAR(250),
    @cTelefono VARCHAR(15),
    @cDocumentoIdentidad VARCHAR(25)
AS
BEGIN
    UPDATE Usuario
    SET
        cNombre = @cNombre,
        cCorreo = @cCorreo,
        cTelefono = @cTelefono,
        cDocumentoIdentidad = @cDocumentoIdentidad
    WHERE nId_Usuario = @nId_Usuario;
    SELECT CAST(SCOPE_IDENTITY() AS INT);
=======
CREATE PROCEDURE USP_Actualizar_Usuario
    @nId_Usuario INT,
    @cNombre NVARCHAR(255),
    @cCorreo NVARCHAR(255),
    @cTelefono NVARCHAR(50),
    @cDocumentoIdentidad NVARCHAR(50)
AS
BEGIN
    UPDATE Usuarios
    SET cNombre = @cNombre,
        cCorreo = @cCorreo,
        cTelefono = @cTelefono,
        cDocumentoIdentidad = @cDocumentoIdentidad
    WHERE nId_Usuario = @nId_Usuario
>>>>>>> ac1f886e50cc18d8ee7457efdfeb12c9a7c83127
END
