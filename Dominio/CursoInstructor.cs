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
        public int CursoId {get; set;}
        public Curso Curso {get;set;}
        public int InstructorId {get; set;}
        public Instructor Instructor {get;set;}
    }
}