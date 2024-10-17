CREATE PROCEDURE USP_Borrar_Genero
    @nId_Genero INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        DELETE FROM Genero
        WHERE nId_Genero = @nId_Genero;

        -- Retorna el número de filas afectadas
        SELECT @@ROWCOUNT AS FilasAfectadas;

    END TRY
    BEGIN CATCH
        -- Manejo de errores
        SELECT 
            ERROR_NUMBER() AS ErrorNumero,
            ERROR_MESSAGE() AS MensajeError;
    END CATCH
END
------------------------------------------------------
CREATE PROCEDURE USP_Borrar_Usuario
    @nId_Usuario INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        DELETE FROM Usuario
        WHERE nId_Usuario = @nId_Usuario;

        -- Retorna el número de filas afectadas
        SELECT @@ROWCOUNT AS FilasAfectadas;

    END TRY
    BEGIN CATCH
        -- Manejo de errores
        SELECT 
            ERROR_NUMBER() AS ErrorNumero,
            ERROR_MESSAGE() AS MensajeError;
    END CATCH
END
------------------------------------------------------
CREATE PROCEDURE USP_Borrar_Sancion
    @nId_Sancion INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        DELETE FROM Sancion
        WHERE nId_Sancion = @nId_Sancion;

        -- Retorna el número de filas afectadas
        SELECT @@ROWCOUNT AS FilasAfectadas;

    END TRY
    BEGIN CATCH
        -- Manejo de errores
        SELECT 
            ERROR_NUMBER() AS ErrorNumero,
            ERROR_MESSAGE() AS MensajeError;
    END CATCH
END
------------------------------------------------------
CREATE PROCEDURE USP_Borrar_Reserva
    @nId_Reserva INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        DELETE FROM Reserva
        WHERE nId_Reserva = @nId_Reserva;

        -- Retorna el número de filas afectadas
        SELECT @@ROWCOUNT AS FilasAfectadas;

    END TRY
    BEGIN CATCH
        -- Manejo de errores
        SELECT 
            ERROR_NUMBER() AS ErrorNumero,
            ERROR_MESSAGE() AS MensajeError;
    END CATCH
END
------------------------------------------------------
CREATE PROCEDURE USP_Borrar_Comentario
    @nId_Comentario INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        DELETE FROM Comentario
        WHERE nId_Comentario = @nId_Comentario;

        -- Retorna el número de filas afectadas
        SELECT @@ROWCOUNT AS FilasAfectadas;

    END TRY
    BEGIN CATCH
        -- Manejo de errores
        SELECT 
            ERROR_NUMBER() AS ErrorNumero,
            ERROR_MESSAGE() AS MensajeError;
    END CATCH
END
------------------------------------------------------
CREATE PROCEDURE USP_Borrar_Autor
    @nId_Autor INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        DELETE FROM Autor
        WHERE nId_Autor = @nId_Autor;

        -- Retorna el número de filas afectadas
        SELECT @@ROWCOUNT AS FilasAfectadas;

    END TRY
    BEGIN CATCH
        -- Manejo de errores
        SELECT 
            ERROR_NUMBER() AS ErrorNumero,
            ERROR_MESSAGE() AS MensajeError;
    END CATCH
END
------------------------------------------------------
CREATE PROCEDURE USP_Eliminar_Libro
    @nId_Libro INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        DELETE FROM Libro
        WHERE nId_Libro = @nId_Libro;

        -- Retorna el número de filas afectadas
        SELECT @@ROWCOUNT AS FilasAfectadas;

    END TRY
    BEGIN CATCH
        -- Manejo de errores
        SELECT 
            ERROR_NUMBER() AS ErrorNumero,
            ERROR_MESSAGE() AS MensajeError;
    END CATCH
