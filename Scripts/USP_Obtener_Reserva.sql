CREATE PROCEDURE USP_Obtener_Reserva
    @nId_Reserva INT
AS
BEGIN
    SELECT nId_Reserva, dFechaReserva, nId_Usuario, nId_Libro
    FROM Reservas
    WHERE nId_Reserva = @nId_Reserva
END
