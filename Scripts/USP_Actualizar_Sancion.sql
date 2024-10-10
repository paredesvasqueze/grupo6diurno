CREATE PROCEDURE USP_Actualizar_Sancion
    @nId_Sancion INT,
    @nMonto INT,
    @cMotivo NVARCHAR(255),
    @dFechaInicio DATETIME,
    @dFechaFin DATETIME,
    @nIn_Usuario INT
AS
BEGIN
    UPDATE Sanciones
    SET nMonto = @nMonto,
        cMotivo = @cMotivo,
        dFechaInicio = @dFechaInicio,
        dFechaFin = @dFechaFin,
        nIn_Usuario = @nIn_Usuario
    WHERE nId_Sancion = @nId_Sancion
END
