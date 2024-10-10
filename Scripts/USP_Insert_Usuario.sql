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
END
