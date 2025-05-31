USE BD_Hospitalsist;
INSERT INTO tbl_Habitaciones (
    Numero, Ubicacion, TipoHabitacion, Costo, Estado, UsuarioAuditoria, FechaAuditoria
)
VALUES
( 12345, 'Lima', 'General', 300.00, 'Disponible', 'Admin', '2025-05-29 00:00:00.000'),
( 64775, 'Amberes', 'Maternidad', 100.00, 'Disponible', 'Admin', '2025-05-29 00:00:00.000'),
( 78615, 'Rincon', 'Pediatra', 500.00, 'Disponible', 'Admin', '2025-05-29 00:00:00.000'),
( 69764, 'Lima', 'Aislamiento', 300.00, 'Bloqueada', 'Admin', '2025-05-29 00:00:00.000'),
( 67662, 'Riachuelo', 'Observacion', 100.00, 'Ocupada', 'Admin', '2025-05-29 00:00:00.000'),
( 63453, 'Culapa', 'General', 100.00, 'Ocupada', 'Admin', '2025-05-29 00:00:00.000'),
( 89272, 'Barberene', 'Maternidad', 500.00, 'Disponible', 'Admin', '2025-05-29 00:00:00.000'),
( 87262, 'Santa Cruz', 'Pediatra', 300.00, 'Bloqueada', 'Admin', '2025-05-29 00:00:00.000'),
( 93726, 'Chapas', 'Observacion', 100.00, 'Preparacion', 'Admin', '2025-05-29 00:00:00.000'),
( 73628, 'Nueva', 'Aislamiento', 300.00, 'Preparacion', 'Admin', '2025-05-29 00:00:00.000');

INSERT INTO tbl_Pacientes (
     CodigoHabitacion, Nombres, Nit, FechaNacimiento, TipoPaciente, Estado, UsuarioAuditoria, FechaAuditoria
)
VALUES
( 5, 'Samanta', 6543, '2005-12-28 00:00:00.000', 'Cita', 'Creada', 'Admin', '2025-05-29 00:00:00.000'),
( 6, 'Joshua', 3726, '2006-04-08 00:00:00.000', 'Emergencia', 'Observacion', 'Admin', '2025-05-29 00:00:00.000'),
( 7, 'Sharahi', 9763, '2018-01-02 00:00:00.000', 'Quirurgicos', 'Aislamiento', 'Admin', '2025-05-29 00:00:00.000'),
( 8, 'Zamanta', 8764, '2019-11-04 00:00:00.000', 'Infeccioso', 'Observacion', 'Admin', '2025-05-29 00:00:00.000'),
( 9, 'Ronal', 2651, '2021-12-12 00:00:00.000', 'Terminal', 'Critico', 'Admin', '2025-05-27 00:00:00.000'),
( 10, 'Nahomy', 8281, '2000-02-19 00:00:00.000', 'Cita', 'Fallecido', 'Admin', '2025-05-29 00:00:00.000'),
( 11, 'Bliezar', 8675, '1999-03-19 00:00:00.000', 'Cita', 'Creada', 'Admin', '2025-05-29 00:00:00.000'),
( 12, 'Oscar', 3625, '1998-04-04 00:00:00.000', 'Emergencia', 'Observacion', 'Admin', '2025-05-29 00:00:00.000'),
( NULL, 'Mayerlin', 7754, '1980-07-06 00:00:00.000', 'Infeccioso', 'Observacion', 'Admin', '2025-05-29 00:00:00.000'),
(NULL, 'Dallane', 6515, '1989-06-09 00:00:00.000', 'Terminal', 'Aislamiento', 'Admin', '2025-05-29 00:00:00.000');

