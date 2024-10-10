USE [Biblioteca]
GO
/****** Object:  StoredProcedure [dbo].[USP_Insert_Autor]    Script Date: 7/10/2024 10:01:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[USP_Insert_Autor]
@cNombre varchar(255),
@cNacionalidad varchar(100),
@dFechaNacimiento datetime
as
begin
insert into Autor
([cNombre],[cNacionalidad],[dFechaNacimiento])
values
(@cNombre,@cNacionalidad,@dFechaNacimiento)
select cast(SCOPE_IDENTITY() as int)
end