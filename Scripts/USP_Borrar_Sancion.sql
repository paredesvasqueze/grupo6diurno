CREATE PROCEDURE USP_Borrar_Sancion
    @nId_Sancion INT
AS
BEGIN
    DELETE FROM Sanciones
    WHERE nId_Sancion = @nId_Sancion
END
