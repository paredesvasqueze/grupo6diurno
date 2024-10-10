CREATE PROCEDURE USP_Borrar_Usuario
    @nId_Usuario INT
AS
BEGIN
    DELETE FROM Usuarios
    WHERE nId_Usuario = @nId_Usuario
END
