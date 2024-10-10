CREATE PROCEDURE USP_Borrar_Comentario
    @nId_Comentario INT
AS
BEGIN
    DELETE FROM Comentarios
    WHERE nId_Comentario = @nId_Comentario
END