INSERT INTO tbl_Empleados( Nombres, TipoTrabajo, Especialidad, Sueldo, FechaAlta, Estado, UsuarioAuditoria, FechaAuditoria
)
VALUES
( 'Juan Solares', 'Director', 'Administracion', 30000.00, '2025-05-27 00:00:00.000', 'Activo', 'Admin', '2025-05-27 00:00:00.000'),
( 'Maria Paz', 'Medico', 'General', 2000.00, '2025-05-27 00:00:00.000', 'Activo', 'Admin', '2025-05-27 00:00:00.000'),
( 'Yojana Morales', 'Enfermero', 'Asistente', 10000.00, '2025-05-27 00:00:00.000', 'Activo', 'Admin', '2025-05-27 00:00:00.000'),
( 'Juan Samayoa', 'Tecnico', 'Digitador', 7000.00, '2025-05-27 00:00:00.000', 'Activo', 'Admin', '2025-05-27 00:00:00.000'),
( 'Biza Cid', 'Farmaceutico', 'General', 6000.00, '2025-05-27 00:00:00.000', 'Activo', 'Admin', '2025-05-27 00:00:00.000'),
( 'Emilie Yuman', 'Enfermero', 'Asistente', 10000.00, '2025-05-27 00:00:00.000', 'Activa', 'Admin', '2025-05-27 00:00:00.000'),
( 'Dallan Davila', 'Medico', 'General', 2000.00, '2025-05-27 00:00:00.000', 'Activo', 'Admin', '2025-05-27 00:00:00.000'),
( 'Siomar Melendez', 'Director', 'Administracion', 3000.00, '2025-05-27 00:00:00.000', 'Activa', 'Admin', '2025-05-27 00:00:00.000'),
( 'Marcos Monterroso', 'Tecnico', 'Digitador', 7000.00, '2025-05-27 00:00:00.000', 'Activo', 'Admin', '2025-05-27 00:00:00.000'),
( 'Yaneth Monzon', 'Farmaceutico', 'General', 6000.00, '2025-05-27 00:00:00.000', 'Activo', 'Admin', '2025-05-27 00:00:00.000');

INSERT INTO tbl_GestionHabitacion ( CodigoEmpleado, CodigoHabitacion, TipoGestion, FechaGestion, Estado, UsuarioAuditoria, FechaAuditoria) VALUES
( 1, 5, 'Preparacion', '2025-05-28 00:00:00.000', 'Creada', 'Admin', '2025-05-29 00:00:00.000'),
( 2, 6, 'Limpieza', '2025-05-25 00:00:00.000', 'Pendiente', 'Admin', '2025-05-29 00:00:00.000'),
( 3, 7, 'Observacion', '2025-05-22 00:00:00.000', 'Progreso', 'Admin', '2025-05-28 00:00:00.000'),
( 4, 8, 'Alimentacion', '2025-05-23 00:00:00.000', 'Completa', 'Admin', '2025-05-28 00:00:00.000'),
( 5, 9, 'Preparacion', '2025-05-28 00:00:00.000', 'Cancelada', 'Admin', '2025-05-29 00:00:00.000'),
( 6, 10, 'Limpieza', '2025-09-24 00:00:00.000', 'Pendiente', 'Admin', '2025-05-29 00:00:00.000'),
( 7, 11, 'Observacion', '2025-05-28 00:00:00.000', 'Progreso', 'Admin', '2025-05-29 00:00:00.000'),
( 8, 12, 'Alimentacion', '2025-05-27 00:00:00.000', 'Completa', 'Admin', '2025-05-29 00:00:00.000'),
( 9, 13, 'Preparacion', '2025-05-28 00:00:00.000', 'Cancelada', 'Admin', '2025-05-29 00:00:00.000'),
(10, 14, 'Limpieza', '2025-05-23 00:00:00.000', 'Progreso', 'Admin', '2025-05-29 00:00:00.000');

