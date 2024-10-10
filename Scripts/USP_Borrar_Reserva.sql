CREATE PROCEDURE USP_Borrar_Reserva
    @nId_Reserva INT
AS
BEGIN
    DELETE FROM Reservas
    WHERE nId_Reserva = @nId_Reserva
END
