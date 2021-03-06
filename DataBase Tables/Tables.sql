CREATE SCHEMA INVENTARIO;

CREATE TABLE INVENTARIO.ingresoComputadores(
SECUENCIAL INT NOT NULL IDENTITY PRIMARY KEY,
CODIGOINTERNO VARCHAR(20) NOT NULL,
CUADADDEUBICACION VARCHAR(20) NOT NULL,
DESCRIPCION VARCHAR(20) NOT NULL,
MEMORIARAM INT NOT NULL,
PROCESADOR VARCHAR(40) NOT NULL,
DISCODURO INT NOT NULL,
LICENCIADO BIT NOT NULL,
OFFICE BIT NOT NULL,
MARCA VARCHAR(15) NOT NULL,
MODELO VARCHAR(20) NOT NULL,
SERIE VARCHAR(30) NOT NULL,
PARTICULARIDAD VARCHAR(30) NOT NULL,
ESTADO BIT NOT NULL,
NODEFACTURA INT NOT NULL,
VALORFACTURA INT NOT NULL,
FECHAADQUISICION DATE NOT NULL,
OBSERVACIONES VARCHAR(100) NOT NULL
);

CREATE TABLE INVENTARIO.ingresoVarios(
SECUENCIAL INT NOT NULL IDENTITY PRIMARY KEY,
CODIGOINTERNO VARCHAR(20) NOT NULL,
CUADADDEUBICACION VARCHAR(20) NOT NULL,
DESCRIPCION VARCHAR(20) NOT NULL,
MARCA VARCHAR(15) NOT NULL,
MODELO VARCHAR(20) NOT NULL,
SERIE VARCHAR(30) NOT NULL,
PARTICULARIDAD VARCHAR(30) NOT NULL,
ESTADO BIT NOT NULL,
NODEFACTURA INT NOT NULL,
VALORFACTURA INT NOT NULL,
FECHAADQUISICION DATE NOT NULL,
OBSERVACIONES VARCHAR(100) NOT NULL
);

CREATE TABLE INVENTARIO.asignacionComputadores(
SECUENCIAL INT NOT NULL IDENTITY PRIMARY KEY,
RESPONSABLE VARCHAR(40) NOT NULL,
CODIGOINTERNO VARCHAR(20) NOT NULL,
TIEMPOINICIO DATE NOT NULL,
TIEMPOFIN DATE NOT NULL
);

CREATE TABLE INVENTARIO.asignacionVarios(
SECUENCIAL INT NOT NULL IDENTITY PRIMARY KEY,
RESPONSABLE VARCHAR(40) NOT NULL,
CODIGOINTERNO VARCHAR(20) NOT NULL,
TIEMPOINICIO DATE NOT NULL,
TIEMPOFIN DATE NOT NULL
);

CREATE TABLE INVENTARIO.bajaComputadores(
SECUENCIAL INT NOT NULL IDENTITY PRIMARY KEY,
TIPO VARCHAR(20) NOT NULL,
RESPONSABLE VARCHAR(30) NOT NULL,
CODIGOINTERNO VARCHAR(20) NOT NULL,
);

CREATE TABLE INVENTARIO.bajaVarios(
SECUENCIAL INT NOT NULL IDENTITY PRIMARY KEY,
TIPO VARCHAR(20) NOT NULL,
RESPONSABLE VARCHAR(30) NOT NULL,
CODIGOINTERNO VARCHAR(20) NOT NULL,
);

CREATE TABLE INVENTARIO.mantenimientoComputadores(
SECUENCIAL INT NOT NULL IDENTITY PRIMARY KEY,
TIPO VARCHAR(20) NOT NULL,
RESPONSABLE VARCHAR(30) NOT NULL,
CODIGOINTERNO VARCHAR(20) NOT NULL,
);

CREATE TABLE INVENTARIO.mantenimientoVarios(
SECUENCIAL INT NOT NULL IDENTITY PRIMARY KEY,
TIPO VARCHAR(20) NOT NULL,
RESPONSABLE VARCHAR(30) NOT NULL,
CODIGOINTERNO VARCHAR(20) NOT NULL,
);

CREATE TABLE INVENTARIO.item(
SECUENCIAL INT NOT NULL IDENTITY PRIMARY KEY,
CODIGO VARCHAR(20) NOT NULL,
TIPOITEM VARCHAR(30) NOT NULL,
CATEGORIAITEM VARCHAR(20) NOT NULL
);