INSERT INTO tbl_Citas ( CodigoEmpleado, FechaIngreso, FechaEgreso, CostoTratamiento, CostoHabitacion, UsuarioAuditoria, FechaAuditoria) VALUES
(  1, '2025-05-23 00:00:00.000', '2025-05-24 00:00:00.000', 500.00, 300.00, 'Admin', '2025-05-29 00:00:00.000'),
(  2, '2025-05-25 00:00:00.000', '2025-05-25 00:00:00.000', 500.00, 1000.00, 'Admin', '2025-05-29 00:00:00.000'),
( 3, '2025-05-22 00:00:00.000', '2025-05-22 00:00:00.000', 500.00, 500.00, 'Admin', '2025-05-28 00:00:00.000'),
(  4, '2025-05-26 00:00:00.000', '2025-05-26 00:00:00.000', 500.00, 100.00, 'Admin', '2025-05-29 00:00:00.000'),
(  5, '2025-05-21 00:00:00.000', '2025-05-21 00:00:00.000', 500.00, 300.00, 'Admin', '2025-05-29 00:00:00.000'),
(  6, '2025-05-27 00:00:00.000', '2025-05-27 00:00:00.000', 500.00, 100.00, 'Admin', '2025-05-29 00:00:00.000'),
(  7, '2025-05-22 00:00:00.000', '2025-05-22 00:00:00.000', 500.00, 300.00, 'Admin', '2025-05-29 00:00:00.000'),
(  8, '2025-05-29 00:00:00.000', '2025-05-29 00:00:00.000', 500.00, 300.00, 'Admin', '2025-05-29 00:00:00.000'),
(  9, '2025-05-20 00:00:00.000', '2025-05-20 00:00:00.000', 500.00, 100.00, 'Admin', '2025-05-29 00:00:00.000'),
(  10, '2025-05-20 00:00:00.000', '2025-05-20 00:00:00.000', 5000.00, 100.00, 'Admin', '2025-05-29 00:00:00.000');
INSERT INTO tbl_PagoCitas(  MontoCita, Impuesto, Descuento, TotalPago, FechaPago, TipoPago, UsuarioAuditoria, FechaAuditoria) VALUES
(  300.00, 36.00, 9.00, 327.00, '2025-05-29 00:00:00.000', 'Efectivo', 'Admin', '2025-05-29 00:00:00.000'),
(  450.00, 54.00, 13.50, 490.50, '2025-05-29 00:00:00.000', 'Tarjeta', 'Admin', '2025-05-29 00:00:00.000'),
(  1300.00, 156.00, 65.00, 1391.00, '2025-05-29 00:00:00.000', 'Transferencia', 'Admin', '2025-05-29 00:00:00.000'),
(  1800.00, 216.00, 90.00, 1926.00, '2025-05-29 00:00:00.000', 'Efectivo', 'Admin', '2025-05-29 00:00:00.000'),
(  4500.00, 540.00, 225.00, 4815.00, '2025-05-29 00:00:00.000', 'Tarjeta', 'Admin', '2025-05-29 00:00:00.000'),
( 200.00, 24.00, 6.00, 218.00, '2025-05-29 00:00:00.000', 'Transferencia', 'Admin', '2025-05-29 00:00:00.000'),
( 490.00, 58.80, 14.70, 534.10, '2025-05-29 00:00:00.000', 'Transferencia', 'Admin', '2025-05-29 00:00:00.000'),
( 350.00, 42.00, 10.50, 381.00, '2025-05-29 00:00:00.000', 'Tarjeta', 'Admin', '2025-05-29 00:00:00.000'),
( 4500.00, 540.00, 225.00, 4815.00, '2025-05-29 00:00:00.000', 'Efectivo', 'Admin', '2025-05-29 00:00:00.000'),
( 8000.00, 960.00, 560.00, 8400.00, '2025-05-29 00:00:00.000', 'Efectivo', 'Admin', '2025-05-29 00:00:00.000');
INSERT INTO tbl_PagoEmpleados( CodigoEmpleado, FechaPago, Sueldo, Bono, MontoHorasE, TotalMonto, Estado, UsuarioAuditoria, FechaAuditoria) VALUES
( 1, '2025-05-29 00:00:00.000', 3000.00, 3600.00, 10.00, 33600.00, 'Pendiente', 'Admin', '2025-05-29 00:00:00.000'),
( 2, '2025-05-29 00:00:00.000', 2000.00, 2400.00, 12.00, 22440.00, 'Proceso', 'Admin', '2025-05-29 00:00:00.000'),
( 3, '2025-05-29 00:00:00.000', 1000.00, 1200.00, 15.00, 13300.00, 'Pagado', 'Admin', '2025-05-29 00:00:00.000'),
( 4, '2025-05-29 00:00:00.000', 800.00, 840.00, 20.00, 11240.00, 'Rechazado', 'Admin', '2025-05-29 00:00:00.000'),
( 5, '2025-05-29 00:00:00.000', 600.00, 720.00, 8.00, 6890.00, 'Proceso', 'Admin', '2025-05-29 00:00:00.000'),
( 6, '2025-05-29 00:00:00.000', 2000.00, 2400.00, 10.00, 22400.00, 'Pagado', 'Admin', '2025-05-29 00:00:00.000'),
( 7, '2025-05-29 00:00:00.000', 10000.00, 1200.00, 14.00, 12180.00, 'Pendiente', 'Admin', '2025-05-29 00:00:00.000'),
( 8, '2025-05-29 00:00:00.000', 9000.00, 1080.00, 12.00, 11160.00, 'Pagado', 'Admin', '2025-05-29 00:00:00.000'),
( 9, '2025-05-29 00:00:00.000', 7000.00, 840.00, 5.00, 6820.00, 'Rechazado', 'Admin', '2025-05-29 00:00:00.000'),
( 10, '2025-05-29 00:00:00.000', 30000.00, 3600.00, 11.00, 33620.00, 'Pendiente', 'Admin', '2025-05-29 00:00:00.000');



