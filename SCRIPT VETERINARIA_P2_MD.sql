create database VETERINARIA_P2_MD
USE VETERINARIA_P2_MD
set dateformat dmy

CREATE TABLE tipos 
(id_tipo int identity(1,1),
nombre varchar(20)
CONSTRAINT pk_tipos PRIMARY KEY (id_tipo)
)

CREATE TABLE clientes 
(id_cliente int identity(1,1),
nom_cliente varchar(30),
sexo varchar(1)
CONSTRAINT pk_clientes PRIMARY KEY (id_cliente)
)

CREATE TABLE mascotas 
(id_mascota int identity(1,1),
nom_mascota varchar(30),
fecha_nac datetime , 
id_tipo int,
id_cliente int
CONSTRAINT pk_mascotas PRIMARY KEY (id_mascota),
CONSTRAINT fk_mascotas_clientes  FOREIGN KEY(id_cliente)
          REFERENCES clientes(id_cliente),
CONSTRAINT fk_mascotas_tipos FOREIGN KEY (id_tipo)
          REFERENCES tipos(id_tipo)
)

CREATE TABLE atenciones
(id_atencion int identity(1,1),
fecha datetime,
descripcion varchar(300),
importe decimal,
id_mascota int 
CONSTRAINT pk_atenciones PRIMARY KEY (id_atencion)
CONSTRAINT fk_atenciones_mascotas FOREIGN KEY (id_mascota)
           REFERENCES mascotas (id_mascota)
)

---Insertamos tipos de mascotas---

INSERT INTO tipos(nombre) VALUES ('Perro')
INSERT INTO tipos(nombre) VALUES ('Gato')
INSERT INTO tipos(nombre) VALUES ('Araña')
INSERT INTO tipos(nombre) VALUES ('Iguana')

---insertamos clientes---
INSERT INTO clientes (nom_cliente,sexo) VALUES ('Alberto','M')
INSERT INTO clientes (nom_cliente,sexo) VALUES ('Javier','M')
INSERT INTO clientes (nom_cliente,sexo) VALUES ('Clarisa','F')
INSERT INTO clientes (nom_cliente,sexo) VALUES ('Tomás','M')
INSERT INTO clientes (nom_cliente,sexo) VALUES ('Laura','F')
INSERT INTO clientes (nom_cliente,sexo) VALUES ('Josefina','F')
INSERT INTO clientes (nom_cliente,sexo) VALUES ('Mariano','M')
INSERT INTO clientes (nom_cliente,sexo) VALUES ('Chiara','F')


---Insertamos mascotas---
INSERT INTO mascotas (nom_mascota,fecha_nac,id_cliente,id_tipo) VALUES('bobi','12/05/1999',1 ,4 )
INSERT INTO mascotas (nom_mascota,fecha_nac,id_cliente,id_tipo) VALUES('Mora','02/08/2015',2 ,3 )
INSERT INTO mascotas (nom_mascota,fecha_nac,id_cliente,id_tipo) VALUES('Chanchi','10/02/2006',3 ,2 )
INSERT INTO mascotas (nom_mascota,fecha_nac,id_cliente,id_tipo) VALUES('Rocko','05/11/2003',4 ,1 )
INSERT INTO mascotas (nom_mascota,fecha_nac,id_cliente,id_tipo) VALUES('Moscú','09/02/2019',5 ,4 )
INSERT INTO mascotas (nom_mascota,fecha_nac,id_cliente,id_tipo) VALUES('Copito','13/12/2010',6 ,3 )
INSERT INTO mascotas (nom_mascota,fecha_nac,id_cliente,id_tipo) VALUES('Morena','01/06/2008',7 ,2 )
INSERT INTO mascotas (nom_mascota,fecha_nac,id_cliente,id_tipo) VALUES('Hulk','26/07/2017',8 ,1 )
INSERT INTO mascotas (nom_mascota,fecha_nac,id_cliente,id_tipo) VALUES('Nala','13/06/2021',3 ,1 )
INSERT INTO mascotas (nom_mascota,fecha_nac,id_cliente,id_tipo) VALUES('Byron','14/10/2008',1 ,4 )

---Insertar atenciones---
INSERT INTO atenciones (fecha,descripcion,importe,id_mascota) VALUES ('25/05/2023','Vacunas',5000 , 35 )


---Creacion de procedimientos almacenados---

CREATE PROCEDURE  SP_CONSULTAR_DUEÑOS
AS
BEGIN
SELECT * FROM clientes
END;



CREATE PROCEDURE  SP_CONSULTAR_MASCOTAS
AS
BEGIN
SELECT * FROM mascotas
END;



