CREATE PROCEDURE USP_GET_Usuario_Todos
AS
BEGIN
    SELECT nId_Usuario, cNombre, cCorreo, cTelefono, cDocumentoIdentidad
    FROM Usuarios
END
