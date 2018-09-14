CREATE SCHEMA INVENTARIO;

CREATE TABLE INVENTARIO.INGRESOCOMPUTADORES(
SECUENCIAL INT NOT NULL IDENTITY PRIMARY KEY,
CODIGOINTERNO VARCHAR(20) NOT NULL,
CUADADDEUBICACION VARCHAR(20) NOT NULL,
DESCRIPCION VARCHAR(20) NOT NULL,
MEMORIARAM INT NOT NULL,
PROCESADOR VARCHAR(40) NOT NULL,
DISCODURO FLOAT(5) NOT NULL,
LICENCIADO BIT NOT NULL,
OFFICE BIT NOT NULL,
MARCA VARCHAR(15) NOT NULL,
MODELO VARCHAR(20) NOT NULL,
SERIE VARCHAR(30) NOT NULL,
PARTICULARIDAD VARCHAR(30) NOT NULL,
ESTADO BIT NOT NULL,
NODEFACTURA FLOAT(10) NOT NULL,
VALORFACTURA FLOAT(7) NOT NULL,
FECHAADQUISICION DATE NOT NULL,
OBSERVACIONES VARCHAR(100) NOT NULL
);

CREATE TABLE INVENTARIO.INGRESOVARIOS(
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
VALORFACTURA FLOAT(7) NOT NULL,
FECHAADQUISICION DATE NOT NULL,
OBSERVACIONES VARCHAR(100) NOT NULL
);

CREATE TABLE INVENTARIO.ASIGNACIONCOMPUTADORES(
SECUENCIAL INT NOT NULL IDENTITY PRIMARY KEY,
RESPONSABLE VARCHAR(40) NOT NULL,
SECUANCIALPERSONA INT NOT NULL,
SECUANCIALINGRESOCOMPUTADORES INT NOT NULL,
TIEMPOINICIO DATE NOT NULL,
TIEMPOFIN DATE NOT NULL
);

CREATE TABLE INVENTARIO.ASIGNACIONVARIOS(
SECUENCIAL INT NOT NULL IDENTITY PRIMARY KEY,
RESPONSABLE VARCHAR(40) NOT NULL,
SECUANCIALPERSONA INT NOT NULL,
SECUANCIALINGRESOVARIOS INT NOT NULL,
TIEMPOINICIO DATE NOT NULL,
TIEMPOFIN DATE NOT NULL
);

CREATE TABLE INVENTARIO.BAJADEEQUIPOSCOMPUTADORES(
SECUENCIAL INT NOT NULL IDENTITY PRIMARY KEY,
TIPO VARCHAR(20) NOT NULL,
SECUANCIALPERSONA INT NOT NULL,
SECUANCIALINGRESOCOMPUTADORES INT NOT NULL,
);

CREATE TABLE INVENTARIO.BAJADEEQUIPOSVARIOS(
SECUENCIAL INT NOT NULL IDENTITY PRIMARY KEY,
TIPO VARCHAR(20) NOT NULL,
SECUANCIALPERSONA INT NOT NULL,
SECUANCIALINGRESOVARIOS INT NOT NULL,
);

CREATE TABLE INVENTARIO.MANTENIMIENTOCOMPUTADORES(
SECUENCIAL INT NOT NULL IDENTITY PRIMARY KEY,
TIPO VARCHAR(20) NOT NULL,
SECUANCIALPERSONA INT NOT NULL,
SECUANCIALINGRESOCOMPUTADORES INT NOT NULL,
);

CREATE TABLE INVENTARIO.MANTENIMIENTOVARIOS(
SECUENCIAL INT NOT NULL IDENTITY PRIMARY KEY,
TIPO VARCHAR(20) NOT NULL,
SECUANCIALPERSONA INT NOT NULL,
SECUANCIALINGRESOVARIOS INT NOT NULL,
);

CREATE TABLE INVENTARIO.ITEM(
SECUENCIAL INT NOT NULL IDENTITY PRIMARY KEY,
CODIGO VARCHAR(20) NOT NULL,
TIPOITEM VARCHAR(30) NOT NULL,
CATEGORIAITEM VARCHAR(20) NOT NULL
);

CREATE TABLE INVENTARIO.SOLICITUD(
SECUENCIAL INT NOT NULL IDENTITY PRIMARY KEY,
TIEMPO VARCHAR(20) NOT NULL,
TIPO VARCHAR(30) NOT NULL,
TIEMPOINICIO DATE NOT NULL,
TIEMPOFIN DATE NOT NULL,
DETALLE VARCHAR(50) NOT NULL
);

CREATE TABLE INVENTARIO.ESTADOSOLICITUD(
SECUENCIAL INT NOT NULL IDENTITY PRIMARY KEY,
SECUANCIALSOLICITUD INT NOT NULL,
ESTADO BIT NOT NULL
);

CREATE TABLE INVENTARIO.DEBOLUCIONEQUIPO(
SECUENCIAL INT NOT NULL IDENTITY PRIMARY KEY,
TIPO VARCHAR(30) NOT NULL,
TIEMPOENTREGA DATE NOT NULL,
DETALLE VARCHAR(50) NOT NULL
);