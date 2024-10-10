CREATE PROCEDURE USP_Insert_Reserva
    @dFechaReserva DATETIME,
    @nId_Usuario INT,
    @nId_Libro INT
AS
BEGIN
    INSERT INTO Reservas (dFechaReserva, nId_Usuario, nId_Libro)
    VALUES (@dFechaReserva, @nId_Usuario, @nId_Libro)

    SELECT SCOPE_IDENTITY() -- Retorna el ID de la nueva reserva insertada
END
