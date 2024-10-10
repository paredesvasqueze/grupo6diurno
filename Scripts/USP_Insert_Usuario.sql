<<<<<<< HEAD
USE [Biblioteca]
GO
CREATE PROCEDURE [dbo].[USP_Insert_Usuario]
    @cNombre VARCHAR(150),
    @cCorreo VARCHAR(250),
    @cTelefono VARCHAR(15),
    @cDocumentoIdentidad VARCHAR(25)
AS
BEGIN
    INSERT INTO Usuario
        ([cNombre], [cCorreo], [cTelefono], [cDocumentoIdentidad])
    VALUES
        (@cNombre, @cCorreo, @cTelefono, @cDocumentoIdentidad);
    SELECT CAST(SCOPE_IDENTITY() AS INT);
=======
CREATE PROCEDURE USP_Insert_Usuario
    @cNombre NVARCHAR(255),
    @cCorreo NVARCHAR(255),
    @cTelefono NVARCHAR(50),
    @cDocumentoIdentidad NVARCHAR(50)
AS
BEGIN
    INSERT INTO Usuarios (cNombre, cCorreo, cTelefono, cDocumentoIdentidad)
    VALUES (@cNombre, @cCorreo, @cTelefono, @cDocumentoIdentidad)

    SELECT SCOPE_IDENTITY() -- Retorna el ID del nuevo usuario insertado
>>>>>>> ac1f886e50cc18d8ee7457efdfeb12c9a7c83127
END
