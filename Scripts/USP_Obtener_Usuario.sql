USE [Biblioteca]
GO
CREATE PROCEDURE [dbo].[USP_Obtener_Usuario]
    @nId_Usuario INT
AS
BEGIN
    SELECT * FROM Usuario
    WHERE nId_Usuario = @nId_Usuario;
END
