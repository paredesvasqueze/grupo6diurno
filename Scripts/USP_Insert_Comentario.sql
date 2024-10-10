CREATE PROCEDURE USP_Insert_Comentario
    @cComentario NVARCHAR(MAX),
    @dFecha DATETIME,
    @nId_Usuario INT,
    @nId_Libro INT,
    @nPuntuacion INT
AS
BEGIN
    INSERT INTO Comentarios (cComentario, dFecha, nId_Usuario, nId_Libro, nPuntuacion)
    VALUES (@cComentario, @dFecha, @nId_Usuario, @nId_Libro, @nPuntuacion)

    SELECT SCOPE_IDENTITY() -- Retorna el ID del nuevo comentario insertado
END
