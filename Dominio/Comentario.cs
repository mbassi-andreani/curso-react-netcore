using System;

namespace Dominio
{
    public class Comentario
    {
        /*
        CREATE TABLE Comentario (
ComentarioId int NOT NULL PRIMARY KEY,
Alumno varchar(100),
Puntaje int,
ComentarioTexto varchar(max),
CursoId int FOREIGN KEY REFERENCES Curso(CursoId)
);
        */
        public Guid ComentarioId {get; set;}
        public string Alumno {get; set;}
        public int Puntaje {get; set;}
        public string ComentarioTexto {get; set;}
        public Guid CursoId {get; set;}
        public Curso Curso {get; set;}
    }
}