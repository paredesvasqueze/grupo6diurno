<<<<<<< HEAD
CREATE PROCEDURE USP_Insert_Genero
=======
<<<<<<< HEAD
CREATE PROCEDURE USP_Insert_Genero
=======
ALTER PROCEDURE USP_Insert_Genero
>>>>>>> a9ae54a9504d26dfedc20b51fcfc4d0959864a7f
>>>>>>> ac1f886e50cc18d8ee7457efdfeb12c9a7c83127
    @cNombreGenero VARCHAR(100)
AS
BEGIN
    INSERT INTO Genero (cNombreGenero)
    VALUES (@cNombreGenero);
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
	select cast(SCOPE_IDENTITY() as int)
>>>>>>> a9ae54a9504d26dfedc20b51fcfc4d0959864a7f
>>>>>>> ac1f886e50cc18d8ee7457efdfeb12c9a7c83127
END