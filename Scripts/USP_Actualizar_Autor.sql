USE [Biblioteca]
GO
/****** Object:  StoredProcedure [dbo].[USP_Actualizar_Autor]    Script Date: 7/10/2024 10:01:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[USP_Actualizar_Autor]
@nId_Autor int,
@cNombre varchar(255),
@cNacionalidad varchar(100),
@dFechaNacimiento datetime
as
begin
update Autor
set
cNombre = @cNombre,
cNacionalidad = @cNacionalidad,
dFechaNacimiento = @dFechaNacimiento
where nId_Autor = @nId_Autor;
select cast(SCOPE_IDENTITY() as int)
end