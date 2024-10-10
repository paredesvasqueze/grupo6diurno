CREATE PROCEDURE USP_GET_Sancion_Todos
AS
BEGIN
    SELECT nId_Sancion, nMonto, cMotivo, dFechaInicio, dFechaFin, nIn_Usuario
    FROM Sanciones
END
