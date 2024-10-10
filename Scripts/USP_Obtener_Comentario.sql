CREATE PROCEDURE USP_Obtener_Comentario
    @nId_Comentario INT
AS
BEGIN
    SELECT nId_Comentario, cComentario, dFecha, nId_Usuario, nId_Libro, nPuntuacion
    FROM Comentarios
    WHERE nId_Comentario = @nId_Comentario
END
