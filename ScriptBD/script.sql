CREATE DATABASE ProyectoTienda;
USE ProyectoTienda;

CREATE TABLE productos (
idP INT PRIMARY KEY AUTO_INCREMENT,
codigoBarras INT(11) NOT NULL,
nombre VARCHAR(255) NOT NULL,
descripcion VARCHAR(255),
precio DOUBLE NOT NULL
);