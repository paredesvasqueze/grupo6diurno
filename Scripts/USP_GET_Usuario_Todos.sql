USE [Biblioteca]
GO
CREATE PROCEDURE [dbo].[USP_GET_Usuario_Todos]
AS
BEGIN
    SELECT * FROM Usuario;
END
