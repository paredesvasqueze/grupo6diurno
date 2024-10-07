CREATE PROCEDURE USP_Delete_Genero
    @nId_Genero INT
AS
BEGIN
    DELETE FROM Genero
    WHERE nId_Genero = @nId_Genero;
END