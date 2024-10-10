<<<<<<< HEAD
CREATE PROCEDURE USP_Delete_Genero
=======
<<<<<<< HEAD
CREATE PROCEDURE USP_Delete_Genero
=======
ALTER PROCEDURE USP_Delete_Genero
>>>>>>> a9ae54a9504d26dfedc20b51fcfc4d0959864a7f
>>>>>>> ac1f886e50cc18d8ee7457efdfeb12c9a7c83127
    @nId_Genero INT
AS
BEGIN
    DELETE FROM Genero
    WHERE nId_Genero = @nId_Genero;
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
	select cast(@@ROWCOUNT as int)
>>>>>>> a9ae54a9504d26dfedc20b51fcfc4d0959864a7f
>>>>>>> ac1f886e50cc18d8ee7457efdfeb12c9a7c83127
END