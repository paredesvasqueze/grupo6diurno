CREATE PROCEDURE USP_Obtener_Sancion
    @nId_Sancion INT
AS
BEGIN
    SELECT nId_Sancion, nMonto, cMotivo, dFechaInicio, dFechaFin, nIn_Usuario
    FROM Sanciones
    WHERE nId_Sancion = @nId_Sancion
END
