-- Script para crear tabla de Asignación Maestro-Materia
-- Tabla que relaciona maestros con materias, grupos, salones y fechas

CREATE TABLE TBL_Asignacion_Maestro_Materia
(
	id_asignacion INT PRIMARY KEY IDENTITY(1,1),
	num_empleado INT NOT NULL,
	id_materia INT NOT NULL,
	grupo VARCHAR(10) NOT NULL,
	salon VARCHAR(20) NOT NULL,
	fecha_asig DATE NOT NULL,
	fecha_fin DATE NULL,
	fecha_movimiento DATETIME DEFAULT GETDATE(),
	estado VARCHAR(10) DEFAULT 'activo' CHECK (estado IN ('activo', 'inactivo')),

	-- Claves foráneas
	CONSTRAINT FK_Asignacion_Maestro FOREIGN KEY (num_empleado) 
		REFERENCES TBL_Registro_Maestros(num_Empleado),
	CONSTRAINT FK_Asignacion_Materia FOREIGN KEY (id_materia) 
		REFERENCES tbl_Materias(Id_Materia),

	-- Índices para mejor rendimiento en búsquedas
	INDEX idx_num_empleado (num_empleado),
	INDEX idx_id_materia (id_materia),
	INDEX idx_estado (estado)
);

-- Script para crear un índice compuesto
CREATE INDEX idx_asignacion_maestro_materia ON TBL_Asignacion_Maestro_Materia(num_empleado, id_materia);

-- Comentarios descriptivos
EXEC sp_addextendedproperty 
	@name = N'MS_Description', 
	@value = N'Tabla de asignación de maestros a materias' , 
	@level0type = N'SCHEMA', 
	@level0name = 'dbo',
	@level1type = N'TABLE', 
	@level1name = 'TBL_Asignacion_Maestro_Materia';

EXEC sp_addextendedproperty 
	@name = N'MS_Description', 
	@value = N'Identificador único de la asignación' , 
	@level0type = N'SCHEMA', 
	@level0name = 'dbo',
	@level1type = N'TABLE', 
	@level1name = 'TBL_Asignacion_Maestro_Materia',
	@level2type = N'COLUMN',
	@level2name = 'id_asignacion';

EXEC sp_addextendedproperty 
	@name = N'MS_Description', 
	@value = N'Número de empleado del maestro' , 
	@level0type = N'SCHEMA', 
	@level0name = 'dbo',
	@level1type = N'TABLE', 
	@level1name = 'TBL_Asignacion_Maestro_Materia',
	@level2type = N'COLUMN',
	@level2name = 'num_empleado';

EXEC sp_addextendedproperty 
	@name = N'MS_Description', 
	@value = N'Identificador de la materia' , 
	@level0type = N'SCHEMA', 
	@level0name = 'dbo',
	@level1type = N'TABLE', 
	@level1name = 'TBL_Asignacion_Maestro_Materia',
	@level2type = N'COLUMN',
	@level2name = 'id_materia';

EXEC sp_addextendedproperty 
	@name = N'MS_Description', 
	@value = N'Grupo o sección del curso' , 
	@level0type = N'SCHEMA', 
	@level0name = 'dbo',
	@level1type = N'TABLE', 
	@level1name = 'TBL_Asignacion_Maestro_Materia',
	@level2type = N'COLUMN',
	@level2name = 'grupo';

EXEC sp_addextendedproperty 
	@name = N'MS_Description', 
	@value = N'Salón o aula donde se imparte la materia' , 
	@level0type = N'SCHEMA', 
	@level0name = 'dbo',
	@level1type = N'TABLE', 
	@level1name = 'TBL_Asignacion_Maestro_Materia',
	@level2type = N'COLUMN',
	@level2name = 'salon';

EXEC sp_addextendedproperty 
	@name = N'MS_Description', 
	@value = N'Fecha de asignación inicial' , 
	@level0type = N'SCHEMA', 
	@level0name = 'dbo',
	@level1type = N'TABLE', 
	@level1name = 'TBL_Asignacion_Maestro_Materia',
	@level2type = N'COLUMN',
	@level2name = 'fecha_asig';

EXEC sp_addextendedproperty 
	@name = N'MS_Description', 
	@value = N'Fecha de finalización de la asignación' , 
	@level0type = N'SCHEMA', 
	@level0name = 'dbo',
	@level1type = N'TABLE', 
	@level1name = 'TBL_Asignacion_Maestro_Materia',
	@level2type = N'COLUMN',
	@level2name = 'fecha_fin';

EXEC sp_addextendedproperty 
	@name = N'MS_Description', 
	@value = N'Fecha de último movimiento o modificación' , 
	@level0type = N'SCHEMA', 
	@level0name = 'dbo',
	@level1type = N'TABLE', 
	@level1name = 'TBL_Asignacion_Maestro_Materia',
	@level2type = N'COLUMN',
	@level2name = 'fecha_movimiento';

EXEC sp_addextendedproperty 
	@name = N'MS_Description', 
	@value = N'Estado de la asignación: activo o inactivo' , 
	@level0type = N'SCHEMA', 
	@level0name = 'dbo',
	@level1type = N'TABLE', 
	@level1name = 'TBL_Asignacion_Maestro_Materia',
	@level2type = N'COLUMN',
	@level2name = 'estado';