END
------------------------------------------------------
CREATE PROCEDURE USP_Eliminar_Prestamo
    @nId_Prestamo INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        DELETE FROM Prestamo
        WHERE nId_Prestamo = @nId_Prestamo;

        -- Retorna el número de filas afectadas
        SELECT @@ROWCOUNT AS FilasAfectadas;

    END TRY
    BEGIN CATCH
        -- Manejo de errores
        SELECT 
            ERROR_NUMBER() AS ErrorNumero,
            ERROR_MESSAGE() AS MensajeError;
    END CATCH
END
------------------------------------------------------
CREATE PROCEDURE USP_Actualizar_Prestamo
    @nId_Prestamo INT,
    @dFechaPrestamo DATE,
    @dFechaDevolucion DATE,
    @nId_Usuario INT,
    @nId_Libro INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        UPDATE Prestamo
        SET 
            dFechaPrestamo = @dFechaPrestamo,
            dFechaDevolucion = @dFechaDevolucion,
            nId_Usuario = @nId_Usuario,
            nId_Libro = @nId_Libro
        WHERE 
            nId_Prestamo = @nId_Prestamo;

        SELECT @@ROWCOUNT AS FilasAfectadas;

    END TRY
    BEGIN CATCH
        SELECT 
            ERROR_NUMBER() AS ErrorNumero,
            ERROR_MESSAGE() AS MensajeError;
    END CATCH
END
------------------------------------------------------
CREATE PROCEDURE USP_Actualizar_Usuario
    @nId_Usuario INT,
    @cNombre NVARCHAR(255),
    @cCorreo NVARCHAR(255),
    @cTelefono NVARCHAR(50),
    @cDocumentoIdentidad NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        UPDATE Usuario
        SET 
            cNombre = @cNombre,
            cCorreo = @cCorreo,
            cTelefono = @cTelefono,
            cDocumentoIdentidad = @cDocumentoIdentidad
        WHERE 
            nId_Usuario = @nId_Usuario;

        -- Retorna el número de filas afectadas
        SELECT @@ROWCOUNT AS FilasAfectadas;

    END TRY
    BEGIN CATCH
        -- Manejo de errores
        SELECT 
            ERROR_NUMBER() AS ErrorNumero,
            ERROR_MESSAGE() AS MensajeError;
    END CATCH
END
------------------------------------------------------
CREATE PROCEDURE USP_Actualizar_Sancion
    @nId_Sancion INT,
    @nMonto INT,
    @cMotivo NVARCHAR(255),
    @dFechaInicio DATETIME,
    @dFechaFin DATETIME,
    @nIn_Usuario INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        UPDATE Sancione
        SET 
            nMonto = @nMonto,
            cMotivo = @cMotivo,
            dFechaInicio = @dFechaInicio,
            dFechaFin = @dFechaFin,
            nIn_Usuario = @nIn_Usuario
        WHERE 
            nId_Sancion = @nId_Sancion;

        -- Retorna el número de filas afectadas
        SELECT @@ROWCOUNT AS FilasAfectadas;

    END TRY
    BEGIN CATCH
        -- Manejo de errores
        SELECT 
            ERROR_NUMBER() AS ErrorNumero,
            ERROR_MESSAGE() AS MensajeError;
    END CATCH
END
------------------------------------------------------
CREATE PROCEDURE USP_Actualizar_Reserva
    @nId_Reserva INT,
    @dFechaReserva DATETIME,
    @nId_Usuario INT,
    @nId_Libro INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        UPDATE Reserva
        SET 
            dFechaReserva = @dFechaReserva,
            nId_Usuario = @nId_Usuario,
            nId_Libro = @nId_Libro
        WHERE 
            nId_Reserva = @nId_Reserva;

        -- Retorna el número de filas afectadas
        SELECT @@ROWCOUNT AS FilasAfectadas;

    END TRY
    BEGIN CATCH
        -- Manejo de errores
        SELECT 
            ERROR_NUMBER() AS ErrorNumero,
            ERROR_MESSAGE() AS MensajeError;
    END CATCH
