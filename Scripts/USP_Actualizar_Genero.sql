CREATE PROCEDURE USP_Actualizar_Genero
    @nId_Genero INT,
    @cNombreGenero VARCHAR(100)
AS
BEGIN
    UPDATE Genero
    SET cNombreGenero = @cNombreGenero
    WHERE nId_Genero = @nId_Genero;
END
