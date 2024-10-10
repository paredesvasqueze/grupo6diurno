ALTER PROCEDURE USP_Insert_Genero
    @cNombreGenero VARCHAR(100)
AS
BEGIN
    INSERT INTO Genero (cNombreGenero)
    VALUES (@cNombreGenero);
	select cast(SCOPE_IDENTITY() as int)
END