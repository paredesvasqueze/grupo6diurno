USE [Biblioteca]
GO
CREATE PROCEDURE [dbo].[USP_Borrar_Usuario]
    @nId_Usuario INT
AS
BEGIN
    DELETE FROM Usuario
    WHERE nId_Usuario = @nId_Usuario;
END
