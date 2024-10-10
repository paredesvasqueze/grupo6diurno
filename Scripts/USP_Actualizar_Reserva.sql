CREATE PROCEDURE USP_Actualizar_Reserva
    @nId_Reserva INT,
    @dFechaReserva DATETIME,
    @nId_Usuario INT,
    @nId_Libro INT
AS
BEGIN
    UPDATE Reservas
    SET dFechaReserva = @dFechaReserva,
        nId_Usuario = @nId_Usuario,
        nId_Libro = @nId_Libro
    WHERE nId_Reserva = @nId_Reserva
END
