create procedure USP_Actualizar_Libro
@nId_Libro int,
@cTitulo varchar(255),
@dAnio datetime,
@nId_Autor int,
@nId_Genero int
as
update Libro
set cTitulo = @cTitulo,
        dAnio = @dAnio,
        nId_Autor = @nId_Autor,
        nId_Genero = @nId_Genero
    WHERE 
        nId_Libro = @nId_Libro;
select cast(@@ROWCOUNT as int)
