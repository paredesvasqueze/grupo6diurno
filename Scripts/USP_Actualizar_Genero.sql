<<<<<<< HEAD
CREATE PROCEDURE USP_Actualizar_Genero
=======
ALTER PROCEDURE USP_Actualizar_Genero
>>>>>>> a9ae54a9504d26dfedc20b51fcfc4d0959864a7f
    @nId_Genero INT,
    @cNombreGenero VARCHAR(100)
AS
BEGIN
    UPDATE Genero
    SET cNombreGenero = @cNombreGenero
    WHERE nId_Genero = @nId_Genero;
<<<<<<< HEAD
END
=======
	select cast(@@ROWCOUNT as int)
END
>>>>>>> a9ae54a9504d26dfedc20b51fcfc4d0959864a7f
