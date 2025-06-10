# 💊 Farma-Di

**Farma-Di** es un sistema de escritorio diseñado para pequeñas farmacias que buscan optimizar sus operaciones diarias. Con Farma-Di podrás:

- 📦 Gestionar tu inventario en tiempo real  
- ⏰ Recibir alertas automáticas de caducidad  
- 💰 Registrar ventas y generar facturas al instante  
- 📊 Obtener reportes gráficos de ventas, stock y tendencias  
- ⚙️ Simplificar la toma de decisiones con datos fiables  
- 📤 Exportar el inventario a Excel (nuevo)

---

## 🚀 Tecnologías empleadas

| Capa                | Tecnología / Herramienta             | Uso principal                                    |
|---------------------|--------------------------------------|--------------------------------------------------|
| 🖥️ Cliente         | C# (.NET Framework) – Windows Forms  | Interfaz de usuario de escritorio                |
| 🗄️ Base de datos    | Microsoft SQL Server                | Almacenamiento de datos relacional (inventario, ventas, usuarios) |
| 🛠️ Desarrollo       | Visual Studio                       | Entorno de desarrollo integrado                   |

---

## 🎯 Objetivos del proyecto

1. **Optimizar el control de inventario**  
   - Registro y consulta instantánea de stock  
   - Alertas de bajo stock y caducidad  

2. **Agilizar el proceso de venta y facturación**  
   - Búsqueda rápida de productos  
   - Cálculo automático de totales, descuentos e impuestos  

3. **Facilitar la toma de decisiones**  
   - Reportes diarios, semanales y mensuales  
   - Análisis de productos más vendidos  

---

## 📝 Instrucciones de instalación y uso

### 1. **Requisitos previos**
- Windows 10 o superior
- .NET Framework 4.7.2 o superior
- Microsoft SQL Server (Express o superior)
- Visual Studio 2019 o superior

### 2. **Configuración de la base de datos**
- Crea una base de datos llamada `FarmaciaGenesis` en SQL Server.
- Restaura el respaldo o ejecuta los scripts de tablas y datos iniciales (consulta a tu profesor o revisa la carpeta `DATOS`).
- Verifica y ajusta la cadena de conexión en `DATOS/Conexion.cs` según tu instancia de SQL Server.

### 3. **Ejecución del sistema**
- Abre la solución `CONTROL_FARMACIA.sln` en Visual Studio.
- Compila la solución (Ctrl+Shift+B).
- Ejecuta el proyecto (F5 o botón de play).
- Inicia sesión con un usuario registrado en la base de datos.

### 4. **Funcionalidades principales**
- **Inventario:** Agrega, edita, elimina y busca productos.
- **Proveedores:** Gestión completa de proveedores.
- **Caducidad:** Consulta productos próximos a vencer.
- **Ventas:** Registra ventas y genera facturas.
- **Exportar a Excel:** Desde el formulario de productos, haz clic en "Exportar a Excel" para guardar el inventario en formato CSV compatible con Excel.

### 5. **Notas**
- Si tienes errores de conexión, revisa la cadena de conexión y que SQL Server esté activo.
- Si necesitas usuarios de prueba, agrégalos directamente en la base de datos.

---

## 📞 Soporte
Para dudas o problemas, contacta a tu profesor o revisa la documentación interna del código.

## ✅ Pruebas manuales sugeridas

Sigue estos pasos para comprobar que el sistema funciona correctamente:

1. **Iniciar sesión**
   - Ingresa con un usuario válido. Si no tienes uno, agrégalo en la base de datos.

2. **Agregar producto**
   - Ve a la sección de productos.
   - Llena todos los campos obligatorios y haz clic en "Agregar".
   - Verifica que el producto aparezca en la lista.

3. **Editar producto**
   - Selecciona un producto de la lista.
   - Modifica algún dato y haz clic en "Actualizar".
   - Verifica que los cambios se reflejen.

4. **Eliminar producto**
   - Selecciona un producto y haz clic en "Eliminar".
   - Confirma que desaparece de la lista.

5. **Buscar producto**
   - Usa la barra de búsqueda por nombre o filtra por categoría.
   - Verifica que los resultados sean correctos.

6. **Exportar a Excel**
   - Haz clic en "Exportar a Excel" en la pantalla de productos.
   - Abre el archivo generado y revisa que los datos sean correctos.

7. **Gestión de proveedores**
   - Agrega, edita y elimina proveedores desde su sección.

8. **Ver productos próximos a caducar**
   - Entra a la sección de caducidad y revisa la lista.

9. **Cerrar sesión y salir**
   - Usa el botón de salir para cerrar el sistema de forma segura.

---


