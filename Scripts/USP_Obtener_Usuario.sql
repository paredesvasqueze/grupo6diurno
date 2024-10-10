CREATE PROCEDURE USP_Obtener_Usuario
    @nId_Usuario INT
AS
BEGIN
    SELECT nId_Usuario, cNombre, cCorreo, cTelefono, cDocumentoIdentidad
    FROM Usuarios
    WHERE nId_Usuario = @nId_Usuario
END
