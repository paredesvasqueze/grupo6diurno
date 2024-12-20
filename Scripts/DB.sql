USE [Biblioteca]
GO
/****** Object:  Table [dbo].[Autor]    Script Date: 5/12/2024 09:37:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Autor](
	[nId_Autor] [int] IDENTITY(1,1) NOT NULL,
	[cNombre] [varchar](250) NULL,
	[cNacionalidad] [varchar](150) NULL,
	[dFechaNacimiento] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[nId_Autor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comentario]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comentario](
	[nId_Comentario] [int] IDENTITY(1,1) NOT NULL,
	[cComentario] [varchar](2500) NULL,
	[dFecha] [date] NULL,
	[nId_Usuario] [int] NULL,
	[nId_Libro] [int] NULL,
	[nPuntuacion] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[nId_Comentario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genero]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genero](
	[nId_Genero] [int] IDENTITY(1,1) NOT NULL,
	[cNombreGenero] [varchar](80) NULL,
PRIMARY KEY CLUSTERED 
(
	[nId_Genero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Libro]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Libro](
	[nId_Libro] [int] IDENTITY(1,1) NOT NULL,
	[cTitulo] [varchar](500) NULL,
	[dAnio] [int] NULL,
	[nId_Autor] [int] NULL,
	[nId_Genero] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[nId_Libro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prestamo]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prestamo](
	[nId_Prestamo] [int] IDENTITY(1,1) NOT NULL,
	[dFechaPrestamo] [date] NULL,
	[dFechaDevolucion] [date] NULL,
	[nId_Usuario] [int] NULL,
	[nId_Libro] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[nId_Prestamo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[nId_Reserva] [int] IDENTITY(1,1) NOT NULL,
	[dFechaReserva] [date] NULL,
	[nId_Usuario] [int] NULL,
	[nId_Libro] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[nId_Reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sancion]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sancion](
	[nId_Sancion] [int] IDENTITY(1,1) NOT NULL,
	[nMonto] [decimal](10, 2) NULL,
	[cMotivo] [varchar](1000) NULL,
	[dFechaInicio] [date] NULL,
	[dFechaFin] [date] NULL,
	[nId_Usuario] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[nId_Sancion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usser]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usser](
	[nIdUsser] [int] IDENTITY(1,1) NOT NULL,
	[cUserName] [varchar](50) NULL,
	[cPassword] [varchar](256) NULL,
PRIMARY KEY CLUSTERED 
(
	[nIdUsser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[nId_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[cNombre] [varchar](150) NULL,
	[cCorreo] [varchar](250) NULL,
	[cTelefono] [varchar](15) NULL,
	[cDocumentoIdentidad] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[nId_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Comentario]  WITH CHECK ADD FOREIGN KEY([nId_Libro])
REFERENCES [dbo].[Libro] ([nId_Libro])
GO
ALTER TABLE [dbo].[Comentario]  WITH CHECK ADD FOREIGN KEY([nId_Usuario])
REFERENCES [dbo].[Usuario] ([nId_Usuario])
GO
ALTER TABLE [dbo].[Libro]  WITH CHECK ADD FOREIGN KEY([nId_Autor])
REFERENCES [dbo].[Autor] ([nId_Autor])
GO
ALTER TABLE [dbo].[Libro]  WITH CHECK ADD FOREIGN KEY([nId_Genero])
REFERENCES [dbo].[Genero] ([nId_Genero])
GO
ALTER TABLE [dbo].[Prestamo]  WITH CHECK ADD FOREIGN KEY([nId_Libro])
REFERENCES [dbo].[Libro] ([nId_Libro])
GO
ALTER TABLE [dbo].[Prestamo]  WITH CHECK ADD FOREIGN KEY([nId_Usuario])
REFERENCES [dbo].[Usuario] ([nId_Usuario])
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD FOREIGN KEY([nId_Libro])
REFERENCES [dbo].[Libro] ([nId_Libro])
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD FOREIGN KEY([nId_Usuario])
REFERENCES [dbo].[Usuario] ([nId_Usuario])
GO
ALTER TABLE [dbo].[Sancion]  WITH CHECK ADD FOREIGN KEY([nId_Usuario])
REFERENCES [dbo].[Usuario] ([nId_Usuario])
GO
/****** Object:  StoredProcedure [dbo].[USP_Actualizar_Autor]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Actualizar_Autor]
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
GO
/****** Object:  StoredProcedure [dbo].[USP_Actualizar_Comentario]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Actualizar_Comentario]
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
GO
/****** Object:  StoredProcedure [dbo].[USP_Actualizar_Genero]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[USP_Actualizar_Genero]
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
GO
/****** Object:  StoredProcedure [dbo].[USP_Actualizar_Libro]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Actualizar_Libro]
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
GO
/****** Object:  StoredProcedure [dbo].[USP_Actualizar_Prestamo]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Actualizar_Prestamo]
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
GO
/****** Object:  StoredProcedure [dbo].[USP_Actualizar_Reserva]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Actualizar_Reserva]
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
GO
/****** Object:  StoredProcedure [dbo].[USP_Actualizar_Sancion]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Actualizar_Sancion]
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
GO
/****** Object:  StoredProcedure [dbo].[USP_Actualizar_Usuario]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Actualizar_Usuario]
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
GO
/****** Object:  StoredProcedure [dbo].[USP_Borrar_Autor]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Borrar_Autor]
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
GO
/****** Object:  StoredProcedure [dbo].[USP_Borrar_Comentario]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Borrar_Comentario]
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
GO
/****** Object:  StoredProcedure [dbo].[USP_Borrar_Genero]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Borrar_Genero]
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
GO
/****** Object:  StoredProcedure [dbo].[USP_Borrar_Libro]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[USP_Borrar_Libro]
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
GO
/****** Object:  StoredProcedure [dbo].[USP_Borrar_Prestamo]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Borrar_Prestamo]
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
GO
/****** Object:  StoredProcedure [dbo].[USP_Borrar_Reserva]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Borrar_Reserva]
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
GO
/****** Object:  StoredProcedure [dbo].[USP_Borrar_Sancion]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Borrar_Sancion]
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
GO
/****** Object:  StoredProcedure [dbo].[USP_Borrar_Usuario]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Borrar_Usuario]
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
GO
/****** Object:  StoredProcedure [dbo].[USP_GET_Autor_Todos]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[USP_GET_Autor_Todos]
as
begin
select * from Autor
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GET_Comentario_Todos]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_GET_Comentario_Todos]
as
begin

select c.*,u.cNombre as cNombreUsuario,
l.cTitulo as cTitulo
from Comentario c
inner join usuario u on c.nId_Usuario = u.nId_Usuario
inner join libro l on c.nId_Libro = l.nId_Libro
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GET_Genero_Todos]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[USP_GET_Genero_Todos]
as
begin
select * from Genero
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GET_Libro_Todos]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_GET_Libro_Todos]
as
begin
select l.*, a.cNombre as cNombreAutor,
g.cNombreGenero as cNombreGenero
from Libro l
inner join autor a on l.nId_Autor = a.nId_Autor
inner join genero g on l.nId_Genero = g.nId_Genero
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GET_Prestamo_Todos]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_GET_Prestamo_Todos]
as
begin
select p.*,u.cNombre as cNombreUsuario,
l.cTitulo as cTitulo
from Prestamo p
inner join usuario u on p.nId_Usuario = u.nId_Usuario
inner join libro l on p.nId_Libro = l.nId_Libro
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GET_Reserva_Todos]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_GET_Reserva_Todos]
as
begin
select r.*,u.cNombre as cNombreUsuario,
l.cTitulo as cTitulo
from Reserva r
inner join usuario u on r.nId_Usuario = u.nId_Usuario
inner join libro l on r.nId_Libro = l.nId_Libro
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GET_Sancion_Todos]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_GET_Sancion_Todos]
as
begin
select s.*,u.cNombre as cNombreUsuario
from Sancion s
inner join Usuario u on s.nId_Usuario = u.nId_Usuario
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GET_Usuario_Todos]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[USP_GET_Usuario_Todos]
as
begin
select * from Usuario
end
-----
GO
/****** Object:  StoredProcedure [dbo].[USP_Insert_Autor]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[USP_Insert_Autor]
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
GO
/****** Object:  StoredProcedure [dbo].[USP_Insert_Comentario]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Insert_Comentario]
    @cComentario NVARCHAR(MAX),
    @dFecha DATETIME,
    @nId_Usuario INT,
    @nId_Libro INT,
    @nPuntuacion INT
AS
BEGIN
    INSERT INTO Comentario (cComentario, dFecha, nId_Usuario, nId_Libro, nPuntuacion)
    VALUES (@cComentario, @dFecha, @nId_Usuario, @nId_Libro, @nPuntuacion)

    SELECT cast( SCOPE_IDENTITY() as int)
END
GO
/****** Object:  StoredProcedure [dbo].[USP_Insert_Genero]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Insert_Genero]
    @cNombreGenero VARCHAR(100)
AS
BEGIN
    INSERT INTO Genero (cNombreGenero)
    VALUES (@cNombreGenero);
	select cast(SCOPE_IDENTITY() as int)
END
GO
/****** Object:  StoredProcedure [dbo].[USP_Insert_Libro]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[USP_Insert_Libro]
@cTitulo varchar(255),
@dAnio int,
@nId_Autor int,
@nId_Genero int
as
begin
Insert into Libro
(cTitulo, dAnio, nId_Autor, nId_Genero)
values (@cTitulo, @dAnio, @nId_Autor, @nId_Genero);
select cast(SCOPE_IDENTITY() as int)
end
GO
/****** Object:  StoredProcedure [dbo].[USP_Insert_Prestamo]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Insert_Prestamo]
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
GO
/****** Object:  StoredProcedure [dbo].[USP_Insert_Reserva]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Insert_Reserva]
    @dFechaReserva DATETIME,
    @nId_Usuario INT,
    @nId_Libro INT
AS
BEGIN
    INSERT INTO Reserva (dFechaReserva, nId_Usuario, nId_Libro)
    VALUES (@dFechaReserva, @nId_Usuario, @nId_Libro)

    SELECT cast( SCOPE_IDENTITY() as int)
END
GO
/****** Object:  StoredProcedure [dbo].[USP_Insert_Sancion]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Insert_Sancion]
    @nMonto INT,
    @cMotivo NVARCHAR(255),
    @dFechaInicio DATETIME,
    @dFechaFin DATETIME,
    @nId_Usuario INT
AS
BEGIN
    INSERT INTO Sancion (nMonto, cMotivo, dFechaInicio, dFechaFin, nId_Usuario)
    VALUES (@nMonto, @cMotivo, @dFechaInicio, @dFechaFin, @nId_Usuario)

   SELECT cast( SCOPE_IDENTITY() as int)
END
GO
/****** Object:  StoredProcedure [dbo].[USP_Insert_Usuario]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Insert_Usuario]
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
GO
/****** Object:  StoredProcedure [dbo].[ValidarUsuario]    Script Date: 5/12/2024 09:37:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ValidarUsuario]
@cUserName varchar(50),
@cPassword varchar(256)
as
begin
if exists(select * from usser where cUserName = @cUserName
and cPassword = @cPassword)
	begin
	select cast(1 as bit)
	end
else
	begin
	select cast (0 as bit)
	end
end
GO
