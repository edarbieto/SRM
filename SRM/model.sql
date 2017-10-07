-- Create schemas

-- Create tables
IF (NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'alumno'))
BEGIN
  CREATE TABLE alumno
  (
    codigo VARCHAR(10) NOT NULL,
    nombre VARCHAR(30),
    apellido VARCHAR(30),
    sexo VARCHAR(1),
    periodoingreso VARCHAR(6),
    dni VARCHAR(8),
    carrera VARCHAR(30),
    fechanacimiento VARCHAR(10),
    direccion VARCHAR(50),
    creditostotales INT,
    creditosmatriculados INT,
    PRIMARY KEY(codigo)
  )
END;

IF (NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'docente'))
BEGIN
  CREATE TABLE docente
  (
    codigo VARCHAR(7) NOT NULL,
    nombre VARCHAR(30),
    apellido VARCHAR(30),
    dni VARCHAR(8),
    fechanacimiento VARCHAR(10),
    descripcion VARCHAR(200),
    direccion VARCHAR(50),
    carrera VARCHAR(30),
    contrato VARCHAR(2),
    PRIMARY KEY(codigo)
  )
END;

IF (NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'curso'))
BEGIN
  CREATE TABLE curso
  (
    codigo VARCHAR(5) NOT NULL,
    nombre VARCHAR(40),
    descripcion VARCHAR(30),
    carrera VARCHAR(30),
    creditaje INT,
    PRIMARY KEY(codigo)
  )
END;

IF (NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'seccion'))
BEGIN
  CREATE TABLE seccion
  (
    codigo VARCHAR(4) NOT NULL,
    sede VARCHAR(15),
    modalidad VARCHAR(15),
    periodo VARCHAR(6),
    codigocurso VARCHAR(5),
    codigodocente VARCHAR(7),
    dia VARCHAR(10),
    horainicio INT,
    horafinal INT,
    aula VARCHAR(4),
    PRIMARY KEY(codigo)
  )
END;

IF (NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'usuario'))
BEGIN
  CREATE TABLE usuario
  (
    codigo VARCHAR(9) NOT NULL,
    username VARCHAR(20),
    password VARCHAR(20),
    nombre VARCHAR(40),
    PRIMARY KEY(codigo)
  )
END;

IF (NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'matricula'))
BEGIN
  CREATE TABLE matricula
  (
    codigo INT NOT NULL,
    codigoalumno VARCHAR(10),
    codigoseccion VARCHAR(4),
    codigousuario VARCHAR(9),
    PRIMARY KEY(codigo)
  )
END;


-- Create FKs
ALTER TABLE seccion
    ADD    FOREIGN KEY (codigodocente)
    REFERENCES docente(codigo)
;
    
ALTER TABLE seccion
    ADD    FOREIGN KEY (codigocurso)
    REFERENCES curso(codigo)
;
    
ALTER TABLE matricula
    ADD    FOREIGN KEY (codigoalumno)
    REFERENCES alumno(codigo)
;
    
ALTER TABLE matricula
    ADD    FOREIGN KEY (codigoseccion)
    REFERENCES seccion(codigo)
;
    
ALTER TABLE matricula
    ADD    FOREIGN KEY (codigousuario)
    REFERENCES usuario(codigo)
;
    

-- Create Indexes

