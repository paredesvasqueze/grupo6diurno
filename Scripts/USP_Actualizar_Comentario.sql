CREATE PROCEDURE USP_Actualizar_Comentario
    @nId_Comentario INT,
    @cComentario NVARCHAR(MAX),
    @dFecha DATETIME,
    @nId_Usuario INT,
    @nId_Libro INT,
    @nPuntuacion INT
AS
BEGIN
    UPDATE Comentarios
    SET cComentario = @cComentario,
        dFecha = @dFecha,
        nId_Usuario = @nId_Usuario,
        nId_Libro = @nId_Libro,
        nPuntuacion = @nPuntuacion
    WHERE nId_Comentario = @nId_Comentario
END
