CREATE DATABASE ProyectoTienda;
USE ProyectoTienda;

CREATE TABLE productos (
idP INT PRIMARY KEY AUTO_INCREMENT,
codigoBarras INT(11) NOT NULL,
nombre VARCHAR(255) NOT NULL,
descripcion VARCHAR(255),
precio DOUBLE NOT NULL
);

INSERT INTO productos VALUES
(NULL, 10000000001, 'Coca Cola', 'Bebida de Cola', 19.99),
(NULL, 10000000002, 'Pepsi', 'Bebida de Cola', 18.99),
(NULL, 10000000003, 'Laptop', 'Bebida de Cola', 19999.99),
(NULL, 10000000004, 'Doritos', 'Bebida de Cola', 18.99),
(NULL, 10000000005, 'Cheetos', 'Bebida de Cola', 13.99);