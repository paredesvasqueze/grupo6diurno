USE [Biblioteca]
GO
/****** Object:  StoredProcedure [dbo].[USP_Borrar_Autor]    Script Date: 7/10/2024 10:01:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[USP_Borrar_Autor]
@nId_Autor int
as
begin
delete from Autor
where nId_Autor = @nId_Autor;
end