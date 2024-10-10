alter pro USP_Insert_Libro
@nId_Libro int,
@cTitulo varchar(255),
@dAnio datetime,
@nId_Autor int,
@nId_Genero int
as
begin
Insert into Libro
(nId_Libro, cTitulo, dAnio, nId_Autor, nId_Genero)
values (@nId_Libro, @cTitulo, @dAnio, @nId_Autor, @nId_Genero);
select cast(SCOPE_IDENTITY() as int)
end