CREATE PROCEDURE USP_Eliminar_Libro
    @nId_Libro INT
AS
BEGIN
    DELETE FROM Libro
    WHERE nId_Libro = @nId_Libro;
END
select cast(@@ROWCOUNT as int)