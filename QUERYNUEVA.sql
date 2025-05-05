
-- Tabla: Usuarios
CREATE TABLE Usuarios (
    IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Apellido NVARCHAR(100),
    Clave NVARCHAR(50) NOT NULL, -- Asumiendo almacenamiento de hash
    Correo NVARCHAR(100) UNIQUE, -- Asumiendo correo único
    Cedula NVARCHAR(20) UNIQUE -- Asumiendo cédula única
);

-- Tabla: CategoriaFarmaco
CREATE TABLE CategoriaFarmaco (
    IdCategoria INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(MAX)
);

-- Tabla: Presentacion
CREATE TABLE Presentacion (
    IdPresentacion INT IDENTITY(1,1) PRIMARY KEY,
    Descripcion NVARCHAR(255) NOT NULL,
    UnidadMedida NVARCHAR(50),
    CantidadUnidadMedida DECIMAL(10, 2) -- Revisa precisión/escala
);

-- Tabla: Concentracion
CREATE TABLE Concentracion (
    IdConcentracion INT IDENTITY(1,1) PRIMARY KEY,
    Volumen DECIMAL(10, 2), -- Revisa precisión/escala
    Porcentaje DECIMAL(5, 2) -- Revisa precisión/escala
);

-- Tabla: Lote
CREATE TABLE Lote (
    IdLote INT IDENTITY(1,1) PRIMARY KEY,
    NumeroLote VARCHAR(100) NOT NULL UNIQUE, -- Lote debería ser único
    FechaEntrega DATE
);

-- Tabla: Marca
CREATE TABLE Marca (
    IdMarca INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(MAX),
    PoliticaDevolucion NVARCHAR(MAX)
);

-- Tabla: Proveedor
CREATE TABLE Proveedor (
    IdProveedor INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(150) NOT NULL,
    Cedula NVARCHAR(20) UNIQUE, -- Asumiendo cédula/RUC único
    Correo NVARCHAR(100) UNIQUE, -- Asumiendo correo único
    IdMarca INT,
    FOREIGN KEY (IdMarca) REFERENCES Marca(IdMarca) ON DELETE SET NULL ON UPDATE CASCADE -- Referencia actualizada
);

-- Tabla: Producto (Anteriormente laboratorio_producto)
CREATE TABLE Producto (
    IdProducto INT IDENTITY(1,1) PRIMARY KEY,
    NombreComercial NVARCHAR(255) NOT NULL,
    NombreGenerico NVARCHAR(255),
    IdCategoria INT,
    PrecioVenta DECIMAL(12, 2) NOT NULL CONSTRAINT DF_Producto_PrecioVenta DEFAULT 0.00, -- Definir precisión/escala
    PrecioCompra DECIMAL(12, 2) CONSTRAINT DF_Producto_PrecioCompra DEFAULT 0.00, -- Definir precisión/escala
    IdPresentacion INT,
    IdConcentracion INT,
    IdProveedor INT,
    IdLote INT, -- Relación directa al lote puede ser una simplificación
    FOREIGN KEY (IdCategoria) REFERENCES CategoriaFarmaco(IdCategoria) ON DELETE SET NULL ON UPDATE CASCADE, -- Referencia actualizada
    FOREIGN KEY (IdPresentacion) REFERENCES Presentacion(IdPresentacion) ON DELETE SET NULL ON UPDATE CASCADE, -- Referencia actualizada
    FOREIGN KEY (IdConcentracion) REFERENCES Concentracion(IdConcentracion) ON DELETE SET NULL ON UPDATE CASCADE, -- Referencia actualizada
    FOREIGN KEY (IdProveedor) REFERENCES Proveedor(IdProveedor) ON DELETE SET NULL ON UPDATE CASCADE, -- Referencia actualizada
    FOREIGN KEY (IdLote) REFERENCES Lote(IdLote) ON DELETE SET NULL ON UPDATE CASCADE -- Referencia actualizada
);

-- Tabla: MovimientoInventario
CREATE TABLE MovimientoInventario (
    IdMovimiento INT IDENTITY(1,1) PRIMARY KEY,
    IdProducto INT NOT NULL,
    TipoMovimiento VARCHAR(50) NOT NULL, -- Ej: ENTRADA, SALIDA, AJUSTE, VENTA
    Cantidad DECIMAL(10, 2) NOT NULL, -- Revisa precisión/escala
    PrecioUnitario DECIMAL(12, 2), -- Revisa precisión/escala
    PrecioCaja DECIMAL(12,2), -- Campo extra visto en diagrama. Revisa precisión/escala
    Descripcion NVARCHAR(MAX),
    Fecha DATETIME2 CONSTRAINT DF_Movimiento_Fecha DEFAULT GETDATE(), -- Fecha/Hora del movimiento
    FOREIGN KEY (IdProducto) REFERENCES Producto(IdProducto) ON DELETE CASCADE ON UPDATE CASCADE -- Referencia actualizada
);

-- Tabla: Factura
CREATE TABLE Factura (
    IdFactura INT IDENTITY(1,1) PRIMARY KEY,
    IdUsuario INT, -- Usuario que emite la factura (empleado)
    Cliente NVARCHAR(255), -- Nombre del cliente
    Fecha DATETIME2 NOT NULL,
    Subtotal DECIMAL(15, 2) NOT NULL CONSTRAINT DF_Factura_Subtotal DEFAULT 0.00, -- Definir precisión/escala
    Descuento DECIMAL(15, 2) CONSTRAINT DF_Factura_Descuento DEFAULT 0.00, -- Definir precisión/escala
    Total DECIMAL(15, 2) NOT NULL CONSTRAINT DF_Factura_Total DEFAULT 0.00, -- Definir precisión/escala
    FOREIGN KEY (IdUsuario) REFERENCES Usuarios(IdUsuario) ON DELETE SET NULL ON UPDATE CASCADE -- Referencia actualizada
);

-- Tabla: DetalleFactura
CREATE TABLE DetalleFactura (
    IdDetalleFactura INT IDENTITY(1,1) PRIMARY KEY,
    IdProducto INT NOT NULL,
    Cantidad DECIMAL(10, 2) NOT NULL, -- Revisa precisión/escala
    TotalDetalle DECIMAL(15, 2) NOT NULL, -- Revisa precisión/escala
    IdFactura INT NOT NULL,
    FOREIGN KEY (IdProducto) REFERENCES Producto(IdProducto) ON DELETE NO ACTION ON UPDATE CASCADE, -- Referencia actualizada
    FOREIGN KEY (IdFactura) REFERENCES Factura(IdFactura) ON DELETE CASCADE ON UPDATE CASCADE -- Referencia actualizada
);

-- Tabla: Devolucion
CREATE TABLE Devolucion (
    IdDevolucion INT IDENTITY(1,1) PRIMARY KEY,
    TipoDevolucion VARCHAR(100) NOT NULL, -- Ej: Cliente, Proveedor
    Descripcion NVARCHAR(MAX) NOT NULL,
    IdFactura INT, -- Factura original (si aplica, para devolución de cliente)
    IdProducto INT NOT NULL, -- Producto devuelto
    Fecha DATETIME2 CONSTRAINT DF_Devolucion_Fecha DEFAULT GETDATE(), -- Fecha/Hora de la devolucion
    FOREIGN KEY (IdFactura) REFERENCES Factura(IdFactura) ON DELETE SET NULL ON UPDATE CASCADE, -- Referencia actualizada
    FOREIGN KEY (IdProducto) REFERENCES Producto(IdProducto) ON DELETE NO ACTION ON UPDATE CASCADE -- Referencia actualizada
);



