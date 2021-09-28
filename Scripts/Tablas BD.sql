create database AgenciaAutomotriz;

create table Producto(
IdProducto int primary key auto_increment,
CodigoBarras varchar(45) ,
Nombre varchar(45),
Descripcion varchar(45),
Marca varchar(45));

create table Herramientas(
IdHerramienta int primary key auto_increment,
CodigoHerramienta varchar(45),
Nombre varchar(45),
Medida varchar(45),
Marca varchar(45),
Descripcion varchar(45));

create table Usuarios(
IdUsuario int primary key auto_increment,
Nombre varchar(45),
Contrasenia varchar(45),
ApellidoP varchar(45),
ApellidoM varchar(45),
FechaNacimiento varchar(45),
rfc varchar(45),
id_tipo int,
foreign key (id_tipo) references Permisos (id));

create table Permisos(
id int primary key not null auto_increment,
nombre varchar(45));