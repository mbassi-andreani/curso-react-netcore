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

--Datos de prueba
--Curso
DECLARE @cursoId1 uniqueidentifier;  
set @cursoId1 = newid();
DECLARE @cursoId2 uniqueidentifier;  
set @cursoId2 = newid();
DECLARE @cursoId3 uniqueidentifier;  
set @cursoId3 = newid();
INSERT [dbo].[Curso] ([CursoId], [Titulo], [Descripcion], [FechaPublicacion], [FotoPortada]) VALUES (@cursoId1, N'Reak Hooks', N'Curso de Programacion de Reak Hooks', CAST(N'2020-10-28T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Curso] ([CursoId], [Titulo], [Descripcion], [FechaPublicacion], [FotoPortada]) VALUES (@cursoId2, N'ASP.NET Core y Reak Hooks', N'Curso de .NET y JS', CAST(N'2020-10-28T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Curso] ([CursoId], [Titulo], [Descripcion], [FechaPublicacion], [FotoPortada]) VALUES (@cursoId3, N'Nuevo Curso', N'El nuevo curso que se agrega a mis cursos', CAST(N'2020-10-29T00:00:00.000' AS DateTime), NULL)
--Precio
INSERT [dbo].[Precio] ([PrecioId], [PrecioActual], [Promocion], [CursoId]) VALUES (newid(), 900.0000, 9.0000, @cursoId1)
INSERT [dbo].[Precio] ([PrecioId], [PrecioActual], [Promocion], [CursoId]) VALUES (newid(), 650.0000, 15.0000, @cursoId2)
--Comentario
INSERT [dbo].[Comentario] ([ComentarioId], [Alumno], [Puntaje], [ComentarioTexto], [CursoId]) VALUES (1, N'Pepito', 5, N'Es el mejor curso de React', @cursoId1)
INSERT [dbo].[Comentario] ([ComentarioId], [Alumno], [Puntaje], [ComentarioTexto], [CursoId]) VALUES (2, N'Juancito', 1, N'No me gustó para nada', @cursoId1)
INSERT [dbo].[Comentario] ([ComentarioId], [Alumno], [Puntaje], [ComentarioTexto], [CursoId]) VALUES (3, N'Cancela', 4, N'Ta bueeeno, pero no tanto', @cursoId1)
INSERT [dbo].[Comentario] ([ComentarioId], [Alumno], [Puntaje], [ComentarioTexto], [CursoId]) VALUES (4, N'Fabian', 5, N'Bueeenooo', @cursoId2)
INSERT [dbo].[Comentario] ([ComentarioId], [Alumno], [Puntaje], [ComentarioTexto], [CursoId]) VALUES (5, N'Raul', 5, N'Maravillosooo', @cursoId2)