INSERT INTO tbl_Usuarios (CodigoEmpleado, Usuario, Clave, TipoUsuario, Estado, UsuarioAuditoria, FechaAuditoria) VALUES
( 1, 'Maria Paz', NULL, 'Doctor', 'Activo', 'Admin', '2025-05-27 00:00:00.000'),
( 2, 'Adnan Torres', NULL, 'Administrador', 'Activo', 'Admin', '2025-05-27 00:00:00.000'),
( 3, 'Valentina Marquez', NULL, 'Asistente', 'Activo', 'Admin', '2025-05-27 00:00:00.000'),
( 4, 'Leonardo Castillo', NULL, 'Digitador', 'Activo', 'Admin', '2025-05-27 00:00:00.000'),
( 5, 'Camila Rios', NULL, 'Doctor', 'Activo', 'Admin', '2025-05-27 00:00:00.000'),
( 6, 'Mateo Fernandez', NULL, 'Director', 'Activo', 'Admin', '2025-05-27 00:00:00.000'),
( 7, 'Santiago Molina', NULL, 'Técnico', 'Activo', 'Admin', '2025-05-27 00:00:00.000'),
( 8, 'Emilia Navarro', NULL, 'Asistente', 'Activo', 'Admin', '2025-05-27 00:00:00.000'),
( 9, 'Nicolas Herrera', NULL, 'Digitador', 'Activo', 'Admin', '2025-05-27 00:00:00.000'),
( 10, 'Luna Salazar', NULL, 'Administrador', 'Activo', 'Admin', '2025-05-27 00:00:00.000');

INSERT INTO tbl_Medicamentos ( Nombre, Costo, Stock, FechaVencimiento, Estado, UsuarioAuditoria, FechaAuditoria) VALUES
( 'Desconocido', 75.00, 10, '2030-12-30', 'Disponible', 'Admin', '2025-05-29'),
( 'Desconocido', 90.00, 0, '2030-12-30', 'Vencido', 'Admin', '2025-05-29'),
( 'Desconocido', 75.00, 0, '2030-12-30', 'Agotado', 'Admin', '2025-05-29'),
( 'Delilin Tableta', 25.00, 0, '2030-12-30', 'Retirado', 'Admin', '2025-05-29'),
( 'Diego Inyección', 425.00, 20, '2030-12-30', 'Disponible', 'Admin', '2025-05-29'),
( 'Alma Suero', 25.00, 20, '2030-12-30', 'Disponible', 'Admin', '2025-05-29'),
( 'Si Jarabe', 150.00, 15, '2030-12-30', 'Disponible', 'Admin', '2025-05-29'),
( 'Maricarmen Crema', 75.00, 9, '2030-12-30', 'Disponible', 'Admin', '2025-05-29'),
( 'Inyeccion', 125.00, 9, '2030-12-30', 'Disponible', 'Admin', '2025-05-29'),
( 'Tableta', 25.00, 0, '2030-12-30', 'Retirado', 'Admin', '2025-05-29');

INSERT INTO tbl_Tratamientos (  CodigoMedicamento, Costo, FechaTratamiento, Estado, UsuarioAuditoria, FechaAuditoria) VALUES
(  1, 150.00, '2025-05-29', 'Pendiente', 'Admin', '2025-05-29'),
(  5, 5.00, '2025-05-29', 'Progreso', 'Admin', '2025-05-29'),
(  5, 5.00, '2025-05-29', 'Completado', 'Admin', '2025-05-29'),
(  4, 25.00, '2025-05-29', 'Suspendido', 'Admin', '2025-05-29'),
(  5, 0.00, '2025-05-29', 'Cancelado', 'Admin', '2025-05-29'),
(  6, 5.00, '2025-05-29', 'Progreso', 'Admin', '2025-05-29'),
(  7, 10.00, '2025-05-29', 'Cancelado', 'Admin', '2025-05-29'),
(  8, 20.00, '2025-05-29', 'Pendiente', 'Admin', '2025-05-29'),
(  9, 125.00, '2025-05-29', 'Completado', 'Admin', '2025-05-29'),
( 10, 5.00, '2025-05-29', 'Cancelado', 'Admin', '2025-05-29');