END
------------------------------------------------------
CREATE PROCEDURE USP_Actualizar_Libro
    @nId_Libro INT,
    @cTitulo VARCHAR(255),
    @dAnio INT,
    @nId_Autor INT,
    @nId_Genero INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        UPDATE Libro
        SET 
            cTitulo = @cTitulo,
            dAnio = @dAnio,
            nId_Autor = @nId_Autor,
            nId_Genero = @nId_Genero
        WHERE 
            nId_Libro = @nId_Libro;

        -- Retorna el número de filas afectadas
        SELECT @@ROWCOUNT AS FilasAfectadas;

    END TRY
    BEGIN CATCH
        -- Manejo de errores
        SELECT 
            ERROR_NUMBER() AS ErrorNumero,
            ERROR_MESSAGE() AS MensajeError;
    END CATCH
END
------------------------------------------------------
create PROCEDURE USP_Actualizar_Genero
    @nId_Genero INT,
    @cNombreGenero VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        UPDATE Genero
        SET cNombreGenero = @cNombreGenero
        WHERE nId_Genero = @nId_Genero;

        -- Retorna el número de filas afectadas
        SELECT @@ROWCOUNT AS FilasAfectadas;

    END TRY
    BEGIN CATCH
        -- Manejo de errores
        SELECT 
            ERROR_NUMBER() AS ErrorNumero,
            ERROR_MESSAGE() AS MensajeError;
    END CATCH
END
------------------------------------------------------
CREATE PROCEDURE USP_Actualizar_Comentario
    @nId_Comentario INT,
    @cComentario VARCHAR(2500),
    @dFecha DATETIME,
    @nId_Usuario INT,
    @nId_Libro INT,
    @nPuntuacion INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        UPDATE Comentario
        SET 
            cComentario = @cComentario,
            dFecha = @dFecha,
            nId_Usuario = @nId_Usuario,
            nId_Libro = @nId_Libro,
            nPuntuacion = @nPuntuacion
        WHERE nId_Comentario = @nId_Comentario;

        -- Retorna el número de filas afectadas
        SELECT @@ROWCOUNT AS FilasAfectadas;

    END TRY
    BEGIN CATCH
        -- Manejo de errores
        SELECT 
            ERROR_NUMBER() AS ErrorNumero,
            ERROR_MESSAGE() AS MensajeError;
    END CATCH
END
------------------------------------------------------
CREATE PROCEDURE USP_Actualizar_Autor
    @nId_Autor INT,
    @cNombre VARCHAR(255),
    @cNacionalidad VARCHAR(100),
    @dFechaNacimiento DATETIME
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        UPDATE Autor
        SET
            cNombre = @cNombre,
            cNacionalidad = @cNacionalidad,
            dFechaNacimiento = @dFechaNacimiento
        WHERE nId_Autor = @nId_Autor;

        -- Retorna el número de filas afectadas
        SELECT @@ROWCOUNT AS FilasAfectadas;

    END TRY
    BEGIN CATCH
        -- Manejo de errores
        SELECT 
            ERROR_NUMBER() AS ErrorNumero,
            ERROR_MESSAGE() AS MensajeError;
    END CATCH
END
------------------------------------------------------
create procedure USP_GET_Autor_Todos
as
begin
select * from Autor
end
------------------------------------------------------
create procedure USP_GET_Genero_Todos
as
begin
select * from Genero
end
------------------------------------------------------
create procedure USP_GET_Usuario_Todos
as
begin
select * from Usuario
end
------------------------------------------------------
create procedure USP_GET_Libro_Todos
as
begin
select * from Libro
end
------------------------------------------------------
create procedure USP_GET_Prestamo_Todos
as
begin
select * from Prestamo
end
------------------------------------------------------
create procedure USP_GET_Reserva_Todos
as
begin
select * from Reserva
end
------------------------------------------------------
create procedure USP_GET_Comentario_Todos
as
begin
select * from Comentario
end
------------------------------------------------------
create procedure USP_GET_Sancion_Todos
as
begin
select * from Sancion
end
------------------------------------------------------
create procedure USP_Insert_Autor
@cNombre varchar(255),
@cNacionalidad varchar(100),
@dFechaNacimiento datetime
as
begin
insert into Autor
([cNombre],[cNacionalidad],[dFechaNacimiento])
values
(@cNombre,@cNacionalidad,@dFechaNacimiento)
select cast(SCOPE_IDENTITY() as int)
end
------------------------------------------------------
CREATE PROCEDURE USP_Insert_Comentario
    @cComentario NVARCHAR(MAX),
    @dFecha DATETIME,
    @nId_Usuario INT,
    @nId_Libro INT,
    @nPuntuacion INT
