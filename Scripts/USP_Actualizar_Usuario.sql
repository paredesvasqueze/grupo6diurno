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
END
