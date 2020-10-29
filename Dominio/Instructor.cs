using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Instructor
    {
        /*
        CREATE TABLE Instructor (
InstructorId int NOT NULL PRIMARY KEY,
Nombre varchar(30),
Apellidos varchar(100),
Grado varchar(30),
FotoPerfil varchar(max)
);
        */
        public Guid InstructorId {get; set;}
        public string Nombre {get; set;}
        public string Apellidos {get; set;}
        public string Grado {get; set;}
        public byte[] FotoPerfil {get; set;}
        public ICollection<CursoInstructor> CursoLink {get;set;}
    }
}