AS
BEGIN
    INSERT INTO Comentario (cComentario, dFecha, nId_Usuario, nId_Libro, nPuntuacion)
    VALUES (@cComentario, @dFecha, @nId_Usuario, @nId_Libro, @nPuntuacion)

    SELECT SCOPE_IDENTITY()
END
------------------------------------------------------
CREATE PROCEDURE USP_Insert_Genero
    @cNombreGenero VARCHAR(100)
AS
BEGIN
    INSERT INTO Genero (cNombreGenero)
    VALUES (@cNombreGenero);
	select cast(SCOPE_IDENTITY() as int)
END
------------------------------------------------------
create procedure USP_Insert_Libro
@nId_Libro int,
@cTitulo varchar(255),
@dAnio int,
@nId_Autor int,
@nId_Genero int
as
begin
Insert into Libro
(nId_Libro, cTitulo, dAnio, nId_Autor, nId_Genero)
values (@nId_Libro, @cTitulo, @dAnio, @nId_Autor, @nId_Genero);
select cast(SCOPE_IDENTITY() as int)
end
------------------------------------------------------
CREATE PROCEDURE USP_Insert_Reserva
    @dFechaReserva DATETIME,
    @nId_Usuario INT,
    @nId_Libro INT
AS
BEGIN
    INSERT INTO Reserva (dFechaReserva, nId_Usuario, nId_Libro)
    VALUES (@dFechaReserva, @nId_Usuario, @nId_Libro)

    SELECT SCOPE_IDENTITY()
END
------------------------------------------------------
CREATE PROCEDURE USP_Insert_Sancion
    @nMonto INT,
    @cMotivo NVARCHAR(255),
    @dFechaInicio DATETIME,
    @dFechaFin DATETIME,
    @nId_Usuario INT
AS
BEGIN
    INSERT INTO Sancion (nMonto, cMotivo, dFechaInicio, dFechaFin, nId_Usuario)
    VALUES (@nMonto, @cMotivo, @dFechaInicio, @dFechaFin, @nId_Usuario)

    SELECT SCOPE_IDENTITY()
END
------------------------------------------------------
CREATE PROCEDURE USP_Insert_Usuario
    @cNombre VARCHAR(150),
    @cCorreo VARCHAR(250),
    @cTelefono VARCHAR(15),
    @cDocumentoIdentidad VARCHAR(25)
AS
BEGIN
    INSERT INTO Usuario
        ([cNombre], [cCorreo], [cTelefono], [cDocumentoIdentidad])
    VALUES
        (@cNombre, @cCorreo, @cTelefono, @cDocumentoIdentidad);
    SELECT CAST(SCOPE_IDENTITY() AS INT);
END
------------------------------------------------------
CREATE PROCEDURE USP_Insert_Prestamo
    @dFechaPrestamo DATE,
    @dFechaDevolucion DATE,
    @nId_Usuario INT,
    @nId_Libro INT
AS
BEGIN
    INSERT INTO Prestamo
        (dFechaPrestamo, dFechaDevolucion, nId_Usuario, nId_Libro)
    VALUES
        (@dFechaPrestamo, @dFechaDevolucion, @nId_Usuario, @nId_Libro);
    SELECT CAST(SCOPE_IDENTITY() AS INT);
END
------------------------------------------------------