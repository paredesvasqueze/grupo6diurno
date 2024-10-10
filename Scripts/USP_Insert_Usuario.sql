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
END
