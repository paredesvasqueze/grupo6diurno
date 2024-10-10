CREATE PROCEDURE USP_GET_Comentario_Todos
AS
BEGIN
    SELECT nId_Comentario, cComentario, dFecha, nId_Usuario, nId_Libro, nPuntuacion
    FROM Comentarios
END
