CREATE PROCEDURE USP_Insert_Sancion
    @nMonto INT,
    @cMotivo NVARCHAR(255),
    @dFechaInicio DATETIME,
    @dFechaFin DATETIME,
    @nIn_Usuario INT
AS
BEGIN
    INSERT INTO Sanciones (nMonto, cMotivo, dFechaInicio, dFechaFin, nIn_Usuario)
    VALUES (@nMonto, @cMotivo, @dFechaInicio, @dFechaFin, @nIn_Usuario)

    SELECT SCOPE_IDENTITY() -- Retorna el ID de la nueva sanción insertada
END
