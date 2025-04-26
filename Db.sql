CREATE DATABASE DocuGuard;
GO
USE DocuGuard;
GO

-- Tabla Usuarios
CREATE TABLE Usuarios (
    id_usuario INT IDENTITY PRIMARY KEY,
    nombre NVARCHAR(100) NOT NULL,
    apellido NVARCHAR(100) NOT NULL,
    correo NVARCHAR(100) NOT NULL UNIQUE,
    clave NVARCHAR(255) NOT NULL, -- aquí guardarás el hash
    rol NVARCHAR(50) NOT NULL
);

-- Tabla Documentos
CREATE TABLE Documentos (
    id_documento INT IDENTITY PRIMARY KEY,
    titulo NVARCHAR(150) NOT NULL,
    descripcion NVARCHAR(MAX),
    ruta_archivo NVARCHAR(255) NOT NULL,
    fecha_subida DATETIME NOT NULL DEFAULT GETDATE(),
    version INT NOT NULL DEFAULT 1,
    estado NVARCHAR(50) NOT NULL,
    id_usuario_subida INT NOT NULL,
    FOREIGN KEY (id_usuario_subida) REFERENCES Usuarios(id_usuario)
);

-- Tabla Permisos
CREATE TABLE Permisos (
    id_permiso INT IDENTITY PRIMARY KEY,
    id_documento INT NOT NULL,
    id_usuario INT NOT NULL,
    nivel_acceso NVARCHAR(50) NOT NULL, -- Ej: Lectura, Escritura, Eliminación
    FOREIGN KEY (id_documento) REFERENCES Documentos(id_documento),
    FOREIGN KEY (id_usuario) REFERENCES Usuarios(id_usuario)
);
