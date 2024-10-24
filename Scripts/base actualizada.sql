CREATE DATABASE Biblioteca;

USE Biblioteca;

CREATE TABLE Usuario (
    nId_Usuario INT PRIMARY KEY IDENTITY(1,1),
    cNombre VARCHAR(150),
    cCorreo VARCHAR(250),
    cTelefono VARCHAR(15),
    cDocumentoIdentidad VARCHAR(25)
);

CREATE TABLE Autor (
    nId_Autor INT PRIMARY KEY IDENTITY(1,1),
    cNombre VARCHAR(250),
    cNacionalidad VARCHAR(150),
    dFechaNacimiento DATE
);

CREATE TABLE Genero (
    nId_Genero INT PRIMARY KEY IDENTITY(1,1),
    cNombreGenero VARCHAR(80)
);

CREATE TABLE Libro (
    nId_Libro INT PRIMARY KEY IDENTITY(1,1),
    cTitulo VARCHAR(500),
    dAnio INT,
    nId_Autor INT,
    nId_Genero INT,
    FOREIGN KEY (nId_Autor) REFERENCES Autor(nId_Autor),
    FOREIGN KEY (nId_Genero) REFERENCES Genero(nId_Genero)
);

CREATE TABLE Prestamo (
    nId_Prestamo INT PRIMARY KEY IDENTITY(1,1),
    dFechaPrestamo DATE,
    dFechaDevolucion DATE,
    nId_Usuario INT,
    nId_Libro INT,
    FOREIGN KEY (nId_Usuario) REFERENCES Usuario(nId_Usuario),
    FOREIGN KEY (nId_Libro) REFERENCES Libro(nId_Libro)
);

CREATE TABLE Reserva (
    nId_Reserva INT PRIMARY KEY IDENTITY(1,1),
    dFechaReserva DATE,
    nId_Usuario INT,
    nId_Libro INT,
    FOREIGN KEY (nId_Usuario) REFERENCES Usuario(nId_Usuario),
    FOREIGN KEY (nId_Libro) REFERENCES Libro(nId_Libro)
);

CREATE TABLE Sancion (
    nId_Sancion INT PRIMARY KEY IDENTITY(1,1),
    nMonto DECIMAL(10, 2),
    cMotivo VARCHAR(1000),
    dFechaInicio DATE,
    dFechaFin DATE,
    nId_Usuario INT,
    FOREIGN KEY (nId_Usuario) REFERENCES Usuario(nId_Usuario)
);

CREATE TABLE Comentario (
    nId_Comentario INT PRIMARY KEY IDENTITY(1,1),
    cComentario VARCHAR(2500),
    dFecha DATE,
    nId_Usuario INT,
    nId_Libro INT,
    nPuntuacion INT,
    FOREIGN KEY (nId_Usuario) REFERENCES Usuario(nId_Usuario),
    FOREIGN KEY (nId_Libro) REFERENCES Libro(nId_Libro)
);