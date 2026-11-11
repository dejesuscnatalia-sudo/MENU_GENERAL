# Guía de Implementación: Tabla de Asignación Maestro-Materia

## Resumen de lo creado

Se han desarrollado todos los componentes necesarios para gestionar la asignación de maestros a materias:

### 1. **Base de Datos**
📄 **Archivo**: `MENU GENERAL/SQL/Script_Asignacion_Maestro_Materia.sql`

Este script crea la tabla `TBL_Asignacion_Maestro_Materia` con los siguientes campos:
- `id_asignacion` (PK, auto-incremento)
- `num_empleado` (FK → TBL_Registro_Maestros)
- `id_materia` (FK → tbl_Materias)
- `grupo` - Código del grupo o sección
- `salon` - Número o identificador del salón
- `fecha_asig` - Fecha de asignación inicial
- `fecha_fin` - Fecha de finalización (opcional)
- `fecha_movimiento` - Fecha de último movimiento (actualización automática)
- `estado` - 'activo' o 'inactivo'

**Instrucciones de instalación:**
1. Abre SQL Server Management Studio
2. Conecta a la base de datos `BD_ESCOLAR`
3. Abre el archivo Script_Asignacion_Maestro_Materia.sql
4. Ejecuta el script completo (los SP de comentarios son opcionales)

### 2. **Clase de Datos**
📄 **Archivo**: `MENU GENERAL/CLASES/clAsignacionMaestroMateria.cs`

Clase que encapsula la lógica de acceso a datos para la tabla:

**Métodos principales:**
- `Guardar()` - Inserta una nueva asignación
- `Modificar()` - Actualiza una asignación existente
- `Buscar()` - Busca por ID de asignación
- `BuscarPorMaestro()` - Obtiene todas las asignaciones de un maestro
- `BuscarPorMateria()` - Obtiene todos los maestros asignados a una materia
- `BuscarActivas()` - Lista todas las asignaciones activas
- `Eliminar()` - Elimina una asignación
- `CambiarEstado()` - Cambia el estado (activo/inactivo)

**Propiedades (Pascal Case):**
- `Id_Asignacion`, `Num_Empleado`, `Id_Materia`, `Grupo`, `Salon`
- `Fecha_Asig`, `Fecha_Fin`, `Fecha_Movimiento`, `Estado`

### 3. **Formulario de Interfaz**
📄 **Archivos**:
- `MENU GENERAL/ESCOLAR/FRMAsignacionMaestroMateria.cs`
- `MENU GENERAL/ESCOLAR/FRMAsignacionMaestroMateria.Designer.cs`
- `MENU GENERAL/ESCOLAR/FRMAsignacionMaestroMateria.resx`

Formulario con interfaz idéntica a FRMMAESTROS que permite:

**Controles:**
- 📱 Campos de texto: ID Asignación, Grupo, Salón
- 📋 Combo boxes: Maestro, Materia, Estado (activo/inactivo)
- 📅 Date pickers: Fecha de Asignación, Fecha de Fin (con checkbox opcional)

**Funcionalidades CRUD:**
- **Crear/Guardar**: Ingresa datos nuevos en los campos y presiona Guardar
- **Leer/Buscar**: Ingresa el ID de asignación, se cargan los datos automáticamente
- **Actualizar/Modificar**: Busca el registro y modifica los campos, luego Guardar
- **Eliminar**: Busca el registro y presiona Eliminar

**Validaciones:**
- Maestro y Materia son obligatorios (combos)
- Grupo y Salón no pueden estar vacíos
- Fecha de asignación no puede ser futura
- Fecha fin debe ser posterior a fecha de asignación (si se especifica)
- Estado debe seleccionar 'activo' o 'inactivo'

**Menú y Toolbar:**
- **Menú Operaciones**: Registrar, Consultar, Eliminar
- **Botones Toolbar**: Guardar, Registrar/Consultar, Eliminar
- **Menú Salir**: Cierra la ventana

## Pasos para usar en tu aplicación

### Paso 1: Ejecutar el Script SQL
```sql
-- Paste el contenido del archivo Script_Asignacion_Maestro_Materia.sql
-- en SQL Server Management Studio y ejecutar
```

### Paso 2: Agregar el Formulario al Menú Principal
En tu Form1 o menú principal, agrega una opción para abrir el formulario:

```csharp
// En tu menú o botón:
FRMAsignacionMaestroMateria frm = new FRMAsignacionMaestroMateria();
frm.ShowDialog();
```

### Paso 3: Vincular con otros módulos
El formulario carga automáticamente los maestros y materias de sus respectivas tablas:
- Combos se cargan al abrir el formulario
- Validaciones integradas

## Características Especiales

✅ **Reutilización de patrones**: Sigue el mismo patrón de FRMMAESTROS
✅ **Relaciones FK**: Mantiene integridad referencial con maestros y materias
✅ **Estados**: Permite marcar asignaciones como activas/inactivas
✅ **Fechas opcionales**: La fecha de fin es opcional (para asignaciones indefinidas)
✅ **Auditoría**: Incluye fecha_movimiento para tracking de cambios
✅ **Búsquedas avanzadas**: Métodos para buscar por maestro, materia o listar activos

## Nota Importante
La clase usa `Global.Esc()` y `Global.Proteger()` del proyecto para:
- Escapar caracteres especiales en SQL
- Manejo centralizado de excepciones

Asegúrate que la clase `Global` esté disponible en tu proyecto.

---
**Creado**: 2024
**Patrón**: ADO.NET con WinForms
**Framework**: .NET Framework 4.7.2
