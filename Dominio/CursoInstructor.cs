using System;

namespace Dominio
{
    public class CursoInstructor
    {
        /*
        CREATE TABLE CursoInstructor (
CursoId int FOREIGN KEY REFERENCES Curso(CursoId),
InstructorId int FOREIGN KEY REFERENCES Instructor(InstructorId),
CONSTRAINT PK_CurIns PRIMARY KEY (CursoId,InstructorId),
);
        */
        public Guid CursoId {get; set;}
        public Curso Curso {get;set;}
        public Guid InstructorId {get; set;}
        public Instructor Instructor {get;set;}
    }
}