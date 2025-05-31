create database BD_Hospitalsist;

create table tbl_Habitaciones
( CodigoHabitacion int Primary Key identity (1,1)not null,
Numero varchar(10), 
ubicacion varchar(100), TipoHabitacion varchar(50), 
Costo Decimal (10,2), Estado varchar (20),
UsuarioAuditoria varchar(100), FechaAuditoria datetime

);
create table tbl_Pacientes
(
 CodigoPaciente int Primary Key identity (1,1) not null,
 CodigoHabitacion int,
 Foreign Key (CodigoHabitacion ) references tbl_Habitaciones(CodigoHabitacion),
 Nombres Varchar (100), Nit varchar(50), FechaNacimiento datetime,
 TipoPaciente varchar(50), Estado varchar(20), UsuarioAuditoria varchar(100), FechaAuditoria datetime
 
);
create table tbl_Empleados
(
CodigoEmleado int primary key identity (1,1) not null,
Nombres varchar (100), TipoTrabajo varchar (100),
Especialidad varchar (100),  sueldo decimal (10,2),
FechaAlta datetime,
Estado varchar (20), UsuarioAuditoria varchar (100),
FechaAuditoria datetime

);
create table tbl_GestionHabitacion
(
CodigoGestion int primary key identity (1,1) not null,
CodigoEmpleado int,
 Foreign Key (CodigoEmpleado ) references tbl_Empleados(CodigoEmleado),
 CodigoHabitacion int,
  Foreign Key (CodigoHabitacion ) references tbl_Habitaciones(CodigoHabitacion),
  TipoGestion varchar (50), FechaGestion datetime, Estado varchar (20),
  UsuarioAuditoria varchar (100), FechaAuditoria datetime
);
create table tbl_Citas
(
CodigoCitas int primary key identity (1,1) not null,
CodigoPaciente int,
Foreign Key (CodigoPaciente) references tbl_Pacientes(CodigoPaciente),
CodigoEmpleado int,
Foreign Key (CodigoEmpleado) references tbl_Empleados(CodigoEmleado),
FechaIngreso datetime, FechaEgreso datetime,
CostoTratamiento decimal (10,2), CostoHabitacion decimal (10,2),
UsuarioAuditoria varchar (100), FechaAuditoria datetime

);
create table tbl_PagoCitas
(
CodigoPagoCita int primary key identity (1,1) not null,
CodigoCita int,
Foreign Key (CodigoCita) references tbl_Citas(CodigoCitas),
MontoCita decimal (10,2), Impuesto decimal (10,2),
Descuento decimal (10,2), TotalPago decimal (10,2), 
FechaPago datetime, TipoPago varchar (50), 
UsuarioAuditoria varchar (100), FechaAuditoria datetime
);
create table tbl_PagoEmpleados
(
CodigoPago int primary key identity (1,1) not null,
CodigoEmpleado int,
Foreign Key (CodigoEmpleado) references tbl_Empleados(CodigoEmleado),
FechaPago datetime, Sueldo decimal (10,2), 
Bono decimal (10,2), MontoHorasE decimal (10,2),
TotalMonto decimal (10,2), Estado varchar (20),
UsuarioAuditoria varchar (100), FechaAuditoria datetime 
);

create table tbl_Usuarios
(
CodigoUsuario int primary key identity (1,1) not null,
CodigoEmpleado int,
Foreign Key (CodigoEmpleado) references tbl_Empleados(CodigoEmleado),
Usuario varchar (50), Clave varchar (256),
TipoUsuario varchar (20), Estado varchar (20), 
UsuarioAuditoria varchar (100), FechaAuditoria datetime 
);
create table tbl_Medicamentos
(
CodigoMedicamento int primary key identity (1,1) not null,
Nombre varchar (100), TipoMedicamento varchar (100), 
Costo decimal (10,2), Stock int,
FechaVencimiento datetime, Estado varchar (20), 
UsuarioAuditoria varchar (100),FechaAuditoria datetime
);

create table tbl_Tratamientos
(
CodigoTratamiento int primary key identity (1,1) not null,
CodigoCita int,
Foreign Key (CodigoCita) references tbl_Citas(CodigoCitas),
CodigoMedicamento int,
Foreign Key (CodigoMedicamento) references tbl_Medicamentos(CodigoMedicamento),
Costo decimal (10,2), FechaTratamiento datetime, 
Estado varchar (20), UsuarioAuditoria varchar (100),
FechaAuditoria datetime

);

SELECT*FROM tbl_Habitaciones
Select*from tbl_Pacientes
select*from tbl_GestionHabitacion

