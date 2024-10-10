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
END
