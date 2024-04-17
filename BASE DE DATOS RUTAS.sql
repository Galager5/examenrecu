create database RUTAS
use RUTAS
CREATE TABLE Clientes (
    ID INT PRIMARY KEY,
    TipoCliente VARCHAR(255),
    Edad INT
);

CREATE TABLE Rutas (
    ID INT PRIMARY KEY,
    NombreRuta VARCHAR(255),
    Precio DECIMAL(5,2)
);

CREATE TABLE Ventas (
    ID INT PRIMARY KEY,
    ClienteID INT FOREIGN KEY REFERENCES Clientes(ID),
    RutaID INT FOREIGN KEY REFERENCES Rutas(ID),
    Cantidad INT,
    Descuento DECIMAL(5,2),
    ImportePago DECIMAL(5,2)
);