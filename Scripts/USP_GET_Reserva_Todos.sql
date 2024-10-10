CREATE PROCEDURE USP_GET_Reserva_Todos
AS
BEGIN
    SELECT nId_Reserva, dFechaReserva, nId_Usuario, nId_Libro
    FROM Reservas
END
