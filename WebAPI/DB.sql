CREATE TABLE Curso (
CursoId int IDENTITY(1,1) NOT NULL PRIMARY KEY,
Titulo nvarchar(500),
Descripcion nvarchar(1000),
FechaPublicacion datetime,
FotoPortada varbinary(MAX)
);

CREATE TABLE Precio (
PrecioId int IDENTITY(1,1) NOT NULL PRIMARY KEY,
PrecioActual money,
Promocion money,
CursoId int FOREIGN KEY REFERENCES Curso(CursoId)
);

CREATE TABLE Comentario (
ComentarioId int IDENTITY(1,1) NOT NULL PRIMARY KEY,
Alumno nvarchar(500),
Puntaje int,
ComentarioTexto nvarchar(max),
CursoId int FOREIGN KEY REFERENCES Curso(CursoId)
);

CREATE TABLE Instructor (
InstructorId int IDENTITY(1,1) NOT NULL PRIMARY KEY,
Nombre nvarchar(500),
Apellidos nvarchar(500),
Grado nvarchar(500),
FotoPerfil varbinary(MAX)
);

CREATE TABLE CursoInstructor (
CursoId int FOREIGN KEY REFERENCES Curso(CursoId),
InstructorId int FOREIGN KEY REFERENCES Instructor(InstructorId),
CONSTRAINT PK_CurIns PRIMARY KEY (CursoId,InstructorId)